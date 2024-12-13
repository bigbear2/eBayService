// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.PlaceOfferCall
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
  public class PlaceOfferCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public PlaceOfferCall() => this.ApiRequest = new PlaceOfferRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public PlaceOfferCall(ApiContext ApiContext)
    {
      this.ApiRequest = new PlaceOfferRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables the authenticated user to to make a bid on an auction item, propose a Best Offer, or purchase a fixed-price/Buy It Now item. Note that this call cannot be used to purchase items that require immediate payment.
    /// </summary>
    /// <param name="Offer">
    /// This container specifies the type of offer being made for the listing specified in the <b>ItemID</b> field. The <b>Offer.Action</b> is used to set the action that is being taken on the listing.
    /// </param>
    /// <param name="ItemID">
    /// Unique identifier that identifies the listing for which the action is being submitted.
    /// 
    /// For a multiple-variation listing, you must also identify the specific variation within that listing using the <b>VariationSpecifics</b> container.
    /// </param>
    /// <param name="BlockOnWarning">
    /// If a warning message is generated when the call is made, this <b>BlockOnWarning</b> will block the bid/buy action if set to <code>true</code>. If <b>BlockOnWarning</b>
    /// is <code>false</code> or omitted, the bid/buy action is allowed, regardless of whether or not a warning message occurs.
    /// 
    /// </param>
    /// <param name="AffiliateTrackingDetails">
    /// Container for affiliate-related tags, which enable the tracking of user
    /// activity. If you include the <b>AffiliateTrackingDetails</b> container in your <b>PlaceOffer</b> call, then
    /// it is possible to receive affiliate commissions based on calls made by your
    /// application. (See the <a href="http://www.ebaypartnernetwork.com/" target="_blank">eBay Partner Network</a>
    /// for information about commissions.) Please note that affiliate tracking is not
    /// available in the Sandbox environment, and that affiliate tracking is not
    /// available when you make a Best Offer.
    /// </param>
    /// <param name="VariationSpecificList">
    /// This container is used to identify a specific variation within a multiple-variation listing identified by the <b>ItemID</b> value. This container is required when attempting to perform an action on a multiple-variation listing.
    /// </param>
    public SellingStatusType PlaceOffer(
      OfferType Offer,
      string ItemID,
      bool BlockOnWarning,
      AffiliateTrackingDetailsType AffiliateTrackingDetails,
      NameValueListTypeCollection VariationSpecificList)
    {
      this.Offer = Offer;
      this.ItemID = ItemID;
      this.BlockOnWarning = BlockOnWarning;
      this.AffiliateTrackingDetails = AffiliateTrackingDetails;
      this.VariationSpecificList = VariationSpecificList;
      this.Execute();
      return this.ApiResponse.SellingStatus;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public SellingStatusType PlaceOffer(OfferType Offer, string ItemID)
    {
      this.Offer = Offer;
      this.ItemID = ItemID;
      this.Execute();
      return this.ApiResponse.SellingStatus;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.PlaceOfferRequestType" /> for this API call.
    /// </summary>
    public PlaceOfferRequestType ApiRequest
    {
      get => (PlaceOfferRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.PlaceOfferResponseType" /> for this API call.
    /// </summary>
    public PlaceOfferResponseType ApiResponse => (PlaceOfferResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.PlaceOfferRequestType.Offer" /> of type <see cref="T:eBay.Service.Core.Soap.OfferType" />.
    /// </summary>
    public OfferType Offer
    {
      get => this.ApiRequest.Offer;
      set => this.ApiRequest.Offer = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.PlaceOfferRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.PlaceOfferRequestType.BlockOnWarning" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool BlockOnWarning
    {
      get => this.ApiRequest.BlockOnWarning;
      set => this.ApiRequest.BlockOnWarning = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.PlaceOfferRequestType.AffiliateTrackingDetails" /> of type <see cref="T:eBay.Service.Core.Soap.AffiliateTrackingDetailsType" />.
    /// </summary>
    public AffiliateTrackingDetailsType AffiliateTrackingDetails
    {
      get => this.ApiRequest.AffiliateTrackingDetails;
      set => this.ApiRequest.AffiliateTrackingDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.PlaceOfferRequestType.VariationSpecifics" /> of type <see cref="T:eBay.Service.Core.Soap.NameValueListTypeCollection" />.
    /// </summary>
    public NameValueListTypeCollection VariationSpecificList
    {
      get => this.ApiRequest.VariationSpecifics;
      set => this.ApiRequest.VariationSpecifics = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.PlaceOfferResponseType.SellingStatus" /> of type <see cref="T:eBay.Service.Core.Soap.SellingStatusType" />.
    /// </summary>
    public SellingStatusType SellingStatus => this.ApiResponse.SellingStatus;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.PlaceOfferResponseType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID => this.ApiResponse.TransactionID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.PlaceOfferResponseType.BestOffer" /> of type <see cref="T:eBay.Service.Core.Soap.BestOfferType" />.
    /// </summary>
    public BestOfferType BestOffer => this.ApiResponse.BestOffer;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.PlaceOfferResponseType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID => this.ApiResponse.OrderLineItemID;
  }
}
