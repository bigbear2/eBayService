// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MarkUpMarkDownEventType
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
  public class MarkUpMarkDownEventType
  {
    private MarkUpMarkDownEventTypeCodeType mType;
    private bool mTypeSpecified;
    private DateTime mTime;
    private bool mTimeSpecified;
    private string mReason;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public MarkUpMarkDownEventTypeCodeType Type
    {
      get => this.mType;
      set
      {
        this.mType = value;
        this.mTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TypeSpecified
    {
      get => this.mTypeSpecified;
      set => this.mTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Time
    {
      get => this.mTime;
      set
      {
        this.mTime = value;
        this.mTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TimeSpecified
    {
      get => this.mTimeSpecified;
      set => this.mTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Reason
    {
      get => this.mReason;
      set => this.mReason = value;
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
