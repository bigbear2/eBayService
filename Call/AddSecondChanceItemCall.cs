// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddSecondChanceItemCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class AddSecondChanceItemCall : ApiCall
  {
    private ItemType mItem;

    /// <summary>
    /// 
    /// </summary>
    public AddSecondChanceItemCall() => this.ApiRequest = new AddSecondChanceItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddSecondChanceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddSecondChanceItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Used by the seller of an auction listing to provide a Second Chance Offer to one of that auction item's non-winning bidders. A Second Chance Offer is used by sellers whenever the seller was unable to complete the sale with the winning bidder because the bidder didn't pay, or if the auction listing ended without the Reserve Price being met, or if that seller has multiple identical items for sale and wants to give other bidders a chance to purchase the item.
    /// 
    /// 
    /// To get information on the bidders for a recently-ended auction listing, the seller can use the <b>GetAllBidders</b> call and pass the corresponding <b>ItemID</b> value into the call request.
    /// 
    /// 
    /// For more information on the specifics of Second Chance Offers, see the <a href="https://pages.ebay.com/help/sell/second_chance_offer.html" target="_blank">Making a Second Chance Offer</a> help page.
    /// </summary>
    /// <param name="RecipientBidderUserID">
    /// This field is used to specify the bidder that is being offered the Second Chance Offer. The eBay User ID of the bidder is used in this field. Specify only one <b>RecipientBidderUserID</b> per call. If multiple users are specified, only the last one specified receives the offer. User ID values will be returned in the <b>Offer.User.UserID</b> field of the <b>GetAllBidders</b> call response.
    /// </param>
    /// <param name="BuyItNowPrice">
    /// The amount the offer recipient must pay to purchase the item as a Second Chance Offer. This field should only be used when the original item was listed in an eBay Motors vehicle category (or in some categories on U.S. and international sites for high-priced items, such as items in many U.S. and Canada Business and Industrial categories) and it ended unsold because the reserve price was not met. Otherwise, eBay establishes the price and no price should be submitted. The price offered to the Second Chance Offer recipient is generally the highest bid that the user made on the original listing.
    /// </param>
    /// <param name="Duration">
    /// This enumeration value indicates the length of time (in days) that the Second Chance Offer will be available to the recipient. Upon receiving the Second Chance Offer, the recipient bidder will have this many days to accept the offer before the offer expires. One of the values in <b>SecondChanceOfferDurationCodeType</b> must be used.
    /// </param>
    /// <param name="ItemID">
    /// This field is used to identify the original auction listing through its unique identifier (Item ID). Upon a successful call, the Second Chance Offer will be identified by a new <b>ItemID</b> in the response.
    /// </param>
    /// <param name="SellerMessage">
    /// This optional field is used to provide a message to the recipient of the Second Chance Offer. This message cannot contain HTML, asterisks, or quotes. The content in this field will be included in the Second Chance Offer email that is sent to the recipient.
    /// </param>
    public string AddSecondChanceItem(
      string RecipientBidderUserID,
      AmountType BuyItNowPrice,
      SecondChanceOfferDurationCodeType Duration,
      string ItemID,
      string SellerMessage)
    {
      this.RecipientBidderUserID = RecipientBidderUserID;
      this.BuyItNowPrice = BuyItNowPrice;
      this.Duration = Duration;
      this.ItemID = ItemID;
      this.SellerMessage = SellerMessage;
      this.Execute();
      return this.ApiResponse.ItemID;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Execute()
    {
      base.Execute();
      if (this.Item == null)
        return;
      this.Item.ItemID = this.ApiResponse.ItemID;
      if (this.Item.ListingDetails == null)
        this.Item.ListingDetails = new ListingDetailsType();
      this.Item.ListingDetails.StartTime = this.ApiResponse.StartTime;
      this.Item.ListingDetails.EndTime = this.ApiResponse.EndTime;
      this.Item.ListingDetails.SecondChanceOriginalItemID = this.ApiRequest.ItemID;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void AddSecondChanceItem(
      string ItemID,
      string ListingDuration,
      string RecipientBidderUserID)
    {
      this.AddSecondChanceItem(new ItemType()
      {
        ItemID = ItemID,
        ListingDuration = ListingDuration
      }, RecipientBidderUserID);
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void AddSecondChanceItem(ItemType Item, string RecipientBidderUserID)
    {
      this.Item = Item;
      this.RecipientBidderUserID = RecipientBidderUserID;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void AddSecondChanceItem(
      string RecipientBidderUserID,
      AmountType BuyItNowPrice,
      bool CopyEmailToSeller,
      SecondChanceOfferDurationCodeType Duration,
      string ItemID)
    {
      this.RecipientBidderUserID = RecipientBidderUserID;
      this.BuyItNowPrice = BuyItNowPrice;
      this.Duration = Duration;
      this.ItemID = ItemID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddSecondChanceItemRequestType" /> for this API call.
    /// </summary>
    public AddSecondChanceItemRequestType ApiRequest
    {
      get => (AddSecondChanceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddSecondChanceItemResponseType" /> for this API call.
    /// </summary>
    public AddSecondChanceItemResponseType ApiResponse
    {
      get => (AddSecondChanceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemRequestType.RecipientBidderUserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RecipientBidderUserID
    {
      get => this.ApiRequest.RecipientBidderUserID;
      set => this.ApiRequest.RecipientBidderUserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemRequestType.BuyItNowPrice" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType BuyItNowPrice
    {
      get => this.ApiRequest.BuyItNowPrice;
      set => this.ApiRequest.BuyItNowPrice = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemRequestType.Duration" /> of type <see cref="T:eBay.Service.Core.Soap.SecondChanceOfferDurationCodeType" />.
    /// </summary>
    public SecondChanceOfferDurationCodeType Duration
    {
      get => this.ApiRequest.Duration;
      set => this.ApiRequest.Duration = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemRequestType.SellerMessage" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SellerMessage
    {
      get => this.ApiRequest.SellerMessage;
      set => this.ApiRequest.SellerMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemType Item
    {
      get => this.mItem;
      set
      {
        this.ApiRequest.ItemID = value.ItemID;
        this.ApiRequest.Duration = (SecondChanceOfferDurationCodeType) Enum.Parse(typeof (SecondChanceOfferDurationCodeType), value.ListingDuration, true);
        if (value.BuyItNowPrice != null)
          this.ApiRequest.BuyItNowPrice = value.BuyItNowPrice;
        this.mItem = value;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemIDResult => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSecondChanceItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;
  }
}
