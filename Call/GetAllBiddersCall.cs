// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetAllBiddersCall
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
  public class GetAllBiddersCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetAllBiddersCall() => this.ApiRequest = new GetAllBiddersRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetAllBiddersCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetAllBiddersRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetAllBidders</b> call, which is used to retrieve bidders from an active or recently-ended auction listing.
    /// </summary>
    /// <param name="ItemID">
    /// This is the unique identifier of the auction listing for which bidders are being retrieved. This auction listing can be active or recently ended. However, to retrieve bidders for an active auction listing, the only <b>CallMode</b> enumeration value that can be used is <code>ViewAll</code>.
    /// </param>
    /// <param name="CallMode">
    /// The enumeration value that is passed into this field will control the set of bidders that will be retrieved in the response. To retrieve bidders from a recently-ended auction listing, any of the three values can be used. To retrieve bidders for an active auction listing, only the <code>ViewAll</code> enumeration value can be used. These values are discussed in <b>GetAllBiddersModeCodeType</b>.
    /// <br />
    /// </param>
    /// <param name="IncludeBiddingSummary">
    /// The user must include this field and set its value to <code>true</code> if the user wishes to retrieve the  <b>BiddingSummary</b> container for each bidder. The <b>BiddingSummary</b> container consists of more detailed bidding information on each bidder.
    /// </param>
    public OfferTypeCollection GetAllBidders(
      string ItemID,
      GetAllBiddersModeCodeType CallMode,
      bool IncludeBiddingSummary)
    {
      this.ItemID = ItemID;
      this.CallMode = CallMode;
      this.IncludeBiddingSummary = IncludeBiddingSummary;
      this.Execute();
      return this.ApiResponse.BidArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public OfferTypeCollection GetAllBidders(string ItemID, GetAllBiddersModeCodeType CallMode)
    {
      this.ItemID = ItemID;
      this.CallMode = CallMode;
      this.Execute();
      return this.ApiResponse.BidArray;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetAllBiddersRequestType" /> for this API call.
    /// </summary>
    public GetAllBiddersRequestType ApiRequest
    {
      get => (GetAllBiddersRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetAllBiddersResponseType" /> for this API call.
    /// </summary>
    public GetAllBiddersResponseType ApiResponse
    {
      get => (GetAllBiddersResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAllBiddersRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAllBiddersRequestType.CallMode" /> of type <see cref="T:eBay.Service.Core.Soap.GetAllBiddersModeCodeType" />.
    /// </summary>
    public GetAllBiddersModeCodeType CallMode
    {
      get => this.ApiRequest.CallMode;
      set => this.ApiRequest.CallMode = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetAllBiddersRequestType.IncludeBiddingSummary" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeBiddingSummary
    {
      get => this.ApiRequest.IncludeBiddingSummary;
      set => this.ApiRequest.IncludeBiddingSummary = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAllBiddersResponseType.BidArray" /> of type <see cref="T:eBay.Service.Core.Soap.OfferTypeCollection" />.
    /// </summary>
    public OfferTypeCollection BidList => this.ApiResponse.BidArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAllBiddersResponseType.HighBidder" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string HighBidder => this.ApiResponse.HighBidder;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAllBiddersResponseType.HighestBid" /> of type <see cref="T:eBay.Service.Core.Soap.AmountType" />.
    /// </summary>
    public AmountType HighestBid => this.ApiResponse.HighestBid;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetAllBiddersResponseType.ListingStatus" /> of type <see cref="T:eBay.Service.Core.Soap.ListingStatusCodeType" />.
    /// </summary>
    public ListingStatusCodeType ListingStatus => this.ApiResponse.ListingStatus;
  }
}
