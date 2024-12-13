// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellingManagerInventoryRequestType
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
  public class GetSellingManagerInventoryRequestType : AbstractRequestType
  {
    private SellingManagerProductSortCodeType mSort;
    private bool mSortSpecified;
    private long mFolderID;
    private bool mFolderIDSpecified;
    private PaginationType mPagination;
    private SortOrderCodeType mSortOrder;
    private bool mSortOrderSpecified;
    private SellingManagerSearchType mSearch;
    private long mStoreCategoryID;
    private bool mStoreCategoryIDSpecified;
    private SellingManagerInventoryPropertyTypeCodeTypeCollection mFilter;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public SellingManagerProductSortCodeType Sort
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
    [XmlElement(Order = 1)]
    public long FolderID
    {
      get => this.mFolderID;
      set
      {
        this.mFolderID = value;
        this.mFolderIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FolderIDSpecified
    {
      get => this.mFolderIDSpecified;
      set => this.mFolderIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public SortOrderCodeType SortOrder
    {
      get => this.mSortOrder;
      set
      {
        this.mSortOrder = value;
        this.mSortOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortOrderSpecified
    {
      get => this.mSortOrderSpecified;
      set => this.mSortOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public SellingManagerSearchType Search
    {
      get => this.mSearch;
      set => this.mSearch = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public long StoreCategoryID
    {
      get => this.mStoreCategoryID;
      set
      {
        this.mStoreCategoryID = value;
        this.mStoreCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreCategoryIDSpecified
    {
      get => this.mStoreCategoryIDSpecified;
      set => this.mStoreCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Filter", Order = 6)]
    public SellingManagerInventoryPropertyTypeCodeTypeCollection Filter
    {
      get => this.mFilter;
      set => this.mFilter = value;
    }
  }
}
