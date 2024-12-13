// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.RespondToFeedbackCall
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
  public class RespondToFeedbackCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public RespondToFeedbackCall() => this.ApiRequest = new RespondToFeedbackRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public RespondToFeedbackCall(ApiContext ApiContext)
    {
      this.ApiRequest = new RespondToFeedbackRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to reply to Feedback that has been left for a user, or to post a
    /// follow-up comment to a Feedback comment the user has left for someone else.
    /// </summary>
    /// <param name="FeedbackID">
    /// A unique identifier for a Feedback record. Buying and selling partners
    /// leave feedback for one another after the completion of an order.
    /// Feedback is left at the order line item level, so a
    /// Feedback comment for each order line item in a Combined Payment order is
    /// expected from the buyer and seller. A unique <b>FeedbackID</b> is created
    /// whenever a buyer leaves feedback for a seller, and vice versa. A
    /// <b>FeedbackID</b> is created by eBay when feedback is left through the eBay
    /// site, or through the <b>LeaveFeedback</b> call. <b>FeedbackIDs</b> can be retrieved
    /// with the <b>GetFeedback</b> call. In the <b>RespondToFeedback</b> call, <b>FeedbackID</b> can
    /// be used as an input filter to respond to a specific Feedback comment.
    /// Since Feedback is always linked to a unique order line item, an
    /// <b>ItemID</b>/<b>TransactionID</b> pair or an <b>OrderLineItemID</b> can also be used to
    /// respond to a Feedback comment.
    /// </param>
    /// <param name="ItemID">
    /// Unique identifier for the eBay listing to which the user will be responding to Feedback. A listing can have multiple
    /// order line items, but only one <b>ItemID</b> value. An <b>ItemID</b> can be
    /// paired up with a corresponding <b>TransactionID</b> and used as an input filter
    /// to respond to a Feedback comment in the <b>RespondToFeedback</b> call. Unless
    /// the specific Feedback record is identified by a <b>FeedbackID</b> or an
    /// <b>OrderLineItemID</b> in the request, an <b>ItemID</b>/<b>TransactionID</b> pair is
    /// required.
    /// </param>
    /// <param name="TransactionID">
    /// Unique identifier for an eBay order line item. A
    /// <b>TransactionID</b> can be paired up with its corresponding <b>ItemID</b> and used as
    /// an input filter to respond to a Feedback comment in the
    /// <b>RespondToFeedback</b> call. Unless the specific Feedback record is
    /// identified by a <b>FeedbackID</b> or an <b>OrderLineItemID</b> in the request, an
    /// <b>ItemID</b>/<b>TransactionID</b> pair is required.
    /// </param>
    /// <param name="TargetUserID">
    /// The eBay user ID of the caller's order partner. The caller is either
    /// replyting to or following up on this user's Feedback comment.
    /// </param>
    /// <param name="ResponseType">
    /// Specifies whether the response is a reply or a follow-up to a Feedback
    /// comment left by the user identified in the <b>TargetUserID</b> field.
    /// </param>
    /// <param name="ResponseText">
    /// Textual comment that the user who is subject of feedback may leave in
    /// response or rebuttal to the Feedback comment. Alternatively, when the
    /// <b>ResponseType</b> is <b>FollowUp</b>, this value contains the text of the follow-up
    /// comment.
    /// 
    /// </param>
    /// <param name="OrderLineItemID">
    /// <b>OrderLineItemID</b> is a unique identifier for an eBay order line item. Since Feedback is always linked to a
    /// unique order line item, an <b>OrderLineItemID</b> can be used to respond
    /// to a Feedback comment.
    /// 
    /// Unless an <b>ItemID</b>/<b>TransactionID</b> pair or a <b>FeedbackID</b> is used to identify
    /// a Feedback record, the <b>OrderLineItemID</b> must be specified.
    /// 
    /// </param>
    public void RespondToFeedback(
      string FeedbackID,
      string ItemID,
      string TransactionID,
      string TargetUserID,
      FeedbackResponseCodeType ResponseType,
      string ResponseText,
      string OrderLineItemID)
    {
      this.FeedbackID = FeedbackID;
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.TargetUserID = TargetUserID;
      this.ResponseType = ResponseType;
      this.ResponseText = ResponseText;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void RespondToFeedback(
      string TargetUserID,
      string ItemID,
      string TransactionID,
      FeedbackResponseCodeType ResponseType,
      string ResponseText)
    {
      this.TargetUserID = TargetUserID;
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.ResponseType = ResponseType;
      this.ResponseText = ResponseText;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void RespondToFeedback(
      string TargetUserID,
      string ItemID,
      FeedbackResponseCodeType ResponseType,
      string ResponseText)
    {
      this.TargetUserID = TargetUserID;
      this.ItemID = ItemID;
      this.ResponseType = ResponseType;
      this.ResponseText = ResponseText;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.RespondToFeedbackRequestType" /> for this API call.
    /// </summary>
    public RespondToFeedbackRequestType ApiRequest
    {
      get => (RespondToFeedbackRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.RespondToFeedbackResponseType" /> for this API call.
    /// </summary>
    public RespondToFeedbackResponseType ApiResponse
    {
      get => (RespondToFeedbackResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.FeedbackID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string FeedbackID
    {
      get => this.ApiRequest.FeedbackID;
      set => this.ApiRequest.FeedbackID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.TargetUserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TargetUserID
    {
      get => this.ApiRequest.TargetUserID;
      set => this.ApiRequest.TargetUserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.ResponseType" /> of type <see cref="T:eBay.Service.Core.Soap.FeedbackResponseCodeType" />.
    /// </summary>
    public FeedbackResponseCodeType ResponseType
    {
      get => this.ApiRequest.ResponseType;
      set => this.ApiRequest.ResponseType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.ResponseText" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ResponseText
    {
      get => this.ApiRequest.ResponseText;
      set => this.ApiRequest.ResponseText = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RespondToFeedbackRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }
  }
}
