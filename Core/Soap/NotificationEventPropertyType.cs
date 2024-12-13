// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NotificationEventPropertyType
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
  public class NotificationEventPropertyType
  {
    private NotificationEventTypeCodeType mEventType;
    private bool mEventTypeSpecified;
    private NotificationEventPropertyNameCodeType mName;
    private bool mNameSpecified;
    private string mValue;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public NotificationEventTypeCodeType EventType
    {
      get => this.mEventType;
      set
      {
        this.mEventType = value;
        this.mEventTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EventTypeSpecified
    {
      get => this.mEventTypeSpecified;
      set => this.mEventTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NotificationEventPropertyNameCodeType Name
    {
      get => this.mName;
      set
      {
        this.mName = value;
        this.mNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NameSpecified
    {
      get => this.mNameSpecified;
      set => this.mNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Value
    {
      get => this.mValue;
      set => this.mValue = value;
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
