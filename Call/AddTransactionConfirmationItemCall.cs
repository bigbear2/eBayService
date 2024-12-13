// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddTransactionConfirmationItemCall
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
  public class AddTransactionConfirmationItemCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddTransactionConfirmationItemCall()
    {
      this.ApiRequest = new AddTransactionConfirmationItemRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddTransactionConfirmationItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddTransactionConfirmationItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Base request of the <b>AddTransactionConfirmationItem</b> call, which is used to end an eBay Motors listing and creates a new Transaction Confirmation Request (TCR) for the motor vehichle, thus enabling the TCR recipient to purchase the item. You can also use this call to see if a new TCR can be created for the specified item.
    /// </summary>
    /// <param name="RecipientUserID">
    /// This field is used to specify the recipient of the Transaction
    /// Confirmation Request (TCR).
    /// </param>
    /// <param name="VerifyEligibilityOnly">
    /// This field is included and set to <code>true</code> if the seller wants to verify whether or not a new Transaction
    /// Confirmation Request (TCR) can be created for the item. If this field is included and its value set to <code>true</code>, no TCR is actually created. If this field is included and its value set to <code>false</code>, or if it is omitted, a Transaction
    /// Confirmation Request is actually created.
    /// </param>
    /// <param name="RecipientPostalCode">
    /// This field is used to specify the postal code of the user to whom the seller is offering the Transaction Confirmation Request. This field is only required if the user does not meet the other options listed in <b>RecipientRelationCodeType</b>.
    /// </param>
    /// <param name="RecipientRelationType">
    /// The enumeration value supplied in this field specifies the current relationship between the seller and the potential buyer. A Transaction Confirmation Request (TCR) for an item can be sent to a potential buyer who has at least one of the following criteria: is an active bidder on the auction listing; has made a Best Offer on the fixed-price listing, is an eBay user who has used the Ask Seller a Question feature, or is an eBay user whose postal code is known.
    /// </param>
    /// <param name="NegotiatedPrice">
    /// The amount in this field is the price that the seller is asking for to purchase the motor vehicle.
    /// </param>
    /// <param name="ListingDuration">
    /// The enumeration value specified in this field will control how many days that the recipient of the offer has to purchase the motor vehicle at the price listed in the <b>NegotiatedPrice</b> field.
    /// </param>
    /// <param name="ItemID">
    /// This field is used to identify the eBay Motors listing using the unique identifier of the listing (<b>ItemID</b>).
    /// </param>
    /// <param name="Comments">
    /// This is optional free-form string field that can be used by the seller to provide any comments or additional information about the Transaction Confirmation Item.
    /// </param>
    public string AddTransactionConfirmationItem(
      string RecipientUserID,
      string VerifyEligibilityOnly,
      string RecipientPostalCode,
      RecipientRelationCodeType RecipientRelationType,
      AmountType NegotiatedPrice,
      SecondChanceOfferDurationCodeType ListingDuration,
      string ItemID,
      string Comments)
    {
      this.RecipientUserID = RecipientUserID;
      this.VerifyEligibilityOnly = VerifyEligibilityOnly;
      this.RecipientPostalCode = RecipientPostalCode;
      this.RecipientRelationType = RecipientRelationType;
      this.NegotiatedPrice = NegotiatedPrice;
      this.ListingDuration = ListingDuration;
      this.ItemID = ItemID;
      this.Comments = Comments;
      this.Execute();
      return this.ApiResponse.ItemID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType" /> for this API call.
    /// </summary>
    public AddTransactionConfirmationItemRequestType ApiRequest
    {
      get => (AddTransactionConfirmationItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddTransactionConfirmationItemResponseType" /> for this API call.
    /// </summary>
    public AddTransactionConfirmationItemResponseType ApiResponse
    {
      get => (AddTransactionConfirmationItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.RecipientUserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RecipientUserID
    {
      get => this.ApiRequest.RecipientUserID;
      set => this.ApiRequest.RecipientUserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.VerifyEligibilityOnly" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string VerifyEligibilityOnly
    {
      get => this.ApiRequest.VerifyEligibilityOnly;
      set => this.ApiRequest.VerifyEligibilityOnly = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.RecipientPostalCode" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RecipientPostalCode
    {
      get => this.ApiRequest.RecipientPostalCode;
      set => this.ApiRequest.RecipientPostalCode = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.RecipientRelationType" /> of type <see cref="T:eBay.Service.Core.Soap.RecipientRelationCodeType" />.
    /// </summary>
    public RecipientRelationCodeType RecipientRelationType
    {
      get => this.ApiRequest.RecipientRelationType;
      set => this.ApiRequest.RecipientRelationType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.NegotiatedPrice" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType NegotiatedPrice
    {
      get => this.ApiRequest.NegotiatedPrice;
      set => this.ApiRequest.NegotiatedPrice = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.ListingDuration" /> of type <see cref="T:eBay.Service.Core.Soap.SecondChanceOfferDurationCodeType" />.
    /// </summary>
    public SecondChanceOfferDurationCodeType ListingDuration
    {
      get => this.ApiRequest.ListingDuration;
      set => this.ApiRequest.ListingDuration = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType.Comments" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Comments
    {
      get => this.ApiRequest.Comments;
      set => this.ApiRequest.Comments = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemIDResult => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddTransactionConfirmationItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;
  }
}
