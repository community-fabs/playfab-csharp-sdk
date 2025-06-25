using CommunityFabs.NET.Sdk.Models.CloudScript;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabCloudScriptApi {
    /// <summary>
    /// Cloud Script is one of PlayFab's most versatile features. It allows client code to request execution of any kind of
    /// custom server-side functionality you can implement, and it can be used in conjunction with virtually anything.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ExecuteEntityCloudScriptAsync({);
    ///   "FunctionName": "levelCompleted",
    ///   "FunctionParameter": {
    ///     "level": 3,
    ///     "points": 400
    ///   },
    ///   "RevisionSelection": "Live",
    ///   "GeneratePlayStreamEvent": true,
    ///   "Entity": {
    ///     "Id": "aaa",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/executeentitycloudscript">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteEntityCloudScriptAsync(ExecuteEntityCloudScriptRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Cloud Script is one of PlayFab's most versatile features. It allows client code to request execution of any kind of
    /// custom server-side functionality you can implement, and it can be used in conjunction with virtually anything.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ExecuteFunctionAsync({);
    ///   "FunctionName": "LevelCompleted",
    ///   "FunctionParameter": {
    ///     "level": 3,
    ///     "points": 400
    ///   },
    ///   "GeneratePlayStreamEvent": true,
    ///   "Entity": {
    ///     "Id": "aaa",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/executefunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets registered Azure Functions for a given title id and function name.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.GetFunctionAsync({);
    ///   "FunctionName": "LevelCompleted"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/getfunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetFunctionResult>> GetFunctionAsync(GetFunctionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all currently registered Event Hub triggered Azure Functions for a given title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ListEventHubFunctionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/listeventhubfunctions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListEventHubFunctionsResult>> ListEventHubFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all currently registered Azure Functions for a given title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ListFunctionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/listfunctions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListFunctionsResult>> ListFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all currently registered HTTP triggered Azure Functions for a given title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ListHttpFunctionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/listhttpfunctions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListHttpFunctionsResult>> ListHttpFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all currently registered Queue triggered Azure Functions for a given title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.ListQueuedFunctionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/listqueuedfunctions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListQueuedFunctionsResult>> ListQueuedFunctionsAsync(ListFunctionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Generate an entity PlayStream event for the provided function result.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.PostFunctionResultForEntityTriggeredActionAsync({);
    ///   "FunctionResult": {
    ///     "ExecutionTimeMilliseconds": 367,
    ///     "FunctionName": "LevelCompleted",
    ///     "FunctionResult": {
    ///       "newScore": 25,
    ///       "isWinner": false
    ///     }
    ///   },
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/postfunctionresultforentitytriggeredaction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> PostFunctionResultForEntityTriggeredActionAsync(PostFunctionResultForEntityTriggeredActionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Generate an entity PlayStream event for the provided function result.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.PostFunctionResultForFunctionExecutionAsync({);
    ///   "FunctionResult": {
    ///     "ExecutionTimeMilliseconds": 367,
    ///     "FunctionName": "LevelCompleted",
    ///     "FunctionResult": {
    ///       "newScore": 25,
    ///       "isWinner": false
    ///     }
    ///   },
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/postfunctionresultforfunctionexecution">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> PostFunctionResultForFunctionExecutionAsync(PostFunctionResultForFunctionExecutionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Generate a player PlayStream event for the provided function result.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.PostFunctionResultForPlayerTriggeredActionAsync({);
    ///   "PlayStreamEventEnvelope": {
    ///     "EntityId": "1234ABCD",
    ///     "EntityType": "title_player_account",
    ///     "EventName": "player_logged_in",
    ///     "EventNamespace": "com.playfab",
    ///     "EventData": "someeventdata",
    ///     "EventSettings": "someeventsettings",
    ///     "EventToBeDropped": false
    ///   },
    ///   "PlayerProfile": {
    ///     "TitleId": "FFFF",
    ///     "PlayerId": "1234ABCD",
    ///     "Created": "2019-02-11T20:23:05Z",
    ///     "LastLogin": "2020-02-11T20:23:05Z",
    ///     "DisplayName": "Gudge"
    ///   },
    ///   "FunctionResult": {
    ///     "ExecutionTimeMilliseconds": 367,
    ///     "FunctionName": "LevelCompleted",
    ///     "FunctionResult": {
    ///       "newScore": 25,
    ///       "isWinner": false
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/postfunctionresultforplayertriggeredaction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> PostFunctionResultForPlayerTriggeredActionAsync(PostFunctionResultForPlayerTriggeredActionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Generate a PlayStream event for the provided function result.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.PostFunctionResultForScheduledTaskAsync({);
    ///   "ScheduledTaskId": {
    ///     "Name": "MyTask",
    ///     "Id": "d739e188-22f6-4d13-a4d5-df2e93d4d2f7"
    ///   },
    ///   "FunctionResult": {
    ///     "ExecutionTimeMilliseconds": 367,
    ///     "FunctionName": "LevelCompleted",
    ///     "FunctionResult": {
    ///       "newScore": 25,
    ///       "isWinner": false
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/postfunctionresultforscheduledtask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> PostFunctionResultForScheduledTaskAsync(PostFunctionResultForScheduledTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Registers an event hub triggered Azure Function with a title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.RegisterEventHubFunctionAsync({);
    ///   "EventHubName": "fn-eventhub",
    ///   "ConnectionString": "SampleConnectionString",
    ///   "FunctionName": "functionName"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/registereventhubfunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> RegisterEventHubFunctionAsync(RegisterEventHubFunctionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Registers an HTTP triggered Azure function with a title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.RegisterHttpFunctionAsync({);
    ///   "FunctionUrl": "http://function.url",
    ///   "FunctionName": "functionName"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/registerhttpfunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Registers a queue triggered Azure Function with a title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.RegisterQueuedFunctionAsync({);
    ///   "QueueName": "fn-queue",
    ///   "ConnectionString": "SampleConnectionString",
    ///   "FunctionName": "functionName"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/registerqueuedfunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unregisters an Azure Function with a title.
    /// <example><br/>Example:<code>
    /// var response = await cloudscriptApi.UnregisterFunctionAsync({);
    ///   "FunctionName": "functionName"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/cloudscript/server-side-cloud-script/unregisterfunction">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> UnregisterFunctionAsync(UnregisterFunctionRequest request, Dictionary<string, string>? extraHeaders);
}