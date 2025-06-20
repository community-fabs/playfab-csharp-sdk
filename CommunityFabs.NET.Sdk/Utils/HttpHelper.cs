namespace CommunityFabs.NET.Sdk.Utils;

public static class HttpHelper
{
    // Static, shared HttpClient instance
    private static readonly HttpClient httpClient = new();

    public static HttpClient HttpClient { get => httpClient; }
}