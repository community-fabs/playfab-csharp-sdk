using CommunityFabs.NET.Sdk.Common;
using CommunityFabs.NET.Sdk.Common.Http;
using CommunityFabs.NET.Sdk.Common.Interfaces;
using CommunityFabs.NET.Sdk.Common.Models;
using CommunityFabs.NET.Sdk.Common.Models.Authentication;
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

    public async Task<PlayFabResult<AuthenticateCustomIdResult>> AuthenticateGameServerWithCustomIdAsync(AuthenticateCustomIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/GameServerIdentity/AuthenticateGameServerWithCustomId", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AuthenticateCustomIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AuthenticateCustomIdResult>>((string)httpResult);
        var result = resultData!.data;
        var updateContext = authenticationContext;
        updateContext.EntityToken = result.EntityToken.EntityToken;
        updateContext.EntityId = result.EntityToken.Entity.Id;
        updateContext.EntityType = result.EntityToken.Entity.Type;

        return new PlayFabResult<AuthenticateCustomIdResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteAsync(DeleteRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/GameServerIdentity/Delete", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetEntityTokenResponse>> GetEntityTokenAsync(GetEntityTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        string authKey = null, authValue = null;
        if (requestContext.ClientSessionTicket != null) { authKey = "X-Authorization"; authValue = requestContext.ClientSessionTicket; }
        if (requestSettings.DeveloperSecretKey != null) { authKey = "X-SecretKey"; authValue = requestSettings.DeveloperSecretKey; }
        if (requestContext.EntityToken != null) { authKey = "X-EntityToken"; authValue = requestContext.EntityToken; }

        var httpResult = await PlayFabHttp.Post("/Authentication/GetEntityToken", request, authKey, authValue, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEntityTokenResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityTokenResponse>>((string)httpResult);
        var result = resultData!.data;
        var updateContext = authenticationContext;
        updateContext.EntityToken = result.EntityToken;
        updateContext.EntityId = result.Entity.Id;
        updateContext.EntityType = result.Entity.Type;

        return new PlayFabResult<GetEntityTokenResponse> { Result = result };
    }
    public async Task<PlayFabResult<ValidateEntityTokenResponse>> ValidateEntityTokenAsync(ValidateEntityTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var entityToken = requestContext?.EntityToken ?? PlayFabSettings.staticPlayer.EntityToken;
        if ((entityToken) == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Authentication/ValidateEntityToken", request, "X-EntityToken", entityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ValidateEntityTokenResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateEntityTokenResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ValidateEntityTokenResponse> { Result = result };
    }
}