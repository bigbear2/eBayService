// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ConfirmIdentityCall
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
  public class ConfirmIdentityCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ConfirmIdentityCall() => this.ApiRequest = new ConfirmIdentityRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ConfirmIdentityCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ConfirmIdentityRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Returns the ID of a user who has gone through an application's consent flow
    /// process for obtaining an authorization token.
    /// </summary>
    /// <param name="SessionID">
    /// A string obtained by making a <b>GetSessionID</b> call, passed in redirect URL to the eBay signin page.
    /// </param>
    public string ConfirmIdentity(string SessionID)
    {
      this.SessionID = SessionID;
      this.Execute();
      return this.ApiResponse.UserID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ConfirmIdentityRequestType" /> for this API call.
    /// </summary>
    public ConfirmIdentityRequestType ApiRequest
    {
      get => (ConfirmIdentityRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ConfirmIdentityResponseType" /> for this API call.
    /// </summary>
    public ConfirmIdentityResponseType ApiResponse
    {
      get => (ConfirmIdentityResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ConfirmIdentityRequestType.SessionID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SessionID
    {
      get => this.ApiRequest.SessionID;
      set => this.ApiRequest.SessionID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ConfirmIdentityResponseType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID => this.ApiResponse.UserID;
  }
}
