// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ContextSearchAssetType
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
  public class ContextSearchAssetType
  {
    private string mKeyword;
    private CategoryType mCategory;
    private int mRanking;
    private bool mRankingSpecified;

    /// <summary>
    /// 
    /// </summary>
    public string Keyword
    {
      get => this.mKeyword;
      set => this.mKeyword = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CategoryType Category
    {
      get => this.mCategory;
      set => this.mCategory = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Ranking
    {
      get => this.mRanking;
      set
      {
        this.mRanking = value;
        this.mRankingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RankingSpecified
    {
      get => this.mRankingSpecified;
      set => this.mRankingSpecified = value;
    }
  }
}
