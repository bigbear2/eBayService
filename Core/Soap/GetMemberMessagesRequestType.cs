// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMemberMessagesRequestType
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
  public class GetMemberMessagesRequestType : AbstractRequestType
  {
    private string mItemID;
    private MessageTypeCodeType mMailMessageType;
    private bool mMailMessageTypeSpecified;
    private MessageStatusTypeCodeType mMessageStatus;
    private bool mMessageStatusSpecified;
    private bool mDisplayToPublic;
    private bool mDisplayToPublicSpecified;
    private DateTime mStartCreationTime;
    private bool mStartCreationTimeSpecified;
    private DateTime mEndCreationTime;
    private bool mEndCreationTimeSpecified;
    private PaginationType mPagination;
    private string mMemberMessageID;
    private string mSenderID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public MessageTypeCodeType MailMessageType
    {
      get => this.mMailMessageType;
      set
      {
        this.mMailMessageType = value;
        this.mMailMessageTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MailMessageTypeSpecified
    {
      get => this.mMailMessageTypeSpecified;
      set => this.mMailMessageTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
    public bool DisplayToPublic
    {
      get => this.mDisplayToPublic;
      set
      {
        this.mDisplayToPublic = value;
        this.mDisplayToPublicSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayToPublicSpecified
    {
      get => this.mDisplayToPublicSpecified;
      set => this.mDisplayToPublicSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public DateTime StartCreationTime
    {
      get => this.mStartCreationTime;
      set
      {
        this.mStartCreationTime = value;
        this.mStartCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartCreationTimeSpecified
    {
      get => this.mStartCreationTimeSpecified;
      set => this.mStartCreationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public DateTime EndCreationTime
    {
      get => this.mEndCreationTime;
      set
      {
        this.mEndCreationTime = value;
        this.mEndCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndCreationTimeSpecified
    {
      get => this.mEndCreationTimeSpecified;
      set => this.mEndCreationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public string MemberMessageID
    {
      get => this.mMemberMessageID;
      set => this.mMemberMessageID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public string SenderID
    {
      get => this.mSenderID;
      set => this.mSenderID = value;
    }
  }
}
