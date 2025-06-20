using CommunityFabs.NET.Sdk.Models.Events;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabEventsInstanceApi : PlayFabBaseInstanceApi, IPlayFabEventsApi {
    public PlayFabEventsInstanceApi() : base() { }
    public PlayFabEventsInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabEventsInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabEventsInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CreateTelemetryKeyResponse> CreateTelemetryKeyAsync(CreateTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateTelemetryKeyResponse>("/Event/CreateTelemetryKey", request, extraHeaders);
    }
    public async Task<DeleteDataConnectionResponse> DeleteDataConnectionAsync(DeleteDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteDataConnectionResponse>("/Event/DeleteDataConnection", request, extraHeaders);
    }
    public async Task<DeleteEventSamplingRatioResult> DeleteEventSamplingRatioAsync(DeleteEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteEventSamplingRatioResult>("/Event/DeleteEventSamplingRatio", request, extraHeaders);
    }
    public async Task<DeleteTelemetryKeyResponse> DeleteTelemetryKeyAsync(DeleteTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteTelemetryKeyResponse>("/Event/DeleteTelemetryKey", request, extraHeaders);
    }
    public async Task<GetDataConnectionResponse> GetDataConnectionAsync(GetDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetDataConnectionResponse>("/Event/GetDataConnection", request, extraHeaders);
    }
    public async Task<GetEventSamplingRatioResult> GetEventSamplingRatioAsync(GetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEventSamplingRatioResult>("/Event/GetEventSamplingRatio", request, extraHeaders);
    }
    public async Task<GetEventSamplingRatiosResult> GetEventSamplingRatiosAsync(GetEventSamplingRatiosRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEventSamplingRatiosResult>("/Event/GetEventSamplingRatios", request, extraHeaders);
    }
    public async Task<GetTelemetryKeyResponse> GetTelemetryKeyAsync(GetTelemetryKeyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTelemetryKeyResponse>("/Event/GetTelemetryKey", request, extraHeaders);
    }
    public async Task<ListDataConnectionsResponse> ListDataConnectionsAsync(ListDataConnectionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListDataConnectionsResponse>("/Event/ListDataConnections", request, extraHeaders);
    }
    public async Task<ListTelemetryKeysResponse> ListTelemetryKeysAsync(ListTelemetryKeysRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListTelemetryKeysResponse>("/Event/ListTelemetryKeys", request, extraHeaders);
    }
    public async Task<SetDataConnectionResponse> SetDataConnectionAsync(SetDataConnectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetDataConnectionResponse>("/Event/SetDataConnection", request, extraHeaders);
    }
    public async Task<SetDataConnectionActiveResponse> SetDataConnectionActiveAsync(SetDataConnectionActiveRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetDataConnectionActiveResponse>("/Event/SetDataConnectionActive", request, extraHeaders);
    }
    public async Task<SetEventSamplingRatioResult> SetEventSamplingRatioAsync(SetEventSamplingRatioRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetEventSamplingRatioResult>("/Event/SetEventSamplingRatio", request, extraHeaders);
    }
    public async Task<SetTelemetryKeyActiveResponse> SetTelemetryKeyActiveAsync(SetTelemetryKeyActiveRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetTelemetryKeyActiveResponse>("/Event/SetTelemetryKeyActive", request, extraHeaders);
    }
    public async Task<WriteEventsResponse> WriteEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventsResponse>("/Event/WriteEvents", request, extraHeaders);
    }
    public async Task<WriteEventsResponse> WriteTelemetryEventsAsync(WriteEventsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<WriteEventsResponse>("/Event/WriteTelemetryEvents", request, extraHeaders);
    }
}