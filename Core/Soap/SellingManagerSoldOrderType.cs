// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerSoldOrderType
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
  public class SellingManagerSoldOrderType
  {
    private SellingManagerSoldTransactionTypeCollection mSellingManagerSoldTransaction;
    private AddressType mShippingAddress;
    private ShippingDetailsType mShippingDetails;
    private AmountType mCashOnDeliveryCost;
    private AmountType mTotalAmount;
    private int mTotalQuantity;
    private bool mTotalQuantitySpecified;
    private AmountType mItemCost;
    private VATRateTypeCollection mVATRate;
    private AmountType mNetInsuranceFee;
    private AmountType mVATInsuranceFee;
    private AmountType mVATShippingFee;
    private AmountType mNetShippingFee;
    private AmountType mNetTotalAmount;
    private AmountType mVATTotalAmount;
    private AmountType mActualShippingCost;
    private AmountType mAdjustmentAmount;
    private string mNotesToBuyer;
    private string mNotesFromBuyer;
    private string mNotesToSeller;
    private SellingManagerOrderStatusType mOrderStatus;
    private UnpaidItemStatusTypeCodeType mUnpaidItemStatus;
    private bool mUnpaidItemStatusSpecified;
    private AmountType mSalePrice;
    private int mEmailsSent;
    private bool mEmailsSentSpecified;
    private int mDaysSinceSale;
    private bool mDaysSinceSaleSpecified;
    private string mBuyerID;
    private string mBuyerEmail;
    private long mSaleRecordID;
    private bool mSaleRecordIDSpecified;
    private DateTime mCreationTime;
    private bool mCreationTimeSpecified;
    private AmountType mRefundAmount;
    private string mRefundStatus;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SellingManagerSoldTransaction")]
    public SellingManagerSoldTransactionTypeCollection SellingManagerSoldTransaction
    {
      get => this.mSellingManagerSoldTransaction;
      set => this.mSellingManagerSoldTransaction = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType ShippingAddress
    {
      get => this.mShippingAddress;
      set => this.mShippingAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingDetailsType ShippingDetails
    {
      get => this.mShippingDetails;
      set => this.mShippingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType CashOnDeliveryCost
    {
      get => this.mCashOnDeliveryCost;
      set => this.mCashOnDeliveryCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalAmount
    {
      get => this.mTotalAmount;
      set => this.mTotalAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalQuantity
    {
      get => this.mTotalQuantity;
      set
      {
        this.mTotalQuantity = value;
        this.mTotalQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalQuantitySpecified
    {
      get => this.mTotalQuantitySpecified;
      set => this.mTotalQuantitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ItemCost
    {
      get => this.mItemCost;
      set => this.mItemCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("VATRate")]
    public VATRateTypeCollection VATRate
    {
      get => this.mVATRate;
      set => this.mVATRate = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType NetInsuranceFee
    {
      get => this.mNetInsuranceFee;
      set => this.mNetInsuranceFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType VATInsuranceFee
    {
      get => this.mVATInsuranceFee;
      set => this.mVATInsuranceFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType VATShippingFee
    {
      get => this.mVATShippingFee;
      set => this.mVATShippingFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType NetShippingFee
    {
      get => this.mNetShippingFee;
      set => this.mNetShippingFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType NetTotalAmount
    {
      get => this.mNetTotalAmount;
      set => this.mNetTotalAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType VATTotalAmount
    {
      get => this.mVATTotalAmount;
      set => this.mVATTotalAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ActualShippingCost
    {
      get => this.mActualShippingCost;
      set => this.mActualShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType AdjustmentAmount
    {
      get => this.mAdjustmentAmount;
      set => this.mAdjustmentAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NotesToBuyer
    {
      get => this.mNotesToBuyer;
      set => this.mNotesToBuyer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NotesFromBuyer
    {
      get => this.mNotesFromBuyer;
      set => this.mNotesFromBuyer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NotesToSeller
    {
      get => this.mNotesToSeller;
      set => this.mNotesToSeller = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerOrderStatusType OrderStatus
    {
      get => this.mOrderStatus;
      set => this.mOrderStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UnpaidItemStatusTypeCodeType UnpaidItemStatus
    {
      get => this.mUnpaidItemStatus;
      set
      {
        this.mUnpaidItemStatus = value;
        this.mUnpaidItemStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UnpaidItemStatusSpecified
    {
      get => this.mUnpaidItemStatusSpecified;
      set => this.mUnpaidItemStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType SalePrice
    {
      get => this.mSalePrice;
      set => this.mSalePrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int EmailsSent
    {
      get => this.mEmailsSent;
      set
      {
        this.mEmailsSent = value;
        this.mEmailsSentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailsSentSpecified
    {
      get => this.mEmailsSentSpecified;
      set => this.mEmailsSentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DaysSinceSale
    {
      get => this.mDaysSinceSale;
      set
      {
        this.mDaysSinceSale = value;
        this.mDaysSinceSaleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DaysSinceSaleSpecified
    {
      get => this.mDaysSinceSaleSpecified;
      set => this.mDaysSinceSaleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerID
    {
      get => this.mBuyerID;
      set => this.mBuyerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerEmail
    {
      get => this.mBuyerEmail;
      set => this.mBuyerEmail = value;
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
    public DateTime CreationTime
    {
      get => this.mCreationTime;
      set
      {
        this.mCreationTime = value;
        this.mCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreationTimeSpecified
    {
      get => this.mCreationTimeSpecified;
      set => this.mCreationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType RefundAmount
    {
      get => this.mRefundAmount;
      set => this.mRefundAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RefundStatus
    {
      get => this.mRefundStatus;
      set => this.mRefundStatus = value;
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
