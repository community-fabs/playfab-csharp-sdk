namespace CommunityFabs.NET.Sdk.Models.CloudScript;

public class AdCampaignAttributionModel {
    public required DateTime AttributedAt { get; set; }
    public string? CampaignId { get; set; }
    public string? Platform { get; set; }
}

public enum CloudScriptRevisionOption {
    Live,
    Latest,
    Specific,
}

public class ContactEmailInfoModel {
    public string? EmailAddress { get; set; }
    public string? Name { get; set; }
    public EmailVerificationStatus? VerificationStatus { get; set; }
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

public enum EmailVerificationStatus {
    Unverified,
    Pending,
    Confirmed,
}

public class EmptyResult {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class EventHubFunctionModel {
    public string? ConnectionString { get; set; }
    public string? EventHubName { get; set; }
    public string? FunctionName { get; set; }
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

/// <summary>
/// Executes CloudScript with the entity profile that is defined in the request.
/// </summary>
public class ExecuteEntityCloudScriptRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string FunctionName { get; set; }
    public object? FunctionParameter { get; set; }
    public bool? GeneratePlayStreamEvent { get; set; }
    public CloudScriptRevisionOption? RevisionSelection { get; set; }
    public int? SpecificRevision { get; set; }
}

/// <summary>
/// Executes an Azure Function with the profile of the entity that is defined in the request.
/// </summary>
public class ExecuteFunctionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string FunctionName { get; set; }
    public object? FunctionParameter { get; set; }
    public bool? GeneratePlayStreamEvent { get; set; }
}

public class ExecuteFunctionResult {
    public FunctionExecutionError? Error { get; set; }
    public int ExecutionTimeMilliseconds { get; set; }
    public string? FunctionName { get; set; }
    public object? FunctionResult { get; set; }
    public bool? FunctionResultTooLarge { get; set; }
}

public class FunctionExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

public class FunctionModel {
    public string? FunctionAddress { get; set; }
    public string? FunctionName { get; set; }
    public string? TriggerType { get; set; }
}

public class GetFunctionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
}

public class GetFunctionResult {
    public string? ConnectionString { get; set; }
    public string? FunctionUrl { get; set; }
    public string? QueueName { get; set; }
    public string? TriggerType { get; set; }
}

public class HttpFunctionModel {
    public string? FunctionName { get; set; }
    public string? FunctionUrl { get; set; }
}

public class LinkedPlatformAccountModel {
    public string? Email { get; set; }
    public LoginIdentityProvider? Platform { get; set; }
    public string? PlatformUserId { get; set; }
    public string? Username { get; set; }
}

public class ListEventHubFunctionsResult {
    public List<EventHubFunctionModel>? Functions { get; set; }
}

/// <summary>
/// A title can have many functions, ListHttpFunctions will return a list of all the currently registered HTTP triggered functions for a given title.
/// </summary>
public class ListFunctionsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListFunctionsResult {
    public List<FunctionModel>? Functions { get; set; }
}

public class ListHttpFunctionsResult {
    public List<HttpFunctionModel>? Functions { get; set; }
}

public class ListQueuedFunctionsResult {
    public List<QueuedFunctionModel>? Functions { get; set; }
}

public class LocationModel {
    public string? City { get; set; }
    public ContinentCode? ContinentCode { get; set; }
    public CountryCode? CountryCode { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
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

public class MembershipModel {
    public bool IsActive { get; set; }
    public required DateTime MembershipExpiration { get; set; }
    public string? MembershipId { get; set; }
    public DateTime? OverrideExpiration { get; set; }
    public bool? OverrideIsSet { get; set; }
    public List<SubscriptionModel>? Subscriptions { get; set; }
}

/// <summary>
/// Identifier by either name or ID. Note that a name may change due to renaming, or reused after being deleted. ID is immutable and unique.
/// </summary>
public class NameIdentifier {
    public string? Id { get; set; }
    public string? Name { get; set; }
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

public class PlayStreamEventEnvelopeModel {
    public string? EntityId { get; set; }
    public string? EntityType { get; set; }
    public string? EventData { get; set; }
    public string? EventName { get; set; }
    public string? EventNamespace { get; set; }
    public string? EventSettings { get; set; }
}

public class PostFunctionResultForEntityTriggeredActionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required ExecuteFunctionResult FunctionResult { get; set; }
}

public class PostFunctionResultForFunctionExecutionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required ExecuteFunctionResult FunctionResult { get; set; }
}

public class PostFunctionResultForPlayerTriggeredActionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required ExecuteFunctionResult FunctionResult { get; set; }
    public required PlayerProfileModel PlayerProfile { get; set; }
    public PlayStreamEventEnvelopeModel? PlayStreamEventEnvelope { get; set; }
}

public class PostFunctionResultForScheduledTaskRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required ExecuteFunctionResult FunctionResult { get; set; }
    public required NameIdentifier ScheduledTaskId { get; set; }
}

public enum PushNotificationPlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class PushNotificationRegistrationModel {
    public string? NotificationEndpointARN { get; set; }
    public PushNotificationPlatform? Platform { get; set; }
}

public class QueuedFunctionModel {
    public string? ConnectionString { get; set; }
    public string? FunctionName { get; set; }
    public string? QueueName { get; set; }
}

/// <summary>
/// A title can have many functions, RegisterEventHubFunction associates a function name with an event hub name and connection string.
/// </summary>
public class RegisterEventHubFunctionRequest {
    public required string ConnectionString { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventHubName { get; set; }
    public required string FunctionName { get; set; }
}

public class RegisterHttpFunctionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
    public required string FunctionUrl { get; set; }
}

/// <summary>
/// A title can have many functions, RegisterQueuedFunction associates a function name with a queue name and connection string.
/// </summary>
public class RegisterQueuedFunctionRequest {
    public required string ConnectionString { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
    public required string QueueName { get; set; }
}

public class ScriptExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

public class StatisticModel {
    public string? Name { get; set; }
    public int Value { get; set; }
    public int Version { get; set; }
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

public class TagModel {
    public string? TagValue { get; set; }
}

public enum TriggerType {
    HTTP,
    Queue,
    EventHub,
}

public class UnregisterFunctionRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
}

public class ValueToDateModel {
    public string? Currency { get; set; }
    public UInt32 TotalValue { get; set; }
    public string? TotalValueAsDecimal { get; set; }
}

