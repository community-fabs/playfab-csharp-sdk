using CommunityFabs.NET.Common.Models.Insights;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabInsightsApi {
    /// <summary>
    /// Gets the current values for the Insights performance and data storage retention, list of pending operations, and the
    /// performance and data storage retention limits.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.GetDetailsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getdetails">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsGetDetailsResponse>> GetDetailsAsync(InsightsEmptyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the range of allowed values for performance and data storage retention values as well as the submeter details
    /// for each performance level.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.GetLimitsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getlimits">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsGetLimitsResponse>> GetLimitsAsync(InsightsEmptyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the status of a SetPerformance or SetStorageRetention operation.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.GetOperationStatusAsync({
    ///   "OperationId": "3ee468c4-ad09-4bb1-bccf-209ef5abfb96"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getoperationstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsGetOperationStatusResponse>> GetOperationStatusAsync(InsightsGetOperationStatusRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a list of pending SetPerformance and/or SetStorageRetention operations for the title.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.GetPendingOperationsAsync({
    ///   "OperationType": "SetPerformance"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/getpendingoperations">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsGetPendingOperationsResponse>> GetPendingOperationsAsync(InsightsGetPendingOperationsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the Insights performance level value for the title.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.SetPerformanceAsync({
    ///   "PerformanceLevel": 3
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/setperformance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsOperationResponse>> SetPerformanceAsync(InsightsSetPerformanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the Insights data storage retention days value for the title.
    /// <example><br/>Example:<code>
    /// var response = await insightsApi.SetStorageRetentionAsync({
    ///   "RetentionDays": 30
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/insights/analytics/setstorageretention">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InsightsOperationResponse>> SetStorageRetentionAsync(InsightsSetStorageRetentionRequest request, Dictionary<string, string>? extraHeaders);
}