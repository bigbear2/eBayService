// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DiscountPriceInfoType
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
  public class DiscountPriceInfoType
  {
    private AmountType mOriginalRetailPrice;
    private AmountType mMinimumAdvertisedPrice;
    private MinimumAdvertisedPriceExposureCodeType mMinimumAdvertisedPriceExposure;
    private bool mMinimumAdvertisedPriceExposureSpecified;
    private PricingTreatmentCodeType mPricingTreatment;
    private bool mPricingTreatmentSpecified;
    private bool mSoldOneBay;
    private bool mSoldOffeBay;
    private AmountType mMadeForOutletComparisonPrice;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DiscountPriceInfoType()
    {
      this.SoldOneBay = false;
      this.SoldOffeBay = false;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType OriginalRetailPrice
    {
      get => this.mOriginalRetailPrice;
      set => this.mOriginalRetailPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MinimumAdvertisedPrice
    {
      get => this.mMinimumAdvertisedPrice;
      set => this.mMinimumAdvertisedPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MinimumAdvertisedPriceExposureCodeType MinimumAdvertisedPriceExposure
    {
      get => this.mMinimumAdvertisedPriceExposure;
      set
      {
        this.mMinimumAdvertisedPriceExposure = value;
        this.mMinimumAdvertisedPriceExposureSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinimumAdvertisedPriceExposureSpecified
    {
      get => this.mMinimumAdvertisedPriceExposureSpecified;
      set => this.mMinimumAdvertisedPriceExposureSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PricingTreatmentCodeType PricingTreatment
    {
      get => this.mPricingTreatment;
      set
      {
        this.mPricingTreatment = value;
        this.mPricingTreatmentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PricingTreatmentSpecified
    {
      get => this.mPricingTreatmentSpecified;
      set => this.mPricingTreatmentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(false)]
    public bool SoldOneBay
    {
      get => this.mSoldOneBay;
      set => this.mSoldOneBay = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(false)]
    public bool SoldOffeBay
    {
      get => this.mSoldOffeBay;
      set => this.mSoldOffeBay = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MadeForOutletComparisonPrice
    {
      get => this.mMadeForOutletComparisonPrice;
      set => this.mMadeForOutletComparisonPrice = value;
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
