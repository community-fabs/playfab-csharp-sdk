using CommunityFabs.NET.Sdk.Models.Data;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabDataInstanceApi : PlayFabBaseInstanceApi, IPlayFabDataApi {
    public PlayFabDataInstanceApi() : base() { }
    public PlayFabDataInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabDataInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabDataInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<AbortFileUploadsResponse> AbortFileUploadsAsync(AbortFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AbortFileUploadsResponse>("/File/AbortFileUploads", request, extraHeaders);
    }
    public async Task<DeleteFilesResponse> DeleteFilesAsync(DeleteFilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteFilesResponse>("/File/DeleteFiles", request, extraHeaders);
    }
    public async Task<FinalizeFileUploadsResponse> FinalizeFileUploadsAsync(FinalizeFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<FinalizeFileUploadsResponse>("/File/FinalizeFileUploads", request, extraHeaders);
    }
    public async Task<GetFilesResponse> GetFilesAsync(GetFilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFilesResponse>("/File/GetFiles", request, extraHeaders);
    }
    public async Task<GetObjectsResponse> GetObjectsAsync(GetObjectsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetObjectsResponse>("/Object/GetObjects", request, extraHeaders);
    }
    public async Task<InitiateFileUploadsResponse> InitiateFileUploadsAsync(InitiateFileUploadsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InitiateFileUploadsResponse>("/File/InitiateFileUploads", request, extraHeaders);
    }
    public async Task<SetObjectsResponse> SetObjectsAsync(SetObjectsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetObjectsResponse>("/Object/SetObjects", request, extraHeaders);
    }
}