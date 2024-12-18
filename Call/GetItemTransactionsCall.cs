﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetItemTransactionsCall
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
  public class GetItemTransactionsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetItemTransactionsCall() => this.ApiRequest = new GetItemTransactionsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetItemTransactionsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetItemTransactionsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This  call retrieves details on one or more order line items for a specified eBay listing. Auctions and single-quantity, fixed-price listings can only have one order line item, but a multiple-quantity and/or multiple-variation, fixed-priced listing can have numerous order line items.
    /// 
    /// To find one or more order line items for an eBay listing, an <b>ItemID</b> value can be passed in. If a user wanted to retrieve a specific order line item, an <b>ItemID</b> value and a an <b>TransactionID</b> value can be passed in, or an <b>OrderLineItemID</b> value can be passed in instead of an <b>ItemID</b>/<b>TransactionID</b> pair.
    /// 
    /// The <b>NumberOfDays</b> or the <b>ModTimeFrom</b> and <b>ModTimeTo</b> date range filters can be used to retrieve order line items generated (or last modified) within a specific range of time. The maximum date range that can be set is 30 days, and the <b>ModTimeFrom</b> date value cannot be set any further back than 90 days in the past. If no date range filters are used, all order line items (associated with the specified listing) generated (or last  modified) in the last 30 days are retrieved. Date ranges are generally only used for multiple-quantity or multiple-variation, fixed-price listings that can have multiple order line items.
    /// 
    /// There are also pagination filters available that allow the user to control how many and which order line items are returned on each page of a results set.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing. A listing can have multiple order line items, but only one <b>ItemID</b>. When you use <b>ItemID</b> alone, eBay returns all order line items that are associated with the <b>ItemID</b>. If you pair <b>ItemID</b> with a specific <b>TransactionID</b>, data on a specific order line item is returned. An <b>OrderLineItemID</b> value can be used instead of an <b>ItemID</b>/<b>TransactionID</b> pair to identify an order line item, and if an <b>OrderLineItemID</b> is specified in the request, any <b>ItemID</b>/<b>TransactionID</b> pair specified in the same request is ignored.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// <b>GetItemTransactions</b> doesn't support SKU as an input because this
    /// call requires an identifier that is unique across your active
    /// and ended listings. Even when <b>InventoryTrackingMethod</b> is set to
    /// <b>SKU</b> in a listing, the SKU is only unique across your active
    /// listings (not your ended listings). To retrieve order line items
    /// by SKU, use <b>GetSellerTransactions</b> or <b>GetOrderTransactions</b> instead.
    /// </span>
    /// </param>
    /// <param name="ModTimeFrom">
    /// The <b>ModTimeFrom</b> and <b>ModTimeTo</b> fields specify a date range for retrieving order line items associated with the specified <b>ItemID</b> value.  The <b>ModTimeFrom</b> field is the starting date range. All of the listing's order line items that were generated (or last modified)within this date range are returned in the output.  The maximum date range that may be specified is 30 days. This value cannot be set back more than 90 days in the past, as this call cannot retrieve sales older than 90 days old. The maximum date range that may be specified is 30 days. This field is not applicable (and is ignored) if the user is looking for a specific order line item by either using an <b>ItemID</b>/<b>TransactionID</b> pair, or an <b>OrderLineItemID</b> value.
    /// </param>
    /// <param name="ModTimeTo">
    /// The <b>ModTimeFrom</b> and <b>ModTimeTo</b> fields specify a date range for retrieving order line items associated with the specified <b>ItemID</b> value. The <b>ModTimeTo</b> field is the ending date range. All eBay order line items that were generated (or last modified) within this date range are returned in the output. The maximum date range that may be specified is 30 days. If the <b>ModTimeFrom</b> field is used and the <b>ModTimeTo</b> field is omitted, the <b>ModTimeTo</b> value defaults to the present time or to 30 days after the date specified with the <b>ModTimeFrom</b> value (if <b>ModTimeFrom</b> value is more than 30 days in the past). This field is not applicable (and is ignored) if the user is looking for a specific order line item by either using an <b>ItemID</b>/<b>TransactionID</b> pair, or an <b>OrderLineItemID</b> value.
    /// </param>
    /// <param name="TransactionID">
    /// Include a <b>TransactionID</b> field in the request if you want to retrieve the data for a specific order line item for the listing specified in the <b>ItemID</b> field. This field is really only applicable for a multiple-quantity or multiple-variation, fixed-price listing that may have multiple sales. An auction listing or a single-quantity, fixed-price listing will only result in one order line item, so this field is not needed in these two cases. If an <b>OrderLineItemID</b> value is used instead to identify an order line item, this field is ignored.
    /// 
    /// If this field is used, any specified date filter is ignored.
    /// </param>
    /// <param name="Pagination">
    /// This container controls how many order line items should be returned per page of data, as well as which page of data to return (if there are multiple pages of order line items).  Use the <b>EntriesPerPage</b> property to control the number of order line items to return per call and the <b>PageNumber</b> property to specify the specific page of data to return. If multiple pages of order line items are returned based on input criteria and <b>Pagination</b> properties, <b>GetItemTransactions</b> will need to be called multiple times (with the <b>PageNumber</b> value being increased by 1 each time) to scroll through all results.
    /// </param>
    /// <param name="IncludeFinalValueFee">
    /// This field is included and set to <code>true</code> if the user wants to view the Final Value Fee (FVF) for all order line items in the response. The Final Value Fee is returned in the <b>Transaction.FinalValueFee</b> field. The Final Value Fee is assessed right after the creation of an order line item.
    /// <br /><br />
    /// </param>
    /// <param name="IncludeContainingOrder">
    /// This field is included and set to <code>true</code> if the user wants to view order-level details, including the unique identifier of the order and the status of the order. The order-level details will be shown in the <b>ContainingOrder</b> container in the response.
    /// <br />
    /// </param>
    /// <param name="Platform">
    /// <span class="tablenote"><b>Note: </b> This field is should no longer be used, as its purpose in the past was to give the user the ability to retrieve only eBay marketplace order line items or only Half.com listings, and since the Half.com site no longer exists, this field is no longer relevant.
    /// </span>
    /// </param>
    /// <param name="NumberOfDays">
    /// This date range filter specifies the number of days (24-hour periods) in the past to search for order line items. All eBay order line items that were either created or modified within this period are returned in the response. If specified, <b>NumberOfDays</b> will override any date range specified with the <b>ModTimeFrom</b>/<b>ModTimeTo</b> date range filters. This field is not applicable if a specific order line item is specified either through an <b>ItemID</b><b>TransactionID</b> pair or an <b>OrderLineItemID</b> value.
    /// </param>
    /// <param name="IncludeVariations">
    /// If this field is included in the request and set to <code>true</code>, details on all variations defined in the specified multiple-variation listing are returned, including variations that have no sales. If this field is not included in the request or set to <code>false</code>, the variations with sales are still returned in separate <b>Transaction</b> nodes. This information is intended to help sellers to reconcile their local inventory with eBay's records, while processing order line items (without requiring a separate call to <b>GetItem</b>).
    /// </param>
    /// <param name="OrderLineItemID">
    /// A unique identifier for an eBay order line item. This identifier is created once there is a commitment to buy (bidder wins the auction, buyer clicks buy button, or buyer purchases item through <b>PlaceOffer</b> call). If you want to retrieve data on a
    /// specific order line item, you can use an <b>OrderLineItemID</b> value in the
    /// request instead of an <b>ItemID</b>/<b>TransactionID</b> pair. If an <b>OrderLineItemID</b> is
    /// provided, any specified date range filter is ignored.
    /// </param>
    public TransactionTypeCollection GetItemTransactions(
      string ItemID,
      DateTime ModTimeFrom,
      DateTime ModTimeTo,
      string TransactionID,
      PaginationType Pagination,
      bool IncludeFinalValueFee,
      bool IncludeContainingOrder,
      TransactionPlatformCodeType Platform,
      int NumberOfDays,
      bool IncludeVariations,
      string OrderLineItemID)
    {
      this.ItemID = ItemID;
      this.ModTimeFrom = ModTimeFrom;
      this.ModTimeTo = ModTimeTo;
      this.TransactionID = TransactionID;
      this.Pagination = Pagination;
      this.IncludeFinalValueFee = IncludeFinalValueFee;
      this.IncludeContainingOrder = IncludeContainingOrder;
      this.Platform = Platform;
      this.NumberOfDays = NumberOfDays;
      this.IncludeVariations = IncludeVariations;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
      return this.ApiResponse.TransactionArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public TransactionTypeCollection GetItemTransactions(string ItemID, TimeFilter ModTimeFilter)
    {
      this.ItemID = ItemID;
      this.ModTimeFilter = ModTimeFilter;
      this.Execute();
      return this.TransactionList;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public TransactionTypeCollection GetItemTransactions(
      string ItemID,
      DateTime TimeFrom,
      DateTime TimeTo)
    {
      this.ItemID = ItemID;
      this.ModTimeFilter = new TimeFilter(TimeFrom, TimeTo);
      this.Execute();
      return this.TransactionList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetItemTransactionsRequestType" /> for this API call.
    /// </summary>
    public GetItemTransactionsRequestType ApiRequest
    {
      get => (GetItemTransactionsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetItemTransactionsResponseType" /> for this API call.
    /// </summary>
    public GetItemTransactionsResponseType ApiResponse
    {
      get => (GetItemTransactionsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.ModTimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeFrom
    {
      get => this.ApiRequest.ModTimeFrom;
      set => this.ApiRequest.ModTimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.ModTimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeTo
    {
      get => this.ApiRequest.ModTimeTo;
      set => this.ApiRequest.ModTimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.IncludeFinalValueFee" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeFinalValueFee
    {
      get => this.ApiRequest.IncludeFinalValueFee;
      set => this.ApiRequest.IncludeFinalValueFee = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.IncludeContainingOrder" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeContainingOrder
    {
      get => this.ApiRequest.IncludeContainingOrder;
      set => this.ApiRequest.IncludeContainingOrder = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.Platform" /> of type <see cref="T:eBay.Service.Core.Soap.TransactionPlatformCodeType" />.
    /// </summary>
    public TransactionPlatformCodeType Platform
    {
      get => this.ApiRequest.Platform;
      set => this.ApiRequest.Platform = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.NumberOfDays" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int NumberOfDays
    {
      get => this.ApiRequest.NumberOfDays;
      set => this.ApiRequest.NumberOfDays = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.IncludeVariations" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeVariations
    {
      get => this.ApiRequest.IncludeVariations;
      set => this.ApiRequest.IncludeVariations = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.ModTimeFrom" /> and <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsRequestType.ModTimeTo" /> of type <see cref="P:eBay.Service.Call.GetItemTransactionsCall.ModTimeFilter" />.
    /// </summary>
    public TimeFilter ModTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.ModTimeFrom, this.ApiRequest.ModTimeTo);
      set
      {
        this.ApiRequest.ModTimeFrom = value.TimeFrom;
        this.ApiRequest.ModTimeTo = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.HasMoreTransactions" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreTransactions => this.ApiResponse.HasMoreTransactions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.TransactionsPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int TransactionsPerPage => this.ApiResponse.TransactionsPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.ReturnedTransactionCountActual" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ReturnedTransactionCountActual => this.ApiResponse.ReturnedTransactionCountActual;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item => this.ApiResponse.Item;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.TransactionArray" /> of type <see cref="T:eBay.Service.Core.Soap.TransactionTypeCollection" />.
    /// </summary>
    public TransactionTypeCollection TransactionList => this.ApiResponse.TransactionArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemTransactionsResponseType.PayPalPreferred" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool PayPalPreferred => this.ApiResponse.PayPalPreferred;
  }
}
