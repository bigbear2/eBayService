// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddMemberMessagesAAQToBidderCall
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
  public class AddMemberMessagesAAQToBidderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddMemberMessagesAAQToBidderCall()
    {
      this.ApiRequest = new AddMemberMessagesAAQToBidderRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddMemberMessagesAAQToBidderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddMemberMessagesAAQToBidderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request of the <b>AddMemberMessagesAAQToBidder</b> call, which allows a seller to send up to 10 messages to bidders/potential buyers regarding an active listing. These potential buyers may include those who have made a Best Offer on a listing.
    /// </summary>
    /// <param name="AddMemberMessagesAAQToBidderRequestContainerList">
    /// An <b>AddMemberMessagesAAQToBidderRequestContainer</b> container is required for each message being sent to unique bidders/potential buyers.  A seller can send up to 10 messages to unique bidders/potential buyers in one <b>AddMemberMessagesAAQToBidder</b> call.
    /// </param>
    public AddMemberMessagesAAQToBidderResponseContainerTypeCollection AddMemberMessagesAAQToBidder(
      AddMemberMessagesAAQToBidderRequestContainerTypeCollection AddMemberMessagesAAQToBidderRequestContainerList)
    {
      this.AddMemberMessagesAAQToBidderRequestContainerList = AddMemberMessagesAAQToBidderRequestContainerList;
      this.Execute();
      return this.ApiResponse.AddMemberMessagesAAQToBidderResponseContainer;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderRequestType" /> for this API call.
    /// </summary>
    public AddMemberMessagesAAQToBidderRequestType ApiRequest
    {
      get => (AddMemberMessagesAAQToBidderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderResponseType" /> for this API call.
    /// </summary>
    public AddMemberMessagesAAQToBidderResponseType ApiResponse
    {
      get => (AddMemberMessagesAAQToBidderResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderRequestType.AddMemberMessagesAAQToBidderRequestContainer" /> of type <see cref="T:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderRequestContainerTypeCollection" />.
    /// </summary>
    public AddMemberMessagesAAQToBidderRequestContainerTypeCollection AddMemberMessagesAAQToBidderRequestContainerList
    {
      get => this.ApiRequest.AddMemberMessagesAAQToBidderRequestContainer;
      set => this.ApiRequest.AddMemberMessagesAAQToBidderRequestContainer = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderResponseType.AddMemberMessagesAAQToBidderResponseContainer" /> of type <see cref="T:eBay.Service.Core.Soap.AddMemberMessagesAAQToBidderResponseContainerTypeCollection" />.
    /// </summary>
    public AddMemberMessagesAAQToBidderResponseContainerTypeCollection AddMemberMessagesAAQToBidderResponseContainerList
    {
      get => this.ApiResponse.AddMemberMessagesAAQToBidderResponseContainer;
    }
  }
}
