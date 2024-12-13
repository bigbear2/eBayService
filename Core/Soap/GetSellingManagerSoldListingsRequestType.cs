// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellingManagerSoldListingsRequestType
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
  public class GetSellingManagerSoldListingsRequestType : AbstractRequestType
  {
    private SellingManagerSearchType mSearch;
    private long mStoreCategoryID;
    private bool mStoreCategoryIDSpecified;
    private SellingManagerSoldListingsPropertyTypeCodeTypeCollection mFilter;
    private bool mArchived;
    private bool mArchivedSpecified;
    private SellingManagerSoldListingsSortTypeCodeType mSort;
    private bool mSortSpecified;
    private SortOrderCodeType mSortOrder;
    private bool mSortOrderSpecified;
    private PaginationType mPagination;
    private TimeRangeType mSaleDateRange;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public SellingManagerSearchType Search
    {
      get => this.mSearch;
      set => this.mSearch = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
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
    [XmlElement("Filter", Order = 2)]
    public SellingManagerSoldListingsPropertyTypeCodeTypeCollection Filter
    {
      get => this.mFilter;
      set => this.mFilter = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool Archived
    {
      get => this.mArchived;
      set
      {
        this.mArchived = value;
        this.mArchivedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ArchivedSpecified
    {
      get => this.mArchivedSpecified;
      set => this.mArchivedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public SellingManagerSoldListingsSortTypeCodeType Sort
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
    [XmlElement(Order = 5)]
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
    [XmlElement(Order = 6)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public TimeRangeType SaleDateRange
    {
      get => this.mSaleDateRange;
      set => this.mSaleDateRange = value;
    }
  }
}
