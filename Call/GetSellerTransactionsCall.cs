// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellerTransactionsCall
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
  public class GetSellerTransactionsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellerTransactionsCall() => this.ApiRequest = new GetSellerTransactionsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellerTransactionsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellerTransactionsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves a seller's order line item information. To retrieve order line items for another seller, the <b>GetItemTransactions</b>) call should be used. This call cannot retrieve sales older than 90 days old.
    /// 
    /// If one or more <b>SKU</b> values or the date range filters (<b>ModTimeFrom</b>/<b>ModTimeTo</b> or <b>NumberOfDays</b>) are not used, the <b>GetItemTransactions</b>) call will retrieve order line items created (or modified) within the last 30 days.
    /// </summary>
    /// <param name="ModTimeFrom">
    /// The <b>ModTimeFrom</b> and <b>ModTimeTo</b> fields are used to specify a date range for retrieving order line items associated with the seller. The <b>ModTimeFrom</b> field is the starting date range. All of the seller's order line items that were created (or last modified) within this date range are returned in the output.  The maximum date range that may be specified is 30 days. This value cannot be set back more than 90 days in the past, as this call cannot retrieve sales older than 90 days. This field is not applicable if the <b>NumberOfDays</b> date filter is used.
    /// 
    /// If you don't specify a <b>ModTimeFrom</b>/<b>ModTimeTo</b> filter, the <b>NumberOfDays</b> time filter is used and it defaults to 30 (days).
    /// </param>
    /// <param name="ModTimeTo">
    /// The <b>ModTimeFrom</b> and <b>ModTimeTo</b> fields are used to specify a date range for retrieving order line items associated with the seller. The <b>ModTimeTo</b> field is the ending date range. All of the seller's order line items that were created (or last modified) within this date range are returned in the output. The maximum date range that may be specified is 30 days.
    /// <br /><br />
    /// If the <b>ModTimeFrom</b> field is
    /// used and the <b>ModTimeTo</b> field is omitted, the <b>ModTimeTo</b> value defaults to
    /// the present time or to 30 days past the <b>ModTimeFrom</b> value (if
    /// <b>ModTimeFrom</b> value is more than 30 days in the past). This field is not
    /// applicable if the <b>NumberOfDays</b> date filter is used.
    /// 
    /// If you don't specify a <b>ModTimeFrom</b>/<b>ModTimeTo</b> filter, the <b>NumberOfDays</b>
    /// time filter is used and it defaults to 30 (days).
    /// </param>
    /// <param name="Pagination">
    /// If many order line items are	available to retrieve, you may need to call <b>GetSellerTransactions</b> multiple times to retrieve all the data. Each result set is returned as a page of order line items. Use the <b>Pagination</b> filters to control the maximum number of order line items to retrieve per page (i.e., per call), and the page number to retrieve.
    /// </param>
    /// <param name="IncludeFinalValueFee">
    /// This field is included and set to <code>true</code> if the user wants to view the Final Value Fee (FVF) for all order line items in the response. The Final Value Fee is returned in the <b>Transaction.FinalValueFee</b> field. The Final Value Fee is assessed right after the creation of an order line item.
    /// <br />
    /// </param>
    /// <param name="IncludeContainingOrder">
    /// This field is included and set to <code>true</code> if the user wants to view order-level details, including the unique identifier of the order and the status of the order. The order-level details will be shown in the <b>ContainingOrder</b> container in the response.
    /// <br />
    /// </param>
    /// <param name="SKUArrayList">
    /// This container is used to search for order line items generated from one or more product SKU values. The response will only include order line items for the seller's product(s) that are represented by the specified SKU value(s).
    /// 
    /// If a user wants to retrieve order line items based on SKUs, the
    /// <b>InventoryTrackingMethod</b> must be set to <code>SKU</code>. The <b>InventoryTrackingMethod</b> value can be set when the seller lists the item through an <b>AddFixedPriceItem</b> call, or it can be set by including the <b>InventoryTrackingMethod</b> field in a <b>GetSellerTransactions</b> call and setting its value to <code>SKU</code>.
    /// 
    /// <span class="tablenote"><b>Note: </b> SKU values must be defined for products in listings for this container to be applicable.
    /// </span>
    /// </param>
    /// <param name="Platform">
    /// <span class="tablenote"><b>Note: </b> This field should no longer be used since its sole purpose was to allow the seller to filter between eBay orders and Half.com orders, and the Half.com site no longer exists.
    /// </span>
    /// </param>
    /// <param name="NumberOfDays">
    /// This field is used to specify how many days (24-hour periods) back in the past you wish to retrieve order line items. All order line items created (or last modified) within this period are retrieved. This value can be set between 1 (day) and 30 (days), and defaults to 30 (days) if omitted from the call.
    /// <br /><br />
    /// If the <b>NumberOfDays</b> filter is used, <b>ModTimeFrom</b> and <b>ModTimeTo</b> date range filters are ignored (if included in the same request).
    /// <br />
    /// </param>
    /// <param name="InventoryTrackingMethod">
    /// This filter is used if the seller wishes to set/change the inventory tracking method. When creating a listing with the <b>AddFixedPriceItem</b> call (or relisting with <b>RelistFixedPriceItem</b> call), sellers can decide whether to track their inventory by Item ID (generated by eBay at listing time) or by seller-defined SKU value.
    /// 
    /// This field is needed (and its value must be set to <code>SKU</code>) if the seller wishes to retrieve order line items based on specified SKU values (specified through <b>SKUArray</b> container) and the current inventory tracking method is set to Item ID.
    /// 
    /// A seller can use a <b>GetItem</b> call for a listing (and look for the <b>Item.InventoryTrackingMethod</b> in the response) to see which inventory tracking method is used for the listing/product.
    /// </param>
    /// <param name="IncludeCodiceFiscale">
    /// If this field is included in the call request and set to <code>true</code>, taxpayer identification information for the buyer is returned under the <b>BuyerTaxIdentifier</b> container.
    /// 
    /// Codice Fiscale is only applicable to buyers on the Italy and Spain sites. It is required that buyers on the Italy site provide their Codice Fiscale ID before buying an item, and sellers on the Spain site have the option of requiring buyers on the Spain site to provide their taxpayer ID.
    /// </param>
    public TransactionTypeCollection GetSellerTransactions(
      DateTime ModTimeFrom,
      DateTime ModTimeTo,
      PaginationType Pagination,
      bool IncludeFinalValueFee,
      bool IncludeContainingOrder,
      StringCollection SKUArrayList,
      TransactionPlatformCodeType Platform,
      int NumberOfDays,
      InventoryTrackingMethodCodeType InventoryTrackingMethod,
      bool IncludeCodiceFiscale)
    {
      this.ModTimeFrom = ModTimeFrom;
      this.ModTimeTo = ModTimeTo;
      this.Pagination = Pagination;
      this.IncludeFinalValueFee = IncludeFinalValueFee;
      this.IncludeContainingOrder = IncludeContainingOrder;
      this.SKUArrayList = SKUArrayList;
      this.Platform = Platform;
      this.NumberOfDays = NumberOfDays;
      this.InventoryTrackingMethod = InventoryTrackingMethod;
      this.IncludeCodiceFiscale = IncludeCodiceFiscale;
      this.Execute();
      return this.ApiResponse.TransactionArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public TransactionTypeCollection GetSellerTransactions(TimeFilter ModTimeFilter)
    {
      this.ModTimeFilter = ModTimeFilter;
      this.Execute();
      return this.TransactionList;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public TransactionTypeCollection GetSellerTransactions(DateTime TimeFrom, DateTime TimeTo)
    {
      this.ModTimeFilter = new TimeFilter(TimeFrom, TimeTo);
      this.Execute();
      return this.TransactionList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellerTransactionsRequestType" /> for this API call.
    /// </summary>
    public GetSellerTransactionsRequestType ApiRequest
    {
      get => (GetSellerTransactionsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellerTransactionsResponseType" /> for this API call.
    /// </summary>
    public GetSellerTransactionsResponseType ApiResponse
    {
      get => (GetSellerTransactionsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.ModTimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeFrom
    {
      get => this.ApiRequest.ModTimeFrom;
      set => this.ApiRequest.ModTimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.ModTimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeTo
    {
      get => this.ApiRequest.ModTimeTo;
      set => this.ApiRequest.ModTimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.IncludeFinalValueFee" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeFinalValueFee
    {
      get => this.ApiRequest.IncludeFinalValueFee;
      set => this.ApiRequest.IncludeFinalValueFee = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.IncludeContainingOrder" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeContainingOrder
    {
      get => this.ApiRequest.IncludeContainingOrder;
      set => this.ApiRequest.IncludeContainingOrder = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.SKUArray" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection SKUArrayList
    {
      get => this.ApiRequest.SKUArray;
      set => this.ApiRequest.SKUArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.Platform" /> of type <see cref="T:eBay.Service.Core.Soap.TransactionPlatformCodeType" />.
    /// </summary>
    public TransactionPlatformCodeType Platform
    {
      get => this.ApiRequest.Platform;
      set => this.ApiRequest.Platform = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.NumberOfDays" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int NumberOfDays
    {
      get => this.ApiRequest.NumberOfDays;
      set => this.ApiRequest.NumberOfDays = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.InventoryTrackingMethod" /> of type <see cref="T:eBay.Service.Core.Soap.InventoryTrackingMethodCodeType" />.
    /// </summary>
    public InventoryTrackingMethodCodeType InventoryTrackingMethod
    {
      get => this.ApiRequest.InventoryTrackingMethod;
      set => this.ApiRequest.InventoryTrackingMethod = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.IncludeCodiceFiscale" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeCodiceFiscale
    {
      get => this.ApiRequest.IncludeCodiceFiscale;
      set => this.ApiRequest.IncludeCodiceFiscale = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.ModTimeFrom" /> and <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsRequestType.ModTimeTo" /> of type <see cref="T:eBay.Service.Core.Soap.TimeFilter" />.
    /// </summary>
    public TimeFilter ModTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.ModTimeFrom, this.ApiRequest.ModTimeTo);
      set
      {
        if (value.TimeFrom > DateTime.MinValue)
          this.ApiRequest.ModTimeFrom = value.TimeFrom;
        if (!(value.TimeTo > DateTime.MinValue))
          return;
        this.ApiRequest.ModTimeTo = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.HasMoreTransactions" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreTransactions => this.ApiResponse.HasMoreTransactions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.TransactionsPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int TransactionsPerPage => this.ApiResponse.TransactionsPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.ReturnedTransactionCountActual" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ReturnedTransactionCountActual => this.ApiResponse.ReturnedTransactionCountActual;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.Seller" /> of type <see cref="T:eBay.Service.Core.Soap.UserType" />.
    /// </summary>
    public UserType Seller => this.ApiResponse.Seller;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.TransactionArray" /> of type <see cref="T:eBay.Service.Core.Soap.TransactionTypeCollection" />.
    /// </summary>
    public TransactionTypeCollection TransactionList => this.ApiResponse.TransactionArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerTransactionsResponseType.PayPalPreferred" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool PayPalPreferred => this.ApiResponse.PayPalPreferred;
  }
}
