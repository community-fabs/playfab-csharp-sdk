using CommunityFabs.NET.Sdk.Models.Server;
using CommunityFabs.NET.Sdk.Models;
using CommunityFabs.NET.Sdk.Http;
using CommunityFabs.NET.Sdk.Interfaces;
using System.Text.Json;

namespace CommunityFabs.NET.Sdk;

public class PlayFabServerInstanceApi : IPlayFabServerApi {
    public readonly PlayFabApiSettings? apiSettings = null;
    public readonly PlayFabAuthenticationContext? authenticationContext = null;

    public PlayFabServerInstanceApi() { }

    public PlayFabServerInstanceApi(PlayFabApiSettings settings)
    {
        apiSettings = settings;
    }

    public PlayFabServerInstanceApi(PlayFabAuthenticationContext context)
    {
        authenticationContext = context;
    }

    public PlayFabServerInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context)
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

    public async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> AddCharacterVirtualCurrencyAsync(AddCharacterVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddCharacterVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyCharacterVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyCharacterVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyCharacterVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> AddFriendAsync(AddFriendRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddFriend", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> AddGenericIDAsync(AddGenericIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddGenericID", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<AddPlayerTagResult>> AddPlayerTagAsync(AddPlayerTagRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddPlayerTag", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddPlayerTagResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddPlayerTagResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddPlayerTagResult> { Result = result };
    }
    public async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddSharedGroupMembers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddSharedGroupMembersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddSharedGroupMembersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddSharedGroupMembersResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AddUserVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<AuthenticateSessionTicketResult>> AuthenticateSessionTicketAsync(AuthenticateSessionTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AuthenticateSessionTicket", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AuthenticateSessionTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AuthenticateSessionTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AuthenticateSessionTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<AwardSteamAchievementResult>> AwardSteamAchievementAsync(AwardSteamAchievementRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/AwardSteamAchievement", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AwardSteamAchievementResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AwardSteamAchievementResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AwardSteamAchievementResult> { Result = result };
    }
    public async Task<PlayFabResult<BanUsersResult>> BanUsersAsync(BanUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/BanUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<BanUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<BanUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<BanUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/ConsumeItem", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumeItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumeItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumeItemResult> { Result = result };
    }
    public async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/CreateSharedGroup", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateSharedGroupResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateSharedGroupResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateSharedGroupResult> { Result = result };
    }
    public async Task<PlayFabResult<DeleteCharacterFromUserResult>> DeleteCharacterFromUserAsync(DeleteCharacterFromUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeleteCharacterFromUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteCharacterFromUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteCharacterFromUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteCharacterFromUserResult> { Result = result };
    }
    public async Task<PlayFabResult<DeletePlayerResult>> DeletePlayerAsync(DeletePlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeletePlayer", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerResult> { Result = result };
    }
    public async Task<PlayFabResult<DeletePlayerCustomPropertiesResult>> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeletePlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<DeletePushNotificationTemplateResult>> DeletePushNotificationTemplateAsync(DeletePushNotificationTemplateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeletePushNotificationTemplate", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePushNotificationTemplateResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePushNotificationTemplateResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePushNotificationTemplateResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> DeleteSharedGroupAsync(DeleteSharedGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeleteSharedGroup", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<DeleteUsersResult>> DeleteUsersAsync(DeleteUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeleteUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeleteUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeleteUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeleteUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<DeregisterGameResponse>> DeregisterGameAsync(DeregisterGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/DeregisterGame", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeregisterGameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeregisterGameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeregisterGameResponse> { Result = result };
    }
    public async Task<PlayFabResult<EvaluateRandomResultTableResult>> EvaluateRandomResultTableAsync(EvaluateRandomResultTableRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/EvaluateRandomResultTable", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EvaluateRandomResultTableResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EvaluateRandomResultTableResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EvaluateRandomResultTableResult> { Result = result };
    }
    public async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/ExecuteCloudScript", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteCloudScriptResult> { Result = result };
    }
    public async Task<PlayFabResult<GetAllActionGroupsResult>> GetAllActionGroupsAsync(GetAllActionGroupsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetAllActionGroups", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAllActionGroupsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAllActionGroupsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAllActionGroupsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetAllSegmentsResult>> GetAllSegmentsAsync(GetAllSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetAllSegments", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAllSegmentsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAllSegmentsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAllSegmentsResult> { Result = result };
    }
    public async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetAllUsersCharacters", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListUsersCharactersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListUsersCharactersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListUsersCharactersResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCatalogItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCatalogItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCatalogItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCatalogItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterInternalDataAsync(GetCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(GetCharacterInventoryRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterInventory", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterInventoryResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterLeaderboard", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterLeaderboardResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetCharacterStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetContentDownloadUrl", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetContentDownloadUrlResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContentDownloadUrlResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetContentDownloadUrlResult> { Result = result };
    }
    public async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetFriendLeaderboard", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardResult> { Result = result };
    }
    public async Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetFriendsList", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFriendsListResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFriendsListResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFriendsListResult> { Result = result };
    }
    public async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetLeaderboard", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardResult> { Result = result };
    }
    public async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetLeaderboardAroundCharacter", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardAroundCharacterResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundCharacterResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardAroundCharacterResult> { Result = result };
    }
    public async Task<PlayFabResult<GetLeaderboardAroundUserResult>> GetLeaderboardAroundUserAsync(GetLeaderboardAroundUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetLeaderboardAroundUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardAroundUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardAroundUserResult> { Result = result };
    }
    public async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetLeaderboardForUserCharacters", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardForUsersCharactersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardForUsersCharactersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardForUsersCharactersResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerCombinedInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerCombinedInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerCombinedInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerCombinedInfoResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerCustomPropertyResult>> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerCustomProperty", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerCustomPropertyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerCustomPropertyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerCustomPropertyResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerProfile", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerProfileResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerProfileResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerProfileResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayersSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerSegments", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSegmentsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSegmentsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSegmentsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayersInSegmentResult>> GetPlayersInSegmentAsync(GetPlayersInSegmentRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayersInSegment", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayersInSegmentResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayersInSegmentResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayersInSegmentResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerStatisticVersions", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticVersionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticVersionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticVersionsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayerTags", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerTagsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerTagsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerTagsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult>> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromBattleNetAccountIds", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromBattleNetAccountIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromFacebookIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromFacebookIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromFacebookInstantGamesIds", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromFacebookInstantGamesIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromGenericIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromGenericIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromGenericIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromGenericIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromNintendoServiceAccountIds", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromNintendoServiceAccountIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromNintendoSwitchDeviceIds", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromPSNAccountIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromPSNAccountIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult>> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromPSNOnlineIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromPSNOnlineIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromSteamIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromSteamIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromSteamIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromSteamIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromSteamNamesResult>> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromSteamNames", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromSteamNamesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromSteamNamesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromSteamNamesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromTwitchIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromTwitchIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPlayFabIDsFromXboxLiveIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromXboxLiveIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPublisherDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPublisherDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPublisherDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetRandomResultTablesResult>> GetRandomResultTablesAsync(GetRandomResultTablesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetRandomResultTables", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetRandomResultTablesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetRandomResultTablesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetRandomResultTablesResult> { Result = result };
    }
    public async Task<PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult>> GetServerCustomIDsFromPlayFabIDsAsync(GetServerCustomIDsFromPlayFabIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetServerCustomIDsFromPlayFabIDs", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetServerCustomIDsFromPlayFabIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetServerCustomIDsFromPlayFabIDsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetSharedGroupData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetSharedGroupDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSharedGroupDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetSharedGroupDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetStoreItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetStoreItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetStoreItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetStoreItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTimeResult>> GetTimeAsync(GetTimeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetTime", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTimeResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTimeResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTimeResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetTitleData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleDataResult>> GetTitleInternalDataAsync(GetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetTitleInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetTitleNews", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleNewsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleNewsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleNewsResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserAccountInfoResult>> GetUserAccountInfoAsync(GetUserAccountInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserAccountInfo", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserAccountInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserAccountInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserAccountInfoResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserBansResult>> GetUserBansAsync(GetUserBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserBansResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserInternalDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserInventory", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserInventoryResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherInternalDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserPublisherInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserPublisherReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<GetUserStatisticsResult>> GetUserStatisticsAsync(GetUserStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GetUserStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GrantCharacterToUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantCharacterToUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantCharacterToUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantCharacterToUserResult> { Result = result };
    }
    public async Task<PlayFabResult<GrantItemsToCharacterResult>> GrantItemsToCharacterAsync(GrantItemsToCharacterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GrantItemsToCharacter", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantItemsToCharacterResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantItemsToCharacterResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantItemsToCharacterResult> { Result = result };
    }
    public async Task<PlayFabResult<GrantItemsToUserResult>> GrantItemsToUserAsync(GrantItemsToUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GrantItemsToUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantItemsToUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantItemsToUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantItemsToUserResult> { Result = result };
    }
    public async Task<PlayFabResult<GrantItemsToUsersResult>> GrantItemsToUsersAsync(GrantItemsToUsersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/GrantItemsToUsers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantItemsToUsersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantItemsToUsersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantItemsToUsersResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkBattleNetAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkNintendoServiceAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountSubjectAsync(LinkNintendoServiceAccountSubjectRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkNintendoServiceAccountSubject", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkNintendoSwitchDeviceId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkNintendoSwitchDeviceIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkNintendoSwitchDeviceIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkNintendoSwitchDeviceIdResult> { Result = result };
    }
    public async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkPSNAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkPSNAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkPSNAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkPSNAccountResult> { Result = result };
    }
    public async Task<PlayFabResult<LinkPSNIdResponse>> LinkPSNIdAsync(LinkPSNIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkPSNId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkPSNIdResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkPSNIdResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkPSNIdResponse> { Result = result };
    }
    public async Task<PlayFabResult<LinkServerCustomIdResult>> LinkServerCustomIdAsync(LinkServerCustomIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkServerCustomId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkServerCustomIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkServerCustomIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkServerCustomIdResult> { Result = result };
    }
    public async Task<PlayFabResult<LinkSteamIdResult>> LinkSteamIdAsync(LinkSteamIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkSteamId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkSteamIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkSteamIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkSteamIdResult> { Result = result };
    }
    public async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LinkXboxAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkXboxAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkXboxAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkXboxAccountResult> { Result = result };
    }
    public async Task<PlayFabResult<ListPlayerCustomPropertiesResult>> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/ListPlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListPlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListPlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListPlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<LogEventResult>> LogEventAsync(LogEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LogEvent", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LogEventResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LogEventResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LogEventResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithAndroidDeviceID", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithBattleNetAsync(LoginWithBattleNetRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithBattleNet", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithCustomID", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithIOSDeviceID", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithPSNAsync(LoginWithPSNRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithPSN", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithServerCustomIdAsync(LoginWithServerCustomIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithServerCustomId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithSteamIdAsync(LoginWithSteamIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithSteamId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithXboxAsync(LoginWithXboxRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithXbox", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ServerLoginResult>> LoginWithXboxIdAsync(LoginWithXboxIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/LoginWithXboxId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ServerLoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ServerLoginResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ServerLoginResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyItemUsesResult>> ModifyItemUsesAsync(ModifyItemUsesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/ModifyItemUses", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyItemUsesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyItemUsesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyItemUsesResult> { Result = result };
    }
    public async Task<PlayFabResult<MoveItemToCharacterFromCharacterResult>> MoveItemToCharacterFromCharacterAsync(MoveItemToCharacterFromCharacterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/MoveItemToCharacterFromCharacter", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<MoveItemToCharacterFromCharacterResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<MoveItemToCharacterFromCharacterResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<MoveItemToCharacterFromCharacterResult> { Result = result };
    }
    public async Task<PlayFabResult<MoveItemToCharacterFromUserResult>> MoveItemToCharacterFromUserAsync(MoveItemToCharacterFromUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/MoveItemToCharacterFromUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<MoveItemToCharacterFromUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<MoveItemToCharacterFromUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<MoveItemToCharacterFromUserResult> { Result = result };
    }
    public async Task<PlayFabResult<MoveItemToUserFromCharacterResult>> MoveItemToUserFromCharacterAsync(MoveItemToUserFromCharacterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/MoveItemToUserFromCharacter", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<MoveItemToUserFromCharacterResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<MoveItemToUserFromCharacterResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<MoveItemToUserFromCharacterResult> { Result = result };
    }
    public async Task<PlayFabResult<NotifyMatchmakerPlayerLeftResult>> NotifyMatchmakerPlayerLeftAsync(NotifyMatchmakerPlayerLeftRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/NotifyMatchmakerPlayerLeft", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<NotifyMatchmakerPlayerLeftResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<NotifyMatchmakerPlayerLeftResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<NotifyMatchmakerPlayerLeftResult> { Result = result };
    }
    public async Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RedeemCoupon", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RedeemCouponResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RedeemCouponResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RedeemCouponResult> { Result = result };
    }
    public async Task<PlayFabResult<RedeemMatchmakerTicketResult>> RedeemMatchmakerTicketAsync(RedeemMatchmakerTicketRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RedeemMatchmakerTicket", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RedeemMatchmakerTicketResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RedeemMatchmakerTicketResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RedeemMatchmakerTicketResult> { Result = result };
    }
    public async Task<PlayFabResult<RefreshGameServerInstanceHeartbeatResult>> RefreshGameServerInstanceHeartbeatAsync(RefreshGameServerInstanceHeartbeatRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RefreshGameServerInstanceHeartbeat", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RefreshGameServerInstanceHeartbeatResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RefreshGameServerInstanceHeartbeatResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RefreshGameServerInstanceHeartbeatResult> { Result = result };
    }
    public async Task<PlayFabResult<RegisterGameResponse>> RegisterGameAsync(RegisterGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RegisterGame", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RegisterGameResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RegisterGameResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RegisterGameResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> RemoveFriendAsync(RemoveFriendRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RemoveFriend", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResult>> RemoveGenericIDAsync(RemoveGenericIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RemoveGenericID", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }
    public async Task<PlayFabResult<RemovePlayerTagResult>> RemovePlayerTagAsync(RemovePlayerTagRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RemovePlayerTag", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemovePlayerTagResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemovePlayerTagResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemovePlayerTagResult> { Result = result };
    }
    public async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RemoveSharedGroupMembers", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveSharedGroupMembersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveSharedGroupMembersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveSharedGroupMembersResult> { Result = result };
    }
    public async Task<PlayFabResult<ReportPlayerServerResult>> ReportPlayerAsync(ReportPlayerServerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/ReportPlayer", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ReportPlayerServerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ReportPlayerServerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ReportPlayerServerResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeAllBansForUserResult>> RevokeAllBansForUserAsync(RevokeAllBansForUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RevokeAllBansForUser", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeAllBansForUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeAllBansForUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeAllBansForUserResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeBansResult>> RevokeBansAsync(RevokeBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RevokeBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeBansResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeInventoryResult>> RevokeInventoryItemAsync(RevokeInventoryItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RevokeInventoryItem", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeInventoryResult> { Result = result };
    }
    public async Task<PlayFabResult<RevokeInventoryItemsResult>> RevokeInventoryItemsAsync(RevokeInventoryItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/RevokeInventoryItems", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RevokeInventoryItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RevokeInventoryItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RevokeInventoryItemsResult> { Result = result };
    }
    public async Task<PlayFabResult<SavePushNotificationTemplateResult>> SavePushNotificationTemplateAsync(SavePushNotificationTemplateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SavePushNotificationTemplate", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SavePushNotificationTemplateResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SavePushNotificationTemplateResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SavePushNotificationTemplateResult> { Result = result };
    }
    public async Task<PlayFabResult<SendCustomAccountRecoveryEmailResult>> SendCustomAccountRecoveryEmailAsync(SendCustomAccountRecoveryEmailRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SendCustomAccountRecoveryEmail", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendCustomAccountRecoveryEmailResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendCustomAccountRecoveryEmailResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendCustomAccountRecoveryEmailResult> { Result = result };
    }
    public async Task<PlayFabResult<SendEmailFromTemplateResult>> SendEmailFromTemplateAsync(SendEmailFromTemplateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SendEmailFromTemplate", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendEmailFromTemplateResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendEmailFromTemplateResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendEmailFromTemplateResult> { Result = result };
    }
    public async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationAsync(SendPushNotificationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SendPushNotification", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendPushNotificationResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendPushNotificationResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendPushNotificationResult> { Result = result };
    }
    public async Task<PlayFabResult<SendPushNotificationResult>> SendPushNotificationFromTemplateAsync(SendPushNotificationFromTemplateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SendPushNotificationFromTemplate", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendPushNotificationResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendPushNotificationResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendPushNotificationResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> SetFriendTagsAsync(SetFriendTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetFriendTags", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<SetGameServerInstanceDataResult>> SetGameServerInstanceDataAsync(SetGameServerInstanceDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetGameServerInstanceData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetGameServerInstanceDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGameServerInstanceDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetGameServerInstanceDataResult> { Result = result };
    }
    public async Task<PlayFabResult<SetGameServerInstanceStateResult>> SetGameServerInstanceStateAsync(SetGameServerInstanceStateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetGameServerInstanceState", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetGameServerInstanceStateResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGameServerInstanceStateResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetGameServerInstanceStateResult> { Result = result };
    }
    public async Task<PlayFabResult<SetGameServerInstanceTagsResult>> SetGameServerInstanceTagsAsync(SetGameServerInstanceTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetGameServerInstanceTags", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetGameServerInstanceTagsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetGameServerInstanceTagsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetGameServerInstanceTagsResult> { Result = result };
    }
    public async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetPlayerSecret", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPlayerSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPlayerSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPlayerSecretResult> { Result = result };
    }
    public async Task<PlayFabResult<SetPublisherDataResult>> SetPublisherDataAsync(SetPublisherDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPublisherDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPublisherDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPublisherDataResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTitleDataResult>> SetTitleDataAsync(SetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetTitleData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<SetTitleDataResult>> SetTitleInternalDataAsync(SetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SetTitleInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetTitleDataResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyCharacterVirtualCurrencyResult>> SubtractCharacterVirtualCurrencyAsync(SubtractCharacterVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SubtractCharacterVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyCharacterVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyCharacterVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyCharacterVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/SubtractUserVirtualCurrency", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkBattleNetAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkNintendoServiceAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkNintendoSwitchDeviceId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkNintendoSwitchDeviceIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkPSNAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkPSNAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkPSNAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkPSNAccountResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlinkServerCustomIdResult>> UnlinkServerCustomIdAsync(UnlinkServerCustomIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkServerCustomId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkServerCustomIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkServerCustomIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkServerCustomIdResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlinkSteamIdResult>> UnlinkSteamIdAsync(UnlinkSteamIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkSteamId", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkSteamIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkSteamIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkSteamIdResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlinkXboxAccount", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkXboxAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkXboxAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkXboxAccountResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlockContainerInstance", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlockContainerItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlockContainerItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlockContainerItemResult> { Result = result };
    }
    public async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UnlockContainerItem", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlockContainerItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlockContainerItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlockContainerItemResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateAvatarUrl", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateBansResult>> UpdateBansAsync(UpdateBansRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateBans", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateBansResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateBansResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateBansResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateCharacterData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterInternalDataAsync(UpdateCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateCharacterInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterReadOnlyDataAsync(UpdateCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateCharacterReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateCharacterStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePlayerCustomPropertiesResult>> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdatePlayerCustomProperties", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdatePlayerStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateSharedGroupData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateSharedGroupDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateSharedGroupDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateSharedGroupDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserInternalDataAsync(UpdateUserInternalDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<EmptyResponse>> UpdateUserInventoryItemCustomDataAsync(UpdateUserInventoryItemDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserInventoryItemCustomData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserPublisherData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherInternalDataAsync(UpdateUserInternalDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserPublisherInternalData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherReadOnlyDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserPublisherReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserReadOnlyDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserReadOnlyData", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }
    public async Task<PlayFabResult<UpdateUserStatisticsResult>> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/UpdateUserStatistics", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserStatisticsResult> { Result = result };
    }
    public async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEventAsync(WriteServerCharacterEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/WriteCharacterEvent", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }
    public async Task<PlayFabResult<WriteEventResponse>> WritePlayerEventAsync(WriteServerPlayerEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/WritePlayerEvent", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }
    public async Task<PlayFabResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authenticationContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestSettings?.DeveloperSecretKey == null) throw new PlayFabException(PlayFabExceptionCode.DeveloperKeyNotSet, "DeveloperSecretKey must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Server/WriteTitleEvent", request, "X-SecretKey", requestSettings.DeveloperSecretKey, extraHeaders, requestSettings);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }
}