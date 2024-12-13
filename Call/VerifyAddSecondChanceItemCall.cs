// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.VerifyAddSecondChanceItemCall
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
  public class VerifyAddSecondChanceItemCall : ApiCall
  {
    private ItemType mItem;

    /// <summary>
    /// 
    /// </summary>
    public VerifyAddSecondChanceItemCall()
    {
      this.ApiRequest = new VerifyAddSecondChanceItemRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public VerifyAddSecondChanceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new VerifyAddSecondChanceItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Simulates the creation of a new Second Chance Offer
    /// listing of an item without actually creating a listing.
    /// </summary>
    /// <param name="RecipientBidderUserID">
    /// Specifies the bidder from the original, ended listing to whom the seller
    /// is extending the second chance offer. Specify only one
    /// <b>RecipientBidderUserID</b> per call. If multiple users are specified (each in a
    /// <b>RecipientBidderUserID</b> node), only the last one specified receives the
    /// offer.
    /// </param>
    /// <param name="BuyItNowPrice">
    /// Specifies the amount the offer recipient must pay to purchase the item
    /// from the Second Chance Offer listing. Use only when the original item was
    /// an eBay Motors (or in some categories on U.S. and international sites for
    /// high-priced items, such as items in many U.S. and Canada Business and
    /// Industrial categories) and it ended unsold because the reserve price was
    /// not met. Call fails with an error for any other item conditions.
    /// </param>
    /// <param name="Duration">
    /// Specifies the length of time the Second Chance Offer listing will be
    /// active. The recipient bidder has that much time to purchase the item or
    /// the listing expires.
    /// </param>
    /// <param name="ItemID">
    /// This field is used to identify the recently-ended auction listing for which a Second Chance Offer will be made to one of the non-winning bidders on the recently-ended auction listing.
    /// </param>
    /// <param name="SellerMessage">
    /// Message content. Cannot contain HTML, asterisks, or quotes. This content
    /// is included in the Second Chance Offer email sent to the recipient, which
    /// can be retrieved with <b>GetMyMessages</b>.
    /// </param>
    public DateTime VerifyAddSecondChanceItem(
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
      return this.ApiResponse.StartTime;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void VerifyAddSecondChanceItem(ItemType Item, string RecipientBidderUserID)
    {
      this.Item = Item;
      this.RecipientBidderUserID = RecipientBidderUserID;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void VerifyAddSecondChanceItem(
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
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType" /> for this API call.
    /// </summary>
    public VerifyAddSecondChanceItemRequestType ApiRequest
    {
      get => (VerifyAddSecondChanceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.VerifyAddSecondChanceItemResponseType" /> for this API call.
    /// </summary>
    public VerifyAddSecondChanceItemResponseType ApiResponse
    {
      get => (VerifyAddSecondChanceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType.RecipientBidderUserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RecipientBidderUserID
    {
      get => this.ApiRequest.RecipientBidderUserID;
      set => this.ApiRequest.RecipientBidderUserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType.BuyItNowPrice" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType BuyItNowPrice
    {
      get => this.ApiRequest.BuyItNowPrice;
      set => this.ApiRequest.BuyItNowPrice = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType.Duration" /> of type <see cref="T:eBay.Service.Core.Soap.SecondChanceOfferDurationCodeType" />.
    /// </summary>
    public SecondChanceOfferDurationCodeType Duration
    {
      get => this.ApiRequest.Duration;
      set => this.ApiRequest.Duration = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType.SellerMessage" /> of type <see cref="T:System.String" />.
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
      set => this.mItem = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddSecondChanceItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;
  }
}
