// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerInventoryCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetSellingManagerInventoryCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerInventoryCall()
    {
      this.ApiRequest = new GetSellingManagerInventoryRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerInventoryCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerInventoryRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves a paginated list containing details of a user's Selling Manager Inventory. This call is subject to change without notice; the deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="Sort">
    /// This field is used if the seller would like to sort Selling Manager Inventory results based on a specific aspect such as Product Name, Average Price, etc. See <b>SellingManagerProductSortCodeType</b> to read more about the available sorting options.
    /// </param>
    /// <param name="FolderID">
    /// This field is included if the seller wants to view Selling Manager Inventory from a specific folder.
    /// </param>
    /// <param name="Pagination">
    /// This container is used if the seller would like to control how many products are returned per page and which page to view.
    /// </param>
    /// <param name="SortOrder">
    /// This field allows the seller to sort in ascending or descending order (based on the selected aspect in the <b>Sort</b> field).
    /// </param>
    /// <param name="Search">
    /// This container is used if the seller would like to search for Selling Manager Inventory based on certain identifiers like Item ID, listing title, buyer user ID, etc. The seller will specify one of the supported search types in <b>SellingManagerSearchTypeCodeType</b>, and then provides the value for that search type.
    /// </param>
    /// <param name="StoreCategoryID">
    /// This field is used if the seller would like to retrieve all Selling Manager Inventory listed in a specific eBay Store Category.
    /// </param>
    /// <param name="FilterList">
    /// One or more <b>Filter</b> fields can be used to retrieve Selling Manager Inventory that is in a certain state, such as active listings, inactive listings, or listings that are low in stock.
    /// </param>
    public DateTime GetSellingManagerInventory(
      SellingManagerProductSortCodeType Sort,
      long FolderID,
      PaginationType Pagination,
      SortOrderCodeType SortOrder,
      SellingManagerSearchType Search,
      long StoreCategoryID,
      SellingManagerInventoryPropertyTypeCodeTypeCollection FilterList)
    {
      this.Sort = Sort;
      this.FolderID = FolderID;
      this.Pagination = Pagination;
      this.SortOrder = SortOrder;
      this.Search = Search;
      this.StoreCategoryID = StoreCategoryID;
      this.FilterList = FilterList;
      this.Execute();
      return this.ApiResponse.InventoryCountLastCalculatedDate;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerInventoryRequestType ApiRequest
    {
      get => (GetSellingManagerInventoryRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerInventoryResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerInventoryResponseType ApiResponse
    {
      get => (GetSellingManagerInventoryResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.Sort" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductSortCodeType" />.
    /// </summary>
    public SellingManagerProductSortCodeType Sort
    {
      get => this.ApiRequest.Sort;
      set => this.ApiRequest.Sort = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.SortOrder" /> of type <see cref="T:eBay.Service.Core.Soap.SortOrderCodeType" />.
    /// </summary>
    public SortOrderCodeType SortOrder
    {
      get => this.ApiRequest.SortOrder;
      set => this.ApiRequest.SortOrder = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.Search" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerSearchType" />.
    /// </summary>
    public SellingManagerSearchType Search
    {
      get => this.ApiRequest.Search;
      set => this.ApiRequest.Search = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.StoreCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long StoreCategoryID
    {
      get => this.ApiRequest.StoreCategoryID;
      set => this.ApiRequest.StoreCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType.Filter" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerInventoryPropertyTypeCodeTypeCollection" />.
    /// </summary>
    public SellingManagerInventoryPropertyTypeCodeTypeCollection FilterList
    {
      get => this.ApiRequest.Filter;
      set => this.ApiRequest.Filter = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryResponseType.InventoryCountLastCalculatedDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime InventoryCountLastCalculatedDate
    {
      get => this.ApiResponse.InventoryCountLastCalculatedDate;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryResponseType.SellingManagerProduct" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductTypeCollection" />.
    /// </summary>
    public SellingManagerProductTypeCollection SellingManagerProductList
    {
      get => this.ApiResponse.SellingManagerProduct;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerInventoryResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;
  }
}
