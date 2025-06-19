namespace CommunityFabs.NET.Sdk.Models.Multiplayer;

public enum AccessPolicy {
    Public,
    Friends,
    Private,
}

public class AssetReference {
    public string? FileName { get; set; }
    public string? MountPath { get; set; }
}

public class AssetReferenceParams {
    public required string FileName { get; set; }
    public string? MountPath { get; set; }
}

public class AssetSummary {
    public string? FileName { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
}

public enum AttributeMergeFunction {
    Min,
    Max,
    Average,
}

public enum AttributeNotSpecifiedBehavior {
    UseDefault,
    MatchAny,
}

public enum AttributeSource {
    User,
    PlayerEntity,
}

public enum AzureRegion {
    AustraliaEast,
    AustraliaSoutheast,
    BrazilSouth,
    CentralUs,
    EastAsia,
    EastUs,
    EastUs2,
    JapanEast,
    JapanWest,
    NorthCentralUs,
    NorthEurope,
    SouthCentralUs,
    SoutheastAsia,
    WestEurope,
    WestUs,
    SouthAfricaNorth,
    WestCentralUs,
    KoreaCentral,
    FranceCentral,
    WestUs2,
    CentralIndia,
    UaeNorth,
    UkSouth,
    SwedenCentral,
    CanadaCentral,
    MexicoCentral,
}

public enum AzureVmFamily {
    A,
    Av2,
    Dv2,
    Dv3,
    F,
    Fsv2,
    Dasv4,
    Dav4,
    Dadsv5,
    Eav4,
    Easv4,
    Ev4,
    Esv4,
    Dsv3,
    Dsv2,
    NCasT4_v3,
    Ddv4,
    Ddsv4,
    HBv3,
    Ddv5,
    Ddsv5,
}

public enum AzureVmSize {
    Standard_A1,
    Standard_A2,
    Standard_A3,
    Standard_A4,
    Standard_A1_v2,
    Standard_A2_v2,
    Standard_A4_v2,
    Standard_A8_v2,
    Standard_D1_v2,
    Standard_D2_v2,
    Standard_D3_v2,
    Standard_D4_v2,
    Standard_D5_v2,
    Standard_D2_v3,
    Standard_D4_v3,
    Standard_D8_v3,
    Standard_D16_v3,
    Standard_F1,
    Standard_F2,
    Standard_F4,
    Standard_F8,
    Standard_F16,
    Standard_F2s_v2,
    Standard_F4s_v2,
    Standard_F8s_v2,
    Standard_F16s_v2,
    Standard_D2as_v4,
    Standard_D4as_v4,
    Standard_D8as_v4,
    Standard_D16as_v4,
    Standard_D2a_v4,
    Standard_D4a_v4,
    Standard_D8a_v4,
    Standard_D16a_v4,
    Standard_D2ads_v5,
    Standard_D4ads_v5,
    Standard_D8ads_v5,
    Standard_D16ads_v5,
    Standard_E2a_v4,
    Standard_E4a_v4,
    Standard_E8a_v4,
    Standard_E16a_v4,
    Standard_E2as_v4,
    Standard_E4as_v4,
    Standard_E8as_v4,
    Standard_E16as_v4,
    Standard_D2s_v3,
    Standard_D4s_v3,
    Standard_D8s_v3,
    Standard_D16s_v3,
    Standard_DS1_v2,
    Standard_DS2_v2,
    Standard_DS3_v2,
    Standard_DS4_v2,
    Standard_DS5_v2,
    Standard_NC4as_T4_v3,
    Standard_D2d_v4,
    Standard_D4d_v4,
    Standard_D8d_v4,
    Standard_D16d_v4,
    Standard_D2ds_v4,
    Standard_D4ds_v4,
    Standard_D8ds_v4,
    Standard_D16ds_v4,
    Standard_HB120_16rs_v3,
    Standard_HB120_32rs_v3,
    Standard_HB120_64rs_v3,
    Standard_HB120_96rs_v3,
    Standard_HB120rs_v3,
    Standard_D2d_v5,
    Standard_D4d_v5,
    Standard_D8d_v5,
    Standard_D16d_v5,
    Standard_D32d_v5,
    Standard_D2ds_v5,
    Standard_D4ds_v5,
    Standard_D8ds_v5,
    Standard_D16ds_v5,
    Standard_D32ds_v5,
}

public class BatchParameters {
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    public required DateTime MatchResultEndDateTime { get; set; }
    public required DateTime MatchResultStartDateTime { get; set; }
    public int MaxIterations { get; set; }
    public string? ParentModelId { get; set; }
}

public class BatchResults {
    public Dictionary<string, double>? LearningActivity { get; set; }
    public int MatchResultsIgnoredCount { get; set; }
    public int MatchResultsUsedCount { get; set; }
    public int RunTimeInSeconds { get; set; }
}

public class BuildAliasDetailsResponse : PlayFabResultCommon {
    public string? AliasId { get; set; }
    public string? AliasName { get; set; }
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class BuildAliasParams {
    public required string AliasId { get; set; }
}

public class BuildRegion {
    public CurrentServerStats? CurrentServerStats { get; set; }
    public DynamicStandbySettings? DynamicStandbySettings { get; set; }
    public bool IsAssetReplicationComplete { get; set; }
    public int MaxServers { get; set; }
    public int? MultiplayerServerCountPerVm { get; set; }
    public string? Region { get; set; }
    public ScheduledStandbySettings? ScheduledStandbySettings { get; set; }
    public int StandbyServers { get; set; }
    public string? Status { get; set; }
    public AzureVmSize? VmSize { get; set; }
}

public class BuildRegionParams {
    public DynamicStandbySettings? DynamicStandbySettings { get; set; }
    public int MaxServers { get; set; }
    public int? MultiplayerServerCountPerVm { get; set; }
    public required string Region { get; set; }
    public ScheduledStandbySettings? ScheduledStandbySettings { get; set; }
    public int StandbyServers { get; set; }
    public AzureVmSize? VmSize { get; set; }
}

public class BuildSelectionCriterion {
    public Dictionary<string, UInt32>? BuildWeightDistribution { get; set; }
}

public class BuildSummary {
    public string? BuildId { get; set; }
    public string? BuildName { get; set; }
    public DateTime? CreationTime { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public List<BuildRegion>? RegionConfigurations { get; set; }
}

/// <summary>
/// Cancels all tickets of which the player is a member in a given queue that are not cancelled or matched. This API is useful if you lose track of what tickets the player is a member of (if the title crashes for instance) and want to "reset". The Entity field is optional if the caller is a player and defaults to that player. Players may not cancel tickets for other people. The Entity field is required if the caller is a server (authenticated as the title).
/// </summary>
public class CancelAllMatchmakingTicketsForPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string QueueName { get; set; }
}

public class CancelAllMatchmakingTicketsForPlayerResult : PlayFabResultCommon {
}

/// <summary>
/// Cancels all backfill tickets of which the player is a member in a given queue that are not cancelled or matched. This API is useful if you lose track of what tickets the player is a member of (if the server crashes for instance) and want to "reset".
/// </summary>
public class CancelAllServerBackfillTicketsForPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required string QueueName { get; set; }
}

public class CancelAllServerBackfillTicketsForPlayerResult : PlayFabResultCommon {
}

public enum CancellationReason {
    Requested,
    Internal,
    Timeout,
}

/// <summary>
/// Only servers and ticket members can cancel a ticket. The ticket can be in five different states when it is cancelled. 1: the ticket is waiting for members to join it, and it has not started matching. If the ticket is cancelled at this stage, it will never match. 2: the ticket is matching. If the ticket is cancelled, it will stop matching. 3: the ticket is matched. A matched ticket cannot be cancelled. 4: the ticket is already cancelled and nothing happens. 5: the ticket is waiting for a server. If the ticket is cancelled, server allocation will be stopped. A server may still be allocated due to a race condition, but that will not be reflected in the ticket. There may be race conditions between the ticket getting matched and the client making a cancellation request. The client must handle the possibility that the cancel request fails if a match is found before the cancellation request is processed. We do not allow resubmitting a cancelled ticket because players must consent to enter matchmaking again. Create a new ticket instead.
/// </summary>
public class CancelMatchmakingTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string QueueName { get; set; }
    public required string TicketId { get; set; }
}

public class CancelMatchmakingTicketResult : PlayFabResultCommon {
}

/// <summary>
/// Request to cancel the creation of a batch model. A Title can make this request.
/// </summary>
public class CancelModelRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public required string ScenarioId { get; set; }
}

public class CancelModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Only servers can cancel a backfill ticket. The ticket can be in three different states when it is cancelled. 1: the ticket is matching. If the ticket is cancelled, it will stop matching. 2: the ticket is matched. A matched ticket cannot be cancelled. 3: the ticket is already cancelled and nothing happens. There may be race conditions between the ticket getting matched and the server making a cancellation request. The server must handle the possibility that the cancel request fails if a match is found before the cancellation request is processed. We do not allow resubmitting a cancelled ticket. Create a new ticket instead.
/// </summary>
public class CancelServerBackfillTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string QueueName { get; set; }
    public required string TicketId { get; set; }
}

public class CancelServerBackfillTicketResult : PlayFabResultCommon {
}

public class Certificate {
    public required string Base64EncodedValue { get; set; }
    public required string Name { get; set; }
    public string? Password { get; set; }
}

public class CertificateSummary {
    public string? Name { get; set; }
    public string? Thumbprint { get; set; }
}

public class CognitiveServicesLocale {
    public string? Gender { get; set; }
    public string? Locale { get; set; }
    public string? Name { get; set; }
    public string? ShortName { get; set; }
}

public enum CognitiveServicesType {
    SpeechToText,
    SpeechToTextTranslation,
    TextToSpeech,
    TextToText,
}

public class ConditionsSet {
    public Dictionary<string, string>? Conditions { get; set; }
}

public class ConnectedPlayer {
    public string? PlayerId { get; set; }
}

public enum ContainerFlavor {
    ManagedWindowsServerCore,
    CustomLinux,
    ManagedWindowsServerCorePreview,
    Invalid,
}

public class ContainerImageReference {
    public required string ImageName { get; set; }
    public string? Tag { get; set; }
}

public class CoreCapacity {
    public int Available { get; set; }
    public string? Region { get; set; }
    public int Total { get; set; }
    public AzureVmFamily? VmFamily { get; set; }
}

public class CoreCapacityChange {
    public int NewCoreLimit { get; set; }
    public required string Region { get; set; }
    public AzureVmFamily VmFamily { get; set; }
}

/// <summary>
/// Request to create a base model. A Title can make this request.
/// </summary>
public class CreateBaseModelRequest : PlayFabRequestCommon {
    public List<ModelCondition>? Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelName { get; set; }
    public required string ScenarioId { get; set; }
}

public class CreateBaseModelResponse : PlayFabResultCommon {
    public string? ModelId { get; set; }
}

/// <summary>
/// Request to create a model for a scenario. This also begins a batch run over a set of MatchResults to create the model. A Title can make this request.
/// </summary>
public class CreateBatchModelRequest : PlayFabRequestCommon {
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    public List<ModelCondition>? Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? Events { get; set; }
    public string? InitialSettingsModelId { get; set; }
    public required DateTime MatchResultEndTimeUtc { get; set; }
    public required DateTime MatchResultStartTimeUtc { get; set; }
    public int MaxIterations { get; set; }
    public required string ModelName { get; set; }
    public required string ScenarioId { get; set; }
}

public class CreateBatchModelResponse : PlayFabResultCommon {
    public string? ModelId { get; set; }
}

/// <summary>
/// Creates a multiplayer server build alias and returns the created alias.
/// </summary>
public class CreateBuildAliasRequest : PlayFabRequestCommon {
    public required string AliasName { get; set; }
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with a custom container and returns information about the build creation request.
/// </summary>
public class CreateBuildWithCustomContainerRequest : PlayFabRequestCommon {
    public bool? AreAssetsReadonly { get; set; }
    public required string BuildName { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public ContainerImageReference? ContainerImageReference { get; set; }
    public string? ContainerRepositoryName { get; set; }
    public string? ContainerRunCommand { get; set; }
    public string? ContainerTag { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<AssetReferenceParams>? GameAssetReferences { get; set; }
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public required List<Port> Ports { get; set; }
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
}

public class CreateBuildWithCustomContainerResponse : PlayFabResultCommon {
    public bool? AreAssetsReadonly { get; set; }
    public string? BuildId { get; set; }
    public string? BuildName { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public string? ContainerRunCommand { get; set; }
    public DateTime? CreationTime { get; set; }
    public ContainerImageReference? CustomGameContainerImage { get; set; }
    public List<AssetReference>? GameAssetReferences { get; set; }
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public string? OsPlatform { get; set; }
    public List<Port>? Ports { get; set; }
    public List<BuildRegion>? RegionConfigurations { get; set; }
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    public string? ServerType { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with a managed container and returns information about the build creation request.
/// </summary>
public class CreateBuildWithManagedContainerRequest : PlayFabRequestCommon {
    public bool? AreAssetsReadonly { get; set; }
    public required string BuildName { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<AssetReferenceParams> GameAssetReferences { get; set; }
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    public string? GameWorkingDirectory { get; set; }
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public required List<Port> Ports { get; set; }
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    public required string StartMultiplayerServerCommand { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
    public WindowsCrashDumpConfiguration? WindowsCrashDumpConfiguration { get; set; }
}

public class CreateBuildWithManagedContainerResponse : PlayFabResultCommon {
    public bool? AreAssetsReadonly { get; set; }
    public string? BuildId { get; set; }
    public string? BuildName { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public DateTime? CreationTime { get; set; }
    public List<AssetReference>? GameAssetReferences { get; set; }
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    public string? GameWorkingDirectory { get; set; }
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public string? OsPlatform { get; set; }
    public List<Port>? Ports { get; set; }
    public List<BuildRegion>? RegionConfigurations { get; set; }
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    public string? ServerType { get; set; }
    public string? StartMultiplayerServerCommand { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with the game server running as a process and returns information about the build creation request.
/// </summary>
public class CreateBuildWithProcessBasedServerRequest : PlayFabRequestCommon {
    public bool? AreAssetsReadonly { get; set; }
    public required string BuildName { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<AssetReferenceParams> GameAssetReferences { get; set; }
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    public string? GameWorkingDirectory { get; set; }
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    public bool? IsOSPreview { get; set; }
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public string? OsPlatform { get; set; }
    public required List<Port> Ports { get; set; }
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    public required string StartMultiplayerServerCommand { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
}

public class CreateBuildWithProcessBasedServerResponse : PlayFabResultCommon {
    public bool? AreAssetsReadonly { get; set; }
    public string? BuildId { get; set; }
    public string? BuildName { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public DateTime? CreationTime { get; set; }
    public List<AssetReference>? GameAssetReferences { get; set; }
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    public string? GameWorkingDirectory { get; set; }
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    public bool? IsOSPreview { get; set; }
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public string? OsPlatform { get; set; }
    public List<Port>? Ports { get; set; }
    public List<BuildRegion>? RegionConfigurations { get; set; }
    public string? ServerType { get; set; }
    public string? StartMultiplayerServerCommand { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Request to create a lobby. A Server or client can create a lobby.
/// </summary>
public class CreateLobbyRequest : PlayFabRequestCommon {
    public AccessPolicy? AccessPolicy { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? LobbyData { get; set; }
    public UInt32 MaxPlayers { get; set; }
    public List<Member>? Members { get; set; }
    public required EntityKey Owner { get; set; }
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    public bool RestrictInvitesToLobbyOwner { get; set; }
    public Dictionary<string, string>? SearchData { get; set; }
    public bool UseConnections { get; set; }
}

public class CreateLobbyResult : PlayFabResultCommon {
    public required string ConnectionString { get; set; }
    public required string LobbyId { get; set; }
}

/// <summary>
/// The client specifies the creator's attributes and optionally a list of other users to match with.
/// </summary>
public class CreateMatchmakingTicketRequest : PlayFabRequestCommon {
    public required MatchmakingPlayer Creator { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int GiveUpAfterSeconds { get; set; }
    public List<EntityKey>? MembersToMatchWith { get; set; }
    public required string QueueName { get; set; }
}

public class CreateMatchmakingTicketResult : PlayFabResultCommon {
    public required string TicketId { get; set; }
}

/// <summary>
/// Creates a remote user to log on to a VM for a multiplayer server build in a specific region. Returns user credential information necessary to log on.
/// </summary>
public class CreateRemoteUserRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public DateTime? ExpirationTime { get; set; }
    public required string Region { get; set; }
    public required string Username { get; set; }
    public required string VmId { get; set; }
}

public class CreateRemoteUserResponse : PlayFabResultCommon {
    public DateTime? ExpirationTime { get; set; }
    public string? Password { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// Request to create a scenario. A Title can make this request.
/// </summary>
public class CreateScenarioRequest : PlayFabRequestCommon {
    public List<ScenarioConfigCondition>? Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? Events { get; set; }
    public required string Name { get; set; }
}

public class CreateScenarioResponse : PlayFabResultCommon {
    public string? ScenarioId { get; set; }
}

/// <summary>
/// The server specifies all the members, their teams and their attributes, and the server details if applicable.
/// </summary>
public class CreateServerBackfillTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int GiveUpAfterSeconds { get; set; }
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    public required string QueueName { get; set; }
    public ServerDetails? ServerDetails { get; set; }
}

public class CreateServerBackfillTicketResult : PlayFabResultCommon {
    public required string TicketId { get; set; }
}

/// <summary>
/// The server specifies all the members and their attributes.
/// </summary>
public class CreateServerMatchmakingTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int GiveUpAfterSeconds { get; set; }
    public required List<MatchmakingPlayer> Members { get; set; }
    public required string QueueName { get; set; }
}

/// <summary>
/// Creates a request to change a title's multiplayer server quotas.
/// </summary>
public class CreateTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon {
    public string? ChangeDescription { get; set; }
    public required List<CoreCapacityChange> Changes { get; set; }
    public string? ContactEmail { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Notes { get; set; }
    public DateTime? StartDate { get; set; }
}

public class CreateTitleMultiplayerServersQuotaChangeResponse : PlayFabResultCommon {
    public string? RequestId { get; set; }
    public bool WasApproved { get; set; }
}

public class CurrentServerStats {
    public int Active { get; set; }
    public int Propping { get; set; }
    public int StandingBy { get; set; }
    public int Total { get; set; }
}

public class CustomDifferenceRuleExpansion {
    public required List<OverrideDouble> DifferenceOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class CustomRegionSelectionRuleExpansion {
    public required List<OverrideUnsignedInt> MaxLatencyOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class CustomSetIntersectionRuleExpansion {
    public required List<OverrideUnsignedInt> MinIntersectionSizeOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class CustomTeamDifferenceRuleExpansion {
    public required List<OverrideDouble> DifferenceOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class CustomTeamSizeBalanceRuleExpansion {
    public required List<OverrideUnsignedInt> DifferenceOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

/// <summary>
/// Request to deactivate a model. A Title can make this request.
/// </summary>
public class DeactivateModelRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public required string ScenarioId { get; set; }
}

public class DeactivateModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a multiplayer server game asset for a title.
/// </summary>
public class DeleteAssetRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FileName { get; set; }
}

/// <summary>
/// Deletes a multiplayer server build alias.
/// </summary>
public class DeleteBuildAliasRequest : PlayFabRequestCommon {
    public required string AliasId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Removes a multiplayer server build's region.
/// </summary>
public class DeleteBuildRegionRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Region { get; set; }
}

/// <summary>
/// Deletes a multiplayer server build.
/// </summary>
public class DeleteBuildRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Deletes a multiplayer server game certificate.
/// </summary>
public class DeleteCertificateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

/// <summary>
/// Removes the specified container image repository. After this operation, a 'docker pull' will fail for all the tags of the specified image. Morever, ListContainerImages will not return the specified image.
/// </summary>
public class DeleteContainerImageRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ImageName { get; set; }
}

/// <summary>
/// Request to delete a lobby. Only servers can delete lobbies.
/// </summary>
public class DeleteLobbyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? LobbyId { get; set; }
}

/// <summary>
/// Request to delete a model. A Title can make this request.
/// </summary>
public class DeleteModelRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public required string ScenarioId { get; set; }
}

public class DeleteModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a remote user to log on to a VM for a multiplayer server build in a specific region. Returns user credential information necessary to log on.
/// </summary>
public class DeleteRemoteUserRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Region { get; set; }
    public required string Username { get; set; }
    public required string VmId { get; set; }
}

/// <summary>
/// Request to delete a scenario configuration. A Title can make this request.
/// </summary>
public class DeleteScenarioRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool ForceDelete { get; set; }
    public required string ScenarioId { get; set; }
}

public class DeleteScenarioResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a multiplayer server game secret.
/// </summary>
public class DeleteSecretRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class DifferenceRule {
    public required QueueRuleAttribute Attribute { get; set; }
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    public CustomDifferenceRuleExpansion? CustomExpansion { get; set; }
    public double? DefaultAttributeValue { get; set; }
    public required double Difference { get; set; }
    public LinearDifferenceRuleExpansion? LinearExpansion { get; set; }
    public AttributeMergeFunction MergeFunction { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
    public required double Weight { get; set; }
}

public enum DirectPeerConnectivityOptions {
    None,
    SamePlatformType,
    DifferentPlatformType,
    AnyPlatformType,
    SameEntityLoginProvider,
    DifferentEntityLoginProvider,
    AnyEntityLoginProvider,
    AnyPlatformTypeAndEntityLoginProvider,
    OnlyServers,
}

public class DynamicStandbySettings {
    public List<DynamicStandbyThreshold>? DynamicFloorMultiplierThresholds { get; set; }
    public bool IsEnabled { get; set; }
    public int? RampDownSeconds { get; set; }
}

public class DynamicStandbyThreshold {
    public required double Multiplier { get; set; }
    public required double TriggerThresholdPercentage { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Enables the multiplayer server feature for a title and returns the enabled status. The enabled status can be Initializing, Enabled, and Disabled. It can up to 20 minutes or more for the title to be enabled for the feature. On average, it can take up to 20 minutes for the title to be enabled for the feature.
/// </summary>
public class EnableMultiplayerServersForTitleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class EnableMultiplayerServersForTitleResponse : PlayFabResultCommon {
    public TitleMultiplayerServerEnabledStatus? Status { get; set; }
}

/// <summary>
/// Enables the parties feature for a title.
/// </summary>
public class EnablePartiesForTitleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public enum ExternalFriendSources {
    None,
    Steam,
    Facebook,
    Xbox,
    Psn,
    All,
}

/// <summary>
/// Request to find friends lobbies. Only a client can find friend lobbies.
/// </summary>
public class FindFriendLobbiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ExcludeFacebookFriends { get; set; }
    public bool? ExcludeSteamFriends { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public string? Filter { get; set; }
    public string? OrderBy { get; set; }
    public PaginationRequest? Pagination { get; set; }
    public string? XboxToken { get; set; }
}

public class FindFriendLobbiesResult : PlayFabResultCommon {
    public required List<FriendLobbySummary> Lobbies { get; set; }
    public required PaginationResponse Pagination { get; set; }
}

/// <summary>
/// Request to find lobbies.
/// </summary>
public class FindLobbiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Filter { get; set; }
    public string? OrderBy { get; set; }
    public PaginationRequest? Pagination { get; set; }
}

public class FindLobbiesResult : PlayFabResultCommon {
    public required List<LobbySummary> Lobbies { get; set; }
    public required PaginationResponse Pagination { get; set; }
}

public class FriendLobbySummary {
    public required string ConnectionString { get; set; }
    public UInt32 CurrentPlayers { get; set; }
    public List<EntityKey>? Friends { get; set; }
    public required string LobbyId { get; set; }
    public UInt32 MaxPlayers { get; set; }
    public MembershipLock? MembershipLock { get; set; }
    public required EntityKey Owner { get; set; }
    public Dictionary<string, string>? SearchData { get; set; }
}

public class GameCertificateReference {
    public string? GsdkAlias { get; set; }
    public string? Name { get; set; }
}

public class GameCertificateReferenceParams {
    public required string GsdkAlias { get; set; }
    public required string Name { get; set; }
}

public class GameSecretReference {
    public string? Name { get; set; }
}

public class GameSecretReferenceParams {
    public required string Name { get; set; }
}

/// <summary>
/// Gets a URL that can be used to download the specified asset.
/// </summary>
public class GetAssetDownloadUrlRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FileName { get; set; }
}

public class GetAssetDownloadUrlResponse : PlayFabResultCommon {
    public string? AssetDownloadUrl { get; set; }
    public string? FileName { get; set; }
}

/// <summary>
/// Gets the URL to upload assets to.
/// </summary>
public class GetAssetUploadUrlRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FileName { get; set; }
}

public class GetAssetUploadUrlResponse : PlayFabResultCommon {
    public string? AssetUploadUrl { get; set; }
    public string? FileName { get; set; }
}

/// <summary>
/// Returns the details about a multiplayer server build alias.
/// </summary>
public class GetBuildAliasRequest : PlayFabRequestCommon {
    public required string AliasId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Returns the details about a multiplayer server build.
/// </summary>
public class GetBuildRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetBuildResponse : PlayFabResultCommon {
    public bool? AreAssetsReadonly { get; set; }
    public string? BuildId { get; set; }
    public string? BuildName { get; set; }
    public string? BuildStatus { get; set; }
    public ContainerFlavor? ContainerFlavor { get; set; }
    public string? ContainerRunCommand { get; set; }
    public DateTime? CreationTime { get; set; }
    public ContainerImageReference? CustomGameContainerImage { get; set; }
    public List<AssetReference>? GameAssetReferences { get; set; }
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public int MultiplayerServerCountPerVm { get; set; }
    public string? OsPlatform { get; set; }
    public List<Port>? Ports { get; set; }
    public List<BuildRegion>? RegionConfigurations { get; set; }
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    public string? ServerType { get; set; }
    public string? StartMultiplayerServerCommand { get; set; }
    public bool? UseStreamingForAssetDownloads { get; set; }
    public AzureVmSize? VmSize { get; set; }
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Gets supported locales for the cognitive services where translation queries can be sent to.
/// </summary>
public class GetCognitiveServicesLocalesRequest : PlayFabRequestCommon {
    public CognitiveServicesType CognitiveServicesType { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Region { get; set; }
}

public class GetCognitiveServicesLocalesResponse : PlayFabResultCommon {
    public List<CognitiveServicesLocale>? Locales { get; set; }
}

/// <summary>
/// Gets a token for the cognitive services where translation queries can be sent to.
/// </summary>
public class GetCognitiveServicesTokenRequest : PlayFabRequestCommon {
    public CognitiveServicesType CognitiveServicesType { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Region { get; set; }
}

public class GetCognitiveServicesTokenResponse : PlayFabResultCommon {
    public DateTime? ExpirationTimeUtc { get; set; }
    public string? ServiceEndpoint { get; set; }
    public string? Token { get; set; }
}

/// <summary>
/// Gets credentials to the container registry where game developers can upload custom container images to before creating a new build.
/// </summary>
public class GetContainerRegistryCredentialsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetContainerRegistryCredentialsResponse : PlayFabResultCommon {
    public string? DnsName { get; set; }
    public string? Password { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// Request to get a lobby.
/// </summary>
public class GetLobbyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? LobbyId { get; set; }
}

public class GetLobbyResult : PlayFabResultCommon {
    public required Lobby Lobby { get; set; }
}

/// <summary>
/// Gets the current configuration for a queue.
/// </summary>
public class GetMatchmakingQueueRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? QueueName { get; set; }
}

public class GetMatchmakingQueueResult : PlayFabResultCommon {
    public MatchmakingQueueConfig? MatchmakingQueue { get; set; }
}

/// <summary>
/// The ticket includes the invited players, their attributes if they have joined, the ticket status, the match Id when applicable, etc. Only servers, the ticket creator and the invited players can get the ticket.
/// </summary>
public class GetMatchmakingTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool EscapeObject { get; set; }
    public required string QueueName { get; set; }
    public required string TicketId { get; set; }
}

public class GetMatchmakingTicketResult : PlayFabResultCommon {
    public CancellationReason? CancellationReason { get; set; }
    public string? CancellationReasonString { get; set; }
    public UInt32? ChangeNumber { get; set; }
    public required DateTime Created { get; set; }
    public required EntityKey Creator { get; set; }
    public int GiveUpAfterSeconds { get; set; }
    public string? MatchId { get; set; }
    public required List<MatchmakingPlayer> Members { get; set; }
    public List<EntityKey>? MembersToMatchWith { get; set; }
    public required string QueueName { get; set; }
    public required string Status { get; set; }
    public required string TicketId { get; set; }
}

/// <summary>
/// When matchmaking has successfully matched together a collection of tickets, it produces a 'match' with an Id. The match contains all of the players that were matched together, and their team assigments. Only servers and ticket members can get the match.
/// </summary>
public class GetMatchRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool EscapeObject { get; set; }
    public required string MatchId { get; set; }
    public required string QueueName { get; set; }
    public bool ReturnMemberAttributes { get; set; }
}

public class GetMatchResult : PlayFabResultCommon {
    public string? ArrangementString { get; set; }
    public required string MatchId { get; set; }
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    public List<string>? RegionPreferences { get; set; }
    public ServerDetails? ServerDetails { get; set; }
}

/// <summary>
/// Request to get the details of a model of a scenario. A Title can make this request.
/// </summary>
public class GetModelDetailsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetModelDetailsResponse : PlayFabResultCommon {
    public ModelDetails? ModelDetails { get; set; }
}

/// <summary>
/// Request to get models for a specific scenario. A Title can make this request.
/// </summary>
public class GetModelsByScenarioRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetModelsByScenarioResponse : PlayFabResultCommon {
    public List<ModelSummary>? Models { get; set; }
}

/// <summary>
/// Gets multiplayer server session details as well as the associated user connection tokens for a build in a specific region.
/// </summary>
public class GetMultiplayerServerAndTokenRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string SessionId { get; set; }
    public required List<string> TokenPlayerIds { get; set; }
}

public class GetMultiplayerServerAndTokenResponse : PlayFabResultCommon {
    public string? BuildId { get; set; }
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public string? FQDN { get; set; }
    public string? IPV4Address { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public List<PlayerToken>? PlayerTokens { get; set; }
    public List<Port>? Ports { get; set; }
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? SessionId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

/// <summary>
/// Gets multiplayer server session details for a build in a specific region.
/// </summary>
public class GetMultiplayerServerDetailsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string SessionId { get; set; }
}

public class GetMultiplayerServerDetailsResponse : PlayFabResultCommon {
    public string? BuildId { get; set; }
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public string? FQDN { get; set; }
    public string? IPV4Address { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public List<Port>? Ports { get; set; }
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? SessionId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

/// <summary>
/// Gets multiplayer server logs for a specific server id in a region. The logs are available only after a server has terminated.
/// </summary>
public class GetMultiplayerServerLogsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Region { get; set; }
    public required string ServerId { get; set; }
}

public class GetMultiplayerServerLogsResponse : PlayFabResultCommon {
    public string? LogDownloadUrl { get; set; }
}

/// <summary>
/// Gets multiplayer server logs for a specific server id in a region. The logs are available only after a server has terminated.
/// </summary>
public class GetMultiplayerSessionLogsBySessionIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string SessionId { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for multiple sets of conditions from a specific model. A Title, Server or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillForConditionsFromModelRequest : PlayFabRequestCommon {
    public required List<ConditionsSet> Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IncludeSkillBreakdown { get; set; }
    public required string ModelId { get; set; }
    public required List<TrueSkillPlayer> Players { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillForConditionsFromModelResponse : PlayFabResultCommon {
    public bool IsModelPrimary { get; set; }
    public List<PlayerSkills>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for multiple sets of conditions from the primary model of a given scenario. A Title, Server or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillForConditionsRequest : PlayFabRequestCommon {
    public required List<ConditionsSet> Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IncludeSkillBreakdown { get; set; }
    public required List<TrueSkillPlayer> Players { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillForConditionsResponse : PlayFabResultCommon {
    public string? ModelId { get; set; }
    public List<PlayerSkills>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for a specific model. A Title, Server or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillFromModelRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IncludeSkillBreakdown { get; set; }
    public required string ModelId { get; set; }
    public required List<TrueSkillPlayer> Players { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillFromModelResponse : PlayFabResultCommon {
    public bool IsModelPrimary { get; set; }
    public List<PlayerSkill>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players from the primary model of a given scenario. A Title, Server or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? Conditions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool IncludeSkillBreakdown { get; set; }
    public required List<TrueSkillPlayer> Players { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillResponse : PlayFabResultCommon {
    public string? ModelId { get; set; }
    public List<PlayerSkill>? Skills { get; set; }
}

/// <summary>
/// Returns the matchmaking statistics for a queue. These include the number of players matching and the statistics related to the time to match statistics in seconds (average and percentiles). Statistics are refreshed once every 5 minutes. Servers can access all statistics no matter what the ClientStatisticsVisibility is configured to. Clients can access statistics according to the ClientStatisticsVisibility. Client requests are forbidden if all visibility fields are false.
/// </summary>
public class GetQueueStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string QueueName { get; set; }
}

public class GetQueueStatisticsResult : PlayFabResultCommon {
    public UInt32? NumberOfPlayersMatching { get; set; }
    public Statistics? TimeToMatchStatisticsInSeconds { get; set; }
}

/// <summary>
/// Gets a remote login endpoint to a VM that is hosting a multiplayer server build in a specific region.
/// </summary>
public class GetRemoteLoginEndpointRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Region { get; set; }
    public required string VmId { get; set; }
}

public class GetRemoteLoginEndpointResponse : PlayFabResultCommon {
    public string? IPV4Address { get; set; }
    public int Port { get; set; }
}

/// <summary>
/// Request to get a scenario configuration. A Title can make this request.
/// </summary>
public class GetScenarioConfigurationRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ScenarioId { get; set; }
}

public class GetScenarioConfigurationResponse : PlayFabResultCommon {
    public ScenarioConfiguration? ScenarioConfiguration { get; set; }
}

/// <summary>
/// Request to get all scenario configurations of a title. A Title can make this request.
/// </summary>
public class GetScenarioConfigurationsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetScenarioConfigurationsResponse : PlayFabResultCommon {
    public List<ScenarioConfiguration>? ScenarioConfigurations { get; set; }
}

/// <summary>
/// The ticket includes the players, their attributes, their teams, the ticket status, the match Id and the server details when applicable, etc. Only servers can get the ticket.
/// </summary>
public class GetServerBackfillTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool EscapeObject { get; set; }
    public required string QueueName { get; set; }
    public required string TicketId { get; set; }
}

public class GetServerBackfillTicketResult : PlayFabResultCommon {
    public CancellationReason? CancellationReason { get; set; }
    public string? CancellationReasonString { get; set; }
    public required DateTime Created { get; set; }
    public int GiveUpAfterSeconds { get; set; }
    public string? MatchId { get; set; }
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    public required string QueueName { get; set; }
    public required ServerDetails ServerDetails { get; set; }
    public required string Status { get; set; }
    public required string TicketId { get; set; }
}

/// <summary>
/// Gets the status of whether a title is enabled for the multiplayer server feature. The enabled status can be Initializing, Enabled, and Disabled.
/// </summary>
public class GetTitleEnabledForMultiplayerServersStatusRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetTitleEnabledForMultiplayerServersStatusResponse : PlayFabResultCommon {
    public TitleMultiplayerServerEnabledStatus? Status { get; set; }
}

/// <summary>
/// Gets a title's server quota change request.
/// </summary>
public class GetTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string RequestId { get; set; }
}

public class GetTitleMultiplayerServersQuotaChangeResponse : PlayFabResultCommon {
    public QuotaChange? Change { get; set; }
}

/// <summary>
/// Gets the quotas for a title in relation to multiplayer servers.
/// </summary>
public class GetTitleMultiplayerServersQuotasRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetTitleMultiplayerServersQuotasResponse : PlayFabResultCommon {
    public TitleMultiplayerServersQuotas? Quotas { get; set; }
}

public class InstrumentationConfiguration {
    public bool? IsEnabled { get; set; }
    public List<string>? ProcessesToMonitor { get; set; }
}

/// <summary>
/// Request to invite a player to a lobby the caller is already a member of. Only a client can invite another player to a lobby.
/// </summary>
public class InviteToLobbyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? InviteeEntity { get; set; }
    public string? LobbyId { get; set; }
    public EntityKey? MemberEntity { get; set; }
}

/// <summary>
/// Request to join an arranged lobby. Only a client can join an arranged lobby.
/// </summary>
public class JoinArrangedLobbyRequest : PlayFabRequestCommon {
    public AccessPolicy? AccessPolicy { get; set; }
    public required string ArrangementString { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public UInt32 MaxPlayers { get; set; }
    public Dictionary<string, string>? MemberData { get; set; }
    public required EntityKey MemberEntity { get; set; }
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    public bool RestrictInvitesToLobbyOwner { get; set; }
    public bool UseConnections { get; set; }
}

/// <summary>
/// Preview: Request to join a lobby as a server. Only callable by a game_server entity and this is restricted to client owned lobbies which are using connections.
/// </summary>
public class JoinLobbyAsServerRequest : PlayFabRequestCommon {
    public required string ConnectionString { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? ServerData { get; set; }
    public required EntityKey ServerEntity { get; set; }
}

public class JoinLobbyAsServerResult : PlayFabResultCommon {
    public required string LobbyId { get; set; }
}

/// <summary>
/// Request to join a lobby. Only a client can join a lobby.
/// </summary>
public class JoinLobbyRequest : PlayFabRequestCommon {
    public string? ConnectionString { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? MemberData { get; set; }
    public EntityKey? MemberEntity { get; set; }
}

public class JoinLobbyResult : PlayFabResultCommon {
    public required string LobbyId { get; set; }
}

/// <summary>
/// Add the player to a matchmaking ticket and specify all of its matchmaking attributes. Players can join a ticket if and only if their EntityKeys are already listed in the ticket's Members list. The matchmaking service automatically starts matching the ticket against other matchmaking tickets once all players have joined the ticket. It is not possible to join a ticket once it has started matching.
/// </summary>
public class JoinMatchmakingTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required MatchmakingPlayer Member { get; set; }
    public required string QueueName { get; set; }
    public required string TicketId { get; set; }
}

public class JoinMatchmakingTicketResult : PlayFabResultCommon {
}

/// <summary>
/// Preview: Request for server to leave a lobby. Only a game_server entity can leave and this is restricted to client owned lobbies which are using connections.
/// </summary>
public class LeaveLobbyAsServerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public required EntityKey ServerEntity { get; set; }
}

/// <summary>
/// Request to leave a lobby. Only a client can leave a lobby.
/// </summary>
public class LeaveLobbyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? LobbyId { get; set; }
    public EntityKey? MemberEntity { get; set; }
}

public class LinearDifferenceRuleExpansion {
    public required double Delta { get; set; }
    public double? Limit { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class LinearRegionSelectionRuleExpansion {
    public UInt32 Delta { get; set; }
    public UInt32 Limit { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class LinearSetIntersectionRuleExpansion {
    public UInt32 Delta { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class LinearTeamDifferenceRuleExpansion {
    public required double Delta { get; set; }
    public double? Limit { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class LinearTeamSizeBalanceRuleExpansion {
    public UInt32 Delta { get; set; }
    public UInt32? Limit { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class LinuxInstrumentationConfiguration {
    public bool IsEnabled { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game asset summaries for a title.
/// </summary>
public class ListAssetSummariesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListAssetSummariesResponse : PlayFabResultCommon {
    public List<AssetSummary>? AssetSummaries { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of summarized details of all multiplayer server builds for a title.
/// </summary>
public class ListBuildAliasesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListBuildAliasesResponse : PlayFabResultCommon {
    public List<BuildAliasDetailsResponse>? BuildAliases { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of summarized details of all multiplayer server builds for a title.
/// </summary>
public class ListBuildSummariesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListBuildSummariesResponse : PlayFabResultCommon {
    public List<BuildSummary>? BuildSummaries { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game certificates for a title.
/// </summary>
public class ListCertificateSummariesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListCertificateSummariesResponse : PlayFabResultCommon {
    public List<CertificateSummary>? CertificateSummaries { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of the container images that have been uploaded to the container registry for a title.
/// </summary>
public class ListContainerImagesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListContainerImagesResponse : PlayFabResultCommon {
    public List<string>? Images { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of the tags for a particular container image that exists in the container registry for a title.
/// </summary>
public class ListContainerImageTagsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ImageName { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListContainerImageTagsResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
    public List<string>? Tags { get; set; }
}

/// <summary>
/// Gets a list of all the matchmaking queue configurations for the title.
/// </summary>
public class ListMatchmakingQueuesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListMatchmakingQueuesResult : PlayFabResultCommon {
    public List<MatchmakingQueueConfig>? MatchMakingQueues { get; set; }
}

/// <summary>
/// If the caller is a title, the EntityKey in the request is required. If the caller is a player, then it is optional. If it is provided it must match the caller's entity.
/// </summary>
public class ListMatchmakingTicketsForPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string QueueName { get; set; }
}

public class ListMatchmakingTicketsForPlayerResult : PlayFabResultCommon {
    public required List<string> TicketIds { get; set; }
}

/// <summary>
/// Returns a list of multiplayer servers for a build in a specific region.
/// </summary>
public class ListMultiplayerServersRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public required string Region { get; set; }
    public string? SkipToken { get; set; }
}

public class ListMultiplayerServersResponse : PlayFabResultCommon {
    public List<MultiplayerServerSummary>? MultiplayerServerSummaries { get; set; }
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers for party.
/// </summary>
public class ListPartyQosServersRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class ListPartyQosServersResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public List<QosServer>? QosServers { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers for a title.
/// </summary>
public class ListQosServersForTitleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? IncludeAllRegions { get; set; }
    public string? RoutingPreference { get; set; }
}

public class ListQosServersForTitleResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public List<QosServer>? QosServers { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers.
/// </summary>
[Obsolete("Do not use")]
public class ListQosServersRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

[Obsolete("Do not use")]
public class ListQosServersResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public List<QosServer>? QosServers { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game secrets for a title.
/// </summary>
public class ListSecretSummariesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public string? SkipToken { get; set; }
}

public class ListSecretSummariesResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public List<SecretSummary>? SecretSummaries { get; set; }
    public string? SkipToken { get; set; }
}

/// <summary>
/// List all server backfill ticket Ids the user is a member of.
/// </summary>
public class ListServerBackfillTicketsForPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required string QueueName { get; set; }
}

public class ListServerBackfillTicketsForPlayerResult : PlayFabResultCommon {
    public required List<string> TicketIds { get; set; }
}

/// <summary>
/// List all server quota change requests for a title.
/// </summary>
public class ListTitleMultiplayerServersQuotaChangesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListTitleMultiplayerServersQuotaChangesResponse : PlayFabResultCommon {
    public List<QuotaChange>? Changes { get; set; }
}

/// <summary>
/// Returns a list of virtual machines for a title.
/// </summary>
public class ListVirtualMachineSummariesRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? PageSize { get; set; }
    public required string Region { get; set; }
    public string? SkipToken { get; set; }
}

public class ListVirtualMachineSummariesResponse : PlayFabResultCommon {
    public int PageSize { get; set; }
    public string? SkipToken { get; set; }
    public List<VirtualMachineSummary>? VirtualMachines { get; set; }
}

public class Lobby {
    public AccessPolicy AccessPolicy { get; set; }
    public UInt32 ChangeNumber { get; set; }
    public required string ConnectionString { get; set; }
    public Dictionary<string, string>? LobbyData { get; set; }
    public required string LobbyId { get; set; }
    public UInt32 MaxPlayers { get; set; }
    public List<Member>? Members { get; set; }
    public MembershipLock MembershipLock { get; set; }
    public EntityKey? Owner { get; set; }
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    public string? PubSubConnectionHandle { get; set; }
    public bool RestrictInvitesToLobbyOwner { get; set; }
    public Dictionary<string, string>? SearchData { get; set; }
    public LobbyServer? Server { get; set; }
    public bool UseConnections { get; set; }
}

public class LobbyEmptyResult : PlayFabResultCommon {
}

public class LobbyServer {
    public string? PubSubConnectionHandle { get; set; }
    public Dictionary<string, string>? ServerData { get; set; }
    public EntityKey? ServerEntity { get; set; }
}

public class LobbySummary {
    public required string ConnectionString { get; set; }
    public UInt32 CurrentPlayers { get; set; }
    public required string LobbyId { get; set; }
    public UInt32 MaxPlayers { get; set; }
    public MembershipLock? MembershipLock { get; set; }
    public required EntityKey Owner { get; set; }
    public Dictionary<string, string>? SearchData { get; set; }
}

/// <summary>
/// A user in a matchmaking ticket.
/// </summary>
public class MatchmakingPlayer {
    public MatchmakingPlayerAttributes? Attributes { get; set; }
    public required EntityKey Entity { get; set; }
}

/// <summary>
/// The matchmaking attributes for a user.
/// </summary>
public class MatchmakingPlayerAttributes {
    public object? DataObject { get; set; }
    public string? EscapedDataObject { get; set; }
}

/// <summary>
/// A player in a created matchmaking match with a team assignment.
/// </summary>
public class MatchmakingPlayerWithTeamAssignment {
    public MatchmakingPlayerAttributes? Attributes { get; set; }
    public required EntityKey Entity { get; set; }
    public string? TeamId { get; set; }
}

public class MatchmakingQueueConfig {
    public BuildAliasParams? BuildAliasParams { get; set; }
    public string? BuildId { get; set; }
    public List<DifferenceRule>? DifferenceRules { get; set; }
    public List<MatchTotalRule>? MatchTotalRules { get; set; }
    public UInt32 MaxMatchSize { get; set; }
    public UInt32? MaxTicketSize { get; set; }
    public UInt32 MinMatchSize { get; set; }
    public required string Name { get; set; }
    public RegionSelectionRule? RegionSelectionRule { get; set; }
    public bool ServerAllocationEnabled { get; set; }
    public List<SetIntersectionRule>? SetIntersectionRules { get; set; }
    public StatisticsVisibilityToPlayers? StatisticsVisibilityToPlayers { get; set; }
    public List<StringEqualityRule>? StringEqualityRules { get; set; }
    public List<TeamDifferenceRule>? TeamDifferenceRules { get; set; }
    public List<MatchmakingQueueTeam>? Teams { get; set; }
    public TeamSizeBalanceRule? TeamSizeBalanceRule { get; set; }
    public TeamTicketSizeSimilarityRule? TeamTicketSizeSimilarityRule { get; set; }
}

public class MatchmakingQueueTeam {
    public UInt32 MaxTeamSize { get; set; }
    public UInt32 MinTeamSize { get; set; }
    public required string Name { get; set; }
}

public class MatchResult {
    public required DateTime EndDateTimeUtc { get; set; }
    public required string ScenarioId { get; set; }
    public required DateTime StartDateTimeUtc { get; set; }
    public required List<MatchResultTeam> Teams { get; set; }
}

public class MatchResultPlayer {
    public int? BotId { get; set; }
    public required string CompletionStatus { get; set; }
    public Dictionary<string, string>? Conditions { get; set; }
    public EntityKey? Entity { get; set; }
    public Dictionary<string, int>? EventCounts { get; set; }
    public string? PreMatchPartyId { get; set; }
    public int SecondsPlayed { get; set; }
}

public class MatchResultTeam {
    public required List<MatchResultPlayer> Players { get; set; }
    public int Rank { get; set; }
}

public class MatchTotalRule {
    public required QueueRuleAttribute Attribute { get; set; }
    public MatchTotalRuleExpansion? Expansion { get; set; }
    public required double Max { get; set; }
    public required double Min { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
    public required double Weight { get; set; }
}

public class MatchTotalRuleExpansion {
    public List<OverrideDouble>? MaxOverrides { get; set; }
    public List<OverrideDouble>? MinOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

public class Member {
    public Dictionary<string, string>? MemberData { get; set; }
    public EntityKey? MemberEntity { get; set; }
    public string? PubSubConnectionHandle { get; set; }
}

public enum MembershipLock {
    Unlocked,
    Locked,
}

public class ModelCondition {
    public required string Key { get; set; }
    public int Rank { get; set; }
}

public class ModelDetails {
    public int? BatchIterations { get; set; }
    public BatchParameters? BatchParameters { get; set; }
    public BatchResults? BatchResults { get; set; }
    public List<ModelCondition>? Conditions { get; set; }
    public required DateTime CreationDateTime { get; set; }
    public double? CurrentAnomalousMatchResultIgnoreThreshold { get; set; }
    public int? CurrentStateProgress { get; set; }
    public int? EstimatedTimeRemainingInSeconds { get; set; }
    public List<string>? Events { get; set; }
    public bool IsPrimary { get; set; }
    public int? MaxStateProgress { get; set; }
    public string? ModelCreationMethod { get; set; }
    public string? ModelId { get; set; }
    public string? ModelName { get; set; }
    public string? ModelState { get; set; }
}

public class ModelSummary {
    public required DateTime CreationDateTime { get; set; }
    public bool IsPrimary { get; set; }
    public string? ModelId { get; set; }
    public string? ModelName { get; set; }
    public string? ModelState { get; set; }
}

public class MonitoringApplicationConfiguration {
    public required AssetReference AssetReference { get; set; }
    public required string ExecutionScriptName { get; set; }
    public string? InstallationScriptName { get; set; }
    public double? OnStartRuntimeInMinutes { get; set; }
}

public class MonitoringApplicationConfigurationParams {
    public required AssetReferenceParams AssetReference { get; set; }
    public required string ExecutionScriptName { get; set; }
    public string? InstallationScriptName { get; set; }
    public double? OnStartRuntimeInMinutes { get; set; }
}

public class MultiplayerServerSummary {
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? SessionId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

public enum OsPlatform {
    Windows,
    Linux,
}

public class OverrideDouble {
    public required double Value { get; set; }
}

public class OverrideUnsignedInt {
    public UInt32 Value { get; set; }
}

public enum OwnerMigrationPolicy {
    None,
    Automatic,
    Manual,
    Server,
}

public class PaginationRequest {
    public string? ContinuationToken { get; set; }
    public UInt32? PageSizeRequested { get; set; }
}

public class PaginationResponse {
    public string? ContinuationToken { get; set; }
    public UInt32? TotalMatchedLobbyCount { get; set; }
}

public class PartyBuildAliasParams {
    public required string AliasId { get; set; }
}

public class PartyInvitationConfiguration {
    public List<EntityKey>? EntityKeys { get; set; }
    public string? Identifier { get; set; }
    public string? Revocability { get; set; }
}

public enum PartyInvitationRevocability {
    Creator,
    Anyone,
}

public class PartyNetworkConfiguration {
    public string? DirectPeerConnectivityOptions { get; set; }
    public UInt32 MaxDevices { get; set; }
    public UInt32 MaxDevicesPerUser { get; set; }
    public UInt32 MaxEndpointsPerDevice { get; set; }
    public UInt32 MaxUsers { get; set; }
    public UInt32 MaxUsersPerDevice { get; set; }
    public PartyInvitationConfiguration? PartyInvitationConfiguration { get; set; }
}

public class PlayerSkill {
    public EntityKey? Entity { get; set; }
    public required DateTime LastProcessedMatchUploadTimeUtc { get; set; }
    public required double MatchmakingSkillValue { get; set; }
    public SkillBreakdown? SkillBreakdown { get; set; }
    public required double SkillValue { get; set; }
}

public class PlayerSkillForCondition {
    public Dictionary<string, string>? Conditions { get; set; }
    public required double MatchmakingSkillValue { get; set; }
    public SkillBreakdown? SkillBreakdown { get; set; }
    public required double SkillValue { get; set; }
}

public class PlayerSkills {
    public EntityKey? Entity { get; set; }
    public required DateTime LastProcessedMatchUploadTimeUtc { get; set; }
    public List<PlayerSkillForCondition>? SkillsForConditions { get; set; }
}

public class PlayerToken {
    public string? PlayerId { get; set; }
    public string? Token { get; set; }
}

public class Port {
    public required string Name { get; set; }
    public int Num { get; set; }
    public ProtocolType Protocol { get; set; }
}

public enum ProtocolType {
    TCP,
    UDP,
}

public class PublicIpAddress {
    public required string FQDN { get; set; }
    public required string IpAddress { get; set; }
    public required string RoutingType { get; set; }
}

public class QosServer {
    public string? Region { get; set; }
    public string? ServerUrl { get; set; }
}

public class QueueRuleAttribute {
    public required string Path { get; set; }
    public AttributeSource Source { get; set; }
}

public class QuotaChange {
    public string? ChangeDescription { get; set; }
    public List<CoreCapacityChange>? Changes { get; set; }
    public bool IsPendingReview { get; set; }
    public string? Notes { get; set; }
    public string? RequestId { get; set; }
    public string? ReviewComments { get; set; }
    public bool WasApproved { get; set; }
}

public class RegionSelectionRule {
    public CustomRegionSelectionRuleExpansion? CustomExpansion { get; set; }
    public LinearRegionSelectionRuleExpansion? LinearExpansion { get; set; }
    public UInt32 MaxLatency { get; set; }
    public required string Name { get; set; }
    public required string Path { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
    public required double Weight { get; set; }
}

/// <summary>
/// Deletes the configuration for a queue. This will permanently delete the configuration and players will no longer be able to match in the queue. All outstanding matchmaking tickets will be cancelled.
/// </summary>
public class RemoveMatchmakingQueueRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? QueueName { get; set; }
}

public class RemoveMatchmakingQueueResult : PlayFabResultCommon {
}

/// <summary>
/// Request to remove a member from a lobby. Owners may remove other members from a lobby. Members cannot remove themselves (use LeaveLobby instead).
/// </summary>
public class RemoveMemberFromLobbyRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? LobbyId { get; set; }
    public EntityKey? MemberEntity { get; set; }
    public bool PreventRejoin { get; set; }
}

/// <summary>
/// Requests a multiplayer server session from a particular build in any of the given preferred regions.
/// </summary>
public class RequestMultiplayerServerAndTokenRequest : PlayFabRequestCommon {
    public BuildAliasParams? BuildAliasParams { get; set; }
    public string? BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? InitialPlayers { get; set; }
    public required List<string> PreferredRegions { get; set; }
    public string? SessionCookie { get; set; }
    public required string SessionId { get; set; }
    public required List<string> TokenPlayerIds { get; set; }
}

public class RequestMultiplayerServerAndTokenResponse : PlayFabResultCommon {
    public string? BuildId { get; set; }
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public string? FQDN { get; set; }
    public string? IPV4Address { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public List<PlayerToken>? PlayerTokens { get; set; }
    public List<Port>? Ports { get; set; }
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? SessionId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a multiplayer server session from a particular build in any of the given preferred regions.
/// </summary>
public class RequestMultiplayerServerRequest : PlayFabRequestCommon {
    public BuildAliasParams? BuildAliasParams { get; set; }
    public string? BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? InitialPlayers { get; set; }
    public required List<string> PreferredRegions { get; set; }
    public string? SessionCookie { get; set; }
    public required string SessionId { get; set; }
}

public class RequestMultiplayerServerResponse : PlayFabResultCommon {
    public string? BuildId { get; set; }
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public string? FQDN { get; set; }
    public string? IPV4Address { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public List<Port>? Ports { get; set; }
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? SessionId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a party session from a particular build if version is provided or in a set of builds if build alias params is provided, in any of the given preferred regions.
/// </summary>
public class RequestPartyRequest : PlayFabRequestCommon {
    public PartyBuildAliasParams? BuildAliasParams { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PartyId { get; set; }
    public required List<string> PreferredRegions { get; set; }
    public string? SessionCookie { get; set; }
    public string? Version { get; set; }
}

public class RequestPartyResponse : PlayFabResultCommon {
    public string? BuildId { get; set; }
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    public string? DTLSCertificateSHA2Thumbprint { get; set; }
    public string? FQDN { get; set; }
    public string? IPV4Address { get; set; }
    public DateTime? LastStateTransitionTime { get; set; }
    public string? PartyId { get; set; }
    public List<Port>? Ports { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a party session from a particular set of builds if build alias params is provided, in any of the given preferred regions.
/// </summary>
public class RequestPartyServiceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required PartyNetworkConfiguration NetworkConfiguration { get; set; }
    public string? PartyId { get; set; }
    public required List<string> PreferredRegions { get; set; }
}

public class RequestPartyServiceResponse : PlayFabResultCommon {
    public string? InvitationId { get; set; }
    public string? PartyId { get; set; }
    public string? SerializedNetworkDescriptor { get; set; }
}

/// <summary>
/// Gets new credentials to the container registry where game developers can upload custom container images to before creating a new build.
/// </summary>
public class RolloverContainerRegistryCredentialsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RolloverContainerRegistryCredentialsResponse : PlayFabResultCommon {
    public string? DnsName { get; set; }
    public string? Password { get; set; }
    public string? Username { get; set; }
}

public enum RoutingType {
    Microsoft,
    Internet,
}

public class ScenarioConfigCondition {
    public required string Key { get; set; }
    public required List<string> Values { get; set; }
}

public class ScenarioConfigEvent {
    public string? Name { get; set; }
    public string? State { get; set; }
}

public class ScenarioConfigResponseCondition {
    public required string Key { get; set; }
    public string? State { get; set; }
    public required List<string> Values { get; set; }
}

public class ScenarioConfiguration {
    public List<ScenarioConfigResponseCondition>? Conditions { get; set; }
    public List<ScenarioConfigEvent>? Events { get; set; }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? PrimaryModelId { get; set; }
}

public class Schedule {
    public string? Description { get; set; }
    public required DateTime EndTime { get; set; }
    public bool IsDisabled { get; set; }
    public bool IsRecurringWeekly { get; set; }
    public required DateTime StartTime { get; set; }
    public int TargetStandby { get; set; }
}

public class ScheduledStandbySettings {
    public bool IsEnabled { get; set; }
    public List<Schedule>? ScheduleList { get; set; }
}

public class Secret {
    public DateTime? ExpirationDate { get; set; }
    public required string Name { get; set; }
    public required string Value { get; set; }
}

public class SecretSummary {
    public DateTime? ExpirationDate { get; set; }
    public string? Name { get; set; }
    public string? Version { get; set; }
}

public class ServerDetails {
    public string? Fqdn { get; set; }
    public string? IPV4Address { get; set; }
    public List<Port>? Ports { get; set; }
    public string? Region { get; set; }
    public string? ServerId { get; set; }
}

public class ServerResourceConstraintParams {
    public required double CpuLimit { get; set; }
    public required double MemoryLimitGB { get; set; }
}

public enum ServerType {
    Container,
    Process,
}

public class SetIntersectionRule {
    public required QueueRuleAttribute Attribute { get; set; }
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    public CustomSetIntersectionRuleExpansion? CustomExpansion { get; set; }
    public List<string>? DefaultAttributeValue { get; set; }
    public LinearSetIntersectionRuleExpansion? LinearExpansion { get; set; }
    public UInt32 MinIntersectionSize { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
    public required double Weight { get; set; }
}

/// <summary>
/// Use this API to create or update matchmaking queue configurations. The queue configuration defines the matchmaking rules. The matchmaking service will match tickets together according to the configured rules. Queue resources are not spun up by calling this API. Queues are created when the first ticket is submitted.
/// </summary>
public class SetMatchmakingQueueRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required MatchmakingQueueConfig MatchmakingQueue { get; set; }
}

public class SetMatchmakingQueueResult : PlayFabResultCommon {
}

/// <summary>
/// Executes the shutdown callback from the GSDK and terminates the multiplayer server session. The callback in the GSDK will allow for graceful shutdown with a 15 minute timeoutIf graceful shutdown has not been completed before 15 minutes have elapsed, the multiplayer server session will be forcefully terminated on it's own.
/// </summary>
public class ShutdownMultiplayerServerRequest : PlayFabRequestCommon {
    public string? BuildId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Region { get; set; }
    public required string SessionId { get; set; }
}

public class SkillBreakdown {
    public int Experience { get; set; }
    public required double Mean { get; set; }
    public double? QuantileRank { get; set; }
    public required double Variance { get; set; }
}

public class Statistics {
    public required double Average { get; set; }
    public required double Percentile50 { get; set; }
    public required double Percentile90 { get; set; }
    public required double Percentile99 { get; set; }
}

public class StatisticsVisibilityToPlayers {
    public bool ShowNumberOfPlayersMatching { get; set; }
    public bool ShowTimeToMatch { get; set; }
}

public class StringEqualityRule {
    public required QueueRuleAttribute Attribute { get; set; }
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    public string? DefaultAttributeValue { get; set; }
    public StringEqualityRuleExpansion? Expansion { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
    public required double Weight { get; set; }
}

public class StringEqualityRuleExpansion {
    public List<bool> EnabledOverrides { get; set; }
    public UInt32 SecondsBetweenExpansions { get; set; }
}

/// <summary>
/// Request to subscribe to lobby resource notifications.
/// </summary>
public class SubscribeToLobbyResourceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey EntityKey { get; set; }
    public required string PubSubConnectionHandle { get; set; }
    public required string ResourceId { get; set; }
    public UInt32 SubscriptionVersion { get; set; }
    public SubscriptionType Type { get; set; }
}

public class SubscribeToLobbyResourceResult : PlayFabResultCommon {
    public required string Topic { get; set; }
}

/// <summary>
/// Subscribe to match resource notifications. Match subscriptions have two types; MatchInvite and MatchTicketStatusChange
/// </summary>
public class SubscribeToMatchResourceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey EntityKey { get; set; }
    public required string PubSubConnectionHandle { get; set; }
    public required string ResourceId { get; set; }
    public UInt32 SubscriptionVersion { get; set; }
    public required string Type { get; set; }
}

public class SubscribeToMatchResourceResult : PlayFabResultCommon {
    public required string Topic { get; set; }
}

public enum SubscriptionType {
    LobbyChange,
    LobbyInvite,
}

public class TeamDifferenceRule {
    public required QueueRuleAttribute Attribute { get; set; }
    public CustomTeamDifferenceRuleExpansion? CustomExpansion { get; set; }
    public required double DefaultAttributeValue { get; set; }
    public required double Difference { get; set; }
    public LinearTeamDifferenceRuleExpansion? LinearExpansion { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
}

public class TeamSizeBalanceRule {
    public CustomTeamSizeBalanceRuleExpansion? CustomExpansion { get; set; }
    public UInt32 Difference { get; set; }
    public LinearTeamSizeBalanceRuleExpansion? LinearExpansion { get; set; }
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
}

public class TeamTicketSizeSimilarityRule {
    public required string Name { get; set; }
    public UInt32? SecondsUntilOptional { get; set; }
}

public enum TitleMultiplayerServerEnabledStatus {
    Initializing,
    Enabled,
    Disabled,
}

public class TitleMultiplayerServersQuotas {
    public List<CoreCapacity>? CoreCapacities { get; set; }
}

public class TrueSkillPlayer {
    public required EntityKey Entity { get; set; }
    public int? SquadSize { get; set; }
}

/// <summary>
/// Request to unsubscribe from lobby notifications.
/// </summary>
public class UnsubscribeFromLobbyResourceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey EntityKey { get; set; }
    public required string PubSubConnectionHandle { get; set; }
    public required string ResourceId { get; set; }
    public UInt32 SubscriptionVersion { get; set; }
    public SubscriptionType Type { get; set; }
}

/// <summary>
/// Unsubscribe from a Match resource's notifications. For MatchInvite, players are expected to unsubscribe once they can no longer accept invites. For MatchTicketStatusChange, players are expected to unsusbcribe once the ticket has reached a canceled or matched state.
/// </summary>
public class UnsubscribeFromMatchResourceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey EntityKey { get; set; }
    public required string PubSubConnectionHandle { get; set; }
    public required string ResourceId { get; set; }
    public UInt32 SubscriptionVersion { get; set; }
    public required string Type { get; set; }
}

public class UnsubscribeFromMatchResourceResult : PlayFabResultCommon {
}

/// <summary>
/// Removes the specified tag from the image. After this operation, a 'docker pull' will fail for the specified image and tag combination. Morever, ListContainerImageTags will not return the specified tag.
/// </summary>
public class UntagContainerImageRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ImageName { get; set; }
    public string? Tag { get; set; }
}

/// <summary>
/// Creates a multiplayer server build alias and returns the created alias.
/// </summary>
public class UpdateBuildAliasRequest : PlayFabRequestCommon {
    public required string AliasId { get; set; }
    public string? AliasName { get; set; }
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's name.
/// </summary>
public class UpdateBuildNameRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public required string BuildName { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's region.
/// </summary>
public class UpdateBuildRegionRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public required BuildRegionParams BuildRegion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's regions.
/// </summary>
public class UpdateBuildRegionsRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
    public required List<BuildRegionParams> BuildRegions { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Preview: Request to update the serverData and serverEntity in case of migration. Only a game_server entity can update this information and this is restricted to client owned lobbies which are using connections.
/// </summary>
public class UpdateLobbyAsServerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public Dictionary<string, string>? ServerData { get; set; }
    public List<string>? ServerDataToDelete { get; set; }
    public EntityKey? ServerEntity { get; set; }
}

/// <summary>
/// Request to update a lobby.
/// </summary>
public class UpdateLobbyRequest : PlayFabRequestCommon {
    public AccessPolicy? AccessPolicy { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? LobbyData { get; set; }
    public List<string>? LobbyDataToDelete { get; set; }
    public string? LobbyId { get; set; }
    public UInt32? MaxPlayers { get; set; }
    public Dictionary<string, string>? MemberData { get; set; }
    public List<string>? MemberDataToDelete { get; set; }
    public EntityKey? MemberEntity { get; set; }
    public MembershipLock? MembershipLock { get; set; }
    public EntityKey? Owner { get; set; }
    public Dictionary<string, string>? SearchData { get; set; }
    public List<string>? SearchDataToDelete { get; set; }
}

/// <summary>
/// Request to update properties of a model. A Title can make this request.
/// </summary>
public class UpdateModelRequest : PlayFabRequestCommon {
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public string? ModelName { get; set; }
    public required string ScenarioId { get; set; }
}

public class UpdateModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Request to update the primary model. A Title can make this request.
/// </summary>
public class UpdatePrimaryModelRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ModelId { get; set; }
    public required string ScenarioId { get; set; }
}

public class UpdatePrimaryModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Request to update a scenario configuration. A Title can make this request.
/// </summary>
public class UpdateScenarioConfigurationRequest : PlayFabRequestCommon {
    public List<string>? ConditionsToRemove { get; set; }
    public List<ScenarioConfigCondition>? ConditionsToUpdateOrAdd { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? EventsToAdd { get; set; }
    public List<string>? EventsToRemove { get; set; }
    public string? Name { get; set; }
    public required string ScenarioId { get; set; }
}

public class UpdateScenarioConfigurationResponse : PlayFabResultCommon {
}

/// <summary>
/// Uploads a multiplayer server game certificate.
/// </summary>
public class UploadCertificateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceUpdate { get; set; }
    public required Certificate GameCertificate { get; set; }
}

/// <summary>
/// Request to upload a match result. A Title or Server can upload a match result.
/// </summary>
public class UploadMatchResultRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required MatchResult MatchResult { get; set; }
}

public class UploadMatchResultResponse : PlayFabResultCommon {
    public string? MatchResultId { get; set; }
    public required DateTime UploadTimeUtc { get; set; }
}

/// <summary>
/// Uploads a multiplayer server game secret.
/// </summary>
public class UploadSecretRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceUpdate { get; set; }
    public required Secret GameSecret { get; set; }
}

public class VirtualMachineSummary {
    public string? HealthStatus { get; set; }
    public string? State { get; set; }
    public string? VmId { get; set; }
}

public class VmStartupScriptConfiguration {
    public List<VmStartupScriptPortRequest>? PortRequests { get; set; }
    public required AssetReference VmStartupScriptAssetReference { get; set; }
}

public class VmStartupScriptParams {
    public List<VmStartupScriptPortRequestParams>? PortRequests { get; set; }
    public required AssetReferenceParams VmStartupScriptAssetReference { get; set; }
}

public class VmStartupScriptPortRequest {
    public required string Name { get; set; }
    public ProtocolType Protocol { get; set; }
}

public class VmStartupScriptPortRequestParams {
    public required string Name { get; set; }
    public ProtocolType Protocol { get; set; }
}

public class WindowsCrashDumpConfiguration {
    public int? CustomDumpFlags { get; set; }
    public int? DumpType { get; set; }
    public bool IsEnabled { get; set; }
}

