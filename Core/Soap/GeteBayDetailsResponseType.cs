// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GeteBayDetailsResponseType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class GeteBayDetailsResponseType : AbstractResponseType
  {
    private CountryDetailsTypeCollection mCountryDetails;
    private CurrencyDetailsTypeCollection mCurrencyDetails;
    private DispatchTimeMaxDetailsTypeCollection mDispatchTimeMaxDetails;
    private PaymentOptionDetailsTypeCollection mPaymentOptionDetails;
    private RegionDetailsTypeCollection mRegionDetails;
    private ShippingLocationDetailsTypeCollection mShippingLocationDetails;
    private ShippingServiceDetailsTypeCollection mShippingServiceDetails;
    private SiteDetailsTypeCollection mSiteDetails;
    private TaxJurisdictionTypeCollection mTaxJurisdiction;
    private URLDetailsTypeCollection mURLDetails;
    private TimeZoneDetailsTypeCollection mTimeZoneDetails;
    private ItemSpecificDetailsTypeCollection mItemSpecificDetails;
    private UnitOfMeasurementDetailsTypeCollection mUnitOfMeasurementDetails;
    private RegionOfOriginDetailsTypeCollection mRegionOfOriginDetails;
    private ShippingPackageDetailsTypeCollection mShippingPackageDetails;
    private ShippingCarrierDetailsTypeCollection mShippingCarrierDetails;
    private ReturnPolicyDetailsType mReturnPolicyDetails;
    private ReturnPolicyDetailsType mInternationalReturnPolicyDetails;
    private ListingStartPriceDetailsTypeCollection mListingStartPriceDetails;
    private SiteBuyerRequirementDetailsTypeCollection mBuyerRequirementDetails;
    private ListingFeatureDetailsTypeCollection mListingFeatureDetails;
    private VariationDetailsType mVariationDetails;
    private ExcludeShippingLocationDetailsTypeCollection mExcludeShippingLocationDetails;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private RecoupmentPolicyDetailsTypeCollection mRecoupmentPolicyDetails;
    private ShippingCategoryDetailsTypeCollection mShippingCategoryDetails;
    private ProductDetailsType mProductDetails;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CountryDetails")]
    public CountryDetailsTypeCollection CountryDetails
    {
      get => this.mCountryDetails;
      set => this.mCountryDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CurrencyDetails")]
    public CurrencyDetailsTypeCollection CurrencyDetails
    {
      get => this.mCurrencyDetails;
      set => this.mCurrencyDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DispatchTimeMaxDetails")]
    public DispatchTimeMaxDetailsTypeCollection DispatchTimeMaxDetails
    {
      get => this.mDispatchTimeMaxDetails;
      set => this.mDispatchTimeMaxDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PaymentOptionDetails")]
    public PaymentOptionDetailsTypeCollection PaymentOptionDetails
    {
      get => this.mPaymentOptionDetails;
      set => this.mPaymentOptionDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RegionDetails")]
    public RegionDetailsTypeCollection RegionDetails
    {
      get => this.mRegionDetails;
      set => this.mRegionDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingLocationDetails")]
    public ShippingLocationDetailsTypeCollection ShippingLocationDetails
    {
      get => this.mShippingLocationDetails;
      set => this.mShippingLocationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingServiceDetails")]
    public ShippingServiceDetailsTypeCollection ShippingServiceDetails
    {
      get => this.mShippingServiceDetails;
      set => this.mShippingServiceDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SiteDetails")]
    public SiteDetailsTypeCollection SiteDetails
    {
      get => this.mSiteDetails;
      set => this.mSiteDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("TaxJurisdiction")]
    public TaxJurisdictionTypeCollection TaxJurisdiction
    {
      get => this.mTaxJurisdiction;
      set => this.mTaxJurisdiction = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("URLDetails")]
    public URLDetailsTypeCollection URLDetails
    {
      get => this.mURLDetails;
      set => this.mURLDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("TimeZoneDetails")]
    public TimeZoneDetailsTypeCollection TimeZoneDetails
    {
      get => this.mTimeZoneDetails;
      set => this.mTimeZoneDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemSpecificDetails")]
    public ItemSpecificDetailsTypeCollection ItemSpecificDetails
    {
      get => this.mItemSpecificDetails;
      set => this.mItemSpecificDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UnitOfMeasurementDetails")]
    public UnitOfMeasurementDetailsTypeCollection UnitOfMeasurementDetails
    {
      get => this.mUnitOfMeasurementDetails;
      set => this.mUnitOfMeasurementDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RegionOfOriginDetails")]
    public RegionOfOriginDetailsTypeCollection RegionOfOriginDetails
    {
      get => this.mRegionOfOriginDetails;
      set => this.mRegionOfOriginDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingPackageDetails")]
    public ShippingPackageDetailsTypeCollection ShippingPackageDetails
    {
      get => this.mShippingPackageDetails;
      set => this.mShippingPackageDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingCarrierDetails")]
    public ShippingCarrierDetailsTypeCollection ShippingCarrierDetails
    {
      get => this.mShippingCarrierDetails;
      set => this.mShippingCarrierDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ReturnPolicyDetailsType ReturnPolicyDetails
    {
      get => this.mReturnPolicyDetails;
      set => this.mReturnPolicyDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ReturnPolicyDetailsType InternationalReturnPolicyDetails
    {
      get => this.mInternationalReturnPolicyDetails;
      set => this.mInternationalReturnPolicyDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ListingStartPriceDetails")]
    public ListingStartPriceDetailsTypeCollection ListingStartPriceDetails
    {
      get => this.mListingStartPriceDetails;
      set => this.mListingStartPriceDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("BuyerRequirementDetails")]
    public SiteBuyerRequirementDetailsTypeCollection BuyerRequirementDetails
    {
      get => this.mBuyerRequirementDetails;
      set => this.mBuyerRequirementDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ListingFeatureDetails")]
    public ListingFeatureDetailsTypeCollection ListingFeatureDetails
    {
      get => this.mListingFeatureDetails;
      set => this.mListingFeatureDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationDetailsType VariationDetails
    {
      get => this.mVariationDetails;
      set => this.mVariationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExcludeShippingLocationDetails")]
    public ExcludeShippingLocationDetailsTypeCollection ExcludeShippingLocationDetails
    {
      get => this.mExcludeShippingLocationDetails;
      set => this.mExcludeShippingLocationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RecoupmentPolicyDetails")]
    public RecoupmentPolicyDetailsTypeCollection RecoupmentPolicyDetails
    {
      get => this.mRecoupmentPolicyDetails;
      set => this.mRecoupmentPolicyDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingCategoryDetails")]
    public ShippingCategoryDetailsTypeCollection ShippingCategoryDetails
    {
      get => this.mShippingCategoryDetails;
      set => this.mShippingCategoryDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductDetailsType ProductDetails
    {
      get => this.mProductDetails;
      set => this.mProductDetails = value;
    }
  }
}
