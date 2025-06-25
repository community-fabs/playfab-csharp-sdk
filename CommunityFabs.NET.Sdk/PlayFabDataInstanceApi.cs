using CommunityFabs.NET.Sdk.Models.Data;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabDataInstanceApi : IPlayFabDataApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabDataInstanceApi() { }

    public PlayFabDataInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabDataInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabDataInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<AbortFileUploadsResponse>> AbortFileUploadsAsync(AbortFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/File/AbortFileUploads", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<AbortFileUploadsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AbortFileUploadsResponse>>((string)httpResult);
        return new PlayFabResult<AbortFileUploadsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteFilesResponse>> DeleteFilesAsync(DeleteFilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/File/DeleteFiles", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteFilesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteFilesResponse>>((string)httpResult);
        return new PlayFabResult<DeleteFilesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<FinalizeFileUploadsResponse>> FinalizeFileUploadsAsync(FinalizeFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/File/FinalizeFileUploads", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<FinalizeFileUploadsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FinalizeFileUploadsResponse>>((string)httpResult);
        return new PlayFabResult<FinalizeFileUploadsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetFilesResponse>> GetFilesAsync(GetFilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/File/GetFiles", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetFilesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFilesResponse>>((string)httpResult);
        return new PlayFabResult<GetFilesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetObjectsResponse>> GetObjectsAsync(GetObjectsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Object/GetObjects", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetObjectsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetObjectsResponse>>((string)httpResult);
        return new PlayFabResult<GetObjectsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<InitiateFileUploadsResponse>> InitiateFileUploadsAsync(InitiateFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/File/InitiateFileUploads", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<InitiateFileUploadsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InitiateFileUploadsResponse>>((string)httpResult);
        return new PlayFabResult<InitiateFileUploadsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetObjectsResponse>> SetObjectsAsync(SetObjectsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Object/SetObjects", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetObjectsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetObjectsResponse>>((string)httpResult);
        return new PlayFabResult<SetObjectsResponse> { Result = resultData.data };
    }
}