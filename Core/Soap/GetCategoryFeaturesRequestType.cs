// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCategoryFeaturesRequestType
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
  public class GetCategoryFeaturesRequestType : AbstractRequestType
  {
    private string mCategoryID;
    private int mLevelLimit;
    private bool mLevelLimitSpecified;
    private bool mViewAllNodes;
    private bool mViewAllNodesSpecified;
    private FeatureIDCodeTypeCollection mFeatureID;
    private bool mAllFeaturesForCategory;
    private bool mAllFeaturesForCategorySpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public int LevelLimit
    {
      get => this.mLevelLimit;
      set
      {
        this.mLevelLimit = value;
        this.mLevelLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LevelLimitSpecified
    {
      get => this.mLevelLimitSpecified;
      set => this.mLevelLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool ViewAllNodes
    {
      get => this.mViewAllNodes;
      set
      {
        this.mViewAllNodes = value;
        this.mViewAllNodesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ViewAllNodesSpecified
    {
      get => this.mViewAllNodesSpecified;
      set => this.mViewAllNodesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FeatureID", Order = 3)]
    public FeatureIDCodeTypeCollection FeatureID
    {
      get => this.mFeatureID;
      set => this.mFeatureID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public bool AllFeaturesForCategory
    {
      get => this.mAllFeaturesForCategory;
      set
      {
        this.mAllFeaturesForCategory = value;
        this.mAllFeaturesForCategorySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AllFeaturesForCategorySpecified
    {
      get => this.mAllFeaturesForCategorySpecified;
      set => this.mAllFeaturesForCategorySpecified = value;
    }
  }
}
