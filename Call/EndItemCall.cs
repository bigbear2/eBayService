// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.EndItemCall
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
  public class EndItemCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public EndItemCall() => this.ApiRequest = new EndItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public EndItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new EndItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Ends the specified item listing before the date and time at which it would normally end per the listing duration.
    /// </summary>
    /// <param name="ItemID">
    /// Unique item ID that identifies the listing that you want to end.
    /// </param>
    /// <param name="EndingReason">
    /// The seller's reason for ending the listing early is input into this required field. The seller is not allowed to use the <code>ProductDeleted</code> value, as this ending reason can only be used internally by eBay to administratively end a listing due to the associated Catalog product being removed from the eBay Catalog.
    /// </param>
    /// <param name="SellerInventoryID">
    /// This field was previously only used to identify and end Half.com listings, and since the Half.com site has been shut down, this element is no longer applicable.
    /// </param>
    public DateTime EndItem(
      string ItemID,
      EndReasonCodeType EndingReason,
      string SellerInventoryID)
    {
      this.ItemID = ItemID;
      this.EndingReason = EndingReason;
      this.SellerInventoryID = SellerInventoryID;
      this.Execute();
      return this.ApiResponse.EndTime;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void EndItem(string ItemID, EndReasonCodeType EndingReason)
    {
      this.ItemID = ItemID;
      this.EndingReason = EndingReason;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.EndItemRequestType" /> for this API call.
    /// </summary>
    public EndItemRequestType ApiRequest
    {
      get => (EndItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.EndItemResponseType" /> for this API call.
    /// </summary>
    public EndItemResponseType ApiResponse => (EndItemResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndItemRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndItemRequestType.EndingReason" /> of type <see cref="T:eBay.Service.Core.Soap.EndReasonCodeType" />.
    /// </summary>
    public EndReasonCodeType EndingReason
    {
      get => this.ApiRequest.EndingReason;
      set => this.ApiRequest.EndingReason = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndItemRequestType.SellerInventoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SellerInventoryID
    {
      get => this.ApiRequest.SellerInventoryID;
      set => this.ApiRequest.SellerInventoryID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.EndItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;
  }
}
