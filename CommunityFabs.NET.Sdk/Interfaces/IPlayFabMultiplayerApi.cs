using CommunityFabs.NET.Sdk.Models.Multiplayer;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabMultiplayerApi {
    /// <summary>
    /// Cancel all active tickets the player is a member of in a given queue.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CancelAllMatchmakingTicketsForPlayerAsync({);
    ///   "Entity": {
    ///     "Id": "123123123",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/cancelallmatchmakingticketsforplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult>> CancelAllMatchmakingTicketsForPlayerAsync(CancelAllMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Cancel all active backfill tickets the player is a member of in a given queue.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CancelAllServerBackfillTicketsForPlayerAsync({);
    ///   "Entity": {
    ///     "Id": "123123123",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/cancelallserverbackfillticketsforplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult>> CancelAllServerBackfillTicketsForPlayerAsync(CancelAllServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Cancel a matchmaking ticket.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CancelMatchmakingTicketAsync({);
    ///   "TicketId": "1c4b0daa-150e-47ae-9923-d770c0f9b07c",
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/cancelmatchmakingticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CancelMatchmakingTicketResult>> CancelMatchmakingTicketAsync(CancelMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Cancel a batch model creation.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.CancelModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/cancelmodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CancelModelResponse>> CancelModelAsync(CancelModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Cancel a server backfill ticket.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CancelServerBackfillTicketAsync({);
    ///   "TicketId": "1c4b0daa-150e-47ae-9923-d770c0f9b07c",
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/cancelserverbackfillticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CancelServerBackfillTicketResult>> CancelServerBackfillTicketAsync(CancelServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a base model with default settings.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.CreateBaseModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelName": "Test Batch Model",
    ///   "Conditions": [
    ///     {
    ///       "Key": "Platform",
    ///       "Rank": 2
    ///     },
    ///     {
    ///       "Key": "GameMode",
    ///       "Rank": 1
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/createbasemodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateBaseModelResponse>> CreateBaseModelAsync(CreateBaseModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a batch model that is learned from a title's match results in a scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.CreateBatchModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelName": "Test Batch Model",
    ///   "Conditions": [
    ///     {
    ///       "Key": "Platform",
    ///       "Rank": 2
    ///     },
    ///     {
    ///       "Key": "GameMode",
    ///       "Rank": 1
    ///     }
    ///   ],
    ///   "Events": [
    ///     "Kills",
    ///     "Deaths"
    ///   ],
    ///   "InitialSettingsModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf",
    ///   "MatchResultStartTimeUtc": "2025-06-20T13:31:18.566Z",
    ///   "MatchResultEndTimeUtc": "2025-06-20T14:01:18.566Z",
    ///   "MaxIterations": 100,
    ///   "AnomalousMatchResultIgnoreThreshold": -20.0
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/createbatchmodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateBatchModelResponse>> CreateBatchModelAsync(CreateBatchModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a multiplayer server build alias.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateBuildAliasAsync({);
    ///   "AliasName": "AliasName",
    ///   "BuildSelectionCriteria": [
    ///     {
    ///       "BuildWeightDistribution": {
    ///         "53781fa8-006d-4e9c-b733-57433d579285": 1
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createbuildalias">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BuildAliasDetailsResponse>> CreateBuildAliasAsync(CreateBuildAliasRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a multiplayer server build with a custom container.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateBuildWithCustomContainerAsync({);
    ///   "ContainerRunCommand": "/data/Assets -startserver",
    ///   "GameAssetReferences": [
    ///     {
    ///       "FileName": "gameserver.zip",
    ///       "MountPath": "/data/Assets"
    ///     }
    ///   ],
    ///   "ContainerImageReference": {
    ///     "ImageName": "ContainerImageName",
    ///     "Tag": "ContainerTag"
    ///   },
    ///   "LinuxInstrumentationConfiguration": {
    ///     "IsEnabled": false
    ///   },
    ///   "ContainerFlavor": "CustomLinux",
    ///   "ServerResourceConstraints": {
    ///     "CpuLimit": 0.5,
    ///     "MemoryLimitGB": 0.5
    ///   },
    ///   "BuildName": "GameBuildName",
    ///   "Metadata": {
    ///     "MetadataKey": "MetadataValue"
    ///   },
    ///   "VmSize": "Standard_D2_v2",
    ///   "MultiplayerServerCountPerVm": 10,
    ///   "Ports": [
    ///     {
    ///       "Name": "PortName",
    ///       "Num": 1243,
    ///       "Protocol": "TCP"
    ///     }
    ///   ],
    ///   "RegionConfigurations": [
    ///     {
    ///       "Region": "EastUs",
    ///       "MaxServers": 10,
    ///       "StandbyServers": 5,
    ///       "ScheduledStandbySettings": {
    ///         "IsEnabled": true,
    ///         "ScheduleList": [
    ///           {
    ///             "StartTime": "2020-08-21T17:00:00Z",
    ///             "EndTime": "2020-08-24T09:00:00Z",
    ///             "IsRecurringWeekly": true,
    ///             "IsDisabled": false,
    ///             "Description": "Weekend Schedule",
    ///             "TargetStandby": 8
    ///           },
    ///           {
    ///             "StartTime": "2020-08-24T09:00:00Z",
    ///             "EndTime": "2020-08-28T17:00:00Z",
    ///             "IsRecurringWeekly": true,
    ///             "IsDisabled": false,
    ///             "Description": "Weekday Schedule",
    ///             "TargetStandby": 3
    ///           }
    ///         ]
    ///       },
    ///       "RoutingSettings": {
    ///         "NumberOfMicrosoftRoutingIPs": 1,
    ///         "NumberOfInternetRoutingIPs": 1,
    ///         "DefaultRoutingType": 1
    ///       }
    ///     },
    ///     {
    ///       "Region": "WestUs",
    ///       "MaxServers": 50,
    ///       "StandbyServers": 8,
    ///       "ScheduledStandbySettings": {
    ///         "IsEnabled": true,
    ///         "ScheduleList": [
    ///           {
    ///             "StartTime": "2020-08-21T09:00:00Z",
    ///             "EndTime": "2020-08-21T23:00:00Z",
    ///             "IsRecurringWeekly": false,
    ///             "IsDisabled": false,
    ///             "Description": "Game Launch",
    ///             "TargetStandby": 30
    ///           }
    ///         ]
    ///       }
    ///     },
    ///     {
    ///       "Region": "NorthEurope",
    ///       "MaxServers": 7,
    ///       "StandbyServers": 3
    ///     }
    ///   ],
    ///   "GameCertificateReferences": [
    ///     {
    ///       "Name": "CertName",
    ///       "GsdkAlias": "CertGsdkAlias"
    ///     }
    ///   ],
    ///   "GameSecretReferences": [
    ///     {
    ///       "Name": "SecretName"
    ///     }
    ///   ],
    ///   "RoutingSettings": {
    ///     "NumberOfMicrosoftRoutingIPs": 1,
    ///     "NumberOfInternetRoutingIPs": 0,
    ///     "DefaultRoutingType": 0
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createbuildwithcustomcontainer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateBuildWithCustomContainerResponse>> CreateBuildWithCustomContainerAsync(CreateBuildWithCustomContainerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a multiplayer server build with a managed container.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateBuildWithManagedContainerAsync({);
    ///   "StartMultiplayerServerCommand": "gameserver.exe -startserver",
    ///   "GameAssetReferences": [
    ///     {
    ///       "FileName": "gameserver.zip",
    ///       "MountPath": "C:\\Asset\\"
    ///     }
    ///   ],
    ///   "InstrumentationConfiguration": {
    ///     "ProcessesToMonitor": [
    ///       "GameServerProcessName"
    ///     ],
    ///     "IsEnabled": true
    ///   },
    ///   "GameWorkingDirectory": "C:\\Assets",
    ///   "ContainerFlavor": "ManagedWindowsServerCore",
    ///   "ServerResourceConstraints": {
    ///     "CpuLimit": 0.5,
    ///     "MemoryLimitGB": 0.5
    ///   },
    ///   "BuildName": "GameBuildName",
    ///   "Metadata": {
    ///     "MetadataKey": "MetadataValue"
    ///   },
    ///   "VmSize": "Standard_D2_v2",
    ///   "MultiplayerServerCountPerVm": 10,
    ///   "Ports": [
    ///     {
    ///       "Name": "PortName",
    ///       "Num": 1243,
    ///       "Protocol": "TCP"
    ///     }
    ///   ],
    ///   "RegionConfigurations": [
    ///     {
    ///       "Region": "EastUs",
    ///       "MaxServers": 10,
    ///       "StandbyServers": 5,
    ///       "ScheduledStandbySettings": {
    ///         "IsEnabled": true,
    ///         "ScheduleList": [
    ///           {
    ///             "StartTime": "2020-08-21T17:00:00Z",
    ///             "EndTime": "2020-08-24T09:00:00Z",
    ///             "IsRecurringWeekly": true,
    ///             "IsDisabled": false,
    ///             "Description": "Weekend Schedule",
    ///             "TargetStandby": 8
    ///           },
    ///           {
    ///             "StartTime": "2020-08-24T09:00:00Z",
    ///             "EndTime": "2020-08-28T17:00:00Z",
    ///             "IsRecurringWeekly": true,
    ///             "IsDisabled": false,
    ///             "Description": "Weekday Schedule",
    ///             "TargetStandby": 3
    ///           }
    ///         ]
    ///       }
    ///     },
    ///     {
    ///       "Region": "WestUs",
    ///       "MaxServers": 50,
    ///       "StandbyServers": 8,
    ///       "ScheduledStandbySettings": {
    ///         "IsEnabled": true,
    ///         "ScheduleList": [
    ///           {
    ///             "StartTime": "2020-08-21T09:00:00Z",
    ///             "EndTime": "2020-08-21T23:00:00Z",
    ///             "IsRecurringWeekly": false,
    ///             "IsDisabled": false,
    ///             "Description": "Game Launch",
    ///             "TargetStandby": 30
    ///           }
    ///         ]
    ///       }
    ///     },
    ///     {
    ///       "Region": "NorthEurope",
    ///       "MaxServers": 7,
    ///       "StandbyServers": 3
    ///     }
    ///   ],
    ///   "GameCertificateReferences": [
    ///     {
    ///       "Name": "CertName",
    ///       "GsdkAlias": "CertGsdkAlias"
    ///     }
    ///   ],
    ///   "GameSecretReferences": [
    ///     {
    ///       "Name": "SecretName"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createbuildwithmanagedcontainer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateBuildWithManagedContainerResponse>> CreateBuildWithManagedContainerAsync(CreateBuildWithManagedContainerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a multiplayer server build with the server running as a process.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateBuildWithProcessBasedServerAsync({);
    ///   "OsPlatform": "Windows",
    ///   "GameAssetReferences": [
    ///     {
    ///       "FileName": "game.zip"
    ///     }
    ///   ],
    ///   "StartMultiplayerServerCommand": "gameserver.exe -startserver",
    ///   "InstrumentationConfiguration": {
    ///     "ProcessesToMonitor": [
    ///       "GameServerProcessName"
    ///     ],
    ///     "IsEnabled": true
    ///   },
    ///   "GameWorkingDirectory": "C:\\Assets",
    ///   "IsOSPreview": false,
    ///   "VmSize": "Standard_D2_v2",
    ///   "MultiplayerServerCountPerVm": 10,
    ///   "Ports": [
    ///     {
    ///       "Name": "PortName",
    ///       "Num": 1243,
    ///       "Protocol": "TCP"
    ///     }
    ///   ],
    ///   "RegionConfigurations": [
    ///     {
    ///       "Region": "EastUs",
    ///       "MaxServers": 10,
    ///       "StandbyServers": 5
    ///     },
    ///     {
    ///       "Region": "WestUs",
    ///       "MaxServers": 12,
    ///       "StandbyServers": 8
    ///     },
    ///     {
    ///       "Region": "NorthEurope",
    ///       "MaxServers": 7,
    ///       "StandbyServers": 3
    ///     }
    ///   ],
    ///   "GameCertificateReferences": [
    ///     {
    ///       "Name": "CertName",
    ///       "GsdkAlias": "CertGsdkAlias"
    ///     }
    ///   ],
    ///   "GameSecretReferences": [
    ///     {
    ///       "Name": "SecretName"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createbuildwithprocessbasedserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateBuildWithProcessBasedServerResponse>> CreateBuildWithProcessBasedServerAsync(CreateBuildWithProcessBasedServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.CreateLobbyAsync({);
    ///   "MaxPlayers": 50,
    ///   "Owner": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "OwnerMigrationPolicy": "Automatic",
    ///   "UseConnections": true,
    ///   "AccessPolicy": "Public",
    ///   "SearchData": {
    ///     "string_key1": "searchable value"
    ///   },
    ///   "LobbyData": {
    ///     "MyGameKey": "MyGameKey value"
    ///   },
    ///   "Members": [
    ///     {
    ///       "MemberEntity": {
    ///         "Id": "1234",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     }
    ///   ],
    ///   "RestrictInvitesToLobbyOwner": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/createlobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateLobbyResult>> CreateLobbyAsync(CreateLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a matchmaking ticket as a client.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CreateMatchmakingTicketAsync({);
    ///   "Creator": {},
    ///   "MembersToMatchWith": [],
    ///   "GiveUpAfterSeconds": 100,
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/creatematchmakingticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateMatchmakingTicketAsync(CreateMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a remote user to log on to a VM for a multiplayer server build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateRemoteUserAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs",
    ///   "VmId": "VmID1",
    ///   "Username": "AUsername",
    ///   "ExpirationTime": "2014-04-07T09:04:28Z"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createremoteuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateRemoteUserResponse>> CreateRemoteUserAsync(CreateRemoteUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a scenario to specify which conditions, conditions values and events will be allowed when submitting match
    /// results.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.CreateScenarioAsync({);
    ///   "Name": "Test Scenario",
    ///   "Conditions": [
    ///     {
    ///       "Key": "Platform",
    ///       "Values": [
    ///         "PC",
    ///         "Xbox"
    ///       ]
    ///     },
    ///     {
    ///       "Key": "GameMode",
    ///       "Values": [
    ///         "TeamDeathMatch",
    ///         "CaptureTheFlag"
    ///       ]
    ///     }
    ///   ],
    ///   "Events": [
    ///     "Kills",
    ///     "Deaths"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/createscenario">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateScenarioResponse>> CreateScenarioAsync(CreateScenarioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a backfill matchmaking ticket as a server. A backfill ticket represents an ongoing game. The matchmaking service
    /// automatically starts matching the backfill ticket against other matchmaking tickets. Backfill tickets cannot match with
    /// other backfill tickets.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CreateServerBackfillTicketAsync({);
    ///   "Members": [],
    ///   "GiveUpAfterSeconds": 100,
    ///   "ServerDetails": {
    ///     "IPV4Address": "10.250.24.54",
    ///     "Ports": [
    ///       {
    ///         "Name": "PortName",
    ///         "Num": 1243,
    ///         "Protocol": "TCP"
    ///       }
    ///     ],
    ///     "Region": "WestUS",
    ///     "Fqdn": "vm.azure.cloudapp.net",
    ///     "ServerId": "359e4634-7c8f-4d44-87a5-f3a876aac6c0"
    ///   },
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/createserverbackfillticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateServerBackfillTicketResult>> CreateServerBackfillTicketAsync(CreateServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create a matchmaking ticket as a server. The matchmaking service automatically starts matching the ticket against other
    /// matchmaking tickets.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.CreateServerMatchmakingTicketAsync({);
    ///   "Members": [
    ///     null
    ///   ],
    ///   "GiveUpAfterSeconds": 100,
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/createservermatchmakingticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateServerMatchmakingTicketAsync(CreateServerMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a request to change a title's multiplayer server quotas.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.CreateTitleMultiplayerServersQuotaChangeAsync({);
    ///   "ContactEmail": "john@mygamestudio.com",
    ///   "StartDate": "2020-01-23T00:00:00Z",
    ///   "ChangeDescription": "Season 3 Launch",
    ///   "Notes": "Based on the last launch, we expect 1 trillion active users.",
    ///   "Changes": [
    ///     {
    ///       "VmFamily": "Dasv4",
    ///       "Region": "EastUs",
    ///       "NewCoreLimit": 55000
    ///     },
    ///     {
    ///       "VmFamily": "Dasv4",
    ///       "Region": "NorthCentralUs",
    ///       "NewCoreLimit": 65000
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/createtitlemultiplayerserversquotachange">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse>> CreateTitleMultiplayerServersQuotaChangeAsync(CreateTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Switch a model's state from Active to Deactivated.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.DeactivateModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/deactivatemodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeactivateModelResponse>> DeactivateModelAsync(DeactivateModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a multiplayer server game asset for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteAssetAsync({);
    ///   "FileName": "gameserver.zip"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deleteasset">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteAssetAsync(DeleteAssetRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a multiplayer server build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteBuildAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletebuild">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteBuildAsync(DeleteBuildRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a multiplayer server build alias.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteBuildAliasAsync({);
    ///   "AliasId": "21781fa8-096d-4d9c-b699-75433d579285"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletebuildalias">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteBuildAliasAsync(DeleteBuildAliasRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes a multiplayer server build's region.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteBuildRegionAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "JapanEast"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletebuildregion">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteBuildRegionAsync(DeleteBuildRegionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a multiplayer server game certificate.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteCertificateAsync({);
    ///   "Name": "GameCertificate1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletecertificate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteCertificateAsync(DeleteCertificateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a container image repository.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteContainerImageRepositoryAsync({);
    ///   "ImageName": "imageName1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletecontainerimagerepository">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteContainerImageRepositoryAsync(DeleteContainerImageRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.DeleteLobbyAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/deletelobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> DeleteLobbyAsync(DeleteLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a model.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.DeleteModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/deletemodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteModelResponse>> DeleteModelAsync(DeleteModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a remote user to log on to a VM for a multiplayer server build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteRemoteUserAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs",
    ///   "VmId": "VmID1",
    ///   "Username": "AUsername"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deleteremoteuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteRemoteUserAsync(DeleteRemoteUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.DeleteScenarioAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ForceDelete": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/deletescenario">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteScenarioResponse>> DeleteScenarioAsync(DeleteScenarioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a multiplayer server game secret.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.DeleteSecretAsync({);
    ///   "Name": "GameSecret1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/deletesecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteSecretAsync(DeleteSecretRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Enables the multiplayer server feature for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.EnableMultiplayerServersForTitleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/enablemultiplayerserversfortitle">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EnableMultiplayerServersForTitleResponse>> EnableMultiplayerServersForTitleAsync(EnableMultiplayerServersForTitleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Enables the parties feature for a title.
    /// <example><br/>Example:<code>
    /// var response = await partyApi.EnablePartiesForTitleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/party/multiplayerserver/enablepartiesfortitle">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> EnablePartiesForTitleAsync(EnablePartiesForTitleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Find lobbies which match certain criteria, and which friends are in.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.FindFriendLobbiesAsync({);
    ///   "Filter": "string_key1 eq 'Wizard' and number_key5 gt 5",
    ///   "OrderBy": "number_key5 desc",
    ///   "ExternalPlatformFriends": "Xbox",
    ///   "XboxToken": "XBOXTOKEN",
    ///   "Pagination": {
    ///     "ContinuationToken": "",
    ///     "PageSizeRequested": 20
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/findfriendlobbies">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<FindFriendLobbiesResult>> FindFriendLobbiesAsync(FindFriendLobbiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Find all the lobbies that match certain criteria.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.FindLobbiesAsync({);
    ///   "Filter": "string_key1 eq 'Wizard' and number_key5 gt 5",
    ///   "OrderBy": "number_key5 desc",
    ///   "Pagination": {
    ///     "ContinuationToken": "",
    ///     "PageSizeRequested": 20
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/findlobbies">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<FindLobbiesResult>> FindLobbiesAsync(FindLobbiesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a URL that can be used to download the specified asset. A sample pre-authenticated url -
    /// https://sampleStorageAccount.blob.core.windows.net/gameassets/gameserver.zip?sv=2015-04-05&ss=b&srt=sco&sp=rw&st=startDa
    /// te&se=endDate&spr=https&sig=sampleSig&api-version=2017-07-29
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetAssetDownloadUrlAsync({);
    ///   "FileName": "gameserver.zip"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getassetdownloadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAssetDownloadUrlResponse>> GetAssetDownloadUrlAsync(GetAssetDownloadUrlRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the URL to upload assets to. A sample pre-authenticated url -
    /// https://sampleStorageAccount.blob.core.windows.net/gameassets/gameserver.zip?sv=2015-04-05&ss=b&srt=sco&sp=rw&st=startDa
    /// te&se=endDate&spr=https&sig=sampleSig&api-version=2017-07-29
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetAssetUploadUrlAsync({);
    ///   "FileName": "gameserver.zip"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getassetuploadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetAssetUploadUrlResponse>> GetAssetUploadUrlAsync(GetAssetUploadUrlRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a multiplayer server build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetBuildAsync({);
    ///   "BuildId": "53781fa8-006d-4e9c-b733-57433d579285"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getbuild">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetBuildResponse>> GetBuildAsync(GetBuildRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a multiplayer server build alias.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetBuildAliasAsync({);
    ///   "AliasId": "21781fa8-096d-4d9c-b699-75433d579285"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getbuildalias">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BuildAliasDetailsResponse>> GetBuildAliasAsync(GetBuildAliasRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets supported locales for the cognitive services based on the specified service type.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetCognitiveServicesLocalesAsync({);
    ///   "CognitiveServicesType": "SpeechToText",
    ///   "Region": "WestUs"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getcognitiveserviceslocales">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCognitiveServicesLocalesResponse>> GetCognitiveServicesLocalesAsync(GetCognitiveServicesLocalesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a token for the cognitive services based on the specified service type.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetCognitiveServicesTokenAsync({);
    ///   "CognitiveServicesType": "SpeechToText",
    ///   "Region": "AustraliaEast"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getcognitiveservicestoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCognitiveServicesTokenResponse>> GetCognitiveServicesTokenAsync(GetCognitiveServicesTokenRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the credentials to the container registry.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetContainerRegistryCredentialsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getcontainerregistrycredentials">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetContainerRegistryCredentialsResponse>> GetContainerRegistryCredentialsAsync(GetContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.GetLobbyAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/getlobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLobbyResult>> GetLobbyAsync(GetLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a match.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.GetMatchAsync({);
    ///   "MatchId": "4e0c5fd7-80e9-4744-b0ce-061a7f067ff5",
    ///   "QueueName": "custom123",
    ///   "EscapeObject": false,
    ///   "ReturnMemberAttributes": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/getmatch">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMatchResult>> GetMatchAsync(GetMatchRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// SDK support is limited to C# and Java for this API. Get a matchmaking queue configuration.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.GetMatchmakingQueueAsync({);
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking-admin/getmatchmakingqueue">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMatchmakingQueueResult>> GetMatchmakingQueueAsync(GetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a matchmaking ticket by ticket Id.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.GetMatchmakingTicketAsync({);
    ///   "TicketId": "1c4b0daa-150e-47ae-9923-d770c0f9b07c",
    ///   "QueueName": "custom123",
    ///   "EscapeObject": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/getmatchmakingticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMatchmakingTicketResult>> GetMatchmakingTicketAsync(GetMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the details of a Model.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetModelDetailsAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/getmodeldetails">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetModelDetailsResponse>> GetModelDetailsAsync(GetModelDetailsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get all of the models assigned to a specific scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetModelsByScenarioAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/getmodelsbyscenario">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetModelsByScenarioResponse>> GetModelsByScenarioAsync(GetModelsByScenarioRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets multiplayer server session details and associated user connection tokens for a build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetMultiplayerServerAndTokenAsync({);
    ///   "TokenPlayerIds": [
    ///     "User1",
    ///     "User2"
    ///   ],
    ///   "SessionId": "02bdef0e-e01e-4b29-8efe-ff9f47a06d8c"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getmultiplayerserverandtoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMultiplayerServerAndTokenResponse>> GetMultiplayerServerAndTokenAsync(GetMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets multiplayer server session details for a build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetMultiplayerServerDetailsAsync({);
    ///   "SessionId": "02bdef0e-e01e-4b29-8efe-ff9f47a06d8c"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getmultiplayerserverdetails">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMultiplayerServerDetailsResponse>> GetMultiplayerServerDetailsAsync(GetMultiplayerServerDetailsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets multiplayer server logs after a server has terminated.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetMultiplayerServerLogsAsync({);
    ///   "Region": "AustraliaEast",
    ///   "ServerId": "SomeServerId"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getmultiplayerserverlogs">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerServerLogsAsync(GetMultiplayerServerLogsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets multiplayer server logs after a server has terminated.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetMultiplayerSessionLogsBySessionIdAsync({);
    ///   "SessionId": "92e29db9-4004-4349-9a1f-b70ac01bdc08"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getmultiplayersessionlogsbysessionid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerSessionLogsBySessionIdAsync(GetMultiplayerSessionLogsBySessionIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets skill values of a set of players from the primary model of a given scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetPlayerSkillAsync({);
    ///   "Conditions": {
    ///     "Platform": "Xbox",
    ///     "Mode": "Deathmatch"
    ///   },
    ///   "Players": [
    ///     {
    ///       "Entity": {
    ///         "Id": "1234",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     },
    ///     {
    ///       "Entity": {
    ///         "Id": "5678",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       },
    ///       "SquadSize": 2
    ///     }
    ///   ],
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "IncludeSkillBreakdown": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill/getplayerskill">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSkillResponse>> GetPlayerSkillAsync(GetPlayerSkillRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets skill values of a set of players for multiple sets of conditions from the primary model of a given scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetPlayerSkillForConditionsAsync({);
    ///   "Conditions": [
    ///     {
    ///       "Conditions": {
    ///         "Platform": "Xbox",
    ///         "Mode": "Deathmatch"
    ///       }
    ///     },
    ///     {
    ///       "Conditions": {
    ///         "Platform": "Xbox",
    ///         "Mode": "Guardian"
    ///       }
    ///     }
    ///   ],
    ///   "Players": [
    ///     {
    ///       "Entity": {
    ///         "Id": "1234",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     },
    ///     {
    ///       "Entity": {
    ///         "Id": "5678",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       },
    ///       "SquadSize": 2
    ///     }
    ///   ],
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "IncludeSkillBreakdown": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill/getplayerskillforconditions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSkillForConditionsResponse>> GetPlayerSkillForConditionsAsync(GetPlayerSkillForConditionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets skill values of a set of players for multiple sets of conditions from a specific model.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetPlayerSkillForConditionsFromModelAsync({);
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf",
    ///   "Conditions": [
    ///     {
    ///       "Conditions": {
    ///         "Platform": "Xbox",
    ///         "Mode": "Deathmatch"
    ///       }
    ///     },
    ///     {
    ///       "Conditions": {
    ///         "Platform": "Xbox",
    ///         "Mode": "Guardian"
    ///       }
    ///     }
    ///   ],
    ///   "Players": [
    ///     {
    ///       "Entity": {
    ///         "Id": "1234",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     },
    ///     {
    ///       "Entity": {
    ///         "Id": "5678",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       },
    ///       "SquadSize": 2
    ///     }
    ///   ],
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "IncludeSkillBreakdown": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill/getplayerskillforconditionsfrommodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSkillForConditionsFromModelResponse>> GetPlayerSkillForConditionsFromModelAsync(GetPlayerSkillForConditionsFromModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets skill values of a set of players from a specific model.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetPlayerSkillFromModelAsync({);
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf",
    ///   "Conditions": {
    ///     "Platform": "Xbox",
    ///     "Mode": "Deathmatch"
    ///   },
    ///   "Players": [
    ///     {
    ///       "Entity": {
    ///         "Id": "1234",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     },
    ///     {
    ///       "Entity": {
    ///         "Id": "5678",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       },
    ///       "SquadSize": 2
    ///     }
    ///   ],
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "IncludeSkillBreakdown": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill/getplayerskillfrommodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetPlayerSkillFromModelResponse>> GetPlayerSkillFromModelAsync(GetPlayerSkillFromModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get the statistics for a queue.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.GetQueueStatisticsAsync({);
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/getqueuestatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetQueueStatisticsResult>> GetQueueStatisticsAsync(GetQueueStatisticsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a remote login endpoint to a VM that is hosting a multiplayer server build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetRemoteLoginEndpointAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs",
    ///   "VmId": "VmID1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/getremoteloginendpoint">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetRemoteLoginEndpointResponse>> GetRemoteLoginEndpointAsync(GetRemoteLoginEndpointRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a scenario configuration.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.GetScenarioConfigurationAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/getscenarioconfiguration">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetScenarioConfigurationResponse>> GetScenarioConfigurationAsync(GetScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets all scenario configurations that belong to the title.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/getscenarioconfigurations">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetScenarioConfigurationsResponse>> GetScenarioConfigurationsAsync(GetScenarioConfigurationsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a matchmaking backfill ticket by ticket Id.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.GetServerBackfillTicketAsync({);
    ///   "TicketId": "1c4b0daa-150e-47ae-9923-d770c0f9b07c",
    ///   "QueueName": "custom123",
    ///   "EscapeObject": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/getserverbackfillticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetServerBackfillTicketResult>> GetServerBackfillTicketAsync(GetServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the status of whether a title is enabled for the multiplayer server feature.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetTitleEnabledForMultiplayerServersStatusAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/gettitleenabledformultiplayerserversstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse>> GetTitleEnabledForMultiplayerServersStatusAsync(GetTitleEnabledForMultiplayerServersStatusRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets a title's server quota change request.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetTitleMultiplayerServersQuotaChangeAsync({);
    ///   "RequestId": "1234"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/gettitlemultiplayerserversquotachange">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse>> GetTitleMultiplayerServersQuotaChangeAsync(GetTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the quotas for a title in relation to multiplayer servers.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.GetTitleMultiplayerServersQuotasAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/gettitlemultiplayerserversquotas">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTitleMultiplayerServersQuotasResponse>> GetTitleMultiplayerServersQuotasAsync(GetTitleMultiplayerServersQuotasRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Send a notification to invite a player to a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.InviteToLobbyAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC",
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "InviteeEntity": {
    ///     "Id": "4321",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/invitetolobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> InviteToLobbyAsync(InviteToLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Join an Arranged lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.JoinArrangedLobbyAsync({);
    ///   "MaxPlayers": 50,
    ///   "OwnerMigrationPolicy": "Automatic",
    ///   "UseConnections": true,
    ///   "AccessPolicy": "Public",
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "ArrangementString": "arrangementString",
    ///   "MemberData": {
    ///     "MyMemberKey": "MyMemberKey value"
    ///   },
    ///   "RestrictInvitesToLobbyOwner": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/joinarrangedlobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<JoinLobbyResult>> JoinArrangedLobbyAsync(JoinArrangedLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Join a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.JoinLobbyAsync({);
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "ConnectionString": "connString",
    ///   "MemberData": {
    ///     "MyDataKey": "MyDataKey value"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/joinlobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<JoinLobbyResult>> JoinLobbyAsync(JoinLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Preview: Join a lobby as a server entity. This is restricted to client lobbies which are using connections.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.JoinLobbyAsServerAsync({);
    ///   "ServerEntity": {
    ///     "Id": "1234",
    ///     "Type": "game_server",
    ///     "TypeString": "game_server"
    ///   },
    ///   "ConnectionString": "connString",
    ///   "ServerData": {
    ///     "MyDataKey": "MyDataKey value"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/joinlobbyasserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<JoinLobbyAsServerResult>> JoinLobbyAsServerAsync(JoinLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Join a matchmaking ticket.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.JoinMatchmakingTicketAsync({);
    ///   "TicketId": "1c4b0daa-150e-47ae-9923-d770c0f9b07c",
    ///   "QueueName": "custom123",
    ///   "Member": {}
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/joinmatchmakingticket">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<JoinMatchmakingTicketResult>> JoinMatchmakingTicketAsync(JoinMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Leave a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.LeaveLobbyAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC",
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/leavelobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsync(LeaveLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Preview: Request for server to leave a lobby. This is restricted to client owned lobbies which are using connections.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.LeaveLobbyAsServerAsync({);
    ///   "ServerEntity": {
    ///     "Id": "1234",
    ///     "Type": "game_server",
    ///     "TypeString": "game_server"
    ///   },
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/leavelobbyasserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsServerAsync(LeaveLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists archived multiplayer server sessions for a build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListArchivedMultiplayerServersAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listarchivedmultiplayerservers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListMultiplayerServersResponse>> ListArchivedMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists multiplayer server game assets for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListAssetSummariesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listassetsummaries">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListAssetSummariesResponse>> ListAssetSummariesAsync(ListAssetSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists details of all build aliases for a title. Accepts tokens for title and if game client access is enabled, allows
    /// game client to request list of builds with player entity token.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListBuildAliasesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listbuildaliases">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListBuildAliasesResponse>> ListBuildAliasesAsync(ListBuildAliasesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists summarized details of all multiplayer server builds for a title. Accepts tokens for title and if game client
    /// access is enabled, allows game client to request list of builds with player entity token.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListBuildSummariesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listbuildsummaries">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesAsync(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists summarized details of all multiplayer server builds for a title. Accepts tokens for title and if game client
    /// access is enabled, allows game client to request list of builds with player entity token.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListBuildSummariesV2Async({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listbuildsummariesv2">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesV2Async(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists multiplayer server game certificates for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListCertificateSummariesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listcertificatesummaries">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListCertificateSummariesResponse>> ListCertificateSummariesAsync(ListCertificateSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists custom container images for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListContainerImagesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listcontainerimages">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListContainerImagesResponse>> ListContainerImagesAsync(ListContainerImagesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists the tags for a custom container image.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListContainerImageTagsAsync({);
    ///   "ImageName": "imageName1",
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listcontainerimagetags">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListContainerImageTagsResponse>> ListContainerImageTagsAsync(ListContainerImageTagsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// SDK support is limited to C# and Java for this API. List all matchmaking queue configs.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.ListMatchmakingQueuesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking-admin/listmatchmakingqueues">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListMatchmakingQueuesResult>> ListMatchmakingQueuesAsync(ListMatchmakingQueuesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all matchmaking ticket Ids the user is a member of.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.ListMatchmakingTicketsForPlayerAsync({);
    ///   "Entity": {
    ///     "Id": "123123123",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/listmatchmakingticketsforplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListMatchmakingTicketsForPlayerResult>> ListMatchmakingTicketsForPlayerAsync(ListMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists multiplayer server sessions for a build.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListMultiplayerServersAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listmultiplayerservers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListMultiplayerServersResponse>> ListMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists quality of service servers for party.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListPartyQosServersAsync({);
    ///   "Version": "1.0.0"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listpartyqosservers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListPartyQosServersResponse>> ListPartyQosServersAsync(ListPartyQosServersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists quality of service servers.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListQosServersAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listqosservers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListQosServersResponse>> ListQosServersAsync(ListQosServersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists quality of service servers for the title. By default, servers are only returned for regions where a Multiplayer
    /// Servers build has been deployed.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListQosServersForTitleAsync({);
    ///   "IncludeAllRegions": true,
    ///   "RoutingPreference": "Microsoft"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listqosserversfortitle">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListQosServersForTitleResponse>> ListQosServersForTitleAsync(ListQosServersForTitleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists multiplayer server game secrets for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListSecretSummariesAsync({);
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listsecretsummaries">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListSecretSummariesResponse>> ListSecretSummariesAsync(ListSecretSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all server backfill ticket Ids the user is a member of.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.ListServerBackfillTicketsForPlayerAsync({);
    ///   "Entity": {
    ///     "Id": "123123123",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/listserverbackfillticketsforplayer">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListServerBackfillTicketsForPlayerResult>> ListServerBackfillTicketsForPlayerAsync(ListServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List all server quota change requests for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListTitleMultiplayerServersQuotaChangesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listtitlemultiplayerserversquotachanges">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse>> ListTitleMultiplayerServersQuotaChangesAsync(ListTitleMultiplayerServersQuotaChangesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Lists virtual machines for a title.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ListVirtualMachineSummariesAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "Region": "SouthCentralUs",
    ///   "PageSize": 10
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/listvirtualmachinesummaries">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListVirtualMachineSummariesResponse>> ListVirtualMachineSummariesAsync(ListVirtualMachineSummariesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// SDK support is limited to C# and Java for this API. Remove a matchmaking queue config.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.RemoveMatchmakingQueueAsync({);
    ///   "QueueName": "custom123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking-admin/removematchmakingqueue">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RemoveMatchmakingQueueResult>> RemoveMatchmakingQueueAsync(RemoveMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Remove a member from a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.RemoveMemberAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC",
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "PreventRejoin": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/removemember">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> RemoveMemberAsync(RemoveMemberFromLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Request a multiplayer server session. Accepts tokens for title and if game client access is enabled, allows game client
    /// to request a server with player entity token.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.RequestMultiplayerServerAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "SessionId": "02bdef0e-e01e-4b29-8efe-ff9f47a06d8c",
    ///   "SessionCookie": "U2Vzc2lvbkNvb2tpZQ==",
    ///   "InitialPlayers": [
    ///     "gamer1",
    ///     "gamer2"
    ///   ],
    ///   "PreferredRegions": [
    ///     "SouthCentralUs",
    ///     "WestUs"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/requestmultiplayerserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RequestMultiplayerServerResponse>> RequestMultiplayerServerAsync(RequestMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Request a multiplayer server session and associated user connection tokens. Accepts tokens for title and if game client
    /// access is enabled, allows game client to request a server with player entity token.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.RequestMultiplayerServerAndTokenAsync({);
    ///   "TokenPlayerIds": [
    ///     "gamer1",
    ///     "gamer2"
    ///   ],
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "SessionId": "02bdef0e-e01e-4b29-8efe-ff9f47a06d8c",
    ///   "SessionCookie": "U2Vzc2lvbkNvb2tpZQ==",
    ///   "InitialPlayers": [
    ///     "gamer1",
    ///     "gamer2"
    ///   ],
    ///   "PreferredRegions": [
    ///     "SouthCentralUs",
    ///     "WestUs"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/requestmultiplayerserverandtoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RequestMultiplayerServerAndTokenResponse>> RequestMultiplayerServerAndTokenAsync(RequestMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Request a party session.
    /// <example><br/>Example:<code>
    /// var response = await partyApi.RequestPartyAsync({);
    ///   "PartyId": "23781fa9-e01e-4b29-4f0b-dd9f37a06a1e",
    ///   "PreferredRegions": [
    ///     "EastUs",
    ///     "WestUs"
    ///   ],
    ///   "SessionCookie": "FooBarCookie",
    ///   "Version": "0.1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/party/multiplayerserver/requestparty">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RequestPartyResponse>> RequestPartyAsync(RequestPartyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Request a party session.
    /// <example><br/>Example:<code>
    /// var response = await partyApi.RequestPartyServiceAsync({);
    ///   "TitleId": "12345",
    ///   "PartyId": "23781fa9-e01e-4b29-4f0b-dd9f37a06a1e",
    ///   "PreferredRegions": [
    ///     "EastUs",
    ///     "WestUs"
    ///   ],
    ///   "NetworkConfiguration": {
    ///     "MaxUsers": 1024,
    ///     "MaxDevices": 128,
    ///     "MaxUsersPerDevice": 8,
    ///     "MaxDevicesPerUser": 128,
    ///     "MaxEndpointsPerDevice": 32,
    ///     "DirectPeerConnectivityOptions": "None",
    ///     "PartyInvitationConfiguration": {
    ///       "Identifier": "f8b73a15-6ec2-48f8-b5fb-6c5946dc10be",
    ///       "Revocability": "Anyone",
    ///       "EntityKeys": []
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/party/multiplayerserver/requestpartyservice">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RequestPartyServiceResponse>> RequestPartyServiceAsync(RequestPartyServiceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Rolls over the credentials to the container registry.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.RolloverContainerRegistryCredentialsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/rollovercontainerregistrycredentials">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RolloverContainerRegistryCredentialsResponse>> RolloverContainerRegistryCredentialsAsync(RolloverContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// SDK support is limited to C# and Java for this API. Create or update a matchmaking queue configuration.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.SetMatchmakingQueueAsync({);
    ///   "MatchmakingQueue": {
    ///     "Name": "ExampleQueueName",
    ///     "MinMatchSize": 7,
    ///     "MaxMatchSize": 8,
    ///     "MaxTicketSize": 2,
    ///     "ServerAllocationEnabled": true,
    ///     "BuildId": "065a3208-39af-4691-8794-5f774c367ac2",
    ///     "DifferenceRules": [
    ///       {
    ///         "Difference": 10.0,
    ///         "MergeFunction": "Average",
    ///         "DefaultAttributeValue": 0.0,
    ///         "LinearExpansion": {
    ///           "Delta": 0.5,
    ///           "Limit": 20.0,
    ///           "SecondsBetweenExpansions": 5
    ///         },
    ///         "Attribute": {
    ///           "Path": "ExampleAttributeDifference",
    ///           "Source": "User"
    ///         },
    ///         "AttributeNotSpecifiedBehavior": "UseDefault",
    ///         "Weight": 1.0,
    ///         "Name": "ExampleNameDifference",
    ///         "SecondsUntilOptional": 50
    ///       }
    ///     ],
    ///     "StringEqualityRules": [
    ///       {
    ///         "DefaultAttributeValue": "ExampleDefault",
    ///         "Expansion": {
    ///           "EnabledOverrides": [
    ///             false,
    ///             true,
    ///             true,
    ///             false
    ///           ],
    ///           "SecondsBetweenExpansions": 5
    ///         },
    ///         "Attribute": {
    ///           "Path": "ExampleAttributeStringEquality",
    ///           "Source": "User"
    ///         },
    ///         "AttributeNotSpecifiedBehavior": "UseDefault",
    ///         "Weight": 1.0,
    ///         "Name": "ExampleNameStringEquality",
    ///         "SecondsUntilOptional": 50
    ///       }
    ///     ],
    ///     "MatchTotalRules": [
    ///       {
    ///         "Attribute": {
    ///           "Path": "ExampleAttribute",
    ///           "Source": "User"
    ///         },
    ///         "Min": 2.0,
    ///         "Max": 0.0,
    ///         "Weight": 1.0,
    ///         "Expansion": {
    ///           "MaxOverrides": [
    ///             {
    ///               "Value": 4.0
    ///             },
    ///             {
    ///               "Value": 4.0
    ///             },
    ///             null
    ///           ],
    ///           "SecondsBetweenExpansions": 5
    ///         },
    ///         "Name": "MatchTotalRule",
    ///         "SecondsUntilOptional": 50
    ///       }
    ///     ],
    ///     "SetIntersectionRules": [
    ///       {
    ///         "DefaultAttributeValue": [
    ///           "a",
    ///           "b",
    ///           "c"
    ///         ],
    ///         "MinIntersectionSize": 2,
    ///         "LinearExpansion": {
    ///           "Delta": 2,
    ///           "SecondsBetweenExpansions": 5
    ///         },
    ///         "Attribute": {
    ///           "Path": "ExampleAttributeSetIntersectionRule",
    ///           "Source": "User"
    ///         },
    ///         "AttributeNotSpecifiedBehavior": "UseDefault",
    ///         "Weight": 1.0,
    ///         "Name": "ExampleNameSetIntersectionRule",
    ///         "SecondsUntilOptional": 50
    ///       }
    ///     ],
    ///     "RegionSelectionRule": {
    ///       "MaxLatency": 250,
    ///       "Path": "Latencies",
    ///       "LinearExpansion": {
    ///         "Delta": 10,
    ///         "Limit": 300,
    ///         "SecondsBetweenExpansions": 5
    ///       },
    ///       "Weight": 1.0,
    ///       "Name": "RegionSelectionRule",
    ///       "SecondsUntilOptional": 50
    ///     },
    ///     "TeamSizeBalanceRule": {
    ///       "Difference": 1,
    ///       "LinearExpansion": {
    ///         "Delta": 1,
    ///         "Limit": 5,
    ///         "SecondsBetweenExpansions": 5
    ///       },
    ///       "Name": "TeamSizeBalanceRule",
    ///       "SecondsUntilOptional": 50
    ///     },
    ///     "TeamDifferenceRules": [
    ///       {
    ///         "Attribute": {
    ///           "Path": "ExampleAttribute",
    ///           "Source": "User"
    ///         },
    ///         "Difference": 2.0,
    ///         "DefaultAttributeValue": 0.0,
    ///         "LinearExpansion": {
    ///           "Delta": 1.0,
    ///           "Limit": 5.0,
    ///           "SecondsBetweenExpansions": 5
    ///         },
    ///         "Name": "TeamDifferenceRule",
    ///         "SecondsUntilOptional": 50
    ///       }
    ///     ],
    ///     "TeamTicketSizeSimilarityRule": {
    ///       "Name": "TeamTicketSizeSimilarityRule",
    ///       "SecondsUntilOptional": 180
    ///     },
    ///     "Teams": [
    ///       {
    ///         "Name": "monster",
    ///         "MinTeamSize": 1,
    ///         "MaxTeamSize": 1
    ///       },
    ///       {
    ///         "Name": "hunters",
    ///         "MinTeamSize": 4,
    ///         "MaxTeamSize": 8
    ///       }
    ///     ],
    ///     "StatisticsVisibilityToPlayers": {
    ///       "ShowNumberOfPlayersMatching": true,
    ///       "ShowTimeToMatch": true
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking-admin/setmatchmakingqueue">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetMatchmakingQueueResult>> SetMatchmakingQueueAsync(SetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Shuts down a multiplayer server session.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.ShutdownMultiplayerServerAsync({);
    ///   "Region": "AustraliaEast",
    ///   "SessionId": "02bdef0e-e01e-4b29-8efe-ff9f47a06d8c"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/shutdownmultiplayerserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> ShutdownMultiplayerServerAsync(ShutdownMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Subscribe to lobby resource notifications.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.SubscribeToLobbyResourceAsync({);
    ///   "Type": "LobbyChange",
    ///   "ResourceId": "5c905725-0184-4112-a563-2f4187710d06",
    ///   "SubscriptionVersion": 1,
    ///   "PubSubConnectionHandle": "PubSubConnection",
    ///   "EntityKey": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/subscribetolobbyresource">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SubscribeToLobbyResourceResult>> SubscribeToLobbyResourceAsync(SubscribeToLobbyResourceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Subscribe to match resource notifications.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.SubscribeToMatchmakingResourceAsync({);
    ///   "Type": "MatchTicketStatusChange",
    ///   "ResourceId": "5a58afee-a9d7-4a47-875b-48bae4dc0590",
    ///   "SubscriptionVersion": 1,
    ///   "PubSubConnectionHandle": "PubSubConnection",
    ///   "EntityKey": {}
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/subscribetomatchmakingresource">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SubscribeToMatchResourceResult>> SubscribeToMatchmakingResourceAsync(SubscribeToMatchResourceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unsubscribe from lobby notifications.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.UnsubscribeFromLobbyResourceAsync({);
    ///   "Type": "LobbyChange",
    ///   "ResourceId": "5c905725-0184-4112-a563-2f4187710d06",
    ///   "SubscriptionVersion": 1,
    ///   "PubSubConnectionHandle": "PubSubConnection",
    ///   "EntityKey": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/unsubscribefromlobbyresource">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> UnsubscribeFromLobbyResourceAsync(UnsubscribeFromLobbyResourceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Unsubscribe from match resource notifications.
    /// <example><br/>Example:<code>
    /// var response = await matchApi.UnsubscribeFromMatchmakingResourceAsync({);
    ///   "Type": "MatchTicketStatusChange",
    ///   "ResourceId": "5a58afee-a9d7-4a47-875b-48bae4dc0590",
    ///   "SubscriptionVersion": 1,
    ///   "PubSubConnectionHandle": "PubSubConnection",
    ///   "EntityKey": {}
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/match/matchmaking/unsubscribefrommatchmakingresource">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UnsubscribeFromMatchResourceResult>> UnsubscribeFromMatchmakingResourceAsync(UnsubscribeFromMatchResourceRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Untags a container image.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UntagContainerImageAsync({);
    ///   "ImageName": "imageName1",
    ///   "Tag": "tag1"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/untagcontainerimage">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UntagContainerImageAsync(UntagContainerImageRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a multiplayer server build alias.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UpdateBuildAliasAsync({);
    ///   "AliasName": "AliasName",
    ///   "BuildSelectionCriteria": [
    ///     {
    ///       "BuildWeightDistribution": {
    ///         "53781fa8-006d-4e9c-b733-57433d579285": 1
    ///       }
    ///     }
    ///   ],
    ///   "AliasId": "21781fa8-096d-4d9c-b699-75433d579285"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/updatebuildalias">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<BuildAliasDetailsResponse>> UpdateBuildAliasAsync(UpdateBuildAliasRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates a multiplayer server build's name.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UpdateBuildNameAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "BuildName": "GameBuildName"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/updatebuildname">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateBuildNameAsync(UpdateBuildNameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates a multiplayer server build's region. If the region is not yet created, it will be created
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UpdateBuildRegionAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "BuildRegion": {
    ///     "Region": "NorthEurope",
    ///     "MaxServers": 7,
    ///     "StandbyServers": 3
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/updatebuildregion">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionAsync(UpdateBuildRegionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates a multiplayer server build's regions.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UpdateBuildRegionsAsync({);
    ///   "BuildId": "21781fa8-096d-4d9c-b699-75433d579285",
    ///   "BuildRegions": [
    ///     {
    ///       "Region": "EastUs",
    ///       "MaxServers": 10,
    ///       "StandbyServers": 5
    ///     },
    ///     {
    ///       "Region": "WestUs",
    ///       "MaxServers": 12,
    ///       "StandbyServers": 8
    ///     },
    ///     {
    ///       "Region": "NorthEurope",
    ///       "MaxServers": 7,
    ///       "StandbyServers": 3
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/updatebuildregions">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionsAsync(UpdateBuildRegionsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update a lobby.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.UpdateLobbyAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC",
    ///   "MaxPlayers": 50,
    ///   "AccessPolicy": "Friends",
    ///   "MembershipLock": "Locked",
    ///   "SearchData": {
    ///     "string_key1": "searchable value"
    ///   },
    ///   "LobbyData": {
    ///     "MyGameKey": "MyGameKey value"
    ///   },
    ///   "MemberEntity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "MemberData": {
    ///     "MyDataKey": "MyDataKey updated value"
    ///   },
    ///   "SearchDataToDelete": [
    ///     "number_key1"
    ///   ],
    ///   "LobbyDataToDelete": [
    ///     "MyOldGameKey"
    ///   ],
    ///   "MemberDataToDelete": []
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/updatelobby">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsync(UpdateLobbyRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Preview: Update fields related to a joined server in the lobby the server is in. Servers can keep a lobby from expiring
    /// by being the one to "update" the lobby in some way. Servers have no impact on last member leave/last member disconnect
    /// behavior.
    /// <example><br/>Example:<code>
    /// var response = await lobbyApi.UpdateLobbyAsServerAsync({);
    ///   "LobbyId": "12345678-1234-1234-1234-123456789ABC",
    ///   "ServerEntity": {
    ///     "Id": "1234",
    ///     "Type": "game_server",
    ///     "TypeString": "game_server"
    ///   },
    ///   "ServerData": {
    ///     "MyDataKey": "MyDataKey value"
    ///   },
    ///   "ServerDataToDelete": [
    ///     "MyOldGameKey"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/lobby/lobby/updatelobbyasserver">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsServerAsync(UpdateLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update a model.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.UpdateModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf",
    ///   "ModelName": "New Model Name",
    ///   "AnomalousMatchResultIgnoreThreshold": -21.0
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/updatemodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateModelResponse>> UpdateModelAsync(UpdateModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Mark a model as primary for a scenario.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.UpdatePrimaryModelAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ModelId": "73a2506e-9fd3-4d84-8dd7-570c8e9e02cf"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/updateprimarymodel">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdatePrimaryModelResponse>> UpdatePrimaryModelAsync(UpdatePrimaryModelRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update a scenario configuration.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.UpdateScenarioConfigurationAsync({);
    ///   "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///   "ConditionsToUpdateOrAdd": [
    ///     {
    ///       "Key": "InputDevice",
    ///       "Values": [
    ///         "MouseAndKeyboard",
    ///         "Controller"
    ///       ]
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill-admin/updatescenarioconfiguration">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateScenarioConfigurationResponse>> UpdateScenarioConfigurationAsync(UpdateScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Uploads a multiplayer server game certificate.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UploadCertificateAsync({);
    ///   "GameCertificate": {
    ///     "Name": "GameCertificate1",
    ///     "Base64EncodedValue": "UGxheUZhYlJvY2tzISEhTGV0J3NtYWtlYWxvdG9mZ2FtZXMh",
    ///     "Password": "PasswordForPFXCertificate"
    ///   },
    ///   "ForceUpdate": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/uploadcertificate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UploadCertificateAsync(UploadCertificateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Uploads a match result.
    /// <example><br/>Example:<code>
    /// var response = await trueskillApi.UploadMatchResultAsync({);
    ///   "MatchResult": {
    ///     "ScenarioId": "f9f0331e-0149-42ba-a994-29b18cac4e4d",
    ///     "Teams": [
    ///       {
    ///         "Players": [
    ///           {
    ///             "Entity": {
    ///               "Id": "5678",
    ///               "Type": "title_player_account",
    ///               "TypeString": "title_player_account"
    ///             },
    ///             "PreMatchPartyId": "630a6523-8853-4cf6-9fda-c7da84f3d87a",
    ///             "SecondsPlayed": 1800,
    ///             "CompletionStatus": "Completed",
    ///             "Conditions": {
    ///               "Platform": "PC",
    ///               "Mode": "Deathmatch"
    ///             },
    ///             "EventCounts": {
    ///               "Kills": 35,
    ///               "Deaths": 5
    ///             }
    ///           },
    ///           {
    ///             "Entity": {
    ///               "Id": "8765",
    ///               "Type": "title_player_account",
    ///               "TypeString": "title_player_account"
    ///             },
    ///             "PreMatchPartyId": "630a6523-8853-4cf6-9fda-c7da84f3d87a",
    ///             "SecondsPlayed": 1800,
    ///             "CompletionStatus": "Completed",
    ///             "Conditions": {
    ///               "Platform": "Xbox",
    ///               "Mode": "Deathmatch"
    ///             },
    ///             "EventCounts": {
    ///               "Kills": 15,
    ///               "Deaths": 10
    ///             }
    ///           }
    ///         ],
    ///         "Rank": 0
    ///       },
    ///       {
    ///         "Players": [
    ///           {
    ///             "SecondsPlayed": 1800,
    ///             "BotId": 77,
    ///             "CompletionStatus": "Completed",
    ///             "Conditions": {
    ///               "Platform": "Xbox",
    ///               "Mode": "Deathmatch"
    ///             },
    ///             "EventCounts": {
    ///               "Kills": 10,
    ///               "Deaths": 15
    ///             }
    ///           },
    ///           {
    ///             "Entity": {
    ///               "Id": "0371",
    ///               "Type": "title_player_account",
    ///               "TypeString": "title_player_account"
    ///             },
    ///             "SecondsPlayed": 900,
    ///             "CompletionStatus": "Disconnected",
    ///             "Conditions": {
    ///               "Platform": "PlayStation",
    ///               "Mode": "Deathmatch"
    ///             },
    ///             "EventCounts": {
    ///               "Kills": 2,
    ///               "Deaths": 20
    ///             }
    ///           },
    ///           {
    ///             "Entity": {
    ///               "Id": "9731",
    ///               "Type": "title_player_account",
    ///               "TypeString": "title_player_account"
    ///             },
    ///             "SecondsPlayed": 900,
    ///             "CompletionStatus": "Completed",
    ///             "Conditions": {
    ///               "Platform": "PlayStation",
    ///               "Mode": "Deathmatch"
    ///             },
    ///             "EventCounts": {
    ///               "Kills": 3,
    ///               "Deaths": 15
    ///             }
    ///           }
    ///         ],
    ///         "Rank": 1
    ///       }
    ///     ],
    ///     "StartDateTimeUtc": "2025-06-20T13:31:18.556Z",
    ///     "EndDateTimeUtc": "2025-06-20T14:01:18.556Z"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/trueskill/trueskill/uploadmatchresult">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UploadMatchResultResponse>> UploadMatchResultAsync(UploadMatchResultRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Uploads a multiplayer server game secret.
    /// <example><br/>Example:<code>
    /// var response = await multiplayerserverApi.UploadSecretAsync({);
    ///   "GameSecret": {
    ///     "Name": "GameSecret1",
    ///     "Value": "Value123",
    ///     "ExpirationDate": "2025-09-01T00:00:00Z"
    ///   },
    ///   "ForceUpdate": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/multiplayerserver/multiplayerserver/uploadsecret">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UploadSecretAsync(UploadSecretRequest request, Dictionary<string, string>? extraHeaders);
}