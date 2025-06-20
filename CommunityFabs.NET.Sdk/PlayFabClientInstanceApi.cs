using CommunityFabs.NET.Sdk.Models.Client;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabClientInstanceApi : PlayFabBaseInstanceApi, IPlayFabClientApi {
    public PlayFabClientInstanceApi() : base() { }
    public PlayFabClientInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabClientInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabClientInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<AcceptTradeResponse> AcceptTradeAsync(AcceptTradeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AcceptTradeResponse>("/Client/AcceptTrade", request, extraHeaders);
    }
    public async Task<AddFriendResult> AddFriendAsync(AddFriendRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddFriendResult>("/Client/AddFriend", request, extraHeaders);
    }
    public async Task<AddGenericIDResult> AddGenericIDAsync(AddGenericIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddGenericIDResult>("/Client/AddGenericID", request, extraHeaders);
    }
    public async Task<AddOrUpdateContactEmailResult> AddOrUpdateContactEmailAsync(AddOrUpdateContactEmailRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddOrUpdateContactEmailResult>("/Client/AddOrUpdateContactEmail", request, extraHeaders);
    }
    public async Task<AddSharedGroupMembersResult> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddSharedGroupMembersResult>("/Client/AddSharedGroupMembers", request, extraHeaders);
    }
    public async Task<AddUsernamePasswordResult> AddUsernamePasswordAsync(AddUsernamePasswordRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddUsernamePasswordResult>("/Client/AddUsernamePassword", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Client/AddUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<AndroidDevicePushNotificationRegistrationResult> AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AndroidDevicePushNotificationRegistrationResult>("/Client/AndroidDevicePushNotificationRegistration", request, extraHeaders);
    }
    public async Task<AttributeInstallResult> AttributeInstallAsync(AttributeInstallRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AttributeInstallResult>("/Client/AttributeInstall", request, extraHeaders);
    }
    public async Task<CancelTradeResponse> CancelTradeAsync(CancelTradeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CancelTradeResponse>("/Client/CancelTrade", request, extraHeaders);
    }
    public async Task<ConfirmPurchaseResult> ConfirmPurchaseAsync(ConfirmPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConfirmPurchaseResult>("/Client/ConfirmPurchase", request, extraHeaders);
    }
    public async Task<ConsumeItemResult> ConsumeItemAsync(ConsumeItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumeItemResult>("/Client/ConsumeItem", request, extraHeaders);
    }
    public async Task<ConsumeMicrosoftStoreEntitlementsResponse> ConsumeMicrosoftStoreEntitlementsAsync(ConsumeMicrosoftStoreEntitlementsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumeMicrosoftStoreEntitlementsResponse>("/Client/ConsumeMicrosoftStoreEntitlements", request, extraHeaders);
    }
    public async Task<ConsumePS5EntitlementsResult> ConsumePS5EntitlementsAsync(ConsumePS5EntitlementsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumePS5EntitlementsResult>("/Client/ConsumePS5Entitlements", request, extraHeaders);
    }
    public async Task<ConsumePSNEntitlementsResult> ConsumePSNEntitlementsAsync(ConsumePSNEntitlementsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumePSNEntitlementsResult>("/Client/ConsumePSNEntitlements", request, extraHeaders);
    }
    public async Task<ConsumeXboxEntitlementsResult> ConsumeXboxEntitlementsAsync(ConsumeXboxEntitlementsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ConsumeXboxEntitlementsResult>("/Client/ConsumeXboxEntitlements", request, extraHeaders);
    }
    public async Task<CreateSharedGroupResult> CreateSharedGroupAsync(CreateSharedGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateSharedGroupResult>("/Client/CreateSharedGroup", request, extraHeaders);
    }
    public async Task<DeletePlayerCustomPropertiesResult> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePlayerCustomPropertiesResult>("/Client/DeletePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<ExecuteCloudScriptResult> ExecuteCloudScriptAsync(ExecuteCloudScriptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteCloudScriptResult>("/Client/ExecuteCloudScript", request, extraHeaders);
    }
    public async Task<GetAccountInfoResult> GetAccountInfoAsync(GetAccountInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAccountInfoResult>("/Client/GetAccountInfo", request, extraHeaders);
    }
    public async Task<GetAdPlacementsResult> GetAdPlacementsAsync(GetAdPlacementsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAdPlacementsResult>("/Client/GetAdPlacements", request, extraHeaders);
    }
    public async Task<ListUsersCharactersResult> GetAllUsersCharactersAsync(ListUsersCharactersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListUsersCharactersResult>("/Client/GetAllUsersCharacters", request, extraHeaders);
    }
    public async Task<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCatalogItemsResult>("/Client/GetCatalogItems", request, extraHeaders);
    }
    public async Task<GetCharacterDataResult> GetCharacterDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterDataResult>("/Client/GetCharacterData", request, extraHeaders);
    }
    public async Task<GetCharacterInventoryResult> GetCharacterInventoryAsync(GetCharacterInventoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterInventoryResult>("/Client/GetCharacterInventory", request, extraHeaders);
    }
    public async Task<GetCharacterLeaderboardResult> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterLeaderboardResult>("/Client/GetCharacterLeaderboard", request, extraHeaders);
    }
    public async Task<GetCharacterDataResult> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterDataResult>("/Client/GetCharacterReadOnlyData", request, extraHeaders);
    }
    public async Task<GetCharacterStatisticsResult> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCharacterStatisticsResult>("/Client/GetCharacterStatistics", request, extraHeaders);
    }
    public async Task<GetCloudScriptUrlResult> GetCloudScriptUrlAsync(GetCloudScriptUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCloudScriptUrlResult>("/Client/GetCloudScriptUrl", request, extraHeaders);
    }
    public async Task<GetContentDownloadUrlResult> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetContentDownloadUrlResult>("/Client/GetContentDownloadUrl", request, extraHeaders);
    }
    public async Task<CurrentGamesResult> GetCurrentGamesAsync(CurrentGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CurrentGamesResult>("/Client/GetCurrentGames", request, extraHeaders);
    }
    public async Task<GetLeaderboardResult> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardResult>("/Client/GetFriendLeaderboard", request, extraHeaders);
    }
    public async Task<GetFriendLeaderboardAroundCurrentUserResult> GetFriendLeaderboardAroundCurrentUserAsync(GetFriendLeaderboardAroundCurrentUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFriendLeaderboardAroundCurrentUserResult>("/Client/GetFriendLeaderboardAroundCurrentUser", request, extraHeaders);
    }
    public async Task<GetFriendLeaderboardAroundPlayerResult> GetFriendLeaderboardAroundPlayerAsync(GetFriendLeaderboardAroundPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFriendLeaderboardAroundPlayerResult>("/Client/GetFriendLeaderboardAroundPlayer", request, extraHeaders);
    }
    public async Task<GetFriendsListResult> GetFriendsListAsync(GetFriendsListRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFriendsListResult>("/Client/GetFriendsList", request, extraHeaders);
    }
    public async Task<GameServerRegionsResult> GetGameServerRegionsAsync(GameServerRegionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GameServerRegionsResult>("/Client/GetGameServerRegions", request, extraHeaders);
    }
    public async Task<GetLeaderboardResult> GetLeaderboardAsync(GetLeaderboardRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardResult>("/Client/GetLeaderboard", request, extraHeaders);
    }
    public async Task<GetLeaderboardAroundCharacterResult> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardAroundCharacterResult>("/Client/GetLeaderboardAroundCharacter", request, extraHeaders);
    }
    public async Task<GetLeaderboardAroundCurrentUserResult> GetLeaderboardAroundCurrentUserAsync(GetLeaderboardAroundCurrentUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardAroundCurrentUserResult>("/Client/GetLeaderboardAroundCurrentUser", request, extraHeaders);
    }
    public async Task<GetLeaderboardAroundPlayerResult> GetLeaderboardAroundPlayerAsync(GetLeaderboardAroundPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardAroundPlayerResult>("/Client/GetLeaderboardAroundPlayer", request, extraHeaders);
    }
    public async Task<GetLeaderboardForUsersCharactersResult> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLeaderboardForUsersCharactersResult>("/Client/GetLeaderboardForUserCharacters", request, extraHeaders);
    }
    public async Task<GetPaymentTokenResult> GetPaymentTokenAsync(GetPaymentTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPaymentTokenResult>("/Client/GetPaymentToken", request, extraHeaders);
    }
    public async Task<GetPhotonAuthenticationTokenResult> GetPhotonAuthenticationTokenAsync(GetPhotonAuthenticationTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPhotonAuthenticationTokenResult>("/Client/GetPhotonAuthenticationToken", request, extraHeaders);
    }
    public async Task<GetPlayerCombinedInfoResult> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerCombinedInfoResult>("/Client/GetPlayerCombinedInfo", request, extraHeaders);
    }
    public async Task<GetPlayerCustomPropertyResult> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerCustomPropertyResult>("/Client/GetPlayerCustomProperty", request, extraHeaders);
    }
    public async Task<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerProfileResult>("/Client/GetPlayerProfile", request, extraHeaders);
    }
    public async Task<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayerSegmentsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerSegmentsResult>("/Client/GetPlayerSegments", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticsResult> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticsResult>("/Client/GetPlayerStatistics", request, extraHeaders);
    }
    public async Task<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerStatisticVersionsResult>("/Client/GetPlayerStatisticVersions", request, extraHeaders);
    }
    public async Task<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerTagsResult>("/Client/GetPlayerTags", request, extraHeaders);
    }
    public async Task<GetPlayerTradesResponse> GetPlayerTradesAsync(GetPlayerTradesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayerTradesResponse>("/Client/GetPlayerTrades", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromBattleNetAccountIdsResult> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromBattleNetAccountIdsResult>("/Client/GetPlayFabIDsFromBattleNetAccountIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromFacebookIDsResult> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromFacebookIDsResult>("/Client/GetPlayFabIDsFromFacebookIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromFacebookInstantGamesIdsResult> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromFacebookInstantGamesIdsResult>("/Client/GetPlayFabIDsFromFacebookInstantGamesIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromGameCenterIDsResult> GetPlayFabIDsFromGameCenterIDsAsync(GetPlayFabIDsFromGameCenterIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromGameCenterIDsResult>("/Client/GetPlayFabIDsFromGameCenterIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromGenericIDsResult> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromGenericIDsResult>("/Client/GetPlayFabIDsFromGenericIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromGoogleIDsResult> GetPlayFabIDsFromGoogleIDsAsync(GetPlayFabIDsFromGoogleIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromGoogleIDsResult>("/Client/GetPlayFabIDsFromGoogleIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> GetPlayFabIDsFromGooglePlayGamesPlayerIDsAsync(GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>("/Client/GetPlayFabIDsFromGooglePlayGamesPlayerIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromKongregateIDsResult> GetPlayFabIDsFromKongregateIDsAsync(GetPlayFabIDsFromKongregateIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromKongregateIDsResult>("/Client/GetPlayFabIDsFromKongregateIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromNintendoServiceAccountIdsResult> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromNintendoServiceAccountIdsResult>("/Client/GetPlayFabIDsFromNintendoServiceAccountIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>("/Client/GetPlayFabIDsFromNintendoSwitchDeviceIds", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromPSNAccountIDsResult> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromPSNAccountIDsResult>("/Client/GetPlayFabIDsFromPSNAccountIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromPSNOnlineIDsResult> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromPSNOnlineIDsResult>("/Client/GetPlayFabIDsFromPSNOnlineIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromSteamIDsResult> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromSteamIDsResult>("/Client/GetPlayFabIDsFromSteamIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromSteamNamesResult> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromSteamNamesResult>("/Client/GetPlayFabIDsFromSteamNames", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromTwitchIDsResult> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromTwitchIDsResult>("/Client/GetPlayFabIDsFromTwitchIDs", request, extraHeaders);
    }
    public async Task<GetPlayFabIDsFromXboxLiveIDsResult> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPlayFabIDsFromXboxLiveIDsResult>("/Client/GetPlayFabIDsFromXboxLiveIDs", request, extraHeaders);
    }
    public async Task<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPublisherDataResult>("/Client/GetPublisherData", request, extraHeaders);
    }
    public async Task<GetPurchaseResult> GetPurchaseAsync(GetPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPurchaseResult>("/Client/GetPurchase", request, extraHeaders);
    }
    public async Task<GetSharedGroupDataResult> GetSharedGroupDataAsync(GetSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetSharedGroupDataResult>("/Client/GetSharedGroupData", request, extraHeaders);
    }
    public async Task<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStoreItemsResult>("/Client/GetStoreItems", request, extraHeaders);
    }
    public async Task<GetTimeResult> GetTimeAsync(GetTimeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTimeResult>("/Client/GetTime", request, extraHeaders);
    }
    public async Task<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleDataResult>("/Client/GetTitleData", request, extraHeaders);
    }
    public async Task<GetTitleNewsResult> GetTitleNewsAsync(GetTitleNewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitleNewsResult>("/Client/GetTitleNews", request, extraHeaders);
    }
    public async Task<GetTitlePublicKeyResult> GetTitlePublicKeyAsync(GetTitlePublicKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitlePublicKeyResult>("/Client/GetTitlePublicKey", request, extraHeaders);
    }
    public async Task<GetTradeStatusResponse> GetTradeStatusAsync(GetTradeStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTradeStatusResponse>("/Client/GetTradeStatus", request, extraHeaders);
    }
    public async Task<GetUserCombinedInfoResult> GetUserCombinedInfoAsync(GetUserCombinedInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserCombinedInfoResult>("/Client/GetUserCombinedInfo", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Client/GetUserData", request, extraHeaders);
    }
    public async Task<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserInventoryResult>("/Client/GetUserInventory", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Client/GetUserPublisherData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Client/GetUserPublisherReadOnlyData", request, extraHeaders);
    }
    public async Task<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserDataResult>("/Client/GetUserReadOnlyData", request, extraHeaders);
    }
    public async Task<GetUserStatisticsResult> GetUserStatisticsAsync(GetUserStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetUserStatisticsResult>("/Client/GetUserStatistics", request, extraHeaders);
    }
    public async Task<GrantCharacterToUserResult> GrantCharacterToUserAsync(GrantCharacterToUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GrantCharacterToUserResult>("/Client/GrantCharacterToUser", request, extraHeaders);
    }
    public async Task<LinkAndroidDeviceIDResult> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkAndroidDeviceIDResult>("/Client/LinkAndroidDeviceID", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkAppleAsync(LinkAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Client/LinkApple", request, extraHeaders);
    }
    public async Task<EmptyResponse> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/LinkBattleNetAccount", request, extraHeaders);
    }
    public async Task<LinkCustomIDResult> LinkCustomIDAsync(LinkCustomIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkCustomIDResult>("/Client/LinkCustomID", request, extraHeaders);
    }
    public async Task<LinkFacebookAccountResult> LinkFacebookAccountAsync(LinkFacebookAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkFacebookAccountResult>("/Client/LinkFacebookAccount", request, extraHeaders);
    }
    public async Task<LinkFacebookInstantGamesIdResult> LinkFacebookInstantGamesIdAsync(LinkFacebookInstantGamesIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkFacebookInstantGamesIdResult>("/Client/LinkFacebookInstantGamesId", request, extraHeaders);
    }
    public async Task<LinkGameCenterAccountResult> LinkGameCenterAccountAsync(LinkGameCenterAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkGameCenterAccountResult>("/Client/LinkGameCenterAccount", request, extraHeaders);
    }
    public async Task<LinkGoogleAccountResult> LinkGoogleAccountAsync(LinkGoogleAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkGoogleAccountResult>("/Client/LinkGoogleAccount", request, extraHeaders);
    }
    public async Task<LinkGooglePlayGamesServicesAccountResult> LinkGooglePlayGamesServicesAccountAsync(LinkGooglePlayGamesServicesAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkGooglePlayGamesServicesAccountResult>("/Client/LinkGooglePlayGamesServicesAccount", request, extraHeaders);
    }
    public async Task<LinkIOSDeviceIDResult> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkIOSDeviceIDResult>("/Client/LinkIOSDeviceID", request, extraHeaders);
    }
    public async Task<LinkKongregateAccountResult> LinkKongregateAsync(LinkKongregateAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkKongregateAccountResult>("/Client/LinkKongregate", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Client/LinkNintendoServiceAccount", request, extraHeaders);
    }
    public async Task<LinkNintendoSwitchDeviceIdResult> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkNintendoSwitchDeviceIdResult>("/Client/LinkNintendoSwitchDeviceId", request, extraHeaders);
    }
    public async Task<EmptyResult> LinkOpenIdConnectAsync(LinkOpenIdConnectRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResult>("/Client/LinkOpenIdConnect", request, extraHeaders);
    }
    public async Task<LinkPSNAccountResult> LinkPSNAccountAsync(LinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkPSNAccountResult>("/Client/LinkPSNAccount", request, extraHeaders);
    }
    public async Task<LinkSteamAccountResult> LinkSteamAccountAsync(LinkSteamAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkSteamAccountResult>("/Client/LinkSteamAccount", request, extraHeaders);
    }
    public async Task<LinkTwitchAccountResult> LinkTwitchAsync(LinkTwitchAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkTwitchAccountResult>("/Client/LinkTwitch", request, extraHeaders);
    }
    public async Task<LinkXboxAccountResult> LinkXboxAccountAsync(LinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LinkXboxAccountResult>("/Client/LinkXboxAccount", request, extraHeaders);
    }
    public async Task<ListPlayerCustomPropertiesResult> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListPlayerCustomPropertiesResult>("/Client/ListPlayerCustomProperties", request, extraHeaders);
    }
    public async Task<LogEventResult> LogEventAsync(LogEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LogEventResult>("/Client/LogEvent", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithAndroidDeviceID", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithAppleAsync(LoginWithAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithApple", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithBattleNetAsync(LoginWithBattleNetRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithBattleNet", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithCustomIDAsync(LoginWithCustomIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithCustomID", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithEmailAddress", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithFacebookAsync(LoginWithFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithFacebook", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithFacebookInstantGamesIdAsync(LoginWithFacebookInstantGamesIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithFacebookInstantGamesId", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithGameCenterAsync(LoginWithGameCenterRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithGameCenter", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithGoogleAccount", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithGooglePlayGamesServicesAsync(LoginWithGooglePlayGamesServicesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithGooglePlayGamesServices", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithIOSDeviceID", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithKongregateAsync(LoginWithKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithKongregate", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithNintendoServiceAccountAsync(LoginWithNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithNintendoServiceAccount", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithNintendoSwitchDeviceIdAsync(LoginWithNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithNintendoSwitchDeviceId", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithOpenIdConnectAsync(LoginWithOpenIdConnectRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithOpenIdConnect", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithPlayFabAsync(LoginWithPlayFabRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithPlayFab", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithPSNAsync(LoginWithPSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithPSN", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithSteamAsync(LoginWithSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithSteam", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithTwitchAsync(LoginWithTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithTwitch", request, extraHeaders);
    }
    public async Task<LoginResult> LoginWithXboxAsync(LoginWithXboxRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<LoginResult>("/Client/LoginWithXbox", request, extraHeaders);
    }
    public async Task<MatchmakeResult> MatchmakeAsync(MatchmakeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<MatchmakeResult>("/Client/Matchmake", request, extraHeaders);
    }
    public async Task<OpenTradeResponse> OpenTradeAsync(OpenTradeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<OpenTradeResponse>("/Client/OpenTrade", request, extraHeaders);
    }
    public async Task<PayForPurchaseResult> PayForPurchaseAsync(PayForPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PayForPurchaseResult>("/Client/PayForPurchase", request, extraHeaders);
    }
    public async Task<PurchaseItemResult> PurchaseItemAsync(PurchaseItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PurchaseItemResult>("/Client/PurchaseItem", request, extraHeaders);
    }
    public async Task<RedeemCouponResult> RedeemCouponAsync(RedeemCouponRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemCouponResult>("/Client/RedeemCoupon", request, extraHeaders);
    }
    public async Task<EmptyResponse> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/RefreshPSNAuthToken", request, extraHeaders);
    }
    public async Task<RegisterForIOSPushNotificationResult> RegisterForIOSPushNotificationAsync(RegisterForIOSPushNotificationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RegisterForIOSPushNotificationResult>("/Client/RegisterForIOSPushNotification", request, extraHeaders);
    }
    public async Task<RegisterPlayFabUserResult> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RegisterPlayFabUserResult>("/Client/RegisterPlayFabUser", request, extraHeaders);
    }
    public async Task<RemoveContactEmailResult> RemoveContactEmailAsync(RemoveContactEmailRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveContactEmailResult>("/Client/RemoveContactEmail", request, extraHeaders);
    }
    public async Task<RemoveFriendResult> RemoveFriendAsync(RemoveFriendRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveFriendResult>("/Client/RemoveFriend", request, extraHeaders);
    }
    public async Task<RemoveGenericIDResult> RemoveGenericIDAsync(RemoveGenericIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveGenericIDResult>("/Client/RemoveGenericID", request, extraHeaders);
    }
    public async Task<RemoveSharedGroupMembersResult> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RemoveSharedGroupMembersResult>("/Client/RemoveSharedGroupMembers", request, extraHeaders);
    }
    public async Task<ReportAdActivityResult> ReportAdActivityAsync(ReportAdActivityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReportAdActivityResult>("/Client/ReportAdActivity", request, extraHeaders);
    }
    public async Task<EmptyResponse> ReportDeviceInfoAsync(DeviceInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/ReportDeviceInfo", request, extraHeaders);
    }
    public async Task<ReportPlayerClientResult> ReportPlayerAsync(ReportPlayerClientRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReportPlayerClientResult>("/Client/ReportPlayer", request, extraHeaders);
    }
    public async Task<RestoreIOSPurchasesResult> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RestoreIOSPurchasesResult>("/Client/RestoreIOSPurchases", request, extraHeaders);
    }
    public async Task<RewardAdActivityResult> RewardAdActivityAsync(RewardAdActivityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RewardAdActivityResult>("/Client/RewardAdActivity", request, extraHeaders);
    }
    public async Task<RunCloudScriptResult> RunCloudScriptAsync(RunCloudScriptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RunCloudScriptResult>("/Client/RunCloudScript", request, extraHeaders);
    }
    public async Task<SendAccountRecoveryEmailResult> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SendAccountRecoveryEmailResult>("/Client/SendAccountRecoveryEmail", request, extraHeaders);
    }
    public async Task<SetFriendTagsResult> SetFriendTagsAsync(SetFriendTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetFriendTagsResult>("/Client/SetFriendTags", request, extraHeaders);
    }
    public async Task<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetPlayerSecretResult>("/Client/SetPlayerSecret", request, extraHeaders);
    }
    public async Task<StartGameResult> StartGameAsync(StartGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<StartGameResult>("/Client/StartGame", request, extraHeaders);
    }
    public async Task<StartPurchaseResult> StartPurchaseAsync(StartPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<StartPurchaseResult>("/Client/StartPurchase", request, extraHeaders);
    }
    public async Task<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ModifyUserVirtualCurrencyResult>("/Client/SubtractUserVirtualCurrency", request, extraHeaders);
    }
    public async Task<UnlinkAndroidDeviceIDResult> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkAndroidDeviceIDResult>("/Client/UnlinkAndroidDeviceID", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkAppleAsync(UnlinkAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/UnlinkApple", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/UnlinkBattleNetAccount", request, extraHeaders);
    }
    public async Task<UnlinkCustomIDResult> UnlinkCustomIDAsync(UnlinkCustomIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkCustomIDResult>("/Client/UnlinkCustomID", request, extraHeaders);
    }
    public async Task<UnlinkFacebookAccountResult> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkFacebookAccountResult>("/Client/UnlinkFacebookAccount", request, extraHeaders);
    }
    public async Task<UnlinkFacebookInstantGamesIdResult> UnlinkFacebookInstantGamesIdAsync(UnlinkFacebookInstantGamesIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkFacebookInstantGamesIdResult>("/Client/UnlinkFacebookInstantGamesId", request, extraHeaders);
    }
    public async Task<UnlinkGameCenterAccountResult> UnlinkGameCenterAccountAsync(UnlinkGameCenterAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkGameCenterAccountResult>("/Client/UnlinkGameCenterAccount", request, extraHeaders);
    }
    public async Task<UnlinkGoogleAccountResult> UnlinkGoogleAccountAsync(UnlinkGoogleAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkGoogleAccountResult>("/Client/UnlinkGoogleAccount", request, extraHeaders);
    }
    public async Task<UnlinkGooglePlayGamesServicesAccountResult> UnlinkGooglePlayGamesServicesAccountAsync(UnlinkGooglePlayGamesServicesAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkGooglePlayGamesServicesAccountResult>("/Client/UnlinkGooglePlayGamesServicesAccount", request, extraHeaders);
    }
    public async Task<UnlinkIOSDeviceIDResult> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkIOSDeviceIDResult>("/Client/UnlinkIOSDeviceID", request, extraHeaders);
    }
    public async Task<UnlinkKongregateAccountResult> UnlinkKongregateAsync(UnlinkKongregateAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkKongregateAccountResult>("/Client/UnlinkKongregate", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/UnlinkNintendoServiceAccount", request, extraHeaders);
    }
    public async Task<UnlinkNintendoSwitchDeviceIdResult> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkNintendoSwitchDeviceIdResult>("/Client/UnlinkNintendoSwitchDeviceId", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnlinkOpenIdConnectAsync(UnlinkOpenIdConnectRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/UnlinkOpenIdConnect", request, extraHeaders);
    }
    public async Task<UnlinkPSNAccountResult> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkPSNAccountResult>("/Client/UnlinkPSNAccount", request, extraHeaders);
    }
    public async Task<UnlinkSteamAccountResult> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkSteamAccountResult>("/Client/UnlinkSteamAccount", request, extraHeaders);
    }
    public async Task<UnlinkTwitchAccountResult> UnlinkTwitchAsync(UnlinkTwitchAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkTwitchAccountResult>("/Client/UnlinkTwitch", request, extraHeaders);
    }
    public async Task<UnlinkXboxAccountResult> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlinkXboxAccountResult>("/Client/UnlinkXboxAccount", request, extraHeaders);
    }
    public async Task<UnlockContainerItemResult> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlockContainerItemResult>("/Client/UnlockContainerInstance", request, extraHeaders);
    }
    public async Task<UnlockContainerItemResult> UnlockContainerItemAsync(UnlockContainerItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UnlockContainerItemResult>("/Client/UnlockContainerItem", request, extraHeaders);
    }
    public async Task<EmptyResponse> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Client/UpdateAvatarUrl", request, extraHeaders);
    }
    public async Task<UpdateCharacterDataResult> UpdateCharacterDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterDataResult>("/Client/UpdateCharacterData", request, extraHeaders);
    }
    public async Task<UpdateCharacterStatisticsResult> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCharacterStatisticsResult>("/Client/UpdateCharacterStatistics", request, extraHeaders);
    }
    public async Task<UpdatePlayerCustomPropertiesResult> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerCustomPropertiesResult>("/Client/UpdatePlayerCustomProperties", request, extraHeaders);
    }
    public async Task<UpdatePlayerStatisticsResult> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdatePlayerStatisticsResult>("/Client/UpdatePlayerStatistics", request, extraHeaders);
    }
    public async Task<UpdateSharedGroupDataResult> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateSharedGroupDataResult>("/Client/UpdateSharedGroupData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Client/UpdateUserData", request, extraHeaders);
    }
    public async Task<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserDataResult>("/Client/UpdateUserPublisherData", request, extraHeaders);
    }
    public async Task<UpdateUserStatisticsResult> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserStatisticsResult>("/Client/UpdateUserStatistics", request, extraHeaders);
    }
    public async Task<UpdateUserTitleDisplayNameResult> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateUserTitleDisplayNameResult>("/Client/UpdateUserTitleDisplayName", request, extraHeaders);
    }
    public async Task<ValidateAmazonReceiptResult> ValidateAmazonIAPReceiptAsync(ValidateAmazonReceiptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ValidateAmazonReceiptResult>("/Client/ValidateAmazonIAPReceipt", request, extraHeaders);
    }
    public async Task<ValidateGooglePlayPurchaseResult> ValidateGooglePlayPurchaseAsync(ValidateGooglePlayPurchaseRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ValidateGooglePlayPurchaseResult>("/Client/ValidateGooglePlayPurchase", request, extraHeaders);
    }
    public async Task<ValidateIOSReceiptResult> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ValidateIOSReceiptResult>("/Client/ValidateIOSReceipt", request, extraHeaders);
    }
    public async Task<ValidateWindowsReceiptResult> ValidateWindowsStoreReceiptAsync(ValidateWindowsReceiptRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ValidateWindowsReceiptResult>("/Client/ValidateWindowsStoreReceipt", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WriteCharacterEventAsync(WriteClientCharacterEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Client/WriteCharacterEvent", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WritePlayerEventAsync(WriteClientPlayerEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Client/WritePlayerEvent", request, extraHeaders);
    }
    public async Task<WriteEventResponse> WriteTitleEventAsync(WriteTitleEventRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventResponse>("/Client/WriteTitleEvent", request, extraHeaders);
    }
}