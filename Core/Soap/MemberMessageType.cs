// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MemberMessageType
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
  public class MemberMessageType
  {
    private MessageTypeCodeType mMessageType;
    private bool mMessageTypeSpecified;
    private QuestionTypeCodeType mQuestionType;
    private bool mQuestionTypeSpecified;
    private bool mEmailCopyToSender;
    private bool mEmailCopyToSenderSpecified;
    private bool mHideSendersEmailAddress;
    private bool mHideSendersEmailAddressSpecified;
    private bool mDisplayToPublic;
    private bool mDisplayToPublicSpecified;
    private string mSenderID;
    private string mSenderEmail;
    private StringCollection mRecipientID;
    private string mSubject;
    private string mBody;
    private string mMessageID;
    private string mParentMessageID;
    private MessageMediaTypeCollection mMessageMedia;
    private XmlElementCollection mAny;

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
    public bool EmailCopyToSender
    {
      get => this.mEmailCopyToSender;
      set
      {
        this.mEmailCopyToSender = value;
        this.mEmailCopyToSenderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailCopyToSenderSpecified
    {
      get => this.mEmailCopyToSenderSpecified;
      set => this.mEmailCopyToSenderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HideSendersEmailAddress
    {
      get => this.mHideSendersEmailAddress;
      set
      {
        this.mHideSendersEmailAddress = value;
        this.mHideSendersEmailAddressSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HideSendersEmailAddressSpecified
    {
      get => this.mHideSendersEmailAddressSpecified;
      set => this.mHideSendersEmailAddressSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
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
    public string SenderID
    {
      get => this.mSenderID;
      set => this.mSenderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SenderEmail
    {
      get => this.mSenderEmail;
      set => this.mSenderEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RecipientID")]
    public StringCollection RecipientID
    {
      get => this.mRecipientID;
      set => this.mRecipientID = value;
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
    public string Body
    {
      get => this.mBody;
      set => this.mBody = value;
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
    public string ParentMessageID
    {
      get => this.mParentMessageID;
      set => this.mParentMessageID = value;
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
