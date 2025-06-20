using CommunityFabs.NET.Sdk.Models.Localization;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabLocalizationInstanceApi : PlayFabBaseInstanceApi, IPlayFabLocalizationApi {
    public PlayFabLocalizationInstanceApi() : base() { }
    public PlayFabLocalizationInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabLocalizationInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabLocalizationInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<GetLanguageListResponse> GetLanguageListAsync(GetLanguageListRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetLanguageListResponse>("/Locale/GetLanguageList", request, extraHeaders);
    }
}