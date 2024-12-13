// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PromotionalSaleType
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
  public class PromotionalSaleType
  {
    private long mPromotionalSaleID;
    private bool mPromotionalSaleIDSpecified;
    private string mPromotionalSaleName;
    private ItemIDArrayType mPromotionalSaleItemIDArray;
    private PromotionalSaleStatusCodeType mStatus;
    private bool mStatusSpecified;
    private DiscountCodeType mDiscountType;
    private bool mDiscountTypeSpecified;
    private double mDiscountValue;
    private bool mDiscountValueSpecified;
    private DateTime mPromotionalSaleStartTime;
    private bool mPromotionalSaleStartTimeSpecified;
    private DateTime mPromotionalSaleEndTime;
    private bool mPromotionalSaleEndTimeSpecified;
    private PromotionalSaleTypeCodeType mPromotionalSaleType1;
    private bool mPromotionalSaleType1Specified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long PromotionalSaleID
    {
      get => this.mPromotionalSaleID;
      set
      {
        this.mPromotionalSaleID = value;
        this.mPromotionalSaleIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleIDSpecified
    {
      get => this.mPromotionalSaleIDSpecified;
      set => this.mPromotionalSaleIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PromotionalSaleName
    {
      get => this.mPromotionalSaleName;
      set => this.mPromotionalSaleName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemIDArrayType PromotionalSaleItemIDArray
    {
      get => this.mPromotionalSaleItemIDArray;
      set => this.mPromotionalSaleItemIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionalSaleStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DiscountCodeType DiscountType
    {
      get => this.mDiscountType;
      set
      {
        this.mDiscountType = value;
        this.mDiscountTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DiscountTypeSpecified
    {
      get => this.mDiscountTypeSpecified;
      set => this.mDiscountTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public double DiscountValue
    {
      get => this.mDiscountValue;
      set
      {
        this.mDiscountValue = value;
        this.mDiscountValueSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DiscountValueSpecified
    {
      get => this.mDiscountValueSpecified;
      set => this.mDiscountValueSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PromotionalSaleStartTime
    {
      get => this.mPromotionalSaleStartTime;
      set
      {
        this.mPromotionalSaleStartTime = value;
        this.mPromotionalSaleStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleStartTimeSpecified
    {
      get => this.mPromotionalSaleStartTimeSpecified;
      set => this.mPromotionalSaleStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PromotionalSaleEndTime
    {
      get => this.mPromotionalSaleEndTime;
      set
      {
        this.mPromotionalSaleEndTime = value;
        this.mPromotionalSaleEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleEndTimeSpecified
    {
      get => this.mPromotionalSaleEndTimeSpecified;
      set => this.mPromotionalSaleEndTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PromotionalSaleType")]
    public PromotionalSaleTypeCodeType PromotionalSaleType1
    {
      get => this.mPromotionalSaleType1;
      set
      {
        this.mPromotionalSaleType1 = value;
        this.mPromotionalSaleType1Specified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleType1Specified
    {
      get => this.mPromotionalSaleType1Specified;
      set => this.mPromotionalSaleType1Specified = value;
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
