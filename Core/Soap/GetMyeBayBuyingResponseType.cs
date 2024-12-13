// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMyeBayBuyingResponseType
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
  public class GetMyeBayBuyingResponseType : AbstractResponseType
  {
    private BuyingSummaryType mBuyingSummary;
    private PaginatedItemArrayType mWatchList;
    private PaginatedItemArrayType mBidList;
    private PaginatedItemArrayType mBestOfferList;
    private PaginatedOrderTransactionArrayType mWonList;
    private PaginatedItemArrayType mLostList;
    private MyeBayFavoriteSearchListType mFavoriteSearches;
    private MyeBayFavoriteSellerListType mFavoriteSellers;
    private ItemTypeCollection mSecondChanceOffer;
    private BidGroupTypeCollection mBidAssistantList;
    private PaginatedOrderTransactionArrayType mDeletedFromWonList;
    private PaginatedItemArrayType mDeletedFromLostList;
    private UserDefinedListTypeCollection mUserDefinedList;

    /// <summary>
    /// 
    /// </summary>
    public BuyingSummaryType BuyingSummary
    {
      get => this.mBuyingSummary;
      set => this.mBuyingSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType WatchList
    {
      get => this.mWatchList;
      set => this.mWatchList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType BidList
    {
      get => this.mBidList;
      set => this.mBidList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType BestOfferList
    {
      get => this.mBestOfferList;
      set => this.mBestOfferList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedOrderTransactionArrayType WonList
    {
      get => this.mWonList;
      set => this.mWonList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType LostList
    {
      get => this.mLostList;
      set => this.mLostList = value;
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
    [XmlElement("SecondChanceOffer")]
    public ItemTypeCollection SecondChanceOffer
    {
      get => this.mSecondChanceOffer;
      set => this.mSecondChanceOffer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("BidGroup", IsNullable = false)]
    public BidGroupTypeCollection BidAssistantList
    {
      get => this.mBidAssistantList;
      set => this.mBidAssistantList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedOrderTransactionArrayType DeletedFromWonList
    {
      get => this.mDeletedFromWonList;
      set => this.mDeletedFromWonList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType DeletedFromLostList
    {
      get => this.mDeletedFromLostList;
      set => this.mDeletedFromLostList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UserDefinedList")]
    public UserDefinedListTypeCollection UserDefinedList
    {
      get => this.mUserDefinedList;
      set => this.mUserDefinedList = value;
    }
  }
}
