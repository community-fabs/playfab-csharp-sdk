using CommunityFabs.NET.Sdk.Models.State;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabStateInstanceApi : IPlayFabStateApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabStateInstanceApi() { }

    public PlayFabStateInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabStateInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabStateInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<CreateLinkResponse>> CreateLinkForStateAsync(CreateLinkRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/CreateLinkForState", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateLinkResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateLinkResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateLinkResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateStateResponse>> CreateStateAsync(CreateStateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/CreateState", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateStateResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateStateResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateStateResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteLinkForStateAsync(DeleteLinkRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/DeleteLinkForState", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteStateAsync(DeleteStateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/DeleteState", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetLinkMetadataResponse>> GetLinkMetadataAsync(GetLinkMetadataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/GetLinkMetadata", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLinkMetadataResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLinkMetadataResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLinkMetadataResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetStateResponse>> GetStateAsync(GetStateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/GetState", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetStateResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetStateResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetStateResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListStateIdsResponse>> ListStateIdsAsync(ListStateIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/StateShare/ListStateIds", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListStateIdsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListStateIdsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListStateIdsResponse> { Result = result };
    }
}