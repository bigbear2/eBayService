// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMyeBaySellingCall
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
  public class GetMyeBaySellingCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMyeBaySellingCall() => this.ApiRequest = new GetMyeBaySellingRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMyeBaySellingCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMyeBaySellingRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves information regarding the user's selling activity, such as items that the user is currently selling (the Active list), auction listings that have bids, sold items, and unsold items.
    /// </summary>
    /// <param name="ScheduledList">
    /// Include this container and set the <b>ScheduledList.Include</b> field to <code>true</code> to return the list of items that are scheduled to become active listings on eBay.com at a future date/time.
    /// 
    /// The user also has the option of using pagination and sorting for the list of Scheduled listings that will be returned.
    /// </param>
    /// <param name="ActiveList">
    /// Include this container and set the <b>ActiveList.Include</b> field to <code>true</code> to return the list of active listings on eBay.com.
    /// 
    /// The user also has the option of using pagination and sorting for the list of active listings that will be returned.
    /// </param>
    /// <param name="SoldList">
    /// Include this container and set the <b>SoldList.Include</b> field to <code>true</code> to return the list of sold order line items.
    /// 
    /// The user also has the option of using pagination and sorting for the list of sold items that will be returned.
    /// </param>
    /// <param name="UnsoldList">
    /// Include this container and set the <b>UnsoldList.Include</b> field to <code>true</code> to return the listings that have ended without a purchase.
    /// 
    /// The user also has the option of using pagination and sorting for the list of unsold items that will be returned.
    /// </param>
    /// <param name="BidList">
    /// This container is deprecated as a Bid List is no longer returned in <b>GetMyeBaySelling</b>.
    /// </param>
    /// <param name="DeletedFromSoldList">
    /// Include this container and set the <b>DeletedFromSoldList.Include</b> field to <code>true</code> to return the list of sold order line items that have since been deleted from the seller's My eBay page.
    /// 
    /// The user also has the option of using pagination and sorting for the list of deleted, sold items that will be returned.
    /// </param>
    /// <param name="DeletedFromUnsoldList">
    /// Include this container and set the <b>DeletedFromUnsoldList.Include</b> field to <code>true</code> to return the list of unsold order line items that have since been deleted from the seller's My eBay page.
    /// 
    /// The user also has the option of using pagination and sorting for the list of deleted, unsold items that will be returned.
    /// </param>
    /// <param name="SellingSummary">
    /// Include this container and set the <b>SellingSummary.Include</b> field to <code>true</code> to return the <b>SellingSummary</b> container in the response. The <b>SellingSummary</b> container consists of selling activity counts and values.
    /// </param>
    /// <param name="HideVariations">
    /// If this field is included and set to <code>true</code>, the <b>Variations</b> node (and all variation data) is omitted for all multiple-variation listings in the response. If this field is omitted or set to <code>false</code>, the <b>Variations</b> node is returned for all multiple-variation listings in the response.
    /// 
    /// </param>
    public SellingSummaryType GetMyeBaySelling(
      ItemListCustomizationType ScheduledList,
      ItemListCustomizationType ActiveList,
      ItemListCustomizationType SoldList,
      ItemListCustomizationType UnsoldList,
      ItemListCustomizationType BidList,
      ItemListCustomizationType DeletedFromSoldList,
      ItemListCustomizationType DeletedFromUnsoldList,
      ItemListCustomizationType SellingSummary,
      bool HideVariations)
    {
      this.ScheduledList = ScheduledList;
      this.ActiveList = ActiveList;
      this.SoldList = SoldList;
      this.UnsoldList = UnsoldList;
      this.BidList = BidList;
      this.DeletedFromSoldList = DeletedFromSoldList;
      this.DeletedFromUnsoldList = DeletedFromUnsoldList;
      this.SellingSummary = SellingSummary;
      this.HideVariations = HideVariations;
      this.Execute();
      return this.ApiResponse.SellingSummary;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void GetMyeBaySelling() => this.Execute();

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMyeBaySellingRequestType" /> for this API call.
    /// </summary>
    public GetMyeBaySellingRequestType ApiRequest
    {
      get => (GetMyeBaySellingRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMyeBaySellingResponseType" /> for this API call.
    /// </summary>
    public GetMyeBaySellingResponseType ApiResponse
    {
      get => (GetMyeBaySellingResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.ScheduledList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType ScheduledList
    {
      get => this.ApiRequest.ScheduledList;
      set => this.ApiRequest.ScheduledList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.ActiveList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType ActiveList
    {
      get => this.ApiRequest.ActiveList;
      set => this.ApiRequest.ActiveList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.SoldList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType SoldList
    {
      get => this.ApiRequest.SoldList;
      set => this.ApiRequest.SoldList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.UnsoldList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType UnsoldList
    {
      get => this.ApiRequest.UnsoldList;
      set => this.ApiRequest.UnsoldList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.BidList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType BidList
    {
      get => this.ApiRequest.BidList;
      set => this.ApiRequest.BidList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.DeletedFromSoldList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType DeletedFromSoldList
    {
      get => this.ApiRequest.DeletedFromSoldList;
      set => this.ApiRequest.DeletedFromSoldList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.DeletedFromUnsoldList" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType DeletedFromUnsoldList
    {
      get => this.ApiRequest.DeletedFromUnsoldList;
      set => this.ApiRequest.DeletedFromUnsoldList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.SellingSummary" /> of type <see cref="T:eBay.Service.Core.Soap.ItemListCustomizationType" />.
    /// </summary>
    public ItemListCustomizationType SellingSummary
    {
      get => this.ApiRequest.SellingSummary;
      set => this.ApiRequest.SellingSummary = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingRequestType.HideVariations" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HideVariations
    {
      get => this.ApiRequest.HideVariations;
      set => this.ApiRequest.HideVariations = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.SellingSummary" /> of type <see cref="T:eBay.Service.Core.Soap.SellingSummaryType" />.
    /// </summary>
    public SellingSummaryType SellingSummaryReturn => this.ApiResponse.SellingSummary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.ScheduledList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType ScheduledListReturn => this.ApiResponse.ScheduledList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.ActiveList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType ActiveListReturn => this.ApiResponse.ActiveList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.SoldList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedOrderTransactionArrayType" />.
    /// </summary>
    public PaginatedOrderTransactionArrayType SoldListReturn => this.ApiResponse.SoldList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.UnsoldList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType UnsoldListReturn => this.ApiResponse.UnsoldList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.Summary" /> of type <see cref="T:eBay.Service.Core.Soap.MyeBaySellingSummaryType" />.
    /// </summary>
    public MyeBaySellingSummaryType Summary => this.ApiResponse.Summary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.BidList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType BidListReturn => this.ApiResponse.BidList;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.DeletedFromSoldList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedOrderTransactionArrayType" />.
    /// </summary>
    public PaginatedOrderTransactionArrayType DeletedFromSoldListReturn
    {
      get => this.ApiResponse.DeletedFromSoldList;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBaySellingResponseType.DeletedFromUnsoldList" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedItemArrayType" />.
    /// </summary>
    public PaginatedItemArrayType DeletedFromUnsoldListReturn
    {
      get => this.ApiResponse.DeletedFromUnsoldList;
    }
  }
}
