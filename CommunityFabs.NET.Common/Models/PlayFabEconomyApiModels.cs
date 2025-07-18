using CommunityFabs.NET.Common.Http;

namespace CommunityFabs.NET.Common.Models.Economy;

public class AddInventoryItemsOperation {
    /// <summary>
    /// The amount to add to the current item amount.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The duration to add to the current item expiration date.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The inventory item the operation applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this operation.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will add the specified inventory items.
/// </summary>
public class AddInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The amount to add for the current item.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The duration to add to the current item expiration date.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The inventory item the request applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this request.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
}

public class AddInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

public class AlternateId {
    /// <summary>
    /// Type of the alternate ID.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Value of the alternate ID.
    /// </summary>
    public string? Value { get; set; }
}

public class CatalogAlternateId {
    /// <summary>
    /// Type of the alternate ID.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Value of the alternate ID.
    /// </summary>
    public string? Value { get; set; }
}

public class CatalogConfig {
    /// <summary>
    /// A list of player entity keys that will have admin permissions. There is a maximum of 64 entities that can be added.
    /// </summary>
    public List<EntityKey>? AdminEntities { get; set; }
    /// <summary>
    /// The set of configuration that only applies to catalog items.
    /// </summary>
    public CatalogSpecificConfig? Catalog { get; set; }
    /// <summary>
    /// A list of deep link formats. Up to 10 can be added.
    /// </summary>
    public List<DeepLinkFormat>? DeepLinkFormats { get; set; }
    /// <summary>
    /// A list of display properties to index. Up to 5 mappings can be added per Display Property Type. More info on display
    /// properties can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/content-types-tags-and-properties#displaypr
    /// operties
    /// </summary>
    public List<DisplayPropertyIndexInfo>? DisplayPropertyIndexInfos { get; set; }
    /// <summary>
    /// The set of configuration that only applies to Files.
    /// </summary>
    public FileConfig? File { get; set; }
    /// <summary>
    /// The set of configuration that only applies to Images.
    /// </summary>
    public ImageConfig? Image { get; set; }
    /// <summary>
    /// Flag defining whether catalog is enabled.
    /// </summary>
    public bool IsCatalogEnabled { get; set; }
    /// <summary>
    /// A list of Platforms that can be applied to catalog items. Each platform can have a maximum character length of 40 and
    /// up to 128 platforms can be listed.
    /// </summary>
    public List<string>? Platforms { get; set; }
    /// <summary>
    /// The set of configuration that only applies to Ratings and Reviews.
    /// </summary>
    public ReviewConfig? Review { get; set; }
    /// <summary>
    /// A set of player entity keys that are allowed to review content. There is a maximum of 128 entities that can be added.
    /// </summary>
    public List<EntityKey>? ReviewerEntities { get; set; }
    /// <summary>
    /// The set of configuration that only applies to user generated contents.
    /// </summary>
    public UserGeneratedContentSpecificConfig? UserGeneratedContent { get; set; }
}

public class CatalogItem {
    /// <summary>
    /// The alternate IDs associated with this item. An alternate ID can be set to 'FriendlyId' or any of the supported
    /// marketplace names.
    /// </summary>
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    /// <summary>
    /// The set of content/files associated with this item. Up to 100 files can be added to an item.
    /// </summary>
    public List<Content>? Contents { get; set; }
    /// <summary>
    /// The client-defined type of the item.
    /// </summary>
    public string? ContentType { get; set; }
    /// <summary>
    /// The date and time when this item was created.
    /// </summary>
    public DateTime? CreationDate { get; set; }
    /// <summary>
    /// The ID of the creator of this catalog item.
    /// </summary>
    public EntityKey? CreatorEntity { get; set; }
    /// <summary>
    /// The set of platform specific deep links for this item.
    /// </summary>
    public List<DeepLink>? DeepLinks { get; set; }
    /// <summary>
    /// The Stack Id that will be used as default for this item in Inventory when an explicit one is not provided. This
    /// DefaultStackId can be a static stack id or '{guid}', which will generate a unique stack id for the item. If null,
    /// Inventory's default stack id will be used.
    /// </summary>
    public string? DefaultStackId { get; set; }
    /// <summary>
    /// A dictionary of localized descriptions. Key is language code and localized string is the value. The NEUTRAL locale is
    /// required. Descriptions have a 10000 character limit per country code.
    /// </summary>
    public Dictionary<string, string>? Description { get; set; }
    /// <summary>
    /// Game specific properties for display purposes. This is an arbitrary JSON blob. The Display Properties field has a 10000
    /// byte limit per item.
    /// </summary>
    public object? DisplayProperties { get; set; }
    /// <summary>
    /// The user provided version of the item for display purposes. Maximum character length of 50.
    /// </summary>
    public string? DisplayVersion { get; set; }
    /// <summary>
    /// The date of when the item will cease to be available. If not provided then the product will be available indefinitely.
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// The current ETag value that can be used for optimistic concurrency in the If-None-Match header.
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The images associated with this item. Images can be thumbnails or screenshots. Up to 100 images can be added to an
    /// item. Only .png, .jpg, .gif, and .bmp file types can be uploaded
    /// </summary>
    public List<Image>? Images { get; set; }
    /// <summary>
    /// Indicates if the item is hidden.
    /// </summary>
    public bool? IsHidden { get; set; }
    /// <summary>
    /// The item references associated with this item. For example, the items in a Bundle/Store/Subscription. Every item can
    /// have up to 50 item references.
    /// </summary>
    public List<CatalogItemReference>? ItemReferences { get; set; }
    /// <summary>
    /// A dictionary of localized keywords. Key is language code and localized list of keywords is the value. Keywords have a
    /// 50 character limit per keyword and up to 32 keywords can be added per country code.
    /// </summary>
    public Dictionary<string, KeywordSet>? Keywords { get; set; }
    /// <summary>
    /// The date and time this item was last updated.
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }
    /// <summary>
    /// The moderation state for this item.
    /// </summary>
    public ModerationState? Moderation { get; set; }
    /// <summary>
    /// The platforms supported by this item.
    /// </summary>
    public List<string>? Platforms { get; set; }
    /// <summary>
    /// The prices the item can be purchased for.
    /// </summary>
    public CatalogPriceOptions? PriceOptions { get; set; }
    /// <summary>
    /// Rating summary for this item.
    /// </summary>
    public Rating? Rating { get; set; }
    /// <summary>
    /// The real price the item was purchased for per marketplace.
    /// </summary>
    public RealMoneyPriceDetails? RealMoneyPriceDetails { get; set; }
    /// <summary>
    /// The date of when the item will be available. If not provided then the product will appear immediately.
    /// </summary>
    public DateTime? StartDate { get; set; }
    /// <summary>
    /// Optional details for stores items.
    /// </summary>
    public StoreDetails? StoreDetails { get; set; }
    /// <summary>
    /// The list of tags that are associated with this item. Up to 32 tags can be added to an item.
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// A dictionary of localized titles. Key is language code and localized string is the value. The NEUTRAL locale is
    /// required. Titles have a 512 character limit per country code.
    /// </summary>
    public Dictionary<string, string>? Title { get; set; }
    /// <summary>
    /// The high-level type of the item. The following item types are supported: bundle, catalogItem, currency, store, ugc,
    /// subscription.
    /// </summary>
    public string? Type { get; set; }
}

public class CatalogItemReference {
    /// <summary>
    /// The amount of the catalog item.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The unique ID of the catalog item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The prices the catalog item can be purchased for.
    /// </summary>
    public CatalogPriceOptions? PriceOptions { get; set; }
}

public class CatalogPrice {
    /// <summary>
    /// The amounts of the catalog item price. Each price can have up to 15 item amounts.
    /// </summary>
    public List<CatalogPriceAmount>? Amounts { get; set; }
    /// <summary>
    /// The per-unit amount this price can be used to purchase.
    /// </summary>
    public int? UnitAmount { get; set; }
    /// <summary>
    /// The per-unit duration this price can be used to purchase. The maximum duration is 100 years.
    /// </summary>
    public double? UnitDurationInSeconds { get; set; }
}

public class CatalogPriceAmount {
    /// <summary>
    /// The amount of the price.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// The Item Id of the price.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Stack Id the client expects to use to purchase the item.
    /// </summary>
    public string? StackId { get; set; }
}

public class CatalogPriceAmountOverride {
    /// <summary>
    /// The exact value that should be utilized in the override.
    /// </summary>
    public int? FixedValue { get; set; }
    /// <summary>
    /// The id of the item this override should utilize.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The multiplier that will be applied to the base Catalog value to determine what value should be utilized in the
    /// override.
    /// </summary>
    public double? Multiplier { get; set; }
}

public class CatalogPriceOptions {
    /// <summary>
    /// Prices of the catalog item. An item can have up to 15 prices
    /// </summary>
    public List<CatalogPrice>? Prices { get; set; }
}

public class CatalogPriceOptionsOverride {
    /// <summary>
    /// The prices utilized in the override.
    /// </summary>
    public List<CatalogPriceOverride>? Prices { get; set; }
}

public class CatalogPriceOverride {
    /// <summary>
    /// The currency amounts utilized in the override for a singular price.
    /// </summary>
    public List<CatalogPriceAmountOverride>? Amounts { get; set; }
}

public class CatalogSpecificConfig {
    /// <summary>
    /// The set of content types that will be used for validation. Each content type can have a maximum character length of 40
    /// and up to 128 types can be listed.
    /// </summary>
    public List<string>? ContentTypes { get; set; }
    /// <summary>
    /// The set of tags that will be used for validation. Each tag can have a maximum character length of 32 and up to 1024
    /// tags can be listed.
    /// </summary>
    public List<string>? Tags { get; set; }
}

public class CatalogView {
    /// <summary>
    /// Number of items to retrieve. If null, all applicable items are returned.
    /// </summary>
    public int? Count { get; set; }
    /// <summary>
    /// The date and time when this view was created.
    /// </summary>
    public DateTime? CreationDate { get; set; }
    /// <summary>
    /// The current ETag value that can be used for optimistic concurrency.
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The format to use when exporting the view file. Supported file formats are: Json, JsonLines, GZippedJson,
    /// GZippedJsonLines
    /// </summary>
    public ViewFileFormat? FileFormat { get; set; }
    /// <summary>
    /// An OData filter used to refine the search query.
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// An optional alternate friendly ID associated with this view.
    /// </summary>
    public string? FriendlyId { get; set; }
    /// <summary>
    /// The unique ID of the view.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Indicates whether the view should be generated for title use or for public use.
    /// </summary>
    public bool? IsTitleView { get; set; }
    /// <summary>
    /// The localized languages to query and retreive, separated by commas (,).
    /// </summary>
    public string? Language { get; set; }
    /// <summary>
    /// The date and time this view was last updated.
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }
    /// <summary>
    /// Diagnostic information from the last time the view was generated.
    /// </summary>
    public CatalogViewDiagnostics? LastViewDiagnostics { get; set; }
    /// <summary>
    /// An OData select query option used to augment the search results. If not defined, the default search result metadata
    /// will be returned.
    /// </summary>
    public string? Select { get; set; }
    /// <summary>
    /// The store to restrict the search request to.
    /// </summary>
    public string? Store { get; set; }
    /// <summary>
    /// The URL of the view file.
    /// </summary>
    public string? Url { get; set; }
}

public class CatalogViewDiagnostics {
    /// <summary>
    /// The last date and time when this view was generated.
    /// </summary>
    public DateTime? GeneratedDate { get; set; }
    /// <summary>
    /// The last count of items included in the view.
    /// </summary>
    public int? ItemCount { get; set; }
    /// <summary>
    /// The last size of the view in bytes.
    /// </summary>
    public int? SizeInBytes { get; set; }
    /// <summary>
    /// The last status of the view.
    /// </summary>
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
    /// <summary>
    /// Name of the category.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// The version of the catalog to upload.
/// </summary>
public class CompleteVersionedCatalogUploadRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class CompleteVersionedCatalogUploadResponse : PlayFabResultCommon {
    /// <summary>
    /// Version of the catalog.
    /// </summary>
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
    /// <summary>
    /// The content unique ID.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The maximum client version that this content is compatible with. Client Versions can be up to 3 segments separated by
    /// periods(.) and each segment can have a maximum value of 65535.
    /// </summary>
    public string? MaxClientVersion { get; set; }
    /// <summary>
    /// The minimum client version that this content is compatible with. Client Versions can be up to 3 segments separated by
    /// periods(.) and each segment can have a maximum value of 65535.
    /// </summary>
    public string? MinClientVersion { get; set; }
    /// <summary>
    /// The list of tags that are associated with this content. Tags must be defined in the Catalog Config before being used in
    /// content.
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// The client-defined type of the content. Content Types must be defined in the Catalog Config before being used.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// The Azure CDN URL for retrieval of the catalog item binary content.
    /// </summary>
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
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Metadata describing the new catalog item to be created.
    /// </summary>
    public CatalogItem? Item { get; set; }
    /// <summary>
    /// Whether the item should be published immediately. This value is optional, defaults to false.
    /// </summary>
    public bool Publish { get; set; }
}

public class CreateDraftItemResponse : PlayFabResultCommon {
    /// <summary>
    /// Updated metadata describing the catalog item just created.
    /// </summary>
    public CatalogItem? Item { get; set; }
}

/// <summary>
/// Upload URLs point to Azure Blobs; clients must follow the Microsoft Azure Storage Blob Service REST API pattern for
/// uploading content. The response contains upload URLs and IDs for each file. The IDs and URLs returned must be added to
/// the item metadata and committed using the CreateDraftItem or UpdateDraftItem Item APIs.
/// </summary>
public class CreateUploadUrlsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description of the files to be uploaded by the client.
    /// </summary>
    public List<UploadInfo>? Files { get; set; }
}

public class CreateUploadUrlsResponse : PlayFabResultCommon {
    /// <summary>
    /// List of URLs metadata for the files to be uploaded by the client.
    /// </summary>
    public List<UploadUrlMetadata>? UploadUrls { get; set; }
}

/// <summary>
/// The version of the catalog from which to create the URL.
/// </summary>
public class CreateVersionedCatalogUploadURLRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class CreateVersionedCatalogUploadURLResponse : PlayFabResultCommon {
    /// <summary>
    /// Write-only Url for uploading the versioned catalog.
    /// </summary>
    public string? Url { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class CreateViewRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Metadata describing the new catalog view to be created.
    /// </summary>
    public CatalogView? View { get; set; }
}

public class CreateViewResponse : PlayFabResultCommon {
    /// <summary>
    /// Updated metadata describing the catalog view just created.
    /// </summary>
    public CatalogView? View { get; set; }
}

public class DeepLink {
    /// <summary>
    /// Target platform for this deep link.
    /// </summary>
    public string? Platform { get; set; }
    /// <summary>
    /// The deep link for this platform.
    /// </summary>
    public string? Url { get; set; }
}

public class DeepLinkFormat {
    /// <summary>
    /// The format of the deep link to return. The format should contain '{id}' to represent where the item ID should be placed.
    /// </summary>
    public string? Format { get; set; }
    /// <summary>
    /// The target platform for the deep link.
    /// </summary>
    public string? Platform { get; set; }
}

public class DeleteEntityItemReviewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteEntityItemReviewsResponse : PlayFabResultCommon {
}

/// <summary>
/// Delete an Inventory Collection by the specified Id for an Entity
/// </summary>
public class DeleteInventoryCollectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The inventory collection id the request applies to.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity the request is about. Set to the caller by default.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
}

public class DeleteInventoryCollectionResponse : PlayFabResultCommon {
}

public class DeleteInventoryItemsOperation {
    /// <summary>
    /// The inventory item the operation applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will delete the entity's inventory items
/// </summary>
public class DeleteInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The inventory item the request applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
}

public class DeleteInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources.
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

public class DeleteItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class DeleteItemResponse : PlayFabResultCommon {
}

/// <summary>
/// The version of the catalog to delete.
/// </summary>
public class DeleteVersionedCatalogRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class DeleteViewRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Friendly ID associated with the view. Mutually exclusive with Id.
    /// </summary>
    public string? FriendlyId { get; set; }
    /// <summary>
    /// The unique ID of the item. Mutually exclusive with FriendlyId.
    /// </summary>
    public string? Id { get; set; }
}

public class DeleteViewResponse : PlayFabResultCommon {
}

public class DisplayPropertyIndexInfo {
    /// <summary>
    /// The property name in the 'DisplayProperties' property to be indexed.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The type of the property to be indexed.
    /// </summary>
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

/// <summary>
/// Execute a list of Inventory Operations for an Entity
/// </summary>
public class ExecuteInventoryOperationsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The operations to run transactionally. The operations will be executed in-order sequentially and will succeed or fail
    /// as a batch. Up to 50 operations can be added.
    /// </summary>
    public List<InventoryOperation>? Operations { get; set; }
}

public class ExecuteInventoryOperationsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of the transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Transfer the specified list of inventory items of an entity's container Id to another entity's container Id.
/// </summary>
public class ExecuteTransferOperationsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The inventory collection id the request is transferring from. (Default="default")
    /// </summary>
    public string? GivingCollectionId { get; set; }
    /// <summary>
    /// The entity the request is transferring from. Set to the caller by default.
    /// </summary>
    public EntityKey? GivingEntity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? GivingETag { get; set; }
    /// <summary>
    /// The idempotency id for the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The transfer operations to run transactionally. The operations will be executed in-order sequentially and will succeed
    /// or fail as a batch. Up to 50 operations can be added.
    /// </summary>
    public List<TransferInventoryItemsOperation>? Operations { get; set; }
    /// <summary>
    /// The inventory collection id the request is transferring to. (Default="default")
    /// </summary>
    public string? ReceivingCollectionId { get; set; }
    /// <summary>
    /// The entity the request is transferring to. Set to the caller by default.
    /// </summary>
    public EntityKey? ReceivingEntity { get; set; }
}

public class ExecuteTransferOperationsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources (before transferring from). This value will be empty if
    /// the operation has not completed yet. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? GivingETag { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request's giving action.
    /// </summary>
    public List<string>? GivingTransactionIds { get; set; }
    /// <summary>
    /// The Idempotency ID for this request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The transfer operation status. Possible values are 'InProgress' or 'Completed'. If the operation has completed, the
    /// response code will be 200. Otherwise, it will be 202.
    /// </summary>
    public string? OperationStatus { get; set; }
    /// <summary>
    /// The token that can be used to get the status of the transfer operation. This will only have a value if OperationStatus
    /// is 'InProgress'.
    /// </summary>
    public string? OperationToken { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources (before transferring to). This value will be empty if
    /// the operation has not completed yet.
    /// </summary>
    public string? ReceivingETag { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request's receiving action.
    /// </summary>
    public List<string>? ReceivingTransactionIds { get; set; }
}

/// <summary>
/// The version of the catalog to export.
/// </summary>
public class ExportVersionedCatalogRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class FileConfig {
    /// <summary>
    /// The set of content types that will be used for validation. Each content type can have a maximum character length of 40
    /// and up to 128 types can be listed.
    /// </summary>
    public List<string>? ContentTypes { get; set; }
    /// <summary>
    /// The set of tags that will be used for validation. Each tag can have a maximum character length of 32 and up to 1024
    /// tags can be listed.
    /// </summary>
    public List<string>? Tags { get; set; }
}

public class FilterOptions {
    /// <summary>
    /// The OData filter utilized. Mutually exclusive with 'IncludeAllItems'. More info about Filter Complexity limits can be
    /// found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/search#limits
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// The flag that overrides the filter and allows for returning all catalog items. Mutually exclusive with 'Filter'.
    /// </summary>
    public bool? IncludeAllItems { get; set; }
}

public class GetCatalogConfigRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetCatalogConfigResponse : PlayFabResultCommon {
    /// <summary>
    /// The catalog configuration.
    /// </summary>
    public CatalogConfig? Config { get; set; }
}

public class GetDraftItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetDraftItemResponse : PlayFabResultCommon {
    /// <summary>
    /// Full metadata of the catalog item requested.
    /// </summary>
    public CatalogItem? Item { get; set; }
}

public class GetDraftItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of item alternate IDs.
    /// </summary>
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items created by the caller, if any are available. Should be null on
    /// initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Default value is 10.
    /// </summary>
    public int? Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// List of Item Ids.
    /// </summary>
    public List<string>? Ids { get; set; }
}

public class GetDraftItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// A set of items created by the entity.
    /// </summary>
    public List<CatalogItem>? Items { get; set; }
}

public class GetEntityDraftItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items created by the caller, if any are available. Should be null on
    /// initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Default value is 10.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// OData Filter to refine the items returned. CatalogItem properties 'type' can be used in the filter. For example: "type
    /// eq 'ugc'"
    /// </summary>
    public string? Filter { get; set; }
}

public class GetEntityDraftItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// A set of items created by the entity.
    /// </summary>
    public List<CatalogItem>? Items { get; set; }
}

public class GetEntityItemReviewRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetEntityItemReviewResponse : PlayFabResultCommon {
    /// <summary>
    /// The review the entity submitted for the requested item.
    /// </summary>
    public Review? Review { get; set; }
}

/// <summary>
/// Get a list of Inventory Collection Ids for the specified Entity
/// </summary>
public class GetInventoryCollectionIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of collection ids, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. The default value is 10
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity the request is about. Set to the caller by default.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetInventoryCollectionIdsResponse : PlayFabResultCommon {
    /// <summary>
    /// The requested inventory collection ids.
    /// </summary>
    public List<string>? CollectionIds { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of collection ids, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will get the entity's inventory items.
/// </summary>
public class GetInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items in the inventory, if any are available. Should be null on
    /// initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Maximum page size is 50. The default value is 10
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// OData Filter to refine the items returned. InventoryItem properties 'type', 'id', and 'stackId' can be used in the
    /// filter. For example: "type eq 'currency'"
    /// </summary>
    public string? Filter { get; set; }
}

public class GetInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The requested inventory items.
    /// </summary>
    public List<InventoryItem>? Items { get; set; }
}

/// <summary>
/// Get the status of an Inventory Operation using an OperationToken.
/// </summary>
public class GetInventoryOperationStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetInventoryOperationStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// The inventory operation status.
    /// </summary>
    public string? OperationStatus { get; set; }
}

/// <summary>
/// Given an item, return a set of bundles and stores containing the item.
/// </summary>
public class GetItemContainersRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items in the inventory, if any are available. Should be null on
    /// initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Default value is 10.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetItemContainersResponse : PlayFabResultCommon {
    /// <summary>
    /// List of Bundles and Stores containing the requested items.
    /// </summary>
    public List<CatalogItem>? Containers { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
}

public class GetItemModerationStateRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetItemModerationStateResponse : PlayFabResultCommon {
    /// <summary>
    /// The current moderation state for the requested item.
    /// </summary>
    public ModerationState? State { get; set; }
}

public class GetItemPublishStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetItemPublishStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// High level status of the published item.
    /// </summary>
    public PublishResult? Result { get; set; }
    /// <summary>
    /// Descriptive message about the current status of the publish.
    /// </summary>
    public string? StatusMessage { get; set; }
}

public class GetItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

/// <summary>
/// Get item result.
/// </summary>
public class GetItemResponse : PlayFabResultCommon {
    /// <summary>
    /// The item result.
    /// </summary>
    public CatalogItem? Item { get; set; }
}

public class GetItemReviewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Default value is 10.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// An OData orderBy used to order the results of the query. Possible values are Helpfulness, Rating, and Submitted (For
    /// example: "Submitted desc")
    /// </summary>
    public string? OrderBy { get; set; }
}

public class GetItemReviewsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The paginated set of results.
    /// </summary>
    public List<Review>? Reviews { get; set; }
}

public class GetItemReviewSummaryRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
}

public class GetItemReviewSummaryResponse : PlayFabResultCommon {
    /// <summary>
    /// The least favorable review for this item.
    /// </summary>
    public Review? LeastFavorableReview { get; set; }
    /// <summary>
    /// The most favorable review for this item.
    /// </summary>
    public Review? MostFavorableReview { get; set; }
    /// <summary>
    /// The summary of ratings associated with this item.
    /// </summary>
    public Rating? Rating { get; set; }
    /// <summary>
    /// The total number of reviews associated with this item.
    /// </summary>
    public int ReviewsCount { get; set; }
}

public class GetItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of item alternate IDs.
    /// </summary>
    public List<CatalogAlternateId>? AlternateIds { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// List of Item Ids.
    /// </summary>
    public List<string>? Ids { get; set; }
}

public class GetItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// Metadata of set of items.
    /// </summary>
    public List<CatalogItem>? Items { get; set; }
}

/// <summary>
/// Gets the access tokens for Microsoft Store authentication.
/// </summary>
public class GetMicrosoftStoreAccessTokensRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetMicrosoftStoreAccessTokensResponse : PlayFabResultCommon {
    /// <summary>
    /// The collections access token for calling https://onestore.microsoft.com/b2b/keys/create/collections to obtain a
    /// CollectionsIdKey for the user
    /// </summary>
    public string? CollectionsAccessToken { get; set; }
    /// <summary>
    /// The date the collections access token expires
    /// </summary>
    public required DateTime CollectionsAccessTokenExpirationDate { get; set; }
}

/// <summary>
/// Get transaction history for specified entity and collection.
/// </summary>
public class GetTransactionHistoryRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available. Should be null on initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. The default value is 10
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// An OData filter used to refine the TransactionHistory. Transaction properties 'timestamp', 'transactionid', 'apiname'
    /// and 'operationtype' can be used in the filter. Properties 'transactionid', 'apiname', and 'operationtype' cannot be
    /// used together in a single request. The 'timestamp' property can be combined with 'apiname' or 'operationtype' in a
    /// single request. For example: "timestamp ge 2023-06-20T23:30Z" or "transactionid eq '10'" or "(timestamp ge
    /// 2023-06-20T23:30Z) and (apiname eq 'AddInventoryItems')". By default, a 6 month timespan from the current date is used.
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// An OData orderby to order TransactionHistory results. The only supported values are 'timestamp asc' or 'timestamp
    /// desc'. Default orderby is 'timestamp asc'
    /// </summary>
    public string? OrderBy { get; set; }
}

public class GetTransactionHistoryResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available. Should be null on initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The requested inventory transactions.
    /// </summary>
    public List<Transaction>? Transactions { get; set; }
}

/// <summary>
/// The version of the catalog and the id of the item.
/// </summary>
public class GetVersionedCatalogItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Id of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class GetVersionedCatalogItemResponse : PlayFabResultCommon {
    /// <summary>
    /// The versioned catalog item.
    /// </summary>
    public VersionedCatalogItem? Item { get; set; }
}

/// <summary>
/// The version of the catalog from which to get the upload status.
/// </summary>
public class GetVersionedCatalogUploadStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class GetVersionedCatalogUploadStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// Status of the upload.
    /// </summary>
    public string? Status { get; set; }
}

public class GetViewRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Friendly ID associated with the view. Mutually exclusive with Id.
    /// </summary>
    public string? FriendlyId { get; set; }
    /// <summary>
    /// The unique ID of the view. Mutually exclusive with FriendlyId.
    /// </summary>
    public string? Id { get; set; }
}

public class GetViewResponse : PlayFabResultCommon {
    /// <summary>
    /// Metadata defining the view.
    /// </summary>
    public CatalogView? View { get; set; }
}

public class GetViewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of views created by the caller, if any are available. Should be null on
    /// initial request.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of views to retrieve. This value is optional. Default value is 10.
    /// </summary>
    public int? Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetViewsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// List of metadata defining the views.
    /// </summary>
    public List<CatalogView>? Views { get; set; }
}

public class GooglePlayProductPurchase {
    /// <summary>
    /// The Product ID (SKU) of the InApp product purchased from the Google Play store.
    /// </summary>
    public string? ProductId { get; set; }
    /// <summary>
    /// The token provided to the player's device when the product was purchased
    /// </summary>
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
    /// <summary>
    /// The image unique ID.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The client-defined tag associated with this image. Tags must be defined in the Catalog Config before being used in
    /// images
    /// </summary>
    public string? Tag { get; set; }
    /// <summary>
    /// Images can be defined as either a "thumbnail" or "screenshot". There can only be one "thumbnail" image per item.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// The URL for retrieval of the image.
    /// </summary>
    public string? Url { get; set; }
}

public class ImageConfig {
    /// <summary>
    /// The set of tags that will be used for validation. Each tag can have a maximum character length of 32 and up to 1024
    /// tags can be listed.
    /// </summary>
    public List<string>? Tags { get; set; }
}

public class InitialValues {
    /// <summary>
    /// Game specific properties for display purposes. The Display Properties field has a 1000 byte limit.
    /// </summary>
    public object? DisplayProperties { get; set; }
}

public class InventoryItem {
    /// <summary>
    /// The amount of the item.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Game specific properties for display purposes. This is an arbitrary JSON blob. The Display Properties field has a 1000
    /// byte limit.
    /// </summary>
    public object? DisplayProperties { get; set; }
    /// <summary>
    /// Only used for subscriptions. The date of when the item will expire in UTC.
    /// </summary>
    public DateTime? ExpirationDate { get; set; }
    /// <summary>
    /// The id of the item. This should correspond to the item id in the catalog.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The stack id of the item.
    /// </summary>
    public string? StackId { get; set; }
    /// <summary>
    /// The type of the item. This should correspond to the item type in the catalog.
    /// </summary>
    public string? Type { get; set; }
}

public class InventoryItemReference {
    /// <summary>
    /// The inventory item alternate id the request applies to.
    /// </summary>
    public AlternateId? AlternateId { get; set; }
    /// <summary>
    /// The inventory item id the request applies to.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The inventory stack id the request should redeem to. (Default="default")
    /// </summary>
    public string? StackId { get; set; }
}

public class InventoryOperation {
    /// <summary>
    /// The add operation.
    /// </summary>
    public AddInventoryItemsOperation? Add { get; set; }
    /// <summary>
    /// The delete operation.
    /// </summary>
    public DeleteInventoryItemsOperation? Delete { get; set; }
    /// <summary>
    /// The purchase operation.
    /// </summary>
    public PurchaseInventoryItemsOperation? Purchase { get; set; }
    /// <summary>
    /// The subtract operation.
    /// </summary>
    public SubtractInventoryItemsOperation? Subtract { get; set; }
    /// <summary>
    /// The transfer operation.
    /// </summary>
    public TransferInventoryItemsOperation? Transfer { get; set; }
    /// <summary>
    /// The update operation.
    /// </summary>
    public UpdateInventoryItemsOperation? Update { get; set; }
}

public class KeywordSet {
    /// <summary>
    /// A list of localized keywords.
    /// </summary>
    public List<string>? Values { get; set; }
}

/// <summary>
/// The list of available versioned catalogs.
/// </summary>
public class ListVersionedCatalogsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// List catalog versions.
/// </summary>
public class ListVersionedCatalogsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of versioned catalogs.
    /// </summary>
    public List<VersionedCatalog>? VersionedCatalogs { get; set; }
    /// <summary>
    /// The source from where the versioned catalogs are coming from.
    /// </summary>
    public string? VersionedCatalogsSource { get; set; }
}

public class ModerationState {
    /// <summary>
    /// The date and time this moderation state was last updated.
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }
    /// <summary>
    /// The current stated reason for the associated item being moderated.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The current moderation status for the associated item.
    /// </summary>
    public ModerationStatus? Status { get; set; }
}

public enum ModerationStatus {
    Unknown,
    AwaitingModeration,
    Approved,
    Rejected,
}

public class Permissions {
    /// <summary>
    /// The list of ids of Segments that the a player can be in to purchase from the store. When a value is provided, the
    /// player must be in at least one of the segments listed for the purchase to be allowed.
    /// </summary>
    public List<string>? SegmentIds { get; set; }
}

/// <summary>
/// The call kicks off a workflow to publish the item to the public catalog. The Publish Status API should be used to
/// monitor the publish job.
/// </summary>
public class PublishDraftItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETag of the catalog item to published from the working catalog to the public catalog. Used for optimistic concurrency.
    /// If the provided ETag does not match the ETag in the current working catalog, the request will be rejected. If not
    /// provided, the current version of the document in the working catalog will be published.
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
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
    /// <summary>
    /// The amount to purchase.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the operation should be deleted from the inventory. (Default
    /// = false)
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The duration to purchase.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The inventory item the operation applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this operation.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
    /// <summary>
    /// The per-item price the item is expected to be purchased at. This must match a value configured in the Catalog or
    /// specified Store.
    /// </summary>
    public List<PurchasePriceAmount>? PriceAmounts { get; set; }
    /// <summary>
    /// The id of the Store to purchase the item from.
    /// </summary>
    public string? StoreId { get; set; }
}

/// <summary>
/// Purchase a single item or bundle, paying the associated price.
/// </summary>
public class PurchaseInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The amount to purchase.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the request should be deleted from the inventory.
    /// (Default=false)
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The duration to purchase.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The inventory item the request applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this request.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
    /// <summary>
    /// The per-item price the item is expected to be purchased at. This must match a value configured in the Catalog or
    /// specified Store.
    /// </summary>
    public List<PurchasePriceAmount>? PriceAmounts { get; set; }
    /// <summary>
    /// Details the overrides used in a purchase operation.
    /// </summary>
    public PurchaseOverridesInfo? PurchaseOverrides { get; set; }
    /// <summary>
    /// The id of the Store to purchase the item from.
    /// </summary>
    public string? StoreId { get; set; }
}

public class PurchaseInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

public class PurchaseOverridesInfo {
}

public class PurchasePriceAmount {
    /// <summary>
    /// The amount of the inventory item to use in the purchase .
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// The inventory item id to use in the purchase .
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The inventory stack id the to use in the purchase. Set to "default" by default
    /// </summary>
    public string? StackId { get; set; }
}

public class Rating {
    /// <summary>
    /// The average rating for this item.
    /// </summary>
    public float? Average { get; set; }
    /// <summary>
    /// The total count of 1 star ratings for this item.
    /// </summary>
    public int? Count1Star { get; set; }
    /// <summary>
    /// The total count of 2 star ratings for this item.
    /// </summary>
    public int? Count2Star { get; set; }
    /// <summary>
    /// The total count of 3 star ratings for this item.
    /// </summary>
    public int? Count3Star { get; set; }
    /// <summary>
    /// The total count of 4 star ratings for this item.
    /// </summary>
    public int? Count4Star { get; set; }
    /// <summary>
    /// The total count of 5 star ratings for this item.
    /// </summary>
    public int? Count5Star { get; set; }
    /// <summary>
    /// The total count of ratings for this item.
    /// </summary>
    public int? TotalCount { get; set; }
}

public class RealMoneyPriceDetails {
    /// <summary>
    /// The 'AppleAppStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? AppleAppStorePrices { get; set; }
    /// <summary>
    /// The 'GooglePlay' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? GooglePlayPrices { get; set; }
    /// <summary>
    /// The 'MicrosoftStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? MicrosoftStorePrices { get; set; }
    /// <summary>
    /// The 'NintendoEShop' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? NintendoEShopPrices { get; set; }
    /// <summary>
    /// The 'PlayStationStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? PlayStationStorePrices { get; set; }
    /// <summary>
    /// The 'Steam' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? SteamPrices { get; set; }
}

/// <summary>
/// Redeem items from the Apple App Store.
/// </summary>
public class RedeemAppleAppStoreInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
    /// <summary>
    /// The receipt provided by the Apple marketplace upon successful purchase.
    /// </summary>
    public string? Receipt { get; set; }
}

public class RedeemAppleAppStoreInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Google Play Store.
/// </summary>
public class RedeemGooglePlayInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
    /// <summary>
    /// The list of purchases to redeem
    /// </summary>
    public List<GooglePlayProductPurchase>? Purchases { get; set; }
}

public class RedeemGooglePlayInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Microsoft Store.
/// </summary>
public class RedeemMicrosoftStoreInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The OneStore Collections Id Key used for AAD authentication.
    /// </summary>
    public string? CollectionsIdKey { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
    /// <summary>
    /// Xbox Token used for delegated business partner authentication. Token provided by the Xbox Live SDK method
    /// GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", "").
    /// </summary>
    public string? XboxToken { get; set; }
}

public class RedeemMicrosoftStoreInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the Nintendo EShop.
/// </summary>
public class RedeemNintendoEShopInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
    /// <summary>
    /// The Nintendo provided token authorizing redemption
    /// </summary>
    public string? NintendoServiceAccountIdToken { get; set; }
}

public class RedeemNintendoEShopInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem items from the PlayStation Store.
/// </summary>
public class RedeemPlayStationStoreInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Auth code returned by PlayStation :tm: Network OAuth system.
    /// </summary>
    public string? AuthorizationCode { get; set; }
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
    /// <summary>
    /// Redirect URI supplied to PlayStation :tm: Network when requesting an auth code.
    /// </summary>
    public string? RedirectUri { get; set; }
    /// <summary>
    /// Optional Service Label to pass into the request.
    /// </summary>
    public string? ServiceLabel { get; set; }
}

public class RedeemPlayStationStoreInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Redeem inventory items from Steam.
/// </summary>
public class RedeemSteamInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default")
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The country code of the real money transaction.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The inventory items to redeem. These items are required to have an alternate id that corresponds to the marketplace to
    /// redeem from.
    /// </summary>
    public List<InventoryItemReference>? Items { get; set; }
}

public class RedeemSteamInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of failed redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionFailure>? Failed { get; set; }
    /// <summary>
    /// The list of successful redemptions from the external marketplace.
    /// </summary>
    public List<RedemptionSuccess>? Succeeded { get; set; }
    /// <summary>
    /// The Transaction IDs associated with the inventory modifications
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

public class RedemptionFailure {
    /// <summary>
    /// The marketplace failure code.
    /// </summary>
    public string? FailureCode { get; set; }
    /// <summary>
    /// The marketplace error details explaining why the offer failed to redeem.
    /// </summary>
    public string? FailureDetails { get; set; }
    /// <summary>
    /// The Marketplace Alternate ID being redeemed.
    /// </summary>
    public string? MarketplaceAlternateId { get; set; }
    /// <summary>
    /// The transaction id in the external marketplace.
    /// </summary>
    public string? MarketplaceTransactionId { get; set; }
}

public class RedemptionSuccess {
    /// <summary>
    /// The Marketplace Alternate ID being redeemed.
    /// </summary>
    public string? MarketplaceAlternateId { get; set; }
    /// <summary>
    /// The transaction id in the external marketplace.
    /// </summary>
    public string? MarketplaceTransactionId { get; set; }
    /// <summary>
    /// The timestamp for when the redeem was completed.
    /// </summary>
    public required DateTime SuccessTimestamp { get; set; }
}

public class ReportItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// Category of concern for this report.
    /// </summary>
    public ConcernCategory? ConcernCategory { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The string reason for this report.
    /// </summary>
    public string? Reason { get; set; }
}

public class ReportItemResponse : PlayFabResultCommon {
}

/// <summary>
/// Submit a report for an inappropriate review, allowing the submitting user to specify their concern.
/// </summary>
public class ReportItemReviewRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID of the item associated with the review.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The reason this review is being reported.
    /// </summary>
    public ConcernCategory? ConcernCategory { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The string ID of the item associated with the review.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The string reason for this report.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The ID of the review to submit a report for.
    /// </summary>
    public string? ReviewId { get; set; }
}

public class ReportItemReviewResponse : PlayFabResultCommon {
}

public class Review {
    /// <summary>
    /// The star rating associated with each selected category in this review.
    /// </summary>
    public Dictionary<string, int>? CategoryRatings { get; set; }
    /// <summary>
    /// The number of negative helpfulness votes for this review.
    /// </summary>
    public int HelpfulNegative { get; set; }
    /// <summary>
    /// The number of positive helpfulness votes for this review.
    /// </summary>
    public int HelpfulPositive { get; set; }
    /// <summary>
    /// Indicates whether the review author has the item installed.
    /// </summary>
    public bool IsInstalled { get; set; }
    /// <summary>
    /// The ID of the item being reviewed.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The version of the item being reviewed.
    /// </summary>
    public string? ItemVersion { get; set; }
    /// <summary>
    /// The locale for which this review was submitted in.
    /// </summary>
    public string? Locale { get; set; }
    /// <summary>
    /// Star rating associated with this review.
    /// </summary>
    public int Rating { get; set; }
    /// <summary>
    /// The ID of the author of the review.
    /// </summary>
    public EntityKey? ReviewerEntity { get; set; }
    /// <summary>
    /// The ID of the review.
    /// </summary>
    public string? ReviewId { get; set; }
    /// <summary>
    /// The full text of this review.
    /// </summary>
    public string? ReviewText { get; set; }
    /// <summary>
    /// The date and time this review was last submitted.
    /// </summary>
    public required DateTime Submitted { get; set; }
    /// <summary>
    /// The title of this review.
    /// </summary>
    public string? Title { get; set; }
}

public class ReviewConfig {
    /// <summary>
    /// A set of categories that can be applied toward ratings and reviews.
    /// </summary>
    public List<CategoryRatingConfig>? CategoryRatings { get; set; }
}

public class ReviewItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The review to submit.
    /// </summary>
    public Review? Review { get; set; }
}

public class ReviewItemResponse : PlayFabResultCommon {
}

public class ReviewTakedown {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The ID of the item associated with the review to take down.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The ID of the review to take down.
    /// </summary>
    public string? ReviewId { get; set; }
}

public class SearchItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Number of items to retrieve. This value is optional. Maximum page size is 50. Default value is 10.
    /// </summary>
    public int Count { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// An OData filter used to refine the search query (For example: "type eq 'ugc'"). More info about Filter Complexity
    /// limits can be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/search#limits
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// The locale to be returned in the result.
    /// </summary>
    public string? Language { get; set; }
    /// <summary>
    /// An OData orderBy used to order the results of the search query. For example: "rating/average asc"
    /// </summary>
    public string? OrderBy { get; set; }
    /// <summary>
    /// The text to search for.
    /// </summary>
    public string? Search { get; set; }
    /// <summary>
    /// An OData select query option used to augment the search results. If not defined, the default search result metadata
    /// will be returned.
    /// </summary>
    public string? Select { get; set; }
    /// <summary>
    /// The store to restrict the search request to.
    /// </summary>
    public StoreReference? Store { get; set; }
}

public class SearchItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// An opaque token used to retrieve the next page of items, if any are available.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The paginated set of results for the search query.
    /// </summary>
    public List<CatalogItem>? Items { get; set; }
}

public class SetItemModerationStateRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID associated with this item.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The unique ID of the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The reason for the moderation state change for the associated item.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The status to set for the associated item.
    /// </summary>
    public ModerationStatus? Status { get; set; }
}

public class SetItemModerationStateResponse : PlayFabResultCommon {
}

public class StoreDetails {
    /// <summary>
    /// The options for the filter in filter-based stores. These options are mutually exclusive with item references.
    /// </summary>
    public FilterOptions? FilterOptions { get; set; }
    /// <summary>
    /// The permissions that control which players can purchase from the store.
    /// </summary>
    public Permissions? Permissions { get; set; }
    /// <summary>
    /// The global prices utilized in the store. These options are mutually exclusive with price options in item references.
    /// </summary>
    public CatalogPriceOptionsOverride? PriceOptionsOverride { get; set; }
}

public class StoreReference {
    /// <summary>
    /// An alternate ID of the store.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The unique ID of the store.
    /// </summary>
    public string? Id { get; set; }
}

public class SubmitItemReviewVoteRequest : PlayFabRequestCommon {
    /// <summary>
    /// An alternate ID of the item associated with the review.
    /// </summary>
    public CatalogAlternateId? AlternateId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The string ID of the item associated with the review.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The ID of the review to submit a helpfulness vote for.
    /// </summary>
    public string? ReviewId { get; set; }
    /// <summary>
    /// The helpfulness vote of the review.
    /// </summary>
    public HelpfulnessVote? Vote { get; set; }
}

public class SubmitItemReviewVoteResponse : PlayFabResultCommon {
}

public class SubtractInventoryItemsOperation {
    /// <summary>
    /// The amount to subtract from the current item amount.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the request should be deleted from the inventory. (Default =
    /// false).
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The duration to subtract from the current item expiration date.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The inventory item the operation applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will subtract the specified inventory items.
/// </summary>
public class SubtractInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The amount to subtract for the current item.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the request should be deleted from the inventory.
    /// (Default=false)
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The duration to subtract from the current item expiration date.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The inventory item the request applies to.
    /// </summary>
    public InventoryItemReference? Item { get; set; }
}

public class SubtractInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

/// <summary>
/// Submit a request to takedown one or more reviews, removing them from public view. Authors will still be able to see
/// their reviews after being taken down.
/// </summary>
public class TakedownItemReviewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The set of reviews to take down.
    /// </summary>
    public List<ReviewTakedown>? Reviews { get; set; }
}

public class TakedownItemReviewsResponse : PlayFabResultCommon {
}

public class Transaction {
    /// <summary>
    /// The API call that caused this transaction.
    /// </summary>
    public string? ApiName { get; set; }
    /// <summary>
    /// Additional details about the transaction. Null if it was not a clawback operation.
    /// </summary>
    public TransactionClawbackDetails? ClawbackDetails { get; set; }
    /// <summary>
    /// The country of the caller of the operation.
    /// </summary>
    public CountryCode? CountryCode { get; set; }
    /// <summary>
    /// The type of item that the the operation occurred on.
    /// </summary>
    public string? ItemType { get; set; }
    /// <summary>
    /// The operations that occurred.
    /// </summary>
    public List<TransactionOperation>? Operations { get; set; }
    /// <summary>
    /// The type of operation that was run.
    /// </summary>
    public string? OperationType { get; set; }
    /// <summary>
    /// Additional details about the transaction. Null if it was not a purchase operation.
    /// </summary>
    public TransactionPurchaseDetails? PurchaseDetails { get; set; }
    /// <summary>
    /// Additional details about the transaction. Null if it was not a redeem operation.
    /// </summary>
    public TransactionRedeemDetails? RedeemDetails { get; set; }
    /// <summary>
    /// The time this transaction occurred in UTC.
    /// </summary>
    public required DateTime Timestamp { get; set; }
    /// <summary>
    /// The id of the transaction. This should be treated like an opaque token.
    /// </summary>
    public string? TransactionId { get; set; }
    /// <summary>
    /// Additional details about the transaction. Null if it was not a transfer operation.
    /// </summary>
    public TransactionTransferDetails? TransferDetails { get; set; }
}

public class TransactionClawbackDetails {
    /// <summary>
    /// The id of the clawed back operation.
    /// </summary>
    public string? TransactionIdClawedback { get; set; }
}

public class TransactionOperation {
    /// <summary>
    /// The amount of items in this transaction.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The duration modified in this transaction.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The friendly id of the items in this transaction.
    /// </summary>
    public string? ItemFriendlyId { get; set; }
    /// <summary>
    /// The item id of the items in this transaction.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The type of item that the operation occurred on.
    /// </summary>
    public string? ItemType { get; set; }
    /// <summary>
    /// The stack id of the items in this transaction.
    /// </summary>
    public string? StackId { get; set; }
    /// <summary>
    /// The type of the operation that occurred.
    /// </summary>
    public string? Type { get; set; }
}

public class TransactionPurchaseDetails {
    /// <summary>
    /// The friendly id of the Store the item was purchased from or null.
    /// </summary>
    public string? StoreFriendlyId { get; set; }
    /// <summary>
    /// The id of the Store the item was purchased from or null.
    /// </summary>
    public string? StoreId { get; set; }
}

public class TransactionRedeemDetails {
    /// <summary>
    /// The marketplace that the offer is being redeemed from.
    /// </summary>
    public string? Marketplace { get; set; }
    /// <summary>
    /// The transaction Id returned from the marketplace.
    /// </summary>
    public string? MarketplaceTransactionId { get; set; }
    /// <summary>
    /// The offer Id of the item being redeemed.
    /// </summary>
    public string? OfferId { get; set; }
}

public class TransactionTransferDetails {
    /// <summary>
    /// The collection id the items were transferred from or null if it was the current collection.
    /// </summary>
    public string? GivingCollectionId { get; set; }
    /// <summary>
    /// The entity the items were transferred from or null if it was the current entity.
    /// </summary>
    public EntityKey? GivingEntity { get; set; }
    /// <summary>
    /// The collection id the items were transferred to or null if it was the current collection.
    /// </summary>
    public string? ReceivingCollectionId { get; set; }
    /// <summary>
    /// The entity the items were transferred to or null if it was the current entity.
    /// </summary>
    public EntityKey? ReceivingEntity { get; set; }
    /// <summary>
    /// The id of the transfer that occurred.
    /// </summary>
    public string? TransferId { get; set; }
}

public class TransferInventoryItemsOperation {
    /// <summary>
    /// The amount to transfer.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the operation should be deleted from the inventory. (Default
    /// = false)
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The inventory item the operation is transferring from.
    /// </summary>
    public InventoryItemReference? GivingItem { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this operation.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
    /// <summary>
    /// The inventory item the operation is transferring to.
    /// </summary>
    public InventoryItemReference? ReceivingItem { get; set; }
}

/// <summary>
/// Transfer the specified inventory items of an entity's container Id to another entity's container Id.
/// </summary>
public class TransferInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The amount to transfer .
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates whether stacks reduced to an amount of 0 during the request should be deleted from the inventory. (Default =
    /// false)
    /// </summary>
    public bool DeleteEmptyStacks { get; set; }
    /// <summary>
    /// The inventory collection id the request is transferring from. (Default="default")
    /// </summary>
    public string? GivingCollectionId { get; set; }
    /// <summary>
    /// The entity the request is transferring from. Set to the caller by default.
    /// </summary>
    public EntityKey? GivingEntity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources (before transferring from). More information about
    /// using ETags can be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? GivingETag { get; set; }
    /// <summary>
    /// The inventory item the request is transferring from.
    /// </summary>
    public InventoryItemReference? GivingItem { get; set; }
    /// <summary>
    /// The idempotency id for the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The values to apply to a stack newly created by this request.
    /// </summary>
    public InitialValues? NewStackValues { get; set; }
    /// <summary>
    /// The inventory collection id the request is transferring to. (Default="default")
    /// </summary>
    public string? ReceivingCollectionId { get; set; }
    /// <summary>
    /// The entity the request is transferring to. Set to the caller by default.
    /// </summary>
    public EntityKey? ReceivingEntity { get; set; }
    /// <summary>
    /// The inventory item the request is transferring to.
    /// </summary>
    public InventoryItemReference? ReceivingItem { get; set; }
}

public class TransferInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources (after transferring from). More information about using
    /// ETags can be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? GivingETag { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request's giving action.
    /// </summary>
    public List<string>? GivingTransactionIds { get; set; }
    /// <summary>
    /// The idempotency id for the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The transfer operation status. Possible values are 'InProgress' or 'Completed'. If the operation has completed, the
    /// response code will be 200. Otherwise, it will be 202.
    /// </summary>
    public string? OperationStatus { get; set; }
    /// <summary>
    /// The token that can be used to get the status of the transfer operation. This will only have a value if OperationStatus
    /// is 'InProgress'.
    /// </summary>
    public string? OperationToken { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request's receiving action.
    /// </summary>
    public List<string>? ReceivingTransactionIds { get; set; }
}

public class UpdateCatalogConfigRequest : PlayFabRequestCommon {
    /// <summary>
    /// The updated catalog configuration.
    /// </summary>
    public CatalogConfig? Config { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UpdateCatalogConfigResponse : PlayFabResultCommon {
}

public class UpdateDraftItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Updated metadata describing the catalog item to be updated.
    /// </summary>
    public CatalogItem? Item { get; set; }
    /// <summary>
    /// Whether the item should be published immediately. This value is optional, defaults to false.
    /// </summary>
    public bool Publish { get; set; }
}

public class UpdateDraftItemResponse : PlayFabResultCommon {
    /// <summary>
    /// Updated metadata describing the catalog item just updated.
    /// </summary>
    public CatalogItem? Item { get; set; }
}

public class UpdateInventoryItemsOperation {
    /// <summary>
    /// The inventory item to update with the specified values.
    /// </summary>
    public InventoryItem? Item { get; set; }
}

/// <summary>
/// Given an entity type, entity identifier and container details, will update the entity's inventory items
/// </summary>
public class UpdateInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The id of the entity's collection to perform this action on. (Default="default"). The number of inventory collections
    /// is unlimited.
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The Idempotency ID for this request. Idempotency IDs can be used to prevent operation replay in the medium term but
    /// will be garbage collected eventually.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The inventory item to update with the specified values.
    /// </summary>
    public InventoryItem? Item { get; set; }
}

public class UpdateInventoryItemsResponse : PlayFabResultCommon {
    /// <summary>
    /// ETags are used for concurrency checking when updating resources. More information about using ETags can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/etags
    /// </summary>
    public string? ETag { get; set; }
    /// <summary>
    /// The idempotency id used in the request.
    /// </summary>
    public string? IdempotencyId { get; set; }
    /// <summary>
    /// The ids of transactions that occurred as a result of the request.
    /// </summary>
    public List<string>? TransactionIds { get; set; }
}

public class UpdateViewRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Updated metadata describing the catalog view to be updated.
    /// </summary>
    public CatalogView? View { get; set; }
}

public class UpdateViewResponse : PlayFabResultCommon {
    /// <summary>
    /// Updated metadata describing the catalog view just updated
    /// </summary>
    public CatalogView? View { get; set; }
}

public class UploadInfo {
    /// <summary>
    /// Name of the file to be uploaded.
    /// </summary>
    public string? FileName { get; set; }
}

public class UploadUrlMetadata {
    /// <summary>
    /// Name of the file for which this upload URL was requested.
    /// </summary>
    public string? FileName { get; set; }
    /// <summary>
    /// Unique ID for the binary content to be uploaded to the target URL.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// URL for the binary content to be uploaded to.
    /// </summary>
    public string? Url { get; set; }
}

public class UserGeneratedContentSpecificConfig {
    /// <summary>
    /// The set of content types that will be used for validation.
    /// </summary>
    public List<string>? ContentTypes { get; set; }
    /// <summary>
    /// The set of tags that will be used for validation.
    /// </summary>
    public List<string>? Tags { get; set; }
}

public class VersionedCatalog {
    /// <summary>
    /// Version of the catalog.
    /// </summary>
    public string? Version { get; set; }
}

public class VersionedCatalogItem {
    /// <summary>
    /// A list of alternate ids for this item.
    /// </summary>
    public List<VersionedCatalogItemAlternateId>? AlternateIds { get; set; }
    /// <summary>
    /// The content type of the item.
    /// </summary>
    public string? ContentType { get; set; }
    /// <summary>
    /// The creation date of the item.
    /// </summary>
    public DateTime? CreationDate { get; set; }
    /// <summary>
    /// The creator entity of the item.
    /// </summary>
    public VersionedCatalogItemCreatorEntity? CreatorEntity { get; set; }
    /// <summary>
    /// The Stack Id that will be used as default for this item in Inventory when an explicit one is not provided.
    /// </summary>
    public string? DefaultStackId { get; set; }
    /// <summary>
    /// The description of the item.
    /// </summary>
    public Dictionary<string, string>? Description { get; set; }
    /// <summary>
    /// The end date of the item.
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// The friendly id of the item.
    /// </summary>
    public string? FriendlyId { get; set; }
    /// <summary>
    /// The id identifying the item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Indicates if the item is hidden.
    /// </summary>
    public bool? IsHidden { get; set; }
    /// <summary>
    /// Indicates if the item is for testing.
    /// </summary>
    public bool? IsTest { get; set; }
    /// <summary>
    /// The item references associated with this item.
    /// </summary>
    public List<VersionedCatalogItemReference>? ItemReferences { get; set; }
    /// <summary>
    /// The keywords of the item.
    /// </summary>
    public Dictionary<string, VersionedCatalogItemKeywordSet>? Keywords { get; set; }
    /// <summary>
    /// The last modified date of the item.
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }
    /// <summary>
    /// The payout information of the payee.
    /// </summary>
    public VersionedCatalogItemPayoutInfo? PayoutInfo { get; set; }
    /// <summary>
    /// The platforms of the item.
    /// </summary>
    public List<string>? Platforms { get; set; }
    /// <summary>
    /// The prices the item can be purchased for.
    /// </summary>
    public VersionedCatalogItemPrice? Price { get; set; }
    /// <summary>
    /// The real price the item was purchased for per marketplace.
    /// </summary>
    public VersionedCatalogItemRealMoneyPriceDetails? RealMoneyPriceDetails { get; set; }
    /// <summary>
    /// The start date of the item.
    /// </summary>
    public DateTime? StartDate { get; set; }
    /// <summary>
    /// Optional details for stores items.
    /// </summary>
    public VersionedCatalogItemStoreDetails? StoreDetails { get; set; }
    /// <summary>
    /// The tags of the item.
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// The title of the item.
    /// </summary>
    public Dictionary<string, string>? Title { get; set; }
    /// <summary>
    /// Whether a non-title entity can interact with the item.
    /// </summary>
    public bool? TitleExclusive { get; set; }
    /// <summary>
    /// The service defined type of the item.
    /// </summary>
    public string? Type { get; set; }
}

public class VersionedCatalogItemAlternateId {
    /// <summary>
    /// Type of the Alternate Id.
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Value of the Alternate Id.
    /// </summary>
    public string? Value { get; set; }
}

public class VersionedCatalogItemCreatorEntity {
    /// <summary>
    /// The id of the creator entity.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// The type of the creator entity.
    /// </summary>
    public string? Type { get; set; }
}

public class VersionedCatalogItemFilterOptions {
    /// <summary>
    /// The OData filter utilized. Mutually exclusive with 'IncludeAllItems'.
    /// </summary>
    public string? Filter { get; set; }
    /// <summary>
    /// The flag that overrides the filter and allows for returning all catalog items. Mutually exclusive with 'Filter'.
    /// </summary>
    public bool? IncludeAllItems { get; set; }
}

public class VersionedCatalogItemKeywordSet {
    /// <summary>
    /// A list of localized keywords.
    /// </summary>
    public List<string>? Values { get; set; }
}

public class VersionedCatalogItemOverride {
    /// <summary>
    /// The exact value that should be utilized in the override.
    /// </summary>
    public double? FixedValue { get; set; }
    /// <summary>
    /// The id of the item this override should utilize.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The multiplier that will be applied to the base Catalog value to determine what value should be utilized in the
    /// override.
    /// </summary>
    public double? Multiplier { get; set; }
}

public class VersionedCatalogItemPayoutInfo {
    /// <summary>
    /// The Dev Center account id of the payee.
    /// </summary>
    public string? AccountSellerId { get; set; }
    /// <summary>
    /// The tax code for payout calculations.
    /// </summary>
    public string? TaxCode { get; set; }
    /// <summary>
    /// The Universal account id of the payee.
    /// </summary>
    public string? Uaid { get; set; }
}

public class VersionedCatalogItemPermissions {
    /// <summary>
    /// The list of ids of Segments that the a player can be in to purchase from the store.
    /// </summary>
    public List<string>? SegmentIds { get; set; }
}

public class VersionedCatalogItemPrice {
    /// <summary>
    /// The amount the payee will receive.
    /// </summary>
    public double? PayoutAmount { get; set; }
    /// <summary>
    /// Prices of the catalog item.
    /// </summary>
    public List<VersionedCatalogItemPriceInstance>? Prices { get; set; }
    /// <summary>
    /// A standardized sorting key to allow proper sorting between items with prices in different currencies.
    /// </summary>
    public int? Sort { get; set; }
}

public class VersionedCatalogItemPriceAmount {
    /// <summary>
    /// The amount of the price.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// Indicates whether the item this price references is defined at the namespace level or not.
    /// </summary>
    public bool? IsFromNamespace { get; set; }
    /// <summary>
    /// The Item Id of the price.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Stack Id the client expects to use to purchase the item.
    /// </summary>
    public string? StackId { get; set; }
}

public class VersionedCatalogItemPriceInstance {
    /// <summary>
    /// The amounts of the catalog item price. Each price can have up to 15 item amounts.
    /// </summary>
    public List<VersionedCatalogItemPriceAmount>? Amounts { get; set; }
    /// <summary>
    /// The per-unit amount this price can be used to purchase.
    /// </summary>
    public int? UnitAmount { get; set; }
    /// <summary>
    /// The per-unit duration this price can be used to purchase. The maximum duration is 100 years.
    /// </summary>
    public double? UnitDurationInSeconds { get; set; }
}

public class VersionedCatalogItemPriceOverride {
    /// <summary>
    /// The currency amounts utilized in the override for a singular price.
    /// </summary>
    public List<VersionedCatalogItemOverride>? Amounts { get; set; }
}

public class VersionedCatalogItemPricesOverride {
    /// <summary>
    /// The payout amount utilized in the override.
    /// </summary>
    public VersionedCatalogItemOverride? PayoutAmount { get; set; }
    /// <summary>
    /// The prices utilized in the override.
    /// </summary>
    public List<VersionedCatalogItemPriceOverride>? Prices { get; set; }
}

public class VersionedCatalogItemRealMoneyPriceDetails {
    /// <summary>
    /// The 'AppleAppStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? AppleAppStorePrices { get; set; }
    /// <summary>
    /// The 'GooglePlay' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? GooglePlayPrices { get; set; }
    /// <summary>
    /// The 'MicrosoftStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? MicrosoftStorePrices { get; set; }
    /// <summary>
    /// The 'NintendoEShop' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? NintendoEShopPrices { get; set; }
    /// <summary>
    /// The 'PlayStationStore' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? PlayStationStorePrices { get; set; }
    /// <summary>
    /// The 'Steam' price amount per CurrencyCode. 'USD' supported only.
    /// </summary>
    public Dictionary<string, int>? SteamPrices { get; set; }
}

public class VersionedCatalogItemReference {
    /// <summary>
    /// The amount of the catalog item.
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The duration in seconds of the catalog item.
    /// </summary>
    public double? DurationInSeconds { get; set; }
    /// <summary>
    /// The unique id of the catalog item.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Indicates whether the item this reference represents is defined at the namespace level or not.
    /// </summary>
    public bool? IsFromNamespace { get; set; }
    /// <summary>
    /// The prices the catalog item can be purchased for.
    /// </summary>
    public VersionedCatalogItemPrice? Price { get; set; }
}

public class VersionedCatalogItemStoreDetails {
    /// <summary>
    /// The options for the filter in filter-based stores. These options are mutually exclusive with item references.
    /// </summary>
    public VersionedCatalogItemFilterOptions? FilterOptions { get; set; }
    /// <summary>
    /// The permissions that control which players can purchase from the store.
    /// </summary>
    public VersionedCatalogItemPermissions? Permissions { get; set; }
    /// <summary>
    /// The global prices utilized in the store. These options are mutually exclusive with price options in item references.
    /// </summary>
    public VersionedCatalogItemPricesOverride? PricesOverride { get; set; }
}

public enum ViewFileFormat {
    Unknown,
    Json,
    JsonLines,
    GZippedJson,
    GZippedJsonLines,
}

