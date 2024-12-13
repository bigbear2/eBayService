// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.FetchTokenCall
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
  public class FetchTokenCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public FetchTokenCall() => this.ApiRequest = new FetchTokenRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public FetchTokenCall(ApiContext ApiContext)
    {
      this.ApiRequest = new FetchTokenRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>Retrieves an authentication token for a user.</summary>
    /// <param name="SecretID">
    /// A value associated with the token retrieval request. SecretID is
    /// defined by the application, and is passed in the redirect URL to the
    /// eBay sign-in page. eBay recommends using a UUID for the secret ID
    /// value. You must also set Username (part of the RequesterCredentials)
    /// for the particular user of interest. SecretID and Username are not
    /// required if SessionID is present.
    /// </param>
    /// <param name="SessionID">
    /// A value associated with the token retrieval request. eBay generates the
    /// session ID when the application makes a GetSessionID request. SessionID
    /// is passed in the redirect URL to the eBay sign-in page. The advantage
    /// of using SessionID is that it does not require UserID as part of the
    /// FetchToken request. SessionID is not required if SecretID is present.
    /// </param>
    public string FetchToken(string SecretID, string SessionID)
    {
      this.SecretID = SecretID;
      this.SessionID = SessionID;
      this.Execute();
      return this.ApiResponse.eBayAuthToken;
    }

    /// <summary>Fetch token using SessionID(new token fetch flow).</summary>
    public string FetchToken(string SessionID)
    {
      this.SessionID = SessionID;
      this.Execute();
      return this.ApiResponse.eBayAuthToken;
    }

    /// <summary>
    /// Constructs a security header from values in <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" />.
    /// </summary>
    /// <returns>Security information of type <see cref="T:eBay.Service.Core.Soap.CustomSecurityHeaderType" />.</returns>
    protected override CustomSecurityHeaderType GetSecurityHeader()
    {
      CustomSecurityHeaderType securityHeader = new CustomSecurityHeaderType();
      if (this.ApiContext.ApiCredential.ApiAccount != null)
      {
        securityHeader.Credentials = new UserIdPasswordType();
        securityHeader.Credentials.AppId = this.ApiContext.ApiCredential.ApiAccount.Application;
        securityHeader.Credentials.DevId = this.ApiContext.ApiCredential.ApiAccount.Developer;
        securityHeader.Credentials.AuthCert = this.ApiContext.ApiCredential.ApiAccount.Certificate;
        if (this.ApiContext.ApiCredential.eBayAccount != null && this.ApiContext.ApiCredential.eBayAccount.UserName != null && this.ApiContext.ApiCredential.eBayAccount.UserName.Length > 0)
          securityHeader.Credentials.Username = this.ApiContext.ApiCredential.eBayAccount.UserName;
      }
      return securityHeader;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.FetchTokenRequestType" /> for this API call.
    /// </summary>
    public FetchTokenRequestType ApiRequest
    {
      get => (FetchTokenRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.FetchTokenResponseType" /> for this API call.
    /// </summary>
    public FetchTokenResponseType ApiResponse => (FetchTokenResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.FetchTokenRequestType.SecretID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SecretID
    {
      get => this.ApiRequest.SecretID;
      set => this.ApiRequest.SecretID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.FetchTokenRequestType.SessionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SessionID
    {
      get => this.ApiRequest.SessionID;
      set => this.ApiRequest.SessionID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.FetchTokenResponseType.eBayAuthToken" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string eBayToken => this.ApiResponse.eBayAuthToken;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.FetchTokenResponseType.HardExpirationTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime HardExpirationTime => this.ApiResponse.HardExpirationTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.FetchTokenResponseType.RESTToken" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string RESTToken => this.ApiResponse.RESTToken;
  }
}
