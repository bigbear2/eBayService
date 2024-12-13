// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetBestOffersCall
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
  public class GetBestOffersCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetBestOffersCall() => this.ApiRequest = new GetBestOffersRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetBestOffersCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetBestOffersRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type of the <b>GetBestOffers</b> call. Depending on the input parameters that are used, this call can be used by a seller to retrieve all active Best Offers, all Best Offers on a specific listing, a specific Best Offer for a specific listing, or Best Offers in a specific state.
    /// <br /><br />
    /// <span class="tablenote"><b>Note: </b>
    /// The Best Offer feature is now available for auction listings on the following sites: US, Canada, UK, Germany, Australia, France, Italy, and Spain. However, sellers must choose between offering Best Offer or Buy It Now on an auction listing, as both features cannot be enabled on the same auction listing.
    /// </span>
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of an eBay listing. If an <b>ItemID</b> is used by itself in the call request, all Best Offers in all states are retrieved for this listing. However, the seller can also combine <b>ItemID</b> and a <b>BestOfferStatus</b> value if that seller only wants to see Best Offers in a specific state. If a <b>BestOfferID</b> field is included in the call request, any <b>ItemID</b> value will be ignored since eBay will only search for and return the Best Offer identified in the <b>BestOfferID</b> field.
    /// </param>
    /// <param name="BestOfferID">
    /// The unique identifier of a Best Offer. An identifier for a Best Offer is automatically created by eBay once a prospective buyer makes a Best Offer on a Best Offer-enabled listing. If a <b>BestOfferID</b> value is supplied in the call request, any <b>ItemID</b> or <b>BestOfferStatus</b> values will be ignored. Only the Best Offer identified by the <b>BestOfferID</b> value will be returned.
    /// </param>
    /// <param name="BestOfferStatus">
    /// This field can be used if the seller wants to retrieve Best Offers in a specific state. The typical use case for this field is when the seller wants to retrieve Best Offers in all states for a specific listing. In fact, the <b>All</b> value can only be used if an <b>ItemID</b> value is also supplied in the call request. If a <b>BestOfferID</b> field is included in the call request, any <b>BestOfferStatus</b> value will be ignored since eBay will only search for and return the Best Offer identified in the <b>BestOfferID</b> field.
    /// <br />
    /// </param>
    /// <param name="Pagination">
    /// This container can be used if the seller is expecting that the <b>GetBestOffers</b> call will retrieve a large number of results, so that seller wishes to view just a subset (one page of multiple pages) of those results at a time. See this container's child fields for more information on how pagination is used.
    /// </param>
    public BestOfferTypeCollection GetBestOffers(
      string ItemID,
      string BestOfferID,
      BestOfferStatusCodeType BestOfferStatus,
      PaginationType Pagination)
    {
      this.ItemID = ItemID;
      this.BestOfferID = BestOfferID;
      this.BestOfferStatus = BestOfferStatus;
      this.Pagination = Pagination;
      this.Execute();
      return this.ApiResponse.BestOfferArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public BestOfferTypeCollection GetBestOffers(string ItemID)
    {
      this.ItemID = ItemID;
      this.Execute();
      return this.BestOfferList;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.ItemBestOffersArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemBestOffersTypeCollection" />.
    /// </summary>
    public ItemBestOffersTypeCollection ItemBestOffersList
    {
      get
      {
        return this.ApiResponse.ItemBestOffersArray == null ? (ItemBestOffersTypeCollection) null : this.ApiResponse.ItemBestOffersArray.ItemBestOffers;
      }
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetBestOffersRequestType" /> for this API call.
    /// </summary>
    public GetBestOffersRequestType ApiRequest
    {
      get => (GetBestOffersRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetBestOffersResponseType" /> for this API call.
    /// </summary>
    public GetBestOffersResponseType ApiResponse
    {
      get => (GetBestOffersResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetBestOffersRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetBestOffersRequestType.BestOfferID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string BestOfferID
    {
      get => this.ApiRequest.BestOfferID;
      set => this.ApiRequest.BestOfferID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetBestOffersRequestType.BestOfferStatus" /> of type <see cref="T:eBay.Service.Core.Soap.BestOfferStatusCodeType" />.
    /// </summary>
    public BestOfferStatusCodeType BestOfferStatus
    {
      get => this.ApiRequest.BestOfferStatus;
      set => this.ApiRequest.BestOfferStatus = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetBestOffersRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.BestOfferArray" /> of type <see cref="T:eBay.Service.Core.Soap.BestOfferTypeCollection" />.
    /// </summary>
    public BestOfferTypeCollection BestOfferList => this.ApiResponse.BestOfferArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item => this.ApiResponse.Item;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.ItemBestOffersArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemBestOffersArrayType" />.
    /// </summary>
    public ItemBestOffersArrayType ItemBestOffersArray => this.ApiResponse.ItemBestOffersArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetBestOffersResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;
  }
}
