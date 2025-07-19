using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.Groups;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the Groups API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabGroupsInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabGroupsApi {

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authContext?.ForgetAllCredentials();
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> AcceptGroupApplicationAsync(AcceptGroupApplicationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/AcceptGroupApplication", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> AcceptGroupInvitationAsync(AcceptGroupInvitationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/AcceptGroupInvitation", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> AddMembersAsync(AddMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/AddMembers", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ApplyToGroupResponse>> ApplyToGroupAsync(ApplyToGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ApplyToGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ApplyToGroupResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ApplyToGroupResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ApplyToGroupResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> BlockEntityAsync(BlockEntityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/BlockEntity", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> ChangeMemberRoleAsync(ChangeMemberRoleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ChangeMemberRole", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<CreateGroupResponse>> CreateGroupAsync(CreateGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/CreateGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateGroupResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateGroupResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateGroupResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<CreateGroupRoleResponse>> CreateRoleAsync(CreateGroupRoleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/CreateRole", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateGroupRoleResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateGroupRoleResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateGroupRoleResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> DeleteGroupAsync(DeleteGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/DeleteGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> DeleteRoleAsync(DeleteRoleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/DeleteRole", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetGroupResponse>> GetGroupAsync(GetGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/GetGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetGroupResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetGroupResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetGroupResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<InviteToGroupResponse>> InviteToGroupAsync(InviteToGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/InviteToGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<InviteToGroupResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<InviteToGroupResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<InviteToGroupResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<IsMemberResponse>> IsMemberAsync(IsMemberRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/IsMember", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<IsMemberResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<IsMemberResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<IsMemberResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListGroupApplicationsResponse>> ListGroupApplicationsAsync(ListGroupApplicationsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListGroupApplications", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListGroupApplicationsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListGroupApplicationsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListGroupApplicationsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListGroupBlocksResponse>> ListGroupBlocksAsync(ListGroupBlocksRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListGroupBlocks", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListGroupBlocksResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListGroupBlocksResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListGroupBlocksResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListGroupInvitationsResponse>> ListGroupInvitationsAsync(ListGroupInvitationsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListGroupInvitations", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListGroupInvitationsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListGroupInvitationsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListGroupInvitationsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListGroupMembersResponse>> ListGroupMembersAsync(ListGroupMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListGroupMembers", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListGroupMembersResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListGroupMembersResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListGroupMembersResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListMembershipResponse>> ListMembershipAsync(ListMembershipRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListMembership", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMembershipResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMembershipResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMembershipResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListMembershipOpportunitiesResponse>> ListMembershipOpportunitiesAsync(ListMembershipOpportunitiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/ListMembershipOpportunities", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMembershipOpportunitiesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMembershipOpportunitiesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMembershipOpportunitiesResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> RemoveGroupApplicationAsync(RemoveGroupApplicationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/RemoveGroupApplication", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> RemoveGroupInvitationAsync(RemoveGroupInvitationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/RemoveGroupInvitation", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> RemoveMembersAsync(RemoveMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/RemoveMembers", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UnblockEntityAsync(UnblockEntityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/UnblockEntity", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateGroupResponse>> UpdateGroupAsync(UpdateGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/UpdateGroup", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateGroupResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateGroupResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateGroupResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateGroupRoleResponse>> UpdateRoleAsync(UpdateGroupRoleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Group/UpdateRole", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateGroupRoleResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateGroupRoleResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateGroupRoleResponse> { Result = result };
    }

}