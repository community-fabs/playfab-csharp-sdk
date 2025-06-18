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
        // TODO - Add doc links and examples
        return !string.IsNullOrEmpty(Description);
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


/* {
  "name": "Profiles",
  "url": "/Profiles",
  "description": "All PlayFab entities have profiles, which hold top-level properties about the entity. These APIs give you the tools needed to manage entity profiles.",
  "apiDescriptionList": [
    "All PlayFab entities have profiles, which hold top-level properties about the entity. These APIs give you the tools needed to manage entity profiles."
  ],
  "datatypes": {
    "EffectType": {
      "name": "EffectType",
      "className": "EffectType",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isenum": true,
      "enumvalues": [
        {
          "name": "Allow"
        },
        {
          "name": "Deny"
        }
      ]
    },
    "EntityDataObject": {
      "name": "EntityDataObject",
      "className": "EntityDataObject",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "An entity object and its associated meta data.",
      "properties": [
        {
          "name": "DataObject",
          "description": "Un-escaped JSON object, if DataAsObject is true.",
          "jsontype": "Object",
          "actualtype": "object",
          "optional": true
        },
        {
          "name": "EscapedDataObject",
          "description": "Escaped string JSON body of the object, if DataAsObject is default or false.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "ObjectName",
          "description": "Name of this object.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        }
      ]
    },
    "EntityKey": {
      "name": "EntityKey",
      "className": "EntityKey",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Combined entity type and ID structure which uniquely identifies a single entity.",
      "properties": [
        {
          "name": "Id",
          "description": "Unique ID of the entity.",
          "jsontype": "String",
          "actualtype": "String"
        },
        {
          "name": "Type",
          "description": "Entity type. See https://docs.microsoft.com/gaming/playfab/features/data/entities/available-built-in-entity-types",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "TypeString",
          "description": "Alternate name for Type.",
          "deprecation": {
            "ProposedAfter": "6/1/2018",
            "DeprecatedAfter": "7/1/2018",
            "ObsoleteAfter": "8/1/2018",
            "ReplacedBy": "Type"
          },
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        }
      ]
    },
    "EntityLineage": {
      "name": "EntityLineage",
      "className": "EntityLineage",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "properties": [
        {
          "name": "CharacterId",
          "description": "The Character Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "GroupId",
          "description": "The Group Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "MasterPlayerAccountId",
          "description": "The Master Player Account Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "NamespaceId",
          "description": "The Namespace Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "TitleId",
          "description": "The Title Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "TitlePlayerAccountId",
          "description": "The Title Player Account Id of the associated entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        }
      ]
    },
    "EntityPermissionStatement": {
      "name": "EntityPermissionStatement",
      "className": "EntityPermissionStatement",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "properties": [
        {
          "name": "Action",
          "description": "The action this statement effects. May be 'Read', 'Write' or '*' for both read and write.",
          "jsontype": "String",
          "actualtype": "String"
        },
        {
          "name": "Comment",
          "description": "A comment about the statement. Intended solely for bookkeeping and debugging.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Condition",
          "description": "Additional conditions to be applied for entity resources.",
          "jsontype": "Object",
          "actualtype": "object",
          "optional": true
        },
        {
          "name": "Effect",
          "description": "The effect this statement will have. It may be either Allow or Deny",
          "jsontype": "String",
          "actualtype": "EffectType",
          "isenum": true
        },
        {
          "name": "Principal",
          "description": "The principal this statement will effect.",
          "jsontype": "Object",
          "actualtype": "object"
        },
        {
          "name": "Resource",
          "description": "The resource this statements effects. Similar to 'pfrn:data--title![Title ID]/Profile/*'",
          "jsontype": "String",
          "actualtype": "String"
        }
      ]
    },
    "EntityProfileBody": {
      "name": "EntityProfileBody",
      "className": "EntityProfileBody",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "properties": [
        {
          "name": "AvatarUrl",
          "description": "Avatar URL for the entity.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Created",
          "description": "The creation time of this profile in UTC.",
          "jsontype": "String",
          "actualtype": "DateTime"
        },
        {
          "name": "DisplayName",
          "description": "The display name of the entity. This field may serve different purposes for different entity types. i.e.: for a title player account it could represent the display name of the player, whereas on a character it could be character's name.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The entity id and type.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        },
        {
          "name": "EntityChain",
          "description": "The chain of responsibility for this entity. Use Lineage.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "ExperimentVariants",
          "description": "The experiment variants of this profile.",
          "collection": "array",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Files",
          "description": "The files on this profile.",
          "collection": "map",
          "jsontype": "Object",
          "actualtype": "EntityProfileFileMetadata",
          "isclass": true,
          "optional": true
        },
        {
          "name": "Language",
          "description": "The language on this profile.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Lineage",
          "description": "The lineage of this profile.",
          "jsontype": "Object",
          "actualtype": "EntityLineage",
          "isclass": true,
          "optional": true
        },
        {
          "name": "Objects",
          "description": "The objects on this profile.",
          "collection": "map",
          "jsontype": "Object",
          "actualtype": "EntityDataObject",
          "isclass": true,
          "optional": true
        },
        {
          "name": "Permissions",
          "description": "The permissions that govern access to this entity profile and its properties. Only includes permissions set on this profile, not global statements from titles and namespaces.",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityPermissionStatement",
          "isclass": true,
          "optional": true
        },
        {
          "name": "Statistics",
          "description": "The statistics on this profile.",
          "collection": "map",
          "jsontype": "Object",
          "actualtype": "EntityStatisticValue",
          "isclass": true,
          "optional": true
        },
        {
          "name": "VersionNumber",
          "description": "The version number of the profile in persistent storage at the time of the read. Used for optional optimistic concurrency during update.",
          "jsontype": "Number",
          "actualtype": "int32"
        }
      ]
    },
    "EntityProfileFileMetadata": {
      "name": "EntityProfileFileMetadata",
      "className": "EntityProfileFileMetadata",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "An entity file's meta data. To get a download URL call File/GetFiles API.",
      "properties": [
        {
          "name": "Checksum",
          "description": "Checksum value for the file, can be used to check if the file on the server has changed.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "FileName",
          "description": "Name of the file",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "LastModified",
          "description": "Last UTC time the file was modified",
          "jsontype": "String",
          "actualtype": "DateTime"
        },
        {
          "name": "Size",
          "description": "Storage service's reported byte count",
          "jsontype": "Number",
          "actualtype": "int32"
        }
      ]
    },
    "EntityStatisticValue": {
      "name": "EntityStatisticValue",
      "className": "EntityStatisticValue",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "properties": [
        {
          "name": "Metadata",
          "description": "Metadata associated with the Statistic.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Name",
          "description": "Statistic name",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Scores",
          "description": "Statistic scores",
          "collection": "array",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Version",
          "description": "Statistic version",
          "jsontype": "Number",
          "actualtype": "int32"
        }
      ]
    },
    "GetEntityProfileRequest": {
      "name": "GetEntityProfileRequest",
      "className": "GetEntityProfileRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given an entity type and entity identifier will retrieve the profile from the entity store. If the profile being retrieved is the caller's, then the read operation is consistent, if not it is an inconsistent read. An inconsistent read means that we do not guarantee all committed writes have occurred before reading the profile, allowing for a stale read. If consistency is important the Version Number on the result can be used to compare which version of the profile any reader has.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "DataAsObject",
          "description": "Determines whether the objects will be returned as an escaped JSON string or as a un-escaped JSON object. Default is JSON string.",
          "jsontype": "Boolean",
          "actualtype": "Boolean",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetEntityProfileResponse": {
      "name": "GetEntityProfileResponse",
      "className": "GetEntityProfileResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "Profile",
          "description": "Entity profile",
          "jsontype": "Object",
          "actualtype": "EntityProfileBody",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetEntityProfilesRequest": {
      "name": "GetEntityProfilesRequest",
      "className": "GetEntityProfilesRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given a set of entity types and entity identifiers will retrieve all readable profiles properties for the caller. Profiles that the caller is not allowed to read will silently not be included in the results.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "DataAsObject",
          "description": "Determines whether the objects will be returned as an escaped JSON string or as a un-escaped JSON object. Default is JSON string.",
          "jsontype": "Boolean",
          "actualtype": "Boolean",
          "optional": true
        },
        {
          "name": "Entities",
          "description": "Entity keys of the profiles to load. Must be between 1 and 25",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true
        }
      ]
    },
    "GetEntityProfilesResponse": {
      "name": "GetEntityProfilesResponse",
      "className": "GetEntityProfilesResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "Profiles",
          "description": "Entity profiles",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityProfileBody",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetGlobalPolicyRequest": {
      "name": "GetGlobalPolicyRequest",
      "className": "GetGlobalPolicyRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Retrieves the title access policy that is used before the profile's policy is inspected during a request. If never customized this will return the default starter policy built by PlayFab.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetGlobalPolicyResponse": {
      "name": "GetGlobalPolicyResponse",
      "className": "GetGlobalPolicyResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "Permissions",
          "description": "The permissions that govern access to all entities under this title or namespace.",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityPermissionStatement",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetTitlePlayersFromMasterPlayerAccountIdsRequest": {
      "name": "GetTitlePlayersFromMasterPlayerAccountIdsRequest",
      "className": "GetTitlePlayersFromMasterPlayerAccountIdsRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given a master player account id (PlayFab ID), returns all title player accounts associated with it.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "MasterPlayerAccountIds",
          "description": "Master player account ids.",
          "collection": "array",
          "jsontype": "String",
          "actualtype": "String"
        },
        {
          "name": "TitleId",
          "description": "Id of title to get players from.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        }
      ]
    },
    "GetTitlePlayersFromMasterPlayerAccountIdsResponse": {
      "name": "GetTitlePlayersFromMasterPlayerAccountIdsResponse",
      "className": "GetTitlePlayersFromMasterPlayerAccountIdsResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "TitleId",
          "description": "Optional id of title to get players from, required if calling using a master_player_account.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "TitlePlayerAccounts",
          "description": "Dictionary of master player ids mapped to title player entity keys and id pairs",
          "collection": "map",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetTitlePlayersFromProviderIDsResponse": {
      "name": "GetTitlePlayersFromProviderIDsResponse",
      "className": "GetTitlePlayersFromProviderIDsResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "TitlePlayerAccounts",
          "description": "Dictionary of provider identifiers mapped to title_player_account lineage. Missing lineage indicates the player either doesn't exist or doesn't play the requested title.",
          "collection": "map",
          "jsontype": "Object",
          "actualtype": "EntityLineage",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "GetTitlePlayersFromXboxLiveIDsRequest": {
      "name": "GetTitlePlayersFromXboxLiveIDsRequest",
      "className": "GetTitlePlayersFromXboxLiveIDsRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given a collection of Xbox IDs (XUIDs), returns all title player accounts.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Sandbox",
          "description": "Xbox Sandbox the players had on their Xbox tokens.",
          "jsontype": "String",
          "actualtype": "String"
        },
        {
          "name": "TitleId",
          "description": "Optional ID of title to get players from, required if calling using a master_player_account.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "XboxLiveIds",
          "description": "List of Xbox Live XUIDs",
          "collection": "array",
          "jsontype": "String",
          "actualtype": "String"
        }
      ]
    },
    "OperationTypes": {
      "name": "OperationTypes",
      "className": "OperationTypes",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isenum": true,
      "enumvalues": [
        {
          "name": "Created"
        },
        {
          "name": "Updated"
        },
        {
          "name": "Deleted"
        },
        {
          "name": "None"
        }
      ]
    },
    "SetAvatarUrlRequest": {
      "name": "SetAvatarUrlRequest",
      "className": "SetAvatarUrlRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "AnyInclusiveFlags": [
        "Beta"
      ],
      "description": "Given an entity profile, will update its avatar url to the provided url if the profile's version is equal to the specified value",
      "isRequest": true,
      "properties": [
        {
          "name": "AvatarUrl",
          "description": "URL of the avatar image. If empty, it removes the existing avatar URL",
          "jsontype": "String",
          "actualtype": "String"
        },
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        },
        {
          "name": "ProfileVersion",
          "description": "The expected version of the profile to perform this update on",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        }
      ]
    },
    "SetAvatarUrlResponse": {
      "name": "SetAvatarUrlResponse",
      "className": "SetAvatarUrlResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "AnyInclusiveFlags": [
        "Beta"
      ],
      "isResult": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        },
        {
          "name": "OperationResult",
          "description": "The type of operation that occurred on the profile's avatar URL",
          "jsontype": "String",
          "actualtype": "OperationTypes",
          "isenum": true,
          "optional": true
        },
        {
          "name": "ProfileVersion",
          "description": "The updated version of the profile after the avatar URL update",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        }
      ]
    },
    "SetDisplayNameRequest": {
      "name": "SetDisplayNameRequest",
      "className": "SetDisplayNameRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given an entity profile, will update its display name to the one passed in if the profile's version is equal to the specified value",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "DisplayName",
          "description": "The new value to be set on Entity Profile's display name",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        },
        {
          "name": "ExpectedVersion",
          "description": "The expected version of a profile to perform this update on",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        }
      ]
    },
    "SetDisplayNameResponse": {
      "name": "SetDisplayNameResponse",
      "className": "SetDisplayNameResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "OperationResult",
          "description": "The type of operation that occured on the profile's display name",
          "jsontype": "String",
          "actualtype": "OperationTypes",
          "isenum": true,
          "optional": true
        },
        {
          "name": "VersionNumber",
          "description": "The updated version of the profile after the display name update",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        }
      ]
    },
    "SetEntityProfilePolicyRequest": {
      "name": "SetEntityProfilePolicyRequest",
      "className": "SetEntityProfilePolicyRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "This will set the access policy statements on the given entity profile. This is not additive, any existing statements will be replaced with the statements in this request.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The entity to perform this action on.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true
        },
        {
          "name": "Statements",
          "description": "The statements to include in the access policy.",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityPermissionStatement",
          "isclass": true
        }
      ]
    },
    "SetEntityProfilePolicyResponse": {
      "name": "SetEntityProfilePolicyResponse",
      "className": "SetEntityProfilePolicyResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "Permissions",
          "description": "The permissions that govern access to this entity profile and its properties. Only includes permissions set on this profile, not global statements from titles and namespaces.",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityPermissionStatement",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "SetGlobalPolicyRequest": {
      "name": "SetGlobalPolicyRequest",
      "className": "SetGlobalPolicyRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Updates the title access policy that is used before the profile's policy is inspected during a request. Policies are compiled and cached for several minutes so an update here may not be reflected in behavior for a short time.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Permissions",
          "description": "The permissions that govern access to all entities under this title or namespace.",
          "collection": "array",
          "jsontype": "Object",
          "actualtype": "EntityPermissionStatement",
          "isclass": true,
          "optional": true
        }
      ]
    },
    "SetGlobalPolicyResponse": {
      "name": "SetGlobalPolicyResponse",
      "className": "SetGlobalPolicyResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": []
    },
    "SetProfileLanguageRequest": {
      "name": "SetProfileLanguageRequest",
      "className": "SetProfileLanguageRequest",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "description": "Given an entity profile, will update its language to the one passed in if the profile's version is equal to the one passed in.",
      "isRequest": true,
      "properties": [
        {
          "name": "CustomTags",
          "description": "The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).",
          "collection": "map",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        },
        {
          "name": "Entity",
          "description": "The optional entity to perform this action on. Defaults to the currently logged in entity.",
          "jsontype": "Object",
          "actualtype": "EntityKey",
          "isclass": true,
          "optional": true
        },
        {
          "name": "ExpectedVersion",
          "description": "The expected version of a profile to perform this update on",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        },
        {
          "name": "Language",
          "description": "The language to set on the given entity. Deletes the profile's language if passed in a null string.",
          "jsontype": "String",
          "actualtype": "String",
          "optional": true
        }
      ]
    },
    "SetProfileLanguageResponse": {
      "name": "SetProfileLanguageResponse",
      "className": "SetProfileLanguageResponse",
      "classNameSpace": "PlayFab.Profiles.Models",
      "assembly": "PlayFab.Profiles.Models",
      "isResult": true,
      "properties": [
        {
          "name": "OperationResult",
          "description": "The type of operation that occured on the profile's language",
          "jsontype": "String",
          "actualtype": "OperationTypes",
          "isenum": true,
          "optional": true
        },
        {
          "name": "VersionNumber",
          "description": "The updated version of the profile after the language update",
          "jsontype": "Number",
          "actualtype": "int32",
          "optional": true
        }
      ]
    }
  },
  "subgroups": [
    {
      "name": "Account Management",
      "methods": [
        "GetGlobalPolicy",
        "GetProfile",
        "GetProfiles",
        "GetTitlePlayersFromMasterPlayerAccountIds",
        "GetTitlePlayersFromXboxLiveIDs",
        "SetAvatarUrl",
        "SetDisplayName",
        "SetGlobalPolicy",
        "SetProfileLanguage",
        "SetProfilePolicy"
      ]
    }
  ],
  "calls": [
    {
      "name": "GetGlobalPolicy",
      "summary": "Gets the global title access policy ",
      "requestDetails": "Retrieves the title access policy that is used before the profile's policy is inspected during a request. If never customized this will return the default starter policy built by PlayFab.",
      "subgroup": "Account Management",
      "url": "/Profile/GetGlobalPolicy",
      "auth": "EntityToken",
      "method": "POST",
      "request": "GetGlobalPolicyRequest",
      "requestExample": "{}",
      "result": "GetGlobalPolicyResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"Permissions\": [\n      {\n        \"Resource\": \"pfrn:data--title_player_account!90901000/Profile/SomethingCool\",\n        \"Action\": \"*\",\n        \"Effect\": \"Allow\",\n        \"Principal\": {\n          \"ChildOf\": {\n            \"EntityType\": \"[SELF]\"\n          }\n        },\n        \"Comment\": \"An example policy\"\n      }\n    ]\n  }\n}",
      "seeAlso": [
        "Profile/GetProfile"
      ]
    },
    {
      "name": "GetProfile",
      "summary": "Retrieves the entity's profile.",
      "requestDetails": "Given an entity type and entity identifier will retrieve the profile from the entity store. If the profile being retrieved is the caller's, then the read operation is consistent, if not it is an inconsistent read. An inconsistent read means that we do not guarantee all committed writes have occurred before reading the profile, allowing for a stale read. If consistency is important the Version Number on the result can be used to compare which version of the profile any reader has.",
      "subgroup": "Account Management",
      "url": "/Profile/GetProfile",
      "auth": "EntityToken",
      "method": "POST",
      "request": "GetEntityProfileRequest",
      "requestExample": "{\n  \"Entity\": {\n    \"Id\": \"1234567787392\",\n    \"Type\": \"title_player_account\",\n    \"TypeString\": \"title_player_account\"\n  }\n}",
      "result": "GetEntityProfileResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"Profile\": {\n      \"Entity\": {\n        \"Id\": \"1234567787392\",\n        \"Type\": \"title_player_account\",\n        \"TypeString\": \"title_player_account\"\n      },\n      \"EntityChain\": \"title_player_account!09839712/1289749013/19073097/1234567787392\",\n      \"VersionNumber\": 0,\n      \"Created\": \"0001-01-01T00:00:00Z\"\n    }\n  }\n}"
    },
    {
      "name": "GetProfiles",
      "summary": "Retrieves the entity's profile.",
      "requestDetails": "Given a set of entity types and entity identifiers will retrieve all readable profiles properties for the caller. Profiles that the caller is not allowed to read will silently not be included in the results.",
      "subgroup": "Account Management",
      "url": "/Profile/GetProfiles",
      "auth": "EntityToken",
      "method": "POST",
      "request": "GetEntityProfilesRequest",
      "requestExample": "{\n  \"Entities\": [\n    {\n      \"Id\": \"1234567787392\",\n      \"Type\": \"title_player_account\",\n      \"TypeString\": \"title_player_account\"\n    },\n    {\n      \"Id\": \"42434567785265\",\n      \"Type\": \"title_player_account\",\n      \"TypeString\": \"title_player_account\"\n    }\n  ]\n}",
      "result": "GetEntityProfilesResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"Profiles\": [\n      {\n        \"Entity\": {\n          \"Id\": \"1234567787392\",\n          \"Type\": \"title_player_account\",\n          \"TypeString\": \"title_player_account\"\n        },\n        \"EntityChain\": \"title_player_account!09839712/1289749013/19073097/1234567787392\",\n        \"VersionNumber\": 0,\n        \"Created\": \"0001-01-01T00:00:00Z\"\n      }\n    ]\n  }\n}"
    },
    {
      "name": "GetTitlePlayersFromMasterPlayerAccountIds",
      "summary": "Retrieves the title player accounts associated with the given master player account.",
      "requestDetails": "Given a master player account id (PlayFab ID), returns all title player accounts associated with it.",
      "subgroup": "Account Management",
      "url": "/Profile/GetTitlePlayersFromMasterPlayerAccountIds",
      "auth": "EntityToken",
      "method": "POST",
      "request": "GetTitlePlayersFromMasterPlayerAccountIdsRequest",
      "requestExample": "{\n  \"MasterPlayerAccountIds\": [\n    \"1233455677\"\n  ],\n  \"TitleId\": \"abc123\"\n}",
      "result": "GetTitlePlayersFromMasterPlayerAccountIdsResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"TitlePlayerAccounts\": {\n      \"1233455677\": {\n        \"Id\": \"1234567787392\",\n        \"Type\": \"title_player_account\",\n        \"TypeString\": \"title_player_account\"\n      },\n      \"2123345568\": {\n        \"Id\": \"23458716980912\",\n        \"Type\": \"title_player_account\",\n        \"TypeString\": \"title_player_account\"\n      }\n    }\n  }\n}"
    },
    {
      "name": "GetTitlePlayersFromXboxLiveIDs",
      "summary": "Retrieves the title player accounts associated with the given XUIDs.",
      "requestDetails": "Given a collection of Xbox IDs (XUIDs), returns all title player accounts.",
      "subgroup": "Account Management",
      "url": "/Profile/GetTitlePlayersFromXboxLiveIDs",
      "auth": "EntityToken",
      "method": "POST",
      "request": "GetTitlePlayersFromXboxLiveIDsRequest",
      "requestExample": "{\n  \"XboxLiveIds\": [\n    \"1233455677\"\n  ],\n  \"Sandbox\": \"RETAIL\"\n}",
      "result": "GetTitlePlayersFromProviderIDsResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"TitlePlayerAccounts\": {\n      \"1233455677\": {\n        \"NamespaceId\": \"9528716980912\",\n        \"TitleId\": \"12342\",\n        \"MasterPlayerAccountId\": \"23458716980912\",\n        \"TitlePlayerAccountId\": \"81258716980352\"\n      }\n    }\n  }\n}"
    },
    {
      "name": "SetAvatarUrl",
      "summary": "Update the avatar url of the entity",
      "requestDetails": "Given an entity profile, will update its avatar url to the provided url if the profile's version is equal to the specified value",
      "subgroup": "Account Management",
      "url": "/Profile/SetAvatarUrl",
      "auth": "EntityToken",
      "method": "POST",
      "request": "SetAvatarUrlRequest",
      "requestExample": "{\n  \"AvatarUrl\": \"https://test.com/image.png\",\n  \"ProfileVersion\": 123,\n  \"Entity\": {\n    \"Id\": \"90901000\",\n    \"Type\": \"title_player_account\",\n    \"TypeString\": \"title_player_account\"\n  }\n}",
      "result": "SetAvatarUrlResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"ProfileVersion\": 85,\n    \"OperationResult\": \"Updated\"\n  }\n}",
      "AnyInclusiveFlags": [
        "Beta"
      ]
    },
    {
      "name": "SetDisplayName",
      "summary": "Update the display name of the entity",
      "requestDetails": "Given an entity profile, will update its display name to the one passed in if the profile's version is equal to the specified value",
      "subgroup": "Account Management",
      "url": "/Profile/SetDisplayName",
      "auth": "EntityToken",
      "method": "POST",
      "request": "SetDisplayNameRequest",
      "requestExample": "{\n  \"DisplayName\": \"My new display name\",\n  \"ExpectedVersion\": 123,\n  \"Entity\": {\n    \"Id\": \"90901000\",\n    \"Type\": \"title_player_account\",\n    \"TypeString\": \"title_player_account\"\n  }\n}",
      "result": "SetDisplayNameResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"VersionNumber\": 42,\n    \"OperationResult\": \"Updated\"\n  }\n}",
      "seeAlso": [
        "Profile/GetProfile"
      ],
      "errors": [
        "AccountNotFound",
        "ConcurrentEditError",
        "EntityProfileConstraintValidationFailed",
        "EntityProfileVersionMismatch",
        "InvalidPartnerResponse",
        "NameNotAvailable",
        "ProfaneDisplayName"
      ]
    },
    {
      "name": "SetGlobalPolicy",
      "summary": "Sets the global title access policy ",
      "requestDetails": "Updates the title access policy that is used before the profile's policy is inspected during a request. Policies are compiled and cached for several minutes so an update here may not be reflected in behavior for a short time.",
      "subgroup": "Account Management",
      "url": "/Profile/SetGlobalPolicy",
      "auth": "EntityToken",
      "method": "POST",
      "request": "SetGlobalPolicyRequest",
      "requestExample": "{\n  \"Permissions\": [\n    {\n      \"Resource\": \"pfrn:data--title_player_account!90901000/Profile/SomethingCool\",\n      \"Action\": \"*\",\n      \"Effect\": \"Allow\",\n      \"Principal\": {\n        \"ChildOf\": {\n          \"EntityType\": \"[SELF]\"\n        }\n      },\n      \"Comment\": \"An example policy\"\n    }\n  ]\n}",
      "result": "SetGlobalPolicyResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {}\n}",
      "seeAlso": [
        "Profile/GetProfile"
      ]
    },
    {
      "name": "SetProfileLanguage",
      "summary": "Updates the entity's language. The precedence hierarchy for communication to the player is Title Player Account language, Master Player Account language, and then title default language if the first two aren't set or supported.",
      "requestDetails": "Given an entity profile, will update its language to the one passed in if the profile's version is equal to the one passed in.",
      "subgroup": "Account Management",
      "url": "/Profile/SetProfileLanguage",
      "auth": "EntityToken",
      "method": "POST",
      "request": "SetProfileLanguageRequest",
      "requestExample": "{\n  \"Language\": \"en\",\n  \"ExpectedVersion\": 123,\n  \"Entity\": {\n    \"Id\": \"1234\",\n    \"Type\": \"title_player_account\",\n    \"TypeString\": \"title_player_account\"\n  }\n}",
      "result": "SetProfileLanguageResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"VersionNumber\": 124,\n    \"OperationResult\": \"Updated\"\n  }\n}"
    },
    {
      "name": "SetProfilePolicy",
      "summary": "Sets the profiles access policy",
      "requestDetails": "This will set the access policy statements on the given entity profile. This is not additive, any existing statements will be replaced with the statements in this request.",
      "subgroup": "Account Management",
      "url": "/Profile/SetProfilePolicy",
      "auth": "EntityToken",
      "method": "POST",
      "request": "SetEntityProfilePolicyRequest",
      "requestExample": "{\n  \"Statements\": [\n    {\n      \"Resource\": \"pfrn:data--*!*\/
Profile/Files/avatar.png\",\n      \"Action\": \"Read\",\n      \"Effect\": \"Allow\",\n      \"Principal\": {\n        \"FriendOf\": \"true\"\n      },\n      \"Comment\": \"Allow my friends to read my avatar\"\n    }\n  ],\n  \"Entity\": {\n    \"Id\": \"90901000\",\n    \"Type\": \"title_player_account\",\n    \"TypeString\": \"title_player_account\"\n  }\n}",
      "result": "SetEntityProfilePolicyResponse",
      "resultExample": "{\n  \"code\": 200,\n  \"status\": \"OK\",\n  \"data\": {\n    \"Permissions\": [\n      {\n        \"Resource\": \"pfrn:data--title_player_account!90901000/Profile/SomethingCool\",\n        \"Action\": \"*\",\n        \"Effect\": \"Allow\",\n        \"Principal\": {\n          \"ChildOf\": {\n            \"EntityType\": \"[SELF]\"\n          }\n        },\n        \"Comment\": \"An example policy\"\n      }\n    ]\n  }\n}",
      "seeAlso": [
        "Profile/GetProfile"
      ]
    }
  ]
 }*/