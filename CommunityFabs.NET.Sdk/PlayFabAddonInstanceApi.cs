using CommunityFabs.NET.Sdk.Models.Addon;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabAddonInstanceApi : IPlayFabAddonApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabAddonInstanceApi() { }

    public PlayFabAddonInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabAddonInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabAddonInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
    {
        apiSettings = settings;
        authenticationContext = context;
    }

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authenticationContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authenticationContext?.ForgetAllCredentials();
    }

    public async Task<PlayFabResult<CreateOrUpdateAppleResponse>> CreateOrUpdateAppleAsync(CreateOrUpdateAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateApple", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateAppleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateAppleResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateAppleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateFacebookResponse>> CreateOrUpdateFacebookAsync(CreateOrUpdateFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateFacebook", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateFacebookResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateFacebookResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateFacebookResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateFacebookInstantGamesResponse>> CreateOrUpdateFacebookInstantGamesAsync(CreateOrUpdateFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateFacebookInstantGames", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateFacebookInstantGamesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateFacebookInstantGamesResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateFacebookInstantGamesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateGoogleResponse>> CreateOrUpdateGoogleAsync(CreateOrUpdateGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateGoogle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateGoogleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateGoogleResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateGoogleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateKongregateResponse>> CreateOrUpdateKongregateAsync(CreateOrUpdateKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateKongregate", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateKongregateResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateKongregateResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateKongregateResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateNintendoResponse>> CreateOrUpdateNintendoAsync(CreateOrUpdateNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateNintendo", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateNintendoResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateNintendoResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateNintendoResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdatePSNResponse>> CreateOrUpdatePSNAsync(CreateOrUpdatePSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdatePSN", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdatePSNResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdatePSNResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdatePSNResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateSteamResponse>> CreateOrUpdateSteamAsync(CreateOrUpdateSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateSteam", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateSteamResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateSteamResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateSteamResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateToxModResponse>> CreateOrUpdateToxModAsync(CreateOrUpdateToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateToxMod", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateToxModResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateToxModResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateToxModResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateOrUpdateTwitchResponse>> CreateOrUpdateTwitchAsync(CreateOrUpdateTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/CreateOrUpdateTwitch", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateOrUpdateTwitchResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateOrUpdateTwitchResponse>>((string)httpResult);
        return new PlayFabResult<CreateOrUpdateTwitchResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteAppleResponse>> DeleteAppleAsync(DeleteAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteApple", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteAppleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteAppleResponse>>((string)httpResult);
        return new PlayFabResult<DeleteAppleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteFacebookResponse>> DeleteFacebookAsync(DeleteFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteFacebook", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteFacebookResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteFacebookResponse>>((string)httpResult);
        return new PlayFabResult<DeleteFacebookResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteFacebookInstantGamesResponse>> DeleteFacebookInstantGamesAsync(DeleteFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteFacebookInstantGames", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteFacebookInstantGamesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteFacebookInstantGamesResponse>>((string)httpResult);
        return new PlayFabResult<DeleteFacebookInstantGamesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteGoogleResponse>> DeleteGoogleAsync(DeleteGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteGoogle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteGoogleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteGoogleResponse>>((string)httpResult);
        return new PlayFabResult<DeleteGoogleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteKongregateResponse>> DeleteKongregateAsync(DeleteKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteKongregate", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteKongregateResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteKongregateResponse>>((string)httpResult);
        return new PlayFabResult<DeleteKongregateResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteNintendoResponse>> DeleteNintendoAsync(DeleteNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteNintendo", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteNintendoResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteNintendoResponse>>((string)httpResult);
        return new PlayFabResult<DeleteNintendoResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeletePSNResponse>> DeletePSNAsync(DeletePSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeletePSN", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeletePSNResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePSNResponse>>((string)httpResult);
        return new PlayFabResult<DeletePSNResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteSteamResponse>> DeleteSteamAsync(DeleteSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteSteam", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteSteamResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteSteamResponse>>((string)httpResult);
        return new PlayFabResult<DeleteSteamResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteToxModResponse>> DeleteToxModAsync(DeleteToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteToxMod", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteToxModResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteToxModResponse>>((string)httpResult);
        return new PlayFabResult<DeleteToxModResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteTwitchResponse>> DeleteTwitchAsync(DeleteTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/DeleteTwitch", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteTwitchResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteTwitchResponse>>((string)httpResult);
        return new PlayFabResult<DeleteTwitchResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetAppleResponse>> GetAppleAsync(GetAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetApple", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetAppleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAppleResponse>>((string)httpResult);
        return new PlayFabResult<GetAppleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetFacebookResponse>> GetFacebookAsync(GetFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetFacebook", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetFacebookResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFacebookResponse>>((string)httpResult);
        return new PlayFabResult<GetFacebookResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetFacebookInstantGamesResponse>> GetFacebookInstantGamesAsync(GetFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetFacebookInstantGames", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetFacebookInstantGamesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFacebookInstantGamesResponse>>((string)httpResult);
        return new PlayFabResult<GetFacebookInstantGamesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetGoogleResponse>> GetGoogleAsync(GetGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetGoogle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetGoogleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetGoogleResponse>>((string)httpResult);
        return new PlayFabResult<GetGoogleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetKongregateResponse>> GetKongregateAsync(GetKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetKongregate", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetKongregateResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetKongregateResponse>>((string)httpResult);
        return new PlayFabResult<GetKongregateResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetNintendoResponse>> GetNintendoAsync(GetNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetNintendo", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetNintendoResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetNintendoResponse>>((string)httpResult);
        return new PlayFabResult<GetNintendoResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetPSNResponse>> GetPSNAsync(GetPSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetPSN", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetPSNResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPSNResponse>>((string)httpResult);
        return new PlayFabResult<GetPSNResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetSteamResponse>> GetSteamAsync(GetSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetSteam", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetSteamResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSteamResponse>>((string)httpResult);
        return new PlayFabResult<GetSteamResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetToxModResponse>> GetToxModAsync(GetToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetToxMod", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetToxModResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetToxModResponse>>((string)httpResult);
        return new PlayFabResult<GetToxModResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTwitchResponse>> GetTwitchAsync(GetTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Addon/GetTwitch", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTwitchResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTwitchResponse>>((string)httpResult);
        return new PlayFabResult<GetTwitchResponse> { Result = resultData.data };
    }
}