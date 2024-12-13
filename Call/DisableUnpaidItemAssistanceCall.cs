// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DisableUnpaidItemAssistanceCall
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
  public class DisableUnpaidItemAssistanceCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DisableUnpaidItemAssistanceCall()
    {
      this.ApiRequest = new DisableUnpaidItemAssistanceRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DisableUnpaidItemAssistanceCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DisableUnpaidItemAssistanceRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller who has opted into the automated Unpaid Item Assistant mechanism to disable the Unpaid Item Assistant at the order line item level. This call can be made whether or not a Unpaid Item case exists for the order line item. If an Unpaid Item case has already been created by the Unpaid Item Assistant, it is converted to a "manual" case for the seller to manage like any other manually-created case.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing. A listing can have multiple order line items, but only one <b>ItemID</b>. To identify a specific order line item for which to disable the Unpaid Item Assistant mechanism, either an <b>ItemID</b>/<b>TransactionID</b> pair, an <b>OrderLineItemID</b>, or a <b>DisputeID</b> (if an Unpaid Item case already exists) is required in the request.
    /// </param>
    /// <param name="TransactionID">
    /// The unique identifier of an order line item. An order line item is created once there is a commitment from a buyer to purchase an item. To identify a specific order line item for which to disable the Unpaid Item Assistant mechanism, either an <b>ItemID</b>/<b>TransactionID</b> pair, an <b>OrderLineItemID</b>, or a <b>DisputeID</b> (if an Unpaid Item case already exists) is required in the request.
    /// </param>
    /// <param name="DisputeID">
    /// A unique identifier for an Unpaid Item case that is filed against an order line item. If an <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> is used to identify an order line item, <b>DisputeID</b> cannot be used and will be ignored if it is included in the request.
    /// </param>
    /// <param name="OrderLineItemID">
    /// <b>OrderLineItemID</b> is a unique identifier for an eBay order line item. To identify a specific order line item for which to disable the Unpaid Item Assistant mechanism, either an <b>ItemID</b>/<b>TransactionID</b> pair, an <b>OrderLineItemID</b>, or a <b>DisputeID</b> is required in the request.
    /// </param>
    public void DisableUnpaidItemAssistance(
      string ItemID,
      string TransactionID,
      string DisputeID,
      string OrderLineItemID)
    {
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.DisputeID = DisputeID;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceRequestType" /> for this API call.
    /// </summary>
    public DisableUnpaidItemAssistanceRequestType ApiRequest
    {
      get => (DisableUnpaidItemAssistanceRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceResponseType" /> for this API call.
    /// </summary>
    public DisableUnpaidItemAssistanceResponseType ApiResponse
    {
      get => (DisableUnpaidItemAssistanceResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceRequestType.DisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DisputeID
    {
      get => this.ApiRequest.DisputeID;
      set => this.ApiRequest.DisputeID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DisableUnpaidItemAssistanceRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }
  }
}
