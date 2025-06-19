namespace CommunityFabs.NET.Sdk.Models.Localization;

public class GetLanguageListRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetLanguageListResponse : PlayFabResultCommon {
    public List<string>? LanguageList { get; set; }
}

