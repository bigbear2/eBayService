// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.EventLogger
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;


namespace eBay.Service.Util
{
  /// <summary>
  /// 
  /// </summary>
  public class EventLogger : ApiLogger
  {
    private string mEventLogName = "eBayWebservice";
    private string mEventLogSource = "SoapSDK";
    private string mMachineName = Environment.MachineName;

    /// <summary>
    /// 
    /// </summary>
    public EventLogger()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="EventLogName"></param>
    /// <param name="EventLogSource"></param>
    /// <param name="MachineName"></param>
    public EventLogger(string EventLogName, string EventLogSource, string MachineName)
    {
      this.mEventLogName = EventLogName;
      this.mEventLogSource = EventLogSource;
      this.mMachineName = MachineName;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="EventLogName"></param>
    /// <param name="EventLogSource"></param>
    /// <param name="MachineName"></param>
    /// <param name="LogInformations"></param>
    /// <param name="LogApiMessages"></param>
    /// <param name="LogExceptions"></param>
    public EventLogger(
      string EventLogName,
      string EventLogSource,
      string MachineName,
      bool LogInformations,
      bool LogApiMessages,
      bool LogExceptions)
    {
      this.LogApiMessages = LogApiMessages;
      this.LogInformations = LogInformations;
      this.LogExceptions = LogExceptions;
      this.mEventLogName = EventLogName;
      this.mEventLogSource = EventLogSource;
      this.mMachineName = MachineName;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Severity"></param>
    public override void RecordMessage(string Message, MessageSeverity Severity)
    {
      StringBuilder stringBuilder = new StringBuilder();
      EventLog eventLog = new EventLog();
      if (!EventLog.SourceExists(this.mEventLogSource))
        EventLog.CreateEventSource(this.mEventLogSource, this.mEventLogName);
      eventLog.Source = this.mEventLogSource;
      eventLog.MachineName = this.mMachineName;
      EventLogEntryType type = EventLogEntryType.Information;
      switch (Severity)
      {
        case MessageSeverity.Informational:
          type = EventLogEntryType.Information;
          break;
        case MessageSeverity.Failure:
          type = EventLogEntryType.FailureAudit;
          break;
        case MessageSeverity.Warning:
          type = EventLogEntryType.Warning;
          break;
        case MessageSeverity.Error:
          type = EventLogEntryType.Error;
          break;
      }
      stringBuilder.Append("[" + DateTime.Now.ToString((IFormatProvider) CultureInfo.CurrentUICulture));
      stringBuilder.Append(", " + Severity.ToString());
      stringBuilder.Append("]\r\n" + Message + "\r\n");
      eventLog.WriteEntry(stringBuilder.ToString(), type);
    }

    /// <summary>
    /// 
    /// </summary>
    public string EventLogName
    {
      get => this.mEventLogName;
      set => this.mEventLogName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EventLogSource
    {
      get => this.mEventLogSource;
      set => this.mEventLogSource = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MachineName
    {
      get => this.mMachineName;
      set => this.mMachineName = value;
    }
  }
}
