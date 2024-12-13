// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetCategoriesCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetCategoriesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetCategoriesCall() => this.ApiRequest = new GetCategoriesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetCategoriesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetCategoriesRequestType();
      this.ApiContext = ApiContext;
    }

    public CategoryTypeCollection GetCategories(
      string CategorySiteID,
      StringCollection CategoryParent,
      int LevelLimit,
      bool ViewAllNodes)
    {
      this.CategorySiteID = CategorySiteID;
      this.CategoryParent = CategoryParent;
      this.LevelLimit = LevelLimit;
      this.ViewAllNodes = ViewAllNodes;
      this.Execute();
      return this.ApiResponse.CategoryArray;
    }

    /// <summary>
    /// Call GetCategoriesVersion to retrieve the Category version for a site.
    /// </summary>
    /// <returns>The <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.CategoryVersion" />.</returns>
    public string GetCategoriesVersion()
    {
      this.DetailLevelOverride = true;
      this.Execute();
      this.DetailLevelOverride = false;
      return this.CategoryVersionResponse;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public CategoryTypeCollection GetCategories()
    {
      this.Execute();
      return this.CategoryList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetCategoriesRequestType" /> for this API call.
    /// </summary>
    public GetCategoriesRequestType ApiRequest
    {
      get => (GetCategoriesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetCategoriesResponseType" /> for this API call.
    /// </summary>
    public GetCategoriesResponseType ApiResponse
    {
      get => (GetCategoriesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoriesRequestType.CategorySiteID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategorySiteID
    {
      get => this.ApiRequest.CategorySiteID;
      set => this.ApiRequest.CategorySiteID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoriesRequestType.CategoryParent" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection CategoryParent
    {
      get => this.ApiRequest.CategoryParent;
      set => this.ApiRequest.CategoryParent = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoriesRequestType.LevelLimit" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int LevelLimit
    {
      get => this.ApiRequest.LevelLimit;
      set => this.ApiRequest.LevelLimit = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoriesRequestType.ViewAllNodes" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ViewAllNodes
    {
      get => this.ApiRequest.ViewAllNodes;
      set => this.ApiRequest.ViewAllNodes = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.CategoryArray" /> of type <see cref="T:eBay.Service.Core.Soap.CategoryTypeCollection" />.
    /// </summary>
    public CategoryTypeCollection CategoryList => this.ApiResponse.CategoryArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.CategoryCount" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int CategoryCount => this.ApiResponse.CategoryCount;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.UpdateTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime UpdateTime => this.ApiResponse.UpdateTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.CategoryVersion" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryVersionResponse => this.ApiResponse.CategoryVersion;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.ReservePriceAllowed" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ReservePriceAllowed => this.ApiResponse.ReservePriceAllowed;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.MinimumReservePrice" /> of type <see cref="T:System.Double" />.
    /// </summary>
    public double MinimumReservePrice => this.ApiResponse.MinimumReservePrice;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoriesResponseType.ReduceReserveAllowed" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ReduceReserveAllowed => this.ApiResponse.ReduceReserveAllowed;
  }
}
