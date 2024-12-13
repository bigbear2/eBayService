// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetStoreCustomPageCall
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
  public class GetStoreCustomPageCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetStoreCustomPageCall() => this.ApiRequest = new GetStoreCustomPageRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetStoreCustomPageCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetStoreCustomPageRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call is used to retrieve a specific custom page or all custom pages created for a seller's eBay Store. The eBay seller must have an eBay Store subscription to use this call.
    /// </summary>
    /// <param name="PageID">
    /// This field is used if the seller wants to retrieved detailed information on a specific custom page. If no <b>PageID</b> is specified, then all of the seller's custom pages are returned, but without the page content.
    /// </param>
    public StoreCustomPageTypeCollection GetStoreCustomPage(long PageID)
    {
      this.PageID = PageID;
      this.Execute();
      return this.ApiResponse.CustomPageArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public StoreCustomPageTypeCollection GetStoreCustomPage()
    {
      this.Execute();
      return this.CustomPageList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetStoreCustomPageRequestType" /> for this API call.
    /// </summary>
    public GetStoreCustomPageRequestType ApiRequest
    {
      get => (GetStoreCustomPageRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetStoreCustomPageResponseType" /> for this API call.
    /// </summary>
    public GetStoreCustomPageResponseType ApiResponse
    {
      get => (GetStoreCustomPageResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetStoreCustomPageRequestType.PageID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long PageID
    {
      get => this.ApiRequest.PageID;
      set => this.ApiRequest.PageID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetStoreCustomPageResponseType.CustomPageArray" /> of type <see cref="T:eBay.Service.Core.Soap.StoreCustomPageTypeCollection" />.
    /// </summary>
    public StoreCustomPageTypeCollection CustomPageList => this.ApiResponse.CustomPageArray;
  }
}
