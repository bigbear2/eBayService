// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteSellingManagerTemplateCall
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
  public class DeleteSellingManagerTemplateCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteSellingManagerTemplateCall()
    {
      this.ApiRequest = new DeleteSellingManagerTemplateRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteSellingManagerTemplateCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteSellingManagerTemplateRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Deletes a Selling Manager template.
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call.
    /// </summary>
    /// <param name="SaleTemplateID">
    /// Unique identifier of the Selling Manager template to be deleted.
    /// You can obtain a <b>SaleTemplateID</b> by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    public string DeleteSellingManagerTemplate(long SaleTemplateID)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.Execute();
      return this.ApiResponse.DeletedSaleTemplateID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerTemplateRequestType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerTemplateRequestType ApiRequest
    {
      get => (DeleteSellingManagerTemplateRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerTemplateResponseType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerTemplateResponseType ApiResponse
    {
      get => (DeleteSellingManagerTemplateResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateResponseType.DeletedSaleTemplateID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DeletedSaleTemplateID => this.ApiResponse.DeletedSaleTemplateID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateResponseType.DeletedSaleTemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DeletedSaleTemplateName => this.ApiResponse.DeletedSaleTemplateName;
  }
}
