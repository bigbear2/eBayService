// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetChallengeTokenCall
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
  public class GetChallengeTokenCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetChallengeTokenCall() => this.ApiRequest = new GetChallengeTokenRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetChallengeTokenCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetChallengeTokenRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type for the <b>GetChallengeToken</b> call. This call retrieves a botblock token and URLs for an image or audio clip that the user is to match.
    /// <br /><br />
    /// This call does not have any call-specific input parameters.
    /// </summary>
    public string GetChallengeToken()
    {
      this.Execute();
      return this.ApiResponse.ChallengeToken;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetChallengeTokenRequestType" /> for this API call.
    /// </summary>
    public GetChallengeTokenRequestType ApiRequest
    {
      get => (GetChallengeTokenRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetChallengeTokenResponseType" /> for this API call.
    /// </summary>
    public GetChallengeTokenResponseType ApiResponse
    {
      get => (GetChallengeTokenResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetChallengeTokenResponseType.ChallengeToken" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ChallengeToken => this.ApiResponse.ChallengeToken;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetChallengeTokenResponseType.ImageChallengeURL" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ImageChallengeURL => this.ApiResponse.ImageChallengeURL;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetChallengeTokenResponseType.AudioChallengeURL" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string AudioChallengeURL => this.ApiResponse.AudioChallengeURL;
  }
}
