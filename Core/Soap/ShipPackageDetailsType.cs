// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShipPackageDetailsType
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
  public class ShipPackageDetailsType
  {
    private MeasurementSystemCodeType mMeasurementUnit;
    private bool mMeasurementUnitSpecified;
    private MeasureType mPackageDepth;
    private MeasureType mPackageLength;
    private MeasureType mPackageWidth;
    private bool mShippingIrregular;
    private bool mShippingIrregularSpecified;
    private ShippingPackageCodeType mShippingPackage;
    private bool mShippingPackageSpecified;
    private MeasureType mWeightMajor;
    private MeasureType mWeightMinor;
    private XmlElementCollection mAny;

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
    public MeasureType PackageDepth
    {
      get => this.mPackageDepth;
      set => this.mPackageDepth = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType PackageLength
    {
      get => this.mPackageLength;
      set => this.mPackageLength = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType PackageWidth
    {
      get => this.mPackageWidth;
      set => this.mPackageWidth = value;
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
    public ShippingPackageCodeType ShippingPackage
    {
      get => this.mShippingPackage;
      set
      {
        this.mShippingPackage = value;
        this.mShippingPackageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingPackageSpecified
    {
      get => this.mShippingPackageSpecified;
      set => this.mShippingPackageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType WeightMajor
    {
      get => this.mWeightMajor;
      set => this.mWeightMajor = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType WeightMinor
    {
      get => this.mWeightMinor;
      set => this.mWeightMinor = value;
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
