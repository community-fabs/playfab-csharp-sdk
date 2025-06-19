namespace CommunityFabs.NET.Sdk.Models.Matchmaker;

/// <summary>
/// This API allows the external match-making service to confirm that the user has a valid Session Ticket for the title, in
/// order to securely enable match-making. The client passes the user's Session Ticket to the external match-making
/// service, which then passes the Session Ticket in as the AuthorizationTicket in this call.
/// </summary>
[Obsolete("Do not use")]
public class AuthUserRequest : PlayFabRequestCommon {
    /// <summary>
    /// Session Ticket provided by the client.
    /// </summary>
    public required string AuthorizationTicket { get; set; }
}

[Obsolete("Do not use")]
public class AuthUserResponse : PlayFabResultCommon {
    /// <summary>
    /// Boolean indicating if the user has been authorized to use the external match-making service.
    /// </summary>
    public bool Authorized { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the account that has been authorized.
    /// </summary>
    public string? PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class DeregisterGameRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique identifier for the Game Server Instance that is being deregistered.
    /// </summary>
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class DeregisterGameResponse : PlayFabResultCommon {
}

/// <summary>
/// A unique instance of an item in a user's inventory. Note, to retrieve additional information for an item such as Tags,
/// Description that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of
/// can be matched to a catalog entry, which contains the additional information. Also note that Custom Data is only set
/// when the User's specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other
/// fields such as UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
[Obsolete("Do not use")]
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

[Obsolete("Do not use")]
public class PlayerJoinedRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique identifier of the Game Server Instance the user is joining. This must be a Game Server Instance started with the
    /// Matchmaker/StartGame API.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// PlayFab unique identifier for the player joining.
    /// </summary>
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class PlayerJoinedResponse : PlayFabResultCommon {
}

[Obsolete("Do not use")]
public class PlayerLeftRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Unique identifier of the Game Server Instance the user is leaving. This must be a Game Server Instance started with the
    /// Matchmaker/StartGame API.
    /// </summary>
    public required string LobbyId { get; set; }
    /// <summary>
    /// PlayFab unique identifier for the player leaving.
    /// </summary>
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class PlayerLeftResponse : PlayFabResultCommon {
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
    /// <summary>
    /// Unique identifier of the build running on the Game Server Instance.
    /// </summary>
    public required string Build { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Game Mode the Game Server instance is running. Note that this must be defined in the Game Modes tab in the PlayFab Game
    /// Manager, along with the Build ID (the same Game Mode can be defined for multiple Build IDs).
    /// </summary>
    public required string GameMode { get; set; }
    /// <summary>
    /// Previous lobby id if re-registering an existing game.
    /// </summary>
    public string? LobbyId { get; set; }
    /// <summary>
    /// Region in which the Game Server Instance is running. For matchmaking using non-AWS region names, set this to any AWS
    /// region and use Tags (below) to specify your custom region.
    /// </summary>
    public Region Region { get; set; }
    /// <summary>
    /// IPV4 address of the Game Server Instance.
    /// </summary>
    public string? ServerHost { get; set; }
    /// <summary>
    /// IPV4 address of the game server instance.
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// IPV6 address (if any) of the game server instance.
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// Port number for communication with the Game Server Instance.
    /// </summary>
    public required string ServerPort { get; set; }
    /// <summary>
    /// Public DNS name (if any) of the server
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
    /// <summary>
    /// Tags for the Game Server Instance
    /// </summary>
    public Dictionary<string, string>? Tags { get; set; }
}

[Obsolete("Do not use")]
public class RegisterGameResponse : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier generated for the Game Server Instance that is registered. If LobbyId is specified in request and the
    /// game still exists in PlayFab, the LobbyId in request is returned. Otherwise a new lobby id will be returned.
    /// </summary>
    public string? LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class StartGameRequest : PlayFabRequestCommon {
    /// <summary>
    /// Unique identifier of the previously uploaded build executable which is to be started.
    /// </summary>
    public required string Build { get; set; }
    /// <summary>
    /// Custom command line argument when starting game server process.
    /// </summary>
    public string? CustomCommandLineData { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// HTTP endpoint URL for receiving game status events, if using an external matchmaker. When the game ends, PlayFab will
    /// make a POST request to this URL with the X-SecretKey header set to the value of the game's secret and an
    /// application/json body of { "EventName": "game_ended", "GameID": "<gameid>" }.
    /// </summary>
    public required string ExternalMatchmakerEventEndpoint { get; set; }
    /// <summary>
    /// Game mode for this Game Server Instance.
    /// </summary>
    public required string GameMode { get; set; }
    /// <summary>
    /// Region with which to associate the server, for filtering.
    /// </summary>
    public Region Region { get; set; }
}

[Obsolete("Do not use")]
public class StartGameResponse : PlayFabResultCommon {
    /// <summary>
    /// Unique identifier for the game/lobby in the new Game Server Instance.
    /// </summary>
    public string? GameID { get; set; }
    /// <summary>
    /// IPV4 address of the new Game Server Instance.
    /// </summary>
    public string? ServerHostname { get; set; }
    /// <summary>
    /// IPV4 address of the server
    /// </summary>
    public string? ServerIPV4Address { get; set; }
    /// <summary>
    /// IPV6 address of the new Game Server Instance.
    /// </summary>
    public string? ServerIPV6Address { get; set; }
    /// <summary>
    /// Port number for communication with the Game Server Instance.
    /// </summary>
    public UInt32 ServerPort { get; set; }
    /// <summary>
    /// Public DNS name (if any) of the server
    /// </summary>
    public string? ServerPublicDNSName { get; set; }
}

[Obsolete("Do not use")]
public class UserInfoRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Minimum catalog version for which data is requested (filters the results to only contain inventory items which have a
    /// catalog version of this or higher).
    /// </summary>
    public int MinCatalogVersion { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose information is being requested.
    /// </summary>
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class UserInfoResponse : PlayFabResultCommon {
    /// <summary>
    /// Array of inventory items in the user's current inventory.
    /// </summary>
    public List<ItemInstance>? Inventory { get; set; }
    /// <summary>
    /// Boolean indicating whether the user is a developer.
    /// </summary>
    public bool IsDeveloper { get; set; }
    /// <summary>
    /// PlayFab unique identifier of the user whose information was requested.
    /// </summary>
    public string? PlayFabId { get; set; }
    /// <summary>
    /// Steam unique identifier, if the user has an associated Steam account.
    /// </summary>
    public string? SteamId { get; set; }
    /// <summary>
    /// Title specific display name, if set.
    /// </summary>
    public string? TitleDisplayName { get; set; }
    /// <summary>
    /// PlayFab unique user name.
    /// </summary>
    public string? Username { get; set; }
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

