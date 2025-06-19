namespace CommunityFabs.NET.Sdk.Models.Events;

public class CreateTelemetryKeyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class CreateTelemetryKeyResponse : PlayFabResultCommon {
    public TelemetryKeyDetails? NewKeyDetails { get; set; }
}

public class DataConnectionAzureBlobSettings {
    public string? AccountName { get; set; }
    public string? ContainerName { get; set; }
    public string? TenantId { get; set; }
}

public class DataConnectionAzureDataExplorerSettings {
    public string? ClusterUri { get; set; }
    public string? Database { get; set; }
    public string? Table { get; set; }
}

public class DataConnectionDetails {
    public required DataConnectionSettings ConnectionSettings { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public DataConnectionStatusDetails? Status { get; set; }
    public DataConnectionType Type { get; set; }
}

public enum DataConnectionErrorState {
    OK,
    Error,
}

public class DataConnectionFabricKQLSettings {
    public string? ClusterUri { get; set; }
    public string? Database { get; set; }
    public string? Table { get; set; }
}

public class DataConnectionSettings {
    public DataConnectionAzureBlobSettings? AzureBlobSettings { get; set; }
    public DataConnectionAzureDataExplorerSettings? AzureDataExplorerSettings { get; set; }
    public DataConnectionFabricKQLSettings? AzureFabricKQLSettings { get; set; }
}

public class DataConnectionStatusDetails {
    public string? Error { get; set; }
    public string? ErrorMessage { get; set; }
    public DateTime? MostRecentErrorTime { get; set; }
    public DataConnectionErrorState? State { get; set; }
}

public enum DataConnectionType {
    AzureBlobStorage,
    AzureDataExplorer,
    FabricKQL,
}

public class DeleteDataConnectionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class DeleteDataConnectionResponse : PlayFabResultCommon {
    public bool WasDeleted { get; set; }
}

public class DeleteEventSamplingRatioRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
}

public class DeleteEventSamplingRatioResult : PlayFabResultCommon {
}

public class DeleteTelemetryKeyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class DeleteTelemetryKeyResponse : PlayFabResultCommon {
    public bool WasKeyDeleted { get; set; }
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class EventContents {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string EventNamespace { get; set; }
    public required string Name { get; set; }
    public string? OriginalId { get; set; }
    public DateTime? OriginalTimestamp { get; set; }
    public object? Payload { get; set; }
    public string? PayloadJSON { get; set; }
}

public class EventSamplingRatio {
    public string? EventName { get; set; }
    public string? EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class GetDataConnectionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class GetDataConnectionResponse : PlayFabResultCommon {
    public DataConnectionDetails? DataConnection { get; set; }
}

public class GetEventSamplingRatioRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
}

public class GetEventSamplingRatioResult : PlayFabResultCommon {
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class GetEventSamplingRatiosRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetEventSamplingRatiosResult : PlayFabResultCommon {
    public List<EventSamplingRatio>? Ratios { get; set; }
}

public class GetTelemetryKeyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class GetTelemetryKeyResponse : PlayFabResultCommon {
    public TelemetryKeyDetails? KeyDetails { get; set; }
}

public class ListDataConnectionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListDataConnectionsResponse : PlayFabResultCommon {
    public List<DataConnectionDetails>? DataConnections { get; set; }
}

public class ListTelemetryKeysRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class ListTelemetryKeysResponse : PlayFabResultCommon {
    public List<TelemetryKeyDetails>? KeyDetails { get; set; }
}

public class SetDataConnectionActiveRequest : PlayFabRequestCommon {
    public bool Active { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class SetDataConnectionActiveResponse : PlayFabResultCommon {
    public DataConnectionDetails? DataConnection { get; set; }
    public bool WasUpdated { get; set; }
}

public class SetDataConnectionRequest : PlayFabRequestCommon {
    public required DataConnectionSettings ConnectionSettings { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public DataConnectionType Type { get; set; }
}

public class SetDataConnectionResponse : PlayFabResultCommon {
    public DataConnectionDetails? DataConnection { get; set; }
}

public class SetEventSamplingRatioRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class SetEventSamplingRatioResult : PlayFabResultCommon {
}

public class SetTelemetryKeyActiveRequest : PlayFabRequestCommon {
    public bool Active { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class SetTelemetryKeyActiveResponse : PlayFabResultCommon {
    public TelemetryKeyDetails? KeyDetails { get; set; }
    public bool WasKeyUpdated { get; set; }
}

public class TelemetryKeyDetails {
    public required DateTime CreateTime { get; set; }
    public bool IsActive { get; set; }
    public string? KeyValue { get; set; }
    public required DateTime LastUpdateTime { get; set; }
    public string? Name { get; set; }
}

public class WriteEventsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<EventContents> Events { get; set; }
}

public class WriteEventsResponse : PlayFabResultCommon {
    public List<string>? AssignedEventIds { get; set; }
}

