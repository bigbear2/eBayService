// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingDetailsType
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
  public class ShippingDetailsType
  {
    private bool mAllowPaymentEdit;
    private bool mAllowPaymentEditSpecified;
    private bool mApplyShippingDiscount;
    private bool mApplyShippingDiscountSpecified;
    private bool mGlobalShipping;
    private bool mGlobalShippingSpecified;
    private CalculatedShippingRateType mCalculatedShippingRate;
    private bool mChangePaymentInstructions;
    private bool mChangePaymentInstructionsSpecified;
    private bool mInsuranceWanted;
    private bool mInsuranceWantedSpecified;
    private bool mPaymentEdited;
    private bool mPaymentEditedSpecified;
    private string mPaymentInstructions;
    private SalesTaxType mSalesTax;
    private string mShippingRateErrorMessage;
    private ShippingRateTypeCodeType mShippingRateType;
    private bool mShippingRateTypeSpecified;
    private ShippingServiceOptionsTypeCollection mShippingServiceOptions;
    private InternationalShippingServiceOptionsTypeCollection mInternationalShippingServiceOption;
    private ShippingTypeCodeType mShippingType;
    private bool mShippingTypeSpecified;
    private int mSellingManagerSalesRecordNumber;
    private bool mSellingManagerSalesRecordNumberSpecified;
    private bool mThirdPartyCheckout;
    private bool mThirdPartyCheckoutSpecified;
    private TaxJurisdictionTypeCollection mTaxTable;
    private bool mGetItFast;
    private bool mGetItFastSpecified;
    private string mShippingServiceUsed;
    private AmountType mDefaultShippingCost;
    private string mShippingDiscountProfileID;
    private FlatShippingDiscountType mFlatShippingDiscount;
    private CalculatedShippingDiscountType mCalculatedShippingDiscount;
    private bool mPromotionalShippingDiscount;
    private bool mPromotionalShippingDiscountSpecified;
    private string mInternationalShippingDiscountProfileID;
    private FlatShippingDiscountType mInternationalFlatShippingDiscount;
    private CalculatedShippingDiscountType mInternationalCalculatedShippingDiscount;
    private bool mInternationalPromotionalShippingDiscount;
    private bool mInternationalPromotionalShippingDiscountSpecified;
    private PromotionalShippingDiscountDetailsType mPromotionalShippingDiscountDetails;
    private AmountType mCODCost;
    private StringCollection mExcludeShipToLocation;
    private bool mSellerExcludeShipToLocationsPreference;
    private bool mSellerExcludeShipToLocationsPreferenceSpecified;
    private ShipmentTrackingDetailsTypeCollection mShipmentTrackingDetails;
    private RateTableDetailsType mRateTableDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool AllowPaymentEdit
    {
      get => this.mAllowPaymentEdit;
      set
      {
        this.mAllowPaymentEdit = value;
        this.mAllowPaymentEditSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AllowPaymentEditSpecified
    {
      get => this.mAllowPaymentEditSpecified;
      set => this.mAllowPaymentEditSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ApplyShippingDiscount
    {
      get => this.mApplyShippingDiscount;
      set
      {
        this.mApplyShippingDiscount = value;
        this.mApplyShippingDiscountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ApplyShippingDiscountSpecified
    {
      get => this.mApplyShippingDiscountSpecified;
      set => this.mApplyShippingDiscountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GlobalShipping
    {
      get => this.mGlobalShipping;
      set
      {
        this.mGlobalShipping = value;
        this.mGlobalShippingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GlobalShippingSpecified
    {
      get => this.mGlobalShippingSpecified;
      set => this.mGlobalShippingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingRateType CalculatedShippingRate
    {
      get => this.mCalculatedShippingRate;
      set => this.mCalculatedShippingRate = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ChangePaymentInstructions
    {
      get => this.mChangePaymentInstructions;
      set
      {
        this.mChangePaymentInstructions = value;
        this.mChangePaymentInstructionsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ChangePaymentInstructionsSpecified
    {
      get => this.mChangePaymentInstructionsSpecified;
      set => this.mChangePaymentInstructionsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool InsuranceWanted
    {
      get => this.mInsuranceWanted;
      set
      {
        this.mInsuranceWanted = value;
        this.mInsuranceWantedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InsuranceWantedSpecified
    {
      get => this.mInsuranceWantedSpecified;
      set => this.mInsuranceWantedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PaymentEdited
    {
      get => this.mPaymentEdited;
      set
      {
        this.mPaymentEdited = value;
        this.mPaymentEditedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentEditedSpecified
    {
      get => this.mPaymentEditedSpecified;
      set => this.mPaymentEditedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PaymentInstructions
    {
      get => this.mPaymentInstructions;
      set => this.mPaymentInstructions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SalesTaxType SalesTax
    {
      get => this.mSalesTax;
      set => this.mSalesTax = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShippingRateErrorMessage
    {
      get => this.mShippingRateErrorMessage;
      set => this.mShippingRateErrorMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingRateTypeCodeType ShippingRateType
    {
      get => this.mShippingRateType;
      set
      {
        this.mShippingRateType = value;
        this.mShippingRateTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingRateTypeSpecified
    {
      get => this.mShippingRateTypeSpecified;
      set => this.mShippingRateTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingServiceOptions")]
    public ShippingServiceOptionsTypeCollection ShippingServiceOptions
    {
      get => this.mShippingServiceOptions;
      set => this.mShippingServiceOptions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("InternationalShippingServiceOption")]
    public InternationalShippingServiceOptionsTypeCollection InternationalShippingServiceOption
    {
      get => this.mInternationalShippingServiceOption;
      set => this.mInternationalShippingServiceOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingTypeCodeType ShippingType
    {
      get => this.mShippingType;
      set
      {
        this.mShippingType = value;
        this.mShippingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTypeSpecified
    {
      get => this.mShippingTypeSpecified;
      set => this.mShippingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int SellingManagerSalesRecordNumber
    {
      get => this.mSellingManagerSalesRecordNumber;
      set
      {
        this.mSellingManagerSalesRecordNumber = value;
        this.mSellingManagerSalesRecordNumberSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellingManagerSalesRecordNumberSpecified
    {
      get => this.mSellingManagerSalesRecordNumberSpecified;
      set => this.mSellingManagerSalesRecordNumberSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ThirdPartyCheckout
    {
      get => this.mThirdPartyCheckout;
      set
      {
        this.mThirdPartyCheckout = value;
        this.mThirdPartyCheckoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ThirdPartyCheckoutSpecified
    {
      get => this.mThirdPartyCheckoutSpecified;
      set => this.mThirdPartyCheckoutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("TaxJurisdiction", IsNullable = false)]
    public TaxJurisdictionTypeCollection TaxTable
    {
      get => this.mTaxTable;
      set => this.mTaxTable = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GetItFast
    {
      get => this.mGetItFast;
      set
      {
        this.mGetItFast = value;
        this.mGetItFastSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GetItFastSpecified
    {
      get => this.mGetItFastSpecified;
      set => this.mGetItFastSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingServiceUsed
    {
      get => this.mShippingServiceUsed;
      set => this.mShippingServiceUsed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType DefaultShippingCost
    {
      get => this.mDefaultShippingCost;
      set => this.mDefaultShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShippingDiscountProfileID
    {
      get => this.mShippingDiscountProfileID;
      set => this.mShippingDiscountProfileID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FlatShippingDiscountType FlatShippingDiscount
    {
      get => this.mFlatShippingDiscount;
      set => this.mFlatShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingDiscountType CalculatedShippingDiscount
    {
      get => this.mCalculatedShippingDiscount;
      set => this.mCalculatedShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PromotionalShippingDiscount
    {
      get => this.mPromotionalShippingDiscount;
      set
      {
        this.mPromotionalShippingDiscount = value;
        this.mPromotionalShippingDiscountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalShippingDiscountSpecified
    {
      get => this.mPromotionalShippingDiscountSpecified;
      set => this.mPromotionalShippingDiscountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalShippingDiscountProfileID
    {
      get => this.mInternationalShippingDiscountProfileID;
      set => this.mInternationalShippingDiscountProfileID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FlatShippingDiscountType InternationalFlatShippingDiscount
    {
      get => this.mInternationalFlatShippingDiscount;
      set => this.mInternationalFlatShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingDiscountType InternationalCalculatedShippingDiscount
    {
      get => this.mInternationalCalculatedShippingDiscount;
      set => this.mInternationalCalculatedShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool InternationalPromotionalShippingDiscount
    {
      get => this.mInternationalPromotionalShippingDiscount;
      set
      {
        this.mInternationalPromotionalShippingDiscount = value;
        this.mInternationalPromotionalShippingDiscountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InternationalPromotionalShippingDiscountSpecified
    {
      get => this.mInternationalPromotionalShippingDiscountSpecified;
      set => this.mInternationalPromotionalShippingDiscountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
    {
      get => this.mPromotionalShippingDiscountDetails;
      set => this.mPromotionalShippingDiscountDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType CODCost
    {
      get => this.mCODCost;
      set => this.mCODCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExcludeShipToLocation")]
    public StringCollection ExcludeShipToLocation
    {
      get => this.mExcludeShipToLocation;
      set => this.mExcludeShipToLocation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerExcludeShipToLocationsPreference
    {
      get => this.mSellerExcludeShipToLocationsPreference;
      set
      {
        this.mSellerExcludeShipToLocationsPreference = value;
        this.mSellerExcludeShipToLocationsPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerExcludeShipToLocationsPreferenceSpecified
    {
      get => this.mSellerExcludeShipToLocationsPreferenceSpecified;
      set => this.mSellerExcludeShipToLocationsPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShipmentTrackingDetails")]
    public ShipmentTrackingDetailsTypeCollection ShipmentTrackingDetails
    {
      get => this.mShipmentTrackingDetails;
      set => this.mShipmentTrackingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RateTableDetailsType RateTableDetails
    {
      get => this.mRateTableDetails;
      set => this.mRateTableDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
