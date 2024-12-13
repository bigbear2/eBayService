// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCategoriesRequestType
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
  public class GetCategoriesRequestType : AbstractRequestType
  {
    private string mCategorySiteID;
    private StringCollection mCategoryParent;
    private int mLevelLimit;
    private bool mLevelLimitSpecified;
    private bool mViewAllNodes;
    private bool mViewAllNodesSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string CategorySiteID
    {
      get => this.mCategorySiteID;
      set => this.mCategorySiteID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CategoryParent", Order = 1)]
    public StringCollection CategoryParent
    {
      get => this.mCategoryParent;
      set => this.mCategoryParent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
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
  }
}
