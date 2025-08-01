using CommunityFabs.NET.Common.Models.Experimentation;
namespace CommunityFabs.NET.Common.Interfaces;

public interface IPlayFabExperimentationApi {
    /// <summary>
    /// Creates a new experiment exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.CreateExclusionGroupAsync({
    ///   "Name": "Commerce Exclusion Group",
    ///   "Description": "Exclusion group for independent, commerce-related experiments"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/createexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateExclusionGroupResult>> CreateExclusionGroupAsync(CreateExclusionGroupRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.CreateExperimentAsync({
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
    public Task<PlayFabResult<CreateExperimentResult>> CreateExperimentAsync(CreateExperimentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes an existing exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.DeleteExclusionGroupAsync({
    ///   "ExclusionGroupId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/deleteexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteExclusionGroupAsync(DeleteExclusionGroupRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.DeleteExperimentAsync({
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/deleteexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteExperimentAsync(DeleteExperimentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the details of all exclusion groups for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.GetExclusionGroupsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexclusiongroups">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetExclusionGroupsResult>> GetExclusionGroupsAsync(GetExclusionGroupsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the details of all exclusion groups for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.GetExclusionGroupTrafficAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexclusiongrouptraffic">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetExclusionGroupTrafficResult>> GetExclusionGroupTrafficAsync(GetExclusionGroupTrafficRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the details of all experiments for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.GetExperimentsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getexperiments">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetExperimentsResult>> GetExperimentsAsync(GetExperimentsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the latest scorecard of the experiment for the title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.GetLatestScorecardAsync({
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/getlatestscorecard">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetLatestScorecardResult>> GetLatestScorecardAsync(GetLatestScorecardRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the treatment assignments for a player for every running experiment in the title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.GetTreatmentAssignmentAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/gettreatmentassignment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTreatmentAssignmentResult>> GetTreatmentAssignmentAsync(GetTreatmentAssignmentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Starts an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.StartExperimentAsync({
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/startexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> StartExperimentAsync(StartExperimentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Stops an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.StopExperimentAsync({
    ///   "ExperimentId": "00000000-0000-0000-0000-000000000000"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/stopexperiment">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> StopExperimentAsync(StopExperimentRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates an existing exclusion group for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.UpdateExclusionGroupAsync({
    ///   "ExclusionGroupId": "00000000-0000-0000-0000-000000000000",
    ///   "Name": "Commerce Exclusion Group",
    ///   "Description": "Exclusion group for independent, commerce-related experiments"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/experimentation/experimentation/updateexclusiongroup">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> UpdateExclusionGroupAsync(UpdateExclusionGroupRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates an existing experiment for a title.
    /// <example><br/>Example:<code>
    /// var response = await experimentationApi.UpdateExperimentAsync({
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
    public Task<PlayFabResult<EmptyResponse>> UpdateExperimentAsync(UpdateExperimentRequest request, Dictionary<string, string>? extraHeaders);
}