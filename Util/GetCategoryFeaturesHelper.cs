// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.GetCategoryFeaturesHelper
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Call;
using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Collections;


namespace eBay.Service.Util
{
  /// <summary>Summary description for GetCategoryFeaturesHelper.</summary>
  public class GetCategoryFeaturesHelper
  {
    private ApiContext _apiContext;
    private SiteCodeType _site;
    private string _categoryID;
    private int _levelLimit = 3;
    private bool _viewAllNodes = true;
    private bool _allFeaturesForCategory = true;
    private FeatureIDCodeTypeCollection _featureIDs;
    private static Hashtable _categoryFeaturesBySite = new Hashtable(5);
    private CategoryFeatureTypeCollection _categoryFeatures;
    private static Hashtable _categoryVersionsBySite = new Hashtable(5);
    private string _categoryVersion;
    private static Hashtable _siteDefaultsBySite = new Hashtable(5);
    private SiteDefaultsType _siteDefaults;
    private static Hashtable _siteFeaturesBySite = new Hashtable(5);
    private FeatureDefinitionsType _siteFeatures;

    /// <summary>
    /// 
    /// </summary>
    public GetCategoryFeaturesHelper(ApiContext ApiContext)
    {
      this._apiContext = ApiContext;
      this._site = this._apiContext.Site;
      this.loadCategoryFeatures(this._site);
    }

    /// <summary>
    /// 
    /// </summary>
    public GetCategoryFeaturesHelper(
      ApiContext ApiContext,
      string CategoryID,
      int LevelLimit,
      bool ViewAllNodes,
      FeatureIDCodeTypeCollection FeatureIDList,
      bool AllFeaturesForCategory)
    {
      this._apiContext = ApiContext;
      this._site = this._apiContext.Site;
      this._categoryID = CategoryID;
      this._levelLimit = LevelLimit;
      this._viewAllNodes = ViewAllNodes;
      this._featureIDs = FeatureIDList;
      this._allFeaturesForCategory = AllFeaturesForCategory;
      this.loadCategoryFeatures(this._site);
    }

    /// <summary>
    /// 
    /// </summary>
    public bool hasCategoryFeatures(SiteCodeType site)
    {
      return GetCategoryFeaturesHelper._categoryFeaturesBySite.ContainsKey((object) site) || GetCategoryFeaturesHelper._categoryVersionsBySite.ContainsKey((object) site) || GetCategoryFeaturesHelper._siteDefaultsBySite.ContainsKey((object) site) || GetCategoryFeaturesHelper._siteFeaturesBySite.ContainsKey((object) site);
    }

    /// <summary>
    /// 
    /// </summary>
    public void loadCategoryFeatures(SiteCodeType site)
    {
      if (GetCategoryFeaturesHelper._categoryFeaturesBySite.ContainsKey((object) site))
        return;
      SiteCodeType site1 = this._site;
      this._site = site;
      this.getCategoryFeatures();
      this.addToCategoryFeaturesMap();
      this.addToSiteDefaultsMap();
      this.addToSiteFeaturesMap();
      this.addToCategoryVersionMap();
      this._site = site1;
    }

    /// <summary>
    /// 
    /// </summary>
    public void loadCategoryFeatures(ApiContext apiContext)
    {
      this._apiContext = apiContext;
      this._site = this._apiContext.Site;
      this.loadCategoryFeatures(this._site);
    }

    /// <summary>
    /// 
    /// </summary>
    public string getCategoryVersion(SiteCodeType site)
    {
      return (string) GetCategoryFeaturesHelper._categoryVersionsBySite[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public string getCategoryVersion() => this.getCategoryVersion(this._apiContext.Site);

    /// <summary>
    /// 
    /// </summary>
    public SiteDefaultsType getSiteDefaults(SiteCodeType site)
    {
      return (SiteDefaultsType) GetCategoryFeaturesHelper._siteDefaultsBySite[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteDefaultsType getSiteDefaults() => this.getSiteDefaults(this._apiContext.Site);

    /// <summary>
    /// 
    /// </summary>
    public FeatureDefinitionsType getSiteFeatures(SiteCodeType site)
    {
      return (FeatureDefinitionsType) GetCategoryFeaturesHelper._siteFeaturesBySite[(object) site];
    }

    /// <summary>
    /// 
    /// </summary>
    public FeatureDefinitionsType getSiteFeatures() => this.getSiteFeatures(this._apiContext.Site);

    /// <summary>
    /// 
    /// </summary>
    public CategoryFeatureType getCategoryFeature(SiteCodeType site, CategoryType category)
    {
      Hashtable hashtable = (Hashtable) GetCategoryFeaturesHelper._categoryFeaturesBySite[(object) site];
      return hashtable != null ? (CategoryFeatureType) hashtable[(object) category] : (CategoryFeatureType) null;
    }

    /// <summary>
    /// 
    /// </summary>
    public CategoryFeatureType getCategoryFeature(CategoryType category)
    {
      return this.getCategoryFeature(this._apiContext.Site, category);
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteCodeType getCurrentSite() => this._site;

    private void addToCategoryFeaturesMap()
    {
      if (GetCategoryFeaturesHelper._categoryFeaturesBySite.ContainsKey((object) this._site))
        return;
      Hashtable hashtable = new Hashtable();
      for (int index = 0; index < this._categoryFeatures.Count; ++index)
      {
        CategoryFeatureType categoryFeature = this._categoryFeatures[index];
        hashtable.Add((object) categoryFeature.CategoryID, (object) categoryFeature);
      }
      GetCategoryFeaturesHelper._categoryFeaturesBySite.Add((object) this._site, (object) hashtable);
    }

    private void addToSiteDefaultsMap()
    {
      if (GetCategoryFeaturesHelper._siteDefaultsBySite.ContainsKey((object) this._site))
        return;
      GetCategoryFeaturesHelper._siteDefaultsBySite.Add((object) this._site, (object) this._siteDefaults);
    }

    private void addToSiteFeaturesMap()
    {
      if (GetCategoryFeaturesHelper._siteFeaturesBySite.ContainsKey((object) this._site))
        return;
      GetCategoryFeaturesHelper._siteFeaturesBySite.Add((object) this._site, (object) this._siteFeatures);
    }

    private void addToCategoryVersionMap()
    {
      if (GetCategoryFeaturesHelper._categoryVersionsBySite.ContainsKey((object) this._site))
        return;
      GetCategoryFeaturesHelper._categoryVersionsBySite.Add((object) this._site, (object) this._categoryVersion);
    }

    private void getCategoryFeatures()
    {
      GetCategoryFeaturesCall categoryFeaturesCall = new GetCategoryFeaturesCall(this._apiContext);
      DetailLevelCodeTypeCollection codeTypeCollection = new DetailLevelCodeTypeCollection(new DetailLevelCodeType[1]);
      categoryFeaturesCall.DetailLevelList = codeTypeCollection;
      categoryFeaturesCall.GetCategoryFeatures(this._categoryID, this._levelLimit, this._viewAllNodes, this._featureIDs, this._allFeaturesForCategory);
      this._categoryFeatures = categoryFeaturesCall.CategoryList;
      this._categoryVersion = categoryFeaturesCall.CategoryVersion;
      this._siteDefaults = categoryFeaturesCall.SiteDefaults;
      this._siteFeatures = categoryFeaturesCall.FeatureDefinitions;
    }
  }
}
