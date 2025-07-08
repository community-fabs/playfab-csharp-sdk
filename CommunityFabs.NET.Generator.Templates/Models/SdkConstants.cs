using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

public class SdkConstants
{
    public required string SdkVersion { get; set; }
    public required string BuildIdentifier { get; set; }
}