using CommunityFabs.NET.Sdk.Models.Sweepstakes;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabSweepstakesInstanceApi : PlayFabBaseInstanceApi, IPlayFabSweepstakesApi {
    public PlayFabSweepstakesInstanceApi() : base() { }
    public PlayFabSweepstakesInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabSweepstakesInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabSweepstakesInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<CreateSweepstakeResponse> CreateSweepstakeAsync(CreateSweepstakeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateSweepstakeResponse>("/Sweepstakes/CreateSweepstake", request, extraHeaders);
    }
    public async Task<GetSweepstakeResponse> GetSweepstakeAsync(GetSweepstakeRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetSweepstakeResponse>("/Sweepstakes/GetSweepstake", request, extraHeaders);
    }
}