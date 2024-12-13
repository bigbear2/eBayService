// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseCheckoutStatusCall
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
  public class ReviseCheckoutStatusCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseCheckoutStatusCall() => this.ApiRequest = new ReviseCheckoutStatusRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseCheckoutStatusCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseCheckoutStatusRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to update the payment details, the shipping details,
    /// and the status of an order.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing. A listing can have multiple order line items, but only one <b>ItemID</b> value. An <b>ItemID</b> value can be paired up with a corresponding <b>TransactionID</b> value to identify and order line item in a <b>ReviseCheckoutStatus</b> call.
    /// 
    /// Unless an <b>OrderLineItemID</b> value is used to identify a an order line item, or an <b>OrderID</b> value is used to identify an order, the <b>ItemID</b>/<b>TransactionID</b> pair must be specified.
    /// 
    /// If an <b>OrderID</b> or an <b>OrderLineItemID</b> value is specified, the <b>ItemID</b>/<b>TransactionID</b> pair is ignored if present in the same request.
    /// <br />
    /// <br />
    /// It is also possible to identify an order line item with a
    /// <b>ItemID</b>/<b>BuyerID</b> combination, but this is not the most ideal approach since an error is returned if there are multiple order line items for that combination.
    /// <br />
    /// </param>
    /// <param name="TransactionID">
    /// Unique identifier for a sales transaction. This identifier is created as soon as there is a commitment to buy (bidder wins the auction, buyer clicks buy button, or buyer purchases item through <b>PlaceOffer</b> call). Since an auction listing can only have one sale/winning bidder during the duration of the listing, the <b>TransactionID</b> value for auction listings is always <code>0</code>. An  <b>ItemID</b>/<b>TransactionID</b> pair can be  used to identify an order line item in a <b>ReviseCheckoutStatus</b> call.
    /// 
    /// Unless an <b>OrderLineItemID</b> is used to identify an order line item,
    /// or an <b>OrderID</b> value is used to identify an order, the <b>ItemID</b>/<b>TransactionID</b> pair must be
    /// specified. For a multiple line item order, <b>OrderID</b>
    /// should be used. If <b>OrderID</b> or <b>OrderLineItemID</b> are specified, the
    /// <b>ItemID</b>/<b>TransactionID</b> pair is ignored if present in the same request.
    /// 
    /// </param>
    /// <param name="OrderID">
    /// A unique identifier that identifies a single line item or multiple line item order.
    /// 
    /// If an <b>OrderID</b> is used in the request, the <b>OrderLineItemID</b> and
    /// <b>ItemID</b>/<b>TransactionID</b> pair are ignored if they are specified in the same request.
    /// 
    /// <span class="tablenote"><b>Note: </b> As of June 2019, eBay has changed the format of order identifier values. The new format is a non-parsable string, globally unique across all eBay marketplaces, and consistent for both single line item and multiple line item orders. Unlike in the past, instead of just being known and exposed to the seller, these unique order identifiers will also be known and used/referenced by the buyer and eBay customer support.
    /// 
    /// For developers and sellers who are already integrated with the Trading API's order management calls, this change shouldn't impact your integration unless you parse the existing order identifiers (e.g., <b>OrderID</b> or <b>OrderLineItemID</b>), or otherwise infer meaning from the format (e.g., differentiating between a single line item order versus a multiple line item order). Because we realize that some integrations may have logic that is dependent upon the old identifier format, eBay is rolling out this Trading API change with version control to support a transition period of approximately 9 months before applications must switch to the new format completely.
    /// 
    /// During the transition period, for developers/sellers using a Trading WSDL older than Version 1113, they can use the <b>X-EBAY-API-COMPATIBILITY-LEVEL</b> HTTP header in API calls to control whether the new or old <b>OrderID</b> format is returned in call response payloads. To get the new <b>OrderID</b> format, the value of the <b>X-EBAY-API-COMPATIBILITY-LEVEL</b> HTTP header must be set to <code>1113</code>. During the transition period and even after, the new and old <b>OrderID</b> formats will still be supported/accepted in all Trading API call request payloads. After the transition period (which will be announced), only the new <b>OrderID</b> format will be returned in all Trading API call response payloads, regardless of the Trading WSDL version used or specified compatibility level.
    /// </span>
    /// 
    /// <span class="tablenote"><b>Note: </b> For sellers integrated with the new order ID format, please note that the identifier for an order will change as it goes from unpaid to paid status. Sellers can check to see if an order has been paid by looking for a value of 'Complete' in the <b>CheckoutStatus.Status</b> field in the response of <b>GetOrders</b> or <b>GetOrderTransactions</b> call, or in the <b>Status.CompleteStatus</b> field in the response of <b>GetItemTransactions</b> or <b>GetSellerTransactions</b> call. Sellers should  not fulfill orders until buyer has made payment. When using a <b>ReviseCheckoutStatus</b> call, either of these order IDs (paid or unpaid status) can be used to update an order. Similarly, either of these order IDs (paid or unpaid status) can be used in <b>GetOrders</b> or <b>GetOrderTransactions</b> call to retrieve specific order(s).
    /// </span>
    /// </param>
    /// <param name="AmountPaid">
    /// The total amount paid by the buyer. For a motor vehicle listing that requires a deposit, the <b>AmountPaid</b> value is the total amount paid by the buyer for the deposit. <b>AmountPaid</b> is optional if <b>CheckoutStatus</b> is <code>Incomplete</code> and required if it is <code>Complete</code>.
    /// </param>
    /// <param name="PaymentMethodUsed">
    /// Payment method used by the buyer. This field may be needed if the order payment between the buyer and seller happens off of eBay's platform. If the payment happens on eBay's platform, this field will not be necessary.
    /// 
    /// See eBay's
    /// <a href="https://www.ebay.com/help/policies/payment-policies/accepted-payments-policy?id=4269" target="_blank">Accepted Payments Policy</a> for more information about safe offline payment methods. Accepted payment methods will vary by category and by country.
    /// </param>
    /// <param name="CheckoutStatus">
    /// This field is included and its value is set to <code>Complete</code> if the seller is using the <b>ReviseCheckoutStatus</b> call to mark the order as 'Paid' by including the <b>PaymentStatus</b> field and setting its value to <code>Paid</code>.
    /// </param>
    /// <param name="ShippingService">
    /// The shipping service selected by the buyer from among the shipping services offered by the seller (such as UPS Ground). For a list of valid values, call <b>GeteBayDetails</b> with the <b>DetailName</b> field set to <code>ShippingServiceDetails</code>. The <b>ShippingServiceDetails.ValidForSellingFlow</b> flag must also be present in the response. Otherwise, that particular shipping service option is no longer valid and cannot be offered to buyers through a listing.
    /// <br /><br />
    /// <span class="tablenote"> <strong>Note:</strong> This field should not be used for orders being shipping through the  Global Shipping program; specifying <code>InternationalPriorityShipping</code> as a value for this field will produce an error. </span>
    /// </param>
    /// <param name="ShippingIncludedInTax">
    /// This field is included and set to <code>true</code> if sales tax for the order is applied against shipping costs (in addition to the item cost).
    /// </param>
    /// <param name="CheckoutMethod">This field is deprecated.</param>
    /// <param name="InsuranceType">
    /// This field is no longer applicable as it is not longer possible for a seller to offer a buyer shipping insurance.
    /// </param>
    /// <param name="PaymentStatus">
    /// This field is used to mark the order as paid or awaiting payment in eBay's system. This field may be needed if the order payment between the buyer and seller happens off of eBay's platform. If the payment happens on eBay's platform, this field will not be necessary. A user specifies <code>Pending</code> to indicate that the order is awaiting payment or if the the buyer has initiated payment, but the funds have not yet been sent to the seller's financial institution.
    /// </param>
    /// <param name="AdjustmentAmount">
    /// This field may be used if the buyer and seller have agreed on making an adjustment to the order total. A positive value indicates that the amount is an extra charge being paid to the seller by the buyer. A negative value indicates that the amount is a discount given to the buyer by the seller.
    /// </param>
    /// <param name="ShippingAddress">
    /// For internal use only. Do not use.
    /// </param>
    /// <param name="BuyerID">
    /// The eBay user ID for the order's buyer. A single line item order can actually be identified by a <b>BuyerID</b>/<b>ItemID</b> pair, but this approach is not recommended since an error may occur if there are multiple order line items between the buyer and seller. <b>BuyerID</b> is ignored if any other valid filter or filter combination is used in the same request.
    /// </param>
    /// <param name="ShippingInsuranceCost">
    /// This field is no longer applicable as it is not longer possible for a seller to offer a buyer shipping insurance.
    /// </param>
    /// <param name="SalesTax">
    /// This field is used if sales tax is being applied to the order. If the  sales tax amount is also being applied to the shipping charges (in addition to the item cost), the <b>ShippingIncludedInTax</b> boolean field should be included in the call request and set to <code>true</code>.
    /// </param>
    /// <param name="ShippingCost">
    /// This field is used to show the cost of shipping being applied to the order.
    /// </param>
    /// <param name="EncryptedID">Not supported.</param>
    /// <param name="ExternalTransaction">
    /// This container is used if payment for the order occurred off of eBay, and the seller wants to pass in the external payment reference ID.
    /// </param>
    /// <param name="MultipleSellerPaymentID">Not supported.</param>
    /// <param name="CODCost">
    /// This dollar value indicates the money due from the buyer upon delivery of the item.
    /// 
    /// This field should only be specified in the <b>ReviseCheckoutStatus</b> request if 'COD' (cash-on-delivery) was the payment method selected by the buyer and it is included as the <b>PaymentMethodUsed</b> value in the same request.
    /// </param>
    /// <param name="OrderLineItemID">
    /// A unique identifier for an eBay order line item. This identifier is created once there is a commitment to buy (bidder wins the auction, buyer clicks buy button, or buyer purchases item through <b>PlaceOffer</b> call).
    /// 
    /// Unless an <b>ItemID</b>/<b>TransactionID</b> pair is used to identify an order line item, or the <b>OrderID</b> is used to identify an order, the <b>OrderLineItemID</b> must be specified. For a multiple line item order, <b>OrderID</b> should be used. If <b>OrderLineItemID</b> is specified, the <b>ItemID</b>/<b>TransactionID</b> pair are ignored if present in the same request.
    /// </param>
    public void ReviseCheckoutStatus(
      string ItemID,
      string TransactionID,
      string OrderID,
      AmountType AmountPaid,
      BuyerPaymentMethodCodeType PaymentMethodUsed,
      CompleteStatusCodeType CheckoutStatus,
      string ShippingService,
      bool ShippingIncludedInTax,
      CheckoutMethodCodeType CheckoutMethod,
      InsuranceSelectedCodeType InsuranceType,
      RCSPaymentStatusCodeType PaymentStatus,
      AmountType AdjustmentAmount,
      AddressType ShippingAddress,
      string BuyerID,
      AmountType ShippingInsuranceCost,
      AmountType SalesTax,
      AmountType ShippingCost,
      string EncryptedID,
      ExternalTransactionType ExternalTransaction,
      string MultipleSellerPaymentID,
      AmountType CODCost,
      string OrderLineItemID)
    {
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.OrderID = OrderID;
      this.AmountPaid = AmountPaid;
      this.PaymentMethodUsed = PaymentMethodUsed;
      this.CheckoutStatus = CheckoutStatus;
      this.ShippingService = ShippingService;
      this.ShippingIncludedInTax = ShippingIncludedInTax;
      this.CheckoutMethod = CheckoutMethod;
      this.InsuranceType = InsuranceType;
      this.PaymentStatus = PaymentStatus;
      this.AdjustmentAmount = AdjustmentAmount;
      this.ShippingAddress = ShippingAddress;
      this.BuyerID = BuyerID;
      this.ShippingInsuranceCost = ShippingInsuranceCost;
      this.SalesTax = SalesTax;
      this.ShippingCost = ShippingCost;
      this.EncryptedID = EncryptedID;
      this.ExternalTransaction = ExternalTransaction;
      this.MultipleSellerPaymentID = MultipleSellerPaymentID;
      this.CODCost = CODCost;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void ReviseCheckoutStatus(
      string ItemID,
      string TransactionID,
      CompleteStatusCodeType CheckoutStatus)
    {
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.CheckoutStatus = CheckoutStatus;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void ReviseCheckoutStatus(string OrderID, CompleteStatusCodeType CheckoutStatus)
    {
      this.OrderID = OrderID;
      this.TransactionID = this.TransactionID;
      this.CheckoutStatus = CheckoutStatus;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType" /> for this API call.
    /// </summary>
    public ReviseCheckoutStatusRequestType ApiRequest
    {
      get => (ReviseCheckoutStatusRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseCheckoutStatusResponseType" /> for this API call.
    /// </summary>
    public ReviseCheckoutStatusResponseType ApiResponse
    {
      get => (ReviseCheckoutStatusResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.OrderID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderID
    {
      get => this.ApiRequest.OrderID;
      set => this.ApiRequest.OrderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.AmountPaid" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType AmountPaid
    {
      get => this.ApiRequest.AmountPaid;
      set => this.ApiRequest.AmountPaid = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.PaymentMethodUsed" /> of type <see cref="T:eBay.Service.Core.Soap.BuyerPaymentMethodCodeType" />.
    /// </summary>
    public BuyerPaymentMethodCodeType PaymentMethodUsed
    {
      get => this.ApiRequest.PaymentMethodUsed;
      set => this.ApiRequest.PaymentMethodUsed = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.CheckoutStatus" /> of type <see cref="T:eBay.Service.Core.Soap.CompleteStatusCodeType" />.
    /// </summary>
    public CompleteStatusCodeType CheckoutStatus
    {
      get => this.ApiRequest.CheckoutStatus;
      set => this.ApiRequest.CheckoutStatus = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ShippingService" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ShippingService
    {
      get => this.ApiRequest.ShippingService;
      set => this.ApiRequest.ShippingService = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ShippingIncludedInTax" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ShippingIncludedInTax
    {
      get => this.ApiRequest.ShippingIncludedInTax;
      set => this.ApiRequest.ShippingIncludedInTax = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.CheckoutMethod" /> of type <see cref="T:eBay.Service.Core.Soap.CheckoutMethodCodeType" />.
    /// </summary>
    public CheckoutMethodCodeType CheckoutMethod
    {
      get => this.ApiRequest.CheckoutMethod;
      set => this.ApiRequest.CheckoutMethod = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.InsuranceType" /> of type <see cref="T:eBay.Service.Core.Soap.InsuranceSelectedCodeType" />.
    /// </summary>
    public InsuranceSelectedCodeType InsuranceType
    {
      get => this.ApiRequest.InsuranceType;
      set => this.ApiRequest.InsuranceType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.PaymentStatus" /> of type <see cref="T:eBay.Service.Core.Soap.RCSPaymentStatusCodeType" />.
    /// </summary>
    public RCSPaymentStatusCodeType PaymentStatus
    {
      get => this.ApiRequest.PaymentStatus;
      set => this.ApiRequest.PaymentStatus = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.AdjustmentAmount" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType AdjustmentAmount
    {
      get => this.ApiRequest.AdjustmentAmount;
      set => this.ApiRequest.AdjustmentAmount = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ShippingAddress" /> of type <see cref="T:eBay.Service.Core.Soap.AddressType" />.
    /// </summary>
    public AddressType ShippingAddress
    {
      get => this.ApiRequest.ShippingAddress;
      set => this.ApiRequest.ShippingAddress = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.BuyerID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string BuyerID
    {
      get => this.ApiRequest.BuyerID;
      set => this.ApiRequest.BuyerID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ShippingInsuranceCost" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType ShippingInsuranceCost
    {
      get => this.ApiRequest.ShippingInsuranceCost;
      set => this.ApiRequest.ShippingInsuranceCost = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.SalesTax" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType SalesTax
    {
      get => this.ApiRequest.SalesTax;
      set => this.ApiRequest.SalesTax = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ShippingCost" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType ShippingCost
    {
      get => this.ApiRequest.ShippingCost;
      set => this.ApiRequest.ShippingCost = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.EncryptedID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string EncryptedID
    {
      get => this.ApiRequest.EncryptedID;
      set => this.ApiRequest.EncryptedID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.ExternalTransaction" /> of type <see cref="T:eBay.Service.Core.Soap.ExternalTransactionType" />.
    /// </summary>
    public ExternalTransactionType ExternalTransaction
    {
      get => this.ApiRequest.ExternalTransaction;
      set => this.ApiRequest.ExternalTransaction = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.MultipleSellerPaymentID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string MultipleSellerPaymentID
    {
      get => this.ApiRequest.MultipleSellerPaymentID;
      set => this.ApiRequest.MultipleSellerPaymentID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.CODCost" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType CODCost
    {
      get => this.ApiRequest.CODCost;
      set => this.ApiRequest.CODCost = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }
  }
}
