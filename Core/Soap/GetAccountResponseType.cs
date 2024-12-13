// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetAccountResponseType
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
  public class GetAccountResponseType : AbstractResponseType
  {
    private string mAccountID;
    private AccountSummaryType mAccountSummary;
    private CurrencyCodeType mCurrency;
    private bool mCurrencySpecified;
    private AccountEntriesType mAccountEntries;
    private PaginationResultType mPaginationResult;
    private bool mHasMoreEntries;
    private bool mHasMoreEntriesSpecified;
    private int mEntriesPerPage;
    private bool mEntriesPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;

    /// <summary>
    /// 
    /// </summary>
    public string AccountID
    {
      get => this.mAccountID;
      set => this.mAccountID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AccountSummaryType AccountSummary
    {
      get => this.mAccountSummary;
      set => this.mAccountSummary = value;
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
    public AccountEntriesType AccountEntries
    {
      get => this.mAccountEntries;
      set => this.mAccountEntries = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasMoreEntries
    {
      get => this.mHasMoreEntries;
      set
      {
        this.mHasMoreEntries = value;
        this.mHasMoreEntriesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasMoreEntriesSpecified
    {
      get => this.mHasMoreEntriesSpecified;
      set => this.mHasMoreEntriesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int EntriesPerPage
    {
      get => this.mEntriesPerPage;
      set
      {
        this.mEntriesPerPage = value;
        this.mEntriesPerPageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EntriesPerPageSpecified
    {
      get => this.mEntriesPerPageSpecified;
      set => this.mEntriesPerPageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PageNumber
    {
      get => this.mPageNumber;
      set
      {
        this.mPageNumber = value;
        this.mPageNumberSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PageNumberSpecified
    {
      get => this.mPageNumberSpecified;
      set => this.mPageNumberSpecified = value;
    }
  }
}
