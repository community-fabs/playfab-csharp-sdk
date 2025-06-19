namespace CommunityFabs.NET.Sdk.Models.Client;

public class AcceptTradeRequest : PlayFabRequestCommon {
    public List<string>? AcceptedInventoryInstanceIds { get; set; }
    public required string OfferingPlayerId { get; set; }
    public required string TradeId { get; set; }
}

public class AcceptTradeResponse : PlayFabResultCommon {
    public TradeInfo? Trade { get; set; }
}

public enum AdActivity {
    Opened,
    Closed,
    Start,
    End,
}

public class AdCampaignAttributionModel {
    public required DateTime AttributedAt { get; set; }
    public string? CampaignId { get; set; }
    public string? Platform { get; set; }
}

public class AddFriendRequest : PlayFabRequestCommon {
    public string? FriendEmail { get; set; }
    public string? FriendPlayFabId { get; set; }
    public string? FriendTitleDisplayName { get; set; }
    public string? FriendUsername { get; set; }
}

public class AddFriendResult : PlayFabResultCommon {
    public bool Created { get; set; }
}

public class AddGenericIDRequest : PlayFabRequestCommon {
    public required GenericServiceId GenericId { get; set; }
}

public class AddGenericIDResult : PlayFabResultCommon {
}

/// <summary>
/// This API adds a contact email to the player's profile. If the player's profile already contains a contact email, it will update the contact email to the email address specified.
/// </summary>
public class AddOrUpdateContactEmailRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EmailAddress { get; set; }
}

public class AddOrUpdateContactEmailResult : PlayFabResultCommon {
}

public class AddSharedGroupMembersRequest : PlayFabRequestCommon {
    public required List<string> PlayFabIds { get; set; }
    public required string SharedGroupId { get; set; }
}

public class AddSharedGroupMembersResult : PlayFabResultCommon {
}

public class AddUsernamePasswordRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string Username { get; set; }
}

/// <summary>
/// Each account must have a unique username and email address in the PlayFab service. Once created, the account may be associated with additional accounts (Steam, Facebook, Game Center, etc.), allowing for added social network lists and achievements systems. This can also be used to provide a recovery method if the user loses their original means of access.
/// </summary>
public class AddUsernamePasswordResult : PlayFabResultCommon {
    public string? Username { get; set; }
}

/// <summary>
/// This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string VirtualCurrency { get; set; }
}

/// <summary>
/// A single ad placement details including placement and reward information
/// </summary>
public class AdPlacementDetails {
    public string? PlacementId { get; set; }
    public string? PlacementName { get; set; }
    public int? PlacementViewsRemaining { get; set; }
    public double? PlacementViewsResetMinutes { get; set; }
    public string? RewardAssetUrl { get; set; }
    public string? RewardDescription { get; set; }
    public string? RewardId { get; set; }
    public string? RewardName { get; set; }
}

/// <summary>
/// Details for each item granted
/// </summary>
public class AdRewardItemGranted {
    public string? CatalogId { get; set; }
    public string? DisplayName { get; set; }
    public string? InstanceId { get; set; }
    public string? ItemId { get; set; }
}

/// <summary>
/// Details on what was granted to the player
/// </summary>
public class AdRewardResults {
    public List<AdRewardItemGranted>? GrantedItems { get; set; }
    public Dictionary<string, int>? GrantedVirtualCurrencies { get; set; }
    public Dictionary<string, int>? IncrementedStatistics { get; set; }
}

/// <summary>
/// More information can be found on configuring your game for the Google Cloud Messaging service in the Google developer documentation, here: http://developer.android.com/google/gcm/client.html. The steps to configure and send Push Notifications is described in the PlayFab tutorials, here: https://docs.microsoft.com/gaming/playfab/features/engagement/push-notifications/quickstart.
/// </summary>
public class AndroidDevicePushNotificationRegistrationRequest : PlayFabRequestCommon {
    public string? ConfirmationMessage { get; set; }
    public required string DeviceToken { get; set; }
    public bool? SendPushNotificationConfirmation { get; set; }
}

public class AndroidDevicePushNotificationRegistrationResult : PlayFabResultCommon {
}

/// <summary>
/// If you have an ad attribution partner enabled, this will post an install to their service to track the device. It uses the given device id to match based on clicks on ads.
/// </summary>
public class AttributeInstallRequest : PlayFabRequestCommon {
    public string? Adid { get; set; }
    public string? Android_Id { get; set; }
    public string? Idfa { get; set; }
}

public class AttributeInstallResult : PlayFabResultCommon {
}

public class BattleNetAccountPlayFabIdPair {
    public string? BattleNetAccountId { get; set; }
    public string? PlayFabId { get; set; }
}

public class CancelTradeRequest : PlayFabRequestCommon {
    public required string TradeId { get; set; }
}

public class CancelTradeResponse : PlayFabResultCommon {
    public TradeInfo? Trade { get; set; }
}

public class CartItem {
    public string? Description { get; set; }
    public string? DisplayName { get; set; }
    public string? ItemClass { get; set; }
    public string? ItemId { get; set; }
    public string? ItemInstanceId { get; set; }
    public Dictionary<string, UInt32>? RealCurrencyPrices { get; set; }
    public Dictionary<string, UInt32>? VCAmount { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrencyPrices { get; set; }
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

public enum CloudScriptRevisionOption {
    Live,
    Latest,
    Specific,
}

/// <summary>
/// Collection filter to include and/or exclude collections with certain key-value pairs. The filter generates a collection set defined by Includes rules and then remove collections that matches the Excludes rules. A collection is considered matching a rule if the rule describes a subset of the collection. 
/// </summary>
[Obsolete("Do not use")]
public class CollectionFilter {
    public List<Container_Dictionary_String_String>? Excludes { get; set; }
    public List<Container_Dictionary_String_String>? Includes { get; set; }
}

/// <summary>
/// The final step in the purchasing process, this API finalizes the purchase with the payment provider, where applicable, adding virtual goods to the player inventory (including random drop table resolution and recursive addition of bundled items) and adjusting virtual currency balances for funds used or added. Note that this is a pull operation, and should be polled regularly when a purchase is in progress. Please note that the processing time for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase operation.
/// </summary>
public class ConfirmPurchaseRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string OrderId { get; set; }
}

/// <summary>
/// When the FailedByPaymentProvider error is returned, it's important to check the ProviderErrorCode, ProviderErrorMessage, and ProviderErrorDetails to understand the specific reason the payment was rejected, as in some rare cases, this may mean that the provider hasn't completed some operation required to finalize the purchase.
/// </summary>
public class ConfirmPurchaseResult : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
    public string? OrderId { get; set; }
    public required DateTime PurchaseDate { get; set; }
}

public class ConsumeItemRequest : PlayFabRequestCommon {
    public string? CharacterId { get; set; }
    public int ConsumeCount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemInstanceId { get; set; }
}

public class ConsumeItemResult : PlayFabResultCommon {
    public string? ItemInstanceId { get; set; }
    public int RemainingUses { get; set; }
}

public class ConsumeMicrosoftStoreEntitlementsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required MicrosoftStorePayload MarketplaceSpecificData { get; set; }
}

public class ConsumeMicrosoftStoreEntitlementsResponse : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
}

public class ConsumePS5EntitlementsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required PlayStation5Payload MarketplaceSpecificData { get; set; }
}

public class ConsumePS5EntitlementsResult : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
}

public class ConsumePSNEntitlementsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int ServiceLabel { get; set; }
}

public class ConsumePSNEntitlementsResult : PlayFabResultCommon {
    public List<ItemInstance>? ItemsGranted { get; set; }
}

public class ConsumeXboxEntitlementsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string XboxToken { get; set; }
}

public class ConsumeXboxEntitlementsResult : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
}

public class ContactEmailInfoModel {
    public string? EmailAddress { get; set; }
    public string? Name { get; set; }
    public EmailVerificationStatus? VerificationStatus { get; set; }
}

/// <summary>
/// A data container
/// </summary>
[Obsolete("Do not use")]
public class Container_Dictionary_String_String {
    public Dictionary<string, string>? Data { get; set; }
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

[Obsolete("Do not use")]
public class CurrentGamesRequest : PlayFabRequestCommon {
    public string? BuildVersion { get; set; }
    public string? GameMode { get; set; }
    public Region? Region { get; set; }
    public string? StatisticName { get; set; }
    public CollectionFilter? TagFilter { get; set; }
}

[Obsolete("Do not use")]
public class CurrentGamesResult : PlayFabResultCommon {
    public int GameCount { get; set; }
    public List<GameInfo>? Games { get; set; }
    public int PlayerCount { get; set; }
}

public class CustomPropertyDetails {
    public string? Name { get; set; }
    public object? Value { get; set; }
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
    public required List<string> PropertyNames { get; set; }
}

public class DeletePlayerCustomPropertiesResult : PlayFabResultCommon {
    public List<DeletedPropertyDetails>? DeletedProperties { get; set; }
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Any arbitrary information collected by the device
/// </summary>
public class DeviceInfoRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Info { get; set; }
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

public class ExecuteCloudScriptRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FunctionName { get; set; }
    public object? FunctionParameter { get; set; }
    public bool? GeneratePlayStreamEvent { get; set; }
    public CloudScriptRevisionOption? RevisionSelection { get; set; }
    public int? SpecificRevision { get; set; }
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

public class GameCenterPlayFabIdPair {
    public string? GameCenterId { get; set; }
    public string? PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class GameInfo {
    public string? BuildVersion { get; set; }
    public string? GameMode { get; set; }
    public string? GameServerData { get; set; }
    public int? GameServerState { get; set; }
    public GameInstanceState? GameServerStateEnum { get; set; }
    public DateTime? LastHeartbeat { get; set; }
    public string? LobbyID { get; set; }
    public int? MaxPlayers { get; set; }
    public List<string>? PlayerUserIds { get; set; }
    public Region? Region { get; set; }
    public UInt32 RunTime { get; set; }
    public string? ServerHostname { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public int? ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
    public string? StatisticName { get; set; }
    public Dictionary<string, string>? Tags { get; set; }
}

public enum GameInstanceState {
    Open,
    Closed,
}

[Obsolete("Do not use")]
public class GameServerRegionsRequest : PlayFabRequestCommon {
    public required string BuildVersion { get; set; }
    public string? TitleId { get; set; }
}

[Obsolete("Do not use")]
public class GameServerRegionsResult : PlayFabResultCommon {
    public List<RegionInfo>? Regions { get; set; }
}

public class GenericPlayFabIdPair {
    public GenericServiceId? GenericId { get; set; }
    public string? PlayFabId { get; set; }
}

public class GenericServiceId {
    public required string ServiceName { get; set; }
    public required string UserId { get; set; }
}

public class GetAccountInfoRequest : PlayFabRequestCommon {
    public string? Email { get; set; }
    public string? PlayFabId { get; set; }
    public string? TitleDisplayName { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// This API retrieves details regarding the player in the PlayFab service. Note that when this call is used to retrieve data about another player (not the one signed into the local client), some data, such as Personally Identifying Information (PII), will be omitted for privacy reasons or to comply with the requirements of the platform belongs to. The user account returned will be based on the identifier provided in priority order: PlayFabId, Username, Email, then TitleDisplayName. If no identifier is specified, the currently signed in user's information will be returned.
/// </summary>
public class GetAccountInfoResult : PlayFabResultCommon {
    public UserAccountInfo? AccountInfo { get; set; }
}

/// <summary>
/// Using an AppId to return a list of valid ad placements for a player.
/// </summary>
public class GetAdPlacementsRequest : PlayFabRequestCommon {
    public required string AppId { get; set; }
    public NameIdentifier? Identifier { get; set; }
}

/// <summary>
/// Array of AdPlacementDetails
/// </summary>
public class GetAdPlacementsResult : PlayFabResultCommon {
    public List<AdPlacementDetails>? AdPlacements { get; set; }
}

public class GetCatalogItemsRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
}

/// <summary>
/// If CatalogVersion is not specified, only inventory items associated with the most recent version of the catalog will be returned.
/// </summary>
public class GetCatalogItemsResult : PlayFabResultCommon {
    public List<CatalogItem>? Catalog { get; set; }
}

/// <summary>
/// Data is stored as JSON key-value pairs. If the Keys parameter is provided, the data object returned will only contain the data specific to the indicated Keys. Otherwise, the full set of custom character data will be returned.
/// </summary>
public class GetCharacterDataRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public UInt32? IfChangedFromDataVersion { get; set; }
    public List<string>? Keys { get; set; }
    public string? PlayFabId { get; set; }
}

public class GetCharacterDataResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// All items currently in the character inventory will be returned, irrespective of how they were acquired (via purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the user's current inventory, and so will not be not included. Also returns their virtual currency balances.
/// </summary>
public class GetCharacterInventoryRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetCharacterInventoryResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public List<ItemInstance>? Inventory { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

public class GetCharacterLeaderboardRequest : PlayFabRequestCommon {
    public string? CharacterType { get; set; }
    public int? MaxResultsCount { get; set; }
    public int StartPosition { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note that the Position of the character in the results is for the overall leaderboard.
/// </summary>
public class GetCharacterLeaderboardResult : PlayFabResultCommon {
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

public class GetCharacterStatisticsRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetCharacterStatisticsResult : PlayFabResultCommon {
    public Dictionary<string, int>? CharacterStatistics { get; set; }
}

/// <summary>
/// Cloud Scripts in PlayFab have both Versions and Revisions. Each time a new script is uploaded against a Version, this creates a new Revision. If Testing is set to true, the URL returned will be for the Cloud Script Revision which was most recently uploaded. If Testing is set to false, the URL returned will be for the Cloud Script Revision which was most recently deployed to live.
/// </summary>
[Obsolete("Do not use")]
public class GetCloudScriptUrlRequest : PlayFabRequestCommon {
    public bool? Testing { get; set; }
    public int? Version { get; set; }
}

/// <summary>
/// The URL returned is the one which must be used by the title to call into a handler in Cloud Script. PlayFab-supplied SDKs will automatically save the results of this call, for use with any calls to RunCloudScript.
/// </summary>
[Obsolete("Do not use")]
public class GetCloudScriptUrlResult : PlayFabResultCommon {
    public string? Url { get; set; }
}

public class GetContentDownloadUrlRequest : PlayFabRequestCommon {
    public string? HttpMethod { get; set; }
    public required string Key { get; set; }
    public bool? ThruCDN { get; set; }
}

public class GetContentDownloadUrlResult : PlayFabResultCommon {
    public string? URL { get; set; }
}

[Obsolete("Do not use")]
public class GetFriendLeaderboardAroundCurrentUserRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public bool? IncludeFacebookFriends { get; set; }
    public bool? IncludeSteamFriends { get; set; }
    public int? MaxResultsCount { get; set; }
    public required string StatisticName { get; set; }
    public string? XboxToken { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have the corresponding statistic.If Facebook friends are included, make sure the access token from previous LoginWithFacebook call is still valid and not expired. If Xbox Live friends are included, make sure the access token from the previous LoginWithXbox call is still valid and not expired. 
/// </summary>
[Obsolete("Do not use")]
public class GetFriendLeaderboardAroundCurrentUserResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetFriendLeaderboardAroundPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public bool? IncludeFacebookFriends { get; set; }
    public bool? IncludeSteamFriends { get; set; }
    public int? MaxResultsCount { get; set; }
    public string? PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
    public string? XboxToken { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have the corresponding statistic.If Facebook friends are included, make sure the access token from previous LoginWithFacebook call is still valid and not expired. If Xbox Live friends are included, make sure the access token from the previous LoginWithXbox call is still valid and not expired. 
/// </summary>
public class GetFriendLeaderboardAroundPlayerResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetFriendLeaderboardRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    public bool? IncludeFacebookFriends { get; set; }
    public bool? IncludeSteamFriends { get; set; }
    public int? MaxResultsCount { get; set; }
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
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public string? XboxToken { get; set; }
}

/// <summary>
/// If any additional services are queried for the user's friends, those friends who also have a PlayFab account registered for the title will be returned in the results. For Facebook, user has to have logged into the title's Facebook app recently, and only friends who also plays this game will be included. Note: If the user authenticated with AuthenticationToken when calling LoginWithFacebook, instead of AccessToken, an empty list will be returned. For Xbox Live, user has to have logged into the Xbox Live recently, and only friends who also play this game will be included.
/// </summary>
public class GetFriendsListResult : PlayFabResultCommon {
    public List<FriendInfo>? Friends { get; set; }
}

public class GetLeaderboardAroundCharacterRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public string? CharacterType { get; set; }
    public int? MaxResultsCount { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the character defaults to 0 when the character does not have the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundCharacterResult : PlayFabResultCommon {
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

[Obsolete("Do not use")]
public class GetLeaderboardAroundCurrentUserRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? MaxResultsCount { get; set; }
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have the corresponding statistic.
/// </summary>
[Obsolete("Do not use")]
public class GetLeaderboardAroundCurrentUserResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? MaxResultsCount { get; set; }
    public string? PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundPlayerResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetLeaderboardForUsersCharactersRequest : PlayFabRequestCommon {
    public int? MaxResultsCount { get; set; }
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
    public int? MaxResultsCount { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    public int StartPosition { get; set; }
    public required string StatisticName { get; set; }
    public bool? UseSpecificVersion { get; set; }
    public int? Version { get; set; }
}

/// <summary>
/// Note: the user's Position is relative to the overall leaderboard.
/// </summary>
public class GetLeaderboardResult : PlayFabResultCommon {
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    public DateTime? NextReset { get; set; }
    public int Version { get; set; }
}

public class GetPaymentTokenRequest : PlayFabRequestCommon {
    public required string TokenProvider { get; set; }
}

public class GetPaymentTokenResult : PlayFabResultCommon {
    public string? OrderId { get; set; }
    public string? ProviderToken { get; set; }
}

public class GetPhotonAuthenticationTokenRequest : PlayFabRequestCommon {
    public required string PhotonApplicationId { get; set; }
}

public class GetPhotonAuthenticationTokenResult : PlayFabResultCommon {
    public string? PhotonCustomAuthenticationToken { get; set; }
}

public class GetPlayerCombinedInfoRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required GetPlayerCombinedInfoRequestParams InfoRequestParameters { get; set; }
    public string? PlayFabId { get; set; }
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

/// <summary>
/// Returns whatever info is requested in the response for the user. If no user is explicitly requested this defaults to the authenticated user. If the user is the same as the requester, PII (like email address, facebook id) is returned if available. Otherwise, only public information is returned. All parameters default to false.
/// </summary>
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
    public required string PropertyName { get; set; }
}

public class GetPlayerCustomPropertyResult : PlayFabResultCommon {
    public int PropertiesVersion { get; set; }
    public CustomPropertyDetails? Property { get; set; }
}

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class GetPlayerProfileRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? PlayFabId { get; set; }
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
}

public class GetPlayerProfileResult : PlayFabResultCommon {
    public PlayerProfileModel? PlayerProfile { get; set; }
}

public class GetPlayerSegmentsRequest : PlayFabRequestCommon {
}

public class GetPlayerSegmentsResult : PlayFabResultCommon {
    public List<GetSegmentResult>? Segments { get; set; }
}

public class GetPlayerStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? StatisticNames { get; set; }
    public List<StatisticNameVersion>? StatisticNameVersions { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetPlayerStatisticsResult : PlayFabResultCommon {
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

public class GetPlayerTradesRequest : PlayFabRequestCommon {
    public TradeStatus? StatusFilter { get; set; }
}

public class GetPlayerTradesResponse : PlayFabResultCommon {
    public List<TradeInfo>? AcceptedTrades { get; set; }
    public List<TradeInfo>? OpenedTrades { get; set; }
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
/// For Facebook Instant Game identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromFacebookInstantGamesIdsResult : PlayFabResultCommon {
    public List<FacebookInstantGamesPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGameCenterIDsRequest : PlayFabRequestCommon {
    public required List<string> GameCenterIDs { get; set; }
}

/// <summary>
/// For Game Center identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGameCenterIDsResult : PlayFabResultCommon {
    public List<GameCenterPlayFabIdPair>? Data { get; set; }
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

public class GetPlayFabIDsFromGoogleIDsRequest : PlayFabRequestCommon {
    public required List<string> GoogleIDs { get; set; }
}

/// <summary>
/// For Google identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGoogleIDsResult : PlayFabResultCommon {
    public List<GooglePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest : PlayFabRequestCommon {
    public required List<string> GooglePlayGamesPlayerIDs { get; set; }
}

/// <summary>
/// For Google Play Games identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult : PlayFabResultCommon {
    public List<GooglePlayGamesPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromKongregateIDsRequest : PlayFabRequestCommon {
    public required List<string> KongregateIDs { get; set; }
}

/// <summary>
/// For Kongregate identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromKongregateIDsResult : PlayFabResultCommon {
    public List<KongregatePlayFabIdPair>? Data { get; set; }
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
/// For Nintendo Switch identifiers which have not been linked to PlayFab accounts, null will be returned.
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
/// For Steam identifiers which have not been linked to PlayFab accounts, or if the user has not logged in recently, null will be returned.
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

public class GetPurchaseRequest : PlayFabRequestCommon {
    public required string OrderId { get; set; }
}

public class GetPurchaseResult : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
    public string? OrderId { get; set; }
    public string? PaymentProvider { get; set; }
    public required DateTime PurchaseDate { get; set; }
    public string? TransactionId { get; set; }
    public string? TransactionStatus { get; set; }
}

public class GetSegmentResult {
    public string? ABTestParent { get; set; }
    public required string Id { get; set; }
    public string? Name { get; set; }
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

/// <summary>
/// A store contains an array of references to items defined in one or more catalog versions of the game, along with the prices for the item, in both real world and virtual currencies. These prices act as an override to any prices defined in the catalog. In this way, the base definitions of the items may be defined in the catalog, with all associated properties, while the pricing can be set for each store, as needed. This allows for subsets of goods to be defined for different purposes (in order to simplify showing some, but not all catalog items to users, based upon different characteristics), along with unique prices. Note that all prices defined in the catalog and store definitions for the item are considered valid, and that a compromised client can be made to send a request for an item based upon any of these definitions. If no price is specified in the store for an item, the price set in the catalog should be displayed to the user.
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
/// This API is designed to return title specific values which can be read, but not written to, by the client. For example, a developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths, movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new build. If the player belongs to an experiment variant that uses title data overrides, the overrides are applied automatically and returned with the title data. Note that there may up to a minute delay in between updating title data and this API call returning the newest value.
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
/// An RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header. For example if Client/LoginWithCustomId requires signature headers but the player does not have an account yet follow these steps: 1) Call Client/GetTitlePublicKey with one of the title's shared secrets. 2) Convert the Base64 encoded CSP blob to a byte array and create an RSA signing object. 3) Encrypt the UTF8 encoded JSON body of the registration request and place the Base64 encoded result into the EncryptedRequest and with the TitleId field, all other fields can be left empty when performing the API request. 4) Client receives authentication token as normal. Future requests to LoginWithCustomId will require the X-PlayFab-Signature header.
/// </summary>
public class GetTitlePublicKeyRequest : PlayFabRequestCommon {
    public required string TitleId { get; set; }
    public required string TitleSharedSecret { get; set; }
}

public class GetTitlePublicKeyResult : PlayFabResultCommon {
    public string? RSAPublicKey { get; set; }
}

public class GetTradeStatusRequest : PlayFabRequestCommon {
    public required string OfferingPlayerId { get; set; }
    public required string TradeId { get; set; }
}

public class GetTradeStatusResponse : PlayFabResultCommon {
    public TradeInfo? Trade { get; set; }
}

[Obsolete("Do not use")]
public class GetUserCombinedInfoRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Email { get; set; }
    public bool? GetAccountInfo { get; set; }
    public bool? GetInventory { get; set; }
    public bool? GetReadOnlyData { get; set; }
    public bool? GetUserData { get; set; }
    public bool? GetVirtualCurrency { get; set; }
    public string? PlayFabId { get; set; }
    public List<string>? ReadOnlyDataKeys { get; set; }
    public string? TitleDisplayName { get; set; }
    public List<string>? UserDataKeys { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// This API retrieves details regarding the user in the PlayFab service. Note that data returned for the locally signed-in user may contain Personally Identifying Information (PII), such as email address, and so care should be taken in how this data is stored and managed. Since this call will always return the relevant information for the user, the recommendation is to not store this data locally.
/// </summary>
[Obsolete("Do not use")]
public class GetUserCombinedInfoResult : PlayFabResultCommon {
    public UserAccountInfo? AccountInfo { get; set; }
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    public UInt32 DataVersion { get; set; }
    public List<ItemInstance>? Inventory { get; set; }
    public string? PlayFabId { get; set; }
    public Dictionary<string, UserDataRecord>? ReadOnlyData { get; set; }
    public UInt32 ReadOnlyDataVersion { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

/// <summary>
/// Data is stored as JSON key-value pairs. Every time the data is updated via any source, the version counter is incremented. If the Version parameter is provided, then this call will only return data if the current version on the system is greater than the value provided. If the Keys parameter is provided, the data object returned will only contain the data specific to the indicated Keys. Otherwise, the full set of custom user data will be returned.
/// </summary>
public class GetUserDataRequest : PlayFabRequestCommon {
    public UInt32? IfChangedFromDataVersion { get; set; }
    public List<string>? Keys { get; set; }
    public string? PlayFabId { get; set; }
}

public class GetUserDataResult : PlayFabResultCommon {
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    public UInt32 DataVersion { get; set; }
}

public class GetUserInventoryRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// All items currently in the user inventory will be returned, irrespective of how they were acquired (via purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the user's current inventory, and so will not be not included.
/// </summary>
public class GetUserInventoryResult : PlayFabResultCommon {
    public List<ItemInstance>? Inventory { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

[Obsolete("Do not use")]
public class GetUserStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class GetUserStatisticsResult : PlayFabResultCommon {
    public Dictionary<string, int>? UserStatistics { get; set; }
}

public class GooglePlayFabIdPair {
    public string? GoogleId { get; set; }
    public string? PlayFabId { get; set; }
}

public class GooglePlayGamesPlayFabIdPair {
    public string? GooglePlayGamesPlayerId { get; set; }
    public string? PlayFabId { get; set; }
}

/// <summary>
/// Grants a character to the user of the type specified by the item ID. The user must already have an instance of this item in their inventory in order to allow character creation. This item can come from a purchase or grant, which must be done before calling to create the character.
/// </summary>
public class GrantCharacterToUserRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string CharacterName { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemId { get; set; }
}

public class GrantCharacterToUserResult : PlayFabResultCommon {
    public string? CharacterId { get; set; }
    public string? CharacterType { get; set; }
    public bool Result { get; set; }
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

public class ItemPurchaseRequest {
    public string? Annotation { get; set; }
    public required string ItemId { get; set; }
    public UInt32 Quantity { get; set; }
    public List<string>? UpgradeFromItems { get; set; }
}

public class KongregatePlayFabIdPair {
    public string? KongregateId { get; set; }
    public string? PlayFabId { get; set; }
}

public class LinkAndroidDeviceIDRequest : PlayFabRequestCommon {
    public string? AndroidDevice { get; set; }
    public required string AndroidDeviceId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public string? OS { get; set; }
}

public class LinkAndroidDeviceIDResult : PlayFabResultCommon {
}

public class LinkAppleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdentityToken { get; set; }
}

public class LinkBattleNetAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdentityToken { get; set; }
}

public class LinkCustomIDRequest : PlayFabRequestCommon {
    public required string CustomId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
}

public class LinkCustomIDResult : PlayFabResultCommon {
}

public class LinkedPlatformAccountModel {
    public string? Email { get; set; }
    public LoginIdentityProvider? Platform { get; set; }
    public string? PlatformUserId { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// Facebook sign-in is accomplished using the Facebook User Access Token. More information on the Token can be found in the Facebook developer documentation (https://developers.facebook.com/docs/facebook-login/access-tokens/). In Unity, for example, the Token is available as AccessToken in the Facebook SDK ScriptableObject FB. Note that titles should never re-use the same Facebook applications between PlayFab Title IDs, as Facebook provides unique user IDs per application and doing so can result in issues with the Facebook ID for the user in their PlayFab account information. If you must re-use an application in a new PlayFab Title ID, please be sure to first unlink all accounts from Facebook, or delete all users in the first Title ID.
/// </summary>
public class LinkFacebookAccountRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public string? AuthenticationToken { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
}

public class LinkFacebookAccountResult : PlayFabResultCommon {
}

public class LinkFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string FacebookInstantGamesSignature { get; set; }
    public bool? ForceLink { get; set; }
}

public class LinkFacebookInstantGamesIdResult : PlayFabResultCommon {
}

public class LinkGameCenterAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string GameCenterId { get; set; }
    public string? PublicKeyUrl { get; set; }
    public string? Salt { get; set; }
    public string? Signature { get; set; }
    public string? Timestamp { get; set; }
}

public class LinkGameCenterAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Google sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google sign-in for Android APIs on the device and passing it to this API.
/// </summary>
public class LinkGoogleAccountRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public string? ServerAuthCode { get; set; }
}

public class LinkGoogleAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Google Play Games sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google Play Games sign-in for Android APIs on the device and passing it to this API.
/// </summary>
public class LinkGooglePlayGamesServicesAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string ServerAuthCode { get; set; }
}

public class LinkGooglePlayGamesServicesAccountResult : PlayFabResultCommon {
}

public class LinkIOSDeviceIDRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string DeviceId { get; set; }
    public string? DeviceModel { get; set; }
    public bool? ForceLink { get; set; }
    public string? OS { get; set; }
}

public class LinkIOSDeviceIDResult : PlayFabResultCommon {
}

public class LinkKongregateAccountRequest : PlayFabRequestCommon {
    public required string AuthTicket { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string KongregateId { get; set; }
}

public class LinkKongregateAccountResult : PlayFabResultCommon {
}

public class LinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdentityToken { get; set; }
}

public class LinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string NintendoSwitchDeviceId { get; set; }
}

public class LinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class LinkOpenIdConnectRequest : PlayFabRequestCommon {
    public required string ConnectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string IdToken { get; set; }
}

public class LinkPSNAccountRequest : PlayFabRequestCommon {
    public required string AuthCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public int? IssuerId { get; set; }
    public required string RedirectUri { get; set; }
}

public class LinkPSNAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Steam authentication is accomplished with the Steam Session Ticket. More information on the Ticket can be found in the Steamworks SDK, here: https://partner.steamgames.com/documentation/auth (requires sign-in). NOTE: For Steam authentication to work, the title must be configured with the Steam Application ID and Publisher Key in the PlayFab Game Manager (under Properties). Information on creating a Publisher Key (referred to as the Secret Key in PlayFab) for your title can be found here: https://partner.steamgames.com/documentation/webapi#publisherkey.
/// </summary>
public class LinkSteamAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string SteamTicket { get; set; }
    public bool? TicketIsServiceSpecific { get; set; }
}

public class LinkSteamAccountResult : PlayFabResultCommon {
}

public class LinkTwitchAccountRequest : PlayFabRequestCommon {
    public required string AccessToken { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
}

public class LinkTwitchAccountResult : PlayFabResultCommon {
}

public class LinkXboxAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? ForceLink { get; set; }
    public required string XboxToken { get; set; }
}

public class LinkXboxAccountResult : PlayFabResultCommon {
}

public class ListPlayerCustomPropertiesRequest : PlayFabRequestCommon {
}

public class ListPlayerCustomPropertiesResult : PlayFabResultCommon {
    public List<CustomPropertyDetails>? Properties { get; set; }
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Returns a list of every character that currently belongs to a user.
/// </summary>
public class ListUsersCharactersRequest : PlayFabRequestCommon {
    public string? PlayFabId { get; set; }
}

public class ListUsersCharactersResult : PlayFabResultCommon {
    public List<CharacterResult>? Characters { get; set; }
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
    public string? EventName { get; set; }
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

public class LoginResult : PlayFabResultCommon {
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
/// On Android devices, the recommendation is to use the Settings.Secure.ANDROID_ID as the AndroidDeviceId, as described in this blog post (http://android-developers.blogspot.com/2011/03/identifying-app-installations.html). More information on this identifier can be found in the Android documentation (http://developer.android.com/reference/android/provider/Settings.Secure.html). If this is the first time a user has signed in with the Android device and CreateAccount is set to true, a new PlayFab account will be created and linked to the Android device ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Android device, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. Please note that while multiple devices of this type can be linked to a single user account, only the one most recently used to login (or most recently linked) will be reflected in the user's account information. We will be updating to show all linked devices in a future release.
/// </summary>
public class LoginWithAndroidDeviceIDRequest : PlayFabRequestCommon {
    public string? AndroidDevice { get; set; }
    public string? AndroidDeviceId { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? OS { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithAppleRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public required string IdentityToken { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithBattleNetRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public required string IdentityToken { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// It is highly recommended that developers ensure that it is extremely unlikely that a customer could generate an ID which is already in use by another customer. If this is the first time a user has signed in with the Custom ID and CreateAccount is set to true, a new PlayFab account will be created and linked to the Custom ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Custom ID, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithCustomIDRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public string? CustomId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Email address and password lengths are provided for information purposes. The server will validate that data passed in conforms to the field definition and report errors appropriately. It is recommended that developers not perform this validation locally, so that future updates do not require client updates.
/// </summary>
public class LoginWithEmailAddressRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Email { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string Password { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public required string FacebookInstantGamesSignature { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Facebook sign-in is accomplished using the Facebook User Access Token. More information on the Token can be found in the Facebook developer documentation (https://developers.facebook.com/docs/facebook-login/access-tokens/). In Unity, for example, the Token is available as AccessToken in the Facebook SDK ScriptableObject FB. If this is the first time a user has signed in with the Facebook account and CreateAccount is set to true, a new PlayFab account will be created and linked to the provided account's Facebook ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Facebook account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. Note that titles should never re-use the same Facebook applications between PlayFab Title IDs, as Facebook provides unique user IDs per application and doing so can result in issues with the Facebook ID for the user in their PlayFab account information. If you must re-use an application in a new PlayFab Title ID, please be sure to first unlink all accounts from Facebook, or delete all users in the first Title ID. Note: If the user is authenticated with AuthenticationToken, instead of AccessToken, the GetFriendsList API will return an empty list.
/// </summary>
public class LoginWithFacebookRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public string? AuthenticationToken { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// The Game Center player identifier (https://developer.apple.com/library/ios/documentation/Accounts/Reference/ACAccountClassRef/index.html#//apple_ref/occ/instp/ACAccount/identifier) is a generated string which is stored on the local device. As with device identifiers, care must be taken to never expose a player's Game Center identifier to end users, as that could result in a user's account being compromised. If this is the first time a user has signed in with Game Center and CreateAccount is set to true, a new PlayFab account will be created and linked to the Game Center identifier. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Game Center account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. If an invalid iOS Game Center player identifier is used, an error indicating this will be returned.
/// </summary>
public class LoginWithGameCenterRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerId { get; set; }
    public string? PlayerSecret { get; set; }
    public string? PublicKeyUrl { get; set; }
    public string? Salt { get; set; }
    public string? Signature { get; set; }
    public string? Timestamp { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Google sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google sign-in for Android APIs on the device and passing it to this API. If this is the first time a user has signed in with the Google account and CreateAccount is set to true, a new PlayFab account will be created and linked to the Google account. Otherwise, if no PlayFab account is linked to the Google account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. The current (recommended) method for obtaining a Google account credential in an Android application is to call GoogleSignInAccount.getServerAuthCode() and send the auth code as the ServerAuthCode parameter of this API. Before doing this, you must create an OAuth 2.0 web application client ID in the Google API Console and configure its client ID and secret in the PlayFab Game Manager Google Add-on for your title. This method does not require prompting of the user for additional Google account permissions, resulting in a user experience with the least possible friction. For more information about obtaining the server auth code, see https://developers.google.com/identity/sign-in/android/offline-access. The previous (deprecated) method was to obtain an OAuth access token by calling GetAccessToken() on the client and passing it as the AccessToken parameter to this API. for the with the Google OAuth 2.0 Access Token. More information on this change can be found in the Google developer documentation (https://android-developers.googleblog.com/2016/01/play-games-permissions-are-changing-in.html).
/// </summary>
public class LoginWithGoogleAccountRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public string? PublisherId { get; set; }
    public string? ServerAuthCode { get; set; }
    public bool? SetEmail { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Google Play Games sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google Play Games sign-in for Android APIs on the device and passing it to this API. If this is the first time a user has signed in with the Google Play Games account and CreateAccount is set to true, a new PlayFab account will be created and linked to the Google Play Games account. Otherwise, if no PlayFab account is linked to the Google Play Games account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. The current (recommended) method for obtaining a Google Play Games account credential in an Android application is to call GamesSignInClient.requestServerSideAccess() and send the auth code as the ServerAuthCode parameter of this API. Before doing this, you must create an OAuth 2.0 web application client ID in the Google API Console and configure its client ID and secret in the PlayFab Game Manager Google Add-on for your title. This method does not require prompting of the user for additional Google account permissions, resulting in a user experience with the least possible friction. For more information about obtaining the server auth code, see https://developers.google.com/games/services/android/signin.
/// </summary>
public class LoginWithGooglePlayGamesServicesRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public string? ServerAuthCode { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// On iOS devices, the identifierForVendor (https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDevice_Class/index.html#//apple_ref/occ/instp/UIDevice/identifierForVendor) must be used as the DeviceId, as the UIDevice uniqueIdentifier has been deprecated as of iOS 5, and use of the advertisingIdentifier for this purpose will result in failure of Apple's certification process. If this is the first time a user has signed in with the iOS device and CreateAccount is set to true, a new PlayFab account will be created and linked to the vendor-specific iOS device ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the iOS device, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. Please note that while multiple devices of this type can be linked to a single user account, only the one most recently used to login (or most recently linked) will be reflected in the user's account information. We will be updating to show all linked devices in a future release.
/// </summary>
public class LoginWithIOSDeviceIDRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DeviceId { get; set; }
    public string? DeviceModel { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? OS { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// More details regarding Kongregate and their game authentication system can be found at http://developers.kongregate.com/docs/virtual-goods/authentication. Developers must provide the Kongregate user ID and auth token that are generated using the Kongregate client library. PlayFab will combine these identifiers with the title's unique Kongregate app ID to log the player into the Kongregate system. If CreateAccount is set to true and there is not already a user matched to this Kongregate ID, then PlayFab will create a new account for this user and link the ID. In this case, no email or username will be associated with the PlayFab account. If there is already a different PlayFab user linked with this account, then an error will be returned.
/// </summary>
public class LoginWithKongregateRequest : PlayFabRequestCommon {
    public string? AuthTicket { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public string? KongregateId { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithNintendoServiceAccountRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public required string IdentityToken { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? NintendoSwitchDeviceId { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

public class LoginWithOpenIdConnectRequest : PlayFabRequestCommon {
    public required string ConnectionId { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public required string IdToken { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Username and password lengths are provided for information purposes. The server will validate that data passed in conforms to the field definition and report errors appropriately. It is recommended that developers not perform this validation locally, so that future updates to the username or password do not require client updates.
/// </summary>
public class LoginWithPlayFabRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public required string Password { get; set; }
    public required string TitleId { get; set; }
    public required string Username { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the PlayStation :tm: Network account and CreateAccount is set to true, a new PlayFab account will be created and linked to the PlayStation :tm: Network account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the PlayStation :tm: Network account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithPSNRequest : PlayFabRequestCommon {
    public string? AuthCode { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public int? IssuerId { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public string? RedirectUri { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// Steam sign-in is accomplished with the Steam Session Ticket. More information on the Ticket can be found in the Steamworks SDK, here: https://partner.steamgames.com/documentation/auth. NOTE: For Steam authentication to work, the title must be configured with the Steam Application ID and Web API Key in the PlayFab Game Manager (under Steam in the Add-ons Marketplace). You can obtain a Web API Key from the Permissions page of any Group associated with your App ID in the Steamworks site. If this is the first time a user has signed in with the Steam account and CreateAccount is set to true, a new PlayFab account will be created and linked to the provided account's Steam ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Steam account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithSteamRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public string? SteamTicket { get; set; }
    public bool? TicketIsServiceSpecific { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// More details regarding Twitch and their authentication system can be found at https://github.com/justintv/Twitch-API/blob/master/authentication.md. Developers must provide the Twitch access token that is generated using one of the Twitch authentication flows. PlayFab will use the title's unique Twitch Client ID to authenticate the token and log in to the PlayFab system. If CreateAccount is set to true and there is not already a user matched to the Twitch username that generated the token, then PlayFab will create a new account for this user and link the ID. In this case, no email or username will be associated with the PlayFab account. If there is already a different PlayFab user linked with this account, then an error will be returned.
/// </summary>
public class LoginWithTwitchRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the Xbox Live account and CreateAccount is set to true, a new PlayFab account will be created and linked to the Xbox Live account. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Xbox Live account, an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithXboxRequest : PlayFabRequestCommon {
    public bool? CreateAccount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? PlayerSecret { get; set; }
    public required string TitleId { get; set; }
    public string? XboxToken { get; set; }
}

public class LogStatement {
    public object? Data { get; set; }
    public string? Level { get; set; }
    public string? Message { get; set; }
}

[Obsolete("Do not use")]
public class MatchmakeRequest : PlayFabRequestCommon {
    public string? BuildVersion { get; set; }
    public string? CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? EnableQueue { get; set; }
    public string? GameMode { get; set; }
    public string? LobbyId { get; set; }
    public Region? Region { get; set; }
    public bool? StartNewIfNoneFound { get; set; }
    public string? StatisticName { get; set; }
    public CollectionFilter? TagFilter { get; set; }
}

[Obsolete("Do not use")]
public class MatchmakeResult : PlayFabResultCommon {
    public string? Expires { get; set; }
    public string? LobbyID { get; set; }
    public int? PollWaitTimeMS { get; set; }
    public string? ServerHostname { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public int? ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
    public MatchmakeStatus? Status { get; set; }
    public string? Ticket { get; set; }
}

public enum MatchmakeStatus {
    Complete,
    Waiting,
    GameNotFound,
    NoAvailableSlots,
    SessionClosed,
}

public class MembershipModel {
    public bool IsActive { get; set; }
    public required DateTime MembershipExpiration { get; set; }
    public string? MembershipId { get; set; }
    public DateTime? OverrideExpiration { get; set; }
    public bool? OverrideIsSet { get; set; }
    public List<SubscriptionModel>? Subscriptions { get; set; }
}

public class MicrosoftStorePayload {
    public string? CollectionsMsIdKey { get; set; }
    public string? UserId { get; set; }
    public string? XboxToken { get; set; }
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

public class NintendoServiceAccountPlayFabIdPair {
    public string? NintendoServiceAccountId { get; set; }
    public string? PlayFabId { get; set; }
}

public class NintendoSwitchPlayFabIdPair {
    public string? NintendoSwitchDeviceId { get; set; }
    public string? PlayFabId { get; set; }
}

public class OpenTradeRequest : PlayFabRequestCommon {
    public List<string>? AllowedPlayerIds { get; set; }
    public List<string>? OfferedInventoryInstanceIds { get; set; }
    public List<string>? RequestedCatalogItemIds { get; set; }
}

public class OpenTradeResponse : PlayFabResultCommon {
    public TradeInfo? Trade { get; set; }
}

/// <summary>
/// This is the second step in the purchasing process, initiating the purchase transaction with the payment provider (if applicable). For payment provider scenarios, the title should next present the user with the payment provider'sinterface for payment. Once the player has completed the payment with the provider, the title should call ConfirmPurchase tofinalize the process and add the appropriate items to the player inventory.
/// </summary>
public class PayForPurchaseRequest : PlayFabRequestCommon {
    public required string Currency { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string OrderId { get; set; }
    public required string ProviderName { get; set; }
    public string? ProviderTransactionId { get; set; }
}

/// <summary>
/// For web-based payment providers, this operation returns the URL to which the user should be directed inorder to approve the purchase. Items added to the user inventory as a result of this operation will be marked as unconfirmed.
/// </summary>
public class PayForPurchaseResult : PlayFabResultCommon {
    public UInt32 CreditApplied { get; set; }
    public string? OrderId { get; set; }
    public string? ProviderData { get; set; }
    public string? ProviderToken { get; set; }
    public string? PurchaseConfirmationPageURL { get; set; }
    public string? PurchaseCurrency { get; set; }
    public UInt32 PurchasePrice { get; set; }
    public TransactionStatus? Status { get; set; }
    public Dictionary<string, int>? VCAmount { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
}

public class PaymentOption {
    public string? Currency { get; set; }
    public UInt32 Price { get; set; }
    public string? ProviderName { get; set; }
    public UInt32 StoreCredit { get; set; }
}

public class PlayerLeaderboardEntry {
    public string? DisplayName { get; set; }
    public string? PlayFabId { get; set; }
    public int Position { get; set; }
    public PlayerProfileModel? Profile { get; set; }
    public int StatValue { get; set; }
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

public class PlayerStatisticVersion {
    public required DateTime ActivationTime { get; set; }
    public DateTime? DeactivationTime { get; set; }
    public DateTime? ScheduledActivationTime { get; set; }
    public DateTime? ScheduledDeactivationTime { get; set; }
    public string? StatisticName { get; set; }
    public UInt32 Version { get; set; }
}

public class PlayStation5Payload {
    public List<string>? Ids { get; set; }
    public string? ServiceLabel { get; set; }
}

public class PSNAccountPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? PSNAccountId { get; set; }
}

public class PSNOnlinePlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? PSNOnlineId { get; set; }
}

/// <summary>
/// Please note that the processing time for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase operation (with each item in a bundle being a distinct add).
/// </summary>
public class PurchaseItemRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ItemId { get; set; }
    public int Price { get; set; }
    public string? StoreId { get; set; }
    public required string VirtualCurrency { get; set; }
}

public class PurchaseItemResult : PlayFabResultCommon {
    public List<ItemInstance>? Items { get; set; }
}

public class PurchaseReceiptFulfillment {
    public List<ItemInstance>? FulfilledItems { get; set; }
    public string? RecordedPriceSource { get; set; }
    public string? RecordedTransactionCurrency { get; set; }
    public UInt32? RecordedTransactionTotal { get; set; }
}

public enum PushNotificationPlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class PushNotificationRegistrationModel {
    public string? NotificationEndpointARN { get; set; }
    public PushNotificationPlatform? Platform { get; set; }
}

/// <summary>
/// Coupon codes can be created for any item, or set of items, in the catalog for the title. This operation causes the coupon to be consumed, and the specific items to be awarded to the user. Attempting to re-use an already consumed code, or a code which has not yet been created in the service, will result in an error.
/// </summary>
public class RedeemCouponRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public required string CouponCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RedeemCouponResult : PlayFabResultCommon {
    public List<ItemInstance>? GrantedItems { get; set; }
}

public class RefreshPSNAuthTokenRequest : PlayFabRequestCommon {
    public required string AuthCode { get; set; }
    public int? IssuerId { get; set; }
    public required string RedirectUri { get; set; }
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
public class RegionInfo {
    public bool Available { get; set; }
    public string? Name { get; set; }
    public string? PingUrl { get; set; }
    public Region? Region { get; set; }
}

/// <summary>
/// The steps to configure and send Push Notifications is described in the PlayFab tutorials, here: https://docs.microsoft.com/gaming/playfab/features/engagement/push-notifications/quickstart
/// </summary>
public class RegisterForIOSPushNotificationRequest : PlayFabRequestCommon {
    public string? ConfirmationMessage { get; set; }
    public required string DeviceToken { get; set; }
    public bool? SendPushNotificationConfirmation { get; set; }
}

public class RegisterForIOSPushNotificationResult : PlayFabResultCommon {
}

public class RegisterPlayFabUserRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DisplayName { get; set; }
    public string? Email { get; set; }
    public string? EncryptedRequest { get; set; }
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    public string? Origination { get; set; }
    public string? Password { get; set; }
    public string? PlayerSecret { get; set; }
    public bool? RequireBothUsernameAndEmail { get; set; }
    public required string TitleId { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// Each account must have a unique email address in the PlayFab service. Once created, the account may be associated with additional accounts (Steam, Facebook, Game Center, etc.), allowing for added social network lists and achievements systems.
/// </summary>
public class RegisterPlayFabUserResult : PlayFabResultCommon {
    public EntityTokenResponse? EntityToken { get; set; }
    public string? PlayFabId { get; set; }
    public string? SessionTicket { get; set; }
    public UserSettings? SettingsForUser { get; set; }
    public string? Username { get; set; }
}

/// <summary>
/// This API removes an existing contact email from the player's profile.
/// </summary>
public class RemoveContactEmailRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RemoveContactEmailResult : PlayFabResultCommon {
}

public class RemoveFriendRequest : PlayFabRequestCommon {
    public required string FriendPlayFabId { get; set; }
}

public class RemoveFriendResult : PlayFabResultCommon {
}

public class RemoveGenericIDRequest : PlayFabRequestCommon {
    public required GenericServiceId GenericId { get; set; }
}

public class RemoveGenericIDResult : PlayFabResultCommon {
}

public class RemoveSharedGroupMembersRequest : PlayFabRequestCommon {
    public required List<string> PlayFabIds { get; set; }
    public required string SharedGroupId { get; set; }
}

public class RemoveSharedGroupMembersResult : PlayFabResultCommon {
}

/// <summary>
/// Report ad activity
/// </summary>
public class ReportAdActivityRequest : PlayFabRequestCommon {
    public AdActivity Activity { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlacementId { get; set; }
    public required string RewardId { get; set; }
}

/// <summary>
/// Report ad activity response has no body
/// </summary>
public class ReportAdActivityResult : PlayFabResultCommon {
}

public class ReportPlayerClientRequest : PlayFabRequestCommon {
    public string? Comment { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ReporteeId { get; set; }
}

/// <summary>
/// Players are currently limited to five reports per day. Attempts by a single user account to submit reports beyond five will result in Updated being returned as false.
/// </summary>
public class ReportPlayerClientResult : PlayFabResultCommon {
    public int SubmissionsRemaining { get; set; }
    public bool? Updated { get; set; }
}

/// <summary>
/// The title should obtain a refresh receipt via restoreCompletedTransactions in the SKPaymentQueue of the Apple StoreKit and pass that in to this call. The resultant receipt contains new receipt instances for all non-consumable goods previously purchased by the user. This API call iterates through every purchase in the receipt and restores the items if they still exist in the catalog and can be validated.
/// </summary>
public class RestoreIOSPurchasesRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ReceiptData { get; set; }
}

/// <summary>
/// Once verified, the valid items will be restored into the user's inventory. This result should be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class RestoreIOSPurchasesResult : PlayFabResultCommon {
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// Details on which placement and reward to perform a grant on
/// </summary>
public class RewardAdActivityRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string PlacementId { get; set; }
    public required string RewardId { get; set; }
}

/// <summary>
/// Result for rewarding an ad activity
/// </summary>
public class RewardAdActivityResult : PlayFabResultCommon {
    public string? AdActivityEventId { get; set; }
    public List<string>? DebugResults { get; set; }
    public string? PlacementId { get; set; }
    public string? PlacementName { get; set; }
    public int? PlacementViewsRemaining { get; set; }
    public double? PlacementViewsResetMinutes { get; set; }
    public AdRewardResults? RewardResults { get; set; }
}

/// <summary>
/// Inputs to the Cloud Script may be specified either using Params, which is an object containing one or more parameters, or ParamsEncoded, which is a string containing the parameters encoded into JSON. Titles should only specify the parameters in one of these inputs - if both are specified, the ParamsEncoded will be used.
/// </summary>
[Obsolete("Do not use")]
public class RunCloudScriptRequest : PlayFabRequestCommon {
    public required string ActionId { get; set; }
    public object? Params { get; set; }
    public string? ParamsEncoded { get; set; }
}

/// <summary>
/// As part of the returned values, both Results and ResultsEncoded will be provided. As with Params and ParamsEncoded, these are respectively an object containing the returned values, and a string containing the returned values encoded into JSON. In addition, the Cloud Script may additionally generate a log, using log.info(), in order to provide additional debugging information.
/// </summary>
[Obsolete("Do not use")]
public class RunCloudScriptResult : PlayFabResultCommon {
    public string? ActionId { get; set; }
    public string? ActionLog { get; set; }
    public required double ExecutionTime { get; set; }
    public object? Results { get; set; }
    public string? ResultsEncoded { get; set; }
    public int Revision { get; set; }
    public int Version { get; set; }
}

public class ScriptExecutionError {
    public string? Error { get; set; }
    public string? Message { get; set; }
    public string? StackTrace { get; set; }
}

/// <summary>
/// If the account in question is a "temporary" account (for example, one that was created via a call to LoginFromIOSDeviceID), thisfunction will have no effect. Only PlayFab accounts which have valid email addresses will be able to receive a password reset email using this API.
/// </summary>
public class SendAccountRecoveryEmailRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Email { get; set; }
    public string? EmailTemplateId { get; set; }
    public string? PublisherId { get; set; }
    public required string TitleId { get; set; }
}

public class SendAccountRecoveryEmailResult : PlayFabResultCommon {
}

/// <summary>
/// This operation is not additive. It will completely replace the tag list for the specified user. Please note that only users in the PlayFab friends list can be assigned tags. Attempting to set a tag on a friend only included in the friends list from a social site integration (such as Facebook or Steam) will return the AccountNotFound error.
/// </summary>
public class SetFriendTagsRequest : PlayFabRequestCommon {
    public required string FriendPlayFabId { get; set; }
    public required List<string> Tags { get; set; }
}

public class SetFriendTagsResult : PlayFabResultCommon {
}

/// <summary>
/// APIs that require signatures require that the player have a configured Player Secret Key that is used to sign all requests. Players that don't have a secret will be blocked from making API calls until it is configured. To create a signature header add a SHA256 hashed string containing UTF8 encoded JSON body as it will be sent to the server, the current time in UTC formatted to ISO 8601, and the players secret formatted as 'body.date.secret'. Place the resulting hash into the header X-PlayFab-Signature, along with a header X-PlayFab-Timestamp of the same UTC timestamp used in the signature.
/// </summary>
public class SetPlayerSecretRequest : PlayFabRequestCommon {
    public string? EncryptedRequest { get; set; }
    public string? PlayerSecret { get; set; }
}

public class SetPlayerSecretResult : PlayFabResultCommon {
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

/// <summary>
/// This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
[Obsolete("Do not use")]
public class StartGameRequest : PlayFabRequestCommon {
    public required string BuildVersion { get; set; }
    public string? CharacterId { get; set; }
    public string? CustomCommandLineData { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string GameMode { get; set; }
    public Region Region { get; set; }
    public string? StatisticName { get; set; }
}

[Obsolete("Do not use")]
public class StartGameResult : PlayFabResultCommon {
    public string? Expires { get; set; }
    public string? LobbyID { get; set; }
    public string? Password { get; set; }
    public string? ServerHostname { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public int? ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
    public string? Ticket { get; set; }
}

/// <summary>
/// This is the first step in the purchasing process. For security purposes, once the order (or "cart") has been created, additional inventory objects may no longer be added. In addition, inventory objects will be locked to the current prices, regardless of any subsequent changes at the catalog level which may occur during the next two steps.
/// </summary>
public class StartPurchaseRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<ItemPurchaseRequest> Items { get; set; }
    public string? StoreId { get; set; }
}

public class StartPurchaseResult : PlayFabResultCommon {
    public List<CartItem>? Contents { get; set; }
    public string? OrderId { get; set; }
    public List<PaymentOption>? PaymentOptions { get; set; }
    public Dictionary<string, int>? VirtualCurrencyBalances { get; set; }
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

/// <summary>
/// This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
public class SubtractUserVirtualCurrencyRequest : PlayFabRequestCommon {
    public int Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
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

public class TradeInfo {
    public List<string>? AcceptedInventoryInstanceIds { get; set; }
    public string? AcceptedPlayerId { get; set; }
    public List<string>? AllowedPlayerIds { get; set; }
    public DateTime? CancelledAt { get; set; }
    public DateTime? FilledAt { get; set; }
    public DateTime? InvalidatedAt { get; set; }
    public List<string>? OfferedCatalogItemIds { get; set; }
    public List<string>? OfferedInventoryInstanceIds { get; set; }
    public string? OfferingPlayerId { get; set; }
    public DateTime? OpenedAt { get; set; }
    public List<string>? RequestedCatalogItemIds { get; set; }
    public TradeStatus? Status { get; set; }
    public string? TradeId { get; set; }
}

public enum TradeStatus {
    Invalid,
    Opening,
    Open,
    Accepting,
    Accepted,
    Filled,
    Cancelled,
}

public enum TransactionStatus {
    CreateCart,
    Init,
    Approved,
    Succeeded,
    FailedByProvider,
    DisputePending,
    RefundPending,
    Refunded,
    RefundFailed,
    ChargedBack,
    FailedByUber,
    FailedByPlayFab,
    Revoked,
    TradePending,
    Traded,
    Upgraded,
    StackPending,
    Stacked,
    Other,
    Failed,
}

public class TreatmentAssignment {
    public List<Variable>? Variables { get; set; }
    public List<string>? Variants { get; set; }
}

public class TwitchPlayFabIdPair {
    public string? PlayFabId { get; set; }
    public string? TwitchId { get; set; }
}

public class UnlinkAndroidDeviceIDRequest : PlayFabRequestCommon {
    public string? AndroidDeviceId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkAndroidDeviceIDResult : PlayFabResultCommon {
}

public class UnlinkAppleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkBattleNetAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkCustomIDRequest : PlayFabRequestCommon {
    public string? CustomId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkCustomIDResult : PlayFabResultCommon {
}

public class UnlinkFacebookAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkFacebookAccountResult : PlayFabResultCommon {
}

public class UnlinkFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? FacebookInstantGamesId { get; set; }
}

public class UnlinkFacebookInstantGamesIdResult : PlayFabResultCommon {
}

public class UnlinkGameCenterAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGameCenterAccountResult : PlayFabResultCommon {
}

public class UnlinkGoogleAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGoogleAccountResult : PlayFabResultCommon {
}

public class UnlinkGooglePlayGamesServicesAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGooglePlayGamesServicesAccountResult : PlayFabResultCommon {
}

public class UnlinkIOSDeviceIDRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DeviceId { get; set; }
}

public class UnlinkIOSDeviceIDResult : PlayFabResultCommon {
}

public class UnlinkKongregateAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkKongregateAccountResult : PlayFabResultCommon {
}

public class UnlinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? NintendoSwitchDeviceId { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class UnlinkOpenIdConnectRequest : PlayFabRequestCommon {
    public required string ConnectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkPSNAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkPSNAccountResult : PlayFabResultCommon {
}

public class UnlinkSteamAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkSteamAccountResult : PlayFabResultCommon {
}

public class UnlinkTwitchAccountRequest : PlayFabRequestCommon {
    public string? AccessToken { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkTwitchAccountResult : PlayFabResultCommon {
}

public class UnlinkXboxAccountRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
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
}

/// <summary>
/// Specify the type of container to open and optionally the catalogVersion for the container to open
/// </summary>
public class UnlockContainerItemRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CharacterId { get; set; }
    public required string ContainerItemId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// The items and vc found within the container. These will be added and stacked in the appropriate inventory.
/// </summary>
public class UnlockContainerItemResult : PlayFabResultCommon {
    public List<ItemInstance>? GrantedItems { get; set; }
    public string? UnlockedItemInstanceId { get; set; }
    public string? UnlockedWithItemInstanceId { get; set; }
    public Dictionary<string, UInt32>? VirtualCurrency { get; set; }
}

public class UpdateAvatarUrlRequest : PlayFabRequestCommon {
    public required string ImageUrl { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary strings containing the custom data for the character. In updating the custom data object, keys which already exist in the object will have their values overwritten, while keys with null values will be removed. New keys will be added, with the given values. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateCharacterDataRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public UserDataPermission? Permission { get; set; }
}

public class UpdateCharacterDataResult : PlayFabResultCommon {
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title. However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is additive. Character Statistics not currently defined will be added, while those already defined will be updated with the given values. All other user statistics will remain unchanged. Character statistics are used by the character-leaderboard apis, and accessible for custom game-logic.
/// </summary>
public class UpdateCharacterStatisticsRequest : PlayFabRequestCommon {
    public required string CharacterId { get; set; }
    public Dictionary<string, int>? CharacterStatistics { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UpdateCharacterStatisticsResult : PlayFabResultCommon {
}

/// <summary>
/// Performs an additive update of the custom properties for the specified player. In updating the player's custom properties, properties which already exist will have their values overwritten. No other properties will be changed apart from those specified in the call.
/// </summary>
public class UpdatePlayerCustomPropertiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? ExpectedPropertiesVersion { get; set; }
    public required List<UpdateProperty> Properties { get; set; }
}

public class UpdatePlayerCustomPropertiesResult : PlayFabResultCommon {
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title. However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is additive. Statistics not currently defined will be added, while those already defined will be updated with the given values. All other user statistics will remain unchanged. Note that if the statistic is intended to have a reset period, the UpdatePlayerStatisticDefinition API call can be used to define that reset period. Once a statistic has been versioned (reset), the now-previous version can still be written to for up a short, pre-defined period (currently 10 seconds), using the Version parameter in this call.
/// </summary>
public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
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
/// This function performs an additive update of the arbitrary strings containing the custom data for the user. In updating the custom data object, keys which already exist in the object will have their values overwritten, while keys with null values will be removed. New keys will be added, with the given values. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserDataRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, string>? Data { get; set; }
    public List<string>? KeysToRemove { get; set; }
    public UserDataPermission? Permission { get; set; }
}

public class UpdateUserDataResult : PlayFabResultCommon {
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title. However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is additive. Statistics not currently defined will be added, while those already defined will be updated with the given values. All other user statistics will remain unchanged. Statistics are used by the leaderboard apis, and accessible for custom game-logic. Note: For statistics configured to reset on an interval, this API call updates the current (latest) version of the player's statistic. Titles using statistic versioning for resettable leaderboards should make use of the UpdatePlayerStatistics call instead, to ensure that the proper version is updated.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public Dictionary<string, int>? UserStatistics { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsResult : PlayFabResultCommon {
}

/// <summary>
/// In addition to the PlayFab username, titles can make use of a DisplayName which is also a unique identifier, but specific to the title. This allows for unique names which more closely match the theme or genre of a title, for example.
/// </summary>
public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string DisplayName { get; set; }
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

public class ValidateAmazonReceiptRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int PurchasePrice { get; set; }
    public required string ReceiptId { get; set; }
    public required string UserId { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the Amazon item name will be added to the user's inventory. This result should be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class ValidateAmazonReceiptResult : PlayFabResultCommon {
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// The packageName and productId are defined in the GooglePlay store. The productId must match the ItemId of the inventory item in the PlayFab catalog for the title. This enables the PlayFab service to securely validate that the purchase is for the correct item, in order to prevent uses from passing valid receipts as being for more expensive items (passing a receipt for a 99-cent purchase as being for a $19.99 purchase, for example). Each receipt may be validated only once to avoid granting the same item over and over from a single purchase.
/// </summary>
public class ValidateGooglePlayPurchaseRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public UInt32? PurchasePrice { get; set; }
    public required string ReceiptJson { get; set; }
    public required string Signature { get; set; }
}

/// <summary>
/// Once verified, the catalog item (ItemId) matching the GooglePlay store item (productId) will be added to the user's inventory. This result should be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class ValidateGooglePlayPurchaseResult : PlayFabResultCommon {
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// The CurrencyCode and PurchasePrice must match the price which was set up for the item in the Apple store. In addition, The ItemId of the inventory in the PlayFab Catalog must match the Product ID as it was set up in the Apple store. This enables the PlayFab service to securely validate that the purchase is for the correct item, in order to prevent uses from passing valid receipts as being for more expensive items (passing a receipt for a 99-cent purchase as being for a $19.99 purchase, for example).
/// </summary>
public class ValidateIOSReceiptRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public string? CurrencyCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int PurchasePrice { get; set; }
    public required string ReceiptData { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the iTunes item name will be added to the user's inventory. This result should be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class ValidateIOSReceiptResult : PlayFabResultCommon {
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

public class ValidateWindowsReceiptRequest : PlayFabRequestCommon {
    public string? CatalogVersion { get; set; }
    public required string CurrencyCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public UInt32 PurchasePrice { get; set; }
    public required string Receipt { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the Product name will be added to the user's inventory. This result should be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class ValidateWindowsReceiptResult : PlayFabResultCommon {
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
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

/// <summary>
/// This API is designed to write a multitude of different client-defined events into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any character-based event. The created event will be locked to the authenticated title and player. 
/// </summary>
public class WriteClientCharacterEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public required string CharacterId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public DateTime? Timestamp { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different event types into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any player-based event. The created event will be locked to the authenticated title and player. 
/// </summary>
public class WriteClientPlayerEventRequest : PlayFabRequestCommon {
    public Dictionary<string, object>? Body { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EventName { get; set; }
    public DateTime? Timestamp { get; set; }
}

public class WriteEventResponse : PlayFabResultCommon {
    public string? EventId { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different client-defined events into PlayStream. It supports a flexible JSON schema, which allowsfor arbitrary key-value pairs to describe any title-based event. The created event will be locked to the authenticated title. 
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

