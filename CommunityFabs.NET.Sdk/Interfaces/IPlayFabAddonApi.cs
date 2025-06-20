using CommunityFabs.NET.Sdk.Models.Addon;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabAddonApi {
    /// <summary>
    /// Creates the Apple addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateAppleAsync({);
    ///   "AppBundleId": "123456",
    ///   "AppSharedSecret": "654321",
    ///   "RequireSecureAuthentication": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdateapple">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateAppleResponse> CreateOrUpdateAppleAsync(CreateOrUpdateAppleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Facebook addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateFacebookAsync({);
    ///   "AppID": "123456",
    ///   "AppSecret": "654321",
    ///   "NotificationEmail": "user@example.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatefacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateFacebookResponse> CreateOrUpdateFacebookAsync(CreateOrUpdateFacebookRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Facebook Instant Games addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateFacebookInstantGamesAsync({);
    ///   "AppID": "123456",
    ///   "AppSecret": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatefacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateFacebookInstantGamesResponse> CreateOrUpdateFacebookInstantGamesAsync(CreateOrUpdateFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Google addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateGoogleAsync({);
    ///   "AppPackageID": "abcdef",
    ///   "AppLicenseKey": "fedcba",
    ///   "OAuthClientID": "123456",
    ///   "OAuthClientSecret": "654321",
    ///   "OAuthCustomRedirectUri": "https://yourdomaingoeshere.com"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdategoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateGoogleResponse> CreateOrUpdateGoogleAsync(CreateOrUpdateGoogleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Kongregate addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateKongregateAsync({);
    ///   "SecretAPIKey": "123456"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatekongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateKongregateResponse> CreateOrUpdateKongregateAsync(CreateOrUpdateKongregateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Nintendo addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateNintendoAsync({);
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
    public Task<CreateOrUpdateNintendoResponse> CreateOrUpdateNintendoAsync(CreateOrUpdateNintendoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the PSN addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdatePSNAsync({);
    ///   "ClientID": "123456",
    ///   "ClientSecret": "abcdef",
    ///   "NextGenClientID": "654321",
    ///   "NextGenClientSecret": "fedcba"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatepsn">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdatePSNResponse> CreateOrUpdatePSNAsync(CreateOrUpdatePSNRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Steam addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateSteamAsync({);
    ///   "ApplicationId": "123456",
    ///   "SecretKey": "654321",
    ///   "UseSandbox": true,
    ///   "EnforceServiceSpecificTickets": true
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatesteam">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateSteamResponse> CreateOrUpdateSteamAsync(CreateOrUpdateSteamRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the ToxMod addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateToxModAsync({);
    ///   "Enabled": false,
    ///   "AccountId": "123456",
    ///   "AccountKey": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatetoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateToxModResponse> CreateOrUpdateToxModAsync(CreateOrUpdateToxModRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates the Twitch addon on a title, or updates it if it already exists.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.CreateOrUpdateTwitchAsync({);
    ///   "ClientID": "123456",
    ///   "ClientSecret": "654321"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/createorupdatetwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateOrUpdateTwitchResponse> CreateOrUpdateTwitchAsync(CreateOrUpdateTwitchRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Apple addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteAppleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deleteapple">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteAppleResponse> DeleteAppleAsync(DeleteAppleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Facebook addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteFacebookAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletefacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteFacebookResponse> DeleteFacebookAsync(DeleteFacebookRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Facebook addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteFacebookInstantGamesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletefacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteFacebookInstantGamesResponse> DeleteFacebookInstantGamesAsync(DeleteFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Google addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteGoogleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletegoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteGoogleResponse> DeleteGoogleAsync(DeleteGoogleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Kongregate addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteKongregateAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletekongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteKongregateResponse> DeleteKongregateAsync(DeleteKongregateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Nintendo addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteNintendoAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletenintendo">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteNintendoResponse> DeleteNintendoAsync(DeleteNintendoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the PSN addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeletePSNAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletepsn">Microsoft Documentation</see>
    /// </summary>
    public Task<DeletePSNResponse> DeletePSNAsync(DeletePSNRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Steam addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteSteamAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletesteam">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteSteamResponse> DeleteSteamAsync(DeleteSteamRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the ToxMod addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteToxModAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletetoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteToxModResponse> DeleteToxModAsync(DeleteToxModRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes the Twitch addon on a title.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.DeleteTwitchAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/deletetwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteTwitchResponse> DeleteTwitchAsync(DeleteTwitchRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Apple addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetAppleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getapple">Microsoft Documentation</see>
    /// </summary>
    public Task<GetAppleResponse> GetAppleAsync(GetAppleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Facebook addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetFacebookAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getfacebook">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFacebookResponse> GetFacebookAsync(GetFacebookRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Facebook Instant Games addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetFacebookInstantGamesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getfacebookinstantgames">Microsoft Documentation</see>
    /// </summary>
    public Task<GetFacebookInstantGamesResponse> GetFacebookInstantGamesAsync(GetFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Google addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetGoogleAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getgoogle">Microsoft Documentation</see>
    /// </summary>
    public Task<GetGoogleResponse> GetGoogleAsync(GetGoogleRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Kongregate addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetKongregateAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getkongregate">Microsoft Documentation</see>
    /// </summary>
    public Task<GetKongregateResponse> GetKongregateAsync(GetKongregateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Nintendo addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetNintendoAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getnintendo">Microsoft Documentation</see>
    /// </summary>
    public Task<GetNintendoResponse> GetNintendoAsync(GetNintendoRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the PSN addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetPSNAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getpsn">Microsoft Documentation</see>
    /// </summary>
    public Task<GetPSNResponse> GetPSNAsync(GetPSNRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Steam addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetSteamAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/getsteam">Microsoft Documentation</see>
    /// </summary>
    public Task<GetSteamResponse> GetSteamAsync(GetSteamRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the ToxMod addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetToxModAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/gettoxmod">Microsoft Documentation</see>
    /// </summary>
    public Task<GetToxModResponse> GetToxModAsync(GetToxModRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets information of the Twitch addon on a title, omits secrets.
    /// <example><br/>Example:<code>
    /// var response = await addonApi.GetTwitchAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/addon/addon/gettwitch">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTwitchResponse> GetTwitchAsync(GetTwitchRequest request, Dictionary<string, string>? extraHeaders);
}