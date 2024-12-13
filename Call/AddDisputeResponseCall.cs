// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddDisputeResponseCall
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
  public class AddDisputeResponseCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddDisputeResponseCall() => this.ApiRequest = new AddDisputeResponseRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddDisputeResponseCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddDisputeResponseRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call enables the seller to respond to an Item Not Received (INR) dispute opened by a buyer through PayPal's Purchase Protection program, or to update an Unpaid Item case. To respond to a case opened by the buyer through eBay's Resolution Center, the seller should use the <a href="http://developer.ebay.com/Devzone/post-order/index.html" target="_blank">Case Management calls</a> of the <b>Post-Order API</b>, the <a href="http://developer.ebay.com/Devzone/resolution-case-management/CallRef/index.html" target="_blank">Resolution Case Management API</a>,  or manage the case manually through the eBay Resolution Center.
    /// </summary>
    /// <param name="DisputeID">
    /// The unique identifier of the eBay Unpaid Item case or PayPal INR dispute. This identifier is created by eBay or PayPal upon case/dispute creation.
    /// </param>
    /// <param name="MessageText">
    /// The text of a comment or response being posted to the case/dispute. Required when <b>DisputeActivity</b> is <b>SellerAddInformation</b>, <b>SellerComment</b>, or <b>SellerPaymentNotReceived</b>. Otherwise, this field is  optional.
    /// </param>
    /// <param name="DisputeActivity">
    /// The type of activity the seller plans to take on the case/dispute. The allowed value is determined by the current state of the case/dispute and whether the seller is updating an Unpaid Item case or responding to a PayPal INR dispute.
    /// </param>
    /// <param name="ShippingCarrierUsed">
    /// The shipping carrier used to ship the item in dispute. This field is not case sensitive in the <strong>AddDisputeResponse</strong> request. Non-alphanumeric characters are not allowed. This field (along with <b>ShipmentTrackNumber</b>) is required if the value of <b>DisputeActivity</b> is set to <code>SellerShippedItem</code>.
    /// </param>
    /// <param name="ShipmentTrackNumber">
    /// The tracking number associated with one package of a shipment. The seller is responsible for the accuracy of the shipment tracking number, as eBay only verifies that the tracking number is consistent with the numbering scheme used by the specified shipping carrier, but cannot verify the accuracy of the tracking number. This field (along with <b>ShippingCarrierUsed</b>) is required if the value of <b>DisputeActivity</b> is set to <code>SellerShippedItem</code>.
    /// </param>
    /// <param name="ShippingTime">
    /// This timestamp indicates the date and time when the item under dispute was
    /// shipped. This field is required if the value of <b>DisputeActivity</b> is set to <code>SellerShippedItem</code>.
    /// </param>
    public void AddDisputeResponse(
      string DisputeID,
      string MessageText,
      DisputeActivityCodeType DisputeActivity,
      string ShippingCarrierUsed,
      string ShipmentTrackNumber,
      DateTime ShippingTime)
    {
      this.DisputeID = DisputeID;
      this.MessageText = MessageText;
      this.DisputeActivity = DisputeActivity;
      this.ShippingCarrierUsed = ShippingCarrierUsed;
      this.ShipmentTrackNumber = ShipmentTrackNumber;
      this.ShippingTime = ShippingTime;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void AddDisputeResponse(
      string DisputeID,
      string MessageText,
      DisputeActivityCodeType DisputeActivity)
    {
      this.DisputeID = DisputeID;
      this.MessageText = MessageText;
      this.DisputeActivity = DisputeActivity;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddDisputeResponseRequestType" /> for this API call.
    /// </summary>
    public AddDisputeResponseRequestType ApiRequest
    {
      get => (AddDisputeResponseRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddDisputeResponseResponseType" /> for this API call.
    /// </summary>
    public AddDisputeResponseResponseType ApiResponse
    {
      get => (AddDisputeResponseResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.DisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DisputeID
    {
      get => this.ApiRequest.DisputeID;
      set => this.ApiRequest.DisputeID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.MessageText" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string MessageText
    {
      get => this.ApiRequest.MessageText;
      set => this.ApiRequest.MessageText = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.DisputeActivity" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeActivityCodeType" />.
    /// </summary>
    public DisputeActivityCodeType DisputeActivity
    {
      get => this.ApiRequest.DisputeActivity;
      set => this.ApiRequest.DisputeActivity = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.ShippingCarrierUsed" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ShippingCarrierUsed
    {
      get => this.ApiRequest.ShippingCarrierUsed;
      set => this.ApiRequest.ShippingCarrierUsed = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.ShipmentTrackNumber" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ShipmentTrackNumber
    {
      get => this.ApiRequest.ShipmentTrackNumber;
      set => this.ApiRequest.ShipmentTrackNumber = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddDisputeResponseRequestType.ShippingTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ShippingTime
    {
      get => this.ApiRequest.ShippingTime;
      set => this.ApiRequest.ShippingTime = value;
    }
  }
}
