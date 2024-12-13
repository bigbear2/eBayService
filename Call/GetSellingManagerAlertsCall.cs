// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerAlertsCall
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
  public class GetSellingManagerAlertsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerAlertsCall()
    {
      this.ApiRequest = new GetSellingManagerAlertsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerAlertsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerAlertsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves Selling Manager alerts.
    /// This call is subject to change without notice; the deprecation process is
    /// inapplicable to this call.
    /// </summary>
    public SellingManagerAlertTypeCollection GetSellingManagerAlerts()
    {
      this.Execute();
      return this.ApiResponse.Alert;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerAlertsRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerAlertsRequestType ApiRequest
    {
      get => (GetSellingManagerAlertsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerAlertsResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerAlertsResponseType ApiResponse
    {
      get => (GetSellingManagerAlertsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerAlertsResponseType.Alert" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAlertTypeCollection" />.
    /// </summary>
    public SellingManagerAlertTypeCollection AlertList => this.ApiResponse.Alert;
  }
}
