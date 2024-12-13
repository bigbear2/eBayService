// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ProductSuggestionType
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
  public class ProductSuggestionType
  {
    private string mTitle;
    private string mEPID;
    private string mStockPhoto;
    private bool mRecommended;
    private bool mRecommendedSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Title
    {
      get => this.mTitle;
      set => this.mTitle = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EPID
    {
      get => this.mEPID;
      set => this.mEPID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StockPhoto
    {
      get => this.mStockPhoto;
      set => this.mStockPhoto = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Recommended
    {
      get => this.mRecommended;
      set
      {
        this.mRecommended = value;
        this.mRecommendedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RecommendedSpecified
    {
      get => this.mRecommendedSpecified;
      set => this.mRecommendedSpecified = value;
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
