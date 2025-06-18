namespace CommunityFabs.NET.Sdk.Models.Addon;

public class CreateOrUpdateAppleRequest {
    public required string AppBundleId { get; set; }
    public string? AppSharedSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public bool? IgnoreExpirationDate { get; set; }
    public bool? RequireSecureAuthentication { get; set; }
}

public class CreateOrUpdateAppleResponse {
}

public class CreateOrUpdateFacebookInstantGamesRequest {
    public required string AppID { get; set; }
    public required string AppSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateFacebookInstantGamesResponse {
}

public class CreateOrUpdateFacebookRequest {
    public required string AppID { get; set; }
    public required string AppSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string NotificationEmail { get; set; }
}

public class CreateOrUpdateFacebookResponse {
}

public class CreateOrUpdateGoogleRequest {
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

public class CreateOrUpdateGoogleResponse {
}

public class CreateOrUpdateKongregateRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string SecretAPIKey { get; set; }
}

public class CreateOrUpdateKongregateResponse {
}

public class CreateOrUpdateNintendoRequest {
    public string? ApplicationID { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<NintendoEnvironment>? Environments { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateNintendoResponse {
}

public class CreateOrUpdatePSNRequest {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public string? NextGenClientID { get; set; }
    public string? NextGenClientSecret { get; set; }
}

public class CreateOrUpdatePSNResponse {
}

public class CreateOrUpdateSteamRequest {
    public required string ApplicationId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool? EnforceServiceSpecificTickets { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
    public required string SecretKey { get; set; }
    public bool? UseSandbox { get; set; }
}

public class CreateOrUpdateSteamResponse {
}

public class CreateOrUpdateToxModRequest {
    public required string AccountId { get; set; }
    public required string AccountKey { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public bool Enabled { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateToxModResponse {
}

public class CreateOrUpdateTwitchRequest {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateTwitchResponse {
}

public class DeleteAppleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteAppleResponse {
}

public class DeleteFacebookInstantGamesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookInstantGamesResponse {
}

public class DeleteFacebookRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookResponse {
}

public class DeleteGoogleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteGoogleResponse {
}

public class DeleteKongregateRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteKongregateResponse {
}

public class DeleteNintendoRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteNintendoResponse {
}

public class DeletePSNRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeletePSNResponse {
}

public class DeleteSteamRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteSteamResponse {
}

public class DeleteToxModRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteToxModResponse {
}

public class DeleteTwitchRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class DeleteTwitchResponse {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class GetAppleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetAppleResponse {
    public string? AppBundleId { get; set; }
    public bool Created { get; set; }
    public bool? IgnoreExpirationDate { get; set; }
    public bool? RequireSecureAuthentication { get; set; }
}

public class GetFacebookInstantGamesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetFacebookInstantGamesResponse {
    public string? AppID { get; set; }
    public bool Created { get; set; }
}

public class GetFacebookRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetFacebookResponse {
    public string? AppID { get; set; }
    public bool Created { get; set; }
    public string? NotificationEmail { get; set; }
}

public class GetGoogleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetGoogleResponse {
    public string? AppPackageID { get; set; }
    public bool Created { get; set; }
    public string? OAuthClientID { get; set; }
    public string? OauthCustomRedirectUri { get; set; }
}

public class GetKongregateRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetKongregateResponse {
    public bool Created { get; set; }
}

public class GetNintendoRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetNintendoResponse {
    public string? ApplicationID { get; set; }
    public bool Created { get; set; }
    public List<NintendoEnvironment>? Environments { get; set; }
}

public class GetPSNRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetPSNResponse {
    public string? ClientID { get; set; }
    public bool Created { get; set; }
    public string? NextGenClientID { get; set; }
}

public class GetSteamRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetSteamResponse {
    public string? ApplicationId { get; set; }
    public bool Created { get; set; }
    public bool? EnforceServiceSpecificTickets { get; set; }
    public bool? UseSandbox { get; set; }
}

public class GetToxModRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetToxModResponse {
    public string? AccountId { get; set; }
    public string? AccountKey { get; set; }
    public bool Created { get; set; }
    public bool Enabled { get; set; }
}

public class GetTwitchRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetTwitchResponse {
    public string? ClientID { get; set; }
    public bool Created { get; set; }
}

public class NintendoEnvironment {
    public string? ClientID { get; set; }
    public string? ClientSecret { get; set; }
    public string? ID { get; set; }
}

