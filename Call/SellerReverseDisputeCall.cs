// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SellerReverseDisputeCall
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
  public class SellerReverseDisputeCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SellerReverseDisputeCall() => this.ApiRequest = new SellerReverseDisputeRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SellerReverseDisputeCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SellerReverseDisputeRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to "reverse" an Unpaid Item dispute that has been closed in case the buyer and seller are able to reach a mutual agreement. If this action is successful, the seller receives a Final Value Fee
    /// credit and the buyer's Unpaid Item strike are both reversed, if applicable.
    /// The dispute might have resulted
    /// in a strike to the buyer and a Final Value Fee credit to the seller. A buyer and
    /// seller sometimes come to agreement after a dispute has been closed. In particular,
    /// the seller might discover that the buyer actually paid, or the buyer might agree
    /// to pay the seller's fees in exchange for having the strike removed.
    /// 
    /// A dispute can only be reversed if it was closed with <b>DisputeActivity</b> set to
    /// <b>SellerEndCommunication</b>, <b>CameToAgreementNeedFVFCredit</b>, or
    /// <b>MutualAgreementOrNoBuyerResponse</b>.
    /// </summary>
    /// <param name="DisputeID">
    /// The unique identifier of the dispute that was returned when the dispute was created.
    /// The dispute must be an Unpaid Item dispute that the seller opened.
    /// </param>
    /// <param name="DisputeResolutionReason">
    /// The reason the dispute is being reversed.
    /// </param>
    public void SellerReverseDispute(
      string DisputeID,
      DisputeResolutionReasonCodeType DisputeResolutionReason)
    {
      this.DisputeID = DisputeID;
      this.DisputeResolutionReason = DisputeResolutionReason;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SellerReverseDisputeRequestType" /> for this API call.
    /// </summary>
    public SellerReverseDisputeRequestType ApiRequest
    {
      get => (SellerReverseDisputeRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SellerReverseDisputeResponseType" /> for this API call.
    /// </summary>
    public SellerReverseDisputeResponseType ApiResponse
    {
      get => (SellerReverseDisputeResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SellerReverseDisputeRequestType.DisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DisputeID
    {
      get => this.ApiRequest.DisputeID;
      set => this.ApiRequest.DisputeID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SellerReverseDisputeRequestType.DisputeResolutionReason" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeResolutionReasonCodeType" />.
    /// </summary>
    public DisputeResolutionReasonCodeType DisputeResolutionReason
    {
      get => this.ApiRequest.DisputeResolutionReason;
      set => this.ApiRequest.DisputeResolutionReason = value;
    }
  }
}
