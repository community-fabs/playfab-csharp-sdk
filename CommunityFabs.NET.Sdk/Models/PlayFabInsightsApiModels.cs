namespace CommunityFabs.NET.Sdk.Models.Insights;

public class InsightsEmptyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class InsightsGetDetailsResponse {
    public UInt32 DataUsageMb { get; set; }
    public string? ErrorMessage { get; set; }
    public InsightsGetLimitsResponse? Limits { get; set; }
    public List<InsightsGetOperationStatusResponse>? PendingOperations { get; set; }
    public int PerformanceLevel { get; set; }
    public int RetentionDays { get; set; }
}

public class InsightsGetLimitsResponse {
    public int DefaultPerformanceLevel { get; set; }
    public int DefaultStorageRetentionDays { get; set; }
    public int StorageMaxRetentionDays { get; set; }
    public int StorageMinRetentionDays { get; set; }
    public List<InsightsPerformanceLevel>? SubMeters { get; set; }
}

/// <summary>
/// Returns the current status for the requested operation id.
/// </summary>
public class InsightsGetOperationStatusRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? OperationId { get; set; }
}

public class InsightsGetOperationStatusResponse {
    public string? Message { get; set; }
    public required DateTime OperationCompletedTime { get; set; }
    public string? OperationId { get; set; }
    public required DateTime OperationLastUpdated { get; set; }
    public required DateTime OperationStartedTime { get; set; }
    public string? OperationType { get; set; }
    public int OperationValue { get; set; }
    public string? Status { get; set; }
}

/// <summary>
/// Returns a list of operations that are in the pending state for the requested operation type.
/// </summary>
public class InsightsGetPendingOperationsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? OperationType { get; set; }
}

public class InsightsGetPendingOperationsResponse {
    public List<InsightsGetOperationStatusResponse>? PendingOperations { get; set; }
}

public class InsightsOperationResponse {
    public string? Message { get; set; }
    public string? OperationId { get; set; }
    public string? OperationType { get; set; }
}

public class InsightsPerformanceLevel {
    public int ActiveEventExports { get; set; }
    public int CacheSizeMB { get; set; }
    public int Concurrency { get; set; }
    public required double CreditsPerMinute { get; set; }
    public int EventsPerSecond { get; set; }
    public int Level { get; set; }
    public int MaxMemoryPerQueryMB { get; set; }
    public int VirtualCpuCores { get; set; }
}

/// <summary>
/// Sets the performance level to the requested value. Use the GetLimits method to get the allowed values.
/// </summary>
public class InsightsSetPerformanceRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int PerformanceLevel { get; set; }
}

/// <summary>
/// Sets the data storage retention to the requested value. Use the GetLimits method to get the range of allowed values.
/// </summary>
public class InsightsSetStorageRetentionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int RetentionDays { get; set; }
}

