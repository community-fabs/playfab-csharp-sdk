using CommunityFabs.NET.Sdk.Models.Profiles;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabProfilesInstanceApi : IPlayFabProfilesApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabProfilesInstanceApi() { }

    public PlayFabProfilesInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabProfilesInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabProfilesInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<GetGlobalPolicyResponse>> GetGlobalPolicyAsync(GetGlobalPolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/GetGlobalPolicy", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetGlobalPolicyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetGlobalPolicyResponse>>((string)httpResult);
        return new PlayFabResult<GetGlobalPolicyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetEntityProfileResponse>> GetProfileAsync(GetEntityProfileRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfile", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetEntityProfileResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfileResponse>>((string)httpResult);
        return new PlayFabResult<GetEntityProfileResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetEntityProfilesResponse>> GetProfilesAsync(GetEntityProfilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfiles", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetEntityProfilesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfilesResponse>>((string)httpResult);
        return new PlayFabResult<GetEntityProfilesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>> GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromMasterPlayerAccountIdsResponse>>((string)httpResult);
        return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTitlePlayersFromProviderIDsResponse>> GetTitlePlayersFromXboxLiveIDsAsync(GetTitlePlayersFromXboxLiveIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromXboxLiveIDs", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromProviderIDsResponse>>((string)httpResult);
        return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetAvatarUrlResponse>> SetAvatarUrlAsync(SetAvatarUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/SetAvatarUrl", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetAvatarUrlResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetAvatarUrlResponse>>((string)httpResult);
        return new PlayFabResult<SetAvatarUrlResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetDisplayNameResponse>> SetDisplayNameAsync(SetDisplayNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/SetDisplayName", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetDisplayNameResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDisplayNameResponse>>((string)httpResult);
        return new PlayFabResult<SetDisplayNameResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetGlobalPolicyResponse>> SetGlobalPolicyAsync(SetGlobalPolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/SetGlobalPolicy", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetGlobalPolicyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGlobalPolicyResponse>>((string)httpResult);
        return new PlayFabResult<SetGlobalPolicyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetProfileLanguageResponse>> SetProfileLanguageAsync(SetProfileLanguageRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfileLanguage", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetProfileLanguageResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetProfileLanguageResponse>>((string)httpResult);
        return new PlayFabResult<SetProfileLanguageResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetEntityProfilePolicyResponse>> SetProfilePolicyAsync(SetEntityProfilePolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfilePolicy", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetEntityProfilePolicyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEntityProfilePolicyResponse>>((string)httpResult);
        return new PlayFabResult<SetEntityProfilePolicyResponse> { Result = resultData.data };
    }
}