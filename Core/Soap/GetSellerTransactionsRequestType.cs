// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellerTransactionsRequestType
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
  public class GetSellerTransactionsRequestType : AbstractRequestType
  {
    private DateTime mModTimeFrom;
    private bool mModTimeFromSpecified;
    private DateTime mModTimeTo;
    private bool mModTimeToSpecified;
    private PaginationType mPagination;
    private bool mIncludeFinalValueFee;
    private bool mIncludeFinalValueFeeSpecified;
    private bool mIncludeContainingOrder;
    private bool mIncludeContainingOrderSpecified;
    private StringCollection mSKUArray;
    private TransactionPlatformCodeType mPlatform;
    private bool mPlatformSpecified;
    private int mNumberOfDays;
    private bool mNumberOfDaysSpecified;
    private InventoryTrackingMethodCodeType mInventoryTrackingMethod;
    private bool mInventoryTrackingMethodSpecified;
    private bool mIncludeCodiceFiscale;
    private bool mIncludeCodiceFiscaleSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
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
    [XmlElement(Order = 1)]
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
    [XmlElement(Order = 4)]
    public bool IncludeContainingOrder
    {
      get => this.mIncludeContainingOrder;
      set
      {
        this.mIncludeContainingOrder = value;
        this.mIncludeContainingOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeContainingOrderSpecified
    {
      get => this.mIncludeContainingOrderSpecified;
      set => this.mIncludeContainingOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 5)]
    [XmlArrayItem("SKU", IsNullable = false)]
    public StringCollection SKUArray
    {
      get => this.mSKUArray;
      set => this.mSKUArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public TransactionPlatformCodeType Platform
    {
      get => this.mPlatform;
      set
      {
        this.mPlatform = value;
        this.mPlatformSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PlatformSpecified
    {
      get => this.mPlatformSpecified;
      set => this.mPlatformSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
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
    [XmlElement(Order = 8)]
    public InventoryTrackingMethodCodeType InventoryTrackingMethod
    {
      get => this.mInventoryTrackingMethod;
      set
      {
        this.mInventoryTrackingMethod = value;
        this.mInventoryTrackingMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InventoryTrackingMethodSpecified
    {
      get => this.mInventoryTrackingMethodSpecified;
      set => this.mInventoryTrackingMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public bool IncludeCodiceFiscale
    {
      get => this.mIncludeCodiceFiscale;
      set
      {
        this.mIncludeCodiceFiscale = value;
        this.mIncludeCodiceFiscaleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeCodiceFiscaleSpecified
    {
      get => this.mIncludeCodiceFiscaleSpecified;
      set => this.mIncludeCodiceFiscaleSpecified = value;
    }
  }
}
