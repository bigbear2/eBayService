// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NameRecommendationType
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
  public class NameRecommendationType
  {
    private string mName;
    private RecommendationValidationRulesType mValidationRules;
    private ValueRecommendationTypeCollection mValueRecommendation;
    private string mHelpURL;
    private ItemSpecificSourceCodeType mSource;
    private bool mSourceSpecified;
    private string mHelpText;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RecommendationValidationRulesType ValidationRules
    {
      get => this.mValidationRules;
      set => this.mValidationRules = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ValueRecommendation")]
    public ValueRecommendationTypeCollection ValueRecommendation
    {
      get => this.mValueRecommendation;
      set => this.mValueRecommendation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string HelpURL
    {
      get => this.mHelpURL;
      set => this.mHelpURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSpecificSourceCodeType Source
    {
      get => this.mSource;
      set
      {
        this.mSource = value;
        this.mSourceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SourceSpecified
    {
      get => this.mSourceSpecified;
      set => this.mSourceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string HelpText
    {
      get => this.mHelpText;
      set => this.mHelpText = value;
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
