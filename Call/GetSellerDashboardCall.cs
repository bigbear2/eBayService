// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellerDashboardCall
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
  public class GetSellerDashboardCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellerDashboardCall() => this.ApiRequest = new GetSellerDashboardRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellerDashboardCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellerDashboardRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type for the <b>GetSellerDashboard</b> call. This call retrieves seller performance data, including seller standards level, Power Seller status, Buyer Satisfaction status, eBay Search standing, and any seller fee discounts.
    /// </summary>
    public SearchStandingDashboardType GetSellerDashboard()
    {
      this.Execute();
      return this.ApiResponse.SearchStanding;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellerDashboardRequestType" /> for this API call.
    /// </summary>
    public GetSellerDashboardRequestType ApiRequest
    {
      get => (GetSellerDashboardRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellerDashboardResponseType" /> for this API call.
    /// </summary>
    public GetSellerDashboardResponseType ApiResponse
    {
      get => (GetSellerDashboardResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.SearchStanding" /> of type <see cref="T:eBay.Service.Core.Soap.SearchStandingDashboardType" />.
    /// </summary>
    public SearchStandingDashboardType SearchStanding => this.ApiResponse.SearchStanding;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.SellerFeeDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.SellerFeeDiscountDashboardType" />.
    /// </summary>
    public SellerFeeDiscountDashboardType SellerFeeDiscount => this.ApiResponse.SellerFeeDiscount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.PowerSellerStatus" /> of type <see cref="T:eBay.Service.Core.Soap.PowerSellerDashboardType" />.
    /// </summary>
    public PowerSellerDashboardType PowerSellerStatus => this.ApiResponse.PowerSellerStatus;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.PolicyCompliance" /> of type <see cref="T:eBay.Service.Core.Soap.PolicyComplianceDashboardType" />.
    /// </summary>
    public PolicyComplianceDashboardType PolicyCompliance => this.ApiResponse.PolicyCompliance;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.BuyerSatisfaction" /> of type <see cref="T:eBay.Service.Core.Soap.BuyerSatisfactionDashboardType" />.
    /// </summary>
    public BuyerSatisfactionDashboardType BuyerSatisfaction => this.ApiResponse.BuyerSatisfaction;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.SellerAccount" /> of type <see cref="T:eBay.Service.Core.Soap.SellerAccountDashboardType" />.
    /// </summary>
    public SellerAccountDashboardType SellerAccount => this.ApiResponse.SellerAccount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerDashboardResponseType.Performance" /> of type <see cref="T:eBay.Service.Core.Soap.PerformanceDashboardTypeCollection" />.
    /// </summary>
    public PerformanceDashboardTypeCollection PerformanceList => this.ApiResponse.Performance;
  }
}
