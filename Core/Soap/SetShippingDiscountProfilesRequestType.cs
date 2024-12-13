// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType
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
  public class SetShippingDiscountProfilesRequestType : AbstractRequestType
  {
    private CurrencyCodeType mCurrencyID;
    private bool mCurrencyIDSpecified;
    private CombinedPaymentPeriodCodeType mCombinedDuration;
    private bool mCombinedDurationSpecified;
    private ModifyActionCodeType mModifyActionCode;
    private bool mModifyActionCodeSpecified;
    private FlatShippingDiscountType mFlatShippingDiscount;
    private CalculatedShippingDiscountType mCalculatedShippingDiscount;
    private CalculatedHandlingDiscountType mCalculatedHandlingDiscount;
    private PromotionalShippingDiscountDetailsType mPromotionalShippingDiscountDetails;
    private ShippingInsuranceType mShippingInsurance;
    private ShippingInsuranceType mInternationalShippingInsurance;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
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
    [XmlElement(Order = 1)]
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

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public ModifyActionCodeType ModifyActionCode
    {
      get => this.mModifyActionCode;
      set
      {
        this.mModifyActionCode = value;
        this.mModifyActionCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModifyActionCodeSpecified
    {
      get => this.mModifyActionCodeSpecified;
      set => this.mModifyActionCodeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public FlatShippingDiscountType FlatShippingDiscount
    {
      get => this.mFlatShippingDiscount;
      set => this.mFlatShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public CalculatedShippingDiscountType CalculatedShippingDiscount
    {
      get => this.mCalculatedShippingDiscount;
      set => this.mCalculatedShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public CalculatedHandlingDiscountType CalculatedHandlingDiscount
    {
      get => this.mCalculatedHandlingDiscount;
      set => this.mCalculatedHandlingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
    {
      get => this.mPromotionalShippingDiscountDetails;
      set => this.mPromotionalShippingDiscountDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public ShippingInsuranceType ShippingInsurance
    {
      get => this.mShippingInsurance;
      set => this.mShippingInsurance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public ShippingInsuranceType InternationalShippingInsurance
    {
      get => this.mInternationalShippingInsurance;
      set => this.mInternationalShippingInsurance = value;
    }
  }
}
