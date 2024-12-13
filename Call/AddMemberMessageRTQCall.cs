// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddMemberMessageRTQCall
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
  public class AddMemberMessageRTQCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddMemberMessageRTQCall() => this.ApiRequest = new AddMemberMessageRTQRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddMemberMessageRTQCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddMemberMessageRTQRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request of the <b>AddMemberMessageRTQ</b> call that enables a seller to reply to a question about an active item listing.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of the listing about which the question was asked. This field is not required if the request includes a <b>RecipientID</b> value in the <b>MemberMessage</b> container, and the bidder/potential buyer and seller do not have more than one listing in common between one another.
    /// </param>
    /// <param name="MemberMessage">
    /// This container is used by the seller to answer the question from the bidder/potential buyer. This container includes the recipient ID of the bidder/potential buyer, the message subject, the message body (where the question is answered), and other values related to the message.
    /// </param>
    public void AddMemberMessageRTQ(string ItemID, MemberMessageType MemberMessage)
    {
      this.ItemID = ItemID;
      this.MemberMessage = MemberMessage;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessageRTQRequestType" /> for this API call.
    /// </summary>
    public AddMemberMessageRTQRequestType ApiRequest
    {
      get => (AddMemberMessageRTQRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessageRTQResponseType" /> for this API call.
    /// </summary>
    public AddMemberMessageRTQResponseType ApiResponse
    {
      get => (AddMemberMessageRTQResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddMemberMessageRTQRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddMemberMessageRTQRequestType.MemberMessage" /> of type <see cref="T:eBay.Service.Core.Soap.MemberMessageType" />.
    /// </summary>
    public MemberMessageType MemberMessage
    {
      get => this.ApiRequest.MemberMessage;
      set => this.ApiRequest.MemberMessage = value;
    }
  }
}
