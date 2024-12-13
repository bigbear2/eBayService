// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RecommendationsType
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
  public class RecommendationsType
  {
    private string mCategoryID;
    private ProductIdentifiersTypeCollection mProductIdentifiers;
    private NameRecommendationTypeCollection mNameRecommendation;
    private bool mUpdated;
    private bool mUpdatedSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ProductIdentifiers")]
    public ProductIdentifiersTypeCollection ProductIdentifiers
    {
      get => this.mProductIdentifiers;
      set => this.mProductIdentifiers = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("NameRecommendation")]
    public NameRecommendationTypeCollection NameRecommendation
    {
      get => this.mNameRecommendation;
      set => this.mNameRecommendation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Updated
    {
      get => this.mUpdated;
      set
      {
        this.mUpdated = value;
        this.mUpdatedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdatedSpecified
    {
      get => this.mUpdatedSpecified;
      set => this.mUpdatedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
