using CommunityFabs.NET.Sdk.Models.Server;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabServerInstanceApi : PlayFabBaseInstanceApi, IPlayFabServerApi {
    public PlayFabServerInstanceApi() : base() { }
    public PlayFabServerInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabServerInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabServerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<ModifyCharacterVirtualCurrencyResult> AddCharacterVirtualCurrencyAsync(AddCharacterVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyCharacterVirtualCurrencyResult>("/Server/AddCharacterVirtualCurrency", request, extraHeaders);
    }
    public async Task<EmptyResponse> AddFriendAsync(AddFriendRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/AddFriend", request, extraHeaders);
    }
    public async Task<EmptyResult> AddGenericIDAsync(AddGenericIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Server/AddGenericID", request, extraHeaders);
    }
    public async Task<AddPlayerTagResult> AddPlayerTagAsync(AddPlayerTagRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddPlayerTagResult>("/Server/AddPlayerTag", request, extraHeaders);
    }
    public async Task<AddSharedGroupMembersResult> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddSharedGroupMembersResult>("/Server/AddSharedGroupMembers", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Server/AddUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<AuthenticateSessionTicketResult> AuthenticateSessionTicketAsync(AuthenticateSessionTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AuthenticateSessionTicketResult>("/Server/AuthenticateSessionTicket", request, extraHeaders);
    }
    public async Task<AwardSteamAchievementResult> AwardSteamAchievementAsync(AwardSteamAchievementRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AwardSteamAchievementResult>("/Server/AwardSteamAchievement", request, extraHeaders);
    }
    public async Task<BanUsersResult> BanUsersAsync(BanUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<BanUsersResult>("/Server/BanUsers", request, extraHeaders);
    }
    public async Task<ConsumeItemResult> ConsumeItemAsync(ConsumeItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumeItemResult>("/Server/ConsumeItem", request, extraHeaders);
    }
    public async Task<CreateSharedGroupResult> CreateSharedGroupAsync(CreateSharedGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateSharedGroupResult>("/Server/CreateSharedGroup", request, extraHeaders);
    }
    public async Task<DeleteCharacterFromUserResult> DeleteCharacterFromUserAsync(DeleteCharacterFromUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteCharacterFromUserResult>("/Server/DeleteCharacterFromUser", request, extraHeaders);
    }
    public async Task<DeletePlayerResult> DeletePlayerAsync(DeletePlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerResult>("/Server/DeletePlayer", request, extraHeaders);
    }
    public async Task<DeletePlayerCustomPropertiesResult> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerCustomPropertiesResult>("/Server/DeletePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<DeletePushNotificationTemplateResult> DeletePushNotificationTemplateAsync(DeletePushNotificationTemplateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePushNotificationTemplateResult>("/Server/DeletePushNotificationTemplate", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteSharedGroupAsync(DeleteSharedGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/DeleteSharedGroup", request, extraHeaders);
    }
    public async Task<DeleteUsersResult> DeleteUsersAsync(DeleteUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteUsersResult>("/Server/DeleteUsers", request, extraHeaders);
    }
    public async Task<DeregisterGameResponse> DeregisterGameAsync(DeregisterGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeregisterGameResponse>("/Server/DeregisterGame", request, extraHeaders);
    }
    public async Task<EvaluateRandomResultTableResult> EvaluateRandomResultTableAsync(EvaluateRandomResultTableRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EvaluateRandomResultTableResult>("/Server/EvaluateRandomResultTable", request, extraHeaders);
    }
    public async Task<ExecuteCloudScriptResult> ExecuteCloudScriptAsync(ExecuteCloudScriptServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteCloudScriptResult>("/Server/ExecuteCloudScript", request, extraHeaders);
    }
    public async Task<GetAllActionGroupsResult> GetAllActionGroupsAsync(GetAllActionGroupsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAllActionGroupsResult>("/Server/GetAllActionGroups", request, extraHeaders);
    }
    public async Task<GetAllSegmentsResult> GetAllSegmentsAsync(GetAllSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAllSegmentsResult>("/Server/GetAllSegments", request, extraHeaders);
    }
    public async Task<ListUsersCharactersResult> GetAllUsersCharactersAsync(ListUsersCharactersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListUsersCharactersResult>("/Server/GetAllUsersCharacters", request, extraHeaders);
    }
    public async Task<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCatalogItemsResult>("/Server/GetCatalogItems", request, extraHeaders);
    }
    public async Task<GetCharacterDataResult> GetCharacterDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterDataResult>("/Server/GetCharacterData", request, extraHeaders);
    }
    public async Task<GetCharacterDataResult> GetCharacterInternalDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterDataResult>("/Server/GetCharacterInternalData", request, extraHeaders);
    }
    public async Task<GetCharacterInventoryResult> GetCharacterInventoryAsync(GetCharacterInventoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterInventoryResult>("/Server/GetCharacterInventory", request, extraHeaders);
    }
    public async Task<GetCharacterLeaderboardResult> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterLeaderboardResult>("/Server/GetCharacterLeaderboard", request, extraHeaders);
    }
    public async Task<GetCharacterDataResult> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterDataResult>("/Server/GetCharacterReadOnlyData", request, extraHeaders);
    }
    public async Task<GetCharacterStatisticsResult> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterStatisticsResult>("/Server/GetCharacterStatistics", request, extraHeaders);
    }
    public async Task<GetContentDownloadUrlResult> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetContentDownloadUrlResult>("/Server/GetContentDownloadUrl", request, extraHeaders);
    }
    public async Task<GetLeaderboardResult> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardResult>("/Server/GetFriendLeaderboard", request, extraHeaders);
    }
    public async Task<GetFriendsListResult> GetFriendsListAsync(GetFriendsListRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFriendsListResult>("/Server/GetFriendsList", request, extraHeaders);
    }
    public async Task<GetLeaderboardResult> GetLeaderboardAsync(GetLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardResult>("/Server/GetLeaderboard", request, extraHeaders);
    }
    public async Task<GetLeaderboardAroundCharacterResult> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardAroundCharacterResult>("/Server/GetLeaderboardAroundCharacter", request, extraHeaders);
    }
    public async Task<GetLeaderboardAroundUserResult> GetLeaderboardAroundUserAsync(GetLeaderboardAroundUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardAroundUserResult>("/Server/GetLeaderboardAroundUser", request, extraHeaders);
    }
    public async Task<GetLeaderboardForUsersCharactersResult> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardForUsersCharactersResult>("/Server/GetLeaderboardForUserCharacters", request, extraHeaders);
    }
    public async Task<GetPlayerCombinedInfoResult> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerCombinedInfoResult>("/Server/GetPlayerCombinedInfo", request, extraHeaders);
    }
    public async Task<GetPlayerCustomPropertyResult> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerCustomPropertyResult>("/Server/GetPlayerCustomProperty", request, extraHeaders);
    }
    public async Task<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerProfileResult>("/Server/GetPlayerProfile", request, extraHeaders);
    }
    public async Task<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSegmentsResult>("/Server/GetPlayerSegments", request, extraHeaders);
    }
    public async Task<GetPlayersInSegmentResult> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayersInSegmentResult>("/Server/GetPlayersInSegment", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticsResult> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticsResult>("/Server/GetPlayerStatistics", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticVersionsResult>("/Server/GetPlayerStatisticVersions", request, extraHeaders);
    }
    public async Task<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerTagsResult>("/Server/GetPlayerTags", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromBattleNetAccountIdsResult> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromBattleNetAccountIdsResult>("/Server/GetPlayFabIDsFromBattleNetAccountIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromFacebookIDsResult> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromFacebookIDsResult>("/Server/GetPlayFabIDsFromFacebookIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromFacebookInstantGamesIdsResult> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromFacebookInstantGamesIdsResult>("/Server/GetPlayFabIDsFromFacebookInstantGamesIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromGenericIDsResult> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromGenericIDsResult>("/Server/GetPlayFabIDsFromGenericIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromNintendoServiceAccountIdsResult> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromNintendoServiceAccountIdsResult>("/Server/GetPlayFabIDsFromNintendoServiceAccountIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>("/Server/GetPlayFabIDsFromNintendoSwitchDeviceIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromPSNAccountIDsResult> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromPSNAccountIDsResult>("/Server/GetPlayFabIDsFromPSNAccountIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromPSNOnlineIDsResult> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromPSNOnlineIDsResult>("/Server/GetPlayFabIDsFromPSNOnlineIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromSteamIDsResult> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromSteamIDsResult>("/Server/GetPlayFabIDsFromSteamIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromSteamNamesResult> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromSteamNamesResult>("/Server/GetPlayFabIDsFromSteamNames", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromTwitchIDsResult> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromTwitchIDsResult>("/Server/GetPlayFabIDsFromTwitchIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromXboxLiveIDsResult> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromXboxLiveIDsResult>("/Server/GetPlayFabIDsFromXboxLiveIDs", request, extraHeaders);
    }
    public async Task<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPublisherDataResult>("/Server/GetPublisherData", request, extraHeaders);
    }
    public async Task<GetRandomResultTablesResult> GetRandomResultTablesAsync(GetRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetRandomResultTablesResult>("/Server/GetRandomResultTables", request, extraHeaders);
    }
    public async Task<GetServerCustomIDsFromPlayFabIDsResult> GetServerCustomIDsFromPlayFabIDsAsync(GetServerCustomIDsFromPlayFabIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetServerCustomIDsFromPlayFabIDsResult>("/Server/GetServerCustomIDsFromPlayFabIDs", request, extraHeaders);
    }
    public async Task<GetSharedGroupDataResult> GetSharedGroupDataAsync(GetSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetSharedGroupDataResult>("/Server/GetSharedGroupData", request, extraHeaders);
    }
    public async Task<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStoreItemsResult>("/Server/GetStoreItems", request, extraHeaders);
    }
    public async Task<GetTimeResult> GetTimeAsync(GetTimeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTimeResult>("/Server/GetTime", request, extraHeaders);
    }
    public async Task<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleDataResult>("/Server/GetTitleData", request, extraHeaders);
    }
    public async Task<GetTitleDataResult> GetTitleInternalDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleDataResult>("/Server/GetTitleInternalData", request, extraHeaders);
    }
    public async Task<GetTitleNewsResult> GetTitleNewsAsync(GetTitleNewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleNewsResult>("/Server/GetTitleNews", request, extraHeaders);
    }
    public async Task<GetUserAccountInfoResult> GetUserAccountInfoAsync(GetUserAccountInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserAccountInfoResult>("/Server/GetUserAccountInfo", request, extraHeaders);
    }
    public async Task<GetUserBansResult> GetUserBansAsync(GetUserBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserBansResult>("/Server/GetUserBans", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserInternalData", request, extraHeaders);
    }
    public async Task<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserInventoryResult>("/Server/GetUserInventory", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserPublisherData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserPublisherInternalData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserPublisherReadOnlyData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Server/GetUserReadOnlyData", request, extraHeaders);
    }
    public async Task<GetUserStatisticsResult> GetUserStatisticsAsync(GetUserStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserStatisticsResult>("/Server/GetUserStatistics", request, extraHeaders);
    }
    public async Task<GrantCharacterToUserResult> GrantCharacterToUserAsync(GrantCharacterToUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantCharacterToUserResult>("/Server/GrantCharacterToUser", request, extraHeaders);
    }
    public async Task<GrantItemsToCharacterResult> GrantItemsToCharacterAsync(GrantItemsToCharacterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantItemsToCharacterResult>("/Server/GrantItemsToCharacter", request, extraHeaders);
    }
    public async Task<GrantItemsToUserResult> GrantItemsToUserAsync(GrantItemsToUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantItemsToUserResult>("/Server/GrantItemsToUser", request, extraHeaders);
    }
    public async Task<GrantItemsToUsersResult> GrantItemsToUsersAsync(GrantItemsToUsersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantItemsToUsersResult>("/Server/GrantItemsToUsers", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Server/LinkBattleNetAccount", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Server/LinkNintendoServiceAccount", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkNintendoServiceAccountSubjectAsync(LinkNintendoServiceAccountSubjectRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Server/LinkNintendoServiceAccountSubject", request, extraHeaders);
    }
    public async Task<LinkNintendoSwitchDeviceIdResult> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkNintendoSwitchDeviceIdResult>("/Server/LinkNintendoSwitchDeviceId", request, extraHeaders);
    }
    public async Task<LinkPSNAccountResult> LinkPSNAccountAsync(LinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkPSNAccountResult>("/Server/LinkPSNAccount", request, extraHeaders);
    }
    public async Task<LinkPSNIdResponse> LinkPSNIdAsync(LinkPSNIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkPSNIdResponse>("/Server/LinkPSNId", request, extraHeaders);
    }
    public async Task<LinkServerCustomIdResult> LinkServerCustomIdAsync(LinkServerCustomIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkServerCustomIdResult>("/Server/LinkServerCustomId", request, extraHeaders);
    }
    public async Task<LinkSteamIdResult> LinkSteamIdAsync(LinkSteamIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkSteamIdResult>("/Server/LinkSteamId", request, extraHeaders);
    }
    public async Task<LinkXboxAccountResult> LinkXboxAccountAsync(LinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkXboxAccountResult>("/Server/LinkXboxAccount", request, extraHeaders);
    }
    public async Task<ListPlayerCustomPropertiesResult> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListPlayerCustomPropertiesResult>("/Server/ListPlayerCustomProperties", request, extraHeaders);
    }
    public async Task<LogEventResult> LogEventAsync(LogEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LogEventResult>("/Server/LogEvent", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithAndroidDeviceID", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithBattleNetAsync(LoginWithBattleNetRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithBattleNet", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithCustomIDAsync(LoginWithCustomIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithCustomID", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithIOSDeviceID", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithPSNAsync(LoginWithPSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithPSN", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithServerCustomIdAsync(LoginWithServerCustomIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithServerCustomId", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithSteamIdAsync(LoginWithSteamIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithSteamId", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithXboxAsync(LoginWithXboxRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithXbox", request, extraHeaders);
    }
    public async Task<ServerLoginResult> LoginWithXboxIdAsync(LoginWithXboxIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ServerLoginResult>("/Server/LoginWithXboxId", request, extraHeaders);
    }
    public async Task<ModifyItemUsesResult> ModifyItemUsesAsync(ModifyItemUsesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyItemUsesResult>("/Server/ModifyItemUses", request, extraHeaders);
    }
    public async Task<MoveItemToCharacterFromCharacterResult> MoveItemToCharacterFromCharacterAsync(MoveItemToCharacterFromCharacterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<MoveItemToCharacterFromCharacterResult>("/Server/MoveItemToCharacterFromCharacter", request, extraHeaders);
    }
    public async Task<MoveItemToCharacterFromUserResult> MoveItemToCharacterFromUserAsync(MoveItemToCharacterFromUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<MoveItemToCharacterFromUserResult>("/Server/MoveItemToCharacterFromUser", request, extraHeaders);
    }
    public async Task<MoveItemToUserFromCharacterResult> MoveItemToUserFromCharacterAsync(MoveItemToUserFromCharacterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<MoveItemToUserFromCharacterResult>("/Server/MoveItemToUserFromCharacter", request, extraHeaders);
    }
    public async Task<NotifyMatchmakerPlayerLeftResult> NotifyMatchmakerPlayerLeftAsync(NotifyMatchmakerPlayerLeftRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<NotifyMatchmakerPlayerLeftResult>("/Server/NotifyMatchmakerPlayerLeft", request, extraHeaders);
    }
    public async Task<RedeemCouponResult> RedeemCouponAsync(RedeemCouponRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemCouponResult>("/Server/RedeemCoupon", request, extraHeaders);
    }
    public async Task<RedeemMatchmakerTicketResult> RedeemMatchmakerTicketAsync(RedeemMatchmakerTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemMatchmakerTicketResult>("/Server/RedeemMatchmakerTicket", request, extraHeaders);
    }
    public async Task<RefreshGameServerInstanceHeartbeatResult> RefreshGameServerInstanceHeartbeatAsync(RefreshGameServerInstanceHeartbeatRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RefreshGameServerInstanceHeartbeatResult>("/Server/RefreshGameServerInstanceHeartbeat", request, extraHeaders);
    }
    public async Task<RegisterGameResponse> RegisterGameAsync(RegisterGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RegisterGameResponse>("/Server/RegisterGame", request, extraHeaders);
    }
    public async Task<EmptyResponse> RemoveFriendAsync(RemoveFriendRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/RemoveFriend", request, extraHeaders);
    }
    public async Task<EmptyResult> RemoveGenericIDAsync(RemoveGenericIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Server/RemoveGenericID", request, extraHeaders);
    }
    public async Task<RemovePlayerTagResult> RemovePlayerTagAsync(RemovePlayerTagRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemovePlayerTagResult>("/Server/RemovePlayerTag", request, extraHeaders);
    }
    public async Task<RemoveSharedGroupMembersResult> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveSharedGroupMembersResult>("/Server/RemoveSharedGroupMembers", request, extraHeaders);
    }
    public async Task<ReportPlayerServerResult> ReportPlayerAsync(ReportPlayerServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReportPlayerServerResult>("/Server/ReportPlayer", request, extraHeaders);
    }
    public async Task<RevokeAllBansForUserResult> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeAllBansForUserResult>("/Server/RevokeAllBansForUser", request, extraHeaders);
    }
    public async Task<RevokeBansResult> RevokeBansAsync(RevokeBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeBansResult>("/Server/RevokeBans", request, extraHeaders);
    }
    public async Task<RevokeInventoryResult> RevokeInventoryItemAsync(RevokeInventoryItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeInventoryResult>("/Server/RevokeInventoryItem", request, extraHeaders);
    }
    public async Task<RevokeInventoryItemsResult> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RevokeInventoryItemsResult>("/Server/RevokeInventoryItems", request, extraHeaders);
    }
    public async Task<SavePushNotificationTemplateResult> SavePushNotificationTemplateAsync(SavePushNotificationTemplateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SavePushNotificationTemplateResult>("/Server/SavePushNotificationTemplate", request, extraHeaders);
    }
    public async Task<SendCustomAccountRecoveryEmailResult> SendCustomAccountRecoveryEmailAsync(SendCustomAccountRecoveryEmailRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendCustomAccountRecoveryEmailResult>("/Server/SendCustomAccountRecoveryEmail", request, extraHeaders);
    }
    public async Task<SendEmailFromTemplateResult> SendEmailFromTemplateAsync(SendEmailFromTemplateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendEmailFromTemplateResult>("/Server/SendEmailFromTemplate", request, extraHeaders);
    }
    public async Task<SendPushNotificationResult> SendPushNotificationAsync(SendPushNotificationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendPushNotificationResult>("/Server/SendPushNotification", request, extraHeaders);
    }
    public async Task<SendPushNotificationResult> SendPushNotificationFromTemplateAsync(SendPushNotificationFromTemplateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendPushNotificationResult>("/Server/SendPushNotificationFromTemplate", request, extraHeaders);
    }
    public async Task<EmptyResponse> SetFriendTagsAsync(SetFriendTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/SetFriendTags", request, extraHeaders);
    }
    public async Task<SetGameServerInstanceDataResult> SetGameServerInstanceDataAsync(SetGameServerInstanceDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetGameServerInstanceDataResult>("/Server/SetGameServerInstanceData", request, extraHeaders);
    }
    public async Task<SetGameServerInstanceStateResult> SetGameServerInstanceStateAsync(SetGameServerInstanceStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetGameServerInstanceStateResult>("/Server/SetGameServerInstanceState", request, extraHeaders);
    }
    public async Task<SetGameServerInstanceTagsResult> SetGameServerInstanceTagsAsync(SetGameServerInstanceTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetGameServerInstanceTagsResult>("/Server/SetGameServerInstanceTags", request, extraHeaders);
    }
    public async Task<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPlayerSecretResult>("/Server/SetPlayerSecret", request, extraHeaders);
    }
    public async Task<SetPublisherDataResult> SetPublisherDataAsync(SetPublisherDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPublisherDataResult>("/Server/SetPublisherData", request, extraHeaders);
    }
    public async Task<SetTitleDataResult> SetTitleDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTitleDataResult>("/Server/SetTitleData", request, extraHeaders);
    }
    public async Task<SetTitleDataResult> SetTitleInternalDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTitleDataResult>("/Server/SetTitleInternalData", request, extraHeaders);
    }
    public async Task<ModifyCharacterVirtualCurrencyResult> SubtractCharacterVirtualCurrencyAsync(SubtractCharacterVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyCharacterVirtualCurrencyResult>("/Server/SubtractCharacterVirtualCurrency", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Server/SubtractUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/UnlinkBattleNetAccount", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/UnlinkNintendoServiceAccount", request, extraHeaders);
    }
    public async Task<UnlinkNintendoSwitchDeviceIdResult> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkNintendoSwitchDeviceIdResult>("/Server/UnlinkNintendoSwitchDeviceId", request, extraHeaders);
    }
    public async Task<UnlinkPSNAccountResult> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkPSNAccountResult>("/Server/UnlinkPSNAccount", request, extraHeaders);
    }
    public async Task<UnlinkServerCustomIdResult> UnlinkServerCustomIdAsync(UnlinkServerCustomIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkServerCustomIdResult>("/Server/UnlinkServerCustomId", request, extraHeaders);
    }
    public async Task<UnlinkSteamIdResult> UnlinkSteamIdAsync(UnlinkSteamIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkSteamIdResult>("/Server/UnlinkSteamId", request, extraHeaders);
    }
    public async Task<UnlinkXboxAccountResult> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkXboxAccountResult>("/Server/UnlinkXboxAccount", request, extraHeaders);
    }
    public async Task<UnlockContainerItemResult> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlockContainerItemResult>("/Server/UnlockContainerInstance", request, extraHeaders);
    }
    public async Task<UnlockContainerItemResult> UnlockContainerItemAsync(UnlockContainerItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlockContainerItemResult>("/Server/UnlockContainerItem", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/UpdateAvatarUrl", request, extraHeaders);
    }
    public async Task<UpdateBansResult> UpdateBansAsync(UpdateBansRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateBansResult>("/Server/UpdateBans", request, extraHeaders);
    }
    public async Task<UpdateCharacterDataResult> UpdateCharacterDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterDataResult>("/Server/UpdateCharacterData", request, extraHeaders);
    }
    public async Task<UpdateCharacterDataResult> UpdateCharacterInternalDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterDataResult>("/Server/UpdateCharacterInternalData", request, extraHeaders);
    }
    public async Task<UpdateCharacterDataResult> UpdateCharacterReadOnlyDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterDataResult>("/Server/UpdateCharacterReadOnlyData", request, extraHeaders);
    }
    public async Task<UpdateCharacterStatisticsResult> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterStatisticsResult>("/Server/UpdateCharacterStatistics", request, extraHeaders);
    }
    public async Task<UpdatePlayerCustomPropertiesResult> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerCustomPropertiesResult>("/Server/UpdatePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<UpdatePlayerStatisticsResult> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerStatisticsResult>("/Server/UpdatePlayerStatistics", request, extraHeaders);
    }
    public async Task<UpdateSharedGroupDataResult> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateSharedGroupDataResult>("/Server/UpdateSharedGroupData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserInternalData", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateUserInventoryItemCustomDataAsync(UpdateUserInventoryItemDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Server/UpdateUserInventoryItemCustomData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserPublisherData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserPublisherInternalData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserPublisherReadOnlyData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Server/UpdateUserReadOnlyData", request, extraHeaders);
    }
    public async Task<UpdateUserStatisticsResult> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserStatisticsResult>("/Server/UpdateUserStatistics", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WriteCharacterEventAsync(WriteServerCharacterEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Server/WriteCharacterEvent", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WritePlayerEventAsync(WriteServerPlayerEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Server/WritePlayerEvent", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WriteTitleEventAsync(WriteTitleEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Server/WriteTitleEvent", request, extraHeaders);
    }
}