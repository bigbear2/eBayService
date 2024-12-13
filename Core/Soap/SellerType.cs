// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerType
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
  public class SellerType
  {
    private int mPaisaPayStatus;
    private bool mPaisaPayStatusSpecified;
    private bool mAllowPaymentEdit;
    private CurrencyCodeType mBillingCurrency;
    private bool mBillingCurrencySpecified;
    private bool mCheckoutEnabled;
    private bool mCIPBankAccountStored;
    private bool mGoodStanding;
    private MerchandizingPrefCodeType mMerchandizingPref;
    private bool mMerchandizingPrefSpecified;
    private bool mQualifiesForB2BVAT;
    private SellerGuaranteeLevelCodeType mSellerGuaranteeLevel;
    private bool mSellerGuaranteeLevelSpecified;
    private SellerLevelCodeType mSellerLevel;
    private bool mSellerLevelSpecified;
    private AddressType mSellerPaymentAddress;
    private SchedulingInfoType mSchedulingInfo;
    private bool mStoreOwner;
    private string mStoreURL;
    private SellerBusinessCodeType mSellerBusinessType;
    private bool mSellerBusinessTypeSpecified;
    private bool mRegisteredBusinessSeller;
    private bool mRegisteredBusinessSellerSpecified;
    private SiteCodeType mStoreSite;
    private bool mStoreSiteSpecified;
    private SellerPaymentMethodCodeType mPaymentMethod;
    private bool mPaymentMethodSpecified;
    private ProStoresCheckoutPreferenceType mProStoresPreference;
    private bool mCharityRegistered;
    private bool mCharityRegisteredSpecified;
    private bool mSafePaymentExempt;
    private bool mSafePaymentExemptSpecified;
    private int mPaisaPayEscrowEMIStatus;
    private bool mPaisaPayEscrowEMIStatusSpecified;
    private CharityAffiliationDetailTypeCollection mCharityAffiliationDetails;
    private float mTransactionPercent;
    private bool mTransactionPercentSpecified;
    private IntegratedMerchantCreditCardInfoType mIntegratedMerchantCreditCardInfo;
    private FeatureEligibilityType mFeatureEligibility;
    private bool mTopRatedSeller;
    private bool mTopRatedSellerSpecified;
    private TopRatedSellerDetailsType mTopRatedSellerDetails;
    private RecoupmentPolicyConsentType mRecoupmentPolicyConsent;
    private bool mDomesticRateTable;
    private bool mDomesticRateTableSpecified;
    private bool mInternationalRateTable;
    private bool mInternationalRateTableSpecified;
    private SellereBayPaymentProcessStatusCodeType mSellereBayPaymentProcessStatus;
    private bool mSellereBayPaymentProcessStatusSpecified;
    private SellereBayPaymentProcessConsentCodeType mSellereBayPaymentProcessConsent;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int PaisaPayStatus
    {
      get => this.mPaisaPayStatus;
      set
      {
        this.mPaisaPayStatus = value;
        this.mPaisaPayStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaisaPayStatusSpecified
    {
      get => this.mPaisaPayStatusSpecified;
      set => this.mPaisaPayStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AllowPaymentEdit
    {
      get => this.mAllowPaymentEdit;
      set => this.mAllowPaymentEdit = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyCodeType BillingCurrency
    {
      get => this.mBillingCurrency;
      set
      {
        this.mBillingCurrency = value;
        this.mBillingCurrencySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BillingCurrencySpecified
    {
      get => this.mBillingCurrencySpecified;
      set => this.mBillingCurrencySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CheckoutEnabled
    {
      get => this.mCheckoutEnabled;
      set => this.mCheckoutEnabled = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CIPBankAccountStored
    {
      get => this.mCIPBankAccountStored;
      set => this.mCIPBankAccountStored = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GoodStanding
    {
      get => this.mGoodStanding;
      set => this.mGoodStanding = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MerchandizingPrefCodeType MerchandizingPref
    {
      get => this.mMerchandizingPref;
      set
      {
        this.mMerchandizingPref = value;
        this.mMerchandizingPrefSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MerchandizingPrefSpecified
    {
      get => this.mMerchandizingPrefSpecified;
      set => this.mMerchandizingPrefSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiesForB2BVAT
    {
      get => this.mQualifiesForB2BVAT;
      set => this.mQualifiesForB2BVAT = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerGuaranteeLevelCodeType SellerGuaranteeLevel
    {
      get => this.mSellerGuaranteeLevel;
      set
      {
        this.mSellerGuaranteeLevel = value;
        this.mSellerGuaranteeLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerGuaranteeLevelSpecified
    {
      get => this.mSellerGuaranteeLevelSpecified;
      set => this.mSellerGuaranteeLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerLevelCodeType SellerLevel
    {
      get => this.mSellerLevel;
      set
      {
        this.mSellerLevel = value;
        this.mSellerLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerLevelSpecified
    {
      get => this.mSellerLevelSpecified;
      set => this.mSellerLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType SellerPaymentAddress
    {
      get => this.mSellerPaymentAddress;
      set => this.mSellerPaymentAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SchedulingInfoType SchedulingInfo
    {
      get => this.mSchedulingInfo;
      set => this.mSchedulingInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool StoreOwner
    {
      get => this.mStoreOwner;
      set => this.mStoreOwner = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string StoreURL
    {
      get => this.mStoreURL;
      set => this.mStoreURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerBusinessCodeType SellerBusinessType
    {
      get => this.mSellerBusinessType;
      set
      {
        this.mSellerBusinessType = value;
        this.mSellerBusinessTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerBusinessTypeSpecified
    {
      get => this.mSellerBusinessTypeSpecified;
      set => this.mSellerBusinessTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RegisteredBusinessSeller
    {
      get => this.mRegisteredBusinessSeller;
      set
      {
        this.mRegisteredBusinessSeller = value;
        this.mRegisteredBusinessSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RegisteredBusinessSellerSpecified
    {
      get => this.mRegisteredBusinessSellerSpecified;
      set => this.mRegisteredBusinessSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteCodeType StoreSite
    {
      get => this.mStoreSite;
      set
      {
        this.mStoreSite = value;
        this.mStoreSiteSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreSiteSpecified
    {
      get => this.mStoreSiteSpecified;
      set => this.mStoreSiteSpecified = value;
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
    public ProStoresCheckoutPreferenceType ProStoresPreference
    {
      get => this.mProStoresPreference;
      set => this.mProStoresPreference = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CharityRegistered
    {
      get => this.mCharityRegistered;
      set
      {
        this.mCharityRegistered = value;
        this.mCharityRegisteredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityRegisteredSpecified
    {
      get => this.mCharityRegisteredSpecified;
      set => this.mCharityRegisteredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SafePaymentExempt
    {
      get => this.mSafePaymentExempt;
      set
      {
        this.mSafePaymentExempt = value;
        this.mSafePaymentExemptSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SafePaymentExemptSpecified
    {
      get => this.mSafePaymentExemptSpecified;
      set => this.mSafePaymentExemptSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PaisaPayEscrowEMIStatus
    {
      get => this.mPaisaPayEscrowEMIStatus;
      set
      {
        this.mPaisaPayEscrowEMIStatus = value;
        this.mPaisaPayEscrowEMIStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaisaPayEscrowEMIStatusSpecified
    {
      get => this.mPaisaPayEscrowEMIStatusSpecified;
      set => this.mPaisaPayEscrowEMIStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("CharityAffiliationDetail", IsNullable = false)]
    public CharityAffiliationDetailTypeCollection CharityAffiliationDetails
    {
      get => this.mCharityAffiliationDetails;
      set => this.mCharityAffiliationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float TransactionPercent
    {
      get => this.mTransactionPercent;
      set
      {
        this.mTransactionPercent = value;
        this.mTransactionPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionPercentSpecified
    {
      get => this.mTransactionPercentSpecified;
      set => this.mTransactionPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public IntegratedMerchantCreditCardInfoType IntegratedMerchantCreditCardInfo
    {
      get => this.mIntegratedMerchantCreditCardInfo;
      set => this.mIntegratedMerchantCreditCardInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeatureEligibilityType FeatureEligibility
    {
      get => this.mFeatureEligibility;
      set => this.mFeatureEligibility = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool TopRatedSeller
    {
      get => this.mTopRatedSeller;
      set
      {
        this.mTopRatedSeller = value;
        this.mTopRatedSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TopRatedSellerSpecified
    {
      get => this.mTopRatedSellerSpecified;
      set => this.mTopRatedSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TopRatedSellerDetailsType TopRatedSellerDetails
    {
      get => this.mTopRatedSellerDetails;
      set => this.mTopRatedSellerDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RecoupmentPolicyConsentType RecoupmentPolicyConsent
    {
      get => this.mRecoupmentPolicyConsent;
      set => this.mRecoupmentPolicyConsent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DomesticRateTable
    {
      get => this.mDomesticRateTable;
      set
      {
        this.mDomesticRateTable = value;
        this.mDomesticRateTableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DomesticRateTableSpecified
    {
      get => this.mDomesticRateTableSpecified;
      set => this.mDomesticRateTableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool InternationalRateTable
    {
      get => this.mInternationalRateTable;
      set
      {
        this.mInternationalRateTable = value;
        this.mInternationalRateTableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InternationalRateTableSpecified
    {
      get => this.mInternationalRateTableSpecified;
      set => this.mInternationalRateTableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellereBayPaymentProcessStatusCodeType SellereBayPaymentProcessStatus
    {
      get => this.mSellereBayPaymentProcessStatus;
      set
      {
        this.mSellereBayPaymentProcessStatus = value;
        this.mSellereBayPaymentProcessStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellereBayPaymentProcessStatusSpecified
    {
      get => this.mSellereBayPaymentProcessStatusSpecified;
      set => this.mSellereBayPaymentProcessStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellereBayPaymentProcessConsentCodeType SellereBayPaymentProcessConsent
    {
      get => this.mSellereBayPaymentProcessConsent;
      set => this.mSellereBayPaymentProcessConsent = value;
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
