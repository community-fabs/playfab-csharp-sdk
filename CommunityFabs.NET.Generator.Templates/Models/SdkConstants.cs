using System.Reflection;
using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

public class SdkConstants
{
    public required string SdkVersion { get; set; }
    public required string BuildIdentifier { get; set; }
    public required string BuildSuffix { get; set; }
    public string PublishVersion {
        get => string.IsNullOrEmpty(BuildSuffix) ? SdkVersion : $"{SdkVersion}-{BuildSuffix}";
    }
}