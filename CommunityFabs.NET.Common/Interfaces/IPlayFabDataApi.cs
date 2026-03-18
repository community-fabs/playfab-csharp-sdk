using CommunityFabs.NET.Common.Models.Data;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabDataApi {
    /// <summary>
    /// Abort pending file uploads to an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.AbortFileUploadsAsync({
    ///   "FileNames": [
    ///     "avatar",
    ///     "game_state"
    ///   ],
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/file/file/abortfileuploads">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AbortFileUploadsResponse>> AbortFileUploadsAsync(AbortFileUploadsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete files on an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.DeleteFilesAsync({
    ///   "FileNames": [
    ///     "game_state",
    ///     "avatar"
    ///   ],
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/file/file/deletefiles">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteFilesResponse>> DeleteFilesAsync(DeleteFilesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Finalize file uploads to an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.FinalizeFileUploadsAsync({
    ///   "ProfileVersion": 0,
    ///   "FileNames": [
    ///     "avatar",
    ///     "game_state"
    ///   ],
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/file/file/finalizefileuploads">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<FinalizeFileUploadsResponse>> FinalizeFileUploadsAsync(FinalizeFileUploadsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves file metadata from an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.GetFilesAsync({
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/file/file/getfiles">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetFilesResponse>> GetFilesAsync(GetFilesRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves objects from an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.GetObjectsAsync({
    ///   "Entity": {
    ///     "Id": "ABC90712ABC",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/object/object/getobjects">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetObjectsResponse>> GetObjectsAsync(GetObjectsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Initiates file uploads to an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.InitiateFileUploadsAsync({
    ///   "FileNames": [
    ///     "avatar",
    ///     "game_state"
    ///   ],
    ///   "Entity": {
    ///     "Id": "ID",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/file/file/initiatefileuploads">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<InitiateFileUploadsResponse>> InitiateFileUploadsAsync(InitiateFileUploadsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets objects on an entity's profile.
    /// <example><br/>Example:<code>
    /// var response = await dataApi.SetObjectsAsync({
    ///   "ExpectedProfileVersion": 5,
    ///   "Objects": [
    ///     {
    ///       "ObjectName": "SaveSate",
    ///       "DataObject": {
    ///         "PlayerDetails": {
    ///           "LastMissionSuccess": "2017-06-15T11:05:19Z",
    ///           "LastMissionFailure": "2017-06-12T11:05:19Z",
    ///           "MapPosition": [
    ///             22.0,
    ///             37.78
    ///           ],
    ///           "IsPaidUpgrade": true
    ///         },
    ///         "GameSettings": {
    ///           "Screen": "FriendsList",
    ///           "Favorites": [
    ///             "Place 1",
    ///             "Place 2"
    ///           ]
    ///         }
    ///       },
    ///       "SimpleStatements": {
    ///         "Read": [
    ///           {
    ///             "Friend": true
    ///           }
    ///         ],
    ///         "Write": [
    ///           "Self"
    ///         ]
    ///       }
    ///     }
    ///   ],
    ///   "Entity": {
    ///     "Id": "A8140AB9109712B",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/object/object/setobjects">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetObjectsResponse>> SetObjectsAsync(SetObjectsRequest request, Dictionary<string, string>? extraHeaders);
}