// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.OfferType
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
  public class OfferType
  {
    private BidActionCodeType mAction;
    private bool mActionSpecified;
    private CurrencyCodeType mCurrency;
    private bool mCurrencySpecified;
    private string mItemID;
    private AmountType mMaxBid;
    private OfferDiscountsType mDiscounts;
    private int mQuantity;
    private bool mQuantitySpecified;
    private bool mSecondChanceEnabled;
    private bool mSecondChanceEnabledSpecified;
    private CurrencyCodeType mSiteCurrency;
    private bool mSiteCurrencySpecified;
    private DateTime mTimeBid;
    private bool mTimeBidSpecified;
    private AmountType mHighestBid;
    private AmountType mConvertedPrice;
    private string mTransactionID;
    private UserType mUser;
    private bool mUserConsent;
    private bool mUserConsentSpecified;
    private int mBidCount;
    private bool mBidCountSpecified;
    private string mMessage;
    private string mBestOfferID;
    private AmountType mMyMaxBid;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public BidActionCodeType Action
    {
      get => this.mAction;
      set
      {
        this.mAction = value;
        this.mActionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionSpecified
    {
      get => this.mActionSpecified;
      set => this.mActionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyCodeType Currency
    {
      get => this.mCurrency;
      set
      {
        this.mCurrency = value;
        this.mCurrencySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CurrencySpecified
    {
      get => this.mCurrencySpecified;
      set => this.mCurrencySpecified = value;
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
    public AmountType MaxBid
    {
      get => this.mMaxBid;
      set => this.mMaxBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public OfferDiscountsType Discounts
    {
      get => this.mDiscounts;
      set => this.mDiscounts = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Quantity
    {
      get => this.mQuantity;
      set
      {
        this.mQuantity = value;
        this.mQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySpecified
    {
      get => this.mQuantitySpecified;
      set => this.mQuantitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SecondChanceEnabled
    {
      get => this.mSecondChanceEnabled;
      set
      {
        this.mSecondChanceEnabled = value;
        this.mSecondChanceEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SecondChanceEnabledSpecified
    {
      get => this.mSecondChanceEnabledSpecified;
      set => this.mSecondChanceEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyCodeType SiteCurrency
    {
      get => this.mSiteCurrency;
      set
      {
        this.mSiteCurrency = value;
        this.mSiteCurrencySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SiteCurrencySpecified
    {
      get => this.mSiteCurrencySpecified;
      set => this.mSiteCurrencySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime TimeBid
    {
      get => this.mTimeBid;
      set
      {
        this.mTimeBid = value;
        this.mTimeBidSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TimeBidSpecified
    {
      get => this.mTimeBidSpecified;
      set => this.mTimeBidSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType HighestBid
    {
      get => this.mHighestBid;
      set => this.mHighestBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedPrice
    {
      get => this.mConvertedPrice;
      set => this.mConvertedPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserType User
    {
      get => this.mUser;
      set => this.mUser = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UserConsent
    {
      get => this.mUserConsent;
      set
      {
        this.mUserConsent = value;
        this.mUserConsentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserConsentSpecified
    {
      get => this.mUserConsentSpecified;
      set => this.mUserConsentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidCount
    {
      get => this.mBidCount;
      set
      {
        this.mBidCount = value;
        this.mBidCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidCountSpecified
    {
      get => this.mBidCountSpecified;
      set => this.mBidCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Message
    {
      get => this.mMessage;
      set => this.mMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BestOfferID
    {
      get => this.mBestOfferID;
      set => this.mBestOfferID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MyMaxBid
    {
      get => this.mMyMaxBid;
      set => this.mMyMaxBid = value;
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
