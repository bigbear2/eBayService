// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerEmailLogType
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
  public class SellingManagerEmailLogType
  {
    private SellingManagerEmailTypeCodeType mEmailType;
    private bool mEmailTypeSpecified;
    private string mCustomEmailName;
    private SellingManagerEmailSentStatusCodeType mEmailState;
    private bool mEmailStateSpecified;
    private DateTime mEventTime;
    private bool mEventTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerEmailTypeCodeType EmailType
    {
      get => this.mEmailType;
      set
      {
        this.mEmailType = value;
        this.mEmailTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailTypeSpecified
    {
      get => this.mEmailTypeSpecified;
      set => this.mEmailTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CustomEmailName
    {
      get => this.mCustomEmailName;
      set => this.mCustomEmailName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerEmailSentStatusCodeType EmailState
    {
      get => this.mEmailState;
      set
      {
        this.mEmailState = value;
        this.mEmailStateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailStateSpecified
    {
      get => this.mEmailStateSpecified;
      set => this.mEmailStateSpecified = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
