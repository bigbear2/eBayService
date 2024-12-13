// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddItemsCall
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
  public class AddItemsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddItemsCall() => this.ApiRequest = new AddItemsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddItemsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddItemsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Defines from one to five items and lists them on a specified eBay site.
    /// </summary>
    /// <param name="AddItemRequestContainerList">
    /// Defines a single item to be listed on eBay. This container is similar to an <b>AddItem</b> request. Up to five of these containers can be included in one <b>AddItems</b> request.
    /// </param>
    public AddItemResponseContainerTypeCollection AddItems(
      AddItemRequestContainerTypeCollection AddItemRequestContainerList)
    {
      this.AddItemRequestContainerList = AddItemRequestContainerList;
      this.Execute();
      return this.ApiResponse.AddItemResponseContainer;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddItemsRequestType" /> for this API call.
    /// </summary>
    public AddItemsRequestType ApiRequest
    {
      get => (AddItemsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddItemsResponseType" /> for this API call.
    /// </summary>
    public AddItemsResponseType ApiResponse => (AddItemsResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddItemsRequestType.AddItemRequestContainer" /> of type <see cref="T:eBay.Service.Core.Soap.AddItemRequestContainerTypeCollection" />.
    /// </summary>
    public AddItemRequestContainerTypeCollection AddItemRequestContainerList
    {
      get => this.ApiRequest.AddItemRequestContainer;
      set => this.ApiRequest.AddItemRequestContainer = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemsResponseType.AddItemResponseContainer" /> of type <see cref="T:eBay.Service.Core.Soap.AddItemResponseContainerTypeCollection" />.
    /// </summary>
    public AddItemResponseContainerTypeCollection AddItemResponseContainerList
    {
      get => this.ApiResponse.AddItemResponseContainer;
    }
  }
}
