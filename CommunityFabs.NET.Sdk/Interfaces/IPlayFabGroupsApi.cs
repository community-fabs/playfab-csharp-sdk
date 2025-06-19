using CommunityFabs.NET.Sdk.Models.Groups;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabGroupsApi {
    /// <summary>
    /// Accepts an outstanding invitation to to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.AcceptGroupApplicationAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/acceptgroupapplication">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> AcceptGroupApplicationAsync(AcceptGroupApplicationRequest request);
    /// <summary>
    /// Accepts an invitation to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.AcceptGroupInvitationAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/acceptgroupinvitation">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> AcceptGroupInvitationAsync(AcceptGroupInvitationRequest request);
    /// <summary>
    /// Adds members to a group or role.
    /// <example><br/>Example:<code>
    /// var response = groupApi.AddMembersAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Members": [
    ///     {
    ///       "Id": "90901000",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/addmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> AddMembersAsync(AddMembersRequest request);
    /// <summary>
    /// Applies to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.ApplyToGroupAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/applytogroup">Microsoft Documentation</see>
    /// </summary>
    public Task<ApplyToGroupResponse> ApplyToGroupAsync(ApplyToGroupRequest request);
    /// <summary>
    /// Blocks a list of entities from joining a group.
    /// <example><br/>Example:<code>
    /// var response = groupApi.BlockEntityAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/blockentity">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> BlockEntityAsync(BlockEntityRequest request);
    /// <summary>
    /// Changes the role membership of a list of entities from one role to another.
    /// <example><br/>Example:<code>
    /// var response = groupApi.ChangeMemberRoleAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "OriginRoleId": "awesomepeople",
    ///   "DestinationRoleId": "members",
    ///   "Members": [
    ///     {
    ///       "Id": "90901000",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/changememberrole">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> ChangeMemberRoleAsync(ChangeMemberRoleRequest request);
    /// <summary>
    /// Creates a new group.
    /// <example><br/>Example:<code>
    /// var response = groupApi.CreateGroupAsync({);
    ///   "GroupName": "Example Group"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/creategroup">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request);
    /// <summary>
    /// Creates a new group role.
    /// <example><br/>Example:<code>
    /// var response = groupApi.CreateRoleAsync({);
    ///   "RoleId": "example",
    ///   "RoleName": "Example Role",
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/createrole">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateGroupRoleResponse> CreateRoleAsync(CreateGroupRoleRequest request);
    /// <summary>
    /// Deletes a group and all roles, invitations, join requests, and blocks associated with it.
    /// <example><br/>Example:<code>
    /// var response = groupApi.DeleteGroupAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/deletegroup">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteGroupAsync(DeleteGroupRequest request);
    /// <summary>
    /// Deletes an existing role in a group.
    /// <example><br/>Example:<code>
    /// var response = groupApi.DeleteRoleAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "RoleId": "ABC1234DEF"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/deleterole">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteRoleAsync(DeleteRoleRequest request);
    /// <summary>
    /// Gets information about a group and its roles
    /// <example><br/>Example:<code>
    /// var response = groupApi.GetGroupAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/getgroup">Microsoft Documentation</see>
    /// </summary>
    public Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request);
    /// <summary>
    /// Invites a player to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.InviteToGroupAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "RoleId": "awesomepeople",
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/invitetogroup">Microsoft Documentation</see>
    /// </summary>
    public Task<InviteToGroupResponse> InviteToGroupAsync(InviteToGroupRequest request);
    /// <summary>
    /// Checks to see if an entity is a member of a group or role within the group
    /// <example><br/>Example:<code>
    /// var response = groupApi.IsMemberAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "RoleId": "ABC1234DEF",
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/ismember">Microsoft Documentation</see>
    /// </summary>
    public Task<IsMemberResponse> IsMemberAsync(IsMemberRequest request);
    /// <summary>
    /// Lists all outstanding requests to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListGroupApplicationsAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listgroupapplications">Microsoft Documentation</see>
    /// </summary>
    public Task<ListGroupApplicationsResponse> ListGroupApplicationsAsync(ListGroupApplicationsRequest request);
    /// <summary>
    /// Lists all entities blocked from joining a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListGroupBlocksAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listgroupblocks">Microsoft Documentation</see>
    /// </summary>
    public Task<ListGroupBlocksResponse> ListGroupBlocksAsync(ListGroupBlocksRequest request);
    /// <summary>
    /// Lists all outstanding invitations for a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListGroupInvitationsAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listgroupinvitations">Microsoft Documentation</see>
    /// </summary>
    public Task<ListGroupInvitationsResponse> ListGroupInvitationsAsync(ListGroupInvitationsRequest request);
    /// <summary>
    /// Lists all members for a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListGroupMembersAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listgroupmembers">Microsoft Documentation</see>
    /// </summary>
    public Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request);
    /// <summary>
    /// Lists all groups and roles for an entity
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListMembershipAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listmembership">Microsoft Documentation</see>
    /// </summary>
    public Task<ListMembershipResponse> ListMembershipAsync(ListMembershipRequest request);
    /// <summary>
    /// Lists all outstanding invitations and group applications for an entity
    /// <example><br/>Example:<code>
    /// var response = groupApi.ListMembershipOpportunitiesAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/listmembershipopportunities">Microsoft Documentation</see>
    /// </summary>
    public Task<ListMembershipOpportunitiesResponse> ListMembershipOpportunitiesAsync(ListMembershipOpportunitiesRequest request);
    /// <summary>
    /// Removes an application to join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.RemoveGroupApplicationAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/removegroupapplication">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> RemoveGroupApplicationAsync(RemoveGroupApplicationRequest request);
    /// <summary>
    /// Removes an invitation join a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.RemoveGroupInvitationAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/removegroupinvitation">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> RemoveGroupInvitationAsync(RemoveGroupInvitationRequest request);
    /// <summary>
    /// Removes members from a group.
    /// <example><br/>Example:<code>
    /// var response = groupApi.RemoveMembersAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "RoleId": "ABC1234DEF",
    ///   "Members": [
    ///     {
    ///       "Id": "90901000",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/removemembers">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> RemoveMembersAsync(RemoveMembersRequest request);
    /// <summary>
    /// Unblocks a list of entities from joining a group
    /// <example><br/>Example:<code>
    /// var response = groupApi.UnblockEntityAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "Entity": {
    ///     "Id": "90901000",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/unblockentity">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnblockEntityAsync(UnblockEntityRequest request);
    /// <summary>
    /// Updates non-membership data about a group.
    /// <example><br/>Example:<code>
    /// var response = groupApi.UpdateGroupAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "GroupName": "My New Group Name",
    ///   "ExpectedProfileVersion": 17
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/updategroup">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request);
    /// <summary>
    /// Updates metadata about a role.
    /// <example><br/>Example:<code>
    /// var response = groupApi.UpdateRoleAsync({);
    ///   "Group": {
    ///     "Id": "ABC1234ABC"
    ///   },
    ///   "RoleId": "ABC1234DEF",
    ///   "RoleName": "My New Role Name",
    ///   "ExpectedProfileVersion": 17
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/group/groups/updaterole">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateGroupRoleResponse> UpdateRoleAsync(UpdateGroupRoleRequest request);
}