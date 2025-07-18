using CommunityFabs.NET.Common.Http;

namespace CommunityFabs.NET.Common.Models.State;

/// <summary>
/// Creates a link to previously stored state. Caller may be title or title player entity.
/// </summary>
public class CreateLinkRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public LinkService LinkService { get; set; }
    public required string StateId { get; set; }
}

public class CreateLinkResponse : PlayFabResultCommon {
    public string? LinkToken { get; set; }
}

/// <summary>
/// Request to create a state.
/// </summary>
public class CreateStateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public required DateTime Expiry { get; set; }
    public string? Label { get; set; }
    public string? PlatformTitleId { get; set; }
    public int RedemptionLimit { get; set; }
    public string? ReferralCode { get; set; }
    public required string State { get; set; }
    public string? ThumbnailUri { get; set; }
    public StateVisibility? Visibility { get; set; }
}

/// <summary>
/// Response from store state operation.
/// </summary>
public class CreateStateResponse : PlayFabResultCommon {
    public string? Id { get; set; }
}

/// <summary>
/// Deletes a link. Caller can be title or title player entity.
/// </summary>
public class DeleteLinkRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string StateId { get; set; }
}

/// <summary>
/// Deletes state. Caller may be title or title player entity.
/// </summary>
public class DeleteStateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Id { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

public class ExpirySetting {
    public int AmountOfUses { get; set; }
    public required DateTime ExpiryDateUTC { get; set; }
    public int MaxAmountOfUses { get; set; }
}

/// <summary>
/// Get public and private metadata for a link. Caller must be a title player entity.
/// </summary>
public class GetLinkMetadataRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LinkToken { get; set; }
}

public class GetLinkMetadataResponse : PlayFabResultCommon {
    public string? Intent { get; set; }
    public bool IsRevoked { get; set; }
    public LinkSetting? LinkSettings { get; set; }
    public Dictionary<string, string>? Metadata { get; set; }
    public Dictionary<string, string>? PrivateMetadata { get; set; }
    public string? Target { get; set; }
}

/// <summary>
/// Request to get state.
/// </summary>
public class GetStateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Id { get; set; }
    public string? PlatformToken { get; set; }
}

/// <summary>
/// Response from retrieve state operation.
/// </summary>
public class GetStateResponse : PlayFabResultCommon {
    public required DateTime Created { get; set; }
    public string? Creator { get; set; }
    public string? Description { get; set; }
    public required DateTime Expiry { get; set; }
    public string? Id { get; set; }
    public string? Label { get; set; }
    public int RedemptionCount { get; set; }
    public int RedemptionLimit { get; set; }
    public string? State { get; set; }
    public string? ThumbnailUri { get; set; }
}

public class IEnumerable_String {
}

public enum LinkService {
    Default,
    Xbox,
    Unknown,
}

public class LinkSetting {
    public ExpirySetting? ExpirySettings { get; set; }
}

/// <summary>
/// Lists ids of states created or retrieved by an entity.
/// </summary>
public class ListStateIdsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListStateIdsResponse : PlayFabResultCommon {
    public IEnumerable_String? CreatedStates { get; set; }
    public IEnumerable_String? RedeemedStates { get; set; }
}

public enum StateVisibility {
    Private,
    FriendsOnly,
    Public,
    Unknown,
}

