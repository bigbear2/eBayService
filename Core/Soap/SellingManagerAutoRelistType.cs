// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAutoRelistType
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
  public class SellingManagerAutoRelistType
  {
    private SellingManagerAutoRelistTypeCodeType mType;
    private bool mTypeSpecified;
    private SellingManagerAutoRelistOptionCodeType mRelistCondition;
    private bool mRelistConditionSpecified;
    private int mRelistAfterDays;
    private bool mRelistAfterDaysSpecified;
    private int mRelistAfterHours;
    private bool mRelistAfterHoursSpecified;
    private DateTime mRelistAtSpecificTimeOfDay;
    private bool mRelistAtSpecificTimeOfDaySpecified;
    private BestOfferDetailsType mBestOfferDetails;
    private int mListingHoldInventoryLevel;
    private bool mListingHoldInventoryLevelSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutoRelistTypeCodeType Type
    {
      get => this.mType;
      set
      {
        this.mType = value;
        this.mTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TypeSpecified
    {
      get => this.mTypeSpecified;
      set => this.mTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutoRelistOptionCodeType RelistCondition
    {
      get => this.mRelistCondition;
      set
      {
        this.mRelistCondition = value;
        this.mRelistConditionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistConditionSpecified
    {
      get => this.mRelistConditionSpecified;
      set => this.mRelistConditionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RelistAfterDays
    {
      get => this.mRelistAfterDays;
      set
      {
        this.mRelistAfterDays = value;
        this.mRelistAfterDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistAfterDaysSpecified
    {
      get => this.mRelistAfterDaysSpecified;
      set => this.mRelistAfterDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RelistAfterHours
    {
      get => this.mRelistAfterHours;
      set
      {
        this.mRelistAfterHours = value;
        this.mRelistAfterHoursSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistAfterHoursSpecified
    {
      get => this.mRelistAfterHoursSpecified;
      set => this.mRelistAfterHoursSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime RelistAtSpecificTimeOfDay
    {
      get => this.mRelistAtSpecificTimeOfDay;
      set
      {
        this.mRelistAtSpecificTimeOfDay = value;
        this.mRelistAtSpecificTimeOfDaySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistAtSpecificTimeOfDaySpecified
    {
      get => this.mRelistAtSpecificTimeOfDaySpecified;
      set => this.mRelistAtSpecificTimeOfDaySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferDetailsType BestOfferDetails
    {
      get => this.mBestOfferDetails;
      set => this.mBestOfferDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ListingHoldInventoryLevel
    {
      get => this.mListingHoldInventoryLevel;
      set
      {
        this.mListingHoldInventoryLevel = value;
        this.mListingHoldInventoryLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingHoldInventoryLevelSpecified
    {
      get => this.mListingHoldInventoryLevelSpecified;
      set => this.mListingHoldInventoryLevelSpecified = value;
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
