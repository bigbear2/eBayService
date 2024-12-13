// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMyMessagesCall
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
  public class GetMyMessagesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMyMessagesCall() => this.ApiRequest = new GetMyMessagesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMyMessagesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMyMessagesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves information about the messages sent to a given user.
    /// </summary>
    /// <param name="AlertIDList">This container is deprecated.</param>
    /// <param name="MessageIDList">
    /// This container can be used to retrieve one or more specific messages identified with their unique <b>MessageID</b> values. Up to  10 <b>MessageID</b> values can be specified with one call.
    /// </param>
    /// <param name="FolderID">
    /// A unique identifier for a My Messages folder. If a <b>FolderID</b> value is provided,
    /// only messages from the specified folder are returned in the response.
    /// </param>
    /// <param name="StartTime">
    /// The beginning of the date-range filter.
    /// Filtering takes into account the entire timestamp of when messages were sent.
    /// Messages expire after one year.
    /// </param>
    /// <param name="EndTime">
    /// The end of the date-range filter. See StartTime
    /// (which is the beginning of the date-range filter).
    /// </param>
    /// <param name="ExternalMessageIDList">
    /// This field is currently available on the US site. A container for IDs that
    /// uniquely identify messages for a given user. If provided at the time of message
    /// creation, this ID can be used to retrieve messages and will take precedence
    /// over message ID.
    /// </param>
    /// <param name="Pagination">
    /// Specifies how to create virtual pages in the returned list (such as total
    /// number of entries and total number of pages to return).
    /// Default value for <b>EntriesPerPage</b> with <b>GetMyMessages</b> is 25.
    /// </param>
    /// <param name="IncludeHighPriorityMessageOnly">
    /// If this field is included in the request and set to <code>true</code>, only High Priority messages are returned in the response.
    /// </param>
    public MyMessagesSummaryType GetMyMessages(
      StringCollection AlertIDList,
      StringCollection MessageIDList,
      long FolderID,
      DateTime StartTime,
      DateTime EndTime,
      StringCollection ExternalMessageIDList,
      PaginationType Pagination,
      bool IncludeHighPriorityMessageOnly)
    {
      this.AlertIDList = AlertIDList;
      this.MessageIDList = MessageIDList;
      this.FolderID = FolderID;
      this.StartTime = StartTime;
      this.EndTime = EndTime;
      this.ExternalMessageIDList = ExternalMessageIDList;
      this.Pagination = Pagination;
      this.IncludeHighPriorityMessageOnly = IncludeHighPriorityMessageOnly;
      this.Execute();
      return this.ApiResponse.Summary;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void GetMyMessages() => this.Execute();

    /// <summary>
    ///  For backward compatibility with old wrappers.
    /// Used to retrieve information about the messages and alerts sent
    ///  to a given user. Depending on the detail level, this information
    ///  can include message and alert counts, resolution and flagged
    ///  status, message and/or alert headers, and message and/or alert
    ///  body text.
    ///  <br /><br />
    ///  Note that this call requires a DetailLevel in the
    ///  request. Omitting the Detail Level returns an error.
    ///  <br /><br />
    ///  ItemID is not returned with this call. Use GetMemberMessages instead.
    ///  </summary>
    /// <param name="AlertIDList">
    /// Contains a list of up to 10 AlertID values.
    /// When AlertID values are used as input, you must
    /// generally specify either AlertID values, or
    /// MessageID values, or both.
    /// </param>
    /// <param name="MessageIDList">
    /// Contains a list of up to 10 MessageID values.
    /// When MessageID values are used as input, you must
    /// generally specify either AlertID values, or
    /// MessageID values, or both.
    /// </param>
    /// <param name="FolderID">
    /// An ID that uniquely identifies the My Messages folder from which to retrieve alerts or messages.
    /// </param>
    public MyMessagesSummaryType GetMyMessages(
      StringCollection AlertIDList,
      StringCollection MessageIDList,
      long FolderID)
    {
      this.AlertIDList = AlertIDList;
      this.MessageIDList = MessageIDList;
      this.FolderID = FolderID;
      this.Execute();
      return this.ApiResponse.Summary;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMyMessagesRequestType" /> for this API call.
    /// </summary>
    public GetMyMessagesRequestType ApiRequest
    {
      get => (GetMyMessagesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMyMessagesResponseType" /> for this API call.
    /// </summary>
    public GetMyMessagesResponseType ApiResponse
    {
      get => (GetMyMessagesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.AlertIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection AlertIDList
    {
      get => this.ApiRequest.AlertIDs;
      set => this.ApiRequest.AlertIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.MessageIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection MessageIDList
    {
      get => this.ApiRequest.MessageIDs;
      set => this.ApiRequest.MessageIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime
    {
      get => this.ApiRequest.StartTime;
      set => this.ApiRequest.StartTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime
    {
      get => this.ApiRequest.EndTime;
      set => this.ApiRequest.EndTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.ExternalMessageIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection ExternalMessageIDList
    {
      get => this.ApiRequest.ExternalMessageIDs;
      set => this.ApiRequest.ExternalMessageIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyMessagesRequestType.IncludeHighPriorityMessageOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeHighPriorityMessageOnly
    {
      get => this.ApiRequest.IncludeHighPriorityMessageOnly;
      set => this.ApiRequest.IncludeHighPriorityMessageOnly = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyMessagesResponseType.Summary" /> of type <see cref="T:eBay.Service.Core.Soap.MyMessagesSummaryType" />.
    /// </summary>
    public MyMessagesSummaryType Summary => this.ApiResponse.Summary;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyMessagesResponseType.Alerts" /> of type <see cref="T:eBay.Service.Core.Soap.MyMessagesAlertTypeCollection" />.
    /// </summary>
    public MyMessagesAlertTypeCollection AlertList => this.ApiResponse.Alerts;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyMessagesResponseType.Messages" /> of type <see cref="T:eBay.Service.Core.Soap.MyMessagesMessageTypeCollection" />.
    /// </summary>
    public MyMessagesMessageTypeCollection MessageList => this.ApiResponse.Messages;
  }
}
