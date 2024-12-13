// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FlatShippingPreferencesType
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
  public class FlatShippingPreferencesType
  {
    private AmountType mAmountPerAdditionalItem;
    private AmountType mDeductionAmountPerAdditionalItem;
    private FlatRateInsuranceRangeCostTypeCollection mFlatRateInsuranceRangeCost;
    private FlatShippingRateOptionCodeType mFlatShippingRateOption;
    private bool mFlatShippingRateOptionSpecified;
    private InsuranceOptionCodeType mInsuranceOption;
    private bool mInsuranceOptionSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AmountType AmountPerAdditionalItem
    {
      get => this.mAmountPerAdditionalItem;
      set => this.mAmountPerAdditionalItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType DeductionAmountPerAdditionalItem
    {
      get => this.mDeductionAmountPerAdditionalItem;
      set => this.mDeductionAmountPerAdditionalItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FlatRateInsuranceRangeCost")]
    public FlatRateInsuranceRangeCostTypeCollection FlatRateInsuranceRangeCost
    {
      get => this.mFlatRateInsuranceRangeCost;
      set => this.mFlatRateInsuranceRangeCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FlatShippingRateOptionCodeType FlatShippingRateOption
    {
      get => this.mFlatShippingRateOption;
      set
      {
        this.mFlatShippingRateOption = value;
        this.mFlatShippingRateOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FlatShippingRateOptionSpecified
    {
      get => this.mFlatShippingRateOptionSpecified;
      set => this.mFlatShippingRateOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InsuranceOptionCodeType InsuranceOption
    {
      get => this.mInsuranceOption;
      set
      {
        this.mInsuranceOption = value;
        this.mInsuranceOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InsuranceOptionSpecified
    {
      get => this.mInsuranceOptionSpecified;
      set => this.mInsuranceOptionSpecified = value;
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
