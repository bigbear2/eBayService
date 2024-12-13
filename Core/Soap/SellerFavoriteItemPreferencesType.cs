// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerFavoriteItemPreferencesType
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
  public class SellerFavoriteItemPreferencesType
  {
    private string mSearchKeywords;
    private long mStoreCategoryID;
    private bool mStoreCategoryIDSpecified;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private StoreItemListSortOrderCodeType mSearchSortOrder;
    private bool mSearchSortOrderSpecified;
    private AmountType mMinPrice;
    private AmountType mMaxPrice;
    private StringCollection mFavoriteItemID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string SearchKeywords
    {
      get => this.mSearchKeywords;
      set => this.mSearchKeywords = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long StoreCategoryID
    {
      get => this.mStoreCategoryID;
      set
      {
        this.mStoreCategoryID = value;
        this.mStoreCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreCategoryIDSpecified
    {
      get => this.mStoreCategoryIDSpecified;
      set => this.mStoreCategoryIDSpecified = value;
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
    public StoreItemListSortOrderCodeType SearchSortOrder
    {
      get => this.mSearchSortOrder;
      set
      {
        this.mSearchSortOrder = value;
        this.mSearchSortOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SearchSortOrderSpecified
    {
      get => this.mSearchSortOrderSpecified;
      set => this.mSearchSortOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MinPrice
    {
      get => this.mMinPrice;
      set => this.mMinPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MaxPrice
    {
      get => this.mMaxPrice;
      set => this.mMaxPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FavoriteItemID")]
    public StringCollection FavoriteItemID
    {
      get => this.mFavoriteItemID;
      set => this.mFavoriteItemID = value;
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
