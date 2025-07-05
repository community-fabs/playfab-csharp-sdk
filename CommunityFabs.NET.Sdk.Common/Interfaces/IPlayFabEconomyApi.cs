using CommunityFabs.NET.Sdk.Common.Models.Economy;
namespace CommunityFabs.NET.Sdk.Common.Interfaces;

public interface IPlayFabEconomyApi {
    /// <summary>
    /// Add inventory items. Up to 10,000 stacks of items can be added to a single inventory collection. Stack size is uncapped.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.AddInventoryItemsAsync({);
    ///   "Item": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   },
    ///   "Amount": 3,
    ///   "ReturnInventory": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/addinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<AddInventoryItemsResponse>> AddInventoryItemsAsync(AddInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Given an existing Versioned Catalog, begin the process of validating the uploaded JSON and creating the described items.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.CompleteVersionedCatalogUploadAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/completeversionedcatalogupload">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CompleteVersionedCatalogUploadResponse>> CompleteVersionedCatalogUploadAsync(CompleteVersionedCatalogUploadRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new item in the working catalog using provided metadata. Note: SAS tokens provided are valid for 1 hour.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.CreateDraftItemAsync({);
    ///   "Item": {
    ///     "Type": "ugc",
    ///     "Title": {
    ///       "NEUTRAL": "Neutral title",
    ///       "en-US": "US English title"
    ///     },
    ///     "Description": {
    ///       "NEUTRAL": "Neutral description",
    ///       "en-US": "US English description"
    ///     },
    ///     "Keywords": {
    ///       "NEUTRAL": {
    ///         "Values": [
    ///           "Keyword_1",
    ///           "Keyword_2"
    ///         ]
    ///       }
    ///     },
    ///     "ContentType": "example item",
    ///     "CreatorEntity": {
    ///       "Id": "someId",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     },
    ///     "IsHidden": false,
    ///     "Tags": [
    ///       "pirates",
    ///       "holiday"
    ///     ],
    ///     "DisplayVersion": "1.0.0",
    ///     "CreationDate": "2018-08-17T22:32:10.472Z",
    ///     "Contents": [
    ///       {
    ///         "Id": "00000000-0000-0000-0000-000000000001",
    ///         "Url": "https://endpoint.blob.core.windows.net/some-identifier-private/00000000-0000-0000-0000-000000000001/textures.zip",
    ///         "MaxClientVersion": "2.4.1",
    ///         "MinClientVersion": "2.0.0"
    ///       }
    ///     ],
    ///     "Images": [
    ///       {
    ///         "Id": "00000000-0000-0000-0000-000000000003",
    ///         "Type": "Thumbnail",
    ///         "Url": "https://endpoint.blob.core.windows.net/some-identifier-private/00000000-0000-0000-0000-000000000003/splashscreen_thumb.jpg"
    ///       }
    ///     ],
    ///     "DisplayProperties": {
    ///       "mapDetails": {
    ///         "mapType": "desertIsland",
    ///         "gameMode": "capture",
    ///         "maxPlayers": 16
    ///       },
    ///       "averageMatchLengthInSeconds": 947
    ///     },
    ///     "DefaultStackId": "Static_Default_Stack_Id"
    ///   },
    ///   "Publish": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/createdraftitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateDraftItemResponse>> CreateDraftItemAsync(CreateDraftItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates one or more upload URLs which can be used by the client to upload raw file data. Content URls and uploaded
    /// content will be garbage collected after 24 hours if not attached to a draft or published item. Detailed pricing info
    /// around uploading content can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/pricing/meters/catalog-meters
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.CreateUploadUrlsAsync({);
    ///   "Files": [
    ///     {
    ///       "FileName": "textures.zip"
    ///     },
    ///     {
    ///       "FileName": "sprites.png"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/createuploadurls">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateUploadUrlsResponse>> CreateUploadUrlsAsync(CreateUploadUrlsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Given an existing Catalog Version, create an URL location where titles can upload a JSON schema of a catalog, if the
    /// catalog is empty.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.CreateVersionedCatalogUploadURLAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/createversionedcataloguploadurl">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateVersionedCatalogUploadURLResponse>> CreateVersionedCatalogUploadURLAsync(CreateVersionedCatalogUploadURLRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates a new view in the catalog using provided metadata.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.CreateViewAsync({);
    ///   "View": {
    ///     "FriendlyId": "exampleView",
    ///     "IsTitleView": false,
    ///     "Count": 10,
    ///     "Filter": "tags/any(t:t eq 'desert') and contentType eq 'map'",
    ///     "Language": "en-US",
    ///     "FileFormat": "JsonLines"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/createview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<CreateViewResponse>> CreateViewAsync(CreateViewRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes all reviews, helpfulness votes, and ratings submitted by the entity specified.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.DeleteEntityItemReviewsAsync({);
    ///   "Entity": {
    ///     "Id": "ABC123",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/deleteentityitemreviews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteEntityItemReviewsResponse>> DeleteEntityItemReviewsAsync(DeleteEntityItemReviewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete an Inventory Collection. More information about Inventory Collections can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/inventory/collections
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.DeleteInventoryCollectionAsync({);
    ///   "CollectionId": "backpack"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/deleteinventorycollection">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteInventoryCollectionResponse>> DeleteInventoryCollectionAsync(DeleteInventoryCollectionRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete inventory items
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.DeleteInventoryItemsAsync({);
    ///   "Item": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/deleteinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteInventoryItemsResponse>> DeleteInventoryItemsAsync(DeleteInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Removes an item from working catalog and all published versions from the public catalog.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.DeleteItemAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/deleteitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteItemResponse>> DeleteItemAsync(DeleteItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Delete versioned catalog.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.DeleteVersionedCatalogAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/deleteversionedcatalog">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<EmptyResponse>> DeleteVersionedCatalogAsync(DeleteVersionedCatalogRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Deletes a catalog view and the associated blob.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.DeleteViewAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/deleteview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<DeleteViewResponse>> DeleteViewAsync(DeleteViewRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Execute a list of Inventory Operations. A maximum list of 50 operations can be performed by a single request. There is
    /// also a limit to 300 items that can be modified/added in a single request. For example, adding a bundle with 50 items
    /// counts as 50 items modified. All operations must be done within a single inventory collection. This API has a reduced
    /// RPS compared to an individual inventory operation with Player Entities limited to 60 requests in 90 seconds.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.ExecuteInventoryOperationsAsync({);
    ///   "Operations": [
    ///     {
    ///       "Add": {
    ///         "Item": {
    ///           "Id": "11111111-1111-1111-1111-111111111111"
    ///         },
    ///         "Amount": 3
    ///       }
    ///     },
    ///     {
    ///       "Subtract": {
    ///         "Item": {
    ///           "Id": "11111111-1111-1111-1111-111111111111"
    ///         },
    ///         "Amount": 3,
    ///         "DeleteEmptyStacks": false
    ///       }
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/executeinventoryoperations">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExecuteInventoryOperationsResponse>> ExecuteInventoryOperationsAsync(ExecuteInventoryOperationsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Transfer a list of inventory items. A maximum list of 50 operations can be performed by a single request. When the
    /// response code is 202, one or more operations did not complete within the timeframe of the request. You can identify the
    /// pending operations by looking for OperationStatus = 'InProgress'. You can check on the operation status at anytime
    /// within 1 day of the request by passing the TransactionToken to the GetInventoryOperationStatus API.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.ExecuteTransferOperationsAsync({);
    ///   "Operations": [
    ///     {
    ///       "GivingItem": {
    ///         "Id": "11111111-1111-1111-1111-111111111111",
    ///         "StackId": "default"
    ///       },
    ///       "ReceivingItem": {
    ///         "Id": "11111111-1111-1111-1111-111111111111",
    ///         "StackId": "default"
    ///       },
    ///       "Amount": 1,
    ///       "DeleteEmptyStacks": false
    ///     }
    ///   ],
    ///   "GivingEntity": {
    ///     "Id": "someId1",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "ReceivingEntity": {
    ///     "Id": "someId2",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   },
    ///   "GivingCollectionId": "default",
    ///   "ReceivingCollectionId": "backpack"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/executetransferoperations">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ExecuteTransferOperationsResponse>> ExecuteTransferOperationsAsync(ExecuteTransferOperationsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Export versioned catalog.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.ExportVersionedCatalogAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/exportversionedcatalog">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<IActionResult>> ExportVersionedCatalogAsync(ExportVersionedCatalogRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the configuration for the catalog. Only Title Entities can call this API. There is a limit of 100 requests in 10
    /// seconds for this API. More information about the Catalog Config can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/settings
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetCatalogConfigAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getcatalogconfig">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetCatalogConfigResponse>> GetCatalogConfigAsync(GetCatalogConfigRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves an item from the working catalog. This item represents the current working state of the item. GetDraftItem
    /// does not work off a cache of the Catalog and should be used when trying to get recent item updates. However, please
    /// note that item references data is cached and may take a few moments for changes to propagate. Note: SAS tokens provided
    /// are valid for 1 hour.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetDraftItemAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getdraftitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetDraftItemResponse>> GetDraftItemAsync(GetDraftItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a paginated list of the items from the draft catalog. Up to 50 IDs can be retrieved in a single request.
    /// GetDraftItems does not work off a cache of the Catalog and should be used when trying to get recent item updates. Note:
    /// SAS tokens provided are valid for 1 hour.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetDraftItemsAsync({);
    ///   "Ids": [
    ///     "dddddddd-dddd-dddd-dddd-dddddddddddd",
    ///     "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getdraftitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetDraftItemsResponse>> GetDraftItemsAsync(GetDraftItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a paginated list of the items from the draft catalog created by the Entity. Up to 50 items can be returned at
    /// once. You can use continuation tokens to paginate through results that return greater than the limit.
    /// GetEntityDraftItems does not work off a cache of the Catalog and should be used when trying to get recent item updates.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetEntityDraftItemsAsync({);
    ///   "Count": 2,
    ///   "Entity": {
    ///     "Id": "someId",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getentitydraftitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEntityDraftItemsResponse>> GetEntityDraftItemsAsync(GetEntityDraftItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the submitted review for the specified item by the authenticated entity. Individual ratings and reviews data
    /// update in near real time with delays within a few seconds.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetEntityItemReviewAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getentityitemreview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetEntityItemReviewResponse>> GetEntityItemReviewAsync(GetEntityItemReviewRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get Inventory Collection Ids. Up to 50 Ids can be returned at once (or 250 with response compression enabled). You can
    /// use continuation tokens to paginate through results that return greater than the limit. It can take a few seconds for
    /// new collection Ids to show up.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.GetInventoryCollectionIdsAsync({);
    ///   "Count": 5
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/getinventorycollectionids">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetInventoryCollectionIdsResponse>> GetInventoryCollectionIdsAsync(GetInventoryCollectionIdsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get current inventory items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.GetInventoryItemsAsync({);
    ///   "Count": 5
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/getinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetInventoryItemsResponse>> GetInventoryItemsAsync(GetInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get the status of an inventory operation using an OperationToken. You can check on the operation status at anytime
    /// within 1 day of the request by passing the TransactionToken to the this API.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.GetInventoryOperationStatusAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/getinventoryoperationstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetInventoryOperationStatusResponse>> GetInventoryOperationStatusAsync(GetInventoryOperationStatusRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves an item from the public catalog. GetItem does not work off a cache of the Catalog and should be used when
    /// trying to get recent item updates. However, please note that item references data is cached and may take a few moments
    /// for changes to propagate.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemResponse>> GetItemAsync(GetItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Search for a given item and return a set of bundles and stores containing the item. Up to 50 items can be returned at
    /// once. You can use continuation tokens to paginate through results that return greater than the limit. This API is
    /// intended for tooling/automation scenarios and has a reduced RPS with Player Entities limited to 30 requests in 300
    /// seconds and Title Entities limited to 100 requests in 10 seconds.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemContainersAsync({);
    ///   "Count": 5,
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitemcontainers">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemContainersResponse>> GetItemContainersAsync(GetItemContainersRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the moderation state for an item, including the concern category and string reason. More information about
    /// moderation states can be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/ugc/moderation
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemModerationStateAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitemmoderationstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemModerationStateResponse>> GetItemModerationStateAsync(GetItemModerationStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the status of a publish of an item.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemPublishStatusAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitempublishstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemPublishStatusResponse>> GetItemPublishStatusAsync(GetItemPublishStatusRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a paginated set of reviews associated with the specified item. Individual ratings and reviews data update in near
    /// real time with delays within a few seconds.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemReviewsAsync({);
    ///   "Count": 2,
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitemreviews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemReviewsResponse>> GetItemReviewsAsync(GetItemReviewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get a summary of all ratings and reviews associated with the specified item. Summary ratings data is cached with update
    /// data coming within 15 minutes.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemReviewSummaryAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitemreviewsummary">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemReviewSummaryResponse>> GetItemReviewSummaryAsync(GetItemReviewSummaryRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves items from the public catalog. Up to 50 items can be returned at once. GetItems does not work off a cache of
    /// the Catalog and should be used when trying to get recent item updates. However, please note that item references data
    /// is cached and may take a few moments for changes to propagate.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetItemsAsync({);
    ///   "Ids": [
    ///     "dddddddd-dddd-dddd-dddd-dddddddddddd",
    ///     "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetItemsResponse>> GetItemsAsync(GetItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Gets the access tokens.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.GetMicrosoftStoreAccessTokensAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/getmicrosoftstoreaccesstokens">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetMicrosoftStoreAccessTokensResponse>> GetMicrosoftStoreAccessTokensAsync(GetMicrosoftStoreAccessTokensRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get transaction history for a player. Up to 250 Events can be returned at once. You can use continuation tokens to
    /// paginate through results that return greater than the limit. Getting transaction history has a lower RPS limit than
    /// getting a Player's inventory with Player Entities having a limit of 30 requests in 300 seconds.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.GetTransactionHistoryAsync({);
    ///   "Count": 10,
    ///   "CollectionId": "default"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/gettransactionhistory">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetTransactionHistoryResponse>> GetTransactionHistoryAsync(GetTransactionHistoryRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Get versioned catalog item.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.GetVersionedCatalogItemAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/getversionedcatalogitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetVersionedCatalogItemResponse>> GetVersionedCatalogItemAsync(GetVersionedCatalogItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Returns the current status of a Versioned Catalog upload.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.GetVersionedCatalogUploadStatusAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/getversionedcataloguploadstatus">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetVersionedCatalogUploadStatusResponse>> GetVersionedCatalogUploadStatusAsync(GetVersionedCatalogUploadStatusRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a specific catalog view.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetViewAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetViewResponse>> GetViewAsync(GetViewRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Retrieves a paginated list of the catalog views.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.GetViewsAsync({);
    ///   "Count": 5,
    ///   "Entity": {
    ///     "Id": "someId",
    ///     "Type": "title_player_account",
    ///     "TypeString": "title_player_account"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/getviews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<GetViewsResponse>> GetViewsAsync(GetViewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// List versioned catalogs.
    /// <example><br/>Example:<code>
    /// var response = await versionedcatalogApi.ListVersionedCatalogsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/versionedcatalog/versionedcatalog/listversionedcatalogs">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ListVersionedCatalogsResponse>> ListVersionedCatalogsAsync(ListVersionedCatalogsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Initiates a publish of an item from the working catalog to the public catalog. You can use the GetItemPublishStatus API
    /// to track the state of the item publish.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.PublishDraftItemAsync({);
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/publishdraftitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<PublishDraftItemResponse>> PublishDraftItemAsync(PublishDraftItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Purchase an item or bundle. Up to 10,000 stacks of items can be added to a single inventory collection. Stack size is
    /// uncapped.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.PurchaseInventoryItemsAsync({);
    ///   "Item": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   },
    ///   "Amount": 1,
    ///   "PriceAmounts": [
    ///     {
    ///       "ItemId": "cccccccc-cccc-cccc-cccc-cccccccccccc",
    ///       "Amount": 15
    ///     }
    ///   ],
    ///   "DeleteEmptyStacks": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/purchaseinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<PurchaseInventoryItemsResponse>> PurchaseInventoryItemsAsync(PurchaseInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemAppleAppStoreInventoryItemsAsync({);
    ///   "Receipt": "receipt"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemappleappstoreinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemAppleAppStoreInventoryItemsResponse>> RedeemAppleAppStoreInventoryItemsAsync(RedeemAppleAppStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemGooglePlayInventoryItemsAsync({);
    ///   "Purchases": [
    ///     {
    ///       "ProductId": "productId",
    ///       "Token": "token"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemgoogleplayinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemGooglePlayInventoryItemsResponse>> RedeemGooglePlayInventoryItemsAsync(RedeemGooglePlayInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemMicrosoftStoreInventoryItemsAsync({);
    ///   "CollectionsIdKey": "collectionsIdKey"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemmicrosoftstoreinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemMicrosoftStoreInventoryItemsResponse>> RedeemMicrosoftStoreInventoryItemsAsync(RedeemMicrosoftStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemNintendoEShopInventoryItemsAsync({);
    ///   "NintendoServiceAccountIdToken": "nsaIdToken"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemnintendoeshopinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemNintendoEShopInventoryItemsResponse>> RedeemNintendoEShopInventoryItemsAsync(RedeemNintendoEShopInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemPlayStationStoreInventoryItemsAsync({);
    ///   "AuthorizationCode": "authorizationCode",
    ///   "RedirectUri": "orbis://games",
    ///   "ServiceLabel": "0"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemplaystationstoreinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemPlayStationStoreInventoryItemsResponse>> RedeemPlayStationStoreInventoryItemsAsync(RedeemPlayStationStoreInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Redeem items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.RedeemSteamInventoryItemsAsync({});
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/redeemsteaminventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<RedeemSteamInventoryItemsResponse>> RedeemSteamInventoryItemsAsync(RedeemSteamInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Submit a report for an item, indicating in what way the item is inappropriate.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.ReportItemAsync({);
    ///   "ConcernCategory": "Profanity",
    ///   "Reason": "There was swearing in the description.",
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/reportitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ReportItemResponse>> ReportItemAsync(ReportItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Submit a report for a review
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.ReportItemReviewAsync({);
    ///   "ReviewId": "dddddddd-dddd-dddd-dddd-dddddddddddd",
    ///   "ItemId": "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee",
    ///   "ConcernCategory": "OffensiveContent",
    ///   "Reason": "Foul language."
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/reportitemreview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ReportItemReviewResponse>> ReportItemReviewAsync(ReportItemReviewRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Creates or updates a review for the specified item. More information around the caching surrounding item ratings and
    /// reviews can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/ratings#ratings-design-and-caching
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.ReviewItemAsync({);
    ///   "Review": {
    ///     "ItemVersion": "2.4.1",
    ///     "Title": "Best Game Ever",
    ///     "ReviewText": "I play this game every day. It's my favorite game yet.",
    ///     "Rating": 5,
    ///     "IsInstalled": true,
    ///     "HelpfulPositive": 0,
    ///     "HelpfulNegative": 0,
    ///     "Submitted": "0001-01-01T00:00:00Z"
    ///   },
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/reviewitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<ReviewItemResponse>> ReviewItemAsync(ReviewItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Executes a search against the public catalog using the provided search parameters and returns a set of paginated
    /// results. SearchItems uses a cache of the catalog with item updates taking up to a few minutes to propagate. You should
    /// use the GetItem API for when trying to immediately get recent item updates. More information about the Search API can
    /// be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/catalog/search
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.SearchItemsAsync({);
    ///   "Search": "Pirates",
    ///   "Filter": "tags/any(t:t eq 'desert') and contentType eq 'map'",
    ///   "OrderBy": "lastModifiedDate asc",
    ///   "ContinuationToken": "abc=",
    ///   "Count": 2
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/searchitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SearchItemsResponse>> SearchItemsAsync(SearchItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Sets the moderation state for an item, including the concern category and string reason. More information about
    /// moderation states can be found here: https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/ugc/moderation
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.SetItemModerationStateAsync({);
    ///   "Status": "AwaitingModeration",
    ///   "Reason": "User reports over threshold",
    ///   "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/setitemmoderationstate">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SetItemModerationStateResponse>> SetItemModerationStateAsync(SetItemModerationStateRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Submit a vote for a review, indicating whether the review was helpful or unhelpful.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.SubmitItemReviewVoteAsync({);
    ///   "ReviewId": "dddddddd-dddd-dddd-dddd-dddddddddddd",
    ///   "ItemId": "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee",
    ///   "Vote": "Helpful"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/submititemreviewvote">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SubmitItemReviewVoteResponse>> SubmitItemReviewVoteAsync(SubmitItemReviewVoteRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Subtract inventory items.
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.SubtractInventoryItemsAsync({);
    ///   "Item": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   },
    ///   "Amount": 3,
    ///   "DeleteEmptyStacks": false,
    ///   "ReturnInventory": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/subtractinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<SubtractInventoryItemsResponse>> SubtractInventoryItemsAsync(SubtractInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Submit a request to takedown one or more reviews.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.TakedownItemReviewsAsync({);
    ///   "Reviews": [
    ///     {
    ///       "ItemId": "00000000-0000-0000-0000-000000000003",
    ///       "ReviewId": "dddddddd-dddd-dddd-dddd-dddddddddddd"
    ///     }
    ///   ]
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/takedownitemreviews">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<TakedownItemReviewsResponse>> TakedownItemReviewsAsync(TakedownItemReviewsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Transfer inventory items. When transferring across collections, a 202 response indicates that the transfer did not
    /// complete within the timeframe of the request. You can identify the pending operations by looking for OperationStatus =
    /// 'InProgress'. You can check on the operation status at anytime within 1 day of the request by passing the
    /// TransactionToken to the GetInventoryOperationStatus API. More information about item transfer scenarios can be found
    /// here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/inventory/?tabs=inventory-game-manager#transfer-inv
    /// entory-items
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.TransferInventoryItemsAsync({);
    ///   "GivingItem": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   },
    ///   "ReceivingItem": {
    ///     "Id": "11111111-1111-1111-1111-111111111111"
    ///   },
    ///   "Amount": 1,
    ///   "DeleteEmptyStacks": false,
    ///   "GivingCollectionId": "default",
    ///   "ReceivingCollectionId": "backpack"
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/transferinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<TransferInventoryItemsResponse>> TransferInventoryItemsAsync(TransferInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates the configuration for the catalog. Only Title Entities can call this API. There is a limit of 10 requests in 10
    /// seconds for this API. More information about the Catalog Config can be found here:
    /// https://learn.microsoft.com/en-us/gaming/playfab/features/economy-v2/settings
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.UpdateCatalogConfigAsync({);
    ///   "Config": {
    ///     "IsCatalogEnabled": true,
    ///     "AdminEntities": [
    ///       {
    ///         "Id": "ABC123",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     ],
    ///     "DisplayPropertyIndexInfos": [
    ///       {
    ///         "Name": "damage",
    ///         "Type": "QueryDouble"
    ///       }
    ///     ],
    ///     "ReviewerEntities": [
    ///       {
    ///         "Id": "ABC123",
    ///         "Type": "title_player_account",
    ///         "TypeString": "title_player_account"
    ///       }
    ///     ],
    ///     "UserGeneratedContent": {
    ///       "ContentTypes": [
    ///         "skin",
    ///         "map",
    ///         "example item"
    ///       ],
    ///       "Tags": [
    ///         "pirate",
    ///         "holiday"
    ///       ]
    ///     }
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/updatecatalogconfig">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateCatalogConfigResponse>> UpdateCatalogConfigAsync(UpdateCatalogConfigRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update the metadata for an item in the working catalog. Note: SAS tokens provided are valid for 1 hour.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.UpdateDraftItemAsync({);
    ///   "Item": {
    ///     "Id": "qqqqqqqq-qqqq-qqqq-qqqq-qqqqqqqqqqqq",
    ///     "Type": "ugc",
    ///     "Title": {
    ///       "NEUTRAL": "Neutral title",
    ///       "en-US": "US English title"
    ///     },
    ///     "Description": {
    ///       "NEUTRAL": "Neutral description",
    ///       "en-US": "US English description"
    ///     },
    ///     "Keywords": {
    ///       "NEUTRAL": {
    ///         "Values": [
    ///           "Keyword_1",
    ///           "Keyword_2"
    ///         ]
    ///       }
    ///     },
    ///     "ContentType": "example item",
    ///     "CreatorEntity": {
    ///       "Id": "someId",
    ///       "Type": "title_player_account",
    ///       "TypeString": "title_player_account"
    ///     },
    ///     "IsHidden": false,
    ///     "Tags": [
    ///       "pirates",
    ///       "holiday"
    ///     ],
    ///     "DisplayVersion": "1.0.0",
    ///     "CreationDate": "2018-08-17T22:32:10.472Z",
    ///     "Contents": [
    ///       {
    ///         "Id": "00000000-0000-0000-0000-000000000001",
    ///         "Url": "https://endpoint.blob.core.windows.net/some-identifier-private/00000000-0000-0000-0000-000000000001/textures.zip",
    ///         "MaxClientVersion": "2.4.1",
    ///         "MinClientVersion": "2.0.0"
    ///       }
    ///     ],
    ///     "Images": [
    ///       {
    ///         "Id": "00000000-0000-0000-0000-000000000003",
    ///         "Type": "Thumbnail",
    ///         "Url": "https://endpoint.blob.core.windows.net/some-identifier-private/00000000-0000-0000-0000-000000000003/splashscreen_thumb.jpg"
    ///       }
    ///     ],
    ///     "DisplayProperties": {
    ///       "mapDetails": {
    ///         "mapType": "desertIsland",
    ///         "gameMode": "capture",
    ///         "maxPlayers": 16
    ///       },
    ///       "averageMatchLengthInSeconds": 947
    ///     },
    ///     "DefaultStackId": "Static_Default_Stack_Id"
    ///   },
    ///   "Publish": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/updatedraftitem">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateDraftItemResponse>> UpdateDraftItemAsync(UpdateDraftItemRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Update inventory items
    /// <example><br/>Example:<code>
    /// var response = await inventoryApi.UpdateInventoryItemsAsync({);
    ///   "Item": {
    ///     "Id": "11111111-1111-1111-1111-111111111111",
    ///     "Amount": 3
    ///   },
    ///   "ReturnInventory": false
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/inventory/inventory/updateinventoryitems">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateInventoryItemsResponse>> UpdateInventoryItemsAsync(UpdateInventoryItemsRequest request, Dictionary<string, string>? extraHeaders);
    /// <summary>
    /// Updates an existing view in the catalog using provided metadata.
    /// <example><br/>Example:<code>
    /// var response = await catalogApi.UpdateViewAsync({);
    ///   "View": {
    ///     "Id": "dddddddd-dddd-dddd-dddd-dddddddddddd",
    ///     "FriendlyId": "exampleView",
    ///     "IsTitleView": false,
    ///     "Count": 10,
    ///     "Filter": "tags/any(t:t eq 'desert') and contentType eq 'map'",
    ///     "Language": "en-US",
    ///     "FileFormat": "JsonLines",
    ///     "Url": "https://views.prod.catalog.playfab.com/title-identifier/dddddddd-dddd-dddd-dddd-dddddddddddd.json",
    ///     "LastModifiedDate": "2023-08-17T22:32:31.911Z",
    ///     "CreationDate": "2023-08-17T22:32:10.472Z",
    ///     "LastViewDiagnostics": {
    ///       "GeneratedDate": "2023-08-18T23:32:10.322Z",
    ///       "Status": "Unknown"
    ///     },
    ///     "ETag": "opaqueString"
    ///   }
    /// });
    /// </code></example>
    /// <br/><see href="https://docs.microsoft.com/rest/api/playfab/catalog/catalog/updateview">Microsoft Documentation</see>
    /// </summary>
    public Task<PlayFabResult<UpdateViewResponse>> UpdateViewAsync(UpdateViewRequest request, Dictionary<string, string>? extraHeaders);
}