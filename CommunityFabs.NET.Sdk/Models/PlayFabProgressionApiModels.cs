namespace CommunityFabs.NET.Sdk.Models.Progression;

public class CreateLeaderboardDefinitionRequest : PlayFabRequestCommon {
    public required List<LeaderboardColumn> Columns { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string EntityType { get; set; }
    public required string Name { get; set; }
    public int SizeLimit { get; set; }
    public required VersionConfiguration VersionConfiguration { get; set; }
}

public class CreateStatisticDefinitionRequest : PlayFabRequestCommon {
    public List<string>? AggregationSources { get; set; }
    public List<StatisticColumn>? Columns { get; set; }
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? EntityType { get; set; }
    public required string Name { get; set; }
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class DeleteLeaderboardDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class DeleteLeaderboardEntriesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<string>? EntityIds { get; set; }
    public required string Name { get; set; }
}

public class DeleteStatisticDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class DeleteStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required List<StatisticDelete> Statistics { get; set; }
}

public class DeleteStatisticsResponse : PlayFabResultCommon {
    public EntityKey? Entity { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

/// <summary>
/// Individual rank of an entity in a leaderboard
/// </summary>
public class EntityLeaderboardEntry {
    public string? DisplayName { get; set; }
    public EntityKey? Entity { get; set; }
    public required DateTime LastUpdated { get; set; }
    public string? Metadata { get; set; }
    public int Rank { get; set; }
    public List<string>? Scores { get; set; }
}

public class EntityStatistics {
    public EntityKey? EntityKey { get; set; }
    public List<EntityStatisticValue>? Statistics { get; set; }
}

public class EntityStatisticValue {
    public string? Metadata { get; set; }
    public string? Name { get; set; }
    public List<string>? Scores { get; set; }
    public int Version { get; set; }
}

public enum ExternalFriendSources {
    None,
    Steam,
    Facebook,
    Xbox,
    Psn,
    All,
}

/// <summary>
/// Request to load a leaderboard.
/// </summary>
public class GetEntityLeaderboardRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string LeaderboardName { get; set; }
    public UInt32 PageSize { get; set; }
    public UInt32? StartingPosition { get; set; }
    public UInt32? Version { get; set; }
}

/// <summary>
/// Leaderboard response
/// </summary>
public class GetEntityLeaderboardResponse : PlayFabResultCommon {
    public List<LeaderboardColumn>? Columns { get; set; }
    public UInt32 EntryCount { get; set; }
    public DateTime? NextReset { get; set; }
    public List<EntityLeaderboardEntry>? Rankings { get; set; }
    public UInt32 Version { get; set; }
}

public class GetFriendLeaderboardForEntityRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public ExternalFriendSources? ExternalFriendSources { get; set; }
    public required string LeaderboardName { get; set; }
    public UInt32? Version { get; set; }
    public string? XboxToken { get; set; }
}

/// <summary>
/// Request to load a section of a leaderboard centered on a specific entity.
/// </summary>
public class GetLeaderboardAroundEntityRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required string LeaderboardName { get; set; }
    public UInt32 MaxSurroundingEntries { get; set; }
    public UInt32? Version { get; set; }
}

public class GetLeaderboardDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class GetLeaderboardDefinitionResponse : PlayFabResultCommon {
    public required List<LeaderboardColumn> Columns { get; set; }
    public required DateTime Created { get; set; }
    public required string EntityType { get; set; }
    public DateTime? LastResetTime { get; set; }
    public required string Name { get; set; }
    public int SizeLimit { get; set; }
    public UInt32 Version { get; set; }
    public required VersionConfiguration VersionConfiguration { get; set; }
}

/// <summary>
/// Request a leaderboard limited to a collection of entities.
/// </summary>
public class GetLeaderboardForEntitiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<string> EntityIds { get; set; }
    public required string LeaderboardName { get; set; }
    public UInt32? Version { get; set; }
}

public class GetStatisticDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class GetStatisticDefinitionResponse : PlayFabResultCommon {
    public List<string>? AggregationDestinations { get; set; }
    public List<string>? AggregationSources { get; set; }
    public List<StatisticColumn>? Columns { get; set; }
    public required DateTime Created { get; set; }
    public string? EntityType { get; set; }
    public DateTime? LastResetTime { get; set; }
    public List<string>? LinkedLeaderboardNames { get; set; }
    public string? Name { get; set; }
    public UInt32 Version { get; set; }
    public VersionConfiguration? VersionConfiguration { get; set; }
}

[Obsolete("Do not use")]
public class GetStatisticDefinitionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

[Obsolete("Do not use")]
public class GetStatisticDefinitionsResponse : PlayFabResultCommon {
    public List<StatisticDefinition>? StatisticDefinitions { get; set; }
}

public class GetStatisticsForEntitiesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required List<EntityKey> Entities { get; set; }
    public List<string>? StatisticNames { get; set; }
}

public class GetStatisticsForEntitiesResponse : PlayFabResultCommon {
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    public List<EntityStatistics>? EntitiesStatistics { get; set; }
}

public class GetStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public List<string>? StatisticNames { get; set; }
}

public class GetStatisticsResponse : PlayFabResultCommon {
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    public EntityKey? Entity { get; set; }
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
}

public class IncrementLeaderboardVersionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class IncrementLeaderboardVersionResponse : PlayFabResultCommon {
    public UInt32 Version { get; set; }
}

public class IncrementStatisticVersionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
}

public class IncrementStatisticVersionResponse : PlayFabResultCommon {
    public UInt32 Version { get; set; }
}

public class LeaderboardColumn {
    public LinkedStatisticColumn? LinkedStatisticColumn { get; set; }
    public required string Name { get; set; }
    public LeaderboardSortDirection SortDirection { get; set; }
}

public class LeaderboardDefinition {
    public required List<LeaderboardColumn> Columns { get; set; }
    public required DateTime Created { get; set; }
    public required string EntityType { get; set; }
    public DateTime? LastResetTime { get; set; }
    public required string Name { get; set; }
    public int SizeLimit { get; set; }
    public UInt32 Version { get; set; }
    public required VersionConfiguration VersionConfiguration { get; set; }
}

public class LeaderboardEntryUpdate {
    public required string EntityId { get; set; }
    public string? Metadata { get; set; }
    public List<string>? Scores { get; set; }
}

public enum LeaderboardSortDirection {
    Descending,
    Ascending,
}

public class LinkedStatisticColumn {
    public required string LinkedStatisticColumnName { get; set; }
    public required string LinkedStatisticName { get; set; }
}

public class ListLeaderboardDefinitionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListLeaderboardDefinitionsResponse : PlayFabResultCommon {
    public List<LeaderboardDefinition>? LeaderboardDefinitions { get; set; }
}

public class ListStatisticDefinitionsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListStatisticDefinitionsResponse : PlayFabResultCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<StatisticDefinition>? StatisticDefinitions { get; set; }
}

public enum ResetInterval {
    Manual,
    Hour,
    Day,
    Week,
    Month,
}

public enum StatisticAggregationMethod {
    Last,
    Min,
    Max,
    Sum,
}

public class StatisticColumn {
    public StatisticAggregationMethod AggregationMethod { get; set; }
    public required string Name { get; set; }
}

public class StatisticColumnCollection {
    public List<StatisticColumn>? Columns { get; set; }
}

public class StatisticDefinition {
    public List<string>? AggregationDestinations { get; set; }
    public List<string>? AggregationSources { get; set; }
    public List<StatisticColumn>? Columns { get; set; }
    public required DateTime Created { get; set; }
    public string? EntityType { get; set; }
    public DateTime? LastResetTime { get; set; }
    public List<string>? LinkedLeaderboardNames { get; set; }
    public string? Name { get; set; }
    public UInt32 Version { get; set; }
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class StatisticDelete {
    public required string Name { get; set; }
}

public class StatisticUpdate {
    public string? Metadata { get; set; }
    public required string Name { get; set; }
    public List<string>? Scores { get; set; }
    public UInt32? Version { get; set; }
}

public class UnlinkLeaderboardFromStatisticRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
    public required string StatisticName { get; set; }
}

public class UpdateLeaderboardDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
    public int? SizeLimit { get; set; }
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class UpdateLeaderboardEntriesRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public List<LeaderboardEntryUpdate>? Entries { get; set; }
    public required string LeaderboardName { get; set; }
}

public class UpdateStatisticDefinitionRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string Name { get; set; }
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class UpdateStatisticsRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
    public required List<StatisticUpdate> Statistics { get; set; }
    public string? TransactionId { get; set; }
}

public class UpdateStatisticsResponse : PlayFabResultCommon {
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    public EntityKey? Entity { get; set; }
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
}

public class VersionConfiguration {
    public int MaxQueryableVersions { get; set; }
    public ResetInterval ResetInterval { get; set; }
}

