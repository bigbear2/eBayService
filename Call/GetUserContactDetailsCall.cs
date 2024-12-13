// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetUserContactDetailsCall
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
  public class GetUserContactDetailsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetUserContactDetailsCall() => this.ApiRequest = new GetUserContactDetailsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetUserContactDetailsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetUserContactDetailsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve contact information for a specified eBay user, given that a bidding relationship (as either a buyer or seller) exists between the caller and the user.
    /// </summary>
    /// <param name="ItemID">
    /// A unique identifier for the eBay listing that the caller and order partner have in common.
    /// </param>
    /// <param name="ContactID">
    /// An eBay user ID that uniquely identifies a given user for whom the caller is seeking information. Either a seller's or bidder's/buyer's user ID can be specified here, as long as an bidding/order relationship exists between the requester and the user specified by this field. That is, a bidder must be bidding on the seller's active auction item, or a prospective buyer has proposed a Best Offer on a listing.
    /// </param>
    /// <param name="RequesterID">
    /// An eBay user ID that uniquely identifies the person who is making the call. Either a seller's or bidder's/buyer's user ID can be specified here, as long as a bidding/order relationship exists between the requester and the user for whom information is being requested.
    /// </param>
    public string GetUserContactDetails(string ItemID, string ContactID, string RequesterID)
    {
      this.ItemID = ItemID;
      this.ContactID = ContactID;
      this.RequesterID = RequesterID;
      this.Execute();
      return this.ApiResponse.UserID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetUserContactDetailsRequestType" /> for this API call.
    /// </summary>
    public GetUserContactDetailsRequestType ApiRequest
    {
      get => (GetUserContactDetailsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetUserContactDetailsResponseType" /> for this API call.
    /// </summary>
    public GetUserContactDetailsResponseType ApiResponse
    {
      get => (GetUserContactDetailsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsRequestType.ContactID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ContactID
    {
      get => this.ApiRequest.ContactID;
      set => this.ApiRequest.ContactID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsRequestType.RequesterID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RequesterID
    {
      get => this.ApiRequest.RequesterID;
      set => this.ApiRequest.RequesterID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsResponseType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID => this.ApiResponse.UserID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsResponseType.ContactAddress" /> of type <see cref="T:eBay.Service.Core.Soap.AddressType" />.
    /// </summary>
    public AddressType ContactAddress => this.ApiResponse.ContactAddress;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserContactDetailsResponseType.RegistrationDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime RegistrationDate => this.ApiResponse.RegistrationDate;
  }
}
