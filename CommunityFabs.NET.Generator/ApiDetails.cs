using CommunityFabs.NET.Generator.Templates.Models;
using System.Text.Json;

namespace CommunityFabs.NET.Generator;

static class ApiDetails
{
    const string RESOURCE_PREFIX = "https://raw.githubusercontent.com/PlayFab/API_Specs/master";
    static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private static async Task<T> FetchResource<T>(string path) where T : class
    {
        var url = $"{RESOURCE_PREFIX}/{path}";
        using var httpClient = new HttpClient();
        var json = await httpClient.GetStringAsync(url);
        var toc = JsonSerializer.Deserialize<T>(json, SerializerOptions);
        if (toc == null)
        {
            throw new InvalidOperationException($"Failed to deserialize {path}");
        }
        return toc;
    }

    public static Task<ApiTableOfContents> GetTableOfContents() => FetchResource<ApiTableOfContents>("TOC.json");

    public static Task<LegacyApiDocument> GetLegacyDocument(string path) => FetchResource<LegacyApiDocument>(path);
}
