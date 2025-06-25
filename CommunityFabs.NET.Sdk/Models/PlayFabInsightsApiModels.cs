using CommunityFabs.NET.Sdk.Http;

namespace CommunityFabs.NET.Sdk.Models.Insights;

public class InsightsEmptyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class InsightsGetDetailsResponse : PlayFabResultCommon {
    /// <summary>
    /// Amount of data (in MB) currently used by Insights.
    /// </summary>
    public uint DataUsageMb { get; set; }
    /// <summary>
    /// Details of any error that occurred while retrieving Insights details.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// Allowed range of values for performance level and data storage retention.
    /// </summary>
    public InsightsGetLimitsResponse? Limits { get; set; }
    /// <summary>
    /// List of pending Insights operations for the title.
    /// </summary>
    public List<InsightsGetOperationStatusResponse>? PendingOperations { get; set; }
    /// <summary>
    /// Current Insights performance level setting.
    /// </summary>
    public int PerformanceLevel { get; set; }
    /// <summary>
    /// Current Insights data storage retention value in days.
    /// </summary>
    public int RetentionDays { get; set; }
}

public class InsightsGetLimitsResponse : PlayFabResultCommon {
    /// <summary>
    /// Default Insights performance level.
    /// </summary>
    public int DefaultPerformanceLevel { get; set; }
    /// <summary>
    /// Default Insights data storage retention days.
    /// </summary>
    public int DefaultStorageRetentionDays { get; set; }
    /// <summary>
    /// Maximum allowed data storage retention days.
    /// </summary>
    public int StorageMaxRetentionDays { get; set; }
    /// <summary>
    /// Minimum allowed data storage retention days.
    /// </summary>
    public int StorageMinRetentionDays { get; set; }
    /// <summary>
    /// List of Insights submeter limits for the allowed performance levels.
    /// </summary>
    public List<InsightsPerformanceLevel>? SubMeters { get; set; }
}

/// <summary>
/// Returns the current status for the requested operation id.
/// </summary>
public class InsightsGetOperationStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Id of the Insights operation.
    /// </summary>
    public string? OperationId { get; set; }
}

public class InsightsGetOperationStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// Optional message related to the operation details.
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Time the operation was completed.
    /// </summary>
    public required DateTime OperationCompletedTime { get; set; }
    /// <summary>
    /// Id of the Insights operation.
    /// </summary>
    public string? OperationId { get; set; }
    /// <summary>
    /// Time the operation status was last updated.
    /// </summary>
    public required DateTime OperationLastUpdated { get; set; }
    /// <summary>
    /// Time the operation started.
    /// </summary>
    public required DateTime OperationStartedTime { get; set; }
    /// <summary>
    /// The type of operation, SetPerformance or SetStorageRetention.
    /// </summary>
    public string? OperationType { get; set; }
    /// <summary>
    /// The value requested for the operation.
    /// </summary>
    public int OperationValue { get; set; }
    /// <summary>
    /// Current status of the operation.
    /// </summary>
    public string? Status { get; set; }
}

/// <summary>
/// Returns a list of operations that are in the pending state for the requested operation type.
/// </summary>
public class InsightsGetPendingOperationsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The type of pending operations requested, or blank for all operation types.
    /// </summary>
    public string? OperationType { get; set; }
}

public class InsightsGetPendingOperationsResponse : PlayFabResultCommon {
    /// <summary>
    /// List of pending Insights operations.
    /// </summary>
    public List<InsightsGetOperationStatusResponse>? PendingOperations { get; set; }
}

public class InsightsOperationResponse : PlayFabResultCommon {
    /// <summary>
    /// Optional message related to the operation details.
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Id of the Insights operation.
    /// </summary>
    public string? OperationId { get; set; }
    /// <summary>
    /// The type of operation, SetPerformance or SetStorageRetention.
    /// </summary>
    public string? OperationType { get; set; }
}

public class InsightsPerformanceLevel {
    /// <summary>
    /// Number of allowed active event exports.
    /// </summary>
    public int ActiveEventExports { get; set; }
    /// <summary>
    /// Maximum cache size.
    /// </summary>
    public int CacheSizeMB { get; set; }
    /// <summary>
    /// Maximum number of concurrent queries.
    /// </summary>
    public int Concurrency { get; set; }
    /// <summary>
    /// Number of Insights credits consumed per minute.
    /// </summary>
    public required double CreditsPerMinute { get; set; }
    /// <summary>
    /// Maximum events per second.
    /// </summary>
    public int EventsPerSecond { get; set; }
    /// <summary>
    /// Performance level.
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// Maximum amount of memory allowed per query.
    /// </summary>
    public int MaxMemoryPerQueryMB { get; set; }
    /// <summary>
    /// Amount of compute power allocated for queries and operations.
    /// </summary>
    public int VirtualCpuCores { get; set; }
}

/// <summary>
/// Sets the performance level to the requested value. Use the GetLimits method to get the allowed values.
/// </summary>
public class InsightsSetPerformanceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The Insights performance level to apply to the title.
    /// </summary>
    public int PerformanceLevel { get; set; }
}

/// <summary>
/// Sets the data storage retention to the requested value. Use the GetLimits method to get the range of allowed values.
/// </summary>
public class InsightsSetStorageRetentionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The Insights data storage retention value (in days) to apply to the title.
    /// </summary>
    public int RetentionDays { get; set; }
}

