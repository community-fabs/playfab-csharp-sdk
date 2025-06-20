using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Utils;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabBaseInstanceApi
{
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;
    private static readonly HttpClient _client = HttpHelper.HttpClient;

    public PlayFabBaseInstanceApi() { }

    public PlayFabBaseInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabBaseInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabBaseInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
    {
        apiSettings = settings;
        authenticationContext = context;
    }

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsClientLoggedIn()
    {
        return authenticationContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetAllCredentials()
    {
        authenticationContext?.ForgetAllCredentials();
    }

    public async Task<T> PostData<T>(string fullUrl, object request, Dictionary<string, string>? extraHeaders) where T : PlayFabResultCommon
    {
        string bodyString = request == null ? "{}" :
            JsonSerializer.Serialize(request);

        HttpResponseMessage httpResponse;
        string httpResponseString;
        IEnumerable<string> requestId;
        bool hasReqId = false;
        using (var postBody = new ByteArrayContent(Encoding.UTF8.GetBytes(bodyString)))
        {
            postBody.Headers.Add("Content-Type", "application/json");
            postBody.Headers.Add("X-PlayFabSDK", Constants.SdkVersionString);
            if (extraHeaders != null)
            {
                foreach (var headerPair in extraHeaders)
                {
                    // Special case for Authorization header
                    if (headerPair.Key.Equals("Authorization", StringComparison.OrdinalIgnoreCase))
                    {
                        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", headerPair.Value);
                    }
                    else
                    {
                        postBody.Headers.Add(headerPair.Key, headerPair.Value);
                    }
                }
            }

            try
            {
                httpResponse = await _client.PostAsync(fullUrl, postBody);
                httpResponseString = await httpResponse.Content.ReadAsStringAsync();
                hasReqId = httpResponse.Headers.TryGetValues("X-RequestId", out requestId);
            }
            catch (HttpRequestException e)
            {
                throw new PlayFabErrorException(new PlayFabError
                {
                    Error = PlayFabErrorCode.ConnectionError,
                    ErrorMessage = e.InnerException?.Message ?? e.Message
                });
            }
            catch (Exception e)
            {
                throw new PlayFabErrorException(new PlayFabError
                {
                    Error = PlayFabErrorCode.ConnectionError,
                    ErrorMessage = e.Message
                });
            }
        }

        if (!httpResponse.IsSuccessStatusCode)
        {
            var error = new PlayFabError();

            if (string.IsNullOrEmpty(httpResponseString))
            {
                error.HttpCode = (int)httpResponse.StatusCode;
                error.HttpStatus = httpResponse.StatusCode.ToString();
                error.RequestId = GetRequestId(hasReqId, requestId);
                throw new PlayFabErrorException(error);
            }

            PlayFabJsonError errorResult;
            try
            {
                errorResult = JsonSerializer.Deserialize<PlayFabJsonError>(httpResponseString);
            }
            catch (Exception e)
            {
                error.HttpCode = (int)httpResponse.StatusCode;
                error.HttpStatus = httpResponse.StatusCode.ToString();
                error.Error = PlayFabErrorCode.JsonParseError;
                error.ErrorMessage = e.Message;
                error.RequestId = GetRequestId(hasReqId, requestId);
                throw new PlayFabErrorException(error);
            }

            error.HttpCode = errorResult.code;
            error.HttpStatus = errorResult.status;
            error.Error = (PlayFabErrorCode)errorResult.errorCode;
            error.ErrorMessage = errorResult.errorMessage;
            error.RetryAfterSeconds = errorResult.retryAfterSeconds;

            if (errorResult.errorDetails != null)
            {
                error.ErrorDetails = new Dictionary<string, string[]>();
                foreach (var detail in errorResult.errorDetails)
                {
                    error.ErrorDetails.Add(detail.Key, detail.Value);
                }
            }

            error.RequestId = GetRequestId(hasReqId, requestId);

            throw new PlayFabErrorException(error);
        }

        if (string.IsNullOrEmpty(httpResponseString))
        {
            throw new PlayFabErrorException(new PlayFabError
            {
                Error = PlayFabErrorCode.Unknown,
                ErrorMessage = "Internal server error",
                RequestId = GetRequestId(hasReqId, requestId)
            });
        }

        var successResponse = JsonSerializer.Deserialize<PlayFabJsonSuccess<T>>(httpResponseString);
        return successResponse.data;
    }

    private string GetRequestId(bool hasReqId, IEnumerable<string> reqIdContainer)
    {
        const string defaultReqId = "NoRequestIdFound";

        if (!hasReqId)
        {
            return defaultReqId;
        }

        try
        {
            string reqId = reqIdContainer.FirstOrDefault();
            if (string.IsNullOrEmpty(reqId))
            {
                reqId = defaultReqId;
            }

            return reqId;
        }
        catch (Exception e)
        {
            return "Failed to Enumerate RequestId. Exception message: " + e.Message;
        }
    }
}