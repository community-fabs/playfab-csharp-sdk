using CommunityFabs.NET.Sdk.Common;
using CommunityFabs.NET.Sdk.Common.Http;
using CommunityFabs.NET.Sdk.Common.Interfaces;
using CommunityFabs.NET.Sdk.Common.Models;
using CommunityFabs.NET.Sdk.Common.Models.CloudScript;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabCloudScriptInstanceApi : IPlayFabCloudScriptApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabCloudScriptInstanceApi() { }

    public PlayFabCloudScriptInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabCloudScriptInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabCloudScriptInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
    {
        apiSettings = settings;
        authenticationContext = context;
    }

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authenticationContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authenticationContext?.ForgetAllCredentials();
    }

    public async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteEntityCloudScriptAsync(ExecuteEntityCloudScriptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteEntityCloudScript", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteCloudScriptResult> { Result = result };
    }
    public async Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteFunctionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteFunctionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteFunctionResult> { Result = result };
    }
    public async Task<PlayFabResult<GetFunctionResult>> GetFunctionAsync(GetFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/GetFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFunctionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFunctionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFunctionResult> { Result = result };
    }
    public async Task<PlayFabResult<ListEventHubFunctionsResult>> ListEventHubFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListEventHubFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListEventHubFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListEventHubFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListEventHubFunctionsResult> { Result = result };
    }
    public async Task<PlayFabResult<ListFunctionsResult>> ListFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListFunctionsResult> { Result = result };
    }
    public async Task<PlayFabResult<ListHttpFunctionsResult>> ListHttpFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListHttpFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListHttpFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListHttpFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListHttpFunctionsResult> { Result = result };
    }
    public async Task<PlayFabResult<ListQueuedFunctionsResult>> ListQueuedFunctionsAsync(ListFunctionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListQueuedFunctions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListQueuedFunctionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQueuedFunctionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListQueuedFunctionsResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForEntityTriggeredActionAsync(PostFunctionResultForEntityTriggeredActionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForEntityTriggeredAction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForFunctionExecutionAsync(PostFunctionResultForFunctionExecutionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForFunctionExecution", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForPlayerTriggeredActionAsync(PostFunctionResultForPlayerTriggeredActionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForPlayerTriggeredAction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForScheduledTaskAsync(PostFunctionResultForScheduledTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForScheduledTask", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterEventHubFunctionAsync(RegisterEventHubFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterEventHubFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterHttpFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterQueuedFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> UnregisterFunctionAsync(UnregisterFunctionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/CloudScript/UnregisterFunction", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
}