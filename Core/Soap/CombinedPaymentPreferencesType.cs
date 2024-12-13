// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CombinedPaymentPreferencesType
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
  public class CombinedPaymentPreferencesType
  {
    private CalculatedShippingPreferencesType mCalculatedShippingPreferences;
    private CombinedPaymentOptionCodeType mCombinedPaymentOption;
    private bool mCombinedPaymentOptionSpecified;
    private CombinedPaymentPeriodCodeType mCombinedPaymentPeriod;
    private bool mCombinedPaymentPeriodSpecified;
    private FlatShippingPreferencesType mFlatShippingPreferences;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public CalculatedShippingPreferencesType CalculatedShippingPreferences
    {
      get => this.mCalculatedShippingPreferences;
      set => this.mCalculatedShippingPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CombinedPaymentOptionCodeType CombinedPaymentOption
    {
      get => this.mCombinedPaymentOption;
      set
      {
        this.mCombinedPaymentOption = value;
        this.mCombinedPaymentOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CombinedPaymentOptionSpecified
    {
      get => this.mCombinedPaymentOptionSpecified;
      set => this.mCombinedPaymentOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CombinedPaymentPeriodCodeType CombinedPaymentPeriod
    {
      get => this.mCombinedPaymentPeriod;
      set
      {
        this.mCombinedPaymentPeriod = value;
        this.mCombinedPaymentPeriodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CombinedPaymentPeriodSpecified
    {
      get => this.mCombinedPaymentPeriodSpecified;
      set => this.mCombinedPaymentPeriodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FlatShippingPreferencesType FlatShippingPreferences
    {
      get => this.mFlatShippingPreferences;
      set => this.mFlatShippingPreferences = value;
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
