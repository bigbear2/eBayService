// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddToWatchListCall
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
  public class AddToWatchListCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddToWatchListCall() => this.ApiRequest = new AddToWatchListRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddToWatchListCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddToWatchListRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Adds one or more order line items to the eBay user's Watch List. An auction item or a single-variation, fixed-price listing is identified with an <b>ItemID</b> value. To add a specific item variation to the Watch List from within a multi-variation, fixed-price listing, the user will use the  <b>VariationKey</b> container instead.
    /// </summary>
    /// <param name="ItemIDList">
    /// The unique identifier of the single-variation listing that is to be added to the eBay user's Watch List. The item must be a currently active item, and the total number of items in the user's Watch List (after the items in the request have been added) cannot exceed the maximum allowed number of Watch List items. One or more <b>ItemID</b> fields can be specified. A separate error node will be returned for each item that was not successfully added to the Watch List.  The user must use either one or more <b>ItemID</b> values or one or more <b>VariationKey</b> containers, but the user may not use both of these entities in the same call.
    /// </param>
    /// <param name="VariationKeyList">
    /// This container is used to specify one or more item variations in a multi-variation, fixed-price listing that you want to add to the Watch List.
    /// The listing is identified through the <b>ItemID</b> value and each item variation existing within that listing is identified through a <b>VariationSpecifics.NameValueList</b> container.
    /// 
    /// 
    /// The user must use either one or more <b>ItemID</b> values or one or more <b>VariationKey</b> containers, but the user may not use both of these entities in the same call.
    /// </param>
    public int AddToWatchList(
      StringCollection ItemIDList,
      VariationKeyTypeCollection VariationKeyList)
    {
      this.ItemIDList = ItemIDList;
      this.VariationKeyList = VariationKeyList;
      this.Execute();
      return this.ApiResponse.WatchListCount;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddToWatchListRequestType" /> for this API call.
    /// </summary>
    public AddToWatchListRequestType ApiRequest
    {
      get => (AddToWatchListRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddToWatchListResponseType" /> for this API call.
    /// </summary>
    public AddToWatchListResponseType ApiResponse
    {
      get => (AddToWatchListResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddToWatchListRequestType.ItemID" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection ItemIDList
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddToWatchListRequestType.VariationKey" /> of type <see cref="T:eBay.Service.Core.Soap.VariationKeyTypeCollection" />.
    /// </summary>
    public VariationKeyTypeCollection VariationKeyList
    {
      get => this.ApiRequest.VariationKey;
      set => this.ApiRequest.VariationKey = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddToWatchListResponseType.WatchListCount" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int WatchListCount => this.ApiResponse.WatchListCount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddToWatchListResponseType.WatchListMaximum" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int WatchListMaximum => this.ApiResponse.WatchListMaximum;
  }
}
