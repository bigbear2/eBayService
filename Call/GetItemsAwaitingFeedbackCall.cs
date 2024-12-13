// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetItemsAwaitingFeedbackCall
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
  public class GetItemsAwaitingFeedbackCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetItemsAwaitingFeedbackCall()
    {
      this.ApiRequest = new GetItemsAwaitingFeedbackRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetItemsAwaitingFeedbackCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetItemsAwaitingFeedbackRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type of the <b>GetItemsAwaitingFeedback</b> call. This call retrieves all completed order line items for which the user (buyer or seller) still needs to leave Feedback for their order partner.
    /// </summary>
    /// <param name="Sort">
    /// This field allows the user to control how the order line items are returned in the response. If this field is not used, order line items are returned based on end time (from most recent to oldest).
    /// Valid values for this field are:
    /// <ul>
    /// <li><code>EndTime</code></li>
    /// <li><code>EndTimeDescending</code> (default value)</li>
    /// <li><code>FeedbackLeft</code></li>
    /// <li><code>FeedbackLeftDescending</code></li>
    /// <li><code>FeedbackReceived</code></li>
    /// <li><code>FeedbackReceivedDescending</code></li>
    /// <li><code>Title</code></li>
    /// <li><code>TitleDescending</code></li>
    /// <li><code>UserID</code></li>
    /// <li><code>UserIDDescending</code></li>
    /// </ul>
    /// Reference the <a href="types/ItemSortTypeCodeType.html">ItemSortTypeCodeType</a> definition for more information on these sort values.
    /// <br />
    /// </param>
    /// <param name="Pagination">
    /// This container can be used if the user only wants to see a subset of order line item results. In this container, the user will specify the number of order line items to return per page of data, and will specify the specific page of data they want to view with each call.
    /// <br /><br />
    /// With the <b>GetItemsAwaitingFeedback</b> call, the maximum allowed value for <b>EntriesPerPage</b> is 200.
    /// </param>
    public PaginatedTransactionArrayType GetItemsAwaitingFeedback(
      ItemSortTypeCodeType Sort,
      PaginationType Pagination)
    {
      this.Sort = Sort;
      this.Pagination = Pagination;
      this.Execute();
      return this.ApiResponse.ItemsAwaitingFeedback;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public PaginatedTransactionArrayType GetItemsAwaitingFeedback(PaginationType Pagination)
    {
      this.Pagination = Pagination;
      this.Execute();
      return this.ItemsAwaitingFeedback;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetItemsAwaitingFeedbackRequestType" /> for this API call.
    /// </summary>
    public GetItemsAwaitingFeedbackRequestType ApiRequest
    {
      get => (GetItemsAwaitingFeedbackRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetItemsAwaitingFeedbackResponseType" /> for this API call.
    /// </summary>
    public GetItemsAwaitingFeedbackResponseType ApiResponse
    {
      get => (GetItemsAwaitingFeedbackResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemsAwaitingFeedbackRequestType.Sort" /> of type <see cref="T:eBay.Service.Core.Soap.ItemSortTypeCodeType" />.
    /// </summary>
    public ItemSortTypeCodeType Sort
    {
      get => this.ApiRequest.Sort;
      set => this.ApiRequest.Sort = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetItemsAwaitingFeedbackRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetItemsAwaitingFeedbackResponseType.ItemsAwaitingFeedback" /> of type <see cref="T:eBay.Service.Core.Soap.PaginatedTransactionArrayType" />.
    /// </summary>
    public PaginatedTransactionArrayType ItemsAwaitingFeedback
    {
      get => this.ApiResponse.ItemsAwaitingFeedback;
    }
  }
}
