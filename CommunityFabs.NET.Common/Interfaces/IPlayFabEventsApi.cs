using CommunityFabs.NET.Common.Models.Events;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabEventsApi {
    /// <summary>
    /// Creates a new telemetry key for the title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.CreateTelemetryKeyAsync({
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/createtelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTelemetryKeyResponse>> CreateTelemetryKeyAsync(CreateTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a Data Connection from a title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.DeleteDataConnectionAsync({
    ///   "Name": "MyDataConnection"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/deletedataconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteDataConnectionResponse>> DeleteDataConnectionAsync(DeleteDataConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the sampling ratio for an event.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/deleteeventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteEventSamplingRatioResult>> DeleteEventSamplingRatioAsync(DeleteEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a telemetry key configured for the title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.DeleteTelemetryKeyAsync({
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/deletetelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteTelemetryKeyResponse>> DeleteTelemetryKeyAsync(DeleteTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a single Data Connection associated with a title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.GetDataConnectionAsync({
    ///   "Name": "MyDataConnection"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/getdataconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetDataConnectionResponse>> GetDataConnectionAsync(GetDataConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the sampling ratio for an event.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.GetEventSamplingRatioAsync({
    ///   "EventNamespace": "com.playfab",
    ///   "EventName": "player_executed_cloudscript"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/geteventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEventSamplingRatioResult>> GetEventSamplingRatioAsync(GetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the event sampling ratios for a title.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/geteventsamplingratios">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEventSamplingRatiosResult>> GetEventSamplingRatiosAsync(GetEventSamplingRatiosRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information about a telemetry key configured for the title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.GetTelemetryKeyAsync({
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/gettelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTelemetryKeyResponse>> GetTelemetryKeyAsync(GetTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the list of Data Connections associated with a title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.ListDataConnectionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/listdataconnections">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListDataConnectionsResponse>> ListDataConnectionsAsync(ListDataConnectionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all telemetry keys configured for the title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.ListTelemetryKeysAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/listtelemetrykeys">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListTelemetryKeysResponse>> ListTelemetryKeysAsync(ListTelemetryKeysRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates or updates a Data Connection on a title.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.SetDataConnectionAsync({
    ///   "Name": "MyDataConnection",
    ///   "Type": "AzureDataExplorer",
    ///   "IsActive": true,
    ///   "ConnectionSettings": {
    ///     "AzureDataExplorerSettings": {
    ///       "ClusterUri": "https://myadxcluster.kusto.windows.net",
    ///       "Database": "MyDatabase",
    ///       "Table": "MyTable"
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/setdataconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetDataConnectionResponse>> SetDataConnectionAsync(SetDataConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets a Data Connection for the title to either the active or deactivated state.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.SetDataConnectionActiveAsync({
    ///   "Name": "MyDataConnection",
    ///   "Active": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/setdataconnectionactive">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetDataConnectionActiveResponse>> SetDataConnectionActiveAsync(SetDataConnectionActiveRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the sampling ratio for an event.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/seteventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetEventSamplingRatioResult>> SetEventSamplingRatioAsync(SetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets a telemetry key to the active or deactivated state.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.SetTelemetryKeyActiveAsync({
    ///   "KeyName": "MyTelemetryKey",
    ///   "Active": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/settelemetrykeyactive">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTelemetryKeyActiveResponse>> SetTelemetryKeyActiveAsync(SetTelemetryKeyActiveRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Write batches of entity based events to PlayStream. The namespace of the Event must be 'custom' or start with 'custom.'.
    /// <example><br/>Example:<code>
    /// var response = await eventApi.WriteEventsAsync({
    ///   "Events": [
    ///     {
    ///       "Entity": {
    ///         "Id": "A8140AB9109712B",
    ///         "Type": "title",
    ///         "TypeString": "title"
    ///       },
    ///       "EventNamespace": "com.playfab.events.example",
    ///       "Name": "something_happened",
    ///       "Payload": {
    ///         "Foo": "Bar",
    ///         "Nums": [
    ///           1,
    ///           2,
    ///           3
    ///         ]
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/writeevents">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<WriteEventsResponse>> WriteEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Write batches of entity based events to as Telemetry events (bypass PlayStream). The namespace must be 'custom' or
    /// start with 'custom.'
    /// <example><br/>Example:<code>
    /// var response = await eventApi.WriteTelemetryEventsAsync({
    ///   "Events": [
    ///     {
    ///       "Entity": {
    ///         "Id": "A8140AB9109712B",
    ///         "Type": "title",
    ///         "TypeString": "title"
    ///       },
    ///       "EventNamespace": "com.playfab.events.example",
    ///       "Name": "something_happened",
    ///       "Payload": {
    ///         "Foo": "Bar",
    ///         "Nums": [
    ///           1,
    ///           2,
    ///           3
    ///         ]
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/writetelemetryevents">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<WriteEventsResponse>> WriteTelemetryEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders);
}