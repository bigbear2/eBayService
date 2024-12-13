// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AccountEntryType
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
  public class AccountEntryType
  {
    private AccountDetailEntryCodeType mAccountDetailsEntryType;
    private bool mAccountDetailsEntryTypeSpecified;
    private string mDescription;
    private AmountType mBalance;
    private DateTime mDate;
    private bool mDateSpecified;
    private AmountType mGrossDetailAmount;
    private string mItemID;
    private string mMemo;
    private AmountType mConversionRate;
    private AmountType mNetDetailAmount;
    private string mRefNumber;
    private Decimal mVATPercent;
    private bool mVATPercentSpecified;
    private string mTitle;
    private string mOrderLineItemID;
    private string mTransactionID;
    private bool mReceivedTopRatedDiscount;
    private bool mReceivedTopRatedDiscountSpecified;
    private string mOrderId;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AccountDetailEntryCodeType AccountDetailsEntryType
    {
      get => this.mAccountDetailsEntryType;
      set
      {
        this.mAccountDetailsEntryType = value;
        this.mAccountDetailsEntryTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AccountDetailsEntryTypeSpecified
    {
      get => this.mAccountDetailsEntryTypeSpecified;
      set => this.mAccountDetailsEntryTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Description
    {
      get => this.mDescription;
      set => this.mDescription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Balance
    {
      get => this.mBalance;
      set => this.mBalance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date
    {
      get => this.mDate;
      set
      {
        this.mDate = value;
        this.mDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DateSpecified
    {
      get => this.mDateSpecified;
      set => this.mDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType GrossDetailAmount
    {
      get => this.mGrossDetailAmount;
      set => this.mGrossDetailAmount = value;
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
    public string Memo
    {
      get => this.mMemo;
      set => this.mMemo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConversionRate
    {
      get => this.mConversionRate;
      set => this.mConversionRate = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType NetDetailAmount
    {
      get => this.mNetDetailAmount;
      set => this.mNetDetailAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RefNumber
    {
      get => this.mRefNumber;
      set => this.mRefNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Decimal VATPercent
    {
      get => this.mVATPercent;
      set
      {
        this.mVATPercent = value;
        this.mVATPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VATPercentSpecified
    {
      get => this.mVATPercentSpecified;
      set => this.mVATPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Title
    {
      get => this.mTitle;
      set => this.mTitle = value;
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
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReceivedTopRatedDiscount
    {
      get => this.mReceivedTopRatedDiscount;
      set
      {
        this.mReceivedTopRatedDiscount = value;
        this.mReceivedTopRatedDiscountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReceivedTopRatedDiscountSpecified
    {
      get => this.mReceivedTopRatedDiscountSpecified;
      set => this.mReceivedTopRatedDiscountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OrderId
    {
      get => this.mOrderId;
      set => this.mOrderId = value;
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
