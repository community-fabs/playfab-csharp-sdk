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

    public async Task<PlayFabResult<CreateTelemetryKeyResponse>> CreateTelemetryKeyAsync(CreateTelemetryKeyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/CreateTelemetryKey", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTelemetryKeyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTelemetryKeyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTelemetryKeyResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteDataConnectionResponse>> DeleteDataConnectionAsync(DeleteDataConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/DeleteDataConnection", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteDataConnectionResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteDataConnectionResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteDataConnectionResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteEventSamplingRatioResult>> DeleteEventSamplingRatioAsync(DeleteEventSamplingRatioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/DeleteEventSamplingRatio", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteEventSamplingRatioResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteEventSamplingRatioResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteEventSamplingRatioResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteTelemetryKeyResponse>> DeleteTelemetryKeyAsync(DeleteTelemetryKeyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/DeleteTelemetryKey", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteTelemetryKeyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteTelemetryKeyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteTelemetryKeyResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetDataConnectionResponse>> GetDataConnectionAsync(GetDataConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/GetDataConnection", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetDataConnectionResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetDataConnectionResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetDataConnectionResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetEventSamplingRatioResult>> GetEventSamplingRatioAsync(GetEventSamplingRatioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/GetEventSamplingRatio", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEventSamplingRatioResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEventSamplingRatioResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEventSamplingRatioResult> { Result = result };
    }
    public async Task<PlayFabResult<GetEventSamplingRatiosResult>> GetEventSamplingRatiosAsync(GetEventSamplingRatiosRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/GetEventSamplingRatios", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEventSamplingRatiosResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEventSamplingRatiosResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEventSamplingRatiosResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTelemetryKeyResponse>> GetTelemetryKeyAsync(GetTelemetryKeyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/GetTelemetryKey", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTelemetryKeyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTelemetryKeyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTelemetryKeyResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListDataConnectionsResponse>> ListDataConnectionsAsync(ListDataConnectionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/ListDataConnections", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListDataConnectionsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListDataConnectionsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListDataConnectionsResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListTelemetryKeysResponse>> ListTelemetryKeysAsync(ListTelemetryKeysRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/ListTelemetryKeys", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListTelemetryKeysResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListTelemetryKeysResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListTelemetryKeysResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetDataConnectionResponse>> SetDataConnectionAsync(SetDataConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/SetDataConnection", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetDataConnectionResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDataConnectionResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetDataConnectionResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetDataConnectionActiveResponse>> SetDataConnectionActiveAsync(SetDataConnectionActiveRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/SetDataConnectionActive", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetDataConnectionActiveResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetDataConnectionActiveResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetDataConnectionActiveResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetEventSamplingRatioResult>> SetEventSamplingRatioAsync(SetEventSamplingRatioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/SetEventSamplingRatio", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetEventSamplingRatioResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEventSamplingRatioResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetEventSamplingRatioResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTelemetryKeyActiveResponse>> SetTelemetryKeyActiveAsync(SetTelemetryKeyActiveRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/SetTelemetryKeyActive", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTelemetryKeyActiveResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTelemetryKeyActiveResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTelemetryKeyActiveResponse> { Result = result };
    }
    public async Task<PlayFabResult<WriteEventsResponse>> WriteEventsAsync(WriteEventsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/WriteEvents", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventsResponse> { Result = result };
    }
    public async Task<PlayFabResult<WriteEventsResponse>> WriteTelemetryEventsAsync(WriteEventsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Event/WriteTelemetryEvents", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventsResponse> { Result = result };
    }
}