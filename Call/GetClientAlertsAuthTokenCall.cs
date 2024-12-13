// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetClientAlertsAuthTokenCall
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
  public class GetClientAlertsAuthTokenCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetClientAlertsAuthTokenCall()
    {
      this.ApiRequest = new GetClientAlertsAuthTokenRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetClientAlertsAuthTokenCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetClientAlertsAuthTokenRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetClientAlertsAuthToken</b> call. This call retrieves a Client Alerts token for the user, which is required when the user makes a <b>GetUserAlerts</b> call (Client Alerts API).
    /// </summary>
    public string GetClientAlertsAuthToken()
    {
      this.Execute();
      return this.ApiResponse.ClientAlertsAuthToken;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetClientAlertsAuthTokenRequestType" /> for this API call.
    /// </summary>
    public GetClientAlertsAuthTokenRequestType ApiRequest
    {
      get => (GetClientAlertsAuthTokenRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetClientAlertsAuthTokenResponseType" /> for this API call.
    /// </summary>
    public GetClientAlertsAuthTokenResponseType ApiResponse
    {
      get => (GetClientAlertsAuthTokenResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetClientAlertsAuthTokenResponseType.ClientAlertsAuthToken" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ClientAlertsAuthToken => this.ApiResponse.ClientAlertsAuthToken;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetClientAlertsAuthTokenResponseType.HardExpirationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime HardExpirationTime => this.ApiResponse.HardExpirationTime;
  }
}
