// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemType
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
    public class ItemType
    {
        private string mApplicationData;
        private AttributeSetTypeCollection mAttributeSetArray;
        private AttributeTypeCollection mAttributeArray;
        private LookupAttributeTypeCollection mLookupAttributeArray;
        private bool mAutoPay;
        private bool mAutoPaySpecified;
        private BiddingDetailsType mBiddingDetails;
        private BuyerProtectionCodeType mBuyerProtection;
        private bool mBuyerProtectionSpecified;
        private AmountType mBuyItNowPrice;
        private bool mCategoryMappingAllowed;
        private CharityType mCharity;
        private CountryCodeType mCountry;
        private bool mCountrySpecified;
        private CrossPromotionsType mCrossPromotion;
        private CurrencyCodeType mCurrency;
        private bool mCurrencySpecified;
        private string mDescription;
        private DescriptionReviseModeCodeType mDescriptionReviseMode;
        private bool mDescriptionReviseModeSpecified;
        private DistanceType mDistance;
        private HitCounterCodeType mHitCounter;
        private bool mHitCounterSpecified;
        private string mItemID;
        private ListingDetailsType mListingDetails;
        private ListingDesignerType mListingDesigner;
        private string mListingDuration;
        private ListingEnhancementsCodeTypeCollection mListingEnhancement;
        private ListingTypeCodeType mListingType;
        private bool mListingTypeSpecified;
        private string mLocation;
        private int mLotSize;
        private bool mLotSizeSpecified;
        private string mPartnerCode;
        private string mPartnerName;
        private PaymentDetailsType mPaymentDetails;
        private BuyerPaymentMethodCodeTypeCollection mPaymentMethods;
        private string mPayPalEmailAddress;
        private CategoryType mPrimaryCategory;
        private bool mPrivateListing;
        private bool mPrivateListingSpecified;
        private ProductListingDetailsType mProductListingDetails;
        private int mQuantity;
        private bool mQuantitySpecified;
        private string mPrivateNotes;
        private string mRegionID;
        private bool mRelistLink;
        private bool mRelistLinkSpecified;
        private AmountType mReservePrice;
        private ReviseStatusType mReviseStatus;
        private DateTime mScheduleTime;
        private bool mScheduleTimeSpecified;
        private CategoryType mSecondaryCategory;
        private CategoryType mFreeAddedCategory;
        private UserType mSeller;
        private SellingStatusType mSellingStatus;
        private ShippingDetailsType mShippingDetails;
        private StringCollection mShipToLocations;
        private SiteCodeType mSite;
        private bool mSiteSpecified;
        private AmountType mStartPrice;
        private StorefrontType mStorefront;
        private string mSubTitle;
        private string mTimeLeft;
        private string mTitle;
        private string mUUID;
        private VATDetailsType mVATDetails;
        private string mSellerVacationNote;
        private long mWatchCount;
        private bool mWatchCountSpecified;
        private long mHitCount;
        private bool mHitCountSpecified;
        private bool mDisableBuyerRequirements;
        private bool mDisableBuyerRequirementsSpecified;
        private BestOfferDetailsType mBestOfferDetails;
        private bool mLocationDefaulted;
        private bool mLocationDefaultedSpecified;
        private bool mUseTaxTable;
        private bool mUseTaxTableSpecified;
        private bool mGetItFast;
        private bool mGetItFastSpecified;
        private bool mBuyerResponsibleForShipping;
        private bool mBuyerResponsibleForShippingSpecified;
        private bool mLimitedWarrantyEligible;
        private bool mLimitedWarrantyEligibleSpecified;
        private string meBayNotes;
        private long mQuestionCount;
        private bool mQuestionCountSpecified;
        private bool mRelisted;
        private bool mRelistedSpecified;
        private int mQuantityAvailable;
        private bool mQuantityAvailableSpecified;
        private string mSKU;
        private SearchDetailsType mSearchDetails;
        private string mPostalCode;
        private PictureDetailsType mPictureDetails;
        private int mDispatchTimeMax;
        private bool mDispatchTimeMaxSpecified;
        private bool mBestOfferEnabled;
        private bool mBestOfferEnabledSpecified;
        private bool mLocalListing;
        private bool mLocalListingSpecified;
        private AddressType mSellerContactDetails;
        private long mTotalQuestionCount;
        private bool mTotalQuestionCountSpecified;
        private bool mProxyItem;
        private bool mProxyItemSpecified;
        private ExtendedContactDetailsType mExtendedSellerContactDetails;
        private int mLeadCount;
        private bool mLeadCountSpecified;
        private int mNewLeadCount;
        private bool mNewLeadCountSpecified;
        private NameValueListTypeCollection mItemSpecifics;
        private string mGroupCategoryID;
        private AmountType mClassifiedAdPayPerLeadFee;
        private bool mBidGroupItem;
        private bool mBidGroupItemSpecified;
        private BuyerProtectionDetailsType mApplyBuyerProtection;
        private ListingSubtypeCodeType mListingSubtype2;
        private bool mListingSubtype2Specified;
        private bool mMechanicalCheckAccepted;
        private bool mMechanicalCheckAcceptedSpecified;
        private bool mUpdateSellerInfo;
        private bool mUpdateSellerInfoSpecified;
        private bool mUpdateReturnPolicy;
        private bool mUpdateReturnPolicySpecified;
        private ItemPolicyViolationType mItemPolicyViolation;
        private StringCollection mCrossBorderTrade;
        private BusinessSellerDetailsType mBusinessSellerDetails;
        private AmountType mBuyerGuaranteePrice;
        private BuyerRequirementDetailsType mBuyerRequirementDetails;
        private ReturnPolicyType mReturnPolicy;
        private SiteCodeTypeCollection mPaymentAllowedSite;
        private InventoryTrackingMethodCodeType mInventoryTrackingMethod;
        private bool mInventoryTrackingMethodSpecified;
        private bool mIntegratedMerchantCreditCardEnabled;
        private bool mIntegratedMerchantCreditCardEnabledSpecified;
        private VariationsType mVariations;
        private ItemCompatibilityListType mItemCompatibilityList;
        private int mItemCompatibilityCount;
        private bool mItemCompatibilityCountSpecified;
        private int mConditionID;
        private bool mConditionIDSpecified;
        private string mConditionDescription;
        private string mConditionDisplayName;
        private string mTaxCategory;
        private QuantityAvailableHintCodeType mQuantityAvailableHint;
        private bool mQuantityAvailableHintSpecified;
        private int mQuantityThreshold;
        private bool mQuantityThresholdSpecified;
        private DiscountPriceInfoType mDiscountPriceInfo;
        private string mSellerProvidedTitle;
        private string mVIN;
        private string mVINLink;
        private string mVRM;
        private string mVRMLink;
        private QuantityInfoType mQuantityInfo;
        private SellerProfilesType mSellerProfiles;
        private ShippingServiceCostOverrideListType mShippingServiceCostOverrideList;
        private ShippingOverrideType mShippingOverride;
        private ShipPackageDetailsType mShippingPackageDetails;
        private bool mTopRatedListing;
        private bool mTopRatedListingSpecified;
        private QuantityRestrictionPerBuyerInfoType mQuantityRestrictionPerBuyer;
        private AmountType mFloorPrice;
        private AmountType mCeilingPrice;
        private bool mIsIntermediatedShippingEligible;
        private bool mIsIntermediatedShippingEligibleSpecified;
        private UnitInfoType mUnitInfo;
        private long mRelistParentID;
        private bool mRelistParentIDSpecified;
        private string mConditionDefinition;
        private bool mHideFromSearch;
        private bool mHideFromSearchSpecified;
        private ReasonHideFromSearchCodeType mReasonHideFromSearch;
        private bool mReasonHideFromSearchSpecified;
        private bool mIncludeRecommendations;
        private PickupInStoreDetailsType mPickupInStoreDetails;
        private int mSiteId;
        private bool mSiteIdSpecified;
        private bool mIgnoreQuantity;
        private bool mIgnoreQuantitySpecified;
        private bool mAvailableForPickupDropOff;
        private bool mAvailableForPickupDropOffSpecified;
        private bool mEligibleForPickupDropOff;
        private bool mEligibleForPickupDropOffSpecified;
        private bool mLiveAuction;
        private bool mLiveAuctionSpecified;
        private DigitalGoodInfoType mDigitalGoodInfo;
        private bool meBayPlus;
        private bool meBayPlusSpecified;
        private bool meBayPlusEligible;
        private bool meBayPlusEligibleSpecified;
        private bool meMailDeliveryAvailable;
        private bool meMailDeliveryAvailableSpecified;
        private bool mIsSecureDescription;
        private bool mIsSecureDescriptionSpecified;
        private RegulatoryType mRegulatory;
        private XmlElementCollection mAny;

        /// <summary>
        /// 
        /// </summary>
        public ItemType()
        {
            this.CategoryMappingAllowed = false;
            this.IncludeRecommendations = false;
        }

        public RegulatoryType Regulatory
        {
            get => this.mRegulatory;
            set => this.mRegulatory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ApplicationData
        {
            get => this.mApplicationData;
            set => this.mApplicationData = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlArrayItem("AttributeSet", IsNullable = false)]
        public AttributeSetTypeCollection AttributeSetArray
        {
            get => this.mAttributeSetArray;
            set => this.mAttributeSetArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlArrayItem("Attribute", IsNullable = false)]
        public AttributeTypeCollection AttributeArray
        {
            get => this.mAttributeArray;
            set => this.mAttributeArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlArrayItem("LookupAttribute", IsNullable = false)]
        public LookupAttributeTypeCollection LookupAttributeArray
        {
            get => this.mLookupAttributeArray;
            set => this.mLookupAttributeArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AutoPay
        {
            get => this.mAutoPay;
            set
            {
                this.mAutoPay = value;
                this.mAutoPaySpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool AutoPaySpecified
        {
            get => this.mAutoPaySpecified;
            set => this.mAutoPaySpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BiddingDetailsType BiddingDetails
        {
            get => this.mBiddingDetails;
            set => this.mBiddingDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BuyerProtectionCodeType BuyerProtection
        {
            get => this.mBuyerProtection;
            set
            {
                this.mBuyerProtection = value;
                this.mBuyerProtectionSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool BuyerProtectionSpecified
        {
            get => this.mBuyerProtectionSpecified;
            set => this.mBuyerProtectionSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType BuyItNowPrice
        {
            get => this.mBuyItNowPrice;
            set => this.mBuyItNowPrice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public bool CategoryMappingAllowed
        {
            get => this.mCategoryMappingAllowed;
            set => this.mCategoryMappingAllowed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CharityType Charity
        {
            get => this.mCharity;
            set => this.mCharity = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CountryCodeType Country
        {
            get => this.mCountry;
            set
            {
                this.mCountry = value;
                this.mCountrySpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool CountrySpecified
        {
            get => this.mCountrySpecified;
            set => this.mCountrySpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CrossPromotionsType CrossPromotion
        {
            get => this.mCrossPromotion;
            set => this.mCrossPromotion = value;
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
        public string Description
        {
            get => this.mDescription;
            set => this.mDescription = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DescriptionReviseModeCodeType DescriptionReviseMode
        {
            get => this.mDescriptionReviseMode;
            set
            {
                this.mDescriptionReviseMode = value;
                this.mDescriptionReviseModeSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool DescriptionReviseModeSpecified
        {
            get => this.mDescriptionReviseModeSpecified;
            set => this.mDescriptionReviseModeSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DistanceType Distance
        {
            get => this.mDistance;
            set => this.mDistance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public HitCounterCodeType HitCounter
        {
            get => this.mHitCounter;
            set
            {
                this.mHitCounter = value;
                this.mHitCounterSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool HitCounterSpecified
        {
            get => this.mHitCounterSpecified;
            set => this.mHitCounterSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ItemID
        {
            get => this.mItemID;
            set => this.mItemID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListingDetailsType ListingDetails
        {
            get => this.mListingDetails;
            set => this.mListingDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListingDesignerType ListingDesigner
        {
            get => this.mListingDesigner;
            set => this.mListingDesigner = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(DataType = "token")]
        public string ListingDuration
        {
            get => this.mListingDuration;
            set => this.mListingDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("ListingEnhancement")]
        public ListingEnhancementsCodeTypeCollection ListingEnhancement
        {
            get => this.mListingEnhancement;
            set => this.mListingEnhancement = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListingTypeCodeType ListingType
        {
            get => this.mListingType;
            set
            {
                this.mListingType = value;
                this.mListingTypeSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ListingTypeSpecified
        {
            get => this.mListingTypeSpecified;
            set => this.mListingTypeSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Location
        {
            get => this.mLocation;
            set => this.mLocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int LotSize
        {
            get => this.mLotSize;
            set
            {
                this.mLotSize = value;
                this.mLotSizeSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LotSizeSpecified
        {
            get => this.mLotSizeSpecified;
            set => this.mLotSizeSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PartnerCode
        {
            get => this.mPartnerCode;
            set => this.mPartnerCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PartnerName
        {
            get => this.mPartnerName;
            set => this.mPartnerName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PaymentDetailsType PaymentDetails
        {
            get => this.mPaymentDetails;
            set => this.mPaymentDetails = value;
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
        public string PayPalEmailAddress
        {
            get => this.mPayPalEmailAddress;
            set => this.mPayPalEmailAddress = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CategoryType PrimaryCategory
        {
            get => this.mPrimaryCategory;
            set => this.mPrimaryCategory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PrivateListing
        {
            get => this.mPrivateListing;
            set
            {
                this.mPrivateListing = value;
                this.mPrivateListingSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool PrivateListingSpecified
        {
            get => this.mPrivateListingSpecified;
            set => this.mPrivateListingSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProductListingDetailsType ProductListingDetails
        {
            get => this.mProductListingDetails;
            set => this.mProductListingDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity
        {
            get => this.mQuantity;
            set
            {
                this.mQuantity = value;
                this.mQuantitySpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool QuantitySpecified
        {
            get => this.mQuantitySpecified;
            set => this.mQuantitySpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PrivateNotes
        {
            get => this.mPrivateNotes;
            set => this.mPrivateNotes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string RegionID
        {
            get => this.mRegionID;
            set => this.mRegionID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool RelistLink
        {
            get => this.mRelistLink;
            set
            {
                this.mRelistLink = value;
                this.mRelistLinkSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool RelistLinkSpecified
        {
            get => this.mRelistLinkSpecified;
            set => this.mRelistLinkSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType ReservePrice
        {
            get => this.mReservePrice;
            set => this.mReservePrice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReviseStatusType ReviseStatus
        {
            get => this.mReviseStatus;
            set => this.mReviseStatus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ScheduleTime
        {
            get => this.mScheduleTime;
            set
            {
                this.mScheduleTime = value;
                this.mScheduleTimeSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ScheduleTimeSpecified
        {
            get => this.mScheduleTimeSpecified;
            set => this.mScheduleTimeSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CategoryType SecondaryCategory
        {
            get => this.mSecondaryCategory;
            set => this.mSecondaryCategory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CategoryType FreeAddedCategory
        {
            get => this.mFreeAddedCategory;
            set => this.mFreeAddedCategory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UserType Seller
        {
            get => this.mSeller;
            set => this.mSeller = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SellingStatusType SellingStatus
        {
            get => this.mSellingStatus;
            set => this.mSellingStatus = value;
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
        [XmlElement("ShipToLocations")]
        public StringCollection ShipToLocations
        {
            get => this.mShipToLocations;
            set => this.mShipToLocations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SiteCodeType Site
        {
            get => this.mSite;
            set
            {
                this.mSite = value;
                this.mSiteSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool SiteSpecified
        {
            get => this.mSiteSpecified;
            set => this.mSiteSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType StartPrice
        {
            get => this.mStartPrice;
            set => this.mStartPrice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StorefrontType Storefront
        {
            get => this.mStorefront;
            set => this.mStorefront = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SubTitle
        {
            get => this.mSubTitle;
            set => this.mSubTitle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement(DataType = "duration")]
        public string TimeLeft
        {
            get => this.mTimeLeft;
            set => this.mTimeLeft = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get => this.mTitle;
            set => this.mTitle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string UUID
        {
            get => this.mUUID;
            set => this.mUUID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VATDetailsType VATDetails
        {
            get => this.mVATDetails;
            set => this.mVATDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SellerVacationNote
        {
            get => this.mSellerVacationNote;
            set => this.mSellerVacationNote = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public long WatchCount
        {
            get => this.mWatchCount;
            set
            {
                this.mWatchCount = value;
                this.mWatchCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool WatchCountSpecified
        {
            get => this.mWatchCountSpecified;
            set => this.mWatchCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public long HitCount
        {
            get => this.mHitCount;
            set
            {
                this.mHitCount = value;
                this.mHitCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool HitCountSpecified
        {
            get => this.mHitCountSpecified;
            set => this.mHitCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool DisableBuyerRequirements
        {
            get => this.mDisableBuyerRequirements;
            set
            {
                this.mDisableBuyerRequirements = value;
                this.mDisableBuyerRequirementsSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool DisableBuyerRequirementsSpecified
        {
            get => this.mDisableBuyerRequirementsSpecified;
            set => this.mDisableBuyerRequirementsSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BestOfferDetailsType BestOfferDetails
        {
            get => this.mBestOfferDetails;
            set => this.mBestOfferDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool LocationDefaulted
        {
            get => this.mLocationDefaulted;
            set
            {
                this.mLocationDefaulted = value;
                this.mLocationDefaultedSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LocationDefaultedSpecified
        {
            get => this.mLocationDefaultedSpecified;
            set => this.mLocationDefaultedSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool UseTaxTable
        {
            get => this.mUseTaxTable;
            set
            {
                this.mUseTaxTable = value;
                this.mUseTaxTableSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool UseTaxTableSpecified
        {
            get => this.mUseTaxTableSpecified;
            set => this.mUseTaxTableSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool GetItFast
        {
            get => this.mGetItFast;
            set
            {
                this.mGetItFast = value;
                this.mGetItFastSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool GetItFastSpecified
        {
            get => this.mGetItFastSpecified;
            set => this.mGetItFastSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool BuyerResponsibleForShipping
        {
            get => this.mBuyerResponsibleForShipping;
            set
            {
                this.mBuyerResponsibleForShipping = value;
                this.mBuyerResponsibleForShippingSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool BuyerResponsibleForShippingSpecified
        {
            get => this.mBuyerResponsibleForShippingSpecified;
            set => this.mBuyerResponsibleForShippingSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool LimitedWarrantyEligible
        {
            get => this.mLimitedWarrantyEligible;
            set
            {
                this.mLimitedWarrantyEligible = value;
                this.mLimitedWarrantyEligibleSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LimitedWarrantyEligibleSpecified
        {
            get => this.mLimitedWarrantyEligibleSpecified;
            set => this.mLimitedWarrantyEligibleSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string eBayNotes
        {
            get => this.meBayNotes;
            set => this.meBayNotes = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public long QuestionCount
        {
            get => this.mQuestionCount;
            set
            {
                this.mQuestionCount = value;
                this.mQuestionCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool QuestionCountSpecified
        {
            get => this.mQuestionCountSpecified;
            set => this.mQuestionCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Relisted
        {
            get => this.mRelisted;
            set
            {
                this.mRelisted = value;
                this.mRelistedSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool RelistedSpecified
        {
            get => this.mRelistedSpecified;
            set => this.mRelistedSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int QuantityAvailable
        {
            get => this.mQuantityAvailable;
            set
            {
                this.mQuantityAvailable = value;
                this.mQuantityAvailableSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool QuantityAvailableSpecified
        {
            get => this.mQuantityAvailableSpecified;
            set => this.mQuantityAvailableSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SKU
        {
            get => this.mSKU;
            set => this.mSKU = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SearchDetailsType SearchDetails
        {
            get => this.mSearchDetails;
            set => this.mSearchDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode
        {
            get => this.mPostalCode;
            set => this.mPostalCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PictureDetailsType PictureDetails
        {
            get => this.mPictureDetails;
            set => this.mPictureDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int DispatchTimeMax
        {
            get => this.mDispatchTimeMax;
            set
            {
                this.mDispatchTimeMax = value;
                this.mDispatchTimeMaxSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool DispatchTimeMaxSpecified
        {
            get => this.mDispatchTimeMaxSpecified;
            set => this.mDispatchTimeMaxSpecified = value;
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
        public bool LocalListing
        {
            get => this.mLocalListing;
            set
            {
                this.mLocalListing = value;
                this.mLocalListingSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LocalListingSpecified
        {
            get => this.mLocalListingSpecified;
            set => this.mLocalListingSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AddressType SellerContactDetails
        {
            get => this.mSellerContactDetails;
            set => this.mSellerContactDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public long TotalQuestionCount
        {
            get => this.mTotalQuestionCount;
            set
            {
                this.mTotalQuestionCount = value;
                this.mTotalQuestionCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool TotalQuestionCountSpecified
        {
            get => this.mTotalQuestionCountSpecified;
            set => this.mTotalQuestionCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool ProxyItem
        {
            get => this.mProxyItem;
            set
            {
                this.mProxyItem = value;
                this.mProxyItemSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ProxyItemSpecified
        {
            get => this.mProxyItemSpecified;
            set => this.mProxyItemSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExtendedContactDetailsType ExtendedSellerContactDetails
        {
            get => this.mExtendedSellerContactDetails;
            set => this.mExtendedSellerContactDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int LeadCount
        {
            get => this.mLeadCount;
            set
            {
                this.mLeadCount = value;
                this.mLeadCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LeadCountSpecified
        {
            get => this.mLeadCountSpecified;
            set => this.mLeadCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int NewLeadCount
        {
            get => this.mNewLeadCount;
            set
            {
                this.mNewLeadCount = value;
                this.mNewLeadCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool NewLeadCountSpecified
        {
            get => this.mNewLeadCountSpecified;
            set => this.mNewLeadCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlArrayItem("NameValueList", IsNullable = false)]
        public NameValueListTypeCollection ItemSpecifics
        {
            get => this.mItemSpecifics;
            set => this.mItemSpecifics = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string GroupCategoryID
        {
            get => this.mGroupCategoryID;
            set => this.mGroupCategoryID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType ClassifiedAdPayPerLeadFee
        {
            get => this.mClassifiedAdPayPerLeadFee;
            set => this.mClassifiedAdPayPerLeadFee = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool BidGroupItem
        {
            get => this.mBidGroupItem;
            set
            {
                this.mBidGroupItem = value;
                this.mBidGroupItemSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool BidGroupItemSpecified
        {
            get => this.mBidGroupItemSpecified;
            set => this.mBidGroupItemSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BuyerProtectionDetailsType ApplyBuyerProtection
        {
            get => this.mApplyBuyerProtection;
            set => this.mApplyBuyerProtection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListingSubtypeCodeType ListingSubtype2
        {
            get => this.mListingSubtype2;
            set
            {
                this.mListingSubtype2 = value;
                this.mListingSubtype2Specified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ListingSubtype2Specified
        {
            get => this.mListingSubtype2Specified;
            set => this.mListingSubtype2Specified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool MechanicalCheckAccepted
        {
            get => this.mMechanicalCheckAccepted;
            set
            {
                this.mMechanicalCheckAccepted = value;
                this.mMechanicalCheckAcceptedSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool MechanicalCheckAcceptedSpecified
        {
            get => this.mMechanicalCheckAcceptedSpecified;
            set => this.mMechanicalCheckAcceptedSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool UpdateSellerInfo
        {
            get => this.mUpdateSellerInfo;
            set
            {
                this.mUpdateSellerInfo = value;
                this.mUpdateSellerInfoSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool UpdateSellerInfoSpecified
        {
            get => this.mUpdateSellerInfoSpecified;
            set => this.mUpdateSellerInfoSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool UpdateReturnPolicy
        {
            get => this.mUpdateReturnPolicy;
            set
            {
                this.mUpdateReturnPolicy = value;
                this.mUpdateReturnPolicySpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool UpdateReturnPolicySpecified
        {
            get => this.mUpdateReturnPolicySpecified;
            set => this.mUpdateReturnPolicySpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemPolicyViolationType ItemPolicyViolation
        {
            get => this.mItemPolicyViolation;
            set => this.mItemPolicyViolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("CrossBorderTrade")]
        public StringCollection CrossBorderTrade
        {
            get => this.mCrossBorderTrade;
            set => this.mCrossBorderTrade = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BusinessSellerDetailsType BusinessSellerDetails
        {
            get => this.mBusinessSellerDetails;
            set => this.mBusinessSellerDetails = value;
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
        public BuyerRequirementDetailsType BuyerRequirementDetails
        {
            get => this.mBuyerRequirementDetails;
            set => this.mBuyerRequirementDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReturnPolicyType ReturnPolicy
        {
            get => this.mReturnPolicy;
            set => this.mReturnPolicy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("PaymentAllowedSite")]
        public SiteCodeTypeCollection PaymentAllowedSite
        {
            get => this.mPaymentAllowedSite;
            set => this.mPaymentAllowedSite = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InventoryTrackingMethodCodeType InventoryTrackingMethod
        {
            get => this.mInventoryTrackingMethod;
            set
            {
                this.mInventoryTrackingMethod = value;
                this.mInventoryTrackingMethodSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool InventoryTrackingMethodSpecified
        {
            get => this.mInventoryTrackingMethodSpecified;
            set => this.mInventoryTrackingMethodSpecified = value;
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
        public VariationsType Variations
        {
            get => this.mVariations;
            set => this.mVariations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ItemCompatibilityListType ItemCompatibilityList
        {
            get => this.mItemCompatibilityList;
            set => this.mItemCompatibilityList = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int ItemCompatibilityCount
        {
            get => this.mItemCompatibilityCount;
            set
            {
                this.mItemCompatibilityCount = value;
                this.mItemCompatibilityCountSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ItemCompatibilityCountSpecified
        {
            get => this.mItemCompatibilityCountSpecified;
            set => this.mItemCompatibilityCountSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int ConditionID
        {
            get => this.mConditionID;
            set
            {
                this.mConditionID = value;
                this.mConditionIDSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ConditionIDSpecified
        {
            get => this.mConditionIDSpecified;
            set => this.mConditionIDSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ConditionDescription
        {
            get => this.mConditionDescription;
            set => this.mConditionDescription = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ConditionDisplayName
        {
            get => this.mConditionDisplayName;
            set => this.mConditionDisplayName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string TaxCategory
        {
            get => this.mTaxCategory;
            set => this.mTaxCategory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuantityAvailableHintCodeType QuantityAvailableHint
        {
            get => this.mQuantityAvailableHint;
            set
            {
                this.mQuantityAvailableHint = value;
                this.mQuantityAvailableHintSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool QuantityAvailableHintSpecified
        {
            get => this.mQuantityAvailableHintSpecified;
            set => this.mQuantityAvailableHintSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int QuantityThreshold
        {
            get => this.mQuantityThreshold;
            set
            {
                this.mQuantityThreshold = value;
                this.mQuantityThresholdSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool QuantityThresholdSpecified
        {
            get => this.mQuantityThresholdSpecified;
            set => this.mQuantityThresholdSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DiscountPriceInfoType DiscountPriceInfo
        {
            get => this.mDiscountPriceInfo;
            set => this.mDiscountPriceInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string SellerProvidedTitle
        {
            get => this.mSellerProvidedTitle;
            set => this.mSellerProvidedTitle = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string VIN
        {
            get => this.mVIN;
            set => this.mVIN = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string VINLink
        {
            get => this.mVINLink;
            set => this.mVINLink = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string VRM
        {
            get => this.mVRM;
            set => this.mVRM = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string VRMLink
        {
            get => this.mVRMLink;
            set => this.mVRMLink = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuantityInfoType QuantityInfo
        {
            get => this.mQuantityInfo;
            set => this.mQuantityInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SellerProfilesType SellerProfiles
        {
            get => this.mSellerProfiles;
            set => this.mSellerProfiles = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShippingServiceCostOverrideListType ShippingServiceCostOverrideList
        {
            get => this.mShippingServiceCostOverrideList;
            set => this.mShippingServiceCostOverrideList = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShippingOverrideType ShippingOverride
        {
            get => this.mShippingOverride;
            set => this.mShippingOverride = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ShipPackageDetailsType ShippingPackageDetails
        {
            get => this.mShippingPackageDetails;
            set => this.mShippingPackageDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool TopRatedListing
        {
            get => this.mTopRatedListing;
            set
            {
                this.mTopRatedListing = value;
                this.mTopRatedListingSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool TopRatedListingSpecified
        {
            get => this.mTopRatedListingSpecified;
            set => this.mTopRatedListingSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QuantityRestrictionPerBuyerInfoType QuantityRestrictionPerBuyer
        {
            get => this.mQuantityRestrictionPerBuyer;
            set => this.mQuantityRestrictionPerBuyer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType FloorPrice
        {
            get => this.mFloorPrice;
            set => this.mFloorPrice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AmountType CeilingPrice
        {
            get => this.mCeilingPrice;
            set => this.mCeilingPrice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsIntermediatedShippingEligible
        {
            get => this.mIsIntermediatedShippingEligible;
            set
            {
                this.mIsIntermediatedShippingEligible = value;
                this.mIsIntermediatedShippingEligibleSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool IsIntermediatedShippingEligibleSpecified
        {
            get => this.mIsIntermediatedShippingEligibleSpecified;
            set => this.mIsIntermediatedShippingEligibleSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UnitInfoType UnitInfo
        {
            get => this.mUnitInfo;
            set => this.mUnitInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public long RelistParentID
        {
            get => this.mRelistParentID;
            set
            {
                this.mRelistParentID = value;
                this.mRelistParentIDSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool RelistParentIDSpecified
        {
            get => this.mRelistParentIDSpecified;
            set => this.mRelistParentIDSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ConditionDefinition
        {
            get => this.mConditionDefinition;
            set => this.mConditionDefinition = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool HideFromSearch
        {
            get => this.mHideFromSearch;
            set
            {
                this.mHideFromSearch = value;
                this.mHideFromSearchSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool HideFromSearchSpecified
        {
            get => this.mHideFromSearchSpecified;
            set => this.mHideFromSearchSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReasonHideFromSearchCodeType ReasonHideFromSearch
        {
            get => this.mReasonHideFromSearch;
            set
            {
                this.mReasonHideFromSearch = value;
                this.mReasonHideFromSearchSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool ReasonHideFromSearchSpecified
        {
            get => this.mReasonHideFromSearchSpecified;
            set => this.mReasonHideFromSearchSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [DefaultValue(false)]
        public bool IncludeRecommendations
        {
            get => this.mIncludeRecommendations;
            set => this.mIncludeRecommendations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PickupInStoreDetailsType PickupInStoreDetails
        {
            get => this.mPickupInStoreDetails;
            set => this.mPickupInStoreDetails = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public int SiteId
        {
            get => this.mSiteId;
            set
            {
                this.mSiteId = value;
                this.mSiteIdSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool SiteIdSpecified
        {
            get => this.mSiteIdSpecified;
            set => this.mSiteIdSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IgnoreQuantity
        {
            get => this.mIgnoreQuantity;
            set
            {
                this.mIgnoreQuantity = value;
                this.mIgnoreQuantitySpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool IgnoreQuantitySpecified
        {
            get => this.mIgnoreQuantitySpecified;
            set => this.mIgnoreQuantitySpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool AvailableForPickupDropOff
        {
            get => this.mAvailableForPickupDropOff;
            set
            {
                this.mAvailableForPickupDropOff = value;
                this.mAvailableForPickupDropOffSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool AvailableForPickupDropOffSpecified
        {
            get => this.mAvailableForPickupDropOffSpecified;
            set => this.mAvailableForPickupDropOffSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool EligibleForPickupDropOff
        {
            get => this.mEligibleForPickupDropOff;
            set
            {
                this.mEligibleForPickupDropOff = value;
                this.mEligibleForPickupDropOffSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool EligibleForPickupDropOffSpecified
        {
            get => this.mEligibleForPickupDropOffSpecified;
            set => this.mEligibleForPickupDropOffSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool LiveAuction
        {
            get => this.mLiveAuction;
            set
            {
                this.mLiveAuction = value;
                this.mLiveAuctionSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool LiveAuctionSpecified
        {
            get => this.mLiveAuctionSpecified;
            set => this.mLiveAuctionSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DigitalGoodInfoType DigitalGoodInfo
        {
            get => this.mDigitalGoodInfo;
            set => this.mDigitalGoodInfo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool eBayPlus
        {
            get => this.meBayPlus;
            set
            {
                this.meBayPlus = value;
                this.meBayPlusSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool eBayPlusSpecified
        {
            get => this.meBayPlusSpecified;
            set => this.meBayPlusSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool eBayPlusEligible
        {
            get => this.meBayPlusEligible;
            set
            {
                this.meBayPlusEligible = value;
                this.meBayPlusEligibleSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool eBayPlusEligibleSpecified
        {
            get => this.meBayPlusEligibleSpecified;
            set => this.meBayPlusEligibleSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool eMailDeliveryAvailable
        {
            get => this.meMailDeliveryAvailable;
            set
            {
                this.meMailDeliveryAvailable = value;
                this.meMailDeliveryAvailableSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool eMailDeliveryAvailableSpecified
        {
            get => this.meMailDeliveryAvailableSpecified;
            set => this.meMailDeliveryAvailableSpecified = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsSecureDescription
        {
            get => this.mIsSecureDescription;
            set
            {
                this.mIsSecureDescription = value;
                this.mIsSecureDescriptionSpecified = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public bool IsSecureDescriptionSpecified
        {
            get => this.mIsSecureDescriptionSpecified;
            set => this.mIsSecureDescriptionSpecified = value;
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
