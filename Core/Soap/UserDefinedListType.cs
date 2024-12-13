// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UserDefinedListType
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
  public class UserDefinedListType
  {
    private string mName;
    private int mItemCount;
    private bool mItemCountSpecified;
    private int mFavoriteSearcheCount;
    private bool mFavoriteSearcheCountSpecified;
    private int mFavoriteSellerCount;
    private bool mFavoriteSellerCountSpecified;
    private ItemTypeCollection mItemArray;
    private MyeBayFavoriteSearchListType mFavoriteSearches;
    private MyeBayFavoriteSellerListType mFavoriteSellers;
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
    public int ItemCount
    {
      get => this.mItemCount;
      set
      {
        this.mItemCount = value;
        this.mItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemCountSpecified
    {
      get => this.mItemCountSpecified;
      set => this.mItemCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FavoriteSearcheCount
    {
      get => this.mFavoriteSearcheCount;
      set
      {
        this.mFavoriteSearcheCount = value;
        this.mFavoriteSearcheCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FavoriteSearcheCountSpecified
    {
      get => this.mFavoriteSearcheCountSpecified;
      set => this.mFavoriteSearcheCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FavoriteSellerCount
    {
      get => this.mFavoriteSellerCount;
      set
      {
        this.mFavoriteSellerCount = value;
        this.mFavoriteSellerCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FavoriteSellerCountSpecified
    {
      get => this.mFavoriteSellerCountSpecified;
      set => this.mFavoriteSellerCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Item", IsNullable = false)]
    public ItemTypeCollection ItemArray
    {
      get => this.mItemArray;
      set => this.mItemArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyeBayFavoriteSearchListType FavoriteSearches
    {
      get => this.mFavoriteSearches;
      set => this.mFavoriteSearches = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyeBayFavoriteSellerListType FavoriteSellers
    {
      get => this.mFavoriteSellers;
      set => this.mFavoriteSellers = value;
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
