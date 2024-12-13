// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DisputeMessageType
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
  public class DisputeMessageType
  {
    private int mMessageID;
    private bool mMessageIDSpecified;
    private DisputeMessageSourceCodeType mMessageSource;
    private bool mMessageSourceSpecified;
    private DateTime mMessageCreationTime;
    private bool mMessageCreationTimeSpecified;
    private string mMessageText;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int MessageID
    {
      get => this.mMessageID;
      set
      {
        this.mMessageID = value;
        this.mMessageIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageIDSpecified
    {
      get => this.mMessageIDSpecified;
      set => this.mMessageIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeMessageSourceCodeType MessageSource
    {
      get => this.mMessageSource;
      set
      {
        this.mMessageSource = value;
        this.mMessageSourceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageSourceSpecified
    {
      get => this.mMessageSourceSpecified;
      set => this.mMessageSourceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime MessageCreationTime
    {
      get => this.mMessageCreationTime;
      set
      {
        this.mMessageCreationTime = value;
        this.mMessageCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageCreationTimeSpecified
    {
      get => this.mMessageCreationTimeSpecified;
      set => this.mMessageCreationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MessageText
    {
      get => this.mMessageText;
      set => this.mMessageText = value;
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
