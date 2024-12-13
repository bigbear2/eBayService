// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetOrderTransactionsCall
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
  public class GetOrderTransactionsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetOrderTransactionsCall() => this.ApiRequest = new GetOrderTransactionsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetOrderTransactionsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetOrderTransactionsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type for the <b>GetOrderTransactions</b> call. This call retrieves detailed information about one or more orders or order line items created (or modified) in the last 90 days.
    /// 
    /// Unlike <b>GetOrders</b>, which can be used to retrieve specific orders, or orders created (or modified) within a specific time period, the <b>GetOrderTransactions</b> call only supports the retrieval of specific orders and/or order line items.
    /// </summary>
    /// <param name="ItemTransactionIDArrayList">
    /// This container is used if the seller wants to retrieve for one or more order line items. An <b>ItemTransactionID</b> container is required for each order line item that is to be retrieved.  An order line item can be identified with an <b>ItemID</b>/<b>TransactionID</b> pair, with an <b>OrderLineItemID</b> value, or with a <b>SKU</b> value (if a SKU is defined for the order line item).
    /// </param>
    /// <param name="OrderIDArrayList">
    /// This container is used if the seller wants to search for one or more orders. An <b>OrderID</b> field is required for each order that is to be retrieved.  Up to 20 <b>OrderID</b> fields can be used.
    /// 
    /// <span class="tablenote"><b>Note: </b> As of June 2019, eBay has changed the format of order identifier values. The new format is a non-parsable string, globally unique across all eBay marketplaces, and consistent for both single line item and multiple line item orders. Unlike in the past, instead of just being known and exposed to the seller, these unique order identifiers will also be known and used/referenced by the buyer and eBay customer support.
    /// 
    /// For developers and sellers who are already integrated with the Trading API's order management calls, this change shouldn't impact your integration unless you parse the existing order identifiers (e.g., <b>OrderID</b> or <b>OrderLineItemID</b>), or otherwise infer meaning from the format (e.g., differentiating between a single line item order versus a multiple line item order). Because we realize that some integrations may have logic that is dependent upon the old identifier format, eBay is rolling out this Trading API change with version control to support a transition period of approximately 9 months before applications must switch to the new format completely.
    /// 
    /// During the transition period, for developers/sellers using a Trading WSDL older than Version 1113, they can use the <b>X-EBAY-API-COMPATIBILITY-LEVEL</b> HTTP header in API calls to control whether the new or old <b>OrderID</b> format is returned in call response payloads. To get the new <b>OrderID</b> format, the value of the <b>X-EBAY-API-COMPATIBILITY-LEVEL</b> HTTP header must be set to <code>1113</code>. During the transition period and even after, the new and old <b>OrderID</b> formats will still be supported/accepted in all Trading API call request payloads. After the transition period (which will be announced), only the new <b>OrderID</b> format will be returned in all Trading API call response payloads, regardless of the Trading WSDL version used or specified compatibility level.
    /// </span>
    /// 
    /// <span class="tablenote"><b>Note: </b> For sellers integrated with the new order ID format, please note that the identifier for an order will change as it goes from unpaid to paid status. Sellers can check to see if an order has been paid by looking for a value of 'Complete' in the <b>CheckoutStatus.Status</b> field in the response of <b>GetOrders</b> or <b>GetOrderTransactions</b> call, or in the <b>Status.CompleteStatus</b> field in the response of <b>GetItemTransactions</b> or <b>GetSellerTransactions</b> call. Sellers should  not fulfill orders until buyer has made payment. When using a <b>GetOrders</b> or <b>GetOrderTransactions</b> call to retrieve specific order(s), either of these order IDs (paid or unpaid status) can be used to retrieve an order.
    /// </span>
    /// </param>
    /// <param name="Platform">
    /// <span class="tablenote"><b>Note: </b> This field should no longer be used since its sole purpose was to allow the seller to filter between eBay orders and Half.com orders, and the Half.com site no longer exists.
    /// </span>
    /// </param>
    /// <param name="IncludeFinalValueFees">
    /// This field is included and set to <code>true</code> if the user wants to view the Final Value Fee (FVF) for all order line items in the response. The Final Value Fee is returned in the <b>Transaction.FinalValueFee</b> field. The Final Value Fee is assessed right after the creation of an order line item.
    /// <br />
    /// </param>
    public OrderTypeCollection GetOrderTransactions(
      ItemTransactionIDTypeCollection ItemTransactionIDArrayList,
      StringCollection OrderIDArrayList,
      TransactionPlatformCodeType Platform,
      bool IncludeFinalValueFees)
    {
      this.ItemTransactionIDArrayList = ItemTransactionIDArrayList;
      this.OrderIDArrayList = OrderIDArrayList;
      this.Platform = Platform;
      this.IncludeFinalValueFees = IncludeFinalValueFees;
      this.Execute();
      return this.ApiResponse.OrderArray;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetOrderTransactionsRequestType" /> for this API call.
    /// </summary>
    public GetOrderTransactionsRequestType ApiRequest
    {
      get => (GetOrderTransactionsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetOrderTransactionsResponseType" /> for this API call.
    /// </summary>
    public GetOrderTransactionsResponseType ApiResponse
    {
      get => (GetOrderTransactionsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetOrderTransactionsRequestType.ItemTransactionIDArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemTransactionIDTypeCollection" />.
    /// </summary>
    public ItemTransactionIDTypeCollection ItemTransactionIDArrayList
    {
      get => this.ApiRequest.ItemTransactionIDArray;
      set => this.ApiRequest.ItemTransactionIDArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetOrderTransactionsRequestType.OrderIDArray" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection OrderIDArrayList
    {
      get => this.ApiRequest.OrderIDArray;
      set => this.ApiRequest.OrderIDArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetOrderTransactionsRequestType.Platform" /> of type <see cref="T:eBay.Service.Core.Soap.TransactionPlatformCodeType" />.
    /// </summary>
    public TransactionPlatformCodeType Platform
    {
      get => this.ApiRequest.Platform;
      set => this.ApiRequest.Platform = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetOrderTransactionsRequestType.IncludeFinalValueFees" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeFinalValueFees
    {
      get => this.ApiRequest.IncludeFinalValueFees;
      set => this.ApiRequest.IncludeFinalValueFees = value;
    }

    /// <summary>
    /// Retrieves information about one or more orders or one or more transactions
    /// (or both), thus displacing the need to call GetOrders and GetItemTransactions
    /// separately.
    /// </summary>
    /// <param name="ItemTransactionIDArrayList">
    /// An array of ItemTransactionIDs.
    /// </param>
    public OrderTypeCollection GetOrderTransactions(
      ItemTransactionIDTypeCollection ItemTransactionIDArrayList)
    {
      this.ItemTransactionIDArrayList = ItemTransactionIDArrayList;
      this.OrderIDArrayList = (StringCollection) null;
      this.Execute();
      return this.ApiResponse.OrderArray;
    }

    /// <summary>
    /// Retrieves information about one or more orders or one or more transactions
    /// (or both), thus displacing the need to call GetOrders and GetItemTransactions
    /// separately.
    /// </summary>
    /// <param name="OrderIDArrayList">An array of OrderIDs.</param>
    public OrderTypeCollection GetOrderTransactions(StringCollection OrderIDArrayList)
    {
      this.ItemTransactionIDArrayList = (ItemTransactionIDTypeCollection) null;
      this.OrderIDArrayList = OrderIDArrayList;
      this.Execute();
      return this.ApiResponse.OrderArray;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetOrderTransactionsResponseType.OrderArray" /> of type <see cref="T:eBay.Service.Core.Soap.OrderTypeCollection" />.
    /// </summary>
    public OrderTypeCollection OrderList => this.ApiResponse.OrderArray;
  }
}
