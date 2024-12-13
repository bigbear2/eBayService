// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerTemplatesCall
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
  public class GetSellingManagerTemplatesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerTemplatesCall()
    {
      this.ApiRequest = new GetSellingManagerTemplatesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerTemplatesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerTemplatesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves Selling Manager templates. This call is subject to change without notice; the deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="SaleTemplateIDList">
    /// The unique identifier of the Selling Manager Template whose data will be returned. A Selling Manager Template contains the data needed to list an item. One or more template IDs can be specified, each in its own field. You can obtain a <b>SaleTemplateID</b> by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    public SellingManagerTemplateDetailsTypeCollection GetSellingManagerTemplates(
      Int64Collection SaleTemplateIDList)
    {
      this.SaleTemplateIDList = SaleTemplateIDList;
      this.Execute();
      return this.ApiResponse.SellingManagerTemplateDetailsArray;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerTemplatesRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerTemplatesRequestType ApiRequest
    {
      get => (GetSellingManagerTemplatesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerTemplatesResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerTemplatesResponseType ApiResponse
    {
      get => (GetSellingManagerTemplatesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplatesRequestType.SaleTemplateID" /> of type <see cref="T:eBay.Service.Core.Soap.Int64Collection" />.
    /// </summary>
    public Int64Collection SaleTemplateIDList
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplatesResponseType.SellingManagerTemplateDetailsArray" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerTemplateDetailsTypeCollection" />.
    /// </summary>
    public SellingManagerTemplateDetailsTypeCollection SellingManagerTemplateDetailsList
    {
      get => this.ApiResponse.SellingManagerTemplateDetailsArray;
    }
  }
}
