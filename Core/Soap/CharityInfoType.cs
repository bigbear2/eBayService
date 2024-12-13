// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CharityInfoType
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
  public class CharityInfoType
  {
    private string mName;
    private bool mListingNPEmailNotifPref;
    private bool mListingNPEmailNotifPrefSpecified;
    private string mListingNPEmail;
    private string mListingNPContactName;
    private string mMission;
    private string mLogoURL;
    private CharityStatusCodeType mStatus;
    private bool mStatusSpecified;
    private string mSearchableString;
    private int mCharityRegion;
    private bool mCharityRegionSpecified;
    private Int32Collection mCharityDomain;
    private string mCharityID;
    private string mLogoURLSelling;
    private bool mDisplayLogoSelling;
    private bool mDisplayLogoSellingSpecified;
    private bool mDisplayNameInCheckout;
    private bool mDisplayNameInCheckoutSpecified;
    private string mDescription;
    private bool mShowMultipleDonationAmountInCheckout;
    private bool mShowMultipleDonationAmountInCheckoutSpecified;
    private string mExternalID;
    private int mPopularityIndex;
    private bool mPopularityIndexSpecified;
    private string mEIN;
    private string mNonProfitSecondName;
    private NonProfitAddressTypeCollection mNonProfitAddress;
    private NonProfitSocialAddressTypeCollection mNonProfitSocialAddress;
    private XmlElementCollection mAny;
    private string mid;

    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ListingNPEmailNotifPref
    {
      get => this.mListingNPEmailNotifPref;
      set
      {
        this.mListingNPEmailNotifPref = value;
        this.mListingNPEmailNotifPrefSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingNPEmailNotifPrefSpecified
    {
      get => this.mListingNPEmailNotifPrefSpecified;
      set => this.mListingNPEmailNotifPrefSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ListingNPEmail
    {
      get => this.mListingNPEmail;
      set => this.mListingNPEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ListingNPContactName
    {
      get => this.mListingNPContactName;
      set => this.mListingNPContactName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Mission
    {
      get => this.mMission;
      set => this.mMission = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string LogoURL
    {
      get => this.mLogoURL;
      set => this.mLogoURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CharityStatusCodeType Status
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
    public string SearchableString
    {
      get => this.mSearchableString;
      set => this.mSearchableString = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CharityRegion
    {
      get => this.mCharityRegion;
      set
      {
        this.mCharityRegion = value;
        this.mCharityRegionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityRegionSpecified
    {
      get => this.mCharityRegionSpecified;
      set => this.mCharityRegionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CharityDomain")]
    public Int32Collection CharityDomain
    {
      get => this.mCharityDomain;
      set => this.mCharityDomain = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CharityID
    {
      get => this.mCharityID;
      set => this.mCharityID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string LogoURLSelling
    {
      get => this.mLogoURLSelling;
      set => this.mLogoURLSelling = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DisplayLogoSelling
    {
      get => this.mDisplayLogoSelling;
      set
      {
        this.mDisplayLogoSelling = value;
        this.mDisplayLogoSellingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayLogoSellingSpecified
    {
      get => this.mDisplayLogoSellingSpecified;
      set => this.mDisplayLogoSellingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DisplayNameInCheckout
    {
      get => this.mDisplayNameInCheckout;
      set
      {
        this.mDisplayNameInCheckout = value;
        this.mDisplayNameInCheckoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayNameInCheckoutSpecified
    {
      get => this.mDisplayNameInCheckoutSpecified;
      set => this.mDisplayNameInCheckoutSpecified = value;
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
    public bool ShowMultipleDonationAmountInCheckout
    {
      get => this.mShowMultipleDonationAmountInCheckout;
      set
      {
        this.mShowMultipleDonationAmountInCheckout = value;
        this.mShowMultipleDonationAmountInCheckoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowMultipleDonationAmountInCheckoutSpecified
    {
      get => this.mShowMultipleDonationAmountInCheckoutSpecified;
      set => this.mShowMultipleDonationAmountInCheckoutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalID
    {
      get => this.mExternalID;
      set => this.mExternalID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PopularityIndex
    {
      get => this.mPopularityIndex;
      set
      {
        this.mPopularityIndex = value;
        this.mPopularityIndexSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PopularityIndexSpecified
    {
      get => this.mPopularityIndexSpecified;
      set => this.mPopularityIndexSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EIN
    {
      get => this.mEIN;
      set => this.mEIN = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NonProfitSecondName
    {
      get => this.mNonProfitSecondName;
      set => this.mNonProfitSecondName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("NonProfitAddress")]
    public NonProfitAddressTypeCollection NonProfitAddress
    {
      get => this.mNonProfitAddress;
      set => this.mNonProfitAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("NonProfitSocialAddress")]
    public NonProfitSocialAddressTypeCollection NonProfitSocialAddress
    {
      get => this.mNonProfitSocialAddress;
      set => this.mNonProfitSocialAddress = value;
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
    [XmlAttribute]
    public string id
    {
      get => this.mid;
      set => this.mid = value;
    }
  }
}
