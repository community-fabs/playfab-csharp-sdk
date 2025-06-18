namespace CommunityFabs.NET.Sdk.Models.Authentication;

/// <summary>
/// Create or return a game_server entity token. Caller must be a title entity.
/// </summary>
public class AuthenticateCustomIdRequest {
    public required string CustomId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class AuthenticateCustomIdResult {
    public EntityTokenResponse? EntityToken { get; set; }
    public bool NewlyCreated { get; set; }
}

/// <summary>
/// Delete a game_server entity. The caller can be the game_server entity attempting to delete itself. Or a title entity attempting to delete game_server entities for this title.
/// </summary>
public class DeleteRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
}

public class EmptyResponse {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class EntityLineage {
    public string? CharacterId { get; set; }
    public string? GroupId { get; set; }
    public string? MasterPlayerAccountId { get; set; }
    public string? NamespaceId { get; set; }
    public string? TitleId { get; set; }
    public string? TitlePlayerAccountId { get; set; }
}

public class EntityTokenResponse {
    public EntityKey? Entity { get; set; }
    public string? EntityToken { get; set; }
    public DateTime? TokenExpiration { get; set; }
}

/// <summary>
/// This API must be called with X-SecretKey, X-Authentication or X-EntityToken headers. An optional EntityKey may be included to attempt to set the resulting EntityToken to a specific entity, however the entity must be a relation of the caller, such as the master_player_account of a character. If sending X-EntityToken the account will be marked as freshly logged in and will issue a new token. If using X-Authentication or X-EntityToken the header must still be valid and cannot be expired or revoked.
/// </summary>
public class GetEntityTokenRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetEntityTokenResponse {
    public EntityKey? Entity { get; set; }
    public string? EntityToken { get; set; }
    public DateTime? TokenExpiration { get; set; }
}

public enum IdentifiedDeviceType {
    Unknown,
    XboxOne,
    Scarlett,
    WindowsOneCore,
    WindowsOneCoreMobile,
    Win32,
    android,
    iOS,
    PlayStation,
    Nintendo,
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
/// Given an entity token, validates that it hasn't expired or been revoked and will return details of the owner.
/// </summary>
public class ValidateEntityTokenRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EntityToken { get; set; }
}

public class ValidateEntityTokenResponse {
    public EntityKey? Entity { get; set; }
    public IdentifiedDeviceType? IdentifiedDeviceType { get; set; }
    public LoginIdentityProvider? IdentityProvider { get; set; }
    public string? IdentityProviderIssuedId { get; set; }
    public EntityLineage? Lineage { get; set; }
}

