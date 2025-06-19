namespace CommunityFabs.NET.Sdk;

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
    public int code;
    public string status;
    public string error;
    public int errorCode;
    public string errorMessage;
    public Dictionary<string, string[]> errorDetails = null;
    public uint? retryAfterSeconds = null;
}

public class PlayFabJsonSuccess<TResult> where TResult : PlayFabResultCommon
{
    public int code;
    public string status;
    public TResult data;
}
