using CommunityFabs.NET.Sdk.Models.Economy;
using CommunityFabs.NET.Sdk.Models;
namespace CommunityFabs.NET.Sdk.Interfaces;

public class PlayFabEconomyInstanceApi : PlayFabBaseInstanceApi, IPlayFabEconomyApi {
    public PlayFabEconomyInstanceApi() : base() { }
    public PlayFabEconomyInstanceApi(PlayFabApiSettings apiSettings) : base(apiSettings) { }
    public PlayFabEconomyInstanceApi(PlayFabAuthenticationContext context) : base(context) { }
    public PlayFabEconomyInstanceApi(PlayFabApiSettings settings, PlayFabAuthenticationContext context) : base(settings, context) { }

    public async Task<AddInventoryItemsResponse> AddInventoryItemsAsync(AddInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<AddInventoryItemsResponse>("/Inventory/AddInventoryItems", request, extraHeaders);
    }
    public async Task<CompleteVersionedCatalogUploadResponse> CompleteVersionedCatalogUploadAsync(CompleteVersionedCatalogUploadRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CompleteVersionedCatalogUploadResponse>("/VersionedCatalog/CompleteVersionedCatalogUpload", request, extraHeaders);
    }
    public async Task<CreateDraftItemResponse> CreateDraftItemAsync(CreateDraftItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateDraftItemResponse>("/Catalog/CreateDraftItem", request, extraHeaders);
    }
    public async Task<CreateUploadUrlsResponse> CreateUploadUrlsAsync(CreateUploadUrlsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateUploadUrlsResponse>("/Catalog/CreateUploadUrls", request, extraHeaders);
    }
    public async Task<CreateVersionedCatalogUploadURLResponse> CreateVersionedCatalogUploadURLAsync(CreateVersionedCatalogUploadURLRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateVersionedCatalogUploadURLResponse>("/VersionedCatalog/CreateVersionedCatalogUploadURL", request, extraHeaders);
    }
    public async Task<CreateViewResponse> CreateViewAsync(CreateViewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<CreateViewResponse>("/Catalog/CreateView", request, extraHeaders);
    }
    public async Task<DeleteEntityItemReviewsResponse> DeleteEntityItemReviewsAsync(DeleteEntityItemReviewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteEntityItemReviewsResponse>("/Catalog/DeleteEntityItemReviews", request, extraHeaders);
    }
    public async Task<DeleteInventoryCollectionResponse> DeleteInventoryCollectionAsync(DeleteInventoryCollectionRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteInventoryCollectionResponse>("/Inventory/DeleteInventoryCollection", request, extraHeaders);
    }
    public async Task<DeleteInventoryItemsResponse> DeleteInventoryItemsAsync(DeleteInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteInventoryItemsResponse>("/Inventory/DeleteInventoryItems", request, extraHeaders);
    }
    public async Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteItemResponse>("/Catalog/DeleteItem", request, extraHeaders);
    }
    public async Task<EmptyResponse> DeleteVersionedCatalogAsync(DeleteVersionedCatalogRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<EmptyResponse>("/VersionedCatalog/DeleteVersionedCatalog", request, extraHeaders);
    }
    public async Task<DeleteViewResponse> DeleteViewAsync(DeleteViewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<DeleteViewResponse>("/Catalog/DeleteView", request, extraHeaders);
    }
    public async Task<ExecuteInventoryOperationsResponse> ExecuteInventoryOperationsAsync(ExecuteInventoryOperationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteInventoryOperationsResponse>("/Inventory/ExecuteInventoryOperations", request, extraHeaders);
    }
    public async Task<ExecuteTransferOperationsResponse> ExecuteTransferOperationsAsync(ExecuteTransferOperationsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ExecuteTransferOperationsResponse>("/Inventory/ExecuteTransferOperations", request, extraHeaders);
    }
    public async Task<IActionResult> ExportVersionedCatalogAsync(ExportVersionedCatalogRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<IActionResult>("/VersionedCatalog/ExportVersionedCatalog", request, extraHeaders);
    }
    public async Task<GetCatalogConfigResponse> GetCatalogConfigAsync(GetCatalogConfigRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetCatalogConfigResponse>("/Catalog/GetCatalogConfig", request, extraHeaders);
    }
    public async Task<GetDraftItemResponse> GetDraftItemAsync(GetDraftItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetDraftItemResponse>("/Catalog/GetDraftItem", request, extraHeaders);
    }
    public async Task<GetDraftItemsResponse> GetDraftItemsAsync(GetDraftItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetDraftItemsResponse>("/Catalog/GetDraftItems", request, extraHeaders);
    }
    public async Task<GetEntityDraftItemsResponse> GetEntityDraftItemsAsync(GetEntityDraftItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityDraftItemsResponse>("/Catalog/GetEntityDraftItems", request, extraHeaders);
    }
    public async Task<GetEntityItemReviewResponse> GetEntityItemReviewAsync(GetEntityItemReviewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetEntityItemReviewResponse>("/Catalog/GetEntityItemReview", request, extraHeaders);
    }
    public async Task<GetInventoryCollectionIdsResponse> GetInventoryCollectionIdsAsync(GetInventoryCollectionIdsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetInventoryCollectionIdsResponse>("/Inventory/GetInventoryCollectionIds", request, extraHeaders);
    }
    public async Task<GetInventoryItemsResponse> GetInventoryItemsAsync(GetInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetInventoryItemsResponse>("/Inventory/GetInventoryItems", request, extraHeaders);
    }
    public async Task<GetInventoryOperationStatusResponse> GetInventoryOperationStatusAsync(GetInventoryOperationStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetInventoryOperationStatusResponse>("/Inventory/GetInventoryOperationStatus", request, extraHeaders);
    }
    public async Task<GetItemResponse> GetItemAsync(GetItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemResponse>("/Catalog/GetItem", request, extraHeaders);
    }
    public async Task<GetItemContainersResponse> GetItemContainersAsync(GetItemContainersRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemContainersResponse>("/Catalog/GetItemContainers", request, extraHeaders);
    }
    public async Task<GetItemModerationStateResponse> GetItemModerationStateAsync(GetItemModerationStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemModerationStateResponse>("/Catalog/GetItemModerationState", request, extraHeaders);
    }
    public async Task<GetItemPublishStatusResponse> GetItemPublishStatusAsync(GetItemPublishStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemPublishStatusResponse>("/Catalog/GetItemPublishStatus", request, extraHeaders);
    }
    public async Task<GetItemReviewsResponse> GetItemReviewsAsync(GetItemReviewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemReviewsResponse>("/Catalog/GetItemReviews", request, extraHeaders);
    }
    public async Task<GetItemReviewSummaryResponse> GetItemReviewSummaryAsync(GetItemReviewSummaryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemReviewSummaryResponse>("/Catalog/GetItemReviewSummary", request, extraHeaders);
    }
    public async Task<GetItemsResponse> GetItemsAsync(GetItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetItemsResponse>("/Catalog/GetItems", request, extraHeaders);
    }
    public async Task<GetMicrosoftStoreAccessTokensResponse> GetMicrosoftStoreAccessTokensAsync(GetMicrosoftStoreAccessTokensRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetMicrosoftStoreAccessTokensResponse>("/Inventory/GetMicrosoftStoreAccessTokens", request, extraHeaders);
    }
    public async Task<GetTransactionHistoryResponse> GetTransactionHistoryAsync(GetTransactionHistoryRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetTransactionHistoryResponse>("/Inventory/GetTransactionHistory", request, extraHeaders);
    }
    public async Task<GetVersionedCatalogItemResponse> GetVersionedCatalogItemAsync(GetVersionedCatalogItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetVersionedCatalogItemResponse>("/VersionedCatalog/GetVersionedCatalogItem", request, extraHeaders);
    }
    public async Task<GetVersionedCatalogUploadStatusResponse> GetVersionedCatalogUploadStatusAsync(GetVersionedCatalogUploadStatusRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetVersionedCatalogUploadStatusResponse>("/VersionedCatalog/GetVersionedCatalogUploadStatus", request, extraHeaders);
    }
    public async Task<GetViewResponse> GetViewAsync(GetViewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetViewResponse>("/Catalog/GetView", request, extraHeaders);
    }
    public async Task<GetViewsResponse> GetViewsAsync(GetViewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<GetViewsResponse>("/Catalog/GetViews", request, extraHeaders);
    }
    public async Task<ListVersionedCatalogsResponse> ListVersionedCatalogsAsync(ListVersionedCatalogsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ListVersionedCatalogsResponse>("/VersionedCatalog/ListVersionedCatalogs", request, extraHeaders);
    }
    public async Task<PublishDraftItemResponse> PublishDraftItemAsync(PublishDraftItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PublishDraftItemResponse>("/Catalog/PublishDraftItem", request, extraHeaders);
    }
    public async Task<PurchaseInventoryItemsResponse> PurchaseInventoryItemsAsync(PurchaseInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<PurchaseInventoryItemsResponse>("/Inventory/PurchaseInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemAppleAppStoreInventoryItemsResponse> RedeemAppleAppStoreInventoryItemsAsync(RedeemAppleAppStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemAppleAppStoreInventoryItemsResponse>("/Inventory/RedeemAppleAppStoreInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemGooglePlayInventoryItemsResponse> RedeemGooglePlayInventoryItemsAsync(RedeemGooglePlayInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemGooglePlayInventoryItemsResponse>("/Inventory/RedeemGooglePlayInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemMicrosoftStoreInventoryItemsResponse> RedeemMicrosoftStoreInventoryItemsAsync(RedeemMicrosoftStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemMicrosoftStoreInventoryItemsResponse>("/Inventory/RedeemMicrosoftStoreInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemNintendoEShopInventoryItemsResponse> RedeemNintendoEShopInventoryItemsAsync(RedeemNintendoEShopInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemNintendoEShopInventoryItemsResponse>("/Inventory/RedeemNintendoEShopInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemPlayStationStoreInventoryItemsResponse> RedeemPlayStationStoreInventoryItemsAsync(RedeemPlayStationStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemPlayStationStoreInventoryItemsResponse>("/Inventory/RedeemPlayStationStoreInventoryItems", request, extraHeaders);
    }
    public async Task<RedeemSteamInventoryItemsResponse> RedeemSteamInventoryItemsAsync(RedeemSteamInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<RedeemSteamInventoryItemsResponse>("/Inventory/RedeemSteamInventoryItems", request, extraHeaders);
    }
    public async Task<ReportItemResponse> ReportItemAsync(ReportItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReportItemResponse>("/Catalog/ReportItem", request, extraHeaders);
    }
    public async Task<ReportItemReviewResponse> ReportItemReviewAsync(ReportItemReviewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReportItemReviewResponse>("/Catalog/ReportItemReview", request, extraHeaders);
    }
    public async Task<ReviewItemResponse> ReviewItemAsync(ReviewItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<ReviewItemResponse>("/Catalog/ReviewItem", request, extraHeaders);
    }
    public async Task<SearchItemsResponse> SearchItemsAsync(SearchItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SearchItemsResponse>("/Catalog/SearchItems", request, extraHeaders);
    }
    public async Task<SetItemModerationStateResponse> SetItemModerationStateAsync(SetItemModerationStateRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SetItemModerationStateResponse>("/Catalog/SetItemModerationState", request, extraHeaders);
    }
    public async Task<SubmitItemReviewVoteResponse> SubmitItemReviewVoteAsync(SubmitItemReviewVoteRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SubmitItemReviewVoteResponse>("/Catalog/SubmitItemReviewVote", request, extraHeaders);
    }
    public async Task<SubtractInventoryItemsResponse> SubtractInventoryItemsAsync(SubtractInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<SubtractInventoryItemsResponse>("/Inventory/SubtractInventoryItems", request, extraHeaders);
    }
    public async Task<TakedownItemReviewsResponse> TakedownItemReviewsAsync(TakedownItemReviewsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<TakedownItemReviewsResponse>("/Catalog/TakedownItemReviews", request, extraHeaders);
    }
    public async Task<TransferInventoryItemsResponse> TransferInventoryItemsAsync(TransferInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<TransferInventoryItemsResponse>("/Inventory/TransferInventoryItems", request, extraHeaders);
    }
    public async Task<UpdateCatalogConfigResponse> UpdateCatalogConfigAsync(UpdateCatalogConfigRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateCatalogConfigResponse>("/Catalog/UpdateCatalogConfig", request, extraHeaders);
    }
    public async Task<UpdateDraftItemResponse> UpdateDraftItemAsync(UpdateDraftItemRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateDraftItemResponse>("/Catalog/UpdateDraftItem", request, extraHeaders);
    }
    public async Task<UpdateInventoryItemsResponse> UpdateInventoryItemsAsync(UpdateInventoryItemsRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateInventoryItemsResponse>("/Inventory/UpdateInventoryItems", request, extraHeaders);
    }
    public async Task<UpdateViewResponse> UpdateViewAsync(UpdateViewRequest request, Dictionary<string, string>? extraHeaders = null) {
        return await PostData<UpdateViewResponse>("/Catalog/UpdateView", request, extraHeaders);
    }
}