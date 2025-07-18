using CommunityFabs.NET.Common.Models;
using System.Text;

namespace CommunityFabs.NET.Common;

public class PlayFabSettings
{
    public readonly static PlayFabApiSettings staticSettings = new() {
        TitleId = string.Empty,
        DeveloperSecretKey = string.Empty
    };
    // This field will likely be removed someday
    public readonly static PlayFabAuthenticationContext staticPlayer = new();

    public static string GetFullUrl(string apiCall, Dictionary<string, string> getParams, PlayFabApiSettings? apiSettings = null)
    {
        apiSettings = apiSettings ?? staticSettings;
        var baseUrl = apiSettings.ProductionEnvironmentUrl;

        var sb = new StringBuilder();

        if (!baseUrl.StartsWith("http"))
        {
            sb.Append("https://");
            if (!string.IsNullOrEmpty(apiSettings?.TitleId))
            {
                sb.Append(apiSettings.TitleId).Append('.');
            }
            if (!string.IsNullOrEmpty(apiSettings?.VerticalName))
            {
                sb.Append(apiSettings?.VerticalName).Append('.');
            }
        }

        sb.Append(baseUrl).Append(apiCall);

        if (getParams != null)
        {
            for (int i = 0; i < getParams.Count; i++)
            {
                var paramPair = getParams.ElementAt(i);
                sb.Append(i == 0 ? '?' : '&');
                sb.Append($"{paramPair.Key}={paramPair.Value}");
            }
        }

        return sb.ToString();
    }
}