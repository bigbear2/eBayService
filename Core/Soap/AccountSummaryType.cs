// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AccountSummaryType
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
  public class AccountSummaryType
  {
    private AccountStateCodeType mAccountState;
    private bool mAccountStateSpecified;
    private AmountType mInvoicePayment;
    private AmountType mInvoiceCredit;
    private AmountType mInvoiceNewFee;
    private AdditionalAccountTypeCollection mAdditionalAccount;
    private AmountType mAmountPastDue;
    private string mBankAccountInfo;
    private DateTime mBankModifyDate;
    private bool mBankModifyDateSpecified;
    private int mBillingCycleDate;
    private bool mBillingCycleDateSpecified;
    private DateTime mCreditCardExpiration;
    private bool mCreditCardExpirationSpecified;
    private string mCreditCardInfo;
    private DateTime mCreditCardModifyDate;
    private bool mCreditCardModifyDateSpecified;
    private AmountType mCurrentBalance;
    private string mEmail;
    private AmountType mInvoiceBalance;
    private DateTime mInvoiceDate;
    private bool mInvoiceDateSpecified;
    private AmountType mLastAmountPaid;
    private DateTime mLastPaymentDate;
    private bool mLastPaymentDateSpecified;
    private bool mPastDue;
    private bool mPastDueSpecified;
    private SellerPaymentMethodCodeType mPaymentMethod;
    private bool mPaymentMethodSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AccountStateCodeType AccountState
    {
      get => this.mAccountState;
      set
      {
        this.mAccountState = value;
        this.mAccountStateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AccountStateSpecified
    {
      get => this.mAccountStateSpecified;
      set => this.mAccountStateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InvoicePayment
    {
      get => this.mInvoicePayment;
      set => this.mInvoicePayment = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InvoiceCredit
    {
      get => this.mInvoiceCredit;
      set => this.mInvoiceCredit = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InvoiceNewFee
    {
      get => this.mInvoiceNewFee;
      set => this.mInvoiceNewFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AdditionalAccount")]
    public AdditionalAccountTypeCollection AdditionalAccount
    {
      get => this.mAdditionalAccount;
      set => this.mAdditionalAccount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType AmountPastDue
    {
      get => this.mAmountPastDue;
      set => this.mAmountPastDue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BankAccountInfo
    {
      get => this.mBankAccountInfo;
      set => this.mBankAccountInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime BankModifyDate
    {
      get => this.mBankModifyDate;
      set
      {
        this.mBankModifyDate = value;
        this.mBankModifyDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BankModifyDateSpecified
    {
      get => this.mBankModifyDateSpecified;
      set => this.mBankModifyDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BillingCycleDate
    {
      get => this.mBillingCycleDate;
      set
      {
        this.mBillingCycleDate = value;
        this.mBillingCycleDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BillingCycleDateSpecified
    {
      get => this.mBillingCycleDateSpecified;
      set => this.mBillingCycleDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreditCardExpiration
    {
      get => this.mCreditCardExpiration;
      set
      {
        this.mCreditCardExpiration = value;
        this.mCreditCardExpirationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreditCardExpirationSpecified
    {
      get => this.mCreditCardExpirationSpecified;
      set => this.mCreditCardExpirationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CreditCardInfo
    {
      get => this.mCreditCardInfo;
      set => this.mCreditCardInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreditCardModifyDate
    {
      get => this.mCreditCardModifyDate;
      set
      {
        this.mCreditCardModifyDate = value;
        this.mCreditCardModifyDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreditCardModifyDateSpecified
    {
      get => this.mCreditCardModifyDateSpecified;
      set => this.mCreditCardModifyDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType CurrentBalance
    {
      get => this.mCurrentBalance;
      set => this.mCurrentBalance = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Email
    {
      get => this.mEmail;
      set => this.mEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InvoiceBalance
    {
      get => this.mInvoiceBalance;
      set => this.mInvoiceBalance = value;
    }

    /// <summary>
    /// 
    /// </summary>
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
    public AmountType LastAmountPaid
    {
      get => this.mLastAmountPaid;
      set => this.mLastAmountPaid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastPaymentDate
    {
      get => this.mLastPaymentDate;
      set
      {
        this.mLastPaymentDate = value;
        this.mLastPaymentDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastPaymentDateSpecified
    {
      get => this.mLastPaymentDateSpecified;
      set => this.mLastPaymentDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PastDue
    {
      get => this.mPastDue;
      set
      {
        this.mPastDue = value;
        this.mPastDueSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PastDueSpecified
    {
      get => this.mPastDueSpecified;
      set => this.mPastDueSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerPaymentMethodCodeType PaymentMethod
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
