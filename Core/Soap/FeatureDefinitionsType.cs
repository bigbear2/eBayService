// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FeatureDefinitionsType
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
  public class FeatureDefinitionsType
  {
    private ListingDurationDefinitionsType mListingDurations;
    private ShippingTermRequiredDefinitionType mShippingTermsRequired;
    private BestOfferEnabledDefinitionType mBestOfferEnabled;
    private DutchBINEnabledDefinitionType mDutchBINEnabled;
    private UserConsentRequiredDefinitionType mUserConsentRequired;
    private HomePageFeaturedEnabledDefinitionType mHomePageFeaturedEnabled;
    private ProPackEnabledDefinitionType mProPackEnabled;
    private BasicUpgradePackEnabledDefinitionType mBasicUpgradePackEnabled;
    private ValuePackEnabledDefinitionType mValuePackEnabled;
    private ProPackPlusEnabledDefinitionType mProPackPlusEnabled;
    private AdFormatEnabledDefinitionType mAdFormatEnabled;
    private BestOfferCounterEnabledDefinitionType mBestOfferCounterEnabled;
    private BestOfferAutoDeclineEnabledDefinitionType mBestOfferAutoDeclineEnabled;
    private LocalMarketSpecialitySubscriptionDefinitionType mLocalMarketSpecialitySubscription;
    private LocalMarketRegularSubscriptionDefinitionType mLocalMarketRegularSubscription;
    private LocalMarketPremiumSubscriptionDefinitionType mLocalMarketPremiumSubscription;
    private LocalMarketNonSubscriptionDefinitionType mLocalMarketNonSubscription;
    private ExpressEnabledDefinitionType mExpressEnabled;
    private ExpressPicturesRequiredDefinitionType mExpressPicturesRequired;
    private ExpressConditionRequiredDefinitionType mExpressConditionRequired;
    private MinimumReservePriceDefinitionType mMinimumReservePrice;
    private TCREnabledDefinitionType mTransactionConfirmationRequestEnabled;
    private SellerContactDetailsEnabledDefinitionType mSellerContactDetailsEnabled;
    private StoreInventoryEnabledDefinitionType mStoreInventoryEnabled;
    private SkypeMeTransactionalEnabledDefinitionType mSkypeMeTransactionalEnabled;
    private SkypeMeNonTransactionalEnabledDefinitionType mSkypeMeNonTransactionalEnabled;
    private LocalListingDistancesRegularDefinitionType mLocalListingDistancesRegular;
    private LocalListingDistancesSpecialtyDefinitionType mLocalListingDistancesSpecialty;
    private LocalListingDistancesNonSubscriptionDefinitionType mLocalListingDistancesNonSubscription;
    private ClassifiedAdPaymentMethodEnabledDefinitionType mClassifiedAdPaymentMethodEnabled;
    private ClassifiedAdShippingMethodEnabledDefinitionType mClassifiedAdShippingMethodEnabled;
    private ClassifiedAdBestOfferEnabledDefinitionType mClassifiedAdBestOfferEnabled;
    private ClassifiedAdCounterOfferEnabledDefinitionType mClassifiedAdCounterOfferEnabled;
    private ClassifiedAdAutoDeclineEnabledDefinitionType mClassifiedAdAutoDeclineEnabled;
    private ClassifiedAdContactByPhoneEnabledDefinitionType mClassifiedAdContactByPhoneEnabled;
    private ClassifiedAdContactByEmailEnabledDefintionType mClassifiedAdContactByEmailEnabled;
    private SafePaymentRequiredDefinitionType mSafePaymentRequired;
    private ClassifiedAdPayPerLeadEnabledDefinitionType mClassifiedAdPayPerLeadEnabled;
    private ItemSpecificsEnabledDefinitionType mItemSpecificsEnabled;
    private PaisaPayFullEscrowEnabledDefinitionType mPaisaPayFullEscrowEnabled;
    private ISBNIdentifierEnabledDefinitionType mISBNIdentifierEnabled;
    private UPCIdentifierEnabledDefinitionType mUPCIdentifierEnabled;
    private EANIdentifierEnabledDefinitionType mEANIdentifierEnabled;
    private BrandMPNIdentifierEnabledDefinitionType mBrandMPNIdentifierEnabled;
    private BestOfferAutoAcceptEnabledDefinitionType mBestOfferAutoAcceptEnabled;
    private ClassifiedAdAutoAcceptEnabledDefinitionType mClassifiedAdAutoAcceptEnabled;
    private CrossBorderTradeNorthAmericaEnabledDefinitionType mCrossBorderTradeNorthAmericaEnabled;
    private CrossBorderTradeGBEnabledDefinitionType mCrossBorderTradeGBEnabled;
    private CrossBorderTradeAustraliaEnabledDefinitionType mCrossBorderTradeAustraliaEnabled;
    private PayPalBuyerProtectionEnabledDefinitionType mPayPalBuyerProtectionEnabled;
    private BuyerGuaranteeEnabledDefinitionType mBuyerGuaranteeEnabled;
    private CombinedFixedPriceTreatmentEnabledDefinitionType mCombinedFixedPriceTreatmentEnabled;
    private ListingEnhancementDurationDefinitionType mGalleryFeaturedDurations;
    private INEscrowWorkflowTimelineDefinitionType mINEscrowWorkflowTimeline;
    private PayPalRequiredDefinitionType mPayPalRequired;
    private eBayMotorsProAdFormatEnabledDefinitionType meBayMotorsProAdFormatEnabled;
    private eBayMotorsProContactByPhoneEnabledDefinitionType meBayMotorsProContactByPhoneEnabled;
    private eBayMotorsProPhoneCountDefinitionType meBayMotorsProPhoneCount;
    private eBayMotorsProContactByAddressEnabledDefinitionType meBayMotorsProContactByAddressEnabled;
    private eBayMotorsProStreetCountDefinitionType meBayMotorsProStreetCount;
    private eBayMotorsProCompanyNameEnabledDefinitionType meBayMotorsProCompanyNameEnabled;
    private eBayMotorsProContactByEmailEnabledDefinitionType meBayMotorsProContactByEmailEnabled;
    private eBayMotorsProBestOfferEnabledDefinitionType meBayMotorsProBestOfferEnabled;
    private eBayMotorsProAutoAcceptEnabledDefinitionType meBayMotorsProAutoAcceptEnabled;
    private eBayMotorsProAutoDeclineEnabledDefinitionType meBayMotorsProAutoDeclineEnabled;
    private eBayMotorsProPaymentMethodCheckOutEnabledDefinitionType meBayMotorsProPaymentMethodCheckOutEnabled;
    private eBayMotorsProShippingMethodEnabledDefinitionType meBayMotorsProShippingMethodEnabled;
    private eBayMotorsProCounterOfferEnabledDefinitionType meBayMotorsProCounterOfferEnabled;
    private eBayMotorsProSellerContactDetailsEnabledDefinitionType meBayMotorsProSellerContactDetailsEnabled;
    private LocalMarketAdFormatEnabledDefinitionType mLocalMarketAdFormatEnabled;
    private LocalMarketContactByPhoneEnabledDefinitionType mLocalMarketContactByPhoneEnabled;
    private LocalMarketPhoneCountDefinitionType mLocalMarketPhoneCount;
    private LocalMarketContactByAddressEnabledDefinitionType mLocalMarketContactByAddressEnabled;
    private LocalMarketStreetCountDefinitionType mLocalMarketStreetCount;
    private LocalMarketCompanyNameEnabledDefinitionType mLocalMarketCompanyNameEnabled;
    private LocalMarketContactByEmailEnabledDefinitionType mLocalMarketContactByEmailEnabled;
    private LocalMarketBestOfferEnabledDefinitionType mLocalMarketBestOfferEnabled;
    private LocalMarketAutoAcceptEnabledDefinitionType mLocalMarketAutoAcceptEnabled;
    private LocalMarketAutoDeclineEnabledDefinitionType mLocalMarketAutoDeclineEnabled;
    private LocalMarketPaymentMethodCheckOutEnabledDefinitionType mLocalMarketPaymentMethodCheckOutEnabled;
    private LocalMarketShippingMethodEnabledDefinitionType mLocalMarketShippingMethodEnabled;
    private LocalMarketCounterOfferEnabledDefinitionType mLocalMarketCounterOfferEnabled;
    private LocalMarketSellerContactDetailsEnabledDefinitionType mLocalMarketSellerContactDetailsEnabled;
    private ClassifiedAdPhoneCountDefinitionType mClassifiedAdPhoneCount;
    private ClassifiedAdContactByAddressEnabledDefinitionType mClassifiedAdContactByAddressEnabled;
    private ClassifiedAdStreetCountDefinitionType mClassifiedAdStreetCount;
    private ClassifiedAdCompanyNameEnabledDefinitionType mClassifiedAdCompanyNameEnabled;
    private SpecialitySubscriptionDefinitionType mSpecialitySubscription;
    private RegularSubscriptionDefinitionType mRegularSubscription;
    private PremiumSubscriptionDefinitionType mPremiumSubscription;
    private NonSubscriptionDefinitionType mNonSubscription;
    private ReturnPolicyEnabledDefinitionType mReturnPolicyEnabled;
    private HandlingTimeEnabledDefinitionType mHandlingTimeEnabled;
    private PayPalRequiredForStoreOwnerDefinitionType mPayPalRequiredForStoreOwner;
    private ReviseQuantityAllowedDefinitionType mReviseQuantityAllowed;
    private RevisePriceAllowedDefinitionType mRevisePriceAllowed;
    private StoreOwnerExtendedListingDurationsEnabledDefinitionType mStoreOwnerExtendedListingDurationsEnabled;
    private StoreOwnerExtendedListingDurationsDefinitionType mStoreOwnerExtendedListingDurations;
    private PaymentMethodDefinitionType mPaymentMethod;
    private Group1MaxFlatShippingCostDefinitionType mGroup1MaxFlatShippingCost;
    private Group2MaxFlatShippingCostDefinitionType mGroup2MaxFlatShippingCost;
    private Group3MaxFlatShippingCostDefinitionType mGroup3MaxFlatShippingCost;
    private MaxFlatShippingCostCBTExemptDefinitionType mMaxFlatShippingCostCBTExempt;
    private MaxFlatShippingCostDefinitionType mMaxFlatShippingCost;
    private VariationsEnabledDefinitionType mVariationsEnabled;
    private AttributeConversionEnabledFeatureDefinitionType mAttributeConversionEnabled;
    private FreeGalleryPlusEnabledDefinitionType mFreeGalleryPlusEnabled;
    private FreePicturePackEnabledDefinitionType mFreePicturePackEnabled;
    private ItemCompatibilityEnabledDefinitionType mItemCompatibilityEnabled;
    private MaxItemCompatibilityDefinitionType mMaxItemCompatibility;
    private MinItemCompatibilityDefinitionType mMinItemCompatibility;
    private ConditionEnabledDefinitionType mConditionEnabled;
    private ConditionValuesDefinitionType mConditionValues;
    private ValueCategoryDefinitionType mValueCategory;
    private ProductCreationEnabledDefinitionType mProductCreationEnabled;
    private EANEnabledDefinitionType mEANEnabled;
    private ISBNEnabledDefinitionType mISBNEnabled;
    private UPCEnabledDefinitionType mUPCEnabled;
    private CompatibleVehicleTypeDefinitionType mCompatibleVehicleType;
    private MaxGranularFitmentCountDefinitionType mMaxGranularFitmentCount;
    private PaymentOptionsGroupEnabledDefinitionType mPaymentOptionsGroup;
    private ProfileCategoryGroupDefinitionType mShippingProfileCategoryGroup;
    private ProfileCategoryGroupDefinitionType mPaymentProfileCategoryGroup;
    private ProfileCategoryGroupDefinitionType mReturnPolicyProfileCategoryGroup;
    private VINSupportedDefinitionType mVINSupported;
    private VRMSupportedDefinitionType mVRMSupported;
    private SellerProvidedTitleSupportedDefinitionType mSellerProvidedTitleSupported;
    private DepositSupportedDefinitionType mDepositSupported;
    private GlobalShippingEnabledDefinitionType mGlobalShippingEnabled;
    private AdditionalCompatibilityEnabledDefinitionType mAdditionalCompatibilityEnabled;
    private XmlElementCollection mAny;
    private PickupDropOffEnabledDefinitionType mPickupDropOffEnabled;
    private DigitalGoodDeliveryEnabledDefinitionType mDigitalGoodDeliveryEnabled;
    private EpidSupportedDefinitionType mEpidSupported;
    private KTypeSupportedDefinitionType mKTypeSupported;
    private ProductRequiredEnabledDefinitionType mProductRequiredEnabled;
    private DomesticReturnsAcceptedDefinitionType mDomesticReturnsAcceptedValues;
    private InternationalReturnsAcceptedDefinitionType mInternationalReturnsAcceptedValues;
    private DomesticReturnsDurationDefinitionType mDomesticReturnsDurationValues;
    private InternationalReturnsDurationDefinitionType mInternationalReturnsDurationValues;
    private DomesticReturnsShipmentPayeeDefinitionType mDomesticReturnsShipmentPayeeValues;
    private InternationalReturnsShipmentPayeeDefinitionType mInternationalReturnsShipmentPayeeValues;
    private DomesticRefundMethodCodeType mDomesticRefundMethodValues;
    private InternationalRefundMethodCodeType mInternationalRefundMethodValues;
    private ReturnPolicyDescriptionEnabledDefinitionType mReturnPolicyDescriptionEnabled;

    /// <summary>
    /// 
    /// </summary>
    public ListingDurationDefinitionsType ListingDurations
    {
      get => this.mListingDurations;
      set => this.mListingDurations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingTermRequiredDefinitionType ShippingTermsRequired
    {
      get => this.mShippingTermsRequired;
      set => this.mShippingTermsRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferEnabledDefinitionType BestOfferEnabled
    {
      get => this.mBestOfferEnabled;
      set => this.mBestOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DutchBINEnabledDefinitionType DutchBINEnabled
    {
      get => this.mDutchBINEnabled;
      set => this.mDutchBINEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserConsentRequiredDefinitionType UserConsentRequired
    {
      get => this.mUserConsentRequired;
      set => this.mUserConsentRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public HomePageFeaturedEnabledDefinitionType HomePageFeaturedEnabled
    {
      get => this.mHomePageFeaturedEnabled;
      set => this.mHomePageFeaturedEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProPackEnabledDefinitionType ProPackEnabled
    {
      get => this.mProPackEnabled;
      set => this.mProPackEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BasicUpgradePackEnabledDefinitionType BasicUpgradePackEnabled
    {
      get => this.mBasicUpgradePackEnabled;
      set => this.mBasicUpgradePackEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ValuePackEnabledDefinitionType ValuePackEnabled
    {
      get => this.mValuePackEnabled;
      set => this.mValuePackEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProPackPlusEnabledDefinitionType ProPackPlusEnabled
    {
      get => this.mProPackPlusEnabled;
      set => this.mProPackPlusEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdFormatEnabledDefinitionType AdFormatEnabled
    {
      get => this.mAdFormatEnabled;
      set => this.mAdFormatEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferCounterEnabledDefinitionType BestOfferCounterEnabled
    {
      get => this.mBestOfferCounterEnabled;
      set => this.mBestOfferCounterEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferAutoDeclineEnabledDefinitionType BestOfferAutoDeclineEnabled
    {
      get => this.mBestOfferAutoDeclineEnabled;
      set => this.mBestOfferAutoDeclineEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketSpecialitySubscriptionDefinitionType LocalMarketSpecialitySubscription
    {
      get => this.mLocalMarketSpecialitySubscription;
      set => this.mLocalMarketSpecialitySubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketRegularSubscriptionDefinitionType LocalMarketRegularSubscription
    {
      get => this.mLocalMarketRegularSubscription;
      set => this.mLocalMarketRegularSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketPremiumSubscriptionDefinitionType LocalMarketPremiumSubscription
    {
      get => this.mLocalMarketPremiumSubscription;
      set => this.mLocalMarketPremiumSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketNonSubscriptionDefinitionType LocalMarketNonSubscription
    {
      get => this.mLocalMarketNonSubscription;
      set => this.mLocalMarketNonSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ExpressEnabledDefinitionType ExpressEnabled
    {
      get => this.mExpressEnabled;
      set => this.mExpressEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ExpressPicturesRequiredDefinitionType ExpressPicturesRequired
    {
      get => this.mExpressPicturesRequired;
      set => this.mExpressPicturesRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ExpressConditionRequiredDefinitionType ExpressConditionRequired
    {
      get => this.mExpressConditionRequired;
      set => this.mExpressConditionRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MinimumReservePriceDefinitionType MinimumReservePrice
    {
      get => this.mMinimumReservePrice;
      set => this.mMinimumReservePrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TCREnabledDefinitionType TransactionConfirmationRequestEnabled
    {
      get => this.mTransactionConfirmationRequestEnabled;
      set => this.mTransactionConfirmationRequestEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerContactDetailsEnabledDefinitionType SellerContactDetailsEnabled
    {
      get => this.mSellerContactDetailsEnabled;
      set => this.mSellerContactDetailsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreInventoryEnabledDefinitionType StoreInventoryEnabled
    {
      get => this.mStoreInventoryEnabled;
      set => this.mStoreInventoryEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SkypeMeTransactionalEnabledDefinitionType SkypeMeTransactionalEnabled
    {
      get => this.mSkypeMeTransactionalEnabled;
      set => this.mSkypeMeTransactionalEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SkypeMeNonTransactionalEnabledDefinitionType SkypeMeNonTransactionalEnabled
    {
      get => this.mSkypeMeNonTransactionalEnabled;
      set => this.mSkypeMeNonTransactionalEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalListingDistancesRegularDefinitionType LocalListingDistancesRegular
    {
      get => this.mLocalListingDistancesRegular;
      set => this.mLocalListingDistancesRegular = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalListingDistancesSpecialtyDefinitionType LocalListingDistancesSpecialty
    {
      get => this.mLocalListingDistancesSpecialty;
      set => this.mLocalListingDistancesSpecialty = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalListingDistancesNonSubscriptionDefinitionType LocalListingDistancesNonSubscription
    {
      get => this.mLocalListingDistancesNonSubscription;
      set => this.mLocalListingDistancesNonSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPaymentMethodEnabledDefinitionType ClassifiedAdPaymentMethodEnabled
    {
      get => this.mClassifiedAdPaymentMethodEnabled;
      set => this.mClassifiedAdPaymentMethodEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdShippingMethodEnabledDefinitionType ClassifiedAdShippingMethodEnabled
    {
      get => this.mClassifiedAdShippingMethodEnabled;
      set => this.mClassifiedAdShippingMethodEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdBestOfferEnabledDefinitionType ClassifiedAdBestOfferEnabled
    {
      get => this.mClassifiedAdBestOfferEnabled;
      set => this.mClassifiedAdBestOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdCounterOfferEnabledDefinitionType ClassifiedAdCounterOfferEnabled
    {
      get => this.mClassifiedAdCounterOfferEnabled;
      set => this.mClassifiedAdCounterOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdAutoDeclineEnabledDefinitionType ClassifiedAdAutoDeclineEnabled
    {
      get => this.mClassifiedAdAutoDeclineEnabled;
      set => this.mClassifiedAdAutoDeclineEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdContactByPhoneEnabledDefinitionType ClassifiedAdContactByPhoneEnabled
    {
      get => this.mClassifiedAdContactByPhoneEnabled;
      set => this.mClassifiedAdContactByPhoneEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdContactByEmailEnabledDefintionType ClassifiedAdContactByEmailEnabled
    {
      get => this.mClassifiedAdContactByEmailEnabled;
      set => this.mClassifiedAdContactByEmailEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SafePaymentRequiredDefinitionType SafePaymentRequired
    {
      get => this.mSafePaymentRequired;
      set => this.mSafePaymentRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPayPerLeadEnabledDefinitionType ClassifiedAdPayPerLeadEnabled
    {
      get => this.mClassifiedAdPayPerLeadEnabled;
      set => this.mClassifiedAdPayPerLeadEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSpecificsEnabledDefinitionType ItemSpecificsEnabled
    {
      get => this.mItemSpecificsEnabled;
      set => this.mItemSpecificsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaisaPayFullEscrowEnabledDefinitionType PaisaPayFullEscrowEnabled
    {
      get => this.mPaisaPayFullEscrowEnabled;
      set => this.mPaisaPayFullEscrowEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ISBNIdentifierEnabledDefinitionType ISBNIdentifierEnabled
    {
      get => this.mISBNIdentifierEnabled;
      set => this.mISBNIdentifierEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UPCIdentifierEnabledDefinitionType UPCIdentifierEnabled
    {
      get => this.mUPCIdentifierEnabled;
      set => this.mUPCIdentifierEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EANIdentifierEnabledDefinitionType EANIdentifierEnabled
    {
      get => this.mEANIdentifierEnabled;
      set => this.mEANIdentifierEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BrandMPNIdentifierEnabledDefinitionType BrandMPNIdentifierEnabled
    {
      get => this.mBrandMPNIdentifierEnabled;
      set => this.mBrandMPNIdentifierEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferAutoAcceptEnabledDefinitionType BestOfferAutoAcceptEnabled
    {
      get => this.mBestOfferAutoAcceptEnabled;
      set => this.mBestOfferAutoAcceptEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdAutoAcceptEnabledDefinitionType ClassifiedAdAutoAcceptEnabled
    {
      get => this.mClassifiedAdAutoAcceptEnabled;
      set => this.mClassifiedAdAutoAcceptEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CrossBorderTradeNorthAmericaEnabledDefinitionType CrossBorderTradeNorthAmericaEnabled
    {
      get => this.mCrossBorderTradeNorthAmericaEnabled;
      set => this.mCrossBorderTradeNorthAmericaEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CrossBorderTradeGBEnabledDefinitionType CrossBorderTradeGBEnabled
    {
      get => this.mCrossBorderTradeGBEnabled;
      set => this.mCrossBorderTradeGBEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CrossBorderTradeAustraliaEnabledDefinitionType CrossBorderTradeAustraliaEnabled
    {
      get => this.mCrossBorderTradeAustraliaEnabled;
      set => this.mCrossBorderTradeAustraliaEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalBuyerProtectionEnabledDefinitionType PayPalBuyerProtectionEnabled
    {
      get => this.mPayPalBuyerProtectionEnabled;
      set => this.mPayPalBuyerProtectionEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerGuaranteeEnabledDefinitionType BuyerGuaranteeEnabled
    {
      get => this.mBuyerGuaranteeEnabled;
      set => this.mBuyerGuaranteeEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CombinedFixedPriceTreatmentEnabledDefinitionType CombinedFixedPriceTreatmentEnabled
    {
      get => this.mCombinedFixedPriceTreatmentEnabled;
      set => this.mCombinedFixedPriceTreatmentEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingEnhancementDurationDefinitionType GalleryFeaturedDurations
    {
      get => this.mGalleryFeaturedDurations;
      set => this.mGalleryFeaturedDurations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public INEscrowWorkflowTimelineDefinitionType INEscrowWorkflowTimeline
    {
      get => this.mINEscrowWorkflowTimeline;
      set => this.mINEscrowWorkflowTimeline = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalRequiredDefinitionType PayPalRequired
    {
      get => this.mPayPalRequired;
      set => this.mPayPalRequired = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProAdFormatEnabledDefinitionType eBayMotorsProAdFormatEnabled
    {
      get => this.meBayMotorsProAdFormatEnabled;
      set => this.meBayMotorsProAdFormatEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProContactByPhoneEnabledDefinitionType eBayMotorsProContactByPhoneEnabled
    {
      get => this.meBayMotorsProContactByPhoneEnabled;
      set => this.meBayMotorsProContactByPhoneEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProPhoneCountDefinitionType eBayMotorsProPhoneCount
    {
      get => this.meBayMotorsProPhoneCount;
      set => this.meBayMotorsProPhoneCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProContactByAddressEnabledDefinitionType eBayMotorsProContactByAddressEnabled
    {
      get => this.meBayMotorsProContactByAddressEnabled;
      set => this.meBayMotorsProContactByAddressEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProStreetCountDefinitionType eBayMotorsProStreetCount
    {
      get => this.meBayMotorsProStreetCount;
      set => this.meBayMotorsProStreetCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProCompanyNameEnabledDefinitionType eBayMotorsProCompanyNameEnabled
    {
      get => this.meBayMotorsProCompanyNameEnabled;
      set => this.meBayMotorsProCompanyNameEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProContactByEmailEnabledDefinitionType eBayMotorsProContactByEmailEnabled
    {
      get => this.meBayMotorsProContactByEmailEnabled;
      set => this.meBayMotorsProContactByEmailEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProBestOfferEnabledDefinitionType eBayMotorsProBestOfferEnabled
    {
      get => this.meBayMotorsProBestOfferEnabled;
      set => this.meBayMotorsProBestOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProAutoAcceptEnabledDefinitionType eBayMotorsProAutoAcceptEnabled
    {
      get => this.meBayMotorsProAutoAcceptEnabled;
      set => this.meBayMotorsProAutoAcceptEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProAutoDeclineEnabledDefinitionType eBayMotorsProAutoDeclineEnabled
    {
      get => this.meBayMotorsProAutoDeclineEnabled;
      set => this.meBayMotorsProAutoDeclineEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProPaymentMethodCheckOutEnabledDefinitionType eBayMotorsProPaymentMethodCheckOutEnabled
    {
      get => this.meBayMotorsProPaymentMethodCheckOutEnabled;
      set => this.meBayMotorsProPaymentMethodCheckOutEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProShippingMethodEnabledDefinitionType eBayMotorsProShippingMethodEnabled
    {
      get => this.meBayMotorsProShippingMethodEnabled;
      set => this.meBayMotorsProShippingMethodEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProCounterOfferEnabledDefinitionType eBayMotorsProCounterOfferEnabled
    {
      get => this.meBayMotorsProCounterOfferEnabled;
      set => this.meBayMotorsProCounterOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayMotorsProSellerContactDetailsEnabledDefinitionType eBayMotorsProSellerContactDetailsEnabled
    {
      get => this.meBayMotorsProSellerContactDetailsEnabled;
      set => this.meBayMotorsProSellerContactDetailsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketAdFormatEnabledDefinitionType LocalMarketAdFormatEnabled
    {
      get => this.mLocalMarketAdFormatEnabled;
      set => this.mLocalMarketAdFormatEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketContactByPhoneEnabledDefinitionType LocalMarketContactByPhoneEnabled
    {
      get => this.mLocalMarketContactByPhoneEnabled;
      set => this.mLocalMarketContactByPhoneEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketPhoneCountDefinitionType LocalMarketPhoneCount
    {
      get => this.mLocalMarketPhoneCount;
      set => this.mLocalMarketPhoneCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketContactByAddressEnabledDefinitionType LocalMarketContactByAddressEnabled
    {
      get => this.mLocalMarketContactByAddressEnabled;
      set => this.mLocalMarketContactByAddressEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketStreetCountDefinitionType LocalMarketStreetCount
    {
      get => this.mLocalMarketStreetCount;
      set => this.mLocalMarketStreetCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketCompanyNameEnabledDefinitionType LocalMarketCompanyNameEnabled
    {
      get => this.mLocalMarketCompanyNameEnabled;
      set => this.mLocalMarketCompanyNameEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketContactByEmailEnabledDefinitionType LocalMarketContactByEmailEnabled
    {
      get => this.mLocalMarketContactByEmailEnabled;
      set => this.mLocalMarketContactByEmailEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketBestOfferEnabledDefinitionType LocalMarketBestOfferEnabled
    {
      get => this.mLocalMarketBestOfferEnabled;
      set => this.mLocalMarketBestOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketAutoAcceptEnabledDefinitionType LocalMarketAutoAcceptEnabled
    {
      get => this.mLocalMarketAutoAcceptEnabled;
      set => this.mLocalMarketAutoAcceptEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketAutoDeclineEnabledDefinitionType LocalMarketAutoDeclineEnabled
    {
      get => this.mLocalMarketAutoDeclineEnabled;
      set => this.mLocalMarketAutoDeclineEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketPaymentMethodCheckOutEnabledDefinitionType LocalMarketPaymentMethodCheckOutEnabled
    {
      get => this.mLocalMarketPaymentMethodCheckOutEnabled;
      set => this.mLocalMarketPaymentMethodCheckOutEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketShippingMethodEnabledDefinitionType LocalMarketShippingMethodEnabled
    {
      get => this.mLocalMarketShippingMethodEnabled;
      set => this.mLocalMarketShippingMethodEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketCounterOfferEnabledDefinitionType LocalMarketCounterOfferEnabled
    {
      get => this.mLocalMarketCounterOfferEnabled;
      set => this.mLocalMarketCounterOfferEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LocalMarketSellerContactDetailsEnabledDefinitionType LocalMarketSellerContactDetailsEnabled
    {
      get => this.mLocalMarketSellerContactDetailsEnabled;
      set => this.mLocalMarketSellerContactDetailsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdPhoneCountDefinitionType ClassifiedAdPhoneCount
    {
      get => this.mClassifiedAdPhoneCount;
      set => this.mClassifiedAdPhoneCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdContactByAddressEnabledDefinitionType ClassifiedAdContactByAddressEnabled
    {
      get => this.mClassifiedAdContactByAddressEnabled;
      set => this.mClassifiedAdContactByAddressEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdStreetCountDefinitionType ClassifiedAdStreetCount
    {
      get => this.mClassifiedAdStreetCount;
      set => this.mClassifiedAdStreetCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ClassifiedAdCompanyNameEnabledDefinitionType ClassifiedAdCompanyNameEnabled
    {
      get => this.mClassifiedAdCompanyNameEnabled;
      set => this.mClassifiedAdCompanyNameEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SpecialitySubscriptionDefinitionType SpecialitySubscription
    {
      get => this.mSpecialitySubscription;
      set => this.mSpecialitySubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RegularSubscriptionDefinitionType RegularSubscription
    {
      get => this.mRegularSubscription;
      set => this.mRegularSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PremiumSubscriptionDefinitionType PremiumSubscription
    {
      get => this.mPremiumSubscription;
      set => this.mPremiumSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NonSubscriptionDefinitionType NonSubscription
    {
      get => this.mNonSubscription;
      set => this.mNonSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ReturnPolicyEnabledDefinitionType ReturnPolicyEnabled
    {
      get => this.mReturnPolicyEnabled;
      set => this.mReturnPolicyEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public HandlingTimeEnabledDefinitionType HandlingTimeEnabled
    {
      get => this.mHandlingTimeEnabled;
      set => this.mHandlingTimeEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalRequiredForStoreOwnerDefinitionType PayPalRequiredForStoreOwner
    {
      get => this.mPayPalRequiredForStoreOwner;
      set => this.mPayPalRequiredForStoreOwner = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ReviseQuantityAllowedDefinitionType ReviseQuantityAllowed
    {
      get => this.mReviseQuantityAllowed;
      set => this.mReviseQuantityAllowed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RevisePriceAllowedDefinitionType RevisePriceAllowed
    {
      get => this.mRevisePriceAllowed;
      set => this.mRevisePriceAllowed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreOwnerExtendedListingDurationsEnabledDefinitionType StoreOwnerExtendedListingDurationsEnabled
    {
      get => this.mStoreOwnerExtendedListingDurationsEnabled;
      set => this.mStoreOwnerExtendedListingDurationsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreOwnerExtendedListingDurationsDefinitionType StoreOwnerExtendedListingDurations
    {
      get => this.mStoreOwnerExtendedListingDurations;
      set => this.mStoreOwnerExtendedListingDurations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentMethodDefinitionType PaymentMethod
    {
      get => this.mPaymentMethod;
      set => this.mPaymentMethod = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Group1MaxFlatShippingCostDefinitionType Group1MaxFlatShippingCost
    {
      get => this.mGroup1MaxFlatShippingCost;
      set => this.mGroup1MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Group2MaxFlatShippingCostDefinitionType Group2MaxFlatShippingCost
    {
      get => this.mGroup2MaxFlatShippingCost;
      set => this.mGroup2MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Group3MaxFlatShippingCostDefinitionType Group3MaxFlatShippingCost
    {
      get => this.mGroup3MaxFlatShippingCost;
      set => this.mGroup3MaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaxFlatShippingCostCBTExemptDefinitionType MaxFlatShippingCostCBTExempt
    {
      get => this.mMaxFlatShippingCostCBTExempt;
      set => this.mMaxFlatShippingCostCBTExempt = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaxFlatShippingCostDefinitionType MaxFlatShippingCost
    {
      get => this.mMaxFlatShippingCost;
      set => this.mMaxFlatShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationsEnabledDefinitionType VariationsEnabled
    {
      get => this.mVariationsEnabled;
      set => this.mVariationsEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AttributeConversionEnabledFeatureDefinitionType AttributeConversionEnabled
    {
      get => this.mAttributeConversionEnabled;
      set => this.mAttributeConversionEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FreeGalleryPlusEnabledDefinitionType FreeGalleryPlusEnabled
    {
      get => this.mFreeGalleryPlusEnabled;
      set => this.mFreeGalleryPlusEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FreePicturePackEnabledDefinitionType FreePicturePackEnabled
    {
      get => this.mFreePicturePackEnabled;
      set => this.mFreePicturePackEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemCompatibilityEnabledDefinitionType ItemCompatibilityEnabled
    {
      get => this.mItemCompatibilityEnabled;
      set => this.mItemCompatibilityEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaxItemCompatibilityDefinitionType MaxItemCompatibility
    {
      get => this.mMaxItemCompatibility;
      set => this.mMaxItemCompatibility = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MinItemCompatibilityDefinitionType MinItemCompatibility
    {
      get => this.mMinItemCompatibility;
      set => this.mMinItemCompatibility = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ConditionEnabledDefinitionType ConditionEnabled
    {
      get => this.mConditionEnabled;
      set => this.mConditionEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ConditionValuesDefinitionType ConditionValues
    {
      get => this.mConditionValues;
      set => this.mConditionValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ValueCategoryDefinitionType ValueCategory
    {
      get => this.mValueCategory;
      set => this.mValueCategory = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductCreationEnabledDefinitionType ProductCreationEnabled
    {
      get => this.mProductCreationEnabled;
      set => this.mProductCreationEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EANEnabledDefinitionType EANEnabled
    {
      get => this.mEANEnabled;
      set => this.mEANEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ISBNEnabledDefinitionType ISBNEnabled
    {
      get => this.mISBNEnabled;
      set => this.mISBNEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UPCEnabledDefinitionType UPCEnabled
    {
      get => this.mUPCEnabled;
      set => this.mUPCEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CompatibleVehicleTypeDefinitionType CompatibleVehicleType
    {
      get => this.mCompatibleVehicleType;
      set => this.mCompatibleVehicleType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaxGranularFitmentCountDefinitionType MaxGranularFitmentCount
    {
      get => this.mMaxGranularFitmentCount;
      set => this.mMaxGranularFitmentCount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentOptionsGroupEnabledDefinitionType PaymentOptionsGroup
    {
      get => this.mPaymentOptionsGroup;
      set => this.mPaymentOptionsGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupDefinitionType ShippingProfileCategoryGroup
    {
      get => this.mShippingProfileCategoryGroup;
      set => this.mShippingProfileCategoryGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupDefinitionType PaymentProfileCategoryGroup
    {
      get => this.mPaymentProfileCategoryGroup;
      set => this.mPaymentProfileCategoryGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProfileCategoryGroupDefinitionType ReturnPolicyProfileCategoryGroup
    {
      get => this.mReturnPolicyProfileCategoryGroup;
      set => this.mReturnPolicyProfileCategoryGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VINSupportedDefinitionType VINSupported
    {
      get => this.mVINSupported;
      set => this.mVINSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VRMSupportedDefinitionType VRMSupported
    {
      get => this.mVRMSupported;
      set => this.mVRMSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerProvidedTitleSupportedDefinitionType SellerProvidedTitleSupported
    {
      get => this.mSellerProvidedTitleSupported;
      set => this.mSellerProvidedTitleSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DepositSupportedDefinitionType DepositSupported
    {
      get => this.mDepositSupported;
      set => this.mDepositSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GlobalShippingEnabledDefinitionType GlobalShippingEnabled
    {
      get => this.mGlobalShippingEnabled;
      set => this.mGlobalShippingEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AdditionalCompatibilityEnabledDefinitionType AdditionalCompatibilityEnabled
    {
      get => this.mAdditionalCompatibilityEnabled;
      set => this.mAdditionalCompatibilityEnabled = value;
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
    public PickupDropOffEnabledDefinitionType PickupDropOffEnabled
    {
      get => this.mPickupDropOffEnabled;
      set => this.mPickupDropOffEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DigitalGoodDeliveryEnabledDefinitionType DigitalGoodDeliveryEnabled
    {
      get => this.mDigitalGoodDeliveryEnabled;
      set => this.mDigitalGoodDeliveryEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EpidSupportedDefinitionType EpidSupported
    {
      get => this.mEpidSupported;
      set => this.mEpidSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public KTypeSupportedDefinitionType KTypeSupported
    {
      get => this.mKTypeSupported;
      set => this.mKTypeSupported = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductRequiredEnabledDefinitionType ProductRequiredEnabled
    {
      get => this.mProductRequiredEnabled;
      set => this.mProductRequiredEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsAcceptedDefinitionType DomesticReturnsAcceptedValues
    {
      get => this.mDomesticReturnsAcceptedValues;
      set => this.mDomesticReturnsAcceptedValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsAcceptedDefinitionType InternationalReturnsAcceptedValues
    {
      get => this.mInternationalReturnsAcceptedValues;
      set => this.mInternationalReturnsAcceptedValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsDurationDefinitionType DomesticReturnsDurationValues
    {
      get => this.mDomesticReturnsDurationValues;
      set => this.mDomesticReturnsDurationValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsDurationDefinitionType InternationalReturnsDurationValues
    {
      get => this.mInternationalReturnsDurationValues;
      set => this.mInternationalReturnsDurationValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DomesticReturnsShipmentPayeeDefinitionType DomesticReturnsShipmentPayeeValues
    {
      get => this.mDomesticReturnsShipmentPayeeValues;
      set => this.mDomesticReturnsShipmentPayeeValues = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public InternationalReturnsShipmentPayeeDefinitionType InternationalReturnsShipmentPayeeValues
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
    public ReturnPolicyDescriptionEnabledDefinitionType ReturnPolicyDescriptionEnabled
    {
      get => this.mReturnPolicyDescriptionEnabled;
      set => this.mReturnPolicyDescriptionEnabled = value;
    }
  }
}
