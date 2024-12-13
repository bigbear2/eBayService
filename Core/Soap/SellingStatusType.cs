// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingStatusType
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
  public class SellingStatusType
  {
    private int mBidCount;
    private bool mBidCountSpecified;
    private AmountType mBidIncrement;
    private AmountType mConvertedCurrentPrice;
    private AmountType mCurrentPrice;
    private UserType mHighBidder;
    private int mLeadCount;
    private bool mLeadCountSpecified;
    private AmountType mMinimumToBid;
    private int mQuantitySold;
    private bool mQuantitySoldSpecified;
    private bool mReserveMet;
    private bool mReserveMetSpecified;
    private bool mSecondChanceEligible;
    private bool mSecondChanceEligibleSpecified;
    private long mBidderCount;
    private bool mBidderCountSpecified;
    private ListingStatusCodeType mListingStatus;
    private bool mListingStatusSpecified;
    private AmountType mFinalValueFee;
    private PromotionalSaleDetailsType mPromotionalSaleDetails;
    private bool mAdminEnded;
    private bool mAdminEndedSpecified;
    private bool mSoldAsBin;
    private bool mSoldAsBinSpecified;
    private int mQuantitySoldByPickupInStore;
    private bool mQuantitySoldByPickupInStoreSpecified;
    private SuggestedBidValueType mSuggestedBidValues;
    private XmlElementCollection mAny;

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
    public AmountType BidIncrement
    {
      get => this.mBidIncrement;
      set => this.mBidIncrement = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedCurrentPrice
    {
      get => this.mConvertedCurrentPrice;
      set => this.mConvertedCurrentPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType CurrentPrice
    {
      get => this.mCurrentPrice;
      set => this.mCurrentPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserType HighBidder
    {
      get => this.mHighBidder;
      set => this.mHighBidder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int LeadCount
    {
      get => this.mLeadCount;
      set
      {
        this.mLeadCount = value;
        this.mLeadCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LeadCountSpecified
    {
      get => this.mLeadCountSpecified;
      set => this.mLeadCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MinimumToBid
    {
      get => this.mMinimumToBid;
      set => this.mMinimumToBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantitySold
    {
      get => this.mQuantitySold;
      set
      {
        this.mQuantitySold = value;
        this.mQuantitySoldSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySoldSpecified
    {
      get => this.mQuantitySoldSpecified;
      set => this.mQuantitySoldSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReserveMet
    {
      get => this.mReserveMet;
      set
      {
        this.mReserveMet = value;
        this.mReserveMetSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReserveMetSpecified
    {
      get => this.mReserveMetSpecified;
      set => this.mReserveMetSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SecondChanceEligible
    {
      get => this.mSecondChanceEligible;
      set
      {
        this.mSecondChanceEligible = value;
        this.mSecondChanceEligibleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SecondChanceEligibleSpecified
    {
      get => this.mSecondChanceEligibleSpecified;
      set => this.mSecondChanceEligibleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long BidderCount
    {
      get => this.mBidderCount;
      set
      {
        this.mBidderCount = value;
        this.mBidderCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidderCountSpecified
    {
      get => this.mBidderCountSpecified;
      set => this.mBidderCountSpecified = value;
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
    public AmountType FinalValueFee
    {
      get => this.mFinalValueFee;
      set => this.mFinalValueFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionalSaleDetailsType PromotionalSaleDetails
    {
      get => this.mPromotionalSaleDetails;
      set => this.mPromotionalSaleDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AdminEnded
    {
      get => this.mAdminEnded;
      set
      {
        this.mAdminEnded = value;
        this.mAdminEndedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AdminEndedSpecified
    {
      get => this.mAdminEndedSpecified;
      set => this.mAdminEndedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SoldAsBin
    {
      get => this.mSoldAsBin;
      set
      {
        this.mSoldAsBin = value;
        this.mSoldAsBinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SoldAsBinSpecified
    {
      get => this.mSoldAsBinSpecified;
      set => this.mSoldAsBinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantitySoldByPickupInStore
    {
      get => this.mQuantitySoldByPickupInStore;
      set
      {
        this.mQuantitySoldByPickupInStore = value;
        this.mQuantitySoldByPickupInStoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySoldByPickupInStoreSpecified
    {
      get => this.mQuantitySoldByPickupInStoreSpecified;
      set => this.mQuantitySoldByPickupInStoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SuggestedBidValueType SuggestedBidValues
    {
      get => this.mSuggestedBidValues;
      set => this.mSuggestedBidValues = value;
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
