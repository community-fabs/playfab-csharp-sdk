using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.Admin;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the Sweepstakes API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabAdminInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabAdminApi {

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authContext?.ForgetAllCredentials();
    }

    public async Task<PlayFabResult<EmptyResponse>> AbortTaskInstanceAsync(AbortTaskInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AbortTaskInstance", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<AddLocalizedNewsResult>> AddLocalizedNewsAsync(AddLocalizedNewsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddLocalizedNews", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddLocalizedNewsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddLocalizedNewsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddLocalizedNewsResult> { Result = result };
    }
    public async Task<PlayFabResult<AddNewsResult>> AddNewsAsync(AddNewsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddNews", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddNewsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddNewsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddNewsResult> { Result = result };
    }
    public async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddPlayerTag", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddPlayerTagResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddPlayerTagResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddPlayerTagResult> { Result = result };
    }
    public async Task<PlayFabResult<AddServerBuildResult>> AddServerBuildAsync(AddServerBuildRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddServerBuild", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddServerBuildResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddServerBuildResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddServerBuildResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddUserVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<BlankResult>> AddVirtualCurrencyTypesAsync(AddVirtualCurrencyTypesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/AddVirtualCurrencyTypes", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BlankResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BlankResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BlankResult> { Result = result };
    }
    public async Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/BanUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BanUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BanUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BanUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<CheckLimitedEditionItemAvailabilityResult>> CheckLimitedEditionItemAvailabilityAsync(CheckLimitedEditionItemAvailabilityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CheckLimitedEditionItemAvailability", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CheckLimitedEditionItemAvailabilityResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CheckLimitedEditionItemAvailabilityResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CheckLimitedEditionItemAvailabilityResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateTaskResult>> CreateActionsOnPlayersInSegmentTaskAsync(CreateActionsOnPlayerSegmentTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateActionsOnPlayersInSegmentTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTaskResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTaskResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTaskResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptAzureFunctionsTaskAsync(CreateCloudScriptAzureFunctionsTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateCloudScriptAzureFunctionsTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTaskResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTaskResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTaskResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateTaskResult>> CreateCloudScriptTaskAsync(CreateCloudScriptTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateCloudScriptTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTaskResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTaskResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTaskResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateTaskResult>> CreateInsightsScheduledScalingTaskAsync(CreateInsightsScheduledScalingTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateInsightsScheduledScalingTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTaskResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTaskResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTaskResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> CreateOpenIdConnectionAsync(CreateOpenIdConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateOpenIdConnection", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreatePlayerSharedSecretResult>> CreatePlayerSharedSecretAsync(CreatePlayerSharedSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreatePlayerSharedSecret", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreatePlayerSharedSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreatePlayerSharedSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreatePlayerSharedSecretResult> { Result = result };
    }
    public async Task<PlayFabResult<CreatePlayerStatisticDefinitionResult>> CreatePlayerStatisticDefinitionAsync(CreatePlayerStatisticDefinitionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreatePlayerStatisticDefinition", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreatePlayerStatisticDefinitionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreatePlayerStatisticDefinitionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreatePlayerStatisticDefinitionResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateSegmentResponse>> CreateSegmentAsync(CreateSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/CreateSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateSegmentResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateSegmentResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateSegmentResponse> { Result = result };
    }
    public async Task<PlayFabResult<BlankResult>> DeleteContentAsync(DeleteContentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteContent", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BlankResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BlankResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BlankResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteEventSinkResult>> DeleteEventSinkAsync(DeleteEventSinkRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteEventSink", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteEventSinkResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteEventSinkResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteEventSinkResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteMasterPlayerAccountResult>> DeleteMasterPlayerAccountAsync(DeleteMasterPlayerAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteMasterPlayerAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteMasterPlayerAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteMasterPlayerAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteMasterPlayerAccountResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteMasterPlayerEventDataResult>> DeleteMasterPlayerEventDataAsync(DeleteMasterPlayerEventDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteMasterPlayerEventData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteMasterPlayerEventDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteMasterPlayerEventDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteMasterPlayerEventDataResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteMembershipSubscriptionResult>> DeleteMembershipSubscriptionAsync(DeleteMembershipSubscriptionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteMembershipSubscription", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteMembershipSubscriptionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteMembershipSubscriptionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteMembershipSubscriptionResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteOpenIdConnectionAsync(DeleteOpenIdConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteOpenIdConnection", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeletePlayer", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<DeletePlayerCustomPropertiesResult>> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeletePlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<DeletePlayerSharedSecretResult>> DeletePlayerSharedSecretAsync(DeletePlayerSharedSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeletePlayerSharedSecret", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerSharedSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerSharedSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerSharedSecretResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteSegmentsResponse>> DeleteSegmentAsync(DeleteSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteSegmentsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteSegmentsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteSegmentsResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteStoreResult>> DeleteStoreAsync(DeleteStoreRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteStore", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteStoreResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteStoreResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteStoreResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteTaskAsync(DeleteTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteTitleResult>> DeleteTitleAsync(DeleteTitleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteTitle", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteTitleResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteTitleResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteTitleResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteTitleDataOverrideResult>> DeleteTitleDataOverrideAsync(DeleteTitleDataOverrideRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteTitleDataOverride", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteTitleDataOverrideResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteTitleDataOverrideResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteTitleDataOverrideResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteUsersResult>> DeleteUsersAsync(DeleteUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/DeleteUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<ExportMasterPlayerDataResult>> ExportMasterPlayerDataAsync(ExportMasterPlayerDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ExportMasterPlayerData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExportMasterPlayerDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExportMasterPlayerDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExportMasterPlayerDataResult> { Result = result };
    }
    public async Task<PlayFabResult<ExportPlayersInSegmentResult>> ExportPlayersInSegmentAsync(ExportPlayersInSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ExportPlayersInSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExportPlayersInSegmentResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExportPlayersInSegmentResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExportPlayersInSegmentResult> { Result = result };
    }
    public async Task<PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult>> GetActionsOnPlayersInSegmentTaskInstanceAsync(GetTaskInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetActionsOnPlayersInSegmentTaskInstance", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetActionsOnPlayersInSegmentTaskInstanceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetActionsOnPlayersInSegmentTaskInstanceResult> { Result = result };
    }
    public async Task<PlayFabResult<GetAllActionGroupsResult>> GetAllActionGroupsAsync(GetAllActionGroupsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetAllActionGroups", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAllActionGroupsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAllActionGroupsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAllActionGroupsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetAllSegments", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAllSegmentsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAllSegmentsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAllSegmentsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetCatalogItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCatalogItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCatalogItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCatalogItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCloudScriptAzureFunctionsTaskInstanceResult>> GetCloudScriptAzureFunctionsTaskInstanceAsync(GetTaskInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetCloudScriptAzureFunctionsTaskInstance", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCloudScriptAzureFunctionsTaskInstanceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptAzureFunctionsTaskInstanceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCloudScriptAzureFunctionsTaskInstanceResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCloudScriptRevisionResult>> GetCloudScriptRevisionAsync(GetCloudScriptRevisionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetCloudScriptRevision", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCloudScriptRevisionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptRevisionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCloudScriptRevisionResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCloudScriptTaskInstanceResult>> GetCloudScriptTaskInstanceAsync(GetTaskInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetCloudScriptTaskInstance", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCloudScriptTaskInstanceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptTaskInstanceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCloudScriptTaskInstanceResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCloudScriptVersionsResult>> GetCloudScriptVersionsAsync(GetCloudScriptVersionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetCloudScriptVersions", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCloudScriptVersionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptVersionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCloudScriptVersionsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetContentListResult>> GetContentListAsync(GetContentListRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetContentList", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetContentListResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContentListResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetContentListResult> { Result = result };
    }
    public async Task<PlayFabResult<GetContentUploadUrlResult>> GetContentUploadUrlAsync(GetContentUploadUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetContentUploadUrl", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetContentUploadUrlResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContentUploadUrlResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetContentUploadUrlResult> { Result = result };
    }
    public async Task<PlayFabResult<GetDataReportResult>> GetDataReportAsync(GetDataReportRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetDataReport", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetDataReportResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetDataReportResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetDataReportResult> { Result = result };
    }
    public async Task<PlayFabResult<GetEventSinksResult>> GetEventSinksAsync(GetEventSinksRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetEventSinks", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetEventSinksResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetEventSinksResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetEventSinksResult> { Result = result };
    }
    public async Task<PlayFabResult<GetMatchmakerGameInfoResult>> GetMatchmakerGameInfoAsync(GetMatchmakerGameInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetMatchmakerGameInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMatchmakerGameInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakerGameInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMatchmakerGameInfoResult> { Result = result };
    }
    public async Task<PlayFabResult<GetMatchmakerGameModesResult>> GetMatchmakerGameModesAsync(GetMatchmakerGameModesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetMatchmakerGameModes", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMatchmakerGameModesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakerGameModesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMatchmakerGameModesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayedTitleListResult>> GetPlayedTitleListAsync(GetPlayedTitleListRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayedTitleList", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayedTitleListResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayedTitleListResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayedTitleListResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerCustomPropertyResult>> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerCustomProperty", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerCustomPropertyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerCustomPropertyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerCustomPropertyResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerIdFromAuthTokenResult>> GetPlayerIdFromAuthTokenAsync(GetPlayerIdFromAuthTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerIdFromAuthToken", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerIdFromAuthTokenResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerIdFromAuthTokenResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerIdFromAuthTokenResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerProfile", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerProfileResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerProfileResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerProfileResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerSegments", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSegmentsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSegmentsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSegmentsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSharedSecretsResult>> GetPlayerSharedSecretsAsync(GetPlayerSharedSecretsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerSharedSecrets", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSharedSecretsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSharedSecretsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSharedSecretsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayersInSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayersInSegmentResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayersInSegmentResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayersInSegmentResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerStatisticDefinitionsResult>> GetPlayerStatisticDefinitionsAsync(GetPlayerStatisticDefinitionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerStatisticDefinitions", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticDefinitionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticDefinitionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticDefinitionsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerStatisticVersions", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticVersionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticVersionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticVersionsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPlayerTags", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerTagsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerTagsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerTagsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPolicyResponse>> GetPolicyAsync(GetPolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPolicy", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPolicyResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPublisherDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPublisherDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPublisherDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetRandomResultTables", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetRandomResultTablesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetRandomResultTablesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetRandomResultTablesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayersInSegmentExportResponse>> GetSegmentExportAsync(GetPlayersInSegmentExportRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetSegmentExport", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayersInSegmentExportResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayersInSegmentExportResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayersInSegmentExportResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetSegmentsResponse>> GetSegmentsAsync(GetSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetSegments", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetSegmentsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSegmentsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetSegmentsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetServerBuildInfoResult>> GetServerBuildInfoAsync(GetServerBuildInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetServerBuildInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetServerBuildInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetServerBuildInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetServerBuildInfoResult> { Result = result };
    }
    public async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetStoreItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetStoreItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetStoreItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetStoreItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTaskInstancesResult>> GetTaskInstancesAsync(GetTaskInstancesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetTaskInstances", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTaskInstancesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTaskInstancesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTaskInstancesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTasksResult>> GetTasksAsync(GetTasksRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetTasks", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTasksResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTasksResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTasksResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetTitleData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetTitleInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<LookupUserAccountInfoResult>> GetUserAccountInfoAsync(LookupUserAccountInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserAccountInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LookupUserAccountInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LookupUserAccountInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LookupUserAccountInfoResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserBansResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserInventory", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserInventoryResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserPublisherInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserPublisherReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GetUserReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/GrantItemsToUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantItemsToUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantItemsToUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantItemsToUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<IncrementLimitedEditionItemAvailabilityResult>> IncrementLimitedEditionItemAvailabilityAsync(IncrementLimitedEditionItemAvailabilityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/IncrementLimitedEditionItemAvailability", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<IncrementLimitedEditionItemAvailabilityResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<IncrementLimitedEditionItemAvailabilityResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<IncrementLimitedEditionItemAvailabilityResult> { Result = result };
    }
    public async Task<PlayFabResult<IncrementPlayerStatisticVersionResult>> IncrementPlayerStatisticVersionAsync(IncrementPlayerStatisticVersionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/IncrementPlayerStatisticVersion", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<IncrementPlayerStatisticVersionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<IncrementPlayerStatisticVersionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<IncrementPlayerStatisticVersionResult> { Result = result };
    }
    public async Task<PlayFabResult<ListOpenIdConnectionResponse>> ListOpenIdConnectionAsync(ListOpenIdConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ListOpenIdConnection", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListOpenIdConnectionResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListOpenIdConnectionResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListOpenIdConnectionResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListPlayerCustomPropertiesResult>> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ListPlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListPlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListPlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListPlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<ListBuildsResult>> ListServerBuildsAsync(ListBuildsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ListServerBuilds", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListBuildsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListBuildsResult> { Result = result };
    }
    public async Task<PlayFabResult<ListVirtualCurrencyTypesResult>> ListVirtualCurrencyTypesAsync(ListVirtualCurrencyTypesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ListVirtualCurrencyTypes", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListVirtualCurrencyTypesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListVirtualCurrencyTypesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListVirtualCurrencyTypesResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyMatchmakerGameModesResult>> ModifyMatchmakerGameModesAsync(ModifyMatchmakerGameModesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ModifyMatchmakerGameModes", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyMatchmakerGameModesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyMatchmakerGameModesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyMatchmakerGameModesResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyServerBuildResult>> ModifyServerBuildAsync(ModifyServerBuildRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ModifyServerBuild", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyServerBuildResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyServerBuildResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyServerBuildResult> { Result = result };
    }
    public async Task<PlayFabResult<RefundPurchaseResponse>> RefundPurchaseAsync(RefundPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RefundPurchase", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RefundPurchaseResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RefundPurchaseResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RefundPurchaseResponse> { Result = result };
    }
    public async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RemovePlayerTag", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemovePlayerTagResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemovePlayerTagResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemovePlayerTagResult> { Result = result };
    }
    public async Task<PlayFabResult<RemoveServerBuildResult>> RemoveServerBuildAsync(RemoveServerBuildRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RemoveServerBuild", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveServerBuildResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveServerBuildResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveServerBuildResult> { Result = result };
    }
    public async Task<PlayFabResult<BlankResult>> RemoveVirtualCurrencyTypesAsync(RemoveVirtualCurrencyTypesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RemoveVirtualCurrencyTypes", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BlankResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BlankResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BlankResult> { Result = result };
    }
    public async Task<PlayFabResult<ResetCharacterStatisticsResult>> ResetCharacterStatisticsAsync(ResetCharacterStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ResetCharacterStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ResetCharacterStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ResetCharacterStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ResetCharacterStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<ResetPasswordResult>> ResetPasswordAsync(ResetPasswordRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ResetPassword", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ResetPasswordResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ResetPasswordResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ResetPasswordResult> { Result = result };
    }
    public async Task<PlayFabResult<BlankResult>> ResetUsersAsync(ResetUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ResetUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BlankResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BlankResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BlankResult> { Result = result };
    }
    public async Task<PlayFabResult<ResetUserStatisticsResult>> ResetUserStatisticsAsync(ResetUserStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ResetUserStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ResetUserStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ResetUserStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ResetUserStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<ResolvePurchaseDisputeResponse>> ResolvePurchaseDisputeAsync(ResolvePurchaseDisputeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/ResolvePurchaseDispute", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ResolvePurchaseDisputeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ResolvePurchaseDisputeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ResolvePurchaseDisputeResponse> { Result = result };
    }
    public async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RevokeAllBansForUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeAllBansForUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeAllBansForUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeAllBansForUserResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RevokeBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeBansResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RevokeInventoryItem", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeInventoryResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RevokeInventoryItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeInventoryItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeInventoryItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeInventoryItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<RunTaskResult>> RunTaskAsync(RunTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/RunTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RunTaskResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RunTaskResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RunTaskResult> { Result = result };
    }
    public async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SendAccountRecoveryEmail", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendAccountRecoveryEmailResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendAccountRecoveryEmailResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendAccountRecoveryEmailResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCatalogItemsResult>> SetCatalogItemsAsync(UpdateCatalogItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetCatalogItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCatalogItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCatalogItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCatalogItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<SetEventSinkResult>> SetEventSinkAsync(SetEventSinkRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetEventSink", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetEventSinkResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetEventSinkResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetEventSinkResult> { Result = result };
    }
    public async Task<PlayFabResult<SetMembershipOverrideResult>> SetMembershipOverrideAsync(SetMembershipOverrideRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetMembershipOverride", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetMembershipOverrideResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetMembershipOverrideResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetMembershipOverrideResult> { Result = result };
    }
    public async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetPlayerSecret", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPlayerSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPlayerSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPlayerSecretResult> { Result = result };
    }
    public async Task<PlayFabResult<SetPublishedRevisionResult>> SetPublishedRevisionAsync(SetPublishedRevisionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetPublishedRevision", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPublishedRevisionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPublishedRevisionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPublishedRevisionResult> { Result = result };
    }
    public async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPublisherDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPublisherDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPublisherDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateStoreItemsResult>> SetStoreItemsAsync(UpdateStoreItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetStoreItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateStoreItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateStoreItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateStoreItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetTitleData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTitleDataAndOverridesResult>> SetTitleDataAndOverridesAsync(SetTitleDataAndOverridesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetTitleDataAndOverrides", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTitleDataAndOverridesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTitleDataAndOverridesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTitleDataAndOverridesResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetTitleInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<SetupPushNotificationResult>> SetupPushNotificationAsync(SetupPushNotificationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SetupPushNotification", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetupPushNotificationResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetupPushNotificationResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetupPushNotificationResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/SubtractUserVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateBansResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCatalogItemsResult>> UpdateCatalogItemsAsync(UpdateCatalogItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateCatalogItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCatalogItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCatalogItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCatalogItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCloudScriptResult>> UpdateCloudScriptAsync(UpdateCloudScriptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateCloudScript", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCloudScriptResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateOpenIdConnectionAsync(UpdateOpenIdConnectionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateOpenIdConnection", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePlayerCustomPropertiesResult>> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdatePlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePlayerSharedSecretResult>> UpdatePlayerSharedSecretAsync(UpdatePlayerSharedSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdatePlayerSharedSecret", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerSharedSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerSharedSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerSharedSecretResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePlayerStatisticDefinitionResult>> UpdatePlayerStatisticDefinitionAsync(UpdatePlayerStatisticDefinitionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdatePlayerStatisticDefinition", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerStatisticDefinitionResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerStatisticDefinitionResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerStatisticDefinitionResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePolicyResponse>> UpdatePolicyAsync(UpdatePolicyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdatePolicy", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePolicyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePolicyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePolicyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateRandomResultTablesResult>> UpdateRandomResultTablesAsync(UpdateRandomResultTablesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateRandomResultTables", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateRandomResultTablesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateRandomResultTablesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateRandomResultTablesResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateSegmentResponse>> UpdateSegmentAsync(UpdateSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateSegmentResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateSegmentResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateSegmentResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateStoreItemsResult>> UpdateStoreItemsAsync(UpdateStoreItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateStoreItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateStoreItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateStoreItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateStoreItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateTaskAsync(UpdateTaskRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateTask", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserPublisherInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserPublisherReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Admin/UpdateUserTitleDisplayName", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserTitleDisplayNameResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserTitleDisplayNameResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserTitleDisplayNameResult> { Result = result };
    }
}