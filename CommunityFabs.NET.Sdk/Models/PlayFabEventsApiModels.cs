using CommunityFabs.NET.Sdk.Http;

namespace CommunityFabs.NET.Sdk.Models.Events;

public class CreateTelemetryKeyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the new key. Telemetry key names must be unique within the scope of the title.
    /// </summary>
    public required string KeyName { get; set; }
}

public class CreateTelemetryKeyResponse : PlayFabResultCommon {
    /// <summary>
    /// Details about the newly created telemetry key.
    /// </summary>
    public TelemetryKeyDetails? NewKeyDetails { get; set; }
}

public class DataConnectionAzureBlobSettings {
    /// <summary>
    /// Name of the storage account.
    /// </summary>
    public string? AccountName { get; set; }
    /// <summary>
    /// Name of the container.
    /// </summary>
    public string? ContainerName { get; set; }
    /// <summary>
    /// Azure Entra Tenant Id.
    /// </summary>
    public string? TenantId { get; set; }
}

public class DataConnectionAzureDataExplorerSettings {
    /// <summary>
    /// The URI of the ADX cluster.
    /// </summary>
    public string? ClusterUri { get; set; }
    /// <summary>
    /// The database to write to.
    /// </summary>
    public string? Database { get; set; }
    /// <summary>
    /// The table to write to.
    /// </summary>
    public string? Table { get; set; }
}

public class DataConnectionDetails {
    /// <summary>
    /// Settings of the data connection.
    /// </summary>
    public required DataConnectionSettings ConnectionSettings { get; set; }
    /// <summary>
    /// Whether or not the connection is currently active.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// The name of the data connection.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Current status of the data connection, if any.
    /// </summary>
    public DataConnectionStatusDetails? Status { get; set; }
    /// <summary>
    /// The type of data connection.
    /// </summary>
    public DataConnectionType Type { get; set; }
}

public enum DataConnectionErrorState {
    OK,
    Error,
}

public class DataConnectionFabricKQLSettings {
    /// <summary>
    /// The URI of the Fabric cluster.
    /// </summary>
    public string? ClusterUri { get; set; }
    /// <summary>
    /// The database to write to.
    /// </summary>
    public string? Database { get; set; }
    /// <summary>
    /// The table to write to.
    /// </summary>
    public string? Table { get; set; }
}

public class DataConnectionSettings {
    /// <summary>
    /// Settings if the type of connection is AzureBlobStorage.
    /// </summary>
    public DataConnectionAzureBlobSettings? AzureBlobSettings { get; set; }
    /// <summary>
    /// Settings if the type of connection is AzureDataExplorer.
    /// </summary>
    public DataConnectionAzureDataExplorerSettings? AzureDataExplorerSettings { get; set; }
    /// <summary>
    /// Settings if the type of connection is FabricKQL.
    /// </summary>
    public DataConnectionFabricKQLSettings? AzureFabricKQLSettings { get; set; }
}

public class DataConnectionStatusDetails {
    /// <summary>
    /// The name of the error affecting the data connection, if any.
    /// </summary>
    public string? Error { get; set; }
    /// <summary>
    /// A description of the error affecting the data connection, if any. This may be empty for some errors.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// The most recent time of the error affecting the data connection, if any.
    /// </summary>
    public DateTime? MostRecentErrorTime { get; set; }
    /// <summary>
    /// Indicates if the connection is in a normal state or error state.
    /// </summary>
    public DataConnectionErrorState? State { get; set; }
}

public enum DataConnectionType {
    AzureBlobStorage,
    AzureDataExplorer,
    FabricKQL,
}

public class DeleteDataConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the data connection to delete.
    /// </summary>
    public required string Name { get; set; }
}

public class DeleteDataConnectionResponse : PlayFabResultCommon {
    /// <summary>
    /// Indicates whether or not the connection was deleted as part of the request.
    /// </summary>
    public bool WasDeleted { get; set; }
}

public class DeleteEventSamplingRatioRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the sampled event
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// Namespace of the sampled event
    /// </summary>
    public required string EventNamespace { get; set; }
}

public class DeleteEventSamplingRatioResult : PlayFabResultCommon {
}

public class DeleteTelemetryKeyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the key to delete.
    /// </summary>
    public required string KeyName { get; set; }
}

public class DeleteTelemetryKeyResponse : PlayFabResultCommon {
    /// <summary>
    /// Indicates whether or not the key was deleted. If false, no key with that name existed.
    /// </summary>
    public bool WasKeyDeleted { get; set; }
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    /// <summary>
    /// Unique ID of the entity.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Entity type. See https://docs.microsoft.com/gaming/playfab/features/data/entities/available-built-in-entity-types
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Alternate name for Type.
    /// </summary>
    public string? TypeString { get; set; }
}

public class EventContents {
    /// <summary>
    /// The optional custom tags associated with the event (e.g. build number, external trace identifiers, etc.). Before an
    /// event is written, this collection and the base request custom tags will be merged, but not overriden. This enables the
    /// caller to specify static tags and per event tags.
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Entity associated with the event. If null, the event will apply to the calling entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The namespace in which the event is defined. Allowed namespaces can vary by API.
    /// </summary>
    public required string EventNamespace { get; set; }
    /// <summary>
    /// The name of this event.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The original unique identifier associated with this event before it was posted to PlayFab. The value might differ from
    /// the EventId value, which is assigned when the event is received by the server.
    /// </summary>
    public string? OriginalId { get; set; }
    /// <summary>
    /// The time (in UTC) associated with this event when it occurred. If specified, this value is stored in the
    /// OriginalTimestamp property of the PlayStream event.
    /// </summary>
    public DateTime? OriginalTimestamp { get; set; }
    /// <summary>
    /// Arbitrary data associated with the event. Only one of Payload or PayloadJSON is allowed.
    /// </summary>
    public object? Payload { get; set; }
    /// <summary>
    /// Arbitrary data associated with the event, represented as a JSON serialized string. Only one of Payload or PayloadJSON
    /// is allowed.
    /// </summary>
    public string? PayloadJSON { get; set; }
}

public class EventSamplingRatio {
    public string? EventName { get; set; }
    public string? EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class GetDataConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the data connection to retrieve.
    /// </summary>
    public required string Name { get; set; }
}

public class GetDataConnectionResponse : PlayFabResultCommon {
    /// <summary>
    /// The details of the queried Data Connection.
    /// </summary>
    public DataConnectionDetails? DataConnection { get; set; }
}

public class GetEventSamplingRatioRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the sampled event
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// Namespace of the sampled event
    /// </summary>
    public required string EventNamespace { get; set; }
}

public class GetEventSamplingRatioResult : PlayFabResultCommon {
    /// <summary>
    /// Name of the sampled event
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// Namespace of the sampled event
    /// </summary>
    public required string EventNamespace { get; set; }
    /// <summary>
    /// Sampling ratio of the event
    /// </summary>
    public int Ratio { get; set; }
}

public class GetEventSamplingRatiosRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetEventSamplingRatiosResult : PlayFabResultCommon {
    public List<EventSamplingRatio>? Ratios { get; set; }
}

public class GetTelemetryKeyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the key to retrieve.
    /// </summary>
    public required string KeyName { get; set; }
}

public class GetTelemetryKeyResponse : PlayFabResultCommon {
    /// <summary>
    /// Details about the requested telemetry key.
    /// </summary>
    public TelemetryKeyDetails? KeyDetails { get; set; }
}

public class ListDataConnectionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListDataConnectionsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of existing Data Connections.
    /// </summary>
    public List<DataConnectionDetails>? DataConnections { get; set; }
}

public class ListTelemetryKeysRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class ListTelemetryKeysResponse : PlayFabResultCommon {
    /// <summary>
    /// The telemetry keys configured for the title.
    /// </summary>
    public List<TelemetryKeyDetails>? KeyDetails { get; set; }
}

public class SetDataConnectionActiveRequest : PlayFabRequestCommon {
    /// <summary>
    /// Whether to set the data connection to active (true) or deactivated (false).
    /// </summary>
    public bool Active { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the data connection to update.
    /// </summary>
    public required string Name { get; set; }
}

public class SetDataConnectionActiveResponse : PlayFabResultCommon {
    /// <summary>
    /// The most current details about the data connection that was to be updated.
    /// </summary>
    public DataConnectionDetails? DataConnection { get; set; }
    /// <summary>
    /// Indicates whether or not the data connection was updated. If false, the data connection was already in the desired
    /// state.
    /// </summary>
    public bool WasUpdated { get; set; }
}

public class SetDataConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// Settings of the data connection.
    /// </summary>
    public required DataConnectionSettings ConnectionSettings { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Whether or not the connection is currently active.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// The name of the data connection to update or create.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The type of data connection.
    /// </summary>
    public DataConnectionType Type { get; set; }
}

public class SetDataConnectionResponse : PlayFabResultCommon {
    /// <summary>
    /// The details of the Data Connection to be created or updated.
    /// </summary>
    public DataConnectionDetails? DataConnection { get; set; }
}

public class SetEventSamplingRatioRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the sampled event
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// Namespace of the sampled event
    /// </summary>
    public required string EventNamespace { get; set; }
    /// <summary>
    /// Sampling ratio of the event
    /// </summary>
    public int Ratio { get; set; }
}

public class SetEventSamplingRatioResult : PlayFabResultCommon {
}

public class SetTelemetryKeyActiveRequest : PlayFabRequestCommon {
    /// <summary>
    /// Whether to set the key to active (true) or deactivated (false).
    /// </summary>
    public bool Active { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the key to update.
    /// </summary>
    public required string KeyName { get; set; }
}

public class SetTelemetryKeyActiveResponse : PlayFabResultCommon {
    /// <summary>
    /// The most current details about the telemetry key that was to be updated.
    /// </summary>
    public TelemetryKeyDetails? KeyDetails { get; set; }
    /// <summary>
    /// Indicates whether or not the key was updated. If false, the key was already in the desired state.
    /// </summary>
    public bool WasKeyUpdated { get; set; }
}

public class TelemetryKeyDetails {
    /// <summary>
    /// When the key was created.
    /// </summary>
    public required DateTime CreateTime { get; set; }
    /// <summary>
    /// Whether or not the key is currently active. Deactivated keys cannot be used for telemetry ingestion.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// The key that can be distributed to clients for use during telemetry ingestion.
    /// </summary>
    public string? KeyValue { get; set; }
    /// <summary>
    /// When the key was last updated.
    /// </summary>
    public required DateTime LastUpdateTime { get; set; }
    /// <summary>
    /// The name of the key. Telemetry key names are unique within the scope of the title.
    /// </summary>
    public string? Name { get; set; }
}

public class WriteEventsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The collection of events to write. Up to 200 events can be written per request.
    /// </summary>
    public required List<EventContents> Events { get; set; }
}

public class WriteEventsResponse : PlayFabResultCommon {
    /// <summary>
    /// The unique identifiers assigned by the server to the events, in the same order as the events in the request. Only
    /// returned if FlushToPlayStream option is true.
    /// </summary>
    public List<string>? AssignedEventIds { get; set; }
}

