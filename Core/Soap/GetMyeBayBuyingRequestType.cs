// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMyeBayBuyingRequestType
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
  public class GetMyeBayBuyingRequestType : AbstractRequestType
  {
    private ItemListCustomizationType mWatchList;
    private ItemListCustomizationType mBidList;
    private ItemListCustomizationType mBestOfferList;
    private ItemListCustomizationType mWonList;
    private ItemListCustomizationType mLostList;
    private MyeBaySelectionType mFavoriteSearches;
    private MyeBaySelectionType mFavoriteSellers;
    private MyeBaySelectionType mSecondChanceOffer;
    private BidAssistantListType mBidAssistantList;
    private ItemListCustomizationType mDeletedFromWonList;
    private ItemListCustomizationType mDeletedFromLostList;
    private ItemListCustomizationType mBuyingSummary;
    private MyeBaySelectionType mUserDefinedLists;
    private bool mHideVariations;
    private bool mHideVariationsSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public ItemListCustomizationType WatchList
    {
      get => this.mWatchList;
      set => this.mWatchList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public ItemListCustomizationType BidList
    {
      get => this.mBidList;
      set => this.mBidList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public ItemListCustomizationType BestOfferList
    {
      get => this.mBestOfferList;
      set => this.mBestOfferList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public ItemListCustomizationType WonList
    {
      get => this.mWonList;
      set => this.mWonList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public ItemListCustomizationType LostList
    {
      get => this.mLostList;
      set => this.mLostList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public MyeBaySelectionType FavoriteSearches
    {
      get => this.mFavoriteSearches;
      set => this.mFavoriteSearches = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public MyeBaySelectionType FavoriteSellers
    {
      get => this.mFavoriteSellers;
      set => this.mFavoriteSellers = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public MyeBaySelectionType SecondChanceOffer
    {
      get => this.mSecondChanceOffer;
      set => this.mSecondChanceOffer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public BidAssistantListType BidAssistantList
    {
      get => this.mBidAssistantList;
      set => this.mBidAssistantList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public ItemListCustomizationType DeletedFromWonList
    {
      get => this.mDeletedFromWonList;
      set => this.mDeletedFromWonList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public ItemListCustomizationType DeletedFromLostList
    {
      get => this.mDeletedFromLostList;
      set => this.mDeletedFromLostList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public ItemListCustomizationType BuyingSummary
    {
      get => this.mBuyingSummary;
      set => this.mBuyingSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    public MyeBaySelectionType UserDefinedLists
    {
      get => this.mUserDefinedLists;
      set => this.mUserDefinedLists = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    public bool HideVariations
    {
      get => this.mHideVariations;
      set
      {
        this.mHideVariations = value;
        this.mHideVariationsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HideVariationsSpecified
    {
      get => this.mHideVariationsSpecified;
      set => this.mHideVariationsSpecified = value;
    }
  }
}
