using CommunityFabs.NET.Sdk.Models.Sweepstakes;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabSweepstakesInstanceApi : IPlayFabSweepstakesApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabSweepstakesInstanceApi() { }

    public PlayFabSweepstakesInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabSweepstakesInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabSweepstakesInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<CreateSweepstakeResponse>> CreateSweepstakeAsync(CreateSweepstakeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Sweepstakes/CreateSweepstake", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateSweepstakeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateSweepstakeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateSweepstakeResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetSweepstakeResponse>> GetSweepstakeAsync(GetSweepstakeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Sweepstakes/GetSweepstake", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetSweepstakeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSweepstakeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetSweepstakeResponse> { Result = result };
    }
}