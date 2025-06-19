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

    public string GenerateSummary(string linePrefix = "/// ")
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
            "int32" => "int",
            "uint32" => "UInt32",
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

    public string GenerateSummary(string linePrefix = "/// ")
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
}