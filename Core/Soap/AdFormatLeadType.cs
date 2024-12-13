// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AdFormatLeadType
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
  public class AdFormatLeadType
  {
    private string mAdditionalInformation;
    private AddressType mAddress;
    private string mBestTimeToCall;
    private string mEmail;
    private DateTime mSubmittedTime;
    private bool mSubmittedTimeSpecified;
    private string mItemID;
    private string mItemTitle;
    private string mUserID;
    private MemberMessageExchangeTypeCollection mMemberMessage;
    private AdFormatLeadStatusCodeType mStatus;
    private bool mStatusSpecified;
    private AmountType mLeadFee;
    private string mExternalEmail;
    private string mPurchaseTimeFrame;
    private string mTradeInYear;
    private string mTradeInMake;
    private string mTradeInModel;
    private bool mFinancingAnswer;
    private bool mFinancingAnswerSpecified;
    private bool mAnswer1;
    private bool mAnswer1Specified;
    private bool mAnswer2;
    private bool mAnswer2Specified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string AdditionalInformation
    {
      get => this.mAdditionalInformation;
      set => this.mAdditionalInformation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType Address
    {
      get => this.mAddress;
      set => this.mAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BestTimeToCall
    {
      get => this.mBestTimeToCall;
      set => this.mBestTimeToCall = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Email
    {
      get => this.mEmail;
      set => this.mEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime SubmittedTime
    {
      get => this.mSubmittedTime;
      set
      {
        this.mSubmittedTime = value;
        this.mSubmittedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubmittedTimeSpecified
    {
      get => this.mSubmittedTimeSpecified;
      set => this.mSubmittedTimeSpecified = value;
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
    public string ItemTitle
    {
      get => this.mItemTitle;
      set => this.mItemTitle = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("MemberMessageExchange", IsNullable = false)]
    public MemberMessageExchangeTypeCollection MemberMessage
    {
      get => this.mMemberMessage;
      set => this.mMemberMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdFormatLeadStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType LeadFee
    {
      get => this.mLeadFee;
      set => this.mLeadFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalEmail
    {
      get => this.mExternalEmail;
      set => this.mExternalEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PurchaseTimeFrame
    {
      get => this.mPurchaseTimeFrame;
      set => this.mPurchaseTimeFrame = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TradeInYear
    {
      get => this.mTradeInYear;
      set => this.mTradeInYear = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TradeInMake
    {
      get => this.mTradeInMake;
      set => this.mTradeInMake = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TradeInModel
    {
      get => this.mTradeInModel;
      set => this.mTradeInModel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FinancingAnswer
    {
      get => this.mFinancingAnswer;
      set
      {
        this.mFinancingAnswer = value;
        this.mFinancingAnswerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FinancingAnswerSpecified
    {
      get => this.mFinancingAnswerSpecified;
      set => this.mFinancingAnswerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Answer1
    {
      get => this.mAnswer1;
      set
      {
        this.mAnswer1 = value;
        this.mAnswer1Specified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Answer1Specified
    {
      get => this.mAnswer1Specified;
      set => this.mAnswer1Specified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Answer2
    {
      get => this.mAnswer2;
      set
      {
        this.mAnswer2 = value;
        this.mAnswer2Specified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Answer2Specified
    {
      get => this.mAnswer2Specified;
      set => this.mAnswer2Specified = value;
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
