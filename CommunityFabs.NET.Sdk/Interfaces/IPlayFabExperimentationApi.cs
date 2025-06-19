using CommunityFabs.NET.Sdk.Models.Experimentation;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabExperimentationApi {
    /// <summary>
    /// Creates a new experiment exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.CreateExclusionGroupAsync({);
    ///   "Name": "Commerce Exclusion Group",
    ///   "Description": "Exclusion group for independent, commerce-related experiments"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/createexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateExclusionGroupResult> CreateExclusionGroupAsync(CreateExclusionGroupRequest request);
    /// <summary>
    /// Creates a new experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.CreateExperimentAsync({);
    ///   "Name": "BackgroundColor Experiment",
    ///   "Description": "Tests whether a green background color increases revenue",
    ///   "StartDate": "2019-10-25T20:37:00Z",
    ///   "EndDate": "2019-11-13T20:37:00Z",
    ///   "Variants": [
    ///     {
    ///       "Name": "Control",
    ///       "Description": "Control variant",
    ///       "TrafficPercentage": 10,
    ///       "Variables": [
    ///         {
    ///           "Name": "BackgroundColor",
    ///           "Value": "White"
    ///         }
    ///       ],
    ///       "IsControl": true
    ///     },
    ///     {
    ///       "Name": "Treatment",
    ///       "Description": "Treatment variant",
    ///       "TrafficPercentage": 90,
    ///       "Variables": [
    ///         {
    ///           "Name": "BackgroundColor",
    ///           "Value": "Green"
    ///         }
    ///       ],
    ///       "IsControl": false
    ///     }
    ///   ],
    ///   "ExperimentType": "Active"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/createexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateExperimentResult> CreateExperimentAsync(CreateExperimentRequest request);
    /// <summary>
    /// Deletes an existing exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.DeleteExclusionGroupAsync({);
    ///   "ExclusionGroupId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/deleteexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteExclusionGroupAsync(DeleteExclusionGroupRequest request);
    /// <summary>
    /// Deletes an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.DeleteExperimentAsync({);
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/deleteexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> DeleteExperimentAsync(DeleteExperimentRequest request);
    /// <summary>
    /// Gets the details of all exclusion groups for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.GetExclusionGroupsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexclusiongroups">Microsoft Documentation</see>
    /// </summary>
    public Task<GetExclusionGroupsResult> GetExclusionGroupsAsync(GetExclusionGroupsRequest request);
    /// <summary>
    /// Gets the details of all exclusion groups for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.GetExclusionGroupTrafficAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexclusiongrouptraffic">Microsoft Documentation</see>
    /// </summary>
    public Task<GetExclusionGroupTrafficResult> GetExclusionGroupTrafficAsync(GetExclusionGroupTrafficRequest request);
    /// <summary>
    /// Gets the details of all experiments for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.GetExperimentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexperiments">Microsoft Documentation</see>
    /// </summary>
    public Task<GetExperimentsResult> GetExperimentsAsync(GetExperimentsRequest request);
    /// <summary>
    /// Gets the latest scorecard of the experiment for the title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.GetLatestScorecardAsync({);
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getlatestscorecard">Microsoft Documentation</see>
    /// </summary>
    public Task<GetLatestScorecardResult> GetLatestScorecardAsync(GetLatestScorecardRequest request);
    /// <summary>
    /// Gets the treatment assignments for a player for every running experiment in the title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.GetTreatmentAssignmentAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/gettreatmentassignment">Microsoft Documentation</see>
    /// </summary>
    public Task<GetTreatmentAssignmentResult> GetTreatmentAssignmentAsync(GetTreatmentAssignmentRequest request);
    /// <summary>
    /// Starts an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.StartExperimentAsync({);
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/startexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> StartExperimentAsync(StartExperimentRequest request);
    /// <summary>
    /// Stops an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.StopExperimentAsync({);
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/stopexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> StopExperimentAsync(StopExperimentRequest request);
    /// <summary>
    /// Updates an existing exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.UpdateExclusionGroupAsync({);
    ///   "ExclusionGroupId": "00000000-0000-0000-0000-000000000000",
    ///   "Name": "Commerce Exclusion Group",
    ///   "Description": "Exclusion group for independent, commerce-related experiments"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/updateexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateExclusionGroupAsync(UpdateExclusionGroupRequest request);
    /// <summary>
    /// Updates an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = experimentationApi.UpdateExperimentAsync({);
    ///   "Name": "BackgroundColor Experiment",
    ///   "Id": "B9A90E90-A009-4254-80A4-46B5933E9D26",
    ///   "Description": "Tests whether a green background color increases revenue",
    ///   "StartDate": "2019-10-25T20:37:00Z",
    ///   "EndDate": "2019-11-13T20:37:00Z",
    ///   "SegmentId": "0",
    ///   "Variants": [
    ///     {
    ///       "Name": "Control",
    ///       "Description": "Control variant",
    ///       "TrafficPercentage": 10,
    ///       "Variables": [
    ///         {
    ///           "Name": "BackgroundColor",
    ///           "Value": "White"
    ///         }
    ///       ],
    ///       "IsControl": true
    ///     },
    ///     {
    ///       "Name": "Treatment",
    ///       "Description": "Treatment variant",
    ///       "TrafficPercentage": 90,
    ///       "Variables": [
    ///         {
    ///           "Name": "BackgroundColor",
    ///           "Value": "Green"
    ///         }
    ///       ],
    ///       "IsControl": false
    ///     }
    ///   ],
    ///   "ExperimentType": "Active"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/updateexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<EmptyResponse> UpdateExperimentAsync(UpdateExperimentRequest request);
}