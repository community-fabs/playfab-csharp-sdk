using System.Text.Json.Serialization;

namespace CommunityFabs.NET.Generator.Templates.Models;

public class ApiTableOfContents
{
    [JsonPropertyName("documents")]
    public List<ApiDocumentReference>? Documents { get; set; }
}

/// <summary>
/// Represents a document entry in the API Table of Contents.
/// </summary>
public class ApiDocumentReference
{
    /// <summary>
    /// Full descriptive name used for describing this document to GUI
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Deprecated : Unique identifier within this file identifying this document - Must match key used in apiSpecPfUrl
    /// </summary>
    [JsonPropertyName("docKey")]
    public string? DocKey { get; set; }

    /// <summary>
    /// Path for the API or Swagger Json. Its basically apispec/dockey or swagger/&lt;api&gt;.swagger.json
    /// </summary>
    [JsonPropertyName("pfurl")]
    public string? Pfurl { get; set; }

    /// <summary>
    /// Short descriptive name used for describing this document to GUI
    /// </summary>
    [JsonPropertyName("shortName")]
    public string? ShortName { get; set; }

    /// <summary>
    /// Relative path from this TOC file, to the indicated file
    /// </summary>
    [JsonPropertyName("relPath")]
    public string? RelPath { get; set; }

    /// <summary>
    /// (Swagger|SdkManualNotes|LegacyPlayFabApiSpec|LegacyPlayFabModels) Describes the json format for the file
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// Indicates to SdkGenerator that this file should be used to define an SDK, and by which functions
    /// </summary>
    [JsonPropertyName("sdkGenMakeMethods")]
    public List<string>? SdkGenMakeMethods { get; set; }

    /// <summary>
    /// Future placeholders for sdkGenMakeMethods
    /// </summary>
    [JsonPropertyName("x-sdkGenMakeMethods")]
    public List<string>? XSdkGenMakeMethods { get; set; }

    /// <summary>
    /// Indicates if the document is optional (not present in all entries)
    /// </summary>
    [JsonPropertyName("isOptional")]
    public bool? IsOptional { get; set; }
}