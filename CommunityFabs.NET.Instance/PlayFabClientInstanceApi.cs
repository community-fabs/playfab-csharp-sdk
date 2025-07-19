using CommunityFabs.NET.Common;
using CommunityFabs.NET.Common.Http;
using CommunityFabs.NET.Common.Interfaces;
using CommunityFabs.NET.Common.Models;
using CommunityFabs.NET.Common.Models.Client;
using System.Text.Json;

namespace CommunityFabs.NET.Instance;

/// <summary>
/// Create a new instance of the Client API
/// </summary>
/// <param name="apiSettings">Current PlayFab API settings</param>
/// <param name="authContext">Current authentication context</param>
/// <param name="httpClient">A custom HttpClient (e.g. for use with Polly policies)</param>
public class PlayFabClientInstanceApi(PlayFabApiSettings? apiSettings = null, PlayFabAuthenticationContext? authContext = null, HttpClient? httpClient = null) : IPlayFabClientApi {

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

    /// <inheritdoc />
    public async Task<PlayFabResult<AcceptTradeResponse>> AcceptTradeAsync(AcceptTradeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AcceptTrade", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AcceptTradeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AcceptTradeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AcceptTradeResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AddFriendResult>> AddFriendAsync(AddFriendRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddFriend", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddFriendResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddFriendResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddFriendResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AddGenericIDResult>> AddGenericIDAsync(AddGenericIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddGenericID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddGenericIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddGenericIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddGenericIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AddOrUpdateContactEmailResult>> AddOrUpdateContactEmailAsync(AddOrUpdateContactEmailRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddOrUpdateContactEmail", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddOrUpdateContactEmailResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddOrUpdateContactEmailResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddOrUpdateContactEmailResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AddSharedGroupMembersResult>> AddSharedGroupMembersAsync(AddSharedGroupMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddSharedGroupMembers", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddSharedGroupMembersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddSharedGroupMembersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddSharedGroupMembersResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AddUsernamePasswordResult>> AddUsernamePasswordAsync(AddUsernamePasswordRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddUsernamePassword", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AddUsernamePasswordResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AddUsernamePasswordResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AddUsernamePasswordResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> AddUserVirtualCurrencyAsync(AddUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AddUserVirtualCurrency", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AndroidDevicePushNotificationRegistrationResult>> AndroidDevicePushNotificationRegistrationAsync(AndroidDevicePushNotificationRegistrationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AndroidDevicePushNotificationRegistration", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AndroidDevicePushNotificationRegistrationResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AndroidDevicePushNotificationRegistrationResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AndroidDevicePushNotificationRegistrationResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<AttributeInstallResult>> AttributeInstallAsync(AttributeInstallRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/AttributeInstall", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<AttributeInstallResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<AttributeInstallResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<AttributeInstallResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<CancelTradeResponse>> CancelTradeAsync(CancelTradeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/CancelTrade", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CancelTradeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CancelTradeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CancelTradeResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConfirmPurchaseResult>> ConfirmPurchaseAsync(ConfirmPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConfirmPurchase", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConfirmPurchaseResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConfirmPurchaseResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConfirmPurchaseResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConsumeItemResult>> ConsumeItemAsync(ConsumeItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConsumeItem", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumeItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumeItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumeItemResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse>> ConsumeMicrosoftStoreEntitlementsAsync(ConsumeMicrosoftStoreEntitlementsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConsumeMicrosoftStoreEntitlements", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumeMicrosoftStoreEntitlementsResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumeMicrosoftStoreEntitlementsResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConsumePS5EntitlementsResult>> ConsumePS5EntitlementsAsync(ConsumePS5EntitlementsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConsumePS5Entitlements", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumePS5EntitlementsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumePS5EntitlementsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumePS5EntitlementsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConsumePSNEntitlementsResult>> ConsumePSNEntitlementsAsync(ConsumePSNEntitlementsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConsumePSNEntitlements", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumePSNEntitlementsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumePSNEntitlementsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumePSNEntitlementsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ConsumeXboxEntitlementsResult>> ConsumeXboxEntitlementsAsync(ConsumeXboxEntitlementsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ConsumeXboxEntitlements", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ConsumeXboxEntitlementsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ConsumeXboxEntitlementsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ConsumeXboxEntitlementsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<CreateSharedGroupResult>> CreateSharedGroupAsync(CreateSharedGroupRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/CreateSharedGroup", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CreateSharedGroupResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CreateSharedGroupResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CreateSharedGroupResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<DeletePlayerCustomPropertiesResult>> DeletePlayerCustomPropertiesAsync(DeletePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/DeletePlayerCustomProperties", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<DeletePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<DeletePlayerCustomPropertiesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ExecuteCloudScriptResult>> ExecuteCloudScriptAsync(ExecuteCloudScriptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ExecuteCloudScript", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ExecuteCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ExecuteCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ExecuteCloudScriptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetAccountInfoResult>> GetAccountInfoAsync(GetAccountInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetAccountInfo", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAccountInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAccountInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAccountInfoResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetAdPlacementsResult>> GetAdPlacementsAsync(GetAdPlacementsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetAdPlacements", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetAdPlacementsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetAdPlacementsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetAdPlacementsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListUsersCharactersResult>> GetAllUsersCharactersAsync(ListUsersCharactersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetAllUsersCharacters", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListUsersCharactersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListUsersCharactersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListUsersCharactersResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCatalogItemsResult>> GetCatalogItemsAsync(GetCatalogItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCatalogItems", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCatalogItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCatalogItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCatalogItemsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterDataAsync(GetCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCharacterData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCharacterInventoryResult>> GetCharacterInventoryAsync(GetCharacterInventoryRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCharacterInventory", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterInventoryResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCharacterLeaderboardResult>> GetCharacterLeaderboardAsync(GetCharacterLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCharacterLeaderboard", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterLeaderboardResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCharacterDataResult>> GetCharacterReadOnlyDataAsync(GetCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCharacterReadOnlyData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCharacterStatisticsResult>> GetCharacterStatisticsAsync(GetCharacterStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCharacterStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCharacterStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCharacterStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCharacterStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetCloudScriptUrlResult>> GetCloudScriptUrlAsync(GetCloudScriptUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCloudScriptUrl", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetCloudScriptUrlResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetCloudScriptUrlResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetCloudScriptUrlResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetContentDownloadUrlResult>> GetContentDownloadUrlAsync(GetContentDownloadUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetContentDownloadUrl", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetContentDownloadUrlResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetContentDownloadUrlResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetContentDownloadUrlResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<CurrentGamesResult>> GetCurrentGamesAsync(CurrentGamesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetCurrentGames", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<CurrentGamesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<CurrentGamesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<CurrentGamesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardResult>> GetFriendLeaderboardAsync(GetFriendLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetFriendLeaderboard", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetFriendLeaderboardAroundCurrentUserResult>> GetFriendLeaderboardAroundCurrentUserAsync(GetFriendLeaderboardAroundCurrentUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetFriendLeaderboardAroundCurrentUser", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFriendLeaderboardAroundCurrentUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFriendLeaderboardAroundCurrentUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFriendLeaderboardAroundCurrentUserResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetFriendLeaderboardAroundPlayerResult>> GetFriendLeaderboardAroundPlayerAsync(GetFriendLeaderboardAroundPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetFriendLeaderboardAroundPlayer", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFriendLeaderboardAroundPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFriendLeaderboardAroundPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFriendLeaderboardAroundPlayerResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetFriendsListResult>> GetFriendsListAsync(GetFriendsListRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetFriendsList", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetFriendsListResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetFriendsListResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetFriendsListResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GameServerRegionsResult>> GetGameServerRegionsAsync(GameServerRegionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetGameServerRegions", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GameServerRegionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GameServerRegionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GameServerRegionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardResult>> GetLeaderboardAsync(GetLeaderboardRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetLeaderboard", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardAroundCharacterResult>> GetLeaderboardAroundCharacterAsync(GetLeaderboardAroundCharacterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetLeaderboardAroundCharacter", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardAroundCharacterResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundCharacterResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardAroundCharacterResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardAroundCurrentUserResult>> GetLeaderboardAroundCurrentUserAsync(GetLeaderboardAroundCurrentUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetLeaderboardAroundCurrentUser", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardAroundCurrentUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundCurrentUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardAroundCurrentUserResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardAroundPlayerResult>> GetLeaderboardAroundPlayerAsync(GetLeaderboardAroundPlayerRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetLeaderboardAroundPlayer", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardAroundPlayerResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardAroundPlayerResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardAroundPlayerResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetLeaderboardForUsersCharactersResult>> GetLeaderboardForUserCharactersAsync(GetLeaderboardForUsersCharactersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetLeaderboardForUserCharacters", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetLeaderboardForUsersCharactersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetLeaderboardForUsersCharactersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetLeaderboardForUsersCharactersResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPaymentTokenResult>> GetPaymentTokenAsync(GetPaymentTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPaymentToken", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPaymentTokenResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPaymentTokenResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPaymentTokenResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPhotonAuthenticationTokenResult>> GetPhotonAuthenticationTokenAsync(GetPhotonAuthenticationTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPhotonAuthenticationToken", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPhotonAuthenticationTokenResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPhotonAuthenticationTokenResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPhotonAuthenticationTokenResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerCombinedInfoResult>> GetPlayerCombinedInfoAsync(GetPlayerCombinedInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerCombinedInfo", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerCombinedInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerCombinedInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerCombinedInfoResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerCustomPropertyResult>> GetPlayerCustomPropertyAsync(GetPlayerCustomPropertyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerCustomProperty", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerCustomPropertyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerCustomPropertyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerCustomPropertyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerProfileResult>> GetPlayerProfileAsync(GetPlayerProfileRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerProfile", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerProfileResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerProfileResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerProfileResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerSegmentsResult>> GetPlayerSegmentsAsync(GetPlayerSegmentsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerSegments", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerSegmentsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerSegmentsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerSegmentsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerStatisticsResult>> GetPlayerStatisticsAsync(GetPlayerStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerStatisticVersionsResult>> GetPlayerStatisticVersionsAsync(GetPlayerStatisticVersionsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerStatisticVersions", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerStatisticVersionsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerStatisticVersionsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerStatisticVersionsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerTagsResult>> GetPlayerTagsAsync(GetPlayerTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerTags", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerTagsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerTagsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerTagsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayerTradesResponse>> GetPlayerTradesAsync(GetPlayerTradesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayerTrades", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayerTradesResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayerTradesResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayerTradesResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult>> GetPlayFabIDsFromBattleNetAccountIdsAsync(GetPlayFabIDsFromBattleNetAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromBattleNetAccountIds", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromBattleNetAccountIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromBattleNetAccountIdsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromFacebookIDsResult>> GetPlayFabIDsFromFacebookIDsAsync(GetPlayFabIDsFromFacebookIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromFacebookIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromFacebookIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromFacebookIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult>> GetPlayFabIDsFromFacebookInstantGamesIdsAsync(GetPlayFabIDsFromFacebookInstantGamesIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromFacebookInstantGamesIds", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromFacebookInstantGamesIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromFacebookInstantGamesIdsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult>> GetPlayFabIDsFromGameCenterIDsAsync(GetPlayFabIDsFromGameCenterIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromGameCenterIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromGameCenterIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromGameCenterIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromGenericIDsResult>> GetPlayFabIDsFromGenericIDsAsync(GetPlayFabIDsFromGenericIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromGenericIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromGenericIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromGenericIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromGenericIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromGoogleIDsResult>> GetPlayFabIDsFromGoogleIDsAsync(GetPlayFabIDsFromGoogleIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromGoogleIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromGoogleIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromGoogleIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromGoogleIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>> GetPlayFabIDsFromGooglePlayGamesPlayerIDsAsync(GetPlayFabIDsFromGooglePlayGamesPlayerIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromGooglePlayGamesPlayerIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromGooglePlayGamesPlayerIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromKongregateIDsResult>> GetPlayFabIDsFromKongregateIDsAsync(GetPlayFabIDsFromKongregateIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromKongregateIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromKongregateIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromKongregateIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromKongregateIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult>> GetPlayFabIDsFromNintendoServiceAccountIdsAsync(GetPlayFabIDsFromNintendoServiceAccountIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromNintendoServiceAccountIds", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromNintendoServiceAccountIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromNintendoServiceAccountIdsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>> GetPlayFabIDsFromNintendoSwitchDeviceIdsAsync(GetPlayFabIDsFromNintendoSwitchDeviceIdsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromNintendoSwitchDeviceIds", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromNintendoSwitchDeviceIdsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult>> GetPlayFabIDsFromPSNAccountIDsAsync(GetPlayFabIDsFromPSNAccountIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromPSNAccountIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromPSNAccountIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromPSNAccountIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult>> GetPlayFabIDsFromPSNOnlineIDsAsync(GetPlayFabIDsFromPSNOnlineIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromPSNOnlineIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromPSNOnlineIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromPSNOnlineIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromSteamIDsResult>> GetPlayFabIDsFromSteamIDsAsync(GetPlayFabIDsFromSteamIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromSteamIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromSteamIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromSteamIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromSteamIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromSteamNamesResult>> GetPlayFabIDsFromSteamNamesAsync(GetPlayFabIDsFromSteamNamesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromSteamNames", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromSteamNamesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromSteamNamesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromSteamNamesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromTwitchIDsResult>> GetPlayFabIDsFromTwitchIDsAsync(GetPlayFabIDsFromTwitchIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromTwitchIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromTwitchIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromTwitchIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult>> GetPlayFabIDsFromXboxLiveIDsAsync(GetPlayFabIDsFromXboxLiveIDsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPlayFabIDsFromXboxLiveIDs", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPlayFabIDsFromXboxLiveIDsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPlayFabIDsFromXboxLiveIDsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPublisherDataResult>> GetPublisherDataAsync(GetPublisherDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPublisherData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPublisherDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPublisherDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPublisherDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetPurchaseResult>> GetPurchaseAsync(GetPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetPurchase", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetPurchaseResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetPurchaseResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetPurchaseResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetSharedGroupDataResult>> GetSharedGroupDataAsync(GetSharedGroupDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetSharedGroupData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetSharedGroupDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetSharedGroupDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetSharedGroupDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetStoreItemsResult>> GetStoreItemsAsync(GetStoreItemsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetStoreItems", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetStoreItemsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetStoreItemsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetStoreItemsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTimeResult>> GetTimeAsync(GetTimeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetTime", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTimeResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTimeResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTimeResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTitleDataResult>> GetTitleDataAsync(GetTitleDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetTitleData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTitleNewsResult>> GetTitleNewsAsync(GetTitleNewsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetTitleNews", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitleNewsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitleNewsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitleNewsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTitlePublicKeyResult>> GetTitlePublicKeyAsync(GetTitlePublicKeyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var httpResult = await PlayFabHttp.Post("/Client/GetTitlePublicKey", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTitlePublicKeyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTitlePublicKeyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTitlePublicKeyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetTradeStatusResponse>> GetTradeStatusAsync(GetTradeStatusRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetTradeStatus", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetTradeStatusResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetTradeStatusResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetTradeStatusResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserCombinedInfoResult>> GetUserCombinedInfoAsync(GetUserCombinedInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserCombinedInfo", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserCombinedInfoResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserCombinedInfoResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserCombinedInfoResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserDataResult>> GetUserDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserInventoryResult>> GetUserInventoryAsync(GetUserInventoryRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserInventory", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserInventoryResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserInventoryResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserInventoryResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserPublisherData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserDataResult>> GetUserPublisherReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserPublisherReadOnlyData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserDataResult>> GetUserReadOnlyDataAsync(GetUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserReadOnlyData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GetUserStatisticsResult>> GetUserStatisticsAsync(GetUserStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GetUserStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GetUserStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GetUserStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GetUserStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<GrantCharacterToUserResult>> GrantCharacterToUserAsync(GrantCharacterToUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/GrantCharacterToUser", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<GrantCharacterToUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<GrantCharacterToUserResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<GrantCharacterToUserResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkAndroidDeviceIDResult>> LinkAndroidDeviceIDAsync(LinkAndroidDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkAndroidDeviceID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkAndroidDeviceIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkAndroidDeviceIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkAndroidDeviceIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> LinkAppleAsync(LinkAppleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkApple", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> LinkBattleNetAccountAsync(LinkBattleNetAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkBattleNetAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkCustomIDResult>> LinkCustomIDAsync(LinkCustomIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkCustomID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkCustomIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkCustomIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkCustomIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkFacebookAccountResult>> LinkFacebookAccountAsync(LinkFacebookAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkFacebookAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkFacebookAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkFacebookAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkFacebookAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkFacebookInstantGamesIdResult>> LinkFacebookInstantGamesIdAsync(LinkFacebookInstantGamesIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkFacebookInstantGamesId", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkFacebookInstantGamesIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkFacebookInstantGamesIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkFacebookInstantGamesIdResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkGameCenterAccountResult>> LinkGameCenterAccountAsync(LinkGameCenterAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkGameCenterAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkGameCenterAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkGameCenterAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkGameCenterAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkGoogleAccountResult>> LinkGoogleAccountAsync(LinkGoogleAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkGoogleAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkGoogleAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkGoogleAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkGoogleAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkGooglePlayGamesServicesAccountResult>> LinkGooglePlayGamesServicesAccountAsync(LinkGooglePlayGamesServicesAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkGooglePlayGamesServicesAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkGooglePlayGamesServicesAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkGooglePlayGamesServicesAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkGooglePlayGamesServicesAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkIOSDeviceIDResult>> LinkIOSDeviceIDAsync(LinkIOSDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkIOSDeviceID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkIOSDeviceIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkIOSDeviceIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkIOSDeviceIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkKongregateAccountResult>> LinkKongregateAsync(LinkKongregateAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkKongregate", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkKongregateAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkKongregateAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkKongregateAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> LinkNintendoServiceAccountAsync(LinkNintendoServiceAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkNintendoServiceAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkNintendoSwitchDeviceIdResult>> LinkNintendoSwitchDeviceIdAsync(LinkNintendoSwitchDeviceIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkNintendoSwitchDeviceId", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkNintendoSwitchDeviceIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkNintendoSwitchDeviceIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkNintendoSwitchDeviceIdResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResult>> LinkOpenIdConnectAsync(LinkOpenIdConnectRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkOpenIdConnect", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkPSNAccountResult>> LinkPSNAccountAsync(LinkPSNAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkPSNAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkPSNAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkPSNAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkPSNAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkSteamAccountResult>> LinkSteamAccountAsync(LinkSteamAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkSteamAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkSteamAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkSteamAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkSteamAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkTwitchAccountResult>> LinkTwitchAsync(LinkTwitchAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkTwitch", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkTwitchAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkTwitchAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkTwitchAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LinkXboxAccountResult>> LinkXboxAccountAsync(LinkXboxAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LinkXboxAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LinkXboxAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LinkXboxAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LinkXboxAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ListPlayerCustomPropertiesResult>> ListPlayerCustomPropertiesAsync(ListPlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ListPlayerCustomProperties", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ListPlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ListPlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ListPlayerCustomPropertiesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LogEventResult>> LogEventAsync(LogEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LogEvent", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LogEventResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LogEventResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<LogEventResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithAndroidDeviceIDAsync(LoginWithAndroidDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithAndroidDeviceID", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithAppleAsync(LoginWithAppleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithApple", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithBattleNetAsync(LoginWithBattleNetRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithBattleNet", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithCustomIDAsync(LoginWithCustomIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithCustomID", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithEmailAddressAsync(LoginWithEmailAddressRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithEmailAddress", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithFacebookAsync(LoginWithFacebookRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithFacebook", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithFacebookInstantGamesIdAsync(LoginWithFacebookInstantGamesIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithFacebookInstantGamesId", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithGameCenterAsync(LoginWithGameCenterRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithGameCenter", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithGoogleAccountAsync(LoginWithGoogleAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithGoogleAccount", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithGooglePlayGamesServicesAsync(LoginWithGooglePlayGamesServicesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithGooglePlayGamesServices", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithIOSDeviceIDAsync(LoginWithIOSDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithIOSDeviceID", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithKongregateAsync(LoginWithKongregateRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithKongregate", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithNintendoServiceAccountAsync(LoginWithNintendoServiceAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithNintendoServiceAccount", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithNintendoSwitchDeviceIdAsync(LoginWithNintendoSwitchDeviceIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithNintendoSwitchDeviceId", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithOpenIdConnectAsync(LoginWithOpenIdConnectRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithOpenIdConnect", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithPlayFabAsync(LoginWithPlayFabRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithPlayFab", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithPSNAsync(LoginWithPSNRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithPSN", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithSteamAsync(LoginWithSteamRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithSteam", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithTwitchAsync(LoginWithTwitchRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithTwitch", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<LoginResult>> LoginWithXboxAsync(LoginWithXboxRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (request != null) request.TitleId = request?.TitleId ?? requestSettings.TitleId;
        if (request.TitleId == null) throw new PlayFabException(PlayFabExceptionCode.TitleNotSet, "TitleId must be set in your local or global settings to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/LoginWithXbox", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<LoginResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<LoginResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<LoginResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<MatchmakeResult>> MatchmakeAsync(MatchmakeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/Matchmake", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<MatchmakeResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<MatchmakeResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<MatchmakeResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<OpenTradeResponse>> OpenTradeAsync(OpenTradeRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/OpenTrade", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<OpenTradeResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<OpenTradeResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<OpenTradeResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<PayForPurchaseResult>> PayForPurchaseAsync(PayForPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/PayForPurchase", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<PayForPurchaseResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<PayForPurchaseResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<PayForPurchaseResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<PurchaseItemResult>> PurchaseItemAsync(PurchaseItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/PurchaseItem", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<PurchaseItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<PurchaseItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<PurchaseItemResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RedeemCouponResult>> RedeemCouponAsync(RedeemCouponRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RedeemCoupon", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RedeemCouponResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RedeemCouponResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RedeemCouponResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> RefreshPSNAuthTokenAsync(RefreshPSNAuthTokenRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RefreshPSNAuthToken", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RegisterForIOSPushNotificationResult>> RegisterForIOSPushNotificationAsync(RegisterForIOSPushNotificationRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RegisterForIOSPushNotification", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RegisterForIOSPushNotificationResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RegisterForIOSPushNotificationResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RegisterForIOSPushNotificationResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RegisterPlayFabUserResult>> RegisterPlayFabUserAsync(RegisterPlayFabUserRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var httpResult = await PlayFabHttp.Post("/Client/RegisterPlayFabUser", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RegisterPlayFabUserResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RegisterPlayFabUserResult>>((string)httpResult);
        var result = resultData!.data;
        result.AuthenticationContext = new PlayFabAuthenticationContext(result.SessionTicket, result.EntityToken.EntityToken, result.PlayFabId, result.EntityToken.Entity.Id, result.EntityToken.Entity.Type);
        authContext.CopyFrom(result.AuthenticationContext);

        return new PlayFabResult<RegisterPlayFabUserResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RemoveContactEmailResult>> RemoveContactEmailAsync(RemoveContactEmailRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RemoveContactEmail", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveContactEmailResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveContactEmailResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveContactEmailResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RemoveFriendResult>> RemoveFriendAsync(RemoveFriendRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RemoveFriend", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveFriendResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveFriendResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveFriendResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RemoveGenericIDResult>> RemoveGenericIDAsync(RemoveGenericIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RemoveGenericID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveGenericIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveGenericIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveGenericIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RemoveSharedGroupMembersResult>> RemoveSharedGroupMembersAsync(RemoveSharedGroupMembersRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RemoveSharedGroupMembers", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RemoveSharedGroupMembersResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RemoveSharedGroupMembersResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RemoveSharedGroupMembersResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ReportAdActivityResult>> ReportAdActivityAsync(ReportAdActivityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ReportAdActivity", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ReportAdActivityResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ReportAdActivityResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ReportAdActivityResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> ReportDeviceInfoAsync(DeviceInfoRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ReportDeviceInfo", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ReportPlayerClientResult>> ReportPlayerAsync(ReportPlayerClientRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ReportPlayer", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ReportPlayerClientResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ReportPlayerClientResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ReportPlayerClientResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RestoreIOSPurchasesResult>> RestoreIOSPurchasesAsync(RestoreIOSPurchasesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RestoreIOSPurchases", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RestoreIOSPurchasesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RestoreIOSPurchasesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RestoreIOSPurchasesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RewardAdActivityResult>> RewardAdActivityAsync(RewardAdActivityRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RewardAdActivity", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RewardAdActivityResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RewardAdActivityResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RewardAdActivityResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<RunCloudScriptResult>> RunCloudScriptAsync(RunCloudScriptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/RunCloudScript", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<RunCloudScriptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<RunCloudScriptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<RunCloudScriptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SendAccountRecoveryEmailResult>> SendAccountRecoveryEmailAsync(SendAccountRecoveryEmailRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;


        var httpResult = await PlayFabHttp.Post("/Client/SendAccountRecoveryEmail", request, null, null, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SendAccountRecoveryEmailResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SendAccountRecoveryEmailResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SendAccountRecoveryEmailResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetFriendTagsResult>> SetFriendTagsAsync(SetFriendTagsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/SetFriendTags", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetFriendTagsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetFriendTagsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetFriendTagsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<SetPlayerSecretResult>> SetPlayerSecretAsync(SetPlayerSecretRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/SetPlayerSecret", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<SetPlayerSecretResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<SetPlayerSecretResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<SetPlayerSecretResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<StartGameResult>> StartGameAsync(StartGameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/StartGame", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<StartGameResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<StartGameResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<StartGameResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<StartPurchaseResult>> StartPurchaseAsync(StartPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/StartPurchase", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<StartPurchaseResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<StartPurchaseResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<StartPurchaseResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ModifyUserVirtualCurrencyResult>> SubtractUserVirtualCurrencyAsync(SubtractUserVirtualCurrencyRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/SubtractUserVirtualCurrency", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ModifyUserVirtualCurrencyResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ModifyUserVirtualCurrencyResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkAndroidDeviceIDResult>> UnlinkAndroidDeviceIDAsync(UnlinkAndroidDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkAndroidDeviceID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkAndroidDeviceIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkAndroidDeviceIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkAndroidDeviceIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UnlinkAppleAsync(UnlinkAppleRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkApple", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UnlinkBattleNetAccountAsync(UnlinkBattleNetAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkBattleNetAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkCustomIDResult>> UnlinkCustomIDAsync(UnlinkCustomIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkCustomID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkCustomIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkCustomIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkCustomIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkFacebookAccountResult>> UnlinkFacebookAccountAsync(UnlinkFacebookAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkFacebookAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkFacebookAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkFacebookAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkFacebookAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkFacebookInstantGamesIdResult>> UnlinkFacebookInstantGamesIdAsync(UnlinkFacebookInstantGamesIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkFacebookInstantGamesId", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkFacebookInstantGamesIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkFacebookInstantGamesIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkFacebookInstantGamesIdResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkGameCenterAccountResult>> UnlinkGameCenterAccountAsync(UnlinkGameCenterAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkGameCenterAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkGameCenterAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkGameCenterAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkGameCenterAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkGoogleAccountResult>> UnlinkGoogleAccountAsync(UnlinkGoogleAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkGoogleAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkGoogleAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkGoogleAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkGoogleAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkGooglePlayGamesServicesAccountResult>> UnlinkGooglePlayGamesServicesAccountAsync(UnlinkGooglePlayGamesServicesAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkGooglePlayGamesServicesAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkGooglePlayGamesServicesAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkGooglePlayGamesServicesAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkGooglePlayGamesServicesAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkIOSDeviceIDResult>> UnlinkIOSDeviceIDAsync(UnlinkIOSDeviceIDRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkIOSDeviceID", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkIOSDeviceIDResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkIOSDeviceIDResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkIOSDeviceIDResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkKongregateAccountResult>> UnlinkKongregateAsync(UnlinkKongregateAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkKongregate", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkKongregateAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkKongregateAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkKongregateAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UnlinkNintendoServiceAccountAsync(UnlinkNintendoServiceAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkNintendoServiceAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkNintendoSwitchDeviceIdResult>> UnlinkNintendoSwitchDeviceIdAsync(UnlinkNintendoSwitchDeviceIdRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkNintendoSwitchDeviceId", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkNintendoSwitchDeviceIdResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkNintendoSwitchDeviceIdResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UnlinkOpenIdConnectAsync(UnlinkOpenIdConnectRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkOpenIdConnect", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkPSNAccountResult>> UnlinkPSNAccountAsync(UnlinkPSNAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkPSNAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkPSNAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkPSNAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkPSNAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkSteamAccountResult>> UnlinkSteamAccountAsync(UnlinkSteamAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkSteamAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkSteamAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkSteamAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkSteamAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkTwitchAccountResult>> UnlinkTwitchAsync(UnlinkTwitchAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkTwitch", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkTwitchAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkTwitchAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkTwitchAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlinkXboxAccountResult>> UnlinkXboxAccountAsync(UnlinkXboxAccountRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlinkXboxAccount", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlinkXboxAccountResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlinkXboxAccountResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlinkXboxAccountResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerInstanceAsync(UnlockContainerInstanceRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlockContainerInstance", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlockContainerItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlockContainerItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlockContainerItemResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UnlockContainerItemResult>> UnlockContainerItemAsync(UnlockContainerItemRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UnlockContainerItem", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UnlockContainerItemResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UnlockContainerItemResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UnlockContainerItemResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<EmptyResponse>> UpdateAvatarUrlAsync(UpdateAvatarUrlRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateAvatarUrl", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<EmptyResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<EmptyResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<EmptyResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateCharacterDataResult>> UpdateCharacterDataAsync(UpdateCharacterDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateCharacterData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateCharacterStatisticsResult>> UpdateCharacterStatisticsAsync(UpdateCharacterStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateCharacterStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateCharacterStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateCharacterStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateCharacterStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdatePlayerCustomPropertiesResult>> UpdatePlayerCustomPropertiesAsync(UpdatePlayerCustomPropertiesRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdatePlayerCustomProperties", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerCustomPropertiesResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerCustomPropertiesResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdatePlayerStatisticsResult>> UpdatePlayerStatisticsAsync(UpdatePlayerStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdatePlayerStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdatePlayerStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdatePlayerStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdatePlayerStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateSharedGroupDataResult>> UpdateSharedGroupDataAsync(UpdateSharedGroupDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateSharedGroupData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateSharedGroupDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateSharedGroupDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateSharedGroupDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateUserData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateUserDataResult>> UpdateUserPublisherDataAsync(UpdateUserDataRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateUserPublisherData", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserDataResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserDataResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserDataResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateUserStatisticsResult>> UpdateUserStatisticsAsync(UpdateUserStatisticsRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateUserStatistics", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserStatisticsResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserStatisticsResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserStatisticsResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<UpdateUserTitleDisplayNameResult>> UpdateUserTitleDisplayNameAsync(UpdateUserTitleDisplayNameRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/UpdateUserTitleDisplayName", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<UpdateUserTitleDisplayNameResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<UpdateUserTitleDisplayNameResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<UpdateUserTitleDisplayNameResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ValidateAmazonReceiptResult>> ValidateAmazonIAPReceiptAsync(ValidateAmazonReceiptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ValidateAmazonIAPReceipt", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ValidateAmazonReceiptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateAmazonReceiptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ValidateAmazonReceiptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ValidateGooglePlayPurchaseResult>> ValidateGooglePlayPurchaseAsync(ValidateGooglePlayPurchaseRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ValidateGooglePlayPurchase", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ValidateGooglePlayPurchaseResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateGooglePlayPurchaseResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ValidateGooglePlayPurchaseResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ValidateIOSReceiptResult>> ValidateIOSReceiptAsync(ValidateIOSReceiptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ValidateIOSReceipt", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ValidateIOSReceiptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateIOSReceiptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ValidateIOSReceiptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<ValidateWindowsReceiptResult>> ValidateWindowsStoreReceiptAsync(ValidateWindowsReceiptRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/ValidateWindowsStoreReceipt", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<ValidateWindowsReceiptResult> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<ValidateWindowsReceiptResult>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<ValidateWindowsReceiptResult> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<WriteEventResponse>> WriteCharacterEventAsync(WriteClientCharacterEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/WriteCharacterEvent", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<WriteEventResponse>> WritePlayerEventAsync(WriteClientPlayerEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/WritePlayerEvent", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }

    /// <inheritdoc />
    public async Task<PlayFabResult<WriteEventResponse>> WriteTitleEventAsync(WriteTitleEventRequest? request, Dictionary<string, string>? extraHeaders = null) {
        var requestContext = request?.AuthenticationContext ?? authContext;
        var requestSettings = apiSettings ?? PlayFabSettings.staticSettings;

        if (requestContext?.ClientSessionTicket == null) throw new PlayFabException(PlayFabExceptionCode.NotLoggedIn, "Must be logged in to call this method");

        var httpResult = await PlayFabHttp.Post("/Client/WriteTitleEvent", request, "X-Authorization", requestContext.ClientSessionTicket, extraHeaders, requestSettings, httpClient);
        if (httpResult is PlayFabError error)
        {
            return new PlayFabResult<WriteEventResponse> { Error = error };
        }

        var resultData = JsonSerializer.Deserialize<PlayFabJsonSuccess<WriteEventResponse>>((string)httpResult);
        var result = resultData!.data;

        return new PlayFabResult<WriteEventResponse> { Result = result };
    }

}