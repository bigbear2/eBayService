// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CategoryType
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
  public class CategoryType
  {
    private bool mBestOfferEnabled;
    private bool mBestOfferEnabledSpecified;
    private bool mAutoPayEnabled;
    private bool mAutoPayEnabledSpecified;
    private bool mB2BVATEnabled;
    private bool mB2BVATEnabledSpecified;
    private bool mCatalogEnabled;
    private bool mCatalogEnabledSpecified;
    private string mCategoryID;
    private int mCategoryLevel;
    private bool mCategoryLevelSpecified;
    private string mCategoryName;
    private StringCollection mCategoryParentID;
    private StringCollection mCategoryParentName;
    private bool mProductSearchPageAvailable;
    private bool mProductSearchPageAvailableSpecified;
    private ExtendedProductFinderIDTypeCollection mProductFinderIDs;
    private CharacteristicsSetTypeCollection mCharacteristicsSets;
    private bool mExpired;
    private bool mExpiredSpecified;
    private bool mIntlAutosFixedCat;
    private bool mIntlAutosFixedCatSpecified;
    private bool mLeafCategory;
    private bool mLeafCategorySpecified;
    private bool mVirtual;
    private bool mVirtualSpecified;
    private int mNumOfItems;
    private bool mNumOfItemsSpecified;
    private bool mSellerGuaranteeEligible;
    private bool mSellerGuaranteeEligibleSpecified;
    private bool mORPA;
    private bool mORPASpecified;
    private bool mORRA;
    private bool mORRASpecified;
    private bool mLSD;
    private bool mLSDSpecified;
    private string mKeywords;
    private XmlElementCollection mAny;

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
    public bool AutoPayEnabled
    {
      get => this.mAutoPayEnabled;
      set
      {
        this.mAutoPayEnabled = value;
        this.mAutoPayEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AutoPayEnabledSpecified
    {
      get => this.mAutoPayEnabledSpecified;
      set => this.mAutoPayEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool B2BVATEnabled
    {
      get => this.mB2BVATEnabled;
      set
      {
        this.mB2BVATEnabled = value;
        this.mB2BVATEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool B2BVATEnabledSpecified
    {
      get => this.mB2BVATEnabledSpecified;
      set => this.mB2BVATEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CatalogEnabled
    {
      get => this.mCatalogEnabled;
      set
      {
        this.mCatalogEnabled = value;
        this.mCatalogEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CatalogEnabledSpecified
    {
      get => this.mCatalogEnabledSpecified;
      set => this.mCatalogEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CategoryLevel
    {
      get => this.mCategoryLevel;
      set
      {
        this.mCategoryLevel = value;
        this.mCategoryLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryLevelSpecified
    {
      get => this.mCategoryLevelSpecified;
      set => this.mCategoryLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryName
    {
      get => this.mCategoryName;
      set => this.mCategoryName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CategoryParentID")]
    public StringCollection CategoryParentID
    {
      get => this.mCategoryParentID;
      set => this.mCategoryParentID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CategoryParentName")]
    public StringCollection CategoryParentName
    {
      get => this.mCategoryParentName;
      set => this.mCategoryParentName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ProductSearchPageAvailable
    {
      get => this.mProductSearchPageAvailable;
      set
      {
        this.mProductSearchPageAvailable = value;
        this.mProductSearchPageAvailableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProductSearchPageAvailableSpecified
    {
      get => this.mProductSearchPageAvailableSpecified;
      set => this.mProductSearchPageAvailableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ProductFinderIDs")]
    public ExtendedProductFinderIDTypeCollection ProductFinderIDs
    {
      get => this.mProductFinderIDs;
      set => this.mProductFinderIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CharacteristicsSets")]
    public CharacteristicsSetTypeCollection CharacteristicsSets
    {
      get => this.mCharacteristicsSets;
      set => this.mCharacteristicsSets = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Expired
    {
      get => this.mExpired;
      set
      {
        this.mExpired = value;
        this.mExpiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpiredSpecified
    {
      get => this.mExpiredSpecified;
      set => this.mExpiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IntlAutosFixedCat
    {
      get => this.mIntlAutosFixedCat;
      set
      {
        this.mIntlAutosFixedCat = value;
        this.mIntlAutosFixedCatSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IntlAutosFixedCatSpecified
    {
      get => this.mIntlAutosFixedCatSpecified;
      set => this.mIntlAutosFixedCatSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LeafCategory
    {
      get => this.mLeafCategory;
      set
      {
        this.mLeafCategory = value;
        this.mLeafCategorySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LeafCategorySpecified
    {
      get => this.mLeafCategorySpecified;
      set => this.mLeafCategorySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Virtual
    {
      get => this.mVirtual;
      set
      {
        this.mVirtual = value;
        this.mVirtualSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VirtualSpecified
    {
      get => this.mVirtualSpecified;
      set => this.mVirtualSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NumOfItems
    {
      get => this.mNumOfItems;
      set
      {
        this.mNumOfItems = value;
        this.mNumOfItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NumOfItemsSpecified
    {
      get => this.mNumOfItemsSpecified;
      set => this.mNumOfItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerGuaranteeEligible
    {
      get => this.mSellerGuaranteeEligible;
      set
      {
        this.mSellerGuaranteeEligible = value;
        this.mSellerGuaranteeEligibleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerGuaranteeEligibleSpecified
    {
      get => this.mSellerGuaranteeEligibleSpecified;
      set => this.mSellerGuaranteeEligibleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ORPA
    {
      get => this.mORPA;
      set
      {
        this.mORPA = value;
        this.mORPASpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ORPASpecified
    {
      get => this.mORPASpecified;
      set => this.mORPASpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ORRA
    {
      get => this.mORRA;
      set
      {
        this.mORRA = value;
        this.mORRASpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ORRASpecified
    {
      get => this.mORRASpecified;
      set => this.mORRASpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LSD
    {
      get => this.mLSD;
      set
      {
        this.mLSD = value;
        this.mLSDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LSDSpecified
    {
      get => this.mLSDSpecified;
      set => this.mLSDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Keywords
    {
      get => this.mKeywords;
      set => this.mKeywords = value;
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
