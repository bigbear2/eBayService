// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyeBaySellingSummaryType
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
  public class MyeBaySellingSummaryType
  {
    private int mActiveAuctionCount;
    private bool mActiveAuctionCountSpecified;
    private int mAuctionSellingCount;
    private bool mAuctionSellingCountSpecified;
    private int mAuctionBidCount;
    private bool mAuctionBidCountSpecified;
    private AmountType mTotalAuctionSellingValue;
    private int mTotalSoldCount;
    private bool mTotalSoldCountSpecified;
    private AmountType mTotalSoldValue;
    private int mSoldDurationInDays;
    private bool mSoldDurationInDaysSpecified;
    private int mClassifiedAdCount;
    private bool mClassifiedAdCountSpecified;
    private int mTotalLeadCount;
    private bool mTotalLeadCountSpecified;
    private int mClassifiedAdOfferCount;
    private bool mClassifiedAdOfferCountSpecified;
    private int mTotalListingsWithLeads;
    private bool mTotalListingsWithLeadsSpecified;
    private long mQuantityLimitRemaining;
    private bool mQuantityLimitRemainingSpecified;
    private AmountType mAmountLimitRemaining;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int ActiveAuctionCount
    {
      get => this.mActiveAuctionCount;
      set
      {
        this.mActiveAuctionCount = value;
        this.mActiveAuctionCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActiveAuctionCountSpecified
    {
      get => this.mActiveAuctionCountSpecified;
      set => this.mActiveAuctionCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int AuctionSellingCount
    {
      get => this.mAuctionSellingCount;
      set
      {
        this.mAuctionSellingCount = value;
        this.mAuctionSellingCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AuctionSellingCountSpecified
    {
      get => this.mAuctionSellingCountSpecified;
      set => this.mAuctionSellingCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int AuctionBidCount
    {
      get => this.mAuctionBidCount;
      set
      {
        this.mAuctionBidCount = value;
        this.mAuctionBidCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AuctionBidCountSpecified
    {
      get => this.mAuctionBidCountSpecified;
      set => this.mAuctionBidCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalAuctionSellingValue
    {
      get => this.mTotalAuctionSellingValue;
      set => this.mTotalAuctionSellingValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalSoldCount
    {
      get => this.mTotalSoldCount;
      set
      {
        this.mTotalSoldCount = value;
        this.mTotalSoldCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalSoldCountSpecified
    {
      get => this.mTotalSoldCountSpecified;
      set => this.mTotalSoldCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalSoldValue
    {
      get => this.mTotalSoldValue;
      set => this.mTotalSoldValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int SoldDurationInDays
    {
      get => this.mSoldDurationInDays;
      set
      {
        this.mSoldDurationInDays = value;
        this.mSoldDurationInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SoldDurationInDaysSpecified
    {
      get => this.mSoldDurationInDaysSpecified;
      set => this.mSoldDurationInDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ClassifiedAdCount
    {
      get => this.mClassifiedAdCount;
      set
      {
        this.mClassifiedAdCount = value;
        this.mClassifiedAdCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdCountSpecified
    {
      get => this.mClassifiedAdCountSpecified;
      set => this.mClassifiedAdCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalLeadCount
    {
      get => this.mTotalLeadCount;
      set
      {
        this.mTotalLeadCount = value;
        this.mTotalLeadCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalLeadCountSpecified
    {
      get => this.mTotalLeadCountSpecified;
      set => this.mTotalLeadCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ClassifiedAdOfferCount
    {
      get => this.mClassifiedAdOfferCount;
      set
      {
        this.mClassifiedAdOfferCount = value;
        this.mClassifiedAdOfferCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdOfferCountSpecified
    {
      get => this.mClassifiedAdOfferCountSpecified;
      set => this.mClassifiedAdOfferCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalListingsWithLeads
    {
      get => this.mTotalListingsWithLeads;
      set
      {
        this.mTotalListingsWithLeads = value;
        this.mTotalListingsWithLeadsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalListingsWithLeadsSpecified
    {
      get => this.mTotalListingsWithLeadsSpecified;
      set => this.mTotalListingsWithLeadsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long QuantityLimitRemaining
    {
      get => this.mQuantityLimitRemaining;
      set
      {
        this.mQuantityLimitRemaining = value;
        this.mQuantityLimitRemainingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityLimitRemainingSpecified
    {
      get => this.mQuantityLimitRemainingSpecified;
      set => this.mQuantityLimitRemainingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType AmountLimitRemaining
    {
      get => this.mAmountLimitRemaining;
      set => this.mAmountLimitRemaining = value;
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
