using CommunityFabs.NET.Sdk.Models.Authentication;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabAuthenticationInstanceApi : IPlayFabAuthenticationApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabAuthenticationInstanceApi() { }

    public PlayFabAuthenticationInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabAuthenticationInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabAuthenticationInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<AuthenticateCustomIdResult>> AuthenticateGameServerWithCustomIdAsync(AuthenticateCustomIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/GameServerIdentity/AuthenticateGameServerWithCustomId", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<AuthenticateCustomIdResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AuthenticateCustomIdResult>>((string)httpResult);
        return new PlayFabResult<AuthenticateCustomIdResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteAsync(DeleteRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/GameServerIdentity/Delete", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetEntityTokenResponse>> GetEntityTokenAsync(GetEntityTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Authentication/GetEntityToken", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetEntityTokenResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityTokenResponse>>((string)httpResult);
        return new PlayFabResult<GetEntityTokenResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ValidateEntityTokenResponse>> ValidateEntityTokenAsync(ValidateEntityTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Authentication/ValidateEntityToken", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ValidateEntityTokenResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateEntityTokenResponse>>((string)httpResult);
        return new PlayFabResult<ValidateEntityTokenResponse> { Result = resultData.data };
    }
}