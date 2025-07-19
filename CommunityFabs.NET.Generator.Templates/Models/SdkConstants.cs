using System.Reflection;
using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

public class SdkConstants
{
    public required string SdkVersion { get; set; }
    public required string BuildIdentifier { get; set; }
    public required int BuildOffset { get; set; }
    public string PublishVersion {
        get
        {
            var versionSegments = SdkVersion.Split('.');
            int patchVersion = versionSegments.Length > 2 ? int.Parse(versionSegments[2]) : 0;
            patchVersion += BuildOffset;
            return $"{versionSegments[0]}.{versionSegments[1]}.{patchVersion}";
        }
    }
}