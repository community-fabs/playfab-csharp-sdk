using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

public class SdkManualNotes
{
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("sdkVersion")]
    public Dictionary<string, string>? SdkVersion { get; set; }
}