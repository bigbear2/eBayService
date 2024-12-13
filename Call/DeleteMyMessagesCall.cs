// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteMyMessagesCall
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
  public class DeleteMyMessagesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteMyMessagesCall() => this.ApiRequest = new DeleteMyMessagesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteMyMessagesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteMyMessagesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>Removes selected messages for a given user.</summary>
    /// <param name="AlertIDList">This field is deprecated.</param>
    /// <param name="MessageIDList">
    /// Contains a list of up to 10 <b>MessageID</b> values.
    /// </param>
    public void DeleteMyMessages(StringCollection AlertIDList, StringCollection MessageIDList)
    {
      this.AlertIDList = AlertIDList;
      this.MessageIDList = MessageIDList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteMyMessagesRequestType" /> for this API call.
    /// </summary>
    public DeleteMyMessagesRequestType ApiRequest
    {
      get => (DeleteMyMessagesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteMyMessagesResponseType" /> for this API call.
    /// </summary>
    public DeleteMyMessagesResponseType ApiResponse
    {
      get => (DeleteMyMessagesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteMyMessagesRequestType.AlertIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection AlertIDList
    {
      get => this.ApiRequest.AlertIDs;
      set => this.ApiRequest.AlertIDs = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteMyMessagesRequestType.MessageIDs" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection MessageIDList
    {
      get => this.ApiRequest.MessageIDs;
      set => this.ApiRequest.MessageIDs = value;
    }
  }
}
