// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetOrdersRequestType
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
  public class GetOrdersRequestType : AbstractRequestType
  {
    private StringCollection mOrderIDArray;
    private DateTime mCreateTimeFrom;
    private bool mCreateTimeFromSpecified;
    private DateTime mCreateTimeTo;
    private bool mCreateTimeToSpecified;
    private TradingRoleCodeType mOrderRole;
    private bool mOrderRoleSpecified;
    private OrderStatusCodeType mOrderStatus;
    private bool mOrderStatusSpecified;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private PaginationType mPagination;
    private DateTime mModTimeFrom;
    private bool mModTimeFromSpecified;
    private DateTime mModTimeTo;
    private bool mModTimeToSpecified;
    private int mNumberOfDays;
    private bool mNumberOfDaysSpecified;
    private bool mIncludeFinalValueFee;
    private bool mIncludeFinalValueFeeSpecified;
    private SortOrderCodeType mSortingOrder;
    private bool mSortingOrderSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 0)]
    [XmlArrayItem("OrderID", IsNullable = false)]
    public StringCollection OrderIDArray
    {
      get => this.mOrderIDArray;
      set => this.mOrderIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime CreateTimeFrom
    {
      get => this.mCreateTimeFrom;
      set
      {
        this.mCreateTimeFrom = value;
        this.mCreateTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreateTimeFromSpecified
    {
      get => this.mCreateTimeFromSpecified;
      set => this.mCreateTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public DateTime CreateTimeTo
    {
      get => this.mCreateTimeTo;
      set
      {
        this.mCreateTimeTo = value;
        this.mCreateTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreateTimeToSpecified
    {
      get => this.mCreateTimeToSpecified;
      set => this.mCreateTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public TradingRoleCodeType OrderRole
    {
      get => this.mOrderRole;
      set
      {
        this.mOrderRole = value;
        this.mOrderRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderRoleSpecified
    {
      get => this.mOrderRoleSpecified;
      set => this.mOrderRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public OrderStatusCodeType OrderStatus
    {
      get => this.mOrderStatus;
      set
      {
        this.mOrderStatus = value;
        this.mOrderStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderStatusSpecified
    {
      get => this.mOrderStatusSpecified;
      set => this.mOrderStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
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
    public DateTime ModTimeFrom
    {
      get => this.mModTimeFrom;
      set
      {
        this.mModTimeFrom = value;
        this.mModTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModTimeFromSpecified
    {
      get => this.mModTimeFromSpecified;
      set => this.mModTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public DateTime ModTimeTo
    {
      get => this.mModTimeTo;
      set
      {
        this.mModTimeTo = value;
        this.mModTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModTimeToSpecified
    {
      get => this.mModTimeToSpecified;
      set => this.mModTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public int NumberOfDays
    {
      get => this.mNumberOfDays;
      set
      {
        this.mNumberOfDays = value;
        this.mNumberOfDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NumberOfDaysSpecified
    {
      get => this.mNumberOfDaysSpecified;
      set => this.mNumberOfDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public bool IncludeFinalValueFee
    {
      get => this.mIncludeFinalValueFee;
      set
      {
        this.mIncludeFinalValueFee = value;
        this.mIncludeFinalValueFeeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeFinalValueFeeSpecified
    {
      get => this.mIncludeFinalValueFeeSpecified;
      set => this.mIncludeFinalValueFeeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public SortOrderCodeType SortingOrder
    {
      get => this.mSortingOrder;
      set
      {
        this.mSortingOrder = value;
        this.mSortingOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortingOrderSpecified
    {
      get => this.mSortingOrderSpecified;
      set => this.mSortingOrderSpecified = value;
    }
  }
}
