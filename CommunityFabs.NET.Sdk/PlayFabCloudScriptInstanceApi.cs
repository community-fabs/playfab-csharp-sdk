using CommunityFabs.NET.Sdk.Models.CloudScript;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabCloudScriptInstanceApi : PlayFabBaseInstanceApi, IPlayFabCloudScriptApi {
    public PlayFabCloudScriptInstanceApi() : base() { }
    public PlayFabCloudScriptInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabCloudScriptInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabCloudScriptInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<ExecuteCloudScriptResult> ExecuteEntityCloudScriptAsync(ExecuteEntityCloudScriptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteCloudScriptResult>("/CloudScript/ExecuteEntityCloudScript", request, extraHeaders);
    }
    public async Task<ExecuteFunctionResult> ExecuteFunctionAsync(ExecuteFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteFunctionResult>("/CloudScript/ExecuteFunction", request, extraHeaders);
    }
    public async Task<GetFunctionResult> GetFunctionAsync(GetFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFunctionResult>("/CloudScript/GetFunction", request, extraHeaders);
    }
    public async Task<ListEventHubFunctionsResult> ListEventHubFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListEventHubFunctionsResult>("/CloudScript/ListEventHubFunctions", request, extraHeaders);
    }
    public async Task<ListFunctionsResult> ListFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListFunctionsResult>("/CloudScript/ListFunctions", request, extraHeaders);
    }
    public async Task<ListHttpFunctionsResult> ListHttpFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListHttpFunctionsResult>("/CloudScript/ListHttpFunctions", request, extraHeaders);
    }
    public async Task<ListQueuedFunctionsResult> ListQueuedFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListQueuedFunctionsResult>("/CloudScript/ListQueuedFunctions", request, extraHeaders);
    }
    public async Task<EmptyResult> PostFunctionResultForEntityTriggeredActionAsync(PostFunctionResultForEntityTriggeredActionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/PostFunctionResultForEntityTriggeredAction", request, extraHeaders);
    }
    public async Task<EmptyResult> PostFunctionResultForFunctionExecutionAsync(PostFunctionResultForFunctionExecutionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/PostFunctionResultForFunctionExecution", request, extraHeaders);
    }
    public async Task<EmptyResult> PostFunctionResultForPlayerTriggeredActionAsync(PostFunctionResultForPlayerTriggeredActionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/PostFunctionResultForPlayerTriggeredAction", request, extraHeaders);
    }
    public async Task<EmptyResult> PostFunctionResultForScheduledTaskAsync(PostFunctionResultForScheduledTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/PostFunctionResultForScheduledTask", request, extraHeaders);
    }
    public async Task<EmptyResult> RegisterEventHubFunctionAsync(RegisterEventHubFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/RegisterEventHubFunction", request, extraHeaders);
    }
    public async Task<EmptyResult> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/RegisterHttpFunction", request, extraHeaders);
    }
    public async Task<EmptyResult> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/RegisterQueuedFunction", request, extraHeaders);
    }
    public async Task<EmptyResult> UnregisterFunctionAsync(UnregisterFunctionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/CloudScript/UnregisterFunction", request, extraHeaders);
    }
}