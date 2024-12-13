// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerSoldTransactionType
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
  public class SellingManagerSoldTransactionType
  {
    private string mInvoiceNumber;
    private long mTransactionID;
    private bool mTransactionIDSpecified;
    private long mSaleRecordID;
    private bool mSaleRecordIDSpecified;
    private string mItemID;
    private int mQuantitySold;
    private bool mQuantitySoldSpecified;
    private AmountType mItemPrice;
    private AmountType mSubtotalAmount;
    private string mItemTitle;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private bool mRelisted;
    private bool mRelistedSpecified;
    private int mWatchCount;
    private bool mWatchCountSpecified;
    private AmountType mStartPrice;
    private AmountType mReservePrice;
    private bool mSecondChanceOfferSent;
    private bool mSecondChanceOfferSentSpecified;
    private string mCustomLabel;
    private TransactionPlatformCodeType mSoldOn;
    private bool mSoldOnSpecified;
    private TransactionPlatformCodeTypeCollection mListedOn;
    private ShipmentType mShipment;
    private bool mCharityListing;
    private bool mCharityListingSpecified;
    private VariationType mVariation;
    private string mOrderLineItemID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string InvoiceNumber
    {
      get => this.mInvoiceNumber;
      set => this.mInvoiceNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long TransactionID
    {
      get => this.mTransactionID;
      set
      {
        this.mTransactionID = value;
        this.mTransactionIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionIDSpecified
    {
      get => this.mTransactionIDSpecified;
      set => this.mTransactionIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long SaleRecordID
    {
      get => this.mSaleRecordID;
      set
      {
        this.mSaleRecordID = value;
        this.mSaleRecordIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SaleRecordIDSpecified
    {
      get => this.mSaleRecordIDSpecified;
      set => this.mSaleRecordIDSpecified = value;
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
    public AmountType ItemPrice
    {
      get => this.mItemPrice;
      set => this.mItemPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType SubtotalAmount
    {
      get => this.mSubtotalAmount;
      set => this.mSubtotalAmount = value;
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
    public ListingTypeCodeType ListingType
    {
      get => this.mListingType;
      set
      {
        this.mListingType = value;
        this.mListingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingTypeSpecified
    {
      get => this.mListingTypeSpecified;
      set => this.mListingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Relisted
    {
      get => this.mRelisted;
      set
      {
        this.mRelisted = value;
        this.mRelistedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistedSpecified
    {
      get => this.mRelistedSpecified;
      set => this.mRelistedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int WatchCount
    {
      get => this.mWatchCount;
      set
      {
        this.mWatchCount = value;
        this.mWatchCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WatchCountSpecified
    {
      get => this.mWatchCountSpecified;
      set => this.mWatchCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType StartPrice
    {
      get => this.mStartPrice;
      set => this.mStartPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ReservePrice
    {
      get => this.mReservePrice;
      set => this.mReservePrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SecondChanceOfferSent
    {
      get => this.mSecondChanceOfferSent;
      set
      {
        this.mSecondChanceOfferSent = value;
        this.mSecondChanceOfferSentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SecondChanceOfferSentSpecified
    {
      get => this.mSecondChanceOfferSentSpecified;
      set => this.mSecondChanceOfferSentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CustomLabel
    {
      get => this.mCustomLabel;
      set => this.mCustomLabel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TransactionPlatformCodeType SoldOn
    {
      get => this.mSoldOn;
      set
      {
        this.mSoldOn = value;
        this.mSoldOnSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SoldOnSpecified
    {
      get => this.mSoldOnSpecified;
      set => this.mSoldOnSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ListedOn")]
    public TransactionPlatformCodeTypeCollection ListedOn
    {
      get => this.mListedOn;
      set => this.mListedOn = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShipmentType Shipment
    {
      get => this.mShipment;
      set => this.mShipment = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CharityListing
    {
      get => this.mCharityListing;
      set
      {
        this.mCharityListing = value;
        this.mCharityListingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityListingSpecified
    {
      get => this.mCharityListingSpecified;
      set => this.mCharityListingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationType Variation
    {
      get => this.mVariation;
      set => this.mVariation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
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
