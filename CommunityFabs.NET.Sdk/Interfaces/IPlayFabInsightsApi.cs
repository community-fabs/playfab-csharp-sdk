using CommunityFabs.NET.Sdk.Models.Insights;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabInsightsApi {
    /// <summary>
    /// Gets the current values for the Insights performance and data storage retention, list of pending operations, and the
    /// performance and data storage retention limits.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.GetDetailsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getdetails">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsGetDetailsResponse> GetDetailsAsync(InsightsEmptyRequest request);
    /// <summary>
    /// Retrieves the range of allowed values for performance and data storage retention values as well as the submeter details
    /// for each performance level.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.GetLimitsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getlimits">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsGetLimitsResponse> GetLimitsAsync(InsightsEmptyRequest request);
    /// <summary>
    /// Gets the status of a SetPerformance or SetStorageRetention operation.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.GetOperationStatusAsync({);
    ///   "OperationId": "3ee468c4-ad09-4bb1-bccf-209ef5abfb96"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getoperationstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsGetOperationStatusResponse> GetOperationStatusAsync(InsightsGetOperationStatusRequest request);
    /// <summary>
    /// Gets a list of pending SetPerformance and/or SetStorageRetention operations for the title.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.GetPendingOperationsAsync({);
    ///   "OperationType": "SetPerformance"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getpendingoperations">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsGetPendingOperationsResponse> GetPendingOperationsAsync(InsightsGetPendingOperationsRequest request);
    /// <summary>
    /// Sets the Insights performance level value for the title.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.SetPerformanceAsync({);
    ///   "PerformanceLevel": 3
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/setperformance">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsOperationResponse> SetPerformanceAsync(InsightsSetPerformanceRequest request);
    /// <summary>
    /// Sets the Insights data storage retention days value for the title.
    /// <example><br/>Example:<code>
    /// var response = insightsApi.SetStorageRetentionAsync({);
    ///   "RetentionDays": 30
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/setstorageretention">Microsoft Documentation</see>
    /// </summary>
    public Task<InsightsOperationResponse> SetStorageRetentionAsync(InsightsSetStorageRetentionRequest request);
}