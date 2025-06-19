namespace CommunityFabs.NET.Sdk.Models.Economy;

public class AddInventoryItemsOperation {
    public int? Amount { get; set; }
    public double? DurationInSeconds { get; set; }
    public InventoryItemReference? Item { get; set; }
    public InitialValues? NewStackValues { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will add the specified inventory items.
/// </summary>
public class AddInventoryItemsRequest : PlayFabRequestCommon {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public double? DurationInSeconds { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public InventoryItemReference? Item { get; set; }
    public InitialValues? NewStackValues { get; set; }
}

public class AddInventoryItemsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

public class AlternateId {
    public string? Type { get; set; }
    public string? Value { get; set; }
}

public class CatalogAlternateId {
    public string? Type { get; set; }
    public string? Value { get; set; }
}

public class CatalogConfig {
    public List<EntityKey>? AdminEntities { get; set; }
    public CatalogSpecificConfig? Catalog { get; set; }
    public List<DeepLinkFormat>? DeepLinkFormats { get; set; }
    public List<DisplayPropertyIndexInfo>? DisplayPropertyIndexInfos { get; set; }
    public FileConfig? File { get; set; }
    public ImageConfig? Image { get; set; }
    public bool IsCatalogEnabled { get; set; }
    public List<string>? Platforms { get; set; }
    public ReviewConfig? Review { get; set; }
    public List<EntityKey>? ReviewerEntities { get; set; }
    public UserGeneratedContentSpecificConfig? UserGeneratedContent { get; set; }
}

public class CatalogItem {
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    public List<Content>? Contents { get; set; }
    public string? ContentType { get; set; }
    public DateTime? CreationDate { get; set; }
    public EntityKey? CreatorEntity { get; set; }
    public List<DeepLink>? DeepLinks { get; set; }
    public string? DefaultStackId { get; set; }
    public Dictionary<string, string>? Description { get; set; }
    public object? DisplayProperties { get; set; }
    public string? DisplayVersion { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ETag { get; set; }
    public string? Id { get; set; }
    public List<Image>? Images { get; set; }
    public bool? IsHidden { get; set; }
    public List<CatalogItemReference>? ItemReferences { get; set; }
    public Dictionary<string, KeywordSet>? Keywords { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public ModerationState? Moderation { get; set; }
    public List<string>? Platforms { get; set; }
    public CatalogPriceOptions? PriceOptions { get; set; }
    public Rating? Rating { get; set; }
    public RealMoneyPriceDetails? RealMoneyPriceDetails { get; set; }
    public DateTime? StartDate { get; set; }
    public StoreDetails? StoreDetails { get; set; }
    public List<string>? Tags { get; set; }
    public Dictionary<string, string>? Title { get; set; }
    public string? Type { get; set; }
}

public class CatalogItemReference {
    public int? Amount { get; set; }
    public string? Id { get; set; }
    public CatalogPriceOptions? PriceOptions { get; set; }
}

public class CatalogPrice {
    public List<CatalogPriceAmount>? Amounts { get; set; }
    public int? UnitAmount { get; set; }
    public double? UnitDurationInSeconds { get; set; }
}

public class CatalogPriceAmount {
    public int Amount { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class CatalogPriceAmountOverride {
    public int? FixedValue { get; set; }
    public string? ItemId { get; set; }
    public double? Multiplier { get; set; }
}

public class CatalogPriceOptions {
    public List<CatalogPrice>? Prices { get; set; }
}

public class CatalogPriceOptionsOverride {
    public List<CatalogPriceOverride>? Prices { get; set; }
}

public class CatalogPriceOverride {
    public List<CatalogPriceAmountOverride>? Amounts { get; set; }
}

public class CatalogSpecificConfig {
    public List<string>? ContentTypes { get; set; }
    public List<string>? Tags { get; set; }
}

public class CatalogView {
    public int? Count { get; set; }
    public DateTime? CreationDate { get; set; }
    public string? ETag { get; set; }
    public ViewFileFormat? FileFormat { get; set; }
    public string? Filter { get; set; }
    public string? FriendlyId { get; set; }
    public string? Id { get; set; }
    public bool? IsTitleView { get; set; }
    public string? Language { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public CatalogViewDiagnostics? LastViewDiagnostics { get; set; }
    public string? Select { get; set; }
    public string? Store { get; set; }
    public string? Url { get; set; }
}

public class CatalogViewDiagnostics {
    public DateTime? GeneratedDate { get; set; }
    public int? ItemCount { get; set; }
    public int? SizeInBytes { get; set; }
    public CatalogViewStatus? Status { get; set; }
}

public enum CatalogViewStatus {
    Unknown,
    Success,
    FileSizeExceeded,
    Error,
    StoreDoesNotExist,
    TransientError,
    PartialSuccess,
    Pending,
}

public class CategoryRatingConfig {
    public string? Name { get; set; }
}

/// <summary>
/// The version of the catalog to upload.
/// </summary>
public class CompleteVersionedCatalogUploadRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class CompleteVersionedCatalogUploadResponse : PlayFabResultCommon {
    public string? Version { get; set; }
}

public enum ConcernCategory {
    None,
    OffensiveContent,
    ChildExploitation,
    MalwareOrVirus,
    PrivacyConcerns,
    MisleadingApp,
    PoorPerformance,
    ReviewResponse,
    SpamAdvertising,
    Profanity,
}

public class Content {
    public string? Id { get; set; }
    public string? MaxClientVersion { get; set; }
    public string? MinClientVersion { get; set; }
    public List<string>? Tags { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
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
/// The item will not be published to the public catalog until the PublishItem API is called for the item.
/// </summary>
public class CreateDraftItemRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public CatalogItem? Item { get; set; }
    public bool Publish { get; set; }
}

public class CreateDraftItemResponse : PlayFabResultCommon {
    public CatalogItem? Item { get; set; }
}

/// <summary>
/// Upload URLs point to Azure Blobs; clients must follow the Microsoft Azure Storage Blob Service REST API pattern for uploading content. The response contains upload URLs and IDs for each file. The IDs and URLs returned must be added to the item metadata and committed using the CreateDraftItem or UpdateDraftItem Item APIs.
/// </summary>
public class CreateUploadUrlsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<UploadInfo>? Files { get; set; }
}

public class CreateUploadUrlsResponse : PlayFabResultCommon {
    public List<UploadUrlMetadata>? UploadUrls { get; set; }
}

/// <summary>
/// The version of the catalog from which to create the URL.
/// </summary>
public class CreateVersionedCatalogUploadURLRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class CreateVersionedCatalogUploadURLResponse : PlayFabResultCommon {
    public string? Url { get; set; }
    public string? Version { get; set; }
}

public class CreateViewRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public CatalogView? View { get; set; }
}

public class CreateViewResponse : PlayFabResultCommon {
    public CatalogView? View { get; set; }
}

public class DeepLink {
    public string? Platform { get; set; }
    public string? Url { get; set; }
}

public class DeepLinkFormat {
    public string? Format { get; set; }
    public string? Platform { get; set; }
}

public class DeleteEntityItemReviewsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteEntityItemReviewsResponse : PlayFabResultCommon {
}

/// <summary>
/// Delete an Inventory Collection by the specified Id for an Entity
/// </summary>
public class DeleteInventoryCollectionRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
}

public class DeleteInventoryCollectionResponse : PlayFabResultCommon {
}

public class DeleteInventoryItemsOperation {
    public InventoryItemReference? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will delete the entity's inventory items
/// </summary>
public class DeleteInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public InventoryItemReference? Item { get; set; }
}

public class DeleteInventoryItemsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

public class DeleteItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

public class DeleteItemResponse : PlayFabResultCommon {
}

/// <summary>
/// The version of the catalog to delete.
/// </summary>
public class DeleteVersionedCatalogRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class DeleteViewRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? FriendlyId { get; set; }
    public string? Id { get; set; }
}

public class DeleteViewResponse : PlayFabResultCommon {
}

public class DisplayPropertyIndexInfo {
    public string? Name { get; set; }
    public DisplayPropertyType? Type { get; set; }
}

public enum DisplayPropertyType {
    None,
    QueryDateTime,
    QueryDouble,
    QueryString,
    SearchString,
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

/// <summary>
/// Execute a list of Inventory Operations for an Entity
/// </summary>
public class ExecuteInventoryOperationsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<InventoryOperation>? Operations { get; set; }
}

public class ExecuteInventoryOperationsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Transfer the specified list of inventory items of an entity's container Id to another entity's container Id.
/// </summary>
public class ExecuteTransferOperationsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? GivingCollectionId { get; set; }
    public EntityKey? GivingEntity { get; set; }
    public string? GivingETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<TransferInventoryItemsOperation>? Operations { get; set; }
    public string? ReceivingCollectionId { get; set; }
    public EntityKey? ReceivingEntity { get; set; }
}

public class ExecuteTransferOperationsResponse : PlayFabResultCommon {
    public string? GivingETag { get; set; }
    public List<string>? GivingTransactionIds { get; set; }
    public string? IdempotencyId { get; set; }
    public string? OperationStatus { get; set; }
    public string? OperationToken { get; set; }
    public string? ReceivingETag { get; set; }
    public List<string>? ReceivingTransactionIds { get; set; }
}

/// <summary>
/// The version of the catalog to export.
/// </summary>
public class ExportVersionedCatalogRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class FileConfig {
    public List<string>? ContentTypes { get; set; }
    public List<string>? Tags { get; set; }
}

public class FilterOptions {
    public string? Filter { get; set; }
    public bool? IncludeAllItems { get; set; }
}

public class GetCatalogConfigRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetCatalogConfigResponse : PlayFabResultCommon {
    public CatalogConfig? Config { get; set; }
}

public class GetDraftItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

public class GetDraftItemResponse : PlayFabResultCommon {
    public CatalogItem? Item { get; set; }
}

public class GetDraftItemsRequest : PlayFabRequestCommon {
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<string>? Ids { get; set; }
}

public class GetDraftItemsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<CatalogItem>? Items { get; set; }
}

public class GetEntityDraftItemsRequest : PlayFabRequestCommon {
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Filter { get; set; }
}

public class GetEntityDraftItemsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<CatalogItem>? Items { get; set; }
}

public class GetEntityItemReviewRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

public class GetEntityItemReviewResponse : PlayFabResultCommon {
    public Review? Review { get; set; }
}

/// <summary>
/// Get a list of Inventory Collection Ids for the specified Entity
/// </summary>
public class GetInventoryCollectionIdsRequest : PlayFabRequestCommon {
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetInventoryCollectionIdsResponse : PlayFabResultCommon {
    public List<string>? CollectionIds { get; set; }
    public string? ContinuationToken { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will get the entity's inventory items. 
/// </summary>
public class GetInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Filter { get; set; }
}

public class GetInventoryItemsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public string? ETag { get; set; }
    public List<InventoryItem>? Items { get; set; }
}

/// <summary>
/// Get the status of an Inventory Operation using an OperationToken.
/// </summary>
public class GetInventoryOperationStatusRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetInventoryOperationStatusResponse : PlayFabResultCommon {
    public string? OperationStatus { get; set; }
}

/// <summary>
/// Given an item, return a set of bundles and stores containing the item.
/// </summary>
public class GetItemContainersRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

public class GetItemContainersResponse : PlayFabResultCommon {
    public List<CatalogItem>? Containers { get; set; }
    public string? ContinuationToken { get; set; }
}

public class GetItemModerationStateRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Id { get; set; }
}

public class GetItemModerationStateResponse : PlayFabResultCommon {
    public ModerationState? State { get; set; }
}

public class GetItemPublishStatusRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

public class GetItemPublishStatusResponse : PlayFabResultCommon {
    public PublishResult? Result { get; set; }
    public string? StatusMessage { get; set; }
}

public class GetItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
}

/// <summary>
/// Get item result.
/// </summary>
public class GetItemResponse : PlayFabResultCommon {
    public CatalogItem? Item { get; set; }
}

public class GetItemReviewsRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Id { get; set; }
    public string? OrderBy { get; set; }
}

public class GetItemReviewsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<Review>? Reviews { get; set; }
}

public class GetItemReviewSummaryRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Id { get; set; }
}

public class GetItemReviewSummaryResponse : PlayFabResultCommon {
    public Review? LeastFavorableReview { get; set; }
    public Review? MostFavorableReview { get; set; }
    public Rating? Rating { get; set; }
    public int ReviewsCount { get; set; }
}

public class GetItemsRequest : PlayFabRequestCommon {
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<string>? Ids { get; set; }
}

public class GetItemsResponse : PlayFabResultCommon {
    public List<CatalogItem>? Items { get; set; }
}

/// <summary>
/// Gets the access tokens for Microsoft Store authentication.
/// </summary>
public class GetMicrosoftStoreAccessTokensRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetMicrosoftStoreAccessTokensResponse : PlayFabResultCommon {
    public string? CollectionsAccessToken { get; set; }
    public required DateTime CollectionsAccessTokenExpirationDate { get; set; }
}

/// <summary>
/// Get transaction history for specified entity and collection.
/// </summary>
public class GetTransactionHistoryRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Filter { get; set; }
    public string? OrderBy { get; set; }
}

public class GetTransactionHistoryResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<Transaction>? Transactions { get; set; }
}

/// <summary>
/// The version of the catalog and the id of the item.
/// </summary>
public class GetVersionedCatalogItemRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Id { get; set; }
    public string? Version { get; set; }
}

public class GetVersionedCatalogItemResponse : PlayFabResultCommon {
    public VersionedCatalogItem? Item { get; set; }
}

/// <summary>
/// The version of the catalog from which to get the upload status.
/// </summary>
public class GetVersionedCatalogUploadStatusRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Version { get; set; }
}

public class GetVersionedCatalogUploadStatusResponse : PlayFabResultCommon {
    public string? Status { get; set; }
}

public class GetViewRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? FriendlyId { get; set; }
    public string? Id { get; set; }
}

public class GetViewResponse : PlayFabResultCommon {
    public CatalogView? View { get; set; }
}

public class GetViewsRequest : PlayFabRequestCommon {
    public string? ContinuationToken { get; set; }
    public int? Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetViewsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<CatalogView>? Views { get; set; }
}

public class GooglePlayProductPurchase {
    public string? ProductId { get; set; }
    public string? Token { get; set; }
}

public enum HelpfulnessVote {
    None,
    UnHelpful,
    Helpful,
}

public class IActionResult : PlayFabResultCommon {
}

public class Image {
    public string? Id { get; set; }
    public string? Tag { get; set; }
    public string? Type { get; set; }
    public string? Url { get; set; }
}

public class ImageConfig {
    public List<string>? Tags { get; set; }
}

public class InitialValues {
    public object? DisplayProperties { get; set; }
}

public class InventoryItem {
    public int? Amount { get; set; }
    public object? DisplayProperties { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public string? Id { get; set; }
    public string? StackId { get; set; }
    public string? Type { get; set; }
}

public class InventoryItemReference {
    public AlternateId? AlternateId { get; set; }
    public string? Id { get; set; }
    public string? StackId { get; set; }
}

public class InventoryOperation {
    public AddInventoryItemsOperation? Add { get; set; }
    public DeleteInventoryItemsOperation? Delete { get; set; }
    public PurchaseInventoryItemsOperation? Purchase { get; set; }
    public SubtractInventoryItemsOperation? Subtract { get; set; }
    public TransferInventoryItemsOperation? Transfer { get; set; }
    public UpdateInventoryItemsOperation? Update { get; set; }
}

public class KeywordSet {
    public List<string>? Values { get; set; }
}

/// <summary>
/// The list of available versioned catalogs.
/// </summary>
public class ListVersionedCatalogsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// List catalog versions.
/// </summary>
public class ListVersionedCatalogsResponse : PlayFabResultCommon {
    public List<VersionedCatalog>? VersionedCatalogs { get; set; }
}

public class ModerationState {
    public DateTime? LastModifiedDate { get; set; }
    public string? Reason { get; set; }
    public ModerationStatus? Status { get; set; }
}

public enum ModerationStatus {
    Unknown,
    AwaitingModeration,
    Approved,
    Rejected,
}

public class Permissions {
    public List<string>? SegmentIds { get; set; }
}

/// <summary>
/// The call kicks off a workflow to publish the item to the public catalog. The Publish Status API should be used to monitor the publish job.
/// </summary>
public class PublishDraftItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? Id { get; set; }
}

public class PublishDraftItemResponse : PlayFabResultCommon {
}

public enum PublishResult {
    Unknown,
    Pending,
    Succeeded,
    Failed,
    Canceled,
}

public class PurchaseInventoryItemsOperation {
    public int? Amount { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public double? DurationInSeconds { get; set; }
    public InventoryItemReference? Item { get; set; }
    public InitialValues? NewStackValues { get; set; }
    public List<PurchasePriceAmount>? PriceAmounts { get; set; }
    public string? StoreId { get; set; }
}

/// <summary>
/// Purchase a single item or bundle, paying the associated price.
/// </summary>
public class PurchaseInventoryItemsRequest : PlayFabRequestCommon {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public double? DurationInSeconds { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public InventoryItemReference? Item { get; set; }
    public InitialValues? NewStackValues { get; set; }
    public List<PurchasePriceAmount>? PriceAmounts { get; set; }
    public PurchaseOverridesInfo? PurchaseOverrides { get; set; }
    public string? StoreId { get; set; }
}

public class PurchaseInventoryItemsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

public class PurchaseOverridesInfo {
}

public class PurchasePriceAmount {
    public int Amount { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class Rating {
    public float? Average { get; set; }
    public int? Count1Star { get; set; }
    public int? Count2Star { get; set; }
    public int? Count3Star { get; set; }
    public int? Count4Star { get; set; }
    public int? Count5Star { get; set; }
    public int? TotalCount { get; set; }
}

public class RealMoneyPriceDetails {
    public Dictionary<string, int>? AppleAppStorePrices { get; set; }
    public Dictionary<string, int>? GooglePlayPrices { get; set; }
    public Dictionary<string, int>? MicrosoftStorePrices { get; set; }
    public Dictionary<string, int>? NintendoEShopPrices { get; set; }
    public Dictionary<string, int>? PlayStationStorePrices { get; set; }
    public Dictionary<string, int>? SteamPrices { get; set; }
}

/// <summary>
/// Redeem items from the Apple App Store.
/// </summary>
public class RedeemAppleAppStoreInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
    public string? Receipt { get; set; }
}

public class RedeemAppleAppStoreInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Google Play Store.
/// </summary>
public class RedeemGooglePlayInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
    public List<GooglePlayProductPurchase>? Purchases { get; set; }
}

public class RedeemGooglePlayInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Microsoft Store.
/// </summary>
public class RedeemMicrosoftStoreInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public string? CollectionsIdKey { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
    public string? XboxToken { get; set; }
}

public class RedeemMicrosoftStoreInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Nintendo EShop.
/// </summary>
public class RedeemNintendoEShopInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
    public string? NintendoServiceAccountIdToken { get; set; }
}

public class RedeemNintendoEShopInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the PlayStation Store.
/// </summary>
public class RedeemPlayStationStoreInventoryItemsRequest : PlayFabRequestCommon {
    public string? AuthorizationCode { get; set; }
    public string? CollectionId { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
    public string? RedirectUri { get; set; }
    public string? ServiceLabel { get; set; }
}

public class RedeemPlayStationStoreInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem inventory items from Steam.
/// </summary>
public class RedeemSteamInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public CountryCode? CountryCode { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<InventoryItemReference>? Items { get; set; }
}

public class RedeemSteamInventoryItemsResponse : PlayFabResultCommon {
    public List<RedemptionFailure>? Failed { get; set; }
    public List<RedemptionSuccess>? Succeeded { get; set; }
    public List<string>? TransactionIds { get; set; }
}

public class RedemptionFailure {
    public string? FailureCode { get; set; }
    public string? FailureDetails { get; set; }
    public string? MarketplaceAlternateId { get; set; }
    public string? MarketplaceTransactionId { get; set; }
}

public class RedemptionSuccess {
    public string? MarketplaceAlternateId { get; set; }
    public string? MarketplaceTransactionId { get; set; }
    public required DateTime SuccessTimestamp { get; set; }
}

public class ReportItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public ConcernCategory? ConcernCategory { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
    public string? Reason { get; set; }
}

public class ReportItemResponse : PlayFabResultCommon {
}

/// <summary>
/// Submit a report for an inappropriate review, allowing the submitting user to specify their concern.
/// </summary>
public class ReportItemReviewRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public ConcernCategory? ConcernCategory { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ItemId { get; set; }
    public string? Reason { get; set; }
    public string? ReviewId { get; set; }
}

public class ReportItemReviewResponse : PlayFabResultCommon {
}

public class Review {
    public Dictionary<string, int>? CategoryRatings { get; set; }
    public int HelpfulNegative { get; set; }
    public int HelpfulPositive { get; set; }
    public bool IsInstalled { get; set; }
    public string? ItemId { get; set; }
    public string? ItemVersion { get; set; }
    public string? Locale { get; set; }
    public int Rating { get; set; }
    public EntityKey? ReviewerEntity { get; set; }
    public string? ReviewId { get; set; }
    public string? ReviewText { get; set; }
    public required DateTime Submitted { get; set; }
    public string? Title { get; set; }
}

public class ReviewConfig {
    public List<CategoryRatingConfig>? CategoryRatings { get; set; }
}

public class ReviewItemRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Id { get; set; }
    public Review? Review { get; set; }
}

public class ReviewItemResponse : PlayFabResultCommon {
}

public class ReviewTakedown {
    public CatalogAlternateId? AlternateId { get; set; }
    public string? ItemId { get; set; }
    public string? ReviewId { get; set; }
}

public class SearchItemsRequest : PlayFabRequestCommon {
    public string? ContinuationToken { get; set; }
    public int Count { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? Filter { get; set; }
    public string? Language { get; set; }
    public string? OrderBy { get; set; }
    public string? Search { get; set; }
    public string? Select { get; set; }
    public StoreReference? Store { get; set; }
}

public class SearchItemsResponse : PlayFabResultCommon {
    public string? ContinuationToken { get; set; }
    public List<CatalogItem>? Items { get; set; }
}

public class SetItemModerationStateRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Id { get; set; }
    public string? Reason { get; set; }
    public ModerationStatus? Status { get; set; }
}

public class SetItemModerationStateResponse : PlayFabResultCommon {
}

public class StoreDetails {
    public FilterOptions? FilterOptions { get; set; }
    public Permissions? Permissions { get; set; }
    public CatalogPriceOptionsOverride? PriceOptionsOverride { get; set; }
}

public class StoreReference {
    public CatalogAlternateId? AlternateId { get; set; }
    public string? Id { get; set; }
}

public class SubmitItemReviewVoteRequest : PlayFabRequestCommon {
    public CatalogAlternateId? AlternateId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ItemId { get; set; }
    public string? ReviewId { get; set; }
    public HelpfulnessVote? Vote { get; set; }
}

public class SubmitItemReviewVoteResponse : PlayFabResultCommon {
}

public class SubtractInventoryItemsOperation {
    public int? Amount { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public double? DurationInSeconds { get; set; }
    public InventoryItemReference? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will subtract the specified inventory items. 
/// </summary>
public class SubtractInventoryItemsRequest : PlayFabRequestCommon {
    public int? Amount { get; set; }
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public double? DurationInSeconds { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public InventoryItemReference? Item { get; set; }
}

public class SubtractInventoryItemsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Submit a request to takedown one or more reviews, removing them from public view. Authors will still be able to see their reviews after being taken down.
/// </summary>
public class TakedownItemReviewsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<ReviewTakedown>? Reviews { get; set; }
}

public class TakedownItemReviewsResponse : PlayFabResultCommon {
}

public class Transaction {
    public string? ApiName { get; set; }
    public TransactionClawbackDetails? ClawbackDetails { get; set; }
    public CountryCode? CountryCode { get; set; }
    public string? ItemType { get; set; }
    public List<TransactionOperation>? Operations { get; set; }
    public string? OperationType { get; set; }
    public TransactionPurchaseDetails? PurchaseDetails { get; set; }
    public TransactionRedeemDetails? RedeemDetails { get; set; }
    public required DateTime Timestamp { get; set; }
    public string? TransactionId { get; set; }
    public TransactionTransferDetails? TransferDetails { get; set; }
}

public class TransactionClawbackDetails {
    public string? TransactionIdClawedback { get; set; }
}

public class TransactionOperation {
    public int? Amount { get; set; }
    public double? DurationInSeconds { get; set; }
    public string? ItemFriendlyId { get; set; }
    public string? ItemId { get; set; }
    public string? ItemType { get; set; }
    public string? StackId { get; set; }
    public string? Type { get; set; }
}

public class TransactionPurchaseDetails {
    public string? StoreFriendlyId { get; set; }
    public string? StoreId { get; set; }
}

public class TransactionRedeemDetails {
    public string? Marketplace { get; set; }
    public string? MarketplaceTransactionId { get; set; }
    public string? OfferId { get; set; }
}

public class TransactionTransferDetails {
    public string? GivingCollectionId { get; set; }
    public EntityKey? GivingEntity { get; set; }
    public string? ReceivingCollectionId { get; set; }
    public EntityKey? ReceivingEntity { get; set; }
    public string? TransferId { get; set; }
}

public class TransferInventoryItemsOperation {
    public int? Amount { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public InventoryItemReference? GivingItem { get; set; }
    public InitialValues? NewStackValues { get; set; }
    public InventoryItemReference? ReceivingItem { get; set; }
}

/// <summary>
/// Transfer the specified inventory items of an entity's container Id to another entity's container Id.
/// </summary>
public class TransferInventoryItemsRequest : PlayFabRequestCommon {
    public int? Amount { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool DeleteEmptyStacks { get; set; }
    public string? GivingCollectionId { get; set; }
    public EntityKey? GivingEntity { get; set; }
    public string? GivingETag { get; set; }
    public InventoryItemReference? GivingItem { get; set; }
    public string? IdempotencyId { get; set; }
    public InitialValues? NewStackValues { get; set; }
    public string? ReceivingCollectionId { get; set; }
    public EntityKey? ReceivingEntity { get; set; }
    public InventoryItemReference? ReceivingItem { get; set; }
}

public class TransferInventoryItemsResponse : PlayFabResultCommon {
    public string? GivingETag { get; set; }
    public List<string>? GivingTransactionIds { get; set; }
    public string? IdempotencyId { get; set; }
    public string? OperationStatus { get; set; }
    public string? OperationToken { get; set; }
    public List<string>? ReceivingTransactionIds { get; set; }
}

public class UpdateCatalogConfigRequest : PlayFabRequestCommon {
    public CatalogConfig? Config { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UpdateCatalogConfigResponse : PlayFabResultCommon {
}

public class UpdateDraftItemRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public CatalogItem? Item { get; set; }
    public bool Publish { get; set; }
}

public class UpdateDraftItemResponse : PlayFabResultCommon {
    public CatalogItem? Item { get; set; }
}

public class UpdateInventoryItemsOperation {
    public InventoryItem? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will update the entity's inventory items
/// </summary>
public class UpdateInventoryItemsRequest : PlayFabRequestCommon {
    public string? CollectionId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public InventoryItem? Item { get; set; }
}

public class UpdateInventoryItemsResponse : PlayFabResultCommon {
    public string? ETag { get; set; }
    public string? IdempotencyId { get; set; }
    public List<string>? TransactionIds { get; set; }
}

public class UpdateViewRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public CatalogView? View { get; set; }
}

public class UpdateViewResponse : PlayFabResultCommon {
    public CatalogView? View { get; set; }
}

public class UploadInfo {
    public string? FileName { get; set; }
}

public class UploadUrlMetadata {
    public string? FileName { get; set; }
    public string? Id { get; set; }
    public string? Url { get; set; }
}

public class UserGeneratedContentSpecificConfig {
    public List<string>? ContentTypes { get; set; }
    public List<string>? Tags { get; set; }
}

public class VersionedCatalog {
    public string? Version { get; set; }
}

public class VersionedCatalogItem {
    public List<VersionedCatalogItemAlternateId>? AlternateIds { get; set; }
    public string? ContentType { get; set; }
    public DateTime? CreationDate { get; set; }
    public VersionedCatalogItemCreatorEntity? CreatorEntity { get; set; }
    public string? DefaultStackId { get; set; }
    public Dictionary<string, string>? Description { get; set; }
    public DateTime? EndDate { get; set; }
    public string? FriendlyId { get; set; }
    public string? Id { get; set; }
    public bool? IsHidden { get; set; }
    public bool? IsTest { get; set; }
    public List<VersionedCatalogItemReference>? ItemReferences { get; set; }
    public Dictionary<string, VersionedCatalogItemKeywordSet>? Keywords { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public VersionedCatalogItemPayoutInfo? PayoutInfo { get; set; }
    public List<string>? Platforms { get; set; }
    public VersionedCatalogItemPrice? Price { get; set; }
    public VersionedCatalogItemRealMoneyPriceDetails? RealMoneyPriceDetails { get; set; }
    public DateTime? StartDate { get; set; }
    public VersionedCatalogItemStoreDetails? StoreDetails { get; set; }
    public List<string>? Tags { get; set; }
    public Dictionary<string, string>? Title { get; set; }
    public bool? TitleExclusive { get; set; }
    public string? Type { get; set; }
}

public class VersionedCatalogItemAlternateId {
    public string? Type { get; set; }
    public string? Value { get; set; }
}

public class VersionedCatalogItemCreatorEntity {
    public string? Id { get; set; }
    public string? Type { get; set; }
}

public class VersionedCatalogItemFilterOptions {
    public string? Filter { get; set; }
    public bool? IncludeAllItems { get; set; }
}

public class VersionedCatalogItemKeywordSet {
    public List<string>? Values { get; set; }
}

public class VersionedCatalogItemOverride {
    public double? FixedValue { get; set; }
    public string? ItemId { get; set; }
    public double? Multiplier { get; set; }
}

public class VersionedCatalogItemPayoutInfo {
    public string? AccountSellerId { get; set; }
    public string? TaxCode { get; set; }
    public string? Uaid { get; set; }
}

public class VersionedCatalogItemPermissions {
    public List<string>? SegmentIds { get; set; }
}

public class VersionedCatalogItemPrice {
    public double? PayoutAmount { get; set; }
    public List<VersionedCatalogItemPriceInstance>? Prices { get; set; }
    public int? Sort { get; set; }
}

public class VersionedCatalogItemPriceAmount {
    public int? Amount { get; set; }
    public bool? IsFromNamespace { get; set; }
    public string? ItemId { get; set; }
    public string? StackId { get; set; }
}

public class VersionedCatalogItemPriceInstance {
    public List<VersionedCatalogItemPriceAmount>? Amounts { get; set; }
    public int? UnitAmount { get; set; }
    public double? UnitDurationInSeconds { get; set; }
}

public class VersionedCatalogItemPriceOverride {
    public List<VersionedCatalogItemOverride>? Amounts { get; set; }
}

public class VersionedCatalogItemPricesOverride {
    public VersionedCatalogItemOverride? PayoutAmount { get; set; }
    public List<VersionedCatalogItemPriceOverride>? Prices { get; set; }
}

public class VersionedCatalogItemRealMoneyPriceDetails {
    public Dictionary<string, int>? AppleAppStorePrices { get; set; }
    public Dictionary<string, int>? GooglePlayPrices { get; set; }
    public Dictionary<string, int>? MicrosoftStorePrices { get; set; }
    public Dictionary<string, int>? NintendoEShopPrices { get; set; }
    public Dictionary<string, int>? PlayStationStorePrices { get; set; }
    public Dictionary<string, int>? SteamPrices { get; set; }
}

public class VersionedCatalogItemReference {
    public int? Amount { get; set; }
    public double? DurationInSeconds { get; set; }
    public string? Id { get; set; }
    public bool? IsFromNamespace { get; set; }
    public VersionedCatalogItemPrice? Price { get; set; }
}

public class VersionedCatalogItemStoreDetails {
    public VersionedCatalogItemFilterOptions? FilterOptions { get; set; }
    public VersionedCatalogItemPermissions? Permissions { get; set; }
    public VersionedCatalogItemPricesOverride? PricesOverride { get; set; }
}

public enum ViewFileFormat {
    Unknown,
    Json,
    JsonLines,
    GZippedJson,
    GZippedJsonLines,
}

