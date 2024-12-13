// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreType
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
  public class StoreType
  {
    private string mName;
    private string mURLPath;
    private string mURL;
    private StoreSubscriptionLevelCodeType mSubscriptionLevel;
    private bool mSubscriptionLevelSpecified;
    private string mDescription;
    private StoreLogoType mLogo;
    private StoreThemeType mTheme;
    private StoreHeaderStyleCodeType mHeaderStyle;
    private bool mHeaderStyleSpecified;
    private long mHomePage;
    private bool mHomePageSpecified;
    private StoreItemListLayoutCodeType mItemListLayout;
    private bool mItemListLayoutSpecified;
    private StoreItemListSortOrderCodeType mItemListSortOrder;
    private bool mItemListSortOrderSpecified;
    private StoreCustomHeaderLayoutCodeType mCustomHeaderLayout;
    private bool mCustomHeaderLayoutSpecified;
    private string mCustomHeader;
    private bool mExportListings;
    private bool mExportListingsSpecified;
    private StoreCustomCategoryTypeCollection mCustomCategories;
    private StoreCustomListingHeaderType mCustomListingHeader;
    private MerchDisplayCodeType mMerchDisplay;
    private bool mMerchDisplaySpecified;
    private DateTime mLastOpenedTime;
    private bool mLastOpenedTimeSpecified;
    private bool mTitleWithCompatibility;
    private bool mTitleWithCompatibilitySpecified;
    private XmlElementCollection mAny;

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
    public string URLPath
    {
      get => this.mURLPath;
      set => this.mURLPath = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string URL
    {
      get => this.mURL;
      set => this.mURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreSubscriptionLevelCodeType SubscriptionLevel
    {
      get => this.mSubscriptionLevel;
      set
      {
        this.mSubscriptionLevel = value;
        this.mSubscriptionLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SubscriptionLevelSpecified
    {
      get => this.mSubscriptionLevelSpecified;
      set => this.mSubscriptionLevelSpecified = value;
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
    public StoreLogoType Logo
    {
      get => this.mLogo;
      set => this.mLogo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreThemeType Theme
    {
      get => this.mTheme;
      set => this.mTheme = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreHeaderStyleCodeType HeaderStyle
    {
      get => this.mHeaderStyle;
      set
      {
        this.mHeaderStyle = value;
        this.mHeaderStyleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HeaderStyleSpecified
    {
      get => this.mHeaderStyleSpecified;
      set => this.mHeaderStyleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long HomePage
    {
      get => this.mHomePage;
      set
      {
        this.mHomePage = value;
        this.mHomePageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HomePageSpecified
    {
      get => this.mHomePageSpecified;
      set => this.mHomePageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreItemListLayoutCodeType ItemListLayout
    {
      get => this.mItemListLayout;
      set
      {
        this.mItemListLayout = value;
        this.mItemListLayoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemListLayoutSpecified
    {
      get => this.mItemListLayoutSpecified;
      set => this.mItemListLayoutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreItemListSortOrderCodeType ItemListSortOrder
    {
      get => this.mItemListSortOrder;
      set
      {
        this.mItemListSortOrder = value;
        this.mItemListSortOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemListSortOrderSpecified
    {
      get => this.mItemListSortOrderSpecified;
      set => this.mItemListSortOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomHeaderLayoutCodeType CustomHeaderLayout
    {
      get => this.mCustomHeaderLayout;
      set
      {
        this.mCustomHeaderLayout = value;
        this.mCustomHeaderLayoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CustomHeaderLayoutSpecified
    {
      get => this.mCustomHeaderLayoutSpecified;
      set => this.mCustomHeaderLayoutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CustomHeader
    {
      get => this.mCustomHeader;
      set => this.mCustomHeader = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExportListings
    {
      get => this.mExportListings;
      set
      {
        this.mExportListings = value;
        this.mExportListingsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExportListingsSpecified
    {
      get => this.mExportListingsSpecified;
      set => this.mExportListingsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("CustomCategory", IsNullable = false)]
    public StoreCustomCategoryTypeCollection CustomCategories
    {
      get => this.mCustomCategories;
      set => this.mCustomCategories = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomListingHeaderType CustomListingHeader
    {
      get => this.mCustomListingHeader;
      set => this.mCustomListingHeader = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MerchDisplayCodeType MerchDisplay
    {
      get => this.mMerchDisplay;
      set
      {
        this.mMerchDisplay = value;
        this.mMerchDisplaySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MerchDisplaySpecified
    {
      get => this.mMerchDisplaySpecified;
      set => this.mMerchDisplaySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastOpenedTime
    {
      get => this.mLastOpenedTime;
      set
      {
        this.mLastOpenedTime = value;
        this.mLastOpenedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastOpenedTimeSpecified
    {
      get => this.mLastOpenedTimeSpecified;
      set => this.mLastOpenedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool TitleWithCompatibility
    {
      get => this.mTitleWithCompatibility;
      set
      {
        this.mTitleWithCompatibility = value;
        this.mTitleWithCompatibilitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TitleWithCompatibilitySpecified
    {
      get => this.mTitleWithCompatibilitySpecified;
      set => this.mTitleWithCompatibilitySpecified = value;
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
