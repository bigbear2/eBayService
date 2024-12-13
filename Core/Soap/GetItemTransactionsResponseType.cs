// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetItemTransactionsResponseType
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
  public class GetItemTransactionsResponseType : AbstractResponseType
  {
    private PaginationResultType mPaginationResult;
    private bool mHasMoreTransactions;
    private bool mHasMoreTransactionsSpecified;
    private int mTransactionsPerPage;
    private bool mTransactionsPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private int mReturnedTransactionCountActual;
    private bool mReturnedTransactionCountActualSpecified;
    private ItemType mItem;
    private TransactionTypeCollection mTransactionArray;
    private bool mPayPalPreferred;
    private bool mPayPalPreferredSpecified;

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
    public bool HasMoreTransactions
    {
      get => this.mHasMoreTransactions;
      set
      {
        this.mHasMoreTransactions = value;
        this.mHasMoreTransactionsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasMoreTransactionsSpecified
    {
      get => this.mHasMoreTransactionsSpecified;
      set => this.mHasMoreTransactionsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TransactionsPerPage
    {
      get => this.mTransactionsPerPage;
      set
      {
        this.mTransactionsPerPage = value;
        this.mTransactionsPerPageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionsPerPageSpecified
    {
      get => this.mTransactionsPerPageSpecified;
      set => this.mTransactionsPerPageSpecified = value;
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

    /// <summary>
    /// 
    /// </summary>
    public int ReturnedTransactionCountActual
    {
      get => this.mReturnedTransactionCountActual;
      set
      {
        this.mReturnedTransactionCountActual = value;
        this.mReturnedTransactionCountActualSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnedTransactionCountActualSpecified
    {
      get => this.mReturnedTransactionCountActualSpecified;
      set => this.mReturnedTransactionCountActualSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemType Item
    {
      get => this.mItem;
      set => this.mItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Transaction", IsNullable = false)]
    public TransactionTypeCollection TransactionArray
    {
      get => this.mTransactionArray;
      set => this.mTransactionArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalPreferred
    {
      get => this.mPayPalPreferred;
      set
      {
        this.mPayPalPreferred = value;
        this.mPayPalPreferredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalPreferredSpecified
    {
      get => this.mPayPalPreferredSpecified;
      set => this.mPayPalPreferredSpecified = value;
    }
  }
}
