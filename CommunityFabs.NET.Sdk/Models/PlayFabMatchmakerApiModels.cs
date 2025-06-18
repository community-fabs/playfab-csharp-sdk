namespace CommunityFabs.NET.Sdk.Models.Matchmaker;

/// <summary>
/// This API allows the external match-making service to confirm that the user has a valid Session Ticket for the title, in order to securely enable match-making. The client passes the user's Session Ticket to the external match-making service, which then passes the Session Ticket in as the AuthorizationTicket in this call.
/// </summary>
[Obsolete("Do not use")]
public class AuthUserRequest {
    public required string AuthorizationTicket { get; set; }
}

[Obsolete("Do not use")]
public class AuthUserResponse {
    public bool Authorized { get; set; }
    public string? PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class DeregisterGameRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class DeregisterGameResponse {
}

/// <summary>
/// A unique instance of an item in a user's inventory. Note, to retrieve additional information for an item such as Tags, Description that are the same across all instances of the item, a call to GetCatalogItems is required. The ItemID of can be matched to a catalog entry, which contains the additional information. Also note that Custom Data is only set when the User's specific instance has updated the CustomData via a call to UpdateUserInventoryItemCustomData. Other fields such as UnitPrice and UnitCurrency are only set when the item was granted via a purchase.
/// </summary>
[Obsolete("Do not use")]
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

[Obsolete("Do not use")]
public class PlayerJoinedRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class PlayerJoinedResponse {
}

[Obsolete("Do not use")]
public class PlayerLeftRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LobbyId { get; set; }
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class PlayerLeftResponse {
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
public class RegisterGameRequest {
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
public class RegisterGameResponse {
    public string? LobbyId { get; set; }
}

[Obsolete("Do not use")]
public class StartGameRequest {
    public required string Build { get; set; }
    public string? CustomCommandLineData { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExternalMatchmakerEventEndpoint { get; set; }
    public required string GameMode { get; set; }
    public Region Region { get; set; }
}

[Obsolete("Do not use")]
public class StartGameResponse {
    public string? GameID { get; set; }
    public string? ServerHostname { get; set; }
    public string? ServerIPV4Address { get; set; }
    public string? ServerIPV6Address { get; set; }
    public UInt32 ServerPort { get; set; }
    public string? ServerPublicDNSName { get; set; }
}

[Obsolete("Do not use")]
public class UserInfoRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int MinCatalogVersion { get; set; }
    public required string PlayFabId { get; set; }
}

[Obsolete("Do not use")]
public class UserInfoResponse {
    public List<ItemInstance>? Inventory { get; set; }
    public bool IsDeveloper { get; set; }
    public string? PlayFabId { get; set; }
    public string? SteamId { get; set; }
    public string? TitleDisplayName { get; set; }
    public string? Username { get; set; }
    public Dictionary<string, int>? VirtualCurrency { get; set; }
    public Dictionary<string, VirtualCurrencyRechargeTime>? VirtualCurrencyRechargeTimes { get; set; }
}

[Obsolete("Do not use")]
public class VirtualCurrencyRechargeTime {
    public int RechargeMax { get; set; }
    public required DateTime RechargeTime { get; set; }
    public int SecondsToRecharge { get; set; }
}

