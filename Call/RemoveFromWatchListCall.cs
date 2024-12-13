// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.RemoveFromWatchListCall
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
  public class RemoveFromWatchListCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public RemoveFromWatchListCall() => this.ApiRequest = new RemoveFromWatchListRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public RemoveFromWatchListCall(ApiContext ApiContext)
    {
      this.ApiRequest = new RemoveFromWatchListRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The call enables a user to remove one or more items from their Watch List. A user can view the items that they are currently watching by calling <b>GetMyeBayBuying</b>.
    /// <br /><br />
    /// The user has the option of removing one or more single-variation listings, one or more product variations within a multiple-variation listing, or removing all items from the Watch List.
    /// </summary>
    /// <param name="ItemIDList">
    /// The unique identifier of the item to be removed from the
    /// user's Watch List. Multiple <b>ItemID</b> fields can be specified in the same request, but note that the <b>RemoveAllItems</b> field or <b>VariationKey</b> container cannot be specified if one or more <b>ItemID</b> fields are used.
    /// <br /><br />
    /// </param>
    /// <param name="RemoveAllItems">
    /// If this field is included and set to <code>true</code>, then all the items in the user's
    /// Watch List are removed. Note that if the <b>RemoveAllItems</b> field is specified, one or more <b>ItemID</b> fields or the <b>VariationKey</b> cannot be used.
    /// </param>
    /// <param name="VariationKeyList">
    /// This container is used if the user want to remove one or more product variations (within a multiple-variation listing) from the Watch List. Note that if the <b>VariationKey</b> container is used, one or more <b>ItemID</b> fields or the <b>RemoveAllItems</b> field cannot be used.
    /// </param>
    public int RemoveFromWatchList(
      StringCollection ItemIDList,
      bool RemoveAllItems,
      VariationKeyTypeCollection VariationKeyList)
    {
      this.ItemIDList = ItemIDList;
      this.RemoveAllItems = RemoveAllItems;
      this.VariationKeyList = VariationKeyList;
      this.Execute();
      return this.ApiResponse.WatchListCount;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public int RemoveFromWatchList(StringCollection ItemIDList)
    {
      this.ItemIDList = ItemIDList;
      this.Execute();
      return this.WatchListCount;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.RemoveFromWatchListRequestType" /> for this API call.
    /// </summary>
    public RemoveFromWatchListRequestType ApiRequest
    {
      get => (RemoveFromWatchListRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.RemoveFromWatchListResponseType" /> for this API call.
    /// </summary>
    public RemoveFromWatchListResponseType ApiResponse
    {
      get => (RemoveFromWatchListResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RemoveFromWatchListRequestType.ItemID" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection ItemIDList
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RemoveFromWatchListRequestType.RemoveAllItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool RemoveAllItems
    {
      get => this.ApiRequest.RemoveAllItems;
      set => this.ApiRequest.RemoveAllItems = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RemoveFromWatchListRequestType.VariationKey" /> of type <see cref="T:eBay.Service.Core.Soap.VariationKeyTypeCollection" />.
    /// </summary>
    public VariationKeyTypeCollection VariationKeyList
    {
      get => this.ApiRequest.VariationKey;
      set => this.ApiRequest.VariationKey = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RemoveFromWatchListResponseType.WatchListCount" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int WatchListCount => this.ApiResponse.WatchListCount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RemoveFromWatchListResponseType.WatchListMaximum" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int WatchListMaximum => this.ApiResponse.WatchListMaximum;
  }
}
