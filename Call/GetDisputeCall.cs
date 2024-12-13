// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetDisputeCall
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
  public class GetDisputeCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetDisputeCall() => this.ApiRequest = new GetDisputeRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetDisputeCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetDisputeRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetDispute</b> call. This call retrieves the details of a seller-initiated dispute. Seller-initiated disputes include mutually-cancelled transactions and unpaid items.
    /// <br /><br />
    /// <span class="tablenote"><strong>Note:</strong>
    /// This call does not support buyer-initiated cases created through eBay's Resolution Center. Buyer-initiated cases include Item Not Received (INR) and escalated Return cases. To retrieve and manage eBay Money Back Guarantee cases, the Case Management calls of the <a href="http://developer.ebay.com/Devzone/post-order/index.html" target="_blank">Post-Order API</a> can be used instead.
    /// </span>
    /// </summary>
    /// <param name="DisputeID">
    /// The unique identifier of an seller-initiated dispute. The caller passes in this value to retrieve detailed information on a specific dispute.
    /// <br /><br />
    /// <span class="tablenote"><strong>Note:</strong>
    /// Buyer-initiated Money Back Guarantee cases are not supported with this call. To retrieve and manage eBay Money Back Guarantee cases, the Case Management calls of the <a href="https://developer.ebay.com/Devzone/post-order/index.html" target="_blank">Post-Order API</a> can be used instead.
    /// </span>
    /// </param>
    public DisputeType GetDispute(string DisputeID)
    {
      this.DisputeID = DisputeID;
      this.Execute();
      return this.ApiResponse.Dispute;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetDisputeRequestType" /> for this API call.
    /// </summary>
    public GetDisputeRequestType ApiRequest
    {
      get => (GetDisputeRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetDisputeResponseType" /> for this API call.
    /// </summary>
    public GetDisputeResponseType ApiResponse => (GetDisputeResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetDisputeRequestType.DisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DisputeID
    {
      get => this.ApiRequest.DisputeID;
      set => this.ApiRequest.DisputeID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetDisputeResponseType.Dispute" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeType" />.
    /// </summary>
    public DisputeType Dispute => this.ApiResponse.Dispute;
  }
}
