// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteSellingManagerProductCall
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
  public class DeleteSellingManagerProductCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteSellingManagerProductCall()
    {
      this.ApiRequest = new DeleteSellingManagerProductRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteSellingManagerProductCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteSellingManagerProductRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Deletes a Selling Manager product.
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call.
    /// </summary>
    /// <param name="ProductID">
    /// The unique identifier of the Selling Manager product to be deleted.
    /// </param>
    public SellingManagerProductDetailsType DeleteSellingManagerProduct(long ProductID)
    {
      this.ProductID = ProductID;
      this.Execute();
      return this.ApiResponse.DeletedSellingManagerProductDetails;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerProductRequestType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerProductRequestType ApiRequest
    {
      get => (DeleteSellingManagerProductRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerProductResponseType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerProductResponseType ApiResponse
    {
      get => (DeleteSellingManagerProductResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerProductRequestType.ProductID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ProductID
    {
      get => this.ApiRequest.ProductID;
      set => this.ApiRequest.ProductID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerProductResponseType.DeletedSellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType DeletedSellingManagerProductDetails
    {
      get => this.ApiResponse.DeletedSellingManagerProductDetails;
    }
  }
}
