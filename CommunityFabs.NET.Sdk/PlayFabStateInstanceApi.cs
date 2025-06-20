using CommunityFabs.NET.Sdk.Models.State;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabStateInstanceApi : PlayFabBaseInstanceApi, IPlayFabStateApi {
    public PlayFabStateInstanceApi() : base() { }
    public PlayFabStateInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabStateInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabStateInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CreateLinkResponse> CreateLinkForStateAsync(CreateLinkRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateLinkResponse>("/StateShare/CreateLinkForState", request, extraHeaders);
    }
    public async Task<CreateStateResponse> CreateStateAsync(CreateStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateStateResponse>("/StateShare/CreateState", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteLinkForStateAsync(DeleteLinkRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/StateShare/DeleteLinkForState", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteStateAsync(DeleteStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/StateShare/DeleteState", request, extraHeaders);
    }
    public async Task<GetLinkMetadataResponse> GetLinkMetadataAsync(GetLinkMetadataRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLinkMetadataResponse>("/StateShare/GetLinkMetadata", request, extraHeaders);
    }
    public async Task<GetStateResponse> GetStateAsync(GetStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetStateResponse>("/StateShare/GetState", request, extraHeaders);
    }
    public async Task<ListStateIdsResponse> ListStateIdsAsync(ListStateIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListStateIdsResponse>("/StateShare/ListStateIds", request, extraHeaders);
    }
}