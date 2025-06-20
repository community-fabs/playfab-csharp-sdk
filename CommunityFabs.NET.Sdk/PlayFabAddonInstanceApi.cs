using CommunityFabs.NET.Sdk.Models.Addon;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabAddonInstanceApi : PlayFabBaseInstanceApi, IPlayFabAddonApi {
    public PlayFabAddonInstanceApi() : base() { }
    public PlayFabAddonInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabAddonInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabAddonInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CreateOrUpdateAppleResponse> CreateOrUpdateAppleAsync(CreateOrUpdateAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateAppleResponse>("/Addon/CreateOrUpdateApple", request, extraHeaders);
    }
    public async Task<CreateOrUpdateFacebookResponse> CreateOrUpdateFacebookAsync(CreateOrUpdateFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateFacebookResponse>("/Addon/CreateOrUpdateFacebook", request, extraHeaders);
    }
    public async Task<CreateOrUpdateFacebookInstantGamesResponse> CreateOrUpdateFacebookInstantGamesAsync(CreateOrUpdateFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateFacebookInstantGamesResponse>("/Addon/CreateOrUpdateFacebookInstantGames", request, extraHeaders);
    }
    public async Task<CreateOrUpdateGoogleResponse> CreateOrUpdateGoogleAsync(CreateOrUpdateGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateGoogleResponse>("/Addon/CreateOrUpdateGoogle", request, extraHeaders);
    }
    public async Task<CreateOrUpdateKongregateResponse> CreateOrUpdateKongregateAsync(CreateOrUpdateKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateKongregateResponse>("/Addon/CreateOrUpdateKongregate", request, extraHeaders);
    }
    public async Task<CreateOrUpdateNintendoResponse> CreateOrUpdateNintendoAsync(CreateOrUpdateNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateNintendoResponse>("/Addon/CreateOrUpdateNintendo", request, extraHeaders);
    }
    public async Task<CreateOrUpdatePSNResponse> CreateOrUpdatePSNAsync(CreateOrUpdatePSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdatePSNResponse>("/Addon/CreateOrUpdatePSN", request, extraHeaders);
    }
    public async Task<CreateOrUpdateSteamResponse> CreateOrUpdateSteamAsync(CreateOrUpdateSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateSteamResponse>("/Addon/CreateOrUpdateSteam", request, extraHeaders);
    }
    public async Task<CreateOrUpdateToxModResponse> CreateOrUpdateToxModAsync(CreateOrUpdateToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateToxModResponse>("/Addon/CreateOrUpdateToxMod", request, extraHeaders);
    }
    public async Task<CreateOrUpdateTwitchResponse> CreateOrUpdateTwitchAsync(CreateOrUpdateTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateOrUpdateTwitchResponse>("/Addon/CreateOrUpdateTwitch", request, extraHeaders);
    }
    public async Task<DeleteAppleResponse> DeleteAppleAsync(DeleteAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteAppleResponse>("/Addon/DeleteApple", request, extraHeaders);
    }
    public async Task<DeleteFacebookResponse> DeleteFacebookAsync(DeleteFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteFacebookResponse>("/Addon/DeleteFacebook", request, extraHeaders);
    }
    public async Task<DeleteFacebookInstantGamesResponse> DeleteFacebookInstantGamesAsync(DeleteFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteFacebookInstantGamesResponse>("/Addon/DeleteFacebookInstantGames", request, extraHeaders);
    }
    public async Task<DeleteGoogleResponse> DeleteGoogleAsync(DeleteGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteGoogleResponse>("/Addon/DeleteGoogle", request, extraHeaders);
    }
    public async Task<DeleteKongregateResponse> DeleteKongregateAsync(DeleteKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteKongregateResponse>("/Addon/DeleteKongregate", request, extraHeaders);
    }
    public async Task<DeleteNintendoResponse> DeleteNintendoAsync(DeleteNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteNintendoResponse>("/Addon/DeleteNintendo", request, extraHeaders);
    }
    public async Task<DeletePSNResponse> DeletePSNAsync(DeletePSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeletePSNResponse>("/Addon/DeletePSN", request, extraHeaders);
    }
    public async Task<DeleteSteamResponse> DeleteSteamAsync(DeleteSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteSteamResponse>("/Addon/DeleteSteam", request, extraHeaders);
    }
    public async Task<DeleteToxModResponse> DeleteToxModAsync(DeleteToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteToxModResponse>("/Addon/DeleteToxMod", request, extraHeaders);
    }
    public async Task<DeleteTwitchResponse> DeleteTwitchAsync(DeleteTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteTwitchResponse>("/Addon/DeleteTwitch", request, extraHeaders);
    }
    public async Task<GetAppleResponse> GetAppleAsync(GetAppleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetAppleResponse>("/Addon/GetApple", request, extraHeaders);
    }
    public async Task<GetFacebookResponse> GetFacebookAsync(GetFacebookRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFacebookResponse>("/Addon/GetFacebook", request, extraHeaders);
    }
    public async Task<GetFacebookInstantGamesResponse> GetFacebookInstantGamesAsync(GetFacebookInstantGamesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetFacebookInstantGamesResponse>("/Addon/GetFacebookInstantGames", request, extraHeaders);
    }
    public async Task<GetGoogleResponse> GetGoogleAsync(GetGoogleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetGoogleResponse>("/Addon/GetGoogle", request, extraHeaders);
    }
    public async Task<GetKongregateResponse> GetKongregateAsync(GetKongregateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetKongregateResponse>("/Addon/GetKongregate", request, extraHeaders);
    }
    public async Task<GetNintendoResponse> GetNintendoAsync(GetNintendoRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetNintendoResponse>("/Addon/GetNintendo", request, extraHeaders);
    }
    public async Task<GetPSNResponse> GetPSNAsync(GetPSNRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetPSNResponse>("/Addon/GetPSN", request, extraHeaders);
    }
    public async Task<GetSteamResponse> GetSteamAsync(GetSteamRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetSteamResponse>("/Addon/GetSteam", request, extraHeaders);
    }
    public async Task<GetToxModResponse> GetToxModAsync(GetToxModRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetToxModResponse>("/Addon/GetToxMod", request, extraHeaders);
    }
    public async Task<GetTwitchResponse> GetTwitchAsync(GetTwitchRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTwitchResponse>("/Addon/GetTwitch", request, extraHeaders);
    }
}