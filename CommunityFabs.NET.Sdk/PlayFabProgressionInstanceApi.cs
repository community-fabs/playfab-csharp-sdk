using CommunityFabs.NET.Sdk.Models.Progression;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabProgressionInstanceApi : PlayFabBaseInstanceApi, IPlayFabProgressionApi {
    public PlayFabProgressionInstanceApi() : base() { }
    public PlayFabProgressionInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabProgressionInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabProgressionInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<EmptyResponse> CreateLeaderboardDefinitionAsync(CreateLeaderboardDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/CreateLeaderboardDefinition", request, extraHeaders);
    }
    public async Task<EmptyResponse> CreateStatisticDefinitionAsync(CreateStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Statistic/CreateStatisticDefinition", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteLeaderboardDefinitionAsync(DeleteLeaderboardDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/DeleteLeaderboardDefinition", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteLeaderboardEntriesAsync(DeleteLeaderboardEntriesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/DeleteLeaderboardEntries", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteStatisticDefinitionAsync(DeleteStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Statistic/DeleteStatisticDefinition", request, extraHeaders);
    }
    public async Task<DeleteStatisticsResponse> DeleteStatisticsAsync(DeleteStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteStatisticsResponse>("/Statistic/DeleteStatistics", request, extraHeaders);
    }
    public async Task<GetEntityLeaderboardResponse> GetFriendLeaderboardForEntityAsync(GetFriendLeaderboardForEntityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityLeaderboardResponse>("/Leaderboard/GetFriendLeaderboardForEntity", request, extraHeaders);
    }
    public async Task<GetEntityLeaderboardResponse> GetLeaderboardAsync(GetEntityLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityLeaderboardResponse>("/Leaderboard/GetLeaderboard", request, extraHeaders);
    }
    public async Task<GetEntityLeaderboardResponse> GetLeaderboardAroundEntityAsync(GetLeaderboardAroundEntityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityLeaderboardResponse>("/Leaderboard/GetLeaderboardAroundEntity", request, extraHeaders);
    }
    public async Task<GetLeaderboardDefinitionResponse> GetLeaderboardDefinitionAsync(GetLeaderboardDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardDefinitionResponse>("/Leaderboard/GetLeaderboardDefinition", request, extraHeaders);
    }
    public async Task<GetEntityLeaderboardResponse> GetLeaderboardForEntitiesAsync(GetLeaderboardForEntitiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityLeaderboardResponse>("/Leaderboard/GetLeaderboardForEntities", request, extraHeaders);
    }
    public async Task<GetStatisticDefinitionResponse> GetStatisticDefinitionAsync(GetStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStatisticDefinitionResponse>("/Statistic/GetStatisticDefinition", request, extraHeaders);
    }
    public async Task<GetStatisticDefinitionsResponse> GetStatisticDefinitionsAsync(GetStatisticDefinitionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStatisticDefinitionsResponse>("/Statistic/GetStatisticDefinitions", request, extraHeaders);
    }
    public async Task<GetStatisticsResponse> GetStatisticsAsync(GetStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStatisticsResponse>("/Statistic/GetStatistics", request, extraHeaders);
    }
    public async Task<GetStatisticsForEntitiesResponse> GetStatisticsForEntitiesAsync(GetStatisticsForEntitiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStatisticsForEntitiesResponse>("/Statistic/GetStatisticsForEntities", request, extraHeaders);
    }
    public async Task<IncrementLeaderboardVersionResponse> IncrementLeaderboardVersionAsync(IncrementLeaderboardVersionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IncrementLeaderboardVersionResponse>("/Leaderboard/IncrementLeaderboardVersion", request, extraHeaders);
    }
    public async Task<IncrementStatisticVersionResponse> IncrementStatisticVersionAsync(IncrementStatisticVersionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IncrementStatisticVersionResponse>("/Statistic/IncrementStatisticVersion", request, extraHeaders);
    }
    public async Task<ListLeaderboardDefinitionsResponse> ListLeaderboardDefinitionsAsync(ListLeaderboardDefinitionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListLeaderboardDefinitionsResponse>("/Leaderboard/ListLeaderboardDefinitions", request, extraHeaders);
    }
    public async Task<ListStatisticDefinitionsResponse> ListStatisticDefinitionsAsync(ListStatisticDefinitionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListStatisticDefinitionsResponse>("/Statistic/ListStatisticDefinitions", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkLeaderboardFromStatisticAsync(UnlinkLeaderboardFromStatisticRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/UnlinkLeaderboardFromStatistic", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateLeaderboardDefinitionAsync(UpdateLeaderboardDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/UpdateLeaderboardDefinition", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateLeaderboardEntriesAsync(UpdateLeaderboardEntriesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Leaderboard/UpdateLeaderboardEntries", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateStatisticDefinitionAsync(UpdateStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Statistic/UpdateStatisticDefinition", request, extraHeaders);
    }
    public async Task<UpdateStatisticsResponse> UpdateStatisticsAsync(UpdateStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateStatisticsResponse>("/Statistic/UpdateStatistics", request, extraHeaders);
    }
}