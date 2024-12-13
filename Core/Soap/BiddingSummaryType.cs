// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BiddingSummaryType
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
  public class BiddingSummaryType
  {
    private int mSummaryDays;
    private bool mSummaryDaysSpecified;
    private int mTotalBids;
    private bool mTotalBidsSpecified;
    private int mBidActivityWithSeller;
    private bool mBidActivityWithSellerSpecified;
    private int mBidsToUniqueSellers;
    private bool mBidsToUniqueSellersSpecified;
    private int mBidsToUniqueCategories;
    private bool mBidsToUniqueCategoriesSpecified;
    private int mBidRetractions;
    private bool mBidRetractionsSpecified;
    private ItemBidDetailsTypeCollection mItemBidDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int SummaryDays
    {
      get => this.mSummaryDays;
      set
      {
        this.mSummaryDays = value;
        this.mSummaryDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SummaryDaysSpecified
    {
      get => this.mSummaryDaysSpecified;
      set => this.mSummaryDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalBids
    {
      get => this.mTotalBids;
      set
      {
        this.mTotalBids = value;
        this.mTotalBidsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalBidsSpecified
    {
      get => this.mTotalBidsSpecified;
      set => this.mTotalBidsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidActivityWithSeller
    {
      get => this.mBidActivityWithSeller;
      set
      {
        this.mBidActivityWithSeller = value;
        this.mBidActivityWithSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidActivityWithSellerSpecified
    {
      get => this.mBidActivityWithSellerSpecified;
      set => this.mBidActivityWithSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidsToUniqueSellers
    {
      get => this.mBidsToUniqueSellers;
      set
      {
        this.mBidsToUniqueSellers = value;
        this.mBidsToUniqueSellersSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidsToUniqueSellersSpecified
    {
      get => this.mBidsToUniqueSellersSpecified;
      set => this.mBidsToUniqueSellersSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidsToUniqueCategories
    {
      get => this.mBidsToUniqueCategories;
      set
      {
        this.mBidsToUniqueCategories = value;
        this.mBidsToUniqueCategoriesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidsToUniqueCategoriesSpecified
    {
      get => this.mBidsToUniqueCategoriesSpecified;
      set => this.mBidsToUniqueCategoriesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidRetractions
    {
      get => this.mBidRetractions;
      set
      {
        this.mBidRetractions = value;
        this.mBidRetractionsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidRetractionsSpecified
    {
      get => this.mBidRetractionsSpecified;
      set => this.mBidRetractionsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemBidDetails")]
    public ItemBidDetailsTypeCollection ItemBidDetails
    {
      get => this.mItemBidDetails;
      set => this.mItemBidDetails = value;
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
