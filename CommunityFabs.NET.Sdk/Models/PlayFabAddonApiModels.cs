namespace CommunityFabs.NET.Sdk.Models.Addon;

public class CreateOrUpdateAppleRequest : PlayFabRequestCommon {
    public required string AppBundleId { get; set; }
    public string? AppSharedSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public bool? IgnoreExpirationDate { get; set; }
    public bool? RequireSecureAuthentication { get; set; }
}

public class CreateOrUpdateAppleResponse : PlayFabResultCommon {
}

public class CreateOrUpdateFacebookInstantGamesRequest : PlayFabRequestCommon {
    public required string AppID { get; set; }
    public required string AppSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateFacebookInstantGamesResponse : PlayFabResultCommon {
}

public class CreateOrUpdateFacebookRequest : PlayFabRequestCommon {
    public required string AppID { get; set; }
    public required string AppSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string NotificationEmail { get; set; }
}

public class CreateOrUpdateFacebookResponse : PlayFabResultCommon {
}

public class CreateOrUpdateGoogleRequest : PlayFabRequestCommon {
    public string? AppLicenseKey { get; set; }
    public string? AppPackageID { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public string? OAuthClientID { get; set; }
    public string? OAuthClientSecret { get; set; }
    public string? OAuthCustomRedirectUri { get; set; }
    public string? ServiceAccountKey { get; set; }
}

public class CreateOrUpdateGoogleResponse : PlayFabResultCommon {
}

public class CreateOrUpdateKongregateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string SecretAPIKey { get; set; }
}

public class CreateOrUpdateKongregateResponse : PlayFabResultCommon {
}

public class CreateOrUpdateNintendoRequest : PlayFabRequestCommon {
    public string? ApplicationID { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<NintendoEnvironment>? Environments { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateNintendoResponse : PlayFabResultCommon {
}

public class CreateOrUpdatePSNRequest : PlayFabRequestCommon {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public string? NextGenClientID { get; set; }
    public string? NextGenClientSecret { get; set; }
}

public class CreateOrUpdatePSNResponse : PlayFabResultCommon {
}

public class CreateOrUpdateSteamRequest : PlayFabRequestCommon {
    public required string ApplicationId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? EnforceServiceSpecificTickets { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string SecretKey { get; set; }
    public bool? UseSandbox { get; set; }
}

public class CreateOrUpdateSteamResponse : PlayFabResultCommon {
}

public class CreateOrUpdateToxModRequest : PlayFabRequestCommon {
    public required string AccountId { get; set; }
    public required string AccountKey { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool Enabled { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateToxModResponse : PlayFabResultCommon {
}

public class CreateOrUpdateTwitchRequest : PlayFabRequestCommon {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateTwitchResponse : PlayFabResultCommon {
}

public class DeleteAppleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteAppleResponse : PlayFabResultCommon {
}

public class DeleteFacebookInstantGamesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookInstantGamesResponse : PlayFabResultCommon {
}

public class DeleteFacebookRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookResponse : PlayFabResultCommon {
}

public class DeleteGoogleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteGoogleResponse : PlayFabResultCommon {
}

public class DeleteKongregateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteKongregateResponse : PlayFabResultCommon {
}

public class DeleteNintendoRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteNintendoResponse : PlayFabResultCommon {
}

public class DeletePSNRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeletePSNResponse : PlayFabResultCommon {
}

public class DeleteSteamRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteSteamResponse : PlayFabResultCommon {
}

public class DeleteToxModRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteToxModResponse : PlayFabResultCommon {
}

public class DeleteTwitchRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteTwitchResponse : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class GetAppleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetAppleResponse : PlayFabResultCommon {
    public string? AppBundleId { get; set; }
    public bool Created { get; set; }
    public bool? IgnoreExpirationDate { get; set; }
    public bool? RequireSecureAuthentication { get; set; }
}

public class GetFacebookInstantGamesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetFacebookInstantGamesResponse : PlayFabResultCommon {
    public string? AppID { get; set; }
    public bool Created { get; set; }
}

public class GetFacebookRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetFacebookResponse : PlayFabResultCommon {
    public string? AppID { get; set; }
    public bool Created { get; set; }
    public string? NotificationEmail { get; set; }
}

public class GetGoogleRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetGoogleResponse : PlayFabResultCommon {
    public string? AppPackageID { get; set; }
    public bool Created { get; set; }
    public string? OAuthClientID { get; set; }
    public string? OauthCustomRedirectUri { get; set; }
}

public class GetKongregateRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetKongregateResponse : PlayFabResultCommon {
    public bool Created { get; set; }
}

public class GetNintendoRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetNintendoResponse : PlayFabResultCommon {
    public string? ApplicationID { get; set; }
    public bool Created { get; set; }
    public List<NintendoEnvironment>? Environments { get; set; }
}

public class GetPSNRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetPSNResponse : PlayFabResultCommon {
    public string? ClientID { get; set; }
    public bool Created { get; set; }
    public string? NextGenClientID { get; set; }
}

public class GetSteamRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetSteamResponse : PlayFabResultCommon {
    public string? ApplicationId { get; set; }
    public bool Created { get; set; }
    public bool? EnforceServiceSpecificTickets { get; set; }
    public bool? UseSandbox { get; set; }
}

public class GetToxModRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetToxModResponse : PlayFabResultCommon {
    public string? AccountId { get; set; }
    public string? AccountKey { get; set; }
    public bool Created { get; set; }
    public bool Enabled { get; set; }
}

public class GetTwitchRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetTwitchResponse : PlayFabResultCommon {
    public string? ClientID { get; set; }
    public bool Created { get; set; }
}

public class NintendoEnvironment {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public string? ID { get; set; }
}

