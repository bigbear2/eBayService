// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyMessagesAlertType
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
  public class MyMessagesAlertType
  {
    private string mSender;
    private string mRecipientUserID;
    private string mSubject;
    private string mPriority;
    private string mAlertID;
    private string mExternalAlertID;
    private string mContentType;
    private string mText;
    private MyMessagesAlertResolutionStatusCode mResolutionStatus;
    private bool mResolutionStatusSpecified;
    private bool mRead;
    private bool mReadSpecified;
    private DateTime mCreationDate;
    private bool mCreationDateSpecified;
    private DateTime mReceiveDate;
    private bool mReceiveDateSpecified;
    private DateTime mExpirationDate;
    private bool mExpirationDateSpecified;
    private DateTime mResolutionDate;
    private bool mResolutionDateSpecified;
    private DateTime mLastReadDate;
    private bool mLastReadDateSpecified;
    private string mItemID;
    private bool mIsTimedResolution;
    private bool mIsTimedResolutionSpecified;
    private string mActionURL;
    private MyMessagesResponseDetailsType mResponseDetails;
    private MyMessagesForwardDetailsType mForwardDetails;
    private MyMessagesFolderType mFolder;
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
    public string Subject
    {
      get => this.mSubject;
      set => this.mSubject = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Priority
    {
      get => this.mPriority;
      set => this.mPriority = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AlertID
    {
      get => this.mAlertID;
      set => this.mAlertID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalAlertID
    {
      get => this.mExternalAlertID;
      set => this.mExternalAlertID = value;
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
    public MyMessagesAlertResolutionStatusCode ResolutionStatus
    {
      get => this.mResolutionStatus;
      set
      {
        this.mResolutionStatus = value;
        this.mResolutionStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResolutionStatusSpecified
    {
      get => this.mResolutionStatusSpecified;
      set => this.mResolutionStatusSpecified = value;
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
    public DateTime ResolutionDate
    {
      get => this.mResolutionDate;
      set
      {
        this.mResolutionDate = value;
        this.mResolutionDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResolutionDateSpecified
    {
      get => this.mResolutionDateSpecified;
      set => this.mResolutionDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastReadDate
    {
      get => this.mLastReadDate;
      set
      {
        this.mLastReadDate = value;
        this.mLastReadDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastReadDateSpecified
    {
      get => this.mLastReadDateSpecified;
      set => this.mLastReadDateSpecified = value;
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
    public bool IsTimedResolution
    {
      get => this.mIsTimedResolution;
      set
      {
        this.mIsTimedResolution = value;
        this.mIsTimedResolutionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IsTimedResolutionSpecified
    {
      get => this.mIsTimedResolutionSpecified;
      set => this.mIsTimedResolutionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ActionURL
    {
      get => this.mActionURL;
      set => this.mActionURL = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
