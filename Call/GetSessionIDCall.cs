// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSessionIDCall
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
  public class GetSessionIDCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSessionIDCall() => this.ApiRequest = new GetSessionIDRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSessionIDCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSessionIDRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves a session ID that identifies a user and your application when you make a <b>FetchToken</b> request.
    /// </summary>
    /// <param name="RuName">
    /// The eBay Registered URL must be specified in this field. An eBay Registered URL is created and associated with a developer's Sandbox or Production key set by logging into the user's developer account on <b>developer.ebay.com</b> and going to the <b>User Tokens</b> page. The <b>RuName</b> value passed in this field must match the one specified for the specific Sandbox or Production key set being used to make the <b>GetSessionID</b> call. For more information on adding and registering your <b class="con">RuName</b>, see the <a href="../../HowTo/Tokens/GettingTokens.html#step1">Setting Up an Application to Receive Tokens</a> tutorial.
    /// </param>
    public string GetSessionID(string RuName)
    {
      this.RuName = RuName;
      this.Execute();
      return this.ApiResponse.SessionID;
    }

    /// <summary>
    /// Request for a SessionID, which is a unique identifier for authenticating data entry during the process that creates a user token.
    /// </summary>
    public string GetSessionID()
    {
      this.Execute();
      return this.ApiResponse.SessionID;
    }

    /// <summary>
    /// Constructs a security header from values in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" />.
    /// </summary>
    /// <returns>Security information of type <see cref="T:eBay.Service.Core.Soap.CustomSecurityHeaderType" />.</returns>
    protected override CustomSecurityHeaderType GetSecurityHeader()
    {
      CustomSecurityHeaderType securityHeader = new CustomSecurityHeaderType();
      if (this.ApiContext.ApiCredential.ApiAccount == null)
        throw new SdkException("GetSessionID needs Api Account to be called!");
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
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSessionIDRequestType" /> for this API call.
    /// </summary>
    public GetSessionIDRequestType ApiRequest
    {
      get => (GetSessionIDRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSessionIDResponseType" /> for this API call.
    /// </summary>
    public GetSessionIDResponseType ApiResponse => (GetSessionIDResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSessionIDRequestType.RuName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RuName
    {
      get => this.ApiRequest.RuName;
      set => this.ApiRequest.RuName = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSessionIDResponseType.SessionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SessionID => this.ApiResponse.SessionID;
  }
}
