using CommunityFabs.NET.Common.Models.Server;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabServerApi {
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the character's balance of the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.AddCharacterVirtualCurrencyAsync({
    ///   "PlayFabId": "20394883",
    ///   "CharacterId": "23424524523",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/addcharactervirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> AddCharacterVirtualCurrencyAsync(AddCharacterVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds the Friend user to the friendlist of the user with PlayFabId. At least one of
    /// FriendPlayFabId,FriendUsername,FriendEmail, or FriendTitleDisplayName should be initialized.
    /// <example><br/>Example:<code>
    /// var response = await friend-list-managementApi.AddFriendAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "FriendPlayFabId": "20394883"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/addfriend">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> AddFriendAsync(AddFriendRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds the specified generic service identifier to the player's PlayFab account. This is designed to allow for a PlayFab
    /// ID lookup of any arbitrary service identifier a title wants to add. This identifier should never be used as
    /// authentication credentials, as the intent is that it is easily accessible by other players.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.AddGenericIDAsync({
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/addgenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> AddGenericIDAsync(AddGenericIDRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds or updates a contact email to the specified player's profile.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.AddOrUpdateContactEmailAsync({
    ///   "PlayFabId": "A01DC15D8E12E230",
    ///   "EmailAddress": "user@example.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/addorupdatecontactemail">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddOrUpdateContactEmailResult>> AddOrUpdateContactEmailAsync(AddOrUpdateContactEmailRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds a given tag to a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.AddPlayerTagAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/addplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds users to the set of those able to update both the shared data, as well as the set of users in the group. Only
    /// users in the group (and the server) can add new members. Shared Groups are designed for sharing data between a very
    /// small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.AddSharedGroupMembersAsync({
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/addsharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the user's balance of the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.AddUserVirtualCurrencyAsync({
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/adduservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Validated a client's session ticket, and if successful, returns details for that user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.AuthenticateSessionTicketAsync({
    ///   "SessionTicket": "4D2----8D11F4249A80000-7C64AB0A9F1D8D1A.CD803BF233CE76CC"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/authenticatesessionticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AuthenticateSessionTicketResult>> AuthenticateSessionTicketAsync(AuthenticateSessionTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Awards the specified users the specified Steam achievements
    /// <example><br/>Example:<code>
    /// var response = await platform-specific-methodsApi.AwardSteamAchievementAsync({
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
    public Task<PlayFabResult<AwardSteamAchievementResult>> AwardSteamAchievementAsync(AwardSteamAchievementRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Bans users by PlayFab ID with optional IP address for the provided game.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.BanUsersAsync({
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
    public Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Consume uses of a consumable item. When all uses are consumed, it will be removed from the player's
    /// inventory.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.ConsumeItemAsync({
    ///   "ItemInstanceId": "94585729",
    ///   "ConsumeCount": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/consumeitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Requests the creation of a shared group object, containing key/value pairs which may be updated by all members of the
    /// group. When created by a server, the group will initially have no members. Shared Groups are designed for sharing data
    /// between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.CreateSharedGroupAsync({
    ///   "SharedGroupId": "Clan Data"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/createsharedgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the specific character ID from the specified user.
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.DeleteCharacterFromUserAsync({
    ///   "PlayFabId": "12345",
    ///   "CharacterId": "98765432",
    ///   "SaveCharacterInventory": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/deletecharacterfromuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteCharacterFromUserResult>> DeleteCharacterFromUserAsync(DeleteCharacterFromUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes a user's player account from a title and deletes all associated data
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.DeletePlayerAsync({
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/deleteplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes title-specific custom properties for a player
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.DeletePlayerCustomPropertiesAsync({
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
    public Task<PlayFabResult<DeletePlayerCustomPropertiesResult>> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes push notification template for title
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.DeletePushNotificationTemplateAsync({
    ///   "PushNotificationTemplateId": "6bc7dbf0-075a-46e9-8e84-35737a22c6a4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/deletepushnotificationtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeletePushNotificationTemplateResult>> DeletePushNotificationTemplateAsync(DeletePushNotificationTemplateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a shared group, freeing up the shared group ID to be reused for a new group. Shared Groups are designed for
    /// sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.DeleteSharedGroupAsync({
    ///   "SharedGroupId": "Clan Data"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/deletesharedgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteSharedGroupAsync(DeleteSharedGroupRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes custom data, all account linkages, and statistics.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.DeleteUsersAsync({
    ///   "PlayFabIds": [
    ///     "203945882"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/deleteusers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteUsersResult>> DeleteUsersAsync(DeleteUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Inform the matchmaker that a Game Server Instance is removed.
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.DeregisterGameAsync({
    ///   "LobbyId": "8285313"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/deregistergame">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeregisterGameResponse>> DeregisterGameAsync(DeregisterGameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Returns the result of an evaluation of a Random Result Table - the ItemId from the game Catalog which would
    /// have been added to the player inventory, if the Random Result Table were added via a Bundle or a call to
    /// UnlockContainer.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.EvaluateRandomResultTableAsync({
    ///   "TableId": "RareElementCard",
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/evaluaterandomresulttable">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EvaluateRandomResultTableResult>> EvaluateRandomResultTableAsync(EvaluateRandomResultTableRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Executes a CloudScript function, with the 'currentPlayerId' set to the PlayFab ID of the authenticated player. The
    /// PlayFab ID is the entity ID of the player's master_player_account entity.
    /// <example><br/>Example:<code>
    /// var response = await server-side-cloud-scriptApi.ExecuteCloudScriptAsync({
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
    public Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieve a list of all PlayStream actions groups.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.GetAllActionGroupsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getallactiongroups">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAllActionGroupsResult>> GetAllActionGroupsAsync(GetAllActionGroupsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves an array of player segment definitions. Results from this can be used in subsequent API calls such as
    /// GetPlayersInSegment which requires a Segment ID. While segment names can change the ID for that segment will not change.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.GetAllSegmentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getallsegments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all of the characters that belong to a specific user. CharacterIds are not globally unique; characterId must be
    /// evaluated with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GetAllUsersCharactersAsync({
    ///   "PlayFabId": "98333765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getalluserscharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetCatalogItemsAsync({
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getcatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.GetCharacterDataAsync({
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
    public Task<PlayFabResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user's character which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.GetCharacterInternalDataAsync({
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
    public Task<PlayFabResult<GetCharacterDataResult>> GetCharacterInternalDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified character's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GetCharacterInventoryAsync({
    ///   "PlayFabId": "204883457",
    ///   "CharacterId": "9890723423",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/getcharacterinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(GetCharacterInventoryRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GetCharacterLeaderboardAsync({
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getcharacterleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user's character which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.GetCharacterReadOnlyDataAsync({
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
    public Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the specific character
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GetCharacterStatisticsAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "CharacterId": "98765432"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getcharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// This API retrieves a pre-signed URL for accessing a content file for the title. A subsequent HTTP GET to the returned
    /// URL will attempt to download the content. A HEAD query to the returned URL will attempt to retrieve the metadata of the
    /// content. Note that a successful result does not guarantee the existence of this content - if it has not been uploaded,
    /// the query to retrieve the data will fail. See this post for more information:
    /// https://community.playfab.com/hc/community/posts/205469488-How-to-upload-files-to-PlayFab-s-Content-Service. Also,
    /// please be aware that the Content service is specifically PlayFab's CDN offering, for which standard CDN rates apply.
    /// <example><br/>Example:<code>
    /// var response = await contentApi.GetContentDownloadUrlAsync({
    ///   "Key": "images/sword_icon.png"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/content/getcontentdownloadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of ranked friends of the given player for the given statistic, starting from the indicated point in
    /// the leaderboard
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetFriendLeaderboardAsync({
    ///   "PlayFabId": "98092347523",
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 1258,
    ///   "MaxResultsCount": 20,
    ///   "ExternalPlatformFriends": "None"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getfriendleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the current friends for the user with PlayFabId, constrained to users who have PlayFab accounts. Friends from
    /// linked accounts (Facebook, Steam) are also included. You may optionally exclude some linked services' friends.
    /// <example><br/>Example:<code>
    /// var response = await friend-list-managementApi.GetFriendsListAsync({
    ///   "PlayFabId": "93798903892789754",
    ///   "ExternalPlatformFriends": "All"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/getfriendslist">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, starting from the indicated point in the leaderboard
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetLeaderboardAsync({
    ///   "StatisticName": "Kills",
    ///   "StartPosition": 0,
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of ranked characters for the given statistic, centered on the requested user
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GetLeaderboardAroundCharacterAsync({
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331",
    ///   "CharacterId": "987343220",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getleaderboardaroundcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of ranked users for the given statistic, centered on the currently signed-in user
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetLeaderboardAroundUserAsync({
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331",
    ///   "MaxResultsCount": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getleaderboardarounduser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLeaderboardAroundUserResult>> GetLeaderboardAroundUserAsync(GetLeaderboardAroundUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of all of the user's characters for the given statistic.
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GetLeaderboardForUserCharactersAsync({
    ///   "StatisticName": "Kills",
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/getleaderboardforusercharacters">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Returns whatever info is requested in the response for the user. Note that PII (like email address, facebook id) may be
    /// returned. All parameters default to false.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetPlayerCombinedInfoAsync({
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
    public Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a title-specific custom property value for a player.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetPlayerCustomPropertyAsync({
    ///   "PlayFabId": "2039475",
    ///   "PropertyName": "level"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayercustomproperty">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerCustomPropertyResult>> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the player's profile
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayerProfileAsync({
    ///   "PlayFabId": "621EF20237534A44"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayerprofile">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all segments that a player currently belongs to at this moment in time.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.GetPlayerSegmentsAsync({
    ///   "PlayFabId": "1337AA00"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayersegments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Allows for paging through all players in a given segment. This API creates a snapshot of all player profiles that match
    /// the segment definition at the time of its creation and lives through the Total Seconds to Live, refreshing its life
    /// span on each subsequent use of the Continuation Token. Profiles that change during the course of paging will not be
    /// reflected in the results. AB Test segments are currently not supported by this operation. NOTE: This API is limited to
    /// being called 30 times in one minute. You will be returned an error if you exceed this threshold.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.GetPlayersInSegmentAsync({
    ///   "SegmentId": "1337AA00",
    ///   "SecondsToLive": 5,
    ///   "MaxBatchSize": 500
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayersinsegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the current version and values for the indicated statistics, for the local player.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetPlayerStatisticsAsync({
    ///   "PlayFabId": "621EF2023753444",
    ///   "StatisticNames": [
    ///     "Points",
    ///     "Wins"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayerstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the information on the available versions of the specified statistic.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetPlayerStatisticVersionsAsync({
    ///   "StatisticName": "headshots"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getplayerstatisticversions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get all tags with a given Namespace (optional) from a player profile.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.GetPlayerTagsAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "Namespace": "title.AAA"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/getplayertags">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Battle.net account identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromBattleNetAccountIdsAsync({
    ///   "BattleNetAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrombattlenetaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult>> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromFacebookIDsAsync({
    ///   "FacebookIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromfacebookids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Facebook Instant Games identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromFacebookInstantGamesIdsAsync({
    ///   "FacebookInstantGamesIds": [
    ///     "1114685845316172",
    ///     "1114685845316173"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromfacebookinstantgamesids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of generic service identifiers. A generic identifier is the
    /// service name plus the service-specific ID for the player, as specified by the title when the generic identifier was
    /// added to the player account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromGenericIDsAsync({
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
    public Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Service Account identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromNintendoServiceAccountIdsAsync({
    ///   "NintendoAccountIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromnintendoserviceaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Nintendo Switch Device identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync({
    ///   "NintendoSwitchDeviceIds": [
    ///     "526f79204261747478",
    ///     "526f79204261747479"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromnintendoswitchdeviceids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of OpenId subject identifiers. A OpenId subject identifier
    /// is the OpenId issuer plus the OpenId subject for the player, as specified by the title when the OpenId identifier was
    /// added to the player account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromOpenIdSubjectIdentifiersAsync({
    ///   "OpenIdSubjectIdentifiers": [
    ///     {
    ///       "Issuer": "https://example.com",
    ///       "Subject": "123456789012345678"
    ///     },
    ///     {
    ///       "Issuer": "https://example-2.com",
    ///       "Subject": "aaaaaaaa-bbbb-cccc-dddd-eeeeeeeeeeee"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromopenidsubjectidentifiers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromOpenIdsResult>> GetPlayFabIDsFromOpenIdSubjectIdentifiersAsync(GetPlayFabIDsFromOpenIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromPSNAccountIDsAsync({
    ///   "PSNAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrompsnaccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of PlayStation :tm: Network identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromPSNOnlineIDsAsync({
    ///   "PSNOnlineIDs": [
    ///     "857555576495",
    ///     "759345551209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfrompsnonlineids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult>> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are the profile
    /// IDs for the user accounts, available as SteamId in the Steamworks Community API calls.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromSteamIDsAsync({
    ///   "SteamStringIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromsteamids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Steam identifiers. The Steam identifiers are persona
    /// names.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromSteamNamesAsync({
    ///   "SteamNames": [
    ///     "steamPersonaName1",
    ///     "steamPersonaName2"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromsteamnames">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromSteamNamesResult>> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of Twitch identifiers. The Twitch identifiers are the IDs
    /// for the user accounts, available as "_id" from the Twitch API methods (ex:
    /// https://github.com/justintv/Twitch-API/blob/master/v3_resources/users.md#get-usersuser).
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromTwitchIDsAsync({
    ///   "TwitchIds": [
    ///     "127168541",
    ///     "88315720"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromtwitchids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the unique PlayFab identifiers for the given set of XboxLive identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetPlayFabIDsFromXboxLiveIDsAsync({
    ///   "XboxLiveAccountIDs": [
    ///     "857498576495",
    ///     "759374651209"
    ///   ],
    ///   "Sandbox": "RETAIL"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getplayfabidsfromxboxliveids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetPublisherDataAsync({
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the configuration information for the specified random results tables for the title, including
    /// all ItemId values and weights
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GetRandomResultTablesAsync({
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
    public Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the associated PlayFab account identifiers for the given set of server custom identifiers.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetServerCustomIDsFromPlayFabIDsAsync({
    ///   "PlayFabIDs": [
    ///     "1232421311"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getservercustomidsfromplayfabids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>> GetServerCustomIDsFromPlayFabIDsAsync(GetServerCustomIDsFromPlayFabIDsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves data stored in a shared group object, as well as the list of members in the group. The server can access all
    /// public and private group data. Shared Groups are designed for sharing data between a very small number of players,
    /// please see our guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.GetSharedGroupDataAsync({
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
    public Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the set of items defined for the specified store, including all prices defined, for the specified
    /// player
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetStoreItemsAsync({
    ///   "StoreId": "BonusStore",
    ///   "PlayFabId": "20394883"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/getstoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the current server time
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetTimeAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettime">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTimeResult>> GetTimeAsync(GetTimeRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetTitleDataAsync({
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom internal title settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetTitleInternalDataAsync({
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title news feed, as configured in the developer portal
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.GetTitleNewsAsync({
    ///   "Count": 25
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/gettitlenews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the relevant details for a specified user
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetUserAccountInfoAsync({
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getuseraccountinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserAccountInfoResult>> GetUserAccountInfoAsync(GetUserAccountInfoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets all bans for a user.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.GetUserBansAsync({
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/getuserbans">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserInternalDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified user's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GetUserInventoryAsync({
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/getuserinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserPublisherDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserPublisherInternalDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserPublisherReadOnlyDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserReadOnlyDataAsync({
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
    public Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the details of all title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.GetUserStatisticsAsync({
    ///   "PlayFabId": "10931252888739651331"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/getuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserStatisticsResult>> GetUserStatisticsAsync(GetUserStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Grants the specified character type to the user. CharacterIds are not globally unique; characterId must be evaluated
    /// with the parent PlayFabId to guarantee uniqueness.
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.GrantCharacterToUserAsync({
    ///   "PlayFabId": "20394883567",
    ///   "CharacterName": "FighterDude",
    ///   "CharacterType": "Blue Warrior"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/characters/grantcharactertouser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified character's inventory
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GrantItemsToCharacterAsync({
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
    public Task<PlayFabResult<GrantItemsToCharacterResult>> GrantItemsToCharacterAsync(GrantItemsToCharacterRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified user's inventory
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GrantItemsToUserAsync({
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
    public Task<PlayFabResult<GrantItemsToUserResult>> GrantItemsToUserAsync(GrantItemsToUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified user inventories
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.GrantItemsToUsersAsync({
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
    public Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Battle.net account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkBattleNetAccountAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Nintendo account associated with the token to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkNintendoServiceAccountAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Nintendo account associated with the Nintendo Service Account subject or id to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkNintendoServiceAccountSubjectAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "Subject": "8e7Eju4j9"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoserviceaccountsubject">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountSubjectAsync(LinkNintendoServiceAccountSubjectRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the NintendoSwitchDeviceId to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkNintendoSwitchDeviceIdAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the PlayStation :tm: Network account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkPSNAccountAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "AuthCode": "LKJDG7DDE",
    ///   "RedirectUri": "orbis://games"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the PlayStation :tm: Network account associated with the provided user id to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkPSNIdAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "PSNUserId": "LKJDG7DDE"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkpsnid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkPSNIdResponse>> LinkPSNIdAsync(LinkPSNIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the custom server identifier, generated by the title, to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkServerCustomIdAsync({
    ///   "PlayFabId": "123412341234",
    ///   "ServerCustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkServerCustomIdResult>> LinkServerCustomIdAsync(LinkServerCustomIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Steam account associated with the provided Steam ID to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkSteamIdAsync({
    ///   "SteamId": "22223333",
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linksteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkSteamIdResult>> LinkSteamIdAsync(LinkSteamIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Twitch account associated with the token to the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkTwitchAccountAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "AccessToken": "twitch-access-token",
    ///   "ForceLink": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linktwitchaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> LinkTwitchAccountAsync(LinkTwitchAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Xbox Live account associated with the provided access code to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkXboxAccountAsync({
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Links the Xbox Live account associated with the provided Xbox ID and Sandbox to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.LinkXboxIdAsync({
    ///   "XboxId": "12344553",
    ///   "Sandbox": "RETAIL",
    ///   "PlayFabId": "5A446C83645201",
    ///   "ForceLink": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/linkxboxid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxIdAsync(LinkXboxIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves title-specific custom property values for a player.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.ListPlayerCustomPropertiesAsync({
    ///   "PlayFabId": "2039475"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/listplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListPlayerCustomPropertiesResult>> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Logs a custom analytics event
    /// <example><br/>Example:<code>
    /// var response = await analyticsApi.LogEventAsync({
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
    public Task<PlayFabResult<LogEventResult>> LogEventAsync(LogEventRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using the Android device identifier, returning a session identifier that can subsequently be used for
    /// API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithAndroidDeviceIDAsync({
    ///   "AndroidDeviceId": "526f79204261747479",
    ///   "OS": "5.0",
    ///   "AndroidDevice": "Nexus 6",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithandroiddeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sign in the user with a Battle.net identity token
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithBattleNetAsync({
    ///   "IdentityToken": "eyJraWQi..."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithbattlenet">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithBattleNetAsync(LoginWithBattleNetRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using a custom unique identifier generated by the title, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithCustomIDAsync({
    ///   "CustomId": "67AB-5397-CC54-EA31",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using the iOS device identifier, returning a session identifier that can subsequently be used for API
    /// calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithIOSDeviceIDAsync({
    ///   "DeviceId": "29848d9bh8900a0b003",
    ///   "OS": "7.11",
    ///   "DeviceModel": "Iphone 5s",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithiosdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using a PlayStation :tm: Network authentication code, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithPSNAsync({
    ///   "AuthCode": "LKJ6D896D",
    ///   "RedirectUri": "orbis://games",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithpsn">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithPSNAsync(LoginWithPSNRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Securely login a game client from an external server backend using a custom identifier for that player. Server Custom
    /// ID and Client Custom ID are mutually exclusive and cannot be used to retrieve the same player account.
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithServerCustomIdAsync({
    ///   "ServerCustomId": "asdalsdkjar09u23ijf",
    ///   "CreateAccount": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithServerCustomIdAsync(LoginWithServerCustomIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using an Steam ID, returning a session identifier that can subsequently be used for API calls which
    /// require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithSteamIdAsync({
    ///   "SteamId": "12344553",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithsteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithSteamIdAsync(LoginWithSteamIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sign in the user with a Twitch access token
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithTwitchAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "AccessToken": "twitch-access-token",
    ///   "CreateAccount": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithtwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithTwitchAsync(LoginWithTwitchRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using a Xbox Live Token from an external server backend, returning a session identifier that can
    /// subsequently be used for API calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithXboxAsync({
    ///   "XboxToken": "XBL3.0 x=1981989841;akljdlkafdknad",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithxbox">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithXboxAsync(LoginWithXboxRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Signs the user in using an Xbox ID and Sandbox ID, returning a session identifier that can subsequently be used for API
    /// calls which require an authenticated user
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.LoginWithXboxIdAsync({
    ///   "XboxId": "12344553",
    ///   "Sandbox": "RETAIL",
    ///   "CreateAccount": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/loginwithxboxid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ServerLoginResult>> LoginWithXboxIdAsync(LoginWithXboxIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Modifies the number of remaining uses of a player's inventory item
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.ModifyItemUsesAsync({
    ///   "PlayFabId": "20394883",
    ///   "ItemInstanceId": "94585729",
    ///   "UsesToAdd": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/modifyitemuses">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyItemUsesResult>> ModifyItemUsesAsync(ModifyItemUsesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a character's inventory into another of the users's character's inventory.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.MoveItemToCharacterFromCharacterAsync({
    ///   "PlayFabId": "234234897234",
    ///   "GivingCharacterId": "98092347523",
    ///   "ReceivingCharacterId": "6323489712",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtocharacterfromcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<MoveItemToCharacterFromCharacterResult>> MoveItemToCharacterFromCharacterAsync(MoveItemToCharacterFromCharacterRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a user's inventory into their character's inventory.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.MoveItemToCharacterFromUserAsync({
    ///   "PlayFabId": "234234897234",
    ///   "CharacterId": "98092347523",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtocharacterfromuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<MoveItemToCharacterFromUserResult>> MoveItemToCharacterFromUserAsync(MoveItemToCharacterFromUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Moves an item from a character's inventory into the owning user's inventory.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.MoveItemToUserFromCharacterAsync({
    ///   "PlayFabId": "234234897234",
    ///   "CharacterId": "98092347523",
    ///   "ItemInstanceId": "701231299999"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/moveitemtouserfromcharacter">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<MoveItemToUserFromCharacterResult>> MoveItemToUserFromCharacterAsync(MoveItemToUserFromCharacterRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Informs the PlayFab match-making service that the user specified has left the Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.NotifyMatchmakerPlayerLeftAsync({
    ///   "LobbyId": "29439584",
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/notifymatchmakerplayerleft">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<NotifyMatchmakerPlayerLeftResult>> NotifyMatchmakerPlayerLeftAsync(NotifyMatchmakerPlayerLeftRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the virtual goods associated with the coupon to the user's inventory. Coupons can be generated via the
    /// Economy-&gt;Catalogs tab in the PlayFab Game Manager.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.RedeemCouponAsync({
    ///   "CouponCode": "123-1234-123",
    ///   "CatalogVersion": "5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/redeemcoupon">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Validates a Game Server session ticket and returns details about the user
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.RedeemMatchmakerTicketAsync({
    ///   "Ticket": "2398349939a03499bc",
    ///   "LobbyId": "2353"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/redeemmatchmakerticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemMatchmakerTicketResult>> RedeemMatchmakerTicketAsync(RedeemMatchmakerTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Set the state of the indicated Game Server Instance. Also update the heartbeat for the instance.
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.RefreshGameServerInstanceHeartbeatAsync({
    ///   "LobbyId": "29439584"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/refreshgameserverinstanceheartbeat">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RefreshGameServerInstanceHeartbeatResult>> RefreshGameServerInstanceHeartbeatAsync(RefreshGameServerInstanceHeartbeatRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Inform the matchmaker that a new Game Server Instance is added.
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.RegisterGameAsync({
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
    public Task<PlayFabResult<RegisterGameResponse>> RegisterGameAsync(RegisterGameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes the specified friend from the the user's friend list
    /// <example><br/>Example:<code>
    /// var response = await friend-list-managementApi.RemoveFriendAsync({
    ///   "FriendPlayFabId": "29837799",
    ///   "PlayFabId": "1a46086aed40f142"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/friend-list-management/removefriend">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> RemoveFriendAsync(RemoveFriendRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes the specified generic service identifier from the player's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.RemoveGenericIDAsync({
    ///   "GenericId": {
    ///     "ServiceName": "BigBizSocial",
    ///     "UserId": "1234567890"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/removegenericid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> RemoveGenericIDAsync(RemoveGenericIDRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Remove a given tag from a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = await playstreamApi.RemovePlayerTagAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/playstream/removeplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes users from the set of those able to update the shared data and the set of users in the group. Only users in the
    /// group can remove members. If as a result of the call, zero users remain with access, the group and its associated data
    /// will be deleted. Shared Groups are designed for sharing data between a very small number of players, please see our
    /// guide: https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.RemoveSharedGroupMembersAsync({
    ///   "SharedGroupId": "Clan Data",
    ///   "PlayFabIds": [
    ///     "D984A64B832",
    ///     "F74A523E1562"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/shared-group-data/removesharedgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Submit a report about a player (due to bad bahavior, etc.) on behalf of another player, so that customer service
    /// representatives for the title can take action concerning potentially toxic players.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.ReportPlayerAsync({
    ///   "ReporterId": "9ddafe27d6d445da",
    ///   "ReporteeId": "1a46086aed40f142",
    ///   "Comment": "cheating"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/reportplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ReportPlayerServerResult>> ReportPlayerAsync(ReportPlayerServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Revoke all active bans for a user.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.RevokeAllBansForUserAsync({
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/revokeallbansforuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Revoke all active bans specified with BanId.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.RevokeBansAsync({
    ///   "BanIds": [
    ///     "E0B5FF89542D413C",
    ///     "EF43FF89542G1546"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/revokebans">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access to an item in a user's inventory
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.RevokeInventoryItemAsync({
    ///   "PlayFabId": "203945882",
    ///   "ItemInstanceId": "2048583045"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/revokeinventoryitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access for up to 25 items across multiple users and characters.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.RevokeInventoryItemsAsync({
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
    public Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Saves push notification template for title
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.SavePushNotificationTemplateAsync({
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
    public Task<PlayFabResult<SavePushNotificationTemplateResult>> SavePushNotificationTemplateAsync(SavePushNotificationTemplateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Forces an email to be sent to the registered contact email address for the user's account based on an account recovery
    /// email template
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.SendCustomAccountRecoveryEmailAsync({
    ///   "EmailTemplateId": "D53AB15D8F12E330",
    ///   "Email": "Me@here.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendcustomaccountrecoveryemail">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SendCustomAccountRecoveryEmailResult>> SendCustomAccountRecoveryEmailAsync(SendCustomAccountRecoveryEmailRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sends an email based on an email template to a player's contact email
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.SendEmailFromTemplateAsync({
    ///   "EmailTemplateId": "B53CA15D92D2E331",
    ///   "PlayFabId": "A01DC15D8E12E230"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendemailfromtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SendEmailFromTemplateResult>> SendEmailFromTemplateAsync(SendEmailFromTemplateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sends an iOS/Android Push Notification to a specific user, if that user's device has been configured for Push
    /// Notifications in PlayFab. If a user has linked both Android and iOS devices, both will be notified.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.SendPushNotificationAsync({
    ///   "Recipient": "F8763A987E",
    ///   "Message": "You have been attacked! Go defend your base!"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendpushnotification">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationAsync(SendPushNotificationRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sends an iOS/Android Push Notification template to a specific user, if that user's device has been configured for Push
    /// Notifications in PlayFab. If a user has linked both Android and iOS devices, both will be notified.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.SendPushNotificationFromTemplateAsync({
    ///   "Recipient": "F8763A987E",
    ///   "PushNotificationTemplateId": "6bc7dbf0-075a-46e9-8e84-35737a22c6a4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/sendpushnotificationfromtemplate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationFromTemplateAsync(SendPushNotificationFromTemplateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the tag list for a specified user in the friend list of another user
    /// <example><br/>Example:<code>
    /// var response = await friend-list-managementApi.SetFriendTagsAsync({
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
    public Task<PlayFabResult<EmptyResponse>> SetFriendTagsAsync(SetFriendTagsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the custom data of the indicated Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.SetGameServerInstanceDataAsync({
    ///   "LobbyId": "29439584",
    ///   "GameServerData": "\"DataA\":\"123\",\"DataB\":\"321\""
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancedata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetGameServerInstanceDataResult>> SetGameServerInstanceDataAsync(SetGameServerInstanceDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Set the state of the indicated Game Server Instance.
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.SetGameServerInstanceStateAsync({
    ///   "LobbyId": "29439584",
    ///   "State": "Closed"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancestate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetGameServerInstanceStateResult>> SetGameServerInstanceStateAsync(SetGameServerInstanceStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Set custom tags for the specified Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = await matchmakingApi.SetGameServerInstanceTagsAsync({
    ///   "LobbyId": "29439584",
    ///   "Tags": {
    ///     "TagA": "123",
    ///     "TagB": "321"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/matchmaking/setgameserverinstancetags">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetGameServerInstanceTagsResult>> SetGameServerInstanceTagsAsync(SetGameServerInstanceTagsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the player's secret if it is not already set. Player secrets are used to sign API requests. To reset a player's
    /// secret use the Admin or Server API method SetPlayerSecret.
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.SetPlayerSecretAsync({
    ///   "PlayerSecret": "ExampleSecret",
    ///   "PlayFabId": "ABCD1234"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/authentication/setplayersecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.SetPublisherDataAsync({
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/setpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.SetTitleDataAsync({
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/settitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the key-value store of custom title settings
    /// <example><br/>Example:<code>
    /// var response = await title-wide-data-managementApi.SetTitleInternalDataAsync({
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/title-wide-data-management/settitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the character's balance of the specified virtual currency by the stated amount. It is possible
    /// to make a VC balance negative with this API.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.SubtractCharacterVirtualCurrencyAsync({
    ///   "PlayFabId": "20394883",
    ///   "CharacterId": "23424524523",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/subtractcharactervirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> SubtractCharacterVirtualCurrencyAsync(SubtractCharacterVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the user's balance of the specified virtual currency by the stated amount. It is possible to
    /// make a VC balance negative with this API.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.SubtractUserVirtualCurrencyAsync({
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/subtractuservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Battle.net account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkBattleNetAccountAsync({
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkbattlenetaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Facebook account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkFacebookAccountAsync({
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkfacebookaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Facebook Instant Games identifier from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkFacebookInstantGamesIdAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "FacebookInstantGamesId": "123456789012345"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkfacebookinstantgamesid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkFacebookInstantGamesIdResult>> UnlinkFacebookInstantGamesIdAsync(UnlinkFacebookInstantGamesIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Nintendo account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkNintendoServiceAccountAsync({
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinknintendoserviceaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related NintendoSwitchDeviceId from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkNintendoSwitchDeviceIdAsync({
    ///   "PlayFabId": "1234FA342",
    ///   "NintendoSwitchDeviceId": "526f79204261747479"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinknintendoswitchdeviceid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related PlayStation :tm: Network account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkPSNAccountAsync({
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkpsnaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the custom server identifier from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkServerCustomIdAsync({
    ///   "PlayFabId": "123412341234",
    ///   "ServerCustomId": "67AB-5397-CC54-EA31"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkservercustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkServerCustomIdResult>> UnlinkServerCustomIdAsync(UnlinkServerCustomIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the Steam account associated with the provided Steam ID to the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkSteamIdAsync({
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinksteamid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkSteamIdResult>> UnlinkSteamIdAsync(UnlinkSteamIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Twitch account from the user's PlayFab account.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkTwitchAccountAsync({
    ///   "PlayFabId": "1234FA342"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinktwitchaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResult>> UnlinkTwitchAccountAsync(UnlinkTwitchAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unlinks the related Xbox Live account from the user's PlayFab account
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UnlinkXboxAccountAsync({
    ///   "PlayFabId": "5a446c83645201"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/unlinkxboxaccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Opens a specific container (ContainerItemInstanceId), with a specific key (KeyItemInstanceId, when
    /// required), and returns the contents of the opened container. If the container (and key when relevant) are consumable
    /// (RemainingUses &gt; 0), their RemainingUses will be decremented, consistent with the operation of ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.UnlockContainerInstanceAsync({
    ///   "PlayFabId": "20394883",
    ///   "ContainerItemInstanceId": "123456788",
    ///   "KeyItemInstanceId": "123456789"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/unlockcontainerinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Searches Player or Character inventory for any ItemInstance matching the given CatalogItemId, if necessary
    /// unlocks it using any appropriate key, and returns the contents of the opened container. If the container (and key when
    /// relevant) are consumable (RemainingUses &gt; 0), their RemainingUses will be decremented, consistent with the operation of
    /// ConsumeItem.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.UnlockContainerItemAsync({
    ///   "PlayFabId": "20394883",
    ///   "ContainerItemId": "crate block 1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-item-management/unlockcontaineritem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update the avatar URL of the specified player
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UpdateAvatarUrlAsync({
    ///   "PlayFabId": "22ca65837b158fab",
    ///   "ImageUrl": "https://www.gravatar.com/avatar/205e460b479e2e5b48aec07710c08d50"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/account-management/updateavatarurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates information of a list of existing bans specified with Ban Ids.
    /// <example><br/>Example:<code>
    /// var response = await account-managementApi.UpdateBansAsync({
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
    public Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.UpdateCharacterDataAsync({
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
    public Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.UpdateCharacterInternalDataAsync({
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
    public Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterInternalDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user's character which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await character-dataApi.UpdateCharacterReadOnlyDataAsync({
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
    public Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterReadOnlyDataAsync(UpdateCharacterDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the specific character
    /// <example><br/>Example:<code>
    /// var response = await charactersApi.UpdateCharacterStatisticsAsync({
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
    public Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom property values for a player
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdatePlayerCustomPropertiesAsync({
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
    public Task<PlayFabResult<UpdatePlayerCustomPropertiesResult>> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdatePlayerStatisticsAsync({
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
    public Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds, updates, and removes data keys for a shared group object. If the permission is set to Public, all fields updated
    /// or added in this call will be readable by users not in the group. By default, data permissions are set to Private.
    /// Regardless of the permission setting, only members of the group (and the server) can update the data. Shared Groups are
    /// designed for sharing data between a very small number of players, please see our guide:
    /// https://docs.microsoft.com/gaming/playfab/features/social/groups/using-shared-group-data
    /// <example><br/>Example:<code>
    /// var response = await shared-group-dataApi.UpdateSharedGroupDataAsync({
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
    public Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserInternalDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Updates the key-value pair data tagged to the specified item, which is read-only from the client.
    /// <example><br/>Example:<code>
    /// var response = await player-item-managementApi.UpdateUserInventoryItemCustomDataAsync({
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
    public Task<PlayFabResult<EmptyResponse>> UpdateUserInventoryItemCustomDataAsync(UpdateUserInventoryItemDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserPublisherDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserPublisherInternalDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserPublisherReadOnlyDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserReadOnlyDataAsync({
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
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the values of the specified title-specific statistics for the user. By default, clients are not permitted to
    /// update statistics. Developers may override this setting in the Game Manager &gt; Settings &gt; API Features.
    /// <example><br/>Example:<code>
    /// var response = await player-data-managementApi.UpdateUserStatisticsAsync({
    ///   "PlayFabId": "10931252888739651331",
    ///   "UserStatistics": {
    ///     "Headshots": 18,
    ///     "Kills": 47
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/player-data-management/updateuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserStatisticsResult>> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Writes a character-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = await analyticsApi.WriteCharacterEventAsync({
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
    public Task<PlayFabResult<WriteEventResponse>> WriteCharacterEventAsync(WriteServerCharacterEventRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Writes a player-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = await analyticsApi.WritePlayerEventAsync({
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
    public Task<PlayFabResult<WriteEventResponse>> WritePlayerEventAsync(WriteServerPlayerEventRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Writes a title-based event into PlayStream.
    /// <example><br/>Example:<code>
    /// var response = await analyticsApi.WriteTitleEventAsync({
    ///   "EventName": "client_update_submitted",
    ///   "Timestamp": "2016-03-07T00:00:00Z",
    ///   "Body": {
    ///     "Version": "1.4.50"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/server/analytics/writetitleevent">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest request, Dictionary<string, string>? extraHeaders);
}