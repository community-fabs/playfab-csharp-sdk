using CommunityFabs.NET.Common.Http;

namespace CommunityFabs.NET.Common.Models.Client;

public class AcceptTradeRequest : PlayFabRequestCommon {
    /// <summary>
    /// Items from the accepting player's inventory in exchange for the offered items in the trade. In the case of a gift, this
    /// will be null.
    /// </summary>
    public List<string>? AcceptedInventoryInstanceIds { get; set; }
    /// <summary>
    /// Player who opened the trade.
    /// </summary>
    public required string OfferingPlayerId { get; set; }
    /// <summary>
    /// Trade identifier.
    /// </summary>
    public required string TradeId { get; set; }
}

public class AcceptTradeResponse : PlayFabResultCommon {
    /// <summary>
    /// Details about trade which was just accepted.
    /// </summary>
    public TradeInfo? Trade { get; set; }
}

public enum AdActivity {
    Opened,
    Closed,
    Start,
    End,
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

public class AddFriendRequest : PlayFabRequestCommon {
    /// <summary>
    /// Email address of the user to attempt to add to the local user's friend list.
    /// </summary>
    public string? FriendEmail { get; set; }
    /// <summary>
    /// PlayFab identifier of the user to attempt to add to the local user's friend list.
    /// </summary>
    public string? FriendPlayFabId { get; set; }
    /// <summary>
    /// Title-specific display name of the user to attempt to add to the local user's friend list.
    /// </summary>
    public string? FriendTitleDisplayName { get; set; }
    /// <summary>
    /// PlayFab username of the user to attempt to add to the local user's friend list.
    /// </summary>
    public string? FriendUsername { get; set; }
}

public class AddFriendResult : PlayFabResultCommon {
    /// <summary>
    /// True if the friend request was processed successfully.
    /// </summary>
    public bool Created { get; set; }
}

public class AddGenericIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Generic service identifier to add to the player account.
    /// </summary>
    public required GenericServiceId GenericId { get; set; }
}

public class AddGenericIDResult : PlayFabResultCommon {
}

/// <summary>
/// This API adds a contact email to the player's profile. If the player's profile already contains a contact email, it
/// will update the contact email to the email address specified.
/// </summary>
public class AddOrUpdateContactEmailRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The new contact email to associate with the player.
    /// </summary>
    public required string EmailAddress { get; set; }
}

public class AddOrUpdateContactEmailResult : PlayFabResultCommon {
}

public class AddSharedGroupMembersRequest : PlayFabRequestCommon {
    /// <summary>
    /// An array of unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required List<string> PlayFabIds { get; set; }
    /// <summary>
    /// Unique identifier for the shared group.
    /// </summary>
    public required string SharedGroupId { get; set; }
}

public class AddSharedGroupMembersResult : PlayFabResultCommon {
}

public class AddUsernamePasswordRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// User email address attached to their account
    /// </summary>
    public required string Email { get; set; }
    /// <summary>
    /// Password for the PlayFab account (6-100 characters)
    /// </summary>
    public required string Password { get; set; }
    /// <summary>
    /// PlayFab username for the account (3-20 characters)
    /// </summary>
    public required string Username { get; set; }
}

/// <summary>
/// Each account must have a unique username and email address in the PlayFab service. Once created, the account may be
/// associated with additional accounts (Steam, Facebook, Game Center, etc.), allowing for added social network lists and
/// achievements systems. This can also be used to provide a recovery method if the user loses their original means of
/// access.
/// </summary>
public class AddUsernamePasswordResult : PlayFabResultCommon {
    /// <summary>
    /// PlayFab unique user name.
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
public class AddUserVirtualCurrencyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Amount to be added to the user balance of the specified virtual currency.
    /// </summary>
    public int Amount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the virtual currency which is to be incremented.
    /// </summary>
    public required string VirtualCurrency { get; set; }
}

/// <summary>
/// A single ad placement details including placement and reward information
/// </summary>
public class AdPlacementDetails {
    /// <summary>
    /// Placement unique ID
    /// </summary>
    public string? PlacementId { get; set; }
    /// <summary>
    /// Placement name
    /// </summary>
    public string? PlacementName { get; set; }
    /// <summary>
    /// If placement has viewing limits indicates how many views are left
    /// </summary>
    public int? PlacementViewsRemaining { get; set; }
    /// <summary>
    /// If placement has viewing limits indicates when they will next reset
    /// </summary>
    public double? PlacementViewsResetMinutes { get; set; }
    /// <summary>
    /// Optional URL to a reward asset
    /// </summary>
    public string? RewardAssetUrl { get; set; }
    /// <summary>
    /// Reward description
    /// </summary>
    public string? RewardDescription { get; set; }
    /// <summary>
    /// Reward unique ID
    /// </summary>
    public string? RewardId { get; set; }
    /// <summary>
    /// Reward name
    /// </summary>
    public string? RewardName { get; set; }
}

/// <summary>
/// Details for each item granted
/// </summary>
public class AdRewardItemGranted {
    /// <summary>
    /// Catalog ID
    /// </summary>
    public string? CatalogId { get; set; }
    /// <summary>
    /// Catalog item display name
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Inventory instance ID
    /// </summary>
    public string? InstanceId { get; set; }
    /// <summary>
    /// Item ID
    /// </summary>
    public string? ItemId { get; set; }
}

/// <summary>
/// Details on what was granted to the player
/// </summary>
public class AdRewardResults {
    /// <summary>
    /// Array of the items granted to the player
    /// </summary>
    public List<AdRewardItemGranted>? GrantedItems { get; set; }
    /// <summary>
    /// Dictionary of virtual currencies that were granted to the player
    /// </summary>
    public Dictionary<string, int>? GrantedVirtualCurrencies { get; set; }
    /// <summary>
    /// Dictionary of statistics that were modified for the player
    /// </summary>
    public Dictionary<string, int>? IncrementedStatistics { get; set; }
}

/// <summary>
/// More information can be found on configuring your game for the Google Cloud Messaging service in the Google developer
/// documentation, here: http://developer.android.com/google/gcm/client.html. The steps to configure and send Push
/// Notifications is described in the PlayFab tutorials, here:
/// https://docs.microsoft.com/gaming/playfab/features/engagement/push-notifications/quickstart.
/// </summary>
public class AndroidDevicePushNotificationRegistrationRequest : PlayFabRequestCommon {
    /// <summary>
    /// Message to display when confirming push notification.
    /// </summary>
    public string? ConfirmationMessage { get; set; }
    /// <summary>
    /// Registration ID provided by the Google Cloud Messaging service when the title registered to receive push notifications
    /// (see the GCM documentation, here: http://developer.android.com/google/gcm/client.html).
    /// </summary>
    public required string DeviceToken { get; set; }
    /// <summary>
    /// If true, send a test push message immediately after sucessful registration. Defaults to false.
    /// </summary>
    public bool? SendPushNotificationConfirmation { get; set; }
}

public class AndroidDevicePushNotificationRegistrationResult : PlayFabResultCommon {
}

/// <summary>
/// If you have an ad attribution partner enabled, this will post an install to their service to track the device. It uses
/// the given device id to match based on clicks on ads.
/// </summary>
public class AttributeInstallRequest : PlayFabRequestCommon {
    /// <summary>
    /// The adid for this device.
    /// </summary>
    public string? Adid { get; set; }
    /// <summary>
    /// The android advertising id. This field is deprecated in favor of Adid for clarity.
    /// </summary>
    public string? Android_Id { get; set; }
    /// <summary>
    /// The IdentifierForAdvertisers for iOS Devices.
    /// </summary>
    public string? Idfa { get; set; }
}

public class AttributeInstallResult : PlayFabResultCommon {
}

public class BattleNetAccountPlayFabIdPair {
    /// <summary>
    /// Unique Battle.net account identifier for a user.
    /// </summary>
    public string? BattleNetAccountId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Battle.net account identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class CancelTradeRequest : PlayFabRequestCommon {
    /// <summary>
    /// Trade identifier.
    /// </summary>
    public required string TradeId { get; set; }
}

public class CancelTradeResponse : PlayFabResultCommon {
    /// <summary>
    /// Details about trade which was just canceled.
    /// </summary>
    public TradeInfo? Trade { get; set; }
}

public class CartItem {
    /// <summary>
    /// Description of the catalog item.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Display name for the catalog item.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Class name to which catalog item belongs.
    /// </summary>
    public string? ItemClass { get; set; }
    /// <summary>
    /// Unique identifier for the catalog item.
    /// </summary>
    public string? ItemId { get; set; }
    /// <summary>
    /// Unique instance identifier for this catalog item.
    /// </summary>
    public string? ItemInstanceId { get; set; }
    /// <summary>
    /// Cost of the catalog item for each applicable real world currency.
    /// </summary>
    public Dictionary<string, uint>? RealCurrencyPrices { get; set; }
    /// <summary>
    /// Amount of each applicable virtual currency which will be received as a result of purchasing this catalog item.
    /// </summary>
    public Dictionary<string, uint>? VCAmount { get; set; }
    /// <summary>
    /// Cost of the catalog item for each applicable virtual currency.
    /// </summary>
    public Dictionary<string, uint>? VirtualCurrencyPrices { get; set; }
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
    public Dictionary<string, uint>? RealCurrencyPrices { get; set; }
    /// <summary>
    /// list of item tags
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// price of this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
    /// </summary>
    public Dictionary<string, uint>? VirtualCurrencyPrices { get; set; }
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
    public Dictionary<string, uint>? BundledVirtualCurrencies { get; set; }
}

public class CatalogItemConsumableInfo {
    /// <summary>
    /// number of times this object can be used, after which it will be removed from the player inventory
    /// </summary>
    public uint? UsageCount { get; set; }
    /// <summary>
    /// duration in seconds for how long the item will remain in the player inventory - once elapsed, the item will be removed
    /// (recommended minimum value is 5 seconds, as lower values can cause the item to expire before operations depending on
    /// this item's details have completed)
    /// </summary>
    public uint? UsagePeriod { get; set; }
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
    public Dictionary<string, uint>? VirtualCurrencyContents { get; set; }
}

public class CharacterInventory {
    /// <summary>
    /// The id of this character.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// The inventory of this character.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
}

public class CharacterLeaderboardEntry {
    /// <summary>
    /// PlayFab unique identifier of the character that belongs to the user for this leaderboard entry.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Title-specific display name of the character for this leaderboard entry.
    /// </summary>
    public string? CharacterName { get; set; }
    /// <summary>
    /// Name of the character class for this entry.
    /// </summary>
    public string? CharacterType { get; set; }
    /// <summary>
    /// Title-specific display name of the user for this leaderboard entry.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user for this leaderboard entry.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// User's overall position in the leaderboard.
    /// </summary>
    public int Position { get; set; }
    /// <summary>
    /// Specific value of the user's statistic.
    /// </summary>
    public int StatValue { get; set; }
}

public class CharacterResult {
    /// <summary>
    /// The id for this character on this player.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// The name of this character.
    /// </summary>
    public string? CharacterName { get; set; }
    /// <summary>
    /// The type-string that was given to this character on creation.
    /// </summary>
    public string? CharacterType { get; set; }
}

public enum CloudScriptRevisionOption {
    Live,
    Latest,
    Specific,
}

/// <summary>
/// Collection filter to include and/or exclude collections with certain key-value pairs. The filter generates a collection
/// set defined by Includes rules and then remove collections that matches the Excludes rules. A collection is considered
/// matching a rule if the rule describes a subset of the collection.
/// </summary>
[Obsolete("Do not use")]
public class CollectionFilter {
    /// <summary>
    /// List of Exclude rules, with any of which if a collection matches, it is excluded by the filter.
    /// </summary>
    public List<Container_Dictionary_String_String>? Excludes { get; set; }
    /// <summary>
    /// List of Include rules, with any of which if a collection matches, it is included by the filter, unless it is excluded
    /// by one of the Exclude rule
    /// </summary>
    public List<Container_Dictionary_String_String>? Includes { get; set; }
}

/// <summary>
/// The final step in the purchasing process, this API finalizes the purchase with the payment provider, where applicable,
/// adding virtual goods to the player inventory (including random drop table resolution and recursive addition of bundled
/// items) and adjusting virtual currency balances for funds used or added. Note that this is a pull operation, and should
/// be polled regularly when a purchase is in progress. Please note that the processing time for inventory grants and
/// purchases increases fractionally the more items are in the inventory, and the more items are in the grant/purchase
/// operation.
/// </summary>
public class ConfirmPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Purchase order identifier returned from StartPurchase.
    /// </summary>
    public required string OrderId { get; set; }
}

/// <summary>
/// When the FailedByPaymentProvider error is returned, it's important to check the ProviderErrorCode,
/// ProviderErrorMessage, and ProviderErrorDetails to understand the specific reason the payment was rejected, as in some
/// rare cases, this may mean that the provider hasn't completed some operation required to finalize the purchase.
/// </summary>
public class ConfirmPurchaseResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
    /// <summary>
    /// Purchase order identifier.
    /// </summary>
    public string? OrderId { get; set; }
    /// <summary>
    /// Date and time of the purchase.
    /// </summary>
    public required DateTime PurchaseDate { get; set; }
}

public class ConsumeItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Number of uses to consume from the item.
    /// </summary>
    public int ConsumeCount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique instance identifier of the item to be consumed.
    /// </summary>
    public required string ItemInstanceId { get; set; }
}

public class ConsumeItemResult : PlayFabResultCommon {
    /// <summary>
    /// Unique instance identifier of the item with uses consumed.
    /// </summary>
    public string? ItemInstanceId { get; set; }
    /// <summary>
    /// Number of uses remaining on the item.
    /// </summary>
    public int RemainingUses { get; set; }
}

public class ConsumeMicrosoftStoreEntitlementsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version to use
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Marketplace specific payload containing details to fetch in app purchase transactions
    /// </summary>
    public required MicrosoftStorePayload MarketplaceSpecificData { get; set; }
}

public class ConsumeMicrosoftStoreEntitlementsResponse : PlayFabResultCommon {
    /// <summary>
    /// Details for the items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
}

public class ConsumePS5EntitlementsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version to use
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Marketplace specific payload containing details to fetch in app purchase transactions
    /// </summary>
    public required PlayStation5Payload MarketplaceSpecificData { get; set; }
}

public class ConsumePS5EntitlementsResult : PlayFabResultCommon {
    /// <summary>
    /// Details for the items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
}

public class ConsumePSNEntitlementsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Which catalog to match granted entitlements against. If null, defaults to title default catalog
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Id of the PlayStation :tm: Network service label to consume entitlements from
    /// </summary>
    public int ServiceLabel { get; set; }
}

public class ConsumePSNEntitlementsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items granted to the player as a result of consuming entitlements.
    /// </summary>
    public List<ItemInstance>? ItemsGranted { get; set; }
}

public class ConsumeXboxEntitlementsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version to use
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Token provided by the Xbox Live SDK/XDK method GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", "").
    /// </summary>
    public required string XboxToken { get; set; }
}

public class ConsumeXboxEntitlementsResult : PlayFabResultCommon {
    /// <summary>
    /// Details for the items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
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

/// <summary>
/// A data container
/// </summary>
[Obsolete("Do not use")]
public class Container_Dictionary_String_String {
    /// <summary>
    /// Content of data
    /// </summary>
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
/// If SharedGroupId is specified, the service will attempt to create a group with that identifier, and will return an
/// error if it is already in use. If no SharedGroupId is specified, a random identifier will be assigned.
/// </summary>
public class CreateSharedGroupRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier for the shared group (a random identifier will be assigned, if one is not specified).
    /// </summary>
    public string? SharedGroupId { get; set; }
}

public class CreateSharedGroupResult : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier for the shared group.
    /// </summary>
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
    /// <summary>
    /// Build to match against.
    /// </summary>
    public string? BuildVersion { get; set; }
    /// <summary>
    /// Game mode to look for.
    /// </summary>
    public string? GameMode { get; set; }
    /// <summary>
    /// Region to check for Game Server Instances.
    /// </summary>
    public Region? Region { get; set; }
    /// <summary>
    /// Statistic name to find statistic-based matches.
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// Filter to include and/or exclude Game Server Instances associated with certain tags.
    /// </summary>
    public CollectionFilter? TagFilter { get; set; }
}

[Obsolete("Do not use")]
public class CurrentGamesResult : PlayFabResultCommon {
    /// <summary>
    /// number of games running
    /// </summary>
    public int GameCount { get; set; }
    /// <summary>
    /// array of games found
    /// </summary>
    public List<GameInfo>? Games { get; set; }
    /// <summary>
    /// total number of players across all servers
    /// </summary>
    public int PlayerCount { get; set; }
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
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Any arbitrary information collected by the device
/// </summary>
public class DeviceInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// Information posted to the PlayStream Event. Currently arbitrary, and specific to the environment sending it.
    /// </summary>
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

public class EntityTokenResponse {
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The token used to set X-EntityToken for all entity based API calls.
    /// </summary>
    public string? EntityToken { get; set; }
    /// <summary>
    /// The time the token will expire, if it is an expiring token, in UTC.
    /// </summary>
    public DateTime? TokenExpiration { get; set; }
}

public class ExecuteCloudScriptRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the CloudScript function to execute
    /// </summary>
    public required string FunctionName { get; set; }
    /// <summary>
    /// Object that is passed in to the function as the first argument
    /// </summary>
    public object? FunctionParameter { get; set; }
    /// <summary>
    /// Generate a 'player_executed_cloudscript' PlayStream event containing the results of the function execution and other
    /// contextual information. This event will show up in the PlayStream debugger console for the player in Game Manager.
    /// </summary>
    public bool? GeneratePlayStreamEvent { get; set; }
    /// <summary>
    /// Option for which revision of the CloudScript to execute. 'Latest' executes the most recently created revision, 'Live'
    /// executes the current live, published revision, and 'Specific' executes the specified revision. The default value is
    /// 'Specific', if the SpeificRevision parameter is specified, otherwise it is 'Live'.
    /// </summary>
    public CloudScriptRevisionOption? RevisionSelection { get; set; }
    /// <summary>
    /// The specivic revision to execute, when RevisionSelection is set to 'Specific'
    /// </summary>
    public int? SpecificRevision { get; set; }
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

public enum ExternalFriendSources {
    None,
    Steam,
    Facebook,
    Xbox,
    Psn,
    All,
}

public class FacebookInstantGamesPlayFabIdPair {
    /// <summary>
    /// Unique Facebook Instant Games identifier for a user.
    /// </summary>
    public string? FacebookInstantGamesId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Facebook Instant Games identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class FacebookPlayFabIdPair {
    /// <summary>
    /// Unique Facebook identifier for a user.
    /// </summary>
    public string? FacebookId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Facebook identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class FriendInfo {
    /// <summary>
    /// This field is not populated.
    /// </summary>
    public string? CurrentMatchmakerLobbyId { get; set; }
    /// <summary>
    /// Available Facebook information (if the user and connected Facebook friend both have PlayFab Accounts in the same title).
    /// </summary>
    public UserFacebookInfo? FacebookInfo { get; set; }
    /// <summary>
    /// PlayFab unique identifier for this friend.
    /// </summary>
    public string? FriendPlayFabId { get; set; }
    /// <summary>
    /// Available Game Center information (if the user and connected Game Center friend both have PlayFab Accounts in the same
    /// title).
    /// </summary>
    public UserGameCenterInfo? GameCenterInfo { get; set; }
    /// <summary>
    /// The profile of the user, if requested.
    /// </summary>
    public PlayerProfileModel? Profile { get; set; }
    /// <summary>
    /// Available PlayStation :tm: Network information, if the user connected PlayStation :tm Network friend both have PlayFab
    /// Accounts in the same title.
    /// </summary>
    public UserPsnInfo? PSNInfo { get; set; }
    /// <summary>
    /// Available Steam information (if the user and connected Steam friend both have PlayFab Accounts in the same title).
    /// </summary>
    public UserSteamInfo? SteamInfo { get; set; }
    /// <summary>
    /// Tags which have been associated with this friend.
    /// </summary>
    public List<string>? Tags { get; set; }
    /// <summary>
    /// Title-specific display name for this friend.
    /// </summary>
    public string? TitleDisplayName { get; set; }
    /// <summary>
    /// PlayFab unique username for this friend.
    /// </summary>
    public string? Username { get; set; }
    /// <summary>
    /// Available Xbox information, (if the user and connected Xbox Live friend both have PlayFab Accounts in the same title).
    /// </summary>
    public UserXboxInfo? XboxInfo { get; set; }
}

public class GameCenterPlayFabIdPair {
    /// <summary>
    /// Unique Game Center identifier for a user.
    /// </summary>
    public string? GameCenterId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Game Center identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class GameInfo {
    /// <summary>
    /// build version this server is running
    /// </summary>
    public string? BuildVersion { get; set; }
    /// <summary>
    /// game mode this server is running
    /// </summary>
    public string? GameMode { get; set; }
    /// <summary>
    /// game session custom data
    /// </summary>
    public string? GameServerData { get; set; }
    /// <summary>
    /// game specific string denoting server configuration
    /// </summary>
    public int? GameServerState { get; set; }
    /// <summary>
    /// game specific string denoting server configuration
    /// </summary>
    public GameInstanceState? GameServerStateEnum { get; set; }
    /// <summary>
    /// last heartbeat of the game server instance, used in external game server provider mode
    /// </summary>
    public DateTime? LastHeartbeat { get; set; }
    /// <summary>
    /// unique lobby identifier for this game server
    /// </summary>
    public string? LobbyID { get; set; }
    /// <summary>
    /// maximum players this server can support
    /// </summary>
    public int? MaxPlayers { get; set; }
    /// <summary>
    /// array of current player IDs on this server
    /// </summary>
    public List<string>? PlayerUserIds { get; set; }
    /// <summary>
    /// region to which this server is associated
    /// </summary>
    public Region? Region { get; set; }
    /// <summary>
    /// duration in seconds this server has been running
    /// </summary>
    public uint RunTime { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerHostname { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// IPV6 address of the server
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// port number to use for non-http communications with the server
    /// </summary>
    public int? ServerPort { get; set; }
    /// <summary>
    /// Public DNS name (if any) of the server
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
    /// <summary>
    /// stastic used to match this game in player statistic matchmaking
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// game session tags
    /// </summary>
    public Dictionary<string, string>? Tags { get; set; }
}

public enum GameInstanceState {
    Open,
    Closed,
}

[Obsolete("Do not use")]
public class GameServerRegionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// version of game server for which stats are being requested
    /// </summary>
    public required string BuildVersion { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public string? TitleId { get; set; }
}

[Obsolete("Do not use")]
public class GameServerRegionsResult : PlayFabResultCommon {
    /// <summary>
    /// array of regions found matching the request parameters
    /// </summary>
    public List<RegionInfo>? Regions { get; set; }
}

public class GenericPlayFabIdPair {
    /// <summary>
    /// Unique generic service identifier for a user.
    /// </summary>
    public GenericServiceId? GenericId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the given generic identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class GenericServiceId {
    /// <summary>
    /// Name of the service for which the player has a unique identifier.
    /// </summary>
    public required string ServiceName { get; set; }
    /// <summary>
    /// Unique identifier of the player in that service.
    /// </summary>
    public required string UserId { get; set; }
}

public class GetAccountInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// User email address for the account to find (if no Username is specified).
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the user whose info is being requested. Optional, defaults to the authenticated user if no
    /// other lookup identifier set.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Title-specific username for the account to find (if no Email is set). Note that if the non-unique Title Display Names
    /// option is enabled for the title, attempts to look up users by Title Display Name will always return AccountNotFound.
    /// </summary>
    public string? TitleDisplayName { get; set; }
    /// <summary>
    /// PlayFab Username for the account to find (if no PlayFabId is specified).
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// This API retrieves details regarding the player in the PlayFab service. Note that when this call is used to retrieve
/// data about another player (not the one signed into the local client), some data, such as Personally Identifying
/// Information (PII), will be omitted for privacy reasons or to comply with the requirements of the platform belongs to.
/// The user account returned will be based on the identifier provided in priority order: PlayFabId, Username, Email, then
/// TitleDisplayName. If no identifier is specified, the currently signed in user's information will be returned.
/// </summary>
public class GetAccountInfoResult : PlayFabResultCommon {
    /// <summary>
    /// Account information for the local user.
    /// </summary>
    public UserAccountInfo? AccountInfo { get; set; }
}

/// <summary>
/// Using an AppId to return a list of valid ad placements for a player.
/// </summary>
public class GetAdPlacementsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The current AppId to use
    /// </summary>
    public required string AppId { get; set; }
    /// <summary>
    /// Using the name or unique identifier, filter the result for get a specific placement.
    /// </summary>
    public NameIdentifier? Identifier { get; set; }
}

/// <summary>
/// Array of AdPlacementDetails
/// </summary>
public class GetAdPlacementsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of results
    /// </summary>
    public List<AdPlacementDetails>? AdPlacements { get; set; }
}

public class GetCatalogItemsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Which catalog is being requested. If null, uses the default catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
}

/// <summary>
/// If CatalogVersion is not specified, only inventory items associated with the most recent version of the catalog will be
/// returned.
/// </summary>
public class GetCatalogItemsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items which can be purchased.
    /// </summary>
    public List<CatalogItem>? Catalog { get; set; }
}

/// <summary>
/// Data is stored as JSON key-value pairs. If the Keys parameter is provided, the data object returned will only contain
/// the data specific to the indicated Keys. Otherwise, the full set of custom character data will be returned.
/// </summary>
public class GetCharacterDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// The version that currently exists according to the caller. The call will return the data for all of the keys if the
    /// version in the system is greater than this.
    /// </summary>
    public uint? IfChangedFromDataVersion { get; set; }
    /// <summary>
    /// Specific keys to search for in the custom user data.
    /// </summary>
    public List<string>? Keys { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the user to load data for. Optional, defaults to yourself if not set.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class GetCharacterDataResult : PlayFabResultCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// User specific data for this title.
    /// </summary>
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    /// <summary>
    /// Indicates the current version of the data that has been set. This is incremented with every set call for that type of
    /// data (read-only, internal, etc). This version can be provided in Get calls to find updated data.
    /// </summary>
    public uint DataVersion { get; set; }
}

/// <summary>
/// All items currently in the character inventory will be returned, irrespective of how they were acquired (via
/// purchasing, grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered
/// to be in the user's current inventory, and so will not be not included. Also returns their virtual currency balances.
/// </summary>
public class GetCharacterInventoryRequest : PlayFabRequestCommon {
    /// <summary>
    /// Used to limit results to only those from a specific catalog version.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetCharacterInventoryResult : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier of the character for this inventory.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Array of inventory items belonging to the character.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
    /// <summary>
    /// Array of virtual currency balance(s) belonging to the character.
    /// </summary>
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    /// <summary>
    /// Array of remaining times and timestamps for virtual currencies.
    /// </summary>
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

public class GetCharacterLeaderboardRequest : PlayFabRequestCommon {
    /// <summary>
    /// Optional character type on which to filter the leaderboard entries.
    /// </summary>
    public string? CharacterType { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// First entry in the leaderboard to be retrieved.
    /// </summary>
    public int StartPosition { get; set; }
    /// <summary>
    /// Unique identifier for the title-specific statistic for the leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note that the Position of the character in the results is for the overall leaderboard.
/// </summary>
public class GetCharacterLeaderboardResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered list of leaderboard entries.
    /// </summary>
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

public class GetCharacterStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetCharacterStatisticsResult : PlayFabResultCommon {
    /// <summary>
    /// The requested character statistics.
    /// </summary>
    public Dictionary<string, int>? CharacterStatistics { get; set; }
}

/// <summary>
/// Cloud Scripts in PlayFab have both Versions and Revisions. Each time a new script is uploaded against a Version, this
/// creates a new Revision. If Testing is set to true, the URL returned will be for the Cloud Script Revision which was
/// most recently uploaded. If Testing is set to false, the URL returned will be for the Cloud Script Revision which was
/// most recently deployed to live.
/// </summary>
[Obsolete("Do not use")]
public class GetCloudScriptUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specifies whether the URL returned should be the one for the most recently uploaded Revision of the Cloud Script
    /// (true), or the Revision most recently set to live (false). Defaults to false.
    /// </summary>
    public bool? Testing { get; set; }
    /// <summary>
    /// Cloud Script Version to use. Defaults to 1.
    /// </summary>
    public int? Version { get; set; }
}

/// <summary>
/// The URL returned is the one which must be used by the title to call into a handler in Cloud Script. PlayFab-supplied
/// SDKs will automatically save the results of this call, for use with any calls to RunCloudScript.
/// </summary>
[Obsolete("Do not use")]
public class GetCloudScriptUrlResult : PlayFabResultCommon {
    /// <summary>
    /// URL of the Cloud Script logic server.
    /// </summary>
    public string? Url { get; set; }
}

public class GetContentDownloadUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// HTTP method to fetch item - GET or HEAD. Use HEAD when only fetching metadata. Default is GET.
    /// </summary>
    public string? HttpMethod { get; set; }
    /// <summary>
    /// Key of the content item to fetch, usually formatted as a path, e.g. images/a.png
    /// </summary>
    public required string Key { get; set; }
    /// <summary>
    /// True to download through CDN. CDN provides higher download bandwidth and lower latency. However, if you want the
    /// latest, non-cached version of the content during development, set this to false. Default is true.
    /// </summary>
    public bool? ThruCDN { get; set; }
}

public class GetContentDownloadUrlResult : PlayFabResultCommon {
    /// <summary>
    /// URL for downloading content via HTTP GET or HEAD method. The URL will expire in approximately one hour.
    /// </summary>
    public string? URL { get; set; }
}

[Obsolete("Do not use")]
public class GetFriendLeaderboardAroundCurrentUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends should be included in the response. In HTTP, it is represented as a
    /// comma-separated list of platforms.
    /// </summary>
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    /// <summary>
    /// Indicates whether Facebook friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeFacebookFriends { get; set; }
    /// <summary>
    /// Indicates whether Steam service friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeSteamFriends { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// Statistic used to rank players for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have
/// the corresponding statistic.If Facebook friends are included, make sure the access token from previous
/// LoginWithFacebook call is still valid and not expired. If Xbox Live friends are included, make sure the access token
/// from the previous LoginWithXbox call is still valid and not expired.
/// </summary>
[Obsolete("Do not use")]
public class GetFriendLeaderboardAroundCurrentUserResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered listing of users and their positions in the requested leaderboard.
    /// </summary>
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// The version of the leaderboard returned.
    /// </summary>
    public int Version { get; set; }
}

public class GetFriendLeaderboardAroundPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends should be included in the response. In HTTP, it is represented as a
    /// comma-separated list of platforms.
    /// </summary>
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    /// <summary>
    /// Indicates whether Facebook friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeFacebookFriends { get; set; }
    /// <summary>
    /// Indicates whether Steam service friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeSteamFriends { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user to center the leaderboard around. If null will center on the logged in user.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Statistic used to rank players for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// If set to false, Version is considered null. If true, uses the specified Version
    /// </summary>
    public bool? UseSpecificVersion { get; set; }
    /// <summary>
    /// The version of the leaderboard to get.
    /// </summary>
    public int? Version { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have
/// the corresponding statistic.If Facebook friends are included, make sure the access token from previous
/// LoginWithFacebook call is still valid and not expired. If Xbox Live friends are included, make sure the access token
/// from the previous LoginWithXbox call is still valid and not expired.
/// </summary>
public class GetFriendLeaderboardAroundPlayerResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered listing of users and their positions in the requested leaderboard.
    /// </summary>
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// The version of the leaderboard returned.
    /// </summary>
    public int Version { get; set; }
}

public class GetFriendLeaderboardRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends should be included in the response. In HTTP, it is represented as a
    /// comma-separated list of platforms.
    /// </summary>
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    /// <summary>
    /// Indicates whether Facebook friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeFacebookFriends { get; set; }
    /// <summary>
    /// Indicates whether Steam service friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeSteamFriends { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Position in the leaderboard to start this listing (defaults to the first entry).
    /// </summary>
    public int StartPosition { get; set; }
    /// <summary>
    /// Statistic used to rank friends for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// If set to false, Version is considered null. If true, uses the specified Version
    /// </summary>
    public bool? UseSpecificVersion { get; set; }
    /// <summary>
    /// The version of the leaderboard to get.
    /// </summary>
    public int? Version { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

public class GetFriendsListRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends should be included in the response. In HTTP, it is represented as a
    /// comma-separated list of platforms.
    /// </summary>
    public ExternalFriendSources? ExternalPlatformFriends { get; set; }
    /// <summary>
    /// Indicates whether Facebook friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeFacebookFriends { get; set; }
    /// <summary>
    /// Indicates whether Steam service friends should be included in the response. Default is true.
    /// </summary>
    public bool? IncludeSteamFriends { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

/// <summary>
/// If any additional services are queried for the user's friends, those friends who also have a PlayFab account registered
/// for the title will be returned in the results. For Facebook, user has to have logged into the title's Facebook app
/// recently, and only friends who also plays this game will be included. Note: If the user authenticated with
/// AuthenticationToken when calling LoginWithFacebook, instead of AccessToken, an empty list will be returned. For Xbox
/// Live, user has to have logged into the Xbox Live recently, and only friends who also play this game will be included.
/// </summary>
public class GetFriendsListResult : PlayFabResultCommon {
    /// <summary>
    /// Array of friends found.
    /// </summary>
    public List<FriendInfo>? Friends { get; set; }
}

public class GetLeaderboardAroundCharacterRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character on which to center the leaderboard.
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// Optional character type on which to filter the leaderboard entries.
    /// </summary>
    public string? CharacterType { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// Unique identifier for the title-specific statistic for the leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the character defaults to 0 when the character does
/// not have the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundCharacterResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered list of leaderboard entries.
    /// </summary>
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

[Obsolete("Do not use")]
public class GetLeaderboardAroundCurrentUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// Statistic used to rank players for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have
/// the corresponding statistic.
/// </summary>
[Obsolete("Do not use")]
public class GetLeaderboardAroundCurrentUserResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered listing of users and their positions in the requested leaderboard.
    /// </summary>
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// The version of the leaderboard returned.
    /// </summary>
    public int Version { get; set; }
}

public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user to center the leaderboard around. If null will center on the logged in user.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Statistic used to rank players for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// If set to false, Version is considered null. If true, uses the specified Version
    /// </summary>
    public bool? UseSpecificVersion { get; set; }
    /// <summary>
    /// The version of the leaderboard to get.
    /// </summary>
    public int? Version { get; set; }
}

/// <summary>
/// Note: When calling 'GetLeaderboardAround...' APIs, the position of the user defaults to 0 when the user does not have
/// the corresponding statistic.
/// </summary>
public class GetLeaderboardAroundPlayerResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered listing of users and their positions in the requested leaderboard.
    /// </summary>
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// The version of the leaderboard returned.
    /// </summary>
    public int Version { get; set; }
}

public class GetLeaderboardForUsersCharactersRequest : PlayFabRequestCommon {
    /// <summary>
    /// Maximum number of entries to retrieve.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// Unique identifier for the title-specific statistic for the leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
}

/// <summary>
/// NOTE: The position of the character in the results is relative to the other characters for that specific user. This
/// mean the values will always be between 0 and one less than the number of characters returned regardless of the size of
/// the actual leaderboard.
/// </summary>
public class GetLeaderboardForUsersCharactersResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered list of leaderboard entries.
    /// </summary>
    public List<CharacterLeaderboardEntry>? Leaderboard { get; set; }
}

public class GetLeaderboardRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Maximum number of entries to retrieve. Default 10, maximum 100.
    /// </summary>
    public int? MaxResultsCount { get; set; }
    /// <summary>
    /// If non-null, this determines which properties of the resulting player profiles to return. For API calls from the
    /// client, only the allowed client profile properties for the title may be requested. These allowed properties are
    /// configured in the Game Manager "Client Profile Options" tab in the "Settings" section.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Position in the leaderboard to start this listing (defaults to the first entry).
    /// </summary>
    public int StartPosition { get; set; }
    /// <summary>
    /// Statistic used to rank players for this leaderboard.
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// If set to false, Version is considered null. If true, uses the specified Version
    /// </summary>
    public bool? UseSpecificVersion { get; set; }
    /// <summary>
    /// The version of the leaderboard to get.
    /// </summary>
    public int? Version { get; set; }
}

/// <summary>
/// Note: the user's Position is relative to the overall leaderboard.
/// </summary>
public class GetLeaderboardResult : PlayFabResultCommon {
    /// <summary>
    /// Ordered listing of users and their positions in the requested leaderboard.
    /// </summary>
    public List<PlayerLeaderboardEntry>? Leaderboard { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// The version of the leaderboard returned.
    /// </summary>
    public int Version { get; set; }
}

public class GetPaymentTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The name of service to provide the payment token. Allowed Values are: xsolla
    /// </summary>
    public required string TokenProvider { get; set; }
}

public class GetPaymentTokenResult : PlayFabResultCommon {
    /// <summary>
    /// PlayFab's purchase order identifier.
    /// </summary>
    public string? OrderId { get; set; }
    /// <summary>
    /// The token from provider.
    /// </summary>
    public string? ProviderToken { get; set; }
}

public class GetPhotonAuthenticationTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The Photon applicationId for the game you wish to log into.
    /// </summary>
    public required string PhotonApplicationId { get; set; }
}

public class GetPhotonAuthenticationTokenResult : PlayFabResultCommon {
    /// <summary>
    /// The Photon authentication token for this game-session.
    /// </summary>
    public string? PhotonCustomAuthenticationToken { get; set; }
}

public class GetPlayerCombinedInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public required GetPlayerCombinedInfoRequestParams InfoRequestParameters { get; set; }
    /// <summary>
    /// PlayFabId of the user whose data will be returned. If not filled included, we return the data for the calling player.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class GetPlayerCombinedInfoRequestParams {
    /// <summary>
    /// Whether to get character inventories. Defaults to false.
    /// </summary>
    public bool GetCharacterInventories { get; set; }
    /// <summary>
    /// Whether to get the list of characters. Defaults to false.
    /// </summary>
    public bool GetCharacterList { get; set; }
    /// <summary>
    /// Whether to get player profile. Defaults to false. Has no effect for a new player.
    /// </summary>
    public bool GetPlayerProfile { get; set; }
    /// <summary>
    /// Whether to get player statistics. Defaults to false.
    /// </summary>
    public bool GetPlayerStatistics { get; set; }
    /// <summary>
    /// Whether to get title data. Defaults to false.
    /// </summary>
    public bool GetTitleData { get; set; }
    /// <summary>
    /// Whether to get the player's account Info. Defaults to false
    /// </summary>
    public bool GetUserAccountInfo { get; set; }
    /// <summary>
    /// Whether to get the player's custom data. Defaults to false
    /// </summary>
    public bool GetUserData { get; set; }
    /// <summary>
    /// Whether to get the player's inventory. Defaults to false
    /// </summary>
    public bool GetUserInventory { get; set; }
    /// <summary>
    /// Whether to get the player's read only data. Defaults to false
    /// </summary>
    public bool GetUserReadOnlyData { get; set; }
    /// <summary>
    /// Whether to get the player's virtual currency balances. Defaults to false
    /// </summary>
    public bool GetUserVirtualCurrency { get; set; }
    /// <summary>
    /// Specific statistics to retrieve. Leave null to get all keys. Has no effect if GetPlayerStatistics is false
    /// </summary>
    public List<string>? PlayerStatisticNames { get; set; }
    /// <summary>
    /// Specifies the properties to return from the player profile. Defaults to returning the player's display name.
    /// </summary>
    public PlayerProfileViewConstraints? ProfileConstraints { get; set; }
    /// <summary>
    /// Specific keys to search for in the custom data. Leave null to get all keys. Has no effect if GetTitleData is false
    /// </summary>
    public List<string>? TitleDataKeys { get; set; }
    /// <summary>
    /// Specific keys to search for in the custom data. Leave null to get all keys. Has no effect if GetUserData is false
    /// </summary>
    public List<string>? UserDataKeys { get; set; }
    /// <summary>
    /// Specific keys to search for in the custom data. Leave null to get all keys. Has no effect if GetUserReadOnlyData is
    /// false
    /// </summary>
    public List<string>? UserReadOnlyDataKeys { get; set; }
}

/// <summary>
/// Returns whatever info is requested in the response for the user. If no user is explicitly requested this defaults to
/// the authenticated user. If the user is the same as the requester, PII (like email address, facebook id) is returned if
/// available. Otherwise, only public information is returned. All parameters default to false.
/// </summary>
public class GetPlayerCombinedInfoResult : PlayFabResultCommon {
    /// <summary>
    /// Results for requested info.
    /// </summary>
    public GetPlayerCombinedInfoResultPayload? InfoResultPayload { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class GetPlayerCombinedInfoResultPayload {
    /// <summary>
    /// Account information for the user. This is always retrieved.
    /// </summary>
    public UserAccountInfo? AccountInfo { get; set; }
    /// <summary>
    /// Inventories for each character for the user.
    /// </summary>
    public List<CharacterInventory>? CharacterInventories { get; set; }
    /// <summary>
    /// List of characters for the user.
    /// </summary>
    public List<CharacterResult>? CharacterList { get; set; }
    /// <summary>
    /// The profile of the players. This profile is not guaranteed to be up-to-date. For a new player, this profile will not
    /// exist.
    /// </summary>
    public PlayerProfileModel? PlayerProfile { get; set; }
    /// <summary>
    /// List of statistics for this player.
    /// </summary>
    public List<StatisticValue>? PlayerStatistics { get; set; }
    /// <summary>
    /// Title data for this title.
    /// </summary>
    public Dictionary<string, string>? TitleData { get; set; }
    /// <summary>
    /// User specific custom data.
    /// </summary>
    public Dictionary<string, UserDataRecord>? UserData { get; set; }
    /// <summary>
    /// The version of the UserData that was returned.
    /// </summary>
    public uint UserDataVersion { get; set; }
    /// <summary>
    /// Array of inventory items in the user's current inventory.
    /// </summary>
    public List<ItemInstance>? UserInventory { get; set; }
    /// <summary>
    /// User specific read-only data.
    /// </summary>
    public Dictionary<string, UserDataRecord>? UserReadOnlyData { get; set; }
    /// <summary>
    /// The version of the Read-Only UserData that was returned.
    /// </summary>
    public uint UserReadOnlyDataVersion { get; set; }
    /// <summary>
    /// Dictionary of virtual currency balance(s) belonging to the user.
    /// </summary>
    public Dictionary<string, int>? UserVirtualCurrency { get; set; }
    /// <summary>
    /// Dictionary of remaining times and timestamps for virtual currencies.
    /// </summary>
    public Dictionary<string, VirtualCurrencyRechargeTime>? UserVirtualCurrencyRechargeTimes { get; set; }
}

public class GetPlayerCustomPropertyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specific property name to search for in the player's properties.
    /// </summary>
    public required string PropertyName { get; set; }
}

public class GetPlayerCustomPropertyResult : PlayFabResultCommon {
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
    public string? PlayFabId { get; set; }
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

public class GetPlayerSegmentsRequest : PlayFabRequestCommon {
}

public class GetPlayerSegmentsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of segments the requested player currently belongs to.
    /// </summary>
    public List<GetSegmentResult>? Segments { get; set; }
}

public class GetPlayerStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// statistics to return (current version will be returned for each)
    /// </summary>
    public List<string>? StatisticNames { get; set; }
    /// <summary>
    /// statistics to return, if StatisticNames is not set (only statistics which have a version matching that provided will be
    /// returned)
    /// </summary>
    public List<StatisticNameVersion>? StatisticNameVersions { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
public class GetPlayerStatisticsResult : PlayFabResultCommon {
    /// <summary>
    /// User statistics for the requested user.
    /// </summary>
    public List<StatisticValue>? Statistics { get; set; }
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

public class GetPlayerTradesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Returns only trades with the given status. If null, returns all trades.
    /// </summary>
    public TradeStatus? StatusFilter { get; set; }
}

public class GetPlayerTradesResponse : PlayFabResultCommon {
    /// <summary>
    /// History of trades which this player has accepted.
    /// </summary>
    public List<TradeInfo>? AcceptedTrades { get; set; }
    /// <summary>
    /// The trades for this player which are currently available to be accepted.
    /// </summary>
    public List<TradeInfo>? OpenedTrades { get; set; }
}

public class GetPlayFabIDsFromBattleNetAccountIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Battle.net account identifiers for which the title needs to get PlayFab identifiers. The array cannot
    /// exceed 10 in length.
    /// </summary>
    public required List<string> BattleNetAccountIds { get; set; }
}

/// <summary>
/// For Battle.net account identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromBattleNetAccountIdsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Battle.net account identifiers to PlayFab identifiers.
    /// </summary>
    public List<BattleNetAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromFacebookIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Facebook identifiers for which the title needs to get PlayFab identifiers. The array cannot exceed 25
    /// in length.
    /// </summary>
    public required List<string> FacebookIDs { get; set; }
}

/// <summary>
/// For Facebook identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromFacebookIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Facebook identifiers to PlayFab identifiers.
    /// </summary>
    public List<FacebookPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromFacebookInstantGamesIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Facebook Instant Games identifiers for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> FacebookInstantGamesIds { get; set; }
}

/// <summary>
/// For Facebook Instant Game identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromFacebookInstantGamesIdsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Facebook Instant Games identifiers to PlayFab identifiers.
    /// </summary>
    public List<FacebookInstantGamesPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGameCenterIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Game Center identifiers (the Player Identifier) for which the title needs to get PlayFab identifiers.
    /// The array cannot exceed 25 in length.
    /// </summary>
    public required List<string> GameCenterIDs { get; set; }
}

/// <summary>
/// For Game Center identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGameCenterIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Game Center identifiers to PlayFab identifiers.
    /// </summary>
    public List<GameCenterPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGenericIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique generic service identifiers for which the title needs to get PlayFab identifiers. Currently limited to
    /// a maximum of 10 in a single request.
    /// </summary>
    public required List<GenericServiceId> GenericIDs { get; set; }
}

/// <summary>
/// For generic service identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGenericIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of generic service identifiers to PlayFab identifiers.
    /// </summary>
    public List<GenericPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGoogleIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Google identifiers (Google+ user IDs) for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> GoogleIDs { get; set; }
}

/// <summary>
/// For Google identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGoogleIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Google identifiers to PlayFab identifiers.
    /// </summary>
    public List<GooglePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Google Play Games identifiers (Google+ user IDs) for which the title needs to get PlayFab identifiers.
    /// The array cannot exceed 25 in length.
    /// </summary>
    public required List<string> GooglePlayGamesPlayerIDs { get; set; }
}

/// <summary>
/// For Google Play Games identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Google Play Games identifiers to PlayFab identifiers.
    /// </summary>
    public List<GooglePlayGamesPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromKongregateIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Kongregate identifiers (Kongregate's user_id) for which the title needs to get PlayFab identifiers. The
    /// array cannot exceed 25 in length.
    /// </summary>
    public required List<string> KongregateIDs { get; set; }
}

/// <summary>
/// For Kongregate identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromKongregateIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Kongregate identifiers to PlayFab identifiers.
    /// </summary>
    public List<KongregatePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromNintendoServiceAccountIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Nintendo Switch Account identifiers for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> NintendoAccountIds { get; set; }
}

/// <summary>
/// For Nintendo Service Account identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromNintendoServiceAccountIdsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Nintendo Switch Service Account identifiers to PlayFab identifiers.
    /// </summary>
    public List<NintendoServiceAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Nintendo Switch Device identifiers for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> NintendoSwitchDeviceIds { get; set; }
}

/// <summary>
/// For Nintendo Switch identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromNintendoSwitchDeviceIdsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Nintendo Switch Device identifiers to PlayFab identifiers.
    /// </summary>
    public List<NintendoSwitchPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromPSNAccountIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Id of the PlayStation :tm: Network issuer environment. If null, defaults to production environment.
    /// </summary>
    public int? IssuerId { get; set; }
    /// <summary>
    /// Array of unique PlayStation :tm: Network identifiers for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> PSNAccountIDs { get; set; }
}

/// <summary>
/// For PlayStation :tm: Network identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromPSNAccountIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of PlayStation :tm: Network identifiers to PlayFab identifiers.
    /// </summary>
    public List<PSNAccountPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromPSNOnlineIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Id of the PlayStation :tm: Network issuer environment. If null, defaults to production environment.
    /// </summary>
    public int? IssuerId { get; set; }
    /// <summary>
    /// Array of unique PlayStation :tm: Network identifiers for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> PSNOnlineIDs { get; set; }
}

/// <summary>
/// For PlayStation :tm: Network identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromPSNOnlineIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of PlayStation :tm: Network identifiers to PlayFab identifiers.
    /// </summary>
    public List<PSNOnlinePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromSteamIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Deprecated: Please use SteamStringIDs
    /// </summary>
    public List<ulong>? SteamIDs { get; set; }
    /// <summary>
    /// Array of unique Steam identifiers (Steam profile IDs) for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public List<string>? SteamStringIDs { get; set; }
}

/// <summary>
/// For Steam identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromSteamIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Steam identifiers to PlayFab identifiers.
    /// </summary>
    public List<SteamPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromSteamNamesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Steam identifiers for which the title needs to get PlayFab identifiers. The array cannot exceed 25 in
    /// length.
    /// </summary>
    public required List<string> SteamNames { get; set; }
}

/// <summary>
/// For Steam identifiers which have not been linked to PlayFab accounts, or if the user has not logged in recently, null
/// will be returned.
/// </summary>
public class GetPlayFabIDsFromSteamNamesResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Steam identifiers to PlayFab identifiers.
    /// </summary>
    public List<SteamNamePlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromTwitchIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Array of unique Twitch identifiers (Twitch's _id) for which the title needs to get PlayFab identifiers. The array
    /// cannot exceed 25 in length.
    /// </summary>
    public required List<string> TwitchIds { get; set; }
}

/// <summary>
/// For Twitch identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromTwitchIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Twitch identifiers to PlayFab identifiers.
    /// </summary>
    public List<TwitchPlayFabIdPair>? Data { get; set; }
}

public class GetPlayFabIDsFromXboxLiveIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The ID of Xbox Live sandbox.
    /// </summary>
    public string? Sandbox { get; set; }
    /// <summary>
    /// Array of unique Xbox Live account identifiers for which the title needs to get PlayFab identifiers. The array cannot
    /// exceed 25 in length.
    /// </summary>
    public required List<string> XboxLiveAccountIDs { get; set; }
}

/// <summary>
/// For XboxLive identifiers which have not been linked to PlayFab accounts, null will be returned.
/// </summary>
public class GetPlayFabIDsFromXboxLiveIDsResult : PlayFabResultCommon {
    /// <summary>
    /// Mapping of Xbox Live identifiers to PlayFab identifiers.
    /// </summary>
    public List<XboxLiveAccountPlayFabIdPair>? Data { get; set; }
}

/// <summary>
/// This API is designed to return publisher-specific values which can be read, but not written to, by the client. This
/// data is shared across all titles assigned to a particular publisher, and can be used for cross-game coordination. Only
/// titles assigned to a publisher can use this API. For more information email helloplayfab@microsoft.com. Note that there
/// may up to a minute delay in between updating title data and this API call returning the newest value.
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

public class GetPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// Purchase order identifier.
    /// </summary>
    public required string OrderId { get; set; }
}

public class GetPurchaseResult : PlayFabResultCommon {
    /// <summary>
    /// Array of items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
    /// <summary>
    /// Purchase order identifier.
    /// </summary>
    public string? OrderId { get; set; }
    /// <summary>
    /// Payment provider used for transaction (If not VC)
    /// </summary>
    public string? PaymentProvider { get; set; }
    /// <summary>
    /// Date and time of the purchase.
    /// </summary>
    public required DateTime PurchaseDate { get; set; }
    /// <summary>
    /// Provider transaction ID (If not VC)
    /// </summary>
    public string? TransactionId { get; set; }
    /// <summary>
    /// PlayFab transaction status
    /// </summary>
    public string? TransactionStatus { get; set; }
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

public class GetSharedGroupDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// If true, return the list of all members of the shared group.
    /// </summary>
    public bool? GetMembers { get; set; }
    /// <summary>
    /// Specific keys to retrieve from the shared group (if not specified, all keys will be returned, while an empty array
    /// indicates that no keys should be returned).
    /// </summary>
    public List<string>? Keys { get; set; }
    /// <summary>
    /// Unique identifier for the shared group.
    /// </summary>
    public required string SharedGroupId { get; set; }
}

public class GetSharedGroupDataResult : PlayFabResultCommon {
    /// <summary>
    /// Data for the requested keys.
    /// </summary>
    public Dictionary<string, SharedGroupDataRecord>? Data { get; set; }
    /// <summary>
    /// List of PlayFabId identifiers for the members of this group, if requested.
    /// </summary>
    public List<string>? Members { get; set; }
}

/// <summary>
/// A store contains an array of references to items defined in one or more catalog versions of the game, along with the
/// prices for the item, in both real world and virtual currencies. These prices act as an override to any prices defined
/// in the catalog. In this way, the base definitions of the items may be defined in the catalog, with all associated
/// properties, while the pricing can be set for each store, as needed. This allows for subsets of goods to be defined for
/// different purposes (in order to simplify showing some, but not all catalog items to users, based upon different
/// characteristics), along with unique prices. Note that all prices defined in the catalog and store definitions for the
/// item are considered valid, and that a compromised client can be made to send a request for an item based upon any of
/// these definitions. If no price is specified in the store for an item, the price set in the catalog should be displayed
/// to the user.
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
/// This query retrieves the current time from one of the servers in PlayFab. Please note that due to clock drift between
/// servers, there is a potential variance of up to 5 seconds.
/// </summary>
public class GetTimeRequest : PlayFabRequestCommon {
}

/// <summary>
/// Time is always returned as Coordinated Universal Time (UTC).
/// </summary>
public class GetTimeResult : PlayFabResultCommon {
    /// <summary>
    /// Current server time when the request was received, in UTC
    /// </summary>
    public required DateTime Time { get; set; }
}

/// <summary>
/// This API is designed to return title specific values which can be read, but not written to, by the client. For example,
/// a developer could choose to store values which modify the user experience, such as enemy spawn rates, weapon strengths,
/// movement speeds, etc. This allows a developer to update the title without the need to create, test, and ship a new
/// build. If the player belongs to an experiment variant that uses title data overrides, the overrides are applied
/// automatically and returned with the title data. Note that there may up to a minute delay in between updating title data
/// and this API call returning the newest value.
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

public class GetTitleNewsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Limits the results to the last n entries. Defaults to 10 if not set.
    /// </summary>
    public int? Count { get; set; }
}

public class GetTitleNewsResult : PlayFabResultCommon {
    /// <summary>
    /// Array of news items.
    /// </summary>
    public List<TitleNewsItem>? News { get; set; }
}

/// <summary>
/// An RSA CSP blob to be used to encrypt the payload of account creation requests when that API requires a signature
/// header. For example if Client/LoginWithCustomId requires signature headers but the player does not have an account yet
/// follow these steps: 1) Call Client/GetTitlePublicKey with one of the title's shared secrets. 2) Convert the Base64
/// encoded CSP blob to a byte array and create an RSA signing object. 3) Encrypt the UTF8 encoded JSON body of the
/// registration request and place the Base64 encoded result into the EncryptedRequest and with the TitleId field, all
/// other fields can be left empty when performing the API request. 4) Client receives authentication token as normal.
/// Future requests to LoginWithCustomId will require the X-PlayFab-Signature header.
/// </summary>
public class GetTitlePublicKeyRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
    /// <summary>
    /// The shared secret key for this title
    /// </summary>
    public required string TitleSharedSecret { get; set; }
}

public class GetTitlePublicKeyResult : PlayFabResultCommon {
    /// <summary>
    /// Base64 encoded RSA CSP byte array blob containing the title's public RSA key
    /// </summary>
    public string? RSAPublicKey { get; set; }
}

public class GetTradeStatusRequest : PlayFabRequestCommon {
    /// <summary>
    /// Player who opened trade.
    /// </summary>
    public required string OfferingPlayerId { get; set; }
    /// <summary>
    /// Trade identifier as returned by OpenTradeOffer.
    /// </summary>
    public required string TradeId { get; set; }
}

public class GetTradeStatusResponse : PlayFabResultCommon {
    /// <summary>
    /// Information about the requested trade.
    /// </summary>
    public TradeInfo? Trade { get; set; }
}

[Obsolete("Do not use")]
public class GetUserCombinedInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// User email address for the account to find (if no Username is specified).
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// If set to false, account info will not be returned. Defaults to true.
    /// </summary>
    public bool? GetAccountInfo { get; set; }
    /// <summary>
    /// If set to false, inventory will not be returned. Defaults to true. Inventory will never be returned for users other
    /// than yourself.
    /// </summary>
    public bool? GetInventory { get; set; }
    /// <summary>
    /// If set to false, read-only user data will not be returned. Defaults to true.
    /// </summary>
    public bool? GetReadOnlyData { get; set; }
    /// <summary>
    /// If set to false, custom user data will not be returned. Defaults to true.
    /// </summary>
    public bool? GetUserData { get; set; }
    /// <summary>
    /// If set to false, virtual currency balances will not be returned. Defaults to true. Currency balances will never be
    /// returned for users other than yourself.
    /// </summary>
    public bool? GetVirtualCurrency { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the user whose info is being requested. Optional, defaults to the authenticated user if no
    /// other lookup identifier set.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// User read-only custom data keys to return. If set to null, all keys will be returned. For users other than yourself,
    /// only public data will be returned.
    /// </summary>
    public List<string>? ReadOnlyDataKeys { get; set; }
    /// <summary>
    /// Title-specific username for the account to find (if no Email is set).
    /// </summary>
    public string? TitleDisplayName { get; set; }
    /// <summary>
    /// User custom data keys to return. If set to null, all keys will be returned. For users other than yourself, only public
    /// data will be returned.
    /// </summary>
    public List<string>? UserDataKeys { get; set; }
    /// <summary>
    /// PlayFab Username for the account to find (if no PlayFabId is specified).
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// This API retrieves details regarding the user in the PlayFab service. Note that data returned for the locally signed-in
/// user may contain Personally Identifying Information (PII), such as email address, and so care should be taken in how
/// this data is stored and managed. Since this call will always return the relevant information for the user, the
/// recommendation is to not store this data locally.
/// </summary>
[Obsolete("Do not use")]
public class GetUserCombinedInfoResult : PlayFabResultCommon {
    /// <summary>
    /// Account information for the user.
    /// </summary>
    public UserAccountInfo? AccountInfo { get; set; }
    /// <summary>
    /// User specific custom data.
    /// </summary>
    public Dictionary<string, UserDataRecord>? Data { get; set; }
    /// <summary>
    /// The version of the UserData that was returned.
    /// </summary>
    public uint DataVersion { get; set; }
    /// <summary>
    /// Array of inventory items in the user's current inventory.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the owner of the combined info.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// User specific read-only data.
    /// </summary>
    public Dictionary<string, UserDataRecord>? ReadOnlyData { get; set; }
    /// <summary>
    /// The version of the Read-Only UserData that was returned.
    /// </summary>
    public uint ReadOnlyDataVersion { get; set; }
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
/// Data is stored as JSON key-value pairs. Every time the data is updated via any source, the version counter is
/// incremented. If the Version parameter is provided, then this call will only return data if the current version on the
/// system is greater than the value provided. If the Keys parameter is provided, the data object returned will only
/// contain the data specific to the indicated Keys. Otherwise, the full set of custom user data will be returned.
/// </summary>
public class GetUserDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// The version that currently exists according to the caller. The call will return the data for all of the keys if the
    /// version in the system is greater than this.
    /// </summary>
    public uint? IfChangedFromDataVersion { get; set; }
    /// <summary>
    /// List of unique keys to load from.
    /// </summary>
    public List<string>? Keys { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the user to load data for. Optional, defaults to yourself if not set. When specified to a
    /// PlayFab id of another player, then this will only return public keys for that account.
    /// </summary>
    public string? PlayFabId { get; set; }
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
    public uint DataVersion { get; set; }
}

public class GetUserInventoryRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// All items currently in the user inventory will be returned, irrespective of how they were acquired (via purchasing,
/// grants, coupons, etc.). Items that are expired, fully consumed, or are no longer valid are not considered to be in the
/// user's current inventory, and so will not be not included.
/// </summary>
public class GetUserInventoryResult : PlayFabResultCommon {
    /// <summary>
    /// Array of inventory items belonging to the user.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
    /// <summary>
    /// Array of virtual currency balance(s) belonging to the user.
    /// </summary>
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    /// <summary>
    /// Array of remaining times and timestamps for virtual currencies.
    /// </summary>
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

[Obsolete("Do not use")]
public class GetUserStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class GetUserStatisticsResult : PlayFabResultCommon {
    /// <summary>
    /// User statistics for the active title.
    /// </summary>
    public Dictionary<string, int>? UserStatistics { get; set; }
}

public class GooglePlayFabIdPair {
    /// <summary>
    /// Unique Google identifier for a user.
    /// </summary>
    public string? GoogleId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Google identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class GooglePlayGamesPlayFabIdPair {
    /// <summary>
    /// Unique Google Play Games identifier for a user.
    /// </summary>
    public string? GooglePlayGamesPlayerId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Google Play Games identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

/// <summary>
/// Grants a character to the user of the type specified by the item ID. The user must already have an instance of this
/// item in their inventory in order to allow character creation. This item can come from a purchase or grant, which must
/// be done before calling to create the character.
/// </summary>
public class GrantCharacterToUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version from which items are to be granted.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Non-unique display name of the character being granted (1-40 characters in length).
    /// </summary>
    public required string CharacterName { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Catalog item identifier of the item in the user's inventory that corresponds to the character in the catalog to be
    /// created.
    /// </summary>
    public required string ItemId { get; set; }
}

public class GrantCharacterToUserResult : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier tagged to this character.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Type of character that was created.
    /// </summary>
    public string? CharacterType { get; set; }
    /// <summary>
    /// Indicates whether this character was created successfully.
    /// </summary>
    public bool Result { get; set; }
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
    public uint UnitPrice { get; set; }
    /// <summary>
    /// The number of uses that were added or removed to this item in this call.
    /// </summary>
    public int? UsesIncrementedBy { get; set; }
}

public class ItemPurchaseRequest {
    /// <summary>
    /// Title-specific text concerning this purchase.
    /// </summary>
    public string? Annotation { get; set; }
    /// <summary>
    /// Unique ItemId of the item to purchase.
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// How many of this item to purchase. Min 1, maximum 25.
    /// </summary>
    public uint Quantity { get; set; }
    /// <summary>
    /// Items to be upgraded as a result of this purchase (upgraded items are hidden, as they are "replaced" by the new items).
    /// </summary>
    public List<string>? UpgradeFromItems { get; set; }
}

public class KongregatePlayFabIdPair {
    /// <summary>
    /// Unique Kongregate identifier for a user.
    /// </summary>
    public string? KongregateId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Kongregate identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class LinkAndroidDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specific model of the user's device.
    /// </summary>
    public string? AndroidDevice { get; set; }
    /// <summary>
    /// Android device identifier for the user's device.
    /// </summary>
    public required string AndroidDeviceId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the device, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Specific Operating System version for the user's device.
    /// </summary>
    public string? OS { get; set; }
}

public class LinkAndroidDeviceIDResult : PlayFabResultCommon {
}

public class LinkAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to a specific Apple account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by Apple after login. Represented as the identityToken field in the authorization
    /// credential payload. Used to validate the request and find the user ID (Apple subject) to link with.
    /// </summary>
    public required string IdentityToken { get; set; }
}

public class LinkBattleNetAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to a specific Battle.net account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// The JSON Web Token (JWT) returned by Battle.net after login
    /// </summary>
    public required string IdentityToken { get; set; }
}

public class LinkCustomIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Custom unique identifier for the user, generated by the title.
    /// </summary>
    public required string CustomId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the custom ID, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
}

public class LinkCustomIDResult : PlayFabResultCommon {
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

/// <summary>
/// Facebook sign-in is accomplished using the Facebook User Access Token. More information on the Token can be found in
/// the Facebook developer documentation (https://developers.facebook.com/docs/facebook-login/access-tokens/). In Unity,
/// for example, the Token is available as AccessToken in the Facebook SDK ScriptableObject FB. Note that titles should
/// never re-use the same Facebook applications between PlayFab Title IDs, as Facebook provides unique user IDs per
/// application and doing so can result in issues with the Facebook ID for the user in their PlayFab account information.
/// If you must re-use an application in a new PlayFab Title ID, please be sure to first unlink all accounts from Facebook,
/// or delete all users in the first Title ID.
/// </summary>
public class LinkFacebookAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier from Facebook for the user.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// Token used for limited login authentication.
    /// </summary>
    public string? AuthenticationToken { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
}

public class LinkFacebookAccountResult : PlayFabResultCommon {
}

public class LinkFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Facebook Instant Games signature for the user.
    /// </summary>
    public required string FacebookInstantGamesSignature { get; set; }
    /// <summary>
    /// If another user is already linked to the Facebook Instant Games ID, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
}

public class LinkFacebookInstantGamesIdResult : PlayFabResultCommon {
}

public class LinkGameCenterAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link. If the current user is already
    /// linked, link both accounts
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Game Center identifier for the player account to be linked.
    /// </summary>
    public required string GameCenterId { get; set; }
    /// <summary>
    /// The URL for the public encryption key that will be used to verify the signature.
    /// </summary>
    public string? PublicKeyUrl { get; set; }
    /// <summary>
    /// A random value used to compute the hash and keep it randomized.
    /// </summary>
    public string? Salt { get; set; }
    /// <summary>
    /// The verification signature of the authentication payload.
    /// </summary>
    public string? Signature { get; set; }
    /// <summary>
    /// The integer representation of date and time that the signature was created on. PlayFab will reject authentication
    /// signatures not within 10 minutes of the server's current time.
    /// </summary>
    public string? Timestamp { get; set; }
}

public class LinkGameCenterAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Google sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google sign-in for Android APIs on
/// the device and passing it to this API.
/// </summary>
public class LinkGoogleAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// OAuth 2.0 access token obtained on the client by calling the getAccessToken() Google client API.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link. If the current user is already
    /// linked, link both accounts
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Server authentication code obtained on the client by calling getServerAuthCode()
    /// (https://developers.google.com/identity/sign-in/android/offline-access) from Google Play for the user.
    /// </summary>
    public string? ServerAuthCode { get; set; }
}

public class LinkGoogleAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Google Play Games sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google Play Games
/// sign-in for Android APIs on the device and passing it to this API.
/// </summary>
public class LinkGooglePlayGamesServicesAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link. If the current user is already
    /// linked, link both accounts
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// OAuth 2.0 server authentication code obtained on the client by calling the requestServerSideAccess()
    /// (https://developers.google.com/games/services/android/signin) Google Play Games client API.
    /// </summary>
    public required string ServerAuthCode { get; set; }
}

public class LinkGooglePlayGamesServicesAccountResult : PlayFabResultCommon {
}

public class LinkIOSDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Vendor-specific iOS identifier for the user's device.
    /// </summary>
    public required string DeviceId { get; set; }
    /// <summary>
    /// Specific model of the user's device.
    /// </summary>
    public string? DeviceModel { get; set; }
    /// <summary>
    /// If another user is already linked to the device, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Specific Operating System version for the user's device.
    /// </summary>
    public string? OS { get; set; }
}

public class LinkIOSDeviceIDResult : PlayFabResultCommon {
}

public class LinkKongregateAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Valid session auth ticket issued by Kongregate
    /// </summary>
    public required string AuthTicket { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Numeric user ID assigned by Kongregate
    /// </summary>
    public required string KongregateId { get; set; }
}

public class LinkKongregateAccountResult : PlayFabResultCommon {
}

public class LinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to a specific Nintendo Switch account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by Nintendo after login. Used to validate the request and find the user ID (Nintendo
    /// Switch subject) to link with.
    /// </summary>
    public required string IdentityToken { get; set; }
}

public class LinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the Nintendo Switch Device ID, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Nintendo Switch unique identifier for the user's device.
    /// </summary>
    public required string NintendoSwitchDeviceId { get; set; }
}

public class LinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class LinkOpenIdConnectRequest : PlayFabRequestCommon {
    /// <summary>
    /// A name that identifies which configured OpenID Connect provider relationship to use. Maximum 100 characters.
    /// </summary>
    public required string ConnectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to a specific OpenId Connect user, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by the identity provider after login. Represented as the id_token field in the
    /// identity provider's response. Used to validate the request and find the user ID (OpenID Connect subject) to link with.
    /// </summary>
    public required string IdToken { get; set; }
}

public class LinkPSNAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Authentication code provided by the PlayStation :tm: Network.
    /// </summary>
    public required string AuthCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Id of the PlayStation :tm: Network issuer environment. If null, defaults to production environment.
    /// </summary>
    public int? IssuerId { get; set; }
    /// <summary>
    /// Redirect URI supplied to PlayStation :tm: Network when requesting an auth code
    /// </summary>
    public required string RedirectUri { get; set; }
}

public class LinkPSNAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Steam authentication is accomplished with the Steam Session Ticket. More information on the Ticket can be found in the
/// Steamworks SDK, here: https://partner.steamgames.com/documentation/auth (requires sign-in). NOTE: For Steam
/// authentication to work, the title must be configured with the Steam Application ID and Publisher Key in the PlayFab
/// Game Manager (under Properties). Information on creating a Publisher Key (referred to as the Secret Key in PlayFab) for
/// your title can be found here: https://partner.steamgames.com/documentation/webapi#publisherkey.
/// </summary>
public class LinkSteamAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Authentication token for the user, returned as a byte array from Steam, and converted to a string (for example, the
    /// byte 0x08 should become "08").
    /// </summary>
    public required string SteamTicket { get; set; }
    /// <summary>
    /// True if ticket was generated using ISteamUser::GetAuthTicketForWebAPI() using "AzurePlayFab" as the identity string.
    /// False if the ticket was generated with ISteamUser::GetAuthSessionTicket().
    /// </summary>
    public bool? TicketIsServiceSpecific { get; set; }
}

public class LinkSteamAccountResult : PlayFabResultCommon {
}

public class LinkTwitchAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Valid token issued by Twitch
    /// </summary>
    public required string AccessToken { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
}

public class LinkTwitchAccountResult : PlayFabResultCommon {
}

public class LinkXboxAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// If another user is already linked to the account, unlink the other user and re-link.
    /// </summary>
    public bool? ForceLink { get; set; }
    /// <summary>
    /// Token provided by the Xbox Live SDK/XDK method GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", "").
    /// </summary>
    public required string XboxToken { get; set; }
}

public class LinkXboxAccountResult : PlayFabResultCommon {
}

public class ListPlayerCustomPropertiesRequest : PlayFabRequestCommon {
}

public class ListPlayerCustomPropertiesResult : PlayFabResultCommon {
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

/// <summary>
/// Returns a list of every character that currently belongs to a user.
/// </summary>
public class ListUsersCharactersRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class ListUsersCharactersResult : PlayFabResultCommon {
    /// <summary>
    /// The requested list of characters.
    /// </summary>
    public List<CharacterResult>? Characters { get; set; }
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

/// <summary>
/// This API is designed to track analytics events. Events logged using this API will be stored in the title's Redshift
/// database. Each unique eventName will create a distinct table within the database. Within that table, a column will be
/// created for every unique key. Using a first-person shooter as an example, the title may need to track headshots as a
/// distinct event. The sample request below demonstrates an example of this. In addition to the values sent, timestamps
/// and User IDs are automatically added as 'ts' and 'user_id' to each table. The 'Headshot' table in this example would
/// then have the schema: 'user_id'|'ts'|'victim'|'gun'|'x_coord'|'y_coord'|'z_coord'|'damage|aim_assist' and the row
/// corresponding to this event would look like: 'EF987654ABAB012'|'2014-1-1
/// 12:12:12'|'B76543AEAE65'|'big_bad_sniper'|10|20|1|1000|1.The PlayFab service automatically creates events for all login
/// and purchase operations. This API is intended for game specific events only. Please note that event logging is not
/// enabled for titles by default. If you need event logging enabled, please contact us at helloplayfab@microsoft.com for
/// more information.
/// </summary>
[Obsolete("Do not use")]
public class LogEventRequest : PlayFabRequestCommon {
    /// <summary>
    /// Contains all the data for this event. Event Values can be strings, booleans or numerics (float, double, integer, long)
    /// and must be consistent on a per-event basis (if the Value for Key 'A' in Event 'Foo' is an integer the first time it is
    /// sent, it must be an integer in all subsequent 'Foo' events). As with event names, Keys must also not use reserved words
    /// (see above). Finally, the size of the Body for an event must be less than 32KB (UTF-8 format).
    /// </summary>
    public Dictionary<string, object>? Body { get; set; }
    /// <summary>
    /// A unique event name which will be used as the table name in the Redshift database. The name will be made lower case,
    /// and cannot not contain spaces. The use of underscores is recommended, for readability. Events also cannot match
    /// reserved terms. The PlayFab reserved terms are 'log_in' and 'purchase', 'create' and 'request', while the Redshift
    /// reserved terms can be found here: http://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html.
    /// </summary>
    public string? EventName { get; set; }
    /// <summary>
    /// Flag to set event Body as profile details in the Redshift database as well as a standard event.
    /// </summary>
    public bool ProfileSetEvent { get; set; }
    /// <summary>
    /// Optional timestamp for this event. If null, the a timestamp is auto-assigned to the event on the server.
    /// </summary>
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

public class LoginResult : PlayFabLoginResultCommon {
    /// <summary>
    /// If LoginTitlePlayerAccountEntity flag is set on the login request the title_player_account will also be logged in and
    /// returned.
    /// </summary>
    public EntityTokenResponse? EntityToken { get; set; }
    /// <summary>
    /// Results for requested info.
    /// </summary>
    public GetPlayerCombinedInfoResultPayload? InfoResultPayload { get; set; }
    /// <summary>
    /// The time of this user's previous login. If there was no previous login, then it's DateTime.MinValue
    /// </summary>
    public DateTime? LastLoginTime { get; set; }
    /// <summary>
    /// True if the master_player_account was newly created on this login.
    /// </summary>
    public bool NewlyCreated { get; set; }
    /// <summary>
    /// Player's unique PlayFabId.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique token authorizing the user and game at the server level, for the current session.
    /// </summary>
    public string? SessionTicket { get; set; }
    /// <summary>
    /// Settings specific to this user.
    /// </summary>
    public UserSettings? SettingsForUser { get; set; }
    /// <summary>
    /// The experimentation treatments for this user at the time of login.
    /// </summary>
    public TreatmentAssignment? TreatmentAssignment { get; set; }
}

/// <summary>
/// On Android devices, the recommendation is to use the Settings.Secure.ANDROID_ID as the AndroidDeviceId, as described in
/// this blog post (http://android-developers.blogspot.com/2011/03/identifying-app-installations.html). More information on
/// this identifier can be found in the Android documentation
/// (http://developer.android.com/reference/android/provider/Settings.Secure.html). If this is the first time a user has
/// signed in with the Android device and CreateAccount is set to true, a new PlayFab account will be created and linked to
/// the Android device ID. In this case, no email or username will be associated with the PlayFab account. Otherwise, if no
/// PlayFab account is linked to the Android device, an error indicating this will be returned, so that the title can guide
/// the user through creation of a PlayFab account. Please note that while multiple devices of this type can be linked to a
/// single user account, only the one most recently used to login (or most recently linked) will be reflected in the user's
/// account information. We will be updating to show all linked devices in a future release.
/// </summary>
public class LoginWithAndroidDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specific model of the user's device.
    /// </summary>
    public string? AndroidDevice { get; set; }
    /// <summary>
    /// Android device identifier for the user's device.
    /// </summary>
    public string? AndroidDeviceId { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Specific Operating System version for the user's device.
    /// </summary>
    public string? OS { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by Apple after login. Represented as the identityToken field in the authorization
    /// credential payload. If you choose to ignore the expiration date for identity tokens, you will receive an NotAuthorized
    /// error if Apple rotates the signing key. In this case, users have to login to provide a fresh identity token.
    /// </summary>
    public required string IdentityToken { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithBattleNetRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// The JSON Web Token (JWT) returned by Battle.net after login
    /// </summary>
    public required string IdentityToken { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// It is highly recommended that developers ensure that it is extremely unlikely that a customer could generate an ID
/// which is already in use by another customer. If this is the first time a user has signed in with the Custom ID and
/// CreateAccount is set to true, a new PlayFab account will be created and linked to the Custom ID. In this case, no email
/// or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Custom ID,
/// an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithCustomIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// Custom unique identifier for the user, generated by the title.
    /// </summary>
    public string? CustomId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Email address and password lengths are provided for information purposes. The server will validate that data passed in
/// conforms to the field definition and report errors appropriately. It is recommended that developers not perform this
/// validation locally, so that future updates do not require client updates.
/// </summary>
public class LoginWithEmailAddressRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Email address for the account.
    /// </summary>
    public required string Email { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Password for the PlayFab account (6-100 characters)
    /// </summary>
    public required string Password { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Facebook Instant Games signature for the user.
    /// </summary>
    public required string FacebookInstantGamesSignature { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Facebook sign-in is accomplished using the Facebook User Access Token. More information on the Token can be found in
/// the Facebook developer documentation (https://developers.facebook.com/docs/facebook-login/access-tokens/). In Unity,
/// for example, the Token is available as AccessToken in the Facebook SDK ScriptableObject FB. If this is the first time a
/// user has signed in with the Facebook account and CreateAccount is set to true, a new PlayFab account will be created
/// and linked to the provided account's Facebook ID. In this case, no email or username will be associated with the
/// PlayFab account. Otherwise, if no PlayFab account is linked to the Facebook account, an error indicating this will be
/// returned, so that the title can guide the user through creation of a PlayFab account. Note that titles should never
/// re-use the same Facebook applications between PlayFab Title IDs, as Facebook provides unique user IDs per application
/// and doing so can result in issues with the Facebook ID for the user in their PlayFab account information. If you must
/// re-use an application in a new PlayFab Title ID, please be sure to first unlink all accounts from Facebook, or delete
/// all users in the first Title ID. Note: If the user is authenticated with AuthenticationToken, instead of AccessToken,
/// the GetFriendsList API will return an empty list.
/// </summary>
public class LoginWithFacebookRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier from Facebook for the user.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// Token used for limited login authentication.
    /// </summary>
    public string? AuthenticationToken { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// The Game Center player identifier
/// (https://developer.apple.com/library/ios/documentation/Accounts/Reference/ACAccountClassRef/index.html#//apple_ref/occ/i
/// nstp/ACAccount/identifier) is a generated string which is stored on the local device. As with device identifiers, care
/// must be taken to never expose a player's Game Center identifier to end users, as that could result in a user's account
/// being compromised. If this is the first time a user has signed in with Game Center and CreateAccount is set to true, a
/// new PlayFab account will be created and linked to the Game Center identifier. In this case, no email or username will
/// be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Game Center account, an error
/// indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. If an
/// invalid iOS Game Center player identifier is used, an error indicating this will be returned.
/// </summary>
public class LoginWithGameCenterRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Unique Game Center player id.
    /// </summary>
    public string? PlayerId { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// The URL for the public encryption key that will be used to verify the signature.
    /// </summary>
    public string? PublicKeyUrl { get; set; }
    /// <summary>
    /// A random value used to compute the hash and keep it randomized.
    /// </summary>
    public string? Salt { get; set; }
    /// <summary>
    /// The verification signature of the authentication payload.
    /// </summary>
    public string? Signature { get; set; }
    /// <summary>
    /// The integer representation of date and time that the signature was created on. PlayFab will reject authentication
    /// signatures not within 10 minutes of the server's current time.
    /// </summary>
    public string? Timestamp { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Google sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google sign-in for Android APIs on
/// the device and passing it to this API. If this is the first time a user has signed in with the Google account and
/// CreateAccount is set to true, a new PlayFab account will be created and linked to the Google account. Otherwise, if no
/// PlayFab account is linked to the Google account, an error indicating this will be returned, so that the title can guide
/// the user through creation of a PlayFab account. The current (recommended) method for obtaining a Google account
/// credential in an Android application is to call GoogleSignInAccount.getServerAuthCode() and send the auth code as the
/// ServerAuthCode parameter of this API. Before doing this, you must create an OAuth 2.0 web application client ID in the
/// Google API Console and configure its client ID and secret in the PlayFab Game Manager Google Add-on for your title.
/// This method does not require prompting of the user for additional Google account permissions, resulting in a user
/// experience with the least possible friction. For more information about obtaining the server auth code, see
/// https://developers.google.com/identity/sign-in/android/offline-access. The previous (deprecated) method was to obtain
/// an OAuth access token by calling GetAccessToken() on the client and passing it as the AccessToken parameter to this
/// API. for the with the Google OAuth 2.0 Access Token. More information on this change can be found in the Google
/// developer documentation (https://android-developers.googleblog.com/2016/01/play-games-permissions-are-changing-in.html).
/// </summary>
public class LoginWithGoogleAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// OAuth 2.0 access token obtained on the client by calling the getAccessToken() Google client API.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public string? PublisherId { get; set; }
    /// <summary>
    /// OAuth 2.0 server authentication code obtained on the client by calling the getServerAuthCode()
    /// (https://developers.google.com/identity/sign-in/android/offline-access) Google client API.
    /// </summary>
    public string? ServerAuthCode { get; set; }
    /// <summary>
    /// Optional boolean to opt out of setting the MPA email when creating a Google account, defaults to true.
    /// </summary>
    public bool? SetEmail { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Google Play Games sign-in is accomplished by obtaining a Google OAuth 2.0 credential using the Google Play Games
/// sign-in for Android APIs on the device and passing it to this API. If this is the first time a user has signed in with
/// the Google Play Games account and CreateAccount is set to true, a new PlayFab account will be created and linked to the
/// Google Play Games account. Otherwise, if no PlayFab account is linked to the Google Play Games account, an error
/// indicating this will be returned, so that the title can guide the user through creation of a PlayFab account. The
/// current (recommended) method for obtaining a Google Play Games account credential in an Android application is to call
/// GamesSignInClient.requestServerSideAccess() and send the auth code as the ServerAuthCode parameter of this API. Before
/// doing this, you must create an OAuth 2.0 web application client ID in the Google API Console and configure its client
/// ID and secret in the PlayFab Game Manager Google Add-on for your title. This method does not require prompting of the
/// user for additional Google account permissions, resulting in a user experience with the least possible friction. For
/// more information about obtaining the server auth code, see https://developers.google.com/games/services/android/signin.
/// </summary>
public class LoginWithGooglePlayGamesServicesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// OAuth 2.0 server authentication code obtained on the client by calling the requestServerSideAccess()
    /// (https://developers.google.com/games/services/android/signin) Google Play Games client API.
    /// </summary>
    public string? ServerAuthCode { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// On iOS devices, the identifierForVendor
/// (https://developer.apple.com/library/ios/documentation/UIKit/Reference/UIDevice_Class/index.html#//apple_ref/occ/instp/U
/// IDevice/identifierForVendor) must be used as the DeviceId, as the UIDevice uniqueIdentifier has been deprecated as of
/// iOS 5, and use of the advertisingIdentifier for this purpose will result in failure of Apple's certification process.
/// If this is the first time a user has signed in with the iOS device and CreateAccount is set to true, a new PlayFab
/// account will be created and linked to the vendor-specific iOS device ID. In this case, no email or username will be
/// associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the iOS device, an error indicating
/// this will be returned, so that the title can guide the user through creation of a PlayFab account. Please note that
/// while multiple devices of this type can be linked to a single user account, only the one most recently used to login
/// (or most recently linked) will be reflected in the user's account information. We will be updating to show all linked
/// devices in a future release.
/// </summary>
public class LoginWithIOSDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Vendor-specific iOS identifier for the user's device.
    /// </summary>
    public string? DeviceId { get; set; }
    /// <summary>
    /// Specific model of the user's device.
    /// </summary>
    public string? DeviceModel { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Specific Operating System version for the user's device.
    /// </summary>
    public string? OS { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// More details regarding Kongregate and their game authentication system can be found at
/// http://developers.kongregate.com/docs/virtual-goods/authentication. Developers must provide the Kongregate user ID and
/// auth token that are generated using the Kongregate client library. PlayFab will combine these identifiers with the
/// title's unique Kongregate app ID to log the player into the Kongregate system. If CreateAccount is set to true and
/// there is not already a user matched to this Kongregate ID, then PlayFab will create a new account for this user and
/// link the ID. In this case, no email or username will be associated with the PlayFab account. If there is already a
/// different PlayFab user linked with this account, then an error will be returned.
/// </summary>
public class LoginWithKongregateRequest : PlayFabRequestCommon {
    /// <summary>
    /// Token issued by Kongregate's client API for the user.
    /// </summary>
    public string? AuthTicket { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Numeric user ID assigned by Kongregate
    /// </summary>
    public string? KongregateId { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithNintendoServiceAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by Nintendo after login.
    /// </summary>
    public required string IdentityToken { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Nintendo Switch unique identifier for the user's device.
    /// </summary>
    public string? NintendoSwitchDeviceId { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class LoginWithOpenIdConnectRequest : PlayFabRequestCommon {
    /// <summary>
    /// A name that identifies which configured OpenID Connect provider relationship to use. Maximum 100 characters.
    /// </summary>
    public required string ConnectionId { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// The JSON Web token (JWT) returned by the identity provider after login. Represented as the id_token field in the
    /// identity provider's response.
    /// </summary>
    public required string IdToken { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Username and password lengths are provided for information purposes. The server will validate that data passed in
/// conforms to the field definition and report errors appropriately. It is recommended that developers not perform this
/// validation locally, so that future updates to the username or password do not require client updates.
/// </summary>
public class LoginWithPlayFabRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Password for the PlayFab account (6-100 characters)
    /// </summary>
    public required string Password { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
    /// <summary>
    /// PlayFab username for the account.
    /// </summary>
    public required string Username { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the PlayStation :tm: Network account and CreateAccount is set to
/// true, a new PlayFab account will be created and linked to the PlayStation :tm: Network account. In this case, no email
/// or username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the PlayStation
/// :tm: Network account, an error indicating this will be returned, so that the title can guide the user through creation
/// of a PlayFab account.
/// </summary>
public class LoginWithPSNRequest : PlayFabRequestCommon {
    /// <summary>
    /// Auth code provided by the PlayStation :tm: Network OAuth provider.
    /// </summary>
    public string? AuthCode { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Id of the PlayStation :tm: Network issuer environment. If null, defaults to production environment.
    /// </summary>
    public int? IssuerId { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Redirect URI supplied to PlayStation :tm: Network when requesting an auth code
    /// </summary>
    public string? RedirectUri { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// Steam sign-in is accomplished with the Steam Session Ticket. More information on the Ticket can be found in the
/// Steamworks SDK, here: https://partner.steamgames.com/documentation/auth. NOTE: For Steam authentication to work, the
/// title must be configured with the Steam Application ID and Web API Key in the PlayFab Game Manager (under Steam in the
/// Add-ons Marketplace). You can obtain a Web API Key from the Permissions page of any Group associated with your App ID
/// in the Steamworks site. If this is the first time a user has signed in with the Steam account and CreateAccount is set
/// to true, a new PlayFab account will be created and linked to the provided account's Steam ID. In this case, no email or
/// username will be associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Steam account,
/// an error indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithSteamRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Authentication token for the user, returned as a byte array from Steam, and converted to a string (for example, the
    /// byte 0x08 should become "08").
    /// </summary>
    public string? SteamTicket { get; set; }
    /// <summary>
    /// True if ticket was generated using ISteamUser::GetAuthTicketForWebAPI() using "AzurePlayFab" as the identity string.
    /// False if the ticket was generated with ISteamUser::GetAuthSessionTicket().
    /// </summary>
    public bool? TicketIsServiceSpecific { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// More details regarding Twitch and their authentication system can be found at
/// https://github.com/justintv/Twitch-API/blob/master/authentication.md. Developers must provide the Twitch access token
/// that is generated using one of the Twitch authentication flows. PlayFab will use the title's unique Twitch Client ID to
/// authenticate the token and log in to the PlayFab system. If CreateAccount is set to true and there is not already a
/// user matched to the Twitch username that generated the token, then PlayFab will create a new account for this user and
/// link the ID. In this case, no email or username will be associated with the PlayFab account. If there is already a
/// different PlayFab user linked with this account, then an error will be returned.
/// </summary>
public class LoginWithTwitchRequest : PlayFabRequestCommon {
    /// <summary>
    /// Token issued by Twitch's API for the user.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

/// <summary>
/// If this is the first time a user has signed in with the Xbox Live account and CreateAccount is set to true, a new
/// PlayFab account will be created and linked to the Xbox Live account. In this case, no email or username will be
/// associated with the PlayFab account. Otherwise, if no PlayFab account is linked to the Xbox Live account, an error
/// indicating this will be returned, so that the title can guide the user through creation of a PlayFab account.
/// </summary>
public class LoginWithXboxRequest : PlayFabRequestCommon {
    /// <summary>
    /// Automatically create a PlayFab account if one is not currently linked to this ID.
    /// </summary>
    public bool? CreateAccount { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
    /// <summary>
    /// Token provided by the Xbox Live SDK/XDK method GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", "").
    /// </summary>
    public string? XboxToken { get; set; }
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

[Obsolete("Do not use")]
public class MatchmakeRequest : PlayFabRequestCommon {
    /// <summary>
    /// Build version to match against. [Note: Required if LobbyId is not specified]
    /// </summary>
    public string? BuildVersion { get; set; }
    /// <summary>
    /// Character to use for stats based matching. Leave null to use account stats.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public bool? EnableQueue { get; set; }
    /// <summary>
    /// Game mode to match make against. [Note: Required if LobbyId is not specified]
    /// </summary>
    public string? GameMode { get; set; }
    /// <summary>
    /// Lobby identifier to match make against. This is used to select a specific Game Server Instance.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// Region to match make against. [Note: Required if LobbyId is not specified]
    /// </summary>
    public Region? Region { get; set; }
    /// <summary>
    /// Start a game session if one with an open slot is not found. Defaults to true.
    /// </summary>
    public bool? StartNewIfNoneFound { get; set; }
    /// <summary>
    /// Player statistic to use in finding a match. May be null for no stat-based matching.
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// Filter to include and/or exclude Game Server Instances associated with certain Tags
    /// </summary>
    public CollectionFilter? TagFilter { get; set; }
}

[Obsolete("Do not use")]
public class MatchmakeResult : PlayFabResultCommon {
    /// <summary>
    /// timestamp for when the server will expire, if applicable
    /// </summary>
    public string? Expires { get; set; }
    /// <summary>
    /// unique lobby identifier of the server matched
    /// </summary>
    public string? LobbyID { get; set; }
    /// <summary>
    /// time in milliseconds the application is configured to wait on matchmaking results
    /// </summary>
    public int? PollWaitTimeMS { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerHostname { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// IPV6 address of the server
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// port number to use for non-http communications with the server
    /// </summary>
    public int? ServerPort { get; set; }
    /// <summary>
    /// Public DNS name (if any) of the server
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
    /// <summary>
    /// result of match making process
    /// </summary>
    public MatchmakeStatus? Status { get; set; }
    /// <summary>
    /// server authorization ticket (used by RedeemMatchmakerTicket to validate user insertion into the game)
    /// </summary>
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

public class MicrosoftStorePayload {
    /// <summary>
    /// Microsoft store ID key. This is optional. Alternatively you can use XboxToken
    /// </summary>
    public string? CollectionsMsIdKey { get; set; }
    /// <summary>
    /// If collectionsMsIdKey is provided, this will verify the user id in the collectionsMsIdKey is the same.
    /// </summary>
    public string? UserId { get; set; }
    /// <summary>
    /// Token provided by the Xbox Live SDK/XDK method GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", ""). This
    /// is optional. Alternatively can use CollectionsMsIdKey
    /// </summary>
    public string? XboxToken { get; set; }
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

public class NintendoServiceAccountPlayFabIdPair {
    /// <summary>
    /// Unique Nintendo Switch Service Account identifier for a user.
    /// </summary>
    public string? NintendoServiceAccountId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Nintendo Switch Service Account
    /// identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class NintendoSwitchPlayFabIdPair {
    /// <summary>
    /// Unique Nintendo Switch Device identifier for a user.
    /// </summary>
    public string? NintendoSwitchDeviceId { get; set; }
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Nintendo Switch Device identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
}

public class OpenTradeRequest : PlayFabRequestCommon {
    /// <summary>
    /// Players who are allowed to accept the trade. If null, the trade may be accepted by any player. If empty, the trade may
    /// not be accepted by any player.
    /// </summary>
    public List<string>? AllowedPlayerIds { get; set; }
    /// <summary>
    /// Player inventory items offered for trade. If not set, the trade is effectively a gift request
    /// </summary>
    public List<string>? OfferedInventoryInstanceIds { get; set; }
    /// <summary>
    /// Catalog items accepted for the trade. If not set, the trade is effectively a gift.
    /// </summary>
    public List<string>? RequestedCatalogItemIds { get; set; }
}

public class OpenTradeResponse : PlayFabResultCommon {
    /// <summary>
    /// The information about the trade that was just opened.
    /// </summary>
    public TradeInfo? Trade { get; set; }
}

/// <summary>
/// This is the second step in the purchasing process, initiating the purchase transaction with the payment provider (if
/// applicable). For payment provider scenarios, the title should next present the user with the payment
/// provider'sinterface for payment. Once the player has completed the payment with the provider, the title should call
/// ConfirmPurchase tofinalize the process and add the appropriate items to the player inventory.
/// </summary>
public class PayForPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// Currency to use to fund the purchase.
    /// </summary>
    public required string Currency { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Purchase order identifier returned from StartPurchase.
    /// </summary>
    public required string OrderId { get; set; }
    /// <summary>
    /// Payment provider to use to fund the purchase.
    /// </summary>
    public required string ProviderName { get; set; }
    /// <summary>
    /// Payment provider transaction identifier. Required for Facebook Payments.
    /// </summary>
    public string? ProviderTransactionId { get; set; }
}

/// <summary>
/// For web-based payment providers, this operation returns the URL to which the user should be directed inorder to approve
/// the purchase. Items added to the user inventory as a result of this operation will be marked as unconfirmed.
/// </summary>
public class PayForPurchaseResult : PlayFabResultCommon {
    /// <summary>
    /// Local credit applied to the transaction (provider specific).
    /// </summary>
    public uint CreditApplied { get; set; }
    /// <summary>
    /// Purchase order identifier.
    /// </summary>
    public string? OrderId { get; set; }
    /// <summary>
    /// Provider used for the transaction.
    /// </summary>
    public string? ProviderData { get; set; }
    /// <summary>
    /// A token generated by the provider to authenticate the request (provider-specific).
    /// </summary>
    public string? ProviderToken { get; set; }
    /// <summary>
    /// URL to the purchase provider page that details the purchase.
    /// </summary>
    public string? PurchaseConfirmationPageURL { get; set; }
    /// <summary>
    /// Currency for the transaction, may be a virtual currency or real money.
    /// </summary>
    public string? PurchaseCurrency { get; set; }
    /// <summary>
    /// Cost of the transaction.
    /// </summary>
    public uint PurchasePrice { get; set; }
    /// <summary>
    /// Status of the transaction.
    /// </summary>
    public TransactionStatus? Status { get; set; }
    /// <summary>
    /// Virtual currencies granted by the transaction, if any.
    /// </summary>
    public Dictionary<string, int>? VCAmount { get; set; }
    /// <summary>
    /// Current virtual currency balances for the user.
    /// </summary>
    public Dictionary<string, int>? VirtualCurrency { get; set; }
}

public class PaymentOption {
    /// <summary>
    /// Specific currency to use to fund the purchase.
    /// </summary>
    public string? Currency { get; set; }
    /// <summary>
    /// Amount of the specified currency needed for the purchase.
    /// </summary>
    public uint Price { get; set; }
    /// <summary>
    /// Name of the purchase provider for this option.
    /// </summary>
    public string? ProviderName { get; set; }
    /// <summary>
    /// Amount of existing credit the user has with the provider.
    /// </summary>
    public uint StoreCredit { get; set; }
}

public class PlayerLeaderboardEntry {
    /// <summary>
    /// Title-specific display name of the user for this leaderboard entry.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user for this leaderboard entry.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// User's overall position in the leaderboard.
    /// </summary>
    public int Position { get; set; }
    /// <summary>
    /// The profile of the user, if requested.
    /// </summary>
    public PlayerProfileModel? Profile { get; set; }
    /// <summary>
    /// Specific value of the user's statistic.
    /// </summary>
    public int StatValue { get; set; }
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

public class PlayerStatisticVersion {
    /// <summary>
    /// time when the statistic version became active
    /// </summary>
    public required DateTime ActivationTime { get; set; }
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
    /// version of the statistic
    /// </summary>
    public uint Version { get; set; }
}

public class PlayStation5Payload {
    /// <summary>
    /// An optional list of entitlement ids to query against PlayStation :tm: Network
    /// </summary>
    public List<string>? Ids { get; set; }
    /// <summary>
    /// Id of the PlayStation :tm: Network service label to consume entitlements from
    /// </summary>
    public string? ServiceLabel { get; set; }
}

public class PSNAccountPlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the PlayStation :tm: Network
    /// identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique PlayStation :tm: Network identifier for a user.
    /// </summary>
    public string? PSNAccountId { get; set; }
}

public class PSNOnlinePlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the PlayStation :tm: Network
    /// identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique PlayStation :tm: Network identifier for a user.
    /// </summary>
    public string? PSNOnlineId { get; set; }
}

/// <summary>
/// Please note that the processing time for inventory grants and purchases increases fractionally the more items are in
/// the inventory, and the more items are in the grant/purchase operation (with each item in a bundle being a distinct add).
/// </summary>
public class PurchaseItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version for the items to be purchased (defaults to most recent version.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique identifier of the item to purchase.
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// Price the client expects to pay for the item (in case a new catalog or store was uploaded, with new prices).
    /// </summary>
    public int Price { get; set; }
    /// <summary>
    /// Store to buy this item through. If not set, prices default to those in the catalog.
    /// </summary>
    public string? StoreId { get; set; }
    /// <summary>
    /// Virtual currency to use to purchase the item.
    /// </summary>
    public required string VirtualCurrency { get; set; }
}

public class PurchaseItemResult : PlayFabResultCommon {
    /// <summary>
    /// Details for the items purchased.
    /// </summary>
    public List<ItemInstance>? Items { get; set; }
}

public class PurchaseReceiptFulfillment {
    /// <summary>
    /// Items granted to the player in fulfillment of the validated receipt.
    /// </summary>
    public List<ItemInstance>? FulfilledItems { get; set; }
    /// <summary>
    /// Source of the payment price information for the recorded purchase transaction. A value of 'Request' indicates that the
    /// price specified in the request was used, whereas a value of 'Catalog' indicates that the real-money price of the
    /// catalog item matching the product ID in the validated receipt transaction and the currency specified in the request
    /// (defaulting to USD) was used.
    /// </summary>
    public string? RecordedPriceSource { get; set; }
    /// <summary>
    /// Currency used to purchase the items (ISO 4217 currency code).
    /// </summary>
    public string? RecordedTransactionCurrency { get; set; }
    /// <summary>
    /// Amount of the stated currency paid for the items, in centesimal units
    /// </summary>
    public uint? RecordedTransactionTotal { get; set; }
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

/// <summary>
/// Coupon codes can be created for any item, or set of items, in the catalog for the title. This operation causes the
/// coupon to be consumed, and the specific items to be awarded to the user. Attempting to re-use an already consumed code,
/// or a code which has not yet been created in the service, will result in an error.
/// </summary>
public class RedeemCouponRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the coupon. If null, uses the default catalog
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Optional identifier for the Character that should receive the item. If null, item is added to the player
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Generated coupon code to redeem.
    /// </summary>
    public required string CouponCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RedeemCouponResult : PlayFabResultCommon {
    /// <summary>
    /// Items granted to the player as a result of redeeming the coupon.
    /// </summary>
    public List<ItemInstance>? GrantedItems { get; set; }
}

public class RefreshPSNAuthTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// Auth code returned by PlayStation :tm: Network OAuth system.
    /// </summary>
    public required string AuthCode { get; set; }
    /// <summary>
    /// Id of the PlayStation :tm: Network issuer environment. If null, defaults to production environment.
    /// </summary>
    public int? IssuerId { get; set; }
    /// <summary>
    /// Redirect URI supplied to PlayStation :tm: Network when requesting an auth code
    /// </summary>
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
    /// <summary>
    /// indicates whether the server specified is available in this region
    /// </summary>
    public bool Available { get; set; }
    /// <summary>
    /// name of the region
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// url to ping to get roundtrip time
    /// </summary>
    public string? PingUrl { get; set; }
    /// <summary>
    /// unique identifier for the region
    /// </summary>
    public Region? Region { get; set; }
}

/// <summary>
/// The steps to configure and send Push Notifications is described in the PlayFab tutorials, here:
/// https://docs.microsoft.com/gaming/playfab/features/engagement/push-notifications/quickstart
/// </summary>
public class RegisterForIOSPushNotificationRequest : PlayFabRequestCommon {
    /// <summary>
    /// Message to display when confirming push notification.
    /// </summary>
    public string? ConfirmationMessage { get; set; }
    /// <summary>
    /// Unique token generated by the Apple Push Notification service when the title registered to receive push notifications.
    /// </summary>
    public required string DeviceToken { get; set; }
    /// <summary>
    /// If true, send a test push message immediately after sucessful registration. Defaults to false.
    /// </summary>
    public bool? SendPushNotificationConfirmation { get; set; }
}

public class RegisterForIOSPushNotificationResult : PlayFabResultCommon {
}

public class RegisterPlayFabUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// An optional parameter for setting the display name for this title (3-25 characters).
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// User email address attached to their account
    /// </summary>
    public string? Email { get; set; }
    /// <summary>
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Flags for which pieces of info to return for the user.
    /// </summary>
    public GetPlayerCombinedInfoRequestParams? InfoRequestParameters { get; set; }
    /// <summary>
    /// Formerly triggered an Entity login with a normal client login. This is now automatic, and always-on.
    /// </summary>
    public bool? LoginTitlePlayerAccountEntity { get; set; }
    /// <summary>
    /// The Origination of a user is determined by the API call used to create the account. In the case of RegisterPlayFabUser,
    /// it will be Organic.
    /// </summary>
    public string? Origination { get; set; }
    /// <summary>
    /// Password for the PlayFab account (6-100 characters)
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
    /// <summary>
    /// An optional parameter that specifies whether both the username and email parameters are required. If true, both
    /// parameters are required; if false, the user must supply either the username or email parameter. The default value is
    /// true.
    /// </summary>
    public bool? RequireBothUsernameAndEmail { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
    /// <summary>
    /// PlayFab username for the account (3-20 characters)
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// Each account must have a unique email address in the PlayFab service. Once created, the account may be associated with
/// additional accounts (Steam, Facebook, Game Center, etc.), allowing for added social network lists and achievements
/// systems.
/// </summary>
public class RegisterPlayFabUserResult : PlayFabLoginResultCommon {
    /// <summary>
    /// If LoginTitlePlayerAccountEntity flag is set on the login request the title_player_account will also be logged in and
    /// returned.
    /// </summary>
    public EntityTokenResponse? EntityToken { get; set; }
    /// <summary>
    /// PlayFab unique identifier for this newly created account.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique token identifying the user and game at the server level, for the current session.
    /// </summary>
    public string? SessionTicket { get; set; }
    /// <summary>
    /// Settings specific to this user.
    /// </summary>
    public UserSettings? SettingsForUser { get; set; }
    /// <summary>
    /// PlayFab unique user name.
    /// </summary>
    public string? Username { get; set; }
}

/// <summary>
/// This API removes an existing contact email from the player's profile.
/// </summary>
public class RemoveContactEmailRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class RemoveContactEmailResult : PlayFabResultCommon {
}

public class RemoveFriendRequest : PlayFabRequestCommon {
    /// <summary>
    /// PlayFab identifier of the friend account which is to be removed.
    /// </summary>
    public required string FriendPlayFabId { get; set; }
}

public class RemoveFriendResult : PlayFabResultCommon {
}

public class RemoveGenericIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Generic service identifier to be removed from the player.
    /// </summary>
    public required GenericServiceId GenericId { get; set; }
}

public class RemoveGenericIDResult : PlayFabResultCommon {
}

public class RemoveSharedGroupMembersRequest : PlayFabRequestCommon {
    /// <summary>
    /// An array of unique PlayFab assigned ID of the user on whom the operation will be performed.
    /// </summary>
    public required List<string> PlayFabIds { get; set; }
    /// <summary>
    /// Unique identifier for the shared group.
    /// </summary>
    public required string SharedGroupId { get; set; }
}

public class RemoveSharedGroupMembersResult : PlayFabResultCommon {
}

/// <summary>
/// Report ad activity
/// </summary>
public class ReportAdActivityRequest : PlayFabRequestCommon {
    /// <summary>
    /// Type of activity, may be Opened, Closed, Start or End
    /// </summary>
    public AdActivity Activity { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique ID of the placement to report for
    /// </summary>
    public required string PlacementId { get; set; }
    /// <summary>
    /// Unique ID of the reward the player was offered
    /// </summary>
    public required string RewardId { get; set; }
}

/// <summary>
/// Report ad activity response has no body
/// </summary>
public class ReportAdActivityResult : PlayFabResultCommon {
}

public class ReportPlayerClientRequest : PlayFabRequestCommon {
    /// <summary>
    /// Optional additional comment by reporting player.
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the reported player.
    /// </summary>
    public required string ReporteeId { get; set; }
}

/// <summary>
/// Players are currently limited to five reports per day. Attempts by a single user account to submit reports beyond five
/// will result in Updated being returned as false.
/// </summary>
public class ReportPlayerClientResult : PlayFabResultCommon {
    /// <summary>
    /// The number of remaining reports which may be filed today.
    /// </summary>
    public int SubmissionsRemaining { get; set; }
    /// <summary>
    /// Deprecated: Always true
    /// </summary>
    public bool? Updated { get; set; }
}

/// <summary>
/// The title should obtain a refresh receipt via restoreCompletedTransactions in the SKPaymentQueue of the Apple StoreKit
/// and pass that in to this call. The resultant receipt contains new receipt instances for all non-consumable goods
/// previously purchased by the user. This API call iterates through every purchase in the receipt and restores the items
/// if they still exist in the catalog and can be validated.
/// </summary>
public class RestoreIOSPurchasesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the restored items. If null, defaults to primary catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Base64 encoded receipt data, passed back by the App Store as a result of a successful purchase.
    /// </summary>
    public required string ReceiptData { get; set; }
}

/// <summary>
/// Once verified, the valid items will be restored into the user's inventory. This result should be used for immediate
/// updates to the local client game state as opposed to the GetUserInventory API which can have an up to half second delay.
/// </summary>
public class RestoreIOSPurchasesResult : PlayFabResultCommon {
    /// <summary>
    /// Fulfilled inventory items and recorded purchases in fulfillment of the validated receipt transactions.
    /// </summary>
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// Details on which placement and reward to perform a grant on
/// </summary>
public class RewardAdActivityRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Placement unique ID
    /// </summary>
    public required string PlacementId { get; set; }
    /// <summary>
    /// Reward unique ID
    /// </summary>
    public required string RewardId { get; set; }
}

/// <summary>
/// Result for rewarding an ad activity
/// </summary>
public class RewardAdActivityResult : PlayFabResultCommon {
    /// <summary>
    /// PlayStream Event ID that was generated by this reward (all subsequent events are associated with this event identifier)
    /// </summary>
    public string? AdActivityEventId { get; set; }
    /// <summary>
    /// Debug results from the grants
    /// </summary>
    public List<string>? DebugResults { get; set; }
    /// <summary>
    /// Id of the placement the reward was for
    /// </summary>
    public string? PlacementId { get; set; }
    /// <summary>
    /// Name of the placement the reward was for
    /// </summary>
    public string? PlacementName { get; set; }
    /// <summary>
    /// If placement has viewing limits indicates how many views are left
    /// </summary>
    public int? PlacementViewsRemaining { get; set; }
    /// <summary>
    /// If placement has viewing limits indicates when they will next reset
    /// </summary>
    public double? PlacementViewsResetMinutes { get; set; }
    /// <summary>
    /// Reward results
    /// </summary>
    public AdRewardResults? RewardResults { get; set; }
}

/// <summary>
/// Inputs to the Cloud Script may be specified either using Params, which is an object containing one or more parameters,
/// or ParamsEncoded, which is a string containing the parameters encoded into JSON. Titles should only specify the
/// parameters in one of these inputs - if both are specified, the ParamsEncoded will be used.
/// </summary>
[Obsolete("Do not use")]
public class RunCloudScriptRequest : PlayFabRequestCommon {
    /// <summary>
    /// server action to trigger
    /// </summary>
    public required string ActionId { get; set; }
    /// <summary>
    /// parameters to pass into the action (If you use this, don't use ParamsEncoded)
    /// </summary>
    public object? Params { get; set; }
    /// <summary>
    /// json-encoded parameters to pass into the action (If you use this, don't use Params)
    /// </summary>
    public string? ParamsEncoded { get; set; }
}

/// <summary>
/// As part of the returned values, both Results and ResultsEncoded will be provided. As with Params and ParamsEncoded,
/// these are respectively an object containing the returned values, and a string containing the returned values encoded
/// into JSON. In addition, the Cloud Script may additionally generate a log, using log.info(), in order to provide
/// additional debugging information.
/// </summary>
[Obsolete("Do not use")]
public class RunCloudScriptResult : PlayFabResultCommon {
    /// <summary>
    /// id of Cloud Script run
    /// </summary>
    public string? ActionId { get; set; }
    /// <summary>
    /// any log statements generated during the run of this action
    /// </summary>
    public string? ActionLog { get; set; }
    /// <summary>
    /// time this script took to run, in seconds
    /// </summary>
    public required double ExecutionTime { get; set; }
    /// <summary>
    /// return values from the server action as a dynamic object
    /// </summary>
    public object? Results { get; set; }
    /// <summary>
    /// return values from the server action as a JSON encoded string
    /// </summary>
    public string? ResultsEncoded { get; set; }
    /// <summary>
    /// revision of Cloud Script run
    /// </summary>
    public int Revision { get; set; }
    /// <summary>
    /// version of Cloud Script run
    /// </summary>
    public int Version { get; set; }
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
    /// <summary>
    /// Deprecated - Do not use
    /// </summary>
    public string? PublisherId { get; set; }
    /// <summary>
    /// Unique identifier for the title, found in the Settings > Game Properties section of the PlayFab developer site when a
    /// title has been selected.
    /// </summary>
    public required string TitleId { get; set; }
}

public class SendAccountRecoveryEmailResult : PlayFabResultCommon {
}

/// <summary>
/// This operation is not additive. It will completely replace the tag list for the specified user. Please note that only
/// users in the PlayFab friends list can be assigned tags. Attempting to set a tag on a friend only included in the
/// friends list from a social site integration (such as Facebook or Steam) will return the AccountNotFound error.
/// </summary>
public class SetFriendTagsRequest : PlayFabRequestCommon {
    /// <summary>
    /// PlayFab identifier of the friend account to which the tag(s) should be applied.
    /// </summary>
    public required string FriendPlayFabId { get; set; }
    /// <summary>
    /// Array of tags to set on the friend account.
    /// </summary>
    public required List<string> Tags { get; set; }
}

public class SetFriendTagsResult : PlayFabResultCommon {
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
    /// Base64 encoded body that is encrypted with the Title's public RSA key (Enterprise Only).
    /// </summary>
    public string? EncryptedRequest { get; set; }
    /// <summary>
    /// Player secret that is used to verify API request signatures (Enterprise Only).
    /// </summary>
    public string? PlayerSecret { get; set; }
}

public class SetPlayerSecretResult : PlayFabResultCommon {
}

public class SharedGroupDataRecord {
    /// <summary>
    /// Timestamp for when this data was last updated.
    /// </summary>
    public required DateTime LastUpdated { get; set; }
    /// <summary>
    /// Unique PlayFab identifier of the user to last update this value.
    /// </summary>
    public string? LastUpdatedBy { get; set; }
    /// <summary>
    /// Indicates whether this data can be read by all users (public) or only members of the group (private).
    /// </summary>
    public UserDataPermission? Permission { get; set; }
    /// <summary>
    /// Data stored for the specified group data key.
    /// </summary>
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
    /// <summary>
    /// version information for the build of the game server which is to be started
    /// </summary>
    public required string BuildVersion { get; set; }
    /// <summary>
    /// character to use for stats based matching. Leave null to use account stats
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// custom command line argument when starting game server process
    /// </summary>
    public string? CustomCommandLineData { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// the title-defined game mode this server is to be running (defaults to 0 if there is only one mode)
    /// </summary>
    public required string GameMode { get; set; }
    /// <summary>
    /// the region to associate this server with for match filtering
    /// </summary>
    public Region Region { get; set; }
    /// <summary>
    /// player statistic for others to use in finding this game. May be null for no stat-based matching
    /// </summary>
    public string? StatisticName { get; set; }
}

[Obsolete("Do not use")]
public class StartGameResult : PlayFabResultCommon {
    /// <summary>
    /// timestamp for when the server should expire, if applicable
    /// </summary>
    public string? Expires { get; set; }
    /// <summary>
    /// unique identifier for the lobby of the server started
    /// </summary>
    public string? LobbyID { get; set; }
    /// <summary>
    /// password required to log into the server
    /// </summary>
    public string? Password { get; set; }
    /// <summary>
    /// server IPV4 address
    /// </summary>
    public string? ServerHostname { get; set; }
    /// <summary>
    /// server IPV4 address
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// server IPV6 address
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// port on the server to be used for communication
    /// </summary>
    public int? ServerPort { get; set; }
    /// <summary>
    /// server public DNS name
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
    /// <summary>
    /// unique identifier for the server
    /// </summary>
    public string? Ticket { get; set; }
}

/// <summary>
/// This is the first step in the purchasing process. For security purposes, once the order (or "cart") has been created,
/// additional inventory objects may no longer be added. In addition, inventory objects will be locked to the current
/// prices, regardless of any subsequent changes at the catalog level which may occur during the next two steps.
/// </summary>
public class StartPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version for the items to be purchased. Defaults to most recent catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Array of items to purchase.
    /// </summary>
    public required List<ItemPurchaseRequest> Items { get; set; }
    /// <summary>
    /// Store through which to purchase items. If not set, prices will be pulled from the catalog itself.
    /// </summary>
    public string? StoreId { get; set; }
}

public class StartPurchaseResult : PlayFabResultCommon {
    /// <summary>
    /// Cart items to be purchased.
    /// </summary>
    public List<CartItem>? Contents { get; set; }
    /// <summary>
    /// Purchase order identifier.
    /// </summary>
    public string? OrderId { get; set; }
    /// <summary>
    /// Available methods by which the user can pay.
    /// </summary>
    public List<PaymentOption>? PaymentOptions { get; set; }
    /// <summary>
    /// Current virtual currency totals for the user.
    /// </summary>
    public Dictionary<string, int>? VirtualCurrencyBalances { get; set; }
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

public class StatisticNameVersion {
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// the version of the statistic to be returned
    /// </summary>
    public uint Version { get; set; }
}

public class StatisticUpdate {
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public required string StatisticName { get; set; }
    /// <summary>
    /// statistic value for the player
    /// </summary>
    public int Value { get; set; }
    /// <summary>
    /// for updates to an existing statistic value for a player, the version of the statistic when it was loaded. Null when
    /// setting the statistic value for the first time.
    /// </summary>
    public uint? Version { get; set; }
}

public class StatisticValue {
    /// <summary>
    /// unique name of the statistic
    /// </summary>
    public string? StatisticName { get; set; }
    /// <summary>
    /// statistic value for the player
    /// </summary>
    public int Value { get; set; }
    /// <summary>
    /// for updates to an existing statistic value for a player, the version of the statistic when it was loaded
    /// </summary>
    public uint Version { get; set; }
}

public class SteamNamePlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Steam identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique Steam identifier for a user, also known as Steam persona name.
    /// </summary>
    public string? SteamName { get; set; }
}

public class SteamPlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Steam identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Deprecated: Please use SteamStringId
    /// </summary>
    public ulong? SteamId { get; set; }
    /// <summary>
    /// Unique Steam identifier for a user.
    /// </summary>
    public string? SteamStringId { get; set; }
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
    public uint? DisplayPosition { get; set; }
    /// <summary>
    /// Unique identifier of the item as it exists in the catalog - note that this must exactly match the ItemId from the
    /// catalog
    /// </summary>
    public required string ItemId { get; set; }
    /// <summary>
    /// Override prices for this item for specific currencies
    /// </summary>
    public Dictionary<string, uint>? RealCurrencyPrices { get; set; }
    /// <summary>
    /// Override prices for this item in virtual currencies and "RM" (the base Real Money purchase price, in USD pennies)
    /// </summary>
    public Dictionary<string, uint>? VirtualCurrencyPrices { get; set; }
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

/// <summary>
/// This API must be enabled for use as an option in the game manager website. It is disabled by default.
/// </summary>
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

public enum TitleActivationStatus {
    None,
    ActivatedTitleKey,
    PendingSteam,
    ActivatedSteam,
    RevokedSteam,
}

public class TitleNewsItem {
    /// <summary>
    /// News item text.
    /// </summary>
    public string? Body { get; set; }
    /// <summary>
    /// Unique identifier of news item.
    /// </summary>
    public string? NewsId { get; set; }
    /// <summary>
    /// Date and time when the news item was posted.
    /// </summary>
    public required DateTime Timestamp { get; set; }
    /// <summary>
    /// Title of the news item.
    /// </summary>
    public string? Title { get; set; }
}

public class TradeInfo {
    /// <summary>
    /// Item instances from the accepting player that are used to fulfill the trade. If null, no one has accepted the trade.
    /// </summary>
    public List<string>? AcceptedInventoryInstanceIds { get; set; }
    /// <summary>
    /// The PlayFab ID of the player who accepted the trade. If null, no one has accepted the trade.
    /// </summary>
    public string? AcceptedPlayerId { get; set; }
    /// <summary>
    /// An optional list of players allowed to complete this trade. If null, anybody can complete the trade.
    /// </summary>
    public List<string>? AllowedPlayerIds { get; set; }
    /// <summary>
    /// If set, The UTC time when this trade was canceled.
    /// </summary>
    public DateTime? CancelledAt { get; set; }
    /// <summary>
    /// If set, The UTC time when this trade was fulfilled.
    /// </summary>
    public DateTime? FilledAt { get; set; }
    /// <summary>
    /// If set, The UTC time when this trade was made invalid.
    /// </summary>
    public DateTime? InvalidatedAt { get; set; }
    /// <summary>
    /// The catalogItem Ids of the item instances being offered.
    /// </summary>
    public List<string>? OfferedCatalogItemIds { get; set; }
    /// <summary>
    /// The itemInstance Ids that are being offered.
    /// </summary>
    public List<string>? OfferedInventoryInstanceIds { get; set; }
    /// <summary>
    /// The PlayFabId for the offering player.
    /// </summary>
    public string? OfferingPlayerId { get; set; }
    /// <summary>
    /// The UTC time when this trade was created.
    /// </summary>
    public DateTime? OpenedAt { get; set; }
    /// <summary>
    /// The catalogItem Ids requested in exchange.
    /// </summary>
    public List<string>? RequestedCatalogItemIds { get; set; }
    /// <summary>
    /// Describes the current state of this trade.
    /// </summary>
    public TradeStatus? Status { get; set; }
    /// <summary>
    /// The identifier for this trade.
    /// </summary>
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
    /// <summary>
    /// List of the experiment variables.
    /// </summary>
    public List<Variable>? Variables { get; set; }
    /// <summary>
    /// List of the experiment variants.
    /// </summary>
    public List<string>? Variants { get; set; }
}

public class TwitchPlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Twitch identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique Twitch identifier for a user.
    /// </summary>
    public string? TwitchId { get; set; }
}

public class UnlinkAndroidDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Android device identifier for the user's device. If not specified, the most recently signed in Android Device ID will
    /// be used.
    /// </summary>
    public string? AndroidDeviceId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkAndroidDeviceIDResult : PlayFabResultCommon {
}

public class UnlinkAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkBattleNetAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkCustomIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// Custom unique identifier for the user, generated by the title. If not specified, the most recently signed in Custom ID
    /// will be used.
    /// </summary>
    public string? CustomId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkCustomIDResult : PlayFabResultCommon {
}

public class UnlinkFacebookAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkFacebookAccountResult : PlayFabResultCommon {
}

public class UnlinkFacebookInstantGamesIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Facebook Instant Games identifier for the user. If not specified, the most recently signed in ID will be used.
    /// </summary>
    public string? FacebookInstantGamesId { get; set; }
}

public class UnlinkFacebookInstantGamesIdResult : PlayFabResultCommon {
}

public class UnlinkGameCenterAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGameCenterAccountResult : PlayFabResultCommon {
}

public class UnlinkGoogleAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGoogleAccountResult : PlayFabResultCommon {
}

public class UnlinkGooglePlayGamesServicesAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkGooglePlayGamesServicesAccountResult : PlayFabResultCommon {
}

public class UnlinkIOSDeviceIDRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Vendor-specific iOS identifier for the user's device. If not specified, the most recently signed in iOS Device ID will
    /// be used.
    /// </summary>
    public string? DeviceId { get; set; }
}

public class UnlinkIOSDeviceIDResult : PlayFabResultCommon {
}

public class UnlinkKongregateAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkKongregateAccountResult : PlayFabResultCommon {
}

public class UnlinkNintendoServiceAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Nintendo Switch Device identifier for the user. If not specified, the most recently signed in device ID will be used.
    /// </summary>
    public string? NintendoSwitchDeviceId { get; set; }
}

public class UnlinkNintendoSwitchDeviceIdResult : PlayFabResultCommon {
}

public class UnlinkOpenIdConnectRequest : PlayFabRequestCommon {
    /// <summary>
    /// A name that identifies which configured OpenID Connect provider relationship to use. Maximum 100 characters.
    /// </summary>
    public required string ConnectionId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkPSNAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkPSNAccountResult : PlayFabResultCommon {
}

public class UnlinkSteamAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkSteamAccountResult : PlayFabResultCommon {
}

public class UnlinkTwitchAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// Valid token issued by Twitch. Used to specify which twitch account to unlink from the profile. By default it uses the
    /// one that is present on the profile.
    /// </summary>
    public string? AccessToken { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UnlinkTwitchAccountResult : PlayFabResultCommon {
}

public class UnlinkXboxAccountRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Token provided by the Xbox Live SDK/XDK method GetTokenAndSignatureAsync("POST", "https://playfabapi.com/", "").
    /// </summary>
    public string? XboxToken { get; set; }
}

public class UnlinkXboxAccountResult : PlayFabResultCommon {
}

/// <summary>
/// Specify the container and optionally the catalogVersion for the container to open
/// </summary>
public class UnlockContainerInstanceRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specifies the catalog version that should be used to determine container contents. If unspecified, uses catalog
    /// associated with the item instance.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// ItemInstanceId of the container to unlock.
    /// </summary>
    public required string ContainerItemInstanceId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// ItemInstanceId of the key that will be consumed by unlocking this container. If the container requires a key, this
    /// parameter is required.
    /// </summary>
    public string? KeyItemInstanceId { get; set; }
}

/// <summary>
/// Specify the type of container to open and optionally the catalogVersion for the container to open
/// </summary>
public class UnlockContainerItemRequest : PlayFabRequestCommon {
    /// <summary>
    /// Specifies the catalog version that should be used to determine container contents. If unspecified, uses default/primary
    /// catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// Catalog ItemId of the container type to unlock.
    /// </summary>
    public required string ContainerItemId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

/// <summary>
/// The items and vc found within the container. These will be added and stacked in the appropriate inventory.
/// </summary>
public class UnlockContainerItemResult : PlayFabResultCommon {
    /// <summary>
    /// Items granted to the player as a result of unlocking the container.
    /// </summary>
    public List<ItemInstance>? GrantedItems { get; set; }
    /// <summary>
    /// Unique instance identifier of the container unlocked.
    /// </summary>
    public string? UnlockedItemInstanceId { get; set; }
    /// <summary>
    /// Unique instance identifier of the key used to unlock the container, if applicable.
    /// </summary>
    public string? UnlockedWithItemInstanceId { get; set; }
    /// <summary>
    /// Virtual currency granted to the player as a result of unlocking the container.
    /// </summary>
    public Dictionary<string, uint>? VirtualCurrency { get; set; }
}

public class UpdateAvatarUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// URL of the avatar image. If empty, it removes the existing avatar URL.
    /// </summary>
    public required string ImageUrl { get; set; }
}

/// <summary>
/// This function performs an additive update of the arbitrary strings containing the custom data for the character. In
/// updating the custom data object, keys which already exist in the object will have their values overwritten, while keys
/// with null values will be removed. New keys will be added, with the given values. No other key-value pairs will be
/// changed apart from those specified in the call.
/// </summary>
public class UpdateCharacterDataRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
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
}

public class UpdateCharacterDataResult : PlayFabResultCommon {
    /// <summary>
    /// Indicates the current version of the data that has been set. This is incremented with every set call for that type of
    /// data (read-only, internal, etc). This version can be provided in Get calls to find updated data.
    /// </summary>
    public uint DataVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title.
/// However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is
/// additive. Character Statistics not currently defined will be added, while those already defined will be updated with
/// the given values. All other user statistics will remain unchanged. Character statistics are used by the
/// character-leaderboard apis, and accessible for custom game-logic.
/// </summary>
public class UpdateCharacterStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// Statistics to be updated with the provided values, in the Key(string), Value(int) pattern.
    /// </summary>
    public Dictionary<string, int>? CharacterStatistics { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class UpdateCharacterStatisticsResult : PlayFabResultCommon {
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
    /// Collection of properties to be set for a player.
    /// </summary>
    public required List<UpdateProperty> Properties { get; set; }
}

public class UpdatePlayerCustomPropertiesResult : PlayFabResultCommon {
    /// <summary>
    /// Indicates the current version of a player's properties that have been set. This is incremented after updates and
    /// deletes. This version can be provided in update and delete calls for concurrency control.
    /// </summary>
    public int PropertiesVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title.
/// However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is
/// additive. Statistics not currently defined will be added, while those already defined will be updated with the given
/// values. All other user statistics will remain unchanged. Note that if the statistic is intended to have a reset period,
/// the UpdatePlayerStatisticDefinition API call can be used to define that reset period. Once a statistic has been
/// versioned (reset), the now-previous version can still be written to for up a short, pre-defined period (currently 10
/// seconds), using the Version parameter in this call.
/// </summary>
public class UpdatePlayerStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Statistics to be updated with the provided values
    /// </summary>
    public required List<StatisticUpdate> Statistics { get; set; }
}

public class UpdatePlayerStatisticsResult : PlayFabResultCommon {
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
/// Note that in the case of multiple calls to write to the same shared group data keys, the last write received by the
/// PlayFab service will determine the value available to subsequent read operations. For scenarios requiring coordination
/// of data updates, it is recommended that titles make use of user data with read permission set to public, or a
/// combination of user data and shared group data.
/// </summary>
public class UpdateSharedGroupDataRequest : PlayFabRequestCommon {
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
    /// Permission to be applied to all user data keys in this request.
    /// </summary>
    public UserDataPermission? Permission { get; set; }
    /// <summary>
    /// Unique identifier for the shared group.
    /// </summary>
    public required string SharedGroupId { get; set; }
}

public class UpdateSharedGroupDataResult : PlayFabResultCommon {
}

/// <summary>
/// This function performs an additive update of the arbitrary strings containing the custom data for the user. In updating
/// the custom data object, keys which already exist in the object will have their values overwritten, while keys with null
/// values will be removed. New keys will be added, with the given values. No other key-value pairs will be changed apart
/// from those specified in the call.
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
    /// Permission to be applied to all user data keys written in this request. Defaults to "private" if not set. This is used
    /// for requests by one player for information about another player; those requests will only return Public keys.
    /// </summary>
    public UserDataPermission? Permission { get; set; }
}

public class UpdateUserDataResult : PlayFabResultCommon {
    /// <summary>
    /// Indicates the current version of the data that has been set. This is incremented with every set call for that type of
    /// data (read-only, internal, etc). This version can be provided in Get calls to find updated data.
    /// </summary>
    public uint DataVersion { get; set; }
}

/// <summary>
/// Enable this option with the 'Allow Client to Post Player Statistics' option in PlayFab GameManager for your title.
/// However, this is not best practice, as this data will no longer be safely controlled by the server. This operation is
/// additive. Statistics not currently defined will be added, while those already defined will be updated with the given
/// values. All other user statistics will remain unchanged. Statistics are used by the leaderboard apis, and accessible
/// for custom game-logic. Note: For statistics configured to reset on an interval, this API call updates the current
/// (latest) version of the player's statistic. Titles using statistic versioning for resettable leaderboards should make
/// use of the UpdatePlayerStatistics call instead, to ensure that the proper version is updated.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Statistics to be updated with the provided values. UserStatistics object must follow the Key(string), Value(int)
    /// pattern.
    /// </summary>
    public Dictionary<string, int>? UserStatistics { get; set; }
}

/// <summary>
/// In addition to being available for use by the title, the statistics are used for all leaderboard operations in PlayFab.
/// </summary>
[Obsolete("Do not use")]
public class UpdateUserStatisticsResult : PlayFabResultCommon {
}

/// <summary>
/// In addition to the PlayFab username, titles can make use of a DisplayName which is also a unique identifier, but
/// specific to the title. This allows for unique names which more closely match the theme or genre of a title, for example.
/// </summary>
public class UpdateUserTitleDisplayNameRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// New title display name for the user - must be between 3 and 25 characters.
    /// </summary>
    public required string DisplayName { get; set; }
}

public class UpdateUserTitleDisplayNameResult : PlayFabResultCommon {
    /// <summary>
    /// Current title display name for the user (this will be the original display name if the rename attempt failed).
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

public class UserSettings {
    /// <summary>
    /// Boolean for whether this player is eligible for gathering device info.
    /// </summary>
    public bool GatherDeviceInfo { get; set; }
    /// <summary>
    /// Boolean for whether this player should report OnFocus play-time tracking.
    /// </summary>
    public bool GatherFocusInfo { get; set; }
    /// <summary>
    /// Boolean for whether this player is eligible for ad tracking.
    /// </summary>
    public bool NeedsAttribution { get; set; }
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

public class ValidateAmazonReceiptRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the fulfilled items. If null, defaults to the primary catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Currency used to pay for the purchase (ISO 4217 currency code).
    /// </summary>
    public string? CurrencyCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Amount of the stated currency paid, in centesimal units.
    /// </summary>
    public int PurchasePrice { get; set; }
    /// <summary>
    /// ReceiptId returned by the Amazon App Store in-app purchase API
    /// </summary>
    public required string ReceiptId { get; set; }
    /// <summary>
    /// AmazonId of the user making the purchase as returned by the Amazon App Store in-app purchase API
    /// </summary>
    public required string UserId { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the Amazon item name will be added to the user's inventory. This result should
/// be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an
/// up to half second delay.
/// </summary>
public class ValidateAmazonReceiptResult : PlayFabResultCommon {
    /// <summary>
    /// Fulfilled inventory items and recorded purchases in fulfillment of the validated receipt transactions.
    /// </summary>
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// The packageName and productId are defined in the GooglePlay store. The productId must match the ItemId of the inventory
/// item in the PlayFab catalog for the title. This enables the PlayFab service to securely validate that the purchase is
/// for the correct item, in order to prevent uses from passing valid receipts as being for more expensive items (passing a
/// receipt for a 99-cent purchase as being for a $19.99 purchase, for example). Each receipt may be validated only once to
/// avoid granting the same item over and over from a single purchase.
/// </summary>
public class ValidateGooglePlayPurchaseRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the fulfilled items. If null, defaults to the primary catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Currency used to pay for the purchase (ISO 4217 currency code).
    /// </summary>
    public string? CurrencyCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Amount of the stated currency paid, in centesimal units.
    /// </summary>
    public uint? PurchasePrice { get; set; }
    /// <summary>
    /// Original JSON string returned by the Google Play IAB API.
    /// </summary>
    public required string ReceiptJson { get; set; }
    /// <summary>
    /// Signature returned by the Google Play IAB API.
    /// </summary>
    public required string Signature { get; set; }
}

/// <summary>
/// Once verified, the catalog item (ItemId) matching the GooglePlay store item (productId) will be added to the user's
/// inventory. This result should be used for immediate updates to the local client game state as opposed to the
/// GetUserInventory API which can have an up to half second delay.
/// </summary>
public class ValidateGooglePlayPurchaseResult : PlayFabResultCommon {
    /// <summary>
    /// Fulfilled inventory items and recorded purchases in fulfillment of the validated receipt transactions.
    /// </summary>
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

/// <summary>
/// The CurrencyCode and PurchasePrice must match the price which was set up for the item in the Apple store. In addition,
/// The ItemId of the inventory in the PlayFab Catalog must match the Product ID as it was set up in the Apple store. This
/// enables the PlayFab service to securely validate that the purchase is for the correct item, in order to prevent uses
/// from passing valid receipts as being for more expensive items (passing a receipt for a 99-cent purchase as being for a
/// $19.99 purchase, for example).
/// </summary>
public class ValidateIOSReceiptRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the fulfilled items. If null, defaults to the primary catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Currency used to pay for the purchase (ISO 4217 currency code).
    /// </summary>
    public string? CurrencyCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Amount of the stated currency paid, in centesimal units.
    /// </summary>
    public int PurchasePrice { get; set; }
    /// <summary>
    /// Base64 encoded receipt data, passed back by the App Store as a result of a successful purchase.
    /// </summary>
    public required string ReceiptData { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the iTunes item name will be added to the user's inventory. This result should
/// be used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an
/// up to half second delay.
/// </summary>
public class ValidateIOSReceiptResult : PlayFabResultCommon {
    /// <summary>
    /// Fulfilled inventory items and recorded purchases in fulfillment of the validated receipt transactions.
    /// </summary>
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
}

public class ValidateWindowsReceiptRequest : PlayFabRequestCommon {
    /// <summary>
    /// Catalog version of the fulfilled items. If null, defaults to the primary catalog.
    /// </summary>
    public string? CatalogVersion { get; set; }
    /// <summary>
    /// Currency used to pay for the purchase (ISO 4217 currency code).
    /// </summary>
    public required string CurrencyCode { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Amount of the stated currency paid, in centesimal units.
    /// </summary>
    public uint PurchasePrice { get; set; }
    /// <summary>
    /// XML Receipt returned by the Windows App Store in-app purchase API
    /// </summary>
    public required string Receipt { get; set; }
}

/// <summary>
/// Once verified, the catalog item matching the Product name will be added to the user's inventory. This result should be
/// used for immediate updates to the local client game state as opposed to the GetUserInventory API which can have an up
/// to half second delay.
/// </summary>
public class ValidateWindowsReceiptResult : PlayFabResultCommon {
    /// <summary>
    /// Fulfilled inventory items and recorded purchases in fulfillment of the validated receipt transactions.
    /// </summary>
    public List<PurchaseReceiptFulfillment>? Fulfillments { get; set; }
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

public class Variable {
    /// <summary>
    /// Name of the variable.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Value of the variable.
    /// </summary>
    public string? Value { get; set; }
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

/// <summary>
/// This API is designed to write a multitude of different client-defined events into PlayStream. It supports a flexible
/// JSON schema, which allowsfor arbitrary key-value pairs to describe any character-based event. The created event will be
/// locked to the authenticated title and player.
/// </summary>
public class WriteClientCharacterEventRequest : PlayFabRequestCommon {
    /// <summary>
    /// Custom event properties. Each property consists of a name (string) and a value (JSON object).
    /// </summary>
    public Dictionary<string, object>? Body { get; set; }
    /// <summary>
    /// Unique PlayFab assigned ID for a specific character owned by a user
    /// </summary>
    public required string CharacterId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the event, within the namespace scoped to the title. The naming convention is up to the caller, but it
    /// commonly follows the subject_verb_object pattern (e.g. player_logged_in).
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// The time (in UTC) associated with this event. The value defaults to the current time.
    /// </summary>
    public DateTime? Timestamp { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different event types into PlayStream. It supports a flexible JSON schema,
/// which allowsfor arbitrary key-value pairs to describe any player-based event. The created event will be locked to the
/// authenticated title and player.
/// </summary>
public class WriteClientPlayerEventRequest : PlayFabRequestCommon {
    /// <summary>
    /// Custom data properties associated with the event. Each property consists of a name (string) and a value (JSON object).
    /// </summary>
    public Dictionary<string, object>? Body { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the event, within the namespace scoped to the title. The naming convention is up to the caller, but it
    /// commonly follows the subject_verb_object pattern (e.g. player_logged_in).
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// The time (in UTC) associated with this event. The value defaults to the current time.
    /// </summary>
    public DateTime? Timestamp { get; set; }
}

public class WriteEventResponse : PlayFabResultCommon {
    /// <summary>
    /// The unique identifier of the event. The values of this identifier consist of ASCII characters and are not constrained
    /// to any particular format.
    /// </summary>
    public string? EventId { get; set; }
}

/// <summary>
/// This API is designed to write a multitude of different client-defined events into PlayStream. It supports a flexible
/// JSON schema, which allowsfor arbitrary key-value pairs to describe any title-based event. The created event will be
/// locked to the authenticated title.
/// </summary>
public class WriteTitleEventRequest : PlayFabRequestCommon {
    /// <summary>
    /// Custom event properties. Each property consists of a name (string) and a value (JSON object).
    /// </summary>
    public Dictionary<string, object>? Body { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the event, within the namespace scoped to the title. The naming convention is up to the caller, but it
    /// commonly follows the subject_verb_object pattern (e.g. player_logged_in).
    /// </summary>
    public required string EventName { get; set; }
    /// <summary>
    /// The time (in UTC) associated with this event. The value defaults to the current time.
    /// </summary>
    public DateTime? Timestamp { get; set; }
}

public class XboxLiveAccountPlayFabIdPair {
    /// <summary>
    /// Unique PlayFab identifier for a user, or null if no PlayFab account is linked to the Xbox Live identifier.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Unique Xbox Live identifier for a user.
    /// </summary>
    public string? XboxLiveAccountId { get; set; }
}

