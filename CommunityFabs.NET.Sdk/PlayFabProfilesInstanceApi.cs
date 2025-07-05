using CommunityFabs.NET.Sdk.Common;
using CommunityFabs.NET.Sdk.Common.Http;
using CommunityFabs.NET.Sdk.Common.Interfaces;
using CommunityFabs.NET.Sdk.Common.Models;
using CommunityFabs.NET.Sdk.Common.Models.Profiles;
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

    public async Task<PlayFabResult<GetGlobalPolicyResponse>> GetGlobalPolicyAsync(GetGlobalPolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetGlobalPolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetGlobalPolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetGlobalPolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetGlobalPolicyResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetEntityProfileResponse>> GetProfileAsync(GetEntityProfileRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfile", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEntityProfileResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfileResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEntityProfileResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetEntityProfilesResponse>> GetProfilesAsync(GetEntityProfilesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetProfiles", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEntityProfilesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEntityProfilesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEntityProfilesResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse>> GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromMasterPlayerAccountIdsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitlePlayersFromMasterPlayerAccountIdsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetTitlePlayersFromProviderIDsResponse>> GetTitlePlayersFromXboxLiveIDsAsync(GetTitlePlayersFromXboxLiveIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/GetTitlePlayersFromXboxLiveIDs", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePlayersFromProviderIDsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitlePlayersFromProviderIDsResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetAvatarUrlResponse>> SetAvatarUrlAsync(SetAvatarUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetAvatarUrl", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetAvatarUrlResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetAvatarUrlResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetAvatarUrlResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetDisplayNameResponse>> SetDisplayNameAsync(SetDisplayNameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetDisplayName", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetDisplayNameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDisplayNameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetDisplayNameResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetGlobalPolicyResponse>> SetGlobalPolicyAsync(SetGlobalPolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetGlobalPolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetGlobalPolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGlobalPolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetGlobalPolicyResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetProfileLanguageResponse>> SetProfileLanguageAsync(SetProfileLanguageRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfileLanguage", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetProfileLanguageResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetProfileLanguageResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetProfileLanguageResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetEntityProfilePolicyResponse>> SetProfilePolicyAsync(SetEntityProfilePolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Profile/SetProfilePolicy", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetEntityProfilePolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEntityProfilePolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetEntityProfilePolicyResponse> { Result = result };
    }
}