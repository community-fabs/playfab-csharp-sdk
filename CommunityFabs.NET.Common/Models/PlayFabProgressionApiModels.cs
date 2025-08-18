using CommunityFabs.NET.Common.Http;

namespace CommunityFabs.NET.Common.Models.Progression;

public class CreateLeaderboardDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// Leaderboard columns describing the sort directions, cannot be changed after creation. A maximum of 5 columns are
    /// allowed.
    /// </summary>
    public required List<LeaderboardColumn> Columns { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity type being represented on the leaderboard. If it doesn't correspond to the PlayFab entity types, use
    /// 'external' as the type.
    /// </summary>
    public required string EntityType { get; set; }
    /// <summary>
    /// [In Preview]: The configuration for the events emitted by this leaderboard. If not specified, no events will be emitted.
    /// </summary>
    public LeaderboardEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// A name for the leaderboard, unique per title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Maximum number of entries on this leaderboard
    /// </summary>
    public int SizeLimit { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class CreateStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// [In Preview]: The list of statistic definition names whose scores must be aggregated towards this stat. If
    /// AggregationSource is specified, the entityType of this definition MUST be Title (making it a CommunityStat). Currently,
    /// only one aggregation source can be specified.
    /// </summary>
    public List<string>? AggregationSources { get; set; }
    /// <summary>
    /// The columns for the statistic defining the aggregation method for each column. A maximum of 5 columns are allowed.
    /// </summary>
    public List<StatisticColumn>? Columns { get; set; }
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entity type allowed to have score(s) for this statistic.
    /// </summary>
    public string? EntityType { get; set; }
    /// <summary>
    /// [In Preview]: Configurations for different Statistics events that can be emitted by the service.
    /// </summary>
    public StatisticsEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Name of the statistic. Must be less than 150 characters. Restricted to a-Z, 0-9, '(', ')', '_', '-' and '.'.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The version reset configuration for the statistic definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class DeleteLeaderboardDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the leaderboard definition to delete.
    /// </summary>
    public required string Name { get; set; }
}

public class DeleteLeaderboardEntriesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The unique Ids of the entries to delete from the leaderboard.
    /// </summary>
    public List<string>? EntityIds { get; set; }
    /// <summary>
    /// The name of the leaderboard.
    /// </summary>
    public required string Name { get; set; }
}

public class DeleteStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the statistic to delete.
    /// </summary>
    public required string Name { get; set; }
}

public class DeleteStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Collection of statistics to remove from this entity.
    /// </summary>
    public required List<StatisticDelete> Statistics { get; set; }
}

public class DeleteStatisticsResponse : PlayFabResultCommon {
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    /// <summary>
    /// Unique ID of the entity.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Entity type. See https://docs.microsoft.com/gaming/playfab/features/data/entities/available-built-in-entity-types
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Alternate name for Type.
    /// </summary>
    public string? TypeString { get; set; }
}

/// <summary>
/// Individual rank of an entity in a leaderboard
/// </summary>
public class EntityLeaderboardEntry {
    /// <summary>
    /// Entity's display name.
    /// </summary>
    public string? DisplayName { get; set; }
    /// <summary>
    /// Entity identifier.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The time at which the last update to the entry was recorded on the server.
    /// </summary>
    public required DateTime LastUpdated { get; set; }
    /// <summary>
    /// An opaque blob of data stored on the leaderboard entry. Note that the metadata is not used for ranking purposes.
    /// </summary>
    public string? Metadata { get; set; }
    /// <summary>
    /// Position on the leaderboard.
    /// </summary>
    public int Rank { get; set; }
    /// <summary>
    /// Scores for the entry.
    /// </summary>
    public List<string>? Scores { get; set; }
}

public class EntityStatistics {
    /// <summary>
    /// The entity for which the statistics are returned.
    /// </summary>
    public EntityKey? EntityKey { get; set; }
    /// <summary>
    /// The statistics for the given entity key.
    /// </summary>
    public List<EntityStatisticValue>? Statistics { get; set; }
}

public class EntityStatisticValue {
    /// <summary>
    /// Metadata associated with the Statistic.
    /// </summary>
    public string? Metadata { get; set; }
    /// <summary>
    /// Statistic name
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Statistic scores
    /// </summary>
    public List<string>? Scores { get; set; }
    /// <summary>
    /// Statistic version
    /// </summary>
    public int Version { get; set; }
}

public enum EventType {
    None,
    Telemetry,
    PlayStream,
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
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the leaderboard.
    /// </summary>
    public required string LeaderboardName { get; set; }
    /// <summary>
    /// Maximum number of results to return from the leaderboard. Minimum 1, maximum 100.
    /// </summary>
    public uint PageSize { get; set; }
    /// <summary>
    /// Index position to start from. 1 is beginning of leaderboard.
    /// </summary>
    public uint? StartingPosition { get; set; }
    /// <summary>
    /// Optional version of the leaderboard, defaults to current version.
    /// </summary>
    public uint? Version { get; set; }
}

/// <summary>
/// Leaderboard response
/// </summary>
public class GetEntityLeaderboardResponse : PlayFabResultCommon {
    /// <summary>
    /// Leaderboard columns describing the sort directions.
    /// </summary>
    public List<LeaderboardColumn>? Columns { get; set; }
    /// <summary>
    /// The number of entries on the leaderboard.
    /// </summary>
    public uint EntryCount { get; set; }
    /// <summary>
    /// The time the next scheduled reset will occur. Null if the leaderboard does not reset on a schedule.
    /// </summary>
    public DateTime? NextReset { get; set; }
    /// <summary>
    /// Individual entity rankings in the leaderboard, in sorted order by rank.
    /// </summary>
    public List<EntityLeaderboardEntry>? Rankings { get; set; }
    /// <summary>
    /// Version of the leaderboard being returned.
    /// </summary>
    public uint Version { get; set; }
}

public class GetFriendLeaderboardForEntityRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Indicates which other platforms' friends should be included in the response. In HTTP, it is represented as a
    /// comma-separated list of platforms.
    /// </summary>
    public ExternalFriendSources? ExternalFriendSources { get; set; }
    /// <summary>
    /// Name of the leaderboard.
    /// </summary>
    public required string LeaderboardName { get; set; }
    /// <summary>
    /// Optional version of the leaderboard, defaults to current version.
    /// </summary>
    public uint? Version { get; set; }
    /// <summary>
    /// Xbox token if Xbox friends should be included. Requires Xbox be configured on PlayFab.
    /// </summary>
    public string? XboxToken { get; set; }
}

/// <summary>
/// Request to load a section of a leaderboard centered on a specific entity.
/// </summary>
public class GetLeaderboardAroundEntityRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Name of the leaderboard.
    /// </summary>
    public required string LeaderboardName { get; set; }
    /// <summary>
    /// Number of surrounding entries to return (in addition to specified entity). In general, the number of ranks above and
    /// below will be split into half. For example, if the specified value is 10, 5 ranks above and 5 ranks below will be
    /// retrieved. However, the numbers will get skewed in either direction when the specified entity is towards the top or
    /// bottom of the leaderboard. Also, the number of entries returned can be lower than the value specified for entries at
    /// the bottom of the leaderboard.
    /// </summary>
    public uint MaxSurroundingEntries { get; set; }
    /// <summary>
    /// Optional version of the leaderboard, defaults to current.
    /// </summary>
    public uint? Version { get; set; }
}

public class GetLeaderboardDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the leaderboard to retrieve the definition for.
    /// </summary>
    public required string Name { get; set; }
}

public class GetLeaderboardDefinitionResponse : PlayFabResultCommon {
    /// <summary>
    /// Sort direction of the leaderboard columns, cannot be changed after creation.
    /// </summary>
    public required List<LeaderboardColumn> Columns { get; set; }
    /// <summary>
    /// Created time, in UTC
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The entity type being represented on the leaderboard. If it doesn't correspond to the PlayFab entity types, use
    /// 'external' as the type.
    /// </summary>
    public required string EntityType { get; set; }
    /// <summary>
    /// [In Preview]: The configuration for the events emitted by this leaderboard. If not specified, no events will be emitted.
    /// </summary>
    public LeaderboardEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Last time, in UTC, leaderboard version was incremented.
    /// </summary>
    public DateTime? LastResetTime { get; set; }
    /// <summary>
    /// A name for the leaderboard, unique per title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Maximum number of entries on this leaderboard
    /// </summary>
    public int SizeLimit { get; set; }
    /// <summary>
    /// Latest Leaderboard version.
    /// </summary>
    public uint Version { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public required VersionConfiguration VersionConfiguration { get; set; }
}

/// <summary>
/// Request a leaderboard limited to a collection of entities.
/// </summary>
public class GetLeaderboardForEntitiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Collection of Entity IDs to include in the leaderboard.
    /// </summary>
    public required List<string> EntityIds { get; set; }
    /// <summary>
    /// Name of the leaderboard.
    /// </summary>
    public required string LeaderboardName { get; set; }
    /// <summary>
    /// Optional version of the leaderboard, defaults to current.
    /// </summary>
    public uint? Version { get; set; }
}

public class GetStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the statistic. Must be less than 150 characters.
    /// </summary>
    public required string Name { get; set; }
}

public class GetStatisticDefinitionResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of statistic definitions names this definition aggregates to.
    /// </summary>
    public List<string>? AggregationDestinations { get; set; }
    /// <summary>
    /// The list of statistic definitions names whose values must be aggregated towards this stat. If AggregationSource is
    /// specified, the entityType of this definition MUST be Title (making it a CommunityStat). Currently, only one aggregation
    /// source can be specified.
    /// </summary>
    public List<string>? AggregationSources { get; set; }
    /// <summary>
    /// The columns for the statistic defining the aggregation method for each column.
    /// </summary>
    public List<StatisticColumn>? Columns { get; set; }
    /// <summary>
    /// Created time, in UTC
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The entity type that can have this statistic.
    /// </summary>
    public string? EntityType { get; set; }
    /// <summary>
    /// [In Preview]: Configurations for different Statistics events that can be emitted by the service.
    /// </summary>
    public StatisticsEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Last time, in UTC, statistic version was incremented.
    /// </summary>
    public DateTime? LastResetTime { get; set; }
    /// <summary>
    /// The list of leaderboards that are linked to this statistic definition.
    /// </summary>
    public List<string>? LinkedLeaderboardNames { get; set; }
    /// <summary>
    /// Name of the statistic.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Statistic version.
    /// </summary>
    public uint Version { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

[Obsolete("Do not use")]
public class GetStatisticDefinitionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

[Obsolete("Do not use")]
public class GetStatisticDefinitionsResponse : PlayFabResultCommon {
    /// <summary>
    /// List of statistic definitions for the title.
    /// </summary>
    public List<StatisticDefinition>? StatisticDefinitions { get; set; }
}

public class GetStatisticsForEntitiesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Collection of Entity IDs to retrieve statistics for.
    /// </summary>
    public required List<EntityKey> Entities { get; set; }
    /// <summary>
    /// The list of statistics to return for the user. If set to null, the current version of all statistics are returned.
    /// </summary>
    public List<string>? StatisticNames { get; set; }
}

public class GetStatisticsForEntitiesResponse : PlayFabResultCommon {
    /// <summary>
    /// A mapping of statistic name to the columns defined in the corresponding definition.
    /// </summary>
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    /// <summary>
    /// List of entities mapped to their statistics. Only the latest version of a statistic is returned.
    /// </summary>
    public List<EntityStatistics>? EntitiesStatistics { get; set; }
}

public class GetStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// The list of statistics to return for the user. If set to null, the current version of all statistics are returned.
    /// </summary>
    public List<string>? StatisticNames { get; set; }
}

public class GetStatisticsResponse : PlayFabResultCommon {
    /// <summary>
    /// A mapping of statistic name to the columns defined in the corresponding definition.
    /// </summary>
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// List of statistics keyed by Name. Only the latest version of a statistic is returned.
    /// </summary>
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
}

public class IncrementLeaderboardVersionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the leaderboard to increment the version for.
    /// </summary>
    public required string Name { get; set; }
}

public class IncrementLeaderboardVersionResponse : PlayFabResultCommon {
    /// <summary>
    /// New Leaderboard version.
    /// </summary>
    public uint Version { get; set; }
}

public class IncrementStatisticVersionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Name of the statistic to increment the version of.
    /// </summary>
    public required string Name { get; set; }
}

public class IncrementStatisticVersionResponse : PlayFabResultCommon {
    /// <summary>
    /// New statistic version.
    /// </summary>
    public uint Version { get; set; }
}

public class LeaderboardColumn {
    /// <summary>
    /// If the value for this column is sourced from a statistic, details of the linked column. Null if the leaderboard is not
    /// linked.
    /// </summary>
    public LinkedStatisticColumn? LinkedStatisticColumn { get; set; }
    /// <summary>
    /// A name for the leaderboard column, unique per leaderboard definition.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The sort direction for this column.
    /// </summary>
    public LeaderboardSortDirection SortDirection { get; set; }
}

public class LeaderboardDefinition {
    /// <summary>
    /// Sort direction of the leaderboard columns, cannot be changed after creation.
    /// </summary>
    public required List<LeaderboardColumn> Columns { get; set; }
    /// <summary>
    /// Created time, in UTC
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The entity type being represented on the leaderboard. If it doesn't correspond to the PlayFab entity types, use
    /// 'external' as the type.
    /// </summary>
    public required string EntityType { get; set; }
    /// <summary>
    /// [In Preview]: The configuration for the events emitted by this leaderboard. If not specified, no events will be emitted.
    /// </summary>
    public LeaderboardEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Last time, in UTC, leaderboard version was incremented.
    /// </summary>
    public DateTime? LastResetTime { get; set; }
    /// <summary>
    /// A name for the leaderboard, unique per title.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Maximum number of entries on this leaderboard
    /// </summary>
    public int SizeLimit { get; set; }
    /// <summary>
    /// Latest Leaderboard version.
    /// </summary>
    public uint Version { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public required VersionConfiguration VersionConfiguration { get; set; }
}

public class LeaderboardEntityRankOnVersionEndConfig {
    /// <summary>
    /// The type of event to emit when the leaderboard version end.
    /// </summary>
    public EventType EventType { get; set; }
    /// <summary>
    /// The maximum number of entity to return on leaderboard version end. Range is 1 to 1000.
    /// </summary>
    public int RankLimit { get; set; }
}

public class LeaderboardEntryUpdate {
    /// <summary>
    /// The unique Id for the entry. If using PlayFab Entities, this would be the entityId of the entity.
    /// </summary>
    public required string EntityId { get; set; }
    /// <summary>
    /// Arbitrary metadata to store along side the leaderboard entry, will be returned by all Leaderboard APIs. Must be less
    /// than 50 UTF8 encoded characters.
    /// </summary>
    public string? Metadata { get; set; }
    /// <summary>
    /// The scores for the leaderboard. The number of values provided here must match the number of columns in the Leaderboard
    /// definition.
    /// </summary>
    public List<string>? Scores { get; set; }
}

public class LeaderboardEventEmissionConfig {
    /// <summary>
    /// This event emits the top ranks of the leaderboard when the leaderboard version end.
    /// </summary>
    public LeaderboardEntityRankOnVersionEndConfig? EntityRankOnVersionEndConfig { get; set; }
    /// <summary>
    /// This event is emitted when the leaderboard version end.
    /// </summary>
    public LeaderboardVersionEndConfig? VersionEndConfig { get; set; }
}

public enum LeaderboardSortDirection {
    Descending,
    Ascending,
}

public class LeaderboardVersionEndConfig {
    /// <summary>
    /// The type of event to emit when the leaderboard version end.
    /// </summary>
    public EventType EventType { get; set; }
}

public class LinkedStatisticColumn {
    /// <summary>
    /// The name of the statistic column that this leaderboard column is sourced from.
    /// </summary>
    public required string LinkedStatisticColumnName { get; set; }
    /// <summary>
    /// The name of the statistic.
    /// </summary>
    public required string LinkedStatisticName { get; set; }
}

public class ListLeaderboardDefinitionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListLeaderboardDefinitionsResponse : PlayFabResultCommon {
    /// <summary>
    /// List of leaderboard definitions for the title.
    /// </summary>
    public List<LeaderboardDefinition>? LeaderboardDefinitions { get; set; }
}

public class ListStatisticDefinitionsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class ListStatisticDefinitionsResponse : PlayFabResultCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// List of statistic definitions for the title.
    /// </summary>
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
    /// <summary>
    /// Aggregation method for calculating new value of a statistic.
    /// </summary>
    public StatisticAggregationMethod AggregationMethod { get; set; }
    /// <summary>
    /// Name of the statistic column, as originally configured.
    /// </summary>
    public required string Name { get; set; }
}

public class StatisticColumnCollection {
    /// <summary>
    /// Columns for the statistic defining the aggregation method for each column.
    /// </summary>
    public List<StatisticColumn>? Columns { get; set; }
}

public class StatisticDefinition {
    /// <summary>
    /// The list of statistic definitions names this definition aggregates to.
    /// </summary>
    public List<string>? AggregationDestinations { get; set; }
    /// <summary>
    /// The list of statistic definitions names whose values must be aggregated towards this stat. If AggregationSource is
    /// specified, the entityType of this definition MUST be Title (making it a CommunityStat). Currently, only one aggregation
    /// source can be specified.
    /// </summary>
    public List<string>? AggregationSources { get; set; }
    /// <summary>
    /// The columns for the statistic defining the aggregation method for each column.
    /// </summary>
    public List<StatisticColumn>? Columns { get; set; }
    /// <summary>
    /// Created time, in UTC
    /// </summary>
    public required DateTime Created { get; set; }
    /// <summary>
    /// The entity type that can have this statistic.
    /// </summary>
    public string? EntityType { get; set; }
    /// <summary>
    /// [In Preview]: Configurations for different Statistics events that can be emitted by the service.
    /// </summary>
    public StatisticsEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Last time, in UTC, statistic version was incremented.
    /// </summary>
    public DateTime? LastResetTime { get; set; }
    /// <summary>
    /// The list of leaderboards that are linked to this statistic definition.
    /// </summary>
    public List<string>? LinkedLeaderboardNames { get; set; }
    /// <summary>
    /// Name of the statistic.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Statistic version.
    /// </summary>
    public uint Version { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class StatisticDelete {
    /// <summary>
    /// Name of the statistic, as originally configured.
    /// </summary>
    public required string Name { get; set; }
}

public class StatisticsEventEmissionConfig {
    /// <summary>
    /// Emitted when statistics are updated.
    /// </summary>
    public StatisticsUpdateEventConfig? UpdateEventConfig { get; set; }
}

public class StatisticsUpdateEventConfig {
    /// <summary>
    /// The event type to emit when statistics are updated.
    /// </summary>
    public EventType EventType { get; set; }
}

public class StatisticUpdate {
    /// <summary>
    /// Arbitrary metadata to store along side the statistic, will be returned by all Leaderboard APIs. Must be less than 50
    /// UTF8 encoded characters.
    /// </summary>
    public string? Metadata { get; set; }
    /// <summary>
    /// Name of the statistic, as originally configured.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Statistic scores for the entity. This will be used in accordance with the aggregation method configured for the
    /// statistics.The maximum value allowed for each individual score is 9223372036854775807. The minimum value for each
    /// individual score is -9223372036854775807The values are formatted as strings to avoid interop issues with client
    /// libraries unable to handle 64bit integers.
    /// </summary>
    public List<string>? Scores { get; set; }
    /// <summary>
    /// Optional field to indicate the version of the statistic to set. When empty defaults to the statistic's current version.
    /// </summary>
    public uint? Version { get; set; }
}

public class UnlinkLeaderboardFromStatisticRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the leaderboard definition to unlink.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The name of the statistic definition to unlink.
    /// </summary>
    public required string StatisticName { get; set; }
}

public class UpdateLeaderboardDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// [In Preview]: The configuration for the events emitted by this leaderboard. If not specified, no events will be emitted.
    /// </summary>
    public LeaderboardEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// The name of the leaderboard to update the definition for.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Maximum number of entries on this leaderboard
    /// </summary>
    public int? SizeLimit { get; set; }
    /// <summary>
    /// The version reset configuration for the leaderboard definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class UpdateLeaderboardEntriesRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The entries to add or update on the leaderboard.
    /// </summary>
    public List<LeaderboardEntryUpdate>? Entries { get; set; }
    /// <summary>
    /// The name of the leaderboard.
    /// </summary>
    public required string LeaderboardName { get; set; }
}

public class UpdateStatisticDefinitionRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// [In Preview]: Configurations for different Statistics events that can be emitted by the service.
    /// </summary>
    public StatisticsEventEmissionConfig? EventEmissionConfig { get; set; }
    /// <summary>
    /// Name of the statistic. Must be less than 150 characters. Restricted to a-Z, 0-9, '(', ')', '_', '-' and '.'.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The version reset configuration for the statistic definition.
    /// </summary>
    public VersionConfiguration? VersionConfiguration { get; set; }
}

public class UpdateStatisticsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Collection of statistics to update, maximum 50.
    /// </summary>
    public required List<StatisticUpdate> Statistics { get; set; }
    /// <summary>
    /// Optional transactionId of this update which can be used to ensure idempotence. Using this field is still in testing
    /// stage.
    /// </summary>
    public string? TransactionId { get; set; }
}

public class UpdateStatisticsResponse : PlayFabResultCommon {
    /// <summary>
    /// A mapping of statistic name to the columns defined in the corresponding definition.
    /// </summary>
    public Dictionary<string, StatisticColumnCollection>? ColumnDetails { get; set; }
    /// <summary>
    /// The entity id and type.
    /// </summary>
    public EntityKey? Entity { get; set; }
    /// <summary>
    /// Updated entity profile statistics.
    /// </summary>
    public Dictionary<string, EntityStatisticValue>? Statistics { get; set; }
}

public class VersionConfiguration {
    /// <summary>
    /// The maximum number of versions of this leaderboard/statistic that can be queried.
    /// </summary>
    public int MaxQueryableVersions { get; set; }
    /// <summary>
    /// Reset interval that statistics or leaderboards will reset on. When using Manual intervalthe reset can only be increased
    /// by calling the Increase version API. When using Hour interval the resetwill occur at the start of the next hour UTC
    /// time. When using Day interval the reset will occur at thestart of the next day in UTC time. When using the Week
    /// interval the reset will occur at the start ofthe next Monday in UTC time. When using Month interval the reset will
    /// occur at the start of the nextmonth in UTC time.
    /// </summary>
    public ResetInterval ResetInterval { get; set; }
}

