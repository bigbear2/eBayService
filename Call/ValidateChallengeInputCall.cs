// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ValidateChallengeInputCall
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
  public class ValidateChallengeInputCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ValidateChallengeInputCall()
    {
      this.ApiRequest = new ValidateChallengeInputRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ValidateChallengeInputCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ValidateChallengeInputRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Validates the user response to a <b class="con">GetChallengeToken</b>
    /// botblock challenge.
    /// </summary>
    /// <param name="ChallengeToken">
    /// Botblock token that was returned by <b>GetChallengeToken</b>.
    /// </param>
    /// <param name="UserInput">
    /// User response to a bot block challenge.
    /// </param>
    /// <param name="KeepTokenValid">
    /// This boolean field is included and set to 'true' if the challenge token should remain valid for up to two minutes.
    /// </param>
    public bool ValidateChallengeInput(
      string ChallengeToken,
      string UserInput,
      bool KeepTokenValid)
    {
      this.ChallengeToken = ChallengeToken;
      this.UserInput = UserInput;
      this.KeepTokenValid = KeepTokenValid;
      this.Execute();
      return this.ApiResponse.ValidToken;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ValidateChallengeInputRequestType" /> for this API call.
    /// </summary>
    public ValidateChallengeInputRequestType ApiRequest
    {
      get => (ValidateChallengeInputRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ValidateChallengeInputResponseType" /> for this API call.
    /// </summary>
    public ValidateChallengeInputResponseType ApiResponse
    {
      get => (ValidateChallengeInputResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateChallengeInputRequestType.ChallengeToken" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ChallengeToken
    {
      get => this.ApiRequest.ChallengeToken;
      set => this.ApiRequest.ChallengeToken = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateChallengeInputRequestType.UserInput" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserInput
    {
      get => this.ApiRequest.UserInput;
      set => this.ApiRequest.UserInput = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateChallengeInputRequestType.KeepTokenValid" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool KeepTokenValid
    {
      get => this.ApiRequest.KeepTokenValid;
      set => this.ApiRequest.KeepTokenValid = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ValidateChallengeInputResponseType.ValidToken" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ValidToken => this.ApiResponse.ValidToken;
  }
}
