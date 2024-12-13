// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TransactionStatusType
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
  public class TransactionStatusType
  {
    private PaymentStatusCodeType meBayPaymentStatus;
    private bool meBayPaymentStatusSpecified;
    private CheckoutStatusCodeType mCheckoutStatus;
    private bool mCheckoutStatusSpecified;
    private DateTime mLastTimeModified;
    private bool mLastTimeModifiedSpecified;
    private BuyerPaymentMethodCodeType mPaymentMethodUsed;
    private bool mPaymentMethodUsedSpecified;
    private CompleteStatusCodeType mCompleteStatus;
    private bool mCompleteStatusSpecified;
    private bool mBuyerSelectedShipping;
    private bool mBuyerSelectedShippingSpecified;
    private PaymentHoldStatusCodeType mPaymentHoldStatus;
    private bool mPaymentHoldStatusSpecified;
    private bool mIntegratedMerchantCreditCardEnabled;
    private bool mIntegratedMerchantCreditCardEnabledSpecified;
    private eBayPaymentMismatchDetailsType meBayPaymentMismatchDetails;
    private InquiryStatusCodeType mInquiryStatus;
    private bool mInquiryStatusSpecified;
    private ReturnStatusCodeType mReturnStatus;
    private bool mReturnStatusSpecified;
    private BuyerPaymentInstrumentCodeType mPaymentInstrument;
    private bool mPaymentInstrumentSpecified;
    private DigitalStatusCodeType mDigitalStatus;
    private bool mDigitalStatusSpecified;
    private CancelStatusCodeType mCancelStatus;
    private bool mCancelStatusSpecified;
    private XmlElementCollection mAny;

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
    public DateTime LastTimeModified
    {
      get => this.mLastTimeModified;
      set
      {
        this.mLastTimeModified = value;
        this.mLastTimeModifiedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastTimeModifiedSpecified
    {
      get => this.mLastTimeModifiedSpecified;
      set => this.mLastTimeModifiedSpecified = value;
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
    public CompleteStatusCodeType CompleteStatus
    {
      get => this.mCompleteStatus;
      set
      {
        this.mCompleteStatus = value;
        this.mCompleteStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CompleteStatusSpecified
    {
      get => this.mCompleteStatusSpecified;
      set => this.mCompleteStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BuyerSelectedShipping
    {
      get => this.mBuyerSelectedShipping;
      set
      {
        this.mBuyerSelectedShipping = value;
        this.mBuyerSelectedShippingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyerSelectedShippingSpecified
    {
      get => this.mBuyerSelectedShippingSpecified;
      set => this.mBuyerSelectedShippingSpecified = value;
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
    public eBayPaymentMismatchDetailsType eBayPaymentMismatchDetails
    {
      get => this.meBayPaymentMismatchDetails;
      set => this.meBayPaymentMismatchDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InquiryStatusCodeType InquiryStatus
    {
      get => this.mInquiryStatus;
      set
      {
        this.mInquiryStatus = value;
        this.mInquiryStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InquiryStatusSpecified
    {
      get => this.mInquiryStatusSpecified;
      set => this.mInquiryStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ReturnStatusCodeType ReturnStatus
    {
      get => this.mReturnStatus;
      set
      {
        this.mReturnStatus = value;
        this.mReturnStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnStatusSpecified
    {
      get => this.mReturnStatusSpecified;
      set => this.mReturnStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerPaymentInstrumentCodeType PaymentInstrument
    {
      get => this.mPaymentInstrument;
      set
      {
        this.mPaymentInstrument = value;
        this.mPaymentInstrumentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentInstrumentSpecified
    {
      get => this.mPaymentInstrumentSpecified;
      set => this.mPaymentInstrumentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DigitalStatusCodeType DigitalStatus
    {
      get => this.mDigitalStatus;
      set
      {
        this.mDigitalStatus = value;
        this.mDigitalStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DigitalStatusSpecified
    {
      get => this.mDigitalStatusSpecified;
      set => this.mDigitalStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CancelStatusCodeType CancelStatus
    {
      get => this.mCancelStatus;
      set
      {
        this.mCancelStatus = value;
        this.mCancelStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CancelStatusSpecified
    {
      get => this.mCancelStatusSpecified;
      set => this.mCancelStatusSpecified = value;
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
