// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetItemShippingCall
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
  public class GetItemShippingCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetItemShippingCall() => this.ApiRequest = new GetItemShippingRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetItemShippingCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetItemShippingRequestType();
      this.ApiContext = ApiContext;
    }

    public ShippingDetailsType GetItemShipping(
      string ItemID,
      int QuantitySold,
      string DestinationPostalCode,
      CountryCodeType DestinationCountryCode)
    {
      this.ItemID = ItemID;
      this.QuantitySold = QuantitySold;
      this.DestinationPostalCode = DestinationPostalCode;
      this.DestinationCountryCode = DestinationCountryCode;
      this.Execute();
      return this.ApiResponse.ShippingDetails;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public ShippingDetailsType GetItemShipping(string ItemID, string DestinationPostalCode)
    {
      this.ItemID = ItemID;
      this.DestinationPostalCode = DestinationPostalCode;
      this.Execute();
      return this.ShippingDetails;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public ShippingDetailsType GetItemShipping(
      string ItemID,
      string DestinationPostalCode,
      CountryCodeType DestinationCountryCode)
    {
      this.DestinationCountryCode = DestinationCountryCode;
      this.ItemID = ItemID;
      this.DestinationPostalCode = DestinationPostalCode;
      this.Execute();
      return this.ShippingDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetItemShippingRequestType" /> for this API call.
    /// </summary>
    public GetItemShippingRequestType ApiRequest
    {
      get => (GetItemShippingRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetItemShippingResponseType" /> for this API call.
    /// </summary>
    public GetItemShippingResponseType ApiResponse
    {
      get => (GetItemShippingResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemShippingRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemShippingRequestType.QuantitySold" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int QuantitySold
    {
      get => this.ApiRequest.QuantitySold;
      set => this.ApiRequest.QuantitySold = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemShippingRequestType.DestinationPostalCode" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DestinationPostalCode
    {
      get => this.ApiRequest.DestinationPostalCode;
      set => this.ApiRequest.DestinationPostalCode = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemShippingRequestType.DestinationCountryCode" /> of type <see cref="T:eBay.Service.Core.Soap.CountryCodeType" />.
    /// </summary>
    public CountryCodeType DestinationCountryCode
    {
      get => this.ApiRequest.DestinationCountryCode;
      set => this.ApiRequest.DestinationCountryCode = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemShippingResponseType.ShippingDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingDetailsType" />.
    /// </summary>
    public ShippingDetailsType ShippingDetails => this.ApiResponse.ShippingDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemShippingResponseType.PickUpInStoreDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PickupInStoreDetailsType" />.
    /// </summary>
    public PickupInStoreDetailsType PickUpInStoreDetails => this.ApiResponse.PickUpInStoreDetails;
  }
}
