using CommunityFabs.NET.Sdk.Models.Multiplayer;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabMultiplayerInstanceApi : PlayFabBaseInstanceApi, IPlayFabMultiplayerApi {
    public PlayFabMultiplayerInstanceApi() : base() { }
    public PlayFabMultiplayerInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabMultiplayerInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabMultiplayerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CancelAllMatchmakingTicketsForPlayerResult> CancelAllMatchmakingTicketsForPlayerAsync(CancelAllMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelAllMatchmakingTicketsForPlayerResult>("/Match/CancelAllMatchmakingTicketsForPlayer", request, extraHeaders);
    }
    public async Task<CancelAllServerBackfillTicketsForPlayerResult> CancelAllServerBackfillTicketsForPlayerAsync(CancelAllServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelAllServerBackfillTicketsForPlayerResult>("/Match/CancelAllServerBackfillTicketsForPlayer", request, extraHeaders);
    }
    public async Task<CancelMatchmakingTicketResult> CancelMatchmakingTicketAsync(CancelMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelMatchmakingTicketResult>("/Match/CancelMatchmakingTicket", request, extraHeaders);
    }
    public async Task<CancelModelResponse> CancelModelAsync(CancelModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelModelResponse>("/TrueSkill/CancelModel", request, extraHeaders);
    }
    public async Task<CancelServerBackfillTicketResult> CancelServerBackfillTicketAsync(CancelServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelServerBackfillTicketResult>("/Match/CancelServerBackfillTicket", request, extraHeaders);
    }
    public async Task<CreateBaseModelResponse> CreateBaseModelAsync(CreateBaseModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateBaseModelResponse>("/TrueSkill/CreateBaseModel", request, extraHeaders);
    }
    public async Task<CreateBatchModelResponse> CreateBatchModelAsync(CreateBatchModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateBatchModelResponse>("/TrueSkill/CreateBatchModel", request, extraHeaders);
    }
    public async Task<BuildAliasDetailsResponse> CreateBuildAliasAsync(CreateBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BuildAliasDetailsResponse>("/MultiplayerServer/CreateBuildAlias", request, extraHeaders);
    }
    public async Task<CreateBuildWithCustomContainerResponse> CreateBuildWithCustomContainerAsync(CreateBuildWithCustomContainerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateBuildWithCustomContainerResponse>("/MultiplayerServer/CreateBuildWithCustomContainer", request, extraHeaders);
    }
    public async Task<CreateBuildWithManagedContainerResponse> CreateBuildWithManagedContainerAsync(CreateBuildWithManagedContainerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateBuildWithManagedContainerResponse>("/MultiplayerServer/CreateBuildWithManagedContainer", request, extraHeaders);
    }
    public async Task<CreateBuildWithProcessBasedServerResponse> CreateBuildWithProcessBasedServerAsync(CreateBuildWithProcessBasedServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateBuildWithProcessBasedServerResponse>("/MultiplayerServer/CreateBuildWithProcessBasedServer", request, extraHeaders);
    }
    public async Task<CreateLobbyResult> CreateLobbyAsync(CreateLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateLobbyResult>("/Lobby/CreateLobby", request, extraHeaders);
    }
    public async Task<CreateMatchmakingTicketResult> CreateMatchmakingTicketAsync(CreateMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateMatchmakingTicketResult>("/Match/CreateMatchmakingTicket", request, extraHeaders);
    }
    public async Task<CreateRemoteUserResponse> CreateRemoteUserAsync(CreateRemoteUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateRemoteUserResponse>("/MultiplayerServer/CreateRemoteUser", request, extraHeaders);
    }
    public async Task<CreateScenarioResponse> CreateScenarioAsync(CreateScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateScenarioResponse>("/TrueSkill/CreateScenario", request, extraHeaders);
    }
    public async Task<CreateServerBackfillTicketResult> CreateServerBackfillTicketAsync(CreateServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateServerBackfillTicketResult>("/Match/CreateServerBackfillTicket", request, extraHeaders);
    }
    public async Task<CreateMatchmakingTicketResult> CreateServerMatchmakingTicketAsync(CreateServerMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateMatchmakingTicketResult>("/Match/CreateServerMatchmakingTicket", request, extraHeaders);
    }
    public async Task<CreateTitleMultiplayerServersQuotaChangeResponse> CreateTitleMultiplayerServersQuotaChangeAsync(CreateTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTitleMultiplayerServersQuotaChangeResponse>("/MultiplayerServer/CreateTitleMultiplayerServersQuotaChange", request, extraHeaders);
    }
    public async Task<DeactivateModelResponse> DeactivateModelAsync(DeactivateModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeactivateModelResponse>("/TrueSkill/DeactivateModel", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteAssetAsync(DeleteAssetRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteAsset", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteBuildAsync(DeleteBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteBuild", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteBuildAliasAsync(DeleteBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteBuildAlias", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteBuildRegionAsync(DeleteBuildRegionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteBuildRegion", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteCertificateAsync(DeleteCertificateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteCertificate", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteContainerImageRepositoryAsync(DeleteContainerImageRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteContainerImageRepository", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> DeleteLobbyAsync(DeleteLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/DeleteLobby", request, extraHeaders);
    }
    public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteModelResponse>("/TrueSkill/DeleteModel", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteRemoteUserAsync(DeleteRemoteUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteRemoteUser", request, extraHeaders);
    }
    public async Task<DeleteScenarioResponse> DeleteScenarioAsync(DeleteScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteScenarioResponse>("/TrueSkill/DeleteScenario", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteSecretAsync(DeleteSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/DeleteSecret", request, extraHeaders);
    }
    public async Task<EnableMultiplayerServersForTitleResponse> EnableMultiplayerServersForTitleAsync(EnableMultiplayerServersForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EnableMultiplayerServersForTitleResponse>("/MultiplayerServer/EnableMultiplayerServersForTitle", request, extraHeaders);
    }
    public async Task<EmptyResponse> EnablePartiesForTitleAsync(EnablePartiesForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Party/EnablePartiesForTitle", request, extraHeaders);
    }
    public async Task<FindFriendLobbiesResult> FindFriendLobbiesAsync(FindFriendLobbiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<FindFriendLobbiesResult>("/Lobby/FindFriendLobbies", request, extraHeaders);
    }
    public async Task<FindLobbiesResult> FindLobbiesAsync(FindLobbiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<FindLobbiesResult>("/Lobby/FindLobbies", request, extraHeaders);
    }
    public async Task<GetAssetDownloadUrlResponse> GetAssetDownloadUrlAsync(GetAssetDownloadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAssetDownloadUrlResponse>("/MultiplayerServer/GetAssetDownloadUrl", request, extraHeaders);
    }
    public async Task<GetAssetUploadUrlResponse> GetAssetUploadUrlAsync(GetAssetUploadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAssetUploadUrlResponse>("/MultiplayerServer/GetAssetUploadUrl", request, extraHeaders);
    }
    public async Task<GetBuildResponse> GetBuildAsync(GetBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetBuildResponse>("/MultiplayerServer/GetBuild", request, extraHeaders);
    }
    public async Task<BuildAliasDetailsResponse> GetBuildAliasAsync(GetBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BuildAliasDetailsResponse>("/MultiplayerServer/GetBuildAlias", request, extraHeaders);
    }
    public async Task<GetCognitiveServicesLocalesResponse> GetCognitiveServicesLocalesAsync(GetCognitiveServicesLocalesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCognitiveServicesLocalesResponse>("/MultiplayerServer/GetCognitiveServicesLocales", request, extraHeaders);
    }
    public async Task<GetCognitiveServicesTokenResponse> GetCognitiveServicesTokenAsync(GetCognitiveServicesTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCognitiveServicesTokenResponse>("/MultiplayerServer/GetCognitiveServicesToken", request, extraHeaders);
    }
    public async Task<GetContainerRegistryCredentialsResponse> GetContainerRegistryCredentialsAsync(GetContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetContainerRegistryCredentialsResponse>("/MultiplayerServer/GetContainerRegistryCredentials", request, extraHeaders);
    }
    public async Task<GetLobbyResult> GetLobbyAsync(GetLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLobbyResult>("/Lobby/GetLobby", request, extraHeaders);
    }
    public async Task<GetMatchResult> GetMatchAsync(GetMatchRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMatchResult>("/Match/GetMatch", request, extraHeaders);
    }
    public async Task<GetMatchmakingQueueResult> GetMatchmakingQueueAsync(GetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMatchmakingQueueResult>("/Match/GetMatchmakingQueue", request, extraHeaders);
    }
    public async Task<GetMatchmakingTicketResult> GetMatchmakingTicketAsync(GetMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMatchmakingTicketResult>("/Match/GetMatchmakingTicket", request, extraHeaders);
    }
    public async Task<GetModelDetailsResponse> GetModelDetailsAsync(GetModelDetailsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetModelDetailsResponse>("/TrueSkill/GetModelDetails", request, extraHeaders);
    }
    public async Task<GetModelsByScenarioResponse> GetModelsByScenarioAsync(GetModelsByScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetModelsByScenarioResponse>("/TrueSkill/GetModelsByScenario", request, extraHeaders);
    }
    public async Task<GetMultiplayerServerAndTokenResponse> GetMultiplayerServerAndTokenAsync(GetMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMultiplayerServerAndTokenResponse>("/MultiplayerServer/GetMultiplayerServerAndToken", request, extraHeaders);
    }
    public async Task<GetMultiplayerServerDetailsResponse> GetMultiplayerServerDetailsAsync(GetMultiplayerServerDetailsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMultiplayerServerDetailsResponse>("/MultiplayerServer/GetMultiplayerServerDetails", request, extraHeaders);
    }
    public async Task<GetMultiplayerServerLogsResponse> GetMultiplayerServerLogsAsync(GetMultiplayerServerLogsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMultiplayerServerLogsResponse>("/MultiplayerServer/GetMultiplayerServerLogs", request, extraHeaders);
    }
    public async Task<GetMultiplayerServerLogsResponse> GetMultiplayerSessionLogsBySessionIdAsync(GetMultiplayerSessionLogsBySessionIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMultiplayerServerLogsResponse>("/MultiplayerServer/GetMultiplayerSessionLogsBySessionId", request, extraHeaders);
    }
    public async Task<GetPlayerSkillResponse> GetPlayerSkillAsync(GetPlayerSkillRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSkillResponse>("/TrueSkill/GetPlayerSkill", request, extraHeaders);
    }
    public async Task<GetPlayerSkillForConditionsResponse> GetPlayerSkillForConditionsAsync(GetPlayerSkillForConditionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSkillForConditionsResponse>("/TrueSkill/GetPlayerSkillForConditions", request, extraHeaders);
    }
    public async Task<GetPlayerSkillForConditionsFromModelResponse> GetPlayerSkillForConditionsFromModelAsync(GetPlayerSkillForConditionsFromModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSkillForConditionsFromModelResponse>("/TrueSkill/GetPlayerSkillForConditionsFromModel", request, extraHeaders);
    }
    public async Task<GetPlayerSkillFromModelResponse> GetPlayerSkillFromModelAsync(GetPlayerSkillFromModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSkillFromModelResponse>("/TrueSkill/GetPlayerSkillFromModel", request, extraHeaders);
    }
    public async Task<GetQueueStatisticsResult> GetQueueStatisticsAsync(GetQueueStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetQueueStatisticsResult>("/Match/GetQueueStatistics", request, extraHeaders);
    }
    public async Task<GetRemoteLoginEndpointResponse> GetRemoteLoginEndpointAsync(GetRemoteLoginEndpointRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetRemoteLoginEndpointResponse>("/MultiplayerServer/GetRemoteLoginEndpoint", request, extraHeaders);
    }
    public async Task<GetScenarioConfigurationResponse> GetScenarioConfigurationAsync(GetScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetScenarioConfigurationResponse>("/TrueSkill/GetScenarioConfiguration", request, extraHeaders);
    }
    public async Task<GetScenarioConfigurationsResponse> GetScenarioConfigurationsAsync(GetScenarioConfigurationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetScenarioConfigurationsResponse>("/TrueSkill/GetScenarioConfigurations", request, extraHeaders);
    }
    public async Task<GetServerBackfillTicketResult> GetServerBackfillTicketAsync(GetServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetServerBackfillTicketResult>("/Match/GetServerBackfillTicket", request, extraHeaders);
    }
    public async Task<GetTitleEnabledForMultiplayerServersStatusResponse> GetTitleEnabledForMultiplayerServersStatusAsync(GetTitleEnabledForMultiplayerServersStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleEnabledForMultiplayerServersStatusResponse>("/MultiplayerServer/GetTitleEnabledForMultiplayerServersStatus", request, extraHeaders);
    }
    public async Task<GetTitleMultiplayerServersQuotaChangeResponse> GetTitleMultiplayerServersQuotaChangeAsync(GetTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleMultiplayerServersQuotaChangeResponse>("/MultiplayerServer/GetTitleMultiplayerServersQuotaChange", request, extraHeaders);
    }
    public async Task<GetTitleMultiplayerServersQuotasResponse> GetTitleMultiplayerServersQuotasAsync(GetTitleMultiplayerServersQuotasRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleMultiplayerServersQuotasResponse>("/MultiplayerServer/GetTitleMultiplayerServersQuotas", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> InviteToLobbyAsync(InviteToLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/InviteToLobby", request, extraHeaders);
    }
    public async Task<JoinLobbyResult> JoinArrangedLobbyAsync(JoinArrangedLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<JoinLobbyResult>("/Lobby/JoinArrangedLobby", request, extraHeaders);
    }
    public async Task<JoinLobbyResult> JoinLobbyAsync(JoinLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<JoinLobbyResult>("/Lobby/JoinLobby", request, extraHeaders);
    }
    public async Task<JoinLobbyAsServerResult> JoinLobbyAsServerAsync(JoinLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<JoinLobbyAsServerResult>("/Lobby/JoinLobbyAsServer", request, extraHeaders);
    }
    public async Task<JoinMatchmakingTicketResult> JoinMatchmakingTicketAsync(JoinMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<JoinMatchmakingTicketResult>("/Match/JoinMatchmakingTicket", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> LeaveLobbyAsync(LeaveLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/LeaveLobby", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> LeaveLobbyAsServerAsync(LeaveLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/LeaveLobbyAsServer", request, extraHeaders);
    }
    public async Task<ListMultiplayerServersResponse> ListArchivedMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMultiplayerServersResponse>("/MultiplayerServer/ListArchivedMultiplayerServers", request, extraHeaders);
    }
    public async Task<ListAssetSummariesResponse> ListAssetSummariesAsync(ListAssetSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListAssetSummariesResponse>("/MultiplayerServer/ListAssetSummaries", request, extraHeaders);
    }
    public async Task<ListBuildAliasesResponse> ListBuildAliasesAsync(ListBuildAliasesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListBuildAliasesResponse>("/MultiplayerServer/ListBuildAliases", request, extraHeaders);
    }
    public async Task<ListBuildSummariesResponse> ListBuildSummariesAsync(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListBuildSummariesResponse>("/MultiplayerServer/ListBuildSummaries", request, extraHeaders);
    }
    public async Task<ListBuildSummariesResponse> ListBuildSummariesV2Async(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListBuildSummariesResponse>("/MultiplayerServer/ListBuildSummariesV2", request, extraHeaders);
    }
    public async Task<ListCertificateSummariesResponse> ListCertificateSummariesAsync(ListCertificateSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListCertificateSummariesResponse>("/MultiplayerServer/ListCertificateSummaries", request, extraHeaders);
    }
    public async Task<ListContainerImagesResponse> ListContainerImagesAsync(ListContainerImagesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListContainerImagesResponse>("/MultiplayerServer/ListContainerImages", request, extraHeaders);
    }
    public async Task<ListContainerImageTagsResponse> ListContainerImageTagsAsync(ListContainerImageTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListContainerImageTagsResponse>("/MultiplayerServer/ListContainerImageTags", request, extraHeaders);
    }
    public async Task<ListMatchmakingQueuesResult> ListMatchmakingQueuesAsync(ListMatchmakingQueuesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMatchmakingQueuesResult>("/Match/ListMatchmakingQueues", request, extraHeaders);
    }
    public async Task<ListMatchmakingTicketsForPlayerResult> ListMatchmakingTicketsForPlayerAsync(ListMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMatchmakingTicketsForPlayerResult>("/Match/ListMatchmakingTicketsForPlayer", request, extraHeaders);
    }
    public async Task<ListMultiplayerServersResponse> ListMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMultiplayerServersResponse>("/MultiplayerServer/ListMultiplayerServers", request, extraHeaders);
    }
    public async Task<ListPartyQosServersResponse> ListPartyQosServersAsync(ListPartyQosServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListPartyQosServersResponse>("/MultiplayerServer/ListPartyQosServers", request, extraHeaders);
    }
    public async Task<ListQosServersResponse> ListQosServersAsync(ListQosServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListQosServersResponse>("/MultiplayerServer/ListQosServers", request, extraHeaders);
    }
    public async Task<ListQosServersForTitleResponse> ListQosServersForTitleAsync(ListQosServersForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListQosServersForTitleResponse>("/MultiplayerServer/ListQosServersForTitle", request, extraHeaders);
    }
    public async Task<ListSecretSummariesResponse> ListSecretSummariesAsync(ListSecretSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListSecretSummariesResponse>("/MultiplayerServer/ListSecretSummaries", request, extraHeaders);
    }
    public async Task<ListServerBackfillTicketsForPlayerResult> ListServerBackfillTicketsForPlayerAsync(ListServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListServerBackfillTicketsForPlayerResult>("/Match/ListServerBackfillTicketsForPlayer", request, extraHeaders);
    }
    public async Task<ListTitleMultiplayerServersQuotaChangesResponse> ListTitleMultiplayerServersQuotaChangesAsync(ListTitleMultiplayerServersQuotaChangesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListTitleMultiplayerServersQuotaChangesResponse>("/MultiplayerServer/ListTitleMultiplayerServersQuotaChanges", request, extraHeaders);
    }
    public async Task<ListVirtualMachineSummariesResponse> ListVirtualMachineSummariesAsync(ListVirtualMachineSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListVirtualMachineSummariesResponse>("/MultiplayerServer/ListVirtualMachineSummaries", request, extraHeaders);
    }
    public async Task<RemoveMatchmakingQueueResult> RemoveMatchmakingQueueAsync(RemoveMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveMatchmakingQueueResult>("/Match/RemoveMatchmakingQueue", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> RemoveMemberAsync(RemoveMemberFromLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/RemoveMember", request, extraHeaders);
    }
    public async Task<RequestMultiplayerServerResponse> RequestMultiplayerServerAsync(RequestMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RequestMultiplayerServerResponse>("/MultiplayerServer/RequestMultiplayerServer", request, extraHeaders);
    }
    public async Task<RequestMultiplayerServerAndTokenResponse> RequestMultiplayerServerAndTokenAsync(RequestMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RequestMultiplayerServerAndTokenResponse>("/MultiplayerServer/RequestMultiplayerServerAndToken", request, extraHeaders);
    }
    public async Task<RequestPartyResponse> RequestPartyAsync(RequestPartyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RequestPartyResponse>("/Party/RequestParty", request, extraHeaders);
    }
    public async Task<RequestPartyServiceResponse> RequestPartyServiceAsync(RequestPartyServiceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RequestPartyServiceResponse>("/Party/RequestPartyService", request, extraHeaders);
    }
    public async Task<RolloverContainerRegistryCredentialsResponse> RolloverContainerRegistryCredentialsAsync(RolloverContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RolloverContainerRegistryCredentialsResponse>("/MultiplayerServer/RolloverContainerRegistryCredentials", request, extraHeaders);
    }
    public async Task<SetMatchmakingQueueResult> SetMatchmakingQueueAsync(SetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetMatchmakingQueueResult>("/Match/SetMatchmakingQueue", request, extraHeaders);
    }
    public async Task<EmptyResponse> ShutdownMultiplayerServerAsync(ShutdownMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/ShutdownMultiplayerServer", request, extraHeaders);
    }
    public async Task<SubscribeToLobbyResourceResult> SubscribeToLobbyResourceAsync(SubscribeToLobbyResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SubscribeToLobbyResourceResult>("/Lobby/SubscribeToLobbyResource", request, extraHeaders);
    }
    public async Task<SubscribeToMatchResourceResult> SubscribeToMatchmakingResourceAsync(SubscribeToMatchResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SubscribeToMatchResourceResult>("/Match/SubscribeToMatchmakingResource", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> UnsubscribeFromLobbyResourceAsync(UnsubscribeFromLobbyResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/UnsubscribeFromLobbyResource", request, extraHeaders);
    }
    public async Task<UnsubscribeFromMatchResourceResult> UnsubscribeFromMatchmakingResourceAsync(UnsubscribeFromMatchResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnsubscribeFromMatchResourceResult>("/Match/UnsubscribeFromMatchmakingResource", request, extraHeaders);
    }
    public async Task<EmptyResponse> UntagContainerImageAsync(UntagContainerImageRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UntagContainerImage", request, extraHeaders);
    }
    public async Task<BuildAliasDetailsResponse> UpdateBuildAliasAsync(UpdateBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BuildAliasDetailsResponse>("/MultiplayerServer/UpdateBuildAlias", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateBuildNameAsync(UpdateBuildNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UpdateBuildName", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateBuildRegionAsync(UpdateBuildRegionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UpdateBuildRegion", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateBuildRegionsAsync(UpdateBuildRegionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UpdateBuildRegions", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> UpdateLobbyAsync(UpdateLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/UpdateLobby", request, extraHeaders);
    }
    public async Task<LobbyEmptyResult> UpdateLobbyAsServerAsync(UpdateLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LobbyEmptyResult>("/Lobby/UpdateLobbyAsServer", request, extraHeaders);
    }
    public async Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateModelResponse>("/TrueSkill/UpdateModel", request, extraHeaders);
    }
    public async Task<UpdatePrimaryModelResponse> UpdatePrimaryModelAsync(UpdatePrimaryModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePrimaryModelResponse>("/TrueSkill/UpdatePrimaryModel", request, extraHeaders);
    }
    public async Task<UpdateScenarioConfigurationResponse> UpdateScenarioConfigurationAsync(UpdateScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateScenarioConfigurationResponse>("/TrueSkill/UpdateScenarioConfiguration", request, extraHeaders);
    }
    public async Task<EmptyResponse> UploadCertificateAsync(UploadCertificateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UploadCertificate", request, extraHeaders);
    }
    public async Task<UploadMatchResultResponse> UploadMatchResultAsync(UploadMatchResultRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UploadMatchResultResponse>("/TrueSkill/UploadMatchResult", request, extraHeaders);
    }
    public async Task<EmptyResponse> UploadSecretAsync(UploadSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/MultiplayerServer/UploadSecret", request, extraHeaders);
    }
}