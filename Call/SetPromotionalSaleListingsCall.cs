// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetPromotionalSaleListingsCall
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
  public class SetPromotionalSaleListingsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetPromotionalSaleListingsCall()
    {
      this.ApiRequest = new SetPromotionalSaleListingsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetPromotionalSaleListingsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetPromotionalSaleListingsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables the seller to change the item listings that are affected by a promotional sale. To use this call, the seller must be a registered eBay Store owner.
    /// </summary>
    /// <param name="PromotionalSaleID">
    /// The unique identifier of the seller's promotional sale. Based on the <b>Action</b>
    /// value, listings will either be added to or removed from the promotional sale.
    /// </param>
    /// <param name="Action">
    /// This required field determines whether you are adding (specify 'Add') or
    /// removing (specify 'Delete) one or more listings from the promotional sale
    /// identified by the <b>PromotionalSaleID</b> value in the request.
    /// 
    /// If you specify 'Delete', you must include one or more <b>ItemID</b> values under the <b>PromotionalSaleItemIDArray</b> container, and you cannot use the other filter options in the request. If you specify 'Add', you can add one or more listings using any of the filtering options in the request. Active auction listings that have one or more bids cannot be added to or removed from a promotional sale.
    /// </param>
    /// <param name="PromotionalSaleItemIDArrayList">
    /// Container consisting of one or more <b>ItemID</b> values. Based on the <b>Action</b> value, the listings identified by these <b>ItemID</b> values are either added to or removed from the promotional sale.  This container is required if listings are being removed (<b>Action</b>='Delete') from the promotional sale.
    /// </param>
    /// <param name="StoreCategoryID">
    /// If a <b>StoreCategoryID</b> value is included in the call request, all active items in this eBay Store category are added to the promotional sale. This field cannot be used if the <b>Action</b> field is set to 'Delete'.
    /// </param>
    /// <param name="CategoryID">
    /// If a <b>CategoryID</b> value is included in the call request, all active items in this eBay category are added to the promotional sale. This field cannot be used if the <b>Action</b> field is set to 'Delete'.
    /// </param>
    /// <param name="AllFixedPriceItems">
    /// If this field is included and set to 'true' in the call request, all fixed-price listings are added to the promotional sale. This field cannot be used if the <b>Action</b> field is set to 'Delete'.
    /// </param>
    /// <param name="AllStoreInventoryItems">
    /// This field is deprecated and should no longer be used because Store Inventory is no longer a supported listing format.
    /// </param>
    /// <param name="AllAuctionItems">
    /// If this field is included and set to 'true' in the call request, all auction listings are added to the promotional sale. This field cannot be used if the <b>Action</b> field is set to 'Delete'.
    /// </param>
    public PromotionalSaleStatusCodeType SetPromotionalSaleListings(
      long PromotionalSaleID,
      ModifyActionCodeType Action,
      ItemIDArrayType PromotionalSaleItemIDArrayList,
      long StoreCategoryID,
      long CategoryID,
      bool AllFixedPriceItems,
      bool AllStoreInventoryItems,
      bool AllAuctionItems)
    {
      this.PromotionalSaleID = PromotionalSaleID;
      this.Action = Action;
      this.PromotionalSaleItemIDArrayList = PromotionalSaleItemIDArrayList;
      this.StoreCategoryID = StoreCategoryID;
      this.CategoryID = CategoryID;
      this.AllFixedPriceItems = AllFixedPriceItems;
      this.AllStoreInventoryItems = AllStoreInventoryItems;
      this.AllAuctionItems = AllAuctionItems;
      this.Execute();
      return this.ApiResponse.Status;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType" /> for this API call.
    /// </summary>
    public SetPromotionalSaleListingsRequestType ApiRequest
    {
      get => (SetPromotionalSaleListingsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetPromotionalSaleListingsResponseType" /> for this API call.
    /// </summary>
    public SetPromotionalSaleListingsResponseType ApiResponse
    {
      get => (SetPromotionalSaleListingsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.PromotionalSaleID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long PromotionalSaleID
    {
      get => this.ApiRequest.PromotionalSaleID;
      set => this.ApiRequest.PromotionalSaleID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.Action" /> of type <see cref="T:eBay.Service.Core.Soap.ModifyActionCodeType" />.
    /// </summary>
    public ModifyActionCodeType Action
    {
      get => this.ApiRequest.Action;
      set => this.ApiRequest.Action = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.PromotionalSaleItemIDArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemIDArrayType" />.
    /// </summary>
    public ItemIDArrayType PromotionalSaleItemIDArrayList
    {
      get => this.ApiRequest.PromotionalSaleItemIDArray;
      set => this.ApiRequest.PromotionalSaleItemIDArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.StoreCategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long StoreCategoryID
    {
      get => this.ApiRequest.StoreCategoryID;
      set => this.ApiRequest.StoreCategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.CategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long CategoryID
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.AllFixedPriceItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool AllFixedPriceItems
    {
      get => this.ApiRequest.AllFixedPriceItems;
      set => this.ApiRequest.AllFixedPriceItems = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.AllStoreInventoryItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool AllStoreInventoryItems
    {
      get => this.ApiRequest.AllStoreInventoryItems;
      set => this.ApiRequest.AllStoreInventoryItems = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType.AllAuctionItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool AllAuctionItems
    {
      get => this.ApiRequest.AllAuctionItems;
      set => this.ApiRequest.AllAuctionItems = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleListingsResponseType.Status" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalSaleStatusCodeType" />.
    /// </summary>
    public PromotionalSaleStatusCodeType Status => this.ApiResponse.Status;
  }
}
