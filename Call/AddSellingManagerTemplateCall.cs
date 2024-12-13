// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddSellingManagerTemplateCall
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
  public class AddSellingManagerTemplateCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddSellingManagerTemplateCall()
    {
      this.ApiRequest = new AddSellingManagerTemplateRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddSellingManagerTemplateCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddSellingManagerTemplateRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request for the <b>AddSellingManagerTemplate</b> call, which is used to create a Selling Manager listing template. Each Selling Manager listing template must be associated with an existing Selling Manager product, and each product can have up to 20 listing templates associated with it.
    /// </summary>
    /// <param name="Item">
    /// This <b>Item</b> container is similar to the one that is used in standard Add/Revise/Relist/Verify Item calls, with the difference being that some of the product-specific data/settings will be inherited through the Selling Manager product that is referenced in the call request, and not through this <b>Item</b> container. The data that is passed in this container will become part of the listing template that is created with this call.
    /// </param>
    /// <param name="SaleTemplateName">
    /// The name of the Selling Manager listing template is provided in this field. If you don't specify a name, then the value in the <b>Item.Title</b> field will be used as the name instead.
    /// </param>
    /// <param name="ProductID">
    /// The unique identifier of the Selling Manager product that will be associated with the listing template being created. Selling Manager Product IDs are returned in the response of a <b>AddSellingManagerProduct</b> call.
    /// Alternatively, the <b>GetSellingManagerInventory</b> call can be used to retrieve active Selling Manager products for the user's account.
    /// </param>
    public long AddSellingManagerTemplate(ItemType Item, string SaleTemplateName, long ProductID)
    {
      this.Item = Item;
      this.SaleTemplateName = SaleTemplateName;
      this.ProductID = ProductID;
      this.Execute();
      return this.ApiResponse.CategoryID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerTemplateRequestType" /> for this API call.
    /// </summary>
    public AddSellingManagerTemplateRequestType ApiRequest
    {
      get => (AddSellingManagerTemplateRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType" /> for this API call.
    /// </summary>
    public AddSellingManagerTemplateResponseType ApiResponse
    {
      get => (AddSellingManagerTemplateResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateRequestType.SaleTemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SaleTemplateName
    {
      get => this.ApiRequest.SaleTemplateName;
      set => this.ApiRequest.SaleTemplateName = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateRequestType.ProductID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ProductID
    {
      get => this.ApiRequest.ProductID;
      set => this.ApiRequest.ProductID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.CategoryID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.Category2ID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID => this.ApiResponse.SaleTemplateID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.SaleTemplateGroupID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateGroupID => this.ApiResponse.SaleTemplateGroupID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.SaleTemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SaleTemplateNameReturn => this.ApiResponse.SaleTemplateName;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.ApiResponse.SellingManagerProductDetails;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
