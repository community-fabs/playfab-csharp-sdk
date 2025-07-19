namespace CommunityFabs.NET.Common.Models;

public sealed class PlayFabAuthenticationContext
{
    /// <summary> Allows access to the ClientAPI </summary>
    public string? ClientSessionTicket { get; set; }
    /// <summary> The master player entity Id </summary>
    public string? PlayFabId { get; set; }
    /// <summary> Allows access to most Entity APIs </summary>
    public string? EntityToken { get; set; }
    /// <summary>
    /// Clients: The title player entity Id (unless replaced with a related entity)
    /// Servers: The title id (unless replaced with a related entity)
    /// </summary>
    public string? EntityId { get; set; }
    /// <summary>
    /// Describes the type of entity identified by EntityId
    /// </summary>
    public string? EntityType { get; set; }

    public PlayFabAuthenticationContext()
    {
    }

    public PlayFabAuthenticationContext(string clientSessionTicket, string entityToken, string playFabId, string entityId, string entityType) : this()
    {
        ClientSessionTicket = clientSessionTicket;
        PlayFabId = playFabId;
        EntityToken = entityToken;
        EntityId = entityId;
        EntityType = entityType;
    }

    public void CopyFrom(PlayFabAuthenticationContext other)
    {
        ClientSessionTicket = other.ClientSessionTicket;
        PlayFabId = other.PlayFabId;
        EntityToken = other.EntityToken;
        EntityId = other.EntityId;
        EntityType = other.EntityType;
    }

    public bool IsClientLoggedIn()
    {
        return !string.IsNullOrEmpty(ClientSessionTicket);
    }

    public bool IsEntityLoggedIn()
    {
        return !string.IsNullOrEmpty(EntityToken);
    }

    public void ForgetAllCredentials()
    {
        PlayFabId = null;
        ClientSessionTicket = null;
        EntityToken = null;
        EntityId = null;
        EntityType = null;
    }
}