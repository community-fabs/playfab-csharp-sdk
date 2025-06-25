using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk.Http;

// TODO: throw exceptions for errors instead of returning multiple types
internal static class PlayFabHttpTransport
{
    static readonly HttpClient client = new();

    public static async Task<object> Post(string fullUrl, object request, Dictionary<string, string> extraHeaders)
    {
        string bodyString;

        if (request == null)
        {
            bodyString = "{}";
        }
        else
        {
            bodyString = JsonSerializer.Serialize(request);
        }

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
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", headerPair.Value);
                    }
                    else
                    {
                        postBody.Headers.Add(headerPair.Key, headerPair.Value);
                    }
                }
            }

            try
            {
                httpResponse = await client.PostAsync(fullUrl, postBody);
                httpResponseString = await httpResponse.Content.ReadAsStringAsync();
                hasReqId = httpResponse.Headers.TryGetValues("X-RequestId", out requestId);
            }
            catch (HttpRequestException e)
            {
                return new PlayFabError
                {
                    Error = PlayFabErrorCode.ConnectionError,
                    ErrorMessage = e.InnerException.Message
                };
            }
            catch (Exception e)
            {
                return new PlayFabError
                {
                    Error = PlayFabErrorCode.ConnectionError,
                    ErrorMessage = e.Message
                };
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
                return error;
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
                error.RequestId = GetRequestId(hasReqId, requestId); ;
                return error;
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

            error.RequestId = GetRequestId(hasReqId, requestId); ;

            return error;
        }

        if (string.IsNullOrEmpty(httpResponseString))
        {
            return new PlayFabError
            {
                Error = PlayFabErrorCode.Unknown,
                ErrorMessage = "Internal server error",
                RequestId = GetRequestId(hasReqId, requestId)
            };
        }

        return httpResponseString;
    }

    private static string GetRequestId(bool hasReqId, IEnumerable<string> reqIdContainer)
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