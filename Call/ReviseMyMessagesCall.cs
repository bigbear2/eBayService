// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseMyMessagesCall
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
  public class ReviseMyMessagesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseMyMessagesCall() => this.ApiRequest = new ReviseMyMessagesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseMyMessagesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseMyMessagesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call can be used to mark one or more messages as 'Read', to flag one or more messages, and/or to move one or more messages to another My Messages folder. Any of these actions can be applied on up to 10 messages with one call.
    /// </summary>
    /// <param name="MessageIDList">
    /// This container is used to specify up to 10 messages (specified with their  <b>MessageID</b> values) on which to perform on or more actions. At least one <b>MessageID</b> value must be included in the request. <b>MessageID</b> values can be retrieved with the <b>GetMyMessages</b> call with the <b>DetailLevel</b> value set to <code>ReturnHeaders</code>.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> Messages in the Sent folder of My Messages cannot be moved, marked as read, or flagged. </span>
    /// </param>
    /// <param name="AlertIDList">This field is deprecated.</param>
    /// <param name="Read">
    /// This boolean field is used to change the 'Read' status of the message(s) in the <b>MessageIDs</b> container. Including this field and setting its value to <code>true</code> will mark all messages in the <b>MessageIDs</b> container as 'Read'. Conversely, including this field and setting its value to <code>false</code> will mark all messages in the <b>MessageIDs</b> container as 'Unread'. The 'Read' status of a message can be retrieved by looking at the <b>Message.Read</b> boolean field of the <b>GetMyMessages</b> call response.
    /// 
    /// 
    /// In each <b>ReviseMyMessages</b> call, at least one of the following fields must be specified in the request: <b>Read</b>, <b>Flagged</b>, and <b>FolderID</b>.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> Messages in the Sent folder of My Messages cannot be moved, marked as read, or flagged. </span>
    /// </param>
    /// <param name="Flagged">
    /// This boolean field is used to change the 'Flagged' status of the message(s) in the <b>MessageIDs</b> container. Including this field and setting its value to <code>true</code> will flag all messages in the <b>MessageIDs</b> container. Conversely, including this field and setting its value to <code>false</code> will unflag all messages in the <b>MessageIDs</b> container. The 'Flagged' status of a message can be retrieved by looking at the <b>Message.Flagged</b> boolean field of the <b>GetMyMessages</b> call response.
    /// 
    /// 
    /// In each <b>ReviseMyMessages</b> call, at least one of the following fields must be specified in the request: <b>Read</b>, <b>Flagged</b>, and <b>FolderID</b>.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> Messages in the Sent folder of My Messages cannot be moved, marked as read, or flagged. </span>
    /// </param>
    /// <param name="FolderID">
    /// A unique identifier of My Messages folder. A <b>FolderID</b> value is supplied if the user want to move the message(s) in the <b>MessageIDs</b> container to a different folder. <b>FolderID</b> values can be retrieved with the <b>GetMyMessages</b> call with the <b>DetailLevel</b> value set to <code>ReturnSummary</code>.
    /// 
    /// In each <b>ReviseMyMessages</b> call, at least one of the following fields must be specified in the request: <b>Read</b>, <b>Flagged</b>, and <b>FolderID</b>.
    /// 
    /// 
    /// <span class="tablenote"><b>Note:</b> Messages in the Sent folder of My Messages cannot be moved, marked as read, or flagged. </span>
    /// </param>
    public void ReviseMyMessages(
      StringCollection MessageIDList,
      StringCollection AlertIDList,
      bool Read,
      bool Flagged,
      long FolderID)
    {
      this.MessageIDList = MessageIDList;
      this.AlertIDList = AlertIDList;
      this.Read = Read;
      this.Flagged = Flagged;
      this.FolderID = FolderID;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void ReviseMyMessages(bool Read, bool Flagged, StringCollection MessageIDList)
    {
      this.Read = Read;
      this.Flagged = Flagged;
      this.MessageIDList = MessageIDList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseMyMessagesRequestType" /> for this API call.
    /// </summary>
    public ReviseMyMessagesRequestType ApiRequest
    {
      get => (ReviseMyMessagesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseMyMessagesResponseType" /> for this API call.
    /// </summary>
    public ReviseMyMessagesResponseType ApiResponse
    {
      get => (ReviseMyMessagesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseMyMessagesRequestType.MessageIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection MessageIDList
    {
      get => this.ApiRequest.MessageIDs;
      set => this.ApiRequest.MessageIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseMyMessagesRequestType.AlertIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection AlertIDList
    {
      get => this.ApiRequest.AlertIDs;
      set => this.ApiRequest.AlertIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseMyMessagesRequestType.Read" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool Read
    {
      get => this.ApiRequest.Read;
      set => this.ApiRequest.Read = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseMyMessagesRequestType.Flagged" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool Flagged
    {
      get => this.ApiRequest.Flagged;
      set => this.ApiRequest.Flagged = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseMyMessagesRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }
  }
}
