using CommunityFabs.NET.Sdk.Models.Experimentation;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabExperimentationInstanceApi : PlayFabBaseInstanceApi, IPlayFabExperimentationApi {
    public PlayFabExperimentationInstanceApi() : base() { }
    public PlayFabExperimentationInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabExperimentationInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabExperimentationInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CreateExclusionGroupResult> CreateExclusionGroupAsync(CreateExclusionGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateExclusionGroupResult>("/Experimentation/CreateExclusionGroup", request, extraHeaders);
    }
    public async Task<CreateExperimentResult> CreateExperimentAsync(CreateExperimentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateExperimentResult>("/Experimentation/CreateExperiment", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteExclusionGroupAsync(DeleteExclusionGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/DeleteExclusionGroup", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteExperimentAsync(DeleteExperimentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/DeleteExperiment", request, extraHeaders);
    }
    public async Task<GetExclusionGroupsResult> GetExclusionGroupsAsync(GetExclusionGroupsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetExclusionGroupsResult>("/Experimentation/GetExclusionGroups", request, extraHeaders);
    }
    public async Task<GetExclusionGroupTrafficResult> GetExclusionGroupTrafficAsync(GetExclusionGroupTrafficRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetExclusionGroupTrafficResult>("/Experimentation/GetExclusionGroupTraffic", request, extraHeaders);
    }
    public async Task<GetExperimentsResult> GetExperimentsAsync(GetExperimentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetExperimentsResult>("/Experimentation/GetExperiments", request, extraHeaders);
    }
    public async Task<GetLatestScorecardResult> GetLatestScorecardAsync(GetLatestScorecardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLatestScorecardResult>("/Experimentation/GetLatestScorecard", request, extraHeaders);
    }
    public async Task<GetTreatmentAssignmentResult> GetTreatmentAssignmentAsync(GetTreatmentAssignmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTreatmentAssignmentResult>("/Experimentation/GetTreatmentAssignment", request, extraHeaders);
    }
    public async Task<EmptyResponse> StartExperimentAsync(StartExperimentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/StartExperiment", request, extraHeaders);
    }
    public async Task<EmptyResponse> StopExperimentAsync(StopExperimentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/StopExperiment", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateExclusionGroupAsync(UpdateExclusionGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/UpdateExclusionGroup", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateExperimentAsync(UpdateExperimentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Experimentation/UpdateExperiment", request, extraHeaders);
    }
}