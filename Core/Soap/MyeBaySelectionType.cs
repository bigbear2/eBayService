// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyeBaySelectionType
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
  public class MyeBaySelectionType
  {
    private bool mInclude;
    private bool mIncludeSpecified;
    private bool mIncludeItemCount;
    private bool mIncludeItemCountSpecified;
    private bool mIncludeFavoriteSearcheCount;
    private bool mIncludeFavoriteSearcheCountSpecified;
    private bool mIncludeFavoriteSellerCount;
    private bool mIncludeFavoriteSellerCountSpecified;
    private SortOrderCodeType mSort;
    private bool mSortSpecified;
    private int mMaxResults;
    private bool mMaxResultsSpecified;
    private string mUserDefinedListName;
    private bool mIncludeListContents;
    private bool mIncludeListContentsSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool Include
    {
      get => this.mInclude;
      set
      {
        this.mInclude = value;
        this.mIncludeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeSpecified
    {
      get => this.mIncludeSpecified;
      set => this.mIncludeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeItemCount
    {
      get => this.mIncludeItemCount;
      set
      {
        this.mIncludeItemCount = value;
        this.mIncludeItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeItemCountSpecified
    {
      get => this.mIncludeItemCountSpecified;
      set => this.mIncludeItemCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeFavoriteSearcheCount
    {
      get => this.mIncludeFavoriteSearcheCount;
      set
      {
        this.mIncludeFavoriteSearcheCount = value;
        this.mIncludeFavoriteSearcheCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeFavoriteSearcheCountSpecified
    {
      get => this.mIncludeFavoriteSearcheCountSpecified;
      set => this.mIncludeFavoriteSearcheCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeFavoriteSellerCount
    {
      get => this.mIncludeFavoriteSellerCount;
      set
      {
        this.mIncludeFavoriteSellerCount = value;
        this.mIncludeFavoriteSellerCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeFavoriteSellerCountSpecified
    {
      get => this.mIncludeFavoriteSellerCountSpecified;
      set => this.mIncludeFavoriteSellerCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SortOrderCodeType Sort
    {
      get => this.mSort;
      set
      {
        this.mSort = value;
        this.mSortSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortSpecified
    {
      get => this.mSortSpecified;
      set => this.mSortSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxResults
    {
      get => this.mMaxResults;
      set
      {
        this.mMaxResults = value;
        this.mMaxResultsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxResultsSpecified
    {
      get => this.mMaxResultsSpecified;
      set => this.mMaxResultsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UserDefinedListName
    {
      get => this.mUserDefinedListName;
      set => this.mUserDefinedListName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeListContents
    {
      get => this.mIncludeListContents;
      set
      {
        this.mIncludeListContents = value;
        this.mIncludeListContentsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeListContentsSpecified
    {
      get => this.mIncludeListContentsSpecified;
      set => this.mIncludeListContentsSpecified = value;
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
