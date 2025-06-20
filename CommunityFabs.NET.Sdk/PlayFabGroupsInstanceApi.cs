using CommunityFabs.NET.Sdk.Models.Groups;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabGroupsInstanceApi : PlayFabBaseInstanceApi, IPlayFabGroupsApi {
    public PlayFabGroupsInstanceApi() : base() { }
    public PlayFabGroupsInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabGroupsInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabGroupsInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<EmptyResponse> AcceptGroupApplicationAsync(AcceptGroupApplicationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/AcceptGroupApplication", request, extraHeaders);
    }
    public async Task<EmptyResponse> AcceptGroupInvitationAsync(AcceptGroupInvitationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/AcceptGroupInvitation", request, extraHeaders);
    }
    public async Task<EmptyResponse> AddMembersAsync(AddMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/AddMembers", request, extraHeaders);
    }
    public async Task<ApplyToGroupResponse> ApplyToGroupAsync(ApplyToGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ApplyToGroupResponse>("/Group/ApplyToGroup", request, extraHeaders);
    }
    public async Task<EmptyResponse> BlockEntityAsync(BlockEntityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/BlockEntity", request, extraHeaders);
    }
    public async Task<EmptyResponse> ChangeMemberRoleAsync(ChangeMemberRoleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/ChangeMemberRole", request, extraHeaders);
    }
    public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateGroupResponse>("/Group/CreateGroup", request, extraHeaders);
    }
    public async Task<CreateGroupRoleResponse> CreateRoleAsync(CreateGroupRoleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateGroupRoleResponse>("/Group/CreateRole", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteGroupAsync(DeleteGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/DeleteGroup", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteRoleAsync(DeleteRoleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/DeleteRole", request, extraHeaders);
    }
    public async Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetGroupResponse>("/Group/GetGroup", request, extraHeaders);
    }
    public async Task<InviteToGroupResponse> InviteToGroupAsync(InviteToGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<InviteToGroupResponse>("/Group/InviteToGroup", request, extraHeaders);
    }
    public async Task<IsMemberResponse> IsMemberAsync(IsMemberRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IsMemberResponse>("/Group/IsMember", request, extraHeaders);
    }
    public async Task<ListGroupApplicationsResponse> ListGroupApplicationsAsync(ListGroupApplicationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListGroupApplicationsResponse>("/Group/ListGroupApplications", request, extraHeaders);
    }
    public async Task<ListGroupBlocksResponse> ListGroupBlocksAsync(ListGroupBlocksRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListGroupBlocksResponse>("/Group/ListGroupBlocks", request, extraHeaders);
    }
    public async Task<ListGroupInvitationsResponse> ListGroupInvitationsAsync(ListGroupInvitationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListGroupInvitationsResponse>("/Group/ListGroupInvitations", request, extraHeaders);
    }
    public async Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListGroupMembersResponse>("/Group/ListGroupMembers", request, extraHeaders);
    }
    public async Task<ListMembershipResponse> ListMembershipAsync(ListMembershipRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMembershipResponse>("/Group/ListMembership", request, extraHeaders);
    }
    public async Task<ListMembershipOpportunitiesResponse> ListMembershipOpportunitiesAsync(ListMembershipOpportunitiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListMembershipOpportunitiesResponse>("/Group/ListMembershipOpportunities", request, extraHeaders);
    }
    public async Task<EmptyResponse> RemoveGroupApplicationAsync(RemoveGroupApplicationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/RemoveGroupApplication", request, extraHeaders);
    }
    public async Task<EmptyResponse> RemoveGroupInvitationAsync(RemoveGroupInvitationRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/RemoveGroupInvitation", request, extraHeaders);
    }
    public async Task<EmptyResponse> RemoveMembersAsync(RemoveMembersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/RemoveMembers", request, extraHeaders);
    }
    public async Task<EmptyResponse> UnblockEntityAsync(UnblockEntityRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/Group/UnblockEntity", request, extraHeaders);
    }
    public async Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateGroupResponse>("/Group/UpdateGroup", request, extraHeaders);
    }
    public async Task<UpdateGroupRoleResponse> UpdateRoleAsync(UpdateGroupRoleRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateGroupRoleResponse>("/Group/UpdateRole", request, extraHeaders);
    }
}