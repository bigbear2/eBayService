// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCategoriesResponseType
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
  public class GetCategoriesResponseType : AbstractResponseType
  {
    private CategoryTypeCollection mCategoryArray;
    private int mCategoryCount;
    private bool mCategoryCountSpecified;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private string mCategoryVersion;
    private bool mReservePriceAllowed;
    private bool mReservePriceAllowedSpecified;
    private double mMinimumReservePrice;
    private bool mMinimumReservePriceSpecified;
    private bool mReduceReserveAllowed;
    private bool mReduceReserveAllowedSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Category", IsNullable = false)]
    public CategoryTypeCollection CategoryArray
    {
      get => this.mCategoryArray;
      set => this.mCategoryArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CategoryCount
    {
      get => this.mCategoryCount;
      set
      {
        this.mCategoryCount = value;
        this.mCategoryCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryCountSpecified
    {
      get => this.mCategoryCountSpecified;
      set => this.mCategoryCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryVersion
    {
      get => this.mCategoryVersion;
      set => this.mCategoryVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReservePriceAllowed
    {
      get => this.mReservePriceAllowed;
      set
      {
        this.mReservePriceAllowed = value;
        this.mReservePriceAllowedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReservePriceAllowedSpecified
    {
      get => this.mReservePriceAllowedSpecified;
      set => this.mReservePriceAllowedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public double MinimumReservePrice
    {
      get => this.mMinimumReservePrice;
      set
      {
        this.mMinimumReservePrice = value;
        this.mMinimumReservePriceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinimumReservePriceSpecified
    {
      get => this.mMinimumReservePriceSpecified;
      set => this.mMinimumReservePriceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReduceReserveAllowed
    {
      get => this.mReduceReserveAllowed;
      set
      {
        this.mReduceReserveAllowed = value;
        this.mReduceReserveAllowedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReduceReserveAllowedSpecified
    {
      get => this.mReduceReserveAllowedSpecified;
      set => this.mReduceReserveAllowedSpecified = value;
    }
  }
}
