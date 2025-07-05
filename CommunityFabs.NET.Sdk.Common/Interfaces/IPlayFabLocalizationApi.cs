using CommunityFabs.NET.Sdk.Common.Models.Localization;
namespace CommunityFabs.NET.Sdk.Common.Interfaces;

public interface IPlayFabLocalizationApi {
    /// <summary>
    /// Retrieves the list of allowed languages, only accessible by title entities
    /// <example><br/>Example:<code>
    /// var response = await localeApi.GetLanguageListAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/locale/localization/getlanguagelist">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLanguageListResponse>> GetLanguageListAsync(GetLanguageListRequest request, Dictionary<string, string>? extraHeaders);
}