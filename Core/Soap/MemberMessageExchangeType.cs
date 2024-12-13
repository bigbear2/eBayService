// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MemberMessageExchangeType
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
  public class MemberMessageExchangeType
  {
    private ItemType mItem;
    private MemberMessageType mQuestion;
    private StringCollection mResponse;
    private MessageStatusTypeCodeType mMessageStatus;
    private bool mMessageStatusSpecified;
    private DateTime mCreationDate;
    private bool mCreationDateSpecified;
    private DateTime mLastModifiedDate;
    private bool mLastModifiedDateSpecified;
    private MessageMediaTypeCollection mMessageMedia;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public ItemType Item
    {
      get => this.mItem;
      set => this.mItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MemberMessageType Question
    {
      get => this.mQuestion;
      set => this.mQuestion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Response")]
    public StringCollection Response
    {
      get => this.mResponse;
      set => this.mResponse = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MessageStatusTypeCodeType MessageStatus
    {
      get => this.mMessageStatus;
      set
      {
        this.mMessageStatus = value;
        this.mMessageStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageStatusSpecified
    {
      get => this.mMessageStatusSpecified;
      set => this.mMessageStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationDate
    {
      get => this.mCreationDate;
      set
      {
        this.mCreationDate = value;
        this.mCreationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreationDateSpecified
    {
      get => this.mCreationDateSpecified;
      set => this.mCreationDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastModifiedDate
    {
      get => this.mLastModifiedDate;
      set
      {
        this.mLastModifiedDate = value;
        this.mLastModifiedDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastModifiedDateSpecified
    {
      get => this.mLastModifiedDateSpecified;
      set => this.mLastModifiedDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("MessageMedia")]
    public MessageMediaTypeCollection MessageMedia
    {
      get => this.mMessageMedia;
      set => this.mMessageMedia = value;
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
