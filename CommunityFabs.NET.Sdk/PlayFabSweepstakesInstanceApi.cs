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

    public async Task<PlayFabResult<CreateSweepstakeResponse>> CreateSweepstakeAsync(CreateSweepstakeRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Sweepstakes/CreateSweepstake", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateSweepstakeResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateSweepstakeResponse>>((string)httpResult);
        return new PlayFabResult<CreateSweepstakeResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetSweepstakeResponse>> GetSweepstakeAsync(GetSweepstakeRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Sweepstakes/GetSweepstake", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetSweepstakeResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSweepstakeResponse>>((string)httpResult);
        return new PlayFabResult<GetSweepstakeResponse> { Result = resultData.data };
    }
}