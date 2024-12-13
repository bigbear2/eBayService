// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddDisputeCall
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
  public class AddDisputeCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddDisputeCall() => this.ApiRequest = new AddDisputeRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddDisputeCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddDisputeRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to create an Unpaid Item case against a buyer, or to cancel a
    /// single line item order.
    /// 
    /// 
    /// Although the seller is eligible to open up an Unpaid Item case two days after the buyer purchases the item or wins the item through an auction, it is recommended that the seller contacts the buyer first to try and make it right before opening a case. The <a href="http://pages.ebay.com/help/sell/unpaid-items.html" target="_blank">Unpaid Items</a> help page talks more about how a seller should to handle an unpaid item.
    /// 
    /// 
    /// To cancel a multiple line item order programmatically, the seller would have to use the <a href="https://developer.ebay.com/Devzone/post-order/post-order_v2_cancellation__post.html" target="_blank">POST /post-order/v2/cancellation</a> call of the <b>Post-Order API</b>.
    /// </summary>
    /// <param name="DisputeExplanation">
    /// This enumerated value gives the explanation of why the seller opened a case (or why seller canceled a single line item order). Not all values contained in <b>DisputeExplanationCodeType</b> are allowed in the <b>AddDispute</b> call, and the values that are allowed must match the <b>DisputeReason</b> value.
    /// </param>
    /// <param name="DisputeReason">
    /// The enumeration value passed into this required field will depend on the action being taken. The seller will pass in <code>BuyerHasNotPaid</code> if the seller is creating an Unpaid Item case against the buyer, or
    /// <code>TransactionMutuallyCanceled</code> if the seller is cancelling a single line item order at the request of the buyer, or if the seller has ran out of stock on the item or otherwise cannot fulfill the order.
    /// </param>
    /// <param name="ItemID">
    /// Unique identifier of an eBay listing. To identify a specific order line item, either an <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> value must be passed in the request. So, unless <b>OrderLineItemID</b> is used, this field is required.
    /// 
    /// </param>
    /// <param name="TransactionID">
    /// The unique identifier of a buyer's purchase. A <b>TransactionID</b> is created by eBay once a buyer purchases the item through a fixed-priced listing or by using the Buy It Now feature in an auction listing, or when an auction listing ends with a winning bidder. To identify a specific order line item, either an <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> value must be passed in the request. So, unless <b>OrderLineItemID</b> is used, this field is required.
    /// 
    /// </param>
    /// <param name="OrderLineItemID">
    /// <b>OrderLineItemID</b> is a unique identifier of an order line item. To identify a specific order line item, either an <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> value must be passed in the request. So, unless <b>ItemID</b>/<b>TransactionID</b> pair is used, this field is required.
    /// 
    /// </param>
    public string AddDispute(
      DisputeExplanationCodeType DisputeExplanation,
      DisputeReasonCodeType DisputeReason,
      string ItemID,
      string TransactionID,
      string OrderLineItemID)
    {
      this.DisputeExplanation = DisputeExplanation;
      this.DisputeReason = DisputeReason;
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
      return this.ApiResponse.DisputeID;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public string AddDispute(
      string ItemID,
      string TransactionID,
      DisputeReasonCodeType DisputeReason,
      DisputeExplanationCodeType DisputeExplanation)
    {
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.DisputeReason = DisputeReason;
      this.DisputeExplanation = DisputeExplanation;
      this.Execute();
      return this.DisputeID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddDisputeRequestType" /> for this API call.
    /// </summary>
    public AddDisputeRequestType ApiRequest
    {
      get => (AddDisputeRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddDisputeResponseType" /> for this API call.
    /// </summary>
    public AddDisputeResponseType ApiResponse => (AddDisputeResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeRequestType.DisputeExplanation" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeExplanationCodeType" />.
    /// </summary>
    public DisputeExplanationCodeType DisputeExplanation
    {
      get => this.ApiRequest.DisputeExplanation;
      set => this.ApiRequest.DisputeExplanation = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeRequestType.DisputeReason" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeReasonCodeType" />.
    /// </summary>
    public DisputeReasonCodeType DisputeReason
    {
      get => this.ApiRequest.DisputeReason;
      set => this.ApiRequest.DisputeReason = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseType.DisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DisputeID => this.ApiResponse.DisputeID;
  }
}
