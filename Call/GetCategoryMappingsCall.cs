// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetCategoryMappingsCall
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
  public class GetCategoryMappingsCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetCategoryMappingsCall() => this.ApiRequest = new GetCategoryMappingsRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetCategoryMappingsCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetCategoryMappingsRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves a map of old category IDs and corresponding active
    /// category IDs defined for the site to which the request is sent.
    /// </summary>
    /// <param name="CategoryVersion">
    /// A version of the category mapping for the site. Filters
    /// out data from the call to return only the category
    /// mappings for which the data has changed since the
    /// specified version. If not specified, all category
    /// mappings are returned. Typically, an application passes
    /// the version value of the last set of category mappings
    /// that the application stored locally. The latest version
    /// value is not necessarily greater than the previous value
    /// that was returned. Therefore, when comparing versions,
    /// only compare whether the value has changed.
    /// </param>
    public CategoryMappingTypeCollection GetCategoryMappings(string CategoryVersion)
    {
      this.CategoryVersion = CategoryVersion;
      this.Execute();
      return this.ApiResponse.CategoryMapping;
    }

    /// <summary>
    /// Call GetCategoryMappingsVersion to retrieve the Category Mapping version for a site.
    /// </summary>
    /// <returns>The <see cref="P:eBay.Service.Core.Soap.GetCategoryMappingsResponseType.CategoryVersion" />.</returns>
    public string GetCategoryMappingsVersion()
    {
      this.DetailLevelOverride = true;
      this.Execute();
      this.DetailLevelOverride = false;
      return this.CategoryVersionResponse;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public CategoryMappingTypeCollection GetCategoryMappings()
    {
      this.Execute();
      return this.CategoryMappingList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetCategoryMappingsRequestType" /> for this API call.
    /// </summary>
    public GetCategoryMappingsRequestType ApiRequest
    {
      get => (GetCategoryMappingsRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetCategoryMappingsResponseType" /> for this API call.
    /// </summary>
    public GetCategoryMappingsResponseType ApiResponse
    {
      get => (GetCategoryMappingsResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryMappingsRequestType.CategoryVersion" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryVersion
    {
      get => this.ApiRequest.CategoryVersion;
      set => this.ApiRequest.CategoryVersion = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryMappingsResponseType.CategoryMapping" /> of type <see cref="T:eBay.Service.Core.Soap.CategoryMappingTypeCollection" />.
    /// </summary>
    public CategoryMappingTypeCollection CategoryMappingList => this.ApiResponse.CategoryMapping;

    /// <summary>
    /// 
    /// </summary>
    public string CategoryVersionResponse => this.ApiResponse.CategoryVersion;
  }
}
