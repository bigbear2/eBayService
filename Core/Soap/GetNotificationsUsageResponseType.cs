// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetNotificationsUsageResponseType
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
  public class GetNotificationsUsageResponseType : AbstractResponseType
  {
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private NotificationDetailsTypeCollection mNotificationDetailsArray;
    private MarkUpMarkDownEventTypeCollection mMarkUpMarkDownHistory;
    private NotificationStatisticsType mNotificationStatistics;

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
    [XmlArrayItem("NotificationDetails", IsNullable = false)]
    public NotificationDetailsTypeCollection NotificationDetailsArray
    {
      get => this.mNotificationDetailsArray;
      set => this.mNotificationDetailsArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("MarkUpMarkDownEvent", IsNullable = false)]
    public MarkUpMarkDownEventTypeCollection MarkUpMarkDownHistory
    {
      get => this.mMarkUpMarkDownHistory;
      set => this.mMarkUpMarkDownHistory = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NotificationStatisticsType NotificationStatistics
    {
      get => this.mNotificationStatistics;
      set => this.mNotificationStatistics = value;
    }
  }
}
