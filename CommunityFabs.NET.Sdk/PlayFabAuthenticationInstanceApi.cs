using CommunityFabs.NET.Sdk.Models.Authentication;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabAuthenticationInstanceApi : PlayFabBaseInstanceApi, IPlayFabAuthenticationApi {
    public PlayFabAuthenticationInstanceApi() : base() { }
    public PlayFabAuthenticationInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabAuthenticationInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabAuthenticationInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<AuthenticateCustomIdResult> AuthenticateGameServerWithCustomIdAsync(AuthenticateCustomIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AuthenticateCustomIdResult>("/GameServerIdentity/AuthenticateGameServerWithCustomId", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteAsync(DeleteRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/GameServerIdentity/Delete", request, extraHeaders);
    }
    public async Task<GetEntityTokenResponse> GetEntityTokenAsync(GetEntityTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityTokenResponse>("/Authentication/GetEntityToken", request, extraHeaders);
    }
    public async Task<ValidateEntityTokenResponse> ValidateEntityTokenAsync(ValidateEntityTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ValidateEntityTokenResponse>("/Authentication/ValidateEntityToken", request, extraHeaders);
    }
}