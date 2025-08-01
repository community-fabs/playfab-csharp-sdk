using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.CloudScript;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the CloudScript API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabCloudScriptInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabCloudScriptApi {

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

    /// <inheritdoc />
    public async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteEntityCloudScriptAsync(ExecuteEntityCloudScriptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteEntityCloudScript", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteCloudScriptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteFunctionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteFunctionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteFunctionResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetFunctionResult>> GetFunctionAsync(GetFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/GetFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFunctionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFunctionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFunctionResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListEventHubFunctionsResult>> ListEventHubFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListEventHubFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListEventHubFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListEventHubFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListEventHubFunctionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListFunctionsResult>> ListFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListFunctionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListHttpFunctionsResult>> ListHttpFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListHttpFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListHttpFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListHttpFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListHttpFunctionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListQueuedFunctionsResult>> ListQueuedFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListQueuedFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListQueuedFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQueuedFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListQueuedFunctionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForEntityTriggeredActionAsync(PostFunctionResultForEntityTriggeredActionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForEntityTriggeredAction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForFunctionExecutionAsync(PostFunctionResultForFunctionExecutionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForFunctionExecution", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForPlayerTriggeredActionAsync(PostFunctionResultForPlayerTriggeredActionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForPlayerTriggeredAction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForScheduledTaskAsync(PostFunctionResultForScheduledTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForScheduledTask", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> RegisterEventHubFunctionAsync(RegisterEventHubFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterEventHubFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterHttpFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterQueuedFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> UnregisterFunctionAsync(UnregisterFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/UnregisterFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

}