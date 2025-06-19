using CommunityFabs.NET.Sdk.Models.Addon;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabAddonApi {
    /// <summary>
    /// Creates the Apple addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateAppleAsync({);
    ///   "AppBundleId": "123456",
    ///   "AppSharedSecret": "654321",
    ///   "RequireSecureAuthentication": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdateapple">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateAppleResponse> CreateOrUpdateAppleAsync(CreateOrUpdateAppleRequest request);
    /// <summary>
    /// Creates the Facebook addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateFacebookAsync({);
    ///   "AppID": "123456",
    ///   "AppSecret": "654321",
    ///   "NotificationEmail": "user@example.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatefacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateFacebookResponse> CreateOrUpdateFacebookAsync(CreateOrUpdateFacebookRequest request);
    /// <summary>
    /// Creates the Facebook Instant Games addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateFacebookInstantGamesAsync({);
    ///   "AppID": "123456",
    ///   "AppSecret": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatefacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateFacebookInstantGamesResponse> CreateOrUpdateFacebookInstantGamesAsync(CreateOrUpdateFacebookInstantGamesRequest request);
    /// <summary>
    /// Creates the Google addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateGoogleAsync({);
    ///   "AppPackageID": "abcdef",
    ///   "AppLicenseKey": "fedcba",
    ///   "OAuthClientID": "123456",
    ///   "OAuthClientSecret": "654321",
    ///   "OAuthCustomRedirectUri": "https://yourdomaingoeshere.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdategoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateGoogleResponse> CreateOrUpdateGoogleAsync(CreateOrUpdateGoogleRequest request);
    /// <summary>
    /// Creates the Kongregate addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateKongregateAsync({);
    ///   "SecretAPIKey": "123456"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatekongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateKongregateResponse> CreateOrUpdateKongregateAsync(CreateOrUpdateKongregateRequest request);
    /// <summary>
    /// Creates the Nintendo addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateNintendoAsync({);
    ///   "ApplicationID": "123456",
    ///   "Environments": [
    ///     {
    ///       "ID": "1",
    ///       "ClientID": "123456",
    ///       "ClientSecret": "654321"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatenintendo">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateNintendoResponse> CreateOrUpdateNintendoAsync(CreateOrUpdateNintendoRequest request);
    /// <summary>
    /// Creates the PSN addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdatePSNAsync({);
    ///   "ClientID": "123456",
    ///   "ClientSecret": "abcdef",
    ///   "NextGenClientID": "654321",
    ///   "NextGenClientSecret": "fedcba"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatepsn">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdatePSNResponse> CreateOrUpdatePSNAsync(CreateOrUpdatePSNRequest request);
    /// <summary>
    /// Creates the Steam addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateSteamAsync({);
    ///   "ApplicationId": "123456",
    ///   "SecretKey": "654321",
    ///   "UseSandbox": true,
    ///   "EnforceServiceSpecificTickets": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatesteam">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateSteamResponse> CreateOrUpdateSteamAsync(CreateOrUpdateSteamRequest request);
    /// <summary>
    /// Creates the ToxMod addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateToxModAsync({);
    ///   "Enabled": false,
    ///   "AccountId": "123456",
    ///   "AccountKey": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatetoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateToxModResponse> CreateOrUpdateToxModAsync(CreateOrUpdateToxModRequest request);
    /// <summary>
    /// Creates the Twitch addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = addonApi.CreateOrUpdateTwitchAsync({);
    ///   "ClientID": "123456",
    ///   "ClientSecret": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatetwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateTwitchResponse> CreateOrUpdateTwitchAsync(CreateOrUpdateTwitchRequest request);
    /// <summary>
    /// Deletes the Apple addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteAppleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deleteapple">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteAppleResponse> DeleteAppleAsync(DeleteAppleRequest request);
    /// <summary>
    /// Deletes the Facebook addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteFacebookAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletefacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteFacebookResponse> DeleteFacebookAsync(DeleteFacebookRequest request);
    /// <summary>
    /// Deletes the Facebook addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteFacebookInstantGamesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletefacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteFacebookInstantGamesResponse> DeleteFacebookInstantGamesAsync(DeleteFacebookInstantGamesRequest request);
    /// <summary>
    /// Deletes the Google addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteGoogleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletegoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteGoogleResponse> DeleteGoogleAsync(DeleteGoogleRequest request);
    /// <summary>
    /// Deletes the Kongregate addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteKongregateAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletekongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteKongregateResponse> DeleteKongregateAsync(DeleteKongregateRequest request);
    /// <summary>
    /// Deletes the Nintendo addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteNintendoAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletenintendo">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteNintendoResponse> DeleteNintendoAsync(DeleteNintendoRequest request);
    /// <summary>
    /// Deletes the PSN addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeletePSNAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletepsn">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePSNResponse> DeletePSNAsync(DeletePSNRequest request);
    /// <summary>
    /// Deletes the Steam addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteSteamAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletesteam">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteSteamResponse> DeleteSteamAsync(DeleteSteamRequest request);
    /// <summary>
    /// Deletes the ToxMod addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteToxModAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletetoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteToxModResponse> DeleteToxModAsync(DeleteToxModRequest request);
    /// <summary>
    /// Deletes the Twitch addon on a title.
    /// <example><br/>Example:<code>
    /// var response = addonApi.DeleteTwitchAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletetwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteTwitchResponse> DeleteTwitchAsync(DeleteTwitchRequest request);
    /// <summary>
    /// Gets information of the Apple addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetAppleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getapple">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAppleResponse> GetAppleAsync(GetAppleRequest request);
    /// <summary>
    /// Gets information of the Facebook addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetFacebookAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getfacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFacebookResponse> GetFacebookAsync(GetFacebookRequest request);
    /// <summary>
    /// Gets information of the Facebook Instant Games addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetFacebookInstantGamesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getfacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFacebookInstantGamesResponse> GetFacebookInstantGamesAsync(GetFacebookInstantGamesRequest request);
    /// <summary>
    /// Gets information of the Google addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetGoogleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getgoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<GetGoogleResponse> GetGoogleAsync(GetGoogleRequest request);
    /// <summary>
    /// Gets information of the Kongregate addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetKongregateAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getkongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<GetKongregateResponse> GetKongregateAsync(GetKongregateRequest request);
    /// <summary>
    /// Gets information of the Nintendo addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetNintendoAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getnintendo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetNintendoResponse> GetNintendoAsync(GetNintendoRequest request);
    /// <summary>
    /// Gets information of the PSN addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetPSNAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getpsn">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPSNResponse> GetPSNAsync(GetPSNRequest request);
    /// <summary>
    /// Gets information of the Steam addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetSteamAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getsteam">Microsoft Documentation</see>
    /// </summary>
    public Task<GetSteamResponse> GetSteamAsync(GetSteamRequest request);
    /// <summary>
    /// Gets information of the ToxMod addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetToxModAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/gettoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<GetToxModResponse> GetToxModAsync(GetToxModRequest request);
    /// <summary>
    /// Gets information of the Twitch addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = addonApi.GetTwitchAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/gettwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTwitchResponse> GetTwitchAsync(GetTwitchRequest request);
}