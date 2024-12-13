// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemListCustomizationType
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
  public class ItemListCustomizationType
  {
    private bool mInclude;
    private bool mIncludeSpecified;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private ItemSortTypeCodeType mSort;
    private bool mSortSpecified;
    private int mDurationInDays;
    private bool mDurationInDaysSpecified;
    private bool mIncludeNotes;
    private bool mIncludeNotesSpecified;
    private PaginationType mPagination;
    private OrderStatusFilterCodeType mOrderStatusFilter;
    private bool mOrderStatusFilterSpecified;
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
    public ListingTypeCodeType ListingType
    {
      get => this.mListingType;
      set
      {
        this.mListingType = value;
        this.mListingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingTypeSpecified
    {
      get => this.mListingTypeSpecified;
      set => this.mListingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSortTypeCodeType Sort
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
    public int DurationInDays
    {
      get => this.mDurationInDays;
      set
      {
        this.mDurationInDays = value;
        this.mDurationInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DurationInDaysSpecified
    {
      get => this.mDurationInDaysSpecified;
      set => this.mDurationInDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeNotes
    {
      get => this.mIncludeNotes;
      set
      {
        this.mIncludeNotes = value;
        this.mIncludeNotesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeNotesSpecified
    {
      get => this.mIncludeNotesSpecified;
      set => this.mIncludeNotesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public OrderStatusFilterCodeType OrderStatusFilter
    {
      get => this.mOrderStatusFilter;
      set
      {
        this.mOrderStatusFilter = value;
        this.mOrderStatusFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderStatusFilterSpecified
    {
      get => this.mOrderStatusFilterSpecified;
      set => this.mOrderStatusFilterSpecified = value;
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
