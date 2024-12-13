// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetUserPreferencesCall
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
  public class GetUserPreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetUserPreferencesCall() => this.ApiRequest = new GetUserPreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetUserPreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetUserPreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves the specified user preferences for the authenticated caller.
    /// </summary>
    /// <param name="ShowBidderNoticePreferences">
    /// If included and set to <code>true</code>, the seller's preference for receiving contact information for unsuccessful bidders is returned in the response.
    /// </param>
    /// <param name="ShowCombinedPaymentPreferences">
    /// If included and set to <code>true</code>, the seller's combined invoice preferences are returned in the response. These preferences are used to allow Combined Invoice orders.
    /// 
    /// </param>
    /// <param name="ShowCrossPromotionPreferences">
    /// This field is deprecated.
    /// </param>
    /// <param name="ShowSellerPaymentPreferences">
    /// If included and set to <code>true</code>, the seller's payment preferences are returned in the response.
    /// </param>
    /// <param name="ShowEndOfAuctionEmailPreferences">
    /// If included and set to <code>true</code>, the seller's preferences for the end-of-auction email sent to the winning bidder is returned in the response. These preferences are only applicable for auction listings.
    /// </param>
    /// <param name="ShowSellerFavoriteItemPreferences">
    /// If included and set to <code>true</code>, the seller's favorite item preferences are returned in the response.
    /// </param>
    /// <param name="ShowProStoresPreferences">
    /// This field is deprecated.
    /// </param>
    /// <param name="ShowEmailShipmentTrackingNumberPreference">
    /// If included and set to <code>true</code>, the seller's preference for sending an email to the buyer with the shipping tracking number is returned in the response.
    /// </param>
    /// <param name="ShowRequiredShipPhoneNumberPreference">
    /// If included and set to <code>true</code>, the seller's preference for requiring that the buyer supply a shipping phone number upon checkout is returned in the response. Some shipping carriers require the receiver's phone number.
    /// </param>
    /// <param name="ShowSellerExcludeShipToLocationPreference">
    /// If included and set to <code>true</code>, all of the seller's excluded shipping locations are returned in the response. The returned list mirrors the seller's current Exclude shipping locations list in My eBay's Shipping Preferences. An excluded shipping location in My eBay can be an entire geographical region (such as Middle East) or only an individual country (such as Iraq). Sellers can override these default settings for an individual listing by using the <b>Item.ShippingDetails.ExcludeShipToLocation</b> field in the <b>AddItem</b> family of calls.
    /// </param>
    /// <param name="ShowUnpaidItemAssistancePreference">
    /// If included and set to <code>true</code>, the seller's Unpaid Item Assistant preferences are returned in the response. The Unpaid Item Assistant automatically opens an Unpaid Item dispute on the behalf of the seller.  <span class="tablenote"><strong>Note:</strong> To return the list of buyers excluded from the Unpaid Item Assistant mechanism, the <b>ShowUnpaidItemAssistanceExclusionList</b> field must also be included and set to <code>true</code> in the request. Excluded buyers can be viewed in the <b>UnpaidItemAssistancePreferences.ExcludedUser</b> field. </span>
    /// </param>
    /// <param name="ShowPurchaseReminderEmailPreferences">
    /// If included and set to <code>true</code>, the seller's preference for sending a purchase reminder email to buyers is returned in the response.
    /// </param>
    /// <param name="ShowUnpaidItemAssistanceExclusionList">
    /// If included and set to <code>true</code>, the list of eBay user IDs on the Unpaid Item Assistant Excluded User list is returned through the <b>UnpaidItemAssistancePreferences.ExcludedUser</b> field in the response. <br /><br /> For excluded users, an Unpaid Item dispute is not automatically filed through the UPI Assistance mechanism. The Excluded User list is managed through the <b>SetUserPreferences</b> call.  <span class="tablenote"><strong>Note:</strong> To return the list of buyers excluded from the Unpaid Item Assistant mechanism, the <b>ShowUnpaidItemAssistancePreference</b> field must also be included and set to <b>true</b> in the request. </span>
    /// </param>
    /// <param name="ShowSellerProfilePreferences">
    /// If this flag is included and set to <code>true</code>, the seller's Business Policies profile information is returned in the response. This information includes a flag that indicates whether or not the seller has opted into Business Policies, as well as Business Policies profiles (payment, shipping, and return policy) active on the seller's account.
    /// </param>
    /// <param name="ShowSellerReturnPreferences">
    /// If this flag is included and set to <code>true</code>, the <b>SellerReturnPreferences</b> container is returned in the response and indicates whether or not the seller has opted in to eBay Managed Returns.
    /// 
    /// eBay Managed Returns are currently only available on the US, UK, DE, AU, and CA (English and French) sites.
    /// </param>
    /// <param name="ShowGlobalShippingProgramPreference">
    /// If this flag is included and set to <code>true</code>, the seller's preference for offering the Global Shipping Program to international buyers will be returned in <strong>OfferGlobalShippingProgramPreference</strong>.
    /// </param>
    /// <param name="ShowDispatchCutoffTimePreferences">
    /// If included and set to <code>true</code>, the seller's same-day handling cutoff time is returned in <strong>DispatchCutoffTimePreference.CutoffTime</strong>.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> This field is not applicable for sellers who have opted into the Handling Time Option of eBay Guaranteed Delivery, as this field only shows a single order cutoff time, but with the Handling Time Option, a seller can set a different order cutoff time for each business day. Currently, eBay Guaranteed Delivery is only available in the US.</span>
    /// 
    /// </param>
    /// <param name="ShowGlobalShippingProgramListingPreference">
    /// If included and set to <code>true</code>, the <strong>GlobalShippingProgramListingPreference</strong> field is returned. A returned value of <code>true</code> indicates that the seller's new listings will enable the Global Shipping Program by default.
    /// </param>
    /// <param name="ShowOverrideGSPServiceWithIntlServicePreference">
    /// If included and set to <code>true</code>, the <strong>OverrideGSPServiceWithIntlServicePreference</strong> field is returned. A returned value of <code>true</code> indicates that for the seller's listings that specify an international shipping service for any Global Shipping-eligible country, the specified service will take precedence and be the listing's default international shipping option for buyers in that country, rather than the Global Shipping Program.
    /// <br /><br />
    /// A returned value of <code>false</code> indicates that the Global Shipping program will take precedence over any international shipping service as the default option in Global Shipping-eligible listings for shipping to any Global Shipping-eligible country.
    /// </param>
    /// <param name="ShowPickupDropoffPreferences">
    /// If included and set to <code>true</code>, the <strong>PickupDropoffSellerPreference</strong> field is returned. A returned value of <code>true</code> indicates that the seller's new listings will by default be eligible to be evaluated for the Click and Collect feature.
    /// <br /><br />
    /// With the Click and Collect feature, a buyer can purchase certain items on eBay and collect them at a local store. Buyers are notified by eBay once their items are available. The Click and Collect feature is only available to large merchants on the eBay UK (site ID 3), eBay Australia (Site ID 15), and eBay Germany (Site ID 77) sites.
    /// <br /><br />
    /// <span class="tablenote"><b>Note:</b> The Click and Collect program no longer allows sellers to set the Click and Collect preference at the listing level.
    /// </span>
    /// </param>
    /// <param name="ShowOutOfStockControlPreference">
    /// If included and set to <code>true</code>, the seller's preferences related to the Out-of-Stock feature will be returned. This feature is set using the <a href="SetUserPreferences.html#Request.OutOfStockControlPreference">SetUserPreferences</a> call.
    /// </param>
    /// <param name="ShoweBayPLUSPreference">
    /// To determine whether a seller can offer eBay Plus in qualified listings, include this field and set it to <code>true</code>.
    /// <br /><br />
    /// eBay Plus is a premium account option for buyers, which provides benefits such as fast free domestic shipping and free returns on selected items. Top Rated eBay sellers must opt in to eBay Plus, and can offer the program on a per-listing basis.
    /// <br /><br />
    /// The <strong>eBayPLUSPreference</strong> container is returned in the response with information about each country where the seller is eligible to offer eBay Plus on listings (one <strong>eBayPLUSPreference</strong> container per country), as well as the seller's opt-in status and listing preference for each country.
    /// <br /><br />
    /// <span class="tablenote">
    /// <strong>Note:</strong> Currently, eBay Plus is available only to buyers in Germany, Austria, and Australia.
    /// </span>
    /// </param>
    public BidderNoticePreferencesType GetUserPreferences(
      bool ShowBidderNoticePreferences,
      bool ShowCombinedPaymentPreferences,
      bool ShowCrossPromotionPreferences,
      bool ShowSellerPaymentPreferences,
      bool ShowEndOfAuctionEmailPreferences,
      bool ShowSellerFavoriteItemPreferences,
      bool ShowProStoresPreferences,
      bool ShowEmailShipmentTrackingNumberPreference,
      bool ShowRequiredShipPhoneNumberPreference,
      bool ShowSellerExcludeShipToLocationPreference,
      bool ShowUnpaidItemAssistancePreference,
      bool ShowPurchaseReminderEmailPreferences,
      bool ShowUnpaidItemAssistanceExclusionList,
      bool ShowSellerProfilePreferences,
      bool ShowSellerReturnPreferences,
      bool ShowGlobalShippingProgramPreference,
      bool ShowDispatchCutoffTimePreferences,
      bool ShowGlobalShippingProgramListingPreference,
      bool ShowOverrideGSPServiceWithIntlServicePreference,
      bool ShowPickupDropoffPreferences,
      bool ShowOutOfStockControlPreference,
      bool ShoweBayPLUSPreference)
    {
      this.ShowBidderNoticePreferences = ShowBidderNoticePreferences;
      this.ShowCombinedPaymentPreferences = ShowCombinedPaymentPreferences;
      this.ShowCrossPromotionPreferences = ShowCrossPromotionPreferences;
      this.ShowSellerPaymentPreferences = ShowSellerPaymentPreferences;
      this.ShowEndOfAuctionEmailPreferences = ShowEndOfAuctionEmailPreferences;
      this.ShowSellerFavoriteItemPreferences = ShowSellerFavoriteItemPreferences;
      this.ShowProStoresPreferences = ShowProStoresPreferences;
      this.ShowEmailShipmentTrackingNumberPreference = ShowEmailShipmentTrackingNumberPreference;
      this.ShowRequiredShipPhoneNumberPreference = ShowRequiredShipPhoneNumberPreference;
      this.ShowSellerExcludeShipToLocationPreference = ShowSellerExcludeShipToLocationPreference;
      this.ShowUnpaidItemAssistancePreference = ShowUnpaidItemAssistancePreference;
      this.ShowPurchaseReminderEmailPreferences = ShowPurchaseReminderEmailPreferences;
      this.ShowUnpaidItemAssistanceExclusionList = ShowUnpaidItemAssistanceExclusionList;
      this.ShowSellerProfilePreferences = ShowSellerProfilePreferences;
      this.ShowSellerReturnPreferences = ShowSellerReturnPreferences;
      this.ShowGlobalShippingProgramPreference = ShowGlobalShippingProgramPreference;
      this.ShowDispatchCutoffTimePreferences = ShowDispatchCutoffTimePreferences;
      this.ShowGlobalShippingProgramListingPreference = ShowGlobalShippingProgramListingPreference;
      this.ShowOverrideGSPServiceWithIntlServicePreference = ShowOverrideGSPServiceWithIntlServicePreference;
      this.ShowPickupDropoffPreferences = ShowPickupDropoffPreferences;
      this.ShowOutOfStockControlPreference = ShowOutOfStockControlPreference;
      this.ShoweBayPLUSPreference = ShoweBayPLUSPreference;
      this.Execute();
      return this.ApiResponse.BidderNoticePreferences;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void GetUserPreferences(
      bool ShowBidderNoticePreferences,
      bool ShowCombinedPaymentPreferences,
      bool ShowCrossPromotionPreferences,
      bool ShowSellerPaymentPreferences,
      bool ShowSellerFavoriteItemPreferences)
    {
      this.ShowBidderNoticePreferences = ShowBidderNoticePreferences;
      this.ShowCombinedPaymentPreferences = ShowCombinedPaymentPreferences;
      this.ShowCrossPromotionPreferences = ShowCrossPromotionPreferences;
      this.ShowSellerPaymentPreferences = ShowSellerPaymentPreferences;
      this.ShowSellerFavoriteItemPreferences = ShowSellerFavoriteItemPreferences;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public BidderNoticePreferencesType GetUserPreferences(
      bool ShowBidderNoticePreferences,
      bool ShowCombinedPaymentPreferences,
      bool ShowCrossPromotionPreferences,
      bool ShowSellerPaymentPreferences,
      bool ShowEndOfAuctionEmailPreferences,
      bool ShowSellerFavoriteItemPreferences)
    {
      this.ShowBidderNoticePreferences = ShowBidderNoticePreferences;
      this.ShowCombinedPaymentPreferences = ShowCombinedPaymentPreferences;
      this.ShowCrossPromotionPreferences = ShowCrossPromotionPreferences;
      this.ShowSellerPaymentPreferences = ShowSellerPaymentPreferences;
      this.ShowEndOfAuctionEmailPreferences = ShowEndOfAuctionEmailPreferences;
      this.ShowSellerFavoriteItemPreferences = ShowSellerFavoriteItemPreferences;
      this.Execute();
      return this.ApiResponse.BidderNoticePreferences;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetUserPreferencesRequestType" /> for this API call.
    /// </summary>
    public GetUserPreferencesRequestType ApiRequest
    {
      get => (GetUserPreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetUserPreferencesResponseType" /> for this API call.
    /// </summary>
    public GetUserPreferencesResponseType ApiResponse
    {
      get => (GetUserPreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowBidderNoticePreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowBidderNoticePreferences
    {
      get => this.ApiRequest.ShowBidderNoticePreferences;
      set => this.ApiRequest.ShowBidderNoticePreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowCombinedPaymentPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowCombinedPaymentPreferences
    {
      get => this.ApiRequest.ShowCombinedPaymentPreferences;
      set => this.ApiRequest.ShowCombinedPaymentPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowCrossPromotionPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowCrossPromotionPreferences
    {
      get => this.ApiRequest.ShowCrossPromotionPreferences;
      set => this.ApiRequest.ShowCrossPromotionPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowSellerPaymentPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowSellerPaymentPreferences
    {
      get => this.ApiRequest.ShowSellerPaymentPreferences;
      set => this.ApiRequest.ShowSellerPaymentPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowEndOfAuctionEmailPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowEndOfAuctionEmailPreferences
    {
      get => this.ApiRequest.ShowEndOfAuctionEmailPreferences;
      set => this.ApiRequest.ShowEndOfAuctionEmailPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowSellerFavoriteItemPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowSellerFavoriteItemPreferences
    {
      get => this.ApiRequest.ShowSellerFavoriteItemPreferences;
      set => this.ApiRequest.ShowSellerFavoriteItemPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowProStoresPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowProStoresPreferences
    {
      get => this.ApiRequest.ShowProStoresPreferences;
      set => this.ApiRequest.ShowProStoresPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowEmailShipmentTrackingNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowEmailShipmentTrackingNumberPreference
    {
      get => this.ApiRequest.ShowEmailShipmentTrackingNumberPreference;
      set => this.ApiRequest.ShowEmailShipmentTrackingNumberPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowRequiredShipPhoneNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowRequiredShipPhoneNumberPreference
    {
      get => this.ApiRequest.ShowRequiredShipPhoneNumberPreference;
      set => this.ApiRequest.ShowRequiredShipPhoneNumberPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowSellerExcludeShipToLocationPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowSellerExcludeShipToLocationPreference
    {
      get => this.ApiRequest.ShowSellerExcludeShipToLocationPreference;
      set => this.ApiRequest.ShowSellerExcludeShipToLocationPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowUnpaidItemAssistancePreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowUnpaidItemAssistancePreference
    {
      get => this.ApiRequest.ShowUnpaidItemAssistancePreference;
      set => this.ApiRequest.ShowUnpaidItemAssistancePreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowPurchaseReminderEmailPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowPurchaseReminderEmailPreferences
    {
      get => this.ApiRequest.ShowPurchaseReminderEmailPreferences;
      set => this.ApiRequest.ShowPurchaseReminderEmailPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowUnpaidItemAssistanceExclusionList" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowUnpaidItemAssistanceExclusionList
    {
      get => this.ApiRequest.ShowUnpaidItemAssistanceExclusionList;
      set => this.ApiRequest.ShowUnpaidItemAssistanceExclusionList = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowSellerProfilePreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowSellerProfilePreferences
    {
      get => this.ApiRequest.ShowSellerProfilePreferences;
      set => this.ApiRequest.ShowSellerProfilePreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowSellerReturnPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowSellerReturnPreferences
    {
      get => this.ApiRequest.ShowSellerReturnPreferences;
      set => this.ApiRequest.ShowSellerReturnPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowGlobalShippingProgramPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowGlobalShippingProgramPreference
    {
      get => this.ApiRequest.ShowGlobalShippingProgramPreference;
      set => this.ApiRequest.ShowGlobalShippingProgramPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowDispatchCutoffTimePreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowDispatchCutoffTimePreferences
    {
      get => this.ApiRequest.ShowDispatchCutoffTimePreferences;
      set => this.ApiRequest.ShowDispatchCutoffTimePreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowGlobalShippingProgramListingPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowGlobalShippingProgramListingPreference
    {
      get => this.ApiRequest.ShowGlobalShippingProgramListingPreference;
      set => this.ApiRequest.ShowGlobalShippingProgramListingPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowOverrideGSPServiceWithIntlServicePreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowOverrideGSPServiceWithIntlServicePreference
    {
      get => this.ApiRequest.ShowOverrideGSPServiceWithIntlServicePreference;
      set => this.ApiRequest.ShowOverrideGSPServiceWithIntlServicePreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowPickupDropoffPreferences" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowPickupDropoffPreferences
    {
      get => this.ApiRequest.ShowPickupDropoffPreferences;
      set => this.ApiRequest.ShowPickupDropoffPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShowOutOfStockControlPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShowOutOfStockControlPreference
    {
      get => this.ApiRequest.ShowOutOfStockControlPreference;
      set => this.ApiRequest.ShowOutOfStockControlPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesRequestType.ShoweBayPLUSPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShoweBayPLUSPreference
    {
      get => this.ApiRequest.ShoweBayPLUSPreference;
      set => this.ApiRequest.ShoweBayPLUSPreference = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.BidderNoticePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.BidderNoticePreferencesType" />.
    /// </summary>
    public BidderNoticePreferencesType BidderNoticePreferences
    {
      get => this.ApiResponse.BidderNoticePreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.CombinedPaymentPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.CombinedPaymentPreferencesType" />.
    /// </summary>
    public CombinedPaymentPreferencesType CombinedPaymentPreferences
    {
      get => this.ApiResponse.CombinedPaymentPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.CrossPromotionPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.CrossPromotionPreferencesType" />.
    /// </summary>
    public CrossPromotionPreferencesType CrossPromotionPreferences
    {
      get => this.ApiResponse.CrossPromotionPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerPaymentPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerPaymentPreferencesType" />.
    /// </summary>
    public SellerPaymentPreferencesType SellerPaymentPreferences
    {
      get => this.ApiResponse.SellerPaymentPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerFavoriteItemPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerFavoriteItemPreferencesType" />.
    /// </summary>
    public SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences
    {
      get => this.ApiResponse.SellerFavoriteItemPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.EndOfAuctionEmailPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.EndOfAuctionEmailPreferencesType" />.
    /// </summary>
    public EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences
    {
      get => this.ApiResponse.EndOfAuctionEmailPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.EmailShipmentTrackingNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool EmailShipmentTrackingNumberPreference
    {
      get => this.ApiResponse.EmailShipmentTrackingNumberPreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.RequiredShipPhoneNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool RequiredShipPhoneNumberPreference
    {
      get => this.ApiResponse.RequiredShipPhoneNumberPreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.ProStoresPreference" /> of type <see cref="T:eBay.Service.Core.Soap.ProStoresCheckoutPreferenceType" />.
    /// </summary>
    public ProStoresCheckoutPreferenceType ProStoresPreference
    {
      get => this.ApiResponse.ProStoresPreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.UnpaidItemAssistancePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.UnpaidItemAssistancePreferencesType" />.
    /// </summary>
    public UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences
    {
      get => this.ApiResponse.UnpaidItemAssistancePreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerExcludeShipToLocationPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerExcludeShipToLocationPreferencesType" />.
    /// </summary>
    public SellerExcludeShipToLocationPreferencesType SellerExcludeShipToLocationPreferences
    {
      get => this.ApiResponse.SellerExcludeShipToLocationPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.PurchaseReminderEmailPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.PurchaseReminderEmailPreferencesType" />.
    /// </summary>
    public PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences
    {
      get => this.ApiResponse.PurchaseReminderEmailPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerThirdPartyCheckoutDisabled" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SellerThirdPartyCheckoutDisabled
    {
      get => this.ApiResponse.SellerThirdPartyCheckoutDisabled;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerProfilePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerProfilePreferencesType" />.
    /// </summary>
    public SellerProfilePreferencesType SellerProfilePreferences
    {
      get => this.ApiResponse.SellerProfilePreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.SellerReturnPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerReturnPreferencesType" />.
    /// </summary>
    public SellerReturnPreferencesType SellerReturnPreferences
    {
      get => this.ApiResponse.SellerReturnPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.OfferGlobalShippingProgramPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool OfferGlobalShippingProgramPreference
    {
      get => this.ApiResponse.OfferGlobalShippingProgramPreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.DispatchCutoffTimePreference" /> of type <see cref="T:eBay.Service.Core.Soap.DispatchCutoffTimePreferencesType" />.
    /// </summary>
    public DispatchCutoffTimePreferencesType DispatchCutoffTimePreference
    {
      get => this.ApiResponse.DispatchCutoffTimePreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.GlobalShippingProgramListingPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool GlobalShippingProgramListingPreference
    {
      get => this.ApiResponse.GlobalShippingProgramListingPreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.OverrideGSPServiceWithIntlServicePreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool OverrideGSPServiceWithIntlServicePreference
    {
      get => this.ApiResponse.OverrideGSPServiceWithIntlServicePreference;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.PickupDropoffSellerPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool PickupDropoffSellerPreference => this.ApiResponse.PickupDropoffSellerPreference;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.OutOfStockControlPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool OutOfStockControlPreference => this.ApiResponse.OutOfStockControlPreference;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserPreferencesResponseType.eBayPLUSPreference" /> of type <see cref="T:eBay.Service.Core.Soap.eBayPLUSPreferenceTypeCollection" />.
    /// </summary>
    public eBayPLUSPreferenceTypeCollection eBayPLUSPreferenceList
    {
      get => this.ApiResponse.eBayPLUSPreference;
    }
  }
}
