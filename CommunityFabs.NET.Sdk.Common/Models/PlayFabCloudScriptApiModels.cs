using CommunityFabs.NET.Sdk.Common.Http;

namespace CommunityFabs.NET.Sdk.Common.Models.CloudScript;

public class AdCampaignAttributionModel {
    /// <summary>
    /// UTC time stamp of attribution
    /// </summary>
    public required DateTime AttributedAt { get; set; }
    /// <summary>
    /// Attribution campaign identifier
    /// </summary>
    public string? CampaignId { get; set; }
    /// <summary>
    /// Attribution network name
    /// </summary>
    public string? Platform { get; set; }
}

public enum CloudScriptRevisionOption {
    Live,
    Latest,
    Specific,
}

public class ContactEmailInfoModel {
    /// <summary>
    /// The email address
    /// </summary>
    public string? EmailAddress { get; set; }
    /// <summary>
    /// The name of the email info data
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The verification status of the email
    /// </summary>
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

public class EmptyResult : PlayFabResultCommon {
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

public class EventHubFunctionModel {
    /// <summary>
    /// The connection string for the event hub.
    /// </summary>
    public string? ConnectionString { get; set; }
    /// <summary>
    /// The name of the event hub that triggers the Azure Function.
    /// </summary>
    public string? EventHubName { get; set; }
    /// <summary>
    /// The name the function was registered under.
    /// </summary>
    public string? FunctionName { get; set; }
}

public class ExecuteCloudScriptResult : PlayFabResultCommon {
    /// <summary>
    /// Number of PlayFab API requests issued by the CloudScript function
    /// </summary>
    public int APIRequestsIssued { get; set; }
    /// <summary>
    /// Information about the error, if any, that occurred during execution
    /// </summary>
    public ScriptExecutionError? Error { get; set; }
    public required double ExecutionTimeSeconds { get; set; }
    /// <summary>
    /// The name of the function that executed
    /// </summary>
    public string? FunctionName { get; set; }
    /// <summary>
    /// The object returned from the CloudScript function, if any
    /// </summary>
    public object? FunctionResult { get; set; }
    /// <summary>
    /// Flag indicating if the FunctionResult was too large and was subsequently dropped from this event. This only occurs if
    /// the total event size is larger than 350KB.
    /// </summary>
    public bool? FunctionResultTooLarge { get; set; }
    /// <summary>
    /// Number of external HTTP requests issued by the CloudScript function
    /// </summary>
    public int HttpRequestsIssued { get; set; }
    /// <summary>
    /// Entries logged during the function execution. These include both entries logged in the function code using log.info()
    /// and log.error() and error entries for API and HTTP request failures.
    /// </summary>
    public List<LogStatement>? Logs { get; set; }
    /// <summary>
    /// Flag indicating if the logs were too large and were subsequently dropped from this event. This only occurs if the total
    /// event size is larger than 350KB after the FunctionResult was removed.
    /// </summary>
    public bool? LogsTooLarge { get; set; }
    public uint MemoryConsumedBytes { get; set; }
    /// <summary>
    /// Processor time consumed while executing the function. This does not include time spent waiting on API calls or HTTP
    /// requests.
    /// </summary>
    public required double ProcessorTimeSeconds { get; set; }
    /// <summary>
    /// The revision of the CloudScript that executed
    /// </summary>
    public int Revision { get; set; }
}

/// <summary>
/// Executes CloudScript with the entity profile that is defined in the request.
/// </summary>
public class ExecuteEntityCloudScriptRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the CloudScript function to execute
    /// </summary>
    public required string FunctionName { get; set; }
    /// <summary>
    /// Object that is passed in to the function as the first argument
    /// </summary>
    public object? FunctionParameter { get; set; }
    /// <summary>
    /// Generate a 'entity_executed_cloudscript' PlayStream event containing the results of the function execution and other
    /// contextual information. This event will show up in the PlayStream debugger console for the player in Game Manager.
    /// </summary>
    public bool? GeneratePlayStreamEvent { get; set; }
    /// <summary>
    /// Option for which revision of the CloudScript to execute. 'Latest' executes the most recently created revision, 'Live'
    /// executes the current live, published revision, and 'Specific' executes the specified revision. The default value is
    /// 'Specific', if the SpecificRevision parameter is specified, otherwise it is 'Live'.
    /// </summary>
    public CloudScriptRevisionOption? RevisionSelection { get; set; }
    /// <summary>
    /// The specific revision to execute, when RevisionSelection is set to 'Specific'
    /// </summary>
    public int? SpecificRevision { get; set; }
}

/// <summary>
/// Executes an Azure Function with the profile of the entity that is defined in the request.
/// </summary>
public class ExecuteFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The name of the CloudScript function to execute
    /// </summary>
    public required string FunctionName { get; set; }
    /// <summary>
    /// Object that is passed in to the function as the FunctionArgument field of the FunctionExecutionContext data structure
    /// </summary>
    public object? FunctionParameter { get; set; }
    /// <summary>
    /// Generate a 'entity_executed_cloudscript_function' PlayStream event containing the results of the function execution and
    /// other contextual information. This event will show up in the PlayStream debugger console for the player in Game Manager.
    /// </summary>
    public bool? GeneratePlayStreamEvent { get; set; }
}

public class ExecuteFunctionResult : PlayFabResultCommon {
    /// <summary>
    /// Error from the CloudScript Azure Function.
    /// </summary>
    public FunctionExecutionError? Error { get; set; }
    /// <summary>
    /// The amount of time the function took to execute
    /// </summary>
    public int ExecutionTimeMilliseconds { get; set; }
    /// <summary>
    /// The name of the function that executed
    /// </summary>
    public string? FunctionName { get; set; }
    /// <summary>
    /// The object returned from the function, if any
    /// </summary>
    public object? FunctionResult { get; set; }
    /// <summary>
    /// Flag indicating if the FunctionResult was too large and was subsequently dropped from this event.
    /// </summary>
    public bool? FunctionResultTooLarge { get; set; }
}

public class FunctionExecutionError {
    /// <summary>
    /// Error code, such as CloudScriptAzureFunctionsExecutionTimeLimitExceeded, CloudScriptAzureFunctionsArgumentSizeExceeded,
    /// CloudScriptAzureFunctionsReturnSizeExceeded or CloudScriptAzureFunctionsHTTPRequestError
    /// </summary>
    public string? Error { get; set; }
    /// <summary>
    /// Details about the error
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Point during the execution of the function at which the error occurred, if any
    /// </summary>
    public string? StackTrace { get; set; }
}

public class FunctionModel {
    /// <summary>
    /// The address of the function.
    /// </summary>
    public string? FunctionAddress { get; set; }
    /// <summary>
    /// The name the function was registered under.
    /// </summary>
    public string? FunctionName { get; set; }
    /// <summary>
    /// The trigger type for the function.
    /// </summary>
    public string? TriggerType { get; set; }
}

public class GetFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the function to register
    /// </summary>
    public required string FunctionName { get; set; }
}

public class GetFunctionResult : PlayFabResultCommon {
    /// <summary>
    /// The connection string for the storage account containing the queue for a queue trigger Azure Function.
    /// </summary>
    public string? ConnectionString { get; set; }
    /// <summary>
    /// The URL to be invoked to execute an HTTP triggered function.
    /// </summary>
    public string? FunctionUrl { get; set; }
    /// <summary>
    /// The name of the queue for a queue trigger Azure Function.
    /// </summary>
    public string? QueueName { get; set; }
    /// <summary>
    /// The trigger type for the function.
    /// </summary>
    public string? TriggerType { get; set; }
}

public class HttpFunctionModel {
    /// <summary>
    /// The name the function was registered under.
    /// </summary>
    public string? FunctionName { get; set; }
    /// <summary>
    /// The URL of the function.
    /// </summary>
    public string? FunctionUrl { get; set; }
}

public class LinkedPlatformAccountModel {
    /// <summary>
    /// Linked account email of the user on the platform, if available
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Authentication platform
    /// </summary>
    public LoginIdentityProvider? Platform { get; set; }
    /// <summary>
    /// Unique account identifier of the user on the platform
    /// </summary>
    public string? PlatformUserId { get; set; }
    /// <summary>
    /// Linked account username of the user on the platform, if available
    /// </summary>
    public string? Username { get; set; }
}

public class ListEventHubFunctionsResult : PlayFabResultCommon {
    /// <summary>
    /// The list of EventHub triggered functions that are currently registered for the title.
    /// </summary>
    public List<EventHubFunctionModel>? Functions { get; set; }
}

/// <summary>
/// A title can have many functions, ListHttpFunctions will return a list of all the currently registered HTTP triggered
/// functions for a given title.
/// </summary>
public class ListFunctionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListFunctionsResult : PlayFabResultCommon {
    /// <summary>
    /// The list of functions that are currently registered for the title.
    /// </summary>
    public List<FunctionModel>? Functions { get; set; }
}

public class ListHttpFunctionsResult : PlayFabResultCommon {
    /// <summary>
    /// The list of HTTP triggered functions that are currently registered for the title.
    /// </summary>
    public List<HttpFunctionModel>? Functions { get; set; }
}

public class ListQueuedFunctionsResult : PlayFabResultCommon {
    /// <summary>
    /// The list of Queue triggered functions that are currently registered for the title.
    /// </summary>
    public List<QueuedFunctionModel>? Functions { get; set; }
}

public class LocationModel {
    /// <summary>
    /// City name.
    /// </summary>
    public string? City { get; set; }
    /// <summary>
    /// The two-character continent code for this location
    /// </summary>
    public ContinentCode? ContinentCode { get; set; }
    /// <summary>
    /// The two-character ISO 3166-1 country code for the country associated with the location
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// Latitude coordinate of the geographic location.
    /// </summary>
    public double? Latitude { get; set; }
    /// <summary>
    /// Longitude coordinate of the geographic location.
    /// </summary>
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
    /// <summary>
    /// Optional object accompanying the message as contextual information
    /// </summary>
    public object? Data { get; set; }
    /// <summary>
    /// 'Debug', 'Info', or 'Error'
    /// </summary>
    public string? Level { get; set; }
    public string? Message { get; set; }
}

public class MembershipModel {
    /// <summary>
    /// Whether this membership is active. That is, whether the MembershipExpiration time has been reached.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// The time this membership expires
    /// </summary>
    public required DateTime MembershipExpiration { get; set; }
    /// <summary>
    /// The id of the membership
    /// </summary>
    public string? MembershipId { get; set; }
    /// <summary>
    /// Membership expirations can be explicitly overridden (via game manager or the admin api). If this membership has been
    /// overridden, this will be the new expiration time.
    /// </summary>
    public DateTime? OverrideExpiration { get; set; }
    /// <summary>
    /// Whether the override expiration is set.
    /// </summary>
    public bool? OverrideIsSet { get; set; }
    /// <summary>
    /// The list of subscriptions that this player has for this membership
    /// </summary>
    public List<SubscriptionModel>? Subscriptions { get; set; }
}

/// <summary>
/// Identifier by either name or ID. Note that a name may change due to renaming, or reused after being deleted. ID is
/// immutable and unique.
/// </summary>
public class NameIdentifier {
    /// <summary>
    /// Id Identifier, if present
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Name Identifier, if present
    /// </summary>
    public string? Name { get; set; }
}

public class PlayerProfileModel {
    /// <summary>
    /// List of advertising campaigns the player has been attributed to
    /// </summary>
    public List<AdCampaignAttributionModel>? AdCampaignAttributions { get; set; }
    /// <summary>
    /// URL of the player's avatar image
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// If the player is currently banned, the UTC Date when the ban expires
    /// </summary>
    public DateTime? BannedUntil { get; set; }
    /// <summary>
    /// List of all contact email info associated with the player account
    /// </summary>
    public List<ContactEmailInfoModel>? ContactEmailAddresses { get; set; }
    /// <summary>
    /// Player record created
    /// </summary>
    public DateTime? Created { get; set; }
    /// <summary>
    /// Player display name
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// List of experiment variants for the player. Note that these variants are not guaranteed to be up-to-date when returned
    /// during login because the player profile is updated only after login. Instead, use the LoginResult.TreatmentAssignment
    /// property during login to get the correct variants and variables.
    /// </summary>
    public List<string>? ExperimentVariants { get; set; }
    /// <summary>
    /// UTC time when the player most recently logged in to the title
    /// </summary>
    public DateTime? LastLogin { get; set; }
    /// <summary>
    /// List of all authentication systems linked to this player account
    /// </summary>
    public List<LinkedPlatformAccountModel>? LinkedAccounts { get; set; }
    /// <summary>
    /// List of geographic locations from which the player has logged in to the title
    /// </summary>
    public List<LocationModel>? Locations { get; set; }
    /// <summary>
    /// List of memberships for the player, along with whether are expired.
    /// </summary>
    public List<MembershipModel>? Memberships { get; set; }
    /// <summary>
    /// Player account origination
    /// </summary>
    public LoginIdentityProvider? Origination { get; set; }
    /// <summary>
    /// PlayFab player account unique identifier
    /// </summary>
    public string? PlayerId { get; set; }
    /// <summary>
    /// Publisher this player belongs to
    /// </summary>
    public string? PublisherId { get; set; }
    /// <summary>
    /// List of configured end points registered for sending the player push notifications
    /// </summary>
    public List<PushNotificationRegistrationModel>? PushNotificationRegistrations { get; set; }
    /// <summary>
    /// List of leaderboard statistic values for the player
    /// </summary>
    public List<StatisticModel>? Statistics { get; set; }
    /// <summary>
    /// List of player's tags for segmentation
    /// </summary>
    public List<TagModel>? Tags { get; set; }
    /// <summary>
    /// Title ID this player profile applies to
    /// </summary>
    public string? TitleId { get; set; }
    /// <summary>
    /// Sum of the player's purchases made with real-money currencies, converted to US dollars equivalent and represented as a
    /// whole number of cents (1/100 USD). For example, 999 indicates nine dollars and ninety-nine cents.
    /// </summary>
    public uint? TotalValueToDateInUSD { get; set; }
    /// <summary>
    /// List of the player's lifetime purchase totals, summed by real-money currency
    /// </summary>
    public List<ValueToDateModel>? ValuesToDate { get; set; }
}

public class PlayStreamEventEnvelopeModel {
    /// <summary>
    /// The ID of the entity the event is about.
    /// </summary>
    public string? EntityId { get; set; }
    /// <summary>
    /// The type of the entity the event is about.
    /// </summary>
    public string? EntityType { get; set; }
    /// <summary>
    /// Data specific to this event.
    /// </summary>
    public string? EventData { get; set; }
    /// <summary>
    /// The name of the event.
    /// </summary>
    public string? EventName { get; set; }
    /// <summary>
    /// The namespace of the event.
    /// </summary>
    public string? EventNamespace { get; set; }
    /// <summary>
    /// Settings for the event.
    /// </summary>
    public string? EventSettings { get; set; }
}

public class PostFunctionResultForEntityTriggeredActionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The result of the function execution.
    /// </summary>
    public required ExecuteFunctionResult FunctionResult { get; set; }
}

public class PostFunctionResultForFunctionExecutionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The result of the function execution.
    /// </summary>
    public required ExecuteFunctionResult FunctionResult { get; set; }
}

public class PostFunctionResultForPlayerTriggeredActionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The result of the function execution.
    /// </summary>
    public required ExecuteFunctionResult FunctionResult { get; set; }
    /// <summary>
    /// The player profile the function was invoked with.
    /// </summary>
    public required PlayerProfileModel PlayerProfile { get; set; }
    /// <summary>
    /// The triggering PlayStream event, if any, that caused the function to be invoked.
    /// </summary>
    public PlayStreamEventEnvelopeModel? PlayStreamEventEnvelope { get; set; }
}

public class PostFunctionResultForScheduledTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The result of the function execution
    /// </summary>
    public required ExecuteFunctionResult FunctionResult { get; set; }
    /// <summary>
    /// The id of the scheduled task that invoked the function.
    /// </summary>
    public required NameIdentifier ScheduledTaskId { get; set; }
}

public enum PushNotificationPlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class PushNotificationRegistrationModel {
    /// <summary>
    /// Notification configured endpoint
    /// </summary>
    public string? NotificationEndpointARN { get; set; }
    /// <summary>
    /// Push notification platform
    /// </summary>
    public PushNotificationPlatform? Platform { get; set; }
}

public class QueuedFunctionModel {
    /// <summary>
    /// The connection string for the Azure Storage Account that hosts the queue.
    /// </summary>
    public string? ConnectionString { get; set; }
    /// <summary>
    /// The name the function was registered under.
    /// </summary>
    public string? FunctionName { get; set; }
    /// <summary>
    /// The name of the queue that triggers the Azure Function.
    /// </summary>
    public string? QueueName { get; set; }
}

/// <summary>
/// A title can have many functions, RegisterEventHubFunction associates a function name with an event hub name and
/// connection string.
/// </summary>
public class RegisterEventHubFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// A connection string for the namespace of the event hub for the Azure Function.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the event hub for the Azure Function.
    /// </summary>
    public required string EventHubName { get; set; }
    /// <summary>
    /// The name of the function to register
    /// </summary>
    public required string FunctionName { get; set; }
}

public class RegisterHttpFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the function to register
    /// </summary>
    public required string FunctionName { get; set; }
    /// <summary>
    /// Full URL for Azure Function that implements the function.
    /// </summary>
    public required string FunctionUrl { get; set; }
}

/// <summary>
/// A title can have many functions, RegisterQueuedFunction associates a function name with a queue name and connection
/// string.
/// </summary>
public class RegisterQueuedFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// A connection string for the storage account that hosts the queue for the Azure Function.
    /// </summary>
    public required string ConnectionString { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the function to register
    /// </summary>
    public required string FunctionName { get; set; }
    /// <summary>
    /// The name of the queue for the Azure Function.
    /// </summary>
    public required string QueueName { get; set; }
}

public class ScriptExecutionError {
    /// <summary>
    /// Error code, such as CloudScriptNotFound, JavascriptException, CloudScriptFunctionArgumentSizeExceeded,
    /// CloudScriptAPIRequestCountExceeded, CloudScriptAPIRequestError, or CloudScriptHTTPRequestError
    /// </summary>
    public string? Error { get; set; }
    /// <summary>
    /// Details about the error
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Point during the execution of the script at which the error occurred, if any
    /// </summary>
    public string? StackTrace { get; set; }
}

public class StatisticModel {
    /// <summary>
    /// Statistic name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Statistic value
    /// </summary>
    public int Value { get; set; }
    /// <summary>
    /// Statistic version (0 if not a versioned statistic)
    /// </summary>
    public int Version { get; set; }
}

public class SubscriptionModel {
    /// <summary>
    /// When this subscription expires.
    /// </summary>
    public required DateTime Expiration { get; set; }
    /// <summary>
    /// The time the subscription was orignially purchased
    /// </summary>
    public required DateTime InitialSubscriptionTime { get; set; }
    /// <summary>
    /// Whether this subscription is currently active. That is, if Expiration > now.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// The status of this subscription, according to the subscription provider.
    /// </summary>
    public SubscriptionProviderStatus? Status { get; set; }
    /// <summary>
    /// The id for this subscription
    /// </summary>
    public string? SubscriptionId { get; set; }
    /// <summary>
    /// The item id for this subscription from the primary catalog
    /// </summary>
    public string? SubscriptionItemId { get; set; }
    /// <summary>
    /// The provider for this subscription. Apple or Google Play are supported today.
    /// </summary>
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
    /// <summary>
    /// Full value of the tag, including namespace
    /// </summary>
    public string? TagValue { get; set; }
}

public enum TriggerType {
    HTTP,
    Queue,
    EventHub,
}

public class UnregisterFunctionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the function to register
    /// </summary>
    public required string FunctionName { get; set; }
}

public class ValueToDateModel {
    /// <summary>
    /// ISO 4217 code of the currency used in the purchases
    /// </summary>
    public string? Currency { get; set; }
    /// <summary>
    /// Total value of the purchases in a whole number of 1/100 monetary units. For example, 999 indicates nine dollars and
    /// ninety-nine cents when Currency is 'USD')
    /// </summary>
    public uint TotalValue { get; set; }
    /// <summary>
    /// Total value of the purchases in a string representation of decimal monetary units. For example, '9.99' indicates nine
    /// dollars and ninety-nine cents when Currency is 'USD'.
    /// </summary>
    public string? TotalValueAsDecimal { get; set; }
}

