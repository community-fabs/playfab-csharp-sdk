namespace CommunityFabs.NET.Sdk.Models.Events;

public class CreateTelemetryKeyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class CreateTelemetryKeyResponse {
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

public class DeleteDataConnectionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class DeleteDataConnectionResponse {
    public bool WasDeleted { get; set; }
}

public class DeleteEventSamplingRatioRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
}

public class DeleteEventSamplingRatioResult {
}

public class DeleteTelemetryKeyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class DeleteTelemetryKeyResponse {
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

public class GetDataConnectionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class GetDataConnectionResponse {
    public DataConnectionDetails? DataConnection { get; set; }
}

public class GetEventSamplingRatioRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
}

public class GetEventSamplingRatioResult {
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class GetEventSamplingRatiosRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetEventSamplingRatiosResult {
    public List<EventSamplingRatio>? Ratios { get; set; }
}

public class GetTelemetryKeyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class GetTelemetryKeyResponse {
    public TelemetryKeyDetails? KeyDetails { get; set; }
}

public class ListDataConnectionsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListDataConnectionsResponse {
    public List<DataConnectionDetails>? DataConnections { get; set; }
}

public class ListTelemetryKeysRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class ListTelemetryKeysResponse {
    public List<TelemetryKeyDetails>? KeyDetails { get; set; }
}

public class SetDataConnectionActiveRequest {
    public bool Active { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class SetDataConnectionActiveResponse {
    public DataConnectionDetails? DataConnection { get; set; }
    public bool WasUpdated { get; set; }
}

public class SetDataConnectionRequest {
    public required DataConnectionSettings ConnectionSettings { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public DataConnectionType Type { get; set; }
}

public class SetDataConnectionResponse {
    public DataConnectionDetails? DataConnection { get; set; }
}

public class SetEventSamplingRatioRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string EventNamespace { get; set; }
    public int Ratio { get; set; }
}

public class SetEventSamplingRatioResult {
}

public class SetTelemetryKeyActiveRequest {
    public bool Active { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string KeyName { get; set; }
}

public class SetTelemetryKeyActiveResponse {
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

public class WriteEventsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<EventContents> Events { get; set; }
}

public class WriteEventsResponse {
    public List<string>? AssignedEventIds { get; set; }
}

