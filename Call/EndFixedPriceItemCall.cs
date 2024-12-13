// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.EndFixedPriceItemCall
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
  public class EndFixedPriceItemCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public EndFixedPriceItemCall() => this.ApiRequest = new EndFixedPriceItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public EndFixedPriceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new EndFixedPriceItemRequestType();
      this.ApiContext = ApiContext;
    }

    public DateTime EndFixedPriceItem(string ItemID, EndReasonCodeType EndingReason, string SKU)
    {
      this.ItemID = ItemID;
      this.EndingReason = EndingReason;
      this.SKU = SKU;
      this.Execute();
      return this.ApiResponse.EndTime;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.EndFixedPriceItemRequestType" /> for this API call.
    /// </summary>
    public EndFixedPriceItemRequestType ApiRequest
    {
      get => (EndFixedPriceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.EndFixedPriceItemResponseType" /> for this API call.
    /// </summary>
    public EndFixedPriceItemResponseType ApiResponse
    {
      get => (EndFixedPriceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndFixedPriceItemRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndFixedPriceItemRequestType.EndingReason" /> of type <see cref="T:eBay.Service.Core.Soap.EndReasonCodeType" />.
    /// </summary>
    public EndReasonCodeType EndingReason
    {
      get => this.ApiRequest.EndingReason;
      set => this.ApiRequest.EndingReason = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndFixedPriceItemRequestType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKU
    {
      get => this.ApiRequest.SKU;
      set => this.ApiRequest.SKU = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.EndFixedPriceItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.EndFixedPriceItemResponseType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKUReturn => this.ApiResponse.SKU;
  }
}
