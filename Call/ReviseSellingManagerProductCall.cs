// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseSellingManagerProductCall
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
  public class ReviseSellingManagerProductCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseSellingManagerProductCall()
    {
      this.ApiRequest = new ReviseSellingManagerProductRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseSellingManagerProductCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseSellingManagerProductRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Revises a Selling Manager Product.
    /// 
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="SellingManagerProductDetails">
    /// The details of the product that is being revised.
    /// </param>
    /// <param name="SellingManagerFolderDetails">
    /// The details of the folder for this product.
    /// </param>
    /// <param name="DeletedFieldList">
    /// Specifies the name of a field to remove from a Selling Manager product.
    /// The request can contain zero, one, or many instances of DeletedField (one for each field to be removed).
    /// DeletedField accepts the following path names, which remove the corresponding fields:
    /// SellingManagerProductDetails.CustomLabel
    /// SellingManagerProductDetails.QuantityAvailable
    /// SellingManagerProductDetails.UnitCost
    /// These values are case-sensitive. Use values that match the case of the schema element names.
    /// </param>
    /// <param name="SellingManagerProductSpecifics">
    /// Specifies an eBay category associated with the product,
    /// defines Item Specifics that are relevant to the product,
    /// and defines variations available for the product
    /// (which may be used to create multi-variation listings).
    /// </param>
    public SellingManagerProductDetailsType ReviseSellingManagerProduct(
      SellingManagerProductDetailsType SellingManagerProductDetails,
      SellingManagerFolderDetailsType SellingManagerFolderDetails,
      StringCollection DeletedFieldList,
      SellingManagerProductSpecificsType SellingManagerProductSpecifics)
    {
      this.SellingManagerProductDetails = SellingManagerProductDetails;
      this.SellingManagerFolderDetails = SellingManagerFolderDetails;
      this.DeletedFieldList = DeletedFieldList;
      this.SellingManagerProductSpecifics = SellingManagerProductSpecifics;
      this.Execute();
      return this.ApiResponse.SellingManagerProductDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerProductRequestType ApiRequest
    {
      get => (ReviseSellingManagerProductRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerProductResponseType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerProductResponseType ApiResponse
    {
      get => (ReviseSellingManagerProductResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.ApiRequest.SellingManagerProductDetails;
      set => this.ApiRequest.SellingManagerProductDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType.SellingManagerFolderDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerFolderDetailsType" />.
    /// </summary>
    public SellingManagerFolderDetailsType SellingManagerFolderDetails
    {
      get => this.ApiRequest.SellingManagerFolderDetails;
      set => this.ApiRequest.SellingManagerFolderDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType.DeletedField" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection DeletedFieldList
    {
      get => this.ApiRequest.DeletedField;
      set => this.ApiRequest.DeletedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType.SellingManagerProductSpecifics" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductSpecificsType" />.
    /// </summary>
    public SellingManagerProductSpecificsType SellingManagerProductSpecifics
    {
      get => this.ApiRequest.SellingManagerProductSpecifics;
      set => this.ApiRequest.SellingManagerProductSpecifics = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerProductResponseType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetailsReturn
    {
      get => this.ApiResponse.SellingManagerProductDetails;
    }
  }
}
