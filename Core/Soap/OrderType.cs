// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.OrderType
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
  public class OrderType
  {
    private string mOrderID;
    private OrderStatusCodeType mOrderStatus;
    private bool mOrderStatusSpecified;
    private AmountType mAdjustmentAmount;
    private AmountType mAmountPaid;
    private AmountType mAmountSaved;
    private CheckoutStatusType mCheckoutStatus;
    private ShippingDetailsType mShippingDetails;
    private TradingRoleCodeType mCreatingUserRole;
    private bool mCreatingUserRoleSpecified;
    private DateTime mCreatedTime;
    private bool mCreatedTimeSpecified;
    private BuyerPaymentMethodCodeTypeCollection mPaymentMethods;
    private string mSellerEmail;
    private AddressType mShippingAddress;
    private ShippingServiceOptionsType mShippingServiceSelected;
    private AmountType mSubtotal;
    private AmountType mTotal;
    private ExternalTransactionTypeCollection mExternalTransaction;
    private TransactionTypeCollection mTransactionArray;
    private string mBuyerUserID;
    private DateTime mPaidTime;
    private bool mPaidTimeSpecified;
    private DateTime mShippedTime;
    private bool mShippedTimeSpecified;
    private bool mIntegratedMerchantCreditCardEnabled;
    private bool mIntegratedMerchantCreditCardEnabledSpecified;
    private bool mBundlePurchase;
    private bool mBundlePurchaseSpecified;
    private string mBuyerCheckoutMessage;
    private string mEIASToken;
    private PaymentHoldStatusCodeType mPaymentHoldStatus;
    private bool mPaymentHoldStatusSpecified;
    private PaymentHoldDetailType mPaymentHoldDetails;
    private AmountType mRefundAmount;
    private string mRefundStatus;
    private RefundTypeCollection mRefundArray;
    private bool mIsMultiLegShipping;
    private bool mIsMultiLegShippingSpecified;
    private MultiLegShippingDetailsType mMultiLegShippingDetails;
    private PaymentsInformationType mMonetaryDetails;
    private PickupDetailsType mPickupDetails;
    private PickupMethodSelectedType mPickupMethodSelected;
    private string mSellerUserID;
    private string mSellerEIASToken;
    private string mCancelReason;
    private CancelStatusCodeType mCancelStatus;
    private bool mCancelStatusSpecified;
    private string mCancelReasonDetails;
    private AmountType mShippingConvenienceCharge;
    private CancelDetailTypeCollection mCancelDetail;
    private string mLogisticsPlanType;
    private TaxIdentifierTypeCollection mBuyerTaxIdentifier;
    private BuyerPackageEnclosuresType mBuyerPackageEnclosures;
    private string mExtendedOrderID;
    private bool mContainseBayPlusTransaction;
    private bool mContainseBayPlusTransactionSpecified;
    private bool meBayCollectAndRemitTax;
    private bool meBayCollectAndRemitTaxSpecified;
    private long mOrderLineItemCount;
    private bool mOrderLineItemCountSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string OrderID
    {
      get => this.mOrderID;
      set => this.mOrderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public OrderStatusCodeType OrderStatus
    {
      get => this.mOrderStatus;
      set
      {
        this.mOrderStatus = value;
        this.mOrderStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderStatusSpecified
    {
      get => this.mOrderStatusSpecified;
      set => this.mOrderStatusSpecified = value;
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
    public AmountType AmountPaid
    {
      get => this.mAmountPaid;
      set => this.mAmountPaid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType AmountSaved
    {
      get => this.mAmountSaved;
      set => this.mAmountSaved = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CheckoutStatusType CheckoutStatus
    {
      get => this.mCheckoutStatus;
      set => this.mCheckoutStatus = value;
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
    public TradingRoleCodeType CreatingUserRole
    {
      get => this.mCreatingUserRole;
      set
      {
        this.mCreatingUserRole = value;
        this.mCreatingUserRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreatingUserRoleSpecified
    {
      get => this.mCreatingUserRoleSpecified;
      set => this.mCreatingUserRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreatedTime
    {
      get => this.mCreatedTime;
      set
      {
        this.mCreatedTime = value;
        this.mCreatedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreatedTimeSpecified
    {
      get => this.mCreatedTimeSpecified;
      set => this.mCreatedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PaymentMethods")]
    public BuyerPaymentMethodCodeTypeCollection PaymentMethods
    {
      get => this.mPaymentMethods;
      set => this.mPaymentMethods = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerEmail
    {
      get => this.mSellerEmail;
      set => this.mSellerEmail = value;
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
    public ShippingServiceOptionsType ShippingServiceSelected
    {
      get => this.mShippingServiceSelected;
      set => this.mShippingServiceSelected = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Subtotal
    {
      get => this.mSubtotal;
      set => this.mSubtotal = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Total
    {
      get => this.mTotal;
      set => this.mTotal = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExternalTransaction")]
    public ExternalTransactionTypeCollection ExternalTransaction
    {
      get => this.mExternalTransaction;
      set => this.mExternalTransaction = value;
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
    public string BuyerUserID
    {
      get => this.mBuyerUserID;
      set => this.mBuyerUserID = value;
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
    public bool BundlePurchase
    {
      get => this.mBundlePurchase;
      set
      {
        this.mBundlePurchase = value;
        this.mBundlePurchaseSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BundlePurchaseSpecified
    {
      get => this.mBundlePurchaseSpecified;
      set => this.mBundlePurchaseSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerCheckoutMessage
    {
      get => this.mBuyerCheckoutMessage;
      set => this.mBuyerCheckoutMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EIASToken
    {
      get => this.mEIASToken;
      set => this.mEIASToken = value;
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
    public PaymentHoldDetailType PaymentHoldDetails
    {
      get => this.mPaymentHoldDetails;
      set => this.mPaymentHoldDetails = value;
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
    [XmlArrayItem("Refund", IsNullable = false)]
    public RefundTypeCollection RefundArray
    {
      get => this.mRefundArray;
      set => this.mRefundArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IsMultiLegShipping
    {
      get => this.mIsMultiLegShipping;
      set
      {
        this.mIsMultiLegShipping = value;
        this.mIsMultiLegShippingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IsMultiLegShippingSpecified
    {
      get => this.mIsMultiLegShippingSpecified;
      set => this.mIsMultiLegShippingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MultiLegShippingDetailsType MultiLegShippingDetails
    {
      get => this.mMultiLegShippingDetails;
      set => this.mMultiLegShippingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentsInformationType MonetaryDetails
    {
      get => this.mMonetaryDetails;
      set => this.mMonetaryDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PickupDetailsType PickupDetails
    {
      get => this.mPickupDetails;
      set => this.mPickupDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PickupMethodSelectedType PickupMethodSelected
    {
      get => this.mPickupMethodSelected;
      set => this.mPickupMethodSelected = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerUserID
    {
      get => this.mSellerUserID;
      set => this.mSellerUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerEIASToken
    {
      get => this.mSellerEIASToken;
      set => this.mSellerEIASToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string CancelReason
    {
      get => this.mCancelReason;
      set => this.mCancelReason = value;
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
    public string CancelReasonDetails
    {
      get => this.mCancelReasonDetails;
      set => this.mCancelReasonDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingConvenienceCharge
    {
      get => this.mShippingConvenienceCharge;
      set => this.mShippingConvenienceCharge = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CancelDetail")]
    public CancelDetailTypeCollection CancelDetail
    {
      get => this.mCancelDetail;
      set => this.mCancelDetail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string LogisticsPlanType
    {
      get => this.mLogisticsPlanType;
      set => this.mLogisticsPlanType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("BuyerTaxIdentifier")]
    public TaxIdentifierTypeCollection BuyerTaxIdentifier
    {
      get => this.mBuyerTaxIdentifier;
      set => this.mBuyerTaxIdentifier = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerPackageEnclosuresType BuyerPackageEnclosures
    {
      get => this.mBuyerPackageEnclosures;
      set => this.mBuyerPackageEnclosures = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExtendedOrderID
    {
      get => this.mExtendedOrderID;
      set => this.mExtendedOrderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ContainseBayPlusTransaction
    {
      get => this.mContainseBayPlusTransaction;
      set
      {
        this.mContainseBayPlusTransaction = value;
        this.mContainseBayPlusTransactionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ContainseBayPlusTransactionSpecified
    {
      get => this.mContainseBayPlusTransactionSpecified;
      set => this.mContainseBayPlusTransactionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayCollectAndRemitTax
    {
      get => this.meBayCollectAndRemitTax;
      set
      {
        this.meBayCollectAndRemitTax = value;
        this.meBayCollectAndRemitTaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayCollectAndRemitTaxSpecified
    {
      get => this.meBayCollectAndRemitTaxSpecified;
      set => this.meBayCollectAndRemitTaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long OrderLineItemCount
    {
      get => this.mOrderLineItemCount;
      set
      {
        this.mOrderLineItemCount = value;
        this.mOrderLineItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderLineItemCountSpecified
    {
      get => this.mOrderLineItemCountSpecified;
      set => this.mOrderLineItemCountSpecified = value;
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
