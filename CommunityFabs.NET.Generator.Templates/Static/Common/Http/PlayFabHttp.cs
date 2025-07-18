using CommunityFabs.NET.Common.Models;

namespace CommunityFabs.NET.Common.Http;

/// <summary>
/// This is a base-class for all Api-request objects.
/// It is currently unfinished, but we will add result-specific properties,
///   and add template where-conditions to make some code easier to follow
/// </summary>
public class PlayFabRequestCommon
{
    public PlayFabAuthenticationContext AuthenticationContext;
}

/// <summary>
/// This is a base-class for all Api-result objects.
/// It is currently unfinished, but we will add result-specific properties,
///   and add template where-conditions to make some code easier to follow
/// </summary>
public class PlayFabResultCommon
{
}

public class PlayFabLoginResultCommon : PlayFabResultCommon
{
    public PlayFabAuthenticationContext AuthenticationContext;
}

public class PlayFabJsonError
{
    public required int code;
    public string? status;
    public string? error;
    public int? errorCode;
    public string? errorMessage;
    public Dictionary<string, string[]>? errorDetails;
    public uint? retryAfterSeconds = null;
}

public class PlayFabJsonSuccess<TResult> where TResult : PlayFabResultCommon
{
    public int code;
    public string status;
    public TResult data;
}

public static class PlayFabHttp
{
    public static async Task<object> Post(string urlPath, PlayFabRequestCommon? request, string authType, string authKey, Dictionary<string, string>? extraHeaders = null, PlayFabApiSettings? instanceSettings = null, HttpClient? customClient = null)
    {
        // if the URL starts with "/", convert it to full url (https://<titleId>.playfabapi.com/<urlPath>)
        if (urlPath.StartsWith('/'))
        {
            var settings = instanceSettings ?? PlayFabSettings.staticSettings;
            var fullPath = settings.GetFullUrl(urlPath);
            return await InternalPost(fullPath, request, authType, authKey, extraHeaders, instanceSettings, customClient);
        }
        return await InternalPost(urlPath, request, authType, authKey, extraHeaders, instanceSettings, customClient);
    }

    private static async Task<object> InternalPost(string fullPath, PlayFabRequestCommon? request, string authType, string authKey, Dictionary<string, string>? extraHeaders = null, PlayFabApiSettings? instanceSettings = null, HttpClient? customClient = null)
    {
        var settings = instanceSettings ?? PlayFabSettings.staticSettings;
        var titleId = settings.TitleId;
        if (string.IsNullOrEmpty(titleId))
        {
            throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "You must set your titleId before making an api call");
        }

        var headers = new Dictionary<string, string>();
        if (authType != null && authKey != null)
        {
            headers[authType] = authKey;
        }
        if (extraHeaders != null)
        {
            foreach (var extraHeader in extraHeaders)
            {
                headers.Add(extraHeader.Key, extraHeader.Value);
            }
        }

        return customClient != null ?
            await PlayFabHttpTransport.Post(customClient, fullPath, request, headers) :
            await PlayFabHttpTransport.Post(fullPath, request, headers);
    }
}