// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerOrderStatusType
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
  public class SellingManagerOrderStatusType
  {
    private CheckoutStatusCodeType mCheckoutStatus;
    private bool mCheckoutStatusSpecified;
    private SellingManagerPaidStatusCodeType mPaidStatus;
    private bool mPaidStatusSpecified;
    private SellingManagerShippedStatusCodeType mShippedStatus;
    private bool mShippedStatusSpecified;
    private PaymentStatusCodeType meBayPaymentStatus;
    private bool meBayPaymentStatusSpecified;
    private string mPayPalTransactionID;
    private BuyerPaymentMethodCodeType mPaymentMethodUsed;
    private bool mPaymentMethodUsedSpecified;
    private CommentTypeCodeType mFeedbackReceived;
    private bool mFeedbackReceivedSpecified;
    private bool mFeedbackSent;
    private bool mFeedbackSentSpecified;
    private int mTotalEmailsSent;
    private bool mTotalEmailsSentSpecified;
    private PaymentHoldStatusCodeType mPaymentHoldStatus;
    private bool mPaymentHoldStatusSpecified;
    private string mSellerInvoiceNumber;
    private DateTime mShippedTime;
    private bool mShippedTimeSpecified;
    private DateTime mPaidTime;
    private bool mPaidTimeSpecified;
    private DateTime mLastEmailSentTime;
    private bool mLastEmailSentTimeSpecified;
    private DateTime mSellerInvoiceTime;
    private bool mSellerInvoiceTimeSpecified;
    private bool mIntegratedMerchantCreditCardEnabled;
    private bool mIntegratedMerchantCreditCardEnabledSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public CheckoutStatusCodeType CheckoutStatus
    {
      get => this.mCheckoutStatus;
      set
      {
        this.mCheckoutStatus = value;
        this.mCheckoutStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CheckoutStatusSpecified
    {
      get => this.mCheckoutStatusSpecified;
      set => this.mCheckoutStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerPaidStatusCodeType PaidStatus
    {
      get => this.mPaidStatus;
      set
      {
        this.mPaidStatus = value;
        this.mPaidStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaidStatusSpecified
    {
      get => this.mPaidStatusSpecified;
      set => this.mPaidStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerShippedStatusCodeType ShippedStatus
    {
      get => this.mShippedStatus;
      set
      {
        this.mShippedStatus = value;
        this.mShippedStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippedStatusSpecified
    {
      get => this.mShippedStatusSpecified;
      set => this.mShippedStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentStatusCodeType eBayPaymentStatus
    {
      get => this.meBayPaymentStatus;
      set
      {
        this.meBayPaymentStatus = value;
        this.meBayPaymentStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayPaymentStatusSpecified
    {
      get => this.meBayPaymentStatusSpecified;
      set => this.meBayPaymentStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PayPalTransactionID
    {
      get => this.mPayPalTransactionID;
      set => this.mPayPalTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerPaymentMethodCodeType PaymentMethodUsed
    {
      get => this.mPaymentMethodUsed;
      set
      {
        this.mPaymentMethodUsed = value;
        this.mPaymentMethodUsedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentMethodUsedSpecified
    {
      get => this.mPaymentMethodUsedSpecified;
      set => this.mPaymentMethodUsedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CommentTypeCodeType FeedbackReceived
    {
      get => this.mFeedbackReceived;
      set
      {
        this.mFeedbackReceived = value;
        this.mFeedbackReceivedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackReceivedSpecified
    {
      get => this.mFeedbackReceivedSpecified;
      set => this.mFeedbackReceivedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FeedbackSent
    {
      get => this.mFeedbackSent;
      set
      {
        this.mFeedbackSent = value;
        this.mFeedbackSentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackSentSpecified
    {
      get => this.mFeedbackSentSpecified;
      set => this.mFeedbackSentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalEmailsSent
    {
      get => this.mTotalEmailsSent;
      set
      {
        this.mTotalEmailsSent = value;
        this.mTotalEmailsSentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalEmailsSentSpecified
    {
      get => this.mTotalEmailsSentSpecified;
      set => this.mTotalEmailsSentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentHoldStatusCodeType PaymentHoldStatus
    {
      get => this.mPaymentHoldStatus;
      set
      {
        this.mPaymentHoldStatus = value;
        this.mPaymentHoldStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentHoldStatusSpecified
    {
      get => this.mPaymentHoldStatusSpecified;
      set => this.mPaymentHoldStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerInvoiceNumber
    {
      get => this.mSellerInvoiceNumber;
      set => this.mSellerInvoiceNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ShippedTime
    {
      get => this.mShippedTime;
      set
      {
        this.mShippedTime = value;
        this.mShippedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippedTimeSpecified
    {
      get => this.mShippedTimeSpecified;
      set => this.mShippedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PaidTime
    {
      get => this.mPaidTime;
      set
      {
        this.mPaidTime = value;
        this.mPaidTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaidTimeSpecified
    {
      get => this.mPaidTimeSpecified;
      set => this.mPaidTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastEmailSentTime
    {
      get => this.mLastEmailSentTime;
      set
      {
        this.mLastEmailSentTime = value;
        this.mLastEmailSentTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastEmailSentTimeSpecified
    {
      get => this.mLastEmailSentTimeSpecified;
      set => this.mLastEmailSentTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime SellerInvoiceTime
    {
      get => this.mSellerInvoiceTime;
      set
      {
        this.mSellerInvoiceTime = value;
        this.mSellerInvoiceTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerInvoiceTimeSpecified
    {
      get => this.mSellerInvoiceTimeSpecified;
      set => this.mSellerInvoiceTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IntegratedMerchantCreditCardEnabled
    {
      get => this.mIntegratedMerchantCreditCardEnabled;
      set
      {
        this.mIntegratedMerchantCreditCardEnabled = value;
        this.mIntegratedMerchantCreditCardEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IntegratedMerchantCreditCardEnabledSpecified
    {
      get => this.mIntegratedMerchantCreditCardEnabledSpecified;
      set => this.mIntegratedMerchantCreditCardEnabledSpecified = value;
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
