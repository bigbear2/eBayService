// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyeBayFavoriteSearchType
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
  public class MyeBayFavoriteSearchType
  {
    private string mSearchName;
    private string mSearchQuery;
    private string mQueryKeywords;
    private string mCategoryID;
    private SimpleItemSortCodeType mItemSort;
    private bool mItemSortSpecified;
    private SortOrderCodeType mSortOrder;
    private bool mSortOrderSpecified;
    private DateTime mEndTimeFrom;
    private bool mEndTimeFromSpecified;
    private DateTime mEndTimeTo;
    private bool mEndTimeToSpecified;
    private int mMaxDistance;
    private bool mMaxDistanceSpecified;
    private string mPostalCode;
    private ItemTypeCodeType mItemType;
    private bool mItemTypeSpecified;
    private AmountType mPriceMax;
    private AmountType mPriceMin;
    private CurrencyCodeType mCurrency;
    private bool mCurrencySpecified;
    private int mBidCountMax;
    private bool mBidCountMaxSpecified;
    private int mBidCountMin;
    private bool mBidCountMinSpecified;
    private SearchFlagCodeTypeCollection mSearchFlag;
    private PaymentMethodSearchCodeType mPaymentMethod;
    private bool mPaymentMethodSpecified;
    private PreferredLocationCodeType mPreferredLocation;
    private bool mPreferredLocationSpecified;
    private StringCollection mSellerID;
    private StringCollection mSellerIDExclude;
    private CountryCodeType mItemsAvailableTo;
    private bool mItemsAvailableToSpecified;
    private CountryCodeType mItemsLocatedIn;
    private bool mItemsLocatedInSpecified;
    private SellerBusinessCodeType mSellerBusinessType;
    private bool mSellerBusinessTypeSpecified;
    private ItemConditionCodeType mCondition;
    private bool mConditionSpecified;
    private int mQuantity;
    private bool mQuantitySpecified;
    private QuantityOperatorCodeType mQuantityOperator;
    private bool mQuantityOperatorSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string SearchName
    {
      get => this.mSearchName;
      set => this.mSearchName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SearchQuery
    {
      get => this.mSearchQuery;
      set => this.mSearchQuery = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string QueryKeywords
    {
      get => this.mQueryKeywords;
      set => this.mQueryKeywords = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SimpleItemSortCodeType ItemSort
    {
      get => this.mItemSort;
      set
      {
        this.mItemSort = value;
        this.mItemSortSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemSortSpecified
    {
      get => this.mItemSortSpecified;
      set => this.mItemSortSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SortOrderCodeType SortOrder
    {
      get => this.mSortOrder;
      set
      {
        this.mSortOrder = value;
        this.mSortOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortOrderSpecified
    {
      get => this.mSortOrderSpecified;
      set => this.mSortOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndTimeFrom
    {
      get => this.mEndTimeFrom;
      set
      {
        this.mEndTimeFrom = value;
        this.mEndTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeFromSpecified
    {
      get => this.mEndTimeFromSpecified;
      set => this.mEndTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndTimeTo
    {
      get => this.mEndTimeTo;
      set
      {
        this.mEndTimeTo = value;
        this.mEndTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeToSpecified
    {
      get => this.mEndTimeToSpecified;
      set => this.mEndTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxDistance
    {
      get => this.mMaxDistance;
      set
      {
        this.mMaxDistance = value;
        this.mMaxDistanceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxDistanceSpecified
    {
      get => this.mMaxDistanceSpecified;
      set => this.mMaxDistanceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PostalCode
    {
      get => this.mPostalCode;
      set => this.mPostalCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemTypeCodeType ItemType
    {
      get => this.mItemType;
      set
      {
        this.mItemType = value;
        this.mItemTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemTypeSpecified
    {
      get => this.mItemTypeSpecified;
      set => this.mItemTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType PriceMax
    {
      get => this.mPriceMax;
      set => this.mPriceMax = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType PriceMin
    {
      get => this.mPriceMin;
      set => this.mPriceMin = value;
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
    public int BidCountMax
    {
      get => this.mBidCountMax;
      set
      {
        this.mBidCountMax = value;
        this.mBidCountMaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidCountMaxSpecified
    {
      get => this.mBidCountMaxSpecified;
      set => this.mBidCountMaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidCountMin
    {
      get => this.mBidCountMin;
      set
      {
        this.mBidCountMin = value;
        this.mBidCountMinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidCountMinSpecified
    {
      get => this.mBidCountMinSpecified;
      set => this.mBidCountMinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SearchFlag")]
    public SearchFlagCodeTypeCollection SearchFlag
    {
      get => this.mSearchFlag;
      set => this.mSearchFlag = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentMethodSearchCodeType PaymentMethod
    {
      get => this.mPaymentMethod;
      set
      {
        this.mPaymentMethod = value;
        this.mPaymentMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentMethodSpecified
    {
      get => this.mPaymentMethodSpecified;
      set => this.mPaymentMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PreferredLocationCodeType PreferredLocation
    {
      get => this.mPreferredLocation;
      set
      {
        this.mPreferredLocation = value;
        this.mPreferredLocationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PreferredLocationSpecified
    {
      get => this.mPreferredLocationSpecified;
      set => this.mPreferredLocationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SellerID")]
    public StringCollection SellerID
    {
      get => this.mSellerID;
      set => this.mSellerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SellerIDExclude")]
    public StringCollection SellerIDExclude
    {
      get => this.mSellerIDExclude;
      set => this.mSellerIDExclude = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryCodeType ItemsAvailableTo
    {
      get => this.mItemsAvailableTo;
      set
      {
        this.mItemsAvailableTo = value;
        this.mItemsAvailableToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemsAvailableToSpecified
    {
      get => this.mItemsAvailableToSpecified;
      set => this.mItemsAvailableToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryCodeType ItemsLocatedIn
    {
      get => this.mItemsLocatedIn;
      set
      {
        this.mItemsLocatedIn = value;
        this.mItemsLocatedInSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemsLocatedInSpecified
    {
      get => this.mItemsLocatedInSpecified;
      set => this.mItemsLocatedInSpecified = value;
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
    public ItemConditionCodeType Condition
    {
      get => this.mCondition;
      set
      {
        this.mCondition = value;
        this.mConditionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ConditionSpecified
    {
      get => this.mConditionSpecified;
      set => this.mConditionSpecified = value;
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
    public QuantityOperatorCodeType QuantityOperator
    {
      get => this.mQuantityOperator;
      set
      {
        this.mQuantityOperator = value;
        this.mQuantityOperatorSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityOperatorSpecified
    {
      get => this.mQuantityOperatorSpecified;
      set => this.mQuantityOperatorSpecified = value;
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
