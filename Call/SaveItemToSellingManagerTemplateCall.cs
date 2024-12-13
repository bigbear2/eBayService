// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SaveItemToSellingManagerTemplateCall
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
  public class SaveItemToSellingManagerTemplateCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SaveItemToSellingManagerTemplateCall()
    {
      this.ApiRequest = new SaveItemToSellingManagerTemplateRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SaveItemToSellingManagerTemplateCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SaveItemToSellingManagerTemplateRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Creates a Selling Manager template based on an existing eBay listing.
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of the eBay listing which should be used as a model to create the Selling Manager template and save it to Selling Manager inventory.
    /// </param>
    /// <param name="ProductID">
    /// Associates the new template with a product.
    /// </param>
    /// <param name="TemplateName">
    /// Name associated with the template. If no name is submitted, the template will be named automatically.
    /// </param>
    public long SaveItemToSellingManagerTemplate(
      string ItemID,
      long ProductID,
      string TemplateName)
    {
      this.ItemID = ItemID;
      this.ProductID = ProductID;
      this.TemplateName = TemplateName;
      this.Execute();
      return this.ApiResponse.TemplateID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateRequestType" /> for this API call.
    /// </summary>
    public SaveItemToSellingManagerTemplateRequestType ApiRequest
    {
      get => (SaveItemToSellingManagerTemplateRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateResponseType" /> for this API call.
    /// </summary>
    public SaveItemToSellingManagerTemplateResponseType ApiResponse
    {
      get => (SaveItemToSellingManagerTemplateResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateRequestType.ProductID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ProductID
    {
      get => this.ApiRequest.ProductID;
      set => this.ApiRequest.ProductID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateRequestType.TemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string TemplateName
    {
      get => this.ApiRequest.TemplateName;
      set => this.ApiRequest.TemplateName = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SaveItemToSellingManagerTemplateResponseType.TemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long TemplateID => this.ApiResponse.TemplateID;
  }
}
