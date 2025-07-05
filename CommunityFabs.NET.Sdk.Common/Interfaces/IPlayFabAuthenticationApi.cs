using CommunityFabs.NET.Sdk.Common.Models.Authentication;
namespace CommunityFabs.NET.Sdk.Common.Interfaces;

public interface IPlayFabAuthenticationApi {
    /// <summary>
    /// Create a game_server entity token and return a new or existing game_server entity.
    /// <example><br/>Example:<code>
    /// var response = await gameserveridentityApi.AuthenticateGameServerWithCustomIdAsync({);
    ///   "CustomId": "12345678123412341234123456789abc"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/gameserveridentity/authentication/authenticategameserverwithcustomid">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AuthenticateCustomIdResult>> AuthenticateGameServerWithCustomIdAsync(AuthenticateCustomIdRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete a game_server entity.
    /// <example><br/>Example:<code>
    /// var response = await gameserveridentityApi.DeleteAsync({);
    ///   "Entity": {
    ///     "Id": "3D00C64954",
    ///     "Type": "game_server",
    ///     "TypeString": "game_server"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/gameserveridentity/authentication/delete">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteAsync(DeleteRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Method to exchange a legacy AuthenticationTicket or title SecretKey for an Entity Token or to refresh a still valid
    /// Entity Token.
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.GetEntityTokenAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/authentication/authentication/getentitytoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEntityTokenResponse>> GetEntityTokenAsync(GetEntityTokenRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Method for a server to validate a client provided EntityToken. Only callable by the title entity.
    /// <example><br/>Example:<code>
    /// var response = await authenticationApi.ValidateEntityTokenAsync({);
    ///   "EntityToken": "50c61b9065b27a124a400ee3b95d404313986969"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/authentication/authentication/validateentitytoken">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ValidateEntityTokenResponse>> ValidateEntityTokenAsync(ValidateEntityTokenRequest request, Dictionary<string, string>? extraHeaders);
}