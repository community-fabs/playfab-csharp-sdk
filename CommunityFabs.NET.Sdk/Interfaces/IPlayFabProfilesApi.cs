using CommunityFabs.NET.Sdk.Models.Profiles;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabProfilesApi {
    /// <summary>
    /// Gets the global title access policy
    /// <example><br/>Example:<code>
    /// var response = profileApi.GetGlobalPolicyAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/getglobalpolicy">Microsoft Documentation</see>
    /// </summary>
    public Task<GetGlobalPolicyResponse> GetGlobalPolicyAsync(GetGlobalPolicyRequest request);
    /// <summary>
    /// Retrieves the entity's profile.
    /// <example><br/>Example:<code>
    /// var response = profileApi.GetProfileAsync({);
    ///   "Entity": {
    ///     "Id": "1234567787392",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/getprofile">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityProfileResponse> GetProfileAsync(GetEntityProfileRequest request);
    /// <summary>
    /// Retrieves the entity's profile.
    /// <example><br/>Example:<code>
    /// var response = profileApi.GetProfilesAsync({);
    ///   "Entities": [
    ///     {
    ///       "Id": "1234567787392",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     },
    ///     {
    ///       "Id": "42434567785265",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/getprofiles">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityProfilesResponse> GetProfilesAsync(GetEntityProfilesRequest request);
    /// <summary>
    /// Retrieves the title player accounts associated with the given master player account.
    /// <example><br/>Example:<code>
    /// var response = profileApi.GetTitlePlayersFromMasterPlayerAccountIdsAsync({);
    ///   "MasterPlayerAccountIds": [
    ///     "1233455677"
    ///   ],
    ///   "TitleId": "abc123"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/gettitleplayersfrommasterplayeraccountids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitlePlayersFromMasterPlayerAccountIdsResponse> GetTitlePlayersFromMasterPlayerAccountIdsAsync(GetTitlePlayersFromMasterPlayerAccountIdsRequest request);
    /// <summary>
    /// Retrieves the title player accounts associated with the given XUIDs.
    /// <example><br/>Example:<code>
    /// var response = profileApi.GetTitlePlayersFromXboxLiveIDsAsync({);
    ///   "XboxLiveIds": [
    ///     "1233455677"
    ///   ],
    ///   "Sandbox": "RETAIL"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/gettitleplayersfromxboxliveids">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTitlePlayersFromProviderIDsResponse> GetTitlePlayersFromXboxLiveIDsAsync(GetTitlePlayersFromXboxLiveIDsRequest request);
    /// <summary>
    /// Update the avatar url of the entity
    /// <example><br/>Example:<code>
    /// var response = profileApi.SetAvatarUrlAsync({);
    ///   "AvatarUrl": "https://test.com/image.png",
    ///   "ProfileVersion": 123,
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/setavatarurl">Microsoft Documentation</see>
    /// </summary>
    public Task<SetAvatarUrlResponse> SetAvatarUrlAsync(SetAvatarUrlRequest request);
    /// <summary>
    /// Update the display name of the entity
    /// <example><br/>Example:<code>
    /// var response = profileApi.SetDisplayNameAsync({);
    ///   "DisplayName": "My new display name",
    ///   "ExpectedVersion": 123,
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/setdisplayname">Microsoft Documentation</see>
    /// </summary>
    public Task<SetDisplayNameResponse> SetDisplayNameAsync(SetDisplayNameRequest request);
    /// <summary>
    /// Sets the global title access policy
    /// <example><br/>Example:<code>
    /// var response = profileApi.SetGlobalPolicyAsync({);
    ///   "Permissions": [
    ///     {
    ///       "Resource": "pfrn:data--title_player_account!90901000/Profile/SomethingCool",
    ///       "Action": "*",
    ///       "Effect": "Allow",
    ///       "Principal": {
    ///         "ChildOf": {
    ///           "EntityType": "[SELF]"
    ///         }
    ///       },
    ///       "Comment": "An example policy"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/setglobalpolicy">Microsoft Documentation</see>
    /// </summary>
    public Task<SetGlobalPolicyResponse> SetGlobalPolicyAsync(SetGlobalPolicyRequest request);
    /// <summary>
    /// Updates the entity's language. The precedence hierarchy for communication to the player is Title Player Account
    /// language, Master Player Account language, and then title default language if the first two aren't set or supported.
    /// <example><br/>Example:<code>
    /// var response = profileApi.SetProfileLanguageAsync({);
    ///   "Language": "en",
    ///   "ExpectedVersion": 123,
    ///   "Entity": {
    ///     "Id": "1234",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/setprofilelanguage">Microsoft Documentation</see>
    /// </summary>
    public Task<SetProfileLanguageResponse> SetProfileLanguageAsync(SetProfileLanguageRequest request);
    /// <summary>
    /// Sets the profiles access policy
    /// <example><br/>Example:<code>
    /// var response = profileApi.SetProfilePolicyAsync({);
    ///   "Statements": [
    ///     {
    ///       "Resource": "pfrn:data--*!*/Profile/Files/avatar.png",
    ///       "Action": "Read",
    ///       "Effect": "Allow",
    ///       "Principal": {
    ///         "FriendOf": "true"
    ///       },
    ///       "Comment": "Allow my friends to read my avatar"
    ///     }
    ///   ],
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/profile/account-management/setprofilepolicy">Microsoft Documentation</see>
    /// </summary>
    public Task<SetEntityProfilePolicyResponse> SetProfilePolicyAsync(SetEntityProfilePolicyRequest request);
}