// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddMemberMessageAAQToPartnerCall
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
  public class AddMemberMessageAAQToPartnerCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddMemberMessageAAQToPartnerCall()
    {
      this.ApiRequest = new AddMemberMessageAAQToPartnerRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddMemberMessageAAQToPartnerCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddMemberMessageAAQToPartnerRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a buyer and seller in an order relationship to
    /// send messages to each other's My Messages Inboxes.
    /// </summary>
    /// <param name="ItemID">
    /// Unique identifier for the listing that is being discussed between the two order partners.
    /// </param>
    /// <param name="MemberMessage">
    /// This container holds the message, and includes the subject, message body, and other details related to the message.
    /// </param>
    public void AddMemberMessageAAQToPartner(string ItemID, MemberMessageType MemberMessage)
    {
      this.ItemID = ItemID;
      this.MemberMessage = MemberMessage;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessageAAQToPartnerRequestType" /> for this API call.
    /// </summary>
    public AddMemberMessageAAQToPartnerRequestType ApiRequest
    {
      get => (AddMemberMessageAAQToPartnerRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddMemberMessageAAQToPartnerResponseType" /> for this API call.
    /// </summary>
    public AddMemberMessageAAQToPartnerResponseType ApiResponse
    {
      get => (AddMemberMessageAAQToPartnerResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddMemberMessageAAQToPartnerRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddMemberMessageAAQToPartnerRequestType.MemberMessage" /> of type <see cref="T:eBay.Service.Core.Soap.MemberMessageType" />.
    /// </summary>
    public MemberMessageType MemberMessage
    {
      get => this.ApiRequest.MemberMessage;
      set => this.ApiRequest.MemberMessage = value;
    }
  }
}
