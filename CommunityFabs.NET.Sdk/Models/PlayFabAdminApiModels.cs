namespace CommunityFabs.NET.Sdk.Models.Admin;

/// <summary>
/// If the task instance has already completed, there will be no-op.
/// </summary>
public class AbortTaskInstanceRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// ID of a task instance that is being aborted.
    /// </summary>
    public required string TaskInstanceId { get; set; }
}

/// <summary>
/// The work to be performed on each entity which can only be of one type.
/// </summary>
public class Action {
    /// <summary>
    /// Action content to add inventory item v2
    /// </summary>
    public AddInventoryItemV2Content? AddInventoryItemV2Content { get; set; }
    /// <summary>
    /// Action content to ban player
    /// </summary>
    public BanPlayerContent? BanPlayerContent { get; set; }
    /// <summary>
    /// Action content to delete inventory item v2
    /// </summary>
    public DeleteInventoryItemV2Content? DeleteInventoryItemV2Content { get; set; }
    /// <summary>
    /// Action content to delete player
    /// </summary>
    public DeletePlayerContent? DeletePlayerContent { get; set; }
    /// <summary>
    /// Action content to execute cloud script
    /// </summary>
    public ExecuteCloudScriptContent? ExecuteCloudScriptContent { get; set; }
    /// <summary>
    /// Action content to execute azure function
    /// </summary>
    public ExecuteFunctionContent? ExecuteFunctionContent { get; set; }
    /// <summary>
    /// Action content to grant item
    /// </summary>
    public GrantItemContent? GrantItemContent { get; set; }
    /// <summary>
    /// Action content to grant virtual currency
    /// </summary>
    public GrantVirtualCurrencyContent? GrantVirtualCurrencyContent { get; set; }
    /// <summary>
    /// Action content to increment player statistic
    /// </summary>
    public IncrementPlayerStatisticContent? IncrementPlayerStatisticContent { get; set; }
    /// <summary>
    /// Action content to send push notification
    /// </summary>
    public PushNotificationContent? PushNotificationContent { get; set; }
    /// <summary>
    /// Action content to send email
    /// </summary>
    public SendEmailContent? SendEmailContent { get; set; }
    /// <summary>
    /// Action content to subtract inventory item v2
    /// </summary>
    public SubtractInventoryItemV2Content? SubtractInventoryItemV2Content { get; set; }
}

public class ActionsOnPlayersInSegmentTaskParameter {
    /// <summary>
    /// List of actions to perform on each player in a segment. Each action object can contain only one action type.
    /// </summary>
    public List<Action>? Actions { get; set; }
    /// <summary>
    /// ID of the segment to perform actions on.
    /// </summary>
    public required string SegmentId { get; set; }
}

public class ActionsOnPlayersInSegmentTaskSummary {
    /// <summary>
    /// UTC timestamp when the task completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }
    /// <summary>
    /// Error message for last processing attempt, if an error occured.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// Flag indicating if the error was fatal, if false job will be retried.
    /// </summary>
    public bool? ErrorWasFatal { get; set; }
    /// <summary>
    /// Estimated time remaining in seconds.
    /// </summary>
    public double? EstimatedSecondsRemaining { get; set; }
    /// <summary>
    /// Progress represented as percentage.
    /// </summary>
    public double? PercentComplete { get; set; }
    /// <summary>
    /// If manually scheduled, ID of user who scheduled the task.
    /// </summary>
    public string? ScheduledByUserId { get; set; }
    /// <summary>
    /// UTC timestamp when the task started.
    /// </summary>
    public required DateTime StartedAt { get; set; }
    /// <summary>
    /// Current status of the task instance.
    /// </summary>
    public TaskInstanceStatus? Status { get; set; }
    /// <summary>
    /// Identifier of the task this instance belongs to.
    /// </summary>
    public NameIdentifier? TaskIdentifier { get; set; }
    /// <summary>
    /// ID of the task instance.
    /// </summary>
    public string? TaskInstanceId { get; set; }
    /// <summary>
    /// Total players in segment when task was started.
    /// </summary>
    public int? TotalPlayersInSegment { get; set; }
    /// <summary>
    /// Total number of players that have had the actions applied to.
    /// </summary>
    public int? TotalPlayersProcessed { get; set; }
}

public class AdCampaignAttribution {
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

public class AdCampaignSegmentFilter {
    /// <summary>
    /// Campaign id.
    /// </summary>
    public string? CampaignId { get; set; }
    /// <summary>
    /// Campaign source.
    /// </summary>
    public string? CampaignSource { get; set; }
    /// <summary>
    /// Campaign comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
}

public class AddInventoryItemsV2SegmentAction {
    /// <summary>
    /// Amount of the item to be granted to a player
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The collection id for where the item will be granted in the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The duration in seconds of the subscription to be granted to a player
    /// </summary>
    public int? DurationInSeconds { get; set; }
    /// <summary>
    /// The id of item to be granted to the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be granted in the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

public class AddInventoryItemV2Content {
    /// <summary>
    /// Amount of the item to be granted to a player
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The collection id for where the item will be granted in the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The duration in seconds of the subscription to be granted to a player
    /// </summary>
    public int? DurationInSeconds { get; set; }
    /// <summary>
    /// The id of item to be granted to the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be granted in the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

public class AddLocalizedNewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Localized body text of the news.
    /// </summary>
    public required string Body { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Language of the news item.
    /// </summary>
    public required string Language { get; set; }
    /// <summary>
    /// Unique id of the updated news item.
    /// </summary>
    public required string NewsId { get; set; }
    /// <summary>
    /// Localized title (headline) of the news item.
    /// </summary>
    public required string Title { get; set; }
}

public class AddLocalizedNewsResult : PlayFabResultCommon {
}

public class AddNewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Default body text of the news.
    /// </summary>
    public required string Body { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Time this news was published. If not set, defaults to now.
    /// </summary>
    public DateTime? Timestamp { get; set; }
    /// <summary>
    /// Default title (headline) of the news item.
    /// </summary>
    public required string Title { get; set; }
}

public class AddNewsResult : PlayFabResultCommon {
    /// <summary>
    /// Unique id of the new news item
    /// </summary>
    public string? NewsId { get; set; }
}

/// <summary>
/// This API will trigger a player_tag_added event and add a tag with the given TagName and PlayFabID to the corresponding
/// player profile. TagName can be used for segmentation and it is limited to 256 characters. Also there is a limit on the
/// number of tags a title can have.
/// </summary>
public class AddPlayerTagRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Unique tag for player profile.
    /// </summary>
    public required string TagName { get; set; }
}

public class AddPlayerTagResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class AddServerBuildRequest : PlayFabRequestCommon {
    /// <summary>
    /// server host regions in which this build should be running and available
    /// </summary>
    public List<Region>? ActiveRegions { get; set; }
    /// <summary>
    /// unique identifier for the build executable
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// appended to the end of the command line when starting game servers
    /// </summary>
    public string? CommandLineTemplate { get; set; }
    /// <summary>
    /// developer comment(s) for this build
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// path to the game server executable. Defaults to gameserver.exe
    /// </summary>
    public string? ExecutablePath { get; set; }
    /// <summary>
    /// maximum number of game server instances that can run on a single host machine
    /// </summary>
    public int MaxGamesPerHost { get; set; }
    /// <summary>
    /// minimum capacity of additional game server instances that can be started before the autoscaling service starts new host
    /// machines (given the number of current running host machines and game server instances)
    /// </summary>
    public int MinFreeGameSlots { get; set; }
}

[Obsolete("Do not use")]
public class AddServerBuildResult : PlayFabResultCommon {
    /// <summary>
    /// array of regions where this build can used, when it is active
    /// </summary>
    public List<Region>? ActiveRegions { get; set; }
    /// <summary>
    /// unique identifier for this build executable
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// appended to the end of the command line when starting game servers
    /// </summary>
    public string? CommandLineTemplate { get; set; }
    /// <summary>
    /// developer comment(s) for this build
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// path to the game server executable. Defaults to gameserver.exe
    /// </summary>
    public string? ExecutablePath { get; set; }
    /// <summary>
    /// maximum number of game server instances that can run on a single host machine
    /// </summary>
    public int MaxGamesPerHost { get; set; }
    /// <summary>
    /// minimum capacity of additional game server instances that can be started before the autoscaling service starts new host
    /// machines (given the number of current running host machines and game server instances)
    /// </summary>
    public int MinFreeGameSlots { get; set; }
    /// <summary>
    /// the current status of the build validation and processing steps
    /// </summary>
    public GameBuildStatus? Status { get; set; }
    /// <summary>
    /// time this build was last modified (or uploaded, if this build has never been modified)
    /// </summary>
    public required DateTime Timestamp { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public string? TitleId { get; set; }
}

public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Amount to be added to the user balance of the specified virtual currency. Maximum VC balance is Int32 (2,147,483,647).
    /// Any increase over this value will be discarded.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose virtual currency balance is to be increased.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Name of the virtual currency which is to be incremented.
    /// </summary>
    public required string VirtualCurrency { get; set; }
}

/// <summary>
/// This operation is additive. Any new currencies defined in the array will be added to the set of those available for the
/// title, while any CurrencyCode identifiers matching existing ones in the game will be overwritten with the new values.
/// </summary>
public class AddVirtualCurrencyTypesRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of virtual currencies and their initial deposits (the amount a user is granted when signing in for the first time)
    /// to the title
    /// </summary>
    public required List<VirtualCurrencyData> VirtualCurrencies { get; set; }
}

public class AllPlayersSegmentFilter {
}

public class ApiCondition {
    /// <summary>
    /// Require that API calls contain an RSA encrypted payload or signed headers.
    /// </summary>
    public Conditionals? HasSignatureOrEncryption { get; set; }
}

public enum AuthTokenType {
    Email,
}

/// <summary>
/// Contains information for a ban.
/// </summary>
public class BanInfo {
    /// <summary>
    /// The active state of this ban. Expired bans may still have this value set to true but they will have no effect.
    /// </summary>
    public bool Active { get; set; }
    /// <summary>
    /// The unique Ban Id associated with this ban.
    /// </summary>
    public string? BanId { get; set; }
    /// <summary>
    /// The time when this ban was applied.
    /// </summary>
    public DateTime? Created { get; set; }
    /// <summary>
    /// The time when this ban expires. Permanent bans do not have expiration date.
    /// </summary>
    public DateTime? Expires { get; set; }
    /// <summary>
    /// Whether or not the Microsoft family members are included in the ban. This property is deprecated and does not work
    /// anymore.
    /// </summary>
    public bool? IncludeMicrosoftFamily { get; set; }
    /// <summary>
    /// The IP address on which the ban was applied. May affect multiple players.
    /// </summary>
    public string? IPAddress { get; set; }
    /// <summary>
    /// The MAC address on which the ban was applied. May affect multiple players. This property is deprecated and does not
    /// work anymore.
    /// </summary>
    public string? MACAddress { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// The reason why this ban was applied.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The family type of the user that is included in the ban.
    /// </summary>
    public string? UserFamilyType { get; set; }
}

public class BanPlayerContent {
    /// <summary>
    /// Duration(in hours) to ban a player. If not provided, the player will be banned permanently.
    /// </summary>
    public int? BanDurationHours { get; set; }
    /// <summary>
    /// Reason to ban a player
    /// </summary>
    public string? BanReason { get; set; }
}

public class BanPlayerSegmentAction {
    /// <summary>
    /// Ban hours duration.
    /// </summary>
    public UInt32? BanHours { get; set; }
    /// <summary>
    /// Reason for ban.
    /// </summary>
    public string? ReasonForBan { get; set; }
}

/// <summary>
/// Represents a single ban request.
/// </summary>
public class BanRequest {
    /// <summary>
    /// The duration in hours for the ban. Leave this blank for a permanent ban.
    /// </summary>
    public UInt32? DurationInHours { get; set; }
    /// <summary>
    /// Whether the Microsoft family members should be included in the ban. May affect multiple players. This property is
    /// deprecated and does not work anymore.
    /// </summary>
    public bool? IncludeMicrosoftFamily { get; set; }
    /// <summary>
    /// IP address to be banned. May affect multiple players.
    /// </summary>
    public string? IPAddress { get; set; }
    /// <summary>
    /// MAC address to be banned. May affect multiple players. This property is deprecated and does not work anymore.
    /// </summary>
    public string? MACAddress { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// The reason for this ban. Maximum 140 characters.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The family type of the user that should be included in the ban if applicable. May affect multiple players.
    /// </summary>
    public UserFamilyType? UserFamilyType { get; set; }
}

/// <summary>
/// The existence of each user will not be verified. When banning by IP or MAC address, multiple players may be affected,
/// so use this feature with caution. Returns information about the new bans.
/// </summary>
public class BanUsersRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of ban requests to be applied. Maximum 100.
    /// </summary>
    public required List<BanRequest> Bans { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class BanUsersResult : PlayFabResultCommon {
    /// <summary>
    /// Information on the bans that were applied
    /// </summary>
    public List<BanInfo>? BanData { get; set; }
}

public class BlankResult : PlayFabResultCommon {
}

/// <summary>
/// A purchasable item from the item catalog
/// </summary>
public class CatalogItem {
    /// <summary>
    /// defines the bundle properties for the item - bundles are items which contain other items, including random drop tables
    /// and virtual currencies
    /// </summary>
    public CatalogItemBundleInfo? Bundle { get; set; }
    /// <summary>
    /// if true, then an item instance of this type can be used to grant a character to a user.
    /// </summary>
    public bool CanBecomeCharacter { get; set; }
    /// <summary>
    /// catalog version for this item
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// defines the consumable properties (number of uses, timeout) for the item
    /// </summary>
    public CatalogItemConsumableInfo? Consumable { get; set; }
    /// <summary>
    /// defines the container properties for the item - what items it contains, including random drop tables and virtual
    /// currencies, and what item (if any) is required to open it via the UnlockContainerItem API
    /// </summary>
    public CatalogItemContainerInfo? Container { get; set; }
    /// <summary>
    /// game specific custom data
    /// </summary>
    public string? CustomData { get; set; }
    /// <summary>
    /// text description of item, to show in-game
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// text name for the item, to show in-game
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// If the item has IsLImitedEdition set to true, and this is the first time this ItemId has been defined as a limited
    /// edition item, this value determines the total number of instances to allocate for the title. Once this limit has been
    /// reached, no more instances of this ItemId can be created, and attempts to purchase or grant it will return a Result of
    /// false for that ItemId. If the item has already been defined to have a limited edition count, or if this value is less
    /// than zero, it will be ignored.
    /// </summary>
    public int InitialLimitedEditionCount { get; set; }
    /// <summary>
    /// BETA: If true, then only a fixed number can ever be granted.
    /// </summary>
    public bool IsLimitedEdition { get; set; }
    /// <summary>
    /// if true, then only one item instance of this type will exist and its remaininguses will be incremented instead.
    /// RemainingUses will cap out at Int32.Max (2,147,483,647). All subsequent increases will be discarded
    /// </summary>
    public bool IsStackable { get; set; }
    /// <summary>
    /// if true, then an item instance of this type can be traded between players using the trading APIs
    /// </summary>
    public bool IsTradable { get; set; }
    /// <summary>
    /// class to which the item belongs
    /// </summary>
    public string? ItemClass { get; set; }
    /// <summary>
    /// unique identifier for this item
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// URL to the item image. For Facebook purchase to display the image on the item purchase page, this must be set to an
    /// HTTP URL.
    /// </summary>
    public string? ItemImageUrl { get; set; }
    /// <summary>
    /// override prices for this item for specific currencies
    /// </summary>
    public Dictionary<string, UInt32>? RealCurrencyPrices { get; set; }
    /// <summary>
    /// list of item tags
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// price of this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
    /// </summary>
    public Dictionary<string, UInt32>? VirtualCurrencyPrices { get; set; }
}

public class CatalogItemBundleInfo {
    /// <summary>
    /// unique ItemId values for all items which will be added to the player inventory when the bundle is added
    /// </summary>
    public List<string>? BundledItems { get; set; }
    /// <summary>
    /// unique TableId values for all RandomResultTable objects which are part of the bundle (random tables will be resolved
    /// and add the relevant items to the player inventory when the bundle is added)
    /// </summary>
    public List<string>? BundledResultTables { get; set; }
    /// <summary>
    /// virtual currency types and balances which will be added to the player inventory when the bundle is added
    /// </summary>
    public Dictionary<string, UInt32>? BundledVirtualCurrencies { get; set; }
}

public class CatalogItemConsumableInfo {
    /// <summary>
    /// number of times this object can be used, after which it will be removed from the player inventory
    /// </summary>
    public UInt32? UsageCount { get; set; }
    /// <summary>
    /// duration in seconds for how long the item will remain in the player inventory - once elapsed, the item will be removed
    /// (recommended minimum value is 5 seconds, as lower values can cause the item to expire before operations depending on
    /// this item's details have completed)
    /// </summary>
    public UInt32? UsagePeriod { get; set; }
    /// <summary>
    /// all inventory item instances in the player inventory sharing a non-null UsagePeriodGroup have their UsagePeriod values
    /// added together, and share the result - when that period has elapsed, all the items in the group will be removed
    /// </summary>
    public string? UsagePeriodGroup { get; set; }
}

/// <summary>
/// Containers are inventory items that can hold other items defined in the catalog, as well as virtual currency, which is
/// added to the player inventory when the container is unlocked, using the UnlockContainerItem API. The items can be
/// anything defined in the catalog, as well as RandomResultTable objects which will be resolved when the container is
/// unlocked. Containers and their keys should be defined as Consumable (having a limited number of uses) in their catalog
/// defintiions, unless the intent is for the player to be able to re-use them infinitely.
/// </summary>
public class CatalogItemContainerInfo {
    /// <summary>
    /// unique ItemId values for all items which will be added to the player inventory, once the container has been unlocked
    /// </summary>
    public List<string>? ItemContents { get; set; }
    /// <summary>
    /// ItemId for the catalog item used to unlock the container, if any (if not specified, a call to UnlockContainerItem will
    /// open the container, adding the contents to the player inventory and currency balances)
    /// </summary>
    public string? KeyItemId { get; set; }
    /// <summary>
    /// unique TableId values for all RandomResultTable objects which are part of the container (once unlocked, random tables
    /// will be resolved and add the relevant items to the player inventory)
    /// </summary>
    public List<string>? ResultTableContents { get; set; }
    /// <summary>
    /// virtual currency types and balances which will be added to the player inventory when the container is unlocked
    /// </summary>
    public Dictionary<string, UInt32>? VirtualCurrencyContents { get; set; }
}

/// <summary>
/// This returns the total number of these items available.
/// </summary>
public class CheckLimitedEditionItemAvailabilityRequest : PlayFabRequestCommon {
    /// <summary>
    /// Which catalog is being updated. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The item to check for.
    /// </summary>
    public required string ItemId { get; set; }
}

public class CheckLimitedEditionItemAvailabilityResult : PlayFabResultCommon {
    /// <summary>
    /// The amount of the specified resource remaining.
    /// </summary>
    public int Amount { get; set; }
}

public class ChurnPredictionSegmentFilter {
    /// <summary>
    /// Comparison
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// RiskLevel
    /// </summary>
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public enum ChurnRiskLevel {
    NoData,
    LowRisk,
    MediumRisk,
    HighRisk,
}

public class CloudScriptAzureFunctionsTaskParameter {
    /// <summary>
    /// Argument to pass to the CloudScript function.
    /// </summary>
    public object? Argument { get; set; }
    /// <summary>
    /// Name of the CloudScript function to execute.
    /// </summary>
    public string? FunctionName { get; set; }
}

public class CloudScriptAzureFunctionsTaskSummary {
    /// <summary>
    /// UTC timestamp when the task completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }
    /// <summary>
    /// Error indicating failure to execute the CloudScript Azure Function
    /// </summary>
    public string? Error { get; set; }
    /// <summary>
    /// Estimated time remaining in seconds.
    /// </summary>
    public double? EstimatedSecondsRemaining { get; set; }
    /// <summary>
    /// Progress represented as percentage.
    /// </summary>
    public double? PercentComplete { get; set; }
    /// <summary>
    /// Result of CloudScript Azure Function execution
    /// </summary>
    public ExecuteFunctionResult? Result { get; set; }
    /// <summary>
    /// If manually scheduled, ID of user who scheduled the task.
    /// </summary>
    public string? ScheduledByUserId { get; set; }
    /// <summary>
    /// UTC timestamp when the task started.
    /// </summary>
    public required DateTime StartedAt { get; set; }
    /// <summary>
    /// Current status of the task instance.
    /// </summary>
    public TaskInstanceStatus? Status { get; set; }
    /// <summary>
    /// Identifier of the task this instance belongs to.
    /// </summary>
    public NameIdentifier? TaskIdentifier { get; set; }
    /// <summary>
    /// ID of the task instance.
    /// </summary>
    public string? TaskInstanceId { get; set; }
}

public class CloudScriptFile {
    /// <summary>
    /// Contents of the Cloud Script javascript. Must be string-escaped javascript.
    /// </summary>
    public required string FileContents { get; set; }
    /// <summary>
    /// Name of the javascript file. These names are not used internally by the server, they are only for developer
    /// organizational purposes.
    /// </summary>
    public required string Filename { get; set; }
}

public class CloudScriptTaskParameter {
    /// <summary>
    /// Argument to pass to the CloudScript function.
    /// </summary>
    public object? Argument { get; set; }
    /// <summary>
    /// Name of the CloudScript function to execute.
    /// </summary>
    public string? FunctionName { get; set; }
}

public class CloudScriptTaskSummary {
    /// <summary>
    /// UTC timestamp when the task completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }
    /// <summary>
    /// Estimated time remaining in seconds.
    /// </summary>
    public double? EstimatedSecondsRemaining { get; set; }
    /// <summary>
    /// Progress represented as percentage.
    /// </summary>
    public double? PercentComplete { get; set; }
    /// <summary>
    /// Result of CloudScript execution
    /// </summary>
    public ExecuteCloudScriptResult? Result { get; set; }
    /// <summary>
    /// If manually scheduled, ID of user who scheduled the task.
    /// </summary>
    public string? ScheduledByUserId { get; set; }
    /// <summary>
    /// UTC timestamp when the task started.
    /// </summary>
    public required DateTime StartedAt { get; set; }
    /// <summary>
    /// Current status of the task instance.
    /// </summary>
    public TaskInstanceStatus? Status { get; set; }
    /// <summary>
    /// Identifier of the task this instance belongs to.
    /// </summary>
    public NameIdentifier? TaskIdentifier { get; set; }
    /// <summary>
    /// ID of the task instance.
    /// </summary>
    public string? TaskInstanceId { get; set; }
}

public class CloudScriptVersionStatus {
    /// <summary>
    /// Most recent revision for this Cloud Script version
    /// </summary>
    public int LatestRevision { get; set; }
    /// <summary>
    /// Published code revision for this Cloud Script version
    /// </summary>
    public int PublishedRevision { get; set; }
    /// <summary>
    /// Version number
    /// </summary>
    public int Version { get; set; }
}

public enum Conditionals {
    Any,
    True,
    False,
}

public class ContactEmailInfo {
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

public class ContentInfo {
    /// <summary>
    /// Key of the content
    /// </summary>
    public string? Key { get; set; }
    /// <summary>
    /// Last modified time
    /// </summary>
    public required DateTime LastModified { get; set; }
    /// <summary>
    /// Size of the content in bytes
    /// </summary>
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
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many
/// create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateActionsOnPlayerSegmentTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Task details related to segment and action
    /// </summary>
    public required ActionsOnPlayersInSegmentTaskParameter Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many
/// create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateCloudScriptAzureFunctionsTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Task details related to CloudScript
    /// </summary>
    public required CloudScriptAzureFunctionsTaskParameter Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many
/// create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateCloudScriptTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Task details related to CloudScript
    /// </summary>
    public required CloudScriptTaskParameter Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
}

/// <summary>
/// Task name is unique within a title. Using a task name that's already taken will cause a name conflict error. Too many
/// create-task requests within a short time will cause a create conflict error.
/// </summary>
public class CreateInsightsScheduledScalingTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Task details related to Insights Scaling
    /// </summary>
    public required InsightsScalingTaskParameter Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
}

public class CreateOpenIdConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The client ID given by the ID provider.
    /// </summary>
    public required string ClientId { get; set; }
    /// <summary>
    /// The client secret given by the ID provider.
    /// </summary>
    public required string ClientSecret { get; set; }
    /// <summary>
    /// A name for the connection that identifies it within the title.
    /// </summary>
    public required string ConnectionId { get; set; }
    /// <summary>
    /// Ignore 'nonce' claim in identity tokens.
    /// </summary>
    public bool? IgnoreNonce { get; set; }
    /// <summary>
    /// The discovery document URL to read issuer information from. This must be the absolute URL to the JSON OpenId
    /// Configuration document and must be accessible from the internet. If you don't know it, try your issuer URL followed by
    /// "/.well-known/openid-configuration". For example, if the issuer is https://example.com, try
    /// https://example.com/.well-known/openid-configuration
    /// </summary>
    public string? IssuerDiscoveryUrl { get; set; }
    /// <summary>
    /// Manually specified information for an OpenID Connect issuer.
    /// </summary>
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    /// <summary>
    /// Override the issuer name for user indexing and lookup.
    /// </summary>
    public string? IssuerOverride { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an
/// RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class CreatePlayerSharedSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// Friendly name for this key
    /// </summary>
    public string? FriendlyName { get; set; }
}

public class CreatePlayerSharedSecretResult : PlayFabResultCommon {
    /// <summary>
    /// The player shared secret to use when calling Client/GetTitlePublicKey
    /// </summary>
    public string? SecretKey { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval
/// enables automatically resetting leaderboards on a specified interval. Upon reset, the statistic updates to a new
/// version with no values (effectively removing all players from the leaderboard). The previous version's statistic values
/// are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to
/// CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a
/// schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset
/// (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short,
/// pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also,
/// once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version
/// information (GetPlayerStatisticVersions). The AggregationMethod determines what action is taken when a new statistic
/// value is submitted - always update with the new value (Last), use the highest of the old and new values (Max), use the
/// smallest (Min), or add them together (Sum).
/// </summary>
public class CreatePlayerStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// the aggregation method to use in updating the statistic (defaults to last)
    /// </summary>
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// interval at which the values of the statistic for all players are reset (resets begin at the next interval boundary)
    /// </summary>
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class CreatePlayerStatisticDefinitionResult : PlayFabResultCommon {
    /// <summary>
    /// created statistic definition
    /// </summary>
    public PlayerStatisticDefinition? Statistic { get; set; }
}

/// <summary>
/// Send all the segment details part of CreateSegmentRequest
/// </summary>
public class CreateSegmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Segment model with all of the segment properties data.
    /// </summary>
    public required SegmentModel SegmentModel { get; set; }
}

public class CreateSegmentResponse : PlayFabResultCommon {
    /// <summary>
    /// Error message.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// Segment id.
    /// </summary>
    public string? SegmentId { get; set; }
}

public class CreateTaskResult : PlayFabResultCommon {
    /// <summary>
    /// ID of the task
    /// </summary>
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
    /// <summary>
    /// Custom property comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Custom property name.
    /// </summary>
    public string? PropertyName { get; set; }
    /// <summary>
    /// Custom property boolean value.
    /// </summary>
    public bool PropertyValue { get; set; }
}

public class CustomPropertyDateTimeSegmentFilter {
    /// <summary>
    /// Custom property comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Custom property name.
    /// </summary>
    public string? PropertyName { get; set; }
    /// <summary>
    /// Custom property datetime value.
    /// </summary>
    public required DateTime PropertyValue { get; set; }
}

public class CustomPropertyDetails {
    /// <summary>
    /// The custom property's name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The custom property's value.
    /// </summary>
    public object? Value { get; set; }
}

public class CustomPropertyNumericSegmentFilter {
    /// <summary>
    /// Custom property comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Custom property name.
    /// </summary>
    public string? PropertyName { get; set; }
    /// <summary>
    /// Custom property numeric value.
    /// </summary>
    public required double PropertyValue { get; set; }
}

public class CustomPropertyStringSegmentFilter {
    /// <summary>
    /// Custom property comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Custom property name.
    /// </summary>
    public string? PropertyName { get; set; }
    /// <summary>
    /// Custom property string value.
    /// </summary>
    public string? PropertyValue { get; set; }
}

public class DeleteContentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Key of the content item to be deleted
    /// </summary>
    public required string Key { get; set; }
}

public class DeletedPropertyDetails {
    /// <summary>
    /// The name of the property which was requested to be deleted.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Indicates whether or not the property was deleted. If false, no property with that name existed.
    /// </summary>
    public bool WasDeleted { get; set; }
}

/// <summary>
/// The request must contain the name of the sink to be deleted.
/// </summary>
public class DeleteEventSinkRequest : PlayFabRequestCommon {
    /// <summary>
    /// The sink name to be deleted.
    /// </summary>
    public required string Name { get; set; }
}

public class DeleteEventSinkResult : PlayFabResultCommon {
}

public class DeleteInventoryItemsV2SegmentAction {
    /// <summary>
    /// The collection id for where the item will be removed from the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The id of item to be removed from the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be removed from the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

public class DeleteInventoryItemV2Content {
    /// <summary>
    /// The collection id for where the item will be removed from the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The id of item to be removed from the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be removed from the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

/// <summary>
/// Deletes all data associated with the master player account, including data from all titles the player has played, such
/// as statistics, custom data, inventory, purchases, virtual currency balances, characters, group memberships, publisher
/// data, credential data, account linkages, friends list, PlayStream event data, and telemetry event data. Removes the
/// player from all leaderboards and player search indexes. Note, this API queues the player for deletion and returns a
/// receipt immediately. Record the receipt ID for future reference. It may take some time before all player data is fully
/// deleted. Upon completion of the deletion, an email will be sent to the notification email address configured for the
/// title confirming the deletion. Until the player data is fully deleted, attempts to recreate the player with the same
/// user account in the same title will fail with the 'AccountDeleted' error. It is highly recommended to know the impact
/// of the deletion by calling GetPlayedTitleList, before calling this API.
/// </summary>
public class DeleteMasterPlayerAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Developer created string to identify a user without PlayFab ID
    /// </summary>
    public string? MetaData { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class DeleteMasterPlayerAccountResult : PlayFabResultCommon {
    /// <summary>
    /// A notification email with this job receipt Id will be sent to the title notification email address when deletion is
    /// complete.
    /// </summary>
    public string? JobReceiptId { get; set; }
    /// <summary>
    /// List of titles from which the player's data will be deleted.
    /// </summary>
    public List<string>? TitleIds { get; set; }
}

/// <summary>
/// Deletes any PlayStream or telemetry event associated with the player from PlayFab. Note, this API queues the data for
/// asynchronous deletion. It may take some time before the data is deleted.
/// </summary>
public class DeleteMasterPlayerEventDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class DeleteMasterPlayerEventDataResult : PlayFabResultCommon {
}

/// <summary>
/// This API lets developers delete a membership subscription.
/// </summary>
public class DeleteMembershipSubscriptionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Id of the membership to apply the override expiration date to.
    /// </summary>
    public required string MembershipId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Id of the subscription that should be deleted from the membership.
    /// </summary>
    public required string SubscriptionId { get; set; }
}

public class DeleteMembershipSubscriptionResult : PlayFabResultCommon {
}

public class DeleteOpenIdConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// unique name of the connection
    /// </summary>
    public required string ConnectionId { get; set; }
}

public class DeletePlayerContent {
}

/// <summary>
/// Deletes custom properties for the specified player. The list of provided property names must be non-empty.
/// </summary>
public class DeletePlayerCustomPropertiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Optional field used for concurrency control. One can ensure that the delete operation will only be performed if the
    /// player's properties have not been updated by any other clients since the last version.
    /// </summary>
    public int? ExpectedPropertiesVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// A list of property names denoting which properties should be deleted.
    /// </summary>
    public required List<string> PropertyNames { get; set; }
}

public class DeletePlayerCustomPropertiesResult : PlayFabResultCommon {
    /// <summary>
    /// The list of properties requested to be deleted.
    /// </summary>
    public List<DeletedPropertyDetails>? DeletedProperties { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose properties were deleted.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Deletes all data associated with the player, including statistics, custom data, inventory, purchases, virtual currency
/// balances, characters and shared group memberships. Removes the player from all leaderboards and player search indexes.
/// Does not delete PlayStream event history associated with the player. Does not delete the publisher user account that
/// created the player in the title nor associated data such as username, password, email address, account linkages, or
/// friends list. Note, this API queues the player for deletion and returns immediately. It may take several minutes or
/// more before all player data is fully deleted. Until the player data is fully deleted, attempts to recreate the player
/// with the same user account in the same title will fail with the 'AccountDeleted' error.
/// </summary>
public class DeletePlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class DeletePlayerResult : PlayFabResultCommon {
}

public class DeletePlayerSegmentAction {
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an
/// RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class DeletePlayerSharedSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// The shared secret key to delete
    /// </summary>
    public string? SecretKey { get; set; }
}

public class DeletePlayerSharedSecretResult : PlayFabResultCommon {
}

public class DeletePlayerStatisticSegmentAction {
    /// <summary>
    /// Statistic name.
    /// </summary>
    public string? StatisticName { get; set; }
}

/// <summary>
/// Send segment id planning to delete part of DeleteSegmentRequest object
/// </summary>
public class DeleteSegmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Segment id.
    /// </summary>
    public required string SegmentId { get; set; }
}

public class DeleteSegmentsResponse : PlayFabResultCommon {
    /// <summary>
    /// Error message.
    /// </summary>
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// This non-reversible operation will permanently delete the requested store.
/// </summary>
public class DeleteStoreRequest : PlayFabRequestCommon {
    /// <summary>
    /// catalog version of the store to delete. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// unqiue identifier for the store which is to be deleted
    /// </summary>
    public required string StoreId { get; set; }
}

public class DeleteStoreResult : PlayFabResultCommon {
}

/// <summary>
/// After a task is deleted, for tracking purposes, the task instances belonging to this task will still remain. They will
/// become orphaned and does not belongs to any task. Executions of any in-progress task instances will continue. If the
/// task specified does not exist, the deletion is considered a success.
/// </summary>
public class DeleteTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specify either the task ID or the name of task to be deleted.
    /// </summary>
    public NameIdentifier? Identifier { get; set; }
}

/// <summary>
/// Will delete all the title data associated with the given override label.
/// </summary>
public class DeleteTitleDataOverrideRequest : PlayFabRequestCommon {
    /// <summary>
    /// Name of the override.
    /// </summary>
    public required string OverrideLabel { get; set; }
}

public class DeleteTitleDataOverrideResult : PlayFabResultCommon {
}

/// <summary>
/// Deletes all data associated with the title, including catalog, virtual currencies, leaderboard statistics, Cloud Script
/// revisions, segment definitions, event rules, tasks, add-ons, secret keys, data encryption keys, and permission
/// policies. Removes the title from its studio and removes all associated developer roles and permissions. Does not delete
/// PlayStream event history associated with the title. Note, this API queues the title for deletion and returns
/// immediately. It may take several hours or more before all title data is fully deleted. All player accounts in the title
/// must be deleted before deleting the title. If any player accounts exist, the API will return a
/// 'TitleContainsUserAccounts' error. Until the title data is fully deleted, attempts to call APIs with the title will
/// fail with the 'TitleDeleted' error.
/// </summary>
public class DeleteTitleRequest : PlayFabRequestCommon {
}

public class DeleteTitleResult : PlayFabResultCommon {
}

/// <summary>
/// Note that this action cannot be undone. It will unlink all accounts and remove all PII information, as well as reset
/// any statistics and leaderboards and clear out any stored custom data for the user.
/// </summary>
[Obsolete("Do not use")]
public class DeleteUsersRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// An array of unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
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
    /// <summary>
    /// Email template id.
    /// </summary>
    public string? EmailTemplateId { get; set; }
    /// <summary>
    /// Email template name.
    /// </summary>
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

public class ErrorDetails {
    /// <summary>
    /// The error code of the user configuration error if this data connection is in an error state.
    /// </summary>
    public string? Code { get; set; }
    /// <summary>
    /// Date (in UTC) when the data connection most recently entered an error state.
    /// </summary>
    public required DateTime StartTime { get; set; }
}

public class EventSink {
    /// <summary>
    /// The type of event sink. Currently only supports AzureBlobStorage.
    /// </summary>
    public ExternalDestinationType DestinationType { get; set; }
    /// <summary>
    /// Error status for the sink.
    /// </summary>
    public ErrorDetails? Error { get; set; }
    /// <summary>
    /// The usage status of the sink.
    /// </summary>
    public bool IsEnabled { get; set; }
    /// <summary>
    /// Friendly name for the event sink.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Settings for the sink.
    /// </summary>
    public required object SinkSettings { get; set; }
}

public class ExecuteAzureFunctionSegmentAction {
    /// <summary>
    /// Azure function.
    /// </summary>
    public string? AzureFunction { get; set; }
    /// <summary>
    /// Azure function parameter.
    /// </summary>
    public object? FunctionParameter { get; set; }
    /// <summary>
    /// Generate play stream event.
    /// </summary>
    public bool GenerateFunctionExecutedEvents { get; set; }
}

public class ExecuteCloudScriptContent {
    /// <summary>
    /// Arguments(JSON) to be passed into the cloudscript method
    /// </summary>
    public required string CloudScriptMethodArguments { get; set; }
    /// <summary>
    /// Cloudscript method name
    /// </summary>
    public required string CloudScriptMethodName { get; set; }
    /// <summary>
    /// Publish cloudscript results as playstream event
    /// </summary>
    public bool PublishResultsToPlayStream { get; set; }
}

public class ExecuteCloudScriptResult {
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
    public UInt32 MemoryConsumedBytes { get; set; }
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

public class ExecuteCloudScriptSegmentAction {
    /// <summary>
    /// Cloud script function.
    /// </summary>
    public string? CloudScriptFunction { get; set; }
    /// <summary>
    /// Generate play stream event.
    /// </summary>
    public bool CloudScriptPublishResultsToPlayStream { get; set; }
    /// <summary>
    /// Cloud script function parameter.
    /// </summary>
    public object? FunctionParameter { get; set; }
    /// <summary>
    /// Cloud script function parameter json text.
    /// </summary>
    public string? FunctionParameterJson { get; set; }
}

public class ExecuteFunctionContent {
    /// <summary>
    /// Arguments(JSON) to be passed into the cloudscript azure function
    /// </summary>
    public required string CloudScriptFunctionArguments { get; set; }
    /// <summary>
    /// Cloudscript azure function name
    /// </summary>
    public required string CloudScriptFunctionName { get; set; }
    /// <summary>
    /// Publish results from executing the azure function as playstream event
    /// </summary>
    public bool PublishResultsToPlayStream { get; set; }
}

public class ExecuteFunctionResult {
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

/// <summary>
/// Exports all data associated with the master player account, including data from all titles the player has played, such
/// as statistics, custom data, inventory, purchases, virtual currency balances, characters, group memberships, publisher
/// data, credential data, account linkages, friends list, PlayStream event data, and telemetry event data. Note, this API
/// queues the player for export and returns a receipt immediately. Record the receipt ID for future reference. It may take
/// some time before the export is available for download. Upon completion of the export, an email containing the URL to
/// download the export dump will be sent to the notification email address configured for the title.
/// </summary>
public class ExportMasterPlayerDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class ExportMasterPlayerDataResult : PlayFabResultCommon {
    /// <summary>
    /// An email with this job receipt Id containing the export download link will be sent to the title notification email
    /// address when the export is complete.
    /// </summary>
    public string? JobReceiptId { get; set; }
}

/// <summary>
/// Request must contain the Segment ID
/// </summary>
public class ExportPlayersInSegmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier of the requested segment.
    /// </summary>
    public required string SegmentId { get; set; }
}

public class ExportPlayersInSegmentResult : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier of the export for the requested Segment.
    /// </summary>
    public string? ExportId { get; set; }
    /// <summary>
    /// Unique identifier of the requested Segment.
    /// </summary>
    public string? SegmentId { get; set; }
}

public enum ExternalDestinationType {
    AzureBlobStorage,
    AzureDataExplorer,
    AzureBlobDelta,
}

public class FirstLoginDateSegmentFilter {
    /// <summary>
    /// First player login date comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// First player login date.
    /// </summary>
    public required DateTime LogInDate { get; set; }
}

public class FirstLoginTimespanSegmentFilter {
    /// <summary>
    /// First player login duration comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// First player login duration.
    /// </summary>
    public required double DurationInMinutes { get; set; }
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

public enum GameBuildStatus {
    Available,
    Validating,
    InvalidBuildPackage,
    Processing,
    FailedToProcess,
}

[Obsolete("Do not use")]
public class GameModeInfo {
    /// <summary>
    /// specific game mode type
    /// </summary>
    public required string Gamemode { get; set; }
    /// <summary>
    /// maximum user count a specific Game Server Instance can support
    /// </summary>
    public UInt32 MaxPlayerCount { get; set; }
    /// <summary>
    /// minimum user count required for this Game Server Instance to continue (usually 1)
    /// </summary>
    public UInt32 MinPlayerCount { get; set; }
    /// <summary>
    /// whether to start as an open session, meaning that players can matchmake into it (defaults to true)
    /// </summary>
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
    /// <summary>
    /// Action Group ID
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Action Group name
    /// </summary>
    public required string Name { get; set; }
}

public class GetActionsOnPlayersInSegmentTaskInstanceResult : PlayFabResultCommon {
    /// <summary>
    /// Parameter of this task instance
    /// </summary>
    public ActionsOnPlayersInSegmentTaskParameter? Parameter { get; set; }
    /// <summary>
    /// Status summary of the actions-on-players-in-segment task instance
    /// </summary>
    public ActionsOnPlayersInSegmentTaskSummary? Summary { get; set; }
}

[Obsolete("Do not use")]
public class GetAllActionGroupsRequest : PlayFabRequestCommon {
}

[Obsolete("Do not use")]
public class GetAllActionGroupsResult : PlayFabResultCommon {
    /// <summary>
    /// List of Action Groups.
    /// </summary>
    public required List<GetActionGroupResult> ActionGroups { get; set; }
}

/// <summary>
/// Request has no paramaters.
/// </summary>
public class GetAllSegmentsRequest : PlayFabRequestCommon {
}

public class GetAllSegmentsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of segments for this title.
    /// </summary>
    public List<GetSegmentResult>? Segments { get; set; }
}

public class GetCatalogItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Which catalog is being requested. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
}

public class GetCatalogItemsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items which can be purchased.
    /// </summary>
    public List<CatalogItem>? Catalog { get; set; }
}

public class GetCloudScriptAzureFunctionsTaskInstanceResult : PlayFabResultCommon {
    /// <summary>
    /// Parameter of this task instance
    /// </summary>
    public CloudScriptAzureFunctionsTaskParameter? Parameter { get; set; }
    /// <summary>
    /// Status summary of the CloudScript Azure Functions task instance
    /// </summary>
    public CloudScriptAzureFunctionsTaskSummary? Summary { get; set; }
}

public class GetCloudScriptRevisionRequest : PlayFabRequestCommon {
    /// <summary>
    /// Revision number. If left null, defaults to the latest revision
    /// </summary>
    public int? Revision { get; set; }
    /// <summary>
    /// Version number. If left null, defaults to the latest version
    /// </summary>
    public int? Version { get; set; }
}

public class GetCloudScriptRevisionResult : PlayFabResultCommon {
    /// <summary>
    /// Time this revision was created
    /// </summary>
    public required DateTime CreatedAt { get; set; }
    /// <summary>
    /// List of Cloud Script files in this revision.
    /// </summary>
    public List<CloudScriptFile>? Files { get; set; }
    /// <summary>
    /// True if this is the currently published revision
    /// </summary>
    public bool IsPublished { get; set; }
    /// <summary>
    /// Revision number.
    /// </summary>
    public int Revision { get; set; }
    /// <summary>
    /// Version number.
    /// </summary>
    public int Version { get; set; }
}

public class GetCloudScriptTaskInstanceResult : PlayFabResultCommon {
    /// <summary>
    /// Parameter of this task instance
    /// </summary>
    public CloudScriptTaskParameter? Parameter { get; set; }
    /// <summary>
    /// Status summary of the CloudScript task instance
    /// </summary>
    public CloudScriptTaskSummary? Summary { get; set; }
}

public class GetCloudScriptVersionsRequest : PlayFabRequestCommon {
}

public class GetCloudScriptVersionsResult : PlayFabResultCommon {
    /// <summary>
    /// List of versions
    /// </summary>
    public List<CloudScriptVersionStatus>? Versions { get; set; }
}

public class GetContentListRequest : PlayFabRequestCommon {
    /// <summary>
    /// Limits the response to keys that begin with the specified prefix. You can use prefixes to list contents under a folder,
    /// or for a specified version, etc.
    /// </summary>
    public string? Prefix { get; set; }
}

public class GetContentListResult : PlayFabResultCommon {
    /// <summary>
    /// List of content items.
    /// </summary>
    public List<ContentInfo>? Contents { get; set; }
    /// <summary>
    /// Number of content items returned. We currently have a maximum of 1000 items limit.
    /// </summary>
    public int ItemCount { get; set; }
    /// <summary>
    /// The total size of listed contents in bytes.
    /// </summary>
    public UInt32 TotalSize { get; set; }
}

public class GetContentUploadUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// A standard MIME type describing the format of the contents. The same MIME type has to be set in the header when
    /// uploading the content. If not specified, the MIME type is 'binary/octet-stream' by default.
    /// </summary>
    public string? ContentType { get; set; }
    /// <summary>
    /// Key of the content item to upload, usually formatted as a path, e.g. images/a.png
    /// </summary>
    public required string Key { get; set; }
}

public class GetContentUploadUrlResult : PlayFabResultCommon {
    /// <summary>
    /// URL for uploading content via HTTP PUT method. The URL requires the 'x-ms-blob-type' header to have the value
    /// 'BlockBlob'. The URL will expire in approximately one hour.
    /// </summary>
    public string? URL { get; set; }
}

/// <summary>
/// Gets the download URL for the requested report data (in CSV form). The reports available through this API call are
/// those available in the Game Manager, in the Analytics->Reports tab.
/// </summary>
public class GetDataReportRequest : PlayFabRequestCommon {
    /// <summary>
    /// Reporting year (UTC)
    /// </summary>
    public int Day { get; set; }
    /// <summary>
    /// Reporting month (UTC)
    /// </summary>
    public int Month { get; set; }
    /// <summary>
    /// Report name
    /// </summary>
    public required string ReportName { get; set; }
    /// <summary>
    /// Reporting year (UTC)
    /// </summary>
    public int Year { get; set; }
}

public class GetDataReportResult : PlayFabResultCommon {
    /// <summary>
    /// The URL where the requested report can be downloaded. This can be any PlayFab generated reports. The full list of
    /// reports can be found at: https://docs.microsoft.com/en-us/gaming/playfab/features/analytics/reports/quickstart.
    /// </summary>
    public string? DownloadUrl { get; set; }
}

/// <summary>
/// Request has no parameters.
/// </summary>
public class GetEventSinksRequest : PlayFabRequestCommon {
}

public class GetEventSinksResult : PlayFabResultCommon {
    /// <summary>
    /// The set of sinks to which to route PlayStream and Telemetry event data.
    /// </summary>
    public required List<EventSink> Sinks { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// unique identifier of the lobby for which info is being requested
    /// </summary>
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameInfoResult : PlayFabResultCommon {
    /// <summary>
    /// version identifier of the game server executable binary being run
    /// </summary>
    public string? BuildVersion { get; set; }
    /// <summary>
    /// time when Game Server Instance is currently scheduled to end
    /// </summary>
    public DateTime? EndTime { get; set; }
    /// <summary>
    /// unique identifier of the lobby
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// game mode for this Game Server Instance
    /// </summary>
    public string? Mode { get; set; }
    /// <summary>
    /// array of unique PlayFab identifiers for users currently connected to this Game Server Instance
    /// </summary>
    public List<string>? Players { get; set; }
    /// <summary>
    /// region in which the Game Server Instance is running
    /// </summary>
    public Region? Region { get; set; }
    /// <summary>
    /// IPV4 address of the game server instance
    /// </summary>
    public string? ServerAddress { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// IPV6 address of the server
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// communication port for this Game Server Instance
    /// </summary>
    public UInt32 ServerPort { get; set; }
    /// <summary>
    /// Public DNS name (if any) of the server
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
    /// <summary>
    /// time when the Game Server Instance was created
    /// </summary>
    public required DateTime StartTime { get; set; }
    /// <summary>
    /// unique identifier of the Game Server Instance for this lobby
    /// </summary>
    public string? TitleId { get; set; }
}

/// <summary>
/// These details are used by the PlayFab matchmaking service to determine if an existing Game Server Instance has room for
/// additional users, and by the PlayFab game server management service to determine when a new Game Server Host should be
/// created in order to prevent excess load on existing Hosts.
/// </summary>
[Obsolete("Do not use")]
public class GetMatchmakerGameModesRequest : PlayFabRequestCommon {
    /// <summary>
    /// previously uploaded build version for which game modes are being requested
    /// </summary>
    public required string BuildVersion { get; set; }
}

[Obsolete("Do not use")]
public class GetMatchmakerGameModesResult : PlayFabResultCommon {
    /// <summary>
    /// array of game modes available for the specified build
    /// </summary>
    public List<GameModeInfo>? GameModes { get; set; }
}

/// <summary>
/// Useful for identifying titles of which the player's data will be deleted by DeleteMasterPlayer.
/// </summary>
public class GetPlayedTitleListRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetPlayedTitleListResult : PlayFabResultCommon {
    /// <summary>
    /// List of titles the player has played
    /// </summary>
    public List<string>? TitleIds { get; set; }
}

public class GetPlayerCustomPropertyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Specific property name to search for in the player's properties.
    /// </summary>
    public required string PropertyName { get; set; }
}

public class GetPlayerCustomPropertyResult : PlayFabResultCommon {
    /// <summary>
    /// PlayFab unique identifier of the user whose properties are being returned.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
    /// <summary>
    /// Player specific property and its corresponding value.
    /// </summary>
    public CustomPropertyDetails? Property { get; set; }
}

/// <summary>
/// Gets a player ID from an auth token. The token expires after 30 minutes and cannot be used to look up a player when
/// expired.
/// </summary>
public class GetPlayerIdFromAuthTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The auth token of the player requesting the password reset.
    /// </summary>
    public required string Token { get; set; }
    /// <summary>
    /// The type of auth token of the player requesting the password reset.
    /// </summary>
    public AuthTokenType TokenType { get; set; }
}

public class GetPlayerIdFromAuthTokenResult : PlayFabResultCommon {
    /// <summary>
    /// The player ID from the token passed in
    /// </summary>
    public string? PlayFabId { get; set; }
}

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer
/// support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care
/// should be taken in how this data is stored and managed. Since this call will always return the relevant information for
/// users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class GetPlayerProfileRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
}

public class GetPlayerProfileResult : PlayFabResultCommon {
    /// <summary>
    /// The profile of the player. This profile is not guaranteed to be up-to-date. For a new player, this profile will not
    /// exist.
    /// </summary>
    public PlayerProfileModel? PlayerProfile { get; set; }
}

public class GetPlayerSegmentsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of segments the requested player currently belongs to.
    /// </summary>
    public List<GetSegmentResult>? Segments { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an
/// RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class GetPlayerSharedSecretsRequest : PlayFabRequestCommon {
}

public class GetPlayerSharedSecretsResult : PlayFabResultCommon {
    /// <summary>
    /// The player shared secret to use when calling Client/GetTitlePublicKey
    /// </summary>
    public List<SharedSecret>? SharedSecrets { get; set; }
}

/// <summary>
/// Request must contain the ExportId
/// </summary>
public class GetPlayersInSegmentExportRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier of the export for the requested Segment.
    /// </summary>
    public required string ExportId { get; set; }
}

public class GetPlayersInSegmentExportResponse : PlayFabResultCommon {
    /// <summary>
    /// Url from which the index file can be downloaded.
    /// </summary>
    public string? IndexUrl { get; set; }
    /// <summary>
    /// Shows the current status of the export
    /// </summary>
    public string? State { get; set; }
}

/// <summary>
/// Initial request must contain at least a Segment ID. Subsequent requests must contain the Segment ID as well as the
/// Continuation Token. Failure to send the Continuation Token will result in a new player segment list being generated.
/// Each time the Continuation Token is passed in the length of the Total Seconds to Live is refreshed. If too much time
/// passes between requests to the point that a subsequent request is past the Total Seconds to Live an error will be
/// returned and paging will be terminated. This API is resource intensive and should not be used in scenarios which might
/// generate high request volumes. Only one request to this API at a time should be made per title. Concurrent requests to
/// the API may be rejected with the APIConcurrentRequestLimitExceeded error.
/// </summary>
public class GetPlayersInSegmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Continuation token if retrieving subsequent pages of results.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If set to true, the profiles are loaded asynchronously and the response will include a continuation token and
    /// approximate profile count until the first batch of profiles is loaded. Use this parameter to help avoid network
    /// timeouts.
    /// </summary>
    public bool? GetProfilesAsync { get; set; }
    /// <summary>
    /// Maximum is 10,000. The value 0 will prevent loading any profiles and return only the count of profiles matching this
    /// segment.
    /// </summary>
    public UInt32? MaxBatchSize { get; set; }
    /// <summary>
    /// Number of seconds to keep the continuation token active. After token expiration it is not possible to continue paging
    /// results. Default is 300 (5 minutes). Maximum is 5,400 (90 minutes).
    /// </summary>
    public UInt32? SecondsToLive { get; set; }
    /// <summary>
    /// Unique identifier for this segment.
    /// </summary>
    public required string SegmentId { get; set; }
}

public class GetPlayersInSegmentResult : PlayFabResultCommon {
    /// <summary>
    /// Continuation token to use to retrieve subsequent pages of results. If token returns null there are no more results.
    /// </summary>
    public string? ContinuationToken { get; set; }
    /// <summary>
    /// Array of player profiles in this segment.
    /// </summary>
    public List<PlayerProfile>? PlayerProfiles { get; set; }
    /// <summary>
    /// Count of profiles matching this segment.
    /// </summary>
    public int ProfilesInSegment { get; set; }
}

public class GetPlayersSegmentsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetPlayerStatisticDefinitionsRequest : PlayFabRequestCommon {
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval
/// defines the period of time at which the leaderboard for the statistic will automatically reset. Upon reset, the
/// statistic updates to a new version with no values (effectively removing all players from the leaderboard). The previous
/// version's statistic values are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not
/// created via a call to CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do
/// not reset on a schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic
/// has been reset (sometimes referred to as versioned or incremented), the previous version can still be written to for up
/// a short, pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the
/// reset. Also, once reset, the historical statistics for players in the title may be retrieved using the URL specified in
/// the version information (GetPlayerStatisticVersions). The AggregationMethod defines what action is taken when a new
/// statistic value is submitted - always update with the new value (Last), use the highest of the old and new values
/// (Max), use the smallest (Min), or add them together (Sum).
/// </summary>
public class GetPlayerStatisticDefinitionsResult : PlayFabResultCommon {
    /// <summary>
    /// the player statistic definitions for the title
    /// </summary>
    public List<PlayerStatisticDefinition>? Statistics { get; set; }
}

public class GetPlayerStatisticVersionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public string? StatisticName { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The information returned
/// in the results defines the state of a specific version of a statistic, including when it was or will become the
/// currently active version, when it will (or did) become a previous version, and its archival state if it is no longer
/// the active version. For a statistic which has been reset, once the archival status is Complete, the full set of
/// statistics for all players in the leaderboard for that version may be retrieved via the ArchiveDownloadUrl. Statistics
/// which have not been reset (incremented/versioned) will only have a single version which is not scheduled to reset.
/// </summary>
public class GetPlayerStatisticVersionsResult : PlayFabResultCommon {
    /// <summary>
    /// version change history of the statistic
    /// </summary>
    public List<PlayerStatisticVersion>? StatisticVersions { get; set; }
}

/// <summary>
/// This API will return a list of canonical tags which includes both namespace and tag's name. If namespace is not
/// provided, the result is a list of all canonical tags. TagName can be used for segmentation and Namespace is limited to
/// 128 characters.
/// </summary>
public class GetPlayerTagsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Optional namespace to filter results by
    /// </summary>
    public string? Namespace { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetPlayerTagsResult : PlayFabResultCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Canonical tags (including namespace and tag's name) for the requested user
    /// </summary>
    public required List<string> Tags { get; set; }
}

/// <summary>
/// Views the requested policy. Today, the only supported policy is 'ApiPolicy'.
/// </summary>
public class GetPolicyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The name of the policy to read. Only supported name is 'ApiPolicy'.
    /// </summary>
    public string? PolicyName { get; set; }
}

public class GetPolicyResponse : PlayFabResultCommon {
    /// <summary>
    /// The name of the policy read.
    /// </summary>
    public string? PolicyName { get; set; }
    /// <summary>
    /// Policy version.
    /// </summary>
    public int PolicyVersion { get; set; }
    /// <summary>
    /// The statements in the requested policy.
    /// </summary>
    public List<PermissionStatement>? Statements { get; set; }
}

/// <summary>
/// This API is designed to return publisher-specific values which can be read, but not written to, by the client. This
/// data is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only
/// titles assigned to a publisher can use this API. For more information email helloplayfab@microsoft.com. This AdminAPI
/// call for getting title data guarantees no delay in between update and retrieval of newly set data.
/// </summary>
public class GetPublisherDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// array of keys to get back data from the Publisher data blob, set by the admin tools
    /// </summary>
    public required List<string> Keys { get; set; }
}

public class GetPublisherDataResult : PlayFabResultCommon {
    /// <summary>
    /// a dictionary object of key / value pairs
    /// </summary>
    public Dictionary<string, string>? Data { get; set; }
}

public class GetRandomResultTablesRequest : PlayFabRequestCommon {
    /// <summary>
    /// catalog version to fetch tables from. Use default catalog version if null
    /// </summary>
    public string? CatalogVersion { get; set; }
}

public class GetRandomResultTablesResult : PlayFabResultCommon {
    /// <summary>
    /// array of random result tables currently available
    /// </summary>
    public Dictionary<string, RandomResultTableListing>? Tables { get; set; }
}

public class GetSegmentResult {
    /// <summary>
    /// Identifier of the segments AB Test, if it is attached to one.
    /// </summary>
    public string? ABTestParent { get; set; }
    /// <summary>
    /// Unique identifier for this segment.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Segment name.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Given input segment ids, return list of segments.
/// </summary>
public class GetSegmentsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Segment ids to filter title segments.
    /// </summary>
    public required List<string> SegmentIds { get; set; }
}

public class GetSegmentsResponse : PlayFabResultCommon {
    /// <summary>
    /// Error message.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// List of title segments.
    /// </summary>
    public List<SegmentModel>? Segments { get; set; }
}

[Obsolete("Do not use")]
public class GetServerBuildInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// unique identifier of the previously uploaded build executable for which information is being requested
    /// </summary>
    public required string BuildId { get; set; }
}

/// <summary>
/// Information about a particular server build
/// </summary>
[Obsolete("Do not use")]
public class GetServerBuildInfoResult : PlayFabResultCommon {
    /// <summary>
    /// array of regions where this build can used, when it is active
    /// </summary>
    public List<Region>? ActiveRegions { get; set; }
    /// <summary>
    /// unique identifier for this build executable
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// developer comment(s) for this build
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// error message, if any, about this build
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// maximum number of game server instances that can run on a single host machine
    /// </summary>
    public int MaxGamesPerHost { get; set; }
    /// <summary>
    /// minimum capacity of additional game server instances that can be started before the autoscaling service starts new host
    /// machines (given the number of current running host machines and game server instances)
    /// </summary>
    public int MinFreeGameSlots { get; set; }
    /// <summary>
    /// the current status of the build validation and processing steps
    /// </summary>
    public GameBuildStatus? Status { get; set; }
    /// <summary>
    /// time this build was last modified (or uploaded, if this build has never been modified)
    /// </summary>
    public required DateTime Timestamp { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public string? TitleId { get; set; }
}

/// <summary>
/// A store contains an array of references to items defined in the catalog, along with the prices for the item, in both
/// real world and virtual currencies. These prices act as an override to any prices defined in the catalog. In this way,
/// the base definitions of the items may be defined in the catalog, with all associated properties, while the pricing can
/// be set for each store, as needed. This allows for subsets of goods to be defined for different purposes (in order to
/// simplify showing some, but not all catalog items to users, based upon different characteristics), along with unique
/// prices. Note that all prices defined in the catalog and store definitions for the item are considered valid, and that a
/// compromised client can be made to send a request for an item based upon any of these definitions. If no price is
/// specified in the store for an item, the price set in the catalog should be displayed to the user.
/// </summary>
public class GetStoreItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version to store items from. Use default catalog version if null
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unqiue identifier for the store which is being requested.
    /// </summary>
    public required string StoreId { get; set; }
}

public class GetStoreItemsResult : PlayFabResultCommon {
    /// <summary>
    /// The base catalog that this store is a part of.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Additional data about the store.
    /// </summary>
    public StoreMarketingModel? MarketingData { get; set; }
    /// <summary>
    /// How the store was last updated (Admin or a third party).
    /// </summary>
    public SourceType? Source { get; set; }
    /// <summary>
    /// Array of items which can be purchased from this store.
    /// </summary>
    public List<StoreItem>? Store { get; set; }
    /// <summary>
    /// The ID of this store.
    /// </summary>
    public string? StoreId { get; set; }
}

/// <summary>
/// The result includes detail information that's specific to a CloudScript task. Only CloudScript tasks configured as "Run
/// Cloud Script function once" will be retrieved. To get a list of task instances by task, status, or time range, use
/// GetTaskInstances.
/// </summary>
public class GetTaskInstanceRequest : PlayFabRequestCommon {
    /// <summary>
    /// ID of the requested task instance.
    /// </summary>
    public required string TaskInstanceId { get; set; }
}

/// <summary>
/// Only the most recent 100 task instances are returned, ordered by start time descending. The results are generic basic
/// information for task instances. To get detail information specific to each task type, use Get*TaskInstance based on its
/// corresponding task type.
/// </summary>
public class GetTaskInstancesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Optional range-from filter for task instances' StartedAt timestamp.
    /// </summary>
    public DateTime? StartedAtRangeFrom { get; set; }
    /// <summary>
    /// Optional range-to filter for task instances' StartedAt timestamp.
    /// </summary>
    public DateTime? StartedAtRangeTo { get; set; }
    /// <summary>
    /// Optional filter for task instances that are of a specific status.
    /// </summary>
    public TaskInstanceStatus? StatusFilter { get; set; }
    /// <summary>
    /// Name or ID of the task whose instances are being queried. If not specified, return all task instances that satisfy
    /// conditions set by other filters.
    /// </summary>
    public NameIdentifier? TaskIdentifier { get; set; }
}

public class GetTaskInstancesResult : PlayFabResultCommon {
    /// <summary>
    /// Basic status summaries of the queried task instances. Empty If no task instances meets the filter criteria. To get
    /// detailed status summary, use Get*TaskInstance API according to task type (e.g.
    /// GetActionsOnPlayersInSegmentTaskInstance).
    /// </summary>
    public List<TaskInstanceBasicSummary>? Summaries { get; set; }
}

public class GetTasksRequest : PlayFabRequestCommon {
    /// <summary>
    /// Provide either the task ID or the task name to get a specific task. If not specified, return all defined tasks.
    /// </summary>
    public NameIdentifier? Identifier { get; set; }
}

public class GetTasksResult : PlayFabResultCommon {
    /// <summary>
    /// Result tasks. Empty if there is no task found.
    /// </summary>
    public List<ScheduledTask>? Tasks { get; set; }
}

/// <summary>
/// This API method is designed to return title specific values which can be read by the client. For example, a developer
/// could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths, movement
/// speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new build. If an
/// override label is specified in the request, the overrides are applied automatically and returned with the title data.
/// Note that due to caching, there may up to a minute delay in between updating title data and a query returning the
/// newest value.
/// </summary>
public class GetTitleDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specific keys to search for in the title data (leave null to get all keys)
    /// </summary>
    public List<string>? Keys { get; set; }
    /// <summary>
    /// Optional field that specifies the name of an override. This value is ignored when used by the game client; otherwise,
    /// the overrides are applied automatically to the title data.
    /// </summary>
    public string? OverrideLabel { get; set; }
}

public class GetTitleDataResult : PlayFabResultCommon {
    /// <summary>
    /// a dictionary object of key / value pairs
    /// </summary>
    public Dictionary<string, string>? Data { get; set; }
}

/// <summary>
/// Get all bans for a user, including inactive and expired bans.
/// </summary>
public class GetUserBansRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetUserBansResult : PlayFabResultCommon {
    /// <summary>
    /// Information about the bans
    /// </summary>
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// Data is stored as JSON key-value pairs. If the Keys parameter is provided, the data object returned will only contain
/// the data specific to the indicated Keys. Otherwise, the full set of custom user data will be returned.
/// </summary>
public class GetUserDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// The version that currently exists according to the caller. The call will return the data for all of the keys if the
    /// version in the system is greater than this.
    /// </summary>
    public UInt32? IfChangedFromDataVersion { get; set; }
    /// <summary>
    /// Specific keys to search for in the custom user data.
    /// </summary>
    public List<string>? Keys { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetUserDataResult : PlayFabResultCommon {
    /// <summary>
    /// User specific data for this title.
    /// </summary>
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    /// <summary>
    /// Indicates the current version of the data that has been set. This is incremented with every set call for that type of
    /// data (read-only, internal, etc). This version can be provided in Get calls to find updated data.
    /// </summary>
    public UInt32 DataVersion { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose custom data is being returned.
    /// </summary>
    public string? PlayFabId { get; set; }
}

/// <summary>
/// All items currently in the user inventory will be returned, irrespective of how they were acquired (via purchasing,
/// grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the
/// user's current inventory, and so will not be not included. There can be a delay of up to a half a second for inventory
/// changes to be reflected in the GetUserInventory API response.
/// </summary>
public class GetUserInventoryRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class GetUserInventoryResult : PlayFabResultCommon {
    /// <summary>
    /// Array of inventory items belonging to the user.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Array of virtual currency balance(s) belonging to the user.
    /// </summary>
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    /// <summary>
    /// Array of remaining times and timestamps for virtual currencies.
    /// </summary>
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

/// <summary>
/// Result of granting an item to a user. Note, to retrieve additional information for an item such as Tags, Description
/// that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of can be matched
/// to a catalog entry, which contains the additional information. Also note that Custom Data is only set when the User's
/// specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other fields such as
/// UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
public class GrantedItemInstance {
    /// <summary>
    /// Game specific comment associated with this instance when it was added to the user inventory.
    /// </summary>
    public string? Annotation { get; set; }
    /// <summary>
    /// Array of unique items that were awarded when this catalog item was purchased.
    /// </summary>
    public List<string>? BundleContents { get; set; }
    /// <summary>
    /// Unique identifier for the parent inventory item, as defined in the catalog, for object which were added from a bundle
    /// or container.
    /// </summary>
    public string? BundleParent { get; set; }
    /// <summary>
    /// Catalog version for the inventory item, when this instance was created.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// A set of custom key-value pairs on the instance of the inventory item, which is not to be confused with the catalog
    /// item's custom data.
    /// </summary>
    public Dictionary<string, string>? CustomData { get; set; }
    /// <summary>
    /// CatalogItem.DisplayName at the time this item was purchased.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Timestamp for when this instance will expire.
    /// </summary>
    public DateTime? Expiration { get; set; }
    /// <summary>
    /// Class name for the inventory item, as defined in the catalog.
    /// </summary>
    public string? ItemClass { get; set; }
    /// <summary>
    /// Unique identifier for the inventory item, as defined in the catalog.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Unique item identifier for this specific instance of the item.
    /// </summary>
    public string? ItemInstanceId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Timestamp for when this instance was purchased.
    /// </summary>
    public DateTime? PurchaseDate { get; set; }
    /// <summary>
    /// Total number of remaining uses, if this is a consumable item.
    /// </summary>
    public int? RemainingUses { get; set; }
    /// <summary>
    /// Result of this operation.
    /// </summary>
    public bool Result { get; set; }
    /// <summary>
    /// Currency type for the cost of the catalog item. Not available when granting items.
    /// </summary>
    public string? UnitCurrency { get; set; }
    /// <summary>
    /// Cost of the catalog item in the given currency. Not available when granting items.
    /// </summary>
    public UInt32 UnitPrice { get; set; }
    /// <summary>
    /// The number of uses that were added or removed to this item in this call.
    /// </summary>
    public int? UsesIncrementedBy { get; set; }
}

public class GrantItemContent {
    /// <summary>
    /// The catalog version of the item to be granted to the player
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The id of item to be granted to the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Quantity of the item to be granted to a player
    /// </summary>
    public int ItemQuantity { get; set; }
}

public class GrantItemSegmentAction {
    /// <summary>
    /// Item catalog id.
    /// </summary>
    public string? CatelogId { get; set; }
    /// <summary>
    /// Item id.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Item quantity.
    /// </summary>
    public UInt32 Quantity { get; set; }
}

/// <summary>
/// This function directly adds inventory items to user inventories. As a result of this operations, the user will not be
/// charged any transaction fee, regardless of the inventory item catalog definition. Please note that the processing time
/// for inventory grants and purchases increases fractionally the more items are in the inventory, and the more items are
/// in the grant/purchase operation.
/// </summary>
public class GrantItemsToUsersRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version from which items are to be granted.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Array of items to grant and the users to whom the items are to be granted.
    /// </summary>
    public required List<ItemGrant> ItemGrants { get; set; }
}

/// <summary>
/// Please note that the order of the items in the response may not match the order of items in the request.
/// </summary>
public class GrantItemsToUsersResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items granted to users.
    /// </summary>
    public List<GrantedItemInstance>? ItemGrantResults { get; set; }
}

public class GrantVirtualCurrencyContent {
    /// <summary>
    /// Amount of currency to be granted to a player
    /// </summary>
    public int CurrencyAmount { get; set; }
    /// <summary>
    /// Code of the currency to be granted to a player
    /// </summary>
    public required string CurrencyCode { get; set; }
}

public class GrantVirtualCurrencySegmentAction {
    /// <summary>
    /// Virtual currency amount.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// Virtual currency code.
    /// </summary>
    public string? CurrencyCode { get; set; }
}

/// <summary>
/// This operation will increment the global counter for the number of these items available. This number cannot be
/// decremented, except by actual grants.
/// </summary>
public class IncrementLimitedEditionItemAvailabilityRequest : PlayFabRequestCommon {
    /// <summary>
    /// Amount to increase availability by.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// Which catalog is being updated. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The item which needs more availability.
    /// </summary>
    public required string ItemId { get; set; }
}

public class IncrementLimitedEditionItemAvailabilityResult : PlayFabResultCommon {
}

public class IncrementPlayerStatisticContent {
    /// <summary>
    /// Amount(in whole number) to increase the player statistic by
    /// </summary>
    public int StatisticChangeBy { get; set; }
    /// <summary>
    /// Name of the player statistic to be incremented
    /// </summary>
    public required string StatisticName { get; set; }
}

public class IncrementPlayerStatisticSegmentAction {
    /// <summary>
    /// Increment value.
    /// </summary>
    public int IncrementValue { get; set; }
    /// <summary>
    /// Statistic name.
    /// </summary>
    public string? StatisticName { get; set; }
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. When this call is made
/// on a given statistic, this forces a reset of that statistic. Upon reset, the statistic updates to a new version with no
/// values (effectively removing all players from the leaderboard). The previous version's statistic values are also
/// archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to
/// CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a
/// schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset
/// (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short,
/// pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also,
/// once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version
/// information (GetPlayerStatisticVersions).
/// </summary>
public class IncrementPlayerStatisticVersionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public string? StatisticName { get; set; }
}

public class IncrementPlayerStatisticVersionResult : PlayFabResultCommon {
    /// <summary>
    /// version change history of the statistic
    /// </summary>
    public PlayerStatisticVersion? StatisticVersion { get; set; }
}

public class InsightsScalingTaskParameter {
    /// <summary>
    /// Insights Performance Level to scale to.
    /// </summary>
    public int Level { get; set; }
}

public class ItemGrant {
    /// <summary>
    /// String detailing any additional information concerning this operation.
    /// </summary>
    public string? Annotation { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Key-value pairs to be written to the custom data. Note that keys are trimmed of whitespace, are limited in size, and
    /// may not begin with a '!' character or be null.
    /// </summary>
    public Dictionary<string, string>? Data { get; set; }
    /// <summary>
    /// Unique identifier of the catalog item to be granted to the user.
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// Optional list of Data-keys to remove from UserData. Some SDKs cannot insert null-values into Data due to language
    /// constraints. Use this to delete the keys directly.
    /// </summary>
    public List<string>? KeysToRemove { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

/// <summary>
/// A unique instance of an item in a user's inventory. Note, to retrieve additional information for an item such as Tags,
/// Description that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of
/// can be matched to a catalog entry, which contains the additional information. Also note that Custom Data is only set
/// when the User's specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other
/// fields such as UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
public class ItemInstance {
    /// <summary>
    /// Game specific comment associated with this instance when it was added to the user inventory.
    /// </summary>
    public string? Annotation { get; set; }
    /// <summary>
    /// Array of unique items that were awarded when this catalog item was purchased.
    /// </summary>
    public List<string>? BundleContents { get; set; }
    /// <summary>
    /// Unique identifier for the parent inventory item, as defined in the catalog, for object which were added from a bundle
    /// or container.
    /// </summary>
    public string? BundleParent { get; set; }
    /// <summary>
    /// Catalog version for the inventory item, when this instance was created.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// A set of custom key-value pairs on the instance of the inventory item, which is not to be confused with the catalog
    /// item's custom data.
    /// </summary>
    public Dictionary<string, string>? CustomData { get; set; }
    /// <summary>
    /// CatalogItem.DisplayName at the time this item was purchased.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Timestamp for when this instance will expire.
    /// </summary>
    public DateTime? Expiration { get; set; }
    /// <summary>
    /// Class name for the inventory item, as defined in the catalog.
    /// </summary>
    public string? ItemClass { get; set; }
    /// <summary>
    /// Unique identifier for the inventory item, as defined in the catalog.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Unique item identifier for this specific instance of the item.
    /// </summary>
    public string? ItemInstanceId { get; set; }
    /// <summary>
    /// Timestamp for when this instance was purchased.
    /// </summary>
    public DateTime? PurchaseDate { get; set; }
    /// <summary>
    /// Total number of remaining uses, if this is a consumable item.
    /// </summary>
    public int? RemainingUses { get; set; }
    /// <summary>
    /// Currency type for the cost of the catalog item. Not available when granting items.
    /// </summary>
    public string? UnitCurrency { get; set; }
    /// <summary>
    /// Cost of the catalog item in the given currency. Not available when granting items.
    /// </summary>
    public UInt32 UnitPrice { get; set; }
    /// <summary>
    /// The number of uses that were added or removed to this item in this call.
    /// </summary>
    public int? UsesIncrementedBy { get; set; }
}

public class LastLoginDateSegmentFilter {
    /// <summary>
    /// Last player login date comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Last player login date.
    /// </summary>
    public required DateTime LogInDate { get; set; }
}

public class LastLoginTimespanSegmentFilter {
    /// <summary>
    /// Last player login duration comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Last player login duration.
    /// </summary>
    public required double DurationInMinutes { get; set; }
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

public class LinkedUserAccountHasEmailSegmentFilter {
    /// <summary>
    /// Login provider comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Login provider.
    /// </summary>
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

public class LinkedUserAccountSegmentFilter {
    /// <summary>
    /// Login provider.
    /// </summary>
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

[Obsolete("Do not use")]
public class ListBuildsRequest : PlayFabRequestCommon {
}

[Obsolete("Do not use")]
public class ListBuildsResult : PlayFabResultCommon {
    /// <summary>
    /// array of uploaded game server builds
    /// </summary>
    public List<GetServerBuildInfoResult>? Builds { get; set; }
}

public class ListOpenIdConnectionRequest : PlayFabRequestCommon {
}

public class ListOpenIdConnectionResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of Open ID Connections
    /// </summary>
    public List<OpenIdConnection>? Connections { get; set; }
}

public class ListPlayerCustomPropertiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class ListPlayerCustomPropertiesResult : PlayFabResultCommon {
    /// <summary>
    /// PlayFab unique identifier of the user whose properties are being returned.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Player specific properties and their corresponding values for this title.
    /// </summary>
    public List<CustomPropertyDetails>? Properties { get; set; }
    /// <summary>
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
}

public class ListVirtualCurrencyTypesRequest : PlayFabRequestCommon {
}

public class ListVirtualCurrencyTypesResult : PlayFabResultCommon {
    /// <summary>
    /// List of virtual currency names defined for this title
    /// </summary>
    public List<VirtualCurrencyData>? VirtualCurrencies { get; set; }
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

public class LocationSegmentFilter {
    /// <summary>
    /// Segment country code.
    /// </summary>
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

/// <summary>
/// This API allows for access to details regarding a user in the PlayFab service, usually for purposes of customer
/// support. Note that data returned may be Personally Identifying Information (PII), such as email address, and so care
/// should be taken in how this data is stored and managed. Since this call will always return the relevant information for
/// users who have accessed the title, the recommendation is to not store this data locally.
/// </summary>
public class LookupUserAccountInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// User email address attached to their account
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Title specific username to match against existing user accounts
    /// </summary>
    public string? TitleDisplayName { get; set; }
    /// <summary>
    /// PlayFab username for the account (3-20 characters)
    /// </summary>
    public string? Username { get; set; }
}

public class LookupUserAccountInfoResult : PlayFabResultCommon {
    /// <summary>
    /// User info for the user matching the request
    /// </summary>
    public UserAccountInfo? UserInfo { get; set; }
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
/// These details are used by the PlayFab matchmaking service to determine if an existing Game Server Instance has room for
/// additional users, and by the PlayFab game server management service to determine when a new Game Server Host should be
/// created in order to prevent excess load on existing Hosts. This operation is not additive. Using it will cause the game
/// mode definition for the game server executable in question to be created from scratch. If there is an existing game
/// server mode definition for the given BuildVersion, it will be deleted and replaced with the data specified in this call.
/// </summary>
[Obsolete("Do not use")]
public class ModifyMatchmakerGameModesRequest : PlayFabRequestCommon {
    /// <summary>
    /// previously uploaded build version for which game modes are being specified
    /// </summary>
    public required string BuildVersion { get; set; }
    /// <summary>
    /// array of game modes (Note: this will replace all game modes for the indicated build version)
    /// </summary>
    public required List<GameModeInfo> GameModes { get; set; }
}

[Obsolete("Do not use")]
public class ModifyMatchmakerGameModesResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class ModifyServerBuildRequest : PlayFabRequestCommon {
    /// <summary>
    /// array of regions where this build can used, when it is active
    /// </summary>
    public List<Region>? ActiveRegions { get; set; }
    /// <summary>
    /// unique identifier of the previously uploaded build executable to be updated
    /// </summary>
    public required string BuildId { get; set; }
    /// <summary>
    /// appended to the end of the command line when starting game servers
    /// </summary>
    public string? CommandLineTemplate { get; set; }
    /// <summary>
    /// developer comment(s) for this build
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// path to the game server executable. Defaults to gameserver.exe
    /// </summary>
    public string? ExecutablePath { get; set; }
    /// <summary>
    /// maximum number of game server instances that can run on a single host machine
    /// </summary>
    public int MaxGamesPerHost { get; set; }
    /// <summary>
    /// minimum capacity of additional game server instances that can be started before the autoscaling service starts new host
    /// machines (given the number of current running host machines and game server instances)
    /// </summary>
    public int MinFreeGameSlots { get; set; }
    /// <summary>
    /// new timestamp
    /// </summary>
    public DateTime? Timestamp { get; set; }
}

[Obsolete("Do not use")]
public class ModifyServerBuildResult : PlayFabResultCommon {
    /// <summary>
    /// array of regions where this build can used, when it is active
    /// </summary>
    public List<Region>? ActiveRegions { get; set; }
    /// <summary>
    /// unique identifier for this build executable
    /// </summary>
    public string? BuildId { get; set; }
    /// <summary>
    /// appended to the end of the command line when starting game servers
    /// </summary>
    public string? CommandLineTemplate { get; set; }
    /// <summary>
    /// developer comment(s) for this build
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// path to the game server executable. Defaults to gameserver.exe
    /// </summary>
    public string? ExecutablePath { get; set; }
    /// <summary>
    /// maximum number of game server instances that can run on a single host machine
    /// </summary>
    public int MaxGamesPerHost { get; set; }
    /// <summary>
    /// minimum capacity of additional game server instances that can be started before the autoscaling service starts new host
    /// machines (given the number of current running host machines and game server instances)
    /// </summary>
    public int MinFreeGameSlots { get; set; }
    /// <summary>
    /// the current status of the build validation and processing steps
    /// </summary>
    public GameBuildStatus? Status { get; set; }
    /// <summary>
    /// time this build was last modified (or uploaded, if this build has never been modified)
    /// </summary>
    public required DateTime Timestamp { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public string? TitleId { get; set; }
}

public class ModifyUserVirtualCurrencyResult : PlayFabResultCommon {
    /// <summary>
    /// Balance of the virtual currency after modification.
    /// </summary>
    public int Balance { get; set; }
    /// <summary>
    /// Amount added or subtracted from the user's virtual currency. Maximum VC balance is Int32 (2,147,483,647). Any increase
    /// over this value will be discarded.
    /// </summary>
    public int BalanceChange { get; set; }
    /// <summary>
    /// User currency was subtracted from.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Name of the virtual currency which was modified.
    /// </summary>
    public string? VirtualCurrency { get; set; }
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

public class OpenIdConnection {
    /// <summary>
    /// The client ID given by the ID provider.
    /// </summary>
    public string? ClientId { get; set; }
    /// <summary>
    /// The client secret given by the ID provider.
    /// </summary>
    public string? ClientSecret { get; set; }
    /// <summary>
    /// A name for the connection to identify it within the title.
    /// </summary>
    public string? ConnectionId { get; set; }
    /// <summary>
    /// Shows if data about the connection will be loaded from the issuer's discovery document
    /// </summary>
    public bool DiscoverConfiguration { get; set; }
    /// <summary>
    /// Ignore 'nonce' claim in identity tokens.
    /// </summary>
    public bool? IgnoreNonce { get; set; }
    /// <summary>
    /// Information for an OpenID Connect provider.
    /// </summary>
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    /// <summary>
    /// Override the issuer name for user indexing and lookup.
    /// </summary>
    public string? IssuerOverride { get; set; }
}

public class OpenIdIssuerInformation {
    /// <summary>
    /// Authorization endpoint URL to direct users to for signin.
    /// </summary>
    public required string AuthorizationUrl { get; set; }
    /// <summary>
    /// The URL of the issuer of the tokens. This must match the exact URL of the issuer field in tokens.
    /// </summary>
    public required string Issuer { get; set; }
    /// <summary>
    /// JSON Web Key Set for validating the signature of tokens.
    /// </summary>
    public required object JsonWebKeySet { get; set; }
    /// <summary>
    /// Token endpoint URL for code verification.
    /// </summary>
    public required string TokenUrl { get; set; }
}

public class PermissionStatement {
    /// <summary>
    /// The action this statement effects. The only supported action is 'Execute'.
    /// </summary>
    public required string Action { get; set; }
    /// <summary>
    /// Additional conditions to be applied for API Resources.
    /// </summary>
    public ApiCondition? ApiConditions { get; set; }
    /// <summary>
    /// A comment about the statement. Intended solely for bookkeeping and debugging.
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// The effect this statement will have. It could be either Allow or Deny
    /// </summary>
    public EffectType Effect { get; set; }
    /// <summary>
    /// The principal this statement will effect. The only supported principal is '*'.
    /// </summary>
    public required string Principal { get; set; }
    /// <summary>
    /// The resource this statements effects. The only supported resources look like 'pfrn:api--*' for all apis, or
    /// 'pfrn:api--/Client/ConfirmPurchase' for specific apis.
    /// </summary>
    public required string Resource { get; set; }
}

public class PlayerChurnPredictionSegmentFilter {
    /// <summary>
    /// Comparison
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// RiskLevel
    /// </summary>
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public class PlayerChurnPredictionTimeSegmentFilter {
    /// <summary>
    /// Comparison
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// DurationInDays
    /// </summary>
    public required double DurationInDays { get; set; }
}

public class PlayerChurnPreviousPredictionSegmentFilter {
    /// <summary>
    /// Comparison
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// RiskLevel
    /// </summary>
    public ChurnRiskLevel? RiskLevel { get; set; }
}

public class PlayerLinkedAccount {
    /// <summary>
    /// Linked account's email
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Authentication platform
    /// </summary>
    public LoginIdentityProvider? Platform { get; set; }
    /// <summary>
    /// Platform user identifier
    /// </summary>
    public string? PlatformUserId { get; set; }
    /// <summary>
    /// Linked account's username
    /// </summary>
    public string? Username { get; set; }
}

public class PlayerLocation {
    /// <summary>
    /// City of the player's geographic location.
    /// </summary>
    public string? City { get; set; }
    /// <summary>
    /// The two-character continent code for this location
    /// </summary>
    public ContinentCode ContinentCode { get; set; }
    /// <summary>
    /// The two-character ISO 3166-1 country code for the country associated with the location
    /// </summary>
    public CountryCode CountryCode { get; set; }
    /// <summary>
    /// Latitude coordinate of the player's geographic location.
    /// </summary>
    public double? Latitude { get; set; }
    /// <summary>
    /// Longitude coordinate of the player's geographic location.
    /// </summary>
    public double? Longitude { get; set; }
}

public class PlayerProfile {
    /// <summary>
    /// Array of ad campaigns player has been attributed to
    /// </summary>
    public List<AdCampaignAttribution>? AdCampaignAttributions { get; set; }
    /// <summary>
    /// Image URL of the player's avatar.
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// Banned until UTC Date. If permanent ban this is set for 20 years after the original ban date.
    /// </summary>
    public DateTime? BannedUntil { get; set; }
    /// <summary>
    /// The prediction of the player to churn within the next seven days.
    /// </summary>
    public ChurnRiskLevel? ChurnPrediction { get; set; }
    /// <summary>
    /// Array of contact email addresses associated with the player
    /// </summary>
    public List<ContactEmailInfo>? ContactEmailAddresses { get; set; }
    /// <summary>
    /// Player record created
    /// </summary>
    public DateTime? Created { get; set; }
    /// <summary>
    /// Dictionary of player's custom properties.
    /// </summary>
    public Dictionary<string, object>? CustomProperties { get; set; }
    /// <summary>
    /// Player Display Name
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Last login
    /// </summary>
    public DateTime? LastLogin { get; set; }
    /// <summary>
    /// Array of third party accounts linked to this player
    /// </summary>
    public List<PlayerLinkedAccount>? LinkedAccounts { get; set; }
    /// <summary>
    /// Dictionary of player's locations by type.
    /// </summary>
    public Dictionary<string, PlayerLocation>? Locations { get; set; }
    /// <summary>
    /// Player account origination
    /// </summary>
    public LoginIdentityProvider? Origination { get; set; }
    /// <summary>
    /// List of player variants for experimentation
    /// </summary>
    public List<string>? PlayerExperimentVariants { get; set; }
    /// <summary>
    /// PlayFab Player ID
    /// </summary>
    public string? PlayerId { get; set; }
    /// <summary>
    /// Array of player statistics
    /// </summary>
    public List<PlayerStatistic>? PlayerStatistics { get; set; }
    /// <summary>
    /// Publisher this player belongs to
    /// </summary>
    public string? PublisherId { get; set; }
    /// <summary>
    /// Array of configured push notification end points
    /// </summary>
    public List<PushNotificationRegistration>? PushNotificationRegistrations { get; set; }
    /// <summary>
    /// Dictionary of player's statistics using only the latest version's value
    /// </summary>
    public Dictionary<string, int>? Statistics { get; set; }
    /// <summary>
    /// List of player's tags for segmentation.
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// Title ID this profile applies to
    /// </summary>
    public string? TitleId { get; set; }
    /// <summary>
    /// A sum of player's total purchases in USD across all currencies.
    /// </summary>
    public UInt32? TotalValueToDateInUSD { get; set; }
    /// <summary>
    /// Dictionary of player's total purchases by currency.
    /// </summary>
    public Dictionary<string, UInt32>? ValuesToDate { get; set; }
    /// <summary>
    /// Dictionary of player's virtual currency balances
    /// </summary>
    public Dictionary<string, int>? VirtualCurrencyBalances { get; set; }
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
    public UInt32? TotalValueToDateInUSD { get; set; }
    /// <summary>
    /// List of the player's lifetime purchase totals, summed by real-money currency
    /// </summary>
    public List<ValueToDateModel>? ValuesToDate { get; set; }
}

public class PlayerProfileViewConstraints {
    /// <summary>
    /// Whether to show player's avatar URL. Defaults to false
    /// </summary>
    public bool ShowAvatarUrl { get; set; }
    /// <summary>
    /// Whether to show the banned until time. Defaults to false
    /// </summary>
    public bool ShowBannedUntil { get; set; }
    /// <summary>
    /// Whether to show campaign attributions. Defaults to false
    /// </summary>
    public bool ShowCampaignAttributions { get; set; }
    /// <summary>
    /// Whether to show contact email addresses. Defaults to false
    /// </summary>
    public bool ShowContactEmailAddresses { get; set; }
    /// <summary>
    /// Whether to show the created date. Defaults to false
    /// </summary>
    public bool ShowCreated { get; set; }
    /// <summary>
    /// Whether to show the display name. Defaults to false
    /// </summary>
    public bool ShowDisplayName { get; set; }
    /// <summary>
    /// Whether to show player's experiment variants. Defaults to false
    /// </summary>
    public bool ShowExperimentVariants { get; set; }
    /// <summary>
    /// Whether to show the last login time. Defaults to false
    /// </summary>
    public bool ShowLastLogin { get; set; }
    /// <summary>
    /// Whether to show the linked accounts. Defaults to false
    /// </summary>
    public bool ShowLinkedAccounts { get; set; }
    /// <summary>
    /// Whether to show player's locations. Defaults to false
    /// </summary>
    public bool ShowLocations { get; set; }
    /// <summary>
    /// Whether to show player's membership information. Defaults to false
    /// </summary>
    public bool ShowMemberships { get; set; }
    /// <summary>
    /// Whether to show origination. Defaults to false
    /// </summary>
    public bool ShowOrigination { get; set; }
    /// <summary>
    /// Whether to show push notification registrations. Defaults to false
    /// </summary>
    public bool ShowPushNotificationRegistrations { get; set; }
    /// <summary>
    /// Reserved for future development
    /// </summary>
    public bool ShowStatistics { get; set; }
    /// <summary>
    /// Whether to show tags. Defaults to false
    /// </summary>
    public bool ShowTags { get; set; }
    /// <summary>
    /// Whether to show the total value to date in usd. Defaults to false
    /// </summary>
    public bool ShowTotalValueToDateInUsd { get; set; }
    /// <summary>
    /// Whether to show the values to date. Defaults to false
    /// </summary>
    public bool ShowValuesToDate { get; set; }
}

public class PlayerStatistic {
    /// <summary>
    /// Statistic ID
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Statistic name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Current statistic value
    /// </summary>
    public int StatisticValue { get; set; }
    /// <summary>
    /// Statistic version (0 if not a versioned statistic)
    /// </summary>
    public int StatisticVersion { get; set; }
}

public class PlayerStatisticDefinition {
    /// <summary>
    /// the aggregation method to use in updating the statistic (defaults to last)
    /// </summary>
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    /// <summary>
    /// current active version of the statistic, incremented each time the statistic resets
    /// </summary>
    public UInt32 CurrentVersion { get; set; }
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// interval at which the values of the statistic for all players are reset automatically
    /// </summary>
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class PlayerStatisticVersion {
    /// <summary>
    /// time when the statistic version became active
    /// </summary>
    public required DateTime ActivationTime { get; set; }
    /// <summary>
    /// status of the process of saving player statistic values of the previous version to a downloadable archive
    /// </summary>
    public StatisticVersionArchivalStatus? ArchivalStatus { get; set; }
    /// <summary>
    /// URL for the downloadable archive of player statistic values, if available
    /// </summary>
    public string? ArchiveDownloadUrl { get; set; }
    /// <summary>
    /// time when the statistic version became inactive due to statistic version incrementing
    /// </summary>
    public DateTime? DeactivationTime { get; set; }
    /// <summary>
    /// time at which the statistic version was scheduled to become active, based on the configured ResetInterval
    /// </summary>
    public DateTime? ScheduledActivationTime { get; set; }
    /// <summary>
    /// time at which the statistic version was scheduled to become inactive, based on the configured ResetInterval
    /// </summary>
    public DateTime? ScheduledDeactivationTime { get; set; }
    /// <summary>
    /// name of the statistic when the version became active
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// status of the statistic version
    /// </summary>
    public StatisticVersionStatus? Status { get; set; }
    /// <summary>
    /// version of the statistic
    /// </summary>
    public UInt32 Version { get; set; }
}

public class PushNotificationContent {
    /// <summary>
    /// Text of message to send.
    /// </summary>
    public string? Message { get; set; }
    /// <summary>
    /// Id of the push notification template.
    /// </summary>
    public string? PushNotificationTemplateId { get; set; }
    /// <summary>
    /// Subject of message to send (may not be displayed in all platforms)
    /// </summary>
    public string? Subject { get; set; }
}

public enum PushNotificationPlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class PushNotificationRegistration {
    /// <summary>
    /// Notification configured endpoint
    /// </summary>
    public string? NotificationEndpointARN { get; set; }
    /// <summary>
    /// Push notification platform
    /// </summary>
    public PushNotificationPlatform? Platform { get; set; }
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

public class PushNotificationSegmentAction {
    /// <summary>
    /// Push notification template id.
    /// </summary>
    public string? PushNotificationTemplateId { get; set; }
}

public class PushNotificationSegmentFilter {
    /// <summary>
    /// Push notification device platform.
    /// </summary>
    public SegmentPushNotificationDevicePlatform? PushNotificationDevicePlatform { get; set; }
}

public enum PushSetupPlatform {
    GCM,
    APNS,
    APNS_SANDBOX,
}

public class RandomResultTable {
    /// <summary>
    /// Child nodes that indicate what kind of drop table item this actually is.
    /// </summary>
    public required List<ResultTableNode> Nodes { get; set; }
    /// <summary>
    /// Unique name for this drop table
    /// </summary>
    public required string TableId { get; set; }
}

public class RandomResultTableListing {
    /// <summary>
    /// Catalog version this table is associated with
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Child nodes that indicate what kind of drop table item this actually is.
    /// </summary>
    public required List<ResultTableNode> Nodes { get; set; }
    /// <summary>
    /// Unique name for this drop table
    /// </summary>
    public required string TableId { get; set; }
}

public class RefundPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique order ID for the purchase in question.
    /// </summary>
    public required string OrderId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// The Reason parameter should correspond with the payment providers reason field, if they require one such as Facebook.
    /// In the case of Facebook this must match one of their refund or dispute resolution enums (See:
    /// https://developers.facebook.com/docs/payments/implementation-guide/handling-disputes-refunds)
    /// </summary>
    public string? Reason { get; set; }
}

public class RefundPurchaseResponse : PlayFabResultCommon {
    /// <summary>
    /// The order's updated purchase status.
    /// </summary>
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
/// This API will trigger a player_tag_removed event and remove a tag with the given TagName and PlayFabID from the
/// corresponding player profile. TagName can be used for segmentation and it is limited to 256 characters
/// </summary>
public class RemovePlayerTagRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Unique tag for player profile.
    /// </summary>
    public required string TagName { get; set; }
}

public class RemovePlayerTagResult : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class RemoveServerBuildRequest : PlayFabRequestCommon {
    /// <summary>
    /// unique identifier of the previously uploaded build executable to be removed
    /// </summary>
    public required string BuildId { get; set; }
}

[Obsolete("Do not use")]
public class RemoveServerBuildResult : PlayFabResultCommon {
}

/// <summary>
/// Virtual currencies to be removed cannot have entries in any catalog nor store for the title. Note that this operation
/// will not remove player balances for the removed currencies; if a deleted currency is recreated at any point, user
/// balances will be in an undefined state.
/// </summary>
public class RemoveVirtualCurrencyTypesRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of virtual currencies to delete
    /// </summary>
    public required List<VirtualCurrencyData> VirtualCurrencies { get; set; }
}

/// <summary>
/// Note that this action cannot be un-done. All statistics for this character will be deleted, removing the user from all
/// leaderboards for the game.
/// </summary>
public class ResetCharacterStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class ResetCharacterStatisticsResult : PlayFabResultCommon {
}

/// <summary>
/// Resets a player's password taking in a new password based and validating the user based off of a token sent to the
/// playerto their email. The token expires after 30 minutes.
/// </summary>
public class ResetPasswordRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The new password for the player.
    /// </summary>
    public required string Password { get; set; }
    /// <summary>
    /// The token of the player requesting the password reset.
    /// </summary>
    public required string Token { get; set; }
}

public class ResetPasswordResult : PlayFabResultCommon {
}

/// <summary>
/// This method is intended for use with test accounts, to allow a developer to reset and test a game experience from the
/// start. Note that in order to reset an account, you must know the username. If the account does not have a username, you
/// must add one with AddUsernamePassword in the client API prior to calling this method.
/// </summary>
[Obsolete("Do not use")]
public class ResetUsersRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Array of users to reset
    /// </summary>
    public required List<UserCredentials> Users { get; set; }
}

/// <summary>
/// Note that this action cannot be un-done. All statistics for this user will be deleted, removing the user from all
/// leaderboards for the game.
/// </summary>
public class ResetUserStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
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
    /// <summary>
    /// Unique order ID for the purchase in question.
    /// </summary>
    public required string OrderId { get; set; }
    /// <summary>
    /// Enum for the desired purchase result state after notifying the payment provider. Valid values are Revoke, Reinstate and
    /// Manual. Manual will cause no change to the order state.
    /// </summary>
    public ResolutionOutcome Outcome { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// The Reason parameter should correspond with the payment providers reason field, if they require one such as Facebook.
    /// In the case of Facebook this must match one of their refund or dispute resolution enums (See:
    /// https://developers.facebook.com/docs/payments/implementation-guide/handling-disputes-refunds)
    /// </summary>
    public string? Reason { get; set; }
}

public class ResolvePurchaseDisputeResponse : PlayFabResultCommon {
    /// <summary>
    /// The order's updated purchase status.
    /// </summary>
    public string? PurchaseStatus { get; set; }
}

public class ResultTableNode {
    /// <summary>
    /// Either an ItemId, or the TableId of another random result table
    /// </summary>
    public required string ResultItem { get; set; }
    /// <summary>
    /// Whether this entry in the table is an item or a link to another table
    /// </summary>
    public ResultTableNodeType ResultItemType { get; set; }
    /// <summary>
    /// How likely this is to be rolled - larger numbers add more weight
    /// </summary>
    public int Weight { get; set; }
}

public enum ResultTableNodeType {
    ItemId,
    TableId,
}

/// <summary>
/// Setting the active state of all non-expired bans for a user to Inactive. Expired bans with an Active state will be
/// ignored, however. Returns information about applied updates only.
/// </summary>
public class RevokeAllBansForUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class RevokeAllBansForUserResult : PlayFabResultCommon {
    /// <summary>
    /// Information on the bans that were revoked.
    /// </summary>
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// Setting the active state of all bans requested to Inactive regardless of whether that ban has already expired. BanIds
/// that do not exist will be skipped. Returns information about applied updates only.
/// </summary>
public class RevokeBansRequest : PlayFabRequestCommon {
    /// <summary>
    /// Ids of the bans to be revoked. Maximum 100.
    /// </summary>
    public required List<string> BanIds { get; set; }
}

public class RevokeBansResult : PlayFabResultCommon {
    /// <summary>
    /// Information on the bans that were revoked
    /// </summary>
    public List<BanInfo>? BanData { get; set; }
}

public class RevokeInventoryItem {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned instance identifier of the item
    /// </summary>
    public required string ItemInstanceId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In cases where the inventory item in question is a "crate", and the items it contained have already been dispensed,
/// this will not revoke access or otherwise remove the items which were dispensed.
/// </summary>
public class RevokeInventoryItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned instance identifier of the item
    /// </summary>
    public required string ItemInstanceId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In cases where the inventory item in question is a "crate", and the items it contained have already been dispensed,
/// this will not revoke access or otherwise remove the items which were dispensed.
/// </summary>
public class RevokeInventoryItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of player items to revoke, between 1 and 25 items.
    /// </summary>
    public required List<RevokeInventoryItem> Items { get; set; }
}

public class RevokeInventoryItemsResult : PlayFabResultCommon {
    /// <summary>
    /// Collection of any errors that occurred during processing.
    /// </summary>
    public List<RevokeItemError>? Errors { get; set; }
}

public class RevokeInventoryResult : PlayFabResultCommon {
}

public class RevokeItemError {
    /// <summary>
    /// Specific error that was encountered.
    /// </summary>
    public GenericErrorCodes? Error { get; set; }
    /// <summary>
    /// Item information that failed to be revoked.
    /// </summary>
    public RevokeInventoryItem? Item { get; set; }
}

/// <summary>
/// The returned task instance ID can be used to query for task execution status.
/// </summary>
public class RunTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Provide either the task ID or the task name to run a task.
    /// </summary>
    public NameIdentifier? Identifier { get; set; }
}

public class RunTaskResult : PlayFabResultCommon {
    /// <summary>
    /// ID of the task instance that is started. This can be used in Get*TaskInstance (e.g. GetCloudScriptTaskInstance) API
    /// call to retrieve status for the task instance.
    /// </summary>
    public string? TaskInstanceId { get; set; }
}

public class ScheduledTask {
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// UTC time of last run
    /// </summary>
    public DateTime? LastRunTime { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// UTC time of next run
    /// </summary>
    public DateTime? NextRunTime { get; set; }
    /// <summary>
    /// Task parameter. Different types of task have different parameter structure. See each task type's create API
    /// documentation for the details.
    /// </summary>
    public object? Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
    /// <summary>
    /// ID of the task
    /// </summary>
    public string? TaskId { get; set; }
    /// <summary>
    /// Task type.
    /// </summary>
    public ScheduledTaskType? Type { get; set; }
}

public enum ScheduledTaskType {
    CloudScript,
    ActionsOnPlayerSegment,
    CloudScriptAzureFunctions,
    InsightsScheduledScaling,
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

public class SegmentAndDefinition {
    /// <summary>
    /// Filter property for ad campaign filter.
    /// </summary>
    public AdCampaignSegmentFilter? AdCampaignFilter { get; set; }
    /// <summary>
    /// property for all player filter.
    /// </summary>
    public AllPlayersSegmentFilter? AllPlayersFilter { get; set; }
    /// <summary>
    /// Filter property for player churn risk level.
    /// </summary>
    public ChurnPredictionSegmentFilter? ChurnPredictionFilter { get; set; }
    /// <summary>
    /// Filter property for boolean custom properties.
    /// </summary>
    public CustomPropertyBooleanSegmentFilter? CustomPropertyBooleanFilter { get; set; }
    /// <summary>
    /// Filter property for datetime custom properties.
    /// </summary>
    public CustomPropertyDateTimeSegmentFilter? CustomPropertyDateTimeFilter { get; set; }
    /// <summary>
    /// Filter property for numeric custom properties.
    /// </summary>
    public CustomPropertyNumericSegmentFilter? CustomPropertyNumericFilter { get; set; }
    /// <summary>
    /// Filter property for string custom properties.
    /// </summary>
    public CustomPropertyStringSegmentFilter? CustomPropertyStringFilter { get; set; }
    /// <summary>
    /// Filter property for first login date.
    /// </summary>
    public FirstLoginDateSegmentFilter? FirstLoginDateFilter { get; set; }
    /// <summary>
    /// Filter property for first login timespan.
    /// </summary>
    public FirstLoginTimespanSegmentFilter? FirstLoginFilter { get; set; }
    /// <summary>
    /// Filter property for last login date.
    /// </summary>
    public LastLoginDateSegmentFilter? LastLoginDateFilter { get; set; }
    /// <summary>
    /// Filter property for last login timespan.
    /// </summary>
    public LastLoginTimespanSegmentFilter? LastLoginFilter { get; set; }
    /// <summary>
    /// Filter property for linked in user account.
    /// </summary>
    public LinkedUserAccountSegmentFilter? LinkedUserAccountFilter { get; set; }
    /// <summary>
    /// Filter property for linked in user account has email.
    /// </summary>
    public LinkedUserAccountHasEmailSegmentFilter? LinkedUserAccountHasEmailFilter { get; set; }
    /// <summary>
    /// Filter property for location.
    /// </summary>
    public LocationSegmentFilter? LocationFilter { get; set; }
    /// <summary>
    /// Filter property for current player churn value.
    /// </summary>
    public PlayerChurnPredictionSegmentFilter? PlayerChurnPredictionFilter { get; set; }
    /// <summary>
    /// Filter property for player churn timespan.
    /// </summary>
    public PlayerChurnPredictionTimeSegmentFilter? PlayerChurnPredictionTimeFilter { get; set; }
    /// <summary>
    /// Filter property for previous player churn value.
    /// </summary>
    public PlayerChurnPreviousPredictionSegmentFilter? PlayerChurnPreviousPredictionFilter { get; set; }
    /// <summary>
    /// Filter property for push notification.
    /// </summary>
    public PushNotificationSegmentFilter? PushNotificationFilter { get; set; }
    /// <summary>
    /// Filter property for statistics.
    /// </summary>
    public StatisticSegmentFilter? StatisticFilter { get; set; }
    /// <summary>
    /// Filter property for tags.
    /// </summary>
    public TagSegmentFilter? TagFilter { get; set; }
    /// <summary>
    /// Filter property for total value to date in USD.
    /// </summary>
    public TotalValueToDateInUSDSegmentFilter? TotalValueToDateInUSDFilter { get; set; }
    /// <summary>
    /// Filter property for user origination.
    /// </summary>
    public UserOriginationSegmentFilter? UserOriginationFilter { get; set; }
    /// <summary>
    /// Filter property for value to date.
    /// </summary>
    public ValueToDateSegmentFilter? ValueToDateFilter { get; set; }
    /// <summary>
    /// Filter property for virtual currency.
    /// </summary>
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
    /// <summary>
    /// Segment description.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Segment actions for current entered segment players.
    /// </summary>
    public List<SegmentTrigger>? EnteredSegmentActions { get; set; }
    /// <summary>
    /// Segment last updated date time.
    /// </summary>
    public required DateTime LastUpdateTime { get; set; }
    /// <summary>
    /// Segment actions for current left segment players.
    /// </summary>
    public List<SegmentTrigger>? LeftSegmentActions { get; set; }
    /// <summary>
    /// Segment name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Segment id in hex.
    /// </summary>
    public string? SegmentId { get; set; }
    /// <summary>
    /// Segment or definitions. This includes segment and definitions and filters.
    /// </summary>
    public List<SegmentOrDefinition>? SegmentOrDefinitions { get; set; }
}

public class SegmentOrDefinition {
    /// <summary>
    /// List of segment and definitions.
    /// </summary>
    public List<SegmentAndDefinition>? SegmentAndDefinitions { get; set; }
}

public enum SegmentPushNotificationDevicePlatform {
    ApplePushNotificationService,
    GoogleCloudMessaging,
}

public class SegmentTrigger {
    /// <summary>
    /// Add inventory item v2 segment trigger action.
    /// </summary>
    public AddInventoryItemsV2SegmentAction? AddInventoryItemsV2Action { get; set; }
    /// <summary>
    /// Ban player segment trigger action.
    /// </summary>
    public BanPlayerSegmentAction? BanPlayerAction { get; set; }
    /// <summary>
    /// Delete inventory item v2 segment trigger action.
    /// </summary>
    public DeleteInventoryItemsV2SegmentAction? DeleteInventoryItemsV2Action { get; set; }
    /// <summary>
    /// Delete player segment trigger action.
    /// </summary>
    public DeletePlayerSegmentAction? DeletePlayerAction { get; set; }
    /// <summary>
    /// Delete player statistic segment trigger action.
    /// </summary>
    public DeletePlayerStatisticSegmentAction? DeletePlayerStatisticAction { get; set; }
    /// <summary>
    /// Email notification segment trigger action.
    /// </summary>
    public EmailNotificationSegmentAction? EmailNotificationAction { get; set; }
    /// <summary>
    /// Execute azure function segment trigger action.
    /// </summary>
    public ExecuteAzureFunctionSegmentAction? ExecuteAzureFunctionAction { get; set; }
    /// <summary>
    /// Execute cloud script segment trigger action.
    /// </summary>
    public ExecuteCloudScriptSegmentAction? ExecuteCloudScriptAction { get; set; }
    /// <summary>
    /// Grant item segment trigger action.
    /// </summary>
    public GrantItemSegmentAction? GrantItemAction { get; set; }
    /// <summary>
    /// Grant virtual currency segment trigger action.
    /// </summary>
    public GrantVirtualCurrencySegmentAction? GrantVirtualCurrencyAction { get; set; }
    /// <summary>
    /// Increment player statistic segment trigger action.
    /// </summary>
    public IncrementPlayerStatisticSegmentAction? IncrementPlayerStatisticAction { get; set; }
    /// <summary>
    /// Push notification segment trigger action.
    /// </summary>
    public PushNotificationSegmentAction? PushNotificationAction { get; set; }
    /// <summary>
    /// Subtract inventory item v2 segment trigger action.
    /// </summary>
    public SubtractInventoryItemsV2SegmentAction? SubtractInventoryItemsV2Action { get; set; }
}

/// <summary>
/// If the account in question is a "temporary" account (for example, one that was created via a call to
/// LoginFromIOSDeviceID), thisfunction will have no effect. Only PlayFab accounts which have valid email addresses will be
/// able to receive a password reset email using this API.
/// </summary>
public class SendAccountRecoveryEmailRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// User email address attached to their account
    /// </summary>
    public required string Email { get; set; }
    /// <summary>
    /// The email template id of the account recovery email template to send.
    /// </summary>
    public string? EmailTemplateId { get; set; }
}

public class SendAccountRecoveryEmailResult : PlayFabResultCommon {
}

public class SendEmailContent {
    /// <summary>
    /// The email template id of the email template to send.
    /// </summary>
    public required string EmailTemplateId { get; set; }
}

/// <summary>
/// The request must contain a valid sink to which PlayFab has write permissions. The sink destination types can be found
/// in the PlayFab documentation.
/// </summary>
public class SetEventSinkRequest : PlayFabRequestCommon {
    /// <summary>
    /// The sink to which to route PlayStream and Telemetry event data.
    /// </summary>
    public required EventSink Sink { get; set; }
}

public class SetEventSinkResult : PlayFabResultCommon {
}

/// <summary>
/// This API lets developers set overrides for membership expirations, independent of any subscriptions setting it.
/// </summary>
public class SetMembershipOverrideRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Expiration time for the membership in DateTime format, will override any subscription expirations.
    /// </summary>
    public required DateTime ExpirationTime { get; set; }
    /// <summary>
    /// Id of the membership to apply the override expiration date to.
    /// </summary>
    public required string MembershipId { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class SetMembershipOverrideResult : PlayFabResultCommon {
}

/// <summary>
/// APIs that require signatures require that the player have a configured Player Secret Key that is used to sign all
/// requests. Players that don't have a secret will be blocked from making API calls until it is configured. To create a
/// signature header add a SHA256 hashed string containing UTF8 encoded JSON body as it will be sent to the server, the
/// current time in UTC formatted to ISO 8601, and the players secret formatted as 'body.date.secret'. Place the resulting
/// hash into the header X-PlayFab-Signature, along with a header X-PlayFab-Timestamp of the same UTC timestamp used in the
/// signature.
/// </summary>
public class SetPlayerSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class SetPlayerSecretResult : PlayFabResultCommon {
}

public class SetPublishedRevisionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Revision to make the current published revision
    /// </summary>
    public int Revision { get; set; }
    /// <summary>
    /// Version number
    /// </summary>
    public int Version { get; set; }
}

public class SetPublishedRevisionResult : PlayFabResultCommon {
}

/// <summary>
/// This API is designed to store publisher-specific values which can be read, but not written to, by the client. This data
/// is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only
/// titles assigned to a publisher can use this API. This operation is additive. If a Key does not exist in the current
/// dataset, it will be added with the specified Value. If it already exists, the Value for that key will be overwritten
/// with the new Value. For more information email helloplayfab@microsoft.com
/// </summary>
public class SetPublisherDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// key we want to set a value on (note, this is additive - will only replace an existing key's value if they are the same
    /// name.) Keys are trimmed of whitespace. Keys may not begin with the '!' character.
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// new value to set. Set to null to remove a value
    /// </summary>
    public string? Value { get; set; }
}

public class SetPublisherDataResult : PlayFabResultCommon {
}

/// <summary>
/// Will set the given key values in the specified override or the primary title data based on whether the label is
/// provided or not.
/// </summary>
public class SetTitleDataAndOverridesRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of titleData key-value pairs to set/delete. Use an empty value to delete an existing key; use a non-empty value to
    /// create/update a key.
    /// </summary>
    public required List<TitleDataKeyValue> KeyValues { get; set; }
    /// <summary>
    /// Name of the override.
    /// </summary>
    public string? OverrideLabel { get; set; }
}

public class SetTitleDataAndOverridesResult : PlayFabResultCommon {
}

/// <summary>
/// This operation is additive. If a Key does not exist in the current dataset, it will be added with the specified Value.
/// If it already exists, the Value for that key will be overwritten with the new Value.
/// </summary>
public class SetTitleDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// key we want to set a value on (note, this is additive - will only replace an existing key's value if they are the same
    /// name.) Keys are trimmed of whitespace. Keys may not begin with the '!' character.
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// new value to set. Set to null to remove a value
    /// </summary>
    public string? Value { get; set; }
}

public class SetTitleDataResult : PlayFabResultCommon {
}

/// <summary>
/// When using the Apple Push Notification service (APNS) or the development version (APNS_SANDBOX), the APNS Private Key
/// should be used as the Credential in this call. With Google Cloud Messaging (GCM), the Android API Key should be used.
/// The current ARN (if one exists) can be overwritten by setting the OverwriteOldARN boolean to true.
/// </summary>
public class SetupPushNotificationRequest : PlayFabRequestCommon {
    /// <summary>
    /// Credential is the Private Key for APNS/APNS_SANDBOX, and the API Key for GCM
    /// </summary>
    public required string Credential { get; set; }
    /// <summary>
    /// for APNS, this is the PlatformPrincipal (SSL Certificate)
    /// </summary>
    public string? Key { get; set; }
    /// <summary>
    /// This field is deprecated and any usage of this will cause the API to fail.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// replace any existing ARN with the newly generated one. If this is set to false, an error will be returned if
    /// notifications have already setup for this platform.
    /// </summary>
    public bool OverwriteOldARN { get; set; }
    /// <summary>
    /// supported notification platforms are Apple Push Notification Service (APNS and APNS_SANDBOX) for iOS and Google Cloud
    /// Messaging (GCM) for Android
    /// </summary>
    public PushSetupPlatform Platform { get; set; }
}

public class SetupPushNotificationResult : PlayFabResultCommon {
    /// <summary>
    /// Amazon Resource Name for the created notification topic.
    /// </summary>
    public string? ARN { get; set; }
}

public class SharedSecret {
    /// <summary>
    /// Flag to indicate if this key is disabled
    /// </summary>
    public bool Disabled { get; set; }
    /// <summary>
    /// Friendly name for this key
    /// </summary>
    public string? FriendlyName { get; set; }
    /// <summary>
    /// The player shared secret to use when calling Client/GetTitlePublicKey
    /// </summary>
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

public enum StatisticResetIntervalOption {
    Never,
    Hour,
    Day,
    Week,
    Month,
}

public class StatisticSegmentFilter {
    /// <summary>
    /// Statistic filter comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Statistic filter value.
    /// </summary>
    public string? FilterValue { get; set; }
    /// <summary>
    /// Statistic name.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Use current version of statistic?
    /// </summary>
    public bool? UseCurrentVersion { get; set; }
    /// <summary>
    /// Statistic version.
    /// </summary>
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
    /// <summary>
    /// Store specific custom data. The data only exists as part of this store; it is not transferred to item instances
    /// </summary>
    public object? CustomData { get; set; }
    /// <summary>
    /// Intended display position for this item. Note that 0 is the first position
    /// </summary>
    public UInt32? DisplayPosition { get; set; }
    /// <summary>
    /// Unique identifier of the item as it exists in the catalog - note that this must exactly match the ItemId from the
    /// catalog
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// Override prices for this item for specific currencies
    /// </summary>
    public Dictionary<string, UInt32>? RealCurrencyPrices { get; set; }
    /// <summary>
    /// Override prices for this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
    /// </summary>
    public Dictionary<string, UInt32>? VirtualCurrencyPrices { get; set; }
}

/// <summary>
/// Marketing data about a specific store
/// </summary>
public class StoreMarketingModel {
    /// <summary>
    /// Tagline for a store.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Display name of a store as it will appear to users.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Custom data about a store.
    /// </summary>
    public object? Metadata { get; set; }
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

public class SubtractInventoryItemsV2SegmentAction {
    /// <summary>
    /// Amount of the item to removed from the player
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The collection id for where the item will be removed from the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The duration in seconds to be removed from the subscription in the players inventory
    /// </summary>
    public int? DurationInSeconds { get; set; }
    /// <summary>
    /// The id of item to be removed from the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be removed from the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

public class SubtractInventoryItemV2Content {
    /// <summary>
    /// Amount of the item to removed from the player
    /// </summary>
    public int? Amount { get; set; }
    /// <summary>
    /// The collection id for where the item will be removed from the player inventory
    /// </summary>
    public string? CollectionId { get; set; }
    /// <summary>
    /// The duration in seconds to be removed from the subscription in the players inventory
    /// </summary>
    public int? DurationInSeconds { get; set; }
    /// <summary>
    /// The id of item to be removed from the player
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// The stack id for where the item will be removed from the player inventory
    /// </summary>
    public string? StackId { get; set; }
}

public class SubtractUserVirtualCurrencyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Amount to be subtracted from the user balance of the specified virtual currency.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose virtual currency balance is to be decreased.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Name of the virtual currency which is to be decremented.
    /// </summary>
    public required string VirtualCurrency { get; set; }
}

public class TagModel {
    /// <summary>
    /// Full value of the tag, including namespace
    /// </summary>
    public string? TagValue { get; set; }
}

public class TagSegmentFilter {
    /// <summary>
    /// Tag comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Tag value.
    /// </summary>
    public string? TagValue { get; set; }
}

public class TaskInstanceBasicSummary {
    /// <summary>
    /// UTC timestamp when the task completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }
    /// <summary>
    /// Error message for last processing attempt, if an error occured.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// Estimated time remaining in seconds.
    /// </summary>
    public double? EstimatedSecondsRemaining { get; set; }
    /// <summary>
    /// Progress represented as percentage.
    /// </summary>
    public double? PercentComplete { get; set; }
    /// <summary>
    /// If manually scheduled, ID of user who scheduled the task.
    /// </summary>
    public string? ScheduledByUserId { get; set; }
    /// <summary>
    /// UTC timestamp when the task started.
    /// </summary>
    public required DateTime StartedAt { get; set; }
    /// <summary>
    /// Current status of the task instance.
    /// </summary>
    public TaskInstanceStatus? Status { get; set; }
    /// <summary>
    /// Identifier of the task this instance belongs to.
    /// </summary>
    public NameIdentifier? TaskIdentifier { get; set; }
    /// <summary>
    /// ID of the task instance.
    /// </summary>
    public string? TaskInstanceId { get; set; }
    /// <summary>
    /// Type of the task.
    /// </summary>
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
    /// <summary>
    /// Key we want to set a value on (note, this is additive - will only replace an existing key's value if they are the same
    /// name.) Keys are trimmed of whitespace. Keys may not begin with the '!' character.
    /// </summary>
    public string? Key { get; set; }
    /// <summary>
    /// New value to set. Set to null to remove a value
    /// </summary>
    public string? Value { get; set; }
}

public class TotalValueToDateInUSDSegmentFilter {
    /// <summary>
    /// Total value to date USD amount.
    /// </summary>
    public string? Amount { get; set; }
    /// <summary>
    /// Total value to date USD comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
}

/// <summary>
/// Represents a single update ban request.
/// </summary>
public class UpdateBanRequest {
    /// <summary>
    /// The updated active state for the ban. Null for no change.
    /// </summary>
    public bool? Active { get; set; }
    /// <summary>
    /// The id of the ban to be updated.
    /// </summary>
    public required string BanId { get; set; }
    /// <summary>
    /// The updated expiration date for the ban. Null for no change.
    /// </summary>
    public DateTime? Expires { get; set; }
    /// <summary>
    /// The updated decision to ban the Microsoft family members to be updated. Null for no change. This property is deprecated
    /// and does not work anymore.
    /// </summary>
    public bool? IncludeMicrosoftFamily { get; set; }
    /// <summary>
    /// The updated IP address for the ban. Null for no change.
    /// </summary>
    public string? IPAddress { get; set; }
    /// <summary>
    /// The updated MAC address for the ban. Null for no change. This property is deprecated and does not work anymore.
    /// </summary>
    public string? MACAddress { get; set; }
    /// <summary>
    /// Whether to make this ban permanent. Set to true to make this ban permanent. This will not modify Active state.
    /// </summary>
    public bool? Permanent { get; set; }
    /// <summary>
    /// The updated reason for the ban to be updated. Maximum 140 characters. Null for no change.
    /// </summary>
    public string? Reason { get; set; }
    /// <summary>
    /// The updated family type of the user that should be included in the ban. Null for no change.
    /// </summary>
    public UserFamilyType? UserFamilyType { get; set; }
}

/// <summary>
/// For each ban, only updates the values that are set. Leave any value to null for no change. If a ban could not be found,
/// the rest are still applied. Returns information about applied updates only.
/// </summary>
public class UpdateBansRequest : PlayFabRequestCommon {
    /// <summary>
    /// List of bans to be updated. Maximum 100.
    /// </summary>
    public required List<UpdateBanRequest> Bans { get; set; }
}

public class UpdateBansResult : PlayFabResultCommon {
    /// <summary>
    /// Information on the bans that were updated
    /// </summary>
    public List<BanInfo>? BanData { get; set; }
}

/// <summary>
/// When used for SetCatalogItems, this operation is not additive. Using it will cause the indicated catalog version to be
/// created from scratch. If there is an existing catalog with the version number in question, it will be deleted and
/// replaced with only the items specified in this call. When used for UpdateCatalogItems, this operation is additive.
/// Items with ItemId values not currently in the catalog will be added, while those with ItemId values matching items
/// currently in the catalog will overwrite those items with the given values.
/// </summary>
public class UpdateCatalogItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of catalog items to be submitted. Note that while CatalogItem has a parameter for CatalogVersion, it is not
    /// required and ignored in this call.
    /// </summary>
    public List<CatalogItem>? Catalog { get; set; }
    /// <summary>
    /// Which catalog is being updated. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Should this catalog be set as the default catalog. Defaults to true. If there is currently no default catalog, this
    /// will always set it.
    /// </summary>
    public bool? SetAsDefaultCatalog { get; set; }
}

public class UpdateCatalogItemsResult : PlayFabResultCommon {
}

public class UpdateCloudScriptRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// PlayFab user ID of the developer initiating the request.
    /// </summary>
    public string? DeveloperPlayFabId { get; set; }
    /// <summary>
    /// List of Cloud Script files to upload to create the new revision. Must have at least one file.
    /// </summary>
    public required List<CloudScriptFile> Files { get; set; }
    /// <summary>
    /// Immediately publish the new revision
    /// </summary>
    public bool Publish { get; set; }
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public int? Version { get; set; }
}

public class UpdateCloudScriptResult : PlayFabResultCommon {
    /// <summary>
    /// New revision number created
    /// </summary>
    public int Revision { get; set; }
    /// <summary>
    /// Cloud Script version updated
    /// </summary>
    public int Version { get; set; }
}

public class UpdateOpenIdConnectionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The client ID given by the ID provider.
    /// </summary>
    public string? ClientId { get; set; }
    /// <summary>
    /// The client secret given by the ID provider.
    /// </summary>
    public string? ClientSecret { get; set; }
    /// <summary>
    /// A name for the connection that identifies it within the title.
    /// </summary>
    public required string ConnectionId { get; set; }
    /// <summary>
    /// Ignore 'nonce' claim in identity tokens.
    /// </summary>
    public bool? IgnoreNonce { get; set; }
    /// <summary>
    /// The issuer URL or discovery document URL to read issuer information from
    /// </summary>
    public string? IssuerDiscoveryUrl { get; set; }
    /// <summary>
    /// Manually specified information for an OpenID Connect issuer.
    /// </summary>
    public OpenIdIssuerInformation? IssuerInformation { get; set; }
    /// <summary>
    /// Override the issuer name for user indexing and lookup.
    /// </summary>
    public string? IssuerOverride { get; set; }
}

/// <summary>
/// Performs an additive update of the custom properties for the specified player. In updating the player's custom
/// properties, properties which already exist will have their values overwritten. No other properties will be changed
/// apart from those specified in the call.
/// </summary>
public class UpdatePlayerCustomPropertiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Optional field used for concurrency control. One can ensure that the update operation will only be performed if the
    /// player's properties have not been updated by any other clients since last the version.
    /// </summary>
    public int? ExpectedPropertiesVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
    /// <summary>
    /// Collection of properties to be set for a player.
    /// </summary>
    public required List<UpdateProperty> Properties { get; set; }
}

public class UpdatePlayerCustomPropertiesResult : PlayFabResultCommon {
    /// <summary>
    /// PlayFab unique identifier of the user whose properties were updated.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Player Shared Secret Keys are used for the call to Client/GetTitlePublicKey, which exchanges the shared secret for an
/// RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature header.
/// </summary>
public class UpdatePlayerSharedSecretRequest : PlayFabRequestCommon {
    /// <summary>
    /// Disable or Enable this key
    /// </summary>
    public bool Disabled { get; set; }
    /// <summary>
    /// Friendly name for this key
    /// </summary>
    public string? FriendlyName { get; set; }
    /// <summary>
    /// The shared secret key to update
    /// </summary>
    public string? SecretKey { get; set; }
}

public class UpdatePlayerSharedSecretResult : PlayFabResultCommon {
}

/// <summary>
/// Statistics are numeric values, with each statistic in the title also generating a leaderboard. The ResetInterval
/// enables automatically resetting leaderboards on a specified interval. Upon reset, the statistic updates to a new
/// version with no values (effectively removing all players from the leaderboard). The previous version's statistic values
/// are also archived for retrieval, if needed (see GetPlayerStatisticVersions). Statistics not created via a call to
/// CreatePlayerStatisticDefinition by default have a VersionChangeInterval of Never, meaning they do not reset on a
/// schedule, but they can be set to do so via a call to UpdatePlayerStatisticDefinition. Once a statistic has been reset
/// (sometimes referred to as versioned or incremented), the now-previous version can still be written to for up a short,
/// pre-defined period (currently 10 seconds), to prevent issues with levels completing around the time of the reset. Also,
/// once reset, the historical statistics for players in the title may be retrieved using the URL specified in the version
/// information (GetPlayerStatisticVersions). The AggregationMethod determines what action is taken when a new statistic
/// value is submitted - always update with the new value (Last), use the highest of the old and new values (Max), use the
/// smallest (Min), or add them together (Sum).
/// </summary>
public class UpdatePlayerStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// the aggregation method to use in updating the statistic (defaults to last)
    /// </summary>
    public StatisticAggregationMethod? AggregationMethod { get; set; }
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// interval at which the values of the statistic for all players are reset (changes are effective at the next occurance of
    /// the new interval boundary)
    /// </summary>
    public StatisticResetIntervalOption? VersionChangeInterval { get; set; }
}

public class UpdatePlayerStatisticDefinitionResult : PlayFabResultCommon {
    /// <summary>
    /// updated statistic definition
    /// </summary>
    public PlayerStatisticDefinition? Statistic { get; set; }
}

/// <summary>
/// Updates permissions for your title. Policies affect what is allowed to happen on your title. Your policy is a
/// collection of statements that, together, govern particular area for your title. Today, the only allowed policy is
/// called 'ApiPolicy' and it governs what API calls are allowed. To verify that you have the latest version always
/// download the current policy from GetPolicy before uploading a new policy. PlayFab updates the base policy periodically
/// and will automatically apply it to the uploaded policy. Overwriting the combined policy blindly may result in
/// unexpected API errors.
/// </summary>
public class UpdatePolicyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Whether to overwrite or append to the existing policy.
    /// </summary>
    public bool OverwritePolicy { get; set; }
    /// <summary>
    /// The name of the policy being updated. Only supported name is 'ApiPolicy'
    /// </summary>
    public required string PolicyName { get; set; }
    /// <summary>
    /// Version of the policy to update. Must be the latest (as returned by GetPolicy).
    /// </summary>
    public int PolicyVersion { get; set; }
    /// <summary>
    /// The new statements to include in the policy.
    /// </summary>
    public required List<PermissionStatement> Statements { get; set; }
}

public class UpdatePolicyResponse : PlayFabResultCommon {
    /// <summary>
    /// The name of the policy that was updated.
    /// </summary>
    public string? PolicyName { get; set; }
    /// <summary>
    /// The statements included in the new version of the policy.
    /// </summary>
    public List<PermissionStatement>? Statements { get; set; }
}

public class UpdateProperty {
    /// <summary>
    /// Name of the custom property. Can contain Unicode letters and digits. They are limited in size.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Value of the custom property. Limited to booleans, numbers, and strings.
    /// </summary>
    public required object Value { get; set; }
}

/// <summary>
/// This operation is additive. Tables with TableId values not currently defined will be added, while those with TableId
/// values matching Tables currently in the catalog will be overwritten with the given values.
/// </summary>
public class UpdateRandomResultTablesRequest : PlayFabRequestCommon {
    /// <summary>
    /// which catalog is being updated. If null, update the current default catalog version
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// array of random result tables to make available (Note: specifying an existing TableId will result in overwriting that
    /// table, while any others will be added to the available set)
    /// </summary>
    public List<RandomResultTable>? Tables { get; set; }
}

public class UpdateRandomResultTablesResult : PlayFabResultCommon {
}

/// <summary>
/// Update segment properties data which are planning to update
/// </summary>
public class UpdateSegmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// Segment model with all of the segment properties data.
    /// </summary>
    public required SegmentModel SegmentModel { get; set; }
}

public class UpdateSegmentResponse : PlayFabResultCommon {
    /// <summary>
    /// Error message.
    /// </summary>
    public string? ErrorMessage { get; set; }
    /// <summary>
    /// Segment id.
    /// </summary>
    public string? SegmentId { get; set; }
}

/// <summary>
/// When used for SetStoreItems, this operation is not additive. Using it will cause the indicated virtual store to be
/// created from scratch. If there is an existing store with the same storeId, it will be deleted and replaced with only
/// the items specified in this call. When used for UpdateStoreItems, this operation is additive. Items with ItemId values
/// not currently in the store will be added, while those with ItemId values matching items currently in the catalog will
/// overwrite those items with the given values. In both cases, a store contains an array of references to items defined in
/// the catalog, along with the prices for the item, in both real world and virtual currencies. These prices act as an
/// override to any prices defined in the catalog. In this way, the base definitions of the items may be defined in the
/// catalog, with all associated properties, while the pricing can be set for each store, as needed. This allows for
/// subsets of goods to be defined for different purposes (in order to simplify showing some, but not all catalog items to
/// users, based upon different characteristics), along with unique prices. Note that all prices defined in the catalog and
/// store definitions for the item are considered valid, and that a compromised client can be made to send a request for an
/// item based upon any of these definitions. If no price is specified in the store for an item, the price set in the
/// catalog should be displayed to the user.
/// </summary>
public class UpdateStoreItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the store to update. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Additional data about the store
    /// </summary>
    public StoreMarketingModel? MarketingData { get; set; }
    /// <summary>
    /// Array of store items - references to catalog items, with specific pricing - to be added
    /// </summary>
    public List<StoreItem>? Store { get; set; }
    /// <summary>
    /// Unique identifier for the store which is to be updated
    /// </summary>
    public required string StoreId { get; set; }
}

public class UpdateStoreItemsResult : PlayFabResultCommon {
}

/// <summary>
/// Note that when calling this API, all properties of the task have to be provided, including properties that you do not
/// want to change. Parameters not specified would be set to default value. If the task name in the update request is new,
/// a task rename operation will be executed before updating other fields of the task. WARNING: Renaming of a task may
/// break logics where the task name is used as an identifier.
/// </summary>
public class UpdateTaskRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description the task
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Specify either the task ID or the name of the task to be updated.
    /// </summary>
    public NameIdentifier? Identifier { get; set; }
    /// <summary>
    /// Whether the schedule is active. Inactive schedule will not trigger task execution.
    /// </summary>
    public bool IsActive { get; set; }
    /// <summary>
    /// Name of the task. This is a unique identifier for tasks in the title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Parameter object specific to the task type. See each task type's create API documentation for details.
    /// </summary>
    public object? Parameter { get; set; }
    /// <summary>
    /// Cron expression for the run schedule of the task. The expression should be in UTC.
    /// </summary>
    public string? Schedule { get; set; }
    /// <summary>
    /// Task type.
    /// </summary>
    public ScheduledTaskType Type { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the user. In
/// updating the custom data object, keys which already exist in the object will have their values overwritten, while keys
/// with null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Key-value pairs to be written to the custom data. Note that keys are trimmed of whitespace, are limited in size, and
    /// may not begin with a '!' character or be null.
    /// </summary>
    public Dictionary<string, string>? Data { get; set; }
    /// <summary>
    /// Optional list of Data-keys to remove from UserData. Some SDKs cannot insert null-values into Data due to language
    /// constraints. Use this to delete the keys directly.
    /// </summary>
    public List<string>? KeysToRemove { get; set; }
    /// <summary>
    /// Permission to be applied to all user data keys written in this request. Defaults to "private" if not set.
    /// </summary>
    public UserDataPermission? Permission { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class UpdateUserDataResult : PlayFabResultCommon {
    /// <summary>
    /// Indicates the current version of the data that has been set. This is incremented with every set call for that type of
    /// data (read-only, internal, etc). This version can be provided in Get calls to find updated data.
    /// </summary>
    public UInt32 DataVersion { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary JSON object containing the custom data for the user. In
/// updating the custom data object, keys which already exist in the object will have their values overwritten, keys with
/// null values will be removed. No other key-value pairs will be changed apart from those specified in the call.
/// </summary>
public class UpdateUserInternalDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Key-value pairs to be written to the custom data. Note that keys are trimmed of whitespace, are limited in size, and
    /// may not begin with a '!' character or be null.
    /// </summary>
    public Dictionary<string, string>? Data { get; set; }
    /// <summary>
    /// Optional list of Data-keys to remove from UserData. Some SDKs cannot insert null-values into Data due to language
    /// constraints. Use this to delete the keys directly.
    /// </summary>
    public List<string>? KeysToRemove { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required string PlayFabId { get; set; }
}

/// <summary>
/// In addition to the PlayFab username, titles can make use of a DisplayName which is also a unique identifier, but
/// specific to the title. This allows for unique names which more closely match the theme or genre of a title, for
/// example. This API enables changing that name, whether due to a customer request, an offensive name choice, etc.
/// </summary>
public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// New title display name for the user - must be between 3 and 25 characters
    /// </summary>
    public required string DisplayName { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose title specific display name is to be changed
    /// </summary>
    public required string PlayFabId { get; set; }
}

public class UpdateUserTitleDisplayNameResult : PlayFabResultCommon {
    /// <summary>
    /// current title display name for the user (this will be the original display name if the rename attempt failed)
    /// </summary>
    public string? DisplayName { get; set; }
}

public class UserAccountInfo {
    /// <summary>
    /// User Android device information, if an Android device has been linked
    /// </summary>
    public UserAndroidDeviceInfo? AndroidDeviceInfo { get; set; }
    /// <summary>
    /// Sign in with Apple account information, if an Apple account has been linked
    /// </summary>
    public UserAppleIdInfo? AppleAccountInfo { get; set; }
    /// <summary>
    /// Battle.net account information, if a Battle.net account has been linked
    /// </summary>
    public UserBattleNetInfo? BattleNetAccountInfo { get; set; }
    /// <summary>
    /// Timestamp indicating when the user account was created
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// Custom ID information, if a custom ID has been assigned
    /// </summary>
    public UserCustomIdInfo? CustomIdInfo { get; set; }
    /// <summary>
    /// User Facebook information, if a Facebook account has been linked
    /// </summary>
    public UserFacebookInfo? FacebookInfo { get; set; }
    /// <summary>
    /// Facebook Instant Games account information, if a Facebook Instant Games account has been linked
    /// </summary>
    public UserFacebookInstantGamesIdInfo? FacebookInstantGamesIdInfo { get; set; }
    /// <summary>
    /// User Gamecenter information, if a Gamecenter account has been linked
    /// </summary>
    public UserGameCenterInfo? GameCenterInfo { get; set; }
    /// <summary>
    /// User Google account information, if a Google account has been linked
    /// </summary>
    public UserGoogleInfo? GoogleInfo { get; set; }
    /// <summary>
    /// User Google Play Games account information, if a Google Play Games account has been linked
    /// </summary>
    public UserGooglePlayGamesInfo? GooglePlayGamesInfo { get; set; }
    /// <summary>
    /// User iOS device information, if an iOS device has been linked
    /// </summary>
    public UserIosDeviceInfo? IosDeviceInfo { get; set; }
    /// <summary>
    /// User Kongregate account information, if a Kongregate account has been linked
    /// </summary>
    public UserKongregateInfo? KongregateInfo { get; set; }
    /// <summary>
    /// Nintendo Switch account information, if a Nintendo Switch account has been linked
    /// </summary>
    public UserNintendoSwitchAccountIdInfo? NintendoSwitchAccountInfo { get; set; }
    /// <summary>
    /// Nintendo Switch device information, if a Nintendo Switch device has been linked
    /// </summary>
    public UserNintendoSwitchDeviceIdInfo? NintendoSwitchDeviceIdInfo { get; set; }
    /// <summary>
    /// OpenID Connect information, if any OpenID Connect accounts have been linked
    /// </summary>
    public List<UserOpenIdInfo>? OpenIdInfo { get; set; }
    /// <summary>
    /// Unique identifier for the user account
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Personal information for the user which is considered more sensitive
    /// </summary>
    public UserPrivateAccountInfo? PrivateInfo { get; set; }
    /// <summary>
    /// User PlayStation :tm: Network account information, if a PlayStation :tm: Network account has been linked
    /// </summary>
    public UserPsnInfo? PsnInfo { get; set; }
    /// <summary>
    /// Server Custom ID information, if a server custom ID has been assigned
    /// </summary>
    public UserServerCustomIdInfo? ServerCustomIdInfo { get; set; }
    /// <summary>
    /// User Steam information, if a Steam account has been linked
    /// </summary>
    public UserSteamInfo? SteamInfo { get; set; }
    /// <summary>
    /// Title-specific information for the user account
    /// </summary>
    public UserTitleInfo? TitleInfo { get; set; }
    /// <summary>
    /// User Twitch account information, if a Twitch account has been linked
    /// </summary>
    public UserTwitchInfo? TwitchInfo { get; set; }
    /// <summary>
    /// User account name in the PlayFab service
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// User XBox account information, if a XBox account has been linked
    /// </summary>
    public UserXboxInfo? XboxInfo { get; set; }
}

public class UserAndroidDeviceInfo {
    /// <summary>
    /// Android device ID
    /// </summary>
    public string? AndroidDeviceId { get; set; }
}

public class UserAppleIdInfo {
    /// <summary>
    /// Apple subject ID
    /// </summary>
    public string? AppleSubjectId { get; set; }
}

public class UserBattleNetInfo {
    /// <summary>
    /// Battle.net identifier
    /// </summary>
    public string? BattleNetAccountId { get; set; }
    /// <summary>
    /// Battle.net display name
    /// </summary>
    public string? BattleNetBattleTag { get; set; }
}

[Obsolete("Do not use")]
public class UserCredentials {
    /// <summary>
    /// Password for the PlayFab account
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// Username of user to reset
    /// </summary>
    public required string Username { get; set; }
}

public class UserCustomIdInfo {
    /// <summary>
    /// Custom ID
    /// </summary>
    public string? CustomId { get; set; }
}

public enum UserDataPermission {
    Private,
    Public,
}

public class UserDataRecord {
    /// <summary>
    /// Timestamp for when this data was last updated.
    /// </summary>
    public required DateTime LastUpdated { get; set; }
    /// <summary>
    /// Indicates whether this data can be read by all users (public) or only the user (private). This is used for GetUserData
    /// requests being made by one player about another player.
    /// </summary>
    public UserDataPermission? Permission { get; set; }
    /// <summary>
    /// Data stored for the specified user data key.
    /// </summary>
    public string? Value { get; set; }
}

public class UserFacebookInfo {
    /// <summary>
    /// Facebook identifier
    /// </summary>
    public string? FacebookId { get; set; }
    /// <summary>
    /// Facebook full name
    /// </summary>
    public string? FullName { get; set; }
}

public class UserFacebookInstantGamesIdInfo {
    /// <summary>
    /// Facebook Instant Games ID
    /// </summary>
    public string? FacebookInstantGamesId { get; set; }
}

public enum UserFamilyType {
    None,
    Xbox,
    Steam,
}

public class UserGameCenterInfo {
    /// <summary>
    /// Gamecenter identifier
    /// </summary>
    public string? GameCenterId { get; set; }
}

public class UserGoogleInfo {
    /// <summary>
    /// Email address of the Google account
    /// </summary>
    public string? GoogleEmail { get; set; }
    /// <summary>
    /// Gender information of the Google account
    /// </summary>
    public string? GoogleGender { get; set; }
    /// <summary>
    /// Google ID
    /// </summary>
    public string? GoogleId { get; set; }
    /// <summary>
    /// Locale of the Google account
    /// </summary>
    public string? GoogleLocale { get; set; }
    /// <summary>
    /// Name of the Google account user
    /// </summary>
    public string? GoogleName { get; set; }
}

public class UserGooglePlayGamesInfo {
    /// <summary>
    /// Avatar image url of the Google Play Games player
    /// </summary>
    public string? GooglePlayGamesPlayerAvatarImageUrl { get; set; }
    /// <summary>
    /// Display name of the Google Play Games player
    /// </summary>
    public string? GooglePlayGamesPlayerDisplayName { get; set; }
    /// <summary>
    /// Google Play Games player ID
    /// </summary>
    public string? GooglePlayGamesPlayerId { get; set; }
}

public class UserIosDeviceInfo {
    /// <summary>
    /// iOS device ID
    /// </summary>
    public string? IosDeviceId { get; set; }
}

public class UserKongregateInfo {
    /// <summary>
    /// Kongregate ID
    /// </summary>
    public string? KongregateId { get; set; }
    /// <summary>
    /// Kongregate Username
    /// </summary>
    public string? KongregateName { get; set; }
}

public class UserNintendoSwitchAccountIdInfo {
    /// <summary>
    /// Nintendo Switch account subject ID
    /// </summary>
    public string? NintendoSwitchAccountSubjectId { get; set; }
}

public class UserNintendoSwitchDeviceIdInfo {
    /// <summary>
    /// Nintendo Switch Device ID
    /// </summary>
    public string? NintendoSwitchDeviceId { get; set; }
}

public class UserOpenIdInfo {
    /// <summary>
    /// OpenID Connection ID
    /// </summary>
    public string? ConnectionId { get; set; }
    /// <summary>
    /// OpenID Issuer
    /// </summary>
    public string? Issuer { get; set; }
    /// <summary>
    /// OpenID Subject
    /// </summary>
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
    /// <summary>
    /// User login provider.
    /// </summary>
    public SegmentLoginIdentityProvider? LoginProvider { get; set; }
}

public class UserPrivateAccountInfo {
    /// <summary>
    /// user email address
    /// </summary>
    public string? Email { get; set; }
}

public class UserPsnInfo {
    /// <summary>
    /// PlayStation :tm: Network account ID
    /// </summary>
    public string? PsnAccountId { get; set; }
    /// <summary>
    /// PlayStation :tm: Network online ID
    /// </summary>
    public string? PsnOnlineId { get; set; }
}

public class UserServerCustomIdInfo {
    /// <summary>
    /// Custom ID
    /// </summary>
    public string? CustomId { get; set; }
}

public class UserSteamInfo {
    /// <summary>
    /// what stage of game ownership the user is listed as being in, from Steam
    /// </summary>
    public TitleActivationStatus? SteamActivationStatus { get; set; }
    /// <summary>
    /// the country in which the player resides, from Steam data
    /// </summary>
    public string? SteamCountry { get; set; }
    /// <summary>
    /// currency type set in the user Steam account
    /// </summary>
    public Currency? SteamCurrency { get; set; }
    /// <summary>
    /// Steam identifier
    /// </summary>
    public string? SteamId { get; set; }
    /// <summary>
    /// Steam display name
    /// </summary>
    public string? SteamName { get; set; }
}

public class UserTitleInfo {
    /// <summary>
    /// URL to the player's avatar.
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// timestamp indicating when the user was first associated with this game (this can differ significantly from when the
    /// user first registered with PlayFab)
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// name of the user, as it is displayed in-game
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// timestamp indicating when the user first signed into this game (this can differ from the Created timestamp, as other
    /// events, such as issuing a beta key to the user, can associate the title to the user)
    /// </summary>
    public DateTime? FirstLogin { get; set; }
    /// <summary>
    /// boolean indicating whether or not the user is currently banned for a title
    /// </summary>
    public bool? isBanned { get; set; }
    /// <summary>
    /// timestamp for the last user login for this title
    /// </summary>
    public DateTime? LastLogin { get; set; }
    /// <summary>
    /// source by which the user first joined the game, if known
    /// </summary>
    public UserOrigination? Origination { get; set; }
    /// <summary>
    /// Title player account entity for this user
    /// </summary>
    public EntityKey? TitlePlayerAccount { get; set; }
}

public class UserTwitchInfo {
    /// <summary>
    /// Twitch ID
    /// </summary>
    public string? TwitchId { get; set; }
    /// <summary>
    /// Twitch Username
    /// </summary>
    public string? TwitchUserName { get; set; }
}

public class UserXboxInfo {
    /// <summary>
    /// XBox user ID
    /// </summary>
    public string? XboxUserId { get; set; }
    /// <summary>
    /// XBox user sandbox
    /// </summary>
    public string? XboxUserSandbox { get; set; }
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
    public UInt32 TotalValue { get; set; }
    /// <summary>
    /// Total value of the purchases in a string representation of decimal monetary units. For example, '9.99' indicates nine
    /// dollars and ninety-nine cents when Currency is 'USD'.
    /// </summary>
    public string? TotalValueAsDecimal { get; set; }
}

public class ValueToDateSegmentFilter {
    /// <summary>
    /// Value to date amount.
    /// </summary>
    public string? Amount { get; set; }
    /// <summary>
    /// Value to date comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Currency using for filter.
    /// </summary>
    public SegmentCurrency? Currency { get; set; }
}

public class VirtualCurrencyBalanceSegmentFilter {
    /// <summary>
    /// Total amount.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// Amount comparison.
    /// </summary>
    public SegmentFilterComparison? Comparison { get; set; }
    /// <summary>
    /// Currency code.
    /// </summary>
    public string? CurrencyCode { get; set; }
}

public class VirtualCurrencyData {
    /// <summary>
    /// unique two-character identifier for this currency type (e.g.: "CC")
    /// </summary>
    public required string CurrencyCode { get; set; }
    /// <summary>
    /// friendly name to show in the developer portal, reports, etc.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// amount to automatically grant users upon first login to the title
    /// </summary>
    public int? InitialDeposit { get; set; }
    /// <summary>
    /// maximum amount to which the currency will recharge (cannot exceed MaxAmount, but can be less)
    /// </summary>
    public int? RechargeMax { get; set; }
    /// <summary>
    /// rate at which the currency automatically be added to over time, in units per day (24 hours)
    /// </summary>
    public int? RechargeRate { get; set; }
}

public class VirtualCurrencyRechargeTime {
    /// <summary>
    /// Maximum value to which the regenerating currency will automatically increment. Note that it can exceed this value
    /// through use of the AddUserVirtualCurrency API call. However, it will not regenerate automatically until it has fallen
    /// below this value.
    /// </summary>
    public int RechargeMax { get; set; }
    /// <summary>
    /// Server timestamp in UTC indicating the next time the virtual currency will be incremented.
    /// </summary>
    public required DateTime RechargeTime { get; set; }
    /// <summary>
    /// Time remaining (in seconds) before the next recharge increment of the virtual currency.
    /// </summary>
    public int SecondsToRecharge { get; set; }
}

