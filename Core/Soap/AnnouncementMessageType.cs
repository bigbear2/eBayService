// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AnnouncementMessageType
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
  public class AnnouncementMessageType
  {
    private DateTime mAnnouncementStartTime;
    private bool mAnnouncementStartTimeSpecified;
    private DateTime mEventTime;
    private bool mEventTimeSpecified;
    private AnnouncementMessageCodeType mMessageType;
    private bool mMessageTypeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DateTime AnnouncementStartTime
    {
      get => this.mAnnouncementStartTime;
      set
      {
        this.mAnnouncementStartTime = value;
        this.mAnnouncementStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AnnouncementStartTimeSpecified
    {
      get => this.mAnnouncementStartTimeSpecified;
      set => this.mAnnouncementStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EventTime
    {
      get => this.mEventTime;
      set
      {
        this.mEventTime = value;
        this.mEventTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EventTimeSpecified
    {
      get => this.mEventTimeSpecified;
      set => this.mEventTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AnnouncementMessageCodeType MessageType
    {
      get => this.mMessageType;
      set
      {
        this.mMessageType = value;
        this.mMessageTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageTypeSpecified
    {
      get => this.mMessageTypeSpecified;
      set => this.mMessageTypeSpecified = value;
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
