// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SiteDefaultsType
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
  public class SiteDefaultsType
  {
    private ListingDurationReferenceTypeCollection mListingDuration;
    private bool mShippingTermsRequired;
    private bool mShippingTermsRequiredSpecified;
    private bool mBestOfferEnabled;
    private bool mBestOfferEnabledSpecified;
    private bool mDutchBINEnabled;
    private bool mDutchBINEnabledSpecified;
    private bool mUserConsentRequired;
    private bool mUserConsentRequiredSpecified;
    private bool mHomePageFeaturedEnabled;
    private bool mHomePageFeaturedEnabledSpecified;
    private bool mProPackEnabled;
    private bool mProPackEnabledSpecified;
    private bool mBasicUpgradePackEnabled;
    private bool mBasicUpgradePackEnabledSpecified;
    private bool mValuePackEnabled;
    private bool mValuePackEnabledSpecified;
    private bool mProPackPlusEnabled;
    private bool mProPackPlusEnabledSpecified;
    private AdFormatEnabledCodeType mAdFormatEnabled;
    private bool mAdFormatEnabledSpecified;
    private bool mBestOfferCounterEnabled;
    private bool mBestOfferCounterEnabledSpecified;
    private bool mBestOfferAutoDeclineEnabled;
    private bool mBestOfferAutoDeclineEnabledSpecified;
    private bool mLocalMarketSpecialitySubscription;
    private bool mLocalMarketSpecialitySubscriptionSpecified;
    private bool mLocalMarketRegularSubscription;
    private bool mLocalMarketRegularSubscriptionSpecified;
    private bool mLocalMarketPremiumSubscription;
    private bool mLocalMarketPremiumSubscriptionSpecified;
    private bool mLocalMarketNonSubscription;
    private bool mLocalMarketNonSubscriptionSpecified;
    private bool mExpressEnabled;
    private bool mExpressEnabledSpecified;
    private bool mExpressPicturesRequired;
    private bool mExpressPicturesRequiredSpecified;
    private bool mExpressConditionRequired;
    private bool mExpressConditionRequiredSpecified;
    private double mMinimumReservePrice;
    private bool mMinimumReservePriceSpecified;
    private bool mSellerContactDetailsEnabled;
    private bool mSellerContactDetailsEnabledSpecified;
    private bool mTransactionConfirmationRequestEnabled;
    private bool mTransactionConfirmationRequestEnabledSpecified;
    private bool mStoreInventoryEnabled;
    private bool mStoreInventoryEnabledSpecified;
    private bool mSkypeMeTransactionalEnabled;
    private bool mSkypeMeTransactionalEnabledSpecified;
    private bool mSkypeMeNonTransactionalEnabled;
    private bool mSkypeMeNonTransactionalEnabledSpecified;
    private string mLocalListingDistancesRegular;
    private string mLocalListingDistancesSpecialty;
    private string mLocalListingDistancesNonSubscription;
    private ClassifiedAdPaymentMethodEnabledCodeType mClassifiedAdPaymentMethodEnabled;
    private bool mClassifiedAdPaymentMethodEnabledSpecified;
    private bool mClassifiedAdShippingMethodEnabled;
    private bool mClassifiedAdShippingMethodEnabledSpecified;
    private ClassifiedAdBestOfferEnabledCodeType mClassifiedAdBestOfferEnabled;
    private bool mClassifiedAdBestOfferEnabledSpecified;
    private bool mClassifiedAdCounterOfferEnabled;
    private bool mClassifiedAdCounterOfferEnabledSpecified;
    private bool mClassifiedAdAutoDeclineEnabled;
    private bool mClassifiedAdAutoDeclineEnabledSpecified;
    private bool mClassifiedAdContactByPhoneEnabled;
    private bool mClassifiedAdContactByPhoneEnabledSpecified;
    private bool mClassifiedAdContactByEmailEnabled;
    private bool mClassifiedAdContactByEmailEnabledSpecified;
    private bool mSafePaymentRequired;
    private bool mSafePaymentRequiredSpecified;
    private bool mClassifiedAdPayPerLeadEnabled;
    private bool mClassifiedAdPayPerLeadEnabledSpecified;
    private ItemSpecificsEnabledCodeType mItemSpecificsEnabled;
    private bool mItemSpecificsEnabledSpecified;
    private bool mPaisaPayFullEscrowEnabled;
    private bool mPaisaPayFullEscrowEnabledSpecified;
    private bool mISBNIdentifierEnabled;
    private bool mISBNIdentifierEnabledSpecified;
    private bool mUPCIdentifierEnabled;
    private bool mUPCIdentifierEnabledSpecified;
    private bool mEANIdentifierEnabled;
    private bool mEANIdentifierEnabledSpecified;
    private bool mBrandMPNIdentifierEnabled;
    private bool mBrandMPNIdentifierEnabledSpecified;
    private bool mClassifiedAdAutoAcceptEnabled;
    private bool mClassifiedAdAutoAcceptEnabledSpecified;
    private bool mBestOfferAutoAcceptEnabled;
    private bool mBestOfferAutoAcceptEnabledSpecified;
    private bool mCrossBorderTradeNorthAmericaEnabled;
    private bool mCrossBorderTradeNorthAmericaEnabledSpecified;
    private bool mCrossBorderTradeGBEnabled;
    private bool mCrossBorderTradeGBEnabledSpecified;
    private bool mCrossBorderTradeAustraliaEnabled;
    private bool mCrossBorderTradeAustraliaEnabledSpecified;
    private bool mPayPalBuyerProtectionEnabled;
    private bool mPayPalBuyerProtectionEnabledSpecified;
    private bool mBuyerGuaranteeEnabled;
    private bool mBuyerGuaranteeEnabledSpecified;
    private INEscrowWorkflowTimelineCodeType mINEscrowWorkflowTimeline;
    private bool mINEscrowWorkflowTimelineSpecified;
    private bool mCombinedFixedPriceTreatmentEnabled;
    private bool mCombinedFixedPriceTreatmentEnabledSpecified;
    private ListingEnhancementDurationReferenceType mGalleryFeaturedDurations;
    private bool mPayPalRequired;
    private bool mPayPalRequiredSpecified;
    private AdFormatEnabledCodeType meBayMotorsProAdFormatEnabled;
    private bool meBayMotorsProAdFormatEnabledSpecified;
    private bool meBayMotorsProContactByPhoneEnabled;
    private bool meBayMotorsProContactByPhoneEnabledSpecified;
    private int meBayMotorsProPhoneCount;
    private bool meBayMotorsProPhoneCountSpecified;
    private bool meBayMotorsProContactByAddressEnabled;
    private bool meBayMotorsProContactByAddressEnabledSpecified;
    private int meBayMotorsProStreetCount;
    private bool meBayMotorsProStreetCountSpecified;
    private bool meBayMotorsProCompanyNameEnabled;
    private bool meBayMotorsProCompanyNameEnabledSpecified;
    private bool meBayMotorsProContactByEmailEnabled;
    private bool meBayMotorsProContactByEmailEnabledSpecified;
    private ClassifiedAdBestOfferEnabledCodeType meBayMotorsProBestOfferEnabled;
    private bool meBayMotorsProBestOfferEnabledSpecified;
    private bool meBayMotorsProAutoAcceptEnabled;
    private bool meBayMotorsProAutoAcceptEnabledSpecified;
    private bool meBayMotorsProAutoDeclineEnabled;
    private bool meBayMotorsProAutoDeclineEnabledSpecified;
    private ClassifiedAdPaymentMethodEnabledCodeType meBayMotorsProPaymentMethodCheckOutEnabled;
    private bool meBayMotorsProPaymentMethodCheckOutEnabledSpecified;
    private bool meBayMotorsProShippingMethodEnabled;
    private bool meBayMotorsProShippingMethodEnabledSpecified;
    private bool meBayMotorsProCounterOfferEnabled;
    private bool meBayMotorsProCounterOfferEnabledSpecified;
    private bool meBayMotorsProSellerContactDetailsEnabled;
    private bool meBayMotorsProSellerContactDetailsEnabledSpecified;
    private AdFormatEnabledCodeType mLocalMarketAdFormatEnabled;
    private bool mLocalMarketAdFormatEnabledSpecified;
    private bool mLocalMarketContactByPhoneEnabled;
    private bool mLocalMarketContactByPhoneEnabledSpecified;
    private int mLocalMarketPhoneCount;
    private bool mLocalMarketPhoneCountSpecified;
    private bool mLocalMarketContactByAddressEnabled;
    private bool mLocalMarketContactByAddressEnabledSpecified;
    private int mLocalMarketStreetCount;
    private bool mLocalMarketStreetCountSpecified;
    private bool mLocalMarketCompanyNameEnabled;
    private bool mLocalMarketCompanyNameEnabledSpecified;
    private bool mLocalMarketContactByEmailEnabled;
    private bool mLocalMarketContactByEmailEnabledSpecified;
    private ClassifiedAdBestOfferEnabledCodeType mLocalMarketBestOfferEnabled;
    private bool mLocalMarketBestOfferEnabledSpecified;
    private bool mLocalMarketAutoAcceptEnabled;
    private bool mLocalMarketAutoAcceptEnabledSpecified;
    private bool mLocalMarketAutoDeclineEnabled;
    private bool mLocalMarketAutoDeclineEnabledSpecified;
    private ClassifiedAdPaymentMethodEnabledCodeType mLocalMarketPaymentMethodCheckOutEnabled;
    private bool mLocalMarketPaymentMethodCheckOutEnabledSpecified;
    private bool mLocalMarketShippingMethodEnabled;
    private bool mLocalMarketShippingMethodEnabledSpecified;
    private bool mLocalMarketCounterOfferEnabled;
    private bool mLocalMarketCounterOfferEnabledSpecified;
    private bool mLocalMarketSellerContactDetailsEnabled;
    private bool mLocalMarketSellerContactDetailsEnabledSpecified;
    private int mClassifiedAdPhoneCount;
    private bool mClassifiedAdPhoneCountSpecified;
    private bool mClassifiedAdContactByAddressEnabled;
    private bool mClassifiedAdContactByAddressEnabledSpecified;
    private int mClassifiedAdStreetCount;
    private bool mClassifiedAdStreetCountSpecified;
    private bool mClassifiedAdCompanyNameEnabled;
    private bool mClassifiedAdCompanyNameEnabledSpecified;
    private GeographicExposureCodeType mSpecialitySubscription;
    private bool mSpecialitySubscriptionSpecified;
    private GeographicExposureCodeType mRegularSubscription;
    private bool mRegularSubscriptionSpecified;
    private GeographicExposureCodeType mPremiumSubscription;
    private bool mPremiumSubscriptionSpecified;
    private GeographicExposureCodeType mNonSubscription;
    private bool mNonSubscriptionSpecified;
    private bool mPayPalRequiredForStoreOwner;
    private bool mPayPalRequiredForStoreOwnerSpecified;
    private bool mReviseQuantityAllowed;
    private bool mReviseQuantityAllowedSpecified;
    private bool mRevisePriceAllowed;
    private bool mRevisePriceAllowedSpecified;
    private bool mStoreOwnerExtendedListingDurationsEnabled;
    private bool mStoreOwnerExtendedListingDurationsEnabledSpecified;
    private StoreOwnerExtendedListingDurationsType mStoreOwnerExtendedListingDurations;
    private bool mReturnPolicyEnabled;
    private bool mReturnPolicyEnabledSpecified;
    private bool mHandlingTimeEnabled;
    private bool mHandlingTimeEnabledSpecified;
    private AmountType mMaxFlatShippingCost;
    private bool mMaxFlatShippingCostCBTExempt;
    private bool mMaxFlatShippingCostCBTExemptSpecified;
    private AmountType mGroup1MaxFlatShippingCost;
    private AmountType mGroup2MaxFlatShippingCost;
    private AmountType mGroup3MaxFlatShippingCost;
    private BuyerPaymentMethodCodeTypeCollection mPaymentMethod;
    private bool mVariationsEnabled;
    private bool mVariationsEnabledSpecified;
    private AttributeConversionEnabledCodeType mAttributeConversionEnabled;
    private bool mAttributeConversionEnabledSpecified;
    private bool mFreeGalleryPlusEnabled;
    private bool mFreeGalleryPlusEnabledSpecified;
    private bool mFreePicturePackEnabled;
    private bool mFreePicturePackEnabledSpecified;
    private ItemCompatibilityEnabledCodeType mItemCompatibilityEnabled;
    private bool mItemCompatibilityEnabledSpecified;
    private int mMinItemCompatibility;
    private bool mMinItemCompatibilitySpecified;
    private int mMaxItemCompatibility;
    private bool mMaxItemCompatibilitySpecified;
    private ConditionEnabledCodeType mConditionEnabled;
    private bool mConditionEnabledSpecified;
    private ConditionValuesType mConditionValues;
    private bool mValueCategory;
    private bool mValueCategorySpecified;
    private ProductCreationEnabledCodeType mProductCreationEnabled;
    private bool mProductCreationEnabledSpecified;
    private ProductIdentiferEnabledCodeType mEANEnabled;
    private bool mEANEnabledSpecified;
    private ProductIdentiferEnabledCodeType mISBNEnabled;
    private bool mISBNEnabledSpecified;
    private ProductIdentiferEnabledCodeType mUPCEnabled;
    private bool mUPCEnabledSpecified;
    private int mMaxGranularFitmentCount;
    private bool mMaxGranularFitmentCountSpecified;
    private string mCompatibleVehicleType;
    private PaymentOptionsGroupEnabledCodeType mPaymentOptionsGroup;
    private bool mPaymentOptionsGroupSpecified;
    private ProfileCategoryGroupCodeType mShippingProfileCategoryGroup;
    private bool mShippingProfileCategoryGroupSpecified;
    private ProfileCategoryGroupCodeType mPaymentProfileCategoryGroup;
    private bool mPaymentProfileCategoryGroupSpecified;
    private ProfileCategoryGroupCodeType mReturnPolicyProfileCategoryGroup;
    private bool mReturnPolicyProfileCategoryGroupSpecified;
    private bool mVINSupported;
    private bool mVINSupportedSpecified;
    private bool mVRMSupported;
    private bool mVRMSupportedSpecified;
    private bool mSellerProvidedTitleSupported;
    private bool mSellerProvidedTitleSupportedSpecified;
    private bool mDepositSupported;
    private bool mDepositSupportedSpecified;
    private bool mGlobalShippingEnabled;
    private bool mGlobalShippingEnabledSpecified;
    private bool mAdditionalCompatibilityEnabled;
    private bool mAdditionalCompatibilityEnabledSpecified;
    private XmlElementCollection mAny;
    private bool mPickupDropOffEnabled;
    private bool mPickupDropOffEnabledSpecified;
    private bool mDigitalGoodDeliveryEnabled;
    private bool mDigitalGoodDeliveryEnabledSpecified;
    private bool mEpidSupported;
    private bool mEpidSupportedSpecified;
    private bool mKTypeSupported;
    private bool mKTypeSupportedSpecified;
    private ProductRequiredEnabledCodeType mProductRequiredEnabled;
    private bool mProductRequiredEnabledSpecified;
    private DomesticReturnsAcceptedCodeType mDomesticReturnsAcceptedValues;
    private InternationalReturnsAcceptedCodeType mInternationalReturnsAcceptedValues;
    private DomesticReturnsDurationCodeType mDomesticReturnsDurationValues;
    private InternationalReturnsDurationCodeType mInternationalReturnsDurationValues;
    private DomesticReturnsShipmentPayeeCodeType mDomesticReturnsShipmentPayeeValues;
    private InternationalReturnsShipmentPayeeCodeType mInternationalReturnsShipmentPayeeValues;
    private DomesticRefundMethodCodeType mDomesticRefundMethodValues;
    private InternationalRefundMethodCodeType mInternationalRefundMethodValues;
    private bool mReturnPolicyDescriptionEnabled;
    private bool mReturnPolicyDescriptionEnabledSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ListingDuration")]
    public ListingDurationReferenceTypeCollection ListingDuration
    {
      get => this.mListingDuration;
      set => this.mListingDuration = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShippingTermsRequired
    {
      get => this.mShippingTermsRequired;
      set
      {
        this.mShippingTermsRequired = value;
        this.mShippingTermsRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTermsRequiredSpecified
    {
      get => this.mShippingTermsRequiredSpecified;
      set => this.mShippingTermsRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferEnabled
    {
      get => this.mBestOfferEnabled;
      set
      {
        this.mBestOfferEnabled = value;
        this.mBestOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferEnabledSpecified
    {
      get => this.mBestOfferEnabledSpecified;
      set => this.mBestOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DutchBINEnabled
    {
      get => this.mDutchBINEnabled;
      set
      {
        this.mDutchBINEnabled = value;
        this.mDutchBINEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DutchBINEnabledSpecified
    {
      get => this.mDutchBINEnabledSpecified;
      set => this.mDutchBINEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UserConsentRequired
    {
      get => this.mUserConsentRequired;
      set
      {
        this.mUserConsentRequired = value;
        this.mUserConsentRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserConsentRequiredSpecified
    {
      get => this.mUserConsentRequiredSpecified;
      set => this.mUserConsentRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HomePageFeaturedEnabled
    {
      get => this.mHomePageFeaturedEnabled;
      set
      {
        this.mHomePageFeaturedEnabled = value;
        this.mHomePageFeaturedEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HomePageFeaturedEnabledSpecified
    {
      get => this.mHomePageFeaturedEnabledSpecified;
      set => this.mHomePageFeaturedEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ProPackEnabled
    {
      get => this.mProPackEnabled;
      set
      {
        this.mProPackEnabled = value;
        this.mProPackEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProPackEnabledSpecified
    {
      get => this.mProPackEnabledSpecified;
      set => this.mProPackEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BasicUpgradePackEnabled
    {
      get => this.mBasicUpgradePackEnabled;
      set
      {
        this.mBasicUpgradePackEnabled = value;
        this.mBasicUpgradePackEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BasicUpgradePackEnabledSpecified
    {
      get => this.mBasicUpgradePackEnabledSpecified;
      set => this.mBasicUpgradePackEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ValuePackEnabled
    {
      get => this.mValuePackEnabled;
      set
      {
        this.mValuePackEnabled = value;
        this.mValuePackEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ValuePackEnabledSpecified
    {
      get => this.mValuePackEnabledSpecified;
      set => this.mValuePackEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ProPackPlusEnabled
    {
      get => this.mProPackPlusEnabled;
      set
      {
        this.mProPackPlusEnabled = value;
        this.mProPackPlusEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProPackPlusEnabledSpecified
    {
      get => this.mProPackPlusEnabledSpecified;
      set => this.mProPackPlusEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdFormatEnabledCodeType AdFormatEnabled
    {
      get => this.mAdFormatEnabled;
      set
      {
        this.mAdFormatEnabled = value;
        this.mAdFormatEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AdFormatEnabledSpecified
    {
      get => this.mAdFormatEnabledSpecified;
      set => this.mAdFormatEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferCounterEnabled
    {
      get => this.mBestOfferCounterEnabled;
      set
      {
        this.mBestOfferCounterEnabled = value;
        this.mBestOfferCounterEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferCounterEnabledSpecified
    {
      get => this.mBestOfferCounterEnabledSpecified;
      set => this.mBestOfferCounterEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferAutoDeclineEnabled
    {
      get => this.mBestOfferAutoDeclineEnabled;
      set
      {
        this.mBestOfferAutoDeclineEnabled = value;
        this.mBestOfferAutoDeclineEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferAutoDeclineEnabledSpecified
    {
      get => this.mBestOfferAutoDeclineEnabledSpecified;
      set => this.mBestOfferAutoDeclineEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketSpecialitySubscription
    {
      get => this.mLocalMarketSpecialitySubscription;
      set
      {
        this.mLocalMarketSpecialitySubscription = value;
        this.mLocalMarketSpecialitySubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketSpecialitySubscriptionSpecified
    {
      get => this.mLocalMarketSpecialitySubscriptionSpecified;
      set => this.mLocalMarketSpecialitySubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketRegularSubscription
    {
      get => this.mLocalMarketRegularSubscription;
      set
      {
        this.mLocalMarketRegularSubscription = value;
        this.mLocalMarketRegularSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketRegularSubscriptionSpecified
    {
      get => this.mLocalMarketRegularSubscriptionSpecified;
      set => this.mLocalMarketRegularSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketPremiumSubscription
    {
      get => this.mLocalMarketPremiumSubscription;
      set
      {
        this.mLocalMarketPremiumSubscription = value;
        this.mLocalMarketPremiumSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketPremiumSubscriptionSpecified
    {
      get => this.mLocalMarketPremiumSubscriptionSpecified;
      set => this.mLocalMarketPremiumSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketNonSubscription
    {
      get => this.mLocalMarketNonSubscription;
      set
      {
        this.mLocalMarketNonSubscription = value;
        this.mLocalMarketNonSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketNonSubscriptionSpecified
    {
      get => this.mLocalMarketNonSubscriptionSpecified;
      set => this.mLocalMarketNonSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressEnabled
    {
      get => this.mExpressEnabled;
      set
      {
        this.mExpressEnabled = value;
        this.mExpressEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressEnabledSpecified
    {
      get => this.mExpressEnabledSpecified;
      set => this.mExpressEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressPicturesRequired
    {
      get => this.mExpressPicturesRequired;
      set
      {
        this.mExpressPicturesRequired = value;
        this.mExpressPicturesRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressPicturesRequiredSpecified
    {
      get => this.mExpressPicturesRequiredSpecified;
      set => this.mExpressPicturesRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressConditionRequired
    {
      get => this.mExpressConditionRequired;
      set
      {
        this.mExpressConditionRequired = value;
        this.mExpressConditionRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressConditionRequiredSpecified
    {
      get => this.mExpressConditionRequiredSpecified;
      set => this.mExpressConditionRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public double MinimumReservePrice
    {
      get => this.mMinimumReservePrice;
      set
      {
        this.mMinimumReservePrice = value;
        this.mMinimumReservePriceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinimumReservePriceSpecified
    {
      get => this.mMinimumReservePriceSpecified;
      set => this.mMinimumReservePriceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerContactDetailsEnabled
    {
      get => this.mSellerContactDetailsEnabled;
      set
      {
        this.mSellerContactDetailsEnabled = value;
        this.mSellerContactDetailsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerContactDetailsEnabledSpecified
    {
      get => this.mSellerContactDetailsEnabledSpecified;
      set => this.mSellerContactDetailsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool TransactionConfirmationRequestEnabled
    {
      get => this.mTransactionConfirmationRequestEnabled;
      set
      {
        this.mTransactionConfirmationRequestEnabled = value;
        this.mTransactionConfirmationRequestEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionConfirmationRequestEnabledSpecified
    {
      get => this.mTransactionConfirmationRequestEnabledSpecified;
      set => this.mTransactionConfirmationRequestEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool StoreInventoryEnabled
    {
      get => this.mStoreInventoryEnabled;
      set
      {
        this.mStoreInventoryEnabled = value;
        this.mStoreInventoryEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreInventoryEnabledSpecified
    {
      get => this.mStoreInventoryEnabledSpecified;
      set => this.mStoreInventoryEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SkypeMeTransactionalEnabled
    {
      get => this.mSkypeMeTransactionalEnabled;
      set
      {
        this.mSkypeMeTransactionalEnabled = value;
        this.mSkypeMeTransactionalEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SkypeMeTransactionalEnabledSpecified
    {
      get => this.mSkypeMeTransactionalEnabledSpecified;
      set => this.mSkypeMeTransactionalEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SkypeMeNonTransactionalEnabled
    {
      get => this.mSkypeMeNonTransactionalEnabled;
      set
      {
        this.mSkypeMeNonTransactionalEnabled = value;
        this.mSkypeMeNonTransactionalEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SkypeMeNonTransactionalEnabledSpecified
    {
      get => this.mSkypeMeNonTransactionalEnabledSpecified;
      set => this.mSkypeMeNonTransactionalEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LocalListingDistancesRegular
    {
      get => this.mLocalListingDistancesRegular;
      set => this.mLocalListingDistancesRegular = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LocalListingDistancesSpecialty
    {
      get => this.mLocalListingDistancesSpecialty;
      set => this.mLocalListingDistancesSpecialty = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LocalListingDistancesNonSubscription
    {
      get => this.mLocalListingDistancesNonSubscription;
      set => this.mLocalListingDistancesNonSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPaymentMethodEnabledCodeType ClassifiedAdPaymentMethodEnabled
    {
      get => this.mClassifiedAdPaymentMethodEnabled;
      set
      {
        this.mClassifiedAdPaymentMethodEnabled = value;
        this.mClassifiedAdPaymentMethodEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdPaymentMethodEnabledSpecified
    {
      get => this.mClassifiedAdPaymentMethodEnabledSpecified;
      set => this.mClassifiedAdPaymentMethodEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdShippingMethodEnabled
    {
      get => this.mClassifiedAdShippingMethodEnabled;
      set
      {
        this.mClassifiedAdShippingMethodEnabled = value;
        this.mClassifiedAdShippingMethodEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdShippingMethodEnabledSpecified
    {
      get => this.mClassifiedAdShippingMethodEnabledSpecified;
      set => this.mClassifiedAdShippingMethodEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdBestOfferEnabledCodeType ClassifiedAdBestOfferEnabled
    {
      get => this.mClassifiedAdBestOfferEnabled;
      set
      {
        this.mClassifiedAdBestOfferEnabled = value;
        this.mClassifiedAdBestOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdBestOfferEnabledSpecified
    {
      get => this.mClassifiedAdBestOfferEnabledSpecified;
      set => this.mClassifiedAdBestOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdCounterOfferEnabled
    {
      get => this.mClassifiedAdCounterOfferEnabled;
      set
      {
        this.mClassifiedAdCounterOfferEnabled = value;
        this.mClassifiedAdCounterOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdCounterOfferEnabledSpecified
    {
      get => this.mClassifiedAdCounterOfferEnabledSpecified;
      set => this.mClassifiedAdCounterOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdAutoDeclineEnabled
    {
      get => this.mClassifiedAdAutoDeclineEnabled;
      set
      {
        this.mClassifiedAdAutoDeclineEnabled = value;
        this.mClassifiedAdAutoDeclineEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdAutoDeclineEnabledSpecified
    {
      get => this.mClassifiedAdAutoDeclineEnabledSpecified;
      set => this.mClassifiedAdAutoDeclineEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdContactByPhoneEnabled
    {
      get => this.mClassifiedAdContactByPhoneEnabled;
      set
      {
        this.mClassifiedAdContactByPhoneEnabled = value;
        this.mClassifiedAdContactByPhoneEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdContactByPhoneEnabledSpecified
    {
      get => this.mClassifiedAdContactByPhoneEnabledSpecified;
      set => this.mClassifiedAdContactByPhoneEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdContactByEmailEnabled
    {
      get => this.mClassifiedAdContactByEmailEnabled;
      set
      {
        this.mClassifiedAdContactByEmailEnabled = value;
        this.mClassifiedAdContactByEmailEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdContactByEmailEnabledSpecified
    {
      get => this.mClassifiedAdContactByEmailEnabledSpecified;
      set => this.mClassifiedAdContactByEmailEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SafePaymentRequired
    {
      get => this.mSafePaymentRequired;
      set
      {
        this.mSafePaymentRequired = value;
        this.mSafePaymentRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SafePaymentRequiredSpecified
    {
      get => this.mSafePaymentRequiredSpecified;
      set => this.mSafePaymentRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdPayPerLeadEnabled
    {
      get => this.mClassifiedAdPayPerLeadEnabled;
      set
      {
        this.mClassifiedAdPayPerLeadEnabled = value;
        this.mClassifiedAdPayPerLeadEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdPayPerLeadEnabledSpecified
    {
      get => this.mClassifiedAdPayPerLeadEnabledSpecified;
      set => this.mClassifiedAdPayPerLeadEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSpecificsEnabledCodeType ItemSpecificsEnabled
    {
      get => this.mItemSpecificsEnabled;
      set
      {
        this.mItemSpecificsEnabled = value;
        this.mItemSpecificsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemSpecificsEnabledSpecified
    {
      get => this.mItemSpecificsEnabledSpecified;
      set => this.mItemSpecificsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PaisaPayFullEscrowEnabled
    {
      get => this.mPaisaPayFullEscrowEnabled;
      set
      {
        this.mPaisaPayFullEscrowEnabled = value;
        this.mPaisaPayFullEscrowEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaisaPayFullEscrowEnabledSpecified
    {
      get => this.mPaisaPayFullEscrowEnabledSpecified;
      set => this.mPaisaPayFullEscrowEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ISBNIdentifierEnabled
    {
      get => this.mISBNIdentifierEnabled;
      set
      {
        this.mISBNIdentifierEnabled = value;
        this.mISBNIdentifierEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ISBNIdentifierEnabledSpecified
    {
      get => this.mISBNIdentifierEnabledSpecified;
      set => this.mISBNIdentifierEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UPCIdentifierEnabled
    {
      get => this.mUPCIdentifierEnabled;
      set
      {
        this.mUPCIdentifierEnabled = value;
        this.mUPCIdentifierEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UPCIdentifierEnabledSpecified
    {
      get => this.mUPCIdentifierEnabledSpecified;
      set => this.mUPCIdentifierEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EANIdentifierEnabled
    {
      get => this.mEANIdentifierEnabled;
      set
      {
        this.mEANIdentifierEnabled = value;
        this.mEANIdentifierEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EANIdentifierEnabledSpecified
    {
      get => this.mEANIdentifierEnabledSpecified;
      set => this.mEANIdentifierEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BrandMPNIdentifierEnabled
    {
      get => this.mBrandMPNIdentifierEnabled;
      set
      {
        this.mBrandMPNIdentifierEnabled = value;
        this.mBrandMPNIdentifierEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BrandMPNIdentifierEnabledSpecified
    {
      get => this.mBrandMPNIdentifierEnabledSpecified;
      set => this.mBrandMPNIdentifierEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdAutoAcceptEnabled
    {
      get => this.mClassifiedAdAutoAcceptEnabled;
      set
      {
        this.mClassifiedAdAutoAcceptEnabled = value;
        this.mClassifiedAdAutoAcceptEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdAutoAcceptEnabledSpecified
    {
      get => this.mClassifiedAdAutoAcceptEnabledSpecified;
      set => this.mClassifiedAdAutoAcceptEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferAutoAcceptEnabled
    {
      get => this.mBestOfferAutoAcceptEnabled;
      set
      {
        this.mBestOfferAutoAcceptEnabled = value;
        this.mBestOfferAutoAcceptEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferAutoAcceptEnabledSpecified
    {
      get => this.mBestOfferAutoAcceptEnabledSpecified;
      set => this.mBestOfferAutoAcceptEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CrossBorderTradeNorthAmericaEnabled
    {
      get => this.mCrossBorderTradeNorthAmericaEnabled;
      set
      {
        this.mCrossBorderTradeNorthAmericaEnabled = value;
        this.mCrossBorderTradeNorthAmericaEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossBorderTradeNorthAmericaEnabledSpecified
    {
      get => this.mCrossBorderTradeNorthAmericaEnabledSpecified;
      set => this.mCrossBorderTradeNorthAmericaEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CrossBorderTradeGBEnabled
    {
      get => this.mCrossBorderTradeGBEnabled;
      set
      {
        this.mCrossBorderTradeGBEnabled = value;
        this.mCrossBorderTradeGBEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossBorderTradeGBEnabledSpecified
    {
      get => this.mCrossBorderTradeGBEnabledSpecified;
      set => this.mCrossBorderTradeGBEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CrossBorderTradeAustraliaEnabled
    {
      get => this.mCrossBorderTradeAustraliaEnabled;
      set
      {
        this.mCrossBorderTradeAustraliaEnabled = value;
        this.mCrossBorderTradeAustraliaEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossBorderTradeAustraliaEnabledSpecified
    {
      get => this.mCrossBorderTradeAustraliaEnabledSpecified;
      set => this.mCrossBorderTradeAustraliaEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalBuyerProtectionEnabled
    {
      get => this.mPayPalBuyerProtectionEnabled;
      set
      {
        this.mPayPalBuyerProtectionEnabled = value;
        this.mPayPalBuyerProtectionEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalBuyerProtectionEnabledSpecified
    {
      get => this.mPayPalBuyerProtectionEnabledSpecified;
      set => this.mPayPalBuyerProtectionEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BuyerGuaranteeEnabled
    {
      get => this.mBuyerGuaranteeEnabled;
      set
      {
        this.mBuyerGuaranteeEnabled = value;
        this.mBuyerGuaranteeEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyerGuaranteeEnabledSpecified
    {
      get => this.mBuyerGuaranteeEnabledSpecified;
      set => this.mBuyerGuaranteeEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public INEscrowWorkflowTimelineCodeType INEscrowWorkflowTimeline
    {
      get => this.mINEscrowWorkflowTimeline;
      set
      {
        this.mINEscrowWorkflowTimeline = value;
        this.mINEscrowWorkflowTimelineSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool INEscrowWorkflowTimelineSpecified
    {
      get => this.mINEscrowWorkflowTimelineSpecified;
      set => this.mINEscrowWorkflowTimelineSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CombinedFixedPriceTreatmentEnabled
    {
      get => this.mCombinedFixedPriceTreatmentEnabled;
      set
      {
        this.mCombinedFixedPriceTreatmentEnabled = value;
        this.mCombinedFixedPriceTreatmentEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CombinedFixedPriceTreatmentEnabledSpecified
    {
      get => this.mCombinedFixedPriceTreatmentEnabledSpecified;
      set => this.mCombinedFixedPriceTreatmentEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingEnhancementDurationReferenceType GalleryFeaturedDurations
    {
      get => this.mGalleryFeaturedDurations;
      set => this.mGalleryFeaturedDurations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalRequired
    {
      get => this.mPayPalRequired;
      set
      {
        this.mPayPalRequired = value;
        this.mPayPalRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalRequiredSpecified
    {
      get => this.mPayPalRequiredSpecified;
      set => this.mPayPalRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdFormatEnabledCodeType eBayMotorsProAdFormatEnabled
    {
      get => this.meBayMotorsProAdFormatEnabled;
      set
      {
        this.meBayMotorsProAdFormatEnabled = value;
        this.meBayMotorsProAdFormatEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProAdFormatEnabledSpecified
    {
      get => this.meBayMotorsProAdFormatEnabledSpecified;
      set => this.meBayMotorsProAdFormatEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProContactByPhoneEnabled
    {
      get => this.meBayMotorsProContactByPhoneEnabled;
      set
      {
        this.meBayMotorsProContactByPhoneEnabled = value;
        this.meBayMotorsProContactByPhoneEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProContactByPhoneEnabledSpecified
    {
      get => this.meBayMotorsProContactByPhoneEnabledSpecified;
      set => this.meBayMotorsProContactByPhoneEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int eBayMotorsProPhoneCount
    {
      get => this.meBayMotorsProPhoneCount;
      set
      {
        this.meBayMotorsProPhoneCount = value;
        this.meBayMotorsProPhoneCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProPhoneCountSpecified
    {
      get => this.meBayMotorsProPhoneCountSpecified;
      set => this.meBayMotorsProPhoneCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProContactByAddressEnabled
    {
      get => this.meBayMotorsProContactByAddressEnabled;
      set
      {
        this.meBayMotorsProContactByAddressEnabled = value;
        this.meBayMotorsProContactByAddressEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProContactByAddressEnabledSpecified
    {
      get => this.meBayMotorsProContactByAddressEnabledSpecified;
      set => this.meBayMotorsProContactByAddressEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int eBayMotorsProStreetCount
    {
      get => this.meBayMotorsProStreetCount;
      set
      {
        this.meBayMotorsProStreetCount = value;
        this.meBayMotorsProStreetCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProStreetCountSpecified
    {
      get => this.meBayMotorsProStreetCountSpecified;
      set => this.meBayMotorsProStreetCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProCompanyNameEnabled
    {
      get => this.meBayMotorsProCompanyNameEnabled;
      set
      {
        this.meBayMotorsProCompanyNameEnabled = value;
        this.meBayMotorsProCompanyNameEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProCompanyNameEnabledSpecified
    {
      get => this.meBayMotorsProCompanyNameEnabledSpecified;
      set => this.meBayMotorsProCompanyNameEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProContactByEmailEnabled
    {
      get => this.meBayMotorsProContactByEmailEnabled;
      set
      {
        this.meBayMotorsProContactByEmailEnabled = value;
        this.meBayMotorsProContactByEmailEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProContactByEmailEnabledSpecified
    {
      get => this.meBayMotorsProContactByEmailEnabledSpecified;
      set => this.meBayMotorsProContactByEmailEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdBestOfferEnabledCodeType eBayMotorsProBestOfferEnabled
    {
      get => this.meBayMotorsProBestOfferEnabled;
      set
      {
        this.meBayMotorsProBestOfferEnabled = value;
        this.meBayMotorsProBestOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProBestOfferEnabledSpecified
    {
      get => this.meBayMotorsProBestOfferEnabledSpecified;
      set => this.meBayMotorsProBestOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProAutoAcceptEnabled
    {
      get => this.meBayMotorsProAutoAcceptEnabled;
      set
      {
        this.meBayMotorsProAutoAcceptEnabled = value;
        this.meBayMotorsProAutoAcceptEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProAutoAcceptEnabledSpecified
    {
      get => this.meBayMotorsProAutoAcceptEnabledSpecified;
      set => this.meBayMotorsProAutoAcceptEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProAutoDeclineEnabled
    {
      get => this.meBayMotorsProAutoDeclineEnabled;
      set
      {
        this.meBayMotorsProAutoDeclineEnabled = value;
        this.meBayMotorsProAutoDeclineEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProAutoDeclineEnabledSpecified
    {
      get => this.meBayMotorsProAutoDeclineEnabledSpecified;
      set => this.meBayMotorsProAutoDeclineEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPaymentMethodEnabledCodeType eBayMotorsProPaymentMethodCheckOutEnabled
    {
      get => this.meBayMotorsProPaymentMethodCheckOutEnabled;
      set
      {
        this.meBayMotorsProPaymentMethodCheckOutEnabled = value;
        this.meBayMotorsProPaymentMethodCheckOutEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProPaymentMethodCheckOutEnabledSpecified
    {
      get => this.meBayMotorsProPaymentMethodCheckOutEnabledSpecified;
      set => this.meBayMotorsProPaymentMethodCheckOutEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProShippingMethodEnabled
    {
      get => this.meBayMotorsProShippingMethodEnabled;
      set
      {
        this.meBayMotorsProShippingMethodEnabled = value;
        this.meBayMotorsProShippingMethodEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProShippingMethodEnabledSpecified
    {
      get => this.meBayMotorsProShippingMethodEnabledSpecified;
      set => this.meBayMotorsProShippingMethodEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProCounterOfferEnabled
    {
      get => this.meBayMotorsProCounterOfferEnabled;
      set
      {
        this.meBayMotorsProCounterOfferEnabled = value;
        this.meBayMotorsProCounterOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProCounterOfferEnabledSpecified
    {
      get => this.meBayMotorsProCounterOfferEnabledSpecified;
      set => this.meBayMotorsProCounterOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayMotorsProSellerContactDetailsEnabled
    {
      get => this.meBayMotorsProSellerContactDetailsEnabled;
      set
      {
        this.meBayMotorsProSellerContactDetailsEnabled = value;
        this.meBayMotorsProSellerContactDetailsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayMotorsProSellerContactDetailsEnabledSpecified
    {
      get => this.meBayMotorsProSellerContactDetailsEnabledSpecified;
      set => this.meBayMotorsProSellerContactDetailsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdFormatEnabledCodeType LocalMarketAdFormatEnabled
    {
      get => this.mLocalMarketAdFormatEnabled;
      set
      {
        this.mLocalMarketAdFormatEnabled = value;
        this.mLocalMarketAdFormatEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketAdFormatEnabledSpecified
    {
      get => this.mLocalMarketAdFormatEnabledSpecified;
      set => this.mLocalMarketAdFormatEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketContactByPhoneEnabled
    {
      get => this.mLocalMarketContactByPhoneEnabled;
      set
      {
        this.mLocalMarketContactByPhoneEnabled = value;
        this.mLocalMarketContactByPhoneEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketContactByPhoneEnabledSpecified
    {
      get => this.mLocalMarketContactByPhoneEnabledSpecified;
      set => this.mLocalMarketContactByPhoneEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int LocalMarketPhoneCount
    {
      get => this.mLocalMarketPhoneCount;
      set
      {
        this.mLocalMarketPhoneCount = value;
        this.mLocalMarketPhoneCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketPhoneCountSpecified
    {
      get => this.mLocalMarketPhoneCountSpecified;
      set => this.mLocalMarketPhoneCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketContactByAddressEnabled
    {
      get => this.mLocalMarketContactByAddressEnabled;
      set
      {
        this.mLocalMarketContactByAddressEnabled = value;
        this.mLocalMarketContactByAddressEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketContactByAddressEnabledSpecified
    {
      get => this.mLocalMarketContactByAddressEnabledSpecified;
      set => this.mLocalMarketContactByAddressEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int LocalMarketStreetCount
    {
      get => this.mLocalMarketStreetCount;
      set
      {
        this.mLocalMarketStreetCount = value;
        this.mLocalMarketStreetCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketStreetCountSpecified
    {
      get => this.mLocalMarketStreetCountSpecified;
      set => this.mLocalMarketStreetCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketCompanyNameEnabled
    {
      get => this.mLocalMarketCompanyNameEnabled;
      set
      {
        this.mLocalMarketCompanyNameEnabled = value;
        this.mLocalMarketCompanyNameEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketCompanyNameEnabledSpecified
    {
      get => this.mLocalMarketCompanyNameEnabledSpecified;
      set => this.mLocalMarketCompanyNameEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketContactByEmailEnabled
    {
      get => this.mLocalMarketContactByEmailEnabled;
      set
      {
        this.mLocalMarketContactByEmailEnabled = value;
        this.mLocalMarketContactByEmailEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketContactByEmailEnabledSpecified
    {
      get => this.mLocalMarketContactByEmailEnabledSpecified;
      set => this.mLocalMarketContactByEmailEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdBestOfferEnabledCodeType LocalMarketBestOfferEnabled
    {
      get => this.mLocalMarketBestOfferEnabled;
      set
      {
        this.mLocalMarketBestOfferEnabled = value;
        this.mLocalMarketBestOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketBestOfferEnabledSpecified
    {
      get => this.mLocalMarketBestOfferEnabledSpecified;
      set => this.mLocalMarketBestOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketAutoAcceptEnabled
    {
      get => this.mLocalMarketAutoAcceptEnabled;
      set
      {
        this.mLocalMarketAutoAcceptEnabled = value;
        this.mLocalMarketAutoAcceptEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketAutoAcceptEnabledSpecified
    {
      get => this.mLocalMarketAutoAcceptEnabledSpecified;
      set => this.mLocalMarketAutoAcceptEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketAutoDeclineEnabled
    {
      get => this.mLocalMarketAutoDeclineEnabled;
      set
      {
        this.mLocalMarketAutoDeclineEnabled = value;
        this.mLocalMarketAutoDeclineEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketAutoDeclineEnabledSpecified
    {
      get => this.mLocalMarketAutoDeclineEnabledSpecified;
      set => this.mLocalMarketAutoDeclineEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPaymentMethodEnabledCodeType LocalMarketPaymentMethodCheckOutEnabled
    {
      get => this.mLocalMarketPaymentMethodCheckOutEnabled;
      set
      {
        this.mLocalMarketPaymentMethodCheckOutEnabled = value;
        this.mLocalMarketPaymentMethodCheckOutEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketPaymentMethodCheckOutEnabledSpecified
    {
      get => this.mLocalMarketPaymentMethodCheckOutEnabledSpecified;
      set => this.mLocalMarketPaymentMethodCheckOutEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketShippingMethodEnabled
    {
      get => this.mLocalMarketShippingMethodEnabled;
      set
      {
        this.mLocalMarketShippingMethodEnabled = value;
        this.mLocalMarketShippingMethodEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketShippingMethodEnabledSpecified
    {
      get => this.mLocalMarketShippingMethodEnabledSpecified;
      set => this.mLocalMarketShippingMethodEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketCounterOfferEnabled
    {
      get => this.mLocalMarketCounterOfferEnabled;
      set
      {
        this.mLocalMarketCounterOfferEnabled = value;
        this.mLocalMarketCounterOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketCounterOfferEnabledSpecified
    {
      get => this.mLocalMarketCounterOfferEnabledSpecified;
      set => this.mLocalMarketCounterOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalMarketSellerContactDetailsEnabled
    {
      get => this.mLocalMarketSellerContactDetailsEnabled;
      set
      {
        this.mLocalMarketSellerContactDetailsEnabled = value;
        this.mLocalMarketSellerContactDetailsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalMarketSellerContactDetailsEnabledSpecified
    {
      get => this.mLocalMarketSellerContactDetailsEnabledSpecified;
      set => this.mLocalMarketSellerContactDetailsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ClassifiedAdPhoneCount
    {
      get => this.mClassifiedAdPhoneCount;
      set
      {
        this.mClassifiedAdPhoneCount = value;
        this.mClassifiedAdPhoneCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdPhoneCountSpecified
    {
      get => this.mClassifiedAdPhoneCountSpecified;
      set => this.mClassifiedAdPhoneCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdContactByAddressEnabled
    {
      get => this.mClassifiedAdContactByAddressEnabled;
      set
      {
        this.mClassifiedAdContactByAddressEnabled = value;
        this.mClassifiedAdContactByAddressEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdContactByAddressEnabledSpecified
    {
      get => this.mClassifiedAdContactByAddressEnabledSpecified;
      set => this.mClassifiedAdContactByAddressEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ClassifiedAdStreetCount
    {
      get => this.mClassifiedAdStreetCount;
      set
      {
        this.mClassifiedAdStreetCount = value;
        this.mClassifiedAdStreetCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdStreetCountSpecified
    {
      get => this.mClassifiedAdStreetCountSpecified;
      set => this.mClassifiedAdStreetCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdCompanyNameEnabled
    {
      get => this.mClassifiedAdCompanyNameEnabled;
      set
      {
        this.mClassifiedAdCompanyNameEnabled = value;
        this.mClassifiedAdCompanyNameEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdCompanyNameEnabledSpecified
    {
      get => this.mClassifiedAdCompanyNameEnabledSpecified;
      set => this.mClassifiedAdCompanyNameEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GeographicExposureCodeType SpecialitySubscription
    {
      get => this.mSpecialitySubscription;
      set
      {
        this.mSpecialitySubscription = value;
        this.mSpecialitySubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SpecialitySubscriptionSpecified
    {
      get => this.mSpecialitySubscriptionSpecified;
      set => this.mSpecialitySubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GeographicExposureCodeType RegularSubscription
    {
      get => this.mRegularSubscription;
      set
      {
        this.mRegularSubscription = value;
        this.mRegularSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RegularSubscriptionSpecified
    {
      get => this.mRegularSubscriptionSpecified;
      set => this.mRegularSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GeographicExposureCodeType PremiumSubscription
    {
      get => this.mPremiumSubscription;
      set
      {
        this.mPremiumSubscription = value;
        this.mPremiumSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PremiumSubscriptionSpecified
    {
      get => this.mPremiumSubscriptionSpecified;
      set => this.mPremiumSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GeographicExposureCodeType NonSubscription
    {
      get => this.mNonSubscription;
      set
      {
        this.mNonSubscription = value;
        this.mNonSubscriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NonSubscriptionSpecified
    {
      get => this.mNonSubscriptionSpecified;
      set => this.mNonSubscriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalRequiredForStoreOwner
    {
      get => this.mPayPalRequiredForStoreOwner;
      set
      {
        this.mPayPalRequiredForStoreOwner = value;
        this.mPayPalRequiredForStoreOwnerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalRequiredForStoreOwnerSpecified
    {
      get => this.mPayPalRequiredForStoreOwnerSpecified;
      set => this.mPayPalRequiredForStoreOwnerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReviseQuantityAllowed
    {
      get => this.mReviseQuantityAllowed;
      set
      {
        this.mReviseQuantityAllowed = value;
        this.mReviseQuantityAllowedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReviseQuantityAllowedSpecified
    {
      get => this.mReviseQuantityAllowedSpecified;
      set => this.mReviseQuantityAllowedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RevisePriceAllowed
    {
      get => this.mRevisePriceAllowed;
      set
      {
        this.mRevisePriceAllowed = value;
        this.mRevisePriceAllowedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RevisePriceAllowedSpecified
    {
      get => this.mRevisePriceAllowedSpecified;
      set => this.mRevisePriceAllowedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool StoreOwnerExtendedListingDurationsEnabled
    {
      get => this.mStoreOwnerExtendedListingDurationsEnabled;
      set
      {
        this.mStoreOwnerExtendedListingDurationsEnabled = value;
        this.mStoreOwnerExtendedListingDurationsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreOwnerExtendedListingDurationsEnabledSpecified
    {
      get => this.mStoreOwnerExtendedListingDurationsEnabledSpecified;
      set => this.mStoreOwnerExtendedListingDurationsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreOwnerExtendedListingDurationsType StoreOwnerExtendedListingDurations
    {
      get => this.mStoreOwnerExtendedListingDurations;
      set => this.mStoreOwnerExtendedListingDurations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReturnPolicyEnabled
    {
      get => this.mReturnPolicyEnabled;
      set
      {
        this.mReturnPolicyEnabled = value;
        this.mReturnPolicyEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnPolicyEnabledSpecified
    {
      get => this.mReturnPolicyEnabledSpecified;
      set => this.mReturnPolicyEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HandlingTimeEnabled
    {
      get => this.mHandlingTimeEnabled;
      set
      {
        this.mHandlingTimeEnabled = value;
        this.mHandlingTimeEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HandlingTimeEnabledSpecified
    {
      get => this.mHandlingTimeEnabledSpecified;
      set => this.mHandlingTimeEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MaxFlatShippingCost
    {
      get => this.mMaxFlatShippingCost;
      set => this.mMaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool MaxFlatShippingCostCBTExempt
    {
      get => this.mMaxFlatShippingCostCBTExempt;
      set
      {
        this.mMaxFlatShippingCostCBTExempt = value;
        this.mMaxFlatShippingCostCBTExemptSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxFlatShippingCostCBTExemptSpecified
    {
      get => this.mMaxFlatShippingCostCBTExemptSpecified;
      set => this.mMaxFlatShippingCostCBTExemptSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Group1MaxFlatShippingCost
    {
      get => this.mGroup1MaxFlatShippingCost;
      set => this.mGroup1MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Group2MaxFlatShippingCost
    {
      get => this.mGroup2MaxFlatShippingCost;
      set => this.mGroup2MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Group3MaxFlatShippingCost
    {
      get => this.mGroup3MaxFlatShippingCost;
      set => this.mGroup3MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PaymentMethod")]
    public BuyerPaymentMethodCodeTypeCollection PaymentMethod
    {
      get => this.mPaymentMethod;
      set => this.mPaymentMethod = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool VariationsEnabled
    {
      get => this.mVariationsEnabled;
      set
      {
        this.mVariationsEnabled = value;
        this.mVariationsEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VariationsEnabledSpecified
    {
      get => this.mVariationsEnabledSpecified;
      set => this.mVariationsEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AttributeConversionEnabledCodeType AttributeConversionEnabled
    {
      get => this.mAttributeConversionEnabled;
      set
      {
        this.mAttributeConversionEnabled = value;
        this.mAttributeConversionEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AttributeConversionEnabledSpecified
    {
      get => this.mAttributeConversionEnabledSpecified;
      set => this.mAttributeConversionEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FreeGalleryPlusEnabled
    {
      get => this.mFreeGalleryPlusEnabled;
      set
      {
        this.mFreeGalleryPlusEnabled = value;
        this.mFreeGalleryPlusEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FreeGalleryPlusEnabledSpecified
    {
      get => this.mFreeGalleryPlusEnabledSpecified;
      set => this.mFreeGalleryPlusEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FreePicturePackEnabled
    {
      get => this.mFreePicturePackEnabled;
      set
      {
        this.mFreePicturePackEnabled = value;
        this.mFreePicturePackEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FreePicturePackEnabledSpecified
    {
      get => this.mFreePicturePackEnabledSpecified;
      set => this.mFreePicturePackEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemCompatibilityEnabledCodeType ItemCompatibilityEnabled
    {
      get => this.mItemCompatibilityEnabled;
      set
      {
        this.mItemCompatibilityEnabled = value;
        this.mItemCompatibilityEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemCompatibilityEnabledSpecified
    {
      get => this.mItemCompatibilityEnabledSpecified;
      set => this.mItemCompatibilityEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MinItemCompatibility
    {
      get => this.mMinItemCompatibility;
      set
      {
        this.mMinItemCompatibility = value;
        this.mMinItemCompatibilitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinItemCompatibilitySpecified
    {
      get => this.mMinItemCompatibilitySpecified;
      set => this.mMinItemCompatibilitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxItemCompatibility
    {
      get => this.mMaxItemCompatibility;
      set
      {
        this.mMaxItemCompatibility = value;
        this.mMaxItemCompatibilitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxItemCompatibilitySpecified
    {
      get => this.mMaxItemCompatibilitySpecified;
      set => this.mMaxItemCompatibilitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ConditionEnabledCodeType ConditionEnabled
    {
      get => this.mConditionEnabled;
      set
      {
        this.mConditionEnabled = value;
        this.mConditionEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ConditionEnabledSpecified
    {
      get => this.mConditionEnabledSpecified;
      set => this.mConditionEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ConditionValuesType ConditionValues
    {
      get => this.mConditionValues;
      set => this.mConditionValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ValueCategory
    {
      get => this.mValueCategory;
      set
      {
        this.mValueCategory = value;
        this.mValueCategorySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ValueCategorySpecified
    {
      get => this.mValueCategorySpecified;
      set => this.mValueCategorySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductCreationEnabledCodeType ProductCreationEnabled
    {
      get => this.mProductCreationEnabled;
      set
      {
        this.mProductCreationEnabled = value;
        this.mProductCreationEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProductCreationEnabledSpecified
    {
      get => this.mProductCreationEnabledSpecified;
      set => this.mProductCreationEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductIdentiferEnabledCodeType EANEnabled
    {
      get => this.mEANEnabled;
      set
      {
        this.mEANEnabled = value;
        this.mEANEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EANEnabledSpecified
    {
      get => this.mEANEnabledSpecified;
      set => this.mEANEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductIdentiferEnabledCodeType ISBNEnabled
    {
      get => this.mISBNEnabled;
      set
      {
        this.mISBNEnabled = value;
        this.mISBNEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ISBNEnabledSpecified
    {
      get => this.mISBNEnabledSpecified;
      set => this.mISBNEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductIdentiferEnabledCodeType UPCEnabled
    {
      get => this.mUPCEnabled;
      set
      {
        this.mUPCEnabled = value;
        this.mUPCEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UPCEnabledSpecified
    {
      get => this.mUPCEnabledSpecified;
      set => this.mUPCEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxGranularFitmentCount
    {
      get => this.mMaxGranularFitmentCount;
      set
      {
        this.mMaxGranularFitmentCount = value;
        this.mMaxGranularFitmentCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxGranularFitmentCountSpecified
    {
      get => this.mMaxGranularFitmentCountSpecified;
      set => this.mMaxGranularFitmentCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CompatibleVehicleType
    {
      get => this.mCompatibleVehicleType;
      set => this.mCompatibleVehicleType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentOptionsGroupEnabledCodeType PaymentOptionsGroup
    {
      get => this.mPaymentOptionsGroup;
      set
      {
        this.mPaymentOptionsGroup = value;
        this.mPaymentOptionsGroupSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentOptionsGroupSpecified
    {
      get => this.mPaymentOptionsGroupSpecified;
      set => this.mPaymentOptionsGroupSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupCodeType ShippingProfileCategoryGroup
    {
      get => this.mShippingProfileCategoryGroup;
      set
      {
        this.mShippingProfileCategoryGroup = value;
        this.mShippingProfileCategoryGroupSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingProfileCategoryGroupSpecified
    {
      get => this.mShippingProfileCategoryGroupSpecified;
      set => this.mShippingProfileCategoryGroupSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupCodeType PaymentProfileCategoryGroup
    {
      get => this.mPaymentProfileCategoryGroup;
      set
      {
        this.mPaymentProfileCategoryGroup = value;
        this.mPaymentProfileCategoryGroupSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentProfileCategoryGroupSpecified
    {
      get => this.mPaymentProfileCategoryGroupSpecified;
      set => this.mPaymentProfileCategoryGroupSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupCodeType ReturnPolicyProfileCategoryGroup
    {
      get => this.mReturnPolicyProfileCategoryGroup;
      set
      {
        this.mReturnPolicyProfileCategoryGroup = value;
        this.mReturnPolicyProfileCategoryGroupSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnPolicyProfileCategoryGroupSpecified
    {
      get => this.mReturnPolicyProfileCategoryGroupSpecified;
      set => this.mReturnPolicyProfileCategoryGroupSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool VINSupported
    {
      get => this.mVINSupported;
      set
      {
        this.mVINSupported = value;
        this.mVINSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VINSupportedSpecified
    {
      get => this.mVINSupportedSpecified;
      set => this.mVINSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool VRMSupported
    {
      get => this.mVRMSupported;
      set
      {
        this.mVRMSupported = value;
        this.mVRMSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VRMSupportedSpecified
    {
      get => this.mVRMSupportedSpecified;
      set => this.mVRMSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerProvidedTitleSupported
    {
      get => this.mSellerProvidedTitleSupported;
      set
      {
        this.mSellerProvidedTitleSupported = value;
        this.mSellerProvidedTitleSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerProvidedTitleSupportedSpecified
    {
      get => this.mSellerProvidedTitleSupportedSpecified;
      set => this.mSellerProvidedTitleSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DepositSupported
    {
      get => this.mDepositSupported;
      set
      {
        this.mDepositSupported = value;
        this.mDepositSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DepositSupportedSpecified
    {
      get => this.mDepositSupportedSpecified;
      set => this.mDepositSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GlobalShippingEnabled
    {
      get => this.mGlobalShippingEnabled;
      set
      {
        this.mGlobalShippingEnabled = value;
        this.mGlobalShippingEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GlobalShippingEnabledSpecified
    {
      get => this.mGlobalShippingEnabledSpecified;
      set => this.mGlobalShippingEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AdditionalCompatibilityEnabled
    {
      get => this.mAdditionalCompatibilityEnabled;
      set
      {
        this.mAdditionalCompatibilityEnabled = value;
        this.mAdditionalCompatibilityEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AdditionalCompatibilityEnabledSpecified
    {
      get => this.mAdditionalCompatibilityEnabledSpecified;
      set => this.mAdditionalCompatibilityEnabledSpecified = value;
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

    /// <summary>
    /// 
    /// </summary>
    public bool PickupDropOffEnabled
    {
      get => this.mPickupDropOffEnabled;
      set
      {
        this.mPickupDropOffEnabled = value;
        this.mPickupDropOffEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PickupDropOffEnabledSpecified
    {
      get => this.mPickupDropOffEnabledSpecified;
      set => this.mPickupDropOffEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DigitalGoodDeliveryEnabled
    {
      get => this.mDigitalGoodDeliveryEnabled;
      set
      {
        this.mDigitalGoodDeliveryEnabled = value;
        this.mDigitalGoodDeliveryEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DigitalGoodDeliveryEnabledSpecified
    {
      get => this.mDigitalGoodDeliveryEnabledSpecified;
      set => this.mDigitalGoodDeliveryEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EpidSupported
    {
      get => this.mEpidSupported;
      set
      {
        this.mEpidSupported = value;
        this.mEpidSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EpidSupportedSpecified
    {
      get => this.mEpidSupportedSpecified;
      set => this.mEpidSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool KTypeSupported
    {
      get => this.mKTypeSupported;
      set
      {
        this.mKTypeSupported = value;
        this.mKTypeSupportedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool KTypeSupportedSpecified
    {
      get => this.mKTypeSupportedSpecified;
      set => this.mKTypeSupportedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductRequiredEnabledCodeType ProductRequiredEnabled
    {
      get => this.mProductRequiredEnabled;
      set
      {
        this.mProductRequiredEnabled = value;
        this.mProductRequiredEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProductRequiredEnabledSpecified
    {
      get => this.mProductRequiredEnabledSpecified;
      set => this.mProductRequiredEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsAcceptedCodeType DomesticReturnsAcceptedValues
    {
      get => this.mDomesticReturnsAcceptedValues;
      set => this.mDomesticReturnsAcceptedValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsAcceptedCodeType InternationalReturnsAcceptedValues
    {
      get => this.mInternationalReturnsAcceptedValues;
      set => this.mInternationalReturnsAcceptedValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsDurationCodeType DomesticReturnsDurationValues
    {
      get => this.mDomesticReturnsDurationValues;
      set => this.mDomesticReturnsDurationValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsDurationCodeType InternationalReturnsDurationValues
    {
      get => this.mInternationalReturnsDurationValues;
      set => this.mInternationalReturnsDurationValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsShipmentPayeeCodeType DomesticReturnsShipmentPayeeValues
    {
      get => this.mDomesticReturnsShipmentPayeeValues;
      set => this.mDomesticReturnsShipmentPayeeValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsShipmentPayeeCodeType InternationalReturnsShipmentPayeeValues
    {
      get => this.mInternationalReturnsShipmentPayeeValues;
      set => this.mInternationalReturnsShipmentPayeeValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticRefundMethodCodeType DomesticRefundMethodValues
    {
      get => this.mDomesticRefundMethodValues;
      set => this.mDomesticRefundMethodValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalRefundMethodCodeType InternationalRefundMethodValues
    {
      get => this.mInternationalRefundMethodValues;
      set => this.mInternationalRefundMethodValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReturnPolicyDescriptionEnabled
    {
      get => this.mReturnPolicyDescriptionEnabled;
      set
      {
        this.mReturnPolicyDescriptionEnabled = value;
        this.mReturnPolicyDescriptionEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnPolicyDescriptionEnabledSpecified
    {
      get => this.mReturnPolicyDescriptionEnabledSpecified;
      set => this.mReturnPolicyDescriptionEnabledSpecified = value;
    }
  }
}
