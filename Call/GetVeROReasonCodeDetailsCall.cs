// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetVeROReasonCodeDetailsCall
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
  public class GetVeROReasonCodeDetailsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetVeROReasonCodeDetailsCall()
    {
      this.ApiRequest = new GetVeROReasonCodeDetailsRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetVeROReasonCodeDetailsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetVeROReasonCodeDetailsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves details for VeRO reason codes and their descriptions. You can specify a
    /// reason code ID to get details for a specific reason on the site specified in the
    /// request header. If <strong>ReasonCodeID</strong> is not passed in the request, all reason codes are
    /// returned. Set <strong>ReturnAllSites</strong> to <code>true</code> to retrieve reason codes for all sites.
    /// You must be a member of the Verified Rights Owner (VeRO) Program to use this call.
    /// </summary>
    /// <param name="ReasonCodeID">
    /// Unique identifier for a reason code. If this <strong>ReasonCodeID</strong> field is passed in, only the details related to this <strong>ReasonCodeID</strong> will be returned. If no reason code is specified, all reason codes are returned.
    /// </param>
    /// <param name="ReturnAllSites">
    /// Set to true to retrieve reason codes for all sites. If not specified, reason codes are returned for the site specified in the request header only. If a <strong>ReasonCodeID</strong> value is specified, this parameter is ignored.
    /// </param>
    public VeROSiteDetailTypeCollection GetVeROReasonCodeDetails(
      long ReasonCodeID,
      bool ReturnAllSites)
    {
      this.ReasonCodeID = ReasonCodeID;
      this.ReturnAllSites = ReturnAllSites;
      this.Execute();
      return this.ApiResponse.VeROReasonCodeDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetVeROReasonCodeDetailsRequestType" /> for this API call.
    /// </summary>
    public GetVeROReasonCodeDetailsRequestType ApiRequest
    {
      get => (GetVeROReasonCodeDetailsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetVeROReasonCodeDetailsResponseType" /> for this API call.
    /// </summary>
    public GetVeROReasonCodeDetailsResponseType ApiResponse
    {
      get => (GetVeROReasonCodeDetailsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReasonCodeDetailsRequestType.ReasonCodeID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ReasonCodeID
    {
      get => this.ApiRequest.ReasonCodeID;
      set => this.ApiRequest.ReasonCodeID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReasonCodeDetailsRequestType.ReturnAllSites" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ReturnAllSites
    {
      get => this.ApiRequest.ReturnAllSites;
      set => this.ApiRequest.ReturnAllSites = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReasonCodeDetailsResponseType.VeROReasonCodeDetails" /> of type <see cref="T:eBay.Service.Core.Soap.VeROSiteDetailTypeCollection" />.
    /// </summary>
    public VeROSiteDetailTypeCollection VeROReasonCodeDetailList
    {
      get => this.ApiResponse.VeROReasonCodeDetails;
    }
  }
}
