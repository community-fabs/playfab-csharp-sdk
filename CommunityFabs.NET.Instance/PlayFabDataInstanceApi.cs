using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.Data;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the Data API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabDataInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabDataApi {

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
    public async Task<PlayFabResult<AbortFileUploadsResponse>> AbortFileUploadsAsync(AbortFileUploadsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/File/AbortFileUploads", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AbortFileUploadsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AbortFileUploadsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AbortFileUploadsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<DeleteFilesResponse>> DeleteFilesAsync(DeleteFilesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/File/DeleteFiles", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteFilesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteFilesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteFilesResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<FinalizeFileUploadsResponse>> FinalizeFileUploadsAsync(FinalizeFileUploadsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/File/FinalizeFileUploads", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<FinalizeFileUploadsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FinalizeFileUploadsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<FinalizeFileUploadsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetFilesResponse>> GetFilesAsync(GetFilesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/File/GetFiles", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFilesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFilesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFilesResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetObjectsResponse>> GetObjectsAsync(GetObjectsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Object/GetObjects", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetObjectsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetObjectsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetObjectsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<InitiateFileUploadsResponse>> InitiateFileUploadsAsync(InitiateFileUploadsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/File/InitiateFileUploads", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InitiateFileUploadsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InitiateFileUploadsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InitiateFileUploadsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetObjectsResponse>> SetObjectsAsync(SetObjectsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Object/SetObjects", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetObjectsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetObjectsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetObjectsResponse> { Result = result };
    }

}