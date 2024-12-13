// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ApiAccessRuleType
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
  public class ApiAccessRuleType
  {
    private string mCallName;
    private bool mCountsTowardAggregate;
    private bool mCountsTowardAggregateSpecified;
    private long mDailyHardLimit;
    private bool mDailyHardLimitSpecified;
    private long mDailySoftLimit;
    private bool mDailySoftLimitSpecified;
    private long mDailyUsage;
    private bool mDailyUsageSpecified;
    private long mHourlyHardLimit;
    private bool mHourlyHardLimitSpecified;
    private long mHourlySoftLimit;
    private bool mHourlySoftLimitSpecified;
    private long mHourlyUsage;
    private bool mHourlyUsageSpecified;
    private int mPeriod;
    private bool mPeriodSpecified;
    private long mPeriodicHardLimit;
    private bool mPeriodicHardLimitSpecified;
    private long mPeriodicSoftLimit;
    private bool mPeriodicSoftLimitSpecified;
    private long mPeriodicUsage;
    private bool mPeriodicUsageSpecified;
    private DateTime mPeriodicStartDate;
    private bool mPeriodicStartDateSpecified;
    private DateTime mModTime;
    private bool mModTimeSpecified;
    private AccessRuleCurrentStatusCodeType mRuleCurrentStatus;
    private bool mRuleCurrentStatusSpecified;
    private AccessRuleStatusCodeType mRuleStatus;
    private bool mRuleStatusSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string CallName
    {
      get => this.mCallName;
      set => this.mCallName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CountsTowardAggregate
    {
      get => this.mCountsTowardAggregate;
      set
      {
        this.mCountsTowardAggregate = value;
        this.mCountsTowardAggregateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CountsTowardAggregateSpecified
    {
      get => this.mCountsTowardAggregateSpecified;
      set => this.mCountsTowardAggregateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long DailyHardLimit
    {
      get => this.mDailyHardLimit;
      set
      {
        this.mDailyHardLimit = value;
        this.mDailyHardLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DailyHardLimitSpecified
    {
      get => this.mDailyHardLimitSpecified;
      set => this.mDailyHardLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long DailySoftLimit
    {
      get => this.mDailySoftLimit;
      set
      {
        this.mDailySoftLimit = value;
        this.mDailySoftLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DailySoftLimitSpecified
    {
      get => this.mDailySoftLimitSpecified;
      set => this.mDailySoftLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long DailyUsage
    {
      get => this.mDailyUsage;
      set
      {
        this.mDailyUsage = value;
        this.mDailyUsageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DailyUsageSpecified
    {
      get => this.mDailyUsageSpecified;
      set => this.mDailyUsageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long HourlyHardLimit
    {
      get => this.mHourlyHardLimit;
      set
      {
        this.mHourlyHardLimit = value;
        this.mHourlyHardLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HourlyHardLimitSpecified
    {
      get => this.mHourlyHardLimitSpecified;
      set => this.mHourlyHardLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long HourlySoftLimit
    {
      get => this.mHourlySoftLimit;
      set
      {
        this.mHourlySoftLimit = value;
        this.mHourlySoftLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HourlySoftLimitSpecified
    {
      get => this.mHourlySoftLimitSpecified;
      set => this.mHourlySoftLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long HourlyUsage
    {
      get => this.mHourlyUsage;
      set
      {
        this.mHourlyUsage = value;
        this.mHourlyUsageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HourlyUsageSpecified
    {
      get => this.mHourlyUsageSpecified;
      set => this.mHourlyUsageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Period
    {
      get => this.mPeriod;
      set
      {
        this.mPeriod = value;
        this.mPeriodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PeriodSpecified
    {
      get => this.mPeriodSpecified;
      set => this.mPeriodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long PeriodicHardLimit
    {
      get => this.mPeriodicHardLimit;
      set
      {
        this.mPeriodicHardLimit = value;
        this.mPeriodicHardLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PeriodicHardLimitSpecified
    {
      get => this.mPeriodicHardLimitSpecified;
      set => this.mPeriodicHardLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long PeriodicSoftLimit
    {
      get => this.mPeriodicSoftLimit;
      set
      {
        this.mPeriodicSoftLimit = value;
        this.mPeriodicSoftLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PeriodicSoftLimitSpecified
    {
      get => this.mPeriodicSoftLimitSpecified;
      set => this.mPeriodicSoftLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long PeriodicUsage
    {
      get => this.mPeriodicUsage;
      set
      {
        this.mPeriodicUsage = value;
        this.mPeriodicUsageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PeriodicUsageSpecified
    {
      get => this.mPeriodicUsageSpecified;
      set => this.mPeriodicUsageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PeriodicStartDate
    {
      get => this.mPeriodicStartDate;
      set
      {
        this.mPeriodicStartDate = value;
        this.mPeriodicStartDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PeriodicStartDateSpecified
    {
      get => this.mPeriodicStartDateSpecified;
      set => this.mPeriodicStartDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ModTime
    {
      get => this.mModTime;
      set
      {
        this.mModTime = value;
        this.mModTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModTimeSpecified
    {
      get => this.mModTimeSpecified;
      set => this.mModTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AccessRuleCurrentStatusCodeType RuleCurrentStatus
    {
      get => this.mRuleCurrentStatus;
      set
      {
        this.mRuleCurrentStatus = value;
        this.mRuleCurrentStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RuleCurrentStatusSpecified
    {
      get => this.mRuleCurrentStatusSpecified;
      set => this.mRuleCurrentStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AccessRuleStatusCodeType RuleStatus
    {
      get => this.mRuleStatus;
      set
      {
        this.mRuleStatus = value;
        this.mRuleStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RuleStatusSpecified
    {
      get => this.mRuleStatusSpecified;
      set => this.mRuleStatusSpecified = value;
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
