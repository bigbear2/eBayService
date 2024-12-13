// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetMessagePreferencesCall
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
  public class SetMessagePreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetMessagePreferencesCall() => this.ApiRequest = new SetMessagePreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetMessagePreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetMessagePreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to add custom Ask Seller a Question (ASQ) subjects to their
    /// Ask a Question page, or to reset any custom subjects to their default values.
    /// </summary>
    /// <param name="ASQPreferences">
    /// This container can be used to set customized ASQ subjects, or it can be used to reset the ASQ subjects to the eBay defaults. Up to nine customized ASQ subjects can be set.
    /// </param>
    public void SetMessagePreferences(ASQPreferencesType ASQPreferences)
    {
      this.ASQPreferences = ASQPreferences;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetMessagePreferencesRequestType" /> for this API call.
    /// </summary>
    public SetMessagePreferencesRequestType ApiRequest
    {
      get => (SetMessagePreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetMessagePreferencesResponseType" /> for this API call.
    /// </summary>
    public SetMessagePreferencesResponseType ApiResponse
    {
      get => (SetMessagePreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetMessagePreferencesRequestType.ASQPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.ASQPreferencesType" />.
    /// </summary>
    public ASQPreferencesType ASQPreferences
    {
      get => this.ApiRequest.ASQPreferences;
      set => this.ApiRequest.ASQPreferences = value;
    }
  }
}
