// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetStorePreferencesCall
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
  public class GetStorePreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetStorePreferencesCall() => this.ApiRequest = new GetStorePreferencesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetStorePreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetStorePreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve an eBay seller's Store preferences. This call does not have any call-specific request payload.
    /// </summary>
    public StorePreferencesType GetStorePreferences()
    {
      this.Execute();
      return this.ApiResponse.StorePreferences;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetStorePreferencesRequestType" /> for this API call.
    /// </summary>
    public GetStorePreferencesRequestType ApiRequest
    {
      get => (GetStorePreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetStorePreferencesResponseType" /> for this API call.
    /// </summary>
    public GetStorePreferencesResponseType ApiResponse
    {
      get => (GetStorePreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStorePreferencesResponseType.StorePreferences" /> of type <see cref="T:eBay.Service.Core.Soap.StorePreferencesType" />.
    /// </summary>
    public StorePreferencesType StorePreferences => this.ApiResponse.StorePreferences;
  }
}
