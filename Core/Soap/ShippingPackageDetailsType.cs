// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingPackageDetailsType
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
  public class ShippingPackageDetailsType
  {
    private int mPackageID;
    private bool mPackageIDSpecified;
    private string mDescription;
    private ShippingPackageCodeType mShippingPackage;
    private bool mShippingPackageSpecified;
    private bool mDefaultValue;
    private bool mDefaultValueSpecified;
    private bool mDimensionsSupported;
    private bool mDimensionsSupportedSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int PackageID
    {
      get => this.mPackageID;
      set
      {
        this.mPackageID = value;
        this.mPackageIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PackageIDSpecified
    {
      get => this.mPackageIDSpecified;
      set => this.mPackageIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Description
    {
      get => this.mDescription;
      set => this.mDescription = value;
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
    public bool DefaultValue
    {
      get => this.mDefaultValue;
      set
      {
        this.mDefaultValue = value;
        this.mDefaultValueSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DefaultValueSpecified
    {
      get => this.mDefaultValueSpecified;
      set => this.mDefaultValueSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DimensionsSupported
    {
      get => this.mDimensionsSupported;
      set
      {
        this.mDimensionsSupported = value;
        this.mDimensionsSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DimensionsSupportedSpecified
    {
      get => this.mDimensionsSupportedSpecified;
      set => this.mDimensionsSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
