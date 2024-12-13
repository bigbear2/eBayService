// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddSellingManagerProductCall
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
  public class AddSellingManagerProductCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddSellingManagerProductCall()
    {
      this.ApiRequest = new AddSellingManagerProductRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddSellingManagerProductCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddSellingManagerProductRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type of the <b>AddSellingManagerProduct</b> call, which is used to create a product or a group of product variations within the Selling Manager Pro system. Once a Selling Manager Pro product or production variation group is created, the product settings and product specifics can be transferred over into a Selling Manager Pro listing template with the <b>AddSellingManagerTemplate</b> call.
    /// </summary>
    /// <param name="SellingManagerProductDetails">
    /// This container is used to provide details about the Selling Manager product, such as product name, quantity available, and unit price.
    /// </param>
    /// <param name="FolderID">
    /// This is the unique identifier of the folder in which the new product will be placed. This folder can be a new folder or a folder that already exists for the seller in Selling Manager Pro. If no folder is specified through this field, the new product is place into the <em>My Products</em> folder by default.
    /// </param>
    /// <param name="SellingManagerProductSpecifics">
    /// This container allows the seller to specify item specifics for a product, to create a product variation group and variation specifics, and/or to specify a listing category for the product or product variation group. A product variation group can be transferred into a listing template that can create a multiple-variation listing. The listing category can either be provided through the <b>PrimaryCategoryID</b> value of this call, or through the <b>Item.PrimaryCategory.CategoryID</b> field of the subsequent <b>AddSellingManagerTemplate</b> call.
    /// </param>
    public SellingManagerProductDetailsType AddSellingManagerProduct(
      SellingManagerProductDetailsType SellingManagerProductDetails,
      long FolderID,
      SellingManagerProductSpecificsType SellingManagerProductSpecifics)
    {
      this.SellingManagerProductDetails = SellingManagerProductDetails;
      this.FolderID = FolderID;
      this.SellingManagerProductSpecifics = SellingManagerProductSpecifics;
      this.Execute();
      return this.ApiResponse.SellingManagerProductDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerProductRequestType" /> for this API call.
    /// </summary>
    public AddSellingManagerProductRequestType ApiRequest
    {
      get => (AddSellingManagerProductRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddSellingManagerProductResponseType" /> for this API call.
    /// </summary>
    public AddSellingManagerProductResponseType ApiResponse
    {
      get => (AddSellingManagerProductResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerProductRequestType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.ApiRequest.SellingManagerProductDetails;
      set => this.ApiRequest.SellingManagerProductDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerProductRequestType.FolderID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long FolderID
    {
      get => this.ApiRequest.FolderID;
      set => this.ApiRequest.FolderID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddSellingManagerProductRequestType.SellingManagerProductSpecifics" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductSpecificsType" />.
    /// </summary>
    public SellingManagerProductSpecificsType SellingManagerProductSpecifics
    {
      get => this.ApiRequest.SellingManagerProductSpecifics;
      set => this.ApiRequest.SellingManagerProductSpecifics = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddSellingManagerProductResponseType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetailsReturn
    {
      get => this.ApiResponse.SellingManagerProductDetails;
    }
  }
}
