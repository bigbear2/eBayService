// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.LeaveFeedbackCall
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
  public class LeaveFeedbackCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public LeaveFeedbackCall() => this.ApiRequest = new LeaveFeedbackRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public LeaveFeedbackCall(ApiContext ApiContext)
    {
      this.ApiRequest = new LeaveFeedbackRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a buyer and seller to leave Feedback for their order partner at the
    /// conclusion of a successful order.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing. A listing can have multiple
    /// order line items, but only one <b>ItemID</b>. Unless an
    /// <b>OrderLineItemID</b> is specified in the <b>LeaveFeedback</b> request, the <b>ItemID</b> is
    /// required along with the <b>TargetUser</b> to identify an order line item
    /// existing between the caller and the <b>TargetUser</b> that requires feedback. A
    /// Feedback comment will be posted for this order line item. If there are
    /// multiple order line items between the two order partners that still
    /// require feedback, the <b>TransactionID</b> will also be required to isolate the
    /// targeted order line item. Feedback cannot be left for order line items
    /// with creation dates more than 60 days in the past.
    /// </param>
    /// <param name="CommentText">
    /// Textual comment that explains, clarifies, or justifies the feedback
    /// score specified in <b>CommentType</b>.
    /// 
    /// </param>
    /// <param name="CommentType">
    /// Score for the Feedback being left. May be Positive, Neutral, or Negative.
    /// 
    /// <span class="tablenote"><b>Note:</b>
    /// Sellers can not leave neutral or negative feedback for buyers. In addition, buyers can not leave neutral or negative feedback within 7 days from the completion of the order for active Power Sellers who have been on eBay for 12 months.
    /// </span>
    /// </param>
    /// <param name="TransactionID">
    /// Unique identifier for an eBay order line item. If there
    /// are multiple order line items between the two order partners that still
    /// require Feedback, the <b>TransactionID</b> is required along with the
    /// corresponding <b>ItemID</b> and <b>TargetUser</b> to isolate the targeted order line
    /// item. If an <b>OrderLineItemID</b> is included in the response to identify a
    /// specific order line item, none of the preceding fields (<b>ItemID</b>,
    /// <b>TransactionID</b>, <b>TargetUser</b>) are needed. Feedback cannot be left for order
    /// line items with creation dates more than 60 days in the past.
    /// </param>
    /// <param name="TargetUser">
    /// Specifies the recipient user about whom the Feedback is being left.
    /// </param>
    /// <param name="SellerItemRatingDetailArrayList">
    /// Container for detailed seller ratings (DSRs). If a buyer is providing DSRs, they are specified in this container. Sellers have access to the number of ratings they've received, as well as to the averages of the DSRs they've received in each DSR area (i.e., to the average of ratings in the item-description area, etc.).
    /// </param>
    /// <param name="OrderLineItemID">
    /// <b>OrderLineItemID</b> is a unique identifier for an eBay order line item. If an <b>OrderLineItemID</b> is included in
    /// the request, the <b>ItemID</b>, <b>TransactionID</b>, and <b>TargetUser</b> fields are not
    /// required. Feedback cannot be left for order line items with creation
    /// dates more than 60 days in the past.
    /// 
    /// </param>
    /// <param name="ItemArrivedWithinEDDType">
    /// This field or the <b>ItemDeliveredWithinEDD</b> field should be included if it is the buyer leaving feedback for the seller. This field will inform eBay about whether or not the buyer received the order line item within the estimated delivery date, which is established once a buyer purchases or commits to buy an item.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> A new "Late shipment rate" metric became a new component of Seller Standards beginning in February 2016. On-time shipping means that the seller shipped the item before the "handling time" expired and/or the item was received by the buyer within the estimated delivery date window, which is established once the buyer pays for the order line item. Previously, a seller's account could be dinged just for getting a low rating for the "shippping time" Detailed Seller Rating. </span>
    /// </param>
    /// <param name="ItemDeliveredWithinEDD">
    /// This field or the <b>ItemArrivedWithinEDDType</b> field should be included if it is the buyer leaving feedback for the seller. This field will inform eBay about whether or not the buyer received the order line item within the estimated delivery date window, which is established once a buyer purchases or commits to buy an item. The value of this field is set to <code>true</code> if the item did arrive within the estimated delivery date, or <code>false</code> if the item arrived past the estimated delivery date.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> A new "Late shipment rate" metric became a new component of Seller Standards beginning in February 2016. On-time shipping means that the seller shipped the item before the "handling time" expired and/or the item was received by the buyer within the estimated delivery date window, which is established once the buyer pays for the order line item. Previously, a seller's account could be dinged just for getting a low rating for the "shippping time" Detailed Seller Rating. </span>
    /// </param>
    public string LeaveFeedback(
      string ItemID,
      string CommentText,
      CommentTypeCodeType CommentType,
      string TransactionID,
      string TargetUser,
      ItemRatingDetailsTypeCollection SellerItemRatingDetailArrayList,
      string OrderLineItemID,
      ItemArrivedWithinEDDCodeType ItemArrivedWithinEDDType,
      bool ItemDeliveredWithinEDD)
    {
      this.ItemID = ItemID;
      this.CommentText = CommentText;
      this.CommentType = CommentType;
      this.TransactionID = TransactionID;
      this.TargetUser = TargetUser;
      this.SellerItemRatingDetailArrayList = SellerItemRatingDetailArrayList;
      this.OrderLineItemID = OrderLineItemID;
      this.ItemArrivedWithinEDDType = ItemArrivedWithinEDDType;
      this.ItemDeliveredWithinEDD = ItemDeliveredWithinEDD;
      this.Execute();
      return this.ApiResponse.FeedbackID;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public string LeaveFeedback(
      string TargetUser,
      string ItemID,
      string TransactionID,
      CommentTypeCodeType CommentType,
      string CommentText)
    {
      this.TargetUser = TargetUser;
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.CommentType = CommentType;
      this.CommentText = CommentText;
      this.Execute();
      return this.FeedbackID;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public string LeaveFeedback(
      string TargetUser,
      string ItemID,
      CommentTypeCodeType CommentType,
      string CommentText)
    {
      this.TargetUser = TargetUser;
      this.ItemID = ItemID;
      this.CommentType = CommentType;
      this.CommentText = CommentText;
      this.Execute();
      return this.FeedbackID;
    }

    /// For backward compatibility with old wrappers
    public string LeaveFeedback(
      string ItemID,
      string CommentText,
      CommentTypeCodeType CommentType,
      string TransactionID,
      string TargetUser)
    {
      this.ItemID = ItemID;
      this.CommentText = CommentText;
      this.CommentType = CommentType;
      this.TransactionID = TransactionID;
      this.TargetUser = TargetUser;
      this.Execute();
      return this.ApiResponse.FeedbackID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.LeaveFeedbackRequestType" /> for this API call.
    /// </summary>
    public LeaveFeedbackRequestType ApiRequest
    {
      get => (LeaveFeedbackRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.LeaveFeedbackResponseType" /> for this API call.
    /// </summary>
    public LeaveFeedbackResponseType ApiResponse
    {
      get => (LeaveFeedbackResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.CommentText" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CommentText
    {
      get => this.ApiRequest.CommentText;
      set => this.ApiRequest.CommentText = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.CommentType" /> of type <see cref="T:eBay.Service.Core.Soap.CommentTypeCodeType" />.
    /// </summary>
    public CommentTypeCodeType CommentType
    {
      get => this.ApiRequest.CommentType;
      set => this.ApiRequest.CommentType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.TargetUser" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TargetUser
    {
      get => this.ApiRequest.TargetUser;
      set => this.ApiRequest.TargetUser = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.SellerItemRatingDetailArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemRatingDetailsTypeCollection" />.
    /// </summary>
    public ItemRatingDetailsTypeCollection SellerItemRatingDetailArrayList
    {
      get => this.ApiRequest.SellerItemRatingDetailArray;
      set => this.ApiRequest.SellerItemRatingDetailArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.ItemArrivedWithinEDDType" /> of type <see cref="T:eBay.Service.Core.Soap.ItemArrivedWithinEDDCodeType" />.
    /// </summary>
    public ItemArrivedWithinEDDCodeType ItemArrivedWithinEDDType
    {
      get => this.ApiRequest.ItemArrivedWithinEDDType;
      set => this.ApiRequest.ItemArrivedWithinEDDType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackRequestType.ItemDeliveredWithinEDD" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ItemDeliveredWithinEDD
    {
      get => this.ApiRequest.ItemDeliveredWithinEDD;
      set => this.ApiRequest.ItemDeliveredWithinEDD = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.LeaveFeedbackResponseType.FeedbackID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string FeedbackID => this.ApiResponse.FeedbackID;
  }
}
