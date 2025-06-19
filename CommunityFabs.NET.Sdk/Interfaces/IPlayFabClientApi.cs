using CommunityFabs.NET.Sdk.Models.Client;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabClientApi {
    /// <summary>
    /// Accepts an open trade (one that has not yet been accepted or cancelled), if the locally signed-in player is in the
    /// allowed player list for the trade, or it is open to all players. If the call is successful, the offered and accepted
    /// items will be swapped between the two players' inventories.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AcceptTradeAsync({);
    ///   "OfferingPlayerId": "CD803BF233CE76CC",
    ///   "TradeId": "D819CEC225EA9948C351",
    ///   "AcceptedInventoryInstanceIds": [
    ///     "95C1797ADDAC24DC0383",
    ///     "0F7793DF55CCEAF21B84"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/trading/accepttrade">Microsoft Documentation</see>
    /// </summary>
    public Task<AcceptTradeResponse> AcceptTradeAsync(AcceptTradeRequest request);
    /// <summary>
    /// Adds the PlayFab user, based upon a match against a supplied unique identifier, to the friend list of the local user.
    /// At least one of FriendPlayFabId,FriendUsername,FriendEmail, or FriendTitleDisplayName should be initialized.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddFriendAsync({);
    ///   "FriendPlayFabId": "29837799"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/friend-list-management/addfriend">Microsoft Documentation</see>
    /// </summary>
    public Task<AddFriendResult> AddFriendAsync(AddFriendRequest request);
    /// <summary>
    /// Adds the specified generic service identifier to the player's PlayFab account. This is designed to allow for a PlayFab
    /// ID lookup of any arbitrary service identifier a title wants to add. This identifier should never be used as
    /// authentication credentials, as the intent is that it is easily accessible by other players.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddGenericIDAsync({);
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/addgenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<AddGenericIDResult> AddGenericIDAsync(AddGenericIDRequest request);
    /// <summary>
    /// Adds or updates a contact email to the player's profile.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddOrUpdateContactEmailAsync({);
    ///   "EmailAddress": "theuser@domain.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/addorupdatecontactemail">Microsoft Documentation</see>
    /// </summary>
    public Task<AddOrUpdateContactEmailResult> AddOrUpdateContactEmailAsync(AddOrUpdateContactEmailRequest request);
    /// <summary>
    /// Adds users to the set of those able to update both the shared data, as well as the set of users in the group. Only
    /// users in the group can add new members. Shared Groups are designed for sharing data between a very small number of
    /// players, please see our guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddSharedGroupMembersAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/shared-group-data/addsharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<AddSharedGroupMembersResult> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request);
    /// <summary>
    /// Adds playfab username/password auth to an existing account created via an anonymous auth method, e.g. automatic device
    /// ID login.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddUsernamePasswordAsync({);
    ///   "Username": "theuser",
    ///   "Email": "me@here.com",
    ///   "Password": "ExampleSecret"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/addusernamepassword">Microsoft Documentation</see>
    /// </summary>
    public Task<AddUsernamePasswordResult> AddUsernamePasswordAsync(AddUsernamePasswordRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the user's balance of the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = clientApi.AddUserVirtualCurrencyAsync({);
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/adduservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request);
    /// <summary>
    /// Registers the Android device to receive push notifications
    /// <example><br/>Example:<code>
    /// var response = clientApi.AndroidDevicePushNotificationRegistrationAsync({);
    ///   "DeviceToken": "59872d98fa632brn8hg3770",
    ///   "SendPushNotificationConfirmation": true,
    ///   "ConfirmationMessage": "Welcome to PlayFab!"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/androiddevicepushnotificationregistration">Microsoft Documentation</see>
    /// </summary>
    public Task<AndroidDevicePushNotificationRegistrationResult> AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest request);
    /// <summary>
    /// Attributes an install for advertisment.
    /// <example><br/>Example:<code>
    /// var response = clientApi.AttributeInstallAsync({);
    ///   "Idfa": "11098810"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/advertising/attributeinstall">Microsoft Documentation</see>
    /// </summary>
    public Task<AttributeInstallResult> AttributeInstallAsync(AttributeInstallRequest request);
    /// <summary>
    /// Cancels an open trade (one that has not yet been accepted or cancelled). Note that only the player who created the
    /// trade can cancel it via this API call, to prevent griefing of the trade system (cancelling trades in order to prevent
    /// other players from accepting them, for trades that can be claimed by more than one player).
    /// <example><br/>Example:<code>
    /// var response = clientApi.CancelTradeAsync({);
    ///   "TradeId": "D819CEC225EA9948C351"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/trading/canceltrade">Microsoft Documentation</see>
    /// </summary>
    public Task<CancelTradeResponse> CancelTradeAsync(CancelTradeRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Confirms with the payment provider that the purchase was approved (if applicable) and adjusts inventory and
    /// virtual currency balances as appropriate
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConfirmPurchaseAsync({);
    ///   "OrderId": "8853591446005860822"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/confirmpurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<ConfirmPurchaseResult> ConfirmPurchaseAsync(ConfirmPurchaseRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Consume uses of a consumable item. When all uses are consumed, it will be removed from the player's
    /// inventory.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConsumeItemAsync({);
    ///   "ItemInstanceId": "94585729",
    ///   "ConsumeCount": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/consumeitem">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumeItemResult> ConsumeItemAsync(ConsumeItemRequest request);
    /// <summary>
    /// Grants the player's current entitlements from Microsoft Store's Collection API
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConsumeMicrosoftStoreEntitlementsAsync({);
    ///   "MarketplaceSpecificData": {
    ///     "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///     "userId": "46239871",
    ///     "collectionsMsIdKey": "MicrosoftStoreIdKey"
    ///   },
    ///   "CatalogVersion": "MainCatalog"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/consumemicrosoftstoreentitlements">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumeMicrosoftStoreEntitlementsResponse> ConsumeMicrosoftStoreEntitlementsAsync(ConsumeMicrosoftStoreEntitlementsRequest request);
    /// <summary>
    /// Checks for any new consumable entitlements. If any are found, they are consumed (if they're consumables) and added as
    /// PlayFab items
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConsumePS5EntitlementsAsync({);
    ///   "MarketplaceSpecificData": {
    ///     "ServiceLabel": "1"
    ///   },
    ///   "CatalogVersion": "MainCatalog"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/consumeps5entitlements">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumePS5EntitlementsResult> ConsumePS5EntitlementsAsync(ConsumePS5EntitlementsRequest request);
    /// <summary>
    /// Checks for any new consumable entitlements. If any are found, they are consumed and added as PlayFab items
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConsumePSNEntitlementsAsync({);
    ///   "ServiceLabel": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/consumepsnentitlements">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumePSNEntitlementsResult> ConsumePSNEntitlementsAsync(ConsumePSNEntitlementsRequest request);
    /// <summary>
    /// Grants the player's current entitlements from Xbox Live, consuming all availble items in Xbox and granting them to the
    /// player's PlayFab inventory. This call is idempotent and will not grant previously granted items to the player.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ConsumeXboxEntitlementsAsync({);
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "CatalogVersion": "XboxItems"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/consumexboxentitlements">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumeXboxEntitlementsResult> ConsumeXboxEntitlementsAsync(ConsumeXboxEntitlementsRequest request);
    /// <summary>
    /// Requests the creation of a shared group object, containing key/value pairs which may be updated by all members of the
    /// group. Upon creation, the current user will be the only member of the group. Shared Groups are designed for sharing
    /// data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = clientApi.CreateSharedGroupAsync({);
    ///   "SharedGroupId": "Clan Data"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/shared-group-data/createsharedgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateSharedGroupResult> CreateSharedGroupAsync(CreateSharedGroupRequest request);
    /// <summary>
    /// Deletes title-specific custom properties for a player
    /// <example><br/>Example:<code>
    /// var response = clientApi.DeletePlayerCustomPropertiesAsync({);
    ///   "PropertyNames": [
    ///     "level",
    ///     "created"
    ///   ],
    ///   "ExpectedPropertiesVersion": 12
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/deleteplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePlayerCustomPropertiesResult> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request);
    /// <summary>
    /// Executes a CloudScript function, with the 'currentPlayerId' set to the PlayFab ID of the authenticated player. The
    /// PlayFab ID is the entity ID of the player's master_player_account entity.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ExecuteCloudScriptAsync({);
    ///   "FunctionName": "levelCompleted",
    ///   "FunctionParameter": {
    ///     "level": 3,
    ///     "points": 400
    ///   },
    ///   "RevisionSelection": "Live",
    ///   "GeneratePlayStreamEvent": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/server-side-cloud-script/executecloudscript">Microsoft Documentation</see>
    /// </summary>
    public Task<ExecuteCloudScriptResult> ExecuteCloudScriptAsync(ExecuteCloudScriptRequest request);
    /// <summary>
    /// Retrieves the user's PlayFab account details
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetAccountInfoAsync({);
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getaccountinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAccountInfoResult> GetAccountInfoAsync(GetAccountInfoRequest request);
    /// <summary>
    /// Returns a list of ad placements and a reward for each
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetAdPlacementsAsync({);
    ///   "AppId": "A12784B",
    ///   "Identifier": {
    ///     "Name": "PowerBonusInterstitial"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/advertising/getadplacements">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAdPlacementsResult> GetAdPlacementsAsync(GetAdPlacementsRequest request);
    /// <summary>
    /// Lists all of the characters that belong to a specific user. CharacterIds are not globally unique; characterId must be
    /// evaluated with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetAllUsersCharactersAsync({);
    ///   "PlayFabId": "98333765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/getalluserscharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<ListUsersCharactersResult> GetAllUsersCharactersAsync(ListUsersCharactersRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCatalogItemsAsync({);
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/getcatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the character which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCharacterDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/character-data/getcharacterdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterDataResult> GetCharacterDataAsync(GetCharacterDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified character's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCharacterInventoryAsync({);
    ///   "CharacterId": "9890723423",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/getcharacterinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterInventoryResult> GetCharacterInventoryAsync(GetCharacterInventoryRequest request);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCharacterLeaderboardAsync({);
    ///   "CharacterType": "blue_warrior",
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/getcharacterleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterLeaderboardResult> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the character which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCharacterReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/character-data/getcharacterreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterDataResult> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCharacterStatisticsAsync({);
    ///   "CharacterId": "98765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/getcharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterStatisticsResult> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request);
    /// <summary>
    /// Retrieves the title-specific URL for Cloud Script servers. This must be queried once, prior to making any calls to
    /// RunCloudScript.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCloudScriptUrlAsync({);
    ///   "Version": 1,
    ///   "Testing": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/server-side-cloud-script/getcloudscripturl">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCloudScriptUrlResult> GetCloudScriptUrlAsync(GetCloudScriptUrlRequest request);
    /// <summary>
    /// This API retrieves a pre-signed URL for accessing a content file for the title. A subsequent HTTP GET to the returned
    /// URL will attempt to download the content. A HEAD query to the returned URL will attempt to retrieve the metadata of the
    /// content. Note that a successful result does not guarantee the existence of this content - if it has not been uploaded,
    /// the query to retrieve the data will fail. See this post for more information:
    /// https://community.playfab.com/hc/community/posts/205469488-How-to-upload-files-to-PlayFab-s-Content-Service. Also,
    /// please be aware that the Content service is specifically PlayFab's CDN offering, for which standard CDN rates apply.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetContentDownloadUrlAsync({);
    ///   "Key": "images/sword_icon.png"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/content/getcontentdownloadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<GetContentDownloadUrlResult> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request);
    /// <summary>
    /// Get details about all current running game servers matching the given parameters.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetCurrentGamesAsync({);
    ///   "Region": "USCentral",
    ///   "BuildVersion": "5.0.1",
    ///   "GameMode": "CaptureTheFlag",
    ///   "StatisticName": "level",
    ///   "TagFilter": {
    ///     "Includes": [
    ///       {
    ///         "Data": {
    ///           "level_cap": "0"
    ///         }
    ///       }
    ///     ],
    ///     "Excludes": [
    ///       {
    ///         "Data": {
    ///           "newbie": "0"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/matchmaking/getcurrentgames">Microsoft Documentation</see>
    /// </summary>
    public Task<CurrentGamesResult> GetCurrentGamesAsync(CurrentGamesRequest request);
    /// <summary>
    /// Retrieves a list of ranked friends of the current player for the given statistic, starting from the indicated point in
    /// the leaderboard
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetFriendLeaderboardAsync({);
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 1258,
    ///   "MaxResultsCount": 20,
    ///   "ExternalPlatformFriends": "Facebook, Xbox, Psn"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getfriendleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardResult> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request);
    /// <summary>
    /// Retrieves a list of ranked friends of the current player for the given statistic, centered on the currently signed-in
    /// user
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetFriendLeaderboardAroundCurrentUserAsync({);
    ///   "StatisticName": "Kills",
    ///   "MaxResultsCount": 20,
    ///   "ExternalPlatformFriends": "None"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getfriendleaderboardaroundcurrentuser">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFriendLeaderboardAroundCurrentUserResult> GetFriendLeaderboardAroundCurrentUserAsync(GetFriendLeaderboardAroundCurrentUserRequest request);
    /// <summary>
    /// Retrieves a list of ranked friends of the current player for the given statistic, centered on the requested PlayFab
    /// user. If PlayFabId is empty or null will return currently logged in user.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetFriendLeaderboardAroundPlayerAsync({);
    ///   "StatisticName": "Kills",
    ///   "MaxResultsCount": 20,
    ///   "ExternalPlatformFriends": "None"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getfriendleaderboardaroundplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFriendLeaderboardAroundPlayerResult> GetFriendLeaderboardAroundPlayerAsync(GetFriendLeaderboardAroundPlayerRequest request);
    /// <summary>
    /// Retrieves the current friend list for the local user, constrained to users who have PlayFab accounts. Friends from
    /// linked accounts (Facebook, Steam) are also included. You may optionally exclude some linked services' friends.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetFriendsListAsync({);
    ///   "ExternalPlatformFriends": "Steam"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/friend-list-management/getfriendslist">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFriendsListResult> GetFriendsListAsync(GetFriendsListRequest request);
    /// <summary>
    /// Get details about the regions hosting game servers matching the given parameters.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetGameServerRegionsAsync({);
    ///   "BuildVersion": "5.0.1",
    ///   "TitleId": "2074"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/matchmaking/getgameserverregions">Microsoft Documentation</see>
    /// </summary>
    public Task<GameServerRegionsResult> GetGameServerRegionsAsync(GameServerRegionsRequest request);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetLeaderboardAsync({);
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardResult> GetLeaderboardAsync(GetLeaderboardRequest request);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, centered on the requested Character ID
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetLeaderboardAroundCharacterAsync({);
    ///   "StatisticName": "Kills",
    ///   "CharacterId": "987343220",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/getleaderboardaroundcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardAroundCharacterResult> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, centered on the currently signed-in user
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetLeaderboardAroundCurrentUserAsync({);
    ///   "StatisticName": "Kills",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getleaderboardaroundcurrentuser">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardAroundCurrentUserResult> GetLeaderboardAroundCurrentUserAsync(GetLeaderboardAroundCurrentUserRequest request);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, centered on the requested player. If PlayFabId is empty or
    /// null will return currently logged in user.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetLeaderboardAroundPlayerAsync({);
    ///   "StatisticName": "Kills",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getleaderboardaroundplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardAroundPlayerResult> GetLeaderboardAroundPlayerAsync(GetLeaderboardAroundPlayerRequest request);
    /// <summary>
    /// Retrieves a list of all of the user's characters for the given statistic.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetLeaderboardForUserCharactersAsync({);
    ///   "StatisticName": "Kills"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/getleaderboardforusercharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardForUsersCharactersResult> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ For payments flows where the provider requires playfab (the fulfiller) to initiate the transaction, but the
    /// client completes the rest of the flow. In the Xsolla case, the token returned here will be passed to Xsolla by the
    /// client to create a cart. Poll GetPurchase using the returned OrderId once you've completed the payment.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPaymentTokenAsync({);
    ///   "TokenProvider": "xsolla"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/getpaymenttoken">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPaymentTokenResult> GetPaymentTokenAsync(GetPaymentTokenRequest request);
    /// <summary>
    /// Gets a Photon custom authentication token that can be used to securely join the player into a Photon room. See
    /// https://docs.microsoft.com/gaming/playfab/features/multiplayer/photon/quickstart for more details.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPhotonAuthenticationTokenAsync({);
    ///   "PhotonApplicationId": "acaa26f3-fcdb-4af4-8c76-3a3d4dd3066f"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/getphotonauthenticationtoken">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPhotonAuthenticationTokenResult> GetPhotonAuthenticationTokenAsync(GetPhotonAuthenticationTokenRequest request);
    /// <summary>
    /// Retrieves all of the user's different kinds of info.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerCombinedInfoAsync({);
    ///   "PlayFabId": "4027527BF22653D1",
    ///   "InfoRequestParameters": {
    ///     "GetUserAccountInfo": true,
    ///     "GetUserInventory": false,
    ///     "GetUserVirtualCurrency": true,
    ///     "GetUserData": true,
    ///     "UserDataKeys": [
    ///       "preferences",
    ///       "progress"
    ///     ],
    ///     "GetUserReadOnlyData": false,
    ///     "GetCharacterInventories": false,
    ///     "GetCharacterList": false,
    ///     "GetTitleData": false,
    ///     "GetPlayerStatistics": false,
    ///     "GetPlayerProfile": false,
    ///     "GetEntityLineage": false
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayercombinedinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerCombinedInfoResult> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request);
    /// <summary>
    /// Retrieves a title-specific custom property value for a player.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerCustomPropertyAsync({);
    ///   "PropertyName": "level"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getplayercustomproperty">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerCustomPropertyResult> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request);
    /// <summary>
    /// Retrieves the player's profile
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerProfileAsync({);
    ///   "PlayFabId": "621EF20237534A44"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayerprofile">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request);
    /// <summary>
    /// List all segments that a player currently belongs to at this moment in time.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerSegmentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/playstream/getplayersegments">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayerSegmentsRequest request);
    /// <summary>
    /// Retrieves the indicated statistics (current version and values for all statistics, if none are specified), for the
    /// local player.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerStatisticsAsync({);
    ///   "StatisticNames": [
    ///     "Points",
    ///     "Wins"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getplayerstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerStatisticsResult> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request);
    /// <summary>
    /// Retrieves the information on the available versions of the specified statistic.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerStatisticVersionsAsync({);
    ///   "StatisticName": "headshots"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getplayerstatisticversions">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request);
    /// <summary>
    /// Get all tags with a given Namespace (optional) from a player profile.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerTagsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "Namespace": "title.AAA"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/playstream/getplayertags">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request);
    /// <summary>
    /// Gets all trades the player has either opened or accepted, optionally filtered by trade status.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayerTradesAsync({);
    ///   "StatusFilter": "Filled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/trading/getplayertrades">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerTradesResponse> GetPlayerTradesAsync(GetPlayerTradesRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Battle.net account identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromBattleNetAccountIdsAsync({);
    ///   "BattleNetAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfrombattlenetaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromBattleNetAccountIdsResult> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromFacebookIDsAsync({);
    ///   "FacebookIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromfacebookids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromFacebookIDsResult> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook Instant Game identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromFacebookInstantGamesIdsAsync({);
    ///   "FacebookInstantGamesIds": [
    ///     "1114685845316172",
    ///     "1114685845316173"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromfacebookinstantgamesids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromFacebookInstantGamesIdsResult> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Game Center identifiers (referenced in the Game Center
    /// Programming Guide as the Player Identifier).
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromGameCenterIDsAsync({);
    ///   "GameCenterIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromgamecenterids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromGameCenterIDsResult> GetPlayFabIDsFromGameCenterIDsAsync(GetPlayFabIDsFromGameCenterIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of generic service identifiers. A generic identifier is the
    /// service name plus the service-specific ID for the player, as specified by the title when the generic identifier was
    /// added to the player account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromGenericIDsAsync({);
    ///   "GenericIDs": [
    ///     {
    ///       "ServiceName": "BigBizSocial",
    ///       "UserId": "1234567890"
    ///     },
    ///     {
    ///       "ServiceName": "VeeCeeMe",
    ///       "UserId": "og5igh85gf43gf"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromgenericids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromGenericIDsResult> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Google identifiers. The Google identifiers are the IDs
    /// for the user accounts, available as "id" in the Google+ People API calls.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromGoogleIDsAsync({);
    ///   "GoogleIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromgoogleids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromGoogleIDsResult> GetPlayFabIDsFromGoogleIDsAsync(GetPlayFabIDsFromGoogleIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Google Play Games identifiers. The Google Play Games
    /// identifiers are the IDs for the user accounts, available as "playerId" in the Google Play Games Services - Players API
    /// calls.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromGooglePlayGamesPlayerIDsAsync({);
    ///   "GooglePlayGamesPlayerIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromgoogleplaygamesplayerids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> GetPlayFabIDsFromGooglePlayGamesPlayerIDsAsync(GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Kongregate identifiers. The Kongregate identifiers are
    /// the IDs for the user accounts, available as "user_id" from the Kongregate API methods(ex:
    /// http://developers.kongregate.com/docs/client/getUserId).
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromKongregateIDsAsync({);
    ///   "KongregateIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromkongregateids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromKongregateIDsResult> GetPlayFabIDsFromKongregateIDsAsync(GetPlayFabIDsFromKongregateIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Service Account identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromNintendoServiceAccountIdsAsync({);
    ///   "NintendoAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromnintendoserviceaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromNintendoServiceAccountIdsResult> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Switch Device identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync({);
    ///   "NintendoSwitchDeviceIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromnintendoswitchdeviceids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromPSNAccountIDsAsync({);
    ///   "PSNAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfrompsnaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromPSNAccountIDsResult> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromPSNOnlineIDsAsync({);
    ///   "PSNOnlineIDs": [
    ///     "857555576495",
    ///     "759345551209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfrompsnonlineids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromPSNOnlineIDsResult> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are the profile
    /// IDs for the user accounts, available as SteamId in the Steamworks Community API calls.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromSteamIDsAsync({);
    ///   "SteamStringIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromsteamids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromSteamIDsResult> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are persona
    /// names.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromSteamNamesAsync({);
    ///   "SteamNames": [
    ///     "steamPersonaName1",
    ///     "steamPersonaName2"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromsteamnames">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromSteamNamesResult> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Twitch identifiers. The Twitch identifiers are the IDs
    /// for the user accounts, available as "_id" from the Twitch API methods (ex:
    /// https://github.com/justintv/Twitch-API/blob/master/v3_resources/users.md#get-usersuser).
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromTwitchIDsAsync({);
    ///   "TwitchIds": [
    ///     "127168541",
    ///     "88315720"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromtwitchids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromTwitchIDsResult> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of XboxLive identifiers.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPlayFabIDsFromXboxLiveIDsAsync({);
    ///   "XboxLiveAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ],
    ///   "Sandbox": "RETAIL"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getplayfabidsfromxboxliveids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromXboxLiveIDsResult> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request);
    /// <summary>
    /// Retrieves the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPublisherDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/getpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves a purchase along with its current PlayFab status. Returns inventory items from the purchase that
    /// are still active.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetPurchaseAsync({);
    ///   "OrderId": "8853591446005860822"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/getpurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPurchaseResult> GetPurchaseAsync(GetPurchaseRequest request);
    /// <summary>
    /// Retrieves data stored in a shared group object, as well as the list of members in the group. Non-members of the group
    /// may use this to retrieve group data, including membership, but they will not receive data for keys marked as private.
    /// Shared Groups are designed for sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetSharedGroupDataAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "Keys": [
    ///     "ClanKills",
    ///     "LastClanUpdate"
    ///   ],
    ///   "GetMembers": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/shared-group-data/getsharedgroupdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetSharedGroupDataResult> GetSharedGroupDataAsync(GetSharedGroupDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the set of items defined for the specified store, including all prices defined
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetStoreItemsAsync({);
    ///   "StoreId": "BonusStore"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/getstoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsRequest request);
    /// <summary>
    /// Retrieves the current server time
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetTimeAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/gettime">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTimeResult> GetTimeAsync(GetTimeRequest request);
    /// <summary>
    /// Retrieves the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetTitleDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/gettitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request);
    /// <summary>
    /// Retrieves the title news feed, as configured in the developer portal
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetTitleNewsAsync({);
    ///   "Count": 25
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/title-wide-data-management/gettitlenews">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitleNewsResult> GetTitleNewsAsync(GetTitleNewsRequest request);
    /// <summary>
    /// Returns the title's base 64 encoded RSA CSP blob.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetTitlePublicKeyAsync({);
    ///   "TitleId": "ID",
    ///   "TitleSharedSecret": "ExampleSecret"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/gettitlepublickey">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitlePublicKeyResult> GetTitlePublicKeyAsync(GetTitlePublicKeyRequest request);
    /// <summary>
    /// Gets the current status of an existing trade.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetTradeStatusAsync({);
    ///   "OfferingPlayerId": "CD803BF233CE76CC",
    ///   "TradeId": "D819CEC225EA9948C351"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/trading/gettradestatus">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTradeStatusResponse> GetTradeStatusAsync(GetTradeStatusRequest request);
    /// <summary>
    /// NOTE: This call will be deprecated soon. For fetching the data for a given user use GetPlayerCombinedInfo. For looking
    /// up users from the client api, we are in the process of adding a new api call. Once that call is ready, this one will be
    /// deprecated. Retrieves all requested data for a user in one unified request. By default, this API returns all data for
    /// the locally signed-in user. The input parameters may be used to limit the data retrieved to any subset of the available
    /// data, as well as retrieve the available data for a different user. Note that certain data, including inventory, virtual
    /// currency balances, and personally identifying information, may only be retrieved for the locally signed-in user. In the
    /// example below, a request is made for the account details, virtual currency balances, and specified user data for the
    /// locally signed-in user.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserCombinedInfoAsync({);
    ///   "GetInventory": false,
    ///   "UserDataKeys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "GetReadOnlyData": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/getusercombinedinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserCombinedInfoResult> GetUserCombinedInfoAsync(GetUserCombinedInfoRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserDataAsync({);
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the user's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserInventoryAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/getuserinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserPublisherDataAsync({);
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserPublisherReadOnlyDataAsync({);
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getuserpublisherreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserReadOnlyDataAsync({);
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getuserreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = clientApi.GetUserStatisticsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/getuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserStatisticsResult> GetUserStatisticsAsync(GetUserStatisticsRequest request);
    /// <summary>
    /// Grants the specified character type to the user. CharacterIds are not globally unique; characterId must be evaluated
    /// with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = clientApi.GrantCharacterToUserAsync({);
    ///   "CatalogVersion": "2.2",
    ///   "ItemId": "Blue Warrior",
    ///   "CharacterName": "FighterDude"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/grantcharactertouser">Microsoft Documentation</see>
    /// </summary>
    public Task<GrantCharacterToUserResult> GrantCharacterToUserAsync(GrantCharacterToUserRequest request);
    /// <summary>
    /// Links the Android device identifier to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkAndroidDeviceIDAsync({);
    ///   "AndroidDeviceId": "526f79204261747479",
    ///   "OS": "5.0",
    ///   "AndroidDevice": "Nexus 6"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkandroiddeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkAndroidDeviceIDResult> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest request);
    /// <summary>
    /// Links the Apple account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkAppleAsync({);
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkapple">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkAppleAsync(LinkAppleRequest request);
    /// <summary>
    /// Links the Battle.net account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkBattleNetAccountAsync({);
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest request);
    /// <summary>
    /// Links the custom identifier, generated by the title, to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkCustomIDAsync({);
    ///   "CustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkCustomIDResult> LinkCustomIDAsync(LinkCustomIDRequest request);
    /// <summary>
    /// Links the Facebook account associated with the provided Facebook access token to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkFacebookAccountAsync({);
    ///   "AccessToken": "FaceAccessTokenID"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkfacebookaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkFacebookAccountResult> LinkFacebookAccountAsync(LinkFacebookAccountRequest request);
    /// <summary>
    /// Links the Facebook Instant Games Id to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkFacebookInstantGamesIdAsync({);
    ///   "FacebookInstantGamesSignature": "abcdef"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkfacebookinstantgamesid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkFacebookInstantGamesIdResult> LinkFacebookInstantGamesIdAsync(LinkFacebookInstantGamesIdRequest request);
    /// <summary>
    /// Links the Game Center account associated with the provided Game Center ID to the user's PlayFab account. Logging in
    /// with a Game Center ID is insecure if you do not include the optional PublicKeyUrl, Salt, Signature, and Timestamp
    /// parameters in this request. It is recommended you require these parameters on all Game Center calls by going to the
    /// Apple Add-ons page in the PlayFab Game Manager and enabling the 'Require secure authentication only for this app'
    /// option.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkGameCenterAccountAsync({);
    ///   "GameCenterId": "2998h2998f0b000d0993"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkgamecenteraccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkGameCenterAccountResult> LinkGameCenterAccountAsync(LinkGameCenterAccountRequest request);
    /// <summary>
    /// Links the currently signed-in user account to their Google account, using their Google account credentials
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkGoogleAccountAsync({);
    ///   "ServerAuthCode": "4/TPdB1ter7eJ7cQ0lGBa6p1Cn-sSHJEXmPJ7t1-v4_ds#"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkgoogleaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkGoogleAccountResult> LinkGoogleAccountAsync(LinkGoogleAccountRequest request);
    /// <summary>
    /// Links the currently signed-in user account to their Google Play Games account, using their Google Play Games account
    /// credentials
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkGooglePlayGamesServicesAccountAsync({);
    ///   "ServerAuthCode": "4/TPdB1ter7eJ7cQ0lGBa6p1Cn-sSHJEXmPJ7t1-v4_ds#"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkgoogleplaygamesservicesaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkGooglePlayGamesServicesAccountResult> LinkGooglePlayGamesServicesAccountAsync(LinkGooglePlayGamesServicesAccountRequest request);
    /// <summary>
    /// Links the vendor-specific iOS device identifier to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkIOSDeviceIDAsync({);
    ///   "DeviceId": "29848d9bh8900a0b003",
    ///   "OS": "7.11",
    ///   "DeviceModel": "Iphone 5s"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkiosdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkIOSDeviceIDResult> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest request);
    /// <summary>
    /// Links the Kongregate identifier to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkKongregateAsync({);
    ///   "KongregateId": "457332",
    ///   "AuthTicket": "{123-456-78931212}"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkkongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkKongregateAccountResult> LinkKongregateAsync(LinkKongregateAccountRequest request);
    /// <summary>
    /// Links the Nintendo account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkNintendoServiceAccountAsync({);
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request);
    /// <summary>
    /// Links the NintendoSwitchDeviceId to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkNintendoSwitchDeviceIdAsync({);
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkNintendoSwitchDeviceIdResult> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request);
    /// <summary>
    /// Links an OpenID Connect account to a user's PlayFab account, based on an existing relationship between a title and an
    /// Open ID Connect provider and the OpenId Connect JWT from that provider.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkOpenIdConnectAsync({);
    ///   "ConnectionId": "exampleprovider",
    ///   "IdToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkopenidconnect">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkOpenIdConnectAsync(LinkOpenIdConnectRequest request);
    /// <summary>
    /// Links the PlayStation :tm: Network account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkPSNAccountAsync({);
    ///   "AuthCode": "LKJDG7DDE",
    ///   "RedirectUri": "orbis://games"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkPSNAccountResult> LinkPSNAccountAsync(LinkPSNAccountRequest request);
    /// <summary>
    /// Links the Steam account associated with the provided Steam authentication ticket to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkSteamAccountAsync({);
    ///   "SteamTicket": "steamTicketID",
    ///   "TicketIsServiceSpecific": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linksteamaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkSteamAccountResult> LinkSteamAccountAsync(LinkSteamAccountRequest request);
    /// <summary>
    /// Links the Twitch account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkTwitchAsync({);
    ///   "AccessToken": "TwitchAccessToken"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linktwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkTwitchAccountResult> LinkTwitchAsync(LinkTwitchAccountRequest request);
    /// <summary>
    /// Links the Xbox Live account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.LinkXboxAccountAsync({);
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/linkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkXboxAccountResult> LinkXboxAccountAsync(LinkXboxAccountRequest request);
    /// <summary>
    /// Retrieves title-specific custom property values for a player.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ListPlayerCustomPropertiesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/listplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<ListPlayerCustomPropertiesResult> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request);
    /// <summary>
    /// Logs a custom analytics event
    /// <example><br/>Example:<code>
    /// var response = clientApi.LogEventAsync({);
    ///   "EventName": "Headshot",
    ///   "Body": {
    ///     "victim": "B76543AEAE65",
    ///     "gun": "sniper_rifle",
    ///     "x_coord": 10,
    ///     "y_coord": 20,
    ///     "z_coord": 1,
    ///     "damage": 1000,
    ///     "aim_assist": false
    ///   },
    ///   "ProfileSetEvent": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/analytics/logevent">Microsoft Documentation</see>
    /// </summary>
    public Task<LogEventResult> LogEventAsync(LogEventRequest request);
    /// <summary>
    /// Signs the user in using the Android device identifier, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithAndroidDeviceIDAsync({);
    ///   "AndroidDeviceId": "526f79204261747479",
    ///   "OS": "5.0",
    ///   "AndroidDevice": "Nexus 6",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithandroiddeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request);
    /// <summary>
    /// Signs in the user with a Sign in with Apple identity token.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithAppleAsync({);
    ///   "IdentityToken": "eyJraWQi...",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithapple">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithAppleAsync(LoginWithAppleRequest request);
    /// <summary>
    /// Sign in the user with a Battle.net identity token
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithBattleNetAsync({);
    ///   "IdentityToken": "eyJraWQi...",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithbattlenet">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithBattleNetAsync(LoginWithBattleNetRequest request);
    /// <summary>
    /// Signs the user in using a custom unique identifier generated by the title, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithCustomIDAsync({);
    ///   "CustomId": "67AB-5397-CC54-EA31",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithCustomIDAsync(LoginWithCustomIDRequest request);
    /// <summary>
    /// Signs the user into the PlayFab account, returning a session identifier that can subsequently be used for API calls
    /// which require an authenticated user. Unlike most other login API calls, LoginWithEmailAddress does not permit the
    /// creation of new accounts via the CreateAccountFlag. Email addresses may be used to create accounts via
    /// RegisterPlayFabUser.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithEmailAddressAsync({);
    ///   "Email": "theuser@domain.com",
    ///   "Password": "thepassword",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithemailaddress">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest request);
    /// <summary>
    /// Signs the user in using a Facebook access token, returning a session identifier that can subsequently be used for API
    /// calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithFacebookAsync({);
    ///   "AccessToken": "FaceAccessTokenID",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithfacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithFacebookAsync(LoginWithFacebookRequest request);
    /// <summary>
    /// Signs the user in using a Facebook Instant Games ID, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user. Requires Facebook Instant Games to be configured.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithFacebookInstantGamesIdAsync({);
    ///   "FacebookInstantGamesSignature": "abcdef",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithfacebookinstantgamesid">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithFacebookInstantGamesIdAsync(LoginWithFacebookInstantGamesIdRequest request);
    /// <summary>
    /// Signs the user in using an iOS Game Center player identifier, returning a session identifier that can subsequently be
    /// used for API calls which require an authenticated user. Logging in with a Game Center ID is insecure if you do not
    /// include the optional PublicKeyUrl, Salt, Signature, and Timestamp parameters in this request. It is recommended you
    /// require these parameters on all Game Center calls by going to the Apple Add-ons page in the PlayFab Game Manager and
    /// enabling the 'Require secure authentication only for this app' option.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithGameCenterAsync({);
    ///   "PlayerId": "pachycephalosaurus01",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithgamecenter">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithGameCenterAsync(LoginWithGameCenterRequest request);
    /// <summary>
    /// Signs the user in using their Google account credentials
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithGoogleAccountAsync({);
    ///   "ServerAuthCode": "4/TPdB1ter7eJ7cQ0lGBa6p1Cn-sSHJEXmPJ7t1-v4_ds#",
    ///   "CreateAccount": false,
    ///   "SetEmail": true,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithgoogleaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest request);
    /// <summary>
    /// Signs the user in using their Google Play Games account credentials
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithGooglePlayGamesServicesAsync({);
    ///   "ServerAuthCode": "4/TPdB1ter7eJ7cQ0lGBa6p1Cn-sSHJEXmPJ7t1-v4_ds#",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithgoogleplaygamesservices">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithGooglePlayGamesServicesAsync(LoginWithGooglePlayGamesServicesRequest request);
    /// <summary>
    /// Signs the user in using the vendor-specific iOS device identifier, returning a session identifier that can subsequently
    /// be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithIOSDeviceIDAsync({);
    ///   "DeviceId": "29848d9bh8900a0b003",
    ///   "OS": "7.11",
    ///   "DeviceModel": "Iphone 5s",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithiosdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request);
    /// <summary>
    /// Signs the user in using a Kongregate player account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithKongregateAsync({);
    ///   "KongregateId": "457332",
    ///   "AuthTicket": "SomeKongregateTokenHere",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithkongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithKongregateAsync(LoginWithKongregateRequest request);
    /// <summary>
    /// Signs in the user with a Nintendo service account token.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithNintendoServiceAccountAsync({);
    ///   "IdentityToken": "eyJraWQi...",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithnintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithNintendoServiceAccountAsync(LoginWithNintendoServiceAccountRequest request);
    /// <summary>
    /// Signs the user in using a Nintendo Switch Device ID, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithNintendoSwitchDeviceIdAsync({);
    ///   "NintendoSwitchDeviceId": "526f79204261747479",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithnintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithNintendoSwitchDeviceIdAsync(LoginWithNintendoSwitchDeviceIdRequest request);
    /// <summary>
    /// Logs in a user with an Open ID Connect JWT created by an existing relationship between a title and an Open ID Connect
    /// provider.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithOpenIdConnectAsync({);
    ///   "ConnectionId": "exampleprovider",
    ///   "IdToken": "eyJraWQi...",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithopenidconnect">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithOpenIdConnectAsync(LoginWithOpenIdConnectRequest request);
    /// <summary>
    /// Signs the user into the PlayFab account, returning a session identifier that can subsequently be used for API calls
    /// which require an authenticated user. Unlike most other login API calls, LoginWithPlayFab does not permit the creation
    /// of new accounts via the CreateAccountFlag. Username/Password credentials may be used to create accounts via
    /// RegisterPlayFabUser, or added to existing accounts using AddUsernamePassword.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithPlayFabAsync({);
    ///   "Username": "theuser",
    ///   "Password": "ExampleSecret",
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithplayfab">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithPlayFabAsync(LoginWithPlayFabRequest request);
    /// <summary>
    /// Signs the user in using a PlayStation :tm: Network authentication code, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithPSNAsync({);
    ///   "AuthCode": "LKJ6D896D",
    ///   "RedirectUri": "orbis://games",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithpsn">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithPSNAsync(LoginWithPSNRequest request);
    /// <summary>
    /// Signs the user in using a Steam authentication ticket, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithSteamAsync({);
    ///   "SteamTicket": "steamTicketID",
    ///   "CreateAccount": false,
    ///   "TicketIsServiceSpecific": true,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithsteam">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithSteamAsync(LoginWithSteamRequest request);
    /// <summary>
    /// Signs the user in using a Twitch access token.
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithTwitchAsync({);
    ///   "AccessToken": "SomeTwitchTokenHere",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithtwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithTwitchAsync(LoginWithTwitchRequest request);
    /// <summary>
    /// Signs the user in using a Xbox Live Token, returning a session identifier that can subsequently be used for API calls
    /// which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = clientApi.LoginWithXboxAsync({);
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "CreateAccount": false,
    ///   "TitleId": "144"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/loginwithxbox">Microsoft Documentation</see>
    /// </summary>
    public Task<LoginResult> LoginWithXboxAsync(LoginWithXboxRequest request);
    /// <summary>
    /// Attempts to locate a game session matching the given parameters. If the goal is to match the player into a specific
    /// active session, only the LobbyId is required. Otherwise, the BuildVersion, GameMode, and Region are all required
    /// parameters. Note that parameters specified in the search are required (they are not weighting factors). If a slot is
    /// found in a server instance matching the parameters, the slot will be assigned to that player, removing it from the
    /// availabe set. In that case, the information on the game session will be returned, otherwise the Status returned will be
    /// GameNotFound.
    /// <example><br/>Example:<code>
    /// var response = clientApi.MatchmakeAsync({);
    ///   "BuildVersion": "5.01",
    ///   "Region": "USCentral",
    ///   "GameMode": "0",
    ///   "TagFilter": {
    ///     "Includes": [
    ///       {
    ///         "Data": {
    ///           "level_cap": "0"
    ///         }
    ///       }
    ///     ],
    ///     "Excludes": [
    ///       {
    ///         "Data": {
    ///           "newbie": "0"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/matchmaking/matchmake">Microsoft Documentation</see>
    /// </summary>
    public Task<MatchmakeResult> MatchmakeAsync(MatchmakeRequest request);
    /// <summary>
    /// Opens a new outstanding trade. Note that a given item instance may only be in one open trade at a time.
    /// <example><br/>Example:<code>
    /// var response = clientApi.OpenTradeAsync({);
    ///   "OfferedInventoryInstanceIds": [
    ///     "1359447",
    ///     "635691"
    ///   ],
    ///   "RequestedCatalogItemIds": [
    ///     "rare_hat_7"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/trading/opentrade">Microsoft Documentation</see>
    /// </summary>
    public Task<OpenTradeResponse> OpenTradeAsync(OpenTradeRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Selects a payment option for purchase order created via StartPurchase
    /// <example><br/>Example:<code>
    /// var response = clientApi.PayForPurchaseAsync({);
    ///   "OrderId": "8853591446005860822",
    ///   "ProviderName": "PayPal",
    ///   "Currency": "RM"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/payforpurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<PayForPurchaseResult> PayForPurchaseAsync(PayForPurchaseRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Buys a single item with virtual currency. You must specify both the virtual currency to use to purchase, as
    /// well as what the client believes the price to be. This lets the server fail the purchase if the price has changed.
    /// <example><br/>Example:<code>
    /// var response = clientApi.PurchaseItemAsync({);
    ///   "ItemId": "shield_level_5",
    ///   "VirtualCurrency": "GV",
    ///   "Price": 25
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/purchaseitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PurchaseItemResult> PurchaseItemAsync(PurchaseItemRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the virtual goods associated with the coupon to the user's inventory. Coupons can be generated via the
    /// Economy->Catalogs tab in the PlayFab Game Manager.
    /// <example><br/>Example:<code>
    /// var response = clientApi.RedeemCouponAsync({);
    ///   "CouponCode": "123-1234-123",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/redeemcoupon">Microsoft Documentation</see>
    /// </summary>
    public Task<RedeemCouponResult> RedeemCouponAsync(RedeemCouponRequest request);
    /// <summary>
    /// Uses the supplied OAuth code to refresh the internally cached player PlayStation :tm: Network auth token
    /// <example><br/>Example:<code>
    /// var response = clientApi.RefreshPSNAuthTokenAsync({);
    ///   "AuthCode": "LKJDG7DDE",
    ///   "RedirectUri": "orbis://games"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/refreshpsnauthtoken">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest request);
    /// <summary>
    /// Registers the iOS device to receive push notifications
    /// <example><br/>Example:<code>
    /// var response = clientApi.RegisterForIOSPushNotificationAsync({);
    ///   "DeviceToken": "39872f98eb882brn8hg3889",
    ///   "SendPushNotificationConfirmation": true,
    ///   "ConfirmationMessage": "Welcome to PlayFab"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/registerforiospushnotification">Microsoft Documentation</see>
    /// </summary>
    public Task<RegisterForIOSPushNotificationResult> RegisterForIOSPushNotificationAsync(RegisterForIOSPushNotificationRequest request);
    /// <summary>
    /// Registers a new Playfab user account, returning a session identifier that can subsequently be used for API calls which
    /// require an authenticated user. You must supply a username and an email address.
    /// <example><br/>Example:<code>
    /// var response = clientApi.RegisterPlayFabUserAsync({);
    ///   "Username": "theuser",
    ///   "Email": "me@here.com",
    ///   "Password": "ExampleSecret",
    ///   "TitleId": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/registerplayfabuser">Microsoft Documentation</see>
    /// </summary>
    public Task<RegisterPlayFabUserResult> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest request);
    /// <summary>
    /// Removes a contact email from the player's profile.
    /// <example><br/>Example:<code>
    /// var response = clientApi.RemoveContactEmailAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/removecontactemail">Microsoft Documentation</see>
    /// </summary>
    public Task<RemoveContactEmailResult> RemoveContactEmailAsync(RemoveContactEmailRequest request);
    /// <summary>
    /// Removes a specified user from the friend list of the local user
    /// <example><br/>Example:<code>
    /// var response = clientApi.RemoveFriendAsync({);
    ///   "FriendPlayFabId": "29837799"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/friend-list-management/removefriend">Microsoft Documentation</see>
    /// </summary>
    public Task<RemoveFriendResult> RemoveFriendAsync(RemoveFriendRequest request);
    /// <summary>
    /// Removes the specified generic service identifier from the player's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.RemoveGenericIDAsync({);
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/removegenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<RemoveGenericIDResult> RemoveGenericIDAsync(RemoveGenericIDRequest request);
    /// <summary>
    /// Removes users from the set of those able to update the shared data and the set of users in the group. Only users in the
    /// group can remove members. If as a result of the call, zero users remain with access, the group and its associated data
    /// will be deleted. Shared Groups are designed for sharing data between a very small number of players, please see our
    /// guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = clientApi.RemoveSharedGroupMembersAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/shared-group-data/removesharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<RemoveSharedGroupMembersResult> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request);
    /// <summary>
    /// Report player's ad activity
    /// <example><br/>Example:<code>
    /// var response = clientApi.ReportAdActivityAsync({);
    ///   "PlacementId": "A124572382B",
    ///   "RewardId": "B2674981A",
    ///   "Activity": "End"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/advertising/reportadactivity">Microsoft Documentation</see>
    /// </summary>
    public Task<ReportAdActivityResult> ReportAdActivityAsync(ReportAdActivityRequest request);
    /// <summary>
    /// Write a PlayStream event to describe the provided player device information. This API method is not designed to be
    /// called directly by developers. Each PlayFab client SDK will eventually report this information automatically.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ReportDeviceInfoAsync({);
    ///   "Info": {
    ///     "UserAgent": "Some Browser",
    ///     "ScreenResolution": "640x480",
    ///     "processorCount": "2"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/analytics/reportdeviceinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> ReportDeviceInfoAsync(DeviceInfoRequest request);
    /// <summary>
    /// Submit a report for another player (due to bad bahavior, etc.), so that customer service representatives for the title
    /// can take action concerning potentially toxic players.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ReportPlayerAsync({);
    ///   "ReporteeId": "1a46086aed40f142",
    ///   "Comment": "cheating"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/reportplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<ReportPlayerClientResult> ReportPlayerAsync(ReportPlayerClientRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Restores all in-app purchases based on the given restore receipt
    /// <example><br/>Example:<code>
    /// var response = clientApi.RestoreIOSPurchasesAsync({);
    ///   "ReceiptData": "F00000000000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/restoreiospurchases">Microsoft Documentation</see>
    /// </summary>
    public Task<RestoreIOSPurchasesResult> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest request);
    /// <summary>
    /// Reward player's ad activity
    /// <example><br/>Example:<code>
    /// var response = clientApi.RewardAdActivityAsync({);
    ///   "PlacementId": "A124572382B",
    ///   "RewardId": "B2674981A"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/advertising/rewardadactivity">Microsoft Documentation</see>
    /// </summary>
    public Task<RewardAdActivityResult> RewardAdActivityAsync(RewardAdActivityRequest request);
    /// <summary>
    /// Triggers a particular server action, passing the provided inputs to the hosted Cloud Script. An action in this context
    /// is a handler in the JavaScript. NOTE: Before calling this API, you must call GetCloudScriptUrl to be assigned a Cloud
    /// Script server URL. When using an official PlayFab SDK, this URL is stored internally in the SDK, but GetCloudScriptUrl
    /// must still be manually called.
    /// <example><br/>Example:<code>
    /// var response = clientApi.RunCloudScriptAsync({);
    ///   "ActionId": "onLevelComplete",
    ///   "ParamsEncoded": "{\"level\":1}"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/server-side-cloud-script/runcloudscript">Microsoft Documentation</see>
    /// </summary>
    public Task<RunCloudScriptResult> RunCloudScriptAsync(RunCloudScriptRequest request);
    /// <summary>
    /// Forces an email to be sent to the registered email address for the user's account, with a link allowing the user to
    /// change the password.If an account recovery email template ID is provided, an email using the custom email template will
    /// be used.
    /// <example><br/>Example:<code>
    /// var response = clientApi.SendAccountRecoveryEmailAsync({);
    ///   "Email": "Me@here.com",
    ///   "TitleId": "1000",
    ///   "EmailTemplateId": "D53AB15D8F12E330"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/sendaccountrecoveryemail">Microsoft Documentation</see>
    /// </summary>
    public Task<SendAccountRecoveryEmailResult> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request);
    /// <summary>
    /// Updates the tag list for a specified user in the friend list of the local user
    /// <example><br/>Example:<code>
    /// var response = clientApi.SetFriendTagsAsync({);
    ///   "FriendPlayFabId": "29837799",
    ///   "Tags": [
    ///     "great sniper",
    ///     "no good at melee"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/friend-list-management/setfriendtags">Microsoft Documentation</see>
    /// </summary>
    public Task<SetFriendTagsResult> SetFriendTagsAsync(SetFriendTagsRequest request);
    /// <summary>
    /// Sets the player's secret if it is not already set. Player secrets are used to sign API requests. To reset a player's
    /// secret use the Admin or Server API method SetPlayerSecret.
    /// <example><br/>Example:<code>
    /// var response = clientApi.SetPlayerSecretAsync({);
    ///   "PlayerSecret": "A cryptographically strong string"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/authentication/setplayersecret">Microsoft Documentation</see>
    /// </summary>
    public Task<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request);
    /// <summary>
    /// Start a new game server with a given configuration, add the current player and return the connection information.
    /// <example><br/>Example:<code>
    /// var response = clientApi.StartGameAsync({);
    ///   "BuildVersion": "5.01",
    ///   "Region": "EUWest",
    ///   "GameMode": "0",
    ///   "CustomCommandLineData": "custom_gameserver_commandline_parameter"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/matchmaking/startgame">Microsoft Documentation</see>
    /// </summary>
    public Task<StartGameResult> StartGameAsync(StartGameRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Creates an order for a list of items from the title catalog
    /// <example><br/>Example:<code>
    /// var response = clientApi.StartPurchaseAsync({);
    ///   "CatalogVersion": "0",
    ///   "StoreId": "BonusStore",
    ///   "Items": [
    ///     {
    ///       "ItemId": "something",
    ///       "Quantity": 1,
    ///       "Annotation": "totally buying something"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/startpurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<StartPurchaseResult> StartPurchaseAsync(StartPurchaseRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the user's balance of the specified virtual currency by the stated amount. It is possible to
    /// make a VC balance negative with this API.
    /// <example><br/>Example:<code>
    /// var response = clientApi.SubtractUserVirtualCurrencyAsync({);
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/subtractuservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request);
    /// <summary>
    /// Unlinks the related Android device identifier from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkAndroidDeviceIDAsync({);
    ///   "AndroidDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkandroiddeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkAndroidDeviceIDResult> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest request);
    /// <summary>
    /// Unlinks the related Apple account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkAppleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkapple">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkAppleAsync(UnlinkAppleRequest request);
    /// <summary>
    /// Unlinks the related Battle.net account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkBattleNetAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest request);
    /// <summary>
    /// Unlinks the related custom identifier from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkCustomIDAsync({);
    ///   "CustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkCustomIDResult> UnlinkCustomIDAsync(UnlinkCustomIDRequest request);
    /// <summary>
    /// Unlinks the related Facebook account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkFacebookAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkfacebookaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkFacebookAccountResult> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest request);
    /// <summary>
    /// Unlinks the related Facebook Instant Game Ids from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkFacebookInstantGamesIdAsync({);
    ///   "FacebookInstantGamesId": "1114685845316173"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkfacebookinstantgamesid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkFacebookInstantGamesIdResult> UnlinkFacebookInstantGamesIdAsync(UnlinkFacebookInstantGamesIdRequest request);
    /// <summary>
    /// Unlinks the related Game Center account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkGameCenterAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkgamecenteraccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkGameCenterAccountResult> UnlinkGameCenterAccountAsync(UnlinkGameCenterAccountRequest request);
    /// <summary>
    /// Unlinks the related Google account from the user's PlayFab account
    /// (https://developers.google.com/android/reference/com/google/android/gms/auth/GoogleAuthUtil#public-methods).
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkGoogleAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkgoogleaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkGoogleAccountResult> UnlinkGoogleAccountAsync(UnlinkGoogleAccountRequest request);
    /// <summary>
    /// Unlinks the related Google Play Games account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkGooglePlayGamesServicesAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkgoogleplaygamesservicesaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkGooglePlayGamesServicesAccountResult> UnlinkGooglePlayGamesServicesAccountAsync(UnlinkGooglePlayGamesServicesAccountRequest request);
    /// <summary>
    /// Unlinks the related iOS device identifier from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkIOSDeviceIDAsync({);
    ///   "DeviceId": "29848d9bh8900a0b003"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkiosdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkIOSDeviceIDResult> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest request);
    /// <summary>
    /// Unlinks the related Kongregate identifier from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkKongregateAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkkongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkKongregateAccountResult> UnlinkKongregateAsync(UnlinkKongregateAccountRequest request);
    /// <summary>
    /// Unlinks the related Nintendo account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkNintendoServiceAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request);
    /// <summary>
    /// Unlinks the related NintendoSwitchDeviceId from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkNintendoSwitchDeviceIdAsync({);
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkNintendoSwitchDeviceIdResult> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request);
    /// <summary>
    /// Unlinks an OpenID Connect account from a user's PlayFab account, based on the connection ID of an existing relationship
    /// between a title and an Open ID Connect provider.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkOpenIdConnectAsync({);
    ///   "ConnectionId": "exampleprovider"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkopenidconnect">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkOpenIdConnectAsync(UnlinkOpenIdConnectRequest request);
    /// <summary>
    /// Unlinks the related PlayStation :tm: Network account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkPSNAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkPSNAccountResult> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request);
    /// <summary>
    /// Unlinks the related Steam account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkSteamAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinksteamaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkSteamAccountResult> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest request);
    /// <summary>
    /// Unlinks the related Twitch account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkTwitchAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinktwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkTwitchAccountResult> UnlinkTwitchAsync(UnlinkTwitchAccountRequest request);
    /// <summary>
    /// Unlinks the related Xbox Live account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlinkXboxAccountAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/unlinkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkXboxAccountResult> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Opens the specified container, with the specified key (when required), and returns the contents of the
    /// opened container. If the container (and key when relevant) are consumable (RemainingUses > 0), their RemainingUses will
    /// be decremented, consistent with the operation of ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlockContainerInstanceAsync({);
    ///   "ContainerItemInstanceId": "123456788",
    ///   "KeyItemInstanceId": "123456789"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/unlockcontainerinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlockContainerItemResult> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Searches target inventory for an ItemInstance matching the given CatalogItemId, if necessary unlocks it
    /// using an appropriate key, and returns the contents of the opened container. If the container (and key when relevant)
    /// are consumable (RemainingUses > 0), their RemainingUses will be decremented, consistent with the operation of
    /// ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UnlockContainerItemAsync({);
    ///   "ContainerItemId": "crate block 1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-item-management/unlockcontaineritem">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlockContainerItemResult> UnlockContainerItemAsync(UnlockContainerItemRequest request);
    /// <summary>
    /// Update the avatar URL of the player
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateAvatarUrlAsync({);
    ///   "ImageUrl": "https://www.gravatar.com/avatar/205e460b479e2e5b48aec07710c08d50"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/updateavatarurl">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request);
    /// <summary>
    /// Creates and updates the title-specific custom data for the user's character which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateCharacterDataAsync({);
    ///   "CharacterId": "98765456",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/character-data/updatecharacterdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterDataResult> UpdateCharacterDataAsync(UpdateCharacterDataRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the specific character. By default, clients are not
    /// permitted to update statistics. Developers may override this setting in the Game Manager > Settings > API Features.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateCharacterStatisticsAsync({);
    ///   "CharacterId": "98765432",
    ///   "CharacterStatistics": {
    ///     "Headshots": 18,
    ///     "Kills": 47
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/characters/updatecharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterStatisticsResult> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request);
    /// <summary>
    /// Updates the title-specific custom property values for a player
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdatePlayerCustomPropertiesAsync({);
    ///   "Properties": [
    ///     {
    ///       "Name": "level",
    ///       "Value": 5
    ///     },
    ///     {
    ///       "Name": "created",
    ///       "Value": false
    ///     }
    ///   ],
    ///   "ExpectedPropertiesVersion": 12
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/updateplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdatePlayerCustomPropertiesResult> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user. By default, clients are not permitted to
    /// update statistics. Developers may override this setting in the Game Manager > Settings > API Features.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdatePlayerStatisticsAsync({);
    ///   "Statistics": [
    ///     {
    ///       "StatisticName": "Points",
    ///       "Version": 1,
    ///       "Value": 600
    ///     },
    ///     {
    ///       "StatisticName": "Wins",
    ///       "Version": 0,
    ///       "Value": 16
    ///     },
    ///     {
    ///       "StatisticName": "Stars",
    ///       "Value": 7
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/updateplayerstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdatePlayerStatisticsResult> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request);
    /// <summary>
    /// Adds, updates, and removes data keys for a shared group object. If the permission is set to Public, all fields updated
    /// or added in this call will be readable by users not in the group. By default, data permissions are set to Private.
    /// Regardless of the permission setting, only members of the group can update the data. Shared Groups are designed for
    /// sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateSharedGroupDataAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "Data": {
    ///     "ClanKills": "34",
    ///     "LastClanUpdate": "2014-10-03T09:21:14Z"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/shared-group-data/updatesharedgroupdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateSharedGroupDataResult> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request);
    /// <summary>
    /// Creates and updates the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateUserDataAsync({);
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/updateuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Creates and updates the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateUserPublisherDataAsync({);
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/updateuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user. By default, clients are not permitted to
    /// update statistics. Developers may override this setting in the Game Manager > Settings > API Features.
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateUserStatisticsAsync({);
    ///   "UserStatistics": {
    ///     "Headshots": 18,
    ///     "Kills": 47
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/player-data-management/updateuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserStatisticsResult> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request);
    /// <summary>
    /// Updates the title specific display name for the user
    /// <example><br/>Example:<code>
    /// var response = clientApi.UpdateUserTitleDisplayNameAsync({);
    ///   "DisplayName": "User Title Name"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/account-management/updateusertitledisplayname">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserTitleDisplayNameResult> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Validates with Amazon that the receipt for an Amazon App Store in-app purchase is valid and that it matches
    /// the purchased catalog item
    /// <example><br/>Example:<code>
    /// var response = clientApi.ValidateAmazonIAPReceiptAsync({);
    ///   "ReceiptId": "q1YqVbJSyjH28DGPKChw9c0o8nd3vSstssQtzSkrzM8tCk43K6z0d_HOTcwwN8vxCrVV0lEqBmpJzs_VK8hJrExLTNLLTCzQK8_MSUnJTy8LSpcoWRnoKKUAFRmaGBtZmBqCCFMzpVoA",
    ///   "UserId": "l3HL7XppEMhrOGDgur9-ulvqomrSg6qyODKmah72lJU="
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/validateamazoniapreceipt">Microsoft Documentation</see>
    /// </summary>
    public Task<ValidateAmazonReceiptResult> ValidateAmazonIAPReceiptAsync(ValidateAmazonReceiptRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Validates a Google Play purchase and gives the corresponding item to the player.
    /// <example><br/>Example:<code>
    /// var response = clientApi.ValidateGooglePlayPurchaseAsync({);
    ///   "ReceiptJson": "{\"orderId\":\"12999763169054705758.1375794066587622\",\"packageName\":\"com.playfab.android.testbed\",\"productId\":\"com.playfab.android.permatest.consumable\",\"purchaseTime\":1410891177231,\"purchaseState\":0,\"purchaseToken\":\"eaflhokdkobkmomjadmoobgb.AO-J1OwoLkW2cqvBcPEgk6SfGceQpOHALMUFmJYeawa-GuDFtl3oKct-5D28t_KvNscFiJOFiWXIS74vJBYg-CGFJgyrdbxalKEMPzXZrg5nLomCME-jIVFAUrzcPah-_66KPImG5ftsMJKI9uzldqEF9OPcakUEmt-kWoXAsl_6-9HH0gBCwh4\"}",
    ///   "Signature": "ks12w0hHHpuit4xW3Fyoa5XX6TkxZ2KpEnBsLfpHHpeakYs2JgVtlLdgyLp/05Zp8oHAuKZyIAJTd2RIFXWMAUwDNUsI0JPBDMpr2oaL66Kuneg4VrGWJkJZTrvTyQoGpnTDdXfEME31iFKX6CrKHvWlAG9nwWxYatd58l83eevQ8CIrJhka/bC5ynw3j18OmFG7AcxymO37a4HkM8QjytvAYDJeOnDU9mooY7afcHIajtffdyAU9kzGWOqDByiU9IsRdkliwQoQYbuX/R5wQnMVZ+FGDDwO1mybx9B20rm7/WCBnWGy2NLsSAFI77iX8tUy/QebfBQhrVnRORi7bw==",
    ///   "CurrencyCode": "USD",
    ///   "PurchasePrice": 199
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/validategoogleplaypurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<ValidateGooglePlayPurchaseResult> ValidateGooglePlayPurchaseAsync(ValidateGooglePlayPurchaseRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Validates with the Apple store that the receipt for an iOS in-app purchase is valid and that it matches the
    /// purchased catalog item
    /// <example><br/>Example:<code>
    /// var response = clientApi.ValidateIOSReceiptAsync({);
    ///   "ReceiptData": "MTExMTExMTExMTENCjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMg0KMzMzMzMzMzMzMzMzMzMzMzMNCjQ0NDQ0NDQ0NDQ0NDQNCjU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NQ0KNjY2NjY2NjY2NjY2Ng0KNzc3Nzc3Nzc3Nzc3NzcNCjg4DQo5OTk5OTk5OTk5OTkNCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMA0KMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTENCjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjINCjMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMw0KNDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0DQo1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1DQo2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2Ng0KNzc3Nzc3Nzc3NzcNCjg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4DQo5DQpBcHBsZSBJbmMuIFdvcmxkd2lkZSBEZXZlbG9wZXIgUmVsYXRpb25zIENlcnRpZmljYXRpb24gQXV0aG9yaXR5IChub3QgcmVhbGx5IC0gZmFrZSBQbGF5RmFiIGV4YW1wbGUsIGJ1dCBjb25ncmF0cyBvbiB0aGlua2luZyB0byBkZWNvZGUgdGhpcyEpDQowMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwDQoxMTExMTExMTExMQ0KMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyDQozMzMzMzMzMzMzMzMzMzMzMw0KNDQ0NDQ0NDQ0NDQ0NA0KNTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1DQo2NjY2NjY2NjY2NjY2DQo3Nzc3Nzc3Nzc3Nzc3Nw0KODgNCjk5OTk5OTk5OTk5OQ0KMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwDQoxMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMQ0KMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMg0KMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzDQo0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQNCjU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTUNCjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2DQo3Nzc3Nzc3Nzc3Nw0KODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODgNCjkNCkFwcGxlIEluYy4gV29ybGR3aWRlIERldmVsb3BlciBSZWxhdGlvbnMgQ2VydGlmaWNhdGlvbiBBdXRob3JpdHkgKG5vdCByZWFsbHkgLSBmYWtlIFBsYXlGYWIgZXhhbXBsZSwgYnV0IGNvbmdyYXRzIG9uIHRoaW5raW5nIHRvIGRlY29kZSB0aGlzISkNCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDANCjExMTExMTExMTExDQoyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjINCjMzMzMzMzMzMzMzMzMzMzMzDQo0NDQ0NDQ0NDQ0NDQ0DQo1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTUNCjY2NjY2NjY2NjY2NjYNCjc3Nzc3Nzc3Nzc3Nzc3DQo4OA0KOTk5OTk5OTk5OTk5DQowMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDANCjExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExDQoyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyDQozMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMNCjQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NA0KNTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NQ0KNjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjYNCjc3Nzc3Nzc3Nzc3DQo4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4OA0KOQ0KQXBwbGUgSW5jLiBXb3JsZHdpZGUgRGV2ZWxvcGVyIFJlbGF0aW9ucyBDZXJ0aWZpY2F0aW9uIEF1dGhvcml0eSAobm90IHJlYWxseSAtIGZha2UgUGxheUZhYiBleGFtcGxlLCBidXQgY29uZ3JhdHMgb24gdGhpbmtpbmcgdG8gZGVjb2RlIHRoaXMhKQ0KMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMA0KMTExMTExMTExMTENCjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMg0KMzMzMzMzMzMzMzMzMzMzMzMNCjQ0NDQ0NDQ0NDQ0NDQNCjU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NQ0KNjY2NjY2NjY2NjY2Ng0KNzc3Nzc3Nzc3Nzc3NzcNCjg4DQo5OTk5OTk5OTk5OTkNCjAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMA0KMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTExMTENCjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjINCjMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMzMw0KNDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0NDQ0DQo1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1NTU1DQo2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2Ng0KNzc3Nzc3Nzc3NzcNCjg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4ODg4DQo5DQpBcHBsZSBJbmMuIFdvcmxkd2lkZSBEZXZlbG9wZXIgUmVsYXRpb25zIENlcnRpZmljYXRpb24gQXV0aG9yaXR5IChub3QgcmVhbGx5IC0gZmFrZSBQbGF5RmFiIGV4YW1wbGUsIGJ1dCBjb25ncmF0cyBvbiB0aGlua2luZyB0byBkZWNvZGUgdGhpcyEpDQowMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAw",
    ///   "CurrencyCode": "GBP",
    ///   "PurchasePrice": 199
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/validateiosreceipt">Microsoft Documentation</see>
    /// </summary>
    public Task<ValidateIOSReceiptResult> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Validates with Windows that the receipt for an Windows App Store in-app purchase is valid and that it
    /// matches the purchased catalog item
    /// <example><br/>Example:<code>
    /// var response = clientApi.ValidateWindowsStoreReceiptAsync({);
    ///   "Receipt": "<Receipt Version=\"1.0\" ReceiptDate=\"2012-08-30T23:10:05Z\" CertificateId=\"b809e47cd0110a4db043b3f73e83acd917fe1336\" ReceiptDeviceId=\"4e362949-acc3-fe3a-e71b-89893eb4f528\">\r\n    <AppReceipt Id=\"8ffa256d-eca8-712a-7cf8-cbf5522df24b\" AppId=\"55428GreenlakeApps.CurrentAppSimulatorEventTest_z7q3q7z11crfr\" PurchaseDate=\"2012-06-04T23:07:24Z\" LicenseType=\"Full\" />\r\n    <ProductReceipt Id=\"6bbf4366-6fb2-8be8-7947-92fd5f683530\" ProductId=\"Product1\" PurchaseDate=\"2012-08-30T23:08:52Z\" ExpirationDate=\"2012-09-02T23:08:49Z\" ProductType=\"Durable\" AppId=\"55428GreenlakeApps.CurrentAppSimulatorEventTest_z7q3q7z11crfr\" />\r\n    <Signature xmlns=\"http://www.w3.org/2000/09/xmldsig#\">\r\n        <SignedInfo>\r\n            <CanonicalizationMethod Algorithm=\"http://www.w3.org/2001/10/xml-exc-c14n#\" />\r\n            <SignatureMethod Algorithm=\"http://www.w3.org/2001/04/xmldsig-more#rsa-sha256\" />\r\n            <Reference URI=\"\">\r\n                <Transforms>\r\n                    <Transform Algorithm=\"http://www.w3.org/2000/09/xmldsig#enveloped-signature\" />\r\n                </Transforms>\r\n                <DigestMethod Algorithm=\"http://www.w3.org/2001/04/xmlenc#sha256\" />\r\n                <DigestValue>cdiU06eD8X/w1aGCHeaGCG9w/kWZ8I099rw4mmPpvdU=</DigestValue>\r\n            </Reference>\r\n        </SignedInfo>\r\n        <SignatureValue>SjRIxS/2r2P6ZdgaR9bwUSa6ZItYYFpKLJZrnAa3zkMylbiWjh9oZGGng2p6/gtBHC2dSTZlLbqnysJjl7mQp/A3wKaIkzjyRXv3kxoVaSV0pkqiPt04cIfFTP0JZkE5QD/vYxiWjeyGp1dThEM2RV811sRWvmEs/hHhVxb32e8xCLtpALYx3a9lW51zRJJN0eNdPAvNoiCJlnogAoTToUQLHs72I1dECnSbeNPXiG7klpy5boKKMCZfnVXXkneWvVFtAA1h2sB7ll40LEHO4oYN6VzD+uKd76QOgGmsu9iGVyRvvmMtahvtL1/pxoxsTRedhKq6zrzCfT8qfh3C1w==</SignatureValue>\r\n    </Signature>\r\n</Receipt>\r\n"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/platform-specific-methods/validatewindowsstorereceipt">Microsoft Documentation</see>
    /// </summary>
    public Task<ValidateWindowsReceiptResult> ValidateWindowsStoreReceiptAsync(ValidateWindowsReceiptRequest request);
    /// <summary>
    /// Writes a character-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = clientApi.WriteCharacterEventAsync({);
    ///   "CharacterId": "E161CB4B7F6C34B",
    ///   "EventName": "character_defeated_enemy",
    ///   "Timestamp": "2016-03-07T00:00:00Z",
    ///   "Body": {
    ///     "Enemy": "guardian",
    ///     "Damage": 5,
    ///     "Coordinates": {
    ///       "X": 123.4,
    ///       "Y": 543.2
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/analytics/writecharacterevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WriteCharacterEventAsync(WriteClientCharacterEventRequest request);
    /// <summary>
    /// Writes a player-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = clientApi.WritePlayerEventAsync({);
    ///   "EventName": "player_defeated_enemy",
    ///   "Timestamp": "2014-03-07T00:00:00Z",
    ///   "Body": {
    ///     "Enemy": "guardian",
    ///     "Damage": 5,
    ///     "Coordinates": {
    ///       "X": 123.4,
    ///       "Y": 543.2
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/analytics/writeplayerevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WritePlayerEventAsync(WriteClientPlayerEventRequest request);
    /// <summary>
    /// Writes a title-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = clientApi.WriteTitleEventAsync({);
    ///   "EventName": "client_update_submitted",
    ///   "Timestamp": "2016-03-07T00:00:00Z",
    ///   "Body": {
    ///     "Version": "1.4.50"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/client/analytics/writetitleevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WriteTitleEventAsync(WriteTitleEventRequest request);
}