using CommunityFabs.NET.Sdk.Models.Multiplayer;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabMultiplayerInstanceApi : IPlayFabMultiplayerApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabMultiplayerInstanceApi() { }

    public PlayFabMultiplayerInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabMultiplayerInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabMultiplayerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
    {
        apiSettings = settings;
        authenticationContext = context;
    }

    /// <summary>
    /// Verify client login.
    /// </summary>
    public bool IsLoggedIn()
    {
        return authenticationContext?.IsClientLoggedIn() ?? false;
    }

    /// <summary>
    /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
    /// A new/fresh login will be required after calling this.
    /// </summary>
    public void ForgetCredentials()
    {
        authenticationContext?.ForgetAllCredentials();
    }

    public async Task<PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult>> CancelAllMatchmakingTicketsForPlayerAsync(CancelAllMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CancelAllMatchmakingTicketsForPlayer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelAllMatchmakingTicketsForPlayerResult>>((string)httpResult);
        return new PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult>> CancelAllServerBackfillTicketsForPlayerAsync(CancelAllServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CancelAllServerBackfillTicketsForPlayer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelAllServerBackfillTicketsForPlayerResult>>((string)httpResult);
        return new PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CancelMatchmakingTicketResult>> CancelMatchmakingTicketAsync(CancelMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CancelMatchmakingTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CancelMatchmakingTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelMatchmakingTicketResult>>((string)httpResult);
        return new PlayFabResult<CancelMatchmakingTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CancelModelResponse>> CancelModelAsync(CancelModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CancelModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CancelModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelModelResponse>>((string)httpResult);
        return new PlayFabResult<CancelModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CancelServerBackfillTicketResult>> CancelServerBackfillTicketAsync(CancelServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CancelServerBackfillTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CancelServerBackfillTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelServerBackfillTicketResult>>((string)httpResult);
        return new PlayFabResult<CancelServerBackfillTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateBaseModelResponse>> CreateBaseModelAsync(CreateBaseModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateBaseModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateBaseModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBaseModelResponse>>((string)httpResult);
        return new PlayFabResult<CreateBaseModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateBatchModelResponse>> CreateBatchModelAsync(CreateBatchModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateBatchModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateBatchModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBatchModelResponse>>((string)httpResult);
        return new PlayFabResult<CreateBatchModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> CreateBuildAliasAsync(CreateBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildAlias", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        return new PlayFabResult<BuildAliasDetailsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateBuildWithCustomContainerResponse>> CreateBuildWithCustomContainerAsync(CreateBuildWithCustomContainerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithCustomContainer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateBuildWithCustomContainerResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithCustomContainerResponse>>((string)httpResult);
        return new PlayFabResult<CreateBuildWithCustomContainerResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateBuildWithManagedContainerResponse>> CreateBuildWithManagedContainerAsync(CreateBuildWithManagedContainerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithManagedContainer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateBuildWithManagedContainerResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithManagedContainerResponse>>((string)httpResult);
        return new PlayFabResult<CreateBuildWithManagedContainerResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateBuildWithProcessBasedServerResponse>> CreateBuildWithProcessBasedServerAsync(CreateBuildWithProcessBasedServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithProcessBasedServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateBuildWithProcessBasedServerResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithProcessBasedServerResponse>>((string)httpResult);
        return new PlayFabResult<CreateBuildWithProcessBasedServerResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateLobbyResult>> CreateLobbyAsync(CreateLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/CreateLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateLobbyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateLobbyResult>>((string)httpResult);
        return new PlayFabResult<CreateLobbyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateMatchmakingTicketAsync(CreateMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CreateMatchmakingTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateMatchmakingTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateMatchmakingTicketResult>>((string)httpResult);
        return new PlayFabResult<CreateMatchmakingTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateRemoteUserResponse>> CreateRemoteUserAsync(CreateRemoteUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateRemoteUser", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateRemoteUserResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateRemoteUserResponse>>((string)httpResult);
        return new PlayFabResult<CreateRemoteUserResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateScenarioResponse>> CreateScenarioAsync(CreateScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateScenario", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateScenarioResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateScenarioResponse>>((string)httpResult);
        return new PlayFabResult<CreateScenarioResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateServerBackfillTicketResult>> CreateServerBackfillTicketAsync(CreateServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CreateServerBackfillTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateServerBackfillTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateServerBackfillTicketResult>>((string)httpResult);
        return new PlayFabResult<CreateServerBackfillTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateServerMatchmakingTicketAsync(CreateServerMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/CreateServerMatchmakingTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateMatchmakingTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateMatchmakingTicketResult>>((string)httpResult);
        return new PlayFabResult<CreateMatchmakingTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse>> CreateTitleMultiplayerServersQuotaChangeAsync(CreateTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateTitleMultiplayerServersQuotaChange", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTitleMultiplayerServersQuotaChangeResponse>>((string)httpResult);
        return new PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeactivateModelResponse>> DeactivateModelAsync(DeactivateModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeactivateModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeactivateModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeactivateModelResponse>>((string)httpResult);
        return new PlayFabResult<DeactivateModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteAssetAsync(DeleteAssetRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteAsset", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildAsync(DeleteBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuild", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildAliasAsync(DeleteBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuildAlias", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildRegionAsync(DeleteBuildRegionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuildRegion", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteCertificateAsync(DeleteCertificateRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteCertificate", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteContainerImageRepositoryAsync(DeleteContainerImageRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteContainerImageRepository", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> DeleteLobbyAsync(DeleteLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/DeleteLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteModelResponse>> DeleteModelAsync(DeleteModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeleteModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteModelResponse>>((string)httpResult);
        return new PlayFabResult<DeleteModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteRemoteUserAsync(DeleteRemoteUserRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteRemoteUser", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<DeleteScenarioResponse>> DeleteScenarioAsync(DeleteScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeleteScenario", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<DeleteScenarioResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteScenarioResponse>>((string)httpResult);
        return new PlayFabResult<DeleteScenarioResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteSecretAsync(DeleteSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteSecret", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EnableMultiplayerServersForTitleResponse>> EnableMultiplayerServersForTitleAsync(EnableMultiplayerServersForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/EnableMultiplayerServersForTitle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EnableMultiplayerServersForTitleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EnableMultiplayerServersForTitleResponse>>((string)httpResult);
        return new PlayFabResult<EnableMultiplayerServersForTitleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> EnablePartiesForTitleAsync(EnablePartiesForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Party/EnablePartiesForTitle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<FindFriendLobbiesResult>> FindFriendLobbiesAsync(FindFriendLobbiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/FindFriendLobbies", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<FindFriendLobbiesResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FindFriendLobbiesResult>>((string)httpResult);
        return new PlayFabResult<FindFriendLobbiesResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<FindLobbiesResult>> FindLobbiesAsync(FindLobbiesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/FindLobbies", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<FindLobbiesResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FindLobbiesResult>>((string)httpResult);
        return new PlayFabResult<FindLobbiesResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetAssetDownloadUrlResponse>> GetAssetDownloadUrlAsync(GetAssetDownloadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetAssetDownloadUrl", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetAssetDownloadUrlResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAssetDownloadUrlResponse>>((string)httpResult);
        return new PlayFabResult<GetAssetDownloadUrlResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetAssetUploadUrlResponse>> GetAssetUploadUrlAsync(GetAssetUploadUrlRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetAssetUploadUrl", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetAssetUploadUrlResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAssetUploadUrlResponse>>((string)httpResult);
        return new PlayFabResult<GetAssetUploadUrlResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetBuildResponse>> GetBuildAsync(GetBuildRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetBuild", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetBuildResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetBuildResponse>>((string)httpResult);
        return new PlayFabResult<GetBuildResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> GetBuildAliasAsync(GetBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetBuildAlias", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        return new PlayFabResult<BuildAliasDetailsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetCognitiveServicesLocalesResponse>> GetCognitiveServicesLocalesAsync(GetCognitiveServicesLocalesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetCognitiveServicesLocales", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetCognitiveServicesLocalesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCognitiveServicesLocalesResponse>>((string)httpResult);
        return new PlayFabResult<GetCognitiveServicesLocalesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetCognitiveServicesTokenResponse>> GetCognitiveServicesTokenAsync(GetCognitiveServicesTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetCognitiveServicesToken", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetCognitiveServicesTokenResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCognitiveServicesTokenResponse>>((string)httpResult);
        return new PlayFabResult<GetCognitiveServicesTokenResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetContainerRegistryCredentialsResponse>> GetContainerRegistryCredentialsAsync(GetContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetContainerRegistryCredentials", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetContainerRegistryCredentialsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContainerRegistryCredentialsResponse>>((string)httpResult);
        return new PlayFabResult<GetContainerRegistryCredentialsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetLobbyResult>> GetLobbyAsync(GetLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/GetLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetLobbyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLobbyResult>>((string)httpResult);
        return new PlayFabResult<GetLobbyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMatchResult>> GetMatchAsync(GetMatchRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/GetMatch", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMatchResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchResult>>((string)httpResult);
        return new PlayFabResult<GetMatchResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMatchmakingQueueResult>> GetMatchmakingQueueAsync(GetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/GetMatchmakingQueue", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMatchmakingQueueResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakingQueueResult>>((string)httpResult);
        return new PlayFabResult<GetMatchmakingQueueResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMatchmakingTicketResult>> GetMatchmakingTicketAsync(GetMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/GetMatchmakingTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMatchmakingTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakingTicketResult>>((string)httpResult);
        return new PlayFabResult<GetMatchmakingTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetModelDetailsResponse>> GetModelDetailsAsync(GetModelDetailsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetModelDetails", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetModelDetailsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetModelDetailsResponse>>((string)httpResult);
        return new PlayFabResult<GetModelDetailsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetModelsByScenarioResponse>> GetModelsByScenarioAsync(GetModelsByScenarioRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetModelsByScenario", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetModelsByScenarioResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetModelsByScenarioResponse>>((string)httpResult);
        return new PlayFabResult<GetModelsByScenarioResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMultiplayerServerAndTokenResponse>> GetMultiplayerServerAndTokenAsync(GetMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerAndToken", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMultiplayerServerAndTokenResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerAndTokenResponse>>((string)httpResult);
        return new PlayFabResult<GetMultiplayerServerAndTokenResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMultiplayerServerDetailsResponse>> GetMultiplayerServerDetailsAsync(GetMultiplayerServerDetailsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerDetails", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMultiplayerServerDetailsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerDetailsResponse>>((string)httpResult);
        return new PlayFabResult<GetMultiplayerServerDetailsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerServerLogsAsync(GetMultiplayerServerLogsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerLogs", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMultiplayerServerLogsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerLogsResponse>>((string)httpResult);
        return new PlayFabResult<GetMultiplayerServerLogsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerSessionLogsBySessionIdAsync(GetMultiplayerSessionLogsBySessionIdRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerSessionLogsBySessionId", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetMultiplayerServerLogsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerLogsResponse>>((string)httpResult);
        return new PlayFabResult<GetMultiplayerServerLogsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetPlayerSkillResponse>> GetPlayerSkillAsync(GetPlayerSkillRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkill", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetPlayerSkillResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillResponse>>((string)httpResult);
        return new PlayFabResult<GetPlayerSkillResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetPlayerSkillForConditionsResponse>> GetPlayerSkillForConditionsAsync(GetPlayerSkillForConditionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillForConditions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetPlayerSkillForConditionsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillForConditionsResponse>>((string)httpResult);
        return new PlayFabResult<GetPlayerSkillForConditionsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetPlayerSkillForConditionsFromModelResponse>> GetPlayerSkillForConditionsFromModelAsync(GetPlayerSkillForConditionsFromModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillForConditionsFromModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetPlayerSkillForConditionsFromModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillForConditionsFromModelResponse>>((string)httpResult);
        return new PlayFabResult<GetPlayerSkillForConditionsFromModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetPlayerSkillFromModelResponse>> GetPlayerSkillFromModelAsync(GetPlayerSkillFromModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillFromModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetPlayerSkillFromModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillFromModelResponse>>((string)httpResult);
        return new PlayFabResult<GetPlayerSkillFromModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetQueueStatisticsResult>> GetQueueStatisticsAsync(GetQueueStatisticsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/GetQueueStatistics", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetQueueStatisticsResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetQueueStatisticsResult>>((string)httpResult);
        return new PlayFabResult<GetQueueStatisticsResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetRemoteLoginEndpointResponse>> GetRemoteLoginEndpointAsync(GetRemoteLoginEndpointRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetRemoteLoginEndpoint", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetRemoteLoginEndpointResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetRemoteLoginEndpointResponse>>((string)httpResult);
        return new PlayFabResult<GetRemoteLoginEndpointResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetScenarioConfigurationResponse>> GetScenarioConfigurationAsync(GetScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetScenarioConfiguration", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetScenarioConfigurationResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetScenarioConfigurationResponse>>((string)httpResult);
        return new PlayFabResult<GetScenarioConfigurationResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetScenarioConfigurationsResponse>> GetScenarioConfigurationsAsync(GetScenarioConfigurationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetScenarioConfigurations", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetScenarioConfigurationsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetScenarioConfigurationsResponse>>((string)httpResult);
        return new PlayFabResult<GetScenarioConfigurationsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetServerBackfillTicketResult>> GetServerBackfillTicketAsync(GetServerBackfillTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/GetServerBackfillTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetServerBackfillTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetServerBackfillTicketResult>>((string)httpResult);
        return new PlayFabResult<GetServerBackfillTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse>> GetTitleEnabledForMultiplayerServersStatusAsync(GetTitleEnabledForMultiplayerServersStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleEnabledForMultiplayerServersStatus", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleEnabledForMultiplayerServersStatusResponse>>((string)httpResult);
        return new PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse>> GetTitleMultiplayerServersQuotaChangeAsync(GetTitleMultiplayerServersQuotaChangeRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleMultiplayerServersQuotaChange", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleMultiplayerServersQuotaChangeResponse>>((string)httpResult);
        return new PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<GetTitleMultiplayerServersQuotasResponse>> GetTitleMultiplayerServersQuotasAsync(GetTitleMultiplayerServersQuotasRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleMultiplayerServersQuotas", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<GetTitleMultiplayerServersQuotasResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleMultiplayerServersQuotasResponse>>((string)httpResult);
        return new PlayFabResult<GetTitleMultiplayerServersQuotasResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> InviteToLobbyAsync(InviteToLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/InviteToLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<JoinLobbyResult>> JoinArrangedLobbyAsync(JoinArrangedLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinArrangedLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<JoinLobbyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyResult>>((string)httpResult);
        return new PlayFabResult<JoinLobbyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<JoinLobbyResult>> JoinLobbyAsync(JoinLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<JoinLobbyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyResult>>((string)httpResult);
        return new PlayFabResult<JoinLobbyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<JoinLobbyAsServerResult>> JoinLobbyAsServerAsync(JoinLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinLobbyAsServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<JoinLobbyAsServerResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyAsServerResult>>((string)httpResult);
        return new PlayFabResult<JoinLobbyAsServerResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<JoinMatchmakingTicketResult>> JoinMatchmakingTicketAsync(JoinMatchmakingTicketRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/JoinMatchmakingTicket", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<JoinMatchmakingTicketResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinMatchmakingTicketResult>>((string)httpResult);
        return new PlayFabResult<JoinMatchmakingTicketResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsync(LeaveLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/LeaveLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsServerAsync(LeaveLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/LeaveLobbyAsServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListMultiplayerServersResponse>> ListArchivedMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListArchivedMultiplayerServers", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListMultiplayerServersResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMultiplayerServersResponse>>((string)httpResult);
        return new PlayFabResult<ListMultiplayerServersResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListAssetSummariesResponse>> ListAssetSummariesAsync(ListAssetSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListAssetSummaries", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListAssetSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListAssetSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListAssetSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListBuildAliasesResponse>> ListBuildAliasesAsync(ListBuildAliasesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildAliases", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListBuildAliasesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildAliasesResponse>>((string)httpResult);
        return new PlayFabResult<ListBuildAliasesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesAsync(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildSummaries", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListBuildSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListBuildSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesV2Async(ListBuildSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildSummariesV2", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListBuildSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListBuildSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListCertificateSummariesResponse>> ListCertificateSummariesAsync(ListCertificateSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListCertificateSummaries", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListCertificateSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListCertificateSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListCertificateSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListContainerImagesResponse>> ListContainerImagesAsync(ListContainerImagesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListContainerImages", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListContainerImagesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListContainerImagesResponse>>((string)httpResult);
        return new PlayFabResult<ListContainerImagesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListContainerImageTagsResponse>> ListContainerImageTagsAsync(ListContainerImageTagsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListContainerImageTags", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListContainerImageTagsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListContainerImageTagsResponse>>((string)httpResult);
        return new PlayFabResult<ListContainerImageTagsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListMatchmakingQueuesResult>> ListMatchmakingQueuesAsync(ListMatchmakingQueuesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/ListMatchmakingQueues", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListMatchmakingQueuesResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMatchmakingQueuesResult>>((string)httpResult);
        return new PlayFabResult<ListMatchmakingQueuesResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListMatchmakingTicketsForPlayerResult>> ListMatchmakingTicketsForPlayerAsync(ListMatchmakingTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/ListMatchmakingTicketsForPlayer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListMatchmakingTicketsForPlayerResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMatchmakingTicketsForPlayerResult>>((string)httpResult);
        return new PlayFabResult<ListMatchmakingTicketsForPlayerResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListMultiplayerServersResponse>> ListMultiplayerServersAsync(ListMultiplayerServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListMultiplayerServers", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListMultiplayerServersResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMultiplayerServersResponse>>((string)httpResult);
        return new PlayFabResult<ListMultiplayerServersResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListPartyQosServersResponse>> ListPartyQosServersAsync(ListPartyQosServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListPartyQosServers", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListPartyQosServersResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListPartyQosServersResponse>>((string)httpResult);
        return new PlayFabResult<ListPartyQosServersResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListQosServersResponse>> ListQosServersAsync(ListQosServersRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListQosServers", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListQosServersResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQosServersResponse>>((string)httpResult);
        return new PlayFabResult<ListQosServersResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListQosServersForTitleResponse>> ListQosServersForTitleAsync(ListQosServersForTitleRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListQosServersForTitle", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListQosServersForTitleResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQosServersForTitleResponse>>((string)httpResult);
        return new PlayFabResult<ListQosServersForTitleResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListSecretSummariesResponse>> ListSecretSummariesAsync(ListSecretSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListSecretSummaries", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListSecretSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListSecretSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListSecretSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListServerBackfillTicketsForPlayerResult>> ListServerBackfillTicketsForPlayerAsync(ListServerBackfillTicketsForPlayerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/ListServerBackfillTicketsForPlayer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListServerBackfillTicketsForPlayerResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListServerBackfillTicketsForPlayerResult>>((string)httpResult);
        return new PlayFabResult<ListServerBackfillTicketsForPlayerResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse>> ListTitleMultiplayerServersQuotaChangesAsync(ListTitleMultiplayerServersQuotaChangesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListTitleMultiplayerServersQuotaChanges", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListTitleMultiplayerServersQuotaChangesResponse>>((string)httpResult);
        return new PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<ListVirtualMachineSummariesResponse>> ListVirtualMachineSummariesAsync(ListVirtualMachineSummariesRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListVirtualMachineSummaries", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<ListVirtualMachineSummariesResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListVirtualMachineSummariesResponse>>((string)httpResult);
        return new PlayFabResult<ListVirtualMachineSummariesResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RemoveMatchmakingQueueResult>> RemoveMatchmakingQueueAsync(RemoveMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/RemoveMatchmakingQueue", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RemoveMatchmakingQueueResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveMatchmakingQueueResult>>((string)httpResult);
        return new PlayFabResult<RemoveMatchmakingQueueResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> RemoveMemberAsync(RemoveMemberFromLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/RemoveMember", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RequestMultiplayerServerResponse>> RequestMultiplayerServerAsync(RequestMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RequestMultiplayerServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RequestMultiplayerServerResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestMultiplayerServerResponse>>((string)httpResult);
        return new PlayFabResult<RequestMultiplayerServerResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RequestMultiplayerServerAndTokenResponse>> RequestMultiplayerServerAndTokenAsync(RequestMultiplayerServerAndTokenRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RequestMultiplayerServerAndToken", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RequestMultiplayerServerAndTokenResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestMultiplayerServerAndTokenResponse>>((string)httpResult);
        return new PlayFabResult<RequestMultiplayerServerAndTokenResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RequestPartyResponse>> RequestPartyAsync(RequestPartyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Party/RequestParty", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RequestPartyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestPartyResponse>>((string)httpResult);
        return new PlayFabResult<RequestPartyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RequestPartyServiceResponse>> RequestPartyServiceAsync(RequestPartyServiceRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Party/RequestPartyService", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RequestPartyServiceResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestPartyServiceResponse>>((string)httpResult);
        return new PlayFabResult<RequestPartyServiceResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<RolloverContainerRegistryCredentialsResponse>> RolloverContainerRegistryCredentialsAsync(RolloverContainerRegistryCredentialsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RolloverContainerRegistryCredentials", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<RolloverContainerRegistryCredentialsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RolloverContainerRegistryCredentialsResponse>>((string)httpResult);
        return new PlayFabResult<RolloverContainerRegistryCredentialsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SetMatchmakingQueueResult>> SetMatchmakingQueueAsync(SetMatchmakingQueueRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/SetMatchmakingQueue", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SetMatchmakingQueueResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetMatchmakingQueueResult>>((string)httpResult);
        return new PlayFabResult<SetMatchmakingQueueResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> ShutdownMultiplayerServerAsync(ShutdownMultiplayerServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ShutdownMultiplayerServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SubscribeToLobbyResourceResult>> SubscribeToLobbyResourceAsync(SubscribeToLobbyResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/SubscribeToLobbyResource", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SubscribeToLobbyResourceResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SubscribeToLobbyResourceResult>>((string)httpResult);
        return new PlayFabResult<SubscribeToLobbyResourceResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<SubscribeToMatchResourceResult>> SubscribeToMatchmakingResourceAsync(SubscribeToMatchResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/SubscribeToMatchmakingResource", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<SubscribeToMatchResourceResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SubscribeToMatchResourceResult>>((string)httpResult);
        return new PlayFabResult<SubscribeToMatchResourceResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UnsubscribeFromLobbyResourceAsync(UnsubscribeFromLobbyResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/UnsubscribeFromLobbyResource", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<UnsubscribeFromMatchResourceResult>> UnsubscribeFromMatchmakingResourceAsync(UnsubscribeFromMatchResourceRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Match/UnsubscribeFromMatchmakingResource", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<UnsubscribeFromMatchResourceResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnsubscribeFromMatchResourceResult>>((string)httpResult);
        return new PlayFabResult<UnsubscribeFromMatchResourceResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UntagContainerImageAsync(UntagContainerImageRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UntagContainerImage", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> UpdateBuildAliasAsync(UpdateBuildAliasRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildAlias", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        return new PlayFabResult<BuildAliasDetailsResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildNameAsync(UpdateBuildNameRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildName", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionAsync(UpdateBuildRegionRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildRegion", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionsAsync(UpdateBuildRegionsRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildRegions", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsync(UpdateLobbyRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/UpdateLobby", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsServerAsync(UpdateLobbyAsServerRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/Lobby/UpdateLobbyAsServer", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        return new PlayFabResult<LobbyEmptyResult> { Result = resultData.data };
    }
    public async Task<PlayFabResult<UpdateModelResponse>> UpdateModelAsync(UpdateModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdateModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<UpdateModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateModelResponse>>((string)httpResult);
        return new PlayFabResult<UpdateModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<UpdatePrimaryModelResponse>> UpdatePrimaryModelAsync(UpdatePrimaryModelRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdatePrimaryModel", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<UpdatePrimaryModelResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePrimaryModelResponse>>((string)httpResult);
        return new PlayFabResult<UpdatePrimaryModelResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<UpdateScenarioConfigurationResponse>> UpdateScenarioConfigurationAsync(UpdateScenarioConfigurationRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdateScenarioConfiguration", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<UpdateScenarioConfigurationResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateScenarioConfigurationResponse>>((string)httpResult);
        return new PlayFabResult<UpdateScenarioConfigurationResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UploadCertificateAsync(UploadCertificateRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UploadCertificate", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<UploadMatchResultResponse>> UploadMatchResultAsync(UploadMatchResultRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UploadMatchResult", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<UploadMatchResultResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UploadMatchResultResponse>>((string)httpResult);
        return new PlayFabResult<UploadMatchResultResponse> { Result = resultData.data };
    }
    public async Task<PlayFabResult<EmptyResponse>> UploadSecretAsync(UploadSecretRequest request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UploadSecret", request, "", "", extraHeaders, requestSettings);
        if (httpResult is PlayFabError)
        {
            return new PlayFabResult<EmptyResponse> { Error = (PlayFabError)httpResult };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        return new PlayFabResult<EmptyResponse> { Result = resultData.data };
    }
}