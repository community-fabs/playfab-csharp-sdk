using CommunityFabs.NET.Sdk.Models.Profiles;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabProfilesInstanceApi : PlayFabBaseInstanceApi, IPlayFabProfilesApi {
    public PlayFabProfilesInstanceApi() : base() { }
    public PlayFabProfilesInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabProfilesInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabProfilesInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<GetGlobalPolicyResponse> GetGlobalPolicyAsync(GetGlobalPolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetGlobalPolicyResponse>("/Profile/GetGlobalPolicy", request, extraHeaders);
    }
    public async Task<GetEntityProfileResponse> GetProfileAsync(GetEntityProfileRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityProfileResponse>("/Profile/GetProfile", request, extraHeaders);
    }
    public async Task<GetEntityProfilesResponse> GetProfilesAsync(GetEntityProfilesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityProfilesResponse>("/Profile/GetProfiles", request, extraHeaders);
    }
    public async Task<GetTitlePlayersFromMasterPlayerAccountIdsResponse> GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitlePlayersFromMasterPlayerAccountIdsResponse>("/Profile/GetTitlePlayersFromMasterPlayerAccountIds", request, extraHeaders);
    }
    public async Task<GetTitlePlayersFromProviderIDsResponse> GetTitlePlayersFromXboxLiveIDsAsync(GetTitlePlayersFromXboxLiveIDsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTitlePlayersFromProviderIDsResponse>("/Profile/GetTitlePlayersFromXboxLiveIDs", request, extraHeaders);
    }
    public async Task<SetAvatarUrlResponse> SetAvatarUrlAsync(SetAvatarUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetAvatarUrlResponse>("/Profile/SetAvatarUrl", request, extraHeaders);
    }
    public async Task<SetDisplayNameResponse> SetDisplayNameAsync(SetDisplayNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetDisplayNameResponse>("/Profile/SetDisplayName", request, extraHeaders);
    }
    public async Task<SetGlobalPolicyResponse> SetGlobalPolicyAsync(SetGlobalPolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetGlobalPolicyResponse>("/Profile/SetGlobalPolicy", request, extraHeaders);
    }
    public async Task<SetProfileLanguageResponse> SetProfileLanguageAsync(SetProfileLanguageRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetProfileLanguageResponse>("/Profile/SetProfileLanguage", request, extraHeaders);
    }
    public async Task<SetEntityProfilePolicyResponse> SetProfilePolicyAsync(SetEntityProfilePolicyRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetEntityProfilePolicyResponse>("/Profile/SetProfilePolicy", request, extraHeaders);
    }
}