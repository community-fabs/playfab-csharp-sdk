using CommunityFabs.NET.Common.Http;

namespace CommunityFabs.NET.Common.Models.Multiplayer;

public enum AccessPolicy {
    Public,
    Friends,
    Private,
}

public class AssetReference {
    /// <summary>
    /// The asset's file name. This is a filename with the .zip, .tar, or .tar.gz extension.
    /// </summary>
    public string? FileName { get; set; }
    /// <summary>
    /// The asset's mount path.
    /// </summary>
    public string? MountPath { get; set; }
}

public class AssetReferenceParams {
    /// <summary>
    /// The asset's file name.
    /// </summary>
    public required string FileName { get; set; }
    /// <summary>
    /// The asset's mount path.
    /// </summary>
    public string? MountPath { get; set; }
}

public class AssetSummary {
    /// <summary>
    /// The asset's file name. This is a filename with the .zip, .tar, or .tar.gz extension.
    /// </summary>
    public string? FileName { get; set; }
    /// <summary>
    /// The metadata associated with the asset.
    /// </summary>
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
    Dadsv6,
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
    Standard_D2ads_v6,
    Standard_D4ads_v6,
    Standard_D8ads_v6,
    Standard_D16ads_v6,
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
    /// <summary>
    /// The initial threshold value for determining if a match result is considered anomalous enough to be ignored. If this is
    /// not specified and the parent model ID is specified, then the parent model's value will be used. Otherwise, a default
    /// value of -20 is used. Note: This was the one that was used when creating the batch model, which might differ from
    /// <c>CurrentAnomalousMatchResultIgnoreThreshold</c> value.
    /// </summary>
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    /// <summary>
    /// DateTime in UTC of the end of the range of match result end times for a batch run. The specified DateTime is exclusive.
    /// </summary>
    public required DateTime MatchResultEndDateTime { get; set; }
    /// <summary>
    /// DateTime in UTC of the start of the range of match result end times for a batch run. The specified DateTime is
    /// inclusive.
    /// </summary>
    public required DateTime MatchResultStartDateTime { get; set; }
    /// <summary>
    /// Maximum number of batch learning iterations to run.
    /// </summary>
    public int MaxIterations { get; set; }
    /// <summary>
    /// ID of the Model that was used as a parent of the batch run for creating this model.
    /// </summary>
    public string? ParentModelId { get; set; }
}

public class BatchResults {
    /// <summary>
    /// A dictionary containing the activity value for certain batch learning iterations. The key is the iteration number and
    /// the value is the activity value. The activity value is a measure of how much the model is changing. The batch learning
    /// algorithm will stop if the activity drops below a convergence threshold.
    /// </summary>
    public Dictionary<string, double>? LearningActivity { get; set; }
    /// <summary>
    /// The number of match results that were within the date range for the batch run but were ignored because they didn't have
    /// the required conditions or events.
    /// </summary>
    public int MatchResultsIgnoredCount { get; set; }
    /// <summary>
    /// The number of match results that were processed in the batch run.
    /// </summary>
    public int MatchResultsUsedCount { get; set; }
    /// <summary>
    /// The total duration in seconds of the batch run.
    /// </summary>
    public int RunTimeInSeconds { get; set; }
}

public class BuildAliasDetailsResponse : PlayFabResultCommon {
    /// <summary>
    /// The guid string alias Id of the alias to be created or updated.
    /// </summary>
    public string? AliasId { get; set; }
    /// <summary>
    /// The alias name.
    /// </summary>
    public string? AliasName { get; set; }
    /// <summary>
    /// Array of build selection criteria.
    /// </summary>
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public string? SkipToken { get; set; }
}

public class BuildAliasParams {
    /// <summary>
    /// The guid string alias ID to use for the request.
    /// </summary>
    public required string AliasId { get; set; }
}

public class BuildRegion {
    /// <summary>
    /// The current multiplayer server stats for the region.
    /// </summary>
    public CurrentServerStats? CurrentServerStats { get; set; }
    /// <summary>
    /// Optional settings to control dynamic adjustment of standby target
    /// </summary>
    public DynamicStandbySettings? DynamicStandbySettings { get; set; }
    /// <summary>
    /// Whether the game assets provided for the build have been replicated to this region.
    /// </summary>
    public bool IsAssetReplicationComplete { get; set; }
    /// <summary>
    /// The maximum number of multiplayer servers for the region.
    /// </summary>
    public int MaxServers { get; set; }
    /// <summary>
    /// Regional override for the number of multiplayer servers to host on a single VM of the build.
    /// </summary>
    public int? MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The build region.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// Optional settings to set the standby target to specified values during the supplied schedules
    /// </summary>
    public ScheduledStandbySettings? ScheduledStandbySettings { get; set; }
    /// <summary>
    /// The target number of standby multiplayer servers for the region.
    /// </summary>
    public int StandbyServers { get; set; }
    /// <summary>
    /// The status of multiplayer servers in the build region. Valid values are - Unknown, Initialized, Deploying, Deployed,
    /// Unhealthy, Deleting, Deleted.
    /// </summary>
    public string? Status { get; set; }
    /// <summary>
    /// Regional override for the VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
}

public class BuildRegionParams {
    /// <summary>
    /// Optional settings to control dynamic adjustment of standby target. If not specified, dynamic standby is disabled
    /// </summary>
    public DynamicStandbySettings? DynamicStandbySettings { get; set; }
    /// <summary>
    /// The maximum number of multiplayer servers for the region.
    /// </summary>
    public int MaxServers { get; set; }
    /// <summary>
    /// Regional override for the number of multiplayer servers to host on a single VM of the build.
    /// </summary>
    public int? MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The build region.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// Optional settings to set the standby target to specified values during the supplied schedules
    /// </summary>
    public ScheduledStandbySettings? ScheduledStandbySettings { get; set; }
    /// <summary>
    /// The number of standby multiplayer servers for the region.
    /// </summary>
    public int StandbyServers { get; set; }
    /// <summary>
    /// Regional override for the VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
}

public class BuildSelectionCriterion {
    /// <summary>
    /// Dictionary of build ids and their respective weights for distribution of allocation requests.
    /// </summary>
    public Dictionary<string, uint>? BuildWeightDistribution { get; set; }
}

public class BuildSummary {
    /// <summary>
    /// The guid string build ID of the build.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public string? BuildName { get; set; }
    /// <summary>
    /// The time the build was created in UTC.
    /// </summary>
    public DateTime? CreationTime { get; set; }
    /// <summary>
    /// The metadata of the build.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration and status for each region in the build.
    /// </summary>
    public List<BuildRegion>? RegionConfigurations { get; set; }
}

/// <summary>
/// Cancels all tickets of which the player is a member in a given queue that are not cancelled or matched. This API is
/// useful if you lose track of what tickets the player is a member of (if the title crashes for instance) and want to
/// "reset". The Entity field is optional if the caller is a player and defaults to that player. Players may not cancel
/// tickets for other people. The Entity field is required if the caller is a server (authenticated as the title).
/// </summary>
public class CancelAllMatchmakingTicketsForPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity key of the player whose tickets should be canceled.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the queue from which a player's tickets should be canceled.
    /// </summary>
    public required string QueueName { get; set; }
}

public class CancelAllMatchmakingTicketsForPlayerResult : PlayFabResultCommon {
}

/// <summary>
/// Cancels all backfill tickets of which the player is a member in a given queue that are not cancelled or matched. This
/// API is useful if you lose track of what tickets the player is a member of (if the server crashes for instance) and want
/// to "reset".
/// </summary>
public class CancelAllServerBackfillTicketsForPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity key of the player whose backfill tickets should be canceled.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The name of the queue from which a player's backfill tickets should be canceled.
    /// </summary>
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
/// Only servers and ticket members can cancel a ticket. The ticket can be in five different states when it is cancelled.
/// 1: the ticket is waiting for members to join it, and it has not started matching. If the ticket is cancelled at this
/// stage, it will never match. 2: the ticket is matching. If the ticket is cancelled, it will stop matching. 3: the ticket
/// is matched. A matched ticket cannot be cancelled. 4: the ticket is already cancelled and nothing happens. 5: the ticket
/// is waiting for a server. If the ticket is cancelled, server allocation will be stopped. A server may still be allocated
/// due to a race condition, but that will not be reflected in the ticket. There may be race conditions between the ticket
/// getting matched and the client making a cancellation request. The client must handle the possibility that the cancel
/// request fails if a match is found before the cancellation request is processed. We do not allow resubmitting a
/// cancelled ticket because players must consent to enter matchmaking again. Create a new ticket instead.
/// </summary>
public class CancelMatchmakingTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the queue the ticket is in.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

public class CancelMatchmakingTicketResult : PlayFabResultCommon {
}

/// <summary>
/// Request to cancel the creation of a batch model. A Title can make this request.
/// </summary>
public class CancelModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the Model we want to cancel a batch run for.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// The ID of the Scenario that the requested model belongs to.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class CancelModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Only servers can cancel a backfill ticket. The ticket can be in three different states when it is cancelled. 1: the
/// ticket is matching. If the ticket is cancelled, it will stop matching. 2: the ticket is matched. A matched ticket
/// cannot be cancelled. 3: the ticket is already cancelled and nothing happens. There may be race conditions between the
/// ticket getting matched and the server making a cancellation request. The server must handle the possibility that the
/// cancel request fails if a match is found before the cancellation request is processed. We do not allow resubmitting a
/// cancelled ticket. Create a new ticket instead.
/// </summary>
public class CancelServerBackfillTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the queue the ticket is in.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

public class CancelServerBackfillTicketResult : PlayFabResultCommon {
}

public class Certificate {
    /// <summary>
    /// Base64 encoded string contents of the certificate.
    /// </summary>
    public required string Base64EncodedValue { get; set; }
    /// <summary>
    /// A name for the certificate. This is used to reference certificates in build configurations.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// If required for your PFX certificate, use this field to provide a password that will be used to install the certificate
    /// on the container.
    /// </summary>
    public string? Password { get; set; }
}

public class CertificateSummary {
    /// <summary>
    /// The name of the certificate.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The thumbprint for the certificate.
    /// </summary>
    public string? Thumbprint { get; set; }
}

public class CognitiveServicesLocale {
    /// <summary>
    /// Gender of the locale if available
    /// </summary>
    public string? Gender { get; set; }
    /// <summary>
    /// The code for supported locale
    /// </summary>
    public string? Locale { get; set; }
    /// <summary>
    /// Name of the locale if available
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Short name of the locale if available
    /// </summary>
    public string? ShortName { get; set; }
}

public enum CognitiveServicesType {
    SpeechToText,
    SpeechToTextTranslation,
    TextToSpeech,
    TextToText,
}

public class ConditionsSet {
    /// <summary>
    /// A map from condition names to condition values in which to get the skills of the players.
    /// </summary>
    public Dictionary<string, string>? Conditions { get; set; }
}

public class ConnectedPlayer {
    /// <summary>
    /// The player ID of the player connected to the multiplayer server.
    /// </summary>
    public string? PlayerId { get; set; }
}

public enum ContainerFlavor {
    ManagedWindowsServerCore,
    CustomLinux,
    ManagedWindowsServerCorePreview,
    Invalid,
}

public class ContainerImageReference {
    /// <summary>
    /// The container image name.
    /// </summary>
    public required string ImageName { get; set; }
    /// <summary>
    /// The container tag.
    /// </summary>
    public string? Tag { get; set; }
}

public class CoreCapacity {
    /// <summary>
    /// The available core capacity for the (Region, VmFamily)
    /// </summary>
    public int Available { get; set; }
    /// <summary>
    /// The AzureRegion
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The total core capacity for the (Region, VmFamily)
    /// </summary>
    public int Total { get; set; }
    /// <summary>
    /// The AzureVmFamily
    /// </summary>
    public AzureVmFamily? VmFamily { get; set; }
}

public class CoreCapacityChange {
    /// <summary>
    /// New quota core limit for the given vm family/region.
    /// </summary>
    public int NewCoreLimit { get; set; }
    /// <summary>
    /// Region to change.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// Virtual machine family to change.
    /// </summary>
    public AzureVmFamily VmFamily { get; set; }
}

/// <summary>
/// Request to create a base model. A Title can make this request.
/// </summary>
public class CreateBaseModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// A list of condition keys and their associated affinity weights for this model.
    /// </summary>
    public List<ModelCondition>? Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the model that will be created.
    /// </summary>
    public required string ModelName { get; set; }
    /// <summary>
    /// The ID of the scenario to create the base model.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class CreateBaseModelResponse : PlayFabResultCommon {
    /// <summary>
    /// The id of the model that was created.
    /// </summary>
    public string? ModelId { get; set; }
}

/// <summary>
/// Request to create a model for a scenario. This also begins a batch run over a set of MatchResults to create the model.
/// A Title can make this request.
/// </summary>
public class CreateBatchModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// The threshold value for determining if a match result is considered anomalous enough to be ignored. It must be
    /// negative. If this is not specified and the parent model ID is specified, then the parent model's value will be used.
    /// Otherwise, a default value of -20 is used. Typically, increasing it by 1 to -19 will roughly detect 3x more anomalous
    /// matches. Typically, decreasing it by 1 to -21 will roughly detect 3x less anomalous matches.
    /// </summary>
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    /// <summary>
    /// A list of condition keys and their associated affinity weights for this model.
    /// </summary>
    public List<ModelCondition>? Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// A list of events used in this model.
    /// </summary>
    public List<string>? Events { get; set; }
    /// <summary>
    /// A model ID which is the batch run uses as a starting point for learning. If not supplied a base model is used as the
    /// starting point.
    /// </summary>
    public string? InitialSettingsModelId { get; set; }
    /// <summary>
    /// The exclusive end time of match results used for this mode.
    /// </summary>
    public required DateTime MatchResultEndTimeUtc { get; set; }
    /// <summary>
    /// The inclusive start time of match results used for this mode.
    /// </summary>
    public required DateTime MatchResultStartTimeUtc { get; set; }
    /// <summary>
    /// The maximum number of batch learning iterations to run.
    /// </summary>
    public int MaxIterations { get; set; }
    /// <summary>
    /// The name of the model that will be created.
    /// </summary>
    public required string ModelName { get; set; }
    /// <summary>
    /// The ID of the scenario for this batch model.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class CreateBatchModelResponse : PlayFabResultCommon {
    /// <summary>
    /// The id of the model that was created. Null if the request failed.
    /// </summary>
    public string? ModelId { get; set; }
}

/// <summary>
/// Creates a multiplayer server build alias and returns the created alias.
/// </summary>
public class CreateBuildAliasRequest : PlayFabRequestCommon {
    /// <summary>
    /// The alias name.
    /// </summary>
    public required string AliasName { get; set; }
    /// <summary>
    /// Array of build selection criteria.
    /// </summary>
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with a custom container and returns information about the build creation request.
/// </summary>
public class CreateBuildWithCustomContainerRequest : PlayFabRequestCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public required string BuildName { get; set; }
    /// <summary>
    /// The flavor of container to create a build from.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The container reference, consisting of the image name and tag.
    /// </summary>
    public ContainerImageReference? ContainerImageReference { get; set; }
    /// <summary>
    /// The name of the container repository.
    /// </summary>
    public string? ContainerRepositoryName { get; set; }
    /// <summary>
    /// The container command to run when the multiplayer server has been allocated, including any arguments.
    /// </summary>
    public string? ContainerRunCommand { get; set; }
    /// <summary>
    /// The tag for the container.
    /// </summary>
    public string? ContainerTag { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The list of game assets related to the build.
    /// </summary>
    public List<AssetReferenceParams>? GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    /// <summary>
    /// The Linux instrumentation configuration for the build.
    /// </summary>
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    /// <summary>
    /// Metadata to tag the build. The keys are case insensitive. The build metadata is made available to the server through
    /// Game Server SDK (GSDK).Constraints: Maximum number of keys: 30, Maximum key length: 50, Maximum value length: 100
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application on the build
    /// </summary>
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The ports to map the build on.
    /// </summary>
    public required List<Port> Ports { get; set; }
    /// <summary>
    /// The region configurations for the build.
    /// </summary>
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    /// <summary>
    /// The resource constraints to apply to each server on the VM (EXPERIMENTAL API)
    /// </summary>
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    /// <summary>
    /// DEPRECATED - this is always true. Assets are downloaded and uncompressed in memory, without the compressedversion being
    /// written first to disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size to create the build on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript for the build
    /// </summary>
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
}

public class CreateBuildWithCustomContainerResponse : PlayFabResultCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The guid string build ID. Must be unique for every build.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public string? BuildName { get; set; }
    /// <summary>
    /// The flavor of container of the build.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The container command to run when the multiplayer server has been allocated, including any arguments.
    /// </summary>
    public string? ContainerRunCommand { get; set; }
    /// <summary>
    /// The time the build was created in UTC.
    /// </summary>
    public DateTime? CreationTime { get; set; }
    /// <summary>
    /// The custom game container image reference information.
    /// </summary>
    public ContainerImageReference? CustomGameContainerImage { get; set; }
    /// <summary>
    /// The game assets for the build.
    /// </summary>
    public List<AssetReference>? GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    /// <summary>
    /// The Linux instrumentation configuration for this build.
    /// </summary>
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    /// <summary>
    /// The metadata of the build.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application for the build
    /// </summary>
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM of the build.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The OS platform used for running the game process.
    /// </summary>
    public string? OsPlatform { get; set; }
    /// <summary>
    /// The ports the build is mapped on.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The region configuration for the build.
    /// </summary>
    public List<BuildRegion>? RegionConfigurations { get; set; }
    /// <summary>
    /// The resource constraints to apply to each server on the VM (EXPERIMENTAL API)
    /// </summary>
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    /// <summary>
    /// The type of game server being hosted.
    /// </summary>
    public string? ServerType { get; set; }
    /// <summary>
    /// When true, assets will be downloaded and uncompressed in memory, without the compressedversion being written first to
    /// disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript feature for the build
    /// </summary>
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with a managed container and returns information about the build creation request.
/// </summary>
public class CreateBuildWithManagedContainerRequest : PlayFabRequestCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public required string BuildName { get; set; }
    /// <summary>
    /// The flavor of container to create a build from.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The list of game assets related to the build.
    /// </summary>
    public required List<AssetReferenceParams> GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    /// <summary>
    /// The directory containing the game executable. This would be the start path of the game assets that contain the main
    /// game server executable. If not provided, a best effort will be made to extract it from the start game command.
    /// </summary>
    public string? GameWorkingDirectory { get; set; }
    /// <summary>
    /// The instrumentation configuration for the build.
    /// </summary>
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    /// <summary>
    /// Metadata to tag the build. The keys are case insensitive. The build metadata is made available to the server through
    /// Game Server SDK (GSDK).Constraints: Maximum number of keys: 30, Maximum key length: 50, Maximum value length: 100
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application on the build
    /// </summary>
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The ports to map the build on.
    /// </summary>
    public required List<Port> Ports { get; set; }
    /// <summary>
    /// The region configurations for the build.
    /// </summary>
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    /// <summary>
    /// The resource constraints to apply to each server on the VM (EXPERIMENTAL API)
    /// </summary>
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    /// <summary>
    /// The command to run when the multiplayer server is started, including any arguments.
    /// </summary>
    public required string StartMultiplayerServerCommand { get; set; }
    /// <summary>
    /// DEPRECATED - this is always true. Assets are downloaded and uncompressed in memory, without the compressedversion being
    /// written first to disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size to create the build on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript for the build
    /// </summary>
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
    /// <summary>
    /// The crash dump configuration for the build.
    /// </summary>
    public WindowsCrashDumpConfiguration? WindowsCrashDumpConfiguration { get; set; }
}

public class CreateBuildWithManagedContainerResponse : PlayFabResultCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The guid string build ID. Must be unique for every build.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public string? BuildName { get; set; }
    /// <summary>
    /// The flavor of container of the build.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The time the build was created in UTC.
    /// </summary>
    public DateTime? CreationTime { get; set; }
    /// <summary>
    /// The game assets for the build.
    /// </summary>
    public List<AssetReference>? GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    /// <summary>
    /// The directory containing the game executable. This would be the start path of the game assets that contain the main
    /// game server executable. If not provided, a best effort will be made to extract it from the start game command.
    /// </summary>
    public string? GameWorkingDirectory { get; set; }
    /// <summary>
    /// The instrumentation configuration for this build.
    /// </summary>
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    /// <summary>
    /// The metadata of the build.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application for the build
    /// </summary>
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM of the build.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The OS platform used for running the game process.
    /// </summary>
    public string? OsPlatform { get; set; }
    /// <summary>
    /// The ports the build is mapped on.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The region configuration for the build.
    /// </summary>
    public List<BuildRegion>? RegionConfigurations { get; set; }
    /// <summary>
    /// The resource constraints to apply to each server on the VM (EXPERIMENTAL API)
    /// </summary>
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    /// <summary>
    /// The type of game server being hosted.
    /// </summary>
    public string? ServerType { get; set; }
    /// <summary>
    /// The command to run when the multiplayer server has been allocated, including any arguments.
    /// </summary>
    public string? StartMultiplayerServerCommand { get; set; }
    /// <summary>
    /// When true, assets will be downloaded and uncompressed in memory, without the compressedversion being written first to
    /// disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript feature for the build
    /// </summary>
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Creates a multiplayer server build with the game server running as a process and returns information about the build
/// creation request.
/// </summary>
public class CreateBuildWithProcessBasedServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public required string BuildName { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The list of game assets related to the build.
    /// </summary>
    public required List<AssetReferenceParams> GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReferenceParams>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReferenceParams>? GameSecretReferences { get; set; }
    /// <summary>
    /// The working directory for the game process. If this is not provided, the working directory will be set based on the
    /// mount path of the game server executable.
    /// </summary>
    public string? GameWorkingDirectory { get; set; }
    /// <summary>
    /// The instrumentation configuration for the Build. Used only if it is a Windows Build.
    /// </summary>
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    /// <summary>
    /// Indicates whether this build will be created using the OS Preview versionPreview OS is recommended for dev builds to
    /// detect any breaking changes before they are released to retail. Retail builds should set this value to false.
    /// </summary>
    public bool? IsOSPreview { get; set; }
    /// <summary>
    /// The Linux instrumentation configuration for the Build. Used only if it is a Linux Build.
    /// </summary>
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    /// <summary>
    /// Metadata to tag the build. The keys are case insensitive. The build metadata is made available to the server through
    /// Game Server SDK (GSDK).Constraints: Maximum number of keys: 30, Maximum key length: 50, Maximum value length: 100
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application on the build
    /// </summary>
    public MonitoringApplicationConfigurationParams? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The OS platform used for running the game process.
    /// </summary>
    public string? OsPlatform { get; set; }
    /// <summary>
    /// The ports to map the build on.
    /// </summary>
    public required List<Port> Ports { get; set; }
    /// <summary>
    /// The region configurations for the build.
    /// </summary>
    public required List<BuildRegionParams> RegionConfigurations { get; set; }
    /// <summary>
    /// The command to run when the multiplayer server is started, including any arguments. The path to any executable should
    /// be relative to the root asset folder when unzipped.
    /// </summary>
    public required string StartMultiplayerServerCommand { get; set; }
    /// <summary>
    /// DEPRECATED - this is always true. Assets are downloaded and uncompressed in memory, without the compressedversion being
    /// written first to disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size to create the build on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript for the build
    /// </summary>
    public VmStartupScriptParams? VmStartupScriptConfiguration { get; set; }
}

public class CreateBuildWithProcessBasedServerResponse : PlayFabResultCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The guid string build ID. Must be unique for every build.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public string? BuildName { get; set; }
    /// <summary>
    /// The flavor of container of the build.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The time the build was created in UTC.
    /// </summary>
    public DateTime? CreationTime { get; set; }
    /// <summary>
    /// The game assets for the build.
    /// </summary>
    public List<AssetReference>? GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The game secrets for the build.
    /// </summary>
    public List<GameSecretReference>? GameSecretReferences { get; set; }
    /// <summary>
    /// The working directory for the game process. If this is not provided, the working directory will be set based on the
    /// mount path of the game server executable.
    /// </summary>
    public string? GameWorkingDirectory { get; set; }
    /// <summary>
    /// The instrumentation configuration for this build.
    /// </summary>
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    /// <summary>
    /// Indicates whether this build will be created using the OS Preview versionPreview OS is recommended for dev builds to
    /// detect any breaking changes before they are released to retail. Retail builds should set this value to false.
    /// </summary>
    public bool? IsOSPreview { get; set; }
    /// <summary>
    /// The Linux instrumentation configuration for this build.
    /// </summary>
    public LinuxInstrumentationConfiguration? LinuxInstrumentationConfiguration { get; set; }
    /// <summary>
    /// The metadata of the build.
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The configuration for the monitoring application for the build
    /// </summary>
    public MonitoringApplicationConfiguration? MonitoringApplicationConfiguration { get; set; }
    /// <summary>
    /// The number of multiplayer servers to host on a single VM of the build.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The OS platform used for running the game process.
    /// </summary>
    public string? OsPlatform { get; set; }
    /// <summary>
    /// The ports the build is mapped on.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The region configuration for the build.
    /// </summary>
    public List<BuildRegion>? RegionConfigurations { get; set; }
    /// <summary>
    /// The type of game server being hosted.
    /// </summary>
    public string? ServerType { get; set; }
    /// <summary>
    /// The command to run when the multiplayer server is started, including any arguments. The path to any executable is
    /// relative to the root asset folder when unzipped.
    /// </summary>
    public string? StartMultiplayerServerCommand { get; set; }
    /// <summary>
    /// When true, assets will be downloaded and uncompressed in memory, without the compressedversion being written first to
    /// disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript feature for the build
    /// </summary>
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Request to create a lobby. A Server or client can create a lobby.
/// </summary>
public class CreateLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The policy indicating who is allowed to join the lobby, and the visibility to queries. May be 'Public', 'Friends' or
    /// 'Private'. Public means the lobby is both visible in queries and any player may join, including invited players.
    /// Friends means that users who are bidirectional friends of members in the lobby may search to find friend lobbies, to
    /// retrieve its connection string. Private means the lobby is not visible in queries, and a player must receive an
    /// invitation to join. Defaults to 'Public' on creation. Can only be changed by the lobby owner.
    /// </summary>
    public AccessPolicy? AccessPolicy { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The private key-value pairs which are visible to all entities in the lobby. At most 30 key-value pairs may be stored
    /// here, keys are limited to 30 characters and values to 1000. The total size of all lobbyData values may not exceed 4096
    /// bytes. Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? LobbyData { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby. The value must be between 2 and 128.
    /// </summary>
    public uint MaxPlayers { get; set; }
    /// <summary>
    /// The member initially added to the lobby. Client must specify exactly one member, which is the creator's entity and
    /// member data. Member PubSubConnectionHandle must be null or empty. Game servers must not specify any members.
    /// </summary>
    public List<Member>? Members { get; set; }
    /// <summary>
    /// The lobby owner. Must be the calling entity.
    /// </summary>
    public required EntityKey Owner { get; set; }
    /// <summary>
    /// The policy for how a new owner is chosen. May be 'Automatic', 'Manual' or 'None'. Can only be specified by clients. If
    /// client-owned and 'Automatic' - The Lobby service will automatically assign another connected owner when the current
    /// owner leaves or disconnects. The useConnections property must be true. If client - owned and 'Manual' - Ownership is
    /// protected as long as the current owner is connected. If the current owner leaves or disconnects any member may set
    /// themselves as the current owner. The useConnections property must be true. If client-owned and 'None' - Any member can
    /// set ownership. The useConnections property can be either true or false.
    /// </summary>
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    /// <summary>
    /// A setting that controls whether only the lobby owner can send invites to join the lobby. When true, only the lobby
    /// owner can send invites. When false or not specified, any member can send invites. Defaults to false if not specified.
    /// Restricted to client owned lobbies.
    /// </summary>
    public bool RestrictInvitesToLobbyOwner { get; set; }
    /// <summary>
    /// The public key-value pairs which allow queries to differentiate between lobbies. Queries will refer to these key-value
    /// pairs in their filter and order by clauses to retrieve lobbies fitting the specified criteria. At most 30 key-value
    /// pairs may be stored here. Keys are of the format string_key1, string_key2 ... string_key30 for string values, or
    /// number_key1, number_key2, ... number_key30 for numeric values.Numeric values are floats. Values can be at most 256
    /// characters long. The total size of all searchData values may not exceed 1024 bytes.
    /// </summary>
    public Dictionary<string, string>? SearchData { get; set; }
    /// <summary>
    /// A setting to control whether connections are used. Defaults to true. When true, notifications are sent to subscribed
    /// players, disconnect detection removes connectionHandles, only owner migration policies using connections are allowed,
    /// and lobbies must have at least one connected member to be searchable or be a server hosted lobby with a connected
    /// server. If false, then notifications are not sent, connections are not allowed, and lobbies do not need connections to
    /// be searchable.
    /// </summary>
    public bool UseConnections { get; set; }
}

public class CreateLobbyResult : PlayFabResultCommon {
    /// <summary>
    /// A field which indicates which lobby the user will be joining.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// Id to uniquely identify a lobby.
    /// </summary>
    public required string LobbyId { get; set; }
}

/// <summary>
/// The client specifies the creator's attributes and optionally a list of other users to match with.
/// </summary>
public class CreateMatchmakingTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The User who created this ticket.
    /// </summary>
    public required MatchmakingPlayer Creator { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// How long to attempt matching this ticket in seconds.
    /// </summary>
    public int GiveUpAfterSeconds { get; set; }
    /// <summary>
    /// A list of Entity Keys of other users to match with.
    /// </summary>
    public List<EntityKey>? MembersToMatchWith { get; set; }
    /// <summary>
    /// The Id of a match queue.
    /// </summary>
    public required string QueueName { get; set; }
}

public class CreateMatchmakingTicketResult : PlayFabResultCommon {
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

/// <summary>
/// Creates a remote user to log on to a VM for a multiplayer server build in a specific region. Returns user credential
/// information necessary to log on.
/// </summary>
public class CreateRemoteUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of to create the remote user for.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The expiration time for the remote user created. Defaults to expiring in one day if not specified.
    /// </summary>
    public DateTime? ExpirationTime { get; set; }
    /// <summary>
    /// The region of virtual machine to create the remote user for.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// The username to create the remote user with.
    /// </summary>
    public required string Username { get; set; }
    /// <summary>
    /// The virtual machine ID the multiplayer server is located on.
    /// </summary>
    public required string VmId { get; set; }
}

public class CreateRemoteUserResponse : PlayFabResultCommon {
    /// <summary>
    /// The expiration time for the remote user created.
    /// </summary>
    public DateTime? ExpirationTime { get; set; }
    /// <summary>
    /// The generated password for the remote user that was created.
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// The username for the remote user that was created.
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// Request to create a scenario. A Title can make this request.
/// </summary>
public class CreateScenarioRequest : PlayFabRequestCommon {
    /// <summary>
    /// A dictionary of allowed condition keys and the allowed condition values for each.
    /// </summary>
    public List<ScenarioConfigCondition>? Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// List of strings that represents all the events that are allowed to be present in a MatchResult.
    /// </summary>
    public List<string>? Events { get; set; }
    /// <summary>
    /// The name of the scenario to create.
    /// </summary>
    public required string Name { get; set; }
}

public class CreateScenarioResponse : PlayFabResultCommon {
    /// <summary>
    /// The id of the scenario that was created.
    /// </summary>
    public string? ScenarioId { get; set; }
}

/// <summary>
/// The server specifies all the members, their teams and their attributes, and the server details if applicable.
/// </summary>
public class CreateServerBackfillTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// How long to attempt matching this ticket in seconds.
    /// </summary>
    public int GiveUpAfterSeconds { get; set; }
    /// <summary>
    /// The users who will be part of this ticket, along with their team assignments.
    /// </summary>
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    /// <summary>
    /// The Id of a match queue.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The details of the server the members are connected to.
    /// </summary>
    public ServerDetails? ServerDetails { get; set; }
}

public class CreateServerBackfillTicketResult : PlayFabResultCommon {
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

/// <summary>
/// The server specifies all the members and their attributes.
/// </summary>
public class CreateServerMatchmakingTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// How long to attempt matching this ticket in seconds.
    /// </summary>
    public int GiveUpAfterSeconds { get; set; }
    /// <summary>
    /// The users who will be part of this ticket.
    /// </summary>
    public required List<MatchmakingPlayer> Members { get; set; }
    /// <summary>
    /// The Id of a match queue.
    /// </summary>
    public required string QueueName { get; set; }
}

/// <summary>
/// Creates a request to change a title's multiplayer server quotas.
/// </summary>
public class CreateTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon {
    /// <summary>
    /// A brief description of the requested changes.
    /// </summary>
    public string? ChangeDescription { get; set; }
    /// <summary>
    /// Changes to make to the titles cores quota.
    /// </summary>
    public required List<CoreCapacityChange> Changes { get; set; }
    /// <summary>
    /// Email to be contacted by our team about this request. Only required when a request is not approved.
    /// </summary>
    public string? ContactEmail { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Additional information about this request that our team can use to better understand the requirements.
    /// </summary>
    public string? Notes { get; set; }
    /// <summary>
    /// When these changes would need to be in effect. Only required when a request is not approved.
    /// </summary>
    public DateTime? StartDate { get; set; }
}

public class CreateTitleMultiplayerServersQuotaChangeResponse : PlayFabResultCommon {
    /// <summary>
    /// Id of the change request that was created.
    /// </summary>
    public string? RequestId { get; set; }
    /// <summary>
    /// Determines if the request was approved or not. When false, our team is reviewing and may respond within 2 business days.
    /// </summary>
    public bool WasApproved { get; set; }
}

public class CurrentServerStats {
    /// <summary>
    /// The number of active multiplayer servers.
    /// </summary>
    public int Active { get; set; }
    /// <summary>
    /// The number of multiplayer servers still downloading game resources (such as assets).
    /// </summary>
    public int Propping { get; set; }
    /// <summary>
    /// The number of standingby multiplayer servers.
    /// </summary>
    public int StandingBy { get; set; }
    /// <summary>
    /// The total number of multiplayer servers.
    /// </summary>
    public int Total { get; set; }
}

public class CustomDifferenceRuleExpansion {
    /// <summary>
    /// Manually specify the values to use for each expansion interval (this overrides Difference, Delta, and MaxDifference).
    /// </summary>
    public required List<OverrideDouble> DifferenceOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class CustomRegionSelectionRuleExpansion {
    /// <summary>
    /// Manually specify the maximum latency to use for each expansion interval.
    /// </summary>
    public required List<OverrideUnsignedInt> MaxLatencyOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class CustomSetIntersectionRuleExpansion {
    /// <summary>
    /// Manually specify the values to use for each expansion interval.
    /// </summary>
    public required List<OverrideUnsignedInt> MinIntersectionSizeOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class CustomTeamDifferenceRuleExpansion {
    /// <summary>
    /// Manually specify the team difference value to use for each expansion interval.
    /// </summary>
    public required List<OverrideDouble> DifferenceOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class CustomTeamSizeBalanceRuleExpansion {
    /// <summary>
    /// Manually specify the team size difference to use for each expansion interval.
    /// </summary>
    public required List<OverrideUnsignedInt> DifferenceOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

/// <summary>
/// Request to deactivate a model. A Title can make this request.
/// </summary>
public class DeactivateModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of model that will be deactivated.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// The ID of the scenario for the model to deactivate.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class DeactivateModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a multiplayer server game asset for a title.
/// </summary>
public class DeleteAssetRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The filename of the asset to delete.
    /// </summary>
    public required string FileName { get; set; }
}

/// <summary>
/// Deletes a multiplayer server build alias.
/// </summary>
public class DeleteBuildAliasRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string alias ID of the alias to perform the action on.
    /// </summary>
    public required string AliasId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Removes a multiplayer server build's region.
/// </summary>
public class DeleteBuildRegionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string ID of the build we want to update regions for.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The build region to delete.
    /// </summary>
    public required string Region { get; set; }
}

/// <summary>
/// Deletes a multiplayer server build.
/// </summary>
public class DeleteBuildRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the build to delete.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Deletes a multiplayer server game certificate.
/// </summary>
public class DeleteCertificateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the certificate.
    /// </summary>
    public required string Name { get; set; }
}

/// <summary>
/// Removes the specified container image repository. After this operation, a 'docker pull' will fail for all the tags of
/// the specified image. Morever, ListContainerImages will not return the specified image.
/// </summary>
public class DeleteContainerImageRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The container image repository we want to delete.
    /// </summary>
    public string? ImageName { get; set; }
}

/// <summary>
/// Request to delete a lobby. Only servers can delete lobbies.
/// </summary>
public class DeleteLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
}

/// <summary>
/// Request to delete a model. A Title can make this request.
/// </summary>
public class DeleteModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the model to be deleted.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// The ID of the scenario for the model to delete.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class DeleteModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a remote user to log on to a VM for a multiplayer server build in a specific region. Returns user credential
/// information necessary to log on.
/// </summary>
public class DeleteRemoteUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the multiplayer server where the remote user is to delete.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region of the multiplayer server where the remote user is to delete.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// The username of the remote user to delete.
    /// </summary>
    public required string Username { get; set; }
    /// <summary>
    /// The virtual machine ID the multiplayer server is located on.
    /// </summary>
    public required string VmId { get; set; }
}

/// <summary>
/// Request to delete a scenario configuration. A Title can make this request.
/// </summary>
public class DeleteScenarioRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If this flag is specified, the scenario will be deleted even if it contains models, as long as they are in either a
    /// failed, cancelled, or deactivated state.
    /// </summary>
    public bool ForceDelete { get; set; }
    /// <summary>
    /// The Scenario ID of the scenario to be deleted.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class DeleteScenarioResponse : PlayFabResultCommon {
}

/// <summary>
/// Deletes a multiplayer server game secret.
/// </summary>
public class DeleteSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the secret.
    /// </summary>
    public required string Name { get; set; }
}

public class DifferenceRule {
    /// <summary>
    /// Description of the attribute used by this rule to match tickets.
    /// </summary>
    public required QueueRuleAttribute Attribute { get; set; }
    /// <summary>
    /// Describes the behavior when an attribute is not specified in the ticket creation request or in the user's entity
    /// profile.
    /// </summary>
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule. When
    /// this is set, Difference is ignored.
    /// </summary>
    public CustomDifferenceRuleExpansion? CustomExpansion { get; set; }
    /// <summary>
    /// The default value assigned to tickets that are missing the attribute specified by AttributePath (assuming that
    /// AttributeNotSpecifiedBehavior is false). Optional.
    /// </summary>
    public double? DefaultAttributeValue { get; set; }
    /// <summary>
    /// The allowed difference between any two tickets at the start of matchmaking.
    /// </summary>
    public required double Difference { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule.
    /// </summary>
    public LinearDifferenceRuleExpansion? LinearExpansion { get; set; }
    /// <summary>
    /// How values are treated when there are multiple players in a single ticket.
    /// </summary>
    public AttributeMergeFunction MergeFunction { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
    /// <summary>
    /// The relative weight of this rule compared to others.
    /// </summary>
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
    /// <summary>
    /// List of auto standing by trigger values and corresponding standing by multiplier. Defaults to 1.5X at 50%, 3X at 25%,
    /// and 4X at 5%
    /// </summary>
    public List<DynamicStandbyThreshold>? DynamicFloorMultiplierThresholds { get; set; }
    /// <summary>
    /// When true, dynamic standby will be enabled
    /// </summary>
    public bool IsEnabled { get; set; }
    /// <summary>
    /// The time it takes to reduce target standing by to configured floor value after an increase. Defaults to 30 minutes
    /// </summary>
    public int? RampDownSeconds { get; set; }
}

public class DynamicStandbyThreshold {
    /// <summary>
    /// When the trigger threshold is reached, multiply by this value
    /// </summary>
    public required double Multiplier { get; set; }
    /// <summary>
    /// The multiplier will be applied when the actual standby divided by target standby floor is less than this value
    /// </summary>
    public required double TriggerThresholdPercentage { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Enables the multiplayer server feature for a title and returns the enabled status. The enabled status can be
/// Initializing, Enabled, and Disabled. It can up to 20 minutes or more for the title to be enabled for the feature. On
/// average, it can take up to 20 minutes for the title to be enabled for the feature.
/// </summary>
public class EnableMultiplayerServersForTitleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class EnableMultiplayerServersForTitleResponse : PlayFabResultCommon {
    /// <summary>
    /// The enabled status for the multiplayer server features for the title.
    /// </summary>
    public TitleMultiplayerServerEnabledStatus? Status { get; set; }
}

/// <summary>
/// Enables the parties feature for a title.
/// </summary>
public class EnablePartiesForTitleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    /// <summary>
    /// Unique ID of the entity.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Entity type. See https://docs.microsoft.com/gaming/playfab/features/data/entities/available-built-in-entity-types
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Alternate name for Type.
    /// </summary>
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
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Controls whether this query should link to friends made on the Facebook network. Defaults to false
    /// </summary>
    public bool? ExcludeFacebookFriends { get; set; }
    /// <summary>
    /// Controls whether this query should link to friends made on the Steam network. Defaults to false
    /// </summary>
    public bool? ExcludeSteamFriends { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends this query should link to.
    /// </summary>
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    /// <summary>
    /// OData style string that contains one or more filters. Only the following operators are supported: "and" (logical and),
    /// "eq" (equal), "ne" (not equals), "ge" (greater than or equal), "gt" (greater than), "le" (less than or equal), and "lt"
    /// (less than). The left-hand side of each OData logical expression should be either a search property key (e.g.
    /// string_key1, number_key3, etc) or one of the pre-defined search keys all of which must be prefixed by "lobby/":
    /// lobby/memberCount (number of players in a lobby), lobby/maxMemberCount (maximum number of players allowed in a lobby),
    /// lobby/memberCountRemaining (remaining number of players who can be allowed in a lobby), lobby/membershipLock (must
    /// equal 'Unlocked' or 'Locked'), lobby/amOwner (required to equal "true"), lobby/amMember (required to equal "true").
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// OData style string that contains sorting for this query in either ascending ("asc") or descending ("desc") order.
    /// OrderBy clauses are of the form "number_key1 asc" or the pre-defined search key "lobby/memberCount asc",
    /// "lobby/memberCountRemaining desc" and "lobby/maxMemberCount desc". To sort by closest, a moniker `distance{number_key1
    /// = 5}` can be used to sort by distance from the given number. This field only supports either one sort clause or one
    /// distance clause.
    /// </summary>
    public string? OrderBy { get; set; }
    /// <summary>
    /// Request pagination information.
    /// </summary>
    public PaginationRequest? Pagination { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

public class FindFriendLobbiesResult : PlayFabResultCommon {
    /// <summary>
    /// Array of lobbies found that matched FindFriendLobbies request.
    /// </summary>
    public required List<FriendLobbySummary> Lobbies { get; set; }
    /// <summary>
    /// Pagination response for FindFriendLobbies request.
    /// </summary>
    public required PaginationResponse Pagination { get; set; }
}

/// <summary>
/// Request to find lobbies.
/// </summary>
public class FindLobbiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// OData style string that contains one or more filters. Only the following operators are supported: "and" (logical and),
    /// "eq" (equal), "ne" (not equals), "ge" (greater than or equal), "gt" (greater than), "le" (less than or equal), and "lt"
    /// (less than). The left-hand side of each OData logical expression should be either a search property key (e.g.
    /// string_key1, number_key3, etc) or one of the pre-defined search keys all of which must be prefixed by "lobby/":
    /// lobby/memberCount (number of players in a lobby), lobby/maxMemberCount (maximum number of players allowed in a lobby),
    /// lobby/memberCountRemaining (remaining number of players who can be allowed in a lobby), lobby/membershipLock (must
    /// equal 'Unlocked' or 'Locked'), lobby/amOwner (required to equal "true"), lobby/amMember (required to equal "true").
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// OData style string that contains sorting for this query in either ascending ("asc") or descending ("desc") order.
    /// OrderBy clauses are of the form "number_key1 asc" or the pre-defined search key "lobby/memberCount asc",
    /// "lobby/memberCountRemaining desc" and "lobby/maxMemberCount desc". To sort by closest, a moniker `distance{number_key1
    /// = 5}` can be used to sort by distance from the given number. This field only supports either one sort clause or one
    /// distance clause.
    /// </summary>
    public string? OrderBy { get; set; }
    /// <summary>
    /// Request pagination information.
    /// </summary>
    public PaginationRequest? Pagination { get; set; }
}

public class FindLobbiesResult : PlayFabResultCommon {
    /// <summary>
    /// Array of lobbies found that matched FindLobbies request.
    /// </summary>
    public required List<LobbySummary> Lobbies { get; set; }
    /// <summary>
    /// Pagination response for FindLobbies request.
    /// </summary>
    public required PaginationResponse Pagination { get; set; }
}

public class FriendLobbySummary {
    /// <summary>
    /// A string used to join the lobby.This field is populated by the Lobby service.Invites are performed by communicating
    /// this connectionString to other players.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// The current number of players in the lobby.
    /// </summary>
    public uint CurrentPlayers { get; set; }
    /// <summary>
    /// Friends in Lobby.
    /// </summary>
    public List<EntityKey>? Friends { get; set; }
    /// <summary>
    /// Id to uniquely identify a lobby.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby.
    /// </summary>
    public uint MaxPlayers { get; set; }
    /// <summary>
    /// A setting indicating whether members are allowed to join this lobby. When Locked new members are prevented from joining.
    /// </summary>
    public MembershipLock? MembershipLock { get; set; }
    /// <summary>
    /// The client or server entity which owns this lobby.
    /// </summary>
    public required EntityKey Owner { get; set; }
    /// <summary>
    /// Search data.
    /// </summary>
    public Dictionary<string, string>? SearchData { get; set; }
}

public class GameCertificateReference {
    /// <summary>
    /// An alias for the game certificate. The game server will reference this alias via GSDK config to retrieve the game
    /// certificate. This alias is used as an identifier in game server code to allow a new certificate with different Name
    /// field to be uploaded without the need to change any game server code to reference the new Name.
    /// </summary>
    public string? GsdkAlias { get; set; }
    /// <summary>
    /// The name of the game certificate. This name should match the name of a certificate that was previously uploaded to this
    /// title.
    /// </summary>
    public string? Name { get; set; }
}

public class GameCertificateReferenceParams {
    /// <summary>
    /// An alias for the game certificate. The game server will reference this alias via GSDK config to retrieve the game
    /// certificate. This alias is used as an identifier in game server code to allow a new certificate with different Name
    /// field to be uploaded without the need to change any game server code to reference the new Name.
    /// </summary>
    public required string GsdkAlias { get; set; }
    /// <summary>
    /// The name of the game certificate. This name should match the name of a certificate that was previously uploaded to this
    /// title.
    /// </summary>
    public required string Name { get; set; }
}

public class GameSecretReference {
    /// <summary>
    /// The name of the game secret. This name should match the name of a secret that was previously added to this title.
    /// </summary>
    public string? Name { get; set; }
}

public class GameSecretReferenceParams {
    /// <summary>
    /// The name of the game secret. This name should match the name of a secret that was previously added to this title.
    /// </summary>
    public required string Name { get; set; }
}

/// <summary>
/// Gets a URL that can be used to download the specified asset.
/// </summary>
public class GetAssetDownloadUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The asset's file name to get the download URL for.
    /// </summary>
    public required string FileName { get; set; }
}

public class GetAssetDownloadUrlResponse : PlayFabResultCommon {
    /// <summary>
    /// The asset's download URL.
    /// </summary>
    public string? AssetDownloadUrl { get; set; }
    /// <summary>
    /// The asset's file name to get the download URL for.
    /// </summary>
    public string? FileName { get; set; }
}

/// <summary>
/// Gets the URL to upload assets to.
/// </summary>
public class GetAssetUploadUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The asset's file name to get the upload URL for.
    /// </summary>
    public required string FileName { get; set; }
}

public class GetAssetUploadUrlResponse : PlayFabResultCommon {
    /// <summary>
    /// The asset's upload URL.
    /// </summary>
    public string? AssetUploadUrl { get; set; }
    /// <summary>
    /// The asset's file name to get the upload URL for.
    /// </summary>
    public string? FileName { get; set; }
}

/// <summary>
/// Returns the details about a multiplayer server build alias.
/// </summary>
public class GetBuildAliasRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string alias ID of the alias to perform the action on.
    /// </summary>
    public required string AliasId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Returns the details about a multiplayer server build.
/// </summary>
public class GetBuildRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the build to get.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetBuildResponse : PlayFabResultCommon {
    /// <summary>
    /// When true, assets will not be copied for each server inside the VM. All serverswill run from the same set of assets, or
    /// will have the same assets mounted in the container.
    /// </summary>
    public bool? AreAssetsReadonly { get; set; }
    /// <summary>
    /// The guid string build ID of the build.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public string? BuildName { get; set; }
    /// <summary>
    /// The current build status. Valid values are - Deploying, Deployed, DeletingRegion, Unhealthy.
    /// </summary>
    public string? BuildStatus { get; set; }
    /// <summary>
    /// The flavor of container of he build.
    /// </summary>
    public ContainerFlavor? ContainerFlavor { get; set; }
    /// <summary>
    /// The container command to run when the multiplayer server has been allocated, including any arguments. This only applies
    /// to custom builds. If the build is a managed build, this field will be null.
    /// </summary>
    public string? ContainerRunCommand { get; set; }
    /// <summary>
    /// The time the build was created in UTC.
    /// </summary>
    public DateTime? CreationTime { get; set; }
    /// <summary>
    /// The custom game container image for a custom build.
    /// </summary>
    public ContainerImageReference? CustomGameContainerImage { get; set; }
    /// <summary>
    /// The game assets for the build.
    /// </summary>
    public List<AssetReference>? GameAssetReferences { get; set; }
    /// <summary>
    /// The game certificates for the build.
    /// </summary>
    public List<GameCertificateReference>? GameCertificateReferences { get; set; }
    /// <summary>
    /// The instrumentation configuration of the build.
    /// </summary>
    public InstrumentationConfiguration? InstrumentationConfiguration { get; set; }
    /// <summary>
    /// Metadata of the build. The keys are case insensitive. The build metadata is made available to the server through Game
    /// Server SDK (GSDK).
    /// </summary>
    public Dictionary<string, string>? Metadata { get; set; }
    /// <summary>
    /// The number of multiplayer servers to hosted on a single VM of the build.
    /// </summary>
    public int MultiplayerServerCountPerVm { get; set; }
    /// <summary>
    /// The OS platform used for running the game process.
    /// </summary>
    public string? OsPlatform { get; set; }
    /// <summary>
    /// The ports the build is mapped on.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The region configuration for the build.
    /// </summary>
    public List<BuildRegion>? RegionConfigurations { get; set; }
    /// <summary>
    /// The resource constraints to apply to each server on the VM.
    /// </summary>
    public ServerResourceConstraintParams? ServerResourceConstraints { get; set; }
    /// <summary>
    /// The type of game server being hosted.
    /// </summary>
    public string? ServerType { get; set; }
    /// <summary>
    /// The command to run when the multiplayer server has been allocated, including any arguments. This only applies to
    /// managed builds. If the build is a custom build, this field will be null.
    /// </summary>
    public string? StartMultiplayerServerCommand { get; set; }
    /// <summary>
    /// When true, assets will be downloaded and uncompressed in memory, without the compressedversion being written first to
    /// disc.
    /// </summary>
    public bool? UseStreamingForAssetDownloads { get; set; }
    /// <summary>
    /// The VM size the build was created on.
    /// </summary>
    public AzureVmSize? VmSize { get; set; }
    /// <summary>
    /// The configuration for the VmStartupScript feature for the build
    /// </summary>
    public VmStartupScriptConfiguration? VmStartupScriptConfiguration { get; set; }
}

/// <summary>
/// Gets supported locales for the cognitive services where translation queries can be sent to.
/// </summary>
public class GetCognitiveServicesLocalesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The type of the cognitive service for which locales are being requested.
    /// </summary>
    public CognitiveServicesType CognitiveServicesType { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region the client is closest to (A service endpoint will be provided for this region or one nearest one available).
    /// </summary>
    public required string Region { get; set; }
}

public class GetCognitiveServicesLocalesResponse : PlayFabResultCommon {
    /// <summary>
    /// The locales for the cognitive service.
    /// </summary>
    public List<CognitiveServicesLocale>? Locales { get; set; }
}

/// <summary>
/// Gets a token for the cognitive services where translation queries can be sent to.
/// </summary>
public class GetCognitiveServicesTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The type of the cognitive service for which a token is being requested.
    /// </summary>
    public CognitiveServicesType CognitiveServicesType { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region the client is closest to (A service endpoint will be provided for this region or one nearest one available).
    /// </summary>
    public required string Region { get; set; }
}

public class GetCognitiveServicesTokenResponse : PlayFabResultCommon {
    /// <summary>
    /// Token expiration time.
    /// </summary>
    public DateTime? ExpirationTimeUtc { get; set; }
    /// <summary>
    /// The url for the service where further requests can be made with the given token.
    /// </summary>
    public string? ServiceEndpoint { get; set; }
    /// <summary>
    /// The token for the cognitive service.
    /// </summary>
    public string? Token { get; set; }
}

/// <summary>
/// Gets credentials to the container registry where game developers can upload custom container images to before creating
/// a new build.
/// </summary>
public class GetContainerRegistryCredentialsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetContainerRegistryCredentialsResponse : PlayFabResultCommon {
    /// <summary>
    /// The url of the container registry.
    /// </summary>
    public string? DnsName { get; set; }
    /// <summary>
    /// The password for accessing the container registry.
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// The username for accessing the container registry.
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// Request to get a lobby.
/// </summary>
public class GetLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
}

public class GetLobbyResult : PlayFabResultCommon {
    /// <summary>
    /// The information pertaining to the requested lobby.
    /// </summary>
    public required Lobby Lobby { get; set; }
}

/// <summary>
/// Gets the current configuration for a queue.
/// </summary>
public class GetMatchmakingQueueRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The Id of the matchmaking queue to retrieve.
    /// </summary>
    public string? QueueName { get; set; }
}

public class GetMatchmakingQueueResult : PlayFabResultCommon {
    /// <summary>
    /// The matchmaking queue config.
    /// </summary>
    public MatchmakingQueueConfig? MatchmakingQueue { get; set; }
}

/// <summary>
/// The ticket includes the invited players, their attributes if they have joined, the ticket status, the match Id when
/// applicable, etc. Only servers, the ticket creator and the invited players can get the ticket.
/// </summary>
public class GetMatchmakingTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Determines whether the matchmaking attributes will be returned as an escaped JSON string or as an un-escaped JSON
    /// object.
    /// </summary>
    public bool EscapeObject { get; set; }
    /// <summary>
    /// The name of the queue to find a match for.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

public class GetMatchmakingTicketResult : PlayFabResultCommon {
    /// <summary>
    /// The reason why the current ticket was canceled. This field is only set if the ticket is in canceled state.
    /// </summary>
    public CancellationReason? CancellationReason { get; set; }
    /// <summary>
    /// The reason why the current ticket was canceled. This field is only set if the ticket is in canceled state. Please retry
    /// if CancellationReason is RetryRequired.
    /// </summary>
    public string? CancellationReasonString { get; set; }
    /// <summary>
    /// Change number used for differentiating older matchmaking status updates from newer ones.
    /// </summary>
    public uint? ChangeNumber { get; set; }
    /// <summary>
    /// The server date and time at which ticket was created.
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The Creator's entity key.
    /// </summary>
    public required EntityKey Creator { get; set; }
    /// <summary>
    /// How long to attempt matching this ticket in seconds.
    /// </summary>
    public int GiveUpAfterSeconds { get; set; }
    /// <summary>
    /// The Id of a match.
    /// </summary>
    public string? MatchId { get; set; }
    /// <summary>
    /// A list of Users that have joined this ticket.
    /// </summary>
    public required List<MatchmakingPlayer> Members { get; set; }
    /// <summary>
    /// A list of PlayFab Ids of Users to match with.
    /// </summary>
    public List<EntityKey>? MembersToMatchWith { get; set; }
    /// <summary>
    /// The Id of a match queue.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The current ticket status. Possible values are: WaitingForPlayers, WaitingForMatch, WaitingForServer, Canceled and
    /// Matched.
    /// </summary>
    public required string Status { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

/// <summary>
/// When matchmaking has successfully matched together a collection of tickets, it produces a 'match' with an Id. The match
/// contains all of the players that were matched together, and their team assigments. Only servers and ticket members can
/// get the match.
/// </summary>
public class GetMatchRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Determines whether the matchmaking attributes will be returned as an escaped JSON string or as an un-escaped JSON
    /// object.
    /// </summary>
    public bool EscapeObject { get; set; }
    /// <summary>
    /// The Id of a match.
    /// </summary>
    public required string MatchId { get; set; }
    /// <summary>
    /// The name of the queue to join.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// Determines whether the matchmaking attributes for each user should be returned in the response for match request.
    /// </summary>
    public bool ReturnMemberAttributes { get; set; }
}

public class GetMatchResult : PlayFabResultCommon {
    /// <summary>
    /// A string that is used by players that are matched together to join an arranged lobby.
    /// </summary>
    public string? ArrangementString { get; set; }
    /// <summary>
    /// The Id of a match.
    /// </summary>
    public required string MatchId { get; set; }
    /// <summary>
    /// A list of Users that are matched together, along with their team assignments.
    /// </summary>
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    /// <summary>
    /// A list of regions that the match could be played in sorted by preference. This value is only set if the queue has a
    /// region selection rule.
    /// </summary>
    public List<string>? RegionPreferences { get; set; }
    /// <summary>
    /// The details of the server that the match has been allocated to.
    /// </summary>
    public ServerDetails? ServerDetails { get; set; }
}

/// <summary>
/// Request to get the details of a model of a scenario. A Title can make this request.
/// </summary>
public class GetModelDetailsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the Model we want to retrieve details for.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// The ID of the Scenario that the requested model belongs to.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetModelDetailsResponse : PlayFabResultCommon {
    /// <summary>
    /// The details of the Model that was requested.
    /// </summary>
    public ModelDetails? ModelDetails { get; set; }
}

/// <summary>
/// Request to get models for a specific scenario. A Title can make this request.
/// </summary>
public class GetModelsByScenarioRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the scenario to get the model.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetModelsByScenarioResponse : PlayFabResultCommon {
    /// <summary>
    /// The model result based on the given scenario.
    /// </summary>
    public List<ModelSummary>? Models { get; set; }
}

/// <summary>
/// Gets multiplayer server session details as well as the associated user connection tokens for a build in a specific
/// region.
/// </summary>
public class GetMultiplayerServerAndTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The title generated guid string session ID of the multiplayer server to get details for. This is to keep track of
    /// multiplayer server sessions.
    /// </summary>
    public required string SessionId { get; set; }
    /// <summary>
    /// List of players for which to get tokens.
    /// </summary>
    public required List<string> TokenPlayerIds { get; set; }
}

public class GetMultiplayerServerAndTokenResponse : PlayFabResultCommon {
    /// <summary>
    /// The identity of the build in which the server was allocated.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The connected players in the multiplayer server.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? FQDN { get; set; }
    /// <summary>
    /// The public IPv4 address of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the multiplayer server state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// A set of tokens that can be used to connect to the server. Tokens match the requested user ids
    /// </summary>
    public List<PlayerToken>? PlayerTokens { get; set; }
    /// <summary>
    /// The ports the multiplayer server uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The list of public Ipv4 addresses associated with the server.
    /// </summary>
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    /// <summary>
    /// The region the multiplayer server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The guid string session ID of the multiplayer server.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// The state of the multiplayer server.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the multiplayer server is located on.
    /// </summary>
    public string? VmId { get; set; }
}

/// <summary>
/// Gets multiplayer server session details for a build in a specific region.
/// </summary>
public class GetMultiplayerServerDetailsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The title generated guid string session ID of the multiplayer server to get details for. This is to keep track of
    /// multiplayer server sessions.
    /// </summary>
    public required string SessionId { get; set; }
}

public class GetMultiplayerServerDetailsResponse : PlayFabResultCommon {
    /// <summary>
    /// The identity of the build in which the server was allocated.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The connected players in the multiplayer server.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? FQDN { get; set; }
    /// <summary>
    /// The public IPv4 address of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the multiplayer server state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// The ports the multiplayer server uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The list of public Ipv4 addresses associated with the server.
    /// </summary>
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    /// <summary>
    /// The region the multiplayer server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The guid string session ID of the multiplayer server.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// The state of the multiplayer server.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the multiplayer server is located on.
    /// </summary>
    public string? VmId { get; set; }
}

/// <summary>
/// Gets multiplayer server logs for a specific server id in a region. The logs are available only after a server has
/// terminated.
/// </summary>
public class GetMultiplayerServerLogsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region of the multiplayer server to get logs for.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The server ID of multiplayer server to get logs for.
    /// </summary>
    public required string ServerId { get; set; }
}

public class GetMultiplayerServerLogsResponse : PlayFabResultCommon {
    /// <summary>
    /// URL for logs download.
    /// </summary>
    public string? LogDownloadUrl { get; set; }
}

/// <summary>
/// Gets multiplayer server logs for a specific server id in a region. The logs are available only after a server has
/// terminated.
/// </summary>
public class GetMultiplayerSessionLogsBySessionIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The server ID of multiplayer server to get logs for.
    /// </summary>
    public required string SessionId { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for multiple sets of conditions from a specific model. A Title, Server
/// or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillForConditionsFromModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// A map from condition names to condition values in which to get the skills of the players.
    /// </summary>
    public required List<ConditionsSet> Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If set to true, TrueSkill will return the player's SkillBreakdown as part of the response.
    /// </summary>
    public bool IncludeSkillBreakdown { get; set; }
    /// <summary>
    /// ID of the model to get the players' skill from.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// List of players to retrieve skill values for.
    /// </summary>
    public required List<TrueSkillPlayer> Players { get; set; }
    /// <summary>
    /// ID of the scenario to get the players' skill from.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillForConditionsFromModelResponse : PlayFabResultCommon {
    /// <summary>
    /// If the specified model is marked as primary for the given scenario.
    /// </summary>
    public bool IsModelPrimary { get; set; }
    /// <summary>
    /// The skill values for the specified players in a given model.
    /// </summary>
    public List<PlayerSkills>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for multiple sets of conditions from the primary model of a given
/// scenario. A Title, Server or Client can request a player's skill.
/// </summary>
public class GetPlayerSkillForConditionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// A map from condition names to condition values in which to get the skills of the players.
    /// </summary>
    public required List<ConditionsSet> Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If set to true, TrueSkill will return the player's SkillBreakdown as part of the response.
    /// </summary>
    public bool IncludeSkillBreakdown { get; set; }
    /// <summary>
    /// List of players to retrieve skill values for.
    /// </summary>
    public required List<TrueSkillPlayer> Players { get; set; }
    /// <summary>
    /// ID of the scenario to get the players' skill from.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillForConditionsResponse : PlayFabResultCommon {
    /// <summary>
    /// ID of the Model where the skill values were retrieved from.
    /// </summary>
    public string? ModelId { get; set; }
    /// <summary>
    /// The skill values for the specified players in the primary model of a given scenario.
    /// </summary>
    public List<PlayerSkills>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players for a specific model. A Title, Server or Client can request a player's
/// skill.
/// </summary>
public class GetPlayerSkillFromModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// A map from condition names to condition values in which to get the skills of the players.
    /// </summary>
    public Dictionary<string, string>? Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If set to true, TrueSkill will return the player's SkillBreakdown as part of the response.
    /// </summary>
    public bool IncludeSkillBreakdown { get; set; }
    /// <summary>
    /// ID of the model to get the players' skill from.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// List of players to retrieve skill values for.
    /// </summary>
    public required List<TrueSkillPlayer> Players { get; set; }
    /// <summary>
    /// ID of the scenario to get the players' skill from.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillFromModelResponse : PlayFabResultCommon {
    /// <summary>
    /// If the specified model is marked as primary for the given scenario.
    /// </summary>
    public bool IsModelPrimary { get; set; }
    /// <summary>
    /// The skill values for the specified players in a given model.
    /// </summary>
    public List<PlayerSkill>? Skills { get; set; }
}

/// <summary>
/// Request to get skill values of a set of players from the primary model of a given scenario. A Title, Server or Client
/// can request a player's skill.
/// </summary>
public class GetPlayerSkillRequest : PlayFabRequestCommon {
    /// <summary>
    /// A map from condition names to condition values in which to get the skills of the players.
    /// </summary>
    public Dictionary<string, string>? Conditions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If set to true, TrueSkill will return the player's SkillBreakdown as part of the response.
    /// </summary>
    public bool IncludeSkillBreakdown { get; set; }
    /// <summary>
    /// List of players to retrieve skill values for.
    /// </summary>
    public required List<TrueSkillPlayer> Players { get; set; }
    /// <summary>
    /// ID of the scenario to get the players' skill from.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetPlayerSkillResponse : PlayFabResultCommon {
    /// <summary>
    /// ID of the Model where the skill values were retrieved from.
    /// </summary>
    public string? ModelId { get; set; }
    /// <summary>
    /// The skill values for the specified players in the primary model of a given scenario.
    /// </summary>
    public List<PlayerSkill>? Skills { get; set; }
}

/// <summary>
/// Returns the matchmaking statistics for a queue. These include the number of players matching and the statistics related
/// to the time to match statistics in seconds (average and percentiles). Statistics are refreshed once every 5 minutes.
/// Servers can access all statistics no matter what the ClientStatisticsVisibility is configured to. Clients can access
/// statistics according to the ClientStatisticsVisibility. Client requests are forbidden if all visibility fields are
/// false.
/// </summary>
public class GetQueueStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the queue.
    /// </summary>
    public required string QueueName { get; set; }
}

public class GetQueueStatisticsResult : PlayFabResultCommon {
    /// <summary>
    /// The current number of players in the matchmaking queue, who are waiting to be matched.
    /// </summary>
    public uint? NumberOfPlayersMatching { get; set; }
    /// <summary>
    /// Statistics representing the time (in seconds) it takes for tickets to find a match.
    /// </summary>
    public Statistics? TimeToMatchStatisticsInSeconds { get; set; }
}

/// <summary>
/// Gets a remote login endpoint to a VM that is hosting a multiplayer server build in a specific region.
/// </summary>
public class GetRemoteLoginEndpointRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the multiplayer server to get remote login information for.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region of the multiplayer server to get remote login information for.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// The virtual machine ID the multiplayer server is located on.
    /// </summary>
    public required string VmId { get; set; }
}

public class GetRemoteLoginEndpointResponse : PlayFabResultCommon {
    /// <summary>
    /// The remote login IPV4 address of multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The remote login port of multiplayer server.
    /// </summary>
    public int Port { get; set; }
}

/// <summary>
/// Request to get a scenario configuration. A Title can make this request.
/// </summary>
public class GetScenarioConfigurationRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The Scenario ID of the given scenario.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class GetScenarioConfigurationResponse : PlayFabResultCommon {
    /// <summary>
    /// The requested Scenario Configuration.
    /// </summary>
    public ScenarioConfiguration? ScenarioConfiguration { get; set; }
}

/// <summary>
/// Request to get all scenario configurations of a title. A Title can make this request.
/// </summary>
public class GetScenarioConfigurationsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetScenarioConfigurationsResponse : PlayFabResultCommon {
    /// <summary>
    /// The Scenario Configurations of the title.
    /// </summary>
    public List<ScenarioConfiguration>? ScenarioConfigurations { get; set; }
}

/// <summary>
/// The ticket includes the players, their attributes, their teams, the ticket status, the match Id and the server details
/// when applicable, etc. Only servers can get the ticket.
/// </summary>
public class GetServerBackfillTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Determines whether the matchmaking attributes will be returned as an escaped JSON string or as an un-escaped JSON
    /// object.
    /// </summary>
    public bool EscapeObject { get; set; }
    /// <summary>
    /// The name of the queue to find a match for.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

public class GetServerBackfillTicketResult : PlayFabResultCommon {
    /// <summary>
    /// The reason why the current ticket was canceled. This field is only set if the ticket is in canceled state.
    /// </summary>
    public CancellationReason? CancellationReason { get; set; }
    /// <summary>
    /// The reason why the current ticket was canceled. This field is only set if the ticket is in canceled state.
    /// </summary>
    public string? CancellationReasonString { get; set; }
    /// <summary>
    /// The server date and time at which ticket was created.
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// How long to attempt matching this ticket in seconds.
    /// </summary>
    public int GiveUpAfterSeconds { get; set; }
    /// <summary>
    /// The Id of a match.
    /// </summary>
    public string? MatchId { get; set; }
    /// <summary>
    /// A list of Users that are part of this ticket, along with their team assignments.
    /// </summary>
    public required List<MatchmakingPlayerWithTeamAssignment> Members { get; set; }
    /// <summary>
    /// The Id of a match queue.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The details of the server the members are connected to.
    /// </summary>
    public required ServerDetails ServerDetails { get; set; }
    /// <summary>
    /// The current ticket status. Possible values are: WaitingForMatch, Canceled and Matched.
    /// </summary>
    public required string Status { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

/// <summary>
/// Gets the status of whether a title is enabled for the multiplayer server feature. The enabled status can be
/// Initializing, Enabled, and Disabled.
/// </summary>
public class GetTitleEnabledForMultiplayerServersStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetTitleEnabledForMultiplayerServersStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// The enabled status for the multiplayer server features for the title.
    /// </summary>
    public TitleMultiplayerServerEnabledStatus? Status { get; set; }
}

/// <summary>
/// Gets a title's server quota change request.
/// </summary>
public class GetTitleMultiplayerServersQuotaChangeRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Id of the change request to get.
    /// </summary>
    public required string RequestId { get; set; }
}

public class GetTitleMultiplayerServersQuotaChangeResponse : PlayFabResultCommon {
    /// <summary>
    /// The change request for this title.
    /// </summary>
    public QuotaChange? Change { get; set; }
}

/// <summary>
/// Gets the quotas for a title in relation to multiplayer servers.
/// </summary>
public class GetTitleMultiplayerServersQuotasRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetTitleMultiplayerServersQuotasResponse : PlayFabResultCommon {
    /// <summary>
    /// The various quotas for multiplayer servers for the title.
    /// </summary>
    public TitleMultiplayerServersQuotas? Quotas { get; set; }
}

public class InstrumentationConfiguration {
    /// <summary>
    /// Designates whether windows instrumentation configuration will be enabled for this Build
    /// </summary>
    public bool? IsEnabled { get; set; }
    /// <summary>
    /// This property is deprecated, use IsEnabled. The list of processes to be monitored on a VM for this build. Providing
    /// processes will turn on performance metrics collection for this build. Process names should not include extensions. If
    /// the game server process is: GameServer.exe; then, ProcessesToMonitor = [ GameServer ]
    /// </summary>
    public List<string>? ProcessesToMonitor { get; set; }
}

/// <summary>
/// Request to invite a player to a lobby the caller is already a member of. Only a client can invite another player to a
/// lobby.
/// </summary>
public class InviteToLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity invited to the lobby.
    /// </summary>
    public EntityKey? InviteeEntity { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// The member entity sending the invite. Must be a member of the lobby.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
}

/// <summary>
/// Request to join an arranged lobby. Only a client can join an arranged lobby.
/// </summary>
public class JoinArrangedLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The policy indicating who is allowed to join the lobby, and the visibility to queries. May be 'Public', 'Friends' or
    /// 'Private'. Public means the lobby is both visible in queries and any player may join, including invited players.
    /// Friends means that users who are bidirectional friends of members in the lobby may search to find friend lobbies, to
    /// retrieve its connection string. Private means the lobby is not visible in queries, and a player must receive an
    /// invitation to join. Defaults to 'Public' on creation. Can only be changed by the lobby owner.
    /// </summary>
    public AccessPolicy? AccessPolicy { get; set; }
    /// <summary>
    /// A field which indicates which lobby the user will be joining. This field is opaque to everyone except the Lobby service
    /// and the creator of the arrangementString (Matchmaking). This string defines a unique identifier for the arranged lobby
    /// as well as the title and member the string is valid for. Arrangement strings have an expiration.
    /// </summary>
    public required string ArrangementString { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby. The value must be between 2 and 128.
    /// </summary>
    public uint MaxPlayers { get; set; }
    /// <summary>
    /// The private key-value pairs used by the member to communicate information to other members and the owner. Visible to
    /// all entities in the lobby. At most 30 key-value pairs may be stored here, keys are limited to 30 characters and values
    /// to 1000. The total size of all memberData values may not exceed 4096 bytes. Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? MemberData { get; set; }
    /// <summary>
    /// The member entity who is joining the lobby. The first member to join will be the lobby owner.
    /// </summary>
    public required EntityKey MemberEntity { get; set; }
    /// <summary>
    /// The policy for how a new owner is chosen. May be 'Automatic', 'Manual' or 'None'. Can only be specified by clients. If
    /// client-owned and 'Automatic' - The Lobby service will automatically assign another connected owner when the current
    /// owner leaves or disconnects. The useConnections property must be true. If client - owned and 'Manual' - Ownership is
    /// protected as long as the current owner is connected. If the current owner leaves or disconnects any member may set
    /// themselves as the current owner. The useConnections property must be true. If client-owned and 'None' - Any member can
    /// set ownership. The useConnections property can be either true or false.
    /// </summary>
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    /// <summary>
    /// A setting that controls whether only the lobby owner can send invites to join the lobby. When true, only the lobby
    /// owner can send invites. When false or not specified, any member can send invites. Defaults to false if not specified.
    /// Restricted to client owned lobbies.
    /// </summary>
    public bool RestrictInvitesToLobbyOwner { get; set; }
    /// <summary>
    /// A setting to control whether connections are used. Defaults to true. When true, notifications are sent to subscribed
    /// players, disconnect detection removes connectionHandles, only owner migration policies using connections are allowed,
    /// and lobbies must have at least one connected member to be searchable or be a server hosted lobby with a connected
    /// server. If false, then notifications are not sent, connections are not allowed, and lobbies do not need connections to
    /// be searchable.
    /// </summary>
    public bool UseConnections { get; set; }
}

/// <summary>
/// Preview: Request to join a lobby as a server. Only callable by a game_server entity and this is restricted to client
/// owned lobbies which are using connections.
/// </summary>
public class JoinLobbyAsServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// A field which indicates which lobby the game_server will be joining. This field is opaque to everyone except the Lobby
    /// service.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The private key-value pairs which are visible to all entities in the lobby but can only be modified by the joined
    /// server.At most 30 key - value pairs may be stored here, keys are limited to 30 characters and values to 1000.The total
    /// size of all serverData values may not exceed 4096 bytes.
    /// </summary>
    public Dictionary<string, string>? ServerData { get; set; }
    /// <summary>
    /// The game_server entity which is joining the Lobby. If a different game_server entity has already joined the request
    /// will fail unless the joined entity is disconnected, in which case the incoming game_server entity will replace the
    /// disconnected entity.
    /// </summary>
    public required EntityKey ServerEntity { get; set; }
}

public class JoinLobbyAsServerResult : PlayFabResultCommon {
    /// <summary>
    /// Successfully joined lobby's id.
    /// </summary>
    public required string LobbyId { get; set; }
}

/// <summary>
/// Request to join a lobby. Only a client can join a lobby.
/// </summary>
public class JoinLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// A field which indicates which lobby the user will be joining. This field is opaque to everyone except the Lobby service.
    /// </summary>
    public string? ConnectionString { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The private key-value pairs used by the member to communicate information to other members and the owner. Visible to
    /// all entities in the lobby. At most 30 key-value pairs may be stored here, keys are limited to 30 characters and values
    /// to 1000. The total size of all memberData values may not exceed 4096 bytes.Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? MemberData { get; set; }
    /// <summary>
    /// The member entity who is joining the lobby.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
}

public class JoinLobbyResult : PlayFabResultCommon {
    /// <summary>
    /// Successfully joined lobby's id.
    /// </summary>
    public required string LobbyId { get; set; }
}

/// <summary>
/// Add the player to a matchmaking ticket and specify all of its matchmaking attributes. Players can join a ticket if and
/// only if their EntityKeys are already listed in the ticket's Members list. The matchmaking service automatically starts
/// matching the ticket against other matchmaking tickets once all players have joined the ticket. It is not possible to
/// join a ticket once it has started matching.
/// </summary>
public class JoinMatchmakingTicketRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The User who wants to join the ticket. Their Id must be listed in PlayFabIdsToMatchWith.
    /// </summary>
    public required MatchmakingPlayer Member { get; set; }
    /// <summary>
    /// The name of the queue to join.
    /// </summary>
    public required string QueueName { get; set; }
    /// <summary>
    /// The Id of the ticket to find a match for.
    /// </summary>
    public required string TicketId { get; set; }
}

public class JoinMatchmakingTicketResult : PlayFabResultCommon {
}

/// <summary>
/// Preview: Request for server to leave a lobby. Only a game_server entity can leave and this is restricted to client
/// owned lobbies which are using connections.
/// </summary>
public class LeaveLobbyAsServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// The game_server entity leaving the lobby. If the game_server was subscribed to notifications, it will be unsubscribed.
    /// If a the given game_server entity is not in the lobby, it will fail.
    /// </summary>
    public required EntityKey ServerEntity { get; set; }
}

/// <summary>
/// Request to leave a lobby. Only a client can leave a lobby.
/// </summary>
public class LeaveLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// The member entity leaving the lobby.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
}

public class LinearDifferenceRuleExpansion {
    /// <summary>
    /// This value gets added to Difference at every expansion interval.
    /// </summary>
    public required double Delta { get; set; }
    /// <summary>
    /// Once the total difference reaches this value, expansion stops. Optional.
    /// </summary>
    public double? Limit { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class LinearRegionSelectionRuleExpansion {
    /// <summary>
    /// This value gets added to MaxLatency at every expansion interval.
    /// </summary>
    public uint Delta { get; set; }
    /// <summary>
    /// Once the max Latency reaches this value, expansion stops.
    /// </summary>
    public uint Limit { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class LinearSetIntersectionRuleExpansion {
    /// <summary>
    /// This value gets added to MinIntersectionSize at every expansion interval.
    /// </summary>
    public uint Delta { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class LinearTeamDifferenceRuleExpansion {
    /// <summary>
    /// This value gets added to Difference at every expansion interval.
    /// </summary>
    public required double Delta { get; set; }
    /// <summary>
    /// Once the total difference reaches this value, expansion stops. Optional.
    /// </summary>
    public double? Limit { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class LinearTeamSizeBalanceRuleExpansion {
    /// <summary>
    /// This value gets added to Difference at every expansion interval.
    /// </summary>
    public uint Delta { get; set; }
    /// <summary>
    /// Once the total difference reaches this value, expansion stops. Optional.
    /// </summary>
    public uint? Limit { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class LinuxInstrumentationConfiguration {
    /// <summary>
    /// Designates whether Linux instrumentation configuration will be enabled for this Build
    /// </summary>
    public bool IsEnabled { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game asset summaries for a title.
/// </summary>
public class ListAssetSummariesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListAssetSummariesResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of asset summaries.
    /// </summary>
    public List<AssetSummary>? AssetSummaries { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of summarized details of all multiplayer server builds for a title.
/// </summary>
public class ListBuildAliasesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListBuildAliasesResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of build aliases for the title
    /// </summary>
    public List<BuildAliasDetailsResponse>? BuildAliases { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of summarized details of all multiplayer server builds for a title.
/// </summary>
public class ListBuildSummariesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListBuildSummariesResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of build summaries for a title.
    /// </summary>
    public List<BuildSummary>? BuildSummaries { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game certificates for a title.
/// </summary>
public class ListCertificateSummariesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListCertificateSummariesResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of game certificates.
    /// </summary>
    public List<CertificateSummary>? CertificateSummaries { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of the container images that have been uploaded to the container registry for a title.
/// </summary>
public class ListContainerImagesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListContainerImagesResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of container images.
    /// </summary>
    public List<string>? Images { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of the tags for a particular container image that exists in the container registry for a title.
/// </summary>
public class ListContainerImageTagsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The container images we want to list tags for.
    /// </summary>
    public string? ImageName { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListContainerImageTagsResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
    /// <summary>
    /// The list of tags for a particular container image.
    /// </summary>
    public List<string>? Tags { get; set; }
}

/// <summary>
/// Gets a list of all the matchmaking queue configurations for the title.
/// </summary>
public class ListMatchmakingQueuesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListMatchmakingQueuesResult : PlayFabResultCommon {
    /// <summary>
    /// The list of matchmaking queue configs for this title.
    /// </summary>
    public List<MatchmakingQueueConfig>? MatchMakingQueues { get; set; }
}

/// <summary>
/// If the caller is a title, the EntityKey in the request is required. If the caller is a player, then it is optional. If
/// it is provided it must match the caller's entity.
/// </summary>
public class ListMatchmakingTicketsForPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity key for which to find the ticket Ids.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the queue to find a match for.
    /// </summary>
    public required string QueueName { get; set; }
}

public class ListMatchmakingTicketsForPlayerResult : PlayFabResultCommon {
    /// <summary>
    /// The list of ticket Ids the user is a member of.
    /// </summary>
    public required List<string> TicketIds { get; set; }
}

/// <summary>
/// Returns a list of multiplayer servers for a build in a specific region.
/// </summary>
public class ListMultiplayerServersRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the multiplayer servers to list.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The region the multiplayer servers to list.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListMultiplayerServersResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of multiplayer server summary details.
    /// </summary>
    public List<MultiplayerServerSummary>? MultiplayerServerSummaries { get; set; }
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers for party.
/// </summary>
public class ListPartyQosServersRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Qos servers version
    /// </summary>
    public string? Version { get; set; }
}

public class ListPartyQosServersResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The list of QoS servers.
    /// </summary>
    public List<QosServer>? QosServers { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers for a title.
/// </summary>
public class ListQosServersForTitleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates that the response should contain Qos servers for all regions, including those where there are no builds
    /// deployed for the title.
    /// </summary>
    public bool? IncludeAllRegions { get; set; }
    /// <summary>
    /// Indicates the Routing Preference used by the Qos servers. The default Routing Preference is Microsoft
    /// </summary>
    public string? RoutingPreference { get; set; }
}

public class ListQosServersForTitleResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The list of QoS servers.
    /// </summary>
    public List<QosServer>? QosServers { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of quality of service servers.
/// </summary>
[Obsolete("Do not use")]
public class ListQosServersRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

[Obsolete("Do not use")]
public class ListQosServersResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The list of QoS servers.
    /// </summary>
    public List<QosServer>? QosServers { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// Returns a list of multiplayer server game secrets for a title.
/// </summary>
public class ListSecretSummariesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListSecretSummariesResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The list of game secret.
    /// </summary>
    public List<SecretSummary>? SecretSummaries { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
}

/// <summary>
/// List all server backfill ticket Ids the user is a member of.
/// </summary>
public class ListServerBackfillTicketsForPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity key for which to find the ticket Ids.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The name of the queue the tickets are in.
    /// </summary>
    public required string QueueName { get; set; }
}

public class ListServerBackfillTicketsForPlayerResult : PlayFabResultCommon {
    /// <summary>
    /// The list of backfill ticket Ids the user is a member of.
    /// </summary>
    public required List<string> TicketIds { get; set; }
}

/// <summary>
/// List all server quota change requests for a title.
/// </summary>
public class ListTitleMultiplayerServersQuotaChangesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListTitleMultiplayerServersQuotaChangesResponse : PlayFabResultCommon {
    /// <summary>
    /// All change requests for this title.
    /// </summary>
    public List<QuotaChange>? Changes { get; set; }
}

/// <summary>
/// Returns a list of virtual machines for a title.
/// </summary>
public class ListVirtualMachineSummariesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the virtual machines to list.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The page size for the request.
    /// </summary>
    public int? PageSize { get; set; }
    /// <summary>
    /// The region of the virtual machines to list.
    /// </summary>
    public required string Region { get; set; }
    /// <summary>
    /// The skip token for the paged request.
    /// </summary>
    public string? SkipToken { get; set; }
}

public class ListVirtualMachineSummariesResponse : PlayFabResultCommon {
    /// <summary>
    /// The page size on the response.
    /// </summary>
    public int PageSize { get; set; }
    /// <summary>
    /// The skip token for the paged response.
    /// </summary>
    public string? SkipToken { get; set; }
    /// <summary>
    /// The list of virtual machine summaries.
    /// </summary>
    public List<VirtualMachineSummary>? VirtualMachines { get; set; }
}

public class Lobby {
    /// <summary>
    /// A setting indicating who is allowed to join this lobby, as well as see it in queries.
    /// </summary>
    public AccessPolicy AccessPolicy { get; set; }
    /// <summary>
    /// A number that increments once for each request that modifies the lobby.
    /// </summary>
    public uint ChangeNumber { get; set; }
    /// <summary>
    /// A string used to join the lobby. This field is populated by the Lobby service. Invites are performed by communicating
    /// this connectionString to other players.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// Lobby data.
    /// </summary>
    public Dictionary<string, string>? LobbyData { get; set; }
    /// <summary>
    /// Id to uniquely identify a lobby.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby.
    /// </summary>
    public uint MaxPlayers { get; set; }
    /// <summary>
    /// Array of all lobby members.
    /// </summary>
    public List<Member>? Members { get; set; }
    /// <summary>
    /// A setting indicating whether members are allowed to join this lobby. When Locked new members are prevented from joining.
    /// </summary>
    public MembershipLock MembershipLock { get; set; }
    /// <summary>
    /// The client or server entity which owns this lobby.
    /// </summary>
    public EntityKey? Owner { get; set; }
    /// <summary>
    /// A setting indicating the owner migration policy. If server owned, this field is not present.
    /// </summary>
    public OwnerMigrationPolicy? OwnerMigrationPolicy { get; set; }
    /// <summary>
    /// An opaque string stored on a SubscribeToLobbyResource call, which indicates the connection an owner or member has with
    /// PubSub.
    /// </summary>
    public string? PubSubConnectionHandle { get; set; }
    /// <summary>
    /// A setting that controls lobby invites. When true only owners can invite new players, when false all members area
    /// allowed to invite.
    /// </summary>
    public bool RestrictInvitesToLobbyOwner { get; set; }
    /// <summary>
    /// Search data.
    /// </summary>
    public Dictionary<string, string>? SearchData { get; set; }
    /// <summary>
    /// Preview: Lobby joined server. This is not the server owner, rather the server that has joined a client owned lobby.
    /// </summary>
    public LobbyServer? Server { get; set; }
    /// <summary>
    /// A flag which determines if connections are used. Defaults to true. Only set on create.
    /// </summary>
    public bool UseConnections { get; set; }
}

public class LobbyEmptyResult : PlayFabResultCommon {
}

public class LobbyServer {
    /// <summary>
    /// Opaque string, stored on a Subscribe call, which indicates the connection a joined server has with PubSub.
    /// </summary>
    public string? PubSubConnectionHandle { get; set; }
    /// <summary>
    /// Key-value pairs specific to the joined server.
    /// </summary>
    public Dictionary<string, string>? ServerData { get; set; }
    /// <summary>
    /// The server entity key.
    /// </summary>
    public EntityKey? ServerEntity { get; set; }
}

public class LobbySummary {
    /// <summary>
    /// A string used to join the lobby.This field is populated by the Lobby service.Invites are performed by communicating
    /// this connectionString to other players.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// The current number of players in the lobby.
    /// </summary>
    public uint CurrentPlayers { get; set; }
    /// <summary>
    /// Id to uniquely identify a lobby.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby.
    /// </summary>
    public uint MaxPlayers { get; set; }
    /// <summary>
    /// A setting indicating whether members are allowed to join this lobby. When Locked new members are prevented from joining.
    /// </summary>
    public MembershipLock? MembershipLock { get; set; }
    /// <summary>
    /// The client or server entity which owns this lobby.
    /// </summary>
    public required EntityKey Owner { get; set; }
    /// <summary>
    /// Search data.
    /// </summary>
    public Dictionary<string, string>? SearchData { get; set; }
}

/// <summary>
/// A user in a matchmaking ticket.
/// </summary>
public class MatchmakingPlayer {
    /// <summary>
    /// The user's attributes custom to the title.
    /// </summary>
    public MatchmakingPlayerAttributes? Attributes { get; set; }
    /// <summary>
    /// The entity key of the matchmaking user.
    /// </summary>
    public required EntityKey Entity { get; set; }
}

/// <summary>
/// The matchmaking attributes for a user.
/// </summary>
public class MatchmakingPlayerAttributes {
    /// <summary>
    /// A data object representing a user's attributes.
    /// </summary>
    public object? DataObject { get; set; }
    /// <summary>
    /// An escaped data object representing a user's attributes.
    /// </summary>
    public string? EscapedDataObject { get; set; }
}

/// <summary>
/// A player in a created matchmaking match with a team assignment.
/// </summary>
public class MatchmakingPlayerWithTeamAssignment {
    /// <summary>
    /// The user's attributes custom to the title. These attributes will be null unless the request has ReturnMemberAttributes
    /// flag set to true.
    /// </summary>
    public MatchmakingPlayerAttributes? Attributes { get; set; }
    /// <summary>
    /// The entity key of the matchmaking user.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The Id of the team the User is assigned to.
    /// </summary>
    public string? TeamId { get; set; }
}

public class MatchmakingQueueConfig {
    /// <summary>
    /// This is the buildAlias that will be used to allocate the multiplayer server for the match.
    /// </summary>
    public BuildAliasParams? BuildAliasParams { get; set; }
    /// <summary>
    /// This is the buildId that will be used to allocate the multiplayer server for the match.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// List of difference rules used to find an optimal match.
    /// </summary>
    public List<DifferenceRule>? DifferenceRules { get; set; }
    /// <summary>
    /// List of match total rules used to find an optimal match.
    /// </summary>
    public List<MatchTotalRule>? MatchTotalRules { get; set; }
    /// <summary>
    /// Maximum number of players in a match.
    /// </summary>
    public uint MaxMatchSize { get; set; }
    /// <summary>
    /// Maximum number of players in a ticket. Optional.
    /// </summary>
    public uint? MaxTicketSize { get; set; }
    /// <summary>
    /// Minimum number of players in a match.
    /// </summary>
    public uint MinMatchSize { get; set; }
    /// <summary>
    /// Unique identifier for a Queue. Chosen by the developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Region selection rule used to find an optimal match.
    /// </summary>
    public RegionSelectionRule? RegionSelectionRule { get; set; }
    /// <summary>
    /// Boolean flag to enable server allocation for the queue.
    /// </summary>
    public bool ServerAllocationEnabled { get; set; }
    /// <summary>
    /// List of set intersection rules used to find an optimal match.
    /// </summary>
    public List<SetIntersectionRule>? SetIntersectionRules { get; set; }
    /// <summary>
    /// Controls which statistics are visible to players.
    /// </summary>
    public StatisticsVisibilityToPlayers? StatisticsVisibilityToPlayers { get; set; }
    /// <summary>
    /// List of string equality rules used to find an optimal match.
    /// </summary>
    public List<StringEqualityRule>? StringEqualityRules { get; set; }
    /// <summary>
    /// List of team difference rules used to find an optimal match.
    /// </summary>
    public List<TeamDifferenceRule>? TeamDifferenceRules { get; set; }
    /// <summary>
    /// The team configuration for a match. This may be null if there are no teams.
    /// </summary>
    public List<MatchmakingQueueTeam>? Teams { get; set; }
    /// <summary>
    /// Team size balance rule used to find an optimal match.
    /// </summary>
    public TeamSizeBalanceRule? TeamSizeBalanceRule { get; set; }
    /// <summary>
    /// Team ticket size similarity rule used to find an optimal match.
    /// </summary>
    public TeamTicketSizeSimilarityRule? TeamTicketSizeSimilarityRule { get; set; }
}

public class MatchmakingQueueTeam {
    /// <summary>
    /// The maximum number of players required for the team.
    /// </summary>
    public uint MaxTeamSize { get; set; }
    /// <summary>
    /// The minimum number of players required for the team.
    /// </summary>
    public uint MinTeamSize { get; set; }
    /// <summary>
    /// A name to identify the team. This is case insensitive.
    /// </summary>
    public required string Name { get; set; }
}

public class MatchResult {
    /// <summary>
    /// Time when the match ended.
    /// </summary>
    public required DateTime EndDateTimeUtc { get; set; }
    /// <summary>
    /// ID of the scenario that this match result belongs to.
    /// </summary>
    public required string ScenarioId { get; set; }
    /// <summary>
    /// Time when the match started.
    /// </summary>
    public required DateTime StartDateTimeUtc { get; set; }
    /// <summary>
    /// List of teams that participated in the given match.
    /// </summary>
    public required List<MatchResultTeam> Teams { get; set; }
}

public class MatchResultPlayer {
    /// <summary>
    /// ID of the Bot. This field should be empty if player isn't a bot.
    /// </summary>
    public int? BotId { get; set; }
    /// <summary>
    /// How the player's participation ended in the match. CompletionStatus can only be Completed, Quit, Disconnected or Kicked.
    /// </summary>
    public required string CompletionStatus { get; set; }
    /// <summary>
    /// A map from condition name to condition value of this player in the given match.
    /// </summary>
    public Dictionary<string, string>? Conditions { get; set; }
    /// <summary>
    /// Entity of the given player. This field should be empty if player is a bot.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// A map from event name to the count of events of this player in the given match.
    /// </summary>
    public Dictionary<string, int>? EventCounts { get; set; }
    /// <summary>
    /// GUID shared by players on this team that formed a group to play together prior to matchmaking.
    /// </summary>
    public string? PreMatchPartyId { get; set; }
    /// <summary>
    /// Duration that the given player stayed in the match.
    /// </summary>
    public int SecondsPlayed { get; set; }
}

public class MatchResultTeam {
    /// <summary>
    /// List of players that participated in the given match in this team.
    /// </summary>
    public required List<MatchResultPlayer> Players { get; set; }
    /// <summary>
    /// Rank of the given team in the match. Rank starts from 0 and increment based on the team placing, the winning team being
    /// 0. Teams can have the same rank to denote draws.
    /// </summary>
    public int Rank { get; set; }
}

public class MatchTotalRule {
    /// <summary>
    /// Description of the attribute used by this rule to match tickets.
    /// </summary>
    public required QueueRuleAttribute Attribute { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals.
    /// </summary>
    public MatchTotalRuleExpansion? Expansion { get; set; }
    /// <summary>
    /// The maximum total value for a group. Must be >= Min.
    /// </summary>
    public required double Max { get; set; }
    /// <summary>
    /// The minimum total value for a group. Must be >=2.
    /// </summary>
    public required double Min { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
    /// <summary>
    /// The relative weight of this rule compared to others.
    /// </summary>
    public required double Weight { get; set; }
}

public class MatchTotalRuleExpansion {
    /// <summary>
    /// Manually specify the values to use for each expansion interval. When this is set, Max is ignored.
    /// </summary>
    public List<OverrideDouble>? MaxOverrides { get; set; }
    /// <summary>
    /// Manually specify the values to use for each expansion interval. When this is set, Min is ignored.
    /// </summary>
    public List<OverrideDouble>? MinOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

public class Member {
    /// <summary>
    /// Key-value pairs specific to member.
    /// </summary>
    public Dictionary<string, string>? MemberData { get; set; }
    /// <summary>
    /// The member entity key.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
    /// <summary>
    /// Opaque string, stored on a Subscribe call, which indicates the connection an owner or member has with PubSub.
    /// </summary>
    public string? PubSubConnectionHandle { get; set; }
}

public enum MembershipLock {
    Unlocked,
    Locked,
}

public class ModelCondition {
    /// <summary>
    /// The key for this condition.
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// A number representing the rank of this condition in terms of how important the condition is in comparison to the other
    /// ones in the model. This number should be between 1 and the total number of condition in the model, and it should be
    /// unique across all the conditions. The lower the specified rank the more important the condition, 1 being the most
    /// important. This will be used for identifying similar conditions when the model has no data about some conditions.
    /// </summary>
    public int Rank { get; set; }
}

public class ModelDetails {
    /// <summary>
    /// The number of batch learning iterations that have been run for this model. When null, it means that this is a base
    /// model.
    /// </summary>
    public int? BatchIterations { get; set; }
    /// <summary>
    /// List of parameters that were used for creating this model via batch run. The value for the parameters is null when the
    /// model is a base model.
    /// </summary>
    public BatchParameters? BatchParameters { get; set; }
    /// <summary>
    /// The summary of the batch results for this model. This will be null when the model is a base model or when the batch run
    /// hasn't finished..
    /// </summary>
    public BatchResults? BatchResults { get; set; }
    /// <summary>
    /// List of condition keys and their associated affinity weights that this model supports.
    /// </summary>
    public List<ModelCondition>? Conditions { get; set; }
    /// <summary>
    /// Time when the Model was created.
    /// </summary>
    public required DateTime CreationDateTime { get; set; }
    /// <summary>
    /// The current threshold value for determining if a match result is considered anomalous enough to be ignored. This will
    /// be null when creating a batch model and the settings have not been loaded yet. Note:
    /// <c>BatchParameters.AnomalousMatchResultIgnoreThreshold</c> value was the one that was used when creating the batch
    /// model, which might differ from this value.
    /// </summary>
    public double? CurrentAnomalousMatchResultIgnoreThreshold { get; set; }
    /// <summary>
    /// An integer between 0 and MaxStateProgress (inclusive) indicating progress within the model's current state, or null if
    /// the current state is not a state with measurable progress.
    /// </summary>
    public int? CurrentStateProgress { get; set; }
    /// <summary>
    /// Time remaining in seconds to finish the current model state. If it is a base model, the model isn't in a state with
    /// measurable progress, or if the time remaining is unknown, this field will be null.
    /// </summary>
    public int? EstimatedTimeRemainingInSeconds { get; set; }
    /// <summary>
    /// List of events that the Model supports.
    /// </summary>
    public List<string>? Events { get; set; }
    /// <summary>
    /// The primary flag of the model.
    /// </summary>
    public bool IsPrimary { get; set; }
    /// <summary>
    /// The maximum progress value for the model's current state, or null if the current state is not a state with measurable
    /// progress.
    /// </summary>
    public int? MaxStateProgress { get; set; }
    /// <summary>
    /// String that represents the method that was used for creating this model. The value can only be either Base or Batch.
    /// </summary>
    public string? ModelCreationMethod { get; set; }
    /// <summary>
    /// The ID of the model.
    /// </summary>
    public string? ModelId { get; set; }
    /// <summary>
    /// The name of the model.
    /// </summary>
    public string? ModelName { get; set; }
    /// <summary>
    /// The state of the model. ModelState can be Pending, LoadingMatches, BuildingModel, SavingModel, ReadyForCatchUp,
    /// CatchingUp, CatchUpFailed, Active, Cancelled, BatchFailed, or Deactivated.
    /// </summary>
    public string? ModelState { get; set; }
}

public class ModelSummary {
    /// <summary>
    /// Time when the Model was created.
    /// </summary>
    public required DateTime CreationDateTime { get; set; }
    /// <summary>
    /// The primary flag of the model.
    /// </summary>
    public bool IsPrimary { get; set; }
    /// <summary>
    /// The ID of the model.
    /// </summary>
    public string? ModelId { get; set; }
    /// <summary>
    /// The name of the model.
    /// </summary>
    public string? ModelName { get; set; }
    /// <summary>
    /// The state of the model. ModelState can be Pending, LoadingMatches, BuildingModel, SavingModel, ReadyForCatchUp,
    /// CatchingUp, CatchUpFailed, Active, Cancelled, BatchFailed, or Deactivated.
    /// </summary>
    public string? ModelState { get; set; }
}

public class MonitoringApplicationConfiguration {
    /// <summary>
    /// Asset which contains the monitoring application files and scripts.
    /// </summary>
    public required AssetReference AssetReference { get; set; }
    /// <summary>
    /// Execution script name, this will be the main executable for the monitoring application.
    /// </summary>
    public required string ExecutionScriptName { get; set; }
    /// <summary>
    /// Installation script name, this will be run before the ExecutionScript.
    /// </summary>
    public string? InstallationScriptName { get; set; }
    /// <summary>
    /// Timespan the monitoring application will be kept alive when running from the start of the VM
    /// </summary>
    public double? OnStartRuntimeInMinutes { get; set; }
}

public class MonitoringApplicationConfigurationParams {
    /// <summary>
    /// Asset which contains the monitoring application files and scripts.
    /// </summary>
    public required AssetReferenceParams AssetReference { get; set; }
    /// <summary>
    /// Execution script name, this will be the main executable for the monitoring application.
    /// </summary>
    public required string ExecutionScriptName { get; set; }
    /// <summary>
    /// Installation script name, this will be run before the ExecutionScript.
    /// </summary>
    public string? InstallationScriptName { get; set; }
    /// <summary>
    /// Timespan the monitoring application will be kept alive when running from the start of the VM
    /// </summary>
    public double? OnStartRuntimeInMinutes { get; set; }
}

public class MultiplayerServerSummary {
    /// <summary>
    /// The connected players in the multiplayer server.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the multiplayer server state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// The region the multiplayer server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The title generated guid string session ID of the multiplayer server.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// The state of the multiplayer server.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the multiplayer server is located on.
    /// </summary>
    public string? VmId { get; set; }
}

public enum OsPlatform {
    Windows,
    Linux,
}

public class OverrideDouble {
    /// <summary>
    /// The custom expansion value.
    /// </summary>
    public required double Value { get; set; }
}

public class OverrideUnsignedInt {
    /// <summary>
    /// The custom expansion value.
    /// </summary>
    public uint Value { get; set; }
}

public enum OwnerMigrationPolicy {
    None,
    Automatic,
    Manual,
    Server,
}

public class PaginationRequest {
    /// <summary>
    /// Continuation token returned as a result in a previous FindLobbies call. Cannot be specified by clients.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The number of lobbies that should be retrieved. Cannot be specified by servers, clients may specify any value up to 50
    /// </summary>
    public uint? PageSizeRequested { get; set; }
}

public class PaginationResponse {
    /// <summary>
    /// Continuation token returned by server call. Not returned for clients
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The number of lobbies that matched the search request.
    /// </summary>
    public uint? TotalMatchedLobbyCount { get; set; }
}

public class PartyBuildAliasParams {
    /// <summary>
    /// The guid string alias ID to use for the request.
    /// </summary>
    public required string AliasId { get; set; }
}

public class PartyInvitationConfiguration {
    /// <summary>
    /// The list of PlayFab EntityKeys that the invitation allows to authenticate into the network. If this list is empty, all
    /// users are allowed to authenticate using the invitation's identifier. This list may contain no more than 1024 items.
    /// </summary>
    public List<EntityKey>? EntityKeys { get; set; }
    /// <summary>
    /// The invite identifier for this party. If this value is specified, it must be no longer than 127 characters.
    /// </summary>
    public string? Identifier { get; set; }
    /// <summary>
    /// Controls which participants can revoke this invite.
    /// </summary>
    public string? Revocability { get; set; }
}

public enum PartyInvitationRevocability {
    Creator,
    Anyone,
}

public class PartyNetworkConfiguration {
    /// <summary>
    /// Controls whether and how to support direct peer-to-peer connection attempts among devices in the network.
    /// </summary>
    public string? DirectPeerConnectivityOptions { get; set; }
    /// <summary>
    /// The maximum number of devices allowed to connect to the network. Must be between 1 and 128, inclusive.
    /// </summary>
    public uint MaxDevices { get; set; }
    /// <summary>
    /// The maximum number of devices allowed per user. Must be greater than 0.
    /// </summary>
    public uint MaxDevicesPerUser { get; set; }
    /// <summary>
    /// The maximum number of endpoints allowed per device. Must be between 0 and 32, inclusive.
    /// </summary>
    public uint MaxEndpointsPerDevice { get; set; }
    /// <summary>
    /// The maximum number of unique users allowed in the network. Must be greater than 0.
    /// </summary>
    public uint MaxUsers { get; set; }
    /// <summary>
    /// The maximum number of users allowed per device. Must be between 1 and 8, inclusive.
    /// </summary>
    public uint MaxUsersPerDevice { get; set; }
    /// <summary>
    /// An optionally-specified configuration for the initial invitation for this party. If not provided, default configuration
    /// values will be used: a title-unique invitation identifier will be generated, the revocability will be Anyone, and the
    /// EntityID list will be empty.
    /// </summary>
    public PartyInvitationConfiguration? PartyInvitationConfiguration { get; set; }
}

public class PlayerSkill {
    /// <summary>
    /// Entity of the given player.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Time when the last match to update the player's skill was uploaded.
    /// </summary>
    public required DateTime LastProcessedMatchUploadTimeUtc { get; set; }
    /// <summary>
    /// The given player's skill value to be used for Matchmaking computed by TrueSkill. This takes into account the player's
    /// squad size, as well as other modifiers related to the skills in this condition as a whole
    /// </summary>
    public required double MatchmakingSkillValue { get; set; }
    /// <summary>
    /// A detailed breakdown of the player's skill. This will only be returned if IncludeSkillBreakdown was specified and true
    /// in the request.
    /// </summary>
    public SkillBreakdown? SkillBreakdown { get; set; }
    /// <summary>
    /// The given player's individual skill computed by TrueSkill.
    /// </summary>
    public required double SkillValue { get; set; }
}

public class PlayerSkillForCondition {
    /// <summary>
    /// Set of Conditions of the respective player skills data.
    /// </summary>
    public Dictionary<string, string>? Conditions { get; set; }
    /// <summary>
    /// The given player's skill value to be used for Matchmaking computed by TrueSkill. This takes into account the player's
    /// squad size, as well as other modifiers related to the skills in this condition as a whole
    /// </summary>
    public required double MatchmakingSkillValue { get; set; }
    /// <summary>
    /// A detailed breakdown of the player's skill. This will only be returned if IncludeSkillBreakdown was specified and true
    /// in the request.
    /// </summary>
    public SkillBreakdown? SkillBreakdown { get; set; }
    /// <summary>
    /// The given player's individual skill computed by TrueSkill.
    /// </summary>
    public required double SkillValue { get; set; }
}

public class PlayerSkills {
    /// <summary>
    /// Entity of the given player.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Time when the last match to update the player's skill was uploaded.
    /// </summary>
    public required DateTime LastProcessedMatchUploadTimeUtc { get; set; }
    /// <summary>
    /// List of skill values for all the conditions sets that were requested.
    /// </summary>
    public List<PlayerSkillForCondition>? SkillsForConditions { get; set; }
}

public class PlayerToken {
    /// <summary>
    /// The player id of the player for which the token applies.
    /// </summary>
    public string? PlayerId { get; set; }
    /// <summary>
    /// The (base64 encoded) token.
    /// </summary>
    public string? Token { get; set; }
}

public class Port {
    /// <summary>
    /// The name for the port.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The number for the port.
    /// </summary>
    public int Num { get; set; }
    /// <summary>
    /// The protocol for the port.
    /// </summary>
    public ProtocolType Protocol { get; set; }
}

public enum ProtocolType {
    TCP,
    UDP,
}

public class PublicIpAddress {
    /// <summary>
    /// FQDN of the public IP
    /// </summary>
    public required string FQDN { get; set; }
    /// <summary>
    /// Server IP Address
    /// </summary>
    public required string IpAddress { get; set; }
    /// <summary>
    /// Routing Type of the public IP.
    /// </summary>
    public required string RoutingType { get; set; }
}

public class QosServer {
    /// <summary>
    /// The region the QoS server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The QoS server URL.
    /// </summary>
    public string? ServerUrl { get; set; }
}

public class QueueRuleAttribute {
    /// <summary>
    /// Specifies which attribute in a ticket to use.
    /// </summary>
    public required string Path { get; set; }
    /// <summary>
    /// Specifies which source the attribute comes from.
    /// </summary>
    public AttributeSource Source { get; set; }
}

public class QuotaChange {
    /// <summary>
    /// A brief description of the requested changes.
    /// </summary>
    public string? ChangeDescription { get; set; }
    /// <summary>
    /// Requested changes to make to the titles cores quota.
    /// </summary>
    public List<CoreCapacityChange>? Changes { get; set; }
    /// <summary>
    /// Whether or not this request is pending a review.
    /// </summary>
    public bool IsPendingReview { get; set; }
    /// <summary>
    /// Additional information about this request that our team can use to better understand the requirements.
    /// </summary>
    public string? Notes { get; set; }
    /// <summary>
    /// Id of the change request.
    /// </summary>
    public string? RequestId { get; set; }
    /// <summary>
    /// Comments by our team when a request is reviewed.
    /// </summary>
    public string? ReviewComments { get; set; }
    /// <summary>
    /// Whether or not this request was approved.
    /// </summary>
    public bool WasApproved { get; set; }
}

public class RegionSelectionRule {
    /// <summary>
    /// Controls how the Max Latency parameter expands over time. Only one expansion can be set per rule. When this is set,
    /// MaxLatency is ignored.
    /// </summary>
    public CustomRegionSelectionRuleExpansion? CustomExpansion { get; set; }
    /// <summary>
    /// Controls how the Max Latency parameter expands over time. Only one expansion can be set per rule.
    /// </summary>
    public LinearRegionSelectionRuleExpansion? LinearExpansion { get; set; }
    /// <summary>
    /// Specifies the maximum latency that is allowed between the client and the selected server. The value is in milliseconds.
    /// </summary>
    public uint MaxLatency { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Specifies which attribute in a ticket to use.
    /// </summary>
    public required string Path { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
    /// <summary>
    /// The relative weight of this rule compared to others.
    /// </summary>
    public required double Weight { get; set; }
}

/// <summary>
/// Deletes the configuration for a queue. This will permanently delete the configuration and players will no longer be
/// able to match in the queue. All outstanding matchmaking tickets will be cancelled.
/// </summary>
public class RemoveMatchmakingQueueRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The Id of the matchmaking queue to remove.
    /// </summary>
    public string? QueueName { get; set; }
}

public class RemoveMatchmakingQueueResult : PlayFabResultCommon {
}

/// <summary>
/// Request to remove a member from a lobby. Owners may remove other members from a lobby. Members cannot remove themselves
/// (use LeaveLobby instead).
/// </summary>
public class RemoveMemberFromLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// The member entity to be removed from the lobby.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
    /// <summary>
    /// If true, removed member can never rejoin this lobby.
    /// </summary>
    public bool PreventRejoin { get; set; }
}

/// <summary>
/// Requests a multiplayer server session from a particular build in any of the given preferred regions.
/// </summary>
public class RequestMultiplayerServerAndTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The identifiers of the build alias to use for the request.
    /// </summary>
    public BuildAliasParams? BuildAliasParams { get; set; }
    /// <summary>
    /// The guid string build ID of the multiplayer server to request.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Initial list of players (potentially matchmade) allowed to connect to the game. This list is passed to the game server
    /// when requested (via GSDK) and can be used to validate players connecting to it.
    /// </summary>
    public List<string>? InitialPlayers { get; set; }
    /// <summary>
    /// The preferred regions to request a multiplayer server from. The Multiplayer Service will iterate through the regions in
    /// the specified order and allocate a server from the first one that has servers available.
    /// </summary>
    public required List<string> PreferredRegions { get; set; }
    /// <summary>
    /// Data encoded as a string that is passed to the game server when requested. This can be used to communicate information
    /// such as game mode or map through the request flow. Maximum size is 8KB
    /// </summary>
    public string? SessionCookie { get; set; }
    /// <summary>
    /// A guid string session ID created track the multiplayer server session over its life.
    /// </summary>
    public required string SessionId { get; set; }
    /// <summary>
    /// List of players for which to get tokens.
    /// </summary>
    public required List<string> TokenPlayerIds { get; set; }
}

public class RequestMultiplayerServerAndTokenResponse : PlayFabResultCommon {
    /// <summary>
    /// The identity of the build in which the server was allocated.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The connected players in the multiplayer server.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? FQDN { get; set; }
    /// <summary>
    /// The public IPv4 address of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the multiplayer server state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// A set of tokens that can be used to connect to the server. Tokens match the requested user ids
    /// </summary>
    public List<PlayerToken>? PlayerTokens { get; set; }
    /// <summary>
    /// The ports the multiplayer server uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The list of public Ipv4 addresses associated with the server.
    /// </summary>
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    /// <summary>
    /// The region the multiplayer server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The guid string session ID of the multiplayer server.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// The state of the multiplayer server.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the multiplayer server is located on.
    /// </summary>
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a multiplayer server session from a particular build in any of the given preferred regions.
/// </summary>
public class RequestMultiplayerServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The identifiers of the build alias to use for the request.
    /// </summary>
    public BuildAliasParams? BuildAliasParams { get; set; }
    /// <summary>
    /// The guid string build ID of the multiplayer server to request.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Initial list of players (potentially matchmade) allowed to connect to the game. This list is passed to the game server
    /// when requested (via GSDK) and can be used to validate players connecting to it.
    /// </summary>
    public List<string>? InitialPlayers { get; set; }
    /// <summary>
    /// The preferred regions to request a multiplayer server from. The Multiplayer Service will iterate through the regions in
    /// the specified order and allocate a server from the first one that has servers available.
    /// </summary>
    public required List<string> PreferredRegions { get; set; }
    /// <summary>
    /// Data encoded as a string that is passed to the game server when requested. This can be used to communicate information
    /// such as game mode or map through the request flow. Maximum size is 8KB
    /// </summary>
    public string? SessionCookie { get; set; }
    /// <summary>
    /// A guid string session ID created track the multiplayer server session over its life.
    /// </summary>
    public required string SessionId { get; set; }
}

public class RequestMultiplayerServerResponse : PlayFabResultCommon {
    /// <summary>
    /// The identity of the build in which the server was allocated.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The connected players in the multiplayer server.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? FQDN { get; set; }
    /// <summary>
    /// The public IPv4 address of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the multiplayer server state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// The ports the multiplayer server uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The list of public Ipv4 addresses associated with the server.
    /// </summary>
    public List<PublicIpAddress>? PublicIPV4Addresses { get; set; }
    /// <summary>
    /// The region the multiplayer server is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The guid string session ID of the multiplayer server.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// The state of the multiplayer server.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the multiplayer server is located on.
    /// </summary>
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a party session from a particular build if version is provided or in a set of builds if build alias params is
/// provided, in any of the given preferred regions.
/// </summary>
public class RequestPartyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The identifiers of the build alias to use for the request.
    /// </summary>
    public PartyBuildAliasParams? BuildAliasParams { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// A guid string party ID created track the party session over its life.
    /// </summary>
    public required string PartyId { get; set; }
    /// <summary>
    /// The preferred regions to request a party session from. The party service will iterate through the regions in the
    /// specified order and allocate a party session from the first one that is available.
    /// </summary>
    public required List<string> PreferredRegions { get; set; }
    /// <summary>
    /// Data encoded as a string that is passed to the party when requested. This can be used to to communicate information
    /// such as party type through the request flow.
    /// </summary>
    public string? SessionCookie { get; set; }
    /// <summary>
    /// The client version for the party being requested.
    /// </summary>
    public string? Version { get; set; }
}

public class RequestPartyResponse : PlayFabResultCommon {
    /// <summary>
    /// The build id that the party was allocated on.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The connected players in the party.
    /// </summary>
    public List<ConnectedPlayer>? ConnectedPlayers { get; set; }
    /// <summary>
    /// The thumbprint of the DTLS certificate presented by the party session
    /// </summary>
    public string? DTLSCertificateSHA2Thumbprint { get; set; }
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this party session.
    /// </summary>
    public string? FQDN { get; set; }
    /// <summary>
    /// The IPv4 address of the virtual machine that is hosting this party session.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The time (UTC) at which a change in the party state was observed.
    /// </summary>
    public DateTime? LastStateTransitionTime { get; set; }
    /// <summary>
    /// The guid string party ID of the party session.
    /// </summary>
    public string? PartyId { get; set; }
    /// <summary>
    /// The ports the party session uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The region the party session is located in.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the party session generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
    /// <summary>
    /// The state of the party session.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID that the party session is located on.
    /// </summary>
    public string? VmId { get; set; }
}

/// <summary>
/// Requests a party session from a particular set of builds if build alias params is provided, in any of the given
/// preferred regions.
/// </summary>
public class RequestPartyServiceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The network configuration for this request.
    /// </summary>
    public required PartyNetworkConfiguration NetworkConfiguration { get; set; }
    /// <summary>
    /// A guid string party ID created track the party session over its life.
    /// </summary>
    public string? PartyId { get; set; }
    /// <summary>
    /// The preferred regions to request a party session from. The party service will iterate through the regions in the
    /// specified order and allocate a party session from the first one that is available.
    /// </summary>
    public required List<string> PreferredRegions { get; set; }
}

public class RequestPartyServiceResponse : PlayFabResultCommon {
    /// <summary>
    /// The invitation identifier supplied in the PartyInvitationConfiguration, or the PlayFab-generated guid if none was
    /// supplied.
    /// </summary>
    public string? InvitationId { get; set; }
    /// <summary>
    /// The guid string party ID of the party session.
    /// </summary>
    public string? PartyId { get; set; }
    /// <summary>
    /// A base-64 encoded string containing the serialized network descriptor for this party.
    /// </summary>
    public string? SerializedNetworkDescriptor { get; set; }
}

/// <summary>
/// Gets new credentials to the container registry where game developers can upload custom container images to before
/// creating a new build.
/// </summary>
public class RolloverContainerRegistryCredentialsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RolloverContainerRegistryCredentialsResponse : PlayFabResultCommon {
    /// <summary>
    /// The url of the container registry.
    /// </summary>
    public string? DnsName { get; set; }
    /// <summary>
    /// The password for accessing the container registry.
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// The username for accessing the container registry.
    /// </summary>
    public string? Username { get; set; }
}

public enum RoutingType {
    Microsoft,
    Internet,
}

public class ScenarioConfigCondition {
    /// <summary>
    /// The key for a scenario condition.
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// List of strings that represents all the values for a condition.
    /// </summary>
    public required List<string> Values { get; set; }
}

public class ScenarioConfigEvent {
    /// <summary>
    /// The name for a scenario event.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The state of a scenario event. State can be Allowed or Required.
    /// </summary>
    public string? State { get; set; }
}

public class ScenarioConfigResponseCondition {
    /// <summary>
    /// The key for a scenario condition.
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// The state of a scenario condition. State can be Allowed or Required.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// List of strings that represents all the values for a condition.
    /// </summary>
    public required List<string> Values { get; set; }
}

public class ScenarioConfiguration {
    /// <summary>
    /// A list of condition keys, allowed condition values, and state for each that are allowed to be present in a MatchResult.
    /// </summary>
    public List<ScenarioConfigResponseCondition>? Conditions { get; set; }
    /// <summary>
    /// List of all the Events that are allowed to be present in a MatchResult for this scenario.
    /// </summary>
    public List<ScenarioConfigEvent>? Events { get; set; }
    /// <summary>
    /// The id of the returned scenario.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The friendly name of the returned scenario.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The ID of the primary model of the scenario.
    /// </summary>
    public string? PrimaryModelId { get; set; }
}

public class Schedule {
    /// <summary>
    /// A short description about this schedule. For example, "Game launch on July 15th".
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The date and time in UTC at which the schedule ends. If IsRecurringWeekly is true, this schedule will keep renewing for
    /// future weeks until disabled or removed.
    /// </summary>
    public required DateTime EndTime { get; set; }
    /// <summary>
    /// Disables the schedule.
    /// </summary>
    public bool IsDisabled { get; set; }
    /// <summary>
    /// If true, the StartTime and EndTime will get renewed every week.
    /// </summary>
    public bool IsRecurringWeekly { get; set; }
    /// <summary>
    /// The date and time in UTC at which the schedule starts.
    /// </summary>
    public required DateTime StartTime { get; set; }
    /// <summary>
    /// The standby target to maintain for the duration of the schedule.
    /// </summary>
    public int TargetStandby { get; set; }
}

public class ScheduledStandbySettings {
    /// <summary>
    /// When true, scheduled standby will be enabled
    /// </summary>
    public bool IsEnabled { get; set; }
    /// <summary>
    /// A list of non-overlapping schedules
    /// </summary>
    public List<Schedule>? ScheduleList { get; set; }
}

public class Secret {
    /// <summary>
    /// Optional secret expiration date.
    /// </summary>
    public DateTime? ExpirationDate { get; set; }
    /// <summary>
    /// A name for the secret. This is used to reference secrets in build configurations.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Secret value.
    /// </summary>
    public required string Value { get; set; }
}

public class SecretSummary {
    /// <summary>
    /// Optional secret expiration date.
    /// </summary>
    public DateTime? ExpirationDate { get; set; }
    /// <summary>
    /// The name of the secret.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The secret version auto-generated after upload.
    /// </summary>
    public string? Version { get; set; }
}

public class ServerDetails {
    /// <summary>
    /// The fully qualified domain name of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? Fqdn { get; set; }
    /// <summary>
    /// The IPv4 address of the virtual machine that is hosting this multiplayer server.
    /// </summary>
    public string? IPV4Address { get; set; }
    /// <summary>
    /// The ports the multiplayer server uses.
    /// </summary>
    public List<Port>? Ports { get; set; }
    /// <summary>
    /// The server's region.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// The string server ID of the multiplayer server generated by PlayFab.
    /// </summary>
    public string? ServerId { get; set; }
}

public class ServerResourceConstraintParams {
    /// <summary>
    /// The maximum number of cores that each server is allowed to use.
    /// </summary>
    public required double CpuLimit { get; set; }
    /// <summary>
    /// The maximum number of GiB of memory that each server is allowed to use. WARNING: After exceeding this limit, the server
    /// will be killed
    /// </summary>
    public required double MemoryLimitGB { get; set; }
}

public enum ServerType {
    Container,
    Process,
}

public class SetIntersectionRule {
    /// <summary>
    /// Description of the attribute used by this rule to match tickets.
    /// </summary>
    public required QueueRuleAttribute Attribute { get; set; }
    /// <summary>
    /// Describes the behavior when an attribute is not specified in the ticket creation request or in the user's entity
    /// profile.
    /// </summary>
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule. When
    /// this is set, MinIntersectionSize is ignored.
    /// </summary>
    public CustomSetIntersectionRuleExpansion? CustomExpansion { get; set; }
    /// <summary>
    /// The default value assigned to tickets that are missing the attribute specified by AttributePath (assuming that
    /// AttributeNotSpecifiedBehavior is UseDefault). Values must be unique.
    /// </summary>
    public List<string>? DefaultAttributeValue { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule.
    /// </summary>
    public LinearSetIntersectionRuleExpansion? LinearExpansion { get; set; }
    /// <summary>
    /// The minimum number of values that must match between sets.
    /// </summary>
    public uint MinIntersectionSize { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
    /// <summary>
    /// The relative weight of this rule compared to others.
    /// </summary>
    public required double Weight { get; set; }
}

/// <summary>
/// Use this API to create or update matchmaking queue configurations. The queue configuration defines the matchmaking
/// rules. The matchmaking service will match tickets together according to the configured rules. Queue resources are not
/// spun up by calling this API. Queues are created when the first ticket is submitted.
/// </summary>
public class SetMatchmakingQueueRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The matchmaking queue config.
    /// </summary>
    public required MatchmakingQueueConfig MatchmakingQueue { get; set; }
}

public class SetMatchmakingQueueResult : PlayFabResultCommon {
}

/// <summary>
/// Executes the shutdown callback from the GSDK and terminates the multiplayer server session. The callback in the GSDK
/// will allow for graceful shutdown with a 15 minute timeoutIf graceful shutdown has not been completed before 15 minutes
/// have elapsed, the multiplayer server session will be forcefully terminated on it's own.
/// </summary>
public class ShutdownMultiplayerServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string build ID of the multiplayer server to delete.
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The region of the multiplayer server to shut down.
    /// </summary>
    public string? Region { get; set; }
    /// <summary>
    /// A guid string session ID of the multiplayer server to shut down.
    /// </summary>
    public required string SessionId { get; set; }
}

public class SkillBreakdown {
    /// <summary>
    /// A number denoting the number of matches that the player has played in the specific conditions.
    /// </summary>
    public int Experience { get; set; }
    /// <summary>
    /// The average skill of the given player's skill distribution.
    /// </summary>
    public required double Mean { get; set; }
    /// <summary>
    /// A double between 0 and 1 denoting the approximate percentage of players that have lower skill than the given player.
    /// QuantileRank is only supported for batch models. Note: The percentage is based on quantiles of player skill obtained
    /// when the model was created, and those quantiles could become less accurate over time.
    /// </summary>
    public double? QuantileRank { get; set; }
    /// <summary>
    /// The variance of the given player's skill based on their skill distribution.
    /// </summary>
    public required double Variance { get; set; }
}

public class Statistics {
    /// <summary>
    /// The average.
    /// </summary>
    public required double Average { get; set; }
    /// <summary>
    /// The 50th percentile.
    /// </summary>
    public required double Percentile50 { get; set; }
    /// <summary>
    /// The 90th percentile.
    /// </summary>
    public required double Percentile90 { get; set; }
    /// <summary>
    /// The 99th percentile.
    /// </summary>
    public required double Percentile99 { get; set; }
}

public class StatisticsVisibilityToPlayers {
    /// <summary>
    /// Whether to allow players to view the current number of players in the matchmaking queue.
    /// </summary>
    public bool ShowNumberOfPlayersMatching { get; set; }
    /// <summary>
    /// Whether to allow players to view statistics representing the time it takes for tickets to find a match.
    /// </summary>
    public bool ShowTimeToMatch { get; set; }
}

public class StringEqualityRule {
    /// <summary>
    /// Description of the attribute used by this rule to match tickets.
    /// </summary>
    public required QueueRuleAttribute Attribute { get; set; }
    /// <summary>
    /// Describes the behavior when an attribute is not specified in the ticket creation request or in the user's entity
    /// profile.
    /// </summary>
    public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior { get; set; }
    /// <summary>
    /// The default value assigned to tickets that are missing the attribute specified by AttributePath (assuming that
    /// AttributeNotSpecifiedBehavior is false).
    /// </summary>
    public string? DefaultAttributeValue { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. For StringEqualityRules, this is limited to
    /// turning the rule off or on during different intervals.
    /// </summary>
    public StringEqualityRuleExpansion? Expansion { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
    /// <summary>
    /// The relative weight of this rule compared to others.
    /// </summary>
    public required double Weight { get; set; }
}

public class StringEqualityRuleExpansion {
    /// <summary>
    /// List of bools specifying whether the rule is applied during this expansion.
    /// </summary>
    public List<bool> EnabledOverrides { get; set; }
    /// <summary>
    /// How many seconds before this rule is expanded.
    /// </summary>
    public uint SecondsBetweenExpansions { get; set; }
}

/// <summary>
/// Request to subscribe to lobby resource notifications.
/// </summary>
public class SubscribeToLobbyResourceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity performing the subscription.
    /// </summary>
    public required EntityKey EntityKey { get; set; }
    /// <summary>
    /// Opaque string, given to a client upon creating a connection with PubSub.
    /// </summary>
    public required string PubSubConnectionHandle { get; set; }
    /// <summary>
    /// The name of the resource to subscribe to. For LobbyChange subscriptions this is the lobbyId. For LobbyInvite
    /// subscriptions this should always be "@me".
    /// </summary>
    public required string ResourceId { get; set; }
    /// <summary>
    /// Version number for the subscription of this resource.
    /// </summary>
    public uint SubscriptionVersion { get; set; }
    /// <summary>
    /// Subscription type. "LobbyChange" subscriptions allow a member or owner to receive notifications of lobby data, member
    /// or owner changes. "LobbyInvite" subscriptions allow a player to receive invites to lobbies. A player does not need to
    /// be a member of a lobby to receive lobby invites.
    /// </summary>
    public SubscriptionType Type { get; set; }
}

public class SubscribeToLobbyResourceResult : PlayFabResultCommon {
    /// <summary>
    /// Topic will be returned in all notifications that are the result of this subscription.
    /// </summary>
    public required string Topic { get; set; }
}

/// <summary>
/// Subscribe to match resource notifications. Match subscriptions have two types; MatchInvite and MatchTicketStatusChange
/// </summary>
public class SubscribeToMatchResourceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity performing the subscription. The entity must be authorized to use this connectionHandle.
    /// </summary>
    public required EntityKey EntityKey { get; set; }
    /// <summary>
    /// Opaque string, given to a client upon creating a connection with PubSub. Notifications will be sent to the connection
    /// associated with this handle.
    /// </summary>
    public required string PubSubConnectionHandle { get; set; }
    /// <summary>
    /// The name of the resource to subscribe to. It follows the format {queueName}|{ticketId} for MatchTicketStatusChange. For
    /// MatchInvite, ResourceId is @me.
    /// </summary>
    public required string ResourceId { get; set; }
    /// <summary>
    /// Version number for the subscription of this resource. Current supported version must be 1.
    /// </summary>
    public uint SubscriptionVersion { get; set; }
    /// <summary>
    /// Subscription type. MatchInvite subscriptions are per-player. MatchTicketStatusChange subscriptions are per-ticket.
    /// Subscribe calls are idempotent. Subscribing on the same resource for the same connection results in success.
    /// </summary>
    public required string Type { get; set; }
}

public class SubscribeToMatchResourceResult : PlayFabResultCommon {
    /// <summary>
    /// Matchmaking resource
    /// </summary>
    public required string Topic { get; set; }
}

public enum SubscriptionType {
    LobbyChange,
    LobbyInvite,
}

public class TeamDifferenceRule {
    /// <summary>
    /// Description of the attribute used by this rule to match teams.
    /// </summary>
    public required QueueRuleAttribute Attribute { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule. When
    /// this is set, Difference is ignored.
    /// </summary>
    public CustomTeamDifferenceRuleExpansion? CustomExpansion { get; set; }
    /// <summary>
    /// The default value assigned to tickets that are missing the attribute specified by AttributePath (assuming that
    /// AttributeNotSpecifiedBehavior is false).
    /// </summary>
    public required double DefaultAttributeValue { get; set; }
    /// <summary>
    /// The allowed difference between any two teams at the start of matchmaking.
    /// </summary>
    public required double Difference { get; set; }
    /// <summary>
    /// Collection of fields relating to expanding this rule at set intervals. Only one expansion can be set per rule.
    /// </summary>
    public LinearTeamDifferenceRuleExpansion? LinearExpansion { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
}

public class TeamSizeBalanceRule {
    /// <summary>
    /// Controls how the Difference parameter expands over time. Only one expansion can be set per rule. When this is set,
    /// Difference is ignored.
    /// </summary>
    public CustomTeamSizeBalanceRuleExpansion? CustomExpansion { get; set; }
    /// <summary>
    /// The allowed difference in team size between any two teams.
    /// </summary>
    public uint Difference { get; set; }
    /// <summary>
    /// Controls how the Difference parameter expands over time. Only one expansion can be set per rule.
    /// </summary>
    public LinearTeamSizeBalanceRuleExpansion? LinearExpansion { get; set; }
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
}

public class TeamTicketSizeSimilarityRule {
    /// <summary>
    /// Friendly name chosen by developer.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// How many seconds before this rule is no longer enforced (but tickets that comply with this rule will still be
    /// prioritized over those that don't). Leave blank if this rule is always enforced.
    /// </summary>
    public uint? SecondsUntilOptional { get; set; }
}

public enum TitleMultiplayerServerEnabledStatus {
    Initializing,
    Enabled,
    Disabled,
}

public class TitleMultiplayerServersQuotas {
    /// <summary>
    /// The core capacity for the various regions and VM Family
    /// </summary>
    public List<CoreCapacity>? CoreCapacities { get; set; }
}

public class TrueSkillPlayer {
    /// <summary>
    /// Entity of the player to retrieve skill values for.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// Size of the squad that the player is currently on. If this value is not specified, we consider the player to not be in
    /// a squad.
    /// </summary>
    public int? SquadSize { get; set; }
}

/// <summary>
/// Request to unsubscribe from lobby notifications.
/// </summary>
public class UnsubscribeFromLobbyResourceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity which performed the subscription.
    /// </summary>
    public required EntityKey EntityKey { get; set; }
    /// <summary>
    /// Opaque string, given to a client upon creating a connection with PubSub.
    /// </summary>
    public required string PubSubConnectionHandle { get; set; }
    /// <summary>
    /// The name of the resource to unsubscribe from.
    /// </summary>
    public required string ResourceId { get; set; }
    /// <summary>
    /// Version number passed for the subscription of this resource.
    /// </summary>
    public uint SubscriptionVersion { get; set; }
    /// <summary>
    /// Subscription type.
    /// </summary>
    public SubscriptionType Type { get; set; }
}

/// <summary>
/// Unsubscribe from a Match resource's notifications. For MatchInvite, players are expected to unsubscribe once they can
/// no longer accept invites. For MatchTicketStatusChange, players are expected to unsusbcribe once the ticket has reached
/// a canceled or matched state.
/// </summary>
public class UnsubscribeFromMatchResourceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity performing the unsubscription. The entity must be authorized to use this connectionHandle.
    /// </summary>
    public required EntityKey EntityKey { get; set; }
    /// <summary>
    /// Opaque string, given to a client upon creating a connection with PubSub.
    /// </summary>
    public required string PubSubConnectionHandle { get; set; }
    /// <summary>
    /// The name of the resource to unsubscribe from. It follows the format {queueName}|{ticketId} for MatchTicketStatusChange.
    /// For MatchInvite, ResourceId is @me.
    /// </summary>
    public required string ResourceId { get; set; }
    /// <summary>
    /// Version number for the unsubscription from this resource.
    /// </summary>
    public uint SubscriptionVersion { get; set; }
    /// <summary>
    /// Type of the subscription to be canceled.
    /// </summary>
    public required string Type { get; set; }
}

public class UnsubscribeFromMatchResourceResult : PlayFabResultCommon {
}

/// <summary>
/// Removes the specified tag from the image. After this operation, a 'docker pull' will fail for the specified image and
/// tag combination. Morever, ListContainerImageTags will not return the specified tag.
/// </summary>
public class UntagContainerImageRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The container image which tag we want to remove.
    /// </summary>
    public string? ImageName { get; set; }
    /// <summary>
    /// The tag we want to remove.
    /// </summary>
    public string? Tag { get; set; }
}

/// <summary>
/// Creates a multiplayer server build alias and returns the created alias.
/// </summary>
public class UpdateBuildAliasRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string alias Id of the alias to be updated.
    /// </summary>
    public required string AliasId { get; set; }
    /// <summary>
    /// The alias name.
    /// </summary>
    public string? AliasName { get; set; }
    /// <summary>
    /// Array of build selection criteria.
    /// </summary>
    public List<BuildSelectionCriterion>? BuildSelectionCriteria { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's name.
/// </summary>
public class UpdateBuildNameRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string ID of the build we want to update the name of.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The build name.
    /// </summary>
    public required string BuildName { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's region.
/// </summary>
public class UpdateBuildRegionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string ID of the build we want to update regions for.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The updated region configuration that should be applied to the specified build.
    /// </summary>
    public required BuildRegionParams BuildRegion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Updates a multiplayer server build's regions.
/// </summary>
public class UpdateBuildRegionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The guid string ID of the build we want to update regions for.
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// The updated region configuration that should be applied to the specified build.
    /// </summary>
    public required List<BuildRegionParams> BuildRegions { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// Preview: Request to update the serverData and serverEntity in case of migration. Only a game_server entity can update
/// this information and this is restricted to client owned lobbies which are using connections.
/// </summary>
public class UpdateLobbyAsServerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// The private key-value pairs which are visible to all entities in the lobby and modifiable by the joined server.
    /// Optional. Sets or updates key-value pairs on the lobby. Only the current lobby lobby server can set serverData. Keys
    /// may be an arbitrary string of at most 30 characters. The total size of all serverData values may not exceed 4096 bytes.
    /// Values are not individually limited. There can be up to 30 key-value pairs stored here. Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? ServerData { get; set; }
    /// <summary>
    /// The keys to delete from the lobby serverData. Optional. Optional. Deletes key-value pairs on the lobby. Only the
    /// current joined lobby server can delete serverData. All the specified keys will be removed from the serverData. Keys
    /// that do not exist in the lobby are a no-op. If the key to delete exists in the serverData (same request) it will result
    /// in a bad request.
    /// </summary>
    public List<string>? ServerDataToDelete { get; set; }
    /// <summary>
    /// The lobby server. Optional. Set a different server as the joined server of the lobby (there can only be 1 joined
    /// server). When changing the server the previous server will automatically be unsubscribed.
    /// </summary>
    public EntityKey? ServerEntity { get; set; }
}

/// <summary>
/// Request to update a lobby.
/// </summary>
public class UpdateLobbyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The policy indicating who is allowed to join the lobby, and the visibility to queries. May be 'Public', 'Friends' or
    /// 'Private'. Public means the lobby is both visible in queries and any player may join, including invited players.
    /// Friends means that users who are bidirectional friends of members in the lobby may search to find friend lobbies, to
    /// retrieve its connection string. Private means the lobby is not visible in queries, and a player must receive an
    /// invitation to join. Defaults to 'Public' on creation. Can only be changed by the lobby owner.
    /// </summary>
    public AccessPolicy? AccessPolicy { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The private key-value pairs which are visible to all entities in the lobby. Optional. Sets or updates key-value pairs
    /// on the lobby. Only the current lobby owner can set lobby data. Keys may be an arbitrary string of at most 30
    /// characters. The total size of all lobbyData values may not exceed 4096 bytes. Values are not individually limited.
    /// There can be up to 30 key-value pairs stored here. Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? LobbyData { get; set; }
    /// <summary>
    /// The keys to delete from the lobby LobbyData. Optional. Behaves similar to searchDataToDelete, but applies to lobbyData.
    /// </summary>
    public List<string>? LobbyDataToDelete { get; set; }
    /// <summary>
    /// The id of the lobby.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// The maximum number of players allowed in the lobby. Updates the maximum allowed number of players in the lobby. Only
    /// the current lobby owner can set this. If set, the value must be greater than or equal to the number of members
    /// currently in the lobby.
    /// </summary>
    public uint? MaxPlayers { get; set; }
    /// <summary>
    /// The private key-value pairs used by the member to communicate information to other members and the owner. Optional.
    /// Sets or updates new key-value pairs on the caller's member data. New keys will be added with their values and existing
    /// keys will be updated with the new values. Visible to all entities in the lobby. At most 30 key-value pairs may be
    /// stored here, keys are limited to 30 characters and values to 1000. The total size of all memberData values may not
    /// exceed 4096 bytes. Keys are case sensitive. Servers cannot specifiy this.
    /// </summary>
    public Dictionary<string, string>? MemberData { get; set; }
    /// <summary>
    /// The keys to delete from the lobby MemberData. Optional. Deletes key-value pairs on the caller's member data. All the
    /// specified keys will be removed from the caller's member data. Keys that do not exist are a no-op. If the key to delete
    /// exists in the memberData (same request) it will result in a bad request. Servers cannot specifiy this.
    /// </summary>
    public List<string>? MemberDataToDelete { get; set; }
    /// <summary>
    /// The member entity whose data is being modified. Servers cannot specify this.
    /// </summary>
    public EntityKey? MemberEntity { get; set; }
    /// <summary>
    /// A setting indicating whether the lobby is locked. May be 'Unlocked' or 'Locked'. When Locked new members are not
    /// allowed to join. Defaults to 'Unlocked' on creation. Can only be changed by the lobby owner.
    /// </summary>
    public MembershipLock? MembershipLock { get; set; }
    /// <summary>
    /// The lobby owner. Optional. Set to transfer ownership of the lobby. If client - owned and 'Automatic' - The Lobby
    /// service will automatically assign another connected owner when the current owner leaves or disconnects. useConnections
    /// must be true. If client - owned and 'Manual' - Ownership is protected as long as the current owner is connected. If the
    /// current owner leaves or disconnects any member may set themselves as the current owner. The useConnections property
    /// must be true. If client-owned and 'None' - Any member can set ownership. The useConnections property can be either true
    /// or false. For all client-owned lobbies when the owner leaves and a new owner can not be automatically selected - The
    /// owner field is set to null. For all client-owned lobbies when the owner disconnects and a new owner can not be
    /// automatically selected - The owner field remains unchanged and the current owner retains all owner abilities for the
    /// lobby. If server-owned (must be 'Server') - Any server can set ownership. The useConnections property must be true.
    /// </summary>
    public EntityKey? Owner { get; set; }
    /// <summary>
    /// The public key-value pairs which allow queries to differentiate between lobbies. Optional. Sets or updates key-value
    /// pairs on the lobby for use with queries. Only the current lobby owner can set search data. New keys will be added with
    /// their values and existing keys will be updated with the new values. There can be up to 30 key-value pairs stored here.
    /// Keys are of the format string_key1, string_key2... string_key30 for string values, or number_key1, number_key2, ...
    /// number_key30 for numeric values. Numeric values are floats. Values can be at most 256 characters long. The total size
    /// of all searchData values may not exceed 1024 bytes.Keys are case sensitive.
    /// </summary>
    public Dictionary<string, string>? SearchData { get; set; }
    /// <summary>
    /// The keys to delete from the lobby SearchData. Optional. Deletes key-value pairs on the lobby. Only the current lobby
    /// owner can delete search data. All the specified keys will be removed from the search data. Keys that do not exist in
    /// the lobby are a no-op.If the key to delete exists in the searchData (same request) it will result in a bad request.
    /// </summary>
    public List<string>? SearchDataToDelete { get; set; }
}

/// <summary>
/// Request to update properties of a model. A Title can make this request.
/// </summary>
public class UpdateModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// Optional new threshold value for anomalous match results in the model.
    /// </summary>
    public double? AnomalousMatchResultIgnoreThreshold { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the Model we want to update.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// Optional new friendly name for the model.
    /// </summary>
    public string? ModelName { get; set; }
    /// <summary>
    /// The ID of the Scenario that the requested model belongs to.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class UpdateModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Request to update the primary model. A Title can make this request.
/// </summary>
public class UpdatePrimaryModelRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of model that will be marked as primary.
    /// </summary>
    public required string ModelId { get; set; }
    /// <summary>
    /// The ID of the scenario to update.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class UpdatePrimaryModelResponse : PlayFabResultCommon {
}

/// <summary>
/// Request to update a scenario configuration. A Title can make this request.
/// </summary>
public class UpdateScenarioConfigurationRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of strings that represents all the conditions that are to be removed.
    /// </summary>
    public List<string>? ConditionsToRemove { get; set; }
    /// <summary>
    /// A dictionary of conditions that are to be added or updated.
    /// </summary>
    public List<ScenarioConfigCondition>? ConditionsToUpdateOrAdd { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// List of strings that represents all the events that are to be added.
    /// </summary>
    public List<string>? EventsToAdd { get; set; }
    /// <summary>
    /// List of strings that represents all the events that are to be removed.
    /// </summary>
    public List<string>? EventsToRemove { get; set; }
    /// <summary>
    /// The friendly name of the given scenario to be updated.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The Scenario ID of the given scenario.
    /// </summary>
    public required string ScenarioId { get; set; }
}

public class UpdateScenarioConfigurationResponse : PlayFabResultCommon {
}

/// <summary>
/// Uploads a multiplayer server game certificate.
/// </summary>
public class UploadCertificateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Forces the certificate renewal if the certificate already exists. Default is false
    /// </summary>
    public bool? ForceUpdate { get; set; }
    /// <summary>
    /// The game certificate to upload.
    /// </summary>
    public required Certificate GameCertificate { get; set; }
}

/// <summary>
/// Request to upload a match result. A Title or Server can upload a match result.
/// </summary>
public class UploadMatchResultRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The match result to be uploaded for computing player skills.
    /// </summary>
    public required MatchResult MatchResult { get; set; }
}

public class UploadMatchResultResponse : PlayFabResultCommon {
    /// <summary>
    /// Identifier of the MatchResult, unique within the title.
    /// </summary>
    public string? MatchResultId { get; set; }
    /// <summary>
    /// Time that the MatchResult was uploaded. Null if the upload of the given MatchResult failed.
    /// </summary>
    public required DateTime UploadTimeUtc { get; set; }
}

/// <summary>
/// Uploads a multiplayer server game secret.
/// </summary>
public class UploadSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Forces the secret renewal if the secret already exists. Default is false
    /// </summary>
    public bool? ForceUpdate { get; set; }
    /// <summary>
    /// The game secret to add.
    /// </summary>
    public required Secret GameSecret { get; set; }
}

public class VirtualMachineSummary {
    /// <summary>
    /// The virtual machine health status.
    /// </summary>
    public string? HealthStatus { get; set; }
    /// <summary>
    /// The virtual machine state.
    /// </summary>
    public string? State { get; set; }
    /// <summary>
    /// The virtual machine ID.
    /// </summary>
    public string? VmId { get; set; }
}

public class VmStartupScriptConfiguration {
    /// <summary>
    /// Optional port requests (name/protocol) that will be used by the VmStartupScript. Max of 5 requests.
    /// </summary>
    public List<VmStartupScriptPortRequest>? PortRequests { get; set; }
    /// <summary>
    /// Asset which contains the VmStartupScript script and any other required files.
    /// </summary>
    public required AssetReference VmStartupScriptAssetReference { get; set; }
}

public class VmStartupScriptParams {
    /// <summary>
    /// Optional port requests (name/protocol) that will be used by the VmStartupScript. Max of 5 requests.
    /// </summary>
    public List<VmStartupScriptPortRequestParams>? PortRequests { get; set; }
    /// <summary>
    /// Asset which contains the VmStartupScript script and any other required files.
    /// </summary>
    public required AssetReferenceParams VmStartupScriptAssetReference { get; set; }
}

public class VmStartupScriptPortRequest {
    /// <summary>
    /// The name for the port.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The protocol for the port.
    /// </summary>
    public ProtocolType Protocol { get; set; }
}

public class VmStartupScriptPortRequestParams {
    /// <summary>
    /// The name for the port.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The protocol for the port.
    /// </summary>
    public ProtocolType Protocol { get; set; }
}

public class WindowsCrashDumpConfiguration {
    /// <summary>
    /// See https://docs.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps for valid values.
    /// </summary>
    public int? CustomDumpFlags { get; set; }
    /// <summary>
    /// See https://docs.microsoft.com/en-us/windows/win32/wer/collecting-user-mode-dumps for valid values.
    /// </summary>
    public int? DumpType { get; set; }
    /// <summary>
    /// Designates whether automatic crash dump capturing will be enabled for this Build.
    /// </summary>
    public bool IsEnabled { get; set; }
}

