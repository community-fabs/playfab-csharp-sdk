namespace CommunityFabs.NET.Sdk.Models.Profiles;

public enum EffectType {
    Allow,
    Deny,
}

/// <summary>
/// An entity object and its associated meta data.
/// </summary>
public class EntityDataObject {
    public object? DataObject { get; set; }
    public string? EscapedDataObject { get; set; }
    public string? ObjectName { get; set; }
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

public class EntityPermissionStatement {
    public required string Action { get; set; }
    public string? Comment { get; set; }
    public object? Condition { get; set; }
    public EffectType Effect { get; set; }
    public required object Principal { get; set; }
    public required string Resource { get; set; }
}

public class EntityProfileBody {
    public string? AvatarUrl { get; set; }
    public required DateTime Created { get; set; }
    public string? DisplayName { get; set; }
    public EntityKey? Entity { get; set; }
    public string? EntityChain { get; set; }
    public List<string>? ExperimentVariants { get; set; }
    public Dictionary<string, EntityProfileFileMetadata>? Files { get; set; }
    public string? Language { get; set; }
    public EntityLineage? Lineage { get; set; }
    public Dictionary<string, EntityDataObject>? Objects { get; set; }
    public List<EntityPermissionStatement>? Permissions { get; set; }
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
    public int VersionNumber { get; set; }
}

/// <summary>
/// An entity file's meta data. To get a download URL call File/GetFiles API.
/// </summary>
public class EntityProfileFileMetadata {
    public string? Checksum { get; set; }
    public string? FileName { get; set; }
    public required DateTime LastModified { get; set; }
    public int Size { get; set; }
}

public class EntityStatisticValue {
    public string? Metadata { get; set; }
    public string? Name { get; set; }
    public List<string>? Scores { get; set; }
    public int Version { get; set; }
}

/// <summary>
/// Given an entity type and entity identifier will retrieve the profile from the entity store. If the profile being retrieved is the caller's, then the read operation is consistent, if not it is an inconsistent read. An inconsistent read means that we do not guarantee all committed writes have occurred before reading the profile, allowing for a stale read. If consistency is important the Version Number on the result can be used to compare which version of the profile any reader has.
/// </summary>
public class GetEntityProfileRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? DataAsObject { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetEntityProfileResponse {
    public EntityProfileBody? Profile { get; set; }
}

/// <summary>
/// Given a set of entity types and entity identifiers will retrieve all readable profiles properties for the caller. Profiles that the caller is not allowed to read will silently not be included in the results.
/// </summary>
public class GetEntityProfilesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? DataAsObject { get; set; }
    public required List<EntityKey> Entities { get; set; }
}

public class GetEntityProfilesResponse {
    public List<EntityProfileBody>? Profiles { get; set; }
}

/// <summary>
/// Retrieves the title access policy that is used before the profile's policy is inspected during a request. If never customized this will return the default starter policy built by PlayFab.
/// </summary>
public class GetGlobalPolicyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetGlobalPolicyResponse {
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

/// <summary>
/// Given a master player account id (PlayFab ID), returns all title player accounts associated with it.
/// </summary>
public class GetTitlePlayersFromMasterPlayerAccountIdsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<string> MasterPlayerAccountIds { get; set; }
    public string? TitleId { get; set; }
}

public class GetTitlePlayersFromMasterPlayerAccountIdsResponse {
    public string? TitleId { get; set; }
    public Dictionary<string, EntityKey>? TitlePlayerAccounts { get; set; }
}

public class GetTitlePlayersFromProviderIDsResponse {
    public Dictionary<string, EntityLineage>? TitlePlayerAccounts { get; set; }
}

/// <summary>
/// Given a collection of Xbox IDs (XUIDs), returns all title player accounts.
/// </summary>
public class GetTitlePlayersFromXboxLiveIDsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Sandbox { get; set; }
    public string? TitleId { get; set; }
    public required List<string> XboxLiveIds { get; set; }
}

public enum OperationTypes {
    Created,
    Updated,
    Deleted,
    None,
}

/// <summary>
/// Given an entity profile, will update its avatar url to the provided url if the profile's version is equal to the specified value
/// </summary>
public class SetAvatarUrlRequest {
    public required string AvatarUrl { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public int? ProfileVersion { get; set; }
}

public class SetAvatarUrlResponse {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public OperationTypes? OperationResult { get; set; }
    public int? ProfileVersion { get; set; }
}

/// <summary>
/// Given an entity profile, will update its display name to the one passed in if the profile's version is equal to the specified value
/// </summary>
public class SetDisplayNameRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DisplayName { get; set; }
    public EntityKey? Entity { get; set; }
    public int? ExpectedVersion { get; set; }
}

public class SetDisplayNameResponse {
    public OperationTypes? OperationResult { get; set; }
    public int? VersionNumber { get; set; }
}

/// <summary>
/// This will set the access policy statements on the given entity profile. This is not additive, any existing statements will be replaced with the statements in this request.
/// </summary>
public class SetEntityProfilePolicyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required List<EntityPermissionStatement> Statements { get; set; }
}

public class SetEntityProfilePolicyResponse {
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

/// <summary>
/// Updates the title access policy that is used before the profile's policy is inspected during a request. Policies are compiled and cached for several minutes so an update here may not be reflected in behavior for a short time.
/// </summary>
public class SetGlobalPolicyRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<EntityPermissionStatement>? Permissions { get; set; }
}

public class SetGlobalPolicyResponse {
}

/// <summary>
/// Given an entity profile, will update its language to the one passed in if the profile's version is equal to the one passed in.
/// </summary>
public class SetProfileLanguageRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public int? ExpectedVersion { get; set; }
    public string? Language { get; set; }
}

public class SetProfileLanguageResponse {
    public OperationTypes? OperationResult { get; set; }
    public int? VersionNumber { get; set; }
}

