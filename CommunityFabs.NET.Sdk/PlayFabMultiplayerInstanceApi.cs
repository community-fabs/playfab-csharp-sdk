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

    public async Task<PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult>> CancelAllMatchmakingTicketsForPlayerAsync(CancelAllMatchmakingTicketsForPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CancelAllMatchmakingTicketsForPlayer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelAllMatchmakingTicketsForPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelAllMatchmakingTicketsForPlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult>> CancelAllServerBackfillTicketsForPlayerAsync(CancelAllServerBackfillTicketsForPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CancelAllServerBackfillTicketsForPlayer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelAllServerBackfillTicketsForPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelAllServerBackfillTicketsForPlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<CancelMatchmakingTicketResult>> CancelMatchmakingTicketAsync(CancelMatchmakingTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CancelMatchmakingTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelMatchmakingTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelMatchmakingTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelMatchmakingTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<CancelModelResponse>> CancelModelAsync(CancelModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CancelModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<CancelServerBackfillTicketResult>> CancelServerBackfillTicketAsync(CancelServerBackfillTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CancelServerBackfillTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelServerBackfillTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelServerBackfillTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelServerBackfillTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateBaseModelResponse>> CreateBaseModelAsync(CreateBaseModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateBaseModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateBaseModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBaseModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateBaseModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateBatchModelResponse>> CreateBatchModelAsync(CreateBatchModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateBatchModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateBatchModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBatchModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateBatchModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> CreateBuildAliasAsync(CreateBuildAliasRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildAlias", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BuildAliasDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateBuildWithCustomContainerResponse>> CreateBuildWithCustomContainerAsync(CreateBuildWithCustomContainerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithCustomContainer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateBuildWithCustomContainerResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithCustomContainerResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateBuildWithCustomContainerResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateBuildWithManagedContainerResponse>> CreateBuildWithManagedContainerAsync(CreateBuildWithManagedContainerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithManagedContainer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateBuildWithManagedContainerResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithManagedContainerResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateBuildWithManagedContainerResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateBuildWithProcessBasedServerResponse>> CreateBuildWithProcessBasedServerAsync(CreateBuildWithProcessBasedServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateBuildWithProcessBasedServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateBuildWithProcessBasedServerResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateBuildWithProcessBasedServerResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateBuildWithProcessBasedServerResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateLobbyResult>> CreateLobbyAsync(CreateLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/CreateLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateLobbyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateLobbyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateLobbyResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateMatchmakingTicketAsync(CreateMatchmakingTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CreateMatchmakingTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateMatchmakingTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateMatchmakingTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateMatchmakingTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateRemoteUserResponse>> CreateRemoteUserAsync(CreateRemoteUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateRemoteUser", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateRemoteUserResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateRemoteUserResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateRemoteUserResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateScenarioResponse>> CreateScenarioAsync(CreateScenarioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/CreateScenario", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateScenarioResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateScenarioResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateScenarioResponse> { Result = result };
    }
    public async Task<PlayFabResult<CreateServerBackfillTicketResult>> CreateServerBackfillTicketAsync(CreateServerBackfillTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CreateServerBackfillTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateServerBackfillTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateServerBackfillTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateServerBackfillTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateMatchmakingTicketResult>> CreateServerMatchmakingTicketAsync(CreateServerMatchmakingTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/CreateServerMatchmakingTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateMatchmakingTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateMatchmakingTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateMatchmakingTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse>> CreateTitleMultiplayerServersQuotaChangeAsync(CreateTitleMultiplayerServersQuotaChangeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/CreateTitleMultiplayerServersQuotaChange", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateTitleMultiplayerServersQuotaChangeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateTitleMultiplayerServersQuotaChangeResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeactivateModelResponse>> DeactivateModelAsync(DeactivateModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeactivateModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeactivateModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeactivateModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeactivateModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteAssetAsync(DeleteAssetRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteAsset", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildAsync(DeleteBuildRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuild", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildAliasAsync(DeleteBuildAliasRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuildAlias", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteBuildRegionAsync(DeleteBuildRegionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteBuildRegion", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteCertificateAsync(DeleteCertificateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteCertificate", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteContainerImageRepositoryAsync(DeleteContainerImageRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteContainerImageRepository", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> DeleteLobbyAsync(DeleteLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/DeleteLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteModelResponse>> DeleteModelAsync(DeleteModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeleteModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteRemoteUserAsync(DeleteRemoteUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteRemoteUser", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteScenarioResponse>> DeleteScenarioAsync(DeleteScenarioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/DeleteScenario", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteScenarioResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteScenarioResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteScenarioResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteSecretAsync(DeleteSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/DeleteSecret", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EnableMultiplayerServersForTitleResponse>> EnableMultiplayerServersForTitleAsync(EnableMultiplayerServersForTitleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/EnableMultiplayerServersForTitle", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EnableMultiplayerServersForTitleResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EnableMultiplayerServersForTitleResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EnableMultiplayerServersForTitleResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> EnablePartiesForTitleAsync(EnablePartiesForTitleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Party/EnablePartiesForTitle", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<FindFriendLobbiesResult>> FindFriendLobbiesAsync(FindFriendLobbiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/FindFriendLobbies", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<FindFriendLobbiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FindFriendLobbiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<FindFriendLobbiesResult> { Result = result };
    }
    public async Task<PlayFabResult<FindLobbiesResult>> FindLobbiesAsync(FindLobbiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/FindLobbies", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<FindLobbiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<FindLobbiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<FindLobbiesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetAssetDownloadUrlResponse>> GetAssetDownloadUrlAsync(GetAssetDownloadUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetAssetDownloadUrl", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAssetDownloadUrlResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAssetDownloadUrlResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAssetDownloadUrlResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetAssetUploadUrlResponse>> GetAssetUploadUrlAsync(GetAssetUploadUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetAssetUploadUrl", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAssetUploadUrlResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAssetUploadUrlResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAssetUploadUrlResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetBuildResponse>> GetBuildAsync(GetBuildRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetBuild", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetBuildResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetBuildResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetBuildResponse> { Result = result };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> GetBuildAliasAsync(GetBuildAliasRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetBuildAlias", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BuildAliasDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetCognitiveServicesLocalesResponse>> GetCognitiveServicesLocalesAsync(GetCognitiveServicesLocalesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetCognitiveServicesLocales", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCognitiveServicesLocalesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCognitiveServicesLocalesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCognitiveServicesLocalesResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetCognitiveServicesTokenResponse>> GetCognitiveServicesTokenAsync(GetCognitiveServicesTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetCognitiveServicesToken", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCognitiveServicesTokenResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCognitiveServicesTokenResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCognitiveServicesTokenResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetContainerRegistryCredentialsResponse>> GetContainerRegistryCredentialsAsync(GetContainerRegistryCredentialsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetContainerRegistryCredentials", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetContainerRegistryCredentialsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContainerRegistryCredentialsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetContainerRegistryCredentialsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetLobbyResult>> GetLobbyAsync(GetLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/GetLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLobbyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLobbyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLobbyResult> { Result = result };
    }
    public async Task<PlayFabResult<GetMatchResult>> GetMatchAsync(GetMatchRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/GetMatch", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMatchResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMatchResult> { Result = result };
    }
    public async Task<PlayFabResult<GetMatchmakingQueueResult>> GetMatchmakingQueueAsync(GetMatchmakingQueueRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/GetMatchmakingQueue", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMatchmakingQueueResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakingQueueResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMatchmakingQueueResult> { Result = result };
    }
    public async Task<PlayFabResult<GetMatchmakingTicketResult>> GetMatchmakingTicketAsync(GetMatchmakingTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/GetMatchmakingTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMatchmakingTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMatchmakingTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMatchmakingTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<GetModelDetailsResponse>> GetModelDetailsAsync(GetModelDetailsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetModelDetails", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetModelDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetModelDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetModelDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetModelsByScenarioResponse>> GetModelsByScenarioAsync(GetModelsByScenarioRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetModelsByScenario", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetModelsByScenarioResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetModelsByScenarioResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetModelsByScenarioResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetMultiplayerServerAndTokenResponse>> GetMultiplayerServerAndTokenAsync(GetMultiplayerServerAndTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerAndToken", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMultiplayerServerAndTokenResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerAndTokenResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMultiplayerServerAndTokenResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetMultiplayerServerDetailsResponse>> GetMultiplayerServerDetailsAsync(GetMultiplayerServerDetailsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerDetails", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMultiplayerServerDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMultiplayerServerDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerServerLogsAsync(GetMultiplayerServerLogsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerServerLogs", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMultiplayerServerLogsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerLogsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMultiplayerServerLogsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetMultiplayerServerLogsResponse>> GetMultiplayerSessionLogsBySessionIdAsync(GetMultiplayerSessionLogsBySessionIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetMultiplayerSessionLogsBySessionId", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetMultiplayerServerLogsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetMultiplayerServerLogsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetMultiplayerServerLogsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSkillResponse>> GetPlayerSkillAsync(GetPlayerSkillRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkill", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSkillResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSkillResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSkillForConditionsResponse>> GetPlayerSkillForConditionsAsync(GetPlayerSkillForConditionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillForConditions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSkillForConditionsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillForConditionsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSkillForConditionsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSkillForConditionsFromModelResponse>> GetPlayerSkillForConditionsFromModelAsync(GetPlayerSkillForConditionsFromModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillForConditionsFromModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSkillForConditionsFromModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillForConditionsFromModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSkillForConditionsFromModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSkillFromModelResponse>> GetPlayerSkillFromModelAsync(GetPlayerSkillFromModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetPlayerSkillFromModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSkillFromModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSkillFromModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSkillFromModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetQueueStatisticsResult>> GetQueueStatisticsAsync(GetQueueStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/GetQueueStatistics", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetQueueStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetQueueStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetQueueStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetRemoteLoginEndpointResponse>> GetRemoteLoginEndpointAsync(GetRemoteLoginEndpointRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetRemoteLoginEndpoint", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetRemoteLoginEndpointResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetRemoteLoginEndpointResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetRemoteLoginEndpointResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetScenarioConfigurationResponse>> GetScenarioConfigurationAsync(GetScenarioConfigurationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetScenarioConfiguration", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetScenarioConfigurationResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetScenarioConfigurationResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetScenarioConfigurationResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetScenarioConfigurationsResponse>> GetScenarioConfigurationsAsync(GetScenarioConfigurationsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/GetScenarioConfigurations", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetScenarioConfigurationsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetScenarioConfigurationsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetScenarioConfigurationsResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetServerBackfillTicketResult>> GetServerBackfillTicketAsync(GetServerBackfillTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/GetServerBackfillTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetServerBackfillTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetServerBackfillTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetServerBackfillTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse>> GetTitleEnabledForMultiplayerServersStatusAsync(GetTitleEnabledForMultiplayerServersStatusRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleEnabledForMultiplayerServersStatus", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleEnabledForMultiplayerServersStatusResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleEnabledForMultiplayerServersStatusResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse>> GetTitleMultiplayerServersQuotaChangeAsync(GetTitleMultiplayerServersQuotaChangeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleMultiplayerServersQuotaChange", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleMultiplayerServersQuotaChangeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleMultiplayerServersQuotaChangeResponse> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleMultiplayerServersQuotasResponse>> GetTitleMultiplayerServersQuotasAsync(GetTitleMultiplayerServersQuotasRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/GetTitleMultiplayerServersQuotas", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleMultiplayerServersQuotasResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleMultiplayerServersQuotasResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleMultiplayerServersQuotasResponse> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> InviteToLobbyAsync(InviteToLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/InviteToLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<JoinLobbyResult>> JoinArrangedLobbyAsync(JoinArrangedLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinArrangedLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<JoinLobbyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<JoinLobbyResult> { Result = result };
    }
    public async Task<PlayFabResult<JoinLobbyResult>> JoinLobbyAsync(JoinLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<JoinLobbyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<JoinLobbyResult> { Result = result };
    }
    public async Task<PlayFabResult<JoinLobbyAsServerResult>> JoinLobbyAsServerAsync(JoinLobbyAsServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/JoinLobbyAsServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<JoinLobbyAsServerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinLobbyAsServerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<JoinLobbyAsServerResult> { Result = result };
    }
    public async Task<PlayFabResult<JoinMatchmakingTicketResult>> JoinMatchmakingTicketAsync(JoinMatchmakingTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/JoinMatchmakingTicket", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<JoinMatchmakingTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<JoinMatchmakingTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<JoinMatchmakingTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsync(LeaveLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/LeaveLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> LeaveLobbyAsServerAsync(LeaveLobbyAsServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/LeaveLobbyAsServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<ListMultiplayerServersResponse>> ListArchivedMultiplayerServersAsync(ListMultiplayerServersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListArchivedMultiplayerServers", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMultiplayerServersResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMultiplayerServersResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMultiplayerServersResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListAssetSummariesResponse>> ListAssetSummariesAsync(ListAssetSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListAssetSummaries", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListAssetSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListAssetSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListAssetSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListBuildAliasesResponse>> ListBuildAliasesAsync(ListBuildAliasesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildAliases", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListBuildAliasesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildAliasesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListBuildAliasesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesAsync(ListBuildSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildSummaries", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListBuildSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListBuildSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListBuildSummariesResponse>> ListBuildSummariesV2Async(ListBuildSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListBuildSummariesV2", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListBuildSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListBuildSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListBuildSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListCertificateSummariesResponse>> ListCertificateSummariesAsync(ListCertificateSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListCertificateSummaries", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListCertificateSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListCertificateSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListCertificateSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListContainerImagesResponse>> ListContainerImagesAsync(ListContainerImagesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListContainerImages", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListContainerImagesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListContainerImagesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListContainerImagesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListContainerImageTagsResponse>> ListContainerImageTagsAsync(ListContainerImageTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListContainerImageTags", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListContainerImageTagsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListContainerImageTagsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListContainerImageTagsResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListMatchmakingQueuesResult>> ListMatchmakingQueuesAsync(ListMatchmakingQueuesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/ListMatchmakingQueues", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMatchmakingQueuesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMatchmakingQueuesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMatchmakingQueuesResult> { Result = result };
    }
    public async Task<PlayFabResult<ListMatchmakingTicketsForPlayerResult>> ListMatchmakingTicketsForPlayerAsync(ListMatchmakingTicketsForPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/ListMatchmakingTicketsForPlayer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMatchmakingTicketsForPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMatchmakingTicketsForPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMatchmakingTicketsForPlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<ListMultiplayerServersResponse>> ListMultiplayerServersAsync(ListMultiplayerServersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListMultiplayerServers", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListMultiplayerServersResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListMultiplayerServersResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListMultiplayerServersResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListPartyQosServersResponse>> ListPartyQosServersAsync(ListPartyQosServersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListPartyQosServers", request, null, null, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListPartyQosServersResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListPartyQosServersResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListPartyQosServersResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListQosServersResponse>> ListQosServersAsync(ListQosServersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListQosServers", request, null, null, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListQosServersResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQosServersResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListQosServersResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListQosServersForTitleResponse>> ListQosServersForTitleAsync(ListQosServersForTitleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListQosServersForTitle", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListQosServersForTitleResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListQosServersForTitleResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListQosServersForTitleResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListSecretSummariesResponse>> ListSecretSummariesAsync(ListSecretSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListSecretSummaries", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListSecretSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListSecretSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListSecretSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListServerBackfillTicketsForPlayerResult>> ListServerBackfillTicketsForPlayerAsync(ListServerBackfillTicketsForPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/ListServerBackfillTicketsForPlayer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListServerBackfillTicketsForPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListServerBackfillTicketsForPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListServerBackfillTicketsForPlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse>> ListTitleMultiplayerServersQuotaChangesAsync(ListTitleMultiplayerServersQuotaChangesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListTitleMultiplayerServersQuotaChanges", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListTitleMultiplayerServersQuotaChangesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListTitleMultiplayerServersQuotaChangesResponse> { Result = result };
    }
    public async Task<PlayFabResult<ListVirtualMachineSummariesResponse>> ListVirtualMachineSummariesAsync(ListVirtualMachineSummariesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ListVirtualMachineSummaries", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListVirtualMachineSummariesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListVirtualMachineSummariesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListVirtualMachineSummariesResponse> { Result = result };
    }
    public async Task<PlayFabResult<RemoveMatchmakingQueueResult>> RemoveMatchmakingQueueAsync(RemoveMatchmakingQueueRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/RemoveMatchmakingQueue", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveMatchmakingQueueResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveMatchmakingQueueResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveMatchmakingQueueResult> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> RemoveMemberAsync(RemoveMemberFromLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/RemoveMember", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<RequestMultiplayerServerResponse>> RequestMultiplayerServerAsync(RequestMultiplayerServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RequestMultiplayerServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RequestMultiplayerServerResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestMultiplayerServerResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RequestMultiplayerServerResponse> { Result = result };
    }
    public async Task<PlayFabResult<RequestMultiplayerServerAndTokenResponse>> RequestMultiplayerServerAndTokenAsync(RequestMultiplayerServerAndTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RequestMultiplayerServerAndToken", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RequestMultiplayerServerAndTokenResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestMultiplayerServerAndTokenResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RequestMultiplayerServerAndTokenResponse> { Result = result };
    }
    public async Task<PlayFabResult<RequestPartyResponse>> RequestPartyAsync(RequestPartyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Party/RequestParty", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RequestPartyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestPartyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RequestPartyResponse> { Result = result };
    }
    public async Task<PlayFabResult<RequestPartyServiceResponse>> RequestPartyServiceAsync(RequestPartyServiceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Party/RequestPartyService", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RequestPartyServiceResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RequestPartyServiceResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RequestPartyServiceResponse> { Result = result };
    }
    public async Task<PlayFabResult<RolloverContainerRegistryCredentialsResponse>> RolloverContainerRegistryCredentialsAsync(RolloverContainerRegistryCredentialsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/RolloverContainerRegistryCredentials", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RolloverContainerRegistryCredentialsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RolloverContainerRegistryCredentialsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RolloverContainerRegistryCredentialsResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetMatchmakingQueueResult>> SetMatchmakingQueueAsync(SetMatchmakingQueueRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/SetMatchmakingQueue", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetMatchmakingQueueResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetMatchmakingQueueResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetMatchmakingQueueResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> ShutdownMultiplayerServerAsync(ShutdownMultiplayerServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/ShutdownMultiplayerServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<SubscribeToLobbyResourceResult>> SubscribeToLobbyResourceAsync(SubscribeToLobbyResourceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/SubscribeToLobbyResource", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SubscribeToLobbyResourceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SubscribeToLobbyResourceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SubscribeToLobbyResourceResult> { Result = result };
    }
    public async Task<PlayFabResult<SubscribeToMatchResourceResult>> SubscribeToMatchmakingResourceAsync(SubscribeToMatchResourceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/SubscribeToMatchmakingResource", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SubscribeToMatchResourceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SubscribeToMatchResourceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SubscribeToMatchResourceResult> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UnsubscribeFromLobbyResourceAsync(UnsubscribeFromLobbyResourceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/UnsubscribeFromLobbyResource", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<UnsubscribeFromMatchResourceResult>> UnsubscribeFromMatchmakingResourceAsync(UnsubscribeFromMatchResourceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Match/UnsubscribeFromMatchmakingResource", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnsubscribeFromMatchResourceResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnsubscribeFromMatchResourceResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnsubscribeFromMatchResourceResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UntagContainerImageAsync(UntagContainerImageRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UntagContainerImage", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<BuildAliasDetailsResponse>> UpdateBuildAliasAsync(UpdateBuildAliasRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildAlias", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BuildAliasDetailsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BuildAliasDetailsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BuildAliasDetailsResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildNameAsync(UpdateBuildNameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildName", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionAsync(UpdateBuildRegionRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildRegion", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateBuildRegionsAsync(UpdateBuildRegionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UpdateBuildRegions", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsync(UpdateLobbyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/UpdateLobby", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<LobbyEmptyResult>> UpdateLobbyAsServerAsync(UpdateLobbyAsServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/Lobby/UpdateLobbyAsServer", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LobbyEmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LobbyEmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LobbyEmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateModelResponse>> UpdateModelAsync(UpdateModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdateModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePrimaryModelResponse>> UpdatePrimaryModelAsync(UpdatePrimaryModelRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdatePrimaryModel", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePrimaryModelResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePrimaryModelResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePrimaryModelResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateScenarioConfigurationResponse>> UpdateScenarioConfigurationAsync(UpdateScenarioConfigurationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UpdateScenarioConfiguration", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateScenarioConfigurationResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateScenarioConfigurationResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateScenarioConfigurationResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UploadCertificateAsync(UploadCertificateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UploadCertificate", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UploadMatchResultResponse>> UploadMatchResultAsync(UploadMatchResultRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/TrueSkill/UploadMatchResult", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UploadMatchResultResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UploadMatchResultResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UploadMatchResultResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UploadSecretAsync(UploadSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.EntityToken == null) throw new PlayFabException(PlayFabExceptionCode.EntityTokenNotSet, "Must call Client Login or GetEntityToken before calling this method");

        var httpResult = await PlayFabHttp.Post("/MultiplayerServer/UploadSecret", request, "X-EntityToken", requestContext.EntityToken, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
}