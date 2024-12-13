// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingDetailsType
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
  public class ListingDetailsType
  {
    private bool mAdult;
    private bool mAdultSpecified;
    private bool mBindingAuction;
    private bool mBindingAuctionSpecified;
    private bool mCheckoutEnabled;
    private bool mCheckoutEnabledSpecified;
    private AmountType mConvertedBuyItNowPrice;
    private AmountType mConvertedStartPrice;
    private AmountType mConvertedReservePrice;
    private bool mHasReservePrice;
    private bool mHasReservePriceSpecified;
    private string mRelistedItemID;
    private string mSecondChanceOriginalItemID;
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private string mViewItemURL;
    private bool mHasUnansweredQuestions;
    private bool mHasUnansweredQuestionsSpecified;
    private bool mHasPublicMessages;
    private bool mHasPublicMessagesSpecified;
    private bool mBuyItNowAvailable;
    private bool mBuyItNowAvailableSpecified;
    private SellerBusinessCodeType mSellerBusinessType;
    private bool mSellerBusinessTypeSpecified;
    private AmountType mMinimumBestOfferPrice;
    private string mMinimumBestOfferMessage;
    private string mLocalListingDistance;
    private string mTCROriginalItemID;
    private string mViewItemURLForNaturalSearch;
    private bool mPayPerLeadEnabled;
    private bool mPayPerLeadEnabledSpecified;
    private AmountType mBestOfferAutoAcceptPrice;
    private EndReasonCodeType mEndingReason;
    private bool mEndingReasonSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool Adult
    {
      get => this.mAdult;
      set
      {
        this.mAdult = value;
        this.mAdultSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AdultSpecified
    {
      get => this.mAdultSpecified;
      set => this.mAdultSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BindingAuction
    {
      get => this.mBindingAuction;
      set
      {
        this.mBindingAuction = value;
        this.mBindingAuctionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BindingAuctionSpecified
    {
      get => this.mBindingAuctionSpecified;
      set => this.mBindingAuctionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CheckoutEnabled
    {
      get => this.mCheckoutEnabled;
      set
      {
        this.mCheckoutEnabled = value;
        this.mCheckoutEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CheckoutEnabledSpecified
    {
      get => this.mCheckoutEnabledSpecified;
      set => this.mCheckoutEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedBuyItNowPrice
    {
      get => this.mConvertedBuyItNowPrice;
      set => this.mConvertedBuyItNowPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedStartPrice
    {
      get => this.mConvertedStartPrice;
      set => this.mConvertedStartPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedReservePrice
    {
      get => this.mConvertedReservePrice;
      set => this.mConvertedReservePrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasReservePrice
    {
      get => this.mHasReservePrice;
      set
      {
        this.mHasReservePrice = value;
        this.mHasReservePriceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasReservePriceSpecified
    {
      get => this.mHasReservePriceSpecified;
      set => this.mHasReservePriceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RelistedItemID
    {
      get => this.mRelistedItemID;
      set => this.mRelistedItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SecondChanceOriginalItemID
    {
      get => this.mSecondChanceOriginalItemID;
      set => this.mSecondChanceOriginalItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime StartTime
    {
      get => this.mStartTime;
      set
      {
        this.mStartTime = value;
        this.mStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeSpecified
    {
      get => this.mStartTimeSpecified;
      set => this.mStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndTime
    {
      get => this.mEndTime;
      set
      {
        this.mEndTime = value;
        this.mEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeSpecified
    {
      get => this.mEndTimeSpecified;
      set => this.mEndTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ViewItemURL
    {
      get => this.mViewItemURL;
      set => this.mViewItemURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasUnansweredQuestions
    {
      get => this.mHasUnansweredQuestions;
      set
      {
        this.mHasUnansweredQuestions = value;
        this.mHasUnansweredQuestionsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasUnansweredQuestionsSpecified
    {
      get => this.mHasUnansweredQuestionsSpecified;
      set => this.mHasUnansweredQuestionsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasPublicMessages
    {
      get => this.mHasPublicMessages;
      set
      {
        this.mHasPublicMessages = value;
        this.mHasPublicMessagesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasPublicMessagesSpecified
    {
      get => this.mHasPublicMessagesSpecified;
      set => this.mHasPublicMessagesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BuyItNowAvailable
    {
      get => this.mBuyItNowAvailable;
      set
      {
        this.mBuyItNowAvailable = value;
        this.mBuyItNowAvailableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyItNowAvailableSpecified
    {
      get => this.mBuyItNowAvailableSpecified;
      set => this.mBuyItNowAvailableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerBusinessCodeType SellerBusinessType
    {
      get => this.mSellerBusinessType;
      set
      {
        this.mSellerBusinessType = value;
        this.mSellerBusinessTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerBusinessTypeSpecified
    {
      get => this.mSellerBusinessTypeSpecified;
      set => this.mSellerBusinessTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MinimumBestOfferPrice
    {
      get => this.mMinimumBestOfferPrice;
      set => this.mMinimumBestOfferPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MinimumBestOfferMessage
    {
      get => this.mMinimumBestOfferMessage;
      set => this.mMinimumBestOfferMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LocalListingDistance
    {
      get => this.mLocalListingDistance;
      set => this.mLocalListingDistance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TCROriginalItemID
    {
      get => this.mTCROriginalItemID;
      set => this.mTCROriginalItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ViewItemURLForNaturalSearch
    {
      get => this.mViewItemURLForNaturalSearch;
      set => this.mViewItemURLForNaturalSearch = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPerLeadEnabled
    {
      get => this.mPayPerLeadEnabled;
      set
      {
        this.mPayPerLeadEnabled = value;
        this.mPayPerLeadEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPerLeadEnabledSpecified
    {
      get => this.mPayPerLeadEnabledSpecified;
      set => this.mPayPerLeadEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType BestOfferAutoAcceptPrice
    {
      get => this.mBestOfferAutoAcceptPrice;
      set => this.mBestOfferAutoAcceptPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EndReasonCodeType EndingReason
    {
      get => this.mEndingReason;
      set
      {
        this.mEndingReason = value;
        this.mEndingReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndingReasonSpecified
    {
      get => this.mEndingReasonSpecified;
      set => this.mEndingReasonSpecified = value;
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
