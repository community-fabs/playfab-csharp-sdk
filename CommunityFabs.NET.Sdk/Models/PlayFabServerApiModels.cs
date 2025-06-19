namespace CommunityFabs.NET.Sdk.Models.Server;

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

public class AddCharacterVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string VirtualCurrency { get; set; }
}

public class AddFriendRequest : PlayFabRequestCommon {
    public string? FriendEmail { get; set; }
    public string? FriendPlayFabId { get; set; }
    public string? FriendTitleDisplayName { get; set; }
    public string? FriendUsername { get; set; }
    public required string PlayFabId { get; set; }
}

public class AddGenericIDRequest : PlayFabRequestCommon {
    public required GenericServiceId GenericId { get; set; }
    public required string PlayFabId { get; set; }
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

public class AddSharedGroupMembersRequest : PlayFabRequestCommon {
    public required List<string> PlayFabIds { get; set; }
    public required string SharedGroupId { get; set; }
}

public class AddSharedGroupMembersResult : PlayFabResultCommon {
}

public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string VirtualCurrency { get; set; }
}

public class AdvancedPushPlatformMsg {
    public bool? GCMDataOnly { get; set; }
    public required string Json { get; set; }
    public PushNotificationPlatform Platform { get; set; }
}

/// <summary>
/// Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class AuthenticateSessionTicketRequest : PlayFabRequestCommon {
    public required string SessionTicket { get; set; }
}

public class AuthenticateSessionTicketResult : PlayFabResultCommon {
    public bool? IsSessionTicketExpired { get; set; }
    public UserAccountInfo? UserInfo { get; set; }
}

public class AwardSteamAchievementItem {
    public required string AchievementName { get; set; }
    public required string PlayFabId { get; set; }
    public bool Result { get; set; }
}

public class AwardSteamAchievementRequest : PlayFabRequestCommon {
    public required List<AwardSteamAchievementItem> Achievements { get; set; }
}

public class AwardSteamAchievementResult : PlayFabResultCommon {
    public List<AwardSteamAchievementItem>? AchievementResults { get; set; }
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

public class BattleNetAccountPlayFabIdPair {
    public string? BattleNetAccountId { get; set; }
    public string? PlayFabId { get; set; }
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

public class CharacterInventory {
    public string? CharacterId { get; set; }
    public List<ItemInstance>? Inventory { get; set; }
}

public class CharacterLeaderboardEntry {
    public string? CharacterId { get; set; }
    public string? CharacterName { get; set; }
    public string? CharacterType { get; set; }
    public string? DisplayName { get; set; }
    public string? PlayFabId { get; set; }
    public int Position { get; set; }
    public int StatValue { get; set; }
}

public class CharacterResult {
    public string? CharacterId { get; set; }
    public string? CharacterName { get; set; }
    public string? CharacterType { get; set; }
}

public enum ChurnRiskLevel {
    NoData,
    LowRisk,
    MediumRisk,
    HighRisk,
}

public enum CloudScriptRevisionOption {
    Live,
    Latest,
    Specific,
}

public class ConsumeItemRequest : PlayFabRequestCommon {
    public string? CharacterId { get; set; }
    public int ConsumeCount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

public class ConsumeItemResult : PlayFabResultCommon {
    public string? ItemInstanceId { get; set; }
    public int RemainingUses { get; set; }
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
/// If SharedGroupId is specified, the service will attempt to create a group with that identifier, and will return an error if it is already in use. If no SharedGroupId is specified, a random identifier will be assigned.
/// </summary>
public class CreateSharedGroupRequest : PlayFabRequestCommon {
    public string? SharedGroupId { get; set; }
}

public class CreateSharedGroupResult : PlayFabResultCommon {
    public string? SharedGroupId { get; set; }
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

public class CustomPropertyDetails {
    public string? Name { get; set; }
    public object? Value { get; set; }
}

/// <summary>
/// This function will delete the specified character from the list allowed by the user, and will also delete any inventory or VC currently held by that character. It will NOT delete any statistics associated for this character, in order to preserve leaderboard integrity.
/// </summary>
public class DeleteCharacterFromUserRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public bool SaveCharacterInventory { get; set; }
}

public class DeleteCharacterFromUserResult : PlayFabResultCommon {
}

public class DeletedPropertyDetails {
    public string? Name { get; set; }
    public bool WasDeleted { get; set; }
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
/// Deletes all data associated with the player, including statistics, custom data, inventory, purchases, virtual currency balances, characters and shared group memberships. Removes the player from all leaderboards and player search indexes. Does not delete PlayStream event history associated with the player. Does not delete the publisher user account that created the player in the title nor associated data such as username, password, email address, account linkages, or friends list. Note, this API queues the player for deletion and returns immediately. It may take several minutes or more before all player data is fully deleted. Until the player data is fully deleted, attempts to recreate the player with the same user account in the same title will fail with the 'AccountDeleted' error. This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
public class DeletePlayerRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class DeletePlayerResult : PlayFabResultCommon {
}

/// <summary>
/// Represents the request to delete a push notification template.
/// </summary>
public class DeletePushNotificationTemplateRequest : PlayFabRequestCommon {
    public required string PushNotificationTemplateId { get; set; }
}

public class DeletePushNotificationTemplateResult : PlayFabResultCommon {
}

public class DeleteSharedGroupRequest : PlayFabRequestCommon {
    public required string SharedGroupId { get; set; }
}

/// <summary>
/// Note that this action cannot be undone. It will unlink all accounts, reset any statistics and leaderboards, and clear out any stored custom data for the user. This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
[Obsolete("Do not use")]
public class DeleteUsersRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<string> PlayFabIds { get; set; }
}

[Obsolete("Do not use")]
public class DeleteUsersResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class DeregisterGameRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class DeregisterGameResponse : PlayFabResultCommon {
}

public enum EmailVerificationStatus {
    Unverified,
    Pending,
    Confirmed,
}

public class EmptyResponse : PlayFabResultCommon {
}

public class EmptyResult : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class EntityTokenResponse {
    public EntityKey? Entity { get; set; }
    public string? EntityToken { get; set; }
    public DateTime? TokenExpiration { get; set; }
}

public class EvaluateRandomResultTableRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string TableId { get; set; }
}

/// <summary>
/// Note that if the Random Result Table contains no entries, or does not exist for the catalog specified (the Primary catalog if one is not specified), an InvalidDropTable error will be returned.
/// </summary>
public class EvaluateRandomResultTableResult : PlayFabResultCommon {
    public string? ResultItemId { get; set; }
}

public class ExecuteCloudScriptResult : PlayFabResultCommon {
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

public class ExecuteCloudScriptServerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
    public object? FunctionParameter { get; set; }
    public bool? GeneratePlayStreamEvent { get; set; }
    public required string PlayFabId { get; set; }
    public CloudScriptRevisionOption? RevisionSelection { get; set; }
    public int? SpecificRevision { get; set; }
}

public enum ExternalFriendSources {
    None,
    Steam,
    Facebook,
    Xbox,
    Psn,
    All,
}

public class FacebookInstantGamesPlayFabIdPair {
    public string? FacebookInstantGamesId { get; set; }
    public string? PlayFabId { get; set; }
}

public class FacebookPlayFabIdPair {
    public string? FacebookId { get; set; }
    public string? PlayFabId { get; set; }
}

public class FriendInfo {
    public string? CurrentMatchmakerLobbyId { get; set; }
    public UserFacebookInfo? FacebookInfo { get; set; }
    public string? FriendPlayFabId { get; set; }
    public UserGameCenterInfo? GameCenterInfo { get; set; }
    public PlayerProfileModel? Profile { get; set; }
    public UserPsnInfo? PSNInfo { get; set; }
    public UserSteamInfo? SteamInfo { get; set; }
    public List<string>? Tags { get; set; }
    public string? TitleDisplayName { get; set; }
    public string? Username { get; set; }
    public UserXboxInfo? XboxInfo { get; set; }
}

public enum GameInstanceState {
    Open,
    Closed,
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

public class GenericPlayFabIdPair {
    public GenericServiceId? GenericId { get; set; }
    public string? PlayFabId { get; set; }
}

public class GenericServiceId {
    public required string ServiceName { get; set; }
    public required string UserId { get; set; }
}

[Obsolete("Do not use")]
public class GetActionGroupResult {
    public string? Id { get; set; }
    public required string Name { get; set; }
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

/// <summary>
/// Data is stored as JSON key-value pairs. If the Keys parameter is provided, the data object returned will only contain the data specific to the indicated Keys. Otherwise, the full set of custom user data will be returned.
/// </summary>
public class GetCharacterDataRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public UInt32? IfChangedFromDataVersion { get; set; }
    public List<string>? Keys { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetCharacterDataResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    public UInt32 DataVersion { get; set; }
    public string? PlayFabId { get; set; }
}

/// <summary>
/// All items currently in the character inventory will be returned, irrespective of how they were acquired (via purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the user's current inventory, and so will not be not included. Also returns their virtual currency balances.
/// </summary>
public class GetCharacterInventoryRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetCharacterInventoryResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public List<ItemInstance>? Inventory { get; set; }
    public string? PlayFabId { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

public class GetCharacterLeaderboardRequest : PlayFabRequestCommon {
    public string? CharacterType { get; set; }
    public int MaxResultsCount { get; set; }
    public int StartPosition { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note that the Position of the character in the results is for the overall leaderboard.
/// </summary>
public class GetCharacterLeaderboardResult : PlayFabResultCommon {
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

/// <summary>
/// Character statistics are similar to user statistics in that they are numeric values which may only be updated by a server operation, in order to minimize the opportunity for unauthorized changes. In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetCharacterStatisticsRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetCharacterStatisticsResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public Dictionary<string, int>? CharacterStatistics { get; set; }
    public string? PlayFabId { get; set; }
}

public class GetContentDownloadUrlRequest : PlayFabRequestCommon {
    public string? HttpMethod { get; set; }
    public required string Key { get; set; }
    public bool? ThruCDN { get; set; }
}

public class GetContentDownloadUrlResult : PlayFabResultCommon {
    public string? URL { get; set; }
}

public class GetFriendLeaderboardRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public bool? IncludeFacebookFriends { get; set; }
    public bool? IncludeSteamFriends { get; set; }
    public int MaxResultsCount { get; set; }
    public required string PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public int StartPosition { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
    public string? XboxToken { get; set; }
}

public class GetFriendsListRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public bool? IncludeFacebookFriends { get; set; }
    public bool? IncludeSteamFriends { get; set; }
    public required string PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public string? XboxToken { get; set; }
}

/// <summary>
/// If any additional services are queried for the user's friends, those friends who also have a PlayFab account registered for the title will be returned in the results. For Facebook, user has to have logged into the title's Facebook app recently, and only friends who also plays this game will be included. For Xbox Live, user has to have logged into the Xbox Live recently, and only friends who also play this game will be included.
/// </summary>
public class GetFriendsListResult : PlayFabResultCommon {
    public List<FriendInfo>? Friends { get; set; }
}

public class GetLeaderboardAroundCharacterRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public string? CharacterType { get; set; }
    public int MaxResultsCount { get; set; }
    public required string PlayFabId { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the character defaults to 0 when the character does not have the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundCharacterResult : PlayFabResultCommon {
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

public class GetLeaderboardAroundUserRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int MaxResultsCount { get; set; }
    public required string PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundUserResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetLeaderboardForUsersCharactersRequest : PlayFabRequestCommon {
    public int? MaxResultsCount { get; set; }
    public required string PlayFabId { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// NOTE: The position of the character in the results is relative to the other characters for that specific user. This mean the values will always be between 0 and one less than the number of characters returned regardless of the size of the actual leaderboard.
/// </summary>
public class GetLeaderboardForUsersCharactersResult : PlayFabResultCommon {
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

public class GetLeaderboardRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int MaxResultsCount { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public int StartPosition { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
}

/// <summary>
/// Note that the Position of the user in the results is for the overall leaderboard.
/// </summary>
public class GetLeaderboardResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetPlayerCombinedInfoRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required GetPlayerCombinedInfoRequestParams InfoRequestParameters { get; set; }
    public required string PlayFabId { get; set; }
}

public class GetPlayerCombinedInfoRequestParams {
    public bool GetCharacterInventories { get; set; }
    public bool GetCharacterList { get; set; }
    public bool GetPlayerProfile { get; set; }
    public bool GetPlayerStatistics { get; set; }
    public bool GetTitleData { get; set; }
    public bool GetUserAccountInfo { get; set; }
    public bool GetUserData { get; set; }
    public bool GetUserInventory { get; set; }
    public bool GetUserReadOnlyData { get; set; }
    public bool GetUserVirtualCurrency { get; set; }
    public List<string>? PlayerStatisticNames { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public List<string>? TitleDataKeys { get; set; }
    public List<string>? UserDataKeys { get; set; }
    public List<string>? UserReadOnlyDataKeys { get; set; }
}

public class GetPlayerCombinedInfoResult : PlayFabResultCommon {
    public GetPlayerCombinedInfoResultPayload? InfoResultPayload { get; set; }
    public string? PlayFabId { get; set; }
}

public class GetPlayerCombinedInfoResultPayload {
    public UserAccountInfo? AccountInfo { get; set; }
    public List<CharacterInventory>? CharacterInventories { get; set; }
    public List<CharacterResult>? CharacterList { get; set; }
    public PlayerProfileModel? PlayerProfile { get; set; }
    public List<StatisticValue>? PlayerStatistics { get; set; }
    public Dictionary<string, string>? TitleData { get; set; }
    public Dictionary<string, UserDataRecord>? UserData { get; set; }
    public UInt32 UserDataVersion { get; set; }
    public List<ItemInstance>? UserInventory { get; set; }
    public Dictionary<string, UserDataRecord>? UserReadOnlyData { get; set; }
    public UInt32 UserReadOnlyDataVersion { get; set; }
    public Dictionary<string, int>? UserVirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? UserVirtualCurrencyRechargeTimes { get; set; }
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

public class GetPlayerStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public List<string>? StatisticNames { get; set; }
    public List<StatisticNameVersion>? StatisticNameVersions { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetPlayerStatisticsResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public List<StatisticValue>? Statistics { get; set; }
}

public class GetPlayerStatisticVersionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? StatisticName { get; set; }
}

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

public class GetPlayFabIDsFromBattleNetAccountIdsRequest : PlayFabRequestCommon {
    public required List<string> BattleNetAccountIds { get; set; }
}

/// <summary>
/// For Battle.net account identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromBattleNetAccountIdsResult : PlayFabResultCommon {
    public List<BattleNetAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromFacebookIDsRequest : PlayFabRequestCommon {
    public required List<string> FacebookIDs { get; set; }
}

/// <summary>
/// For Facebook identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromFacebookIDsResult : PlayFabResultCommon {
    public List<FacebookPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromFacebookInstantGamesIdsRequest : PlayFabRequestCommon {
    public required List<string> FacebookInstantGamesIds { get; set; }
}

/// <summary>
/// For Facebook Instant Games identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromFacebookInstantGamesIdsResult : PlayFabResultCommon {
    public List<FacebookInstantGamesPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGenericIDsRequest : PlayFabRequestCommon {
    public required List<GenericServiceId> GenericIDs { get; set; }
}

/// <summary>
/// For generic service identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGenericIDsResult : PlayFabResultCommon {
    public List<GenericPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromNintendoServiceAccountIdsRequest : PlayFabRequestCommon {
    public required List<string> NintendoAccountIds { get; set; }
}

/// <summary>
/// For Nintendo Service Account identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromNintendoServiceAccountIdsResult : PlayFabResultCommon {
    public List<NintendoServiceAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest : PlayFabRequestCommon {
    public required List<string> NintendoSwitchDeviceIds { get; set; }
}

/// <summary>
/// For Nintendo Switch Device identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromNintendoSwitchDeviceIdsResult : PlayFabResultCommon {
    public List<NintendoSwitchPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromPSNAccountIDsRequest : PlayFabRequestCommon {
    public int? IssuerId { get; set; }
    public required List<string> PSNAccountIDs { get; set; }
}

/// <summary>
/// For PlayStation :tm: Network identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromPSNAccountIDsResult : PlayFabResultCommon {
    public List<PSNAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromPSNOnlineIDsRequest : PlayFabRequestCommon {
    public int? IssuerId { get; set; }
    public required List<string> PSNOnlineIDs { get; set; }
}

/// <summary>
/// For PlayStation :tm: Network identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromPSNOnlineIDsResult : PlayFabResultCommon {
    public List<PSNOnlinePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromSteamIDsRequest : PlayFabRequestCommon {
    public List<uint64>? SteamIDs { get; set; }
    public List<string>? SteamStringIDs { get; set; }
}

/// <summary>
/// For Steam identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromSteamIDsResult : PlayFabResultCommon {
    public List<SteamPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromSteamNamesRequest : PlayFabRequestCommon {
    public required List<string> SteamNames { get; set; }
}

/// <summary>
/// For Steam identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromSteamNamesResult : PlayFabResultCommon {
    public List<SteamNamePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromTwitchIDsRequest : PlayFabRequestCommon {
    public required List<string> TwitchIds { get; set; }
}

/// <summary>
/// For Twitch identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromTwitchIDsResult : PlayFabResultCommon {
    public List<TwitchPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromXboxLiveIDsRequest : PlayFabRequestCommon {
    public string? Sandbox { get; set; }
    public required List<string> XboxLiveAccountIDs { get; set; }
}

/// <summary>
/// For XboxLive identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromXboxLiveIDsResult : PlayFabResultCommon {
    public List<XboxLiveAccountPlayFabIdPair>? Data { get; set; }
}

/// <summary>
/// This API is designed to return publisher-specific values which can be read, but not written to, by the client. This data is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only titles assigned to a publisher can use this API. For more information email helloplayfab@microsoft.com. Note that there may up to a minute delay in between updating title data and this API call returning the newest value.
/// </summary>
public class GetPublisherDataRequest : PlayFabRequestCommon {
    public required List<string> Keys { get; set; }
}

public class GetPublisherDataResult : PlayFabResultCommon {
    public Dictionary<string, string>? Data { get; set; }
}

public class GetRandomResultTablesRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required List<string> TableIDs { get; set; }
}

/// <summary>
/// Note that if a specified Random Result Table contains no entries, or does not exist in the catalog, an InvalidDropTable error will be returned.
/// </summary>
public class GetRandomResultTablesResult : PlayFabResultCommon {
    public Dictionary<string, RandomResultTableListing>? Tables { get; set; }
}

public class GetSegmentResult {
    public string? ABTestParent { get; set; }
    public required string Id { get; set; }
    public string? Name { get; set; }
}

public class GetServerCustomIDsFromPlayFabIDsRequest : PlayFabRequestCommon {
    public required List<string> PlayFabIDs { get; set; }
}

/// <summary>
/// For a PlayFab account that isn't associated with a server custom identity, ServerCustomId will be null.
/// </summary>
public class GetServerCustomIDsFromPlayFabIDsResult : PlayFabResultCommon {
    public List<ServerCustomIDPlayFabIDPair>? Data { get; set; }
}

public class GetSharedGroupDataRequest : PlayFabRequestCommon {
    public bool? GetMembers { get; set; }
    public List<string>? Keys { get; set; }
    public required string SharedGroupId { get; set; }
}

public class GetSharedGroupDataResult : PlayFabResultCommon {
    public Dictionary<string, SharedGroupDataRecord>? Data { get; set; }
    public List<string>? Members { get; set; }
}

public class GetStoreItemsResult : PlayFabResultCommon {
    public string? CatalogVersion { get; set; }
    public StoreMarketingModel? MarketingData { get; set; }
    public SourceType? Source { get; set; }
    public List<StoreItem>? Store { get; set; }
    public string? StoreId { get; set; }
}

/// <summary>
/// A store contains an array of references to items defined in one or more catalog versions of the game, along with the prices for the item, in both real world and virtual currencies. These prices act as an override to any prices defined in the catalog. In this way, the base definitions of the items may be defined in the catalog, with all associated properties, while the pricing can be set for each store, as needed. This allows for subsets of goods to be defined for different purposes (in order to simplify showing some, but not all catalog items to users, based upon different characteristics), along with unique prices. Note that all prices defined in the catalog and store definitions for the item are considered valid, and that a compromised client can be made to send a request for an item based upon any of these definitions. If no price is specified in the store for an item, the price set in the catalog should be displayed to the user.
/// </summary>
public class GetStoreItemsServerRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? PlayFabId { get; set; }
    public required string StoreId { get; set; }
}

/// <summary>
/// This query retrieves the current time from one of the servers in PlayFab. Please note that due to clock drift between servers, there is a potential variance of up to 5 seconds.
/// </summary>
public class GetTimeRequest : PlayFabRequestCommon {
}

/// <summary>
/// Time is always returned as Coordinated Universal Time (UTC).
/// </summary>
public class GetTimeResult : PlayFabResultCommon {
    public required DateTime Time { get; set; }
}

/// <summary>
/// This API is designed to return title specific values which can be read, but not written to, by the client. For example, a developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths, movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new build. If an override label is specified in the request, the overrides are applied automatically and returned with the title data. Note that there may up to a minute delay in between updating title data and this API call returning the newest value.
/// </summary>
public class GetTitleDataRequest : PlayFabRequestCommon {
    public List<string>? Keys { get; set; }
    public string? OverrideLabel { get; set; }
}

public class GetTitleDataResult : PlayFabResultCommon {
    public Dictionary<string, string>? Data { get; set; }
}

public class GetTitleNewsRequest : PlayFabRequestCommon {
    public int? Count { get; set; }
}

public class GetTitleNewsResult : PlayFabResultCommon {
    public List<TitleNewsItem>? News { get; set; }
}

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class GetUserAccountInfoRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class GetUserAccountInfoResult : PlayFabResultCommon {
    public UserAccountInfo? UserInfo { get; set; }
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
/// All items currently in the user inventory will be returned, irrespective of how they were acquired (via purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the user's current inventory, and so will not be not included.
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

[Obsolete("Do not use")]
public class GetUserStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// User statistics are numeric values which may only be updated by a server operation, in order to minimize the opportunity for unauthorized changes. In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class GetUserStatisticsResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public Dictionary<string, int>? UserStatistics { get; set; }
}

/// <summary>
/// Grants a character to the user of the type and name specified in the request.
/// </summary>
public class GrantCharacterToUserRequest : PlayFabRequestCommon {
    public required string CharacterName { get; set; }
    public required string CharacterType { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class GrantCharacterToUserResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
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

/// <summary>
/// This function directly adds inventory items to the character's inventories. As a result of this operations, the user will not be charged any transaction fee, regardless of the inventory item catalog definition. Please note that the processing time for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase operation.
/// </summary>
public class GrantItemsToCharacterRequest : PlayFabRequestCommon {
    public string? Annotation { get; set; }
    public string? CatalogVersion { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? ItemIds { get; set; }
    public required string PlayFabId { get; set; }
}

public class GrantItemsToCharacterResult : PlayFabResultCommon {
    public List<GrantedItemInstance>? ItemGrantResults { get; set; }
}

/// <summary>
/// This function directly adds inventory items to the user's inventories. As a result of this operations, the user will not be charged any transaction fee, regardless of the inventory item catalog definition. Please note that the processing time for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase operation.
/// </summary>
public class GrantItemsToUserRequest : PlayFabRequestCommon {
    public string? Annotation { get; set; }
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<string> ItemIds { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// Please note that the order of the items in the response may not match the order of items in the request.
/// </summary>
public class GrantItemsToUserResult : PlayFabResultCommon {
    public List<GrantedItemInstance>? ItemGrantResults { get; set; }
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

public class LinkBattleNetAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdentityToken { get; set; }
    public required string PlayFabId { get; set; }
}

public class LinkedPlatformAccountModel {
    public string? Email { get; set; }
    public LoginIdentityProvider? Platform { get; set; }
    public string? PlatformUserId { get; set; }
    public string? Username { get; set; }
}

public class LinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdentityToken { get; set; }
    public required string PlayFabId { get; set; }
}

public class LinkNintendoServiceAccountSubjectRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string PlayFabId { get; set; }
    public required string Subject { get; set; }
}

public class LinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string NintendoSwitchDeviceId { get; set; }
    public required string PlayFabId { get; set; }
}

public class LinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class LinkPSNAccountRequest : PlayFabRequestCommon {
    public required string AuthCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public int? IssuerId { get; set; }
    public required string PlayFabId { get; set; }
    public required string RedirectUri { get; set; }
}

public class LinkPSNAccountResult : PlayFabResultCommon {
}

public class LinkPSNIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public int? IssuerId { get; set; }
    public required string PlayFabId { get; set; }
    public required string PSNUserId { get; set; }
}

public class LinkPSNIdResponse : PlayFabResultCommon {
}

public class LinkServerCustomIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string PlayFabId { get; set; }
    public required string ServerCustomId { get; set; }
}

public class LinkServerCustomIdResult : PlayFabResultCommon {
}

public class LinkSteamIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string PlayFabId { get; set; }
    public required string SteamId { get; set; }
}

public class LinkSteamIdResult : PlayFabResultCommon {
}

public class LinkXboxAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string PlayFabId { get; set; }
    public required string XboxToken { get; set; }
}

public class LinkXboxAccountResult : PlayFabResultCommon {
}

public class ListPlayerCustomPropertiesRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class ListPlayerCustomPropertiesResult : PlayFabResultCommon {
    public string? PlayFabId { get; set; }
    public List<CustomPropertyDetails>? Properties { get; set; }
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Returns a list of every character that currently belongs to a user.
/// </summary>
public class ListUsersCharactersRequest : PlayFabRequestCommon {
    public required string PlayFabId { get; set; }
}

public class ListUsersCharactersResult : PlayFabResultCommon {
    public List<CharacterResult>? Characters { get; set; }
}

/// <summary>
/// Contains the localized push notification content.
/// </summary>
public class LocalizedPushNotificationProperties {
    public string? Message { get; set; }
    public string? Subject { get; set; }
}

public class LocationModel {
    public string? City { get; set; }
    public ContinentCode? ContinentCode { get; set; }
    public CountryCode? CountryCode { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}

/// <summary>
/// This API is designed to track analytics events. Events logged using this API will be stored in the title's Redshift database. Each unique eventName will create a distinct table within the database. Within that table, a column will be created for every unique key. Using a first-person shooter as an example, the title may need to track headshots as a distinct event. The sample request below demonstrates an example of this. In addition to the values sent, timestamps and User IDs are automatically added as 'ts' and 'user_id' to each table. The 'Headshot' table in this example would then have the schema: 'user_id'|'ts'|'victim'|'gun'|'x_coord'|'y_coord'|'z_coord'|'damage|aim_assist' and the row corresponding to this event would look like: 'EF987654ABAB012'|'2014-1-1 12:12:12'|'B76543AEAE65'|'big_bad_sniper'|10|20|1|1000|1.The PlayFab service automatically creates events for all login and purchase operations. This API is intended for game specific events only. Please note that event logging is not enabled for titles by default. If you need event logging enabled, please contact us at helloplayfab@microsoft.com for more information.
/// </summary>
[Obsolete("Do not use")]
public class LogEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public string? EntityId { get; set; }
    public string? EntityType { get; set; }
    public string? EventName { get; set; }
    public string? PlayFabId { get; set; }
    public bool ProfileSetEvent { get; set; }
    public DateTime? Timestamp { get; set; }
}

[Obsolete("Do not use")]
public class LogEventResult : PlayFabResultCommon {
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

/// <summary>
/// On Android devices, the recommendation is to use the Settings.Secure.ANDROID_ID as the AndroidDeviceId, as described in this blog post (http://android-developers.blogspot.com/2011/03/identifying-app-installations.html). More information on this identifier can be found in the Android documentation (http://developer.android.com/reference/android/provider/Settings.Secure.html). If this is the first time a user has signed in with the Android device and CreateAccount is set to true, a new PlayFab account will be created and linked to the Android device ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Android device, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. Please note that while multiple devices of this type can be linked to a single user account, only the one most recently used to login (or most recently linked) will be reflected in the user's account information. We will be updating to show all linked devices in a future release.
/// </summary>
public class LoginWithAndroidDeviceIDRequest : PlayFabRequestCommon {
    public string? AndroidDevice { get; set; }
    public required string AndroidDeviceId { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public string? OS { get; set; }
}

public class LoginWithBattleNetRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string IdentityToken { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
}

/// <summary>
/// It is highly recommended that developers ensure that it is extremely unlikely that a customer could generate an ID which is already in use by another customer. If this is the first time a user has signed in with the Custom ID and CreateAccount is set to true, a new PlayFab account will be created and linked to the Custom ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Custom ID, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithCustomIDRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public required string CustomId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
}

/// <summary>
/// On iOS devices, the identifierForVendor (https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDevice_Class/index.html#//apple_ref/occ/instp/UIDevice/identifierForVendor) must be used as the DeviceId, as the UIDevice uniqueIdentifier has been deprecated as of iOS 5, and use of the advertisingIdentifier for this purpose will result in failure of Apple's certification process. If this is the first time a user has signed in with the iOS device and CreateAccount is set to true, a new PlayFab account will be created and linked to the vendor-specific iOS device ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the iOS device, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithIOSDeviceIDRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string DeviceId { get; set; }
    public string? DeviceModel { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public string? OS { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the PlayStation :tm: Network account and CreateAccount is set to true, a new PlayFab account will be created and linked to the PlayStation :tm: Network account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the PlayStation :tm: Network account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithPSNRequest : PlayFabRequestCommon {
    public required string AuthCode { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public int? IssuerId { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string RedirectUri { get; set; }
}

public class LoginWithServerCustomIdRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string ServerCustomId { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the Steam ID and CreateAccount is set to true, a new PlayFab account will be created and linked to the Steam account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Steam account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. Steam users that are not logged into the Steam Client app will only have their Steam username synced, other data, such as currency and country will not be available until they login while the Client is open.
/// </summary>
public class LoginWithSteamIdRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string SteamId { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the Xbox ID and CreateAccount is set to true, a new PlayFab account will be created and linked to the Xbox Live account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Xbox Live account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithXboxIdRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string Sandbox { get; set; }
    public required string XboxId { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the Xbox Live account and CreateAccount is set to true, a new PlayFab account will be created and linked to the Xbox Live account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Xbox Live account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithXboxRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string XboxToken { get; set; }
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

public class ModifyCharacterVirtualCurrencyResult : PlayFabResultCommon {
    public int Balance { get; set; }
    public string? VirtualCurrency { get; set; }
}

/// <summary>
/// This function can both add and remove uses of an inventory item. If the number of uses drops below zero, the item will be removed from active inventory.
/// </summary>
public class ModifyItemUsesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
    public int UsesToAdd { get; set; }
}

public class ModifyItemUsesResult : PlayFabResultCommon {
    public string? ItemInstanceId { get; set; }
    public int RemainingUses { get; set; }
}

public class ModifyUserVirtualCurrencyResult : PlayFabResultCommon {
    public int Balance { get; set; }
    public int BalanceChange { get; set; }
    public string? PlayFabId { get; set; }
    public string? VirtualCurrency { get; set; }
}

/// <summary>
/// Transfers an item from a character to another character that is owned by the same user. This will remove the item from the character's inventory (until and unless it is moved back), and will enable the other character to make use of the item instead.
/// </summary>
public class MoveItemToCharacterFromCharacterRequest : PlayFabRequestCommon {
    public required string GivingCharacterId { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
    public required string ReceivingCharacterId { get; set; }
}

public class MoveItemToCharacterFromCharacterResult : PlayFabResultCommon {
}

/// <summary>
/// Transfers an item from a user to a character she owns. This will remove the item from the user's inventory (until and unless it is moved back), and will enable the character to make use of the item instead.
/// </summary>
public class MoveItemToCharacterFromUserRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

public class MoveItemToCharacterFromUserResult : PlayFabResultCommon {
}

/// <summary>
/// Transfers an item from a character to the owning user. This will remove the item from the character's inventory (until and unless it is moved back), and will enable the user to make use of the item instead.
/// </summary>
public class MoveItemToUserFromCharacterRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public required string ItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

public class MoveItemToUserFromCharacterResult : PlayFabResultCommon {
}

public class NintendoServiceAccountPlayFabIdPair {
    public string? NintendoServiceAccountId { get; set; }
    public string? PlayFabId { get; set; }
}

public class NintendoSwitchPlayFabIdPair {
    public string? NintendoSwitchDeviceId { get; set; }
    public string? PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class NotifyMatchmakerPlayerLeftRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class NotifyMatchmakerPlayerLeftResult : PlayFabResultCommon {
    public PlayerConnectionState? PlayerState { get; set; }
}

public enum PlayerConnectionState {
    Unassigned,
    Connecting,
    Participating,
    Participated,
}

public class PlayerLeaderboardEntry {
    public string? DisplayName { get; set; }
    public string? PlayFabId { get; set; }
    public int Position { get; set; }
    public PlayerProfileModel? Profile { get; set; }
    public int StatValue { get; set; }
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

public class PlayerStatisticVersion {
    public required DateTime ActivationTime { get; set; }
    public DateTime? DeactivationTime { get; set; }
    public DateTime? ScheduledActivationTime { get; set; }
    public DateTime? ScheduledDeactivationTime { get; set; }
    public string? StatisticName { get; set; }
    public UInt32 Version { get; set; }
}

public class PSNAccountPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? PSNAccountId { get; set; }
}

public class PSNOnlinePlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? PSNOnlineId { get; set; }
}

public class PushNotificationPackage {
    public int Badge { get; set; }
    public string? CustomData { get; set; }
    public string? Icon { get; set; }
    public required string Message { get; set; }
    public string? ScheduleDate { get; set; }
    public string? Sound { get; set; }
    public required string Title { get; set; }
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

public class RandomResultTableListing {
    public string? CatalogVersion { get; set; }
    public required List<ResultTableNode> Nodes { get; set; }
    public required string TableId { get; set; }
}

/// <summary>
/// Coupon codes can be created for any item, or set of items, in the catalog for the title. This operation causes the coupon to be consumed, and the specific items to be awarded to the user. Attempting to re-use an already consumed code, or a code which has not yet been created in the service, will result in an error.
/// </summary>
public class RedeemCouponRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public required string CouponCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class RedeemCouponResult : PlayFabResultCommon {
    public List<ItemInstance>? GrantedItems { get; set; }
}

/// <summary>
/// This function is used by a Game Server Instance to validate with the PlayFab service that a user has been registered as connected to the server. The Ticket is provided to the client either as a result of a call to StartGame or Matchmake, each of which return a Ticket specific to the Game Server Instance. This function will fail in any case where the Ticket presented is not valid for the specific Game Server Instance making the call. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
[Obsolete("Do not use")]
public class RedeemMatchmakerTicketRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public required string Ticket { get; set; }
}

[Obsolete("Do not use")]
public class RedeemMatchmakerTicketResult : PlayFabResultCommon {
    public string? Error { get; set; }
    public bool TicketIsValid { get; set; }
    public UserAccountInfo? UserInfo { get; set; }
}

[Obsolete("Do not use")]
public class RefreshGameServerInstanceHeartbeatRequest : PlayFabRequestCommon {
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class RefreshGameServerInstanceHeartbeatResult : PlayFabResultCommon {
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

[Obsolete("Do not use")]
public class RegisterGameRequest : PlayFabRequestCommon {
    public required string Build { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string GameMode { get; set; }
    public string? LobbyId { get; set; }
    public Region Region { get; set; }
    public string? ServerHost { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public required string ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
    public Dictionary<string, string>? Tags { get; set; }
}

[Obsolete("Do not use")]
public class RegisterGameResponse : PlayFabResultCommon {
    public string? LobbyId { get; set; }
}

public class RemoveFriendRequest : PlayFabRequestCommon {
    public required string FriendPlayFabId { get; set; }
    public required string PlayFabId { get; set; }
}

public class RemoveGenericIDRequest : PlayFabRequestCommon {
    public required GenericServiceId GenericId { get; set; }
    public required string PlayFabId { get; set; }
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

public class RemoveSharedGroupMembersRequest : PlayFabRequestCommon {
    public required List<string> PlayFabIds { get; set; }
    public required string SharedGroupId { get; set; }
}

public class RemoveSharedGroupMembersResult : PlayFabResultCommon {
}

public class ReportPlayerServerRequest : PlayFabRequestCommon {
    public string? Comment { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ReporteeId { get; set; }
    public required string ReporterId { get; set; }
}

/// <summary>
/// Players are currently limited to five reports per day. Attempts by a single user account to submit reports beyond five will result in Updated being returned as false.
/// </summary>
public class ReportPlayerServerResult : PlayFabResultCommon {
    public int SubmissionsRemaining { get; set; }
    public bool? Updated { get; set; }
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
/// Represents the save push notification template request.
/// </summary>
public class SavePushNotificationTemplateRequest : PlayFabRequestCommon {
    public string? AndroidPayload { get; set; }
    public string? Id { get; set; }
    public string? IOSPayload { get; set; }
    public Dictionary<string, LocalizedPushNotificationProperties>? LocalizedPushNotificationTemplates { get; set; }
    public required string Name { get; set; }
}

/// <summary>
/// Represents the save push notification template result.
/// </summary>
public class SavePushNotificationTemplateResult : PlayFabResultCommon {
    public string? PushNotificationTemplateId { get; set; }
}

public class ScriptExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

/// <summary>
/// PlayFab accounts which have valid email address or username will be able to receive a password reset email using this API.The email sent must be an account recovery email template. The username or email can be passed in to send the email
/// </summary>
public class SendCustomAccountRecoveryEmailRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Email { get; set; }
    public required string EmailTemplateId { get; set; }
    public string? Username { get; set; }
}

public class SendCustomAccountRecoveryEmailResult : PlayFabResultCommon {
}

/// <summary>
/// Sends an email for only players that have contact emails associated with them. Takes in an email template ID specifyingthe email template to send.
/// </summary>
public class SendEmailFromTemplateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EmailTemplateId { get; set; }
    public required string PlayFabId { get; set; }
}

public class SendEmailFromTemplateResult : PlayFabResultCommon {
}

/// <summary>
/// Represents the request for sending a push notification template to a recipient.
/// </summary>
public class SendPushNotificationFromTemplateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PushNotificationTemplateId { get; set; }
    public required string Recipient { get; set; }
}

public class SendPushNotificationRequest : PlayFabRequestCommon {
    public List<AdvancedPushPlatformMsg>? AdvancedPlatformDelivery { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Message { get; set; }
    public PushNotificationPackage? Package { get; set; }
    public required string Recipient { get; set; }
    public string? Subject { get; set; }
    public List<PushNotificationPlatform>? TargetPlatforms { get; set; }
}

public class SendPushNotificationResult : PlayFabResultCommon {
}

public class ServerCustomIDPlayFabIDPair {
    public string? PlayFabId { get; set; }
    public string? ServerCustomId { get; set; }
}

public class ServerLoginResult : PlayFabResultCommon {
    public EntityTokenResponse? EntityToken { get; set; }
    public GetPlayerCombinedInfoResultPayload? InfoResultPayload { get; set; }
    public DateTime? LastLoginTime { get; set; }
    public bool NewlyCreated { get; set; }
    public string? PlayFabId { get; set; }
    public string? SessionTicket { get; set; }
    public UserSettings? SettingsForUser { get; set; }
    public TreatmentAssignment? TreatmentAssignment { get; set; }
}

/// <summary>
/// This operation is not additive. It will completely replace the tag list for the specified user. Please note that only users in the PlayFab friends list can be assigned tags. Attempting to set a tag on a friend only included in the friends list from a social site integration (such as Facebook or Steam) will return the AccountNotFound error.
/// </summary>
public class SetFriendTagsRequest : PlayFabRequestCommon {
    public required string FriendPlayFabId { get; set; }
    public required string PlayFabId { get; set; }
    public required List<string> Tags { get; set; }
}

[Obsolete("Do not use")]
public class SetGameServerInstanceDataRequest : PlayFabRequestCommon {
    public required string GameServerData { get; set; }
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class SetGameServerInstanceDataResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class SetGameServerInstanceStateRequest : PlayFabRequestCommon {
    public required string LobbyId { get; set; }
    public GameInstanceState State { get; set; }
}

[Obsolete("Do not use")]
public class SetGameServerInstanceStateResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class SetGameServerInstanceTagsRequest : PlayFabRequestCommon {
    public required string LobbyId { get; set; }
    public required Dictionary<string, string> Tags { get; set; }
}

[Obsolete("Do not use")]
public class SetGameServerInstanceTagsResult : PlayFabResultCommon {
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
/// This API is designed to store title specific values which can be read, but not written to, by the client. For example, a developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths, movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new build. This operation is additive. If a Key does not exist in the current dataset, it will be added with the specified Value. If it already exists, the Value for that key will be overwritten with the new Value.
/// </summary>
public class SetTitleDataRequest : PlayFabRequestCommon {
    public required string Key { get; set; }
    public string? Value { get; set; }
}

public class SetTitleDataResult : PlayFabResultCommon {
}

public class SharedGroupDataRecord {
    public required DateTime LastUpdated { get; set; }
    public string? LastUpdatedBy { get; set; }
    public UserDataPermission? Permission { get; set; }
    public string? Value { get; set; }
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

public class StatisticModel {
    public string? Name { get; set; }
    public int Value { get; set; }
    public int Version { get; set; }
}

public class StatisticNameVersion {
    public required string StatisticName { get; set; }
    public UInt32 Version { get; set; }
}

public class StatisticUpdate {
    public required string StatisticName { get; set; }
    public int Value { get; set; }
    public UInt32? Version { get; set; }
}

public class StatisticValue {
    public string? StatisticName { get; set; }
    public int Value { get; set; }
    public UInt32 Version { get; set; }
}

public class SteamNamePlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? SteamName { get; set; }
}

public class SteamPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public uint64? SteamId { get; set; }
    public string? SteamStringId { get; set; }
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

public class SubtractCharacterVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string VirtualCurrency { get; set; }
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

public enum TitleActivationStatus {
    None,
    ActivatedTitleKey,
    PendingSteam,
    ActivatedSteam,
    RevokedSteam,
}

public class TitleNewsItem {
    public string? Body { get; set; }
    public string? NewsId { get; set; }
    public required DateTime Timestamp { get; set; }
    public string? Title { get; set; }
}

public class TreatmentAssignment {
    public List<Variable>? Variables { get; set; }
    public List<string>? Variants { get; set; }
}

public class TwitchPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? TwitchId { get; set; }
}

public class UnlinkBattleNetAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class UnlinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? NintendoSwitchDeviceId { get; set; }
    public required string PlayFabId { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class UnlinkPSNAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class UnlinkPSNAccountResult : PlayFabResultCommon {
}

public class UnlinkServerCustomIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public required string ServerCustomId { get; set; }
}

public class UnlinkServerCustomIdResult : PlayFabResultCommon {
}

public class UnlinkSteamIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class UnlinkSteamIdResult : PlayFabResultCommon {
}

public class UnlinkXboxAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public string? XboxToken { get; set; }
}

public class UnlinkXboxAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Specify the container and optionally the catalogVersion for the container to open
/// </summary>
public class UnlockContainerInstanceRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public required string ContainerItemInstanceId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? KeyItemInstanceId { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// Specify the type of container to open and optionally the catalogVersion for the container to open
/// </summary>
public class UnlockContainerItemRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public required string ContainerItemId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// The items and vc found within the container. These will be added and stacked in your inventory as appropriate.
/// </summary>
public class UnlockContainerItemResult : PlayFabResultCommon {
    public List<ItemInstance>? GrantedItems { get; set; }
    public string? UnlockedItemInstanceId { get; set; }
    public string? UnlockedWithItemInstanceId { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrency { get; set; }
}

public class UpdateAvatarUrlRequest : PlayFabRequestCommon {
    public required string ImageUrl { get; set; }
    public required string PlayFabId { get; set; }
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
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the user. In updating the custom data object, keys which already exist in the object will have their values overwritten, while keys with null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateCharacterDataRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public UserDataPermission? Permission { get; set; }
    public required string PlayFabId { get; set; }
}

public class UpdateCharacterDataResult : PlayFabResultCommon {
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// Character statistics are similar to user statistics in that they are numeric values which may only be updated by a server operation, in order to minimize the opportunity for unauthorized changes. In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class UpdateCharacterStatisticsRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, int>? CharacterStatistics { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
}

public class UpdateCharacterStatisticsResult : PlayFabResultCommon {
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
/// This operation is additive. Statistics not currently defined will be added, while those already defined will be updated with the given values. All other user statistics will remain unchanged.
/// </summary>
public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceUpdate { get; set; }
    public required string PlayFabId { get; set; }
    public required List<StatisticUpdate> Statistics { get; set; }
}

public class UpdatePlayerStatisticsResult : PlayFabResultCommon {
}

public class UpdateProperty {
    public required string Name { get; set; }
    public required object Value { get; set; }
}

/// <summary>
/// Note that in the case of multiple calls to write to the same shared group data keys, the last write received by the PlayFab service will determine the value available to subsequent read operations. For scenarios requiring coordination of data updates, it is recommended that titles make use of user data with read permission set to public, or a combination of user data and shared group data.
/// </summary>
public class UpdateSharedGroupDataRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public UserDataPermission? Permission { get; set; }
    public required string SharedGroupId { get; set; }
}

public class UpdateSharedGroupDataResult : PlayFabResultCommon {
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
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the item instance which belongs to the specified user. In updating the custom data object, keys which already exist in the object will have their values overwritten, while keys with null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserInventoryItemDataRequest : PlayFabRequestCommon {
    public string? CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public required string ItemInstanceId { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public required string PlayFabId { get; set; }
}

/// <summary>
/// This operation is additive. Statistics not currently defined will be added, while those already defined will be updated with the given values. All other user statistics will remain unchanged. Note: For statistics configured to reset on an interval, this API call updates the current (latest) version of the player's statistic. Titles using statistic versioning for resettable leaderboards should make use of the UpdatePlayerStatistics call instead, to ensure that the proper version is updated.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlayFabId { get; set; }
    public Dictionary<string, int>? UserStatistics { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsResult : PlayFabResultCommon {
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

public class UserSettings {
    public bool GatherDeviceInfo { get; set; }
    public bool GatherFocusInfo { get; set; }
    public bool NeedsAttribution { get; set; }
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

public class Variable {
    public required string Name { get; set; }
    public string? Value { get; set; }
}

public class VirtualCurrencyRechargeTime {
    public int RechargeMax { get; set; }
    public required DateTime RechargeTime { get; set; }
    public int SecondsToRecharge { get; set; }
}

public class WriteEventResponse : PlayFabResultCommon {
    public string? EventId { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different event types into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any character-based event. The created event will be locked to the authenticated title. 
/// </summary>
public class WriteServerCharacterEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string PlayFabId { get; set; }
    public DateTime? Timestamp { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different event types into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any player-based event. The created event will be locked to the authenticated title. 
/// </summary>
public class WriteServerPlayerEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public required string PlayFabId { get; set; }
    public DateTime? Timestamp { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different event types into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any title-based event. The created event will be locked to the authenticated title. 
/// </summary>
public class WriteTitleEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public DateTime? Timestamp { get; set; }
}

public class XboxLiveAccountPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? XboxLiveAccountId { get; set; }
}

