// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSuggestedCategoriesCall
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
  public class GetSuggestedCategoriesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSuggestedCategoriesCall()
    {
      this.ApiRequest = new GetSuggestedCategoriesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSuggestedCategoriesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSuggestedCategoriesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call returns a list of up to 10 eBay categories that have the highest percentage of listings whose listing titles or descriptions contain the keywords you specify.
    /// </summary>
    /// <param name="Query">
    /// This field is used to specify the search query, consisting of one or
    /// more keywords to search for in listing titles and descriptions.
    /// The words "and" and "or" are treated like any other
    /// word.
    /// </param>
    public SuggestedCategoryTypeCollection GetSuggestedCategories(string Query)
    {
      this.Query = Query;
      this.Execute();
      return this.ApiResponse.SuggestedCategoryArray != null ? this.ApiResponse.SuggestedCategoryArray.SuggestedCategory : (SuggestedCategoryTypeCollection) null;
    }

    /// <summary>
    /// Gets the <see cref="P:eBay.Service.Core.Soap.SuggestedCategoryArrayType.SuggestedCategory" /> of type <see cref="T:eBay.Service.Core.Soap.SuggestedCategoryTypeCollection" />.
    /// </summary>
    public SuggestedCategoryTypeCollection SuggestedCategoryList
    {
      get
      {
        return this.ApiResponse.SuggestedCategoryArray == null ? (SuggestedCategoryTypeCollection) null : this.ApiResponse.SuggestedCategoryArray.SuggestedCategory;
      }
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSuggestedCategoriesRequestType" /> for this API call.
    /// </summary>
    public GetSuggestedCategoriesRequestType ApiRequest
    {
      get => (GetSuggestedCategoriesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSuggestedCategoriesResponseType" /> for this API call.
    /// </summary>
    public GetSuggestedCategoriesResponseType ApiResponse
    {
      get => (GetSuggestedCategoriesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSuggestedCategoriesRequestType.Query" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Query
    {
      get => this.ApiRequest.Query;
      set => this.ApiRequest.Query = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSuggestedCategoriesResponseType.SuggestedCategoryArray" /> of type <see cref="T:eBay.Service.Core.Soap.SuggestedCategoryArrayType" />.
    /// </summary>
    public SuggestedCategoryArrayType SuggestedCategoryArray
    {
      get => this.ApiResponse.SuggestedCategoryArray;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSuggestedCategoriesResponseType.CategoryCount" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int CategoryCount => this.ApiResponse.CategoryCount;
  }
}
