// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetUserPreferencesCall
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
  public class SetUserPreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetUserPreferencesCall() => this.ApiRequest = new SetUserPreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetUserPreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetUserPreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call allows an eBay user to set/modify numerous seller account preferences.
    /// </summary>
    /// <param name="BidderNoticePreferences">
    /// This container is included if the seller wishes to receive contact information for unsuccessful bidders. This preference is only applicable for auction listings.
    /// </param>
    /// <param name="CombinedPaymentPreferences">
    /// This container is included if the seller wishes to set the preference for allowing Combined Invoice orders for cases where the buyer has multiple unpaid order line items from the same seller.
    /// </param>
    /// <param name="CrossPromotionPreferences">
    /// This container is deprecated.
    /// </param>
    /// <param name="SellerPaymentPreferences">
    /// This container is included if the seller wishes to set various payment preferences. One or more preferences may be set or modified under this container. Payment preferences specified in a <b>SetUserPreferences</b> call override the settings in My eBay payment preferences.
    /// </param>
    /// <param name="SellerFavoriteItemPreferences">
    /// This container is included if the seller wishes to set preferences for displaying items on a buyer's Favorite Sellers' Items page or Favorite Sellers' Items digest. One or more preferences may be set or modified under this container.
    /// </param>
    /// <param name="EndOfAuctionEmailPreferences">
    /// This container is included if the seller wishes to set preferences for the end-of-auction email sent to the winning bidder. These preferences allow the seller to customize the Email that is sent to buyer at the end of the auction. One or more preferences may be set or modified under this container. These preferences are only applicable for auction listings.
    /// </param>
    /// <param name="EmailShipmentTrackingNumberPreference">
    /// This field is included and set to <code>true</code> if the seller wishes to email the shipment's tracking number to the buyer.
    /// </param>
    /// <param name="RequiredShipPhoneNumberPreference">
    /// This field is included and set to <code>true</code> if the seller wishes to require the buyer to provide a shipping phone number upon checkout. Some shipping carriers require the receiver's phone number.
    /// </param>
    /// <param name="UnpaidItemAssistancePreferences">
    /// This container is included if the seller wishes to set Unpaid Item Assistant preferences. The Unpaid Item Assistant automatically opens an Unpaid Item case on the behalf of the seller if the buyer has not paid for the order after a specified number of days. One or more preferences may be set or modified under this container.
    /// </param>
    /// <param name="PurchaseReminderEmailPreferences">
    /// This container is included if the seller wishes to set the preference for sending a purchase reminder email to buyers.
    /// </param>
    /// <param name="SellerThirdPartyCheckoutDisabled">
    /// This field is no longer applicable, as third-party checkout on eBay is no longer possible.
    /// </param>
    /// <param name="DispatchCutoffTimePreference">
    /// This container is included if the seller wishes to set the order cut off time for same-day shipping. If the seller specifies a value of <code>0</code> in <strong>Item.DispatchTimeMax</strong> to offer same day handling when listing an item, the seller's shipping time commitment depends on the order cut off time set for the listing site, as indicated by the <strong>DispatchCutoffTimePreference.CutoffTime</strong> field.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> This field is not applicable for sellers who have opted into the Handling Time Option of eBay Guaranteed Delivery, as this field only shows a single order cutoff time, but with the Handling Time Option, a seller can set a different order cutoff time for each business day. Currently, eBay Guaranteed Delivery is only available in the US.</span>
    /// </param>
    /// <param name="GlobalShippingProgramListingPreference">
    /// If this flag is included and set to <code>true</code>, the seller's new listings will enable the Global Shipping Program by default.
    /// <br /><br />
    /// <span class="tablenote">
    /// <strong>Note:</strong> This field is ignored for sellers who are not opted in to the Global Shipping Program (when GetUserPreferences returns <strong>OfferGlobalShippingProgramPreference</strong> with a value of <code>false</code>).
    /// </span>
    /// </param>
    /// <param name="OverrideGSPserviceWithIntlService">
    /// If this flag is included and set to <code>true</code>, and the seller specifies an international shipping service to a particular country for a given listing, the specified service will take precedence and be the listing's default international shipping option for buyers in that country, rather than the Global Shipping Program. The Global Shipping Program will still be the listing's default option for shipping to any Global Shipping-eligible country for which the seller does <em>not</em> specify an international shipping service.
    /// <br /><br />
    /// If this flag is set to <code>false</code>, the Global Shipping Program will be each Global Shipping-eligible listing's default option for shipping to any Global Shipping-eligible country, regardless of any international shipping service that the seller specifies for the listing.
    /// </param>
    /// <param name="OutOfStockControlPreference">
    /// If this flag is included and set to <code>true</code>, it enables the Out-of-Stock feature. A seller would use this feature to keep Fixed-Price GTC (Good 'Til Canceled) listings alive even when the "quantity available" value goes to 0 (zero). This is useful when waiting for additional stock and eliminates the need to end the listing and then recreating it when stock arrives. <br /><br />
    /// While the "quantity available" value is 0, the listing would be hidden from eBay search and if that item was specifically searched for with <b>GetItem</b> (or related call), the element <b>HideFromSearch</b> would be returned as 'true' and <b>ReasonHideFromSearch</b> would be returned as 'OutOfStock'.
    /// <br /><br />
    /// When stock is available, the seller can use the <b>Revise</b> calls to update the inventory of the item (through the <b>Item.Quantity</b> or <b>Item.Variations.Variation.Quantity</b> fields) and the listing would appear again.
    /// <br /><br />
    /// You can return the value of this flag using the <a href="GetUserPreferences.html#Request.ShowOutOfStockControlPreference">GetUserPreferences</a> call and setting the <b>ShowOutOfStockControlPreference</b> field to 'true'. <br /><br />
    /// <span class="tablenote"><b>IMPORTANT: </b> When a listing using the Out-of-Stock feature has zero quantity, the seller has 90 days to add inventory without incurring a listing fee. Fees are changed at the end of each the billing cycle but are then refunded if the item is out-of-stock for an entire billing period. See <a href="../../../../guides/features-guide/default.html#development/Listings-UseOutOfStock.html#FeesForaListingWithZeroQuantity">Fees For a Listing With Zero Quantity</a> for details. </span>
    /// </param>
    public void SetUserPreferences(
      BidderNoticePreferencesType BidderNoticePreferences,
      CombinedPaymentPreferencesType CombinedPaymentPreferences,
      CrossPromotionPreferencesType CrossPromotionPreferences,
      SellerPaymentPreferencesType SellerPaymentPreferences,
      SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences,
      EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences,
      bool EmailShipmentTrackingNumberPreference,
      bool RequiredShipPhoneNumberPreference,
      UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences,
      PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences,
      bool SellerThirdPartyCheckoutDisabled,
      DispatchCutoffTimePreferencesType DispatchCutoffTimePreference,
      bool GlobalShippingProgramListingPreference,
      bool OverrideGSPserviceWithIntlService,
      bool OutOfStockControlPreference)
    {
      this.BidderNoticePreferences = BidderNoticePreferences;
      this.CombinedPaymentPreferences = CombinedPaymentPreferences;
      this.CrossPromotionPreferences = CrossPromotionPreferences;
      this.SellerPaymentPreferences = SellerPaymentPreferences;
      this.SellerFavoriteItemPreferences = SellerFavoriteItemPreferences;
      this.EndOfAuctionEmailPreferences = EndOfAuctionEmailPreferences;
      this.EmailShipmentTrackingNumberPreference = EmailShipmentTrackingNumberPreference;
      this.RequiredShipPhoneNumberPreference = RequiredShipPhoneNumberPreference;
      this.UnpaidItemAssistancePreferences = UnpaidItemAssistancePreferences;
      this.PurchaseReminderEmailPreferences = PurchaseReminderEmailPreferences;
      this.SellerThirdPartyCheckoutDisabled = SellerThirdPartyCheckoutDisabled;
      this.DispatchCutoffTimePreference = DispatchCutoffTimePreference;
      this.GlobalShippingProgramListingPreference = GlobalShippingProgramListingPreference;
      this.OverrideGSPserviceWithIntlService = OverrideGSPserviceWithIntlService;
      this.OutOfStockControlPreference = OutOfStockControlPreference;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void SetUserPreferences() => this.Execute();

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void SetUserPreferences(
      BidderNoticePreferencesType BidderNoticePreferences,
      CombinedPaymentPreferencesType CombinedPaymentPreferences,
      CrossPromotionPreferencesType CrossPromotionPreferences,
      SellerPaymentPreferencesType SellerPaymentPreferences,
      SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences,
      EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences)
    {
      this.BidderNoticePreferences = BidderNoticePreferences;
      this.CombinedPaymentPreferences = CombinedPaymentPreferences;
      this.CrossPromotionPreferences = CrossPromotionPreferences;
      this.SellerPaymentPreferences = SellerPaymentPreferences;
      this.SellerFavoriteItemPreferences = SellerFavoriteItemPreferences;
      this.EndOfAuctionEmailPreferences = EndOfAuctionEmailPreferences;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetUserPreferencesRequestType" /> for this API call.
    /// </summary>
    public SetUserPreferencesRequestType ApiRequest
    {
      get => (SetUserPreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetUserPreferencesResponseType" /> for this API call.
    /// </summary>
    public SetUserPreferencesResponseType ApiResponse
    {
      get => (SetUserPreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.BidderNoticePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.BidderNoticePreferencesType" />.
    /// </summary>
    public BidderNoticePreferencesType BidderNoticePreferences
    {
      get => this.ApiRequest.BidderNoticePreferences;
      set => this.ApiRequest.BidderNoticePreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.CombinedPaymentPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.CombinedPaymentPreferencesType" />.
    /// </summary>
    public CombinedPaymentPreferencesType CombinedPaymentPreferences
    {
      get => this.ApiRequest.CombinedPaymentPreferences;
      set => this.ApiRequest.CombinedPaymentPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.CrossPromotionPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.CrossPromotionPreferencesType" />.
    /// </summary>
    public CrossPromotionPreferencesType CrossPromotionPreferences
    {
      get => this.ApiRequest.CrossPromotionPreferences;
      set => this.ApiRequest.CrossPromotionPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.SellerPaymentPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerPaymentPreferencesType" />.
    /// </summary>
    public SellerPaymentPreferencesType SellerPaymentPreferences
    {
      get => this.ApiRequest.SellerPaymentPreferences;
      set => this.ApiRequest.SellerPaymentPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.SellerFavoriteItemPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.SellerFavoriteItemPreferencesType" />.
    /// </summary>
    public SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences
    {
      get => this.ApiRequest.SellerFavoriteItemPreferences;
      set => this.ApiRequest.SellerFavoriteItemPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.EndOfAuctionEmailPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.EndOfAuctionEmailPreferencesType" />.
    /// </summary>
    public EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences
    {
      get => this.ApiRequest.EndOfAuctionEmailPreferences;
      set => this.ApiRequest.EndOfAuctionEmailPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.EmailShipmentTrackingNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool EmailShipmentTrackingNumberPreference
    {
      get => this.ApiRequest.EmailShipmentTrackingNumberPreference;
      set => this.ApiRequest.EmailShipmentTrackingNumberPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.RequiredShipPhoneNumberPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool RequiredShipPhoneNumberPreference
    {
      get => this.ApiRequest.RequiredShipPhoneNumberPreference;
      set => this.ApiRequest.RequiredShipPhoneNumberPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.UnpaidItemAssistancePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.UnpaidItemAssistancePreferencesType" />.
    /// </summary>
    public UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences
    {
      get => this.ApiRequest.UnpaidItemAssistancePreferences;
      set => this.ApiRequest.UnpaidItemAssistancePreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.PurchaseReminderEmailPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.PurchaseReminderEmailPreferencesType" />.
    /// </summary>
    public PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences
    {
      get => this.ApiRequest.PurchaseReminderEmailPreferences;
      set => this.ApiRequest.PurchaseReminderEmailPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.SellerThirdPartyCheckoutDisabled" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SellerThirdPartyCheckoutDisabled
    {
      get => this.ApiRequest.SellerThirdPartyCheckoutDisabled;
      set => this.ApiRequest.SellerThirdPartyCheckoutDisabled = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.DispatchCutoffTimePreference" /> of type <see cref="T:eBay.Service.Core.Soap.DispatchCutoffTimePreferencesType" />.
    /// </summary>
    public DispatchCutoffTimePreferencesType DispatchCutoffTimePreference
    {
      get => this.ApiRequest.DispatchCutoffTimePreference;
      set => this.ApiRequest.DispatchCutoffTimePreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.GlobalShippingProgramListingPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool GlobalShippingProgramListingPreference
    {
      get => this.ApiRequest.GlobalShippingProgramListingPreference;
      set => this.ApiRequest.GlobalShippingProgramListingPreference = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.OverrideGSPserviceWithIntlService" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool OverrideGSPserviceWithIntlService
    {
      get => this.ApiRequest.OverrideGSPserviceWithIntlService;
      set => this.ApiRequest.OverrideGSPserviceWithIntlService = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetUserPreferencesRequestType.OutOfStockControlPreference" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool OutOfStockControlPreference
    {
      get => this.ApiRequest.OutOfStockControlPreference;
      set => this.ApiRequest.OutOfStockControlPreference = value;
    }
  }
}
