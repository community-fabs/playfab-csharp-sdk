using CommunityFabs.NET.Sdk.Models.Insights;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabInsightsInstanceApi : PlayFabBaseInstanceApi, IPlayFabInsightsApi {
    public PlayFabInsightsInstanceApi() : base() { }
    public PlayFabInsightsInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabInsightsInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabInsightsInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<InsightsGetDetailsResponse> GetDetailsAsync(InsightsEmptyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsGetDetailsResponse>("/Insights/GetDetails", request, extraHeaders);
    }
    public async Task<InsightsGetLimitsResponse> GetLimitsAsync(InsightsEmptyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsGetLimitsResponse>("/Insights/GetLimits", request, extraHeaders);
    }
    public async Task<InsightsGetOperationStatusResponse> GetOperationStatusAsync(InsightsGetOperationStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsGetOperationStatusResponse>("/Insights/GetOperationStatus", request, extraHeaders);
    }
    public async Task<InsightsGetPendingOperationsResponse> GetPendingOperationsAsync(InsightsGetPendingOperationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsGetPendingOperationsResponse>("/Insights/GetPendingOperations", request, extraHeaders);
    }
    public async Task<InsightsOperationResponse> SetPerformanceAsync(InsightsSetPerformanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsOperationResponse>("/Insights/SetPerformance", request, extraHeaders);
    }
    public async Task<InsightsOperationResponse> SetStorageRetentionAsync(InsightsSetStorageRetentionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InsightsOperationResponse>("/Insights/SetStorageRetention", request, extraHeaders);
    }
}