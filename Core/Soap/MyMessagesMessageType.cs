// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyMessagesMessageType
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
  public class MyMessagesMessageType
  {
    private string mSender;
    private string mRecipientUserID;
    private string mSendToName;
    private string mSubject;
    private string mMessageID;
    private string mExternalMessageID;
    private string mContentType;
    private string mText;
    private bool mFlagged;
    private bool mFlaggedSpecified;
    private bool mRead;
    private bool mReadSpecified;
    private DateTime mCreationDate;
    private bool mCreationDateSpecified;
    private DateTime mReceiveDate;
    private bool mReceiveDateSpecified;
    private DateTime mExpirationDate;
    private bool mExpirationDateSpecified;
    private string mItemID;
    private MyMessagesResponseDetailsType mResponseDetails;
    private MyMessagesForwardDetailsType mForwardDetails;
    private MyMessagesFolderType mFolder;
    private string mContent;
    private MessageTypeCodeType mMessageType;
    private bool mMessageTypeSpecified;
    private ListingStatusCodeType mListingStatus;
    private bool mListingStatusSpecified;
    private QuestionTypeCodeType mQuestionType;
    private bool mQuestionTypeSpecified;
    private bool mReplied;
    private bool mRepliedSpecified;
    private bool mHighPriority;
    private bool mHighPrioritySpecified;
    private DateTime mItemEndTime;
    private bool mItemEndTimeSpecified;
    private string mItemTitle;
    private MessageMediaTypeCollection mMessageMedia;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Sender
    {
      get => this.mSender;
      set => this.mSender = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RecipientUserID
    {
      get => this.mRecipientUserID;
      set => this.mRecipientUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SendToName
    {
      get => this.mSendToName;
      set => this.mSendToName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Subject
    {
      get => this.mSubject;
      set => this.mSubject = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MessageID
    {
      get => this.mMessageID;
      set => this.mMessageID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalMessageID
    {
      get => this.mExternalMessageID;
      set => this.mExternalMessageID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ContentType
    {
      get => this.mContentType;
      set => this.mContentType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Text
    {
      get => this.mText;
      set => this.mText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Flagged
    {
      get => this.mFlagged;
      set
      {
        this.mFlagged = value;
        this.mFlaggedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FlaggedSpecified
    {
      get => this.mFlaggedSpecified;
      set => this.mFlaggedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Read
    {
      get => this.mRead;
      set
      {
        this.mRead = value;
        this.mReadSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReadSpecified
    {
      get => this.mReadSpecified;
      set => this.mReadSpecified = value;
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
    public DateTime ReceiveDate
    {
      get => this.mReceiveDate;
      set
      {
        this.mReceiveDate = value;
        this.mReceiveDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReceiveDateSpecified
    {
      get => this.mReceiveDateSpecified;
      set => this.mReceiveDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpirationDate
    {
      get => this.mExpirationDate;
      set
      {
        this.mExpirationDate = value;
        this.mExpirationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpirationDateSpecified
    {
      get => this.mExpirationDateSpecified;
      set => this.mExpirationDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyMessagesResponseDetailsType ResponseDetails
    {
      get => this.mResponseDetails;
      set => this.mResponseDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyMessagesForwardDetailsType ForwardDetails
    {
      get => this.mForwardDetails;
      set => this.mForwardDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyMessagesFolderType Folder
    {
      get => this.mFolder;
      set => this.mFolder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Content
    {
      get => this.mContent;
      set => this.mContent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MessageTypeCodeType MessageType
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
    public ListingStatusCodeType ListingStatus
    {
      get => this.mListingStatus;
      set
      {
        this.mListingStatus = value;
        this.mListingStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingStatusSpecified
    {
      get => this.mListingStatusSpecified;
      set => this.mListingStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public QuestionTypeCodeType QuestionType
    {
      get => this.mQuestionType;
      set
      {
        this.mQuestionType = value;
        this.mQuestionTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuestionTypeSpecified
    {
      get => this.mQuestionTypeSpecified;
      set => this.mQuestionTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Replied
    {
      get => this.mReplied;
      set
      {
        this.mReplied = value;
        this.mRepliedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RepliedSpecified
    {
      get => this.mRepliedSpecified;
      set => this.mRepliedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HighPriority
    {
      get => this.mHighPriority;
      set
      {
        this.mHighPriority = value;
        this.mHighPrioritySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HighPrioritySpecified
    {
      get => this.mHighPrioritySpecified;
      set => this.mHighPrioritySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ItemEndTime
    {
      get => this.mItemEndTime;
      set
      {
        this.mItemEndTime = value;
        this.mItemEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemEndTimeSpecified
    {
      get => this.mItemEndTimeSpecified;
      set => this.mItemEndTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ItemTitle
    {
      get => this.mItemTitle;
      set => this.mItemTitle = value;
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
