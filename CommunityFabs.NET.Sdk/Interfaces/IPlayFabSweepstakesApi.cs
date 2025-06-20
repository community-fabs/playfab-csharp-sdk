using CommunityFabs.NET.Sdk.Models.Sweepstakes;
namespace CommunityFabs.NET.Sdk.Interfaces;

public interface IPlayFabSweepstakesApi {
    /// <summary>
    /// Creates a sweepstake for the associated title. Returns information about the sweepstake that was created.
    /// <example><br/>Example:<code>
    /// var response = await sweepstakesApi.CreateSweepstakeAsync({);
    ///   "Name": "Example Sweepstake",
    ///   "RewardId": "12345",
    ///   "StartDate": "2020-06-25T00:00:00Z",
    ///   "EndDate": "2020-07-02T00:00:00Z",
    ///   "DrawingDate": "2020-07-03T00:00:00Z",
    ///   "MaxNumberOfWinners": 5
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/sweepstakes/null/createsweepstake">Microsoft Documentation</see>
    /// </summary>
    public Task<CreateSweepstakeResponse> CreateSweepstakeAsync(CreateSweepstakeRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a sweeepstake for the associated title. If name is empty, will return all sweepstakes in the title.
    /// <example><br/>Example:<code>
    /// var response = await sweepstakesApi.GetSweepstakeAsync({);
    ///   "Name": "TestSweepstake"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/sweepstakes/null/getsweepstake">Microsoft Documentation</see>
    /// </summary>
    public Task<GetSweepstakeResponse> GetSweepstakeAsync(GetSweepstakeRequest request, Dictionary<string, string>? extraHeaders);
}