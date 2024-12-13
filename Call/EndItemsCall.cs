// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.EndItemsCall
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
  public class EndItemsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public EndItemsCall() => this.ApiRequest = new EndItemsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public EndItemsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new EndItemsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The <b>EndItems</b> call is used to end up to 10 specified eBay listings before the date and time at which those listings would normally end per the listing duration.
    /// </summary>
    /// <param name="EndItemRequestContainerList">
    /// An <b>EndItemRequestContainer</b> container is required for each eBay listing that the seller plans to end through the <b>EndItems</b> call. Up to 10 eBay listings can be ended with one <b>EndItems</b> call.
    /// </param>
    public EndItemResponseContainerTypeCollection EndItems(
      EndItemRequestContainerTypeCollection EndItemRequestContainerList)
    {
      this.EndItemRequestContainerList = EndItemRequestContainerList;
      this.Execute();
      return this.ApiResponse.EndItemResponseContainer;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.EndItemsRequestType" /> for this API call.
    /// </summary>
    public EndItemsRequestType ApiRequest
    {
      get => (EndItemsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.EndItemsResponseType" /> for this API call.
    /// </summary>
    public EndItemsResponseType ApiResponse => (EndItemsResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.EndItemsRequestType.EndItemRequestContainer" /> of type <see cref="T:eBay.Service.Core.Soap.EndItemRequestContainerTypeCollection" />.
    /// </summary>
    public EndItemRequestContainerTypeCollection EndItemRequestContainerList
    {
      get => this.ApiRequest.EndItemRequestContainer;
      set => this.ApiRequest.EndItemRequestContainer = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.EndItemsResponseType.EndItemResponseContainer" /> of type <see cref="T:eBay.Service.Core.Soap.EndItemResponseContainerTypeCollection" />.
    /// </summary>
    public EndItemResponseContainerTypeCollection EndItemResponseContainerList
    {
      get => this.ApiResponse.EndItemResponseContainer;
    }
  }
}
