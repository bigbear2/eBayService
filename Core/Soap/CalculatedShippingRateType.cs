// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CalculatedShippingRateType
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
  public class CalculatedShippingRateType
  {
    private string mOriginatingPostalCode;
    private MeasurementSystemCodeType mMeasurementUnit;
    private bool mMeasurementUnitSpecified;
    private AmountType mPackagingHandlingCosts;
    private bool mShippingIrregular;
    private bool mShippingIrregularSpecified;
    private AmountType mInternationalPackagingHandlingCosts;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string OriginatingPostalCode
    {
      get => this.mOriginatingPostalCode;
      set => this.mOriginatingPostalCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasurementSystemCodeType MeasurementUnit
    {
      get => this.mMeasurementUnit;
      set
      {
        this.mMeasurementUnit = value;
        this.mMeasurementUnitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MeasurementUnitSpecified
    {
      get => this.mMeasurementUnitSpecified;
      set => this.mMeasurementUnitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType PackagingHandlingCosts
    {
      get => this.mPackagingHandlingCosts;
      set => this.mPackagingHandlingCosts = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShippingIrregular
    {
      get => this.mShippingIrregular;
      set
      {
        this.mShippingIrregular = value;
        this.mShippingIrregularSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingIrregularSpecified
    {
      get => this.mShippingIrregularSpecified;
      set => this.mShippingIrregularSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InternationalPackagingHandlingCosts
    {
      get => this.mInternationalPackagingHandlingCosts;
      set => this.mInternationalPackagingHandlingCosts = value;
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
