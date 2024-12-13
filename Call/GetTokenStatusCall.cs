// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetTokenStatusCall
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
  public class GetTokenStatusCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetTokenStatusCall() => this.ApiRequest = new GetTokenStatusRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetTokenStatusCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetTokenStatusRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to get the current status of a user token. There are no call-specific fields in the request payload.
    /// </summary>
    public TokenStatusType GetTokenStatus()
    {
      this.Execute();
      return this.ApiResponse.TokenStatus;
    }

    /// <summary>
    /// Constructs a security header from values in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" />.
    /// </summary>
    /// <returns>Security information of type <see cref="T:eBay.Service.Core.Soap.CustomSecurityHeaderType" />.</returns>
    protected override CustomSecurityHeaderType GetSecurityHeader()
    {
      CustomSecurityHeaderType securityHeader = new CustomSecurityHeaderType();
      if (this.ApiContext.ApiCredential.eBayToken == null || this.ApiContext.ApiCredential.eBayToken.Length <= 0)
        throw new SdkException("GetTokenStatus needs a valid, active auth token to be called!");
      securityHeader.eBayAuthToken = this.ApiContext.ApiCredential.eBayToken;
      if (this.ApiContext.ApiCredential.ApiAccount == null)
        throw new SdkException("GetTokenStatus needs the full set of developer credentials to be called!");
      securityHeader.Credentials = new UserIdPasswordType();
      securityHeader.Credentials.AppId = this.ApiContext.ApiCredential.ApiAccount.Application;
      securityHeader.Credentials.DevId = this.ApiContext.ApiCredential.ApiAccount.Developer;
      securityHeader.Credentials.AuthCert = this.ApiContext.ApiCredential.ApiAccount.Certificate;
      return securityHeader;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetTokenStatusRequestType" /> for this API call.
    /// </summary>
    public GetTokenStatusRequestType ApiRequest
    {
      get => (GetTokenStatusRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetTokenStatusResponseType" /> for this API call.
    /// </summary>
    public GetTokenStatusResponseType ApiResponse
    {
      get => (GetTokenStatusResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetTokenStatusResponseType.TokenStatus" /> of type <see cref="T:eBay.Service.Core.Soap.TokenStatusType" />.
    /// </summary>
    public TokenStatusType TokenStatus => this.ApiResponse.TokenStatus;
  }
}
