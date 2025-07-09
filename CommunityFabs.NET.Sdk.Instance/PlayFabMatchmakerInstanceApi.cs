using CommunityFabs.NET.Sdk.Common;
using CommunityFabs.NET.Sdk.Common.Http;
using CommunityFabs.NET.Sdk.Common.Interfaces;
using CommunityFabs.NET.Sdk.Common.Models;
using CommunityFabs.NET.Sdk.Common.Models.Matchmaker;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk.Instance;

public class PlayFabMatchmakerInstanceApi : IPlayFabMatchmakerApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabMatchmakerInstanceApi() { }

    public PlayFabMatchmakerInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabMatchmakerInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabMatchmakerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<AuthUserResponse>> AuthUserAsync(AuthUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/AuthUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AuthUserResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AuthUserResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AuthUserResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeregisterGameResponse>> DeregisterGameAsync(DeregisterGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/DeregisterGame", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeregisterGameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeregisterGameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeregisterGameResponse> { Result = result };
    }
    public async Task<PlayFabResult<PlayerJoinedResponse>> PlayerJoinedAsync(PlayerJoinedRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/PlayerJoined", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<PlayerJoinedResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<PlayerJoinedResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<PlayerJoinedResponse> { Result = result };
    }
    public async Task<PlayFabResult<PlayerLeftResponse>> PlayerLeftAsync(PlayerLeftRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/PlayerLeft", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<PlayerLeftResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<PlayerLeftResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<PlayerLeftResponse> { Result = result };
    }
    public async Task<PlayFabResult<RegisterGameResponse>> RegisterGameAsync(RegisterGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/RegisterGame", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RegisterGameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RegisterGameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RegisterGameResponse> { Result = result };
    }
    public async Task<PlayFabResult<StartGameResponse>> StartGameAsync(StartGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/StartGame", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<StartGameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<StartGameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<StartGameResponse> { Result = result };
    }
    public async Task<PlayFabResult<UserInfoResponse>> UserInfoAsync(UserInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Matchmaker/UserInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UserInfoResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UserInfoResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UserInfoResponse> { Result = result };
    }
}