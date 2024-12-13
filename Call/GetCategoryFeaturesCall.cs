// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetCategoryFeaturesCall
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
  public class GetCategoryFeaturesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetCategoryFeaturesCall() => this.ApiRequest = new GetCategoryFeaturesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetCategoryFeaturesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetCategoryFeaturesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Returns information about the features that are applicable to different categories,
    /// such as listing durations, shipping term requirements, and Best Offer support.
    /// </summary>
    /// <param name="CategoryID">
    /// Specifies the category for which you want to retrieve the feature settings.
    /// 
    /// Specify a CategoryID, set DetailLevel to ReturnAll, and set
    /// ViewAllNodes to true to return the default site settings, the
    /// overrides for the specified category, plus all the child
    /// categories that have overrides on the features they inherit.
    /// 
    /// If you also set AllFeaturesForCategory to true, eBay returns the site
    /// defaults, plus all the settings for the specified category. Child
    /// category information is not returned in this case.
    /// 
    /// If CategoryID is not specified, eBay returns the feature settings for
    /// the site. To return details on all categories that have overrides on
    /// the properties they inherit, set DetailLevel to ReturnAll, and set
    /// ViewAllNodes to true. If you also set AllFeaturesForCategory to true,
    /// eBay returns only the site defaults with no child category information.
    /// </param>
    /// <param name="LevelLimit">
    /// This field is used if the user wants to control the maximum depth of the category hierarchy to retrieve, or in other words, how many levels of eBay categories that are returned in the response. If this field is omitted, and no <b>CategoryID</b> is specified, eBay feature metadata for every eBay category from the root on down will be returned. If this field is omitted, but a <b>CategoryID</b> is specified, the specified category and all of its children (down to the leaf categories) are returned.
    /// 
    /// 
    /// If the <b>CategoryID</b> field is not used, but the <b>LevelLimit</b> field is used and set to <code>1</code>, eBay feature metadata is only returned for the top-level categories (also known as L1 categories).
    /// </param>
    /// <param name="ViewAllNodes">
    /// You must set <b>DetailLevel</b> to <code>ReturnAll</code> in order to correctly populate the
    /// response when you set <b>ViewAllNodes</b> to true. In this case, eBay returns the
    /// site defaults along with all the categories that override the feature
    /// settings they inherit. Here, each Category container shows only the
    /// features that it has overridden from its parent node.
    /// 
    /// If you also specify a <b>CategoryID</b>, eBay returns the details for that category,
    /// along with containers for each of its child categories that have feature
    /// overrides.
    /// 
    /// Note that if <b>ViewAllNodes</b> is set to false (the default) and <b>DetailLevel</b> is
    /// set to <code>ReturnAll</code>, eBay returns only the leaf categories that have features
    /// that override the settings they inherit. In this case, the call will not
    /// return leaf categories that do not have overrides.
    /// </param>
    /// <param name="FeatureIDList">
    /// Use this field if you want to know if specific features are enabled at the site or root category level. Multiple <b>FeatureID</b> elements can be used in the request. If no <b>FeatureID</b> elements are used, the call retrieves data for all features, as applicable to the other request parameters.
    /// </param>
    /// <param name="AllFeaturesForCategory">
    /// Use this switch to view all of the feature settings for a specific category.
    /// All feature settings are returned, regardless of the site default settings.
    /// This element works in conjunction with CategoryID--refer to the notes for
    /// that element for more details.
    /// 
    /// If you also set FeatureID, eBay returns the status of the specified
    /// features only, for the specified category.
    /// </param>
    public CategoryFeatureTypeCollection GetCategoryFeatures(
      string CategoryID,
      int LevelLimit,
      bool ViewAllNodes,
      FeatureIDCodeTypeCollection FeatureIDList,
      bool AllFeaturesForCategory)
    {
      this.CategoryID = CategoryID;
      this.LevelLimit = LevelLimit;
      this.ViewAllNodes = ViewAllNodes;
      this.FeatureIDList = FeatureIDList;
      this.AllFeaturesForCategory = AllFeaturesForCategory;
      this.Execute();
      return this.ApiResponse.Category;
    }

    /// <summary>
    /// Call GetCategoryFeaturesVersion to retrieve the Category version for a site.
    /// </summary>
    /// <returns>The <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.CategoryVersion" />.</returns>
    public string GetCategoryFeaturesVersion()
    {
      this.DetailLevelOverride = true;
      this.Execute();
      this.DetailLevelOverride = false;
      return this.ApiResponse.CategoryVersion;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public CategoryFeatureTypeCollection GetCategoryFeatures()
    {
      this.Execute();
      return this.CategoryList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType" /> for this API call.
    /// </summary>
    public GetCategoryFeaturesRequestType ApiRequest
    {
      get => (GetCategoryFeaturesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType" /> for this API call.
    /// </summary>
    public GetCategoryFeaturesResponseType ApiResponse
    {
      get => (GetCategoryFeaturesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType.LevelLimit" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int LevelLimit
    {
      get => this.ApiRequest.LevelLimit;
      set => this.ApiRequest.LevelLimit = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType.ViewAllNodes" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ViewAllNodes
    {
      get => this.ApiRequest.ViewAllNodes;
      set => this.ApiRequest.ViewAllNodes = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType.FeatureID" /> of type <see cref="T:eBay.Service.Core.Soap.FeatureIDCodeTypeCollection" />.
    /// </summary>
    public FeatureIDCodeTypeCollection FeatureIDList
    {
      get => this.ApiRequest.FeatureID;
      set => this.ApiRequest.FeatureID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesRequestType.AllFeaturesForCategory" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool AllFeaturesForCategory
    {
      get => this.ApiRequest.AllFeaturesForCategory;
      set => this.ApiRequest.AllFeaturesForCategory = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.CategoryVersion" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryVersion => this.ApiResponse.CategoryVersion;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.UpdateTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime UpdateTime => this.ApiResponse.UpdateTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.Category" /> of type <see cref="T:eBay.Service.Core.Soap.CategoryFeatureTypeCollection" />.
    /// </summary>
    public CategoryFeatureTypeCollection CategoryList => this.ApiResponse.Category;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.SiteDefaults" /> of type <see cref="T:eBay.Service.Core.Soap.SiteDefaultsType" />.
    /// </summary>
    public SiteDefaultsType SiteDefaults => this.ApiResponse.SiteDefaults;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetCategoryFeaturesResponseType.FeatureDefinitions" /> of type <see cref="T:eBay.Service.Core.Soap.FeatureDefinitionsType" />.
    /// </summary>
    public FeatureDefinitionsType FeatureDefinitions => this.ApiResponse.FeatureDefinitions;
  }
}
