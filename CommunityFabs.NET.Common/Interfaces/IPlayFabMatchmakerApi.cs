using CommunityFabs.NET.Common.Models.Matchmaker;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabMatchmakerApi {
    /// <summary>
    /// Validates a user with the PlayFab service
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.AuthUserAsync({
    ///   "AuthorizationTicket": "9F856B4A071A9A5D-0-0-AD0-8D165320C16429B-72087E2356D29870.9D0410B3E78D8A5F"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/authuser">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AuthUserResponse>> AuthUserAsync(AuthUserRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Inform the matchmaker that a Game Server Instance is removed.
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.DeregisterGameAsync({
    ///   "LobbyId": "8285313"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/deregistergame">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeregisterGameResponse>> DeregisterGameAsync(DeregisterGameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Informs the PlayFab game server hosting service that the indicated user has joined the Game Server Instance specified
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.PlayerJoinedAsync({
    ///   "LobbyId": "serverID",
    ///   "PlayFabId": "23990802934"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/playerjoined">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<PlayerJoinedResponse>> PlayerJoinedAsync(PlayerJoinedRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Informs the PlayFab game server hosting service that the indicated user has left the Game Server Instance specified
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.PlayerLeftAsync({
    ///   "LobbyId": "serverID",
    ///   "PlayFabId": "23990802934"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/playerleft">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<PlayerLeftResponse>> PlayerLeftAsync(PlayerLeftRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Inform the matchmaker that a new Game Server Instance is added.
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.RegisterGameAsync({
    ///   "ServerHost": "118.129.31.244",
    ///   "ServerPort": "9984",
    ///   "Build": "11_034234.13",
    ///   "Region": "USEast",
    ///   "GameMode": "FreeForAll",
    ///   "Tags": {
    ///     "level_cap": "high",
    ///     "no_smoking": "1"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/registergame">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RegisterGameResponse>> RegisterGameAsync(RegisterGameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Instructs the PlayFab game server hosting service to instantiate a new Game Server Instance
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.StartGameAsync({
    ///   "Build": "6.01",
    ///   "Region": "USCentral",
    ///   "GameMode": "capture_the_flag",
    ///   "CustomCommandLineData": "custom_gameserver_commandline_parameter",
    ///   "ExternalMatchmakerEventEndpoint": "https://yourmatchmaker.com/gamestatusevents/"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/startgame">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<StartGameResponse>> StartGameAsync(StartGameRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves the relevant details for a specified user, which the external match-making service can then use to compute
    /// effective matches
    /// <example><br/>Example:<code>
    /// var response = await matchmakerApi.UserInfoAsync({
    ///   "PlayFabId": "23990802934",
    ///   "MinCatalogVersion": 4
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/matchmaker/matchmaking/userinfo">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UserInfoResponse>> UserInfoAsync(UserInfoRequest request, Dictionary<string, string>? extraHeaders);
}