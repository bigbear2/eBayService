// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCategoryFeaturesResponseType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class GetCategoryFeaturesResponseType : AbstractResponseType
  {
    private string mCategoryVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private CategoryFeatureTypeCollection mCategory;
    private SiteDefaultsType mSiteDefaults;
    private FeatureDefinitionsType mFeatureDefinitions;

    /// <summary>
    /// 
    /// </summary>
    public string CategoryVersion
    {
      get => this.mCategoryVersion;
      set => this.mCategoryVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Category")]
    public CategoryFeatureTypeCollection Category
    {
      get => this.mCategory;
      set => this.mCategory = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteDefaultsType SiteDefaults
    {
      get => this.mSiteDefaults;
      set => this.mSiteDefaults = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeatureDefinitionsType FeatureDefinitions
    {
      get => this.mFeatureDefinitions;
      set => this.mFeatureDefinitions = value;
    }
  }
}
