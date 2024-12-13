// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetStoreCall
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
  public class SetStoreCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetStoreCall() => this.ApiRequest = new SetStoreRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetStoreCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetStoreRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to set/modify the configuration of a seller's eBay Store. Configuration information includes store theme information and eBay Store category hierarchy.
    /// </summary>
    /// <param name="Store">
    /// This container is used to set/modify the configuration of a seller's eBay Store.
    /// </param>
    public void SetStore(StoreType Store)
    {
      this.Store = Store;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetStoreRequestType" /> for this API call.
    /// </summary>
    public SetStoreRequestType ApiRequest
    {
      get => (SetStoreRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetStoreResponseType" /> for this API call.
    /// </summary>
    public SetStoreResponseType ApiResponse => (SetStoreResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetStoreRequestType.Store" /> of type <see cref="T:eBay.Service.Core.Soap.StoreType" />.
    /// </summary>
    public StoreType Store
    {
      get => this.ApiRequest.Store;
      set => this.ApiRequest.Store = value;
    }
  }
}
