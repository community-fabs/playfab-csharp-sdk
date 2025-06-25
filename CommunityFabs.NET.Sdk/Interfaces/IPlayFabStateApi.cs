using CommunityFabs.NET.Sdk.Models.State;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabStateApi {
    /// <summary>
    /// Creates a link to previously stored state.
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/createlinkforstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateLinkResponse>> CreateLinkForStateAsync(CreateLinkRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Create state.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.CreateStateAsync({);
    ///   "Description": "Specific map location",
    ///   "Expiry": "2023-12-01T20:20:20Z",
    ///   "Label": "Map location",
    ///   "PlatformTitleId": "12345678",
    ///   "RedemptionLimit": 12,
    ///   "State": "{ \"loc\": [ 23, 45, 67 ]}",
    ///   "ThumbnailUri": "https://example.com/someimage.png",
    ///   "Visibility": "Public"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/createstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateStateResponse>> CreateStateAsync(CreateStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a link.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.DeleteLinkForStateAsync({);
    ///   "StateId": "77a00990-50d1-4703-a018-68bfa2c46750"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/deletelinkforstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteLinkForStateAsync(DeleteLinkRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete state.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.DeleteStateAsync({);
    ///   "Id": "4eb6d9f2-bc22-4d3d-823e-8ada5773a41a"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/deletestate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteStateAsync(DeleteStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get public and private metadata for a link.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.GetLinkMetadataAsync({);
    ///   "LinkToken": "sometoken"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/getlinkmetadata">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLinkMetadataResponse>> GetLinkMetadataAsync(GetLinkMetadataRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get state.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.GetStateAsync({);
    ///   "Id": "25078688-3905-4b10-a780-374a2e4364f3",
    ///   "PlatformToken": "sometoken"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/getstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetStateResponse>> GetStateAsync(GetStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List state ids.
    /// <example><br/>Example:<code>
    /// var response = await stateshareApi.ListStateIdsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/stateshare/player-data-management/liststateids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListStateIdsResponse>> ListStateIdsAsync(ListStateIdsRequest request, Dictionary<string, string>? extraHeaders);
}