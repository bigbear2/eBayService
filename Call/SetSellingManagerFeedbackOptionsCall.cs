// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetSellingManagerFeedbackOptionsCall
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
  public class SetSellingManagerFeedbackOptionsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetSellingManagerFeedbackOptionsCall()
    {
      this.ApiRequest = new SetSellingManagerFeedbackOptionsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetSellingManagerFeedbackOptionsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetSellingManagerFeedbackOptionsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables Selling Manager Pro subscribers to store standard feedback comments that can
    /// be left for their buyers. Selling Manager Pro subscribers can also specify what
    /// events, if any, will trigger an automated feedback response to buyers.
    /// </summary>
    /// <param name="AutomatedLeaveFeedbackEvent">
    /// Specifies the event that will trigger automated feedback to the buyer.
    /// </param>
    /// <param name="StoredCommentList">
    /// Contains a set of comments from which one can be selected to leave
    /// feedback for a buyer. If automated feedback is used, a comment is
    /// selected from the set randomly. Stored comments cannot be replaced or
    /// edited individually. Submitting a stored comments array replaces all
    /// existing stored comments.
    /// 
    /// </param>
    public void SetSellingManagerFeedbackOptions(
      AutomatedLeaveFeedbackEventCodeType AutomatedLeaveFeedbackEvent,
      StringCollection StoredCommentList)
    {
      this.AutomatedLeaveFeedbackEvent = AutomatedLeaveFeedbackEvent;
      this.StoredCommentList = StoredCommentList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerFeedbackOptionsRequestType" /> for this API call.
    /// </summary>
    public SetSellingManagerFeedbackOptionsRequestType ApiRequest
    {
      get => (SetSellingManagerFeedbackOptionsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerFeedbackOptionsResponseType" /> for this API call.
    /// </summary>
    public SetSellingManagerFeedbackOptionsResponseType ApiResponse
    {
      get => (SetSellingManagerFeedbackOptionsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerFeedbackOptionsRequestType.AutomatedLeaveFeedbackEvent" /> of type <see cref="T:eBay.Service.Core.Soap.AutomatedLeaveFeedbackEventCodeType" />.
    /// </summary>
    public AutomatedLeaveFeedbackEventCodeType AutomatedLeaveFeedbackEvent
    {
      get => this.ApiRequest.AutomatedLeaveFeedbackEvent;
      set => this.ApiRequest.AutomatedLeaveFeedbackEvent = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerFeedbackOptionsRequestType.StoredComments" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection StoredCommentList
    {
      get => this.ApiRequest.StoredComments;
      set => this.ApiRequest.StoredComments = value;
    }
  }
}
