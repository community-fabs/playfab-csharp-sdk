using CommunityFabs.NET.Sdk.Models.Server;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabServerApi {
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the character's balance of the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddCharacterVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "CharacterId": "23424524523",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/addcharactervirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyCharacterVirtualCurrencyResult> AddCharacterVirtualCurrencyAsync(AddCharacterVirtualCurrencyRequest request);
    /// <summary>
    /// Adds the Friend user to the friendlist of the user with PlayFabId. At least one of
    /// FriendPlayFabId,FriendUsername,FriendEmail, or FriendTitleDisplayName should be initialized.
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddFriendAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "FriendPlayFabId": "20394883"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/addfriend">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> AddFriendAsync(AddFriendRequest request);
    /// <summary>
    /// Adds the specified generic service identifier to the player's PlayFab account. This is designed to allow for a PlayFab
    /// ID lookup of any arbitrary service identifier a title wants to add. This identifier should never be used as
    /// authentication credentials, as the intent is that it is easily accessible by other players.
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddGenericIDAsync({);
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/addgenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> AddGenericIDAsync(AddGenericIDRequest request);
    /// <summary>
    /// Adds a given tag to a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddPlayerTagAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/addplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<AddPlayerTagResult> AddPlayerTagAsync(AddPlayerTagRequest request);
    /// <summary>
    /// Adds users to the set of those able to update both the shared data, as well as the set of users in the group. Only
    /// users in the group (and the server) can add new members. Shared Groups are designed for sharing data between a very
    /// small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddSharedGroupMembersAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/addsharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<AddSharedGroupMembersResult> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the user's balance of the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = serverApi.AddUserVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/adduservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyUserVirtualCurrencyResult> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request);
    /// <summary>
    /// Validated a client's session ticket, and if successful, returns details for that user
    /// <example><br/>Example:<code>
    /// var response = serverApi.AuthenticateSessionTicketAsync({);
    ///   "SessionTicket": "4D2----8D11F4249A80000-7C64AB0A9F1D8D1A.CD803BF233CE76CC"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/authenticatesessionticket">Microsoft Documentation</see>
    /// </summary>
    public Task<AuthenticateSessionTicketResult> AuthenticateSessionTicketAsync(AuthenticateSessionTicketRequest request);
    /// <summary>
    /// Awards the specified users the specified Steam achievements
    /// <example><br/>Example:<code>
    /// var response = serverApi.AwardSteamAchievementAsync({);
    ///   "Achievements": [
    ///     {
    ///       "PlayFabId": "234974573892",
    ///       "AchievementName": "FinishLevel1",
    ///       "Result": false
    ///     },
    ///     {
    ///       "PlayFabId": "334353433",
    ///       "AchievementName": "FinishLevel1",
    ///       "Result": false
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/platform-specific-methods/awardsteamachievement">Microsoft Documentation</see>
    /// </summary>
    public Task<AwardSteamAchievementResult> AwardSteamAchievementAsync(AwardSteamAchievementRequest request);
    /// <summary>
    /// Bans users by PlayFab ID with optional IP address, or MAC address for the provided game.
    /// <example><br/>Example:<code>
    /// var response = serverApi.BanUsersAsync({);
    ///   "Bans": [
    ///     {
    ///       "PlayFabId": "1679AF5CD04BD838",
    ///       "IPAddress": "192.168.1.1",
    ///       "Reason": "You cheated!",
    ///       "DurationInHours": 7
    ///     },
    ///     {
    ///       "PlayFabId": "2329AF5CD04BF513",
    ///       "Reason": "Caught you using speed hack!"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/banusers">Microsoft Documentation</see>
    /// </summary>
    public Task<BanUsersResult> BanUsersAsync(BanUsersRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Consume uses of a consumable item. When all uses are consumed, it will be removed from the player's
    /// inventory.
    /// <example><br/>Example:<code>
    /// var response = serverApi.ConsumeItemAsync({);
    ///   "ItemInstanceId": "94585729",
    ///   "ConsumeCount": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/consumeitem">Microsoft Documentation</see>
    /// </summary>
    public Task<ConsumeItemResult> ConsumeItemAsync(ConsumeItemRequest request);
    /// <summary>
    /// Requests the creation of a shared group object, containing key/value pairs which may be updated by all members of the
    /// group. When created by a server, the group will initially have no members. Shared Groups are designed for sharing data
    /// between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.CreateSharedGroupAsync({);
    ///   "SharedGroupId": "Clan Data"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/createsharedgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateSharedGroupResult> CreateSharedGroupAsync(CreateSharedGroupRequest request);
    /// <summary>
    /// Deletes the specific character ID from the specified user.
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeleteCharacterFromUserAsync({);
    ///   "PlayFabId": "12345",
    ///   "CharacterId": "98765432",
    ///   "SaveCharacterInventory": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/deletecharacterfromuser">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteCharacterFromUserResult> DeleteCharacterFromUserAsync(DeleteCharacterFromUserRequest request);
    /// <summary>
    /// Removes a user's player account from a title and deletes all associated data
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeletePlayerAsync({);
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/deleteplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePlayerResult> DeletePlayerAsync(DeletePlayerRequest request);
    /// <summary>
    /// Deletes title-specific custom properties for a player
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeletePlayerCustomPropertiesAsync({);
    ///   "PlayFabId": "2039475",
    ///   "PropertyNames": [
    ///     "level",
    ///     "created"
    ///   ],
    ///   "ExpectedPropertiesVersion": 12
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/deleteplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePlayerCustomPropertiesResult> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request);
    /// <summary>
    /// Deletes push notification template for title
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeletePushNotificationTemplateAsync({);
    ///   "PushNotificationTemplateId": "6bc7dbf0-075a-46e9-8e84-35737a22c6a4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/deletepushnotificationtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePushNotificationTemplateResult> DeletePushNotificationTemplateAsync(DeletePushNotificationTemplateRequest request);
    /// <summary>
    /// Deletes a shared group, freeing up the shared group ID to be reused for a new group. Shared Groups are designed for
    /// sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeleteSharedGroupAsync({);
    ///   "SharedGroupId": "Clan Data"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/deletesharedgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteSharedGroupAsync(DeleteSharedGroupRequest request);
    /// <summary>
    /// Deletes custom data, all account linkages, and statistics.
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeleteUsersAsync({);
    ///   "PlayFabIds": [
    ///     "203945882"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/deleteusers">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteUsersResult> DeleteUsersAsync(DeleteUsersRequest request);
    /// <summary>
    /// Inform the matchmaker that a Game Server Instance is removed.
    /// <example><br/>Example:<code>
    /// var response = serverApi.DeregisterGameAsync({);
    ///   "LobbyId": "8285313"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/deregistergame">Microsoft Documentation</see>
    /// </summary>
    public Task<DeregisterGameResponse> DeregisterGameAsync(DeregisterGameRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Returns the result of an evaluation of a Random Result Table - the ItemId from the game Catalog which would
    /// have been added to the player inventory, if the Random Result Table were added via a Bundle or a call to
    /// UnlockContainer.
    /// <example><br/>Example:<code>
    /// var response = serverApi.EvaluateRandomResultTableAsync({);
    ///   "TableId": "RareElementCard",
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/evaluaterandomresulttable">Microsoft Documentation</see>
    /// </summary>
    public Task<EvaluateRandomResultTableResult> EvaluateRandomResultTableAsync(EvaluateRandomResultTableRequest request);
    /// <summary>
    /// Executes a CloudScript function, with the 'currentPlayerId' set to the PlayFab ID of the authenticated player. The
    /// PlayFab ID is the entity ID of the player's master_player_account entity.
    /// <example><br/>Example:<code>
    /// var response = serverApi.ExecuteCloudScriptAsync({);
    ///   "PlayFabId": "1337D00D",
    ///   "FunctionName": "levelCompleted",
    ///   "FunctionParameter": {
    ///     "level": 3,
    ///     "points": 400
    ///   },
    ///   "RevisionSelection": "Live",
    ///   "GeneratePlayStreamEvent": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/server-side-cloud-script/executecloudscript">Microsoft Documentation</see>
    /// </summary>
    public Task<ExecuteCloudScriptResult> ExecuteCloudScriptAsync(ExecuteCloudScriptServerRequest request);
    /// <summary>
    /// Retrieve a list of all PlayStream actions groups.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetAllActionGroupsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getallactiongroups">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAllActionGroupsResult> GetAllActionGroupsAsync(GetAllActionGroupsRequest request);
    /// <summary>
    /// Retrieves an array of player segment definitions. Results from this can be used in subsequent API calls such as
    /// GetPlayersInSegment which requires a Segment ID. While segment names can change the ID for that segment will not change.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetAllSegmentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getallsegments">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAllSegmentsResult> GetAllSegmentsAsync(GetAllSegmentsRequest request);
    /// <summary>
    /// Lists all of the characters that belong to a specific user. CharacterIds are not globally unique; characterId must be
    /// evaluated with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetAllUsersCharactersAsync({);
    ///   "PlayFabId": "98333765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getalluserscharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<ListUsersCharactersResult> GetAllUsersCharactersAsync(ListUsersCharactersRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCatalogItemsAsync({);
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getcatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCatalogItemsResult> GetCatalogItemsAsync(GetCatalogItemsRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/getcharacterdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterDataResult> GetCharacterDataAsync(GetCharacterDataRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user's character which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/getcharacterinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterDataResult> GetCharacterInternalDataAsync(GetCharacterDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified character's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterInventoryAsync({);
    ///   "PlayFabId": "204883457",
    ///   "CharacterId": "9890723423",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/getcharacterinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterInventoryResult> GetCharacterInventoryAsync(GetCharacterInventoryRequest request);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterLeaderboardAsync({);
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getcharacterleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterLeaderboardResult> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user's character which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/getcharacterreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterDataResult> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the specific character
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetCharacterStatisticsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "CharacterId": "98765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getcharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetCharacterStatisticsResult> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request);
    /// <summary>
    /// This API retrieves a pre-signed URL for accessing a content file for the title. A subsequent HTTP GET to the returned
    /// URL will attempt to download the content. A HEAD query to the returned URL will attempt to retrieve the metadata of the
    /// content. Note that a successful result does not guarantee the existence of this content - if it has not been uploaded,
    /// the query to retrieve the data will fail. See this post for more information:
    /// https://community.playfab.com/hc/community/posts/205469488-How-to-upload-files-to-PlayFab-s-Content-Service. Also,
    /// please be aware that the Content service is specifically PlayFab's CDN offering, for which standard CDN rates apply.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetContentDownloadUrlAsync({);
    ///   "Key": "images/sword_icon.png"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/content/getcontentdownloadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<GetContentDownloadUrlResult> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request);
    /// <summary>
    /// Retrieves a list of ranked friends of the given player for the given statistic, starting from the indicated point in
    /// the leaderboard
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetFriendLeaderboardAsync({);
    ///   "PlayFabId": "98092347523",
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 1258,
    ///   "MaxResultsCount": 20,
    ///   "ExternalPlatformFriends": "None"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getfriendleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardResult> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request);
    /// <summary>
    /// Retrieves the current friends for the user with PlayFabId, constrained to users who have PlayFab accounts. Friends from
    /// linked accounts (Facebook, Steam) are also included. You may optionally exclude some linked services' friends.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetFriendsListAsync({);
    ///   "PlayFabId": "93798903892789754",
    ///   "ExternalPlatformFriends": "All"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/getfriendslist">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFriendsListResult> GetFriendsListAsync(GetFriendsListRequest request);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetLeaderboardAsync({);
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardResult> GetLeaderboardAsync(GetLeaderboardRequest request);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, centered on the requested user
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetLeaderboardAroundCharacterAsync({);
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331",
    ///   "CharacterId": "987343220",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getleaderboardaroundcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardAroundCharacterResult> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, centered on the currently signed-in user
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetLeaderboardAroundUserAsync({);
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getleaderboardarounduser">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardAroundUserResult> GetLeaderboardAroundUserAsync(GetLeaderboardAroundUserRequest request);
    /// <summary>
    /// Retrieves a list of all of the user's characters for the given statistic.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetLeaderboardForUserCharactersAsync({);
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getleaderboardforusercharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardForUsersCharactersResult> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request);
    /// <summary>
    /// Returns whatever info is requested in the response for the user. Note that PII (like email address, facebook id) may be
    /// returned. All parameters default to false.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerCombinedInfoAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayercombinedinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerCombinedInfoResult> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request);
    /// <summary>
    /// Retrieves a title-specific custom property value for a player.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerCustomPropertyAsync({);
    ///   "PlayFabId": "2039475",
    ///   "PropertyName": "level"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayercustomproperty">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerCustomPropertyResult> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request);
    /// <summary>
    /// Retrieves the player's profile
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerProfileAsync({);
    ///   "PlayFabId": "621EF20237534A44"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayerprofile">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerProfileResult> GetPlayerProfileAsync(GetPlayerProfileRequest request);
    /// <summary>
    /// List all segments that a player currently belongs to at this moment in time.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerSegmentsAsync({);
    ///   "PlayFabId": "1337AA00"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayersegments">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerSegmentsResult> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request);
    /// <summary>
    /// Allows for paging through all players in a given segment. This API creates a snapshot of all player profiles that match
    /// the segment definition at the time of its creation and lives through the Total Seconds to Live, refreshing its life
    /// span on each subsequent use of the Continuation Token. Profiles that change during the course of paging will not be
    /// reflected in the results. AB Test segments are currently not supported by this operation. NOTE: This API is limited to
    /// being called 30 times in one minute. You will be returned an error if you exceed this threshold.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayersInSegmentAsync({);
    ///   "SegmentId": "1337AA00",
    ///   "SecondsToLive": 5,
    ///   "MaxBatchSize": 500
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayersinsegment">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayersInSegmentResult> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request);
    /// <summary>
    /// Retrieves the current version and values for the indicated statistics, for the local player.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerStatisticsAsync({);
    ///   "PlayFabId": "621EF2023753444",
    ///   "StatisticNames": [
    ///     "Points",
    ///     "Wins"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayerstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerStatisticsResult> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request);
    /// <summary>
    /// Retrieves the information on the available versions of the specified statistic.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerStatisticVersionsAsync({);
    ///   "StatisticName": "headshots"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayerstatisticversions">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerStatisticVersionsResult> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request);
    /// <summary>
    /// Get all tags with a given Namespace (optional) from a player profile.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayerTagsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "Namespace": "title.AAA"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayertags">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayerTagsResult> GetPlayerTagsAsync(GetPlayerTagsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Battle.net account identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromBattleNetAccountIdsAsync({);
    ///   "BattleNetAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrombattlenetaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromBattleNetAccountIdsResult> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromFacebookIDsAsync({);
    ///   "FacebookIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromfacebookids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromFacebookIDsResult> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook Instant Games identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromFacebookInstantGamesIdsAsync({);
    ///   "FacebookInstantGamesIds": [
    ///     "1114685845316172",
    ///     "1114685845316173"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromfacebookinstantgamesids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromFacebookInstantGamesIdsResult> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of generic service identifiers. A generic identifier is the
    /// service name plus the service-specific ID for the player, as specified by the title when the generic identifier was
    /// added to the player account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromGenericIDsAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromgenericids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromGenericIDsResult> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Service Account identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromNintendoServiceAccountIdsAsync({);
    ///   "NintendoAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromnintendoserviceaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromNintendoServiceAccountIdsResult> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Switch Device identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync({);
    ///   "NintendoSwitchDeviceIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromnintendoswitchdeviceids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromPSNAccountIDsAsync({);
    ///   "PSNAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrompsnaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromPSNAccountIDsResult> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromPSNOnlineIDsAsync({);
    ///   "PSNOnlineIDs": [
    ///     "857555576495",
    ///     "759345551209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrompsnonlineids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromPSNOnlineIDsResult> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are the profile
    /// IDs for the user accounts, available as SteamId in the Steamworks Community API calls.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromSteamIDsAsync({);
    ///   "SteamStringIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromsteamids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromSteamIDsResult> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are persona
    /// names.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromSteamNamesAsync({);
    ///   "SteamNames": [
    ///     "steamPersonaName1",
    ///     "steamPersonaName2"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromsteamnames">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromSteamNamesResult> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Twitch identifiers. The Twitch identifiers are the IDs
    /// for the user accounts, available as "_id" from the Twitch API methods (ex:
    /// https://github.com/justintv/Twitch-API/blob/master/v3_resources/users.md#get-usersuser).
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromTwitchIDsAsync({);
    ///   "TwitchIds": [
    ///     "127168541",
    ///     "88315720"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromtwitchids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromTwitchIDsResult> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of XboxLive identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPlayFabIDsFromXboxLiveIDsAsync({);
    ///   "XboxLiveAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ],
    ///   "Sandbox": "RETAIL"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromxboxliveids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPlayFabIDsFromXboxLiveIDsResult> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request);
    /// <summary>
    /// Retrieves the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetPublisherDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPublisherDataResult> GetPublisherDataAsync(GetPublisherDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the configuration information for the specified random results tables for the title, including
    /// all ItemId values and weights
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetRandomResultTablesAsync({);
    ///   "CatalogVersion": "1",
    ///   "TableIDs": [
    ///     "CommonElementCard",
    ///     "UncommonElementCard",
    ///     "RareElementCard"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/getrandomresulttables">Microsoft Documentation</see>
    /// </summary>
    public Task<GetRandomResultTablesResult> GetRandomResultTablesAsync(GetRandomResultTablesRequest request);
    /// <summary>
    /// Retrieves the associated PlayFab account identifiers for the given set of server custom identifiers.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetServerCustomIDsFromPlayFabIDsAsync({);
    ///   "PlayFabIDs": [
    ///     "1232421311"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getservercustomidsfromplayfabids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetServerCustomIDsFromPlayFabIDsResult> GetServerCustomIDsFromPlayFabIDsAsync(GetServerCustomIDsFromPlayFabIDsRequest request);
    /// <summary>
    /// Retrieves data stored in a shared group object, as well as the list of members in the group. The server can access all
    /// public and private group data. Shared Groups are designed for sharing data between a very small number of players,
    /// please see our guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetSharedGroupDataAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "Keys": [
    ///     "ClanKills",
    ///     "LastClanUpdate"
    ///   ],
    ///   "GetMembers": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/getsharedgroupdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetSharedGroupDataResult> GetSharedGroupDataAsync(GetSharedGroupDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the set of items defined for the specified store, including all prices defined, for the specified
    /// player
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetStoreItemsAsync({);
    ///   "StoreId": "BonusStore",
    ///   "PlayFabId": "20394883"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getstoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStoreItemsResult> GetStoreItemsAsync(GetStoreItemsServerRequest request);
    /// <summary>
    /// Retrieves the current server time
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetTimeAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettime">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTimeResult> GetTimeAsync(GetTimeRequest request);
    /// <summary>
    /// Retrieves the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetTitleDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitleDataResult> GetTitleDataAsync(GetTitleDataRequest request);
    /// <summary>
    /// Retrieves the key-value store of custom internal title settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetTitleInternalDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitleDataResult> GetTitleInternalDataAsync(GetTitleDataRequest request);
    /// <summary>
    /// Retrieves the title news feed, as configured in the developer portal
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetTitleNewsAsync({);
    ///   "Count": 25
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitlenews">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitleNewsResult> GetTitleNewsAsync(GetTitleNewsRequest request);
    /// <summary>
    /// Retrieves the relevant details for a specified user
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserAccountInfoAsync({);
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getuseraccountinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserAccountInfoResult> GetUserAccountInfoAsync(GetUserAccountInfoRequest request);
    /// <summary>
    /// Gets all bans for a user.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserBansAsync({);
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getuserbans">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserBansResult> GetUserBansAsync(GetUserBansRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserInternalDataAsync(GetUserDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified user's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserInventoryAsync({);
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/getuserinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserInventoryResult> GetUserInventoryAsync(GetUserInventoryRequest request);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserPublisherDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserPublisherDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserPublisherInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserpublisherinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserPublisherInternalDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserPublisherReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserpublisherreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserDataResult> GetUserReadOnlyDataAsync(GetUserDataRequest request);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = serverApi.GetUserStatisticsAsync({);
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetUserStatisticsResult> GetUserStatisticsAsync(GetUserStatisticsRequest request);
    /// <summary>
    /// Grants the specified character type to the user. CharacterIds are not globally unique; characterId must be evaluated
    /// with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = serverApi.GrantCharacterToUserAsync({);
    ///   "PlayFabId": "20394883567",
    ///   "CharacterName": "FighterDude",
    ///   "CharacterType": "Blue Warrior"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/grantcharactertouser">Microsoft Documentation</see>
    /// </summary>
    public Task<GrantCharacterToUserResult> GrantCharacterToUserAsync(GrantCharacterToUserRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified character's inventory
    /// <example><br/>Example:<code>
    /// var response = serverApi.GrantItemsToCharacterAsync({);
    ///   "CharacterId": "9876543268",
    ///   "PlayFabId": "20394883",
    ///   "Annotation": "Entered Level 2",
    ///   "ItemIds": [
    ///     "shield_level_5",
    ///     "shield_level_6"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/grantitemstocharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<GrantItemsToCharacterResult> GrantItemsToCharacterAsync(GrantItemsToCharacterRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified user's inventory
    /// <example><br/>Example:<code>
    /// var response = serverApi.GrantItemsToUserAsync({);
    ///   "PlayFabId": "20394883",
    ///   "Annotation": "Entered Level 2",
    ///   "ItemIds": [
    ///     "shield_level_3",
    ///     "shield_level_4"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/grantitemstouser">Microsoft Documentation</see>
    /// </summary>
    public Task<GrantItemsToUserResult> GrantItemsToUserAsync(GrantItemsToUserRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified user inventories
    /// <example><br/>Example:<code>
    /// var response = serverApi.GrantItemsToUsersAsync({);
    ///   "CatalogVersion": "5",
    ///   "ItemGrants": [
    ///     {
    ///       "PlayFabId": "20394883",
    ///       "ItemId": "shield_level_1",
    ///       "Annotation": "Entered Level 2"
    ///     },
    ///     {
    ///       "PlayFabId": "20394883",
    ///       "ItemId": "shield_level_2",
    ///       "Annotation": "Entered Level 2",
    ///       "Data": {
    ///         "Equipped": "True",
    ///         "Slot": "Head"
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/grantitemstousers">Microsoft Documentation</see>
    /// </summary>
    public Task<GrantItemsToUsersResult> GrantItemsToUsersAsync(GrantItemsToUsersRequest request);
    /// <summary>
    /// Links the Battle.net account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkBattleNetAccountAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest request);
    /// <summary>
    /// Links the Nintendo account associated with the token to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkNintendoServiceAccountAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request);
    /// <summary>
    /// Links the Nintendo account associated with the Nintendo Service Account subject or id to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkNintendoServiceAccountSubjectAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "Subject": "8e7Eju4j9"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoserviceaccountsubject">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> LinkNintendoServiceAccountSubjectAsync(LinkNintendoServiceAccountSubjectRequest request);
    /// <summary>
    /// Links the NintendoSwitchDeviceId to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkNintendoSwitchDeviceIdAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkNintendoSwitchDeviceIdResult> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request);
    /// <summary>
    /// Links the PlayStation :tm: Network account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkPSNAccountAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "AuthCode": "LKJDG7DDE",
    ///   "RedirectUri": "orbis://games"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkPSNAccountResult> LinkPSNAccountAsync(LinkPSNAccountRequest request);
    /// <summary>
    /// Links the PlayStation :tm: Network account associated with the provided user id to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkPSNIdAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "PSNUserId": "LKJDG7DDE"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkpsnid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkPSNIdResponse> LinkPSNIdAsync(LinkPSNIdRequest request);
    /// <summary>
    /// Links the custom server identifier, generated by the title, to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkServerCustomIdAsync({);
    ///   "PlayFabId": "123412341234",
    ///   "ServerCustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkServerCustomIdResult> LinkServerCustomIdAsync(LinkServerCustomIdRequest request);
    /// <summary>
    /// Links the Steam account associated with the provided Steam ID to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkSteamIdAsync({);
    ///   "SteamId": "22223333",
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linksteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkSteamIdResult> LinkSteamIdAsync(LinkSteamIdRequest request);
    /// <summary>
    /// Links the Xbox Live account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.LinkXboxAccountAsync({);
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<LinkXboxAccountResult> LinkXboxAccountAsync(LinkXboxAccountRequest request);
    /// <summary>
    /// Retrieves title-specific custom property values for a player.
    /// <example><br/>Example:<code>
    /// var response = serverApi.ListPlayerCustomPropertiesAsync({);
    ///   "PlayFabId": "2039475"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/listplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<ListPlayerCustomPropertiesResult> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request);
    /// <summary>
    /// Logs a custom analytics event
    /// <example><br/>Example:<code>
    /// var response = serverApi.LogEventAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/analytics/logevent">Microsoft Documentation</see>
    /// </summary>
    public Task<LogEventResult> LogEventAsync(LogEventRequest request);
    /// <summary>
    /// Signs the user in using the Android device identifier, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithAndroidDeviceIDAsync({);
    ///   "AndroidDeviceId": "526f79204261747479",
    ///   "OS": "5.0",
    ///   "AndroidDevice": "Nexus 6",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithandroiddeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request);
    /// <summary>
    /// Sign in the user with a Battle.net identity token
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithBattleNetAsync({);
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithbattlenet">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithBattleNetAsync(LoginWithBattleNetRequest request);
    /// <summary>
    /// Signs the user in using a custom unique identifier generated by the title, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithCustomIDAsync({);
    ///   "CustomId": "67AB-5397-CC54-EA31",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithCustomIDAsync(LoginWithCustomIDRequest request);
    /// <summary>
    /// Signs the user in using the iOS device identifier, returning a session identifier that can subsequently be used for API
    /// calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithIOSDeviceIDAsync({);
    ///   "DeviceId": "29848d9bh8900a0b003",
    ///   "OS": "7.11",
    ///   "DeviceModel": "Iphone 5s",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithiosdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request);
    /// <summary>
    /// Signs the user in using a PlayStation :tm: Network authentication code, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithPSNAsync({);
    ///   "AuthCode": "LKJ6D896D",
    ///   "RedirectUri": "orbis://games",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithpsn">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithPSNAsync(LoginWithPSNRequest request);
    /// <summary>
    /// Securely login a game client from an external server backend using a custom identifier for that player. Server Custom
    /// ID and Client Custom ID are mutually exclusive and cannot be used to retrieve the same player account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithServerCustomIdAsync({);
    ///   "ServerCustomId": "asdalsdkjar09u23ijf",
    ///   "CreateAccount": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithServerCustomIdAsync(LoginWithServerCustomIdRequest request);
    /// <summary>
    /// Signs the user in using an Steam ID, returning a session identifier that can subsequently be used for API calls which
    /// require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithSteamIdAsync({);
    ///   "SteamId": "12344553",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithsteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithSteamIdAsync(LoginWithSteamIdRequest request);
    /// <summary>
    /// Signs the user in using a Xbox Live Token from an external server backend, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithXboxAsync({);
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithxbox">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithXboxAsync(LoginWithXboxRequest request);
    /// <summary>
    /// Signs the user in using an Xbox ID and Sandbox ID, returning a session identifier that can subsequently be used for API
    /// calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = serverApi.LoginWithXboxIdAsync({);
    ///   "XboxId": "12344553",
    ///   "Sandbox": "RETAIL",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithxboxid">Microsoft Documentation</see>
    /// </summary>
    public Task<ServerLoginResult> LoginWithXboxIdAsync(LoginWithXboxIdRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Modifies the number of remaining uses of a player's inventory item
    /// <example><br/>Example:<code>
    /// var response = serverApi.ModifyItemUsesAsync({);
    ///   "PlayFabId": "20394883",
    ///   "ItemInstanceId": "94585729",
    ///   "UsesToAdd": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/modifyitemuses">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyItemUsesResult> ModifyItemUsesAsync(ModifyItemUsesRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a character's inventory into another of the users's character's inventory.
    /// <example><br/>Example:<code>
    /// var response = serverApi.MoveItemToCharacterFromCharacterAsync({);
    ///   "PlayFabId": "234234897234",
    ///   "GivingCharacterId": "98092347523",
    ///   "ReceivingCharacterId": "6323489712",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtocharacterfromcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<MoveItemToCharacterFromCharacterResult> MoveItemToCharacterFromCharacterAsync(MoveItemToCharacterFromCharacterRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a user's inventory into their character's inventory.
    /// <example><br/>Example:<code>
    /// var response = serverApi.MoveItemToCharacterFromUserAsync({);
    ///   "PlayFabId": "234234897234",
    ///   "CharacterId": "98092347523",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtocharacterfromuser">Microsoft Documentation</see>
    /// </summary>
    public Task<MoveItemToCharacterFromUserResult> MoveItemToCharacterFromUserAsync(MoveItemToCharacterFromUserRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a character's inventory into the owning user's inventory.
    /// <example><br/>Example:<code>
    /// var response = serverApi.MoveItemToUserFromCharacterAsync({);
    ///   "PlayFabId": "234234897234",
    ///   "CharacterId": "98092347523",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtouserfromcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<MoveItemToUserFromCharacterResult> MoveItemToUserFromCharacterAsync(MoveItemToUserFromCharacterRequest request);
    /// <summary>
    /// Informs the PlayFab match-making service that the user specified has left the Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = serverApi.NotifyMatchmakerPlayerLeftAsync({);
    ///   "LobbyId": "29439584",
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/notifymatchmakerplayerleft">Microsoft Documentation</see>
    /// </summary>
    public Task<NotifyMatchmakerPlayerLeftResult> NotifyMatchmakerPlayerLeftAsync(NotifyMatchmakerPlayerLeftRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the virtual goods associated with the coupon to the user's inventory. Coupons can be generated via the
    /// Economy->Catalogs tab in the PlayFab Game Manager.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RedeemCouponAsync({);
    ///   "CouponCode": "123-1234-123",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/redeemcoupon">Microsoft Documentation</see>
    /// </summary>
    public Task<RedeemCouponResult> RedeemCouponAsync(RedeemCouponRequest request);
    /// <summary>
    /// Validates a Game Server session ticket and returns details about the user
    /// <example><br/>Example:<code>
    /// var response = serverApi.RedeemMatchmakerTicketAsync({);
    ///   "Ticket": "2398349939a03499bc",
    ///   "LobbyId": "2353"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/redeemmatchmakerticket">Microsoft Documentation</see>
    /// </summary>
    public Task<RedeemMatchmakerTicketResult> RedeemMatchmakerTicketAsync(RedeemMatchmakerTicketRequest request);
    /// <summary>
    /// Set the state of the indicated Game Server Instance. Also update the heartbeat for the instance.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RefreshGameServerInstanceHeartbeatAsync({);
    ///   "LobbyId": "29439584"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/refreshgameserverinstanceheartbeat">Microsoft Documentation</see>
    /// </summary>
    public Task<RefreshGameServerInstanceHeartbeatResult> RefreshGameServerInstanceHeartbeatAsync(RefreshGameServerInstanceHeartbeatRequest request);
    /// <summary>
    /// Inform the matchmaker that a new Game Server Instance is added.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RegisterGameAsync({);
    ///   "ServerHost": "118.129.31.244",
    ///   "ServerPort": "9984",
    ///   "Build": "11_034234.13",
    ///   "Region": "USEast",
    ///   "GameMode": "FreeForAll",
    ///   "Tags": {
    ///     "level_cap": "high",
    ///     "no_smoking": "1"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/registergame">Microsoft Documentation</see>
    /// </summary>
    public Task<RegisterGameResponse> RegisterGameAsync(RegisterGameRequest request);
    /// <summary>
    /// Removes the specified friend from the the user's friend list
    /// <example><br/>Example:<code>
    /// var response = serverApi.RemoveFriendAsync({);
    ///   "FriendPlayFabId": "29837799",
    ///   "PlayFabId": "1a46086aed40f142"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/removefriend">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> RemoveFriendAsync(RemoveFriendRequest request);
    /// <summary>
    /// Removes the specified generic service identifier from the player's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RemoveGenericIDAsync({);
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/removegenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResult> RemoveGenericIDAsync(RemoveGenericIDRequest request);
    /// <summary>
    /// Remove a given tag from a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RemovePlayerTagAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/removeplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<RemovePlayerTagResult> RemovePlayerTagAsync(RemovePlayerTagRequest request);
    /// <summary>
    /// Removes users from the set of those able to update the shared data and the set of users in the group. Only users in the
    /// group can remove members. If as a result of the call, zero users remain with access, the group and its associated data
    /// will be deleted. Shared Groups are designed for sharing data between a very small number of players, please see our
    /// guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.RemoveSharedGroupMembersAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/removesharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<RemoveSharedGroupMembersResult> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request);
    /// <summary>
    /// Submit a report about a player (due to bad bahavior, etc.) on behalf of another player, so that customer service
    /// representatives for the title can take action concerning potentially toxic players.
    /// <example><br/>Example:<code>
    /// var response = serverApi.ReportPlayerAsync({);
    ///   "ReporterId": "9ddafe27d6d445da",
    ///   "ReporteeId": "1a46086aed40f142",
    ///   "Comment": "cheating"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/reportplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<ReportPlayerServerResult> ReportPlayerAsync(ReportPlayerServerRequest request);
    /// <summary>
    /// Revoke all active bans for a user.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RevokeAllBansForUserAsync({);
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/revokeallbansforuser">Microsoft Documentation</see>
    /// </summary>
    public Task<RevokeAllBansForUserResult> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request);
    /// <summary>
    /// Revoke all active bans specified with BanId.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RevokeBansAsync({);
    ///   "BanIds": [
    ///     "E0B5FF89542D413C",
    ///     "EF43FF89542G1546"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/revokebans">Microsoft Documentation</see>
    /// </summary>
    public Task<RevokeBansResult> RevokeBansAsync(RevokeBansRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access to an item in a user's inventory
    /// <example><br/>Example:<code>
    /// var response = serverApi.RevokeInventoryItemAsync({);
    ///   "PlayFabId": "203945882",
    ///   "ItemInstanceId": "2048583045"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/revokeinventoryitem">Microsoft Documentation</see>
    /// </summary>
    public Task<RevokeInventoryResult> RevokeInventoryItemAsync(RevokeInventoryItemRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access for up to 25 items across multiple users and characters.
    /// <example><br/>Example:<code>
    /// var response = serverApi.RevokeInventoryItemsAsync({);
    ///   "Items": [
    ///     {
    ///       "PlayFabId": "203945882",
    ///       "ItemInstanceId": "2048583045"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/revokeinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<RevokeInventoryItemsResult> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request);
    /// <summary>
    /// Saves push notification template for title
    /// <example><br/>Example:<code>
    /// var response = serverApi.SavePushNotificationTemplateAsync({);
    ///   "Id": "6bc7dbf0-075a-46e9-8e84-35737a22c6a4",
    ///   "Name": "F8763A987E",
    ///   "AndroidPayload": "{       notification:      {          body: \"Some Message\",          title: \"Subject\",          body_loc_key: \"someLocKey\"     } }",
    ///   "IOSPayload": "{       aps:      {          alert:          {          body: \"Some Message\",          title: \"Subject\",          \"loc-key\": \"someLocKey\"         }      } }",
    ///   "LocalizedPushNotificationTemplates": {
    ///     "en": {
    ///       "Subject": "Recent Attack",
    ///       "Message": "You have been attacked! Go defend your base!"
    ///     },
    ///     "fr": {
    ///       "Subject": "Attaque récente",
    ///       "Message": "Vous avez été attaqué! Va défendre ta base!"
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/savepushnotificationtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<SavePushNotificationTemplateResult> SavePushNotificationTemplateAsync(SavePushNotificationTemplateRequest request);
    /// <summary>
    /// Forces an email to be sent to the registered contact email address for the user's account based on an account recovery
    /// email template
    /// <example><br/>Example:<code>
    /// var response = serverApi.SendCustomAccountRecoveryEmailAsync({);
    ///   "EmailTemplateId": "D53AB15D8F12E330",
    ///   "Email": "Me@here.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendcustomaccountrecoveryemail">Microsoft Documentation</see>
    /// </summary>
    public Task<SendCustomAccountRecoveryEmailResult> SendCustomAccountRecoveryEmailAsync(SendCustomAccountRecoveryEmailRequest request);
    /// <summary>
    /// Sends an email based on an email template to a player's contact email
    /// <example><br/>Example:<code>
    /// var response = serverApi.SendEmailFromTemplateAsync({);
    ///   "EmailTemplateId": "B53CA15D92D2E331",
    ///   "PlayFabId": "A01DC15D8E12E230"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendemailfromtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<SendEmailFromTemplateResult> SendEmailFromTemplateAsync(SendEmailFromTemplateRequest request);
    /// <summary>
    /// Sends an iOS/Android Push Notification to a specific user, if that user's device has been configured for Push
    /// Notifications in PlayFab. If a user has linked both Android and iOS devices, both will be notified.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SendPushNotificationAsync({);
    ///   "Recipient": "F8763A987E",
    ///   "Message": "You have been attacked! Go defend your base!"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendpushnotification">Microsoft Documentation</see>
    /// </summary>
    public Task<SendPushNotificationResult> SendPushNotificationAsync(SendPushNotificationRequest request);
    /// <summary>
    /// Sends an iOS/Android Push Notification template to a specific user, if that user's device has been configured for Push
    /// Notifications in PlayFab. If a user has linked both Android and iOS devices, both will be notified.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SendPushNotificationFromTemplateAsync({);
    ///   "Recipient": "F8763A987E",
    ///   "PushNotificationTemplateId": "6bc7dbf0-075a-46e9-8e84-35737a22c6a4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendpushnotificationfromtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<SendPushNotificationResult> SendPushNotificationFromTemplateAsync(SendPushNotificationFromTemplateRequest request);
    /// <summary>
    /// Updates the tag list for a specified user in the friend list of another user
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetFriendTagsAsync({);
    ///   "PlayFabId": "ABCDEF123456",
    ///   "FriendPlayFabId": "298ABC37799",
    ///   "Tags": [
    ///     "sniper",
    ///     "melee"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/setfriendtags">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> SetFriendTagsAsync(SetFriendTagsRequest request);
    /// <summary>
    /// Sets the custom data of the indicated Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetGameServerInstanceDataAsync({);
    ///   "LobbyId": "29439584",
    ///   "GameServerData": "\"DataA\":\"123\",\"DataB\":\"321\""
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancedata">Microsoft Documentation</see>
    /// </summary>
    public Task<SetGameServerInstanceDataResult> SetGameServerInstanceDataAsync(SetGameServerInstanceDataRequest request);
    /// <summary>
    /// Set the state of the indicated Game Server Instance.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetGameServerInstanceStateAsync({);
    ///   "LobbyId": "29439584",
    ///   "State": "Closed"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancestate">Microsoft Documentation</see>
    /// </summary>
    public Task<SetGameServerInstanceStateResult> SetGameServerInstanceStateAsync(SetGameServerInstanceStateRequest request);
    /// <summary>
    /// Set custom tags for the specified Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetGameServerInstanceTagsAsync({);
    ///   "LobbyId": "29439584",
    ///   "Tags": {
    ///     "TagA": "123",
    ///     "TagB": "321"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancetags">Microsoft Documentation</see>
    /// </summary>
    public Task<SetGameServerInstanceTagsResult> SetGameServerInstanceTagsAsync(SetGameServerInstanceTagsRequest request);
    /// <summary>
    /// Sets the player's secret if it is not already set. Player secrets are used to sign API requests. To reset a player's
    /// secret use the Admin or Server API method SetPlayerSecret.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetPlayerSecretAsync({);
    ///   "PlayerSecret": "ExampleSecret",
    ///   "PlayFabId": "ABCD1234"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/setplayersecret">Microsoft Documentation</see>
    /// </summary>
    public Task<SetPlayerSecretResult> SetPlayerSecretAsync(SetPlayerSecretRequest request);
    /// <summary>
    /// Updates the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetPublisherDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/setpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<SetPublisherDataResult> SetPublisherDataAsync(SetPublisherDataRequest request);
    /// <summary>
    /// Updates the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetTitleDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/settitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<SetTitleDataResult> SetTitleDataAsync(SetTitleDataRequest request);
    /// <summary>
    /// Updates the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = serverApi.SetTitleInternalDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/settitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<SetTitleDataResult> SetTitleInternalDataAsync(SetTitleDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the character's balance of the specified virtual currency by the stated amount. It is possible
    /// to make a VC balance negative with this API.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SubtractCharacterVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "CharacterId": "23424524523",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/subtractcharactervirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyCharacterVirtualCurrencyResult> SubtractCharacterVirtualCurrencyAsync(SubtractCharacterVirtualCurrencyRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the user's balance of the specified virtual currency by the stated amount. It is possible to
    /// make a VC balance negative with this API.
    /// <example><br/>Example:<code>
    /// var response = serverApi.SubtractUserVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/subtractuservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<ModifyUserVirtualCurrencyResult> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request);
    /// <summary>
    /// Unlinks the related Battle.net account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkBattleNetAccountAsync({);
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest request);
    /// <summary>
    /// Unlinks the related Nintendo account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkNintendoServiceAccountAsync({);
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request);
    /// <summary>
    /// Unlinks the related NintendoSwitchDeviceId from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkNintendoSwitchDeviceIdAsync({);
    ///   "PlayFabId": "1234FA342",
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkNintendoSwitchDeviceIdResult> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request);
    /// <summary>
    /// Unlinks the related PlayStation :tm: Network account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkPSNAccountAsync({);
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkPSNAccountResult> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request);
    /// <summary>
    /// Unlinks the custom server identifier from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkServerCustomIdAsync({);
    ///   "PlayFabId": "123412341234",
    ///   "ServerCustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkServerCustomIdResult> UnlinkServerCustomIdAsync(UnlinkServerCustomIdRequest request);
    /// <summary>
    /// Unlinks the Steam account associated with the provided Steam ID to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkSteamIdAsync({);
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinksteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkSteamIdResult> UnlinkSteamIdAsync(UnlinkSteamIdRequest request);
    /// <summary>
    /// Unlinks the related Xbox Live account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlinkXboxAccountAsync({);
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlinkXboxAccountResult> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Opens a specific container (ContainerItemInstanceId), with a specific key (KeyItemInstanceId, when
    /// required), and returns the contents of the opened container. If the container (and key when relevant) are consumable
    /// (RemainingUses > 0), their RemainingUses will be decremented, consistent with the operation of ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlockContainerInstanceAsync({);
    ///   "PlayFabId": "20394883",
    ///   "ContainerItemInstanceId": "123456788",
    ///   "KeyItemInstanceId": "123456789"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/unlockcontainerinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlockContainerItemResult> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Searches Player or Character inventory for any ItemInstance matching the given CatalogItemId, if necessary
    /// unlocks it using any appropriate key, and returns the contents of the opened container. If the container (and key when
    /// relevant) are consumable (RemainingUses > 0), their RemainingUses will be decremented, consistent with the operation of
    /// ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UnlockContainerItemAsync({);
    ///   "PlayFabId": "20394883",
    ///   "ContainerItemId": "crate block 1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/unlockcontaineritem">Microsoft Documentation</see>
    /// </summary>
    public Task<UnlockContainerItemResult> UnlockContainerItemAsync(UnlockContainerItemRequest request);
    /// <summary>
    /// Update the avatar URL of the specified player
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateAvatarUrlAsync({);
    ///   "PlayFabId": "22ca65837b158fab",
    ///   "ImageUrl": "https://www.gravatar.com/avatar/205e460b479e2e5b48aec07710c08d50"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/updateavatarurl">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request);
    /// <summary>
    /// Updates information of a list of existing bans specified with Ban Ids.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateBansAsync({);
    ///   "Bans": [
    ///     {
    ///       "BanId": "E0B5FF89542D413C",
    ///       "Permanent": true,
    ///       "Active": true
    ///     },
    ///     {
    ///       "BanId": "EF43FF89542G1546",
    ///       "Reason": "Royal pardon",
    ///       "Expires": "2016-07-04T00:00:00Z"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/updatebans">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateBansResult> UpdateBansAsync(UpdateBansRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateCharacterDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/updatecharacterdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterDataResult> UpdateCharacterDataAsync(UpdateCharacterDataRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateCharacterInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/updatecharacterinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterDataResult> UpdateCharacterInternalDataAsync(UpdateCharacterDataRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateCharacterReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "CharacterId": "98342357",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/character-data/updatecharacterreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterDataResult> UpdateCharacterReadOnlyDataAsync(UpdateCharacterDataRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the specific character
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateCharacterStatisticsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "CharacterId": "98765432",
    ///   "CharacterStatistics": {
    ///     "Headshots": 18,
    ///     "Kills": 47
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/updatecharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateCharacterStatisticsResult> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request);
    /// <summary>
    /// Updates the title-specific custom property values for a player
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdatePlayerCustomPropertiesAsync({);
    ///   "PlayFabId": "2039475",
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdatePlayerCustomPropertiesResult> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdatePlayerStatisticsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "Statistics": [
    ///     {
    ///       "StatisticName": "Points",
    ///       "Version": 1,
    ///       "Value": 600
    ///     },
    ///     {
    ///       "StatisticName": "Wins",
    ///       "Version": 2,
    ///       "Value": 16
    ///     },
    ///     {
    ///       "StatisticName": "Stars",
    ///       "Value": 7
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateplayerstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdatePlayerStatisticsResult> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request);
    /// <summary>
    /// Adds, updates, and removes data keys for a shared group object. If the permission is set to Public, all fields updated
    /// or added in this call will be readable by users not in the group. By default, data permissions are set to Private.
    /// Regardless of the permission setting, only members of the group (and the server) can update the data. Shared Groups are
    /// designed for sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateSharedGroupDataAsync({);
    ///   "SharedGroupId": "Clan Data",
    ///   "Data": {
    ///     "ClanKills": "34",
    ///     "LastClanUpdate": "2014-10-03T09:21:14Z"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/updatesharedgroupdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateSharedGroupDataResult> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Updates the key-value pair data tagged to the specified item, which is read-only from the client.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserInventoryItemCustomDataAsync({);
    ///   "PlayFabId": "204883457",
    ///   "CharacterId": "9890723423",
    ///   "ItemInstanceId": "88331144",
    ///   "Data": {
    ///     "Equipped": "True",
    ///     "Slot": "Head"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/updateuserinventoryitemcustomdata">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateUserInventoryItemCustomDataAsync(UpdateUserInventoryItemDataRequest request);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserPublisherDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserPublisherDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserPublisherInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserpublisherinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserPublisherReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserpublisherreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Updates the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   },
    ///   "Permission": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserDataResult> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user. By default, clients are not permitted to
    /// update statistics. Developers may override this setting in the Game Manager > Settings > API Features.
    /// <example><br/>Example:<code>
    /// var response = serverApi.UpdateUserStatisticsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "UserStatistics": {
    ///     "Headshots": 18,
    ///     "Kills": 47
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateUserStatisticsResult> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request);
    /// <summary>
    /// Writes a character-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = serverApi.WriteCharacterEventAsync({);
    ///   "PlayFabId": "3947655299CB786",
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/analytics/writecharacterevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WriteCharacterEventAsync(WriteServerCharacterEventRequest request);
    /// <summary>
    /// Writes a player-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = serverApi.WritePlayerEventAsync({);
    ///   "PlayFabId": "3947655299CB786",
    ///   "EventName": "player_defeated_enemy",
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/analytics/writeplayerevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WritePlayerEventAsync(WriteServerPlayerEventRequest request);
    /// <summary>
    /// Writes a title-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = serverApi.WriteTitleEventAsync({);
    ///   "EventName": "client_update_submitted",
    ///   "Timestamp": "2016-03-07T00:00:00Z",
    ///   "Body": {
    ///     "Version": "1.4.50"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/analytics/writetitleevent">Microsoft Documentation</see>
    /// </summary>
    public Task<WriteEventResponse> WriteTitleEventAsync(WriteTitleEventRequest request);
}