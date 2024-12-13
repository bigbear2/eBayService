// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UserType
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
  public class UserType
  {
    private bool mAboutMePage;
    private bool mAboutMePageSpecified;
    private string mEIASToken;
    private string mEmail;
    private int mFeedbackScore;
    private bool mFeedbackScoreSpecified;
    private int mUniqueNegativeFeedbackCount;
    private bool mUniqueNegativeFeedbackCountSpecified;
    private int mUniquePositiveFeedbackCount;
    private bool mUniquePositiveFeedbackCountSpecified;
    private float mPositiveFeedbackPercent;
    private bool mPositiveFeedbackPercentSpecified;
    private bool mFeedbackPrivate;
    private bool mFeedbackPrivateSpecified;
    private FeedbackRatingStarCodeType mFeedbackRatingStar;
    private bool mFeedbackRatingStarSpecified;
    private bool mIDVerified;
    private bool mIDVerifiedSpecified;
    private bool meBayGoodStanding;
    private bool meBayGoodStandingSpecified;
    private bool mNewUser;
    private bool mNewUserSpecified;
    private AddressType mRegistrationAddress;
    private DateTime mRegistrationDate;
    private bool mRegistrationDateSpecified;
    private SiteCodeType mSite;
    private bool mSiteSpecified;
    private UserStatusCodeType mStatus;
    private bool mStatusSpecified;
    private string mUserID;
    private bool mUserIDChanged;
    private bool mUserIDChangedSpecified;
    private DateTime mUserIDLastChanged;
    private bool mUserIDLastChangedSpecified;
    private VATStatusCodeType mVATStatus;
    private bool mVATStatusSpecified;
    private BuyerType mBuyerInfo;
    private SellerType mSellerInfo;
    private BusinessRoleType mBusinessRole;
    private bool mBusinessRoleSpecified;
    private CharityAffiliationsType mCharityAffiliations;
    private PayPalAccountLevelCodeType mPayPalAccountLevel;
    private bool mPayPalAccountLevelSpecified;
    private PayPalAccountTypeCodeType mPayPalAccountType;
    private bool mPayPalAccountTypeSpecified;
    private PayPalAccountStatusCodeType mPayPalAccountStatus;
    private bool mPayPalAccountStatusSpecified;
    private EBaySubscriptionTypeCodeTypeCollection mUserSubscription;
    private bool mSiteVerified;
    private bool mSiteVerifiedSpecified;
    private StringCollection mSkypeID;
    private bool meBayWikiReadOnly;
    private bool meBayWikiReadOnlySpecified;
    private int mTUVLevel;
    private bool mTUVLevelSpecified;
    private string mVATID;
    private SellerPaymentMethodCodeType mSellerPaymentMethod;
    private bool mSellerPaymentMethodSpecified;
    private BiddingSummaryType mBiddingSummary;
    private bool mUserAnonymized;
    private bool mUserAnonymizedSpecified;
    private int mUniqueNeutralFeedbackCount;
    private bool mUniqueNeutralFeedbackCountSpecified;
    private bool mEnterpriseSeller;
    private bool mEnterpriseSellerSpecified;
    private string mBillingEmail;
    private bool mQualifiesForSelling;
    private bool mQualifiesForSellingSpecified;
    private string mStaticAlias;
    private AddressType mShippingAddress;
    private MembershipDetailTypeCollection mMembership;
    private string mUserFirstName;
    private string mUserLastName;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool AboutMePage
    {
      get => this.mAboutMePage;
      set
      {
        this.mAboutMePage = value;
        this.mAboutMePageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AboutMePageSpecified
    {
      get => this.mAboutMePageSpecified;
      set => this.mAboutMePageSpecified = value;
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
    public string Email
    {
      get => this.mEmail;
      set => this.mEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FeedbackScore
    {
      get => this.mFeedbackScore;
      set
      {
        this.mFeedbackScore = value;
        this.mFeedbackScoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackScoreSpecified
    {
      get => this.mFeedbackScoreSpecified;
      set => this.mFeedbackScoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniqueNegativeFeedbackCount
    {
      get => this.mUniqueNegativeFeedbackCount;
      set
      {
        this.mUniqueNegativeFeedbackCount = value;
        this.mUniqueNegativeFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniqueNegativeFeedbackCountSpecified
    {
      get => this.mUniqueNegativeFeedbackCountSpecified;
      set => this.mUniqueNegativeFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniquePositiveFeedbackCount
    {
      get => this.mUniquePositiveFeedbackCount;
      set
      {
        this.mUniquePositiveFeedbackCount = value;
        this.mUniquePositiveFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniquePositiveFeedbackCountSpecified
    {
      get => this.mUniquePositiveFeedbackCountSpecified;
      set => this.mUniquePositiveFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float PositiveFeedbackPercent
    {
      get => this.mPositiveFeedbackPercent;
      set
      {
        this.mPositiveFeedbackPercent = value;
        this.mPositiveFeedbackPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PositiveFeedbackPercentSpecified
    {
      get => this.mPositiveFeedbackPercentSpecified;
      set => this.mPositiveFeedbackPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FeedbackPrivate
    {
      get => this.mFeedbackPrivate;
      set
      {
        this.mFeedbackPrivate = value;
        this.mFeedbackPrivateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackPrivateSpecified
    {
      get => this.mFeedbackPrivateSpecified;
      set => this.mFeedbackPrivateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeedbackRatingStarCodeType FeedbackRatingStar
    {
      get => this.mFeedbackRatingStar;
      set
      {
        this.mFeedbackRatingStar = value;
        this.mFeedbackRatingStarSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackRatingStarSpecified
    {
      get => this.mFeedbackRatingStarSpecified;
      set => this.mFeedbackRatingStarSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IDVerified
    {
      get => this.mIDVerified;
      set
      {
        this.mIDVerified = value;
        this.mIDVerifiedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IDVerifiedSpecified
    {
      get => this.mIDVerifiedSpecified;
      set => this.mIDVerifiedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayGoodStanding
    {
      get => this.meBayGoodStanding;
      set
      {
        this.meBayGoodStanding = value;
        this.meBayGoodStandingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayGoodStandingSpecified
    {
      get => this.meBayGoodStandingSpecified;
      set => this.meBayGoodStandingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool NewUser
    {
      get => this.mNewUser;
      set
      {
        this.mNewUser = value;
        this.mNewUserSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewUserSpecified
    {
      get => this.mNewUserSpecified;
      set => this.mNewUserSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType RegistrationAddress
    {
      get => this.mRegistrationAddress;
      set => this.mRegistrationAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RegistrationDate
    {
      get => this.mRegistrationDate;
      set
      {
        this.mRegistrationDate = value;
        this.mRegistrationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RegistrationDateSpecified
    {
      get => this.mRegistrationDateSpecified;
      set => this.mRegistrationDateSpecified = value;
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
    public UserStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UserIDChanged
    {
      get => this.mUserIDChanged;
      set
      {
        this.mUserIDChanged = value;
        this.mUserIDChangedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserIDChangedSpecified
    {
      get => this.mUserIDChangedSpecified;
      set => this.mUserIDChangedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UserIDLastChanged
    {
      get => this.mUserIDLastChanged;
      set
      {
        this.mUserIDLastChanged = value;
        this.mUserIDLastChangedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserIDLastChangedSpecified
    {
      get => this.mUserIDLastChangedSpecified;
      set => this.mUserIDLastChangedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VATStatusCodeType VATStatus
    {
      get => this.mVATStatus;
      set
      {
        this.mVATStatus = value;
        this.mVATStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VATStatusSpecified
    {
      get => this.mVATStatusSpecified;
      set => this.mVATStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerType BuyerInfo
    {
      get => this.mBuyerInfo;
      set => this.mBuyerInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerType SellerInfo
    {
      get => this.mSellerInfo;
      set => this.mSellerInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BusinessRoleType BusinessRole
    {
      get => this.mBusinessRole;
      set
      {
        this.mBusinessRole = value;
        this.mBusinessRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BusinessRoleSpecified
    {
      get => this.mBusinessRoleSpecified;
      set => this.mBusinessRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CharityAffiliationsType CharityAffiliations
    {
      get => this.mCharityAffiliations;
      set => this.mCharityAffiliations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalAccountLevelCodeType PayPalAccountLevel
    {
      get => this.mPayPalAccountLevel;
      set
      {
        this.mPayPalAccountLevel = value;
        this.mPayPalAccountLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalAccountLevelSpecified
    {
      get => this.mPayPalAccountLevelSpecified;
      set => this.mPayPalAccountLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalAccountTypeCodeType PayPalAccountType
    {
      get => this.mPayPalAccountType;
      set
      {
        this.mPayPalAccountType = value;
        this.mPayPalAccountTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalAccountTypeSpecified
    {
      get => this.mPayPalAccountTypeSpecified;
      set => this.mPayPalAccountTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayPalAccountStatusCodeType PayPalAccountStatus
    {
      get => this.mPayPalAccountStatus;
      set
      {
        this.mPayPalAccountStatus = value;
        this.mPayPalAccountStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalAccountStatusSpecified
    {
      get => this.mPayPalAccountStatusSpecified;
      set => this.mPayPalAccountStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UserSubscription")]
    public EBaySubscriptionTypeCodeTypeCollection UserSubscription
    {
      get => this.mUserSubscription;
      set => this.mUserSubscription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SiteVerified
    {
      get => this.mSiteVerified;
      set
      {
        this.mSiteVerified = value;
        this.mSiteVerifiedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SiteVerifiedSpecified
    {
      get => this.mSiteVerifiedSpecified;
      set => this.mSiteVerifiedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SkypeID")]
    public StringCollection SkypeID
    {
      get => this.mSkypeID;
      set => this.mSkypeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool eBayWikiReadOnly
    {
      get => this.meBayWikiReadOnly;
      set
      {
        this.meBayWikiReadOnly = value;
        this.meBayWikiReadOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayWikiReadOnlySpecified
    {
      get => this.meBayWikiReadOnlySpecified;
      set => this.meBayWikiReadOnlySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TUVLevel
    {
      get => this.mTUVLevel;
      set
      {
        this.mTUVLevel = value;
        this.mTUVLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TUVLevelSpecified
    {
      get => this.mTUVLevelSpecified;
      set => this.mTUVLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string VATID
    {
      get => this.mVATID;
      set => this.mVATID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerPaymentMethodCodeType SellerPaymentMethod
    {
      get => this.mSellerPaymentMethod;
      set
      {
        this.mSellerPaymentMethod = value;
        this.mSellerPaymentMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerPaymentMethodSpecified
    {
      get => this.mSellerPaymentMethodSpecified;
      set => this.mSellerPaymentMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BiddingSummaryType BiddingSummary
    {
      get => this.mBiddingSummary;
      set => this.mBiddingSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UserAnonymized
    {
      get => this.mUserAnonymized;
      set
      {
        this.mUserAnonymized = value;
        this.mUserAnonymizedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserAnonymizedSpecified
    {
      get => this.mUserAnonymizedSpecified;
      set => this.mUserAnonymizedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniqueNeutralFeedbackCount
    {
      get => this.mUniqueNeutralFeedbackCount;
      set
      {
        this.mUniqueNeutralFeedbackCount = value;
        this.mUniqueNeutralFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniqueNeutralFeedbackCountSpecified
    {
      get => this.mUniqueNeutralFeedbackCountSpecified;
      set => this.mUniqueNeutralFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EnterpriseSeller
    {
      get => this.mEnterpriseSeller;
      set
      {
        this.mEnterpriseSeller = value;
        this.mEnterpriseSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EnterpriseSellerSpecified
    {
      get => this.mEnterpriseSellerSpecified;
      set => this.mEnterpriseSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BillingEmail
    {
      get => this.mBillingEmail;
      set => this.mBillingEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiesForSelling
    {
      get => this.mQualifiesForSelling;
      set
      {
        this.mQualifiesForSelling = value;
        this.mQualifiesForSellingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiesForSellingSpecified
    {
      get => this.mQualifiesForSellingSpecified;
      set => this.mQualifiesForSellingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StaticAlias
    {
      get => this.mStaticAlias;
      set => this.mStaticAlias = value;
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
    [XmlArrayItem("Program", IsNullable = false)]
    public MembershipDetailTypeCollection Membership
    {
      get => this.mMembership;
      set => this.mMembership = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UserFirstName
    {
      get => this.mUserFirstName;
      set => this.mUserFirstName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UserLastName
    {
      get => this.mUserLastName;
      set => this.mUserLastName = value;
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
