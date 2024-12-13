// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerSoldListingsCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetSellingManagerSoldListingsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerSoldListingsCall()
    {
      this.ApiRequest = new GetSellingManagerSoldListingsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerSoldListingsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerSoldListingsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Returns a Selling Manager user's sold listings.
    /// 
    /// This call is subject to change without notice; the deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="Search">
    /// This container is used if the seller would like to search for Selling Manager Sele Records based on certain identifiers like Saler Record ID, Item ID, listing title, buyer user ID, etc. The seller will specify one of the supported search types in <b>SellingManagerSearchTypeCodeType</b>, and then provides the value for that search type.
    /// </param>
    /// <param name="StoreCategoryID">
    /// This field is used if the seller would like to retrieve all Selling Manager Sale Records for products listed in a specific eBay Store Category.
    /// </param>
    /// <param name="FilterList">
    /// One or more <b>Filter</b> fields can be used to retrieve Selling Manager Sale Records for orders that are in a certain state. See <b>SellingManagerSoldListingsPropertyTypeCodeType</b> for the supported values.
    /// </param>
    /// <param name="Archived">
    /// This field is included and set to <code>true</code> if the seller would like to retrieve one or more archived orders between 90 and 120 days old.
    /// </param>
    /// <param name="Sort">
    /// This field is used if the seller would like to sort Selling Manager Sale Record results based on a specific aspect such as purchase date, checkout status, total price, etc. See <b>SellingManagerSoldListingsSortTypeCodeType</b> to read more about the available sorting options.
    /// </param>
    /// <param name="SortOrder">
    /// This field allows the seller to sort in ascending or descending order (based on the selected aspect in the <b>Sort</b> field).
    /// </param>
    /// <param name="Pagination">
    /// This container is used if the seller would like to control how many Sale Records are returned per page and which page to view.
    /// </param>
    /// <param name="SaleDateRange">
    /// This container allows the seller to retrieve orders that were purchased within a specified time range. A time range can be set up to 90 days in the past (or up to 120 days if the <b>Archived</b> field is included and set to <code>true</code>.
    /// </param>
    public SellingManagerSoldOrderTypeCollection GetSellingManagerSoldListings(
      SellingManagerSearchType Search,
      long StoreCategoryID,
      SellingManagerSoldListingsPropertyTypeCodeTypeCollection FilterList,
      bool Archived,
      SellingManagerSoldListingsSortTypeCodeType Sort,
      SortOrderCodeType SortOrder,
      PaginationType Pagination,
      TimeRangeType SaleDateRange)
    {
      this.Search = Search;
      this.StoreCategoryID = StoreCategoryID;
      this.FilterList = FilterList;
      this.Archived = Archived;
      this.Sort = Sort;
      this.SortOrder = SortOrder;
      this.Pagination = Pagination;
      this.SaleDateRange = SaleDateRange;
      this.Execute();
      return this.ApiResponse.SaleRecord;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerSoldListingsRequestType ApiRequest
    {
      get => (GetSellingManagerSoldListingsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerSoldListingsResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerSoldListingsResponseType ApiResponse
    {
      get => (GetSellingManagerSoldListingsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.Search" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerSearchType" />.
    /// </summary>
    public SellingManagerSearchType Search
    {
      get => this.ApiRequest.Search;
      set => this.ApiRequest.Search = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.StoreCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long StoreCategoryID
    {
      get => this.ApiRequest.StoreCategoryID;
      set => this.ApiRequest.StoreCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.Filter" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerSoldListingsPropertyTypeCodeTypeCollection" />.
    /// </summary>
    public SellingManagerSoldListingsPropertyTypeCodeTypeCollection FilterList
    {
      get => this.ApiRequest.Filter;
      set => this.ApiRequest.Filter = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.Archived" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool Archived
    {
      get => this.ApiRequest.Archived;
      set => this.ApiRequest.Archived = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.Sort" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerSoldListingsSortTypeCodeType" />.
    /// </summary>
    public SellingManagerSoldListingsSortTypeCodeType Sort
    {
      get => this.ApiRequest.Sort;
      set => this.ApiRequest.Sort = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.SortOrder" /> of type <see cref="T:eBay.Service.Core.Soap.SortOrderCodeType" />.
    /// </summary>
    public SortOrderCodeType SortOrder
    {
      get => this.ApiRequest.SortOrder;
      set => this.ApiRequest.SortOrder = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType.SaleDateRange" /> of type <see cref="T:eBay.Service.Core.Soap.TimeRangeType" />.
    /// </summary>
    public TimeRangeType SaleDateRange
    {
      get => this.ApiRequest.SaleDateRange;
      set => this.ApiRequest.SaleDateRange = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsResponseType.SaleRecord" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerSoldOrderTypeCollection" />.
    /// </summary>
    public SellingManagerSoldOrderTypeCollection SaleRecordList => this.ApiResponse.SaleRecord;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerSoldListingsResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;
  }
}
