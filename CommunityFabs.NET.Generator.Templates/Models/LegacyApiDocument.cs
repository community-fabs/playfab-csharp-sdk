using System.Text;
using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

/// <summary>
/// Top-level legacy API document.
/// </summary>
public class LegacyApiDocument
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("apiDescriptionList")]
    public List<string>? ApiDescriptionList { get; set; }

    [JsonPropertyName("datatypes")]
    public Dictionary<string, LegacyDatatype>? Datatypes { get; set; }

    [JsonPropertyName("subgroups")]
    public List<LegacySubgroup>? Subgroups { get; set; }

    [JsonPropertyName("calls")]
    public List<LegacyApiCall>? Calls { get; set; }

    [JsonPropertyName("errors")]
    public Dictionary<string, ErrorCode> Errors { get; set; } = new Dictionary<string, ErrorCode>();
}

/// <summary>
/// Represents a datatype (class or enum) in the legacy API.
/// </summary>
public class LegacyDatatype
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("className")]
    public string? ClassName { get; set; }

    [JsonPropertyName("classNameSpace")]
    public string? ClassNameSpace { get; set; }

    [JsonPropertyName("assembly")]
    public string? Assembly { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("isenum")]
    public bool? IsEnum { get; set; }

    [JsonPropertyName("enumvalues")]
    public List<LegacyEnumValue>? EnumValues { get; set; }

    [JsonPropertyName("properties")]
    public List<LegacyProperty>? Properties { get; set; }

    [JsonPropertyName("isRequest")]
    public bool? IsRequest { get; set; }

    [JsonPropertyName("isResult")]
    public bool? IsResult { get; set; }

    [JsonPropertyName("deprecation")]
    public LegacyDeprecation? Deprecation { get; set; }

    public bool HasSummary()
    {
        return !string.IsNullOrEmpty(Description);
    }

    public string GetSummary(string linePrefix = "/// ")
    {
        if (!HasSummary())
        {
            return string.Empty;
        }
        var summaryLines = Utils.SplitDescription(Description.Trim());
        var summary = new StringBuilder();
        summary.AppendLine($"{linePrefix}<summary>");
        foreach (var line in summaryLines)
        {
            summary.AppendLine($"{linePrefix}{line}");
        }
        summary.AppendLine($"{linePrefix}</summary>");
        return summary.ToString();
    }

    public string GetBaseClass()
    {
        var baseClass = "";
        if (IsRequest ?? false)
        {
            baseClass = "PlayFabRequestCommon";
        }
        else if (ClassName == "LoginResult" || ClassName == "AuthenticateIdentityResult" || ClassName == "RegisterPlayFabUserResult")
        {
            baseClass = "PlayFabLoginResultCommon";
        }
        else if (IsResult ?? false)
        {
            baseClass = "PlayFabResultCommon";
        }
        return baseClass;
    }
}

/// <summary>
/// Represents a property of a datatype.
/// </summary>
public class LegacyProperty
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("jsontype")]
    public string? JsonType { get; set; }

    [JsonPropertyName("actualtype")]
    public string? ActualType { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    [JsonPropertyName("isclass")]
    public bool? IsClass { get; set; }

    [JsonPropertyName("isenum")]
    public bool? IsEnum { get; set; }

    [JsonPropertyName("deprecation")]
    public LegacyDeprecation? Deprecation { get; set; }

    /// <summary>
    /// Returns whether the "required" keyword should be applied
    /// </summary>
    public bool IsRequired()
    {
        return !(Optional ?? false) && !(IsEnum ?? false) && ActualType != "Boolean" &&
            ActualType != "int32" && ActualType != "uint32";
    }

    /// <summary>
    /// Returns the C# type name for this property, considering collection types and primitive types.
    /// </summary>
    public string GetTypeName()
    {
        var actualType = ActualType switch
        {
            "String" => "string",
            "int16" => "short",
            "uint16" => "ushort",
            "int32" => "int",
            "uint32" => "uint",
            "int64" => "long",
            "uint64" => "ulong",
            "Boolean" => "bool",
            _ => ActualType
        } ?? "object";
        if (Collection == "array")
        {
            actualType = $"List<{actualType}>";
        }
        else if (Collection == "map")
        {
            actualType = $"Dictionary<string, {actualType}>";
        }
        return actualType;
    }

    public bool HasSummary()
    {
        return !string.IsNullOrEmpty(Description);
    }

    public string GetSummary(string linePrefix = "/// ")
    {
        if (!HasSummary())
        {
            return string.Empty;
        }
        var summaryLines = Utils.SplitDescription(Description.Trim());
        var summary = new StringBuilder();
        summary.AppendLine($"{linePrefix}<summary>");
        foreach (var line in summaryLines)
        {
            summary.AppendLine($"{linePrefix}{line}");
        }
        summary.AppendLine($"{linePrefix}</summary>");
        return summary.ToString();
    }
}

/// <summary>
/// Represents an enum value.
/// </summary>
public class LegacyEnumValue
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents deprecation information for a property.
/// </summary>
public class LegacyDeprecation
{
    [JsonPropertyName("ProposedAfter")]
    public string? ProposedAfter { get; set; }

    [JsonPropertyName("DeprecatedAfter")]
    public string? DeprecatedAfter { get; set; }

    [JsonPropertyName("ObsoleteAfter")]
    public string? ObsoleteAfter { get; set; }

    [JsonPropertyName("ReplacedBy")]
    public string? ReplacedBy { get; set; }

    public string GetDeprecationMessage ()
    {
        return !string.IsNullOrEmpty(ReplacedBy) ?
            $"Please use {ReplacedBy} instead" :
            "Do not use";
    }
}

/// <summary>
/// Represents a subgroup of API calls.
/// </summary>
public class LegacySubgroup
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("methods")]
    public List<string>? Methods { get; set; }
}

/// <summary>
/// Represents an API call definition.
/// </summary>
public class LegacyApiCall
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    [JsonPropertyName("requestDetails")]
    public string? RequestDetails { get; set; }

    [JsonPropertyName("subgroup")]
    public string? Subgroup { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("auth")]
    public string? Auth { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }

    [JsonPropertyName("requestExample")]
    public string? RequestExample { get; set; }

    [JsonPropertyName("result")]
    public string? Result { get; set; }

    [JsonPropertyName("resultExample")]
    public string? ResultExample { get; set; }

    [JsonPropertyName("seeAlso")]
    public List<string>? SeeAlso { get; set; }

    [JsonPropertyName("errors")]
    public List<string>? Errors { get; set; }

    public string GetDocumentationLink()
    {
        if (string.IsNullOrEmpty(Url))
        {
            return string.Empty;
        }
        var apiName = Url.Split('/')[1]!.ToLowerInvariant();
        var apiCategory = Subgroup?.ToLowerInvariant().Replace(" ", "-") ?? "unknown";
        return $"https://docs.microsoft.com/rest/api/playfab/{apiName}/{apiCategory}/{Name?.ToLowerInvariant()}";
    }

    public string GetSummary(string prefix = "/// ")
    {
        if (string.IsNullOrEmpty(Summary))
        {
            return string.Empty;
        }
        var summaryLines = Utils.SplitDescription(Summary.Trim());
        var summary = new StringBuilder();
        summary.AppendLine($"{prefix}<summary>");
        foreach (var line in summaryLines)
        {
            summary.AppendLine($"{prefix}{line}");
        }

        if (!string.IsNullOrEmpty(RequestExample))
        {
            var apiName = Url!.Split('/')[1]!.ToLowerInvariant();
            var requestLines = RequestExample.Split("\n");
            summary.AppendLine($"{prefix}<example><br/>Example:<code>");
            if (requestLines.Length == 1)
            {
                summary.AppendLine($"{prefix}var response = await {apiName}Api.{Name}Async({requestLines[0]});");
            }
            else
            {
                summary.AppendLine($"{prefix}var response = await {apiName}Api.{Name}Async({requestLines[0]});");
                for (int i = 1; i < requestLines.Length; i++)
                {
                    if (i == requestLines.Length - 1)
                    {
                        // add closing parentheses to the last line
                        summary.AppendLine($"{prefix}{requestLines[i]});");
                        break;
                    }

                    summary.AppendLine($"{prefix}{requestLines[i]}");
                }
            }
            summary.AppendLine($"{prefix}</code></example>");
        }
        
        var docLink = GetDocumentationLink();
        if (!string.IsNullOrEmpty(docLink))
        {
            summary.AppendLine($"{prefix}<br/><see href=\"{docLink}\">Microsoft Documentation</see>");
        }

        summary.AppendLine($"{prefix}</summary>");

        return summary.ToString();
    }
}

public class ErrorCode
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
}