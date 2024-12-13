// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.CallMetricsTable
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Util;
using System.Collections;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// This feature is intended for development, not for deployed applications. During development,
  /// you may wish to log performance data for specific calls, in order to determine
  /// application performance before you deploy your application. The CallMetricsTable enables this. You
  /// set the CallMetricsTable object in your application's ApiContext, then
  /// set the <see cref="P:eBay.Service.Core.Sdk.ApiContext.EnableMetrics" /> property to <b>true</b>.
  /// For more information on using CallMetrics,
  /// <see href="http://ebay.custhelp.com/cgi-bin/ebay.cfg/php/enduser/std_adp.php?p_faqid=862">Enabling Call Metrics Logging</see>.
  /// </summary>
  public class CallMetricsTable
  {
    private int NUMBER_OF_COLUMNS = 5;
    private ApiLogger mLogger;
    private Hashtable mMetricsTable = new Hashtable();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="metrics"></param>
    public void AddCallMetrics(CallMetricsEntry metrics)
    {
      lock (this)
      {
        string callName = metrics.CallName;
        ArrayList arrayList = (ArrayList) this.mMetricsTable[(object) callName];
        if (arrayList == null)
        {
          arrayList = new ArrayList();
          this.mMetricsTable[(object) callName] = (object) arrayList;
        }
        arrayList.Add((object) metrics);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="callname"></param>
    /// <returns></returns>
    public CallMetricsEntry GetNewEntry(string callname)
    {
      CallMetricsEntry metrics = new CallMetricsEntry(callname);
      this.AddCallMetrics(metrics);
      return metrics;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    public void Log(string str) => this.mLogger.RecordMessage(str, MessageSeverity.Informational);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="metricsList"></param>
    /// <returns></returns>
    private long[] GenerateAverage(ArrayList metricsList)
    {
      long[] totals = new long[this.NUMBER_OF_COLUMNS];
      for (int index = 0; index < totals.Length; ++index)
        totals[index] = 0L;
      for (int index = 0; index < metricsList.Count; ++index)
        ((CallMetricsEntry) metricsList[index]).UpdateTotals(totals);
      for (int index = 0; index < totals.Length; ++index)
        totals[index] /= (long) metricsList.Count;
      return totals;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="callname"></param>
    /// <param name="logger"></param>
    /// <param name="metricsList"></param>
    private void GenerateReportPerCallname(
      string callname,
      ApiLogger logger,
      ArrayList metricsList)
    {
      this.mLogger = logger;
      this.Log("Call name: " + callname);
      this.Log("Number of calls recorded: " + (object) metricsList.Count);
      this.Log("Total     Setup     Network   Server    Finish    Start Time          ");
      this.Log("======================================================================");
      for (int index = 0; index < metricsList.Count; ++index)
        ((CallMetricsEntry) metricsList[index]).GenerateReport(logger);
      string str = "";
      if (metricsList.Count > 0)
      {
        foreach (long n in this.GenerateAverage(metricsList))
          str += CallMetricsEntry.FormatNumber(n);
      }
      this.Log("Average : ");
      this.Log(str);
      this.Log("======================================================================");
    }

    /// <summary>
    /// 
    /// </summary>
    public void GenerateReport(ApiLogger logger)
    {
      foreach (string key in (IEnumerable) this.mMetricsTable.Keys)
      {
        ArrayList metricsList = (ArrayList) this.mMetricsTable[(object) key];
        this.GenerateReportPerCallname(key, logger, metricsList);
      }
    }
  }
}
