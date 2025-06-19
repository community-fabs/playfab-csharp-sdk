namespace CommunityFabs.NET.Sdk.Models.Admin;

/// <summary>
/// If the task instance has already completed, there will be no-op.
/// </summary>
public class AbortTaskInstanceRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string TaskInstanceId { get; set; }
}

/// <summary>
/// The work to be performed on each entity which can only be of one type.
/// </summary>
public class Action {
    public AddInventoryItemV2Content? AddInventoryItemV2Content { get; set; }
    public BanPlayerContent? BanPlayerContent { get; set; }
    public DeleteInventoryItemV2Content? DeleteInventoryItemV2Content { get; set; }
    public DeletePlayerContent? DeletePlayerContent { get; set; }
    public ExecuteCloudScriptContent? ExecuteCloudScriptContent { get; set; }
    public ExecuteFunctionContent? ExecuteFunctionContent { get; set; }
    public GrantItemContent? GrantItemContent { get; set; }
    public GrantVirtualCurrencyContent? GrantVirtualCurrencyContent { get; set; }
    public IncrementPlayerStatisticContent? IncrementPlayerStatisticContent { get; set; }
    public PushNotificationContent? PushNotificationContent { get; set; }
    public SendEmailContent? SendEmailContent { get; set; }
    public SubtractInventoryItemV2Content? SubtractInventoryItemV2Content { get; set; }
}

public class ActionsOnPlayersInSegmentTaskParameter {
    public List<Action>? Actions { get; set; }
    public required string SegmentId { get; set; }
}

public class ActionsOnPlayersInSegmentTaskSummary {
    public DateTime? CompletedAt { get; set; }
    public string? ErrorMessage { get; set; }
    public bool? ErrorWasFatal { get; set; }
    public double? EstimatedSecondsRemaining { get; set; }
    public double? PercentComplete { get; set; }
    public string? ScheduledByUserId { get; set; }
    public required DateTime StartedAt { get; set; }
    public TaskInstanceStatus? Status { get; set; }
    public NameIdentifier? TaskIdentifier { get; set; }
    public string? TaskInstanceId { get; set; }
    public int? TotalPlayersInSegment { get; set; }
    public int? TotalPlayersProcessed { get; set; }
}

public class AdCampaignAttribution {
    public required DateTime AttributedAt { get; set; }
    public string? CampaignId { get; set; }
    public string? Platform { get; set; }
}

public class AdCampaignAttributionModel {
    public required DateTime AttributedAt { get; set; }
    public string? CampaignId { get; set; }
    public string? Platform { get; set; }
}

public class AdCampaignSegmentFilter {
    public string? CampaignId { get; set; }
    public string? CampaignSource { get; set; }
    public SegmentFilterComparison? Comparison { get; set; }
}

public class AddInventoryItemsV2SegmentAction {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public int? DurationInSeconds { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class AddInventoryItemV2Content {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public int? DurationInSeconds { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class AddLocalizedNewsRequest : PlayFabRequestCommon {
    public required string Body { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Language { get; set; }
    public required string NewsId { get; set; }
    public required string Title { get; set; }
}

public class AddLocalizedNewsResult : PlayFabResultCommon {
}

public class AddNewsRequest : PlayFabRequestCommon {
    public required string Body { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public DateTime? Timestamp { get; set; }
    public required string Title { get; set; }
}

public class AddNewsResult : PlayFabResultCommon {
    public string? NewsId { get; set; }
}

/// <summary>
/// This API will trigger a player_tag_added event and add a tag with the given TagName and PlayFabID to the corresponding player profile. TagName can be used for segmentation and it is limited to 256 characters. Also there is a limit on the number of tags a title can have.
/// </summary>
public class AddPlayerTagRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string TagName { get; set; }
}

public class AddPlayerTagResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class AddServerBuildRequest : PlayFabRequestCommon {
    public List<Region>? ActiveRegions { get; set; }
    public required string BuildId { get; set; }
    public string? CommandLineTemplate { get; set; }
    public string? Comment { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ExecutablePath { get; set; }
    public int MaxGamesPerHost { get; set; }
    public int MinFreeGameSlots { get; set; }
}

[Obsolete("Do not use")]
public class AddServerBuildResult : PlayFabResultCommon {
    public List<Region>? ActiveRegions { get; set; }
    public string? BuildId { get; set; }
    public string? CommandLineTemplate { get; set; }
    public string? Comment { get; set; }
    public string? ExecutablePath { get; set; }
    public int MaxGamesPerHost { get; set; }
    public int MinFreeGameSlots { get; set; }
    public GameBuildStatus? Status { get; set; }
    public required DateTime Timestamp { get; set; }
    public string? TitleId { get; set; }
}

public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string VirtualCurrency { get; set; }
}

/// <summary>
/// This operation is additive. Any new currencies defined in the array will be added to the set of those available for the title, while any CurrencyCode identifiers matching existing ones in the game will be overwritten with the new values.
/// </summary>
public class AddVirtualCurrencyTypesRequest : PlayFabRequestCommon {
    public required List<VirtualCurrencyData> VirtualCurrencies { get; set; }
}

public class AllPlayersSegmentFilter {
}

public class ApiCondition {
    public Conditionals? HasSignatureOrEncryption { get; set; }
}

public enum AuthTokenType {
    Email,
}

/// <summary>
/// Contains information for a ban.
/// </summary>
public class BanInfo {
    public bool Active { get; set; }
    public string? BanId { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Expires { get; set; }
    public bool? IncludeMicrosoftFamily { get; set; }
    public string? IPAddress { get; set; }
    public string? MACAddress { get; set; }
    public string? PlayFabId { get; set; }
    public string? Reason { get; set; }
    public string? UserFamilyType { get; set; }
}

public class BanPlayerContent {
    public int? BanDurationHours { get; set; }
    public string? BanReason { get; set; }
}

public class BanPlayerSegmentAction {
    public UInt32? BanHours { get; set; }
    public string? ReasonForBan { get; set; }
}

/// <summary>
/// Represents a single ban request.
/// </summary>
public class BanRequest {
    public UInt32? DurationInHours { get; set; }
    public bool? IncludeMicrosoftFamily { get; set; }
    public string? IPAddress { get; set; }
    public string? MACAddress { get; set; }
    public required string PlayFabId { get; set; }
    public string? Reason { get; set; }
    public UserFamilyType? UserFamilyType { get; set; }
}

/// <summary>
/// The existence of each user will not be verified. When banning by IP or MAC address, multiple players may be affected, so use this feature with caution. Returns information about the new bans.
/// </summary>
public class BanUsersRequest : PlayFabRequestCommon {
    public required List<BanRequest> Bans { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class BanUsersResult : PlayFabResultCommon {
    public List<BanInfo>? BanData { get; set; }
}

public class BlankResult : PlayFabResultCommon {
}

/// <summary>
/// A purchasable item from the item catalog
/// </summary>
public class CatalogItem {
    public CatalogItemBundleInfo? Bundle { get; set; }
    public bool CanBecomeCharacter { get; set; }
    public string? CatalogVersion { get; set; }
    public CatalogItemConsumableInfo? Consumable { get; set; }
    public CatalogItemContainerInfo? Container { get; set; }
    public string? CustomData { get; set; }
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public int InitialLimitedEditionCount { get; set; }
    public bool IsLimitedEdition { get; set; }
    public bool IsStackable { get; set; }
    public bool IsTradable { get; set; }
    public string? ItemClass { get; set; }
    public required string ItemId { get; set; }
    public string? ItemImageUrl { get; set; }
    public Dictionary<string, UInt32>? RealCurrencyPrices { get; set; }
    public List<string>? Tags { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrencyPrices { get; set; }
}

public class CatalogItemBundleInfo {
    public List<string>? BundledItems { get; set; }
    public List<string>? BundledResultTables { get; set; }
    public Dictionary<string, UInt32>? BundledVirtualCurrencies { get; set; }
}

public class CatalogItemConsumableInfo {
    public UInt32? UsageCount { get; set; }
    public UInt32? UsagePeriod { get; set; }
    public string? UsagePeriodGroup { get; set; }
}

/// <summary>
/// Containers are inventory items that can hold other items defined in the catalog, as well as virtual currency, which is added to the player inventory when the container is unlocked, using the UnlockContainerItem API. The items can be anything defined in the catalog, as well as RandomResultTable objects which will be resolved when the container is unlocked. Containers and their keys should be defined as Consumable (having a limited number of uses) in their catalog defintiions, unless the intent is for the player to be able to re-use them infinitely.
/// </summary>
public class CatalogItemContainerInfo {
    public List<string>? ItemContents { get; set; }
    public string? KeyItemId { get; set; }
    public List<string>? ResultTableContents { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrencyContents { get; set; }
}

/// <summary>
/// This returns the total number of these items available.
/// </summary>
public class CheckLimitedEditionItemAvailabilityRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string ItemId { get; set; }
}

public class CheckLimitedEditionItemAvailabilityResult : PlayFabResultCommon {
    public int Amount { get; set; }
}

public class ChurnPredictionSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public enum ChurnRiskLevel {
    NoData,
    LowRisk,
    MediumRisk,
    HighRisk,
}

public class CloudScriptAzureFunctionsTaskParameter {
    public object? Argument { get; set; }
    public string? FunctionName { get; set; }
}

public class CloudScriptAzureFunctionsTaskSummary {
    public DateTime? CompletedAt { get; set; }
    public string? Error { get; set; }
    public double? EstimatedSecondsRemaining { get; set; }
    public double? PercentComplete { get; set; }
    public ExecuteFunctionResult? Result { get; set; }
    public string? ScheduledByUserId { get; set; }
    public required DateTime StartedAt { get; set; }
    public TaskInstanceStatus? Status { get; set; }
    public NameIdentifier? TaskIdentifier { get; set; }
    public string? TaskInstanceId { get; set; }
}

public class CloudScriptFile {
    public required string FileContents { get; set; }
    public required string Filename { get; set; }
}

public class CloudScriptTaskParameter {
    public object? Argument { get; set; }
    public string? FunctionName { get; set; }
}

public class CloudScriptTaskSummary {
    public DateTime? CompletedAt { get; set; }
    public double? EstimatedSecondsRemaining { get; set; }
    public double? PercentComplete { get; set; }
    public ExecuteCloudScriptResult? Result { get; set; }
    public string? ScheduledByUserId { get; set; }
    public required DateTime StartedAt { get; set; }
    public TaskInstanceStatus? Status { get; set; }
    public NameIdentifier? TaskIdentifier { get; set; }
    public string? TaskInstanceId { get; set; }
}

public class CloudScriptVersionStatus {
    public int LatestRevision { get; set; }
    public int PublishedRevision { get; set; }
    public int Version { get; set; }
}

public enum Conditionals {
    Any,
    True,
    False,
}

public class ContactEmailInfo {
    public string? EmailAddress { get; set; }
    public string? Name { get; set; }
    public EmailVerificationStatus? VerificationStatus { get; set; }
}

public class ContactEmailInfoModel {
    public string? EmailAddress { get; set; }
    public string? Name { get; set; }
    public EmailVerificationStatus? VerificationStatus { get; set; }
}

public class ContentInfo {
    public string? Key { get; set; }
    public required DateTime LastModified { get; set; }
    public required double Size { get; set; }
}

public enum ContinentCode {
    AF,
    AN,
    AS,
    EU,
    NA,
    OC,
    SA,
    Unknown,
}

public enum CountryCode {
    AF,
    AX,
    AL,
    DZ,
    AS,
    AD,
    AO,
    AI,
    AQ,
    AG,
    AR,
    AM,
    AW,
    AU,
    AT,
    AZ,
    BS,
    BH,
    BD,
    BB,
    BY,
    BE,
    BZ,
    BJ,
    BM,
    BT,
    BO,
    BQ,
    BA,
    BW,
    BV,
    BR,
    IO,
    BN,
    BG,
    BF,
    BI,
    KH,
    CM,
    CA,
    CV,
    KY,
    CF,
    TD,
    CL,
    CN,
    CX,
    CC,
    CO,
    KM,
    CG,
    CD,
    CK,
    CR,
    CI,
    HR,
    CU,
    CW,
    CY,
    CZ,
    DK,
    DJ,
    DM,
    DO,
    EC,
    EG,
    SV,
    GQ,
    ER,
    EE,
    ET,
    FK,
    FO,
    FJ,
    FI,
    FR,
    GF,
    PF,
    TF,
    GA,
    GM,
    GE,
    DE,
    GH,
    GI,
    GR,
    GL,
    GD,
    GP,
    GU,
    GT,
    GG,
    GN,
    GW,
    GY,
    HT,
    HM,
    VA,
    HN,
    HK,
    HU,
    IS,
    IN,
    ID,
    IR,
    IQ,
    IE,
    IM,
    IL,
    IT,
    JM,
    JP,
    JE,
    JO,
    KZ,
    KE,
    KI,
    KP,
    KR,
    KW,
    KG,
    LA,
    LV,
    LB,
    LS,
    LR,
    LY,
    LI,
    LT,
    LU,
    MO,
    MK,
    MG,
    MW,
    MY,
    MV,
    ML,
    MT,
    MH,
    MQ,
    MR,
    MU,
    YT,
    MX,
    FM,
    MD,
    MC,
    MN,
    ME,
    MS,
    MA,
    MZ,
    MM,
    NA,
    NR,
    NP,
    NL,
    NC,
    NZ,
    NI,
    NE,
    NG,
    NU,
    NF,
    MP,
    NO,
    OM,
    PK,
    PW,
    PS,
    PA,
    PG,
    PY,
    PE,
    PH,
    PN,
    PL,
    PT,
    PR,
    QA,
    RE,
    RO,
    RU,
    RW,
    BL,
    SH,
    KN,
    LC,
    MF,
    PM,
    VC,
    WS,
    SM,
    ST,
    SA,
    SN,
    RS,
    SC,
    SL,
    SG,
    SX,
    SK,
    SI,
    SB,
    SO,
    ZA,
    GS,
    SS,
    ES,
    LK,
    SD,
    SR,
    SJ,
    SZ,
    SE,
    CH,
    SY,
    TW,
    TJ,
    TZ,
    TH,
    TL,
    TG,
    TK,
    TO,
    TT,
    TN,
    TR,
    TM,
    TC,
    TV,
    UG,
    UA,
    AE,
    GB,
    US,
    UM,
    UY,
    UZ,
    VU,
    VE,
    VN,
    VG,
    VI,
    WF,
    EH,
    YE,
    ZM,
    ZW,
    Unknown,
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateActionsOnPlayerSegmentTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public required ActionsOnPlayersInSegmentTaskParameter Parameter { get; set; }
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateCloudScriptAzureFunctionsTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public required CloudScriptAzureFunctionsTaskParameter Parameter { get; set; }
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateCloudScriptTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public required CloudScriptTaskParameter Parameter { get; set; }
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateInsightsScheduledScalingTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public required InsightsScalingTaskParameter Parameter { get; set; }
    public string? Schedule { get; set; }
}

public class CreateOpenIdConnectionRequest : PlayFabRequestCommon {
    public required string ClientId { get; set; }
    public required string ClientSecret { get; set; }
    public required string ConnectionId { get; set; }
    public bool? IgnoreNonce { get; set; }
    public string? IssuerDiscoveryUrl { get; set; }
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    public string? IssuerOverride { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class CreatePlayerSharedSecretRequest : PlayFabRequestCommon {
    public string? FriendlyName { get; set; }
}

public class CreatePlayerSharedSecretResult : PlayFabResultCommon {
    public string? SecretKey { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval enables automatically resetting leaderboards on a specified interval. Upon reset, the statistic updates to a new version with no values (effectively removing all players from the leaderboard). The previous version's statistic values are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short, pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also, once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version information (GetPlayerStatisticVersions). The AggregationMethod determines what action is taken when a new statistic value is submitted - always update with the new value (Last), use the highest of the old and new values (Max), use the smallest (Min), or add them together (Sum).
/// </summary>
public class CreatePlayerStatisticDefinitionRequest : PlayFabRequestCommon {
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string StatisticName { get; set; }
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class CreatePlayerStatisticDefinitionResult : PlayFabResultCommon {
    public PlayerStatisticDefinition? Statistic { get; set; }
}

/// <summary>
/// Send all the segment details part of CreateSegmentRequest
/// </summary>
public class CreateSegmentRequest : PlayFabRequestCommon {
    public required SegmentModel SegmentModel { get; set; }
}

public class CreateSegmentResponse : PlayFabResultCommon {
    public string? ErrorMessage { get; set; }
    public string? SegmentId { get; set; }
}

public class CreateTaskResult : PlayFabResultCommon {
    public string? TaskId { get; set; }
}

public enum Currency {
    AED,
    AFN,
    ALL,
    AMD,
    ANG,
    AOA,
    ARS,
    AUD,
    AWG,
    AZN,
    BAM,
    BBD,
    BDT,
    BGN,
    BHD,
    BIF,
    BMD,
    BND,
    BOB,
    BRL,
    BSD,
    BTN,
    BWP,
    BYR,
    BZD,
    CAD,
    CDF,
    CHF,
    CLP,
    CNY,
    COP,
    CRC,
    CUC,
    CUP,
    CVE,
    CZK,
    DJF,
    DKK,
    DOP,
    DZD,
    EGP,
    ERN,
    ETB,
    EUR,
    FJD,
    FKP,
    GBP,
    GEL,
    GGP,
    GHS,
    GIP,
    GMD,
    GNF,
    GTQ,
    GYD,
    HKD,
    HNL,
    HRK,
    HTG,
    HUF,
    IDR,
    ILS,
    IMP,
    INR,
    IQD,
    IRR,
    ISK,
    JEP,
    JMD,
    JOD,
    JPY,
    KES,
    KGS,
    KHR,
    KMF,
    KPW,
    KRW,
    KWD,
    KYD,
    KZT,
    LAK,
    LBP,
    LKR,
    LRD,
    LSL,
    LYD,
    MAD,
    MDL,
    MGA,
    MKD,
    MMK,
    MNT,
    MOP,
    MRO,
    MUR,
    MVR,
    MWK,
    MXN,
    MYR,
    MZN,
    NAD,
    NGN,
    NIO,
    NOK,
    NPR,
    NZD,
    OMR,
    PAB,
    PEN,
    PGK,
    PHP,
    PKR,
    PLN,
    PYG,
    QAR,
    RON,
    RSD,
    RUB,
    RWF,
    SAR,
    SBD,
    SCR,
    SDG,
    SEK,
    SGD,
    SHP,
    SLL,
    SOS,
    SPL,
    SRD,
    STD,
    SVC,
    SYP,
    SZL,
    THB,
    TJS,
    TMT,
    TND,
    TOP,
    TRY,
    TTD,
    TVD,
    TWD,
    TZS,
    UAH,
    UGX,
    USD,
    UYU,
    UZS,
    VEF,
    VND,
    VUV,
    WST,
    XAF,
    XCD,
    XDR,
    XOF,
    XPF,
    YER,
    ZAR,
    ZMW,
    ZWD,
}

public class CustomPropertyBooleanSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? PropertyName { get; set; }
    public bool PropertyValue { get; set; }
}

public class CustomPropertyDateTimeSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? PropertyName { get; set; }
    public required DateTime PropertyValue { get; set; }
}

public class CustomPropertyDetails {
    public string? Name { get; set; }
    public object? Value { get; set; }
}

public class CustomPropertyNumericSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? PropertyName { get; set; }
    public required double PropertyValue { get; set; }
}

public class CustomPropertyStringSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? PropertyName { get; set; }
    public string? PropertyValue { get; set; }
}

public class DeleteContentRequest : PlayFabRequestCommon {
    public required string Key { get; set; }
}

public class DeletedPropertyDetails {
    public string? Name { get; set; }
    public bool WasDeleted { get; set; }
}

/// <summary>
/// The request must contain the name of the sink to be deleted. 
/// </summary>
public class DeleteEventSinkRequest : PlayFabRequestCommon {
    public required string Name { get; set; }
}

public class DeleteEventSinkResult : PlayFabResultCommon {
}

public class DeleteInventoryItemsV2SegmentAction {
    public string? CollectionId { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class DeleteInventoryItemV2Content {
    public string? CollectionId { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

/// <summary>
/// Deletes all data associated with the master player account, including data from all titles the player has played, such as statistics, custom data, inventory, purchases, virtual currency balances, characters, group memberships, publisher data, credential data, account linkages, friends list, PlayStream event data, and telemetry event data. Removes the player from all leaderboards and player search indexes. Note, this API queues the player for deletion and returns a receipt immediately. Record the receipt ID for future reference. It may take some time before all player data is fully deleted. Upon completion of the deletion, an email will be sent to the notification email address configured for the title confirming the deletion. Until the player data is fully deleted, attempts to recreate the player with the same user account in the same title will fail with the 'AccountDeleted' error. It is highly recommended to know the impact of the deletion by calling GetPlayedTitleList, before calling this API.
/// </summary>
public class DeleteMasterPlayerAccountRequest : PlayFabRequestCommon {
    public string? MetaData { get; set; }
    public required string PlayFabId { get; set; }
}

public class DeleteMasterPlayerAccountResult : PlayFabResultCommon {
    public string? JobReceiptId { get; set; }
    public List<string>? TitleIds { get; set; }
}

/// <summary>
/// Deletes any PlayStream or telemetry event associated with the player from PlayFab. Note, this API queues the data for asynchronous deletion. It may take some time before the data is deleted.
/// </summary>
public class DeleteMasterPlayerEventDataRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class DeleteMasterPlayerEventDataResult : PlayFabResultCommon {
}

/// <summary>
/// This API lets developers delete a membership subscription.
/// </summary>
public class DeleteMembershipSubscriptionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string MembershipId { get; set; }
    public required string PlayFabId { get; set; }
    public required string SubscriptionId { get; set; }
}

public class DeleteMembershipSubscriptionResult : PlayFabResultCommon {
}

public class DeleteOpenIdConnectionRequest : PlayFabRequestCommon {
    public required string ConnectionId { get; set; }
}

public class DeletePlayerContent {
}

/// <summary>
/// Deletes custom properties for the specified player. The list of provided property names must be non-empty.
/// </summary>
public class DeletePlayerCustomPropertiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? ExpectedPropertiesVersion { get; set; }
    public required string PlayFabId { get; set; }
    public required List<string> PropertyNames { get; set; }
}

public class DeletePlayerCustomPropertiesResult : PlayFabResultCommon {
    public List<DeletedPropertyDetails>? DeletedProperties { get; set; }
    public string? PlayFabId { get; set; }
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Deletes all data associated with the player, including statistics, custom data, inventory, purchases, virtual currency balances, characters and shared group memberships. Removes the player from all leaderboards and player search indexes. Does not delete PlayStream event history associated with the player. Does not delete the publisher user account that created the player in the title nor associated data such as username, password, email address, account linkages, or friends list. Note, this API queues the player for deletion and returns immediately. It may take several minutes or more before all player data is fully deleted. Until the player data is fully deleted, attempts to recreate the player with the same user account in the same title will fail with the 'AccountDeleted' error.
/// </summary>
public class DeletePlayerRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class DeletePlayerResult : PlayFabResultCommon {
}

public class DeletePlayerSegmentAction {
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class DeletePlayerSharedSecretRequest : PlayFabRequestCommon {
    public string? SecretKey { get; set; }
}

public class DeletePlayerSharedSecretResult : PlayFabResultCommon {
}

public class DeletePlayerStatisticSegmentAction {
    public string? StatisticName { get; set; }
}

/// <summary>
/// Send segment id planning to delete part of DeleteSegmentRequest object
/// </summary>
public class DeleteSegmentRequest : PlayFabRequestCommon {
    public required string SegmentId { get; set; }
}

public class DeleteSegmentsResponse : PlayFabResultCommon {
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// This non-reversible operation will permanently delete the requested store.
/// </summary>
public class DeleteStoreRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string StoreId { get; set; }
}

public class DeleteStoreResult : PlayFabResultCommon {
}

/// <summary>
/// After a task is deleted, for tracking purposes, the task instances belonging to this task will still remain. They will become orphaned and does not belongs to any task. Executions of any in-progress task instances will continue. If the task specified does not exist, the deletion is considered a success.
/// </summary>
public class DeleteTaskRequest : PlayFabRequestCommon {
    public NameIdentifier? Identifier { get; set; }
}

/// <summary>
/// Will delete all the title data associated with the given override label.
/// </summary>
public class DeleteTitleDataOverrideRequest : PlayFabRequestCommon {
    public required string OverrideLabel { get; set; }
}

public class DeleteTitleDataOverrideResult : PlayFabResultCommon {
}

/// <summary>
/// Deletes all data associated with the title, including catalog, virtual currencies, leaderboard statistics, Cloud Script revisions, segment definitions, event rules, tasks, add-ons, secret keys, data encryption keys, and permission policies. Removes the title from its studio and removes all associated developer roles and permissions. Does not delete PlayStream event history associated with the title. Note, this API queues the title for deletion and returns immediately. It may take several hours or more before all title data is fully deleted. All player accounts in the title must be deleted before deleting the title. If any player accounts exist, the API will return a 'TitleContainsUserAccounts' error. Until the title data is fully deleted, attempts to call APIs with the title will fail with the 'TitleDeleted' error.
/// </summary>
public class DeleteTitleRequest : PlayFabRequestCommon {
}

public class DeleteTitleResult : PlayFabResultCommon {
}

/// <summary>
/// Note that this action cannot be undone. It will unlink all accounts and remove all PII information, as well as reset any statistics and leaderboards and clear out any stored custom data for the user.
/// </summary>
[Obsolete("Do not use")]
public class DeleteUsersRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<string> PlayFabIds { get; set; }
}

[Obsolete("Do not use")]
public class DeleteUsersResult : PlayFabResultCommon {
}

public enum EffectType {
    Allow,
    Deny,
}

public class EmailNotificationSegmentAction {
    public string? EmailTemplateId { get; set; }
    public string? EmailTemplateName { get; set; }
}

public enum EmailVerificationStatus {
    Unverified,
    Pending,
    Confirmed,
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class ErrorDetails {
    public string? Code { get; set; }
    public required DateTime StartTime { get; set; }
}

public class EventSink {
    public ExternalDestinationType DestinationType { get; set; }
    public ErrorDetails? Error { get; set; }
    public bool IsEnabled { get; set; }
    public required string Name { get; set; }
    public required object SinkSettings { get; set; }
}

public class ExecuteAzureFunctionSegmentAction {
    public string? AzureFunction { get; set; }
    public object? FunctionParameter { get; set; }
    public bool GenerateFunctionExecutedEvents { get; set; }
}

public class ExecuteCloudScriptContent {
    public required string CloudScriptMethodArguments { get; set; }
    public required string CloudScriptMethodName { get; set; }
    public bool PublishResultsToPlayStream { get; set; }
}

public class ExecuteCloudScriptResult {
    public int APIRequestsIssued { get; set; }
    public ScriptExecutionError? Error { get; set; }
    public required double ExecutionTimeSeconds { get; set; }
    public string? FunctionName { get; set; }
    public object? FunctionResult { get; set; }
    public bool? FunctionResultTooLarge { get; set; }
    public int HttpRequestsIssued { get; set; }
    public List<LogStatement>? Logs { get; set; }
    public bool? LogsTooLarge { get; set; }
    public UInt32 MemoryConsumedBytes { get; set; }
    public required double ProcessorTimeSeconds { get; set; }
    public int Revision { get; set; }
}

public class ExecuteCloudScriptSegmentAction {
    public string? CloudScriptFunction { get; set; }
    public bool CloudScriptPublishResultsToPlayStream { get; set; }
    public object? FunctionParameter { get; set; }
    public string? FunctionParameterJson { get; set; }
}

public class ExecuteFunctionContent {
    public required string CloudScriptFunctionArguments { get; set; }
    public required string CloudScriptFunctionName { get; set; }
    public bool PublishResultsToPlayStream { get; set; }
}

public class ExecuteFunctionResult {
    public FunctionExecutionError? Error { get; set; }
    public int ExecutionTimeMilliseconds { get; set; }
    public string? FunctionName { get; set; }
    public object? FunctionResult { get; set; }
    public bool? FunctionResultTooLarge { get; set; }
}

/// <summary>
/// Exports all data associated with the master player account, including data from all titles the player has played, such as statistics, custom data, inventory, purchases, virtual currency balances, characters, group memberships, publisher data, credential data, account linkages, friends list, PlayStream event data, and telemetry event data. Note, this API queues the player for export and returns a receipt immediately. Record the receipt ID for future reference. It may take some time before the export is available for download. Upon completion of the export, an email containing the URL to download the export dump will be sent to the notification email address configured for the title.
/// </summary>
public class ExportMasterPlayerDataRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class ExportMasterPlayerDataResult : PlayFabResultCommon {
    public string? JobReceiptId { get; set; }
}

/// <summary>
/// Request must contain the Segment ID
/// </summary>
public class ExportPlayersInSegmentRequest : PlayFabRequestCommon {
    public required string SegmentId { get; set; }
}

public class ExportPlayersInSegmentResult : PlayFabResultCommon {
    public string? ExportId { get; set; }
    public string? SegmentId { get; set; }
}

public enum ExternalDestinationType {
    AzureBlobStorage,
    AzureDataExplorer,
    AzureBlobDelta,
}

public class FirstLoginDateSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public required DateTime LogInDate { get; set; }
}

public class FirstLoginTimespanSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public required double DurationInMinutes { get; set; }
}

public class FunctionExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

public enum GameBuildStatus {
    Available,
    Validating,
    InvalidBuildPackage,
    Processing,
    FailedToProcess,
}

[Obsolete("Do not use")]
public class GameModeInfo {
    public required string Gamemode { get; set; }
    public UInt32 MaxPlayerCount { get; set; }
    public UInt32 MinPlayerCount { get; set; }
    public bool? StartOpen { get; set; }
}

public enum GenericErrorCodes {
    Success,
    UnkownError,
    InvalidParams,
    AccountNotFound,
    AccountBanned,
    InvalidUsernameOrPassword,
    InvalidTitleId,
    InvalidEmailAddress,
    EmailAddressNotAvailable,
    InvalidUsername,
    InvalidPassword,
    UsernameNotAvailable,
    InvalidSteamTicket,
    AccountAlreadyLinked,
    LinkedAccountAlreadyClaimed,
    InvalidFacebookToken,
    AccountNotLinked,
    FailedByPaymentProvider,
    CouponCodeNotFound,
    InvalidContainerItem,
    ContainerNotOwned,
    KeyNotOwned,
    InvalidItemIdInTable,
    InvalidReceipt,
    ReceiptAlreadyUsed,
    ReceiptCancelled,
    GameNotFound,
    GameModeNotFound,
    InvalidGoogleToken,
    UserIsNotPartOfDeveloper,
    InvalidTitleForDeveloper,
    TitleNameConflicts,
    UserisNotValid,
    ValueAlreadyExists,
    BuildNotFound,
    PlayerNotInGame,
    InvalidTicket,
    InvalidDeveloper,
    InvalidOrderInfo,
    RegistrationIncomplete,
    InvalidPlatform,
    UnknownError,
    SteamApplicationNotOwned,
    WrongSteamAccount,
    TitleNotActivated,
    RegistrationSessionNotFound,
    NoSuchMod,
    FileNotFound,
    DuplicateEmail,
    ItemNotFound,
    ItemNotOwned,
    ItemNotRecycleable,
    ItemNotAffordable,
    InvalidVirtualCurrency,
    WrongVirtualCurrency,
    WrongPrice,
    NonPositiveValue,
    InvalidRegion,
    RegionAtCapacity,
    ServerFailedToStart,
    NameNotAvailable,
    InsufficientFunds,
    InvalidDeviceID,
    InvalidPushNotificationToken,
    NoRemainingUses,
    InvalidPaymentProvider,
    PurchaseInitializationFailure,
    DuplicateUsername,
    InvalidBuyerInfo,
    NoGameModeParamsSet,
    BodyTooLarge,
    ReservedWordInBody,
    InvalidTypeInBody,
    InvalidRequest,
    ReservedEventName,
    InvalidUserStatistics,
    NotAuthenticated,
    StreamAlreadyExists,
    ErrorCreatingStream,
    StreamNotFound,
    InvalidAccount,
    PurchaseDoesNotExist,
    InvalidPurchaseTransactionStatus,
    APINotEnabledForGameClientAccess,
    NoPushNotificationARNForTitle,
    BuildAlreadyExists,
    BuildPackageDoesNotExist,
    CustomAnalyticsEventsNotEnabledForTitle,
    InvalidSharedGroupId,
    NotAuthorized,
    MissingTitleGoogleProperties,
    InvalidItemProperties,
    InvalidPSNAuthCode,
    InvalidItemId,
    PushNotEnabledForAccount,
    PushServiceError,
    ReceiptDoesNotContainInAppItems,
    ReceiptContainsMultipleInAppItems,
    InvalidBundleID,
    JavascriptException,
    InvalidSessionTicket,
    UnableToConnectToDatabase,
    InternalServerError,
    InvalidReportDate,
    DatabaseThroughputExceeded,
    InvalidGameTicket,
    ExpiredGameTicket,
    GameTicketDoesNotMatchLobby,
    LinkedDeviceAlreadyClaimed,
    DeviceAlreadyLinked,
    DeviceNotLinked,
    PartialFailure,
    PublisherNotSet,
    ServiceUnavailable,
    VersionNotFound,
    RevisionNotFound,
    InvalidPublisherId,
    DownstreamServiceUnavailable,
    APINotIncludedInTitleUsageTier,
    DAULimitExceeded,
    APIRequestLimitExceeded,
    InvalidAPIEndpoint,
    BuildNotAvailable,
    ConcurrentEditError,
    ContentNotFound,
    CharacterNotFound,
    CloudScriptNotFound,
    ContentQuotaExceeded,
    InvalidCharacterStatistics,
    PhotonNotEnabledForTitle,
    PhotonApplicationNotFound,
    PhotonApplicationNotAssociatedWithTitle,
    InvalidEmailOrPassword,
    FacebookAPIError,
    InvalidContentType,
    KeyLengthExceeded,
    DataLengthExceeded,
    TooManyKeys,
    FreeTierCannotHaveVirtualCurrency,
    MissingAmazonSharedKey,
    AmazonValidationError,
    InvalidPSNIssuerId,
    PSNInaccessible,
    ExpiredAuthToken,
    FailedToGetEntitlements,
    FailedToConsumeEntitlement,
    TradeAcceptingUserNotAllowed,
    TradeInventoryItemIsAssignedToCharacter,
    TradeInventoryItemIsBundle,
    TradeStatusNotValidForCancelling,
    TradeStatusNotValidForAccepting,
    TradeDoesNotExist,
    TradeCancelled,
    TradeAlreadyFilled,
    TradeWaitForStatusTimeout,
    TradeInventoryItemExpired,
    TradeMissingOfferedAndAcceptedItems,
    TradeAcceptedItemIsBundle,
    TradeAcceptedItemIsStackable,
    TradeInventoryItemInvalidStatus,
    TradeAcceptedCatalogItemInvalid,
    TradeAllowedUsersInvalid,
    TradeInventoryItemDoesNotExist,
    TradeInventoryItemIsConsumed,
    TradeInventoryItemIsStackable,
    TradeAcceptedItemsMismatch,
    InvalidKongregateToken,
    FeatureNotConfiguredForTitle,
    NoMatchingCatalogItemForReceipt,
    InvalidCurrencyCode,
    NoRealMoneyPriceForCatalogItem,
    TradeInventoryItemIsNotTradable,
    TradeAcceptedCatalogItemIsNotTradable,
    UsersAlreadyFriends,
    LinkedIdentifierAlreadyClaimed,
    CustomIdNotLinked,
    TotalDataSizeExceeded,
    DeleteKeyConflict,
    InvalidXboxLiveToken,
    ExpiredXboxLiveToken,
    ResettableStatisticVersionRequired,
    NotAuthorizedByTitle,
    NoPartnerEnabled,
    InvalidPartnerResponse,
    APINotEnabledForGameServerAccess,
    StatisticNotFound,
    StatisticNameConflict,
    StatisticVersionClosedForWrites,
    StatisticVersionInvalid,
    APIClientRequestRateLimitExceeded,
    InvalidJSONContent,
    InvalidDropTable,
    StatisticVersionAlreadyIncrementedForScheduledInterval,
    StatisticCountLimitExceeded,
    StatisticVersionIncrementRateExceeded,
    ContainerKeyInvalid,
    CloudScriptExecutionTimeLimitExceeded,
    NoWritePermissionsForEvent,
    CloudScriptFunctionArgumentSizeExceeded,
    CloudScriptAPIRequestCountExceeded,
    CloudScriptAPIRequestError,
    CloudScriptHTTPRequestError,
    InsufficientGuildRole,
    GuildNotFound,
    OverLimit,
    EventNotFound,
    InvalidEventField,
    InvalidEventName,
    CatalogNotConfigured,
    OperationNotSupportedForPlatform,
    SegmentNotFound,
    StoreNotFound,
    InvalidStatisticName,
    TitleNotQualifiedForLimit,
    InvalidServiceLimitLevel,
    ServiceLimitLevelInTransition,
    CouponAlreadyRedeemed,
    GameServerBuildSizeLimitExceeded,
    GameServerBuildCountLimitExceeded,
    VirtualCurrencyCountLimitExceeded,
    VirtualCurrencyCodeExists,
    TitleNewsItemCountLimitExceeded,
    InvalidTwitchToken,
    TwitchResponseError,
    ProfaneDisplayName,
    UserAlreadyAdded,
    InvalidVirtualCurrencyCode,
    VirtualCurrencyCannotBeDeleted,
    IdentifierAlreadyClaimed,
    IdentifierNotLinked,
    InvalidContinuationToken,
    ExpiredContinuationToken,
    InvalidSegment,
    InvalidSessionId,
    SessionLogNotFound,
    InvalidSearchTerm,
    TwoFactorAuthenticationTokenRequired,
    GameServerHostCountLimitExceeded,
    PlayerTagCountLimitExceeded,
    RequestAlreadyRunning,
    ActionGroupNotFound,
    MaximumSegmentBulkActionJobsRunning,
    NoActionsOnPlayersInSegmentJob,
    DuplicateStatisticName,
    ScheduledTaskNameConflict,
    ScheduledTaskCreateConflict,
    InvalidScheduledTaskName,
    InvalidTaskSchedule,
    SteamNotEnabledForTitle,
    LimitNotAnUpgradeOption,
    NoSecretKeyEnabledForCloudScript,
    TaskNotFound,
    TaskInstanceNotFound,
    InvalidIdentityProviderId,
    MisconfiguredIdentityProvider,
    InvalidScheduledTaskType,
    BillingInformationRequired,
    LimitedEditionItemUnavailable,
    InvalidAdPlacementAndReward,
    AllAdPlacementViewsAlreadyConsumed,
    GoogleOAuthNotConfiguredForTitle,
    GoogleOAuthError,
    UserNotFriend,
    InvalidSignature,
    InvalidPublicKey,
    GoogleOAuthNoIdTokenIncludedInResponse,
    StatisticUpdateInProgress,
    LeaderboardVersionNotAvailable,
    StatisticAlreadyHasPrizeTable,
    PrizeTableHasOverlappingRanks,
    PrizeTableHasMissingRanks,
    PrizeTableRankStartsAtZero,
    InvalidStatistic,
    ExpressionParseFailure,
    ExpressionInvokeFailure,
    ExpressionTooLong,
    DataUpdateRateExceeded,
    RestrictedEmailDomain,
    EncryptionKeyDisabled,
    EncryptionKeyMissing,
    EncryptionKeyBroken,
    NoSharedSecretKeyConfigured,
    SecretKeyNotFound,
    PlayerSecretAlreadyConfigured,
    APIRequestsDisabledForTitle,
    InvalidSharedSecretKey,
    PrizeTableHasNoRanks,
    ProfileDoesNotExist,
    ContentS3OriginBucketNotConfigured,
    InvalidEnvironmentForReceipt,
    EncryptedRequestNotAllowed,
    SignedRequestNotAllowed,
    RequestViewConstraintParamsNotAllowed,
    BadPartnerConfiguration,
    XboxBPCertificateFailure,
    XboxXASSExchangeFailure,
    InvalidEntityId,
    StatisticValueAggregationOverflow,
    EmailMessageFromAddressIsMissing,
    EmailMessageToAddressIsMissing,
    SmtpServerAuthenticationError,
    SmtpServerLimitExceeded,
    SmtpServerInsufficientStorage,
    SmtpServerCommunicationError,
    SmtpServerGeneralFailure,
    EmailClientTimeout,
    EmailClientCanceledTask,
    EmailTemplateMissing,
    InvalidHostForTitleId,
    EmailConfirmationTokenDoesNotExist,
    EmailConfirmationTokenExpired,
    AccountDeleted,
    PlayerSecretNotConfigured,
    InvalidSignatureTime,
    NoContactEmailAddressFound,
    InvalidAuthToken,
    AuthTokenDoesNotExist,
    AuthTokenExpired,
    AuthTokenAlreadyUsedToResetPassword,
    MembershipNameTooLong,
    MembershipNotFound,
    GoogleServiceAccountInvalid,
    GoogleServiceAccountParseFailure,
    EntityTokenMissing,
    EntityTokenInvalid,
    EntityTokenExpired,
    EntityTokenRevoked,
    InvalidProductForSubscription,
    XboxInaccessible,
    SubscriptionAlreadyTaken,
    SmtpAddonNotEnabled,
    APIConcurrentRequestLimitExceeded,
    XboxRejectedXSTSExchangeRequest,
    VariableNotDefined,
    TemplateVersionNotDefined,
    FileTooLarge,
    TitleDeleted,
    TitleContainsUserAccounts,
    TitleDeletionPlayerCleanupFailure,
    EntityFileOperationPending,
    NoEntityFileOperationPending,
    EntityProfileVersionMismatch,
    TemplateVersionTooOld,
    MembershipDefinitionInUse,
    PaymentPageNotConfigured,
    FailedLoginAttemptRateLimitExceeded,
    EntityBlockedByGroup,
    RoleDoesNotExist,
    EntityIsAlreadyMember,
    DuplicateRoleId,
    GroupInvitationNotFound,
    GroupApplicationNotFound,
    OutstandingInvitationAcceptedInstead,
    OutstandingApplicationAcceptedInstead,
    RoleIsGroupDefaultMember,
    RoleIsGroupAdmin,
    RoleNameNotAvailable,
    GroupNameNotAvailable,
    EmailReportAlreadySent,
    EmailReportRecipientBlacklisted,
    EventNamespaceNotAllowed,
    EventEntityNotAllowed,
    InvalidEntityType,
    NullTokenResultFromAad,
    InvalidTokenResultFromAad,
    NoValidCertificateForAad,
    InvalidCertificateForAad,
    DuplicateDropTableId,
    MultiplayerServerError,
    MultiplayerServerTooManyRequests,
    MultiplayerServerNoContent,
    MultiplayerServerBadRequest,
    MultiplayerServerUnauthorized,
    MultiplayerServerForbidden,
    MultiplayerServerNotFound,
    MultiplayerServerConflict,
    MultiplayerServerInternalServerError,
    MultiplayerServerUnavailable,
    ExplicitContentDetected,
    PIIContentDetected,
    InvalidScheduledTaskParameter,
    PerEntityEventRateLimitExceeded,
    TitleDefaultLanguageNotSet,
    EmailTemplateMissingDefaultVersion,
    FacebookInstantGamesIdNotLinked,
    InvalidFacebookInstantGamesSignature,
    FacebookInstantGamesAuthNotConfiguredForTitle,
    EntityProfileConstraintValidationFailed,
    TelemetryIngestionKeyPending,
    TelemetryIngestionKeyNotFound,
    StatisticChildNameInvalid,
    DataIntegrityError,
    VirtualCurrencyCannotBeSetToOlderVersion,
    VirtualCurrencyMustBeWithinIntegerRange,
    EmailTemplateInvalidSyntax,
    EmailTemplateMissingCallback,
    PushNotificationTemplateInvalidPayload,
    InvalidLocalizedPushNotificationLanguage,
    MissingLocalizedPushNotificationMessage,
    PushNotificationTemplateMissingPlatformPayload,
    PushNotificationTemplatePayloadContainsInvalidJson,
    PushNotificationTemplateContainsInvalidIosPayload,
    PushNotificationTemplateContainsInvalidAndroidPayload,
    PushNotificationTemplateIosPayloadMissingNotificationBody,
    PushNotificationTemplateAndroidPayloadMissingNotificationBody,
    PushNotificationTemplateNotFound,
    PushNotificationTemplateMissingDefaultVersion,
    PushNotificationTemplateInvalidSyntax,
    PushNotificationTemplateNoCustomPayloadForV1,
    NoLeaderboardForStatistic,
    TitleNewsMissingDefaultLanguage,
    TitleNewsNotFound,
    TitleNewsDuplicateLanguage,
    TitleNewsMissingTitleOrBody,
    TitleNewsInvalidLanguage,
    EmailRecipientBlacklisted,
    InvalidGameCenterAuthRequest,
    GameCenterAuthenticationFailed,
    CannotEnablePartiesForTitle,
    PartyError,
    PartyRequests,
    PartyNoContent,
    PartyBadRequest,
    PartyUnauthorized,
    PartyForbidden,
    PartyNotFound,
    PartyConflict,
    PartyInternalServerError,
    PartyUnavailable,
    PartyTooManyRequests,
    PushNotificationTemplateMissingName,
    CannotEnableMultiplayerServersForTitle,
    WriteAttemptedDuringExport,
    MultiplayerServerTitleQuotaCoresExceeded,
    AutomationRuleNotFound,
    EntityAPIKeyLimitExceeded,
    EntityAPIKeyNotFound,
    EntityAPIKeyOrSecretInvalid,
    EconomyServiceUnavailable,
    EconomyServiceInternalError,
    QueryRateLimitExceeded,
    EntityAPIKeyCreationDisabledForEntity,
    ForbiddenByEntityPolicy,
    UpdateInventoryRateLimitExceeded,
    StudioCreationRateLimited,
    StudioCreationInProgress,
    DuplicateStudioName,
    StudioNotFound,
    StudioDeleted,
    StudioDeactivated,
    StudioActivated,
    TitleCreationRateLimited,
    TitleCreationInProgress,
    DuplicateTitleName,
    TitleActivationRateLimited,
    TitleActivationInProgress,
    TitleDeactivated,
    TitleActivated,
    CloudScriptAzureFunctionsExecutionTimeLimitExceeded,
    CloudScriptAzureFunctionsArgumentSizeExceeded,
    CloudScriptAzureFunctionsReturnSizeExceeded,
    CloudScriptAzureFunctionsHTTPRequestError,
    VirtualCurrencyBetaGetError,
    VirtualCurrencyBetaCreateError,
    VirtualCurrencyBetaInitialDepositSaveError,
    VirtualCurrencyBetaSaveError,
    VirtualCurrencyBetaDeleteError,
    VirtualCurrencyBetaRestoreError,
    VirtualCurrencyBetaSaveConflict,
    VirtualCurrencyBetaUpdateError,
    InsightsManagementDatabaseNotFound,
    InsightsManagementOperationNotFound,
    InsightsManagementErrorPendingOperationExists,
    InsightsManagementSetPerformanceLevelInvalidParameter,
    InsightsManagementSetStorageRetentionInvalidParameter,
    InsightsManagementGetStorageUsageInvalidParameter,
    InsightsManagementGetOperationStatusInvalidParameter,
    DuplicatePurchaseTransactionId,
    EvaluationModePlayerCountExceeded,
    GetPlayersInSegmentRateLimitExceeded,
    CloudScriptFunctionNameSizeExceeded,
    PaidInsightsFeaturesNotEnabled,
    CloudScriptAzureFunctionsQueueRequestError,
    EvaluationModeTitleCountExceeded,
    InsightsManagementTitleNotInFlight,
    LimitNotFound,
    LimitNotAvailableViaAPI,
    InsightsManagementSetStorageRetentionBelowMinimum,
    InsightsManagementSetStorageRetentionAboveMaximum,
    AppleNotEnabledForTitle,
    InsightsManagementNewActiveEventExportLimitInvalid,
    InsightsManagementSetPerformanceRateLimited,
    PartyRequestsThrottledFromRateLimiter,
    XboxServiceTooManyRequests,
    NintendoSwitchNotEnabledForTitle,
    RequestMultiplayerServersThrottledFromRateLimiter,
    TitleDataOverrideNotFound,
    DuplicateKeys,
    WasNotCreatedWithCloudRoot,
    LegacyMultiplayerServersDeprecated,
    VirtualCurrencyCurrentlyUnavailable,
    SteamUserNotFound,
    ElasticSearchOperationFailed,
    NotImplemented,
    PublisherNotFound,
    PublisherDeleted,
    ApiDisabledForMigration,
    ResourceNameUpdateNotAllowed,
    ApiNotEnabledForTitle,
    DuplicateTitleNameForPublisher,
    AzureTitleCreationInProgress,
    TitleConstraintsPublisherDeletion,
    InvalidPlayerAccountPoolId,
    PlayerAccountPoolNotFound,
    PlayerAccountPoolDeleted,
    TitleCleanupInProgress,
    AzureResourceConcurrentOperationInProgress,
    TitlePublisherUpdateNotAllowed,
    AzureResourceManagerNotSupportedInStamp,
    ApiNotIncludedInAzurePlayFabFeatureSet,
    GoogleServiceAccountFailedAuth,
    GoogleAPIServiceUnavailable,
    GoogleAPIServiceUnknownError,
    NoValidIdentityForAad,
    PlayerIdentityLinkNotFound,
    PhotonApplicationIdAlreadyInUse,
    CloudScriptUnableToDeleteProductionRevision,
    CustomIdNotFound,
    AutomationInvalidInput,
    AutomationInvalidRuleName,
    AutomationRuleAlreadyExists,
    AutomationRuleLimitExceeded,
    InvalidGooglePlayGamesServerAuthCode,
    PlayStreamConnectionFailed,
    InvalidEventContents,
    InsightsV1Deprecated,
    AnalysisSubscriptionNotFound,
    AnalysisSubscriptionFailed,
    AnalysisSubscriptionFoundAlready,
    AnalysisSubscriptionManagementInvalidInput,
    InvalidGameCenterId,
    InvalidNintendoSwitchAccountId,
    EntityAPIKeysNotSupported,
    IpAddressBanned,
    EntityLineageBanned,
    NamespaceMismatch,
    InvalidServiceConfiguration,
    InvalidNamespaceMismatch,
    LeaderboardColumnLengthMismatch,
    InvalidStatisticScore,
    LeaderboardColumnsNotSpecified,
    LeaderboardMaxSizeTooLarge,
    InvalidAttributeStatisticsSpecified,
    LeaderboardNotFound,
    TokenSigningKeyNotFound,
    LeaderboardNameConflict,
    LinkedStatisticColumnMismatch,
    NoLinkedStatisticToLeaderboard,
    StatDefinitionAlreadyLinkedToLeaderboard,
    LinkingStatsNotAllowedForEntityType,
    LeaderboardCountLimitExceeded,
    LeaderboardSizeLimitExceeded,
    LeaderboardDefinitionModificationNotAllowedWhileLinked,
    StatisticDefinitionModificationNotAllowedWhileLinked,
    LeaderboardUpdateNotAllowedWhileLinked,
    CloudScriptAzureFunctionsEventHubRequestError,
    ExternalEntityNotAllowedForTier,
    InvalidBaseTimeForInterval,
    EntityTypeMismatchWithStatDefinition,
    SpecifiedVersionLeaderboardNotFound,
    LeaderboardColumnLengthMismatchWithStatDefinition,
    DuplicateColumnNameFound,
    LinkedStatisticColumnNotFound,
    LinkedStatisticColumnRequired,
    MultipleLinkedStatisticsNotAllowed,
    DuplicateLinkedStatisticColumnNameFound,
    AggregationTypeNotAllowedForMultiColumnStatistic,
    MaxQueryableVersionsValueNotAllowedForTier,
    StatisticDefinitionHasNullOrEmptyVersionConfiguration,
    StatisticColumnLengthMismatch,
    InvalidExternalEntityId,
    UpdatingStatisticsUsingTransactionIdNotAvailableForFreeTier,
    TransactionAlreadyApplied,
    ReportDataNotRetrievedSuccessfully,
    ResetIntervalCannotBeModified,
    VersionIncrementRateExceeded,
    InvalidSteamUsername,
    InvalidVersionResetForLinkedLeaderboard,
    BattleNetNotEnabledForTitle,
    ReportNotProcessed,
    DataNotAvailable,
    InvalidReportName,
    ResourceNotModified,
    StudioCreationLimitExceeded,
    MatchmakingEntityInvalid,
    MatchmakingPlayerAttributesInvalid,
    MatchmakingQueueNotFound,
    MatchmakingMatchNotFound,
    MatchmakingTicketNotFound,
    MatchmakingAlreadyJoinedTicket,
    MatchmakingTicketAlreadyCompleted,
    MatchmakingQueueConfigInvalid,
    MatchmakingMemberProfileInvalid,
    NintendoSwitchDeviceIdNotLinked,
    MatchmakingNotEnabled,
    MatchmakingPlayerAttributesTooLarge,
    MatchmakingNumberOfPlayersInTicketTooLarge,
    MatchmakingAttributeInvalid,
    MatchmakingPlayerHasNotJoinedTicket,
    MatchmakingRateLimitExceeded,
    MatchmakingTicketMembershipLimitExceeded,
    MatchmakingUnauthorized,
    MatchmakingQueueLimitExceeded,
    MatchmakingRequestTypeMismatch,
    MatchmakingBadRequest,
    PubSubFeatureNotEnabledForTitle,
    PubSubTooManyRequests,
    PubSubConnectionNotFoundForEntity,
    PubSubConnectionHandleInvalid,
    PubSubSubscriptionLimitExceeded,
    TitleConfigNotFound,
    TitleConfigUpdateConflict,
    TitleConfigSerializationError,
    CatalogApiNotImplemented,
    CatalogEntityInvalid,
    CatalogTitleIdMissing,
    CatalogPlayerIdMissing,
    CatalogClientIdentityInvalid,
    CatalogOneOrMoreFilesInvalid,
    CatalogItemMetadataInvalid,
    CatalogItemIdInvalid,
    CatalogSearchParameterInvalid,
    CatalogFeatureDisabled,
    CatalogConfigInvalid,
    CatalogItemTypeInvalid,
    CatalogBadRequest,
    CatalogTooManyRequests,
    InvalidCatalogItemConfiguration,
    ExportInvalidStatusUpdate,
    ExportInvalidPrefix,
    ExportBlobContainerDoesNotExist,
    ExportNotFound,
    ExportCouldNotUpdate,
    ExportInvalidStorageType,
    ExportAmazonBucketDoesNotExist,
    ExportInvalidBlobStorage,
    ExportKustoException,
    ExportKustoConnectionFailed,
    ExportUnknownError,
    ExportCantEditPendingExport,
    ExportLimitExports,
    ExportLimitEvents,
    ExportInvalidPartitionStatusModification,
    ExportCouldNotCreate,
    ExportNoBackingDatabaseFound,
    ExportCouldNotDelete,
    ExportCannotDetermineEventQuery,
    ExportInvalidQuerySchemaModification,
    ExportQuerySchemaMissingRequiredColumns,
    ExportCannotParseQuery,
    ExportControlCommandsNotAllowed,
    ExportQueryMissingTableReference,
    ExportInsightsV1Deprecated,
    ExplorerBasicInvalidQueryName,
    ExplorerBasicInvalidQueryDescription,
    ExplorerBasicInvalidQueryConditions,
    ExplorerBasicInvalidQueryStartDate,
    ExplorerBasicInvalidQueryEndDate,
    ExplorerBasicInvalidQueryGroupBy,
    ExplorerBasicInvalidQueryAggregateType,
    ExplorerBasicInvalidQueryAggregateProperty,
    ExplorerBasicLoadQueriesError,
    ExplorerBasicLoadQueryError,
    ExplorerBasicCreateQueryError,
    ExplorerBasicDeleteQueryError,
    ExplorerBasicUpdateQueryError,
    ExplorerBasicSavedQueriesLimit,
    ExplorerBasicSavedQueryNotFound,
    TenantShardMapperShardNotFound,
    TitleNotEnabledForParty,
    PartyVersionNotFound,
    MultiplayerServerBuildReferencedByMatchmakingQueue,
    MultiplayerServerBuildReferencedByBuildAlias,
    MultiplayerServerBuildAliasReferencedByMatchmakingQueue,
    PartySerializationError,
    ExperimentationExperimentStopped,
    ExperimentationExperimentRunning,
    ExperimentationExperimentNotFound,
    ExperimentationExperimentNeverStarted,
    ExperimentationExperimentDeleted,
    ExperimentationClientTimeout,
    ExperimentationInvalidVariantConfiguration,
    ExperimentationInvalidVariableConfiguration,
    ExperimentInvalidId,
    ExperimentationNoScorecard,
    ExperimentationTreatmentAssignmentFailed,
    ExperimentationTreatmentAssignmentDisabled,
    ExperimentationInvalidDuration,
    ExperimentationMaxExperimentsReached,
    ExperimentationExperimentSchedulingInProgress,
    ExperimentationInvalidEndDate,
    ExperimentationInvalidStartDate,
    ExperimentationMaxDurationExceeded,
    ExperimentationExclusionGroupNotFound,
    ExperimentationExclusionGroupInsufficientCapacity,
    ExperimentationExclusionGroupCannotDelete,
    ExperimentationExclusionGroupInvalidTrafficAllocation,
    ExperimentationExclusionGroupInvalidName,
    ExperimentationLegacyExperimentInvalidOperation,
    MaxActionDepthExceeded,
    TitleNotOnUpdatedPricingPlan,
    SegmentManagementTitleNotInFlight,
    SegmentManagementNoExpressionTree,
    SegmentManagementTriggerActionCountOverLimit,
    SegmentManagementSegmentCountOverLimit,
    SegmentManagementInvalidSegmentId,
    SegmentManagementInvalidInput,
    SegmentManagementInvalidSegmentName,
    DeleteSegmentRateLimitExceeded,
    CreateSegmentRateLimitExceeded,
    UpdateSegmentRateLimitExceeded,
    GetSegmentsRateLimitExceeded,
    AsyncExportNotInFlight,
    AsyncExportNotFound,
    AsyncExportRateLimitExceeded,
    AnalyticsSegmentCountOverLimit,
    SnapshotNotFound,
    InventoryApiNotImplemented,
    InventoryCollectionDeletionDisallowed,
    LobbyDoesNotExist,
    LobbyRateLimitExceeded,
    LobbyPlayerAlreadyJoined,
    LobbyNotJoinable,
    LobbyMemberCannotRejoin,
    LobbyCurrentPlayersMoreThanMaxPlayers,
    LobbyPlayerNotPresent,
    LobbyBadRequest,
    LobbyPlayerMaxLobbyLimitExceeded,
    LobbyNewOwnerMustBeConnected,
    LobbyCurrentOwnerStillConnected,
    LobbyMemberIsNotOwner,
    LobbyServerMismatch,
    LobbyServerNotFound,
    LobbyDifferentServerAlreadyJoined,
    LobbyServerAlreadyJoined,
    LobbyIsNotClientOwned,
    LobbyDoesNotUseConnections,
    EventSamplingInvalidRatio,
    EventSamplingInvalidEventNamespace,
    EventSamplingInvalidEventName,
    EventSamplingRatioNotFound,
    TelemetryKeyNotFound,
    TelemetryKeyInvalidName,
    TelemetryKeyAlreadyExists,
    TelemetryKeyInvalid,
    TelemetryKeyCountOverLimit,
    TelemetryKeyDeactivated,
    TelemetryKeyLongInsightsRetentionNotAllowed,
    EventSinkConnectionInvalid,
    EventSinkConnectionUnauthorized,
    EventSinkRegionInvalid,
    EventSinkLimitExceeded,
    EventSinkSasTokenInvalid,
    EventSinkNotFound,
    EventSinkNameInvalid,
    EventSinkSasTokenPermissionInvalid,
    EventSinkSecretInvalid,
    EventSinkTenantNotFound,
    EventSinkAadNotFound,
    EventSinkDatabaseNotFound,
    EventSinkTitleUnauthorized,
    EventSinkInsufficientRoleAssignment,
    EventSinkContainerNotFound,
    EventSinkTenantIdInvalid,
    EventSinkResourceMisconfigured,
    EventSinkAccessDenied,
    EventSinkWriteConflict,
    EventSinkResourceNotFound,
    EventSinkResourceFeatureNotSupported,
    EventSinkBucketNameInvalid,
    EventSinkResourceUnavailable,
    OperationCanceled,
    InvalidDisplayNameRandomSuffixLength,
    AllowNonUniquePlayerDisplayNamesDisableNotAllowed,
    PartitionedEventInvalid,
    PartitionedEventCountOverLimit,
    ManageEventNamespaceInvalid,
    ManageEventNameInvalid,
    ManagedEventNotFound,
    ManageEventsInvalidRatio,
    ManagedEventInvalid,
    PlayerCustomPropertiesPropertyNameTooLong,
    PlayerCustomPropertiesPropertyNameIsInvalid,
    PlayerCustomPropertiesStringPropertyValueTooLong,
    PlayerCustomPropertiesValueIsInvalidType,
    PlayerCustomPropertiesVersionMismatch,
    PlayerCustomPropertiesPropertyCountTooHigh,
    PlayerCustomPropertiesDuplicatePropertyName,
    PlayerCustomPropertiesPropertyDoesNotExist,
    AddonAlreadyExists,
    AddonDoesntExist,
    CopilotDisabled,
    CopilotInvalidRequest,
    TrueSkillUnauthorized,
    TrueSkillInvalidTitleId,
    TrueSkillInvalidScenarioId,
    TrueSkillInvalidModelId,
    TrueSkillInvalidModelName,
    TrueSkillInvalidPlayerIds,
    TrueSkillInvalidEntityKey,
    TrueSkillInvalidConditionKey,
    TrueSkillInvalidConditionValue,
    TrueSkillInvalidConditionAffinityWeight,
    TrueSkillInvalidEventName,
    TrueSkillMatchResultCreated,
    TrueSkillMatchResultAlreadySubmitted,
    TrueSkillBadPlayerIdInMatchResult,
    TrueSkillInvalidBotIdInMatchResult,
    TrueSkillDuplicatePlayerInMatchResult,
    TrueSkillNoPlayerInMatchResultTeam,
    TrueSkillPlayersInMatchResultExceedingLimit,
    TrueSkillInvalidPreMatchPartyInMatchResult,
    TrueSkillInvalidTimestampInMatchResult,
    TrueSkillStartTimeMissingInMatchResult,
    TrueSkillEndTimeMissingInMatchResult,
    TrueSkillInvalidPlayerSecondsPlayedInMatchResult,
    TrueSkillNoTeamInMatchResult,
    TrueSkillNotEnoughTeamsInMatchResult,
    TrueSkillInvalidRanksInMatchResult,
    TrueSkillNoWinnerInMatchResult,
    TrueSkillMissingRequiredCondition,
    TrueSkillMissingRequiredEvent,
    TrueSkillUnknownEventName,
    TrueSkillInvalidEventCount,
    TrueSkillUnknownConditionKey,
    TrueSkillUnknownConditionValue,
    TrueSkillScenarioConfigDoesNotExist,
    TrueSkillUnknownModelId,
    TrueSkillNoModelInScenario,
    TrueSkillNotSupportedForTitle,
    TrueSkillModelIsNotActive,
    TrueSkillUnauthorizedToQueryOtherPlayerSkills,
    TrueSkillInvalidMaxIterations,
    TrueSkillEndTimeBeforeStartTime,
    TrueSkillInvalidJobId,
    TrueSkillInvalidMetadataId,
    TrueSkillMissingBuildVerison,
    TrueSkillJobAlreadyExists,
    TrueSkillJobNotFound,
    TrueSkillOperationCanceled,
    TrueSkillActiveModelLimitExceeded,
    TrueSkillTotalModelLimitExceeded,
    TrueSkillUnknownInitialModelId,
    TrueSkillUnauthorizedForJob,
    TrueSkillInvalidScenarioName,
    TrueSkillConditionStateIsRequired,
    TrueSkillEventStateIsRequired,
    TrueSkillDuplicateEvent,
    TrueSkillDuplicateCondition,
    TrueSkillInvalidAnomalyThreshold,
    TrueSkillConditionKeyLimitExceeded,
    TrueSkillConditionValuePerKeyLimitExceeded,
    TrueSkillInvalidTimestamp,
    TrueSkillEventLimitExceeded,
    TrueSkillInvalidPlayers,
    TrueSkillTrueSkillPlayerNull,
    TrueSkillInvalidPlayerId,
    TrueSkillInvalidSquadSize,
    TrueSkillConditionSetNotInModel,
    TrueSkillModelStateInvalidForOperation,
    TrueSkillScenarioContainsActiveModel,
    TrueSkillInvalidConditionRank,
    TrueSkillTotalScenarioLimitExceeded,
    TrueSkillInvalidConditionsList,
    GameSaveManifestNotFound,
    GameSaveManifestVersionAlreadyExists,
    GameSaveConflictUpdatingManifest,
    GameSaveManifestUpdatesNotAllowed,
    GameSaveFileAlreadyExists,
    GameSaveManifestVersionNotFinalized,
    GameSaveUnknownFileInManifest,
    GameSaveFileExceededReportedSize,
    GameSaveFileNotUploaded,
    GameSaveBadRequest,
    GameSaveOperationNotAllowed,
    GameSaveDataStorageQuotaExceeded,
    GameSaveNewerManifestExists,
    GameSaveBaseVersionNotAvailable,
    GameSaveManifestVersionQuarantined,
    GameSaveManifestUploadProgressUpdateNotAllowed,
    GameSaveNotFinalizedManifestNotEligibleAsKnownGood,
    GameSaveNoUpdatesRequested,
    GameSaveTitleDoesNotExist,
    GameSaveOperationNotAllowedForTitle,
    GameSaveManifestFilesLimitExceeded,
    GameSaveManifestDescriptionUpdateNotAllowed,
    GameSaveTitleConfigNotFound,
    GameSaveTitleAlreadyOnboarded,
    GameSaveServiceNotEnabledForTitle,
    GameSaveServiceOnboardingPending,
    GameSaveManifestNotEligibleAsConflictingVersion,
    GameSaveServiceUnavailable,
    GameSaveConflict,
    GameSaveManifestNotEligibleForRollback,
    StateShareForbidden,
    StateShareTitleNotInFlight,
    StateShareStateNotFound,
    StateShareLinkNotFound,
    StateShareStateRedemptionLimitExceeded,
    StateShareStateRedemptionLimitNotUpdated,
    StateShareCreatedStatesLimitExceeded,
    StateShareIdMissingOrMalformed,
    PlayerCreationDisabled,
    AccountAlreadyExists,
    TagInvalid,
    TagTooLong,
    StatisticColumnAggregationMismatch,
    StatisticResetIntervalMismatch,
    VersionConfigurationCannotBeSpecifiedForLinkedStat,
    VersionConfigurationIsRequired,
    InvalidEntityTypeForAggregation,
    MultiLevelAggregationNotAllowed,
    AggregationTypeNotAllowedForLinkedStat,
}

[Obsolete("Do not use")]
public class GetActionGroupResult {
    public string? Id { get; set; }
    public required string Name { get; set; }
}

public class GetActionsOnPlayersInSegmentTaskInstanceResult : PlayFabResultCommon {
    public ActionsOnPlayersInSegmentTaskParameter? Parameter { get; set; }
    public ActionsOnPlayersInSegmentTaskSummary? Summary { get; set; }
}

[Obsolete("Do not use")]
public class GetAllActionGroupsRequest : PlayFabRequestCommon {
}

[Obsolete("Do not use")]
public class GetAllActionGroupsResult : PlayFabResultCommon {
    public required List<GetActionGroupResult> ActionGroups { get; set; }
}

/// <summary>
/// Request has no paramaters.
/// </summary>
public class GetAllSegmentsRequest : PlayFabRequestCommon {
}

public class GetAllSegmentsResult : PlayFabResultCommon {
    public List<GetSegmentResult>? Segments { get; set; }
}

public class GetCatalogItemsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
}

public class GetCatalogItemsResult : PlayFabResultCommon {
    public List<CatalogItem>? Catalog { get; set; }
}

public class GetCloudScriptAzureFunctionsTaskInstanceResult : PlayFabResultCommon {
    public CloudScriptAzureFunctionsTaskParameter? Parameter { get; set; }
    public CloudScriptAzureFunctionsTaskSummary? Summary { get; set; }
}

public class GetCloudScriptRevisionRequest : PlayFabRequestCommon {
    public int? Revision { get; set; }
    public int? Version { get; set; }
}

public class GetCloudScriptRevisionResult : PlayFabResultCommon {
    public required DateTime CreatedAt { get; set; }
    public List<CloudScriptFile>? Files { get; set; }
    public bool IsPublished { get; set; }
    public int Revision { get; set; }
    public int Version { get; set; }
}

public class GetCloudScriptTaskInstanceResult : PlayFabResultCommon {
    public CloudScriptTaskParameter? Parameter { get; set; }
    public CloudScriptTaskSummary? Summary { get; set; }
}

public class GetCloudScriptVersionsRequest : PlayFabRequestCommon {
}

public class GetCloudScriptVersionsResult : PlayFabResultCommon {
    public List<CloudScriptVersionStatus>? Versions { get; set; }
}

public class GetContentListRequest : PlayFabRequestCommon {
    public string? Prefix { get; set; }
}

public class GetContentListResult : PlayFabResultCommon {
    public List<ContentInfo>? Contents { get; set; }
    public int ItemCount { get; set; }
    public UInt32 TotalSize { get; set; }
}

public class GetContentUploadUrlRequest : PlayFabRequestCommon {
    public string? ContentType { get; set; }
    public required string Key { get; set; }
}

public class GetContentUploadUrlResult : PlayFabResultCommon {
    public string? URL { get; set; }
}

/// <summary>
/// Gets the download URL for the requested report data (in CSV form). The reports available through this API call are those available in the Game Manager, in the Analytics->Reports tab.
/// </summary>
public class GetDataReportRequest : PlayFabRequestCommon {
    public int Day { get; set; }
    public int Month { get; set; }
    public required string ReportName { get; set; }
    public int Year { get; set; }
}

public class GetDataReportResult : PlayFabResultCommon {
    public string? DownloadUrl { get; set; }
}

/// <summary>
/// Request has no parameters.
/// </summary>
public class GetEventSinksRequest : PlayFabRequestCommon {
}

public class GetEventSinksResult : PlayFabResultCommon {
    public required List<EventSink> Sinks { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameInfoRequest : PlayFabRequestCommon {
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameInfoResult : PlayFabResultCommon {
    public string? BuildVersion { get; set; }
    public DateTime? EndTime { get; set; }
    public string? LobbyId { get; set; }
    public string? Mode { get; set; }
    public List<string>? Players { get; set; }
    public Region? Region { get; set; }
    public string? ServerAddress { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public UInt32 ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
    public required DateTime StartTime { get; set; }
    public string? TitleId { get; set; }
}

/// <summary>
/// These details are used by the PlayFab matchmaking service to determine if an existing Game Server Instance has room for additional users, and by the PlayFab game server management service to determine when a new Game Server Host should be created in order to prevent excess load on existing Hosts.
/// </summary>
[Obsolete("Do not use")]
public class GetMatchmakerGameModesRequest : PlayFabRequestCommon {
    public required string BuildVersion { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameModesResult : PlayFabResultCommon {
    public List<GameModeInfo>? GameModes { get; set; }
}

/// <summary>
/// Useful for identifying titles of which the player's data will be deleted by DeleteMasterPlayer.
/// </summary>
public class GetPlayedTitleListRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class GetPlayedTitleListResult : PlayFabResultCommon {
    public List<string>? TitleIds { get; set; }
}

public class GetPlayerCustomPropertyRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
    public required string PropertyName { get; set; }
}

public class GetPlayerCustomPropertyResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public int PropertiesVersion { get; set; }
    public CustomPropertyDetails? Property { get; set; }
}

/// <summary>
/// Gets a player ID from an auth token. The token expires after 30 minutes and cannot be used to look up a player when expired.
/// </summary>
public class GetPlayerIdFromAuthTokenRequest : PlayFabRequestCommon {
    public required string Token { get; set; }
    public AuthTokenType TokenType { get; set; }
}

public class GetPlayerIdFromAuthTokenResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
}

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class GetPlayerProfileRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
}

public class GetPlayerProfileResult : PlayFabResultCommon {
    public PlayerProfileModel? PlayerProfile { get; set; }
}

public class GetPlayerSegmentsResult : PlayFabResultCommon {
    public List<GetSegmentResult>? Segments { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class GetPlayerSharedSecretsRequest : PlayFabRequestCommon {
}

public class GetPlayerSharedSecretsResult : PlayFabResultCommon {
    public List<SharedSecret>? SharedSecrets { get; set; }
}

/// <summary>
/// Request must contain the ExportId
/// </summary>
public class GetPlayersInSegmentExportRequest : PlayFabRequestCommon {
    public required string ExportId { get; set; }
}

public class GetPlayersInSegmentExportResponse : PlayFabResultCommon {
    public string? IndexUrl { get; set; }
    public string? State { get; set; }
}

/// <summary>
/// Initial request must contain at least a Segment ID. Subsequent requests must contain the Segment ID as well as the Continuation Token. Failure to send the Continuation Token will result in a new player segment list being generated. Each time the Continuation Token is passed in the length of the Total Seconds to Live is refreshed. If too much time passes between requests to the point that a subsequent request is past the Total Seconds to Live an error will be returned and paging will be terminated. This API is resource intensive and should not be used in scenarios which might generate high request volumes. Only one request to this API at a time should be made per title. Concurrent requests to the API may be rejected with the APIConcurrentRequestLimitExceeded error.
/// </summary>
public class GetPlayersInSegmentRequest : PlayFabRequestCommon {
    public string? ContinuationToken { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? GetProfilesAsync { get; set; }
    public UInt32? MaxBatchSize { get; set; }
    public UInt32? SecondsToLive { get; set; }
    public required string SegmentId { get; set; }
}

public class GetPlayersInSegmentResult : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<PlayerProfile>? PlayerProfiles { get; set; }
    public int ProfilesInSegment { get; set; }
}

public class GetPlayersSegmentsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetPlayerStatisticDefinitionsRequest : PlayFabRequestCommon {
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval defines the period of time at which the leaderboard for the statistic will automatically reset. Upon reset, the statistic updates to a new version with no values (effectively removing all players from the leaderboard). The previous version's statistic values are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset (sometimes referred to as versioned or incremented), the previous version can still be written to for up a short, pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also, once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version information (GetPlayerStatisticVersions). The AggregationMethod defines what action is taken when a new statistic value is submitted - always update with the new value (Last), use the highest of the old and new values (Max), use the smallest (Min), or add them together (Sum).
/// </summary>
public class GetPlayerStatisticDefinitionsResult : PlayFabResultCommon {
    public List<PlayerStatisticDefinition>? Statistics { get; set; }
}

public class GetPlayerStatisticVersionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? StatisticName { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The information returned in the results defines the state of a specific version of a statistic, including when it was or will become the currently active version, when it will (or did) become a previous version, and its archival state if it is no longer the active version. For a statistic which has been reset, once the archival status is Complete, the full set of statistics for all players in the leaderboard for that version may be retrieved via the ArchiveDownloadUrl. Statistics which have not been reset (incremented/versioned) will only have a single version which is not scheduled to reset.
/// </summary>
public class GetPlayerStatisticVersionsResult : PlayFabResultCommon {
    public List<PlayerStatisticVersion>? StatisticVersions { get; set; }
}

/// <summary>
/// This API will return a list of canonical tags which includes both namespace and tag's name. If namespace is not provided, the result is a list of all canonical tags. TagName can be used for segmentation and Namespace is limited to 128 characters.
/// </summary>
public class GetPlayerTagsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Namespace { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetPlayerTagsResult : PlayFabResultCommon {
    public required string PlayFabId { get; set; }
    public required List<string> Tags { get; set; }
}

/// <summary>
/// Views the requested policy. Today, the only supported policy is 'ApiPolicy'.
/// </summary>
public class GetPolicyRequest : PlayFabRequestCommon {
    public string? PolicyName { get; set; }
}

public class GetPolicyResponse : PlayFabResultCommon {
    public string? PolicyName { get; set; }
    public int PolicyVersion { get; set; }
    public List<PermissionStatement>? Statements { get; set; }
}

/// <summary>
/// This API is designed to return publisher-specific values which can be read, but not written to, by the client. This data is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only titles assigned to a publisher can use this API. For more information email helloplayfab@microsoft.com. This AdminAPI call for getting title data guarantees no delay in between update and retrieval of newly set data.
/// </summary>
public class GetPublisherDataRequest : PlayFabRequestCommon {
    public required List<string> Keys { get; set; }
}

public class GetPublisherDataResult : PlayFabResultCommon {
    public Dictionary<string, string>? Data { get; set; }
}

public class GetRandomResultTablesRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
}

public class GetRandomResultTablesResult : PlayFabResultCommon {
    public Dictionary<string, RandomResultTableListing>? Tables { get; set; }
}

public class GetSegmentResult {
    public string? ABTestParent { get; set; }
    public required string Id { get; set; }
    public string? Name { get; set; }
}

/// <summary>
/// Given input segment ids, return list of segments.
/// </summary>
public class GetSegmentsRequest : PlayFabRequestCommon {
    public required List<string> SegmentIds { get; set; }
}

public class GetSegmentsResponse : PlayFabResultCommon {
    public string? ErrorMessage { get; set; }
    public List<SegmentModel>? Segments { get; set; }
}

[Obsolete("Do not use")]
public class GetServerBuildInfoRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
}

/// <summary>
/// Information about a particular server build
/// </summary>
[Obsolete("Do not use")]
public class GetServerBuildInfoResult : PlayFabResultCommon {
    public List<Region>? ActiveRegions { get; set; }
    public string? BuildId { get; set; }
    public string? Comment { get; set; }
    public string? ErrorMessage { get; set; }
    public int MaxGamesPerHost { get; set; }
    public int MinFreeGameSlots { get; set; }
    public GameBuildStatus? Status { get; set; }
    public required DateTime Timestamp { get; set; }
    public string? TitleId { get; set; }
}

/// <summary>
/// A store contains an array of references to items defined in the catalog, along with the prices for the item, in both real world and virtual currencies. These prices act as an override to any prices defined in the catalog. In this way, the base definitions of the items may be defined in the catalog, with all associated properties, while the pricing can be set for each store, as needed. This allows for subsets of goods to be defined for different purposes (in order to simplify showing some, but not all catalog items to users, based upon different characteristics), along with unique prices. Note that all prices defined in the catalog and store definitions for the item are considered valid, and that a compromised client can be made to send a request for an item based upon any of these definitions. If no price is specified in the store for an item, the price set in the catalog should be displayed to the user.
/// </summary>
public class GetStoreItemsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string StoreId { get; set; }
}

public class GetStoreItemsResult : PlayFabResultCommon {
    public string? CatalogVersion { get; set; }
    public StoreMarketingModel? MarketingData { get; set; }
    public SourceType? Source { get; set; }
    public List<StoreItem>? Store { get; set; }
    public string? StoreId { get; set; }
}

/// <summary>
/// The result includes detail information that's specific to a CloudScript task. Only CloudScript tasks configured as "Run Cloud Script function once" will be retrieved. To get a list of task instances by task, status, or time range, use GetTaskInstances.
/// </summary>
public class GetTaskInstanceRequest : PlayFabRequestCommon {
    public required string TaskInstanceId { get; set; }
}

/// <summary>
/// Only the most recent 100 task instances are returned, ordered by start time descending. The results are generic basic information for task instances. To get detail information specific to each task type, use Get*TaskInstance based on its corresponding task type.
/// </summary>
public class GetTaskInstancesRequest : PlayFabRequestCommon {
    public DateTime? StartedAtRangeFrom { get; set; }
    public DateTime? StartedAtRangeTo { get; set; }
    public TaskInstanceStatus? StatusFilter { get; set; }
    public NameIdentifier? TaskIdentifier { get; set; }
}

public class GetTaskInstancesResult : PlayFabResultCommon {
    public List<TaskInstanceBasicSummary>? Summaries { get; set; }
}

public class GetTasksRequest : PlayFabRequestCommon {
    public NameIdentifier? Identifier { get; set; }
}

public class GetTasksResult : PlayFabResultCommon {
    public List<ScheduledTask>? Tasks { get; set; }
}

/// <summary>
/// This API method is designed to return title specific values which can be read by the client. For example, a developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths, movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new build. If an override label is specified in the request, the overrides are applied automatically and returned with the title data. Note that due to caching, there may up to a minute delay in between updating title data and a query returning the newest value.
/// </summary>
public class GetTitleDataRequest : PlayFabRequestCommon {
    public List<string>? Keys { get; set; }
    public string? OverrideLabel { get; set; }
}

public class GetTitleDataResult : PlayFabResultCommon {
    public Dictionary<string, string>? Data { get; set; }
}

/// <summary>
/// Get all bans for a user, including inactive and expired bans. 
/// </summary>
public class GetUserBansRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class GetUserBansResult : PlayFabResultCommon {
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// Data is stored as JSON key-value pairs. If the Keys parameter is provided, the data object returned will only contain the data specific to the indicated Keys. Otherwise, the full set of custom user data will be returned.
/// </summary>
public class GetUserDataRequest : PlayFabRequestCommon {
    public UInt32? IfChangedFromDataVersion { get; set; }
    public List<string>? Keys { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetUserDataResult : PlayFabResultCommon {
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    public UInt32 DataVersion { get; set; }
    public string? PlayFabId { get; set; }
}

/// <summary>
/// All items currently in the user inventory will be returned, irrespective of how they were acquired (via purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the user's current inventory, and so will not be not included. There can be a delay of up to a half a second for inventory changes to be reflected in the GetUserInventory API response.
/// </summary>
public class GetUserInventoryRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetUserInventoryResult : PlayFabResultCommon {
    public List<ItemInstance>? Inventory { get; set; }
    public string? PlayFabId { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

/// <summary>
/// Result of granting an item to a user. Note, to retrieve additional information for an item such as Tags, Description that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of can be matched to a catalog entry, which contains the additional information. Also note that Custom Data is only set when the User's specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other fields such as UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
public class GrantedItemInstance {
    public string? Annotation { get; set; }
    public List<string>? BundleContents { get; set; }
    public string? BundleParent { get; set; }
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public Dictionary<string, string>? CustomData { get; set; }
    public string? DisplayName { get; set; }
    public DateTime? Expiration { get; set; }
    public string? ItemClass { get; set; }
    public string? ItemId { get; set; }
    public string? ItemInstanceId { get; set; }
    public string? PlayFabId { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public int? RemainingUses { get; set; }
    public bool Result { get; set; }
    public string? UnitCurrency { get; set; }
    public UInt32 UnitPrice { get; set; }
    public int? UsesIncrementedBy { get; set; }
}

public class GrantItemContent {
    public string? CatalogVersion { get; set; }
    public string? ItemId { get; set; }
    public int ItemQuantity { get; set; }
}

public class GrantItemSegmentAction {
    public string? CatelogId { get; set; }
    public string? ItemId { get; set; }
    public UInt32 Quantity { get; set; }
}

/// <summary>
/// This function directly adds inventory items to user inventories. As a result of this operations, the user will not be charged any transaction fee, regardless of the inventory item catalog definition. Please note that the processing time for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase operation.
/// </summary>
public class GrantItemsToUsersRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<ItemGrant> ItemGrants { get; set; }
}

/// <summary>
/// Please note that the order of the items in the response may not match the order of items in the request.
/// </summary>
public class GrantItemsToUsersResult : PlayFabResultCommon {
    public List<GrantedItemInstance>? ItemGrantResults { get; set; }
}

public class GrantVirtualCurrencyContent {
    public int CurrencyAmount { get; set; }
    public required string CurrencyCode { get; set; }
}

public class GrantVirtualCurrencySegmentAction {
    public int Amount { get; set; }
    public string? CurrencyCode { get; set; }
}

/// <summary>
/// This operation will increment the global counter for the number of these items available. This number cannot be decremented, except by actual grants.
/// </summary>
public class IncrementLimitedEditionItemAvailabilityRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemId { get; set; }
}

public class IncrementLimitedEditionItemAvailabilityResult : PlayFabResultCommon {
}

public class IncrementPlayerStatisticContent {
    public int StatisticChangeBy { get; set; }
    public required string StatisticName { get; set; }
}

public class IncrementPlayerStatisticSegmentAction {
    public int IncrementValue { get; set; }
    public string? StatisticName { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. When this call is made on a given statistic, this forces a reset of that statistic. Upon reset, the statistic updates to a new version with no values (effectively removing all players from the leaderboard). The previous version's statistic values are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short, pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also, once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version information (GetPlayerStatisticVersions).
/// </summary>
public class IncrementPlayerStatisticVersionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? StatisticName { get; set; }
}

public class IncrementPlayerStatisticVersionResult : PlayFabResultCommon {
    public PlayerStatisticVersion? StatisticVersion { get; set; }
}

public class InsightsScalingTaskParameter {
    public int Level { get; set; }
}

public class ItemGrant {
    public string? Annotation { get; set; }
    public string? CharacterId { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public required string ItemId { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// A unique instance of an item in a user's inventory. Note, to retrieve additional information for an item such as Tags, Description that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of can be matched to a catalog entry, which contains the additional information. Also note that Custom Data is only set when the User's specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other fields such as UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
public class ItemInstance {
    public string? Annotation { get; set; }
    public List<string>? BundleContents { get; set; }
    public string? BundleParent { get; set; }
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomData { get; set; }
    public string? DisplayName { get; set; }
    public DateTime? Expiration { get; set; }
    public string? ItemClass { get; set; }
    public string? ItemId { get; set; }
    public string? ItemInstanceId { get; set; }
    public DateTime? PurchaseDate { get; set; }
    public int? RemainingUses { get; set; }
    public string? UnitCurrency { get; set; }
    public UInt32 UnitPrice { get; set; }
    public int? UsesIncrementedBy { get; set; }
}

public class LastLoginDateSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public required DateTime LogInDate { get; set; }
}

public class LastLoginTimespanSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public required double DurationInMinutes { get; set; }
}

public class LinkedPlatformAccountModel {
    public string? Email { get; set; }
    public LoginIdentityProvider? Platform { get; set; }
    public string? PlatformUserId { get; set; }
    public string? Username { get; set; }
}

public class LinkedUserAccountHasEmailSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

public class LinkedUserAccountSegmentFilter {
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

[Obsolete("Do not use")]
public class ListBuildsRequest : PlayFabRequestCommon {
}

[Obsolete("Do not use")]
public class ListBuildsResult : PlayFabResultCommon {
    public List<GetServerBuildInfoResult>? Builds { get; set; }
}

public class ListOpenIdConnectionRequest : PlayFabRequestCommon {
}

public class ListOpenIdConnectionResponse : PlayFabResultCommon {
    public List<OpenIdConnection>? Connections { get; set; }
}

public class ListPlayerCustomPropertiesRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class ListPlayerCustomPropertiesResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public List<CustomPropertyDetails>? Properties { get; set; }
    public int PropertiesVersion { get; set; }
}

public class ListVirtualCurrencyTypesRequest : PlayFabRequestCommon {
}

public class ListVirtualCurrencyTypesResult : PlayFabResultCommon {
    public List<VirtualCurrencyData>? VirtualCurrencies { get; set; }
}

public class LocationModel {
    public string? City { get; set; }
    public ContinentCode? ContinentCode { get; set; }
    public CountryCode? CountryCode { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}

public class LocationSegmentFilter {
    public SegmentCountryCode? CountryCode { get; set; }
}

public enum LoginIdentityProvider {
    Unknown,
    PlayFab,
    Custom,
    GameCenter,
    GooglePlay,
    Steam,
    XBoxLive,
    PSN,
    Kongregate,
    Facebook,
    IOSDevice,
    AndroidDevice,
    Twitch,
    WindowsHello,
    GameServer,
    CustomServer,
    NintendoSwitch,
    FacebookInstantGames,
    OpenIdConnect,
    Apple,
    NintendoSwitchAccount,
    GooglePlayGames,
    XboxMobileStore,
    King,
    BattleNet,
}

public class LogStatement {
    public object? Data { get; set; }
    public string? Level { get; set; }
    public string? Message { get; set; }
}

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class LookupUserAccountInfoRequest : PlayFabRequestCommon {
    public string? Email { get; set; }
    public string? PlayFabId { get; set; }
    public string? TitleDisplayName { get; set; }
    public string? Username { get; set; }
}

public class LookupUserAccountInfoResult : PlayFabResultCommon {
    public UserAccountInfo? UserInfo { get; set; }
}

public class MembershipModel {
    public bool IsActive { get; set; }
    public required DateTime MembershipExpiration { get; set; }
    public string? MembershipId { get; set; }
    public DateTime? OverrideExpiration { get; set; }
    public bool? OverrideIsSet { get; set; }
    public List<SubscriptionModel>? Subscriptions { get; set; }
}

/// <summary>
/// These details are used by the PlayFab matchmaking service to determine if an existing Game Server Instance has room for additional users, and by the PlayFab game server management service to determine when a new Game Server Host should be created in order to prevent excess load on existing Hosts. This operation is not additive. Using it will cause the game mode definition for the game server executable in question to be created from scratch. If there is an existing game server mode definition for the given BuildVersion, it will be deleted and replaced with the data specified in this call.
/// </summary>
[Obsolete("Do not use")]
public class ModifyMatchmakerGameModesRequest : PlayFabRequestCommon {
    public required string BuildVersion { get; set; }
    public required List<GameModeInfo> GameModes { get; set; }
}

[Obsolete("Do not use")]
public class ModifyMatchmakerGameModesResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class ModifyServerBuildRequest : PlayFabRequestCommon {
    public List<Region>? ActiveRegions { get; set; }
    public required string BuildId { get; set; }
    public string? CommandLineTemplate { get; set; }
    public string? Comment { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ExecutablePath { get; set; }
    public int MaxGamesPerHost { get; set; }
    public int MinFreeGameSlots { get; set; }
    public DateTime? Timestamp { get; set; }
}

[Obsolete("Do not use")]
public class ModifyServerBuildResult : PlayFabResultCommon {
    public List<Region>? ActiveRegions { get; set; }
    public string? BuildId { get; set; }
    public string? CommandLineTemplate { get; set; }
    public string? Comment { get; set; }
    public string? ExecutablePath { get; set; }
    public int MaxGamesPerHost { get; set; }
    public int MinFreeGameSlots { get; set; }
    public GameBuildStatus? Status { get; set; }
    public required DateTime Timestamp { get; set; }
    public string? TitleId { get; set; }
}

public class ModifyUserVirtualCurrencyResult : PlayFabResultCommon {
    public int Balance { get; set; }
    public int BalanceChange { get; set; }
    public string? PlayFabId { get; set; }
    public string? VirtualCurrency { get; set; }
}

/// <summary>
/// Identifier by either name or ID. Note that a name may change due to renaming, or reused after being deleted. ID is immutable and unique.
/// </summary>
public class NameIdentifier {
    public string? Id { get; set; }
    public string? Name { get; set; }
}

public class OpenIdConnection {
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public string? ConnectionId { get; set; }
    public bool DiscoverConfiguration { get; set; }
    public bool? IgnoreNonce { get; set; }
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    public string? IssuerOverride { get; set; }
}

public class OpenIdIssuerInformation {
    public required string AuthorizationUrl { get; set; }
    public required string Issuer { get; set; }
    public required object JsonWebKeySet { get; set; }
    public required string TokenUrl { get; set; }
}

public class PermissionStatement {
    public required string Action { get; set; }
    public ApiCondition? ApiConditions { get; set; }
    public string? Comment { get; set; }
    public EffectType Effect { get; set; }
    public required string Principal { get; set; }
    public required string Resource { get; set; }
}

public class PlayerChurnPredictionSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public class PlayerChurnPredictionTimeSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public required double DurationInDays { get; set; }
}

public class PlayerChurnPreviousPredictionSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public class PlayerLinkedAccount {
    public string? Email { get; set; }
    public LoginIdentityProvider? Platform { get; set; }
    public string? PlatformUserId { get; set; }
    public string? Username { get; set; }
}

public class PlayerLocation {
    public string? City { get; set; }
    public ContinentCode ContinentCode { get; set; }
    public CountryCode CountryCode { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}

public class PlayerProfile {
    public List<AdCampaignAttribution>? AdCampaignAttributions { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? BannedUntil { get; set; }
    public ChurnRiskLevel? ChurnPrediction { get; set; }
    public List<ContactEmailInfo>? ContactEmailAddresses { get; set; }
    public DateTime? Created { get; set; }
    public Dictionary<string, object>? CustomProperties { get; set; }
    public string? DisplayName { get; set; }
    public DateTime? LastLogin { get; set; }
    public List<PlayerLinkedAccount>? LinkedAccounts { get; set; }
    public Dictionary<string, PlayerLocation>? Locations { get; set; }
    public LoginIdentityProvider? Origination { get; set; }
    public List<string>? PlayerExperimentVariants { get; set; }
    public string? PlayerId { get; set; }
    public List<PlayerStatistic>? PlayerStatistics { get; set; }
    public string? PublisherId { get; set; }
    public List<PushNotificationRegistration>? PushNotificationRegistrations { get; set; }
    public Dictionary<string, int>? Statistics { get; set; }
    public List<string>? Tags { get; set; }
    public string? TitleId { get; set; }
    public UInt32? TotalValueToDateInUSD { get; set; }
    public Dictionary<string, UInt32>? ValuesToDate { get; set; }
    public Dictionary<string, int>? VirtualCurrencyBalances { get; set; }
}

public class PlayerProfileModel {
    public List<AdCampaignAttributionModel>? AdCampaignAttributions { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? BannedUntil { get; set; }
    public List<ContactEmailInfoModel>? ContactEmailAddresses { get; set; }
    public DateTime? Created { get; set; }
    public string? DisplayName { get; set; }
    public List<string>? ExperimentVariants { get; set; }
    public DateTime? LastLogin { get; set; }
    public List<LinkedPlatformAccountModel>? LinkedAccounts { get; set; }
    public List<LocationModel>? Locations { get; set; }
    public List<MembershipModel>? Memberships { get; set; }
    public LoginIdentityProvider? Origination { get; set; }
    public string? PlayerId { get; set; }
    public string? PublisherId { get; set; }
    public List<PushNotificationRegistrationModel>? PushNotificationRegistrations { get; set; }
    public List<StatisticModel>? Statistics { get; set; }
    public List<TagModel>? Tags { get; set; }
    public string? TitleId { get; set; }
    public UInt32? TotalValueToDateInUSD { get; set; }
    public List<ValueToDateModel>? ValuesToDate { get; set; }
}

public class PlayerProfileViewConstraints {
    public bool ShowAvatarUrl { get; set; }
    public bool ShowBannedUntil { get; set; }
    public bool ShowCampaignAttributions { get; set; }
    public bool ShowContactEmailAddresses { get; set; }
    public bool ShowCreated { get; set; }
    public bool ShowDisplayName { get; set; }
    public bool ShowExperimentVariants { get; set; }
    public bool ShowLastLogin { get; set; }
    public bool ShowLinkedAccounts { get; set; }
    public bool ShowLocations { get; set; }
    public bool ShowMemberships { get; set; }
    public bool ShowOrigination { get; set; }
    public bool ShowPushNotificationRegistrations { get; set; }
    public bool ShowStatistics { get; set; }
    public bool ShowTags { get; set; }
    public bool ShowTotalValueToDateInUsd { get; set; }
    public bool ShowValuesToDate { get; set; }
}

public class PlayerStatistic {
    public string? Id { get; set; }
    public string? Name { get; set; }
    public int StatisticValue { get; set; }
    public int StatisticVersion { get; set; }
}

public class PlayerStatisticDefinition {
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    public UInt32 CurrentVersion { get; set; }
    public string? StatisticName { get; set; }
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class PlayerStatisticVersion {
    public required DateTime ActivationTime { get; set; }
    public StatisticVersionArchivalStatus? ArchivalStatus { get; set; }
    public string? ArchiveDownloadUrl { get; set; }
    public DateTime? DeactivationTime { get; set; }
    public DateTime? ScheduledActivationTime { get; set; }
    public DateTime? ScheduledDeactivationTime { get; set; }
    public string? StatisticName { get; set; }
    public StatisticVersionStatus? Status { get; set; }
    public UInt32 Version { get; set; }
}

public class PushNotificationContent {
    public string? Message { get; set; }
    public string? PushNotificationTemplateId { get; set; }
    public string? Subject { get; set; }
}

public enum PushNotificationPlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class PushNotificationRegistration {
    public string? NotificationEndpointARN { get; set; }
    public PushNotificationPlatform? Platform { get; set; }
}

public class PushNotificationRegistrationModel {
    public string? NotificationEndpointARN { get; set; }
    public PushNotificationPlatform? Platform { get; set; }
}

public class PushNotificationSegmentAction {
    public string? PushNotificationTemplateId { get; set; }
}

public class PushNotificationSegmentFilter {
    public SegmentPushNotificationDevicePlatform? PushNotificationDevicePlatform { get; set; }
}

public enum PushSetupPlatform {
    GCM,
    APNS,
    APNS_SANDBOX,
}

public class RandomResultTable {
    public required List<ResultTableNode> Nodes { get; set; }
    public required string TableId { get; set; }
}

public class RandomResultTableListing {
    public string? CatalogVersion { get; set; }
    public required List<ResultTableNode> Nodes { get; set; }
    public required string TableId { get; set; }
}

public class RefundPurchaseRequest : PlayFabRequestCommon {
    public required string OrderId { get; set; }
    public required string PlayFabId { get; set; }
    public string? Reason { get; set; }
}

public class RefundPurchaseResponse : PlayFabResultCommon {
    public string? PurchaseStatus { get; set; }
}

public enum Region {
    USCentral,
    USEast,
    EUWest,
    Singapore,
    Japan,
    Brazil,
    Australia,
}

/// <summary>
/// This API will trigger a player_tag_removed event and remove a tag with the given TagName and PlayFabID from the corresponding player profile. TagName can be used for segmentation and it is limited to 256 characters
/// </summary>
public class RemovePlayerTagRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string TagName { get; set; }
}

public class RemovePlayerTagResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class RemoveServerBuildRequest : PlayFabRequestCommon {
    public required string BuildId { get; set; }
}

[Obsolete("Do not use")]
public class RemoveServerBuildResult : PlayFabResultCommon {
}

/// <summary>
/// Virtual currencies to be removed cannot have entries in any catalog nor store for the title. Note that this operation will not remove player balances for the removed currencies; if a deleted currency is recreated at any point, user balances will be in an undefined state.
/// </summary>
public class RemoveVirtualCurrencyTypesRequest : PlayFabRequestCommon {
    public required List<VirtualCurrencyData> VirtualCurrencies { get; set; }
}

/// <summary>
/// Note that this action cannot be un-done. All statistics for this character will be deleted, removing the user from all leaderboards for the game.
/// </summary>
public class ResetCharacterStatisticsRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class ResetCharacterStatisticsResult : PlayFabResultCommon {
}

/// <summary>
/// Resets a player's password taking in a new password based and validating the user based off of a token sent to the playerto their email. The token expires after 30 minutes.
/// </summary>
public class ResetPasswordRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Password { get; set; }
    public required string Token { get; set; }
}

public class ResetPasswordResult : PlayFabResultCommon {
}

/// <summary>
/// This method is intended for use with test accounts, to allow a developer to reset and test a game experience from the start. Note that in order to reset an account, you must know the username. If the account does not have a username, you must add one with AddUsernamePassword in the client API prior to calling this method.
/// </summary>
[Obsolete("Do not use")]
public class ResetUsersRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<UserCredentials> Users { get; set; }
}

/// <summary>
/// Note that this action cannot be un-done. All statistics for this user will be deleted, removing the user from all leaderboards for the game.
/// </summary>
public class ResetUserStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class ResetUserStatisticsResult : PlayFabResultCommon {
}

public enum ResolutionOutcome {
    Revoke,
    Reinstate,
    Manual,
}

public class ResolvePurchaseDisputeRequest : PlayFabRequestCommon {
    public required string OrderId { get; set; }
    public ResolutionOutcome Outcome { get; set; }
    public required string PlayFabId { get; set; }
    public string? Reason { get; set; }
}

public class ResolvePurchaseDisputeResponse : PlayFabResultCommon {
    public string? PurchaseStatus { get; set; }
}

public class ResultTableNode {
    public required string ResultItem { get; set; }
    public ResultTableNodeType ResultItemType { get; set; }
    public int Weight { get; set; }
}

public enum ResultTableNodeType {
    ItemId,
    TableId,
}

/// <summary>
/// Setting the active state of all non-expired bans for a user to Inactive. Expired bans with an Active state will be ignored, however. Returns information about applied updates only.
/// </summary>
public class RevokeAllBansForUserRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class RevokeAllBansForUserResult : PlayFabResultCommon {
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// Setting the active state of all bans requested to Inactive regardless of whether that ban has already expired. BanIds that do not exist will be skipped. Returns information about applied updates only. 
/// </summary>
public class RevokeBansRequest : PlayFabRequestCommon {
    public required List<string> BanIds { get; set; }
}

public class RevokeBansResult : PlayFabResultCommon {
    public List<BanInfo>? BanData { get; set; }
}

public class RevokeInventoryItem {
    public string? CharacterId { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In cases where the inventory item in question is a "crate", and the items it contained have already been dispensed, this will not revoke access or otherwise remove the items which were dispensed.
/// </summary>
public class RevokeInventoryItemRequest : PlayFabRequestCommon {
    public string? CharacterId { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In cases where the inventory item in question is a "crate", and the items it contained have already been dispensed, this will not revoke access or otherwise remove the items which were dispensed.
/// </summary>
public class RevokeInventoryItemsRequest : PlayFabRequestCommon {
    public required List<RevokeInventoryItem> Items { get; set; }
}

public class RevokeInventoryItemsResult : PlayFabResultCommon {
    public List<RevokeItemError>? Errors { get; set; }
}

public class RevokeInventoryResult : PlayFabResultCommon {
}

public class RevokeItemError {
    public GenericErrorCodes? Error { get; set; }
    public RevokeInventoryItem? Item { get; set; }
}

/// <summary>
/// The returned task instance ID can be used to query for task execution status.
/// </summary>
public class RunTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public NameIdentifier? Identifier { get; set; }
}

public class RunTaskResult : PlayFabResultCommon {
    public string? TaskInstanceId { get; set; }
}

public class ScheduledTask {
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public DateTime? LastRunTime { get; set; }
    public required string Name { get; set; }
    public DateTime? NextRunTime { get; set; }
    public object? Parameter { get; set; }
    public string? Schedule { get; set; }
    public string? TaskId { get; set; }
    public ScheduledTaskType? Type { get; set; }
}

public enum ScheduledTaskType {
    CloudScript,
    ActionsOnPlayerSegment,
    CloudScriptAzureFunctions,
    InsightsScheduledScaling,
}

public class ScriptExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

public class SegmentAndDefinition {
    public AdCampaignSegmentFilter? AdCampaignFilter { get; set; }
    public AllPlayersSegmentFilter? AllPlayersFilter { get; set; }
    public ChurnPredictionSegmentFilter? ChurnPredictionFilter { get; set; }
    public CustomPropertyBooleanSegmentFilter? CustomPropertyBooleanFilter { get; set; }
    public CustomPropertyDateTimeSegmentFilter? CustomPropertyDateTimeFilter { get; set; }
    public CustomPropertyNumericSegmentFilter? CustomPropertyNumericFilter { get; set; }
    public CustomPropertyStringSegmentFilter? CustomPropertyStringFilter { get; set; }
    public FirstLoginDateSegmentFilter? FirstLoginDateFilter { get; set; }
    public FirstLoginTimespanSegmentFilter? FirstLoginFilter { get; set; }
    public LastLoginDateSegmentFilter? LastLoginDateFilter { get; set; }
    public LastLoginTimespanSegmentFilter? LastLoginFilter { get; set; }
    public LinkedUserAccountSegmentFilter? LinkedUserAccountFilter { get; set; }
    public LinkedUserAccountHasEmailSegmentFilter? LinkedUserAccountHasEmailFilter { get; set; }
    public LocationSegmentFilter? LocationFilter { get; set; }
    public PlayerChurnPredictionSegmentFilter? PlayerChurnPredictionFilter { get; set; }
    public PlayerChurnPredictionTimeSegmentFilter? PlayerChurnPredictionTimeFilter { get; set; }
    public PlayerChurnPreviousPredictionSegmentFilter? PlayerChurnPreviousPredictionFilter { get; set; }
    public PushNotificationSegmentFilter? PushNotificationFilter { get; set; }
    public StatisticSegmentFilter? StatisticFilter { get; set; }
    public TagSegmentFilter? TagFilter { get; set; }
    public TotalValueToDateInUSDSegmentFilter? TotalValueToDateInUSDFilter { get; set; }
    public UserOriginationSegmentFilter? UserOriginationFilter { get; set; }
    public ValueToDateSegmentFilter? ValueToDateFilter { get; set; }
    public VirtualCurrencyBalanceSegmentFilter? VirtualCurrencyBalanceFilter { get; set; }
}

public enum SegmentCountryCode {
    AF,
    AX,
    AL,
    DZ,
    AS,
    AD,
    AO,
    AI,
    AQ,
    AG,
    AR,
    AM,
    AW,
    AU,
    AT,
    AZ,
    BS,
    BH,
    BD,
    BB,
    BY,
    BE,
    BZ,
    BJ,
    BM,
    BT,
    BO,
    BQ,
    BA,
    BW,
    BV,
    BR,
    IO,
    BN,
    BG,
    BF,
    BI,
    KH,
    CM,
    CA,
    CV,
    KY,
    CF,
    TD,
    CL,
    CN,
    CX,
    CC,
    CO,
    KM,
    CG,
    CD,
    CK,
    CR,
    CI,
    HR,
    CU,
    CW,
    CY,
    CZ,
    DK,
    DJ,
    DM,
    DO,
    EC,
    EG,
    SV,
    GQ,
    ER,
    EE,
    ET,
    FK,
    FO,
    FJ,
    FI,
    FR,
    GF,
    PF,
    TF,
    GA,
    GM,
    GE,
    DE,
    GH,
    GI,
    GR,
    GL,
    GD,
    GP,
    GU,
    GT,
    GG,
    GN,
    GW,
    GY,
    HT,
    HM,
    VA,
    HN,
    HK,
    HU,
    IS,
    IN,
    ID,
    IR,
    IQ,
    IE,
    IM,
    IL,
    IT,
    JM,
    JP,
    JE,
    JO,
    KZ,
    KE,
    KI,
    KP,
    KR,
    KW,
    KG,
    LA,
    LV,
    LB,
    LS,
    LR,
    LY,
    LI,
    LT,
    LU,
    MO,
    MK,
    MG,
    MW,
    MY,
    MV,
    ML,
    MT,
    MH,
    MQ,
    MR,
    MU,
    YT,
    MX,
    FM,
    MD,
    MC,
    MN,
    ME,
    MS,
    MA,
    MZ,
    MM,
    NA,
    NR,
    NP,
    NL,
    NC,
    NZ,
    NI,
    NE,
    NG,
    NU,
    NF,
    MP,
    NO,
    OM,
    PK,
    PW,
    PS,
    PA,
    PG,
    PY,
    PE,
    PH,
    PN,
    PL,
    PT,
    PR,
    QA,
    RE,
    RO,
    RU,
    RW,
    BL,
    SH,
    KN,
    LC,
    MF,
    PM,
    VC,
    WS,
    SM,
    ST,
    SA,
    SN,
    RS,
    SC,
    SL,
    SG,
    SX,
    SK,
    SI,
    SB,
    SO,
    ZA,
    GS,
    SS,
    ES,
    LK,
    SD,
    SR,
    SJ,
    SZ,
    SE,
    CH,
    SY,
    TW,
    TJ,
    TZ,
    TH,
    TL,
    TG,
    TK,
    TO,
    TT,
    TN,
    TR,
    TM,
    TC,
    TV,
    UG,
    UA,
    AE,
    GB,
    US,
    UM,
    UY,
    UZ,
    VU,
    VE,
    VN,
    VG,
    VI,
    WF,
    EH,
    YE,
    ZM,
    ZW,
}

public enum SegmentCurrency {
    AED,
    AFN,
    ALL,
    AMD,
    ANG,
    AOA,
    ARS,
    AUD,
    AWG,
    AZN,
    BAM,
    BBD,
    BDT,
    BGN,
    BHD,
    BIF,
    BMD,
    BND,
    BOB,
    BRL,
    BSD,
    BTN,
    BWP,
    BYR,
    BZD,
    CAD,
    CDF,
    CHF,
    CLP,
    CNY,
    COP,
    CRC,
    CUC,
    CUP,
    CVE,
    CZK,
    DJF,
    DKK,
    DOP,
    DZD,
    EGP,
    ERN,
    ETB,
    EUR,
    FJD,
    FKP,
    GBP,
    GEL,
    GGP,
    GHS,
    GIP,
    GMD,
    GNF,
    GTQ,
    GYD,
    HKD,
    HNL,
    HRK,
    HTG,
    HUF,
    IDR,
    ILS,
    IMP,
    INR,
    IQD,
    IRR,
    ISK,
    JEP,
    JMD,
    JOD,
    JPY,
    KES,
    KGS,
    KHR,
    KMF,
    KPW,
    KRW,
    KWD,
    KYD,
    KZT,
    LAK,
    LBP,
    LKR,
    LRD,
    LSL,
    LYD,
    MAD,
    MDL,
    MGA,
    MKD,
    MMK,
    MNT,
    MOP,
    MRO,
    MUR,
    MVR,
    MWK,
    MXN,
    MYR,
    MZN,
    NAD,
    NGN,
    NIO,
    NOK,
    NPR,
    NZD,
    OMR,
    PAB,
    PEN,
    PGK,
    PHP,
    PKR,
    PLN,
    PYG,
    QAR,
    RON,
    RSD,
    RUB,
    RWF,
    SAR,
    SBD,
    SCR,
    SDG,
    SEK,
    SGD,
    SHP,
    SLL,
    SOS,
    SPL,
    SRD,
    STD,
    SVC,
    SYP,
    SZL,
    THB,
    TJS,
    TMT,
    TND,
    TOP,
    TRY,
    TTD,
    TVD,
    TWD,
    TZS,
    UAH,
    UGX,
    USD,
    UYU,
    UZS,
    VEF,
    VND,
    VUV,
    WST,
    XAF,
    XCD,
    XDR,
    XOF,
    XPF,
    YER,
    ZAR,
    ZMW,
    ZWD,
}

public enum SegmentFilterComparison {
    GreaterThan,
    LessThan,
    EqualTo,
    NotEqualTo,
    GreaterThanOrEqual,
    LessThanOrEqual,
    Exists,
    Contains,
    NotContains,
}

public enum SegmentLoginIdentityProvider {
    Unknown,
    PlayFab,
    Custom,
    GameCenter,
    GooglePlay,
    Steam,
    XBoxLive,
    PSN,
    Kongregate,
    Facebook,
    IOSDevice,
    AndroidDevice,
    Twitch,
    WindowsHello,
    GameServer,
    CustomServer,
    NintendoSwitch,
    FacebookInstantGames,
    OpenIdConnect,
    Apple,
    NintendoSwitchAccount,
    GooglePlayGames,
}

public class SegmentModel {
    public string? Description { get; set; }
    public List<SegmentTrigger>? EnteredSegmentActions { get; set; }
    public required DateTime LastUpdateTime { get; set; }
    public List<SegmentTrigger>? LeftSegmentActions { get; set; }
    public string? Name { get; set; }
    public string? SegmentId { get; set; }
    public List<SegmentOrDefinition>? SegmentOrDefinitions { get; set; }
}

public class SegmentOrDefinition {
    public List<SegmentAndDefinition>? SegmentAndDefinitions { get; set; }
}

public enum SegmentPushNotificationDevicePlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class SegmentTrigger {
    public AddInventoryItemsV2SegmentAction? AddInventoryItemsV2Action { get; set; }
    public BanPlayerSegmentAction? BanPlayerAction { get; set; }
    public DeleteInventoryItemsV2SegmentAction? DeleteInventoryItemsV2Action { get; set; }
    public DeletePlayerSegmentAction? DeletePlayerAction { get; set; }
    public DeletePlayerStatisticSegmentAction? DeletePlayerStatisticAction { get; set; }
    public EmailNotificationSegmentAction? EmailNotificationAction { get; set; }
    public ExecuteAzureFunctionSegmentAction? ExecuteAzureFunctionAction { get; set; }
    public ExecuteCloudScriptSegmentAction? ExecuteCloudScriptAction { get; set; }
    public GrantItemSegmentAction? GrantItemAction { get; set; }
    public GrantVirtualCurrencySegmentAction? GrantVirtualCurrencyAction { get; set; }
    public IncrementPlayerStatisticSegmentAction? IncrementPlayerStatisticAction { get; set; }
    public PushNotificationSegmentAction? PushNotificationAction { get; set; }
    public SubtractInventoryItemsV2SegmentAction? SubtractInventoryItemsV2Action { get; set; }
}

/// <summary>
/// If the account in question is a "temporary" account (for example, one that was created via a call to LoginFromIOSDeviceID), thisfunction will have no effect. Only PlayFab accounts which have valid email addresses will be able to receive a password reset email using this API.
/// </summary>
public class SendAccountRecoveryEmailRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Email { get; set; }
    public string? EmailTemplateId { get; set; }
}

public class SendAccountRecoveryEmailResult : PlayFabResultCommon {
}

public class SendEmailContent {
    public required string EmailTemplateId { get; set; }
}

/// <summary>
/// The request must contain a valid sink to which PlayFab has write permissions. The sink destination types can be found in the PlayFab documentation.
/// </summary>
public class SetEventSinkRequest : PlayFabRequestCommon {
    public required EventSink Sink { get; set; }
}

public class SetEventSinkResult : PlayFabResultCommon {
}

/// <summary>
/// This API lets developers set overrides for membership expirations, independent of any subscriptions setting it.
/// </summary>
public class SetMembershipOverrideRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required DateTime ExpirationTime { get; set; }
    public required string MembershipId { get; set; }
    public required string PlayFabId { get; set; }
}

public class SetMembershipOverrideResult : PlayFabResultCommon {
}

/// <summary>
/// APIs that require signatures require that the player have a configured Player Secret Key that is used to sign all requests. Players that don't have a secret will be blocked from making API calls until it is configured. To create a signature header add a SHA256 hashed string containing UTF8 encoded JSON body as it will be sent to the server, the current time in UTC formatted to ISO 8601, and the players secret formatted as 'body.date.secret'. Place the resulting hash into the header X-PlayFab-Signature, along with a header X-PlayFab-Timestamp of the same UTC timestamp used in the signature.
/// </summary>
public class SetPlayerSecretRequest : PlayFabRequestCommon {
    public string? PlayerSecret { get; set; }
    public required string PlayFabId { get; set; }
}

public class SetPlayerSecretResult : PlayFabResultCommon {
}

public class SetPublishedRevisionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int Revision { get; set; }
    public int Version { get; set; }
}

public class SetPublishedRevisionResult : PlayFabResultCommon {
}

/// <summary>
/// This API is designed to store publisher-specific values which can be read, but not written to, by the client. This data is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only titles assigned to a publisher can use this API. This operation is additive. If a Key does not exist in the current dataset, it will be added with the specified Value. If it already exists, the Value for that key will be overwritten with the new Value. For more information email helloplayfab@microsoft.com
/// </summary>
public class SetPublisherDataRequest : PlayFabRequestCommon {
    public required string Key { get; set; }
    public string? Value { get; set; }
}

public class SetPublisherDataResult : PlayFabResultCommon {
}

/// <summary>
/// Will set the given key values in the specified override or the primary title data based on whether the label is provided or not.
/// </summary>
public class SetTitleDataAndOverridesRequest : PlayFabRequestCommon {
    public required List<TitleDataKeyValue> KeyValues { get; set; }
    public string? OverrideLabel { get; set; }
}

public class SetTitleDataAndOverridesResult : PlayFabResultCommon {
}

/// <summary>
/// This operation is additive. If a Key does not exist in the current dataset, it will be added with the specified Value. If it already exists, the Value for that key will be overwritten with the new Value.
/// </summary>
public class SetTitleDataRequest : PlayFabRequestCommon {
    public required string Key { get; set; }
    public string? Value { get; set; }
}

public class SetTitleDataResult : PlayFabResultCommon {
}

/// <summary>
/// When using the Apple Push Notification service (APNS) or the development version (APNS_SANDBOX), the APNS Private Key should be used as the Credential in this call. With Google Cloud Messaging (GCM), the Android API Key should be used. The current ARN (if one exists) can be overwritten by setting the OverwriteOldARN boolean to true.
/// </summary>
public class SetupPushNotificationRequest : PlayFabRequestCommon {
    public required string Credential { get; set; }
    public string? Key { get; set; }
    public string? Name { get; set; }
    public bool OverwriteOldARN { get; set; }
    public PushSetupPlatform Platform { get; set; }
}

public class SetupPushNotificationResult : PlayFabResultCommon {
    public string? ARN { get; set; }
}

public class SharedSecret {
    public bool Disabled { get; set; }
    public string? FriendlyName { get; set; }
    public string? SecretKey { get; set; }
}

public enum SourceType {
    Admin,
    BackEnd,
    GameClient,
    GameServer,
    Partner,
    Custom,
    API,
}

public enum StatisticAggregationMethod {
    Last,
    Min,
    Max,
    Sum,
}

public class StatisticModel {
    public string? Name { get; set; }
    public int Value { get; set; }
    public int Version { get; set; }
}

public enum StatisticResetIntervalOption {
    Never,
    Hour,
    Day,
    Week,
    Month,
}

public class StatisticSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? FilterValue { get; set; }
    public string? Name { get; set; }
    public bool? UseCurrentVersion { get; set; }
    public int? Version { get; set; }
}

public enum StatisticVersionArchivalStatus {
    NotScheduled,
    Scheduled,
    Queued,
    InProgress,
    Complete,
}

public enum StatisticVersionStatus {
    Active,
    SnapshotPending,
    Snapshot,
    ArchivalPending,
    Archived,
}

/// <summary>
/// A store entry that list a catalog item at a particular price
/// </summary>
public class StoreItem {
    public object? CustomData { get; set; }
    public UInt32? DisplayPosition { get; set; }
    public required string ItemId { get; set; }
    public Dictionary<string, UInt32>? RealCurrencyPrices { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrencyPrices { get; set; }
}

/// <summary>
/// Marketing data about a specific store
/// </summary>
public class StoreMarketingModel {
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public object? Metadata { get; set; }
}

public class SubscriptionModel {
    public required DateTime Expiration { get; set; }
    public required DateTime InitialSubscriptionTime { get; set; }
    public bool IsActive { get; set; }
    public SubscriptionProviderStatus? Status { get; set; }
    public string? SubscriptionId { get; set; }
    public string? SubscriptionItemId { get; set; }
    public string? SubscriptionProvider { get; set; }
}

public enum SubscriptionProviderStatus {
    NoError,
    Cancelled,
    UnknownError,
    BillingError,
    ProductUnavailable,
    CustomerDidNotAcceptPriceChange,
    FreeTrial,
    PaymentPending,
}

public class SubtractInventoryItemsV2SegmentAction {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public int? DurationInSeconds { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class SubtractInventoryItemV2Content {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public int? DurationInSeconds { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class SubtractUserVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string VirtualCurrency { get; set; }
}

public class TagModel {
    public string? TagValue { get; set; }
}

public class TagSegmentFilter {
    public SegmentFilterComparison? Comparison { get; set; }
    public string? TagValue { get; set; }
}

public class TaskInstanceBasicSummary {
    public DateTime? CompletedAt { get; set; }
    public string? ErrorMessage { get; set; }
    public double? EstimatedSecondsRemaining { get; set; }
    public double? PercentComplete { get; set; }
    public string? ScheduledByUserId { get; set; }
    public required DateTime StartedAt { get; set; }
    public TaskInstanceStatus? Status { get; set; }
    public NameIdentifier? TaskIdentifier { get; set; }
    public string? TaskInstanceId { get; set; }
    public ScheduledTaskType? Type { get; set; }
}

public enum TaskInstanceStatus {
    Succeeded,
    Starting,
    InProgress,
    Failed,
    Aborted,
    Stalled,
}

public enum TitleActivationStatus {
    None,
    ActivatedTitleKey,
    PendingSteam,
    ActivatedSteam,
    RevokedSteam,
}

public class TitleDataKeyValue {
    public string? Key { get; set; }
    public string? Value { get; set; }
}

public class TotalValueToDateInUSDSegmentFilter {
    public string? Amount { get; set; }
    public SegmentFilterComparison? Comparison { get; set; }
}

/// <summary>
/// Represents a single update ban request.
/// </summary>
public class UpdateBanRequest {
    public bool? Active { get; set; }
    public required string BanId { get; set; }
    public DateTime? Expires { get; set; }
    public bool? IncludeMicrosoftFamily { get; set; }
    public string? IPAddress { get; set; }
    public string? MACAddress { get; set; }
    public bool? Permanent { get; set; }
    public string? Reason { get; set; }
    public UserFamilyType? UserFamilyType { get; set; }
}

/// <summary>
/// For each ban, only updates the values that are set. Leave any value to null for no change. If a ban could not be found, the rest are still applied. Returns information about applied updates only.
/// </summary>
public class UpdateBansRequest : PlayFabRequestCommon {
    public required List<UpdateBanRequest> Bans { get; set; }
}

public class UpdateBansResult : PlayFabResultCommon {
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// When used for SetCatalogItems, this operation is not additive. Using it will cause the indicated catalog version to be created from scratch. If there is an existing catalog with the version number in question, it will be deleted and replaced with only the items specified in this call. When used for UpdateCatalogItems, this operation is additive. Items with ItemId values not currently in the catalog will be added, while those with ItemId values matching items currently in the catalog will overwrite those items with the given values.
/// </summary>
public class UpdateCatalogItemsRequest : PlayFabRequestCommon {
    public List<CatalogItem>? Catalog { get; set; }
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? SetAsDefaultCatalog { get; set; }
}

public class UpdateCatalogItemsResult : PlayFabResultCommon {
}

public class UpdateCloudScriptRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DeveloperPlayFabId { get; set; }
    public required List<CloudScriptFile> Files { get; set; }
    public bool Publish { get; set; }
    public int? Version { get; set; }
}

public class UpdateCloudScriptResult : PlayFabResultCommon {
    public int Revision { get; set; }
    public int Version { get; set; }
}

public class UpdateOpenIdConnectionRequest : PlayFabRequestCommon {
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
    public required string ConnectionId { get; set; }
    public bool? IgnoreNonce { get; set; }
    public string? IssuerDiscoveryUrl { get; set; }
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    public string? IssuerOverride { get; set; }
}

/// <summary>
/// Performs an additive update of the custom properties for the specified player. In updating the player's custom properties, properties which already exist will have their values overwritten. No other properties will be changed apart from those specified in the call.
/// </summary>
public class UpdatePlayerCustomPropertiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? ExpectedPropertiesVersion { get; set; }
    public required string PlayFabId { get; set; }
    public required List<UpdateProperty> Properties { get; set; }
}

public class UpdatePlayerCustomPropertiesResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class UpdatePlayerSharedSecretRequest : PlayFabRequestCommon {
    public bool Disabled { get; set; }
    public string? FriendlyName { get; set; }
    public string? SecretKey { get; set; }
}

public class UpdatePlayerSharedSecretResult : PlayFabResultCommon {
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval enables automatically resetting leaderboards on a specified interval. Upon reset, the statistic updates to a new version with no values (effectively removing all players from the leaderboard). The previous version's statistic values are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short, pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also, once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version information (GetPlayerStatisticVersions). The AggregationMethod determines what action is taken when a new statistic value is submitted - always update with the new value (Last), use the highest of the old and new values (Max), use the smallest (Min), or add them together (Sum).
/// </summary>
public class UpdatePlayerStatisticDefinitionRequest : PlayFabRequestCommon {
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    public required string StatisticName { get; set; }
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class UpdatePlayerStatisticDefinitionResult : PlayFabResultCommon {
    public PlayerStatisticDefinition? Statistic { get; set; }
}

/// <summary>
/// Updates permissions for your title. Policies affect what is allowed to happen on your title. Your policy is a collection of statements that, together, govern particular area for your title. Today, the only allowed policy is called 'ApiPolicy' and it governs what API calls are allowed. To verify that you have the latest version always download the current policy from GetPolicy before uploading a new policy. PlayFab updates the base policy periodically and will automatically apply it to the uploaded policy. Overwriting the combined policy blindly may result in unexpected API errors.
/// </summary>
public class UpdatePolicyRequest : PlayFabRequestCommon {
    public bool OverwritePolicy { get; set; }
    public required string PolicyName { get; set; }
    public int PolicyVersion { get; set; }
    public required List<PermissionStatement> Statements { get; set; }
}

public class UpdatePolicyResponse : PlayFabResultCommon {
    public string? PolicyName { get; set; }
    public List<PermissionStatement>? Statements { get; set; }
}

public class UpdateProperty {
    public required string Name { get; set; }
    public required object Value { get; set; }
}

/// <summary>
/// This operation is additive. Tables with TableId values not currently defined will be added, while those with TableId values matching Tables currently in the catalog will be overwritten with the given values.
/// </summary>
public class UpdateRandomResultTablesRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<RandomResultTable>? Tables { get; set; }
}

public class UpdateRandomResultTablesResult : PlayFabResultCommon {
}

/// <summary>
/// Update segment properties data which are planning to update
/// </summary>
public class UpdateSegmentRequest : PlayFabRequestCommon {
    public required SegmentModel SegmentModel { get; set; }
}

public class UpdateSegmentResponse : PlayFabResultCommon {
    public string? ErrorMessage { get; set; }
    public string? SegmentId { get; set; }
}

/// <summary>
/// When used for SetStoreItems, this operation is not additive. Using it will cause the indicated virtual store to be created from scratch. If there is an existing store with the same storeId, it will be deleted and replaced with only the items specified in this call. When used for UpdateStoreItems, this operation is additive. Items with ItemId values not currently in the store will be added, while those with ItemId values matching items currently in the catalog will overwrite those items with the given values. In both cases, a store contains an array of references to items defined in the catalog, along with the prices for the item, in both real world and virtual currencies. These prices act as an override to any prices defined in the catalog. In this way, the base definitions of the items may be defined in the catalog, with all associated properties, while the pricing can be set for each store, as needed. This allows for subsets of goods to be defined for different purposes (in order to simplify showing some, but not all catalog items to users, based upon different characteristics), along with unique prices. Note that all prices defined in the catalog and store definitions for the item are considered valid, and that a compromised client can be made to send a request for an item based upon any of these definitions. If no price is specified in the store for an item, the price set in the catalog should be displayed to the user.
/// </summary>
public class UpdateStoreItemsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public StoreMarketingModel? MarketingData { get; set; }
    public List<StoreItem>? Store { get; set; }
    public required string StoreId { get; set; }
}

public class UpdateStoreItemsResult : PlayFabResultCommon {
}

/// <summary>
/// Note that when calling this API, all properties of the task have to be provided, including properties that you do not want to change. Parameters not specified would be set to default value. If the task name in the update request is new, a task rename operation will be executed before updating other fields of the task. WARNING: Renaming of a task may break logics where the task name is used as an identifier.
/// </summary>
public class UpdateTaskRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public NameIdentifier? Identifier { get; set; }
    public bool IsActive { get; set; }
    public required string Name { get; set; }
    public object? Parameter { get; set; }
    public string? Schedule { get; set; }
    public ScheduledTaskType Type { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the user. In updating the custom data object, keys which already exist in the object will have their values overwritten, while keys with null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserDataRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public UserDataPermission? Permission { get; set; }
    public required string PlayFabId { get; set; }
}

public class UpdateUserDataResult : PlayFabResultCommon {
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the user. In updating the custom data object, keys which already exist in the object will have their values overwritten, keys with null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserInternalDataRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In addition to the PlayFab username, titles can make use of a DisplayName which is also a unique identifier, but specific to the title. This allows for unique names which more closely match the theme or genre of a title, for example. This API enables changing that name, whether due to a customer request, an offensive name choice, etc.
/// </summary>
public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string DisplayName { get; set; }
    public required string PlayFabId { get; set; }
}

public class UpdateUserTitleDisplayNameResult : PlayFabResultCommon {
    public string? DisplayName { get; set; }
}

public class UserAccountInfo {
    public UserAndroidDeviceInfo? AndroidDeviceInfo { get; set; }
    public UserAppleIdInfo? AppleAccountInfo { get; set; }
    public UserBattleNetInfo? BattleNetAccountInfo { get; set; }
    public required DateTime Created { get; set; }
    public UserCustomIdInfo? CustomIdInfo { get; set; }
    public UserFacebookInfo? FacebookInfo { get; set; }
    public UserFacebookInstantGamesIdInfo? FacebookInstantGamesIdInfo { get; set; }
    public UserGameCenterInfo? GameCenterInfo { get; set; }
    public UserGoogleInfo? GoogleInfo { get; set; }
    public UserGooglePlayGamesInfo? GooglePlayGamesInfo { get; set; }
    public UserIosDeviceInfo? IosDeviceInfo { get; set; }
    public UserKongregateInfo? KongregateInfo { get; set; }
    public UserNintendoSwitchAccountIdInfo? NintendoSwitchAccountInfo { get; set; }
    public UserNintendoSwitchDeviceIdInfo? NintendoSwitchDeviceIdInfo { get; set; }
    public List<UserOpenIdInfo>? OpenIdInfo { get; set; }
    public string? PlayFabId { get; set; }
    public UserPrivateAccountInfo? PrivateInfo { get; set; }
    public UserPsnInfo? PsnInfo { get; set; }
    public UserServerCustomIdInfo? ServerCustomIdInfo { get; set; }
    public UserSteamInfo? SteamInfo { get; set; }
    public UserTitleInfo? TitleInfo { get; set; }
    public UserTwitchInfo? TwitchInfo { get; set; }
    public string? Username { get; set; }
    public UserXboxInfo? XboxInfo { get; set; }
}

public class UserAndroidDeviceInfo {
    public string? AndroidDeviceId { get; set; }
}

public class UserAppleIdInfo {
    public string? AppleSubjectId { get; set; }
}

public class UserBattleNetInfo {
    public string? BattleNetAccountId { get; set; }
    public string? BattleNetBattleTag { get; set; }
}

[Obsolete("Do not use")]
public class UserCredentials {
    public string? Password { get; set; }
    public required string Username { get; set; }
}

public class UserCustomIdInfo {
    public string? CustomId { get; set; }
}

public enum UserDataPermission {
    Private,
    Public,
}

public class UserDataRecord {
    public required DateTime LastUpdated { get; set; }
    public UserDataPermission? Permission { get; set; }
    public string? Value { get; set; }
}

public class UserFacebookInfo {
    public string? FacebookId { get; set; }
    public string? FullName { get; set; }
}

public class UserFacebookInstantGamesIdInfo {
    public string? FacebookInstantGamesId { get; set; }
}

public enum UserFamilyType {
    None,
    Xbox,
    Steam,
}

public class UserGameCenterInfo {
    public string? GameCenterId { get; set; }
}

public class UserGoogleInfo {
    public string? GoogleEmail { get; set; }
    public string? GoogleGender { get; set; }
    public string? GoogleId { get; set; }
    public string? GoogleLocale { get; set; }
    public string? GoogleName { get; set; }
}

public class UserGooglePlayGamesInfo {
    public string? GooglePlayGamesPlayerAvatarImageUrl { get; set; }
    public string? GooglePlayGamesPlayerDisplayName { get; set; }
    public string? GooglePlayGamesPlayerId { get; set; }
}

public class UserIosDeviceInfo {
    public string? IosDeviceId { get; set; }
}

public class UserKongregateInfo {
    public string? KongregateId { get; set; }
    public string? KongregateName { get; set; }
}

public class UserNintendoSwitchAccountIdInfo {
    public string? NintendoSwitchAccountSubjectId { get; set; }
}

public class UserNintendoSwitchDeviceIdInfo {
    public string? NintendoSwitchDeviceId { get; set; }
}

public class UserOpenIdInfo {
    public string? ConnectionId { get; set; }
    public string? Issuer { get; set; }
    public string? Subject { get; set; }
}

public enum UserOrigination {
    Organic,
    Steam,
    Google,
    Amazon,
    Facebook,
    Kongregate,
    GamersFirst,
    Unknown,
    IOS,
    LoadTest,
    Android,
    PSN,
    GameCenter,
    CustomId,
    XboxLive,
    Parse,
    Twitch,
    ServerCustomId,
    NintendoSwitchDeviceId,
    FacebookInstantGamesId,
    OpenIdConnect,
    Apple,
    NintendoSwitchAccount,
    GooglePlayGames,
    XboxMobileStore,
    King,
    BattleNet,
}

public class UserOriginationSegmentFilter {
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

public class UserPrivateAccountInfo {
    public string? Email { get; set; }
}

public class UserPsnInfo {
    public string? PsnAccountId { get; set; }
    public string? PsnOnlineId { get; set; }
}

public class UserServerCustomIdInfo {
    public string? CustomId { get; set; }
}

public class UserSteamInfo {
    public TitleActivationStatus? SteamActivationStatus { get; set; }
    public string? SteamCountry { get; set; }
    public Currency? SteamCurrency { get; set; }
    public string? SteamId { get; set; }
    public string? SteamName { get; set; }
}

public class UserTitleInfo {
    public string? AvatarUrl { get; set; }
    public required DateTime Created { get; set; }
    public string? DisplayName { get; set; }
    public DateTime? FirstLogin { get; set; }
    public bool? isBanned { get; set; }
    public DateTime? LastLogin { get; set; }
    public UserOrigination? Origination { get; set; }
    public EntityKey? TitlePlayerAccount { get; set; }
}

public class UserTwitchInfo {
    public string? TwitchId { get; set; }
    public string? TwitchUserName { get; set; }
}

public class UserXboxInfo {
    public string? XboxUserId { get; set; }
    public string? XboxUserSandbox { get; set; }
}

public class ValueToDateModel {
    public string? Currency { get; set; }
    public UInt32 TotalValue { get; set; }
    public string? TotalValueAsDecimal { get; set; }
}

public class ValueToDateSegmentFilter {
    public string? Amount { get; set; }
    public SegmentFilterComparison? Comparison { get; set; }
    public SegmentCurrency? Currency { get; set; }
}

public class VirtualCurrencyBalanceSegmentFilter {
    public int Amount { get; set; }
    public SegmentFilterComparison? Comparison { get; set; }
    public string? CurrencyCode { get; set; }
}

public class VirtualCurrencyData {
    public required string CurrencyCode { get; set; }
    public string? DisplayName { get; set; }
    public int? InitialDeposit { get; set; }
    public int? RechargeMax { get; set; }
    public int? RechargeRate { get; set; }
}

public class VirtualCurrencyRechargeTime {
    public int RechargeMax { get; set; }
    public required DateTime RechargeTime { get; set; }
    public int SecondsToRecharge { get; set; }
}

