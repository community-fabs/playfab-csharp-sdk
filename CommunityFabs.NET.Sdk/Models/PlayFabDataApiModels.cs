namespace CommunityFabs.NET.Sdk.Models.Data;

/// <summary>
/// Aborts the pending upload of the requested files.
/// </summary>
public class AbortFileUploadsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required List<string> FileNames { get; set; }
    public int? ProfileVersion { get; set; }
}

public class AbortFileUploadsResponse {
    public EntityKey? Entity { get; set; }
    public int ProfileVersion { get; set; }
}

/// <summary>
/// Deletes the requested files from the entity's profile.
/// </summary>
public class DeleteFilesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required List<string> FileNames { get; set; }
    public int? ProfileVersion { get; set; }
}

public class DeleteFilesResponse {
    public EntityKey? Entity { get; set; }
    public int ProfileVersion { get; set; }
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

/// <summary>
/// Finalizes the upload of the requested files. Verifies that the files have been successfully uploaded and moves the file pointers from pending to live.
/// </summary>
public class FinalizeFileUploadsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required List<string> FileNames { get; set; }
    public int ProfileVersion { get; set; }
}

public class FinalizeFileUploadsResponse {
    public EntityKey? Entity { get; set; }
    public Dictionary<string, GetFileMetadata>? Metadata { get; set; }
    public int ProfileVersion { get; set; }
}

public class GetFileMetadata {
    public string? Checksum { get; set; }
    public string? DownloadUrl { get; set; }
    public string? FileName { get; set; }
    public required DateTime LastModified { get; set; }
    public int Size { get; set; }
}

/// <summary>
/// Returns URLs that may be used to download the files for a profile for a limited length of time. Only returns files that have been successfully uploaded, files that are still pending will either return the old value, if it exists, or nothing.
/// </summary>
public class GetFilesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
}

public class GetFilesResponse {
    public EntityKey? Entity { get; set; }
    public Dictionary<string, GetFileMetadata>? Metadata { get; set; }
    public int ProfileVersion { get; set; }
}

/// <summary>
/// Gets JSON objects from an entity profile and returns it. 
/// </summary>
public class GetObjectsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public bool? EscapeObject { get; set; }
}

public class GetObjectsResponse {
    public EntityKey? Entity { get; set; }
    public Dictionary<string, ObjectResult>? Objects { get; set; }
    public int ProfileVersion { get; set; }
}

public class InitiateFileUploadMetadata {
    public string? FileName { get; set; }
    public string? UploadUrl { get; set; }
}

/// <summary>
/// Returns URLs that may be used to upload the files for a profile 5 minutes. After using the upload calls FinalizeFileUploads must be called to move the file status from pending to live.
/// </summary>
public class InitiateFileUploadsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required List<string> FileNames { get; set; }
    public int? ProfileVersion { get; set; }
}

public class InitiateFileUploadsResponse {
    public EntityKey? Entity { get; set; }
    public int ProfileVersion { get; set; }
    public List<InitiateFileUploadMetadata>? UploadDetails { get; set; }
}

public class ObjectResult {
    public object? DataObject { get; set; }
    public string? EscapedDataObject { get; set; }
    public string? ObjectName { get; set; }
}

public enum OperationTypes {
    Created,
    Updated,
    Deleted,
    None,
}

public class SetObject {
    public object? DataObject { get; set; }
    public bool? DeleteObject { get; set; }
    public string? EscapedDataObject { get; set; }
    public required string ObjectName { get; set; }
}

public class SetObjectInfo {
    public string? ObjectName { get; set; }
    public string? OperationReason { get; set; }
    public OperationTypes? SetResult { get; set; }
}

/// <summary>
/// Sets JSON objects on the requested entity profile. May include a version number to be used to perform optimistic concurrency operations during update. If the current version differs from the version in the request the request will be ignored. If no version is set on the request then the value will always be updated if the values differ. Using the version value does not guarantee a write though, ConcurrentEditError may still occur if multiple clients are attempting to update the same profile. 
/// </summary>
public class SetObjectsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public int? ExpectedProfileVersion { get; set; }
    public required List<SetObject> Objects { get; set; }
}

public class SetObjectsResponse {
    public int ProfileVersion { get; set; }
    public List<SetObjectInfo>? SetResults { get; set; }
}

