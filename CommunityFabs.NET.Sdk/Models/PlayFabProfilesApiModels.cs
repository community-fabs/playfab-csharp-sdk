using CommunityFabs.NET.Sdk.Http;

namespace CommunityFabs.NET.Sdk.Models.Profiles;

public enum EffectType {
    Allow,
    Deny,
}

/// <summary>
/// An entity object and its associated meta data.
/// </summary>
public class EntityDataObject {
    /// <summary>
    /// Un-escaped JSON object, if DataAsObject is true.
    /// </summary>
    public object? DataObject { get; set; }
    /// <summary>
    /// Escaped string JSON body of the object, if DataAsObject is default or false.
    /// </summary>
    public string? EscapedDataObject { get; set; }
    /// <summary>
    /// Name of this object.
    /// </summary>
    public string? ObjectName { get; set; }
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

public class EntityPermissionStatement {
    /// <summary>
    /// The action this statement effects. May be 'Read', 'Write' or '*' for both read and write.
    /// </summary>
    public required string Action { get; set; }
    /// <summary>
    /// A comment about the statement. Intended solely for bookkeeping and debugging.
    /// </summary>
    public string? Comment { get; set; }
    /// <summary>
    /// Additional conditions to be applied for entity resources.
    /// </summary>
    public object? Condition { get; set; }
    /// <summary>
    /// The effect this statement will have. It may be either Allow or Deny
    /// </summary>
    public EffectType Effect { get; set; }
    /// <summary>
    /// The principal this statement will effect.
    /// </summary>
    public required object Principal { get; set; }
    /// <summary>
    /// The resource this statements effects. Similar to 'pfrn:data--title![Title ID]/Profile/*'
    /// </summary>
    public required string Resource { get; set; }
}

public class EntityProfileBody {
    /// <summary>
    /// Avatar URL for the entity.
    /// </summary>
    public string? AvatarUrl { get; set; }
    /// <summary>
    /// The creation time of this profile in UTC.
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The display name of the entity. This field may serve different purposes for different entity types. i.e.: for a title
    /// player account it could represent the display name of the player, whereas on a character it could be character's name.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The chain of responsibility for this entity. Use Lineage.
    /// </summary>
    public string? EntityChain { get; set; }
    /// <summary>
    /// The experiment variants of this profile.
    /// </summary>
    public List<string>? ExperimentVariants { get; set; }
    /// <summary>
    /// The files on this profile.
    /// </summary>
    public Dictionary<string, EntityProfileFileMetadata>? Files { get; set; }
    /// <summary>
    /// The language on this profile.
    /// </summary>
    public string? Language { get; set; }
    /// <summary>
    /// The lineage of this profile.
    /// </summary>
    public EntityLineage? Lineage { get; set; }
    /// <summary>
    /// The objects on this profile.
    /// </summary>
    public Dictionary<string, EntityDataObject>? Objects { get; set; }
    /// <summary>
    /// The permissions that govern access to this entity profile and its properties. Only includes permissions set on this
    /// profile, not global statements from titles and namespaces.
    /// </summary>
    public List<EntityPermissionStatement>? Permissions { get; set; }
    /// <summary>
    /// The statistics on this profile.
    /// </summary>
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
    /// <summary>
    /// The version number of the profile in persistent storage at the time of the read. Used for optional optimistic
    /// concurrency during update.
    /// </summary>
    public int VersionNumber { get; set; }
}

/// <summary>
/// An entity file's meta data. To get a download URL call File/GetFiles API.
/// </summary>
public class EntityProfileFileMetadata {
    /// <summary>
    /// Checksum value for the file, can be used to check if the file on the server has changed.
    /// </summary>
    public string? Checksum { get; set; }
    /// <summary>
    /// Name of the file
    /// </summary>
    public string? FileName { get; set; }
    /// <summary>
    /// Last UTC time the file was modified
    /// </summary>
    public required DateTime LastModified { get; set; }
    /// <summary>
    /// Storage service's reported byte count
    /// </summary>
    public int Size { get; set; }
}

public class EntityStatisticValue {
    /// <summary>
    /// Metadata associated with the Statistic.
    /// </summary>
    public string? Metadata { get; set; }
    /// <summary>
    /// Statistic name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Statistic scores
    /// </summary>
    public List<string>? Scores { get; set; }
    /// <summary>
    /// Statistic version
    /// </summary>
    public int Version { get; set; }
}

/// <summary>
/// Given an entity type and entity identifier will retrieve the profile from the entity store. If the profile being
/// retrieved is the caller's, then the read operation is consistent, if not it is an inconsistent read. An inconsistent
/// read means that we do not guarantee all committed writes have occurred before reading the profile, allowing for a stale
/// read. If consistency is important the Version Number on the result can be used to compare which version of the profile
/// any reader has.
/// </summary>
public class GetEntityProfileRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Determines whether the objects will be returned as an escaped JSON string or as a un-escaped JSON object. Default is
    /// JSON string.
    /// </summary>
    public bool? DataAsObject { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetEntityProfileResponse : PlayFabResultCommon {
    /// <summary>
    /// Entity profile
    /// </summary>
    public EntityProfileBody? Profile { get; set; }
}

/// <summary>
/// Given a set of entity types and entity identifiers will retrieve all readable profiles properties for the caller.
/// Profiles that the caller is not allowed to read will silently not be included in the results.
/// </summary>
public class GetEntityProfilesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Determines whether the objects will be returned as an escaped JSON string or as a un-escaped JSON object. Default is
    /// JSON string.
    /// </summary>
    public bool? DataAsObject { get; set; }
    /// <summary>
    /// Entity keys of the profiles to load. Must be between 1 and 25
    /// </summary>
    public required List<EntityKey> Entities { get; set; }
}

public class GetEntityProfilesResponse : PlayFabResultCommon {
    /// <summary>
    /// Entity profiles
    /// </summary>
    public List<EntityProfileBody>? Profiles { get; set; }
}

/// <summary>
/// Retrieves the title access policy that is used before the profile's policy is inspected during a request. If never
/// customized this will return the default starter policy built by PlayFab.
/// </summary>
public class GetGlobalPolicyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetGlobalPolicyResponse : PlayFabResultCommon {
    /// <summary>
    /// The permissions that govern access to all entities under this title or namespace.
    /// </summary>
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

/// <summary>
/// Given a master player account id (PlayFab ID), returns all title player accounts associated with it.
/// </summary>
public class GetTitlePlayersFromMasterPlayerAccountIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Master player account ids.
    /// </summary>
    public required List<string> MasterPlayerAccountIds { get; set; }
    /// <summary>
    /// Id of title to get players from.
    /// </summary>
    public string? TitleId { get; set; }
}

public class GetTitlePlayersFromMasterPlayerAccountIdsResponse : PlayFabResultCommon {
    /// <summary>
    /// Optional id of title to get players from, required if calling using a master_player_account.
    /// </summary>
    public string? TitleId { get; set; }
    /// <summary>
    /// Dictionary of master player ids mapped to title player entity keys and id pairs
    /// </summary>
    public Dictionary<string, EntityKey>? TitlePlayerAccounts { get; set; }
}

public class GetTitlePlayersFromProviderIDsResponse : PlayFabResultCommon {
    /// <summary>
    /// Dictionary of provider identifiers mapped to title_player_account lineage. Missing lineage indicates the player either
    /// doesn't exist or doesn't play the requested title.
    /// </summary>
    public Dictionary<string, EntityLineage>? TitlePlayerAccounts { get; set; }
}

/// <summary>
/// Given a collection of Xbox IDs (XUIDs), returns all title player accounts.
/// </summary>
public class GetTitlePlayersFromXboxLiveIDsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Xbox Sandbox the players had on their Xbox tokens.
    /// </summary>
    public required string Sandbox { get; set; }
    /// <summary>
    /// Optional ID of title to get players from, required if calling using a master_player_account.
    /// </summary>
    public string? TitleId { get; set; }
    /// <summary>
    /// List of Xbox Live XUIDs
    /// </summary>
    public required List<string> XboxLiveIds { get; set; }
}

public enum OperationTypes {
    Created,
    Updated,
    Deleted,
    None,
}

/// <summary>
/// Given an entity profile, will update its avatar url to the provided url if the profile's version is equal to the
/// specified value
/// </summary>
public class SetAvatarUrlRequest : PlayFabRequestCommon {
    /// <summary>
    /// URL of the avatar image. If empty, it removes the existing avatar URL
    /// </summary>
    public required string AvatarUrl { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The expected version of the profile to perform this update on
    /// </summary>
    public int? ProfileVersion { get; set; }
}

public class SetAvatarUrlResponse : PlayFabResultCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The type of operation that occurred on the profile's avatar URL
    /// </summary>
    public OperationTypes? OperationResult { get; set; }
    /// <summary>
    /// The updated version of the profile after the avatar URL update
    /// </summary>
    public int? ProfileVersion { get; set; }
}

/// <summary>
/// Given an entity profile, will update its display name to the one passed in if the profile's version is equal to the
/// specified value
/// </summary>
public class SetDisplayNameRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The new value to be set on Entity Profile's display name
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The expected version of a profile to perform this update on
    /// </summary>
    public int? ExpectedVersion { get; set; }
}

public class SetDisplayNameResponse : PlayFabResultCommon {
    /// <summary>
    /// The type of operation that occured on the profile's display name
    /// </summary>
    public OperationTypes? OperationResult { get; set; }
    /// <summary>
    /// The updated version of the profile after the display name update
    /// </summary>
    public int? VersionNumber { get; set; }
}

/// <summary>
/// This will set the access policy statements on the given entity profile. This is not additive, any existing statements
/// will be replaced with the statements in this request.
/// </summary>
public class SetEntityProfilePolicyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity to perform this action on.
    /// </summary>
    public required EntityKey Entity { get; set; }
    /// <summary>
    /// The statements to include in the access policy.
    /// </summary>
    public required List<EntityPermissionStatement> Statements { get; set; }
}

public class SetEntityProfilePolicyResponse : PlayFabResultCommon {
    /// <summary>
    /// The permissions that govern access to this entity profile and its properties. Only includes permissions set on this
    /// profile, not global statements from titles and namespaces.
    /// </summary>
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

/// <summary>
/// Updates the title access policy that is used before the profile's policy is inspected during a request. Policies are
/// compiled and cached for several minutes so an update here may not be reflected in behavior for a short time.
/// </summary>
public class SetGlobalPolicyRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The permissions that govern access to all entities under this title or namespace.
    /// </summary>
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

public class SetGlobalPolicyResponse : PlayFabResultCommon {
}

/// <summary>
/// Given an entity profile, will update its language to the one passed in if the profile's version is equal to the one
/// passed in.
/// </summary>
public class SetProfileLanguageRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The expected version of a profile to perform this update on
    /// </summary>
    public int? ExpectedVersion { get; set; }
    /// <summary>
    /// The language to set on the given entity. Deletes the profile's language if passed in a null string.
    /// </summary>
    public string? Language { get; set; }
}

public class SetProfileLanguageResponse : PlayFabResultCommon {
    /// <summary>
    /// The type of operation that occured on the profile's language
    /// </summary>
    public OperationTypes? OperationResult { get; set; }
    /// <summary>
    /// The updated version of the profile after the language update
    /// </summary>
    public int? VersionNumber { get; set; }
}

