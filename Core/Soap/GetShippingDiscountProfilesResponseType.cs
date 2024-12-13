// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetShippingDiscountProfilesResponseType
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
  public class GetShippingDiscountProfilesResponseType : AbstractResponseType
  {
    private CurrencyCodeType mCurrencyID;
    private bool mCurrencyIDSpecified;
    private FlatShippingDiscountType mFlatShippingDiscount;
    private CalculatedShippingDiscountType mCalculatedShippingDiscount;
    private bool mPromotionalShippingDiscount;
    private bool mPromotionalShippingDiscountSpecified;
    private CalculatedHandlingDiscountType mCalculatedHandlingDiscount;
    private PromotionalShippingDiscountDetailsType mPromotionalShippingDiscountDetails;
    private ShippingInsuranceType mShippingInsurance;
    private ShippingInsuranceType mInternationalShippingInsurance;
    private CombinedPaymentPeriodCodeType mCombinedDuration;
    private bool mCombinedDurationSpecified;

    /// <summary>
    /// 
    /// </summary>
    public CurrencyCodeType CurrencyID
    {
      get => this.mCurrencyID;
      set
      {
        this.mCurrencyID = value;
        this.mCurrencyIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CurrencyIDSpecified
    {
      get => this.mCurrencyIDSpecified;
      set => this.mCurrencyIDSpecified = value;
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
    public CalculatedHandlingDiscountType CalculatedHandlingDiscount
    {
      get => this.mCalculatedHandlingDiscount;
      set => this.mCalculatedHandlingDiscount = value;
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
    public ShippingInsuranceType ShippingInsurance
    {
      get => this.mShippingInsurance;
      set => this.mShippingInsurance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingInsuranceType InternationalShippingInsurance
    {
      get => this.mInternationalShippingInsurance;
      set => this.mInternationalShippingInsurance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CombinedPaymentPeriodCodeType CombinedDuration
    {
      get => this.mCombinedDuration;
      set
      {
        this.mCombinedDuration = value;
        this.mCombinedDurationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CombinedDurationSpecified
    {
      get => this.mCombinedDurationSpecified;
      set => this.mCombinedDurationSpecified = value;
    }
  }
}
