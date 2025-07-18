namespace CommunityFabs.NET.Sdk.Common;

public class PlayFabApiSettings
{
    public readonly Dictionary<string, string> RequestGetParams = new()
    {
        { "sdk", Constants.SdkVersionString }
    };
    /// <summary> You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website) </summary>
    public required string TitleId;
    /// <summary> You must set this value for PlayFabSdk to work properly (Found in the Game Manager for your title, at the PlayFab Website) </summary>
    public required string DeveloperSecretKey;
    /// <summary> This is only for customers running a private cluster.  Generally you shouldn't touch this </summary>
    public string ProductionEnvironmentUrl = Constants.DefaultProductionEnvironmentUrl;
    /// <summary> The name of a customer vertical. This is only for customers running a private cluster.  Generally you shouldn't touch this </summary>
    public string? VerticalName = null;

    public virtual string GetFullUrl(string apiCall)
    {
        return PlayFabSettings.GetFullUrl(apiCall, RequestGetParams, this);
    }
}