using CommunityFabs.NET.Sdk.Common;
using CommunityFabs.NET.Sdk.Common.Http;
using CommunityFabs.NET.Sdk.Common.Interfaces;
using CommunityFabs.NET.Sdk.Common.Models;
using CommunityFabs.NET.Sdk.Common.Models.Insights;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk.Instance;

/// <summary>
/// Create a new instance of the Sweepstakes API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabInsightsInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabInsightsApi {

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authContext?.ForgetAllCredentials();
    }

    public async Task<PlayFabResult<InsightsGetDetailsResponse>> GetDetailsAsync(InsightsEmptyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/GetDetails", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsGetDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsGetDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsGetDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<InsightsGetLimitsResponse>> GetLimitsAsync(InsightsEmptyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/GetLimits", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsGetLimitsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsGetLimitsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsGetLimitsResponse> { Result = result };
    }
    public async Task<PlayFabResult<InsightsGetOperationStatusResponse>> GetOperationStatusAsync(InsightsGetOperationStatusRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/GetOperationStatus", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsGetOperationStatusResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsGetOperationStatusResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsGetOperationStatusResponse> { Result = result };
    }
    public async Task<PlayFabResult<InsightsGetPendingOperationsResponse>> GetPendingOperationsAsync(InsightsGetPendingOperationsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/GetPendingOperations", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsGetPendingOperationsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsGetPendingOperationsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsGetPendingOperationsResponse> { Result = result };
    }
    public async Task<PlayFabResult<InsightsOperationResponse>> SetPerformanceAsync(InsightsSetPerformanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/SetPerformance", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsOperationResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsOperationResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsOperationResponse> { Result = result };
    }
    public async Task<PlayFabResult<InsightsOperationResponse>> SetStorageRetentionAsync(InsightsSetStorageRetentionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Insights/SetStorageRetention", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InsightsOperationResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InsightsOperationResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InsightsOperationResponse> { Result = result };
    }
}