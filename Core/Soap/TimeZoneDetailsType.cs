// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TimeZoneDetailsType
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
  public class TimeZoneDetailsType
  {
    private string mTimeZoneID;
    private string mStandardLabel;
    private string mStandardOffset;
    private string mDaylightSavingsLabel;
    private string mDaylightSavingsOffset;
    private bool mDaylightSavingsInEffect;
    private bool mDaylightSavingsInEffectSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string TimeZoneID
    {
      get => this.mTimeZoneID;
      set => this.mTimeZoneID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StandardLabel
    {
      get => this.mStandardLabel;
      set => this.mStandardLabel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StandardOffset
    {
      get => this.mStandardOffset;
      set => this.mStandardOffset = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DaylightSavingsLabel
    {
      get => this.mDaylightSavingsLabel;
      set => this.mDaylightSavingsLabel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DaylightSavingsOffset
    {
      get => this.mDaylightSavingsOffset;
      set => this.mDaylightSavingsOffset = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DaylightSavingsInEffect
    {
      get => this.mDaylightSavingsInEffect;
      set
      {
        this.mDaylightSavingsInEffect = value;
        this.mDaylightSavingsInEffectSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DaylightSavingsInEffectSpecified
    {
      get => this.mDaylightSavingsInEffectSpecified;
      set => this.mDaylightSavingsInEffectSpecified = value;
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
