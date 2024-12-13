// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TransactionType
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
  public class TransactionType
  {
    private AmountType mAmountPaid;
    private AmountType mAdjustmentAmount;
    private AmountType mConvertedAdjustmentAmount;
    private UserType mBuyer;
    private ShippingDetailsType mShippingDetails;
    private AmountType mConvertedAmountPaid;
    private AmountType mConvertedTransactionPrice;
    private DateTime mCreatedDate;
    private bool mCreatedDateSpecified;
    private DepositTypeCodeType mDepositType;
    private bool mDepositTypeSpecified;
    private ItemType mItem;
    private int mQuantityPurchased;
    private bool mQuantityPurchasedSpecified;
    private TransactionStatusType mStatus;
    private string mTransactionID;
    private AmountType mTransactionPrice;
    private bool mBestOfferSale;
    private bool mBestOfferSaleSpecified;
    private Decimal mVATPercent;
    private bool mVATPercentSpecified;
    private ExternalTransactionTypeCollection mExternalTransaction;
    private SellingManagerProductDetailsType mSellingManagerProductDetails;
    private ShippingServiceOptionsType mShippingServiceSelected;
    private string mBuyerMessage;
    private AmountType mDutchAuctionBid;
    private PaidStatusCodeType mBuyerPaidStatus;
    private bool mBuyerPaidStatusSpecified;
    private PaidStatusCodeType mSellerPaidStatus;
    private bool mSellerPaidStatusSpecified;
    private DateTime mPaidTime;
    private bool mPaidTimeSpecified;
    private DateTime mShippedTime;
    private bool mShippedTimeSpecified;
    private AmountType mTotalPrice;
    private FeedbackInfoType mFeedbackLeft;
    private FeedbackInfoType mFeedbackReceived;
    private OrderType mContainingOrder;
    private AmountType mFinalValueFee;
    private ListingCheckoutRedirectPreferenceType mListingCheckoutRedirectPreference;
    private RefundTypeCollection mRefundArray;
    private SiteCodeType mTransactionSiteID;
    private bool mTransactionSiteIDSpecified;
    private TransactionPlatformCodeType mPlatform;
    private bool mPlatformSpecified;
    private string mCartID;
    private bool mSellerContactBuyerByEmail;
    private bool mSellerContactBuyerByEmailSpecified;
    private string mPayPalEmailAddress;
    private string mPaisaPayID;
    private AmountType mBuyerGuaranteePrice;
    private VariationType mVariation;
    private string mBuyerCheckoutMessage;
    private AmountType mTotalTransactionPrice;
    private TaxesType mTaxes;
    private bool mBundlePurchase;
    private bool mBundlePurchaseSpecified;
    private AmountType mActualShippingCost;
    private AmountType mActualHandlingCost;
    private string mOrderLineItemID;
    private string meBayPaymentID;
    private PaymentHoldDetailType mPaymentHoldDetails;
    private SellerDiscountsType mSellerDiscounts;
    private AmountType mRefundAmount;
    private string mRefundStatus;
    private string mCodiceFiscale;
    private bool mIsMultiLegShipping;
    private bool mIsMultiLegShippingSpecified;
    private MultiLegShippingDetailsType mMultiLegShippingDetails;
    private DateTime mInvoiceSentTime;
    private bool mInvoiceSentTimeSpecified;
    private UnpaidItemType mUnpaidItem;
    private bool mIntangibleItem;
    private bool mIntangibleItemSpecified;
    private PaymentsInformationType mMonetaryDetails;
    private PickupDetailsType mPickupDetails;
    private PickupMethodSelectedType mPickupMethodSelected;
    private AmountType mShippingConvenienceCharge;
    private string mLogisticsPlanType;
    private BuyerPackageEnclosuresType mBuyerPackageEnclosures;
    private string mInventoryReservationID;
    private string mExtendedOrderID;
    private bool meBayPlusTransaction;
    private bool meBayPlusTransactionSpecified;
    private GiftSummaryType mGiftSummary;
    private DigitalDeliverySelectedType mDigitalDeliverySelected;
    private bool mGift;
    private bool mGiftSpecified;
    private bool mGuaranteedShipping;
    private bool mGuaranteedShippingSpecified;
    private bool mGuaranteedDelivery;
    private bool mGuaranteedDeliverySpecified;
    private bool meBayCollectAndRemitTax;
    private bool meBayCollectAndRemitTaxSpecified;
    private TaxesType meBayCollectAndRemitTaxes;
    private XmlElementCollection mAny;

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
    public AmountType AdjustmentAmount
    {
      get => this.mAdjustmentAmount;
      set => this.mAdjustmentAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedAdjustmentAmount
    {
      get => this.mConvertedAdjustmentAmount;
      set => this.mConvertedAdjustmentAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserType Buyer
    {
      get => this.mBuyer;
      set => this.mBuyer = value;
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
    public AmountType ConvertedAmountPaid
    {
      get => this.mConvertedAmountPaid;
      set => this.mConvertedAmountPaid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedTransactionPrice
    {
      get => this.mConvertedTransactionPrice;
      set => this.mConvertedTransactionPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreatedDate
    {
      get => this.mCreatedDate;
      set
      {
        this.mCreatedDate = value;
        this.mCreatedDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreatedDateSpecified
    {
      get => this.mCreatedDateSpecified;
      set => this.mCreatedDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DepositTypeCodeType DepositType
    {
      get => this.mDepositType;
      set
      {
        this.mDepositType = value;
        this.mDepositTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DepositTypeSpecified
    {
      get => this.mDepositTypeSpecified;
      set => this.mDepositTypeSpecified = value;
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
    public int QuantityPurchased
    {
      get => this.mQuantityPurchased;
      set
      {
        this.mQuantityPurchased = value;
        this.mQuantityPurchasedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityPurchasedSpecified
    {
      get => this.mQuantityPurchasedSpecified;
      set => this.mQuantityPurchasedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TransactionStatusType Status
    {
      get => this.mStatus;
      set => this.mStatus = value;
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
    public AmountType TransactionPrice
    {
      get => this.mTransactionPrice;
      set => this.mTransactionPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferSale
    {
      get => this.mBestOfferSale;
      set
      {
        this.mBestOfferSale = value;
        this.mBestOfferSaleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferSaleSpecified
    {
      get => this.mBestOfferSaleSpecified;
      set => this.mBestOfferSaleSpecified = value;
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
    [XmlElement("ExternalTransaction")]
    public ExternalTransactionTypeCollection ExternalTransaction
    {
      get => this.mExternalTransaction;
      set => this.mExternalTransaction = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.mSellingManagerProductDetails;
      set => this.mSellingManagerProductDetails = value;
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
    public string BuyerMessage
    {
      get => this.mBuyerMessage;
      set => this.mBuyerMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType DutchAuctionBid
    {
      get => this.mDutchAuctionBid;
      set => this.mDutchAuctionBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaidStatusCodeType BuyerPaidStatus
    {
      get => this.mBuyerPaidStatus;
      set
      {
        this.mBuyerPaidStatus = value;
        this.mBuyerPaidStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyerPaidStatusSpecified
    {
      get => this.mBuyerPaidStatusSpecified;
      set => this.mBuyerPaidStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaidStatusCodeType SellerPaidStatus
    {
      get => this.mSellerPaidStatus;
      set
      {
        this.mSellerPaidStatus = value;
        this.mSellerPaidStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerPaidStatusSpecified
    {
      get => this.mSellerPaidStatusSpecified;
      set => this.mSellerPaidStatusSpecified = value;
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
    public AmountType TotalPrice
    {
      get => this.mTotalPrice;
      set => this.mTotalPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeedbackInfoType FeedbackLeft
    {
      get => this.mFeedbackLeft;
      set => this.mFeedbackLeft = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeedbackInfoType FeedbackReceived
    {
      get => this.mFeedbackReceived;
      set => this.mFeedbackReceived = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public OrderType ContainingOrder
    {
      get => this.mContainingOrder;
      set => this.mContainingOrder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType FinalValueFee
    {
      get => this.mFinalValueFee;
      set => this.mFinalValueFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingCheckoutRedirectPreferenceType ListingCheckoutRedirectPreference
    {
      get => this.mListingCheckoutRedirectPreference;
      set => this.mListingCheckoutRedirectPreference = value;
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
    public SiteCodeType TransactionSiteID
    {
      get => this.mTransactionSiteID;
      set
      {
        this.mTransactionSiteID = value;
        this.mTransactionSiteIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionSiteIDSpecified
    {
      get => this.mTransactionSiteIDSpecified;
      set => this.mTransactionSiteIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TransactionPlatformCodeType Platform
    {
      get => this.mPlatform;
      set
      {
        this.mPlatform = value;
        this.mPlatformSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PlatformSpecified
    {
      get => this.mPlatformSpecified;
      set => this.mPlatformSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CartID
    {
      get => this.mCartID;
      set => this.mCartID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerContactBuyerByEmail
    {
      get => this.mSellerContactBuyerByEmail;
      set
      {
        this.mSellerContactBuyerByEmail = value;
        this.mSellerContactBuyerByEmailSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerContactBuyerByEmailSpecified
    {
      get => this.mSellerContactBuyerByEmailSpecified;
      set => this.mSellerContactBuyerByEmailSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PayPalEmailAddress
    {
      get => this.mPayPalEmailAddress;
      set => this.mPayPalEmailAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PaisaPayID
    {
      get => this.mPaisaPayID;
      set => this.mPaisaPayID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType BuyerGuaranteePrice
    {
      get => this.mBuyerGuaranteePrice;
      set => this.mBuyerGuaranteePrice = value;
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
    public string BuyerCheckoutMessage
    {
      get => this.mBuyerCheckoutMessage;
      set => this.mBuyerCheckoutMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalTransactionPrice
    {
      get => this.mTotalTransactionPrice;
      set => this.mTotalTransactionPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TaxesType Taxes
    {
      get => this.mTaxes;
      set => this.mTaxes = value;
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
    public AmountType ActualShippingCost
    {
      get => this.mActualShippingCost;
      set => this.mActualShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ActualHandlingCost
    {
      get => this.mActualHandlingCost;
      set => this.mActualHandlingCost = value;
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
    public string eBayPaymentID
    {
      get => this.meBayPaymentID;
      set => this.meBayPaymentID = value;
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
    public SellerDiscountsType SellerDiscounts
    {
      get => this.mSellerDiscounts;
      set => this.mSellerDiscounts = value;
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
    public string CodiceFiscale
    {
      get => this.mCodiceFiscale;
      set => this.mCodiceFiscale = value;
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
    public DateTime InvoiceSentTime
    {
      get => this.mInvoiceSentTime;
      set
      {
        this.mInvoiceSentTime = value;
        this.mInvoiceSentTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InvoiceSentTimeSpecified
    {
      get => this.mInvoiceSentTimeSpecified;
      set => this.mInvoiceSentTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UnpaidItemType UnpaidItem
    {
      get => this.mUnpaidItem;
      set => this.mUnpaidItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IntangibleItem
    {
      get => this.mIntangibleItem;
      set
      {
        this.mIntangibleItem = value;
        this.mIntangibleItemSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IntangibleItemSpecified
    {
      get => this.mIntangibleItemSpecified;
      set => this.mIntangibleItemSpecified = value;
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
    public AmountType ShippingConvenienceCharge
    {
      get => this.mShippingConvenienceCharge;
      set => this.mShippingConvenienceCharge = value;
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
    public BuyerPackageEnclosuresType BuyerPackageEnclosures
    {
      get => this.mBuyerPackageEnclosures;
      set => this.mBuyerPackageEnclosures = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InventoryReservationID
    {
      get => this.mInventoryReservationID;
      set => this.mInventoryReservationID = value;
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
    public bool eBayPlusTransaction
    {
      get => this.meBayPlusTransaction;
      set
      {
        this.meBayPlusTransaction = value;
        this.meBayPlusTransactionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayPlusTransactionSpecified
    {
      get => this.meBayPlusTransactionSpecified;
      set => this.meBayPlusTransactionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GiftSummaryType GiftSummary
    {
      get => this.mGiftSummary;
      set => this.mGiftSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DigitalDeliverySelectedType DigitalDeliverySelected
    {
      get => this.mDigitalDeliverySelected;
      set => this.mDigitalDeliverySelected = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Gift
    {
      get => this.mGift;
      set
      {
        this.mGift = value;
        this.mGiftSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GiftSpecified
    {
      get => this.mGiftSpecified;
      set => this.mGiftSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GuaranteedShipping
    {
      get => this.mGuaranteedShipping;
      set
      {
        this.mGuaranteedShipping = value;
        this.mGuaranteedShippingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GuaranteedShippingSpecified
    {
      get => this.mGuaranteedShippingSpecified;
      set => this.mGuaranteedShippingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GuaranteedDelivery
    {
      get => this.mGuaranteedDelivery;
      set
      {
        this.mGuaranteedDelivery = value;
        this.mGuaranteedDeliverySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GuaranteedDeliverySpecified
    {
      get => this.mGuaranteedDeliverySpecified;
      set => this.mGuaranteedDeliverySpecified = value;
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
    public TaxesType eBayCollectAndRemitTaxes
    {
      get => this.meBayCollectAndRemitTaxes;
      set => this.meBayCollectAndRemitTaxes = value;
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
