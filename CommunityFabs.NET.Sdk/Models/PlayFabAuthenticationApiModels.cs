namespace CommunityFabs.NET.Sdk.Models.Authentication;

/// <summary>
/// Create or return a game_server entity token. Caller must be a title entity.
/// </summary>
public class AuthenticateCustomIdRequest : PlayFabRequestCommon {
    /// <summary>
    /// The customId used to create and retrieve game_server entity tokens. This is unique at the title level. CustomId must be
    /// between 32 and 100 characters.
    /// </summary>
    public required string CustomId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class AuthenticateCustomIdResult : PlayFabResultCommon {
    /// <summary>
    /// The token generated used to set X-EntityToken for game_server calls.
    /// </summary>
    public EntityTokenResponse? EntityToken { get; set; }
    /// <summary>
    /// True if the account was newly created on this authentication.
    /// </summary>
    public bool NewlyCreated { get; set; }
}

/// <summary>
/// Delete a game_server entity. The caller can be the game_server entity attempting to delete itself. Or a title entity
/// attempting to delete game_server entities for this title.
/// </summary>
public class DeleteRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The game_server entity to be removed.
    /// </summary>
    public required EntityKey Entity { get; set; }
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

public class EntityLineage {
    /// <summary>
    /// The Character Id of the associated entity.
    /// </summary>
    public string? CharacterId { get; set; }
    /// <summary>
    /// The Group Id of the associated entity.
    /// </summary>
    public string? GroupId { get; set; }
    /// <summary>
    /// The Master Player Account Id of the associated entity.
    /// </summary>
    public string? MasterPlayerAccountId { get; set; }
    /// <summary>
    /// The Namespace Id of the associated entity.
    /// </summary>
    public string? NamespaceId { get; set; }
    /// <summary>
    /// The Title Id of the associated entity.
    /// </summary>
    public string? TitleId { get; set; }
    /// <summary>
    /// The Title Player Account Id of the associated entity.
    /// </summary>
    public string? TitlePlayerAccountId { get; set; }
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

/// <summary>
/// This API must be called with X-SecretKey, X-Authentication or X-EntityToken headers. An optional EntityKey may be
/// included to attempt to set the resulting EntityToken to a specific entity, however the entity must be a relation of the
/// caller, such as the master_player_account of a character. If sending X-EntityToken the account will be marked as
/// freshly logged in and will issue a new token. If using X-Authentication or X-EntityToken the header must still be valid
/// and cannot be expired or revoked.
/// </summary>
public class GetEntityTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetEntityTokenResponse : PlayFabResultCommon {
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
public class ValidateEntityTokenRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Client EntityToken
    /// </summary>
    public required string EntityToken { get; set; }
}

public class ValidateEntityTokenResponse : PlayFabResultCommon {
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The authenticated device for this entity, for the given login
    /// </summary>
    public IdentifiedDeviceType? IdentifiedDeviceType { get; set; }
    /// <summary>
    /// The identity provider for this entity, for the given login
    /// </summary>
    public LoginIdentityProvider? IdentityProvider { get; set; }
    /// <summary>
    /// The ID issued by the identity provider, e.g. a XUID on Xbox Live
    /// </summary>
    public string? IdentityProviderIssuedId { get; set; }
    /// <summary>
    /// The lineage of this profile.
    /// </summary>
    public EntityLineage? Lineage { get; set; }
}

