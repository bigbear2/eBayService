// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ValidateTestUserRegistrationCall
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
  public class ValidateTestUserRegistrationCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ValidateTestUserRegistrationCall()
    {
      this.ApiRequest = new ValidateTestUserRegistrationRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ValidateTestUserRegistrationCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ValidateTestUserRegistrationRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Requests to enable a test user to sell items in the Sandbox environment.
    /// </summary>
    /// <param name="FeedbackScore">
    /// Value for the feedback score of a user. If no value is passed in the request,
    /// or if the value is zero, the feedback score is unchanged. This element is not intended
    /// for regularly testing feedback because the feedback value can change after the request.
    /// </param>
    /// <param name="RegistrationDate">
    /// Value for the date and time that a user's registration begins.
    /// </param>
    /// <param name="SubscribeSA">
    /// This field is no longer applicable since the Seller Assistant feature is no longer available.
    /// </param>
    /// <param name="SubscribeSAPro">
    /// This field is no longer applicable since the Seller Assistant Pro feature is no longer available.
    /// </param>
    /// <param name="SubscribeSM">
    /// Indicates if a user subscribes to Selling Manager. You cannot
    /// request to subscribe a user to both Selling Manager and
    /// Selling Manager Pro. You cannot request to unsubscribe a user.
    /// </param>
    /// <param name="SubscribeSMPro">
    /// Indicates if a user subscribes to Selling Manager Pro. You cannot
    /// request to subscribe a user to both Selling Manager and
    /// Selling Manager Pro. You cannot request to unsubscribe a user.
    /// </param>
    public void ValidateTestUserRegistration(
      int FeedbackScore,
      DateTime RegistrationDate,
      bool SubscribeSA,
      bool SubscribeSAPro,
      bool SubscribeSM,
      bool SubscribeSMPro)
    {
      this.FeedbackScore = FeedbackScore;
      this.RegistrationDate = RegistrationDate;
      this.SubscribeSA = SubscribeSA;
      this.SubscribeSAPro = SubscribeSAPro;
      this.SubscribeSM = SubscribeSM;
      this.SubscribeSMPro = SubscribeSMPro;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void ValidateTestUserRegistration() => this.Execute();

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType" /> for this API call.
    /// </summary>
    public ValidateTestUserRegistrationRequestType ApiRequest
    {
      get => (ValidateTestUserRegistrationRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ValidateTestUserRegistrationResponseType" /> for this API call.
    /// </summary>
    public ValidateTestUserRegistrationResponseType ApiResponse
    {
      get => (ValidateTestUserRegistrationResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.FeedbackScore" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int FeedbackScore
    {
      get => this.ApiRequest.FeedbackScore;
      set => this.ApiRequest.FeedbackScore = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.RegistrationDate" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime RegistrationDate
    {
      get => this.ApiRequest.RegistrationDate;
      set => this.ApiRequest.RegistrationDate = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.SubscribeSA" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SubscribeSA
    {
      get => this.ApiRequest.SubscribeSA;
      set => this.ApiRequest.SubscribeSA = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.SubscribeSAPro" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SubscribeSAPro
    {
      get => this.ApiRequest.SubscribeSAPro;
      set => this.ApiRequest.SubscribeSAPro = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.SubscribeSM" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SubscribeSM
    {
      get => this.ApiRequest.SubscribeSM;
      set => this.ApiRequest.SubscribeSM = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ValidateTestUserRegistrationRequestType.SubscribeSMPro" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool SubscribeSMPro
    {
      get => this.ApiRequest.SubscribeSMPro;
      set => this.ApiRequest.SubscribeSMPro = value;
    }
  }
}
