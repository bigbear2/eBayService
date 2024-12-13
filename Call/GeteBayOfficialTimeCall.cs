// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GeteBayOfficialTimeCall
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
  public class GeteBayOfficialTimeCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GeteBayOfficialTimeCall() => this.ApiRequest = new GeteBayOfficialTimeRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GeteBayOfficialTimeCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GeteBayOfficialTimeRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>Gets the official eBay system time in GMT.</summary>
    public DateTime GeteBayOfficialTime()
    {
      this.Execute();
      return this.ApiResponse.Timestamp;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GeteBayOfficialTimeRequestType" /> for this API call.
    /// </summary>
    public GeteBayOfficialTimeRequestType ApiRequest
    {
      get => (GeteBayOfficialTimeRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GeteBayOfficialTimeResponseType" /> for this API call.
    /// </summary>
    public GeteBayOfficialTimeResponseType ApiResponse
    {
      get => (GeteBayOfficialTimeResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the <see cref="P:eBay.Service.Core.Soap.AbstractResponseType.Timestamp" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EBayTime => this.ApiResponse.Timestamp;
  }
}
