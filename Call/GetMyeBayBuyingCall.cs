// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMyeBayBuyingCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetMyeBayBuyingCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMyeBayBuyingCall() => this.ApiRequest = new GetMyeBayBuyingRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMyeBayBuyingCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMyeBayBuyingRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves information regarding a user's buying activity, such as items they are watching, bidding on, have won, did not win, and have made Best Offers on.
    /// </summary>
    /// <param name="WatchList">
    /// Include this container and set the <b>WatchList.Include</b> field to <code>true</code> to return the list of items on the eBay user's Watch List.
    /// 
    /// The user also has the option of using pagination and sorting for the list of watched items that will be returned.
    /// </param>
    /// <param name="BidList">
    /// Include this container and set the <b>BidList.Include</b> field to <code>true</code> to return the list of auction items on which the eBay user has bid.
    /// 
    /// The user also has the option of using pagination and sorting for the list of auction items that will be returned.
    /// </param>
    /// <param name="BestOfferList">
    /// Include this container and set the <b>BestOfferList.Include</b> field to <code>true</code> to return the list of items on which the eBay user has made a Best Offer.
    /// 
    /// The user also has the option of using pagination and sorting for the list of items that will be returned.
    /// </param>
    /// <param name="WonList">
    /// Include this container and set the <b>WonList.Include</b> field to <code>true</code> to return the list of auction items on which the eBay user has bid on and won.
    /// 
    /// The user also has the option of using pagination and sorting for the list of auction items that will be returned.
    /// </param>
    /// <param name="LostList">
    /// Include this container and set the <b>LostList.Include</b> field to <code>true</code> to return the list of auction items on which the eBay user has bid on and lost.
    /// 
    /// The user also has the option of using pagination and sorting for the list of auction items that will be returned.
    /// </param>
    /// <param name="FavoriteSearches">
    /// Include this container and set the <b>FavoriteSearches.Include</b> field to <code>true</code> to return the list of the eBay user's saved searches.
    /// </param>
    /// <param name="FavoriteSellers">
    /// Include this container and set the <b>FavoriteSellers.Include</b> field to <code>true</code> to return the list of the eBay user's saved sellers.
    /// </param>
    /// <param name="SecondChanceOffer">
    /// Include this container and set the <b>SecondChanceOffer.Include</b> field to <code>true</code> to return any Second Chance Offers that the eBay user has received.
    /// </param>
    /// <param name="BidAssistantList">This field is deprecated.</param>
    /// <param name="DeletedFromWonList">
    /// Include this container and set the <b>DeletedFromWonList.Include</b> field to <code>true</code> to return the list of auction items on which the eBay user has bid on and won, but has deleted from their My eBay page.
    /// 
    /// The user also has the option of using pagination and sorting for the list of auction items that will be returned.
    /// </param>
    /// <param name="DeletedFromLostList">
    /// Include this container and set the <b>DeletedFromLostList.Include</b> field to <code>true</code> to return the list of auction items on which the eBay user has bid on and lost, and has deleted from their My eBay page.
    /// 
    /// The user also has the option of using pagination and sorting for the list of auction items that will be returned.
    /// </param>
    /// <param name="BuyingSummary">
    /// Include this container and set the <b>BuyingSummary.Include</b> field to <code>true</code> to return the <b>BuyingSummary</b> container in the response. The <b>BuyingSummary</b> container consists of buying/bidding activity counts and values.
    /// </param>
    /// <param name="UserDefinedLists">
    /// Include this container and set the <b>UserDefinedLists.Include</b> field to <code>true</code> to return one or more user-defined lists. User-defined lists are lists created by the user in My eBay and consists of a combination of items, saved sellers, and/or saved searches.
    /// </param>
    /// <param name="HideVariations">
    /// If this field is included and set to <code>true</code>, the <b>Variations</b> node (and all variation data) is omitted for all multiple-variation listings in the response. If this field is omitted or set to <code>false</code>, the <b>Variations</b> node is returned for all multiple-variation listings in the response.
    /// 
    /// </param>
    public BuyingSummaryType GetMyeBayBuying(
      ItemListCustomizationType WatchList,
      ItemListCustomizationType BidList,
      ItemListCustomizationType BestOfferList,
      ItemListCustomizationType WonList,
      ItemListCustomizationType LostList,
      MyeBaySelectionType FavoriteSearches,
      MyeBaySelectionType FavoriteSellers,
      MyeBaySelectionType SecondChanceOffer,
      BidAssistantListType BidAssistantList,
      ItemListCustomizationType DeletedFromWonList,
      ItemListCustomizationType DeletedFromLostList,
      ItemListCustomizationType BuyingSummary,
      MyeBaySelectionType UserDefinedLists,
      bool HideVariations)
    {
      this.WatchList = WatchList;
      this.BidList = BidList;
      this.BestOfferList = BestOfferList;
      this.WonList = WonList;
      this.LostList = LostList;
      this.FavoriteSearches = FavoriteSearches;
      this.FavoriteSellers = FavoriteSellers;
      this.SecondChanceOffer = SecondChanceOffer;
      this.BidAssistantList = BidAssistantList;
      this.DeletedFromWonList = DeletedFromWonList;
      this.DeletedFromLostList = DeletedFromLostList;
      this.BuyingSummary = BuyingSummary;
      this.UserDefinedLists = UserDefinedLists;
      this.HideVariations = HideVariations;
      this.Execute();
      return this.ApiResponse.BuyingSummary;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public BuyingSummaryType GetMyeBayBuying(
      ItemListCustomizationType WatchList,
      ItemListCustomizationType BidList,
      ItemListCustomizationType BestOfferList,
      ItemListCustomizationType WonList,
      ItemListCustomizationType LostList,
      MyeBaySelectionType FavoriteSearches,
      MyeBaySelectionType FavoriteSellers,
      MyeBaySelectionType SecondChanceOffer)
    {
      this.WatchList = WatchList;
      this.BidList = BidList;
      this.BestOfferList = BestOfferList;
      this.WonList = WonList;
      this.LostList = LostList;
      this.FavoriteSearches = FavoriteSearches;
      this.FavoriteSellers = FavoriteSellers;
      this.SecondChanceOffer = SecondChanceOffer;
      this.Execute();
      return this.ApiResponse.BuyingSummary;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void GetMyeBayBuying() => this.Execute();

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType" /> for this API call.
    /// </summary>
    public GetMyeBayBuyingRequestType ApiRequest
    {
      get => (GetMyeBayBuyingRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType" /> for this API call.
    /// </summary>
    public GetMyeBayBuyingResponseType ApiResponse
    {
      get => (GetMyeBayBuyingResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.WatchList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType WatchList
    {
      get => this.ApiRequest.WatchList;
      set => this.ApiRequest.WatchList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.BidList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType BidList
    {
      get => this.ApiRequest.BidList;
      set => this.ApiRequest.BidList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.BestOfferList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType BestOfferList
    {
      get => this.ApiRequest.BestOfferList;
      set => this.ApiRequest.BestOfferList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.WonList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType WonList
    {
      get => this.ApiRequest.WonList;
      set => this.ApiRequest.WonList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.LostList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType LostList
    {
      get => this.ApiRequest.LostList;
      set => this.ApiRequest.LostList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.FavoriteSearches" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBaySelectionType" />.
    /// </summary>
    public MyeBaySelectionType FavoriteSearches
    {
      get => this.ApiRequest.FavoriteSearches;
      set => this.ApiRequest.FavoriteSearches = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.FavoriteSellers" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBaySelectionType" />.
    /// </summary>
    public MyeBaySelectionType FavoriteSellers
    {
      get => this.ApiRequest.FavoriteSellers;
      set => this.ApiRequest.FavoriteSellers = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.SecondChanceOffer" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBaySelectionType" />.
    /// </summary>
    public MyeBaySelectionType SecondChanceOffer
    {
      get => this.ApiRequest.SecondChanceOffer;
      set => this.ApiRequest.SecondChanceOffer = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.BidAssistantList" /> of type <see cref="T:eBay.Service.Core.Soap.BidAssistantListType" />.
    /// </summary>
    public BidAssistantListType BidAssistantList
    {
      get => this.ApiRequest.BidAssistantList;
      set => this.ApiRequest.BidAssistantList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.DeletedFromWonList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType DeletedFromWonList
    {
      get => this.ApiRequest.DeletedFromWonList;
      set => this.ApiRequest.DeletedFromWonList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.DeletedFromLostList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType DeletedFromLostList
    {
      get => this.ApiRequest.DeletedFromLostList;
      set => this.ApiRequest.DeletedFromLostList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.BuyingSummary" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType BuyingSummary
    {
      get => this.ApiRequest.BuyingSummary;
      set => this.ApiRequest.BuyingSummary = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.UserDefinedLists" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBaySelectionType" />.
    /// </summary>
    public MyeBaySelectionType UserDefinedLists
    {
      get => this.ApiRequest.UserDefinedLists;
      set => this.ApiRequest.UserDefinedLists = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingRequestType.HideVariations" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HideVariations
    {
      get => this.ApiRequest.HideVariations;
      set => this.ApiRequest.HideVariations = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.BuyingSummary" /> of type <see cref="T:eBay.Service.Core.Soap.BuyingSummaryType" />.
    /// </summary>
    public BuyingSummaryType BuyingSummaryReturn => this.ApiResponse.BuyingSummary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.WatchList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType WatchListReturn => this.ApiResponse.WatchList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.BidList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType BidListReturn => this.ApiResponse.BidList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.BestOfferList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType BestOfferListReturn => this.ApiResponse.BestOfferList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.WonList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedOrderTransactionArrayType" />.
    /// </summary>
    public PaginatedOrderTransactionArrayType WonListReturn => this.ApiResponse.WonList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.LostList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType LostListReturn => this.ApiResponse.LostList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.FavoriteSearches" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBayFavoriteSearchListType" />.
    /// </summary>
    public MyeBayFavoriteSearchListType FavoriteSearchesReturn => this.ApiResponse.FavoriteSearches;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.FavoriteSellers" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBayFavoriteSellerListType" />.
    /// </summary>
    public MyeBayFavoriteSellerListType FavoriteSellersReturn => this.ApiResponse.FavoriteSellers;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.SecondChanceOffer" /> of type <see cref="T:eBay.Service.Core.Soap.ItemTypeCollection" />.
    /// </summary>
    public ItemTypeCollection SecondChanceOfferReturn => this.ApiResponse.SecondChanceOffer;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.BidAssistantList" /> of type <see cref="T:eBay.Service.Core.Soap.BidGroupTypeCollection" />.
    /// </summary>
    public BidGroupTypeCollection BidAssistantListList => this.ApiResponse.BidAssistantList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.DeletedFromWonList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedOrderTransactionArrayType" />.
    /// </summary>
    public PaginatedOrderTransactionArrayType DeletedFromWonListReturn
    {
      get => this.ApiResponse.DeletedFromWonList;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.DeletedFromLostList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType DeletedFromLostListReturn => this.ApiResponse.DeletedFromLostList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayBuyingResponseType.UserDefinedList" /> of type <see cref="T:eBay.Service.Core.Soap.UserDefinedListTypeCollection" />.
    /// </summary>
    public UserDefinedListTypeCollection UserDefinedListList => this.ApiResponse.UserDefinedList;
  }
}
