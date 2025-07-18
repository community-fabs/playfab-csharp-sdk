using CommunityFabs.NET.Common.Models.Admin;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabAdminApi {
    /// <summary>
    /// Abort an ongoing task instance.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AbortTaskInstanceAsync({);
    ///   "TaskInstanceId": "E52531B47B1761C7-4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/aborttaskinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> AbortTaskInstanceAsync(AbortTaskInstanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update news item to include localized version
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddLocalizedNewsAsync({);
    ///   "NewsId": "74623b12-6c80-ee4b-7c3b-58e638aa62bd",
    ///   "Language": "en",
    ///   "Title": "News of the Day",
    ///   "Body": "<b>We have a new object to buy!</b>"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/addlocalizednews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddLocalizedNewsResult>> AddLocalizedNewsAsync(AddLocalizedNewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds a new news item to the title's news feed
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddNewsAsync({);
    ///   "Timestamp": "2014-04-06T00:00:00Z",
    ///   "Title": "News of the Day",
    ///   "Body": "<b>We have a new object to buy!</b>"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/addnews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddNewsResult>> AddNewsAsync(AddNewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds a given tag to a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddPlayerTagAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/addplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds the game server executable specified (previously uploaded - see GetServerBuildUploadUrl) to the set of those a
    /// client is permitted to request in a call to StartGame
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddServerBuildAsync({);
    ///   "BuildId": "5.0.1",
    ///   "CommandLineTemplate": "-game_id=<game_id> -game_build_version=<game_build_version> -game_mode=<game_mode> -server_host_domain=<server_host_domain> -server_host_port=<server_host_port> -server_host_region=<server_host_region> -playfab_api_endpoint=<playfab_api_endpoint> -title_secret_key=<title_secret_key> -custom_data=<custom_data> -log_file_path=<log_file_path> -output_files_directory_path=<output_files_directory_path>",
    ///   "ExecutablePath": "\\ShooterGame\\Binaries\\Win64\\ShooterGameServer.exe",
    ///   "ActiveRegions": [
    ///     "USCentral",
    ///     "EUWest"
    ///   ],
    ///   "Comment": "Testing new IAP methods",
    ///   "MaxGamesPerHost": 5,
    ///   "MinFreeGameSlots": 1
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/custom-server-management/addserverbuild">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddServerBuildResult>> AddServerBuildAsync(AddServerBuildRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increments the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddUserVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/adduservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds one or more virtual currencies to the set defined for the title. Virtual Currencies have a maximum
    /// value of 2,147,483,647 when granted to a player. Any value over that will be discarded.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.AddVirtualCurrencyTypesAsync({);
    ///   "VirtualCurrencies": [
    ///     {
    ///       "CurrencyCode": "CC",
    ///       "DisplayName": "Chump Coins",
    ///       "InitialDeposit": 100,
    ///       "RechargeRate": 1000,
    ///       "RechargeMax": 1000
    ///     },
    ///     {
    ///       "CurrencyCode": "GC"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/addvirtualcurrencytypes">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BlankResult>> AddVirtualCurrencyTypesAsync(AddVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Bans users by PlayFab ID with optional IP address, or MAC address for the provided game.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.BanUsersAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/banusers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Checks the global count for the limited edition item.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CheckLimitedEditionItemAvailabilityAsync({);
    ///   "CatalogVersion": "Rares",
    ///   "ItemId": "FreeHoodie"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/checklimitededitionitemavailability">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CheckLimitedEditionItemAvailabilityResult>> CheckLimitedEditionItemAvailabilityAsync(CheckLimitedEditionItemAvailabilityRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create an ActionsOnPlayersInSegment task, which iterates through all players in a segment to execute action.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateActionsOnPlayersInSegmentTaskAsync({);
    ///   "Name": "PushNotificationVIP_Halloween",
    ///   "Description": "Send push notification to VIP players about Halloween event",
    ///   "IsActive": false,
    ///   "Parameter": {
    ///     "SegmentId": "274828AF93F13472",
    ///     "Actions": [
    ///       {
    ///         "GrantItemContent": {
    ///           "CatalogVersion": "foo",
    ///           "ItemId": "bar",
    ///           "ItemQuantity": 1
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/createactionsonplayersinsegmenttask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTaskResult>> CreateActionsOnPlayersInSegmentTaskAsync(CreateActionsOnPlayerSegmentTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a CloudScript task, which can run a CloudScript on a schedule.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateCloudScriptAzureFunctionsTaskAsync({);
    ///   "Name": "EnableWeekdayHappyHour",
    ///   "Description": "Turn on special pricing for weekday happy hour.",
    ///   "Schedule": "0 17 * * 1-5",
    ///   "IsActive": false,
    ///   "Parameter": {
    ///     "FunctionName": "applyStorePreset",
    ///     "Argument": {
    ///       "preset": "WeekdayHappyHour"
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/createcloudscriptazurefunctionstask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptAzureFunctionsTaskAsync(CreateCloudScriptAzureFunctionsTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a CloudScript task, which can run a CloudScript on a schedule.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateCloudScriptTaskAsync({);
    ///   "Name": "EnableWeekdayHappyHour",
    ///   "Description": "Turn on special pricing for weekday happy hour.",
    ///   "Schedule": "0 17 * * 1-5",
    ///   "IsActive": false,
    ///   "Parameter": {
    ///     "FunctionName": "applyStorePreset",
    ///     "Argument": {
    ///       "preset": "WeekdayHappyHour"
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/createcloudscripttask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptTaskAsync(CreateCloudScriptTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a Insights Scheduled Scaling task, which can scale Insights Performance Units on a schedule
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateInsightsScheduledScalingTaskAsync({);
    ///   "Name": "EnableWeekdayPerformance",
    ///   "Description": "Scale up Insights Performance Units during weekdays.",
    ///   "Schedule": "0 0 * * 1-5",
    ///   "IsActive": false,
    ///   "Parameter": {
    ///     "Level": 3
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/createinsightsscheduledscalingtask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTaskResult>> CreateInsightsScheduledScalingTaskAsync(CreateInsightsScheduledScalingTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Registers a relationship between a title and an Open ID Connect provider.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateOpenIdConnectionAsync({);
    ///   "ConnectionId": "oidconnection1",
    ///   "ClientId": "example_id_1",
    ///   "ClientSecret": "example_secret_1",
    ///   "IssuerInformation": {
    ///     "Issuer": "https://issuer.example.com/",
    ///     "AuthorizationUrl": "https://issuer.example.com/authorize",
    ///     "TokenUrl": "https://issuer.example.com/oauth2/token",
    ///     "JsonWebKeySet": {
    ///       "keys": [
    ///         "..."
    ///       ]
    ///     }
    ///   },
    ///   "IssuerOverride": "https://issueroverride.example.com/",
    ///   "IgnoreNonce": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/createopenidconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> CreateOpenIdConnectionAsync(CreateOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new Player Shared Secret Key. It may take up to 5 minutes for this key to become generally available after
    /// this API returns.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreatePlayerSharedSecretAsync({);
    ///   "FriendlyName": "iOS Users"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/createplayersharedsecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreatePlayerSharedSecretResult>> CreatePlayerSharedSecretAsync(CreatePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Adds a new player statistic configuration to the title, optionally allowing the developer to specify a reset interval
    /// and an aggregation method.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreatePlayerStatisticDefinitionAsync({);
    ///   "StatisticName": "headshots",
    ///   "VersionChangeInterval": "Never",
    ///   "ShouldProvisionLeaderboard": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/createplayerstatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreatePlayerStatisticDefinitionResult>> CreatePlayerStatisticDefinitionAsync(CreatePlayerStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new player segment by defining the conditions on player properties. Also, create actions to target the player
    /// segments for a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.CreateSegmentAsync({);
    ///   "SegmentModel": {
    ///     "Name": "My user segment",
    ///     "LastUpdateTime": "0001-01-01T00:00:00Z",
    ///     "SegmentOrDefinitions": [
    ///       {
    ///         "SegmentAndDefinitions": [
    ///           {
    ///             "AllPlayersFilter": {}
    ///           }
    ///         ]
    ///       }
    ///     ],
    ///     "EnteredSegmentActions": [
    ///       {
    ///         "BanPlayerAction": {
    ///           "BanHours": 2,
    ///           "ReasonForBan": "Not played for a year"
    ///         }
    ///       }
    ///     ],
    ///     "LeftSegmentActions": [
    ///       {
    ///         "ExecuteAzureFunctionAction": {
    ///           "AzureFunction": "AzureFunction1",
    ///           "FunctionParameter": "{\"InputParam\": \"1\"}",
    ///           "GenerateFunctionExecutedEvents": false
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/segments/createsegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateSegmentResponse>> CreateSegmentAsync(CreateSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a content file from the title. When deleting a file that does not exist, it returns success.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteContentAsync({);
    ///   "Key": "images/sword_icon.png"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/content/deletecontent">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BlankResult>> DeleteContentAsync(DeleteContentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a sink to stop sending PlayStream and Telemetry event data
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteEventSinkAsync({);
    ///   "Name": "MyStorage"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/deleteeventsink">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteEventSinkResult>> DeleteEventSinkAsync(DeleteEventSinkRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes a master player account entirely from all titles and deletes all associated data
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteMasterPlayerAccountAsync({);
    ///   "PlayFabId": "A68C908B66C23C5",
    ///   "MetaData": "Identifying info"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/deletemasterplayeraccount">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteMasterPlayerAccountResult>> DeleteMasterPlayerAccountAsync(DeleteMasterPlayerAccountRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes PlayStream and telemetry event data associated with the master player account from PlayFab storage
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteMasterPlayerEventDataAsync({);
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/deletemasterplayereventdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteMasterPlayerEventDataResult>> DeleteMasterPlayerEventDataAsync(DeleteMasterPlayerEventDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a player's subscription
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteMembershipSubscriptionAsync({);
    ///   "MembershipId": "ShieldBonusMembership",
    ///   "SubscriptionId": "39F6B89A-0F0C-4D96-B12C-BA89543A11A1",
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/deletemembershipsubscription">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteMembershipSubscriptionResult>> DeleteMembershipSubscriptionAsync(DeleteMembershipSubscriptionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes a relationship between a title and an OpenID Connect provider.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteOpenIdConnectionAsync({);
    ///   "ConnectionId": "oidconnection1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/deleteopenidconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteOpenIdConnectionAsync(DeleteOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes a user's player account from a title and deletes all associated data
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeletePlayerAsync({);
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/deleteplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes title-specific custom properties for a player
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeletePlayerCustomPropertiesAsync({);
    ///   "PlayFabId": "2039475",
    ///   "PropertyNames": [
    ///     "level",
    ///     "created"
    ///   ],
    ///   "ExpectedPropertiesVersion": 12
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/deleteplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeletePlayerCustomPropertiesResult>> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes an existing Player Shared Secret Key. It may take up to 5 minutes for this delete to be reflected after this
    /// API returns.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeletePlayerSharedSecretAsync({);
    ///   "SecretKey": "keysaresecret"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/deleteplayersharedsecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeletePlayerSharedSecretResult>> DeletePlayerSharedSecretAsync(DeletePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes an existing player segment and its associated action(s) for a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteSegmentAsync({);
    ///   "SegmentId": "97EF0E9302CBE996"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/segments/deletesegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteSegmentsResponse>> DeleteSegmentAsync(DeleteSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Deletes an existing virtual item store
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteStoreAsync({);
    ///   "StoreId": "BonusStore"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/deletestore">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteStoreResult>> DeleteStoreAsync(DeleteStoreRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a task.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteTaskAsync({);
    ///   "Identifier": {
    ///     "Id": "E1772FD927D8539D"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/deletetask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteTaskAsync(DeleteTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Permanently deletes a title and all associated configuration
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteTitleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/deletetitle">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteTitleResult>> DeleteTitleAsync(DeleteTitleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a specified set of title data overrides.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteTitleDataOverrideAsync({);
    ///   "OverrideLabel": "LaunchData"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/deletetitledataoverride">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteTitleDataOverrideResult>> DeleteTitleDataOverrideAsync(DeleteTitleDataOverrideRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the users for the provided game. Deletes custom data, all account linkages, and statistics. This method does
    /// not remove the player's event history, login history, inventory items, nor virtual currencies.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.DeleteUsersAsync({);
    ///   "PlayFabIds": [
    ///     "203945882"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/deleteusers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteUsersResult>> DeleteUsersAsync(DeleteUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Exports all associated data of a master player account
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ExportMasterPlayerDataAsync({);
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/exportmasterplayerdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExportMasterPlayerDataResult>> ExportMasterPlayerDataAsync(ExportMasterPlayerDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Starts an export for the player profiles in a segment. This API creates a snapshot of all the player profiles which
    /// match the segment definition at the time of the API call. Profiles which change while an export is in progress will not
    /// be reflected in the results.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ExportPlayersInSegmentAsync({);
    ///   "SegmentId": "ABCDEF1234567890"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/exportplayersinsegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExportPlayersInSegmentResult>> ExportPlayersInSegmentAsync(ExportPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get information about a ActionsOnPlayersInSegment task instance.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetActionsOnPlayersInSegmentTaskInstanceAsync({);
    ///   "TaskInstanceId": "E52531B47B1761C7-4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/getactionsonplayersinsegmenttaskinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>> GetActionsOnPlayersInSegmentTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieve a list of all PlayStream actions groups.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetAllActionGroupsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getallactiongroups">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAllActionGroupsResult>> GetAllActionGroupsAsync(GetAllActionGroupsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves an array of player segment definitions. Results from this can be used in subsequent API calls such as
    /// GetPlayersInSegment which requires a Segment ID. While segment names can change the ID for that segment will not change.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetAllSegmentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getallsegments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified version of the title's catalog of virtual goods, including all defined properties
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetCatalogItemsAsync({);
    ///   "CatalogVersion": "1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/getcatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get detail information about a CloudScript Azure Functions task instance.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetCloudScriptAzureFunctionsTaskInstanceAsync({);
    ///   "TaskInstanceId": "E52531B47B1761C7-4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/getcloudscriptazurefunctionstaskinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCloudScriptAzureFunctionsTaskInstanceResult>> GetCloudScriptAzureFunctionsTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the contents and information of a specific Cloud Script revision.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetCloudScriptRevisionAsync({);
    ///   "Version": 1,
    ///   "Revision": 3
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/server-side-cloud-script/getcloudscriptrevision">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCloudScriptRevisionResult>> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get detail information about a CloudScript task instance.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetCloudScriptTaskInstanceAsync({);
    ///   "TaskInstanceId": "E52531B47B1761C7-4"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/getcloudscripttaskinstance">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCloudScriptTaskInstanceResult>> GetCloudScriptTaskInstanceAsync(GetTaskInstanceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists all the current cloud script versions. For each version, information about the current published and latest
    /// revisions is also listed.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetCloudScriptVersionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/server-side-cloud-script/getcloudscriptversions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCloudScriptVersionsResult>> GetCloudScriptVersionsAsync(GetCloudScriptVersionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all contents of the title and get statistics such as size
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetContentListAsync({);
    ///   "Prefix": "2016/1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/content/getcontentlist">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetContentListResult>> GetContentListAsync(GetContentListRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the pre-signed URL for uploading a content file. A subsequent HTTP PUT to the returned URL uploads the
    /// content. Also, please be aware that the Content service is specifically PlayFab's CDN offering, for which standard CDN
    /// rates apply.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetContentUploadUrlAsync({);
    ///   "Key": "images/sword_icon.png",
    ///   "ContentType": "image/png"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/content/getcontentuploadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetContentUploadUrlResult>> GetContentUploadUrlAsync(GetContentUploadUrlRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a download URL for the requested report
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetDataReportAsync({);
    ///   "ReportName": "PurchaseDataReport",
    ///   "Year": 2014,
    ///   "Month": 12,
    ///   "Day": 5
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getdatareport">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetDataReportResult>> GetDataReportAsync(GetDataReportRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the set of sinks to which to route PlayStream and Telemetry event data.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetEventSinksAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/geteventsinks">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEventSinksResult>> GetEventSinksAsync(GetEventSinksRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the details for a specific completed session, including links to standard out and standard error logs
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetMatchmakerGameInfoAsync({);
    ///   "LobbyId": "2938488"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/matchmaking/getmatchmakergameinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMatchmakerGameInfoResult>> GetMatchmakerGameInfoAsync(GetMatchmakerGameInfoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the details of defined game modes for the specified game server executable
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetMatchmakerGameModesAsync({);
    ///   "BuildVersion": "5.0.1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/matchmaking/getmatchmakergamemodes">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMatchmakerGameModesResult>> GetMatchmakerGameModesAsync(GetMatchmakerGameModesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get the list of titles that the player has played
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayedTitleListAsync({);
    ///   "PlayFabId": "A68C908B66C23C5"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/getplayedtitlelist">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayedTitleListResult>> GetPlayedTitleListAsync(GetPlayedTitleListRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a title-specific custom property value for a player.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerCustomPropertyAsync({);
    ///   "PlayFabId": "2039475",
    ///   "PropertyName": "level"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getplayercustomproperty">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerCustomPropertyResult>> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a player's ID from an auth token.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerIdFromAuthTokenAsync({);
    ///   "Token": "3F584AD0EF943E2",
    ///   "TokenType": "Email"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/getplayeridfromauthtoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerIdFromAuthTokenResult>> GetPlayerIdFromAuthTokenAsync(GetPlayerIdFromAuthTokenRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the player's profile
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerProfileAsync({);
    ///   "PlayFabId": "621EF20237534A44"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/getplayerprofile">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all segments that a player currently belongs to at this moment in time.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerSegmentsAsync({);
    ///   "PlayFabId": "1337AA00"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getplayersegments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Returns all Player Shared Secret Keys including disabled and expired.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerSharedSecretsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/getplayersharedsecrets">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSharedSecretsResult>> GetPlayerSharedSecretsAsync(GetPlayerSharedSecretsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Allows for paging through all players in a given segment. This API creates a snapshot of all player profiles that match
    /// the segment definition at the time of its creation and lives through the Total Seconds to Live, refreshing its life
    /// span on each subsequent use of the Continuation Token. Profiles that change during the course of paging will not be
    /// reflected in the results. AB Test segments are currently not supported by this operation. NOTE: This API is limited to
    /// being called 30 times in one minute. You will be returned an error if you exceed this threshold.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayersInSegmentAsync({);
    ///   "SegmentId": "1337AA00",
    ///   "SecondsToLive": 5,
    ///   "MaxBatchSize": 500
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getplayersinsegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the configuration information for all player statistics defined in the title, regardless of whether they have
    /// a reset interval.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerStatisticDefinitionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getplayerstatisticdefinitions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerStatisticDefinitionsResult>> GetPlayerStatisticDefinitionsAsync(GetPlayerStatisticDefinitionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the information on the available versions of the specified statistic.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerStatisticVersionsAsync({);
    ///   "StatisticName": "headshots"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getplayerstatisticversions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get all tags with a given Namespace (optional) from a player profile.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPlayerTagsAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "Namespace": "title.AAA"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getplayertags">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the requested policy.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPolicyAsync({);
    ///   "PolicyName": "ApiPolicy"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/getpolicy">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPolicyResponse>> GetPolicyAsync(GetPolicyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetPublisherDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/getpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the random drop table configuration for the title
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetRandomResultTablesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/getrandomresulttables">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the result of an export started by ExportPlayersInSegment API. If the ExportPlayersInSegment is successful
    /// and complete, this API returns the IndexUrl from which the index file can be downloaded. The index file has a list of
    /// urls from which the files containing the player profile data can be downloaded. Otherwise, it returns the current
    /// 'State' of the export
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetSegmentExportAsync({);
    ///   "ExportId": "ABCDEF1234567890"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/getsegmentexport">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayersInSegmentExportResponse>> GetSegmentExportAsync(GetPlayersInSegmentExportRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get detail information of a segment and its associated definition(s) and action(s) for a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetSegmentsAsync({);
    ///   "SegmentIds": [
    ///     "B05FC8CB558A6570",
    ///     "97EF0E9302CBE996"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/segments/getsegments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetSegmentsResponse>> GetSegmentsAsync(GetSegmentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the build details for the specified game server executable
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetServerBuildInfoAsync({);
    ///   "BuildId": "5.0.1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/custom-server-management/getserverbuildinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetServerBuildInfoResult>> GetServerBuildInfoAsync(GetServerBuildInfoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the set of items defined for the specified store, including all prices defined
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetStoreItemsAsync({);
    ///   "StoreId": "BonusStore"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/getstoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Query for task instances by task, status, or time range.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetTaskInstancesAsync({);
    ///   "StatusFilter": "Failed",
    ///   "StartedAtRangeFrom": "2016-08-23T11:00:00Z"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/gettaskinstances">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTaskInstancesResult>> GetTaskInstancesAsync(GetTaskInstancesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get definition information on a specified task or all tasks within a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetTasksAsync({);
    ///   "Identifier": {
    ///     "Name": "EnableDailyHappyHour"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/gettasks">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTasksResult>> GetTasksAsync(GetTasksRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom title settings which can be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetTitleDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/gettitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the key-value store of custom title settings which cannot be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetTitleInternalDataAsync({);
    ///   "Keys": [
    ///     "color",
    ///     "propertyA"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/gettitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the relevant details for a specified user, based upon a match against a supplied unique identifier
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserAccountInfoAsync({);
    ///   "PlayFabId": "293753934",
    ///   "IgnoreMissingTitleActivation": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/getuseraccountinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LookupUserAccountInfoResult>> GetUserAccountInfoAsync(LookupUserAccountInfoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets all bans for a user.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserBansAsync({);
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/getuserbans">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retrieves the specified user's current inventory of virtual goods
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserInventoryAsync({);
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/getuserinventory">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserPublisherDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserPublisherInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserpublisherinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserPublisherReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserpublisherreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GetUserReadOnlyDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Keys": [
    ///     "preferences",
    ///     "progress"
    ///   ],
    ///   "IfChangedFromDataVersion": 13
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/getuserreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Adds the specified items to the specified user inventories
    /// <example><br/>Example:<code>
    /// var response = await adminApi.GrantItemsToUsersAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/grantitemstousers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Increases the global count for the given scarce resource.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.IncrementLimitedEditionItemAvailabilityAsync({);
    ///   "CatalogVersion": "Rares",
    ///   "ItemId": "FreeHoodie",
    ///   "Amount": 50
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/incrementlimitededitionitemavailability">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>> IncrementLimitedEditionItemAvailabilityAsync(IncrementLimitedEditionItemAvailabilityRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Resets the indicated statistic, removing all player entries for it and backing up the old values.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.IncrementPlayerStatisticVersionAsync({);
    ///   "StatisticName": "headshots"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/incrementplayerstatisticversion">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<IncrementPlayerStatisticVersionResult>> IncrementPlayerStatisticVersionAsync(IncrementPlayerStatisticVersionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a list of all Open ID Connect providers registered to a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ListOpenIdConnectionAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/listopenidconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListOpenIdConnectionResponse>> ListOpenIdConnectionAsync(ListOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves title-specific custom property values for a player.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ListPlayerCustomPropertiesAsync({);
    ///   "PlayFabId": "2039475"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/listplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListPlayerCustomPropertiesResult>> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the build details for all game server executables which are currently defined for the title
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ListServerBuildsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/custom-server-management/listserverbuilds">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListBuildsResult>> ListServerBuildsAsync(ListBuildsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Retuns the list of all defined virtual currencies for the title
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ListVirtualCurrencyTypesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/listvirtualcurrencytypes">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListVirtualCurrencyTypesResult>> ListVirtualCurrencyTypesAsync(ListVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the game server mode details for the specified game server executable
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ModifyMatchmakerGameModesAsync({);
    ///   "BuildVersion": "5.0.1",
    ///   "GameModes": [
    ///     {
    ///       "Gamemode": "0",
    ///       "MinPlayerCount": 2,
    ///       "MaxPlayerCount": 25
    ///     },
    ///     {
    ///       "Gamemode": "1",
    ///       "MinPlayerCount": 4,
    ///       "MaxPlayerCount": 35,
    ///       "StartOpen": false
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/matchmaking/modifymatchmakergamemodes">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyMatchmakerGameModesResult>> ModifyMatchmakerGameModesAsync(ModifyMatchmakerGameModesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the build details for the specified game server executable
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ModifyServerBuildAsync({);
    ///   "BuildId": "5.0.1",
    ///   "Timestamp": "2014-03-24T00:00:00Z",
    ///   "ActiveRegions": [
    ///     "USCentral",
    ///     "EUWest"
    ///   ],
    ///   "MaxGamesPerHost": 5,
    ///   "MinFreeGameSlots": 2,
    ///   "ExecutablePath": "\\ShooterGame\\Binaries\\Win64\\ShooterGameServer.exe",
    ///   "Comment": "Testing new IAP methods"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/custom-server-management/modifyserverbuild">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyServerBuildResult>> ModifyServerBuildAsync(ModifyServerBuildRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Attempts to process an order refund through the original real money payment provider.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RefundPurchaseAsync({);
    ///   "PlayFabId": "20394883",
    ///   "OrderId": "B456AE0",
    ///   "Reason": "Customer Request"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/refundpurchase">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RefundPurchaseResponse>> RefundPurchaseAsync(RefundPurchaseRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Remove a given tag from a player profile. The tag's namespace is automatically generated based on the source of the tag.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RemovePlayerTagAsync({);
    ///   "PlayFabId": "10931252888739651331",
    ///   "TagName": "MostKilled"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/removeplayertag">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes the game server executable specified from the set of those a client is permitted to request in a call to
    /// StartGame
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RemoveServerBuildAsync({);
    ///   "BuildId": "5.0.1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/custom-server-management/removeserverbuild">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RemoveServerBuildResult>> RemoveServerBuildAsync(RemoveServerBuildRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Removes one or more virtual currencies from the set defined for the title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RemoveVirtualCurrencyTypesAsync({);
    ///   "VirtualCurrencies": [
    ///     {
    ///       "CurrencyCode": "CC"
    ///     },
    ///     {
    ///       "CurrencyCode": "GC"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/removevirtualcurrencytypes">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BlankResult>> RemoveVirtualCurrencyTypesAsync(RemoveVirtualCurrencyTypesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Completely removes all statistics for the specified character, for the current game
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ResetCharacterStatisticsAsync({);
    ///   "PlayFabId": "293753934",
    ///   "CharacterId": "7654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/characters/resetcharacterstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ResetCharacterStatisticsResult>> ResetCharacterStatisticsAsync(ResetCharacterStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Reset a player's password for a given title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ResetPasswordAsync({);
    ///   "Token": "2B584FA1DF645E4",
    ///   "Password": "ExampleSecret@r"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/resetpassword">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ResetPasswordResult>> ResetPasswordAsync(ResetPasswordRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Resets all title-specific information about a particular account, including user data, virtual currency balances,
    /// inventory, purchase history, and statistics
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ResetUsersAsync({);
    ///   "Users": [
    ///     {
    ///       "Username": "John"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/resetusers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BlankResult>> ResetUsersAsync(ResetUsersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Completely removes all statistics for the specified user, for the current game
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ResetUserStatisticsAsync({);
    ///   "PlayFabId": "293753934"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/resetuserstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ResetUserStatisticsResult>> ResetUserStatisticsAsync(ResetUserStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Attempts to resolve a dispute with the original order's payment provider.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.ResolvePurchaseDisputeAsync({);
    ///   "PlayFabId": "20394883",
    ///   "OrderId": "B456AE0",
    ///   "Reason": "Customer Request",
    ///   "Outcome": "Reinstate"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/resolvepurchasedispute">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ResolvePurchaseDisputeResponse>> ResolvePurchaseDisputeAsync(ResolvePurchaseDisputeRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Revoke all active bans for a user.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RevokeAllBansForUserAsync({);
    ///   "PlayFabId": "1679AF5CD04BD838"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/revokeallbansforuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Revoke all active bans specified with BanId.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RevokeBansAsync({);
    ///   "BanIds": [
    ///     "E0B5FF89542D413C",
    ///     "EF43FF89542G1546"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/revokebans">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access to an item in a user's inventory
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RevokeInventoryItemAsync({);
    ///   "PlayFabId": "203945882",
    ///   "ItemInstanceId": "2048583045"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/revokeinventoryitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Revokes access for up to 25 items across multiple users and characters.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RevokeInventoryItemsAsync({);
    ///   "Items": [
    ///     {
    ///       "PlayFabId": "203945882",
    ///       "ItemInstanceId": "2048583045"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/revokeinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Run a task immediately regardless of its schedule.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.RunTaskAsync({);
    ///   "Identifier": {
    ///     "Id": "E1772FD927D8539D"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/runtask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RunTaskResult>> RunTaskAsync(RunTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Forces an email to be sent to the registered email address for the user's account, with a link allowing the user to
    /// change the password.If an account recovery email template ID is provided, an email using the custom email template will
    /// be used.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SendAccountRecoveryEmailAsync({);
    ///   "Email": "assignedemail@here.com",
    ///   "EmailTemplateId": "D53AB15D8F12E330"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/sendaccountrecoveryemail">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Creates the catalog configuration of all virtual goods for the specified catalog version
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetCatalogItemsAsync({);
    ///   "CatalogVersion": "5",
    ///   "Catalog": [
    ///     {
    ///       "ItemId": "shield_level_5",
    ///       "ItemClass": "shields",
    ///       "DisplayName": "Level 5 Shield",
    ///       "Description": "Strong defense against projectile attacks",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199,
    ///         "GV": 25
    ///       },
    ///       "RealCurrencyPrices": {
    ///         "GBP": 149,
    ///         "EUR": 169
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "energy_boost_1",
    ///       "ItemClass": "boosts",
    ///       "DisplayName": "Energy Drink Six-Pack",
    ///       "Description": "Get a quick burst of energy whenever you need it",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199,
    ///         "GV": 25
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_1",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 1",
    ///       "Description": "Item 1 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_2",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 2",
    ///       "Description": "Item 2 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_3",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 3",
    ///       "Description": "Item 3 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_4",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 4",
    ///       "Description": "Item 4 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "granted_item_a",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Granted Item A",
    ///       "Description": "Bonus item granted for free once the full set of 4 Grant Set items are collected",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "consumable_item_1",
    ///       "ItemClass": "Consumables",
    ///       "DisplayName": "Consumable Item 1",
    ///       "Description": "Item demonstrating usage-based consumables",
    ///       "VirtualCurrencyPrices": {
    ///         "GV": 500
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 3
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "consumable_item_2",
    ///       "ItemClass": "Consumables",
    ///       "DisplayName": "Consumable Item 2",
    ///       "Description": "Item demonstrating time-based consumables",
    ///       "VirtualCurrencyPrices": {
    ///         "GV": 750
    ///       },
    ///       "Consumable": {
    ///         "UsagePeriod": 3600,
    ///         "UsagePeriodGroup": "usage_group_1"
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_bundle_item_1",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Bundled Item 1",
    ///       "Description": "Item which is added to the user inventory as part of a bundle",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_bundle_item_2",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Bundled Item 2",
    ///       "Description": "Item which is added to the user inventory as part of a bundle",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_bundle_1",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Item bundle 1",
    ///       "Description": "Item which, when added to the user inventory, also adds other bundled items",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 599
    ///       },
    ///       "Bundle": {
    ///         "BundledItems": [
    ///           "sub_bundle_item_1",
    ///           "sub_bundle_item_2"
    ///         ],
    ///         "BundledResultTables": [
    ///           "random_result_1"
    ///         ],
    ///         "BundledVirtualCurrencies": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "key_item_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Key Item 1",
    ///       "Description": "Key used to unlock Container 1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_container_item_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Container Item 1",
    ///       "Description": "Item which is added to the user inventory as part of opening a container",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_container_item_2",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Container Item 2",
    ///       "Description": "Item which is added to the user inventory as part of opening a container",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_container_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Item Container 1",
    ///       "Description": "Item which, when opened with Key Item 1, also adds the items it holds to the user inventory",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 499
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 1
    ///       },
    ///       "Container": {
    ///         "KeyItemId": "key_item_1",
    ///         "ItemContents": [
    ///           "sub_container_item_1",
    ///           "sub_container_item_2"
    ///         ],
    ///         "ResultTableContents": [
    ///           "random_result_1"
    ///         ],
    ///         "VirtualCurrencyContents": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_container_2",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Item Container 2",
    ///       "Description": "Item which, when opened (no key needed), adds the items it holds to the user inventory",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 99
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 1
    ///       },
    ///       "Container": {
    ///         "VirtualCurrencyContents": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "starterpack_1",
    ///       "ItemClass": "starterpacks",
    ///       "DisplayName": "Super Starter Pack",
    ///       "Description": "Everything you need to get started fast track at the right price",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/setcatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateCatalogItemsResult>> SetCatalogItemsAsync(UpdateCatalogItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the sink to which to route PlayStream and Telemetry event data.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetEventSinkAsync({);
    ///   "Sink": {
    ///     "Name": "MyStorage",
    ///     "DestinationType": "AzureBlobStorage",
    ///     "IsEnabled": true,
    ///     "SinkSettings": {
    ///       "AccountName": "mystorageaccount",
    ///       "ContainerName": "mycontainername",
    ///       "TenantId": null,
    ///       "Credentials": {
    ///         "Secret": ""
    ///       }
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/playstream/seteventsink">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetEventSinkResult>> SetEventSinkAsync(SetEventSinkRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the override expiration for a membership subscription
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetMembershipOverrideAsync({);
    ///   "ExpirationTime": "2014-04-06T00:00:00Z",
    ///   "MembershipId": "ShieldBonusMembership",
    ///   "PlayFabId": "204883457"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/setmembershipoverride">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetMembershipOverrideResult>> SetMembershipOverrideAsync(SetMembershipOverrideRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets or resets the player's secret. Player secrets are used to sign API requests.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetPlayerSecretAsync({);
    ///   "PlayerSecret": "ExampleSecret",
    ///   "PlayFabId": "ABCD1234"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/setplayersecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the currently published revision of a title Cloud Script
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetPublishedRevisionAsync({);
    ///   "Version": 1,
    ///   "Revision": 3
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/server-side-cloud-script/setpublishedrevision">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetPublishedRevisionResult>> SetPublishedRevisionAsync(SetPublishedRevisionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the key-value store of custom publisher settings
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetPublisherDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/shared-group-data/setpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Sets all the items in one virtual store
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetStoreItemsAsync({);
    ///   "StoreId": "BonusStore",
    ///   "Store": [
    ///     {
    ///       "ItemId": "shield_level_5",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 180,
    ///         "GV": 20
    ///       },
    ///       "RealCurrencyPrices": {
    ///         "GBP": 100
    ///       }
    ///     },
    ///     {
    ///       "ItemId": "energy_boost_1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 250,
    ///         "GV": 30
    ///       }
    ///     },
    ///     {
    ///       "ItemId": "starterpack_1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 399
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/setstoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateStoreItemsResult>> SetStoreItemsAsync(UpdateStoreItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates and updates the key-value store of custom title settings which can be read by the client. For example, a
    /// developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths,
    /// movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new
    /// build.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetTitleDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/settitledata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Set and delete key-value pairs in a title data override instance.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetTitleDataAndOverridesAsync({);
    ///   "OverrideLabel": "Holiday title data",
    ///   "TitleId": "8FF3A797",
    ///   "KeyValues": [
    ///     {
    ///       "Key": "Running Speed",
    ///       "Value": "1.03"
    ///     },
    ///     {
    ///       "Key": "Walking Speed",
    ///       "Value": "0.05"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/settitledataandoverrides">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTitleDataAndOverridesResult>> SetTitleDataAndOverridesAsync(SetTitleDataAndOverridesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the key-value store of custom title settings which cannot be read by the client. These values can be used to
    /// tweak settings used by game servers and Cloud Scripts without the need to update and re-deploy.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetTitleInternalDataAsync({);
    ///   "Key": "Running Speed",
    ///   "Value": "1.03"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/settitleinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the Amazon Resource Name (ARN) for iOS and Android push notifications. Documentation on the exact restrictions can
    /// be found at: http://docs.aws.amazon.com/sns/latest/api/API_CreatePlatformApplication.html. Currently, Amazon device
    /// Messaging is not supported.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SetupPushNotificationAsync({);
    ///   "Platform": "APNS_SANDBOX",
    ///   "Key": "MyKey123",
    ///   "Credential": "MyCredentialsXYZ",
    ///   "OverwriteOldARN": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/setuppushnotification">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetupPushNotificationResult>> SetupPushNotificationAsync(SetupPushNotificationRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Decrements the specified virtual currency by the stated amount
    /// <example><br/>Example:<code>
    /// var response = await adminApi.SubtractUserVirtualCurrencyAsync({);
    ///   "PlayFabId": "20394883",
    ///   "VirtualCurrency": "GC",
    ///   "Amount": 100
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-item-management/subtractuservirtualcurrency">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates information of a list of existing bans specified with Ban Ids.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateBansAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/updatebans">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Updates the catalog configuration for virtual goods in the specified catalog version
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateCatalogItemsAsync({);
    ///   "CatalogVersion": "5",
    ///   "Catalog": [
    ///     {
    ///       "ItemId": "shield_level_5",
    ///       "ItemClass": "shields",
    ///       "DisplayName": "Level 5 Shield",
    ///       "Description": "Strong defense against projectile attacks",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199,
    ///         "GV": 25
    ///       },
    ///       "RealCurrencyPrices": {
    ///         "GBP": 149,
    ///         "EUR": 169
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "energy_boost_1",
    ///       "ItemClass": "boosts",
    ///       "DisplayName": "Energy Drink Six-Pack",
    ///       "Description": "Get a quick burst of energy whenever you need it",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199,
    ///         "GV": 25
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_1",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 1",
    ///       "Description": "Item 1 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_2",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 2",
    ///       "Description": "Item 2 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_3",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 3",
    ///       "Description": "Item 3 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "required_item_for_grant_a_4",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Grant Set Item 4",
    ///       "Description": "Item 4 from the set of items needed to get Granted Item A for free",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 249,
    ///         "GV": 1500
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "granted_item_a",
    ///       "ItemClass": "sets",
    ///       "DisplayName": "Granted Item A",
    ///       "Description": "Bonus item granted for free once the full set of 4 Grant Set items are collected",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "consumable_item_1",
    ///       "ItemClass": "Consumables",
    ///       "DisplayName": "Consumable Item 1",
    ///       "Description": "Item demonstrating usage-based consumables",
    ///       "VirtualCurrencyPrices": {
    ///         "GV": 500
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 3
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "consumable_item_2",
    ///       "ItemClass": "Consumables",
    ///       "DisplayName": "Consumable Item 2",
    ///       "Description": "Item demonstrating time-based consumables",
    ///       "VirtualCurrencyPrices": {
    ///         "GV": 750
    ///       },
    ///       "Consumable": {
    ///         "UsagePeriod": 3600,
    ///         "UsagePeriodGroup": "usage_group_1"
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_bundle_item_1",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Bundled Item 1",
    ///       "Description": "Item which is added to the user inventory as part of a bundle",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_bundle_item_2",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Bundled Item 2",
    ///       "Description": "Item which is added to the user inventory as part of a bundle",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_bundle_1",
    ///       "ItemClass": "Bundles",
    ///       "DisplayName": "Item bundle 1",
    ///       "Description": "Item which, when added to the user inventory, also adds other bundled items",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 599
    ///       },
    ///       "Bundle": {
    ///         "BundledItems": [
    ///           "sub_bundle_item_1",
    ///           "sub_bundle_item_2"
    ///         ],
    ///         "BundledResultTables": [
    ///           "random_result_1"
    ///         ],
    ///         "BundledVirtualCurrencies": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "key_item_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Key Item 1",
    ///       "Description": "Key used to unlock Container 1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 199
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_container_item_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Container Item 1",
    ///       "Description": "Item which is added to the user inventory as part of opening a container",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "sub_container_item_2",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Container Item 2",
    ///       "Description": "Item which is added to the user inventory as part of opening a container",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_container_1",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Item Container 1",
    ///       "Description": "Item which, when opened with Key Item 1, also adds the items it holds to the user inventory",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 499
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 1
    ///       },
    ///       "Container": {
    ///         "KeyItemId": "key_item_1",
    ///         "ItemContents": [
    ///           "sub_container_item_1",
    ///           "sub_container_item_2"
    ///         ],
    ///         "ResultTableContents": [
    ///           "random_result_1"
    ///         ],
    ///         "VirtualCurrencyContents": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "item_container_2",
    ///       "ItemClass": "Containers",
    ///       "DisplayName": "Item Container 2",
    ///       "Description": "Item which, when opened (no key needed), adds the items it holds to the user inventory",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 99
    ///       },
    ///       "Consumable": {
    ///         "UsageCount": 1
    ///       },
    ///       "Container": {
    ///         "VirtualCurrencyContents": {
    ///           "GV": 1000
    ///         }
    ///       },
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     },
    ///     {
    ///       "ItemId": "starterpack_1",
    ///       "ItemClass": "starterpacks",
    ///       "DisplayName": "Super Starter Pack",
    ///       "Description": "Everything you need to get started fast track at the right price",
    ///       "CanBecomeCharacter": false,
    ///       "IsStackable": false,
    ///       "IsTradable": false,
    ///       "IsLimitedEdition": false,
    ///       "InitialLimitedEditionCount": 0
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/updatecatalogitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateCatalogItemsResult>> UpdateCatalogItemsAsync(UpdateCatalogItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new Cloud Script revision and uploads source code to it. Note that at this time, only one file should be
    /// submitted in the revision.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateCloudScriptAsync({);
    ///   "Files": [
    ///     {
    ///       "Filename": "main.js",
    ///       "FileContents": "var LevelRewards =\r\n[\r\n\t[\"TestItem1\"],\r\n\t[\"TestItem2\"],\r\n\t[\"TestItem3\"],\r\n\t[\"TestItem1\", \"TestItem2\"],\r\n\t[\"TestItem2\", \"TestItem2\"],\r\n\t[\"TestItem3\", \"TestItem3\"]\r\n]\r\n\r\nhandlers.onLevelComplete = function(args)\r\n{\r\n\tvar levelNum = args.level;\r\n\t\r\n\t// Do some basic input validation\r\n\tif(levelNum < 0 || levelNum >= LevelRewards.length)\r\n\t{\r\n\t\tlog.info(\"Invalid level \"+levelNum+\" completed by \"+currentPlayerId);\r\n\t\treturn {};\r\n\t}\r\n\t\r\n\tvar levelCompleteKey = \"LevelCompleted\"+levelNum;\r\n\t\r\n\t// Get the user's internal data\r\n\tvar playerInternalData = server.GetUserInternalData(\r\n\t{\r\n\t\tPlayFabId: currentPlayerId,\r\n\t\tKeys: [levelCompleteKey]\r\n\t});\r\n\t\r\n\t// Did they already complete this level?\r\n\tif(playerInternalData.Data[levelCompleteKey])\r\n\t{\r\n\t\tlog.info(\"Player \"+currentPlayerId+\" already completed level \"+levelNum);\r\n\t\treturn {};\r\n\t}\r\n\t\r\n\tvar rewards = LevelRewards[levelNum];\r\n\t\r\n\tvar resultItems = null;\r\n\tif(rewards)\r\n\t{\r\n\t\t// Grant reward items to player for completing the level\r\n\t\tvar itemGrantResult = server.GrantItemsToUser(\r\n\t\t{\r\n\t\t\tPlayFabId: currentPlayerId,\r\n\t\t\tAnnotation: \"Given by completing level \"+levelNum,\r\n\t\t\tItemIds: rewards\r\n\t\t});\r\n\t\t\r\n\t\tresultItems = itemGrantResult.ItemGrantResults;\r\n\t}\r\n\t\r\n\t// Mark the level as being completed so they can't get the reward again\r\n\tvar saveData = {};\r\n\tsaveData[levelCompleteKey] = \"true\";\r\n\tserver.UpdateUserInternalData(\r\n\t{\r\n\t\tPlayFabId: currentPlayerId,\r\n\t\tData: saveData\r\n\t});\r\n\r\n\t// Return the results of the item grant so the client can see what they got\r\n\treturn {\r\n\t\trewards: resultItems\r\n\t};\r\n}\r\n\r\nvar monsterRewards =\r\n{\r\n\t\"skrill\" : { \"ChumpCoins\" : 100},\r\n\t\"lumpur\" : { \"ChumpCoins\" : 200}\r\n}\r\n\r\nvar killCoolDown = 60;\r\n\r\nfunction currTimeSeconds()\r\n{\r\n\tvar now = new Date();\r\n\treturn now.getTime() / 1000;\r\n}\r\n\r\nhandlers.monsterKilled = function(args)\r\n{\r\n\tvar monsterType = args.type;\r\n\t\r\n\tvar now = currTimeSeconds();\r\n\t\r\n\t// Get the user's internal data\r\n\tvar playerInternalData = server.GetUserInternalData(\r\n\t{\r\n\t\tPlayFabId: currentPlayerId,\r\n\t\tKeys: [\"lastKill\"]\r\n\t});\r\n\t\r\n\t// Check when the last time they killed a monster was \r\n\tvar lastKill = playerInternalData.Data[\"lastKill\"];\r\n\tif(lastKill)\r\n\t{\r\n\t\t// We have a value, see when it is\r\n\t\tvar lastKillTime = parseInt(lastKill.Value);\r\n\t\tif(now - lastKillTime < killCoolDown)\r\n\t\t{\r\n\t\t\t// In this particular game, it should not be possible to kill a monster more often than once a minute, so they might be cheating\r\n\t\t\tlog.info(\"Player \"+currentPlayerId+\" killed \"+monsterType+\" again too quickly!\");\r\n\t\t\treturn {};\r\n\t\t}\r\n\t}\r\n\t\r\n\tvar killReward = monsterRewards[monsterType];\r\n\t\r\n\tif(killReward)\r\n\t{\r\n\t\tfor(var currency in killReward)\r\n\t\t{\r\n\t\t\tvar amount = killReward[currency];\r\n\t\t\tserver.AddUserVirtualCurrency({ PlayFabId: currentPlayerId, VirtualCurrency: currency, Amount: amount });\r\n\t\t}\r\n\t}\r\n\t\r\n\t// Reset the kill timer\r\n\tserver.UpdateUserInternalData(\r\n\t{\r\n\t\tPlayFabId: currentPlayerId,\r\n\t\tData: {\r\n\t\t\t\"lastKill\" : String(now)\r\n\t\t}\r\n\t});\r\n\t\r\n\treturn {\r\n\t\trewards: killReward\r\n\t};\r\n}"
    ///     }
    ///   ],
    ///   "Publish": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/server-side-cloud-script/updatecloudscript">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateCloudScriptResult>> UpdateCloudScriptAsync(UpdateCloudScriptRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Modifies data and credentials for an existing relationship between a title and an Open ID Connect provider
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateOpenIdConnectionAsync({);
    ///   "ConnectionId": "oidconnection1",
    ///   "ClientId": "example_id_1",
    ///   "ClientSecret": "new_example_secret",
    ///   "IssuerInformation": {
    ///     "Issuer": "https://issuer.example.com/",
    ///     "AuthorizationUrl": "https://issuer.example.com/authorize",
    ///     "TokenUrl": "https://issuer.example.com/oauth2/token",
    ///     "JsonWebKeySet": {
    ///       "keys": [
    ///         "..."
    ///       ]
    ///     }
    ///   },
    ///   "IssuerOverride": "https://issueroverride.example.com/"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/updateopenidconnection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateOpenIdConnectionAsync(UpdateOpenIdConnectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom property values for a player
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdatePlayerCustomPropertiesAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateplayercustomproperties">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdatePlayerCustomPropertiesResult>> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates a existing Player Shared Secret Key. It may take up to 5 minutes for this update to become generally available
    /// after this API returns.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdatePlayerSharedSecretAsync({);
    ///   "SecretKey": "keysaresecret",
    ///   "FriendlyName": "XBox Users",
    ///   "Disabled": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/updateplayersharedsecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdatePlayerSharedSecretResult>> UpdatePlayerSharedSecretAsync(UpdatePlayerSharedSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates a player statistic configuration for the title, optionally allowing the developer to specify a reset interval.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdatePlayerStatisticDefinitionAsync({);
    ///   "StatisticName": "headshots",
    ///   "VersionChangeInterval": "Day",
    ///   "ShouldProvisionLeaderboard": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateplayerstatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdatePlayerStatisticDefinitionResult>> UpdatePlayerStatisticDefinitionAsync(UpdatePlayerStatisticDefinitionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Changes a policy for a title
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdatePolicyAsync({);
    ///   "PolicyName": "ApiPolicy",
    ///   "Statements": [
    ///     {
    ///       "Resource": "pfrn:api--*",
    ///       "Action": "*",
    ///       "Effect": "Allow",
    ///       "Principal": "*",
    ///       "Comment": "The default allow all policy"
    ///     },
    ///     {
    ///       "Resource": "pfrn:api--/Client/ConfirmPurchase",
    ///       "Action": "*",
    ///       "Effect": "Allow",
    ///       "Principal": "*",
    ///       "Comment": "This statement allows only request to ConfirmPurchase"
    ///     }
    ///   ],
    ///   "OverwritePolicy": false,
    ///   "PolicyVersion": 0
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/authentication/updatepolicy">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdatePolicyResponse>> UpdatePolicyAsync(UpdatePolicyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Updates the random drop table configuration for the title
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateRandomResultTablesAsync({);
    ///   "Tables": [
    ///     {
    ///       "TableId": "DropTable 1",
    ///       "Nodes": [
    ///         {
    ///           "ResultItemType": "ItemId",
    ///           "ResultItem": "Gold Crown 1",
    ///           "Weight": 20
    ///         },
    ///         {
    ///           "ResultItemType": "ItemId",
    ///           "ResultItem": "Magic Sword 3",
    ///           "Weight": 50
    ///         },
    ///         {
    ///           "ResultItemType": "ItemId",
    ///           "ResultItem": "Clear Shield 3",
    ///           "Weight": 70
    ///         }
    ///       ]
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/updaterandomresulttables">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateRandomResultTablesResult>> UpdateRandomResultTablesAsync(UpdateRandomResultTablesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates an existing player segment and its associated definition(s) and action(s) for a title.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateSegmentAsync({);
    ///   "SegmentModel": {
    ///     "SegmentId": "B05FC8CB558A6570",
    ///     "Name": "My user segment",
    ///     "LastUpdateTime": "0001-01-01T00:00:00Z",
    ///     "SegmentOrDefinitions": [
    ///       {
    ///         "SegmentAndDefinitions": [
    ///           {
    ///             "AllPlayersFilter": {}
    ///           }
    ///         ]
    ///       }
    ///     ],
    ///     "EnteredSegmentActions": [
    ///       {
    ///         "BanPlayerAction": {
    ///           "BanHours": 2,
    ///           "ReasonForBan": "Not played for a year"
    ///         }
    ///       }
    ///     ],
    ///     "LeftSegmentActions": [
    ///       {
    ///         "ExecuteAzureFunctionAction": {
    ///           "AzureFunction": "AzureFunction1",
    ///           "FunctionParameter": "{\"InputParam\": \"1\"}",
    ///           "GenerateFunctionExecutedEvents": false
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/segments/updatesegment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateSegmentResponse>> UpdateSegmentAsync(UpdateSegmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// _NOTE: This is a Legacy Economy API, and is in bugfix-only mode. All new Economy features are being developed only for
    /// version 2._ Updates an existing virtual item store with new or modified items
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateStoreItemsAsync({);
    ///   "StoreId": "BonusStore",
    ///   "Store": [
    ///     {
    ///       "ItemId": "shield_level_5",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 180,
    ///         "GV": 20
    ///       },
    ///       "RealCurrencyPrices": {
    ///         "GBP": 100
    ///       }
    ///     },
    ///     {
    ///       "ItemId": "energy_boost_1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 250,
    ///         "GV": 30
    ///       }
    ///     },
    ///     {
    ///       "ItemId": "starterpack_1",
    ///       "VirtualCurrencyPrices": {
    ///         "RM": 399
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/title-wide-data-management/updatestoreitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateStoreItemsResult>> UpdateStoreItemsAsync(UpdateStoreItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update an existing task.
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateTaskAsync({);
    ///   "Identifier": {
    ///     "Name": "PushEventNotificationVIP_Halloween"
    ///   },
    ///   "Name": "PushEventNotificationVIP_Thanksgiving",
    ///   "Description": "Send push notification to VIP about Thanksgiving event",
    ///   "IsActive": false,
    ///   "Type": "ActionsOnPlayerSegment",
    ///   "Parameter": {
    ///     "SegmentId": "E2B0F9C19B02D796",
    ///     "Actions": [
    ///       {
    ///         "GrantItemContent": {
    ///           "CatalogVersion": "foo",
    ///           "ItemId": "bar",
    ///           "ItemQuantity": 1
    ///         }
    ///       }
    ///     ]
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/scheduledtask/updatetask">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateTaskAsync(UpdateTaskRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserDataAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which is readable and writable by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserPublisherDataAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserpublisherdata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which cannot be accessed by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserPublisherInternalDataAsync({);
    ///   "PlayFabId": "2039475",
    ///   "Data": {
    ///     "Class": "Fighter",
    ///     "Gender": "Female",
    ///     "Icon": "Guard 3",
    ///     "Theme": "Colorful"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserpublisherinternaldata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the publisher-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserPublisherReadOnlyDataAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserpublisherreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title-specific custom data for the user which can only be read by the client
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserReadOnlyDataAsync({);
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
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/player-data-management/updateuserreadonlydata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the title specific display name for a user
    /// <example><br/>Example:<code>
    /// var response = await adminApi.UpdateUserTitleDisplayNameAsync({);
    ///   "PlayFabId": "293438",
    ///   "DisplayName": "New Display Name"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/admin/account-management/updateusertitledisplayname">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest request, Dictionary<string, string>? extraHeaders);
}