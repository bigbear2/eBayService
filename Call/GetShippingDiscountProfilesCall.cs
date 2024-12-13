// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetShippingDiscountProfilesCall
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
  public class GetShippingDiscountProfilesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetShippingDiscountProfilesCall()
    {
      this.ApiRequest = new GetShippingDiscountProfilesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetShippingDiscountProfilesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetShippingDiscountProfilesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call retrieves all shipping discount profiles currently defined by the user, along with other Combined Invoice-related details such as packaging and handling costs.
    /// </summary>
    public CurrencyCodeType GetShippingDiscountProfiles()
    {
      this.Execute();
      return this.ApiResponse.CurrencyID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetShippingDiscountProfilesRequestType" /> for this API call.
    /// </summary>
    public GetShippingDiscountProfilesRequestType ApiRequest
    {
      get => (GetShippingDiscountProfilesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType" /> for this API call.
    /// </summary>
    public GetShippingDiscountProfilesResponseType ApiResponse
    {
      get => (GetShippingDiscountProfilesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.CurrencyID" /> of type <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.
    /// </summary>
    public CurrencyCodeType CurrencyID => this.ApiResponse.CurrencyID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.FlatShippingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.FlatShippingDiscountType" />.
    /// </summary>
    public FlatShippingDiscountType FlatShippingDiscount => this.ApiResponse.FlatShippingDiscount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.CalculatedShippingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.CalculatedShippingDiscountType" />.
    /// </summary>
    public CalculatedShippingDiscountType CalculatedShippingDiscount
    {
      get => this.ApiResponse.CalculatedShippingDiscount;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.PromotionalShippingDiscount" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool PromotionalShippingDiscount => this.ApiResponse.PromotionalShippingDiscount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.CalculatedHandlingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.CalculatedHandlingDiscountType" />.
    /// </summary>
    public CalculatedHandlingDiscountType CalculatedHandlingDiscount
    {
      get => this.ApiResponse.CalculatedHandlingDiscount;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.PromotionalShippingDiscountDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalShippingDiscountDetailsType" />.
    /// </summary>
    public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
    {
      get => this.ApiResponse.PromotionalShippingDiscountDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.ShippingInsurance" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingInsuranceType" />.
    /// </summary>
    public ShippingInsuranceType ShippingInsurance => this.ApiResponse.ShippingInsurance;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.InternationalShippingInsurance" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingInsuranceType" />.
    /// </summary>
    public ShippingInsuranceType InternationalShippingInsurance
    {
      get => this.ApiResponse.InternationalShippingInsurance;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType.CombinedDuration" /> of type <see cref="T:eBay.Service.Core.Soap.CombinedPaymentPeriodCodeType" />.
    /// </summary>
    public CombinedPaymentPeriodCodeType CombinedDuration => this.ApiResponse.CombinedDuration;
  }
}
