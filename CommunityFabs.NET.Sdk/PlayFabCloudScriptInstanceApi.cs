using CommunityFabs.NET.Sdk.Models.CloudScript;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
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

    public async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteEntityCloudScriptAsync(ExecuteEntityCloudScriptRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteEntityCloudScript", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ExecuteCloudScriptResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteCloudScriptResult>>((string)httpResult);
        return new PlayFabResult<ExecuteCloudScriptResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ExecuteFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ExecuteFunctionResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteFunctionResult>>((string)httpResult);
        return new PlayFabResult<ExecuteFunctionResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetFunctionResult>> GetFunctionAsync(GetFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/GetFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetFunctionResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFunctionResult>>((string)httpResult);
        return new PlayFabResult<GetFunctionResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListEventHubFunctionsResult>> ListEventHubFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListEventHubFunctions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListEventHubFunctionsResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListEventHubFunctionsResult>>((string)httpResult);
        return new PlayFabResult<ListEventHubFunctionsResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListFunctionsResult>> ListFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListFunctions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListFunctionsResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListFunctionsResult>>((string)httpResult);
        return new PlayFabResult<ListFunctionsResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListHttpFunctionsResult>> ListHttpFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListHttpFunctions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListHttpFunctionsResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListHttpFunctionsResult>>((string)httpResult);
        return new PlayFabResult<ListHttpFunctionsResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListQueuedFunctionsResult>> ListQueuedFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/ListQueuedFunctions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListQueuedFunctionsResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQueuedFunctionsResult>>((string)httpResult);
        return new PlayFabResult<ListQueuedFunctionsResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForEntityTriggeredActionAsync(PostFunctionResultForEntityTriggeredActionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForEntityTriggeredAction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForFunctionExecutionAsync(PostFunctionResultForFunctionExecutionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForFunctionExecution", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForPlayerTriggeredActionAsync(PostFunctionResultForPlayerTriggeredActionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForPlayerTriggeredAction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> PostFunctionResultForScheduledTaskAsync(PostFunctionResultForScheduledTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/PostFunctionResultForScheduledTask", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterEventHubFunctionAsync(RegisterEventHubFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterEventHubFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterHttpFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/RegisterQueuedFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResult>> UnregisterFunctionAsync(UnregisterFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/CloudScript/UnregisterFunction", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        return new PlayFabResult<EmptyResult> { Result = resultData.data };
    }
}