// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetAccountRequestType
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
  public class GetAccountRequestType : AbstractRequestType
  {
    private AccountHistorySelectionCodeType mAccountHistorySelection;
    private bool mAccountHistorySelectionSpecified;
    private DateTime mInvoiceDate;
    private bool mInvoiceDateSpecified;
    private DateTime mBeginDate;
    private bool mBeginDateSpecified;
    private DateTime mEndDate;
    private bool mEndDateSpecified;
    private PaginationType mPagination;
    private bool mExcludeBalance;
    private bool mExcludeBalanceSpecified;
    private bool mExcludeSummary;
    private bool mExcludeSummarySpecified;
    private bool mIncludeConversionRate;
    private bool mIncludeConversionRateSpecified;
    private AccountEntrySortTypeCodeType mAccountEntrySortType;
    private bool mAccountEntrySortTypeSpecified;
    private CurrencyCodeType mCurrency;
    private bool mCurrencySpecified;
    private string mItemID;
    private string mOrderID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public AccountHistorySelectionCodeType AccountHistorySelection
    {
      get => this.mAccountHistorySelection;
      set
      {
        this.mAccountHistorySelection = value;
        this.mAccountHistorySelectionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AccountHistorySelectionSpecified
    {
      get => this.mAccountHistorySelectionSpecified;
      set => this.mAccountHistorySelectionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime InvoiceDate
    {
      get => this.mInvoiceDate;
      set
      {
        this.mInvoiceDate = value;
        this.mInvoiceDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InvoiceDateSpecified
    {
      get => this.mInvoiceDateSpecified;
      set => this.mInvoiceDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public DateTime BeginDate
    {
      get => this.mBeginDate;
      set
      {
        this.mBeginDate = value;
        this.mBeginDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BeginDateSpecified
    {
      get => this.mBeginDateSpecified;
      set => this.mBeginDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public DateTime EndDate
    {
      get => this.mEndDate;
      set
      {
        this.mEndDate = value;
        this.mEndDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndDateSpecified
    {
      get => this.mEndDateSpecified;
      set => this.mEndDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public bool ExcludeBalance
    {
      get => this.mExcludeBalance;
      set
      {
        this.mExcludeBalance = value;
        this.mExcludeBalanceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExcludeBalanceSpecified
    {
      get => this.mExcludeBalanceSpecified;
      set => this.mExcludeBalanceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public bool ExcludeSummary
    {
      get => this.mExcludeSummary;
      set
      {
        this.mExcludeSummary = value;
        this.mExcludeSummarySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExcludeSummarySpecified
    {
      get => this.mExcludeSummarySpecified;
      set => this.mExcludeSummarySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool IncludeConversionRate
    {
      get => this.mIncludeConversionRate;
      set
      {
        this.mIncludeConversionRate = value;
        this.mIncludeConversionRateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeConversionRateSpecified
    {
      get => this.mIncludeConversionRateSpecified;
      set => this.mIncludeConversionRateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public AccountEntrySortTypeCodeType AccountEntrySortType
    {
      get => this.mAccountEntrySortType;
      set
      {
        this.mAccountEntrySortType = value;
        this.mAccountEntrySortTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AccountEntrySortTypeSpecified
    {
      get => this.mAccountEntrySortTypeSpecified;
      set => this.mAccountEntrySortTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
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
    [XmlElement(Order = 10)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public string OrderID
    {
      get => this.mOrderID;
      set => this.mOrderID = value;
    }
  }
}
