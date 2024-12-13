// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetStorePreferencesCall
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
  public class SetStorePreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetStorePreferencesCall() => this.ApiRequest = new SetStorePreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetStorePreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetStorePreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Sets the preferences for a user's eBay Store. Sellers must have an eBay Store subscription in order to use this call.
    /// </summary>
    /// <param name="StorePreferences">
    /// This container is used to set the eBay Store's preferences. Currently, the only applicable eBay Store preferences are Store vacation preferences.
    /// </param>
    public void SetStorePreferences(StorePreferencesType StorePreferences)
    {
      this.StorePreferences = StorePreferences;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetStorePreferencesRequestType" /> for this API call.
    /// </summary>
    public SetStorePreferencesRequestType ApiRequest
    {
      get => (SetStorePreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetStorePreferencesResponseType" /> for this API call.
    /// </summary>
    public SetStorePreferencesResponseType ApiResponse
    {
      get => (SetStorePreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStorePreferencesRequestType.StorePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.StorePreferencesType" />.
    /// </summary>
    public StorePreferencesType StorePreferences
    {
      get => this.ApiRequest.StorePreferences;
      set => this.ApiRequest.StorePreferences = value;
    }
  }
}
