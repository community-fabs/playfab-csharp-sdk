using CommunityFabs.NET.Sdk.Models.Admin;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabAdminInstanceApi : PlayFabBaseInstanceApi, IPlayFabAdminApi {
    public PlayFabAdminInstanceApi() : base() { }
    public PlayFabAdminInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabAdminInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabAdminInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<EmptyResponse> AbortTaskInstanceAsync(AbortTaskInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/AbortTaskInstance", request, extraHeaders);
    }
    public async Task<AddLocalizedNewsResult> AddLocalizedNewsAsync(AddLocalizedNewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddLocalizedNewsResult>("/Admin/AddLocalizedNews", request, extraHeaders);
    }
    public async Task<AddNewsResult> AddNewsAsync(AddNewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddNewsResult>("/Admin/AddNews", request, extraHeaders);
    }
    public async Task<AddPlayerTagResult> AddPlayerTagAsync(AddPlayerTagRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddPlayerTagResult>("/Admin/AddPlayerTag", request, extraHeaders);
    }
    public async Task<AddServerBuildResult> AddServerBuildAsync(AddServerBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddServerBuildResult>("/Admin/AddServerBuild", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Admin/AddUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<BlankResult> AddVirtualCurrencyTypesAsync(AddVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BlankResult>("/Admin/AddVirtualCurrencyTypes", request, extraHeaders);
    }
    public async Task<BanUsersResult> BanUsersAsync(BanUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BanUsersResult>("/Admin/BanUsers", request, extraHeaders);
    }
    public async Task<CheckLimitedEditionItemAvailabilityResult> CheckLimitedEditionItemAvailabilityAsync(CheckLimitedEditionItemAvailabilityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CheckLimitedEditionItemAvailabilityResult>("/Admin/CheckLimitedEditionItemAvailability", request, extraHeaders);
    }
    public async Task<CreateTaskResult> CreateActionsOnPlayersInSegmentTaskAsync(CreateActionsOnPlayerSegmentTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTaskResult>("/Admin/CreateActionsOnPlayersInSegmentTask", request, extraHeaders);
    }
    public async Task<CreateTaskResult> CreateCloudScriptAzureFunctionsTaskAsync(CreateCloudScriptAzureFunctionsTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTaskResult>("/Admin/CreateCloudScriptAzureFunctionsTask", request, extraHeaders);
    }
    public async Task<CreateTaskResult> CreateCloudScriptTaskAsync(CreateCloudScriptTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTaskResult>("/Admin/CreateCloudScriptTask", request, extraHeaders);
    }
    public async Task<CreateTaskResult> CreateInsightsScheduledScalingTaskAsync(CreateInsightsScheduledScalingTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTaskResult>("/Admin/CreateInsightsScheduledScalingTask", request, extraHeaders);
    }
    public async Task<EmptyResponse> CreateOpenIdConnectionAsync(CreateOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/CreateOpenIdConnection", request, extraHeaders);
    }
    public async Task<CreatePlayerSharedSecretResult> CreatePlayerSharedSecretAsync(CreatePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreatePlayerSharedSecretResult>("/Admin/CreatePlayerSharedSecret", request, extraHeaders);
    }
    public async Task<CreatePlayerStatisticDefinitionResult> CreatePlayerStatisticDefinitionAsync(CreatePlayerStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreatePlayerStatisticDefinitionResult>("/Admin/CreatePlayerStatisticDefinition", request, extraHeaders);
    }
    public async Task<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateSegmentResponse>("/Admin/CreateSegment", request, extraHeaders);
    }
    public async Task<BlankResult> DeleteContentAsync(DeleteContentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BlankResult>("/Admin/DeleteContent", request, extraHeaders);
    }
    public async Task<DeleteEventSinkResult> DeleteEventSinkAsync(DeleteEventSinkRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteEventSinkResult>("/Admin/DeleteEventSink", request, extraHeaders);
    }
    public async Task<DeleteMasterPlayerAccountResult> DeleteMasterPlayerAccountAsync(DeleteMasterPlayerAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteMasterPlayerAccountResult>("/Admin/DeleteMasterPlayerAccount", request, extraHeaders);
    }
    public async Task<DeleteMasterPlayerEventDataResult> DeleteMasterPlayerEventDataAsync(DeleteMasterPlayerEventDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteMasterPlayerEventDataResult>("/Admin/DeleteMasterPlayerEventData", request, extraHeaders);
    }
    public async Task<DeleteMembershipSubscriptionResult> DeleteMembershipSubscriptionAsync(DeleteMembershipSubscriptionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteMembershipSubscriptionResult>("/Admin/DeleteMembershipSubscription", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteOpenIdConnectionAsync(DeleteOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/DeleteOpenIdConnection", request, extraHeaders);
    }
    public async Task<DeletePlayerResult> DeletePlayerAsync(DeletePlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerResult>("/Admin/DeletePlayer", request, extraHeaders);
    }
    public async Task<DeletePlayerCustomPropertiesResult> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerCustomPropertiesResult>("/Admin/DeletePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<DeletePlayerSharedSecretResult> DeletePlayerSharedSecretAsync(DeletePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerSharedSecretResult>("/Admin/DeletePlayerSharedSecret", request, extraHeaders);
    }
    public async Task<DeleteSegmentsResponse> DeleteSegmentAsync(DeleteSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteSegmentsResponse>("/Admin/DeleteSegment", request, extraHeaders);
    }
    public async Task<DeleteStoreResult> DeleteStoreAsync(DeleteStoreRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteStoreResult>("/Admin/DeleteStore", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteTaskAsync(DeleteTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/DeleteTask", request, extraHeaders);
    }
    public async Task<DeleteTitleResult> DeleteTitleAsync(DeleteTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteTitleResult>("/Admin/DeleteTitle", request, extraHeaders);
    }
    public async Task<DeleteTitleDataOverrideResult> DeleteTitleDataOverrideAsync(DeleteTitleDataOverrideRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteTitleDataOverrideResult>("/Admin/DeleteTitleDataOverride", request, extraHeaders);
    }
    public async Task<DeleteUsersResult> DeleteUsersAsync(DeleteUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteUsersResult>("/Admin/DeleteUsers", request, extraHeaders);
    }
    public async Task<ExportMasterPlayerDataResult> ExportMasterPlayerDataAsync(ExportMasterPlayerDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExportMasterPlayerDataResult>("/Admin/ExportMasterPlayerData", request, extraHeaders);
    }
    public async Task<ExportPlayersInSegmentResult> ExportPlayersInSegmentAsync(ExportPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExportPlayersInSegmentResult>("/Admin/ExportPlayersInSegment", request, extraHeaders);
    }
    public async Task<GetActionsOnPlayersInSegmentTaskInstanceResult> GetActionsOnPlayersInSegmentTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetActionsOnPlayersInSegmentTaskInstanceResult>("/Admin/GetActionsOnPlayersInSegmentTaskInstance", request, extraHeaders);
    }
    public async Task<GetAllActionGroupsResult> GetAllActionGroupsAsync(GetAllActionGroupsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAllActionGroupsResult>("/Admin/GetAllActionGroups", request, extraHeaders);
    }
    public async Task<GetAllSegmentsResult> GetAllSegmentsAsync(GetAllSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAllSegmentsResult>("/Admin/GetAllSegments", request, extraHeaders);
    }
    public async Task<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCatalogItemsResult>("/Admin/GetCatalogItems", request, extraHeaders);
    }
    public async Task<GetCloudScriptAzureFunctionsTaskInstanceResult> GetCloudScriptAzureFunctionsTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCloudScriptAzureFunctionsTaskInstanceResult>("/Admin/GetCloudScriptAzureFunctionsTaskInstance", request, extraHeaders);
    }
    public async Task<GetCloudScriptRevisionResult> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCloudScriptRevisionResult>("/Admin/GetCloudScriptRevision", request, extraHeaders);
    }
    public async Task<GetCloudScriptTaskInstanceResult> GetCloudScriptTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCloudScriptTaskInstanceResult>("/Admin/GetCloudScriptTaskInstance", request, extraHeaders);
    }
    public async Task<GetCloudScriptVersionsResult> GetCloudScriptVersionsAsync(GetCloudScriptVersionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCloudScriptVersionsResult>("/Admin/GetCloudScriptVersions", request, extraHeaders);
    }
    public async Task<GetContentListResult> GetContentListAsync(GetContentListRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetContentListResult>("/Admin/GetContentList", request, extraHeaders);
    }
    public async Task<GetContentUploadUrlResult> GetContentUploadUrlAsync(GetContentUploadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetContentUploadUrlResult>("/Admin/GetContentUploadUrl", request, extraHeaders);
    }
    public async Task<GetDataReportResult> GetDataReportAsync(GetDataReportRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetDataReportResult>("/Admin/GetDataReport", request, extraHeaders);
    }
    public async Task<GetEventSinksResult> GetEventSinksAsync(GetEventSinksRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEventSinksResult>("/Admin/GetEventSinks", request, extraHeaders);
    }
    public async Task<GetMatchmakerGameInfoResult> GetMatchmakerGameInfoAsync(GetMatchmakerGameInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMatchmakerGameInfoResult>("/Admin/GetMatchmakerGameInfo", request, extraHeaders);
    }
    public async Task<GetMatchmakerGameModesResult> GetMatchmakerGameModesAsync(GetMatchmakerGameModesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMatchmakerGameModesResult>("/Admin/GetMatchmakerGameModes", request, extraHeaders);
    }
    public async Task<GetPlayedTitleListResult> GetPlayedTitleListAsync(GetPlayedTitleListRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayedTitleListResult>("/Admin/GetPlayedTitleList", request, extraHeaders);
    }
    public async Task<GetPlayerCustomPropertyResult> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerCustomPropertyResult>("/Admin/GetPlayerCustomProperty", request, extraHeaders);
    }
    public async Task<GetPlayerIdFromAuthTokenResult> GetPlayerIdFromAuthTokenAsync(GetPlayerIdFromAuthTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerIdFromAuthTokenResult>("/Admin/GetPlayerIdFromAuthToken", request, extraHeaders);
    }
    public async Task<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerProfileResult>("/Admin/GetPlayerProfile", request, extraHeaders);
    }
    public async Task<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSegmentsResult>("/Admin/GetPlayerSegments", request, extraHeaders);
    }
    public async Task<GetPlayerSharedSecretsResult> GetPlayerSharedSecretsAsync(GetPlayerSharedSecretsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSharedSecretsResult>("/Admin/GetPlayerSharedSecrets", request, extraHeaders);
    }
    public async Task<GetPlayersInSegmentResult> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayersInSegmentResult>("/Admin/GetPlayersInSegment", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticDefinitionsResult> GetPlayerStatisticDefinitionsAsync(GetPlayerStatisticDefinitionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticDefinitionsResult>("/Admin/GetPlayerStatisticDefinitions", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticVersionsResult>("/Admin/GetPlayerStatisticVersions", request, extraHeaders);
    }
    public async Task<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerTagsResult>("/Admin/GetPlayerTags", request, extraHeaders);
    }
    public async Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPolicyResponse>("/Admin/GetPolicy", request, extraHeaders);
    }
    public async Task<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPublisherDataResult>("/Admin/GetPublisherData", request, extraHeaders);
    }
    public async Task<GetRandomResultTablesResult> GetRandomResultTablesAsync(GetRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetRandomResultTablesResult>("/Admin/GetRandomResultTables", request, extraHeaders);
    }
    public async Task<GetPlayersInSegmentExportResponse> GetSegmentExportAsync(GetPlayersInSegmentExportRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayersInSegmentExportResponse>("/Admin/GetSegmentExport", request, extraHeaders);
    }
    public async Task<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetSegmentsResponse>("/Admin/GetSegments", request, extraHeaders);
    }
    public async Task<GetServerBuildInfoResult> GetServerBuildInfoAsync(GetServerBuildInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetServerBuildInfoResult>("/Admin/GetServerBuildInfo", request, extraHeaders);
    }
    public async Task<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStoreItemsResult>("/Admin/GetStoreItems", request, extraHeaders);
    }
    public async Task<GetTaskInstancesResult> GetTaskInstancesAsync(GetTaskInstancesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTaskInstancesResult>("/Admin/GetTaskInstances", request, extraHeaders);
    }
    public async Task<GetTasksResult> GetTasksAsync(GetTasksRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTasksResult>("/Admin/GetTasks", request, extraHeaders);
    }
    public async Task<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleDataResult>("/Admin/GetTitleData", request, extraHeaders);
    }
    public async Task<GetTitleDataResult> GetTitleInternalDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleDataResult>("/Admin/GetTitleInternalData", request, extraHeaders);
    }
    public async Task<LookupUserAccountInfoResult> GetUserAccountInfoAsync(LookupUserAccountInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LookupUserAccountInfoResult>("/Admin/GetUserAccountInfo", request, extraHeaders);
    }
    public async Task<GetUserBansResult> GetUserBansAsync(GetUserBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserBansResult>("/Admin/GetUserBans", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserInternalData", request, extraHeaders);
    }
    public async Task<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserInventoryResult>("/Admin/GetUserInventory", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserPublisherData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserPublisherInternalData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserPublisherReadOnlyData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Admin/GetUserReadOnlyData", request, extraHeaders);
    }
    public async Task<GrantItemsToUsersResult> GrantItemsToUsersAsync(GrantItemsToUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantItemsToUsersResult>("/Admin/GrantItemsToUsers", request, extraHeaders);
    }
    public async Task<IncrementLimitedEditionItemAvailabilityResult> IncrementLimitedEditionItemAvailabilityAsync(IncrementLimitedEditionItemAvailabilityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IncrementLimitedEditionItemAvailabilityResult>("/Admin/IncrementLimitedEditionItemAvailability", request, extraHeaders);
    }
    public async Task<IncrementPlayerStatisticVersionResult> IncrementPlayerStatisticVersionAsync(IncrementPlayerStatisticVersionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IncrementPlayerStatisticVersionResult>("/Admin/IncrementPlayerStatisticVersion", request, extraHeaders);
    }
    public async Task<ListOpenIdConnectionResponse> ListOpenIdConnectionAsync(ListOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListOpenIdConnectionResponse>("/Admin/ListOpenIdConnection", request, extraHeaders);
    }
    public async Task<ListPlayerCustomPropertiesResult> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListPlayerCustomPropertiesResult>("/Admin/ListPlayerCustomProperties", request, extraHeaders);
    }
    public async Task<ListBuildsResult> ListServerBuildsAsync(ListBuildsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListBuildsResult>("/Admin/ListServerBuilds", request, extraHeaders);
    }
    public async Task<ListVirtualCurrencyTypesResult> ListVirtualCurrencyTypesAsync(ListVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListVirtualCurrencyTypesResult>("/Admin/ListVirtualCurrencyTypes", request, extraHeaders);
    }
    public async Task<ModifyMatchmakerGameModesResult> ModifyMatchmakerGameModesAsync(ModifyMatchmakerGameModesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyMatchmakerGameModesResult>("/Admin/ModifyMatchmakerGameModes", request, extraHeaders);
    }
    public async Task<ModifyServerBuildResult> ModifyServerBuildAsync(ModifyServerBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyServerBuildResult>("/Admin/ModifyServerBuild", request, extraHeaders);
    }
    public async Task<RefundPurchaseResponse> RefundPurchaseAsync(RefundPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RefundPurchaseResponse>("/Admin/RefundPurchase", request, extraHeaders);
    }
    public async Task<RemovePlayerTagResult> RemovePlayerTagAsync(RemovePlayerTagRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemovePlayerTagResult>("/Admin/RemovePlayerTag", request, extraHeaders);
    }
    public async Task<RemoveServerBuildResult> RemoveServerBuildAsync(RemoveServerBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveServerBuildResult>("/Admin/RemoveServerBuild", request, extraHeaders);
    }
    public async Task<BlankResult> RemoveVirtualCurrencyTypesAsync(RemoveVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BlankResult>("/Admin/RemoveVirtualCurrencyTypes", request, extraHeaders);
    }
    public async Task<ResetCharacterStatisticsResult> ResetCharacterStatisticsAsync(ResetCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ResetCharacterStatisticsResult>("/Admin/ResetCharacterStatistics", request, extraHeaders);
    }
    public async Task<ResetPasswordResult> ResetPasswordAsync(ResetPasswordRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ResetPasswordResult>("/Admin/ResetPassword", request, extraHeaders);
    }
    public async Task<BlankResult> ResetUsersAsync(ResetUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BlankResult>("/Admin/ResetUsers", request, extraHeaders);
    }
    public async Task<ResetUserStatisticsResult> ResetUserStatisticsAsync(ResetUserStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ResetUserStatisticsResult>("/Admin/ResetUserStatistics", request, extraHeaders);
    }
    public async Task<ResolvePurchaseDisputeResponse> ResolvePurchaseDisputeAsync(ResolvePurchaseDisputeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ResolvePurchaseDisputeResponse>("/Admin/ResolvePurchaseDispute", request, extraHeaders);
    }
    public async Task<RevokeAllBansForUserResult> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeAllBansForUserResult>("/Admin/RevokeAllBansForUser", request, extraHeaders);
    }
    public async Task<RevokeBansResult> RevokeBansAsync(RevokeBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeBansResult>("/Admin/RevokeBans", request, extraHeaders);
    }
    public async Task<RevokeInventoryResult> RevokeInventoryItemAsync(RevokeInventoryItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeInventoryResult>("/Admin/RevokeInventoryItem", request, extraHeaders);
    }
    public async Task<RevokeInventoryItemsResult> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeInventoryItemsResult>("/Admin/RevokeInventoryItems", request, extraHeaders);
    }
    public async Task<RunTaskResult> RunTaskAsync(RunTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RunTaskResult>("/Admin/RunTask", request, extraHeaders);
    }
    public async Task<SendAccountRecoveryEmailResult> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendAccountRecoveryEmailResult>("/Admin/SendAccountRecoveryEmail", request, extraHeaders);
    }
    public async Task<UpdateCatalogItemsResult> SetCatalogItemsAsync(UpdateCatalogItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCatalogItemsResult>("/Admin/SetCatalogItems", request, extraHeaders);
    }
    public async Task<SetEventSinkResult> SetEventSinkAsync(SetEventSinkRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetEventSinkResult>("/Admin/SetEventSink", request, extraHeaders);
    }
    public async Task<SetMembershipOverrideResult> SetMembershipOverrideAsync(SetMembershipOverrideRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetMembershipOverrideResult>("/Admin/SetMembershipOverride", request, extraHeaders);
    }
    public async Task<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPlayerSecretResult>("/Admin/SetPlayerSecret", request, extraHeaders);
    }
    public async Task<SetPublishedRevisionResult> SetPublishedRevisionAsync(SetPublishedRevisionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPublishedRevisionResult>("/Admin/SetPublishedRevision", request, extraHeaders);
    }
    public async Task<SetPublisherDataResult> SetPublisherDataAsync(SetPublisherDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPublisherDataResult>("/Admin/SetPublisherData", request, extraHeaders);
    }
    public async Task<UpdateStoreItemsResult> SetStoreItemsAsync(UpdateStoreItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateStoreItemsResult>("/Admin/SetStoreItems", request, extraHeaders);
    }
    public async Task<SetTitleDataResult> SetTitleDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTitleDataResult>("/Admin/SetTitleData", request, extraHeaders);
    }
    public async Task<SetTitleDataAndOverridesResult> SetTitleDataAndOverridesAsync(SetTitleDataAndOverridesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTitleDataAndOverridesResult>("/Admin/SetTitleDataAndOverrides", request, extraHeaders);
    }
    public async Task<SetTitleDataResult> SetTitleInternalDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTitleDataResult>("/Admin/SetTitleInternalData", request, extraHeaders);
    }
    public async Task<SetupPushNotificationResult> SetupPushNotificationAsync(SetupPushNotificationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetupPushNotificationResult>("/Admin/SetupPushNotification", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Admin/SubtractUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<UpdateBansResult> UpdateBansAsync(UpdateBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateBansResult>("/Admin/UpdateBans", request, extraHeaders);
    }
    public async Task<UpdateCatalogItemsResult> UpdateCatalogItemsAsync(UpdateCatalogItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCatalogItemsResult>("/Admin/UpdateCatalogItems", request, extraHeaders);
    }
    public async Task<UpdateCloudScriptResult> UpdateCloudScriptAsync(UpdateCloudScriptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCloudScriptResult>("/Admin/UpdateCloudScript", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateOpenIdConnectionAsync(UpdateOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/UpdateOpenIdConnection", request, extraHeaders);
    }
    public async Task<UpdatePlayerCustomPropertiesResult> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerCustomPropertiesResult>("/Admin/UpdatePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<UpdatePlayerSharedSecretResult> UpdatePlayerSharedSecretAsync(UpdatePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerSharedSecretResult>("/Admin/UpdatePlayerSharedSecret", request, extraHeaders);
    }
    public async Task<UpdatePlayerStatisticDefinitionResult> UpdatePlayerStatisticDefinitionAsync(UpdatePlayerStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerStatisticDefinitionResult>("/Admin/UpdatePlayerStatisticDefinition", request, extraHeaders);
    }
    public async Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePolicyResponse>("/Admin/UpdatePolicy", request, extraHeaders);
    }
    public async Task<UpdateRandomResultTablesResult> UpdateRandomResultTablesAsync(UpdateRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateRandomResultTablesResult>("/Admin/UpdateRandomResultTables", request, extraHeaders);
    }
    public async Task<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateSegmentResponse>("/Admin/UpdateSegment", request, extraHeaders);
    }
    public async Task<UpdateStoreItemsResult> UpdateStoreItemsAsync(UpdateStoreItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateStoreItemsResult>("/Admin/UpdateStoreItems", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateTaskAsync(UpdateTaskRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Admin/UpdateTask", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserInternalData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserPublisherData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserPublisherInternalData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserPublisherReadOnlyData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Admin/UpdateUserReadOnlyData", request, extraHeaders);
    }
    public async Task<UpdateUserTitleDisplayNameResult> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserTitleDisplayNameResult>("/Admin/UpdateUserTitleDisplayName", request, extraHeaders);
    }
}