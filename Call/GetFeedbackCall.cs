// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetFeedbackCall
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
  public class GetFeedbackCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetFeedbackCall() => this.ApiRequest = new GetFeedbackRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetFeedbackCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetFeedbackRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves one, many, or all Feedback records for a specific eBay user. There is a filter option in the call request to limit Feedback records to those that are received, or to those that are left for other buyers, as well as a filter option to limit Feedback records to those that are received as a buyer or seller.
    /// </summary>
    /// <param name="UserID">
    /// The user's eBay User ID is specified in this field. If this field is used, all retrieved Feedback data will be for this eBay user. Specifies the user whose feedback data is to be returned. If this field is omitted in the call request, all retrieved Feedback records will be for the eBay user making the call.
    /// </param>
    /// <param name="FeedbackID">
    /// The unique identifier of a Feedback record. This field is used if the user wants to retrieve a specific Feedback record. If <b>FeedbackID</b> is specified in the call request, all other input fields are ignored.
    /// </param>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing. A listing can have multiple order line items, but only one <b>ItemID</b>. If <b>ItemID</b> is specified in the <b>GetFeedback</b> request, the returned Feedback record(s) are restricted to the specified <b>ItemID</b>. The maximum number of Feedback records that can be returned is 100.
    /// </param>
    /// <param name="TransactionID">
    /// Unique identifier for an eBay order line item. A
    /// <b>TransactionID</b> can be paired up with its corresponding <b>ItemID</b> and used as
    /// an input filter in the <b>GetFeedback</b> request. If an <b>ItemID</b>/<b>TransactionID</b>
    /// pair or an <b>OrderLineItemID</b> value is used to retrieve a feedback record
    /// on a specific order line item, the <b>FeedbackType</b> and <b>Pagination</b>
    /// fields (if included) are ignored.
    /// </param>
    /// <param name="CommentTypeList">
    /// This field is used to retrieve Feedback records of a specific type (Positive, Negative, or Neutral) in <b>FeedbackDetailArray</b>. You can include one or two <b> CommentType</b> fields in the request. If no <b>CommentType</b> value is specified, Feedback records of all types are returned.
    /// </param>
    /// <param name="FeedbackType">
    /// This field is used to restrict retrieved Feedback records to those that the user left for other buyers, Feedback records received as a seller, Feedback records received as a buyer, or Feedback records received as a buyer and seller. The default value is <b>FeedbackReceived</b>, so if the  <b>FeedbackType</b> field is omitted in the request, all Feedback records received by the user as a buyer and seller are returned in the response. "Feedback Left" data will not be returned in the call response.
    /// </param>
    /// <param name="Pagination">
    /// Controls the pagination of the result set. Child elements, <b>EntriesPerPage</b> and
    /// <b>PageNumber</b>, specify the maximum number of individual feedback records to return
    /// per call and which page of data to return. Only applicable if <b>DetailLevel</b> is
    /// set to <b>ReturnAll</b> and the call is returning feedback for a <b>UserID</b>. Feedback
    /// summary data is not paginated, but when pagination is used, it is returned
    /// after the last feedback detail entry.
    /// 
    /// Accepted values for <b>Pagination.EntriesPerPage</b> for GetFeedback is 25 (the
    /// default), 50, 100, and 200. If you specify a value of zero, or a value
    /// greater than 200, the call fails with an error. If you specify a value between
    /// one and twenty-four, the value is rounded up to 25. Values between 26 and 199
    /// that are not one of the accepted values are rounded down to the nearest
    /// accepted value.
    /// </param>
    /// <param name="OrderLineItemID">
    /// <b>OrderLineItemID</b> is a unique identifier for an eBay order line item. An <b>OrderLineItemID</b> can be used as an
    /// input filter in the <b>GetFeedback</b> request. If an <b>OrderLineItemID</b> value is
    /// used to retrieve a feedback record on a specific order line item, the
    /// <b>FeedbackType</b> and <b>Pagination</b> fields (if included) are ignored.
    /// </param>
    public FeedbackDetailTypeCollection GetFeedback(
      string UserID,
      string FeedbackID,
      string ItemID,
      string TransactionID,
      CommentTypeCodeTypeCollection CommentTypeList,
      FeedbackTypeCodeType FeedbackType,
      PaginationType Pagination,
      string OrderLineItemID)
    {
      this.UserID = UserID;
      this.FeedbackID = FeedbackID;
      this.ItemID = ItemID;
      this.TransactionID = TransactionID;
      this.CommentTypeList = CommentTypeList;
      this.FeedbackType = FeedbackType;
      this.Pagination = Pagination;
      this.OrderLineItemID = OrderLineItemID;
      this.Execute();
      return this.ApiResponse.FeedbackDetailArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public FeedbackDetailTypeCollection GetFeedback()
    {
      this.Execute();
      return this.FeedbackList;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public FeedbackDetailTypeCollection GetFeedback(string UserID)
    {
      this.UserID = UserID;
      this.Execute();
      return this.FeedbackList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetFeedbackRequestType" /> for this API call.
    /// </summary>
    public GetFeedbackRequestType ApiRequest
    {
      get => (GetFeedbackRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetFeedbackResponseType" /> for this API call.
    /// </summary>
    public GetFeedbackResponseType ApiResponse => (GetFeedbackResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID
    {
      get => this.ApiRequest.UserID;
      set => this.ApiRequest.UserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.FeedbackID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string FeedbackID
    {
      get => this.ApiRequest.FeedbackID;
      set => this.ApiRequest.FeedbackID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.TransactionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TransactionID
    {
      get => this.ApiRequest.TransactionID;
      set => this.ApiRequest.TransactionID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.CommentType" /> of type <see cref="T:eBay.Service.Core.Soap.CommentTypeCodeTypeCollection" />.
    /// </summary>
    public CommentTypeCodeTypeCollection CommentTypeList
    {
      get => this.ApiRequest.CommentType;
      set => this.ApiRequest.CommentType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.FeedbackType" /> of type <see cref="T:eBay.Service.Core.Soap.FeedbackTypeCodeType" />.
    /// </summary>
    public FeedbackTypeCodeType FeedbackType
    {
      get => this.ApiRequest.FeedbackType;
      set => this.ApiRequest.FeedbackType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetFeedbackRequestType.OrderLineItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderLineItemID
    {
      get => this.ApiRequest.OrderLineItemID;
      set => this.ApiRequest.OrderLineItemID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.FeedbackDetailArray" /> of type <see cref="T:eBay.Service.Core.Soap.FeedbackDetailTypeCollection" />.
    /// </summary>
    public FeedbackDetailTypeCollection FeedbackList => this.ApiResponse.FeedbackDetailArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.FeedbackDetailItemTotal" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int FeedbackDetailItemTotal => this.ApiResponse.FeedbackDetailItemTotal;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.FeedbackSummary" /> of type <see cref="T:eBay.Service.Core.Soap.FeedbackSummaryType" />.
    /// </summary>
    public FeedbackSummaryType FeedbackSummary => this.ApiResponse.FeedbackSummary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.FeedbackScore" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int FeedbackScore => this.ApiResponse.FeedbackScore;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.EntriesPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int EntriesPerPage => this.ApiResponse.EntriesPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetFeedbackResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;
  }
}
