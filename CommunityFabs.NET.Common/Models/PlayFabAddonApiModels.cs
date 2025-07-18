using CommunityFabs.NET.Sdk.Common.Http;

namespace CommunityFabs.NET.Sdk.Common.Models.Addon;

public class CreateOrUpdateAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// iOS App Bundle ID obtained after setting up your app in the App Store.
    /// </summary>
    public required string AppBundleId { get; set; }
    /// <summary>
    /// iOS App Shared Secret obtained after setting up your app in the App Store.
    /// </summary>
    public string? AppSharedSecret { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Ignore expiration date for identity tokens. Be aware that when set to true this can invalidate expired tokens in the
    /// case where Apple rotates their signing keys.
    /// </summary>
    public bool? IgnoreExpirationDate { get; set; }
    /// <summary>
    /// Require secure authentication only for this app.
    /// </summary>
    public bool? RequireSecureAuthentication { get; set; }
}

public class CreateOrUpdateAppleResponse : PlayFabResultCommon {
}

public class CreateOrUpdateFacebookInstantGamesRequest : PlayFabRequestCommon {
    /// <summary>
    /// Facebook App ID obtained after setting up your app in Facebook Instant Games.
    /// </summary>
    public required string AppID { get; set; }
    /// <summary>
    /// Facebook App Secret obtained after setting up your app in Facebook Instant Games.
    /// </summary>
    public required string AppSecret { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateFacebookInstantGamesResponse : PlayFabResultCommon {
}

public class CreateOrUpdateFacebookRequest : PlayFabRequestCommon {
    /// <summary>
    /// Facebook App ID obtained after setting up your app in Facebook.
    /// </summary>
    public required string AppID { get; set; }
    /// <summary>
    /// Facebook App Secret obtained after setting up your app in Facebook.
    /// </summary>
    public required string AppSecret { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Email address for purchase dispute notifications.
    /// </summary>
    public required string NotificationEmail { get; set; }
}

public class CreateOrUpdateFacebookResponse : PlayFabResultCommon {
}

public class CreateOrUpdateGoogleRequest : PlayFabRequestCommon {
    /// <summary>
    /// Google App License Key obtained after setting up your app in the Google Play developer portal. Required if using Google
    /// receipt validation.
    /// </summary>
    public string? AppLicenseKey { get; set; }
    /// <summary>
    /// Google App Package ID obtained after setting up your app in the Google Play developer portal. Required if using Google
    /// receipt validation.
    /// </summary>
    public string? AppPackageID { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Google OAuth Client ID obtained through the Google Developer Console by creating a new set of "OAuth Client ID".
    /// Required if using Google Authentication.
    /// </summary>
    public string? OAuthClientID { get; set; }
    /// <summary>
    /// Google OAuth Client Secret obtained through the Google Developer Console by creating a new set of "OAuth Client ID".
    /// Required if using Google Authentication.
    /// </summary>
    public string? OAuthClientSecret { get; set; }
    /// <summary>
    /// Authorized Redirect Uri obtained through the Google Developer Console. This currently defaults to
    /// https://oauth.playfab.com/oauth2/google. If you are authenticating players via browser, please update this to your own
    /// domain.
    /// </summary>
    public string? OAuthCustomRedirectUri { get; set; }
    /// <summary>
    /// Needed to enable pending purchase handling and subscription processing.
    /// </summary>
    public string? ServiceAccountKey { get; set; }
}

public class CreateOrUpdateGoogleResponse : PlayFabResultCommon {
}

public class CreateOrUpdateKongregateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Kongregate Secret API Key obtained after setting up your game in your Kongregate developer account.
    /// </summary>
    public required string SecretAPIKey { get; set; }
}

public class CreateOrUpdateKongregateResponse : PlayFabResultCommon {
}

public class CreateOrUpdateNintendoRequest : PlayFabRequestCommon {
    /// <summary>
    /// Nintendo Switch Application ID, without the "0x" prefix.
    /// </summary>
    public string? ApplicationID { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// List of Nintendo Environments, currently supporting up to 4. Needs Catalog enabled.
    /// </summary>
    public List<NintendoEnvironment>? Environments { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateNintendoResponse : PlayFabResultCommon {
}

public class CreateOrUpdatePSNRequest : PlayFabRequestCommon {
    /// <summary>
    /// Client ID obtained after setting up your game with Sony. This one is associated with the existing PS4 marketplace.
    /// </summary>
    public string? ClientID { get; set; }
    /// <summary>
    /// Client secret obtained after setting up your game with Sony. This one is associated with the existing PS4 marketplace.
    /// </summary>
    public string? ClientSecret { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Client ID obtained after setting up your game with Sony. This one is associated with the modern marketplace, which
    /// includes PS5, cross-generation for PS4, and unified entitlements.
    /// </summary>
    public string? NextGenClientID { get; set; }
    /// <summary>
    /// Client secret obtained after setting up your game with Sony. This one is associated with the modern marketplace, which
    /// includes PS5, cross-generation for PS4, and unified entitlements.
    /// </summary>
    public string? NextGenClientSecret { get; set; }
}

public class CreateOrUpdatePSNResponse : PlayFabResultCommon {
}

public class CreateOrUpdateSteamRequest : PlayFabRequestCommon {
    /// <summary>
    /// Application ID obtained after setting up your app in Valve's developer portal.
    /// </summary>
    public required string ApplicationId { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Enforce usage of AzurePlayFab identity in user authentication tickets.
    /// </summary>
    public bool? EnforceServiceSpecificTickets { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
    /// <summary>
    /// Sercet Key obtained after setting up your app in Valve's developer portal.
    /// </summary>
    public required string SecretKey { get; set; }
    /// <summary>
    /// Use Steam Payments sandbox endpoint for test transactions.
    /// </summary>
    public bool? UseSandbox { get; set; }
}

public class CreateOrUpdateSteamResponse : PlayFabResultCommon {
}

public class CreateOrUpdateToxModRequest : PlayFabRequestCommon {
    /// <summary>
    /// Account ID obtained after creating your ToxMod developer account.
    /// </summary>
    public required string AccountId { get; set; }
    /// <summary>
    /// Account Key obtained after creating your ToxMod developer account.
    /// </summary>
    public required string AccountKey { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Whether ToxMod Addon is Enabled by Title.
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateToxModResponse : PlayFabResultCommon {
}

public class CreateOrUpdateTwitchRequest : PlayFabRequestCommon {
    /// <summary>
    /// Client ID obtained after creating your Twitch developer account.
    /// </summary>
    public string? ClientID { get; set; }
    /// <summary>
    /// Client Secret obtained after creating your Twitch developer account.
    /// </summary>
    public string? ClientSecret { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// If an error should be returned if the addon already exists.
    /// </summary>
    public bool? ErrorIfExists { get; set; }
}

public class CreateOrUpdateTwitchResponse : PlayFabResultCommon {
}

public class DeleteAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteAppleResponse : PlayFabResultCommon {
}

public class DeleteFacebookInstantGamesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookInstantGamesResponse : PlayFabResultCommon {
}

public class DeleteFacebookRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteFacebookResponse : PlayFabResultCommon {
}

public class DeleteGoogleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteGoogleResponse : PlayFabResultCommon {
}

public class DeleteKongregateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteKongregateResponse : PlayFabResultCommon {
}

public class DeleteNintendoRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteNintendoResponse : PlayFabResultCommon {
}

public class DeletePSNRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeletePSNResponse : PlayFabResultCommon {
}

public class DeleteSteamRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteSteamResponse : PlayFabResultCommon {
}

public class DeleteToxModRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteToxModResponse : PlayFabResultCommon {
}

public class DeleteTwitchRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class DeleteTwitchResponse : PlayFabResultCommon {
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

public class GetAppleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetAppleResponse : PlayFabResultCommon {
    /// <summary>
    /// iOS App Bundle ID obtained after setting up your app in the App Store.
    /// </summary>
    public string? AppBundleId { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Ignore expiration date for identity tokens.
    /// </summary>
    public bool? IgnoreExpirationDate { get; set; }
    /// <summary>
    /// Require secure authentication only for this app.
    /// </summary>
    public bool? RequireSecureAuthentication { get; set; }
}

public class GetFacebookInstantGamesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetFacebookInstantGamesResponse : PlayFabResultCommon {
    /// <summary>
    /// Facebook App ID obtained after setting up your app in Facebook Instant Games.
    /// </summary>
    public string? AppID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
}

public class GetFacebookRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetFacebookResponse : PlayFabResultCommon {
    /// <summary>
    /// Facebook App ID obtained after setting up your app in Facebook.
    /// </summary>
    public string? AppID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Email address for purchase dispute notifications.
    /// </summary>
    public string? NotificationEmail { get; set; }
}

public class GetGoogleRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetGoogleResponse : PlayFabResultCommon {
    /// <summary>
    /// Google App Package ID obtained after setting up your app in the Google Play developer portal. Required if using Google
    /// receipt validation.
    /// </summary>
    public string? AppPackageID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Google OAuth Client ID obtained through the Google Developer Console by creating a new set of "OAuth Client ID".
    /// Required if using Google Authentication.
    /// </summary>
    public string? OAuthClientID { get; set; }
    /// <summary>
    /// Authorized Redirect Uri obtained through the Google Developer Console. This currently defaults to
    /// https://oauth.playfab.com/oauth2/google. If you are authenticating players via browser, please update this to your own
    /// domain.
    /// </summary>
    public string? OauthCustomRedirectUri { get; set; }
}

public class GetKongregateRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetKongregateResponse : PlayFabResultCommon {
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
}

public class GetNintendoRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetNintendoResponse : PlayFabResultCommon {
    /// <summary>
    /// Nintendo Switch Application ID, without the "0x" prefix.
    /// </summary>
    public string? ApplicationID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// List of Nintendo Environments, currently supporting up to 4.
    /// </summary>
    public List<NintendoEnvironment>? Environments { get; set; }
}

public class GetPSNRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetPSNResponse : PlayFabResultCommon {
    /// <summary>
    /// Client ID obtained after setting up your game with Sony. This one is associated with the existing PS4 marketplace.
    /// </summary>
    public string? ClientID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Client ID obtained after setting up your game with Sony. This one is associated with the modern marketplace, which
    /// includes PS5, cross-generation for PS4, and unified entitlements.
    /// </summary>
    public string? NextGenClientID { get; set; }
}

public class GetSteamRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetSteamResponse : PlayFabResultCommon {
    /// <summary>
    /// Application ID obtained after setting up your game in Valve's developer portal.
    /// </summary>
    public string? ApplicationId { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Enforce usage of AzurePlayFab identity in user authentication tickets.
    /// </summary>
    public bool? EnforceServiceSpecificTickets { get; set; }
    /// <summary>
    /// Use Steam Payments sandbox endpoint for test transactions.
    /// </summary>
    public bool? UseSandbox { get; set; }
}

public class GetToxModRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetToxModResponse : PlayFabResultCommon {
    /// <summary>
    /// Account ID obtained after creating your Twitch developer account.
    /// </summary>
    public string? AccountId { get; set; }
    /// <summary>
    /// Account Key obtained after creating your Twitch developer account.
    /// </summary>
    public string? AccountKey { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
    /// <summary>
    /// Whether the ToxMod Addon is enabled by the title.
    /// </summary>
    public bool Enabled { get; set; }
}

public class GetTwitchRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetTwitchResponse : PlayFabResultCommon {
    /// <summary>
    /// Client ID obtained after creating your Twitch developer account.
    /// </summary>
    public string? ClientID { get; set; }
    /// <summary>
    /// Addon status.
    /// </summary>
    public bool Created { get; set; }
}

public class NintendoEnvironment {
    /// <summary>
    /// Client ID for the Nintendo Environment.
    /// </summary>
    public string? ClientID { get; set; }
    /// <summary>
    /// Client Secret for the Nintendo Environment.
    /// </summary>
    public string? ClientSecret { get; set; }
    /// <summary>
    /// ID for the Nintendo Environment.
    /// </summary>
    public string? ID { get; set; }
}

