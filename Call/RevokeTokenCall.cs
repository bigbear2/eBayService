// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.RevokeTokenCall
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
  public class RevokeTokenCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public RevokeTokenCall() => this.ApiRequest = new RevokeTokenRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public RevokeTokenCall(ApiContext ApiContext)
    {
      this.ApiRequest = new RevokeTokenRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>Revokes a token before it would otherwise expire.</summary>
    /// <param name="UnsubscribeNotification">
    /// Cancels notification subscriptions for the user/application if set to true. Default value is false.
    /// </param>
    public void RevokeToken(bool UnsubscribeNotification)
    {
      this.UnsubscribeNotification = UnsubscribeNotification;
      this.Execute();
    }

    /// <summary>
    /// Constructs a security header from values in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" />.
    /// </summary>
    /// <returns>Security information of type <see cref="T:eBay.Service.Core.Soap.CustomSecurityHeaderType" />.</returns>
    protected override CustomSecurityHeaderType GetSecurityHeader()
    {
      CustomSecurityHeaderType securityHeader = new CustomSecurityHeaderType();
      if (this.ApiContext.ApiCredential.eBayToken == null || this.ApiContext.ApiCredential.eBayToken.Length <= 0)
        throw new SdkException("RevokeToken needs a valid, active auth token to be called!");
      securityHeader.eBayAuthToken = this.ApiContext.ApiCredential.eBayToken;
      if (this.ApiContext.ApiCredential.ApiAccount == null)
        throw new SdkException("RevokeToken needs the full set of developer credentials to be called!");
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
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.RevokeTokenRequestType" /> for this API call.
    /// </summary>
    public RevokeTokenRequestType ApiRequest
    {
      get => (RevokeTokenRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.RevokeTokenResponseType" /> for this API call.
    /// </summary>
    public RevokeTokenResponseType ApiResponse => (RevokeTokenResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RevokeTokenRequestType.UnsubscribeNotification" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool UnsubscribeNotification
    {
      get => this.ApiRequest.UnsubscribeNotification;
      set => this.ApiRequest.UnsubscribeNotification = value;
    }
  }
}
