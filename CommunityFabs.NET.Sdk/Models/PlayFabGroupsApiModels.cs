namespace CommunityFabs.NET.Sdk.Models.Groups;

/// <summary>
/// Accepts an outstanding invitation to to join a group if the invited entity is not blocked by the group. Nothing is returned in the case of success.
/// </summary>
public class AcceptGroupApplicationRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Accepts an outstanding invitation to join the group if the invited entity is not blocked by the group. Only the invited entity or a parent in its chain (e.g. title) may accept the invitation on the invited entity's behalf. Nothing is returned in the case of success.
/// </summary>
public class AcceptGroupInvitationRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Adds members to a group or role. Existing members of the group will added to roles within the group, but if the user is not already a member of the group, only title claimants may add them to the group, and others must use the group application or invite system to add new members to a group. Returns nothing if successful.
/// </summary>
public class AddMembersRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
    public required List<EntityKey> Members { get; set; }
    public string? RoleId { get; set; }
}

/// <summary>
/// Creates an application to join a group. Calling this while a group application already exists will return the same application instead of an error and will not refresh the time before the application expires. By default, if the entity has an invitation to join the group outstanding, this will accept the invitation to join the group instead and return an error indicating such, rather than creating a duplicate application to join that will need to be cleaned up later. Returns information about the application or an error indicating an invitation was accepted instead.
/// </summary>
public class ApplyToGroupRequest {
    public bool? AutoAcceptOutstandingInvite { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Describes an application to join a group
/// </summary>
public class ApplyToGroupResponse {
    public EntityWithLineage? Entity { get; set; }
    public required DateTime Expires { get; set; }
    public EntityKey? Group { get; set; }
}

/// <summary>
/// Blocks a list of entities from joining a group. Blocked entities may not create new applications to join, be invited to join, accept an invitation, or have an application accepted. Failure due to being blocked does not clean up existing applications or invitations to the group. No data is returned in the case of success.
/// </summary>
public class BlockEntityRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Changes the role membership of a list of entities from one role to another in in a single operation. The destination role must already exist. This is equivalent to adding the entities to the destination role and removing from the origin role. Returns nothing if successful.
/// </summary>
public class ChangeMemberRoleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? DestinationRoleId { get; set; }
    public required EntityKey Group { get; set; }
    public required List<EntityKey> Members { get; set; }
    public required string OriginRoleId { get; set; }
}

/// <summary>
/// Creates a new group, as well as administration and member roles, based off of a title's group template. Returns information about the group that was created.
/// </summary>
public class CreateGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string GroupName { get; set; }
}

public class CreateGroupResponse {
    public string? AdminRoleId { get; set; }
    public required DateTime Created { get; set; }
    public required EntityKey Group { get; set; }
    public string? GroupName { get; set; }
    public string? MemberRoleId { get; set; }
    public int ProfileVersion { get; set; }
    public Dictionary<string, string>? Roles { get; set; }
}

/// <summary>
/// Creates a new role within an existing group, with no members. Both the role ID and role name must be unique within the group, but the name can be the same as the ID. The role ID is set at creation and cannot be changed. Returns information about the role that was created.
/// </summary>
public class CreateGroupRoleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
    public required string RoleId { get; set; }
    public required string RoleName { get; set; }
}

public class CreateGroupRoleResponse {
    public int ProfileVersion { get; set; }
    public string? RoleId { get; set; }
    public string? RoleName { get; set; }
}

/// <summary>
/// Deletes a group and all roles, invitations, join requests, and blocks associated with it. Permission to delete is only required the group itself to execute this action. The group and data cannot be cannot be recovered once removed, but any abuse reports about the group will remain. No data is returned in the case of success.
/// </summary>
public class DeleteGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Returns information about the role
/// </summary>
public class DeleteRoleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
    public string? RoleId { get; set; }
}

public class EmptyResponse {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class EntityMemberRole {
    public List<EntityWithLineage>? Members { get; set; }
    public string? RoleId { get; set; }
    public string? RoleName { get; set; }
}

/// <summary>
/// Entity wrapper class that contains the entity key and the entities that make up the lineage of the entity.
/// </summary>
public class EntityWithLineage {
    public EntityKey? Key { get; set; }
    public Dictionary<string, EntityKey>? Lineage { get; set; }
}

/// <summary>
/// Returns the ID, name, role list and other non-membership related information about a group.
/// </summary>
public class GetGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Group { get; set; }
    public string? GroupName { get; set; }
}

public class GetGroupResponse {
    public string? AdminRoleId { get; set; }
    public required DateTime Created { get; set; }
    public required EntityKey Group { get; set; }
    public string? GroupName { get; set; }
    public string? MemberRoleId { get; set; }
    public int ProfileVersion { get; set; }
    public Dictionary<string, string>? Roles { get; set; }
}

/// <summary>
/// Describes an application to join a group
/// </summary>
public class GroupApplication {
    public EntityWithLineage? Entity { get; set; }
    public required DateTime Expires { get; set; }
    public EntityKey? Group { get; set; }
}

/// <summary>
/// Describes an entity that is blocked from joining a group.
/// </summary>
public class GroupBlock {
    public EntityWithLineage? Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Describes an invitation to a group.
/// </summary>
public class GroupInvitation {
    public required DateTime Expires { get; set; }
    public EntityKey? Group { get; set; }
    public EntityWithLineage? InvitedByEntity { get; set; }
    public EntityWithLineage? InvitedEntity { get; set; }
    public string? RoleId { get; set; }
}

/// <summary>
/// Describes a group role
/// </summary>
public class GroupRole {
    public string? RoleId { get; set; }
    public string? RoleName { get; set; }
}

/// <summary>
/// Describes a group and the roles that it contains
/// </summary>
public class GroupWithRoles {
    public EntityKey? Group { get; set; }
    public string? GroupName { get; set; }
    public int ProfileVersion { get; set; }
    public List<GroupRole>? Roles { get; set; }
}

/// <summary>
/// Invites a player to join a group, if they are not blocked by the group. An optional role can be provided to automatically assign the player to the role if they accept the invitation. By default, if the entity has an application to the group outstanding, this will accept the application instead and return an error indicating such, rather than creating a duplicate invitation to join that will need to be cleaned up later. Returns information about the new invitation or an error indicating an existing application to join was accepted.
/// </summary>
public class InviteToGroupRequest {
    public bool? AutoAcceptOutstandingApplication { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
    public string? RoleId { get; set; }
}

/// <summary>
/// Describes an invitation to a group.
/// </summary>
public class InviteToGroupResponse {
    public required DateTime Expires { get; set; }
    public EntityKey? Group { get; set; }
    public EntityWithLineage? InvitedByEntity { get; set; }
    public EntityWithLineage? InvitedEntity { get; set; }
    public string? RoleId { get; set; }
}

/// <summary>
/// Checks to see if an entity is a member of a group or role within the group. A result indicating if the entity is a member of the group is returned, or a permission error if the caller does not have permission to read the group's member list.
/// </summary>
public class IsMemberRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
    public string? RoleId { get; set; }
}

public class IsMemberResponse {
    public bool IsMember { get; set; }
}

/// <summary>
/// Lists all outstanding requests to join a group. Returns a list of all requests to join, as well as when the request will expire. To get the group applications for a specific entity, use ListMembershipOpportunities.
/// </summary>
public class ListGroupApplicationsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
}

public class ListGroupApplicationsResponse {
    public List<GroupApplication>? Applications { get; set; }
}

/// <summary>
/// Lists all entities blocked from joining a group. A list of blocked entities is returned
/// </summary>
public class ListGroupBlocksRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
}

public class ListGroupBlocksResponse {
    public List<GroupBlock>? BlockedEntities { get; set; }
}

/// <summary>
/// Lists all outstanding invitations for a group. Returns a list of entities that have been invited, as well as when the invitation will expire. To get the group invitations for a specific entity, use ListMembershipOpportunities.
/// </summary>
public class ListGroupInvitationsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
}

public class ListGroupInvitationsResponse {
    public List<GroupInvitation>? Invitations { get; set; }
}

/// <summary>
/// Gets a list of members and the roles they belong to within the group. If the caller does not have permission to view the role, and the member is in no other role, the member is not displayed. Returns a list of entities that are members of the group.
/// </summary>
public class ListGroupMembersRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
}

public class ListGroupMembersResponse {
    public List<EntityMemberRole>? Members { get; set; }
}

/// <summary>
/// Lists all outstanding group applications and invitations for an entity. Anyone may call this for any entity, but data will only be returned for the entity or a parent of that entity. To list invitations or applications for a group to check if a player is trying to join, use ListGroupInvitations and ListGroupApplications.
/// </summary>
public class ListMembershipOpportunitiesRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class ListMembershipOpportunitiesResponse {
    public List<GroupApplication>? Applications { get; set; }
    public List<GroupInvitation>? Invitations { get; set; }
}

/// <summary>
/// Lists the groups and roles that an entity is a part of, checking to see if group and role metadata and memberships should be visible to the caller. If the entity is not in any roles that are visible to the caller, the group is not returned in the results, even if the caller otherwise has permission to see that the entity is a member of that group.
/// </summary>
public class ListMembershipRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class ListMembershipResponse {
    public List<GroupWithRoles>? Groups { get; set; }
}

public enum OperationTypes {
    Created,
    Updated,
    Deleted,
    None,
}

/// <summary>
/// Removes an existing application to join the group. This is used for both rejection of an application as well as withdrawing an application. The applying entity or a parent in its chain (e.g. title) may withdraw the application, and any caller with appropriate access in the group may reject an application. No data is returned in the case of success.
/// </summary>
public class RemoveGroupApplicationRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Removes an existing invitation to join the group. This is used for both rejection of an invitation as well as rescinding an invitation. The invited entity or a parent in its chain (e.g. title) may reject the invitation by calling this method, and any caller with appropriate access in the group may rescind an invitation. No data is returned in the case of success.
/// </summary>
public class RemoveGroupInvitationRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Removes members from a group. A member can always remove themselves from a group, regardless of permissions. Returns nothing if successful.
/// </summary>
public class RemoveMembersRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Group { get; set; }
    public required List<EntityKey> Members { get; set; }
    public string? RoleId { get; set; }
}

/// <summary>
/// Unblocks a list of entities from joining a group. No data is returned in the case of success.
/// </summary>
public class UnblockEntityRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required EntityKey Entity { get; set; }
    public required EntityKey Group { get; set; }
}

/// <summary>
/// Updates data about a group, such as the name or default member role. Returns information about whether the update was successful. Only title claimants may modify the administration role for a group.
/// </summary>
public class UpdateGroupRequest {
    public string? AdminRoleId { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? ExpectedProfileVersion { get; set; }
    public required EntityKey Group { get; set; }
    public string? GroupName { get; set; }
    public string? MemberRoleId { get; set; }
}

public class UpdateGroupResponse {
    public string? OperationReason { get; set; }
    public int ProfileVersion { get; set; }
    public OperationTypes? SetResult { get; set; }
}

/// <summary>
/// Updates the role name. Returns information about whether the update was successful.
/// </summary>
public class UpdateGroupRoleRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public int? ExpectedProfileVersion { get; set; }
    public required EntityKey Group { get; set; }
    public string? RoleId { get; set; }
    public required string RoleName { get; set; }
}

public class UpdateGroupRoleResponse {
    public string? OperationReason { get; set; }
    public int ProfileVersion { get; set; }
    public OperationTypes? SetResult { get; set; }
}

