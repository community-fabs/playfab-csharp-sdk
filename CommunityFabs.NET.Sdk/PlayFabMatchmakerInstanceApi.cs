using CommunityFabs.NET.Sdk.Models.Matchmaker;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabMatchmakerInstanceApi : PlayFabBaseInstanceApi, IPlayFabMatchmakerApi {
    public PlayFabMatchmakerInstanceApi() : base() { }
    public PlayFabMatchmakerInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabMatchmakerInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabMatchmakerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<AuthUserResponse> AuthUserAsync(AuthUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AuthUserResponse>("/Matchmaker/AuthUser", request, extraHeaders);
    }
    public async Task<DeregisterGameResponse> DeregisterGameAsync(DeregisterGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeregisterGameResponse>("/Matchmaker/DeregisterGame", request, extraHeaders);
    }
    public async Task<PlayerJoinedResponse> PlayerJoinedAsync(PlayerJoinedRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PlayerJoinedResponse>("/Matchmaker/PlayerJoined", request, extraHeaders);
    }
    public async Task<PlayerLeftResponse> PlayerLeftAsync(PlayerLeftRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PlayerLeftResponse>("/Matchmaker/PlayerLeft", request, extraHeaders);
    }
    public async Task<RegisterGameResponse> RegisterGameAsync(RegisterGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RegisterGameResponse>("/Matchmaker/RegisterGame", request, extraHeaders);
    }
    public async Task<StartGameResponse> StartGameAsync(StartGameRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<StartGameResponse>("/Matchmaker/StartGame", request, extraHeaders);
    }
    public async Task<UserInfoResponse> UserInfoAsync(UserInfoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UserInfoResponse>("/Matchmaker/UserInfo", request, extraHeaders);
    }
}