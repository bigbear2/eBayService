// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAutoListAccordingToScheduleType
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
  public class SellingManagerAutoListAccordingToScheduleType
  {
    private DayOfWeekCodeTypeCollection mDayOfWeek;
    private int mListingPeriodInWeeks;
    private bool mListingPeriodInWeeksSpecified;
    private DateTime mListAtSpecificTimeOfDay;
    private bool mListAtSpecificTimeOfDaySpecified;
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private int mMaxActiveItemCount;
    private bool mMaxActiveItemCountSpecified;
    private int mListingHoldInventoryLevel;
    private bool mListingHoldInventoryLevelSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DayOfWeek")]
    public DayOfWeekCodeTypeCollection DayOfWeek
    {
      get => this.mDayOfWeek;
      set => this.mDayOfWeek = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ListingPeriodInWeeks
    {
      get => this.mListingPeriodInWeeks;
      set
      {
        this.mListingPeriodInWeeks = value;
        this.mListingPeriodInWeeksSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingPeriodInWeeksSpecified
    {
      get => this.mListingPeriodInWeeksSpecified;
      set => this.mListingPeriodInWeeksSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime ListAtSpecificTimeOfDay
    {
      get => this.mListAtSpecificTimeOfDay;
      set
      {
        this.mListAtSpecificTimeOfDay = value;
        this.mListAtSpecificTimeOfDaySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListAtSpecificTimeOfDaySpecified
    {
      get => this.mListAtSpecificTimeOfDaySpecified;
      set => this.mListAtSpecificTimeOfDaySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime StartTime
    {
      get => this.mStartTime;
      set
      {
        this.mStartTime = value;
        this.mStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeSpecified
    {
      get => this.mStartTimeSpecified;
      set => this.mStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndTime
    {
      get => this.mEndTime;
      set
      {
        this.mEndTime = value;
        this.mEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeSpecified
    {
      get => this.mEndTimeSpecified;
      set => this.mEndTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxActiveItemCount
    {
      get => this.mMaxActiveItemCount;
      set
      {
        this.mMaxActiveItemCount = value;
        this.mMaxActiveItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxActiveItemCountSpecified
    {
      get => this.mMaxActiveItemCountSpecified;
      set => this.mMaxActiveItemCountSpecified = value;
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
