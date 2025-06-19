using CommunityFabs.NET.Sdk.Models.Events;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabEventsApi {
    /// <summary>
    /// Creates a new telemetry key for the title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.CreateTelemetryKeyAsync({);
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/createtelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateTelemetryKeyResponse> CreateTelemetryKeyAsync(CreateTelemetryKeyRequest request);
    /// <summary>
    /// Deletes a Data Connection from a title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.DeleteDataConnectionAsync({);
    ///   "Name": "MyDataConnection"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/deletedataconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteDataConnectionResponse> DeleteDataConnectionAsync(DeleteDataConnectionRequest request);
    /// <summary>
    /// Deletes the sampling ratio for an event.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/deleteeventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteEventSamplingRatioResult> DeleteEventSamplingRatioAsync(DeleteEventSamplingRatioRequest request);
    /// <summary>
    /// Deletes a telemetry key configured for the title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.DeleteTelemetryKeyAsync({);
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/deletetelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteTelemetryKeyResponse> DeleteTelemetryKeyAsync(DeleteTelemetryKeyRequest request);
    /// <summary>
    /// Retrieves a single Data Connection associated with a title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.GetDataConnectionAsync({);
    ///   "Name": "MyDataConnection"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/getdataconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<GetDataConnectionResponse> GetDataConnectionAsync(GetDataConnectionRequest request);
    /// <summary>
    /// Gets the sampling ratio for an event.
    /// <example><br/>Example:<code>
    /// var response = eventApi.GetEventSamplingRatioAsync({);
    ///   "EventNamespace": "com.playfab",
    ///   "EventName": "player_executed_cloudscript"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/geteventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEventSamplingRatioResult> GetEventSamplingRatioAsync(GetEventSamplingRatioRequest request);
    /// <summary>
    /// Gets the event sampling ratios for a title.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/geteventsamplingratios">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEventSamplingRatiosResult> GetEventSamplingRatiosAsync(GetEventSamplingRatiosRequest request);
    /// <summary>
    /// Gets information about a telemetry key configured for the title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.GetTelemetryKeyAsync({);
    ///   "KeyName": "MyTelemetryKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/gettelemetrykey">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTelemetryKeyResponse> GetTelemetryKeyAsync(GetTelemetryKeyRequest request);
    /// <summary>
    /// Retrieves the list of Data Connections associated with a title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.ListDataConnectionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/listdataconnections">Microsoft Documentation</see>
    /// </summary>
    public Task<ListDataConnectionsResponse> ListDataConnectionsAsync(ListDataConnectionsRequest request);
    /// <summary>
    /// Lists all telemetry keys configured for the title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.ListTelemetryKeysAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/listtelemetrykeys">Microsoft Documentation</see>
    /// </summary>
    public Task<ListTelemetryKeysResponse> ListTelemetryKeysAsync(ListTelemetryKeysRequest request);
    /// <summary>
    /// Creates or updates a Data Connection on a title.
    /// <example><br/>Example:<code>
    /// var response = eventApi.SetDataConnectionAsync({);
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
    public Task<SetDataConnectionResponse> SetDataConnectionAsync(SetDataConnectionRequest request);
    /// <summary>
    /// Sets a Data Connection for the title to either the active or deactivated state.
    /// <example><br/>Example:<code>
    /// var response = eventApi.SetDataConnectionActiveAsync({);
    ///   "Name": "MyDataConnection",
    ///   "Active": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/setdataconnectionactive">Microsoft Documentation</see>
    /// </summary>
    public Task<SetDataConnectionActiveResponse> SetDataConnectionActiveAsync(SetDataConnectionActiveRequest request);
    /// <summary>
    /// Sets the sampling ratio for an event.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream/seteventsamplingratio">Microsoft Documentation</see>
    /// </summary>
    public Task<SetEventSamplingRatioResult> SetEventSamplingRatioAsync(SetEventSamplingRatioRequest request);
    /// <summary>
    /// Sets a telemetry key to the active or deactivated state.
    /// <example><br/>Example:<code>
    /// var response = eventApi.SetTelemetryKeyActiveAsync({);
    ///   "KeyName": "MyTelemetryKey",
    ///   "Active": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/event/playstream-events/settelemetrykeyactive">Microsoft Documentation</see>
    /// </summary>
    public Task<SetTelemetryKeyActiveResponse> SetTelemetryKeyActiveAsync(SetTelemetryKeyActiveRequest request);
    /// <summary>
    /// Write batches of entity based events to PlayStream. The namespace of the Event must be 'custom' or start with 'custom.'.
    /// <example><br/>Example:<code>
    /// var response = eventApi.WriteEventsAsync({);
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
    public Task<WriteEventsResponse> WriteEventsAsync(WriteEventsRequest request);
    /// <summary>
    /// Write batches of entity based events to as Telemetry events (bypass PlayStream). The namespace must be 'custom' or
    /// start with 'custom.'
    /// <example><br/>Example:<code>
    /// var response = eventApi.WriteTelemetryEventsAsync({);
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
    public Task<WriteEventsResponse> WriteTelemetryEventsAsync(WriteEventsRequest request);
}