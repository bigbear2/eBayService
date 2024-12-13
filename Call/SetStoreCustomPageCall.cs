// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetStoreCustomPageCall
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
  public class SetStoreCustomPageCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetStoreCustomPageCall() => this.ApiRequest = new SetStoreCustomPageRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetStoreCustomPageCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetStoreCustomPageRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Creates or updates a custom page on a user's eBay Store. Sellers must have an eBay Store subscription in order to use this call.
    /// </summary>
    /// <param name="CustomPage">
    /// This container is used to create a new eBay Store custom page or modify an existing custom page.
    /// </param>
    public StoreCustomPageType SetStoreCustomPage(StoreCustomPageType CustomPage)
    {
      this.CustomPage = CustomPage;
      this.Execute();
      return this.ApiResponse.CustomPage;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetStoreCustomPageRequestType" /> for this API call.
    /// </summary>
    public SetStoreCustomPageRequestType ApiRequest
    {
      get => (SetStoreCustomPageRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetStoreCustomPageResponseType" /> for this API call.
    /// </summary>
    public SetStoreCustomPageResponseType ApiResponse
    {
      get => (SetStoreCustomPageResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreCustomPageRequestType.CustomPage" /> of type <see cref="T:eBay.Service.Core.Soap.StoreCustomPageType" />.
    /// </summary>
    public StoreCustomPageType CustomPage
    {
      get => this.ApiRequest.CustomPage;
      set => this.ApiRequest.CustomPage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomPageType CustomPageResult => this.ApiResponse.CustomPage;
  }
}
