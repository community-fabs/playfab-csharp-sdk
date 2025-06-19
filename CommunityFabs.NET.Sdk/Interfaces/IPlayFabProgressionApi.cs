using CommunityFabs.NET.Sdk.Models.Progression;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabProgressionApi {
    /// <summary>
    /// Creates a new leaderboard definition.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.CreateLeaderboardDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel",
    ///   "EntityType": "title_player_account",
    ///   "VersionConfiguration": {
    ///     "ResetInterval": "Manual",
    ///     "MaxQueryableVersions": 1
    ///   },
    ///   "Columns": [
    ///     {
    ///       "Name": "Hits",
    ///       "SortDirection": "Descending"
    ///     }
    ///   ],
    ///   "SizeLimit": 1000
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/createleaderboarddefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> CreateLeaderboardDefinitionAsync(CreateLeaderboardDefinitionRequest request);
    /// <summary>
    /// Create a new entity statistic definition.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.CreateStatisticDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel",
    ///   "AggregationMethod": "Last",
    ///   "Columns": [
    ///     {
    ///       "AggregationMethod": "Min"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/createstatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> CreateStatisticDefinitionAsync(CreateStatisticDefinitionRequest request);
    /// <summary>
    /// Deletes a leaderboard definition.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.DeleteLeaderboardDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/deleteleaderboarddefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteLeaderboardDefinitionAsync(DeleteLeaderboardDefinitionRequest request);
    /// <summary>
    /// Deletes the specified entries from the given leaderboard.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.DeleteLeaderboardEntriesAsync({);
    ///   "Name": "Points",
    ///   "EntityIds": [
    ///     "12802710371",
    ///     "01849174301"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/deleteleaderboardentries">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteLeaderboardEntriesAsync(DeleteLeaderboardEntriesRequest request);
    /// <summary>
    /// Delete an entity statistic definition. Will delete all statistics on entity profiles and leaderboards.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.DeleteStatisticDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/deletestatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteStatisticDefinitionAsync(DeleteStatisticDefinitionRequest request);
    /// <summary>
    /// Delete statistics on an entity profile. This will remove all rankings from associated leaderboards.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.DeleteStatisticsAsync({);
    ///   "Statistics": [
    ///     {
    ///       "Name": "TotalCarTime"
    ///     },
    ///     {
    ///       "Name": "FastestTimesByMap",
    ///       "Version": 15
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/deletestatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<DeleteStatisticsResponse> DeleteStatisticsAsync(DeleteStatisticsRequest request);
    /// <summary>
    /// Get the friend leaderboard for the specified entity. A maximum of 25 friend entries are listed in the leaderboard.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.GetFriendLeaderboardForEntityAsync({);
    ///   "LeaderboardName": "Points",
    ///   "ExternalFriendSources": "None"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/getfriendleaderboardforentity">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityLeaderboardResponse> GetFriendLeaderboardForEntityAsync(GetFriendLeaderboardForEntityRequest request);
    /// <summary>
    /// Get the leaderboard for a specific entity type and statistic.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.GetLeaderboardAsync({);
    ///   "LeaderboardName": "Points",
    ///   "Version": 2,
    ///   "StartingPosition": 100,
    ///   "PageSize": 20
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/getleaderboard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityLeaderboardResponse> GetLeaderboardAsync(GetEntityLeaderboardRequest request);
    /// <summary>
    /// Get the leaderboard around a specific entity.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.GetLeaderboardAroundEntityAsync({);
    ///   "LeaderboardName": "Points",
    ///   "Version": 2,
    ///   "MaxSurroundingEntries": 0,
    ///   "Entity": {
    ///     "Id": "819478109412",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/getleaderboardaroundentity">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityLeaderboardResponse> GetLeaderboardAroundEntityAsync(GetLeaderboardAroundEntityRequest request);
    /// <summary>
    /// Gets the specified leaderboard definition.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.GetLeaderboardDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/getleaderboarddefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLeaderboardDefinitionResponse> GetLeaderboardDefinitionAsync(GetLeaderboardDefinitionRequest request);
    /// <summary>
    /// Get the leaderboard limited to a set of entities.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.GetLeaderboardForEntitiesAsync({);
    ///   "LeaderboardName": "Points",
    ///   "Version": 2,
    ///   "EntityIds": [
    ///     "12802710371",
    ///     "01849174301"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/getleaderboardforentities">Microsoft Documentation</see>
    /// </summary>
    public Task<GetEntityLeaderboardResponse> GetLeaderboardForEntitiesAsync(GetLeaderboardForEntitiesRequest request);
    /// <summary>
    /// Get current statistic definition information
    /// <example><br/>Example:<code>
    /// var response = statisticApi.GetStatisticDefinitionAsync({);
    ///   "Name": "Points"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/getstatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStatisticDefinitionResponse> GetStatisticDefinitionAsync(GetStatisticDefinitionRequest request);
    /// <summary>
    /// Get all current statistic definitions information
    /// <example><br/>Example:<code>
    /// var response = statisticApi.GetStatisticDefinitionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/getstatisticdefinitions">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStatisticDefinitionsResponse> GetStatisticDefinitionsAsync(GetStatisticDefinitionsRequest request);
    /// <summary>
    /// Gets statistics for the specified entity.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.GetStatisticsAsync({);
    ///   "StatisticNames": [
    ///     "SpeedRuns",
    ///     "Boosts"
    ///   ],
    ///   "Entity": {
    ///     "Id": "A197412JDA",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/getstatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStatisticsResponse> GetStatisticsAsync(GetStatisticsRequest request);
    /// <summary>
    /// Gets statistics for the specified collection of entities.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.GetStatisticsForEntitiesAsync({);
    ///   "Entities": [
    ///     {
    ///       "Id": "A197412JDA",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     },
    ///     {
    ///       "Id": "B197412JDB",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     }
    ///   ],
    ///   "StatisticNames": [
    ///     "SpeedRuns",
    ///     "Boosts"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/getstatisticsforentities">Microsoft Documentation</see>
    /// </summary>
    public Task<GetStatisticsForEntitiesResponse> GetStatisticsForEntitiesAsync(GetStatisticsForEntitiesRequest request);
    /// <summary>
    /// Increment a leaderboard version.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.IncrementLeaderboardVersionAsync({);
    ///   "Name": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/incrementleaderboardversion">Microsoft Documentation</see>
    /// </summary>
    public Task<IncrementLeaderboardVersionResponse> IncrementLeaderboardVersionAsync(IncrementLeaderboardVersionRequest request);
    /// <summary>
    /// Increment an entity statistic definition version.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.IncrementStatisticVersionAsync({);
    ///   "Name": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/incrementstatisticversion">Microsoft Documentation</see>
    /// </summary>
    public Task<IncrementStatisticVersionResponse> IncrementStatisticVersionAsync(IncrementStatisticVersionRequest request);
    /// <summary>
    /// Lists the leaderboard definitions defined for the Title.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.ListLeaderboardDefinitionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/listleaderboarddefinitions">Microsoft Documentation</see>
    /// </summary>
    public Task<ListLeaderboardDefinitionsResponse> ListLeaderboardDefinitionsAsync(ListLeaderboardDefinitionsRequest request);
    /// <summary>
    /// Get all current statistic definitions information
    /// <example><br/>Example:<code>
    /// var response = statisticApi.ListStatisticDefinitionsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/liststatisticdefinitions">Microsoft Documentation</see>
    /// </summary>
    public Task<ListStatisticDefinitionsResponse> ListStatisticDefinitionsAsync(ListStatisticDefinitionsRequest request);
    /// <summary>
    /// Unlinks a leaderboard definition from it's linked statistic definition.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.UnlinkLeaderboardFromStatisticAsync({);
    ///   "Name": "HighestScoresByLevel",
    ///   "StatisticName": "HighestScoresByLevel"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/unlinkleaderboardfromstatistic">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UnlinkLeaderboardFromStatisticAsync(UnlinkLeaderboardFromStatisticRequest request);
    /// <summary>
    /// Updates a leaderboard definition.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.UpdateLeaderboardDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel",
    ///   "VersionConfiguration": {
    ///     "ResetInterval": "Manual",
    ///     "MaxQueryableVersions": 1
    ///   },
    ///   "SizeLimit": 1000
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/updateleaderboarddefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateLeaderboardDefinitionAsync(UpdateLeaderboardDefinitionRequest request);
    /// <summary>
    /// Adds or updates entries on the specified leaderboard.
    /// <example><br/>Example:<code>
    /// var response = leaderboardApi.UpdateLeaderboardEntriesAsync({);
    ///   "LeaderboardName": "Points",
    ///   "Entries": [
    ///     {
    ///       "Scores": [
    ///         "100",
    ///         "200"
    ///       ],
    ///       "EntityId": "12802710371"
    ///     },
    ///     {
    ///       "Scores": [
    ///         "120",
    ///         "200"
    ///       ],
    ///       "EntityId": "01849174301"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/leaderboard/leaderboards/updateleaderboardentries">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateLeaderboardEntriesAsync(UpdateLeaderboardEntriesRequest request);
    /// <summary>
    /// Update an existing entity statistic definition.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.UpdateStatisticDefinitionAsync({);
    ///   "Name": "HighestScoresByLevel",
    ///   "VersionConfiguration": {
    ///     "ResetInterval": "Manual",
    ///     "MaxQueryableVersions": 2
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/updatestatisticdefinition">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateStatisticDefinitionAsync(UpdateStatisticDefinitionRequest request);
    /// <summary>
    /// Update statistics on an entity profile. Depending on the statistic definition, this may result in entity being ranked
    /// on various leaderboards.
    /// <example><br/>Example:<code>
    /// var response = statisticApi.UpdateStatisticsAsync({);
    ///   "Statistics": [
    ///     {
    ///       "Name": "RoundsWon",
    ///       "Value": 0,
    ///       "Metadata": "BestRun:34.13,Car:13452",
    ///       "Scores": [
    ///         "100",
    ///         "200"
    ///       ]
    ///     },
    ///     {
    ///       "Name": "FastestTimesByMap",
    ///       "Value": 0,
    ///       "Metadata": "Car:13452",
    ///       "Scores": [
    ///         "200",
    ///         "300"
    ///       ]
    ///     },
    ///     {
    ///       "Name": "TotalCarTime",
    ///       "Value": 0,
    ///       "Scores": [
    ///         "300",
    ///         "400"
    ///       ]
    ///     }
    ///   ],
    ///   "Entity": {
    ///     "Id": "A197412JDA",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/statistic/statistics/updatestatistics">Microsoft Documentation</see>
    /// </summary>
    public Task<UpdateStatisticsResponse> UpdateStatisticsAsync(UpdateStatisticsRequest request);
}