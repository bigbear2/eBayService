// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetUserNotesCall
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
  public class SetUserNotesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetUserNotesCall() => this.ApiRequest = new SetUserNotesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetUserNotesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetUserNotesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables users to add, modify, or delete a pinned note for any item that is being tracked in the My eBay All Selling and All Buying areas.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier of the listing to which the My eBay note will be
    /// attached. Notes can only be added to items that are
    /// currently being tracked in My eBay.
    /// </param>
    /// <param name="Action">
    /// The seller must include this field and set it to 'AddOrUpdate' to add a new user note or update an existing user note, or set it to 'Delete' to delete an existing user note.
    /// </param>
    /// <param name="NoteText">
    /// This field is needed if the <b>Action</b> is <code>AddOrUpdate</code>. The text supplied in this field will
    /// completely replace any existing My eBay note for the
    /// specified item.
    /// </param>
    /// <param name="TransactionID">
    /// Unique identifier for the order line item to which the My
    /// eBay note will be attached. Notes can only be added to order line items
    /// that are currently being tracked in My eBay. Buyers can
    /// view user notes made on order line items in the
    /// <b>PrivateNotes</b> field of the <b>WonList</b> container in <b>GetMyeBayBuying</b>, and
    /// sellers can view user notes made on order line items in
    /// the <b>PrivateNotes</b> field of the <b>SoldList</b> and <b>DeletedFromSoldList</b>
    /// containers in <b>GetMyeBaySellinging</b>.
    /// </param>
    /// <param name="VariationSpecificList">
    /// Container consisting of name-value pairs that identify (match) one
    /// variation within a fixed-price, multiple-variation listing. The specified
    /// name-value pair(s) must exist in the listing specified by either the
    /// <b>ItemID</b> or <b>SKU</b> values specified in the request. If a specific order line
    /// item is targeted in the request with an
    /// <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> value, any specified
    /// <b>VariationSpecifics</b> container is ignored by the call.
    /// </param>
    /// <param name="SKU">
    /// SKU value of the item variation to which the My eBay note will be
    /// attached. Notes can only be added to items that are currently being
    /// tracked in My eBay. A SKU (stock keeping unit) value is defined by and
    /// used by the seller to identify a variation within a fixed-price, multiple-
    /// variation listing. The SKU value is assigned to a variation of an item
    /// through the <b>Variations.Variation.SKU</b> element.
    /// 
    /// 
    /// This field can only be used if the <b>Item.InventoryTrackingMethod</b> field
    /// (set with the <b>AddFixedPriceItem</b> or <b>RelistFixedPriceItem</b> calls) is set to
    /// SKU.
    /// 
    /// 
    /// If a specific order line item is targeted in the request
    /// with an <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> value, any
    /// specified <b>SKU</b> is ignored by the call.
    /// </param>
    /// <param name="OrderLineItemID">
    /// A unique identifier for an eBay order line item. This field is created as
    /// soon as there is a commitment to buy from the seller. <b>OrderLineItemID</b> can be used in the input instead of
    /// an <b>ItemID</b>/<b>TransactionID</b> pair to identify an order line item.
    /// 
    /// 
    /// Notes can only be added to order line items that are currently being
    /// tracked in My eBay. Buyers can view user notes made on order line items in
    /// the <b>PrivateNotes</b> field of the <b>WonList</b> container in <b>GetMyeBayBuying</b>, and
    /// sellers can view user notes made on order line items in the <b>PrivateNotes</b>
    /// field of the <b>SoldList</b> and <b>DeletedFromSoldList</b> containers in
    /// <b>GetMyeBaySellinging</b>.
    /// </param>
    public void SetUserNotes(
      string ItemID,
      SetUserNotesActionCodeType Action,
      string NoteText,
      string TransactionID,
      NameValueListTypeCollection VariationSpecificList,
      string SKU,
      string OrderLineItemID)
    {
      this.ItemID = ItemID;
      this.Action = Action;
      this.NoteText = NoteText;
      this.TransactionID = TransactionID;
      this.VariationSpecificList = VariationSpecificList;
      this.SKU = SKU;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetUserNotesRequestType" /> for this API call.
    /// </summary>
    public SetUserNotesRequestType ApiRequest
    {
      get => (SetUserNotesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetUserNotesResponseType" /> for this API call.
    /// </summary>
    public SetUserNotesResponseType ApiResponse => (SetUserNotesResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.Action" /> of type <see cref="T:eBay.Service.Core.Soap.SetUserNotesActionCodeType" />.
    /// </summary>
    public SetUserNotesActionCodeType Action
    {
      get => this.ApiRequest.Action;
      set => this.ApiRequest.Action = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.NoteText" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string NoteText
    {
      get => this.ApiRequest.NoteText;
      set => this.ApiRequest.NoteText = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.VariationSpecifics" /> of type <see cref="T:eBay.Service.Core.Soap.NameValueListTypeCollection" />.
    /// </summary>
    public NameValueListTypeCollection VariationSpecificList
    {
      get => this.ApiRequest.VariationSpecifics;
      set => this.ApiRequest.VariationSpecifics = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKU
    {
      get => this.ApiRequest.SKU;
      set => this.ApiRequest.SKU = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserNotesRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }
  }
}
