namespace CommunityFabs.NET.Sdk.Models.Localization;

public class GetLanguageListRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetLanguageListResponse {
    public List<string>? LanguageList { get; set; }
}

