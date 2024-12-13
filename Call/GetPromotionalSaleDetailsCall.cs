// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetPromotionalSaleDetailsCall
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
  public class GetPromotionalSaleDetailsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetPromotionalSaleDetailsCall()
    {
      this.ApiRequest = new GetPromotionalSaleDetailsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetPromotionalSaleDetailsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetPromotionalSaleDetailsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type for the <b>GetPromotionalSaleDetails</b> call. This call retrieves information about promotional sales set up by an eBay store owner. The eBay store owner has the option to retrieve all promotional sales, a specific promotional sale, or promotional sales in a specific state.
    /// </summary>
    /// <param name="PromotionalSaleID">
    /// The unique identifier of the promotional sale to retrieve. This field is used if the eBay store owner only wants to retrieve a specific promotional sale. Any <b>PromotionalSaleStatus</b> fields that are included will be ignored if the <b>PromotionalSaleID</b> field is used.
    /// 
    /// If neither the <b>PromotionalSaleID</b> nor a <b>PromotionalSaleStatus</b> field is used, then all promotional sales for the eBay store owner are returned.
    /// </param>
    /// <param name="PromotionalSaleStatuList">
    /// One or more <b>PromotionalSaleStatus</b> fields are used if the eBay store owner wants to retrieve promotional sales in a specific state, such as <code>Active</code>, <code>Scheduled</code>, or <code>Deleted</code>. A <b>PromotionalSaleStatus</b> field is included for each status. See <a href="types/PromotionalSaleStatusCodeType.html">PromotionalSaleStatusCodeType</a> for a description of the status values that can be used in this field.
    /// 
    /// If neither the <b>PromotionalSaleID</b> nor a <b>PromotionalSaleStatus</b> field is used, then all promotional sales for the eBay store owner are returned.
    /// </param>
    public PromotionalSaleTypeCollection GetPromotionalSaleDetails(
      long PromotionalSaleID,
      PromotionalSaleStatusCodeTypeCollection PromotionalSaleStatuList)
    {
      this.PromotionalSaleID = PromotionalSaleID;
      this.PromotionalSaleStatuList = PromotionalSaleStatuList;
      this.Execute();
      return this.ApiResponse.PromotionalSaleDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetPromotionalSaleDetailsRequestType" /> for this API call.
    /// </summary>
    public GetPromotionalSaleDetailsRequestType ApiRequest
    {
      get => (GetPromotionalSaleDetailsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetPromotionalSaleDetailsResponseType" /> for this API call.
    /// </summary>
    public GetPromotionalSaleDetailsResponseType ApiResponse
    {
      get => (GetPromotionalSaleDetailsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetPromotionalSaleDetailsRequestType.PromotionalSaleID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long PromotionalSaleID
    {
      get => this.ApiRequest.PromotionalSaleID;
      set => this.ApiRequest.PromotionalSaleID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetPromotionalSaleDetailsRequestType.PromotionalSaleStatus" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalSaleStatusCodeTypeCollection" />.
    /// </summary>
    public PromotionalSaleStatusCodeTypeCollection PromotionalSaleStatuList
    {
      get => this.ApiRequest.PromotionalSaleStatus;
      set => this.ApiRequest.PromotionalSaleStatus = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetPromotionalSaleDetailsResponseType.PromotionalSaleDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalSaleTypeCollection" />.
    /// </summary>
    public PromotionalSaleTypeCollection PromotionalSaleDetailList
    {
      get => this.ApiResponse.PromotionalSaleDetails;
    }
  }
}
