// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RegionOfOriginDetailsType
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
  public class RegionOfOriginDetailsType
  {
    private string mRegionOfOrigin;
    private string mDescription;
    private StatusCodeType mStatus;
    private bool mStatusSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string RegionOfOrigin
    {
      get => this.mRegionOfOrigin;
      set => this.mRegionOfOrigin = value;
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
    public StatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
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
