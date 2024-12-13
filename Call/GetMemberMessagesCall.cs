// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMemberMessagesCall
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
  public class GetMemberMessagesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMemberMessagesCall() => this.ApiRequest = new GetMemberMessagesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMemberMessagesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMemberMessagesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves a list of the messages buyers have posted about your
    /// active item listings.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of the eBay listing for which you wish to retrieve member messages.
    /// 
    /// For <em>Ask Seller Question</em> messages, the <b>ItemID</b> and/or a date range
    /// (specified with <b>StartCreationTime</b> and <b>EndCreationTime</b> fields),
    /// are required, or the call will fail.
    /// </param>
    /// <param name="MailMessageType">
    /// This required field indicates the type of member message to retrieve. Only the following two enumeration values are allowed. The call will fail if this field is not included in the request.
    /// </param>
    /// <param name="MessageStatus">
    /// This field allows you to retrieve only unanswered member messages or answered member messages. If this field is omitted, both answered and unanswered member messages are retrieved.
    /// </param>
    /// <param name="DisplayToPublic">
    /// If included in the request and set to <code>true</code>, only public messages (viewable in the Item listing) are returned. If omitted or set to <code>false</code> in the request, all messages (that match other filters in the request) are returned in the response.
    /// </param>
    /// <param name="StartCreationTime">
    /// Used as beginning of date range filter. If specified, filters the returned messages to only those with a creation date greater than or equal to the specified date and time.
    /// 
    /// For Contact eBay Member (CEM) messages, <b>StartCreationTime</b> and <b>EndCreationTime</b> must be provided.
    /// 
    /// For Ask Seller a Question (ASQ) messages, either the <b>ItemID</b>, or a date range (specified with <b>StartCreationTime</b> and <b>EndCreationTime</b>), or both must be included.
    /// </param>
    /// <param name="EndCreationTime">
    /// Used as end of date range filter. If specified, filters
    /// the returned messages to only those with a creation date
    /// less than or equal to the specified date and time.
    /// 
    /// For Contact eBay Member (CEM) messages, <b>StartCreationTime</b> and <b>EndCreationTime</b>
    /// must be provided.
    /// 
    /// For Ask Seller a Question (ASQ) messages, either the <b>ItemID</b>, or a date range
    /// (specified with <b>StartCreationTime</b> and <b>EndCreationTime</b>),
    /// or both must be included.
    /// </param>
    /// <param name="Pagination">
    /// Standard pagination argument used to reduce response.
    /// </param>
    /// <param name="MemberMessageID">
    /// An ID that uniquely identifies the message for a given user to be retrieved. Used for the <b>AskSellerQuestion</b> notification only.
    /// </param>
    /// <param name="SenderID">
    /// An eBay ID that uniquely identifies a user. For <b>GetMemberMessages</b>, this is the sender of the message. If included in the request, returns only messages from the specified sender.
    /// </param>
    public MemberMessageExchangeTypeCollection GetMemberMessages(
      string ItemID,
      MessageTypeCodeType MailMessageType,
      MessageStatusTypeCodeType MessageStatus,
      bool DisplayToPublic,
      DateTime StartCreationTime,
      DateTime EndCreationTime,
      PaginationType Pagination,
      string MemberMessageID,
      string SenderID)
    {
      this.ItemID = ItemID;
      this.MailMessageType = MailMessageType;
      this.MessageStatus = MessageStatus;
      this.DisplayToPublic = DisplayToPublic;
      this.StartCreationTime = StartCreationTime;
      this.EndCreationTime = EndCreationTime;
      this.Pagination = Pagination;
      this.MemberMessageID = MemberMessageID;
      this.SenderID = SenderID;
      this.Execute();
      return this.ApiResponse.MemberMessage;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public MemberMessageExchangeTypeCollection GetMemberMessages(
      string ItemID,
      MessageTypeCodeType MailMessageType,
      MessageStatusTypeCodeType MessageStatus)
    {
      this.ItemID = ItemID;
      this.MailMessageType = MailMessageType;
      this.MessageStatus = MessageStatus;
      this.Execute();
      return this.MemberMessageList;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public MemberMessageExchangeTypeCollection GetMemberMessages(
      TimeFilter CreateTimeFilter,
      MessageTypeCodeType MailMessageType,
      MessageStatusTypeCodeType MessageStatus)
    {
      this.CreateTimeFilter = CreateTimeFilter;
      this.MailMessageType = MailMessageType;
      this.MessageStatus = MessageStatus;
      this.Execute();
      return this.MemberMessageList;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public MemberMessageExchangeTypeCollection GetMemberMessages(
      DateTime TimeFrom,
      DateTime TimeTo,
      MessageTypeCodeType MailMessageType,
      MessageStatusTypeCodeType MessageStatus)
    {
      this.CreateTimeFilter = new TimeFilter(TimeFrom, TimeTo);
      this.MailMessageType = MailMessageType;
      this.MessageStatus = MessageStatus;
      this.Execute();
      return this.MemberMessageList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMemberMessagesRequestType" /> for this API call.
    /// </summary>
    public GetMemberMessagesRequestType ApiRequest
    {
      get => (GetMemberMessagesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMemberMessagesResponseType" /> for this API call.
    /// </summary>
    public GetMemberMessagesResponseType ApiResponse
    {
      get => (GetMemberMessagesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.MailMessageType" /> of type <see cref="T:eBay.Service.Core.Soap.MessageTypeCodeType" />.
    /// </summary>
    public MessageTypeCodeType MailMessageType
    {
      get => this.ApiRequest.MailMessageType;
      set => this.ApiRequest.MailMessageType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.MessageStatus" /> of type <see cref="T:eBay.Service.Core.Soap.MessageStatusTypeCodeType" />.
    /// </summary>
    public MessageStatusTypeCodeType MessageStatus
    {
      get => this.ApiRequest.MessageStatus;
      set => this.ApiRequest.MessageStatus = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.DisplayToPublic" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DisplayToPublic
    {
      get => this.ApiRequest.DisplayToPublic;
      set => this.ApiRequest.DisplayToPublic = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.StartCreationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartCreationTime
    {
      get => this.ApiRequest.StartCreationTime;
      set => this.ApiRequest.StartCreationTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.EndCreationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndCreationTime
    {
      get => this.ApiRequest.EndCreationTime;
      set => this.ApiRequest.EndCreationTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.MemberMessageID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string MemberMessageID
    {
      get => this.ApiRequest.MemberMessageID;
      set => this.ApiRequest.MemberMessageID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.SenderID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SenderID
    {
      get => this.ApiRequest.SenderID;
      set => this.ApiRequest.SenderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.StartCreationTime" /> and <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesRequestType.EndCreationTime" /> of type <see cref="T:eBay.Service.Core.Soap.TimeFilter" />.
    /// </summary>
    public TimeFilter CreateTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.StartCreationTime, this.ApiRequest.EndCreationTime);
      set
      {
        if (value.TimeFrom > DateTime.MinValue)
          this.ApiRequest.StartCreationTime = value.TimeFrom;
        if (!(value.TimeTo > DateTime.MinValue))
          return;
        this.ApiRequest.EndCreationTime = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesResponseType.MemberMessage" /> of type <see cref="T:eBay.Service.Core.Soap.MemberMessageExchangeTypeCollection" />.
    /// </summary>
    public MemberMessageExchangeTypeCollection MemberMessageList => this.ApiResponse.MemberMessage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMemberMessagesResponseType.HasMoreItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreItems => this.ApiResponse.HasMoreItems;
  }
}
