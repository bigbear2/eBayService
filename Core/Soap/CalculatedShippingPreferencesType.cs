// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CalculatedShippingPreferencesType
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
  public class CalculatedShippingPreferencesType
  {
    private AmountType mCalculatedShippingAmountForEntireOrder;
    private CalculatedShippingChargeOptionCodeType mCalculatedShippingChargeOption;
    private bool mCalculatedShippingChargeOptionSpecified;
    private CalculatedShippingRateOptionCodeType mCalculatedShippingRateOption;
    private bool mCalculatedShippingRateOptionSpecified;
    private InsuranceOptionCodeType mInsuranceOption;
    private bool mInsuranceOptionSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AmountType CalculatedShippingAmountForEntireOrder
    {
      get => this.mCalculatedShippingAmountForEntireOrder;
      set => this.mCalculatedShippingAmountForEntireOrder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingChargeOptionCodeType CalculatedShippingChargeOption
    {
      get => this.mCalculatedShippingChargeOption;
      set
      {
        this.mCalculatedShippingChargeOption = value;
        this.mCalculatedShippingChargeOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CalculatedShippingChargeOptionSpecified
    {
      get => this.mCalculatedShippingChargeOptionSpecified;
      set => this.mCalculatedShippingChargeOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingRateOptionCodeType CalculatedShippingRateOption
    {
      get => this.mCalculatedShippingRateOption;
      set
      {
        this.mCalculatedShippingRateOption = value;
        this.mCalculatedShippingRateOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CalculatedShippingRateOptionSpecified
    {
      get => this.mCalculatedShippingRateOptionSpecified;
      set => this.mCalculatedShippingRateOptionSpecified = value;
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
