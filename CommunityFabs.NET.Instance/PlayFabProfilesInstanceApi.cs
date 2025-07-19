using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.Profiles;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the Profiles API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabProfilesInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabProfilesApi {

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authContext?.ForgetAllCredentials();
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetGlobalPolicyResponse>> GetGlobalPolicyAsync(GetGlobalPolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetGlobalPolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetGlobalPolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetGlobalPolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetGlobalPolicyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetEntityProfileResponse>> GetProfileAsync(GetEntityProfileRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfile", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEntityProfileResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfileResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEntityProfileResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetEntityProfilesResponse>> GetProfilesAsync(GetEntityProfilesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfiles", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEntityProfilesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfilesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEntityProfilesResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>> GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromMasterPlayerAccountIdsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTitlePlayersFromProviderIDsResponse>> GetTitlePlayersFromXboxLiveIDsAsync(GetTitlePlayersFromXboxLiveIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromXboxLiveIDs", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromProviderIDsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetAvatarUrlResponse>> SetAvatarUrlAsync(SetAvatarUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetAvatarUrl", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetAvatarUrlResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetAvatarUrlResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetAvatarUrlResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetDisplayNameResponse>> SetDisplayNameAsync(SetDisplayNameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetDisplayName", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetDisplayNameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDisplayNameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetDisplayNameResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetGlobalPolicyResponse>> SetGlobalPolicyAsync(SetGlobalPolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetGlobalPolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetGlobalPolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGlobalPolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetGlobalPolicyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetProfileLanguageResponse>> SetProfileLanguageAsync(SetProfileLanguageRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfileLanguage", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetProfileLanguageResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetProfileLanguageResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetProfileLanguageResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetEntityProfilePolicyResponse>> SetProfilePolicyAsync(SetEntityProfilePolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfilePolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetEntityProfilePolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEntityProfilePolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetEntityProfilePolicyResponse> { Result = result };
    }

}