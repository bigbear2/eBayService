// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GeteBayDetailsCall
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
  public class GeteBayDetailsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GeteBayDetailsCall() => this.ApiRequest = new GeteBayDetailsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GeteBayDetailsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GeteBayDetailsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GeteBayDetails</b> call. This call retrieves the latest eBay feature-related metadata values that are supported when listing items. This metadata includes country codes, currency codes, Item Specifics thresholds, supported Return Policy values, available shipping carriers and shipping service options, and more. This call may be used to keep metadata up-to-date in your applications.
    /// 
    /// In some cases, the data returned in the response will vary according to the eBay site that you use for the request.
    /// </summary>
    /// <param name="DetailNameList">
    /// One or more <b>DetailName</b> fields may be used to control the the type of metadata that is returned in the response. If no <b>DetailName</b> fields are used, all metadata will be returned in the response. It is a good idea to familiarize yourself with the metadata that can be returned with <b>GeteBayDetails</b> by reading through the enumeration values in <a href="types/DetailNameCodeType.html">DetailNameCodeType</a>.
    /// </param>
    public void GeteBayDetails(DetailNameCodeTypeCollection DetailNameList)
    {
      this.DetailNameList = DetailNameList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GeteBayDetailsRequestType" /> for this API call.
    /// </summary>
    public GeteBayDetailsRequestType ApiRequest
    {
      get => (GeteBayDetailsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GeteBayDetailsResponseType" /> for this API call.
    /// </summary>
    public GeteBayDetailsResponseType ApiResponse
    {
      get => (GeteBayDetailsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsRequestType.DetailName" /> of type <see cref="T:eBay.Service.Core.Soap.DetailNameCodeTypeCollection" />.
    /// </summary>
    public DetailNameCodeTypeCollection DetailNameList
    {
      get => this.ApiRequest.DetailName;
      set => this.ApiRequest.DetailName = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.CountryDetails" /> of type <see cref="T:eBay.Service.Core.Soap.CountryDetailsTypeCollection" />.
    /// </summary>
    public CountryDetailsTypeCollection CountryDetailList => this.ApiResponse.CountryDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.CurrencyDetails" /> of type <see cref="T:eBay.Service.Core.Soap.CurrencyDetailsTypeCollection" />.
    /// </summary>
    public CurrencyDetailsTypeCollection CurrencyDetailList => this.ApiResponse.CurrencyDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.DispatchTimeMaxDetails" /> of type <see cref="T:eBay.Service.Core.Soap.DispatchTimeMaxDetailsTypeCollection" />.
    /// </summary>
    public DispatchTimeMaxDetailsTypeCollection DispatchTimeMaxDetailList
    {
      get => this.ApiResponse.DispatchTimeMaxDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.PaymentOptionDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PaymentOptionDetailsTypeCollection" />.
    /// </summary>
    public PaymentOptionDetailsTypeCollection PaymentOptionDetailList
    {
      get => this.ApiResponse.PaymentOptionDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.RegionDetails" /> of type <see cref="T:eBay.Service.Core.Soap.RegionDetailsTypeCollection" />.
    /// </summary>
    public RegionDetailsTypeCollection RegionDetailList => this.ApiResponse.RegionDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ShippingLocationDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingLocationDetailsTypeCollection" />.
    /// </summary>
    public ShippingLocationDetailsTypeCollection ShippingLocationDetailList
    {
      get => this.ApiResponse.ShippingLocationDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ShippingServiceDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingServiceDetailsTypeCollection" />.
    /// </summary>
    public ShippingServiceDetailsTypeCollection ShippingServiceDetailList
    {
      get => this.ApiResponse.ShippingServiceDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.SiteDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SiteDetailsTypeCollection" />.
    /// </summary>
    public SiteDetailsTypeCollection SiteDetailList => this.ApiResponse.SiteDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.TaxJurisdiction" /> of type <see cref="T:eBay.Service.Core.Soap.TaxJurisdictionTypeCollection" />.
    /// </summary>
    public TaxJurisdictionTypeCollection TaxJurisdictionList => this.ApiResponse.TaxJurisdiction;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.URLDetails" /> of type <see cref="T:eBay.Service.Core.Soap.URLDetailsTypeCollection" />.
    /// </summary>
    public URLDetailsTypeCollection URLDetailList => this.ApiResponse.URLDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.TimeZoneDetails" /> of type <see cref="T:eBay.Service.Core.Soap.TimeZoneDetailsTypeCollection" />.
    /// </summary>
    public TimeZoneDetailsTypeCollection TimeZoneDetailList => this.ApiResponse.TimeZoneDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ItemSpecificDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ItemSpecificDetailsTypeCollection" />.
    /// </summary>
    public ItemSpecificDetailsTypeCollection ItemSpecificDetailList
    {
      get => this.ApiResponse.ItemSpecificDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.UnitOfMeasurementDetails" /> of type <see cref="T:eBay.Service.Core.Soap.UnitOfMeasurementDetailsTypeCollection" />.
    /// </summary>
    public UnitOfMeasurementDetailsTypeCollection UnitOfMeasurementDetailList
    {
      get => this.ApiResponse.UnitOfMeasurementDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.RegionOfOriginDetails" /> of type <see cref="T:eBay.Service.Core.Soap.RegionOfOriginDetailsTypeCollection" />.
    /// </summary>
    public RegionOfOriginDetailsTypeCollection RegionOfOriginDetailList
    {
      get => this.ApiResponse.RegionOfOriginDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ShippingPackageDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingPackageDetailsTypeCollection" />.
    /// </summary>
    public ShippingPackageDetailsTypeCollection ShippingPackageDetailList
    {
      get => this.ApiResponse.ShippingPackageDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ShippingCarrierDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingCarrierDetailsTypeCollection" />.
    /// </summary>
    public ShippingCarrierDetailsTypeCollection ShippingCarrierDetailList
    {
      get => this.ApiResponse.ShippingCarrierDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ReturnPolicyDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ReturnPolicyDetailsType" />.
    /// </summary>
    public ReturnPolicyDetailsType ReturnPolicyDetails => this.ApiResponse.ReturnPolicyDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.InternationalReturnPolicyDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ReturnPolicyDetailsType" />.
    /// </summary>
    public ReturnPolicyDetailsType InternationalReturnPolicyDetails
    {
      get => this.ApiResponse.InternationalReturnPolicyDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ListingStartPriceDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ListingStartPriceDetailsTypeCollection" />.
    /// </summary>
    public ListingStartPriceDetailsTypeCollection ListingStartPriceDetailList
    {
      get => this.ApiResponse.ListingStartPriceDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.BuyerRequirementDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SiteBuyerRequirementDetailsTypeCollection" />.
    /// </summary>
    public SiteBuyerRequirementDetailsTypeCollection BuyerRequirementDetailList
    {
      get => this.ApiResponse.BuyerRequirementDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ListingFeatureDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ListingFeatureDetailsTypeCollection" />.
    /// </summary>
    public ListingFeatureDetailsTypeCollection ListingFeatureDetailList
    {
      get => this.ApiResponse.ListingFeatureDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.VariationDetails" /> of type <see cref="T:eBay.Service.Core.Soap.VariationDetailsType" />.
    /// </summary>
    public VariationDetailsType VariationDetails => this.ApiResponse.VariationDetails;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ExcludeShippingLocationDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ExcludeShippingLocationDetailsTypeCollection" />.
    /// </summary>
    public ExcludeShippingLocationDetailsTypeCollection ExcludeShippingLocationDetailList
    {
      get => this.ApiResponse.ExcludeShippingLocationDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.UpdateTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime UpdateTime => this.ApiResponse.UpdateTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.RecoupmentPolicyDetails" /> of type <see cref="T:eBay.Service.Core.Soap.RecoupmentPolicyDetailsTypeCollection" />.
    /// </summary>
    public RecoupmentPolicyDetailsTypeCollection RecoupmentPolicyDetailList
    {
      get => this.ApiResponse.RecoupmentPolicyDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ShippingCategoryDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingCategoryDetailsTypeCollection" />.
    /// </summary>
    public ShippingCategoryDetailsTypeCollection ShippingCategoryDetailList
    {
      get => this.ApiResponse.ShippingCategoryDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GeteBayDetailsResponseType.ProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.ProductDetailsType" />.
    /// </summary>
    public ProductDetailsType ProductDetails => this.ApiResponse.ProductDetails;
  }
}
