using CommunityFabs.NET.Sdk.Models.Events;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabEventsInstanceApi : IPlayFabEventsApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabEventsInstanceApi() { }

    public PlayFabEventsInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabEventsInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabEventsInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<CreateTelemetryKeyResponse>> CreateTelemetryKeyAsync(CreateTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/CreateTelemetryKey", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateTelemetryKeyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTelemetryKeyResponse>>((string)httpResult);
        return new PlayFabResult<CreateTelemetryKeyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteDataConnectionResponse>> DeleteDataConnectionAsync(DeleteDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/DeleteDataConnection", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteDataConnectionResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteDataConnectionResponse>>((string)httpResult);
        return new PlayFabResult<DeleteDataConnectionResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteEventSamplingRatioResult>> DeleteEventSamplingRatioAsync(DeleteEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/DeleteEventSamplingRatio", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteEventSamplingRatioResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteEventSamplingRatioResult>>((string)httpResult);
        return new PlayFabResult<DeleteEventSamplingRatioResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteTelemetryKeyResponse>> DeleteTelemetryKeyAsync(DeleteTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/DeleteTelemetryKey", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteTelemetryKeyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteTelemetryKeyResponse>>((string)httpResult);
        return new PlayFabResult<DeleteTelemetryKeyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetDataConnectionResponse>> GetDataConnectionAsync(GetDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/GetDataConnection", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetDataConnectionResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetDataConnectionResponse>>((string)httpResult);
        return new PlayFabResult<GetDataConnectionResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetEventSamplingRatioResult>> GetEventSamplingRatioAsync(GetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/GetEventSamplingRatio", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetEventSamplingRatioResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEventSamplingRatioResult>>((string)httpResult);
        return new PlayFabResult<GetEventSamplingRatioResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetEventSamplingRatiosResult>> GetEventSamplingRatiosAsync(GetEventSamplingRatiosRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/GetEventSamplingRatios", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetEventSamplingRatiosResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEventSamplingRatiosResult>>((string)httpResult);
        return new PlayFabResult<GetEventSamplingRatiosResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTelemetryKeyResponse>> GetTelemetryKeyAsync(GetTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/GetTelemetryKey", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTelemetryKeyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTelemetryKeyResponse>>((string)httpResult);
        return new PlayFabResult<GetTelemetryKeyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListDataConnectionsResponse>> ListDataConnectionsAsync(ListDataConnectionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/ListDataConnections", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListDataConnectionsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListDataConnectionsResponse>>((string)httpResult);
        return new PlayFabResult<ListDataConnectionsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListTelemetryKeysResponse>> ListTelemetryKeysAsync(ListTelemetryKeysRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/ListTelemetryKeys", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListTelemetryKeysResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListTelemetryKeysResponse>>((string)httpResult);
        return new PlayFabResult<ListTelemetryKeysResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetDataConnectionResponse>> SetDataConnectionAsync(SetDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/SetDataConnection", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetDataConnectionResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDataConnectionResponse>>((string)httpResult);
        return new PlayFabResult<SetDataConnectionResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetDataConnectionActiveResponse>> SetDataConnectionActiveAsync(SetDataConnectionActiveRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/SetDataConnectionActive", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetDataConnectionActiveResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDataConnectionActiveResponse>>((string)httpResult);
        return new PlayFabResult<SetDataConnectionActiveResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetEventSamplingRatioResult>> SetEventSamplingRatioAsync(SetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/SetEventSamplingRatio", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetEventSamplingRatioResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEventSamplingRatioResult>>((string)httpResult);
        return new PlayFabResult<SetEventSamplingRatioResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetTelemetryKeyActiveResponse>> SetTelemetryKeyActiveAsync(SetTelemetryKeyActiveRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/SetTelemetryKeyActive", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetTelemetryKeyActiveResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTelemetryKeyActiveResponse>>((string)httpResult);
        return new PlayFabResult<SetTelemetryKeyActiveResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<WriteEventsResponse>> WriteEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/WriteEvents", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<WriteEventsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventsResponse>>((string)httpResult);
        return new PlayFabResult<WriteEventsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<WriteEventsResponse>> WriteTelemetryEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Event/WriteTelemetryEvents", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<WriteEventsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventsResponse>>((string)httpResult);
        return new PlayFabResult<WriteEventsResponse> { Result = resultData.data };
    }
}