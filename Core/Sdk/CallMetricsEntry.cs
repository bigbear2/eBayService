// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.CallMetricsEntry
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Util;
using System;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// You use <see cref="T:eBay.Service.Core.Sdk.CallMetricsTable" /> with the <see cref="T:eBay.Service.Core.Sdk.ApiContext" /> object if you want to log all
  /// API calls. Alternatively, you could use <see cref="T:eBay.Service.Core.Sdk.CallMetricsEntry" /> to simply log specific calls. To do this, you
  /// would create your API call wrapper object (for example, <see cref="T:eBay.Service.Call.GetUserCall" />) then set its
  /// CallMetricsEntry property to an instance of the CallMetricsEntry object. Execute the call and then invoke
  /// <see cref="M:eBay.Service.Core.Sdk.CallMetricsEntry.GenerateReport(eBay.Service.Util.ApiLogger)" /> on the call wrapper's CallMetricsEntry property.
  /// </summary>
  /// <example>
  ///  The following snippet shows how to set up the use of the CallMetricsEntry:
  ///  <code>
  /// GetUserCall apiCall = new GetUserCall(apiContext);
  /// apiCall.CallMetricsEntry = new CallMetricsEntry();
  /// apiCall.DetailLevelList.Add(DetailLevelCodeType.ReturnAll);
  /// apiCall.Execute();
  /// piLogger MyLog = new FileLogger("entry_log.txt", true, true, true);
  /// apiCall.CallMetricsEntry.GenerateReport(MyLog);
  ///  </code>
  ///  </example>
  public class CallMetricsEntry
  {
    private DateTime mApiCallStarted;
    private DateTime mNetworkSendStarted;
    private DateTime mNetworkReceiveEnded;
    private DateTime mApiCallEnded;
    private long mServerProcessingTime;
    private string mCallName;
    private static ApiLogger sLogger;
    private static string SPACES = "                                   ";

    /// <summary>Default constructor.</summary>
    public CallMetricsEntry()
    {
    }

    /// <summary>
    /// Initialize and set API call name on the entry so that it is ready to accumulate metrics..
    /// </summary>
    public CallMetricsEntry(string callname) => this.Initialize(callname);

    /// <summary>
    /// The time at which the ApiCall object began setting up and issuing the call (beginning of SendRequest()).
    /// </summary>
    public DateTime ApiCallStarted
    {
      get => this.mApiCallStarted;
      set => this.mApiCallStarted = value;
    }

    /// <summary>
    /// The time at which the ApiCall object finished issuing the call (end of SendRequest()).
    /// </summary>
    public DateTime ApiCallEnded
    {
      get => this.mApiCallEnded;
      set => this.mApiCallEnded = value;
    }

    /// <summary>
    /// The time at which the serialized request message bgan to be sent over the network.
    /// </summary>
    public DateTime NetworkSendStarted
    {
      get => this.mNetworkSendStarted;
      set => this.mNetworkSendStarted = value;
    }

    /// <summary>
    /// The time at which a response message was received from the network and became ready to deserialize.
    /// </summary>
    public DateTime NetworkReceiveEnded
    {
      get => this.mNetworkReceiveEnded;
      set => this.mNetworkReceiveEnded = value;
    }

    /// <summary>
    /// The server-side processing time reported by the eBay server.
    /// </summary>
    public long ServerProcessingTime
    {
      get => this.mServerProcessingTime;
      set => this.mServerProcessingTime = value;
    }

    /// <summary>The name of the call currently being tracked.</summary>
    public string CallName
    {
      get => this.mCallName;
      set => this.mCallName = value;
    }

    /// <summary>
    /// Reference to the logger to be used for recording data.
    /// </summary>
    public static ApiLogger logger
    {
      get => CallMetricsEntry.sLogger;
      set => CallMetricsEntry.sLogger = value;
    }

    /// <summary>
    /// Total time spent in ApiCall processing (ApiCallEnded - ApiCallStarted).
    /// </summary>
    public long TurnaroundTime => this.GetTimeInterval(this.ApiCallStarted, this.ApiCallEnded);

    /// <summary>
    /// Time spent in setup, serialization, and/or compression before sending the request (NetworkSendStarted - ApiCallStarted).
    /// </summary>
    public long CallInitTime => this.GetTimeInterval(this.ApiCallStarted, this.NetworkSendStarted);

    /// <summary>
    /// Time spent between send and receive, equal to the combination of transmission and server processing time
    /// (NetworkReceiveEnded - NetworkSendStarted).
    /// </summary>
    public long NetworkAndServerTime
    {
      get => this.GetTimeInterval(this.NetworkSendStarted, this.NetworkReceiveEnded);
    }

    /// <summary>
    /// Time spent in decompression, deserialization, and final processing, after receiving the response (ApiCallEnded - NetworkReceiveEnded).
    /// </summary>
    public long CallFinishTime => this.GetTimeInterval(this.NetworkReceiveEnded, this.ApiCallEnded);

    /// <summary>
    /// 
    /// </summary>
    public long NetworkTime => this.NetworkAndServerTime - this.ServerProcessingTime;

    private long GetTimeInterval(DateTime start, DateTime end)
    {
      return start.Equals(DateTime.MinValue) || end.Equals(DateTime.MinValue) ? -1L : (long) (end - start).TotalMilliseconds;
    }

    /// <summary>
    /// Generates the call metrics information about the API call that was made.
    /// </summary>
    public void GenerateReport(ApiLogger logger)
    {
      logger.RecordMessage(CallMetricsEntry.FormatNumber(this.TurnaroundTime) + CallMetricsEntry.FormatNumber(this.CallInitTime) + CallMetricsEntry.FormatNumber(this.NetworkTime) + CallMetricsEntry.FormatNumber(this.ServerProcessingTime > 0L ? this.ServerProcessingTime : -1L) + CallMetricsEntry.FormatNumber(this.CallFinishTime) + CallMetricsEntry.FormatString(this.ApiCallStarted.ToString("yyyy'-'MM'-'dd HH':'mm':'ss'.'fff"), 25), MessageSeverity.Informational);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="totals"></param>
    public void UpdateTotals(long[] totals)
    {
      totals[0] += this.TurnaroundTime;
      totals[1] += this.CallInitTime;
      totals[2] += this.NetworkTime;
      totals[3] += this.ServerProcessingTime;
      totals[4] += this.CallFinishTime;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Initialize(string name)
    {
      this.CallName = name;
      this.mApiCallStarted = DateTime.MinValue;
      this.mNetworkSendStarted = DateTime.MinValue;
      this.mNetworkReceiveEnded = DateTime.MinValue;
      this.mApiCallEnded = DateTime.MinValue;
      this.mServerProcessingTime = 0L;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    public static string FormatNumber(long n)
    {
      string str = n != -1L ? n.ToString() : "N/A";
      return str + CallMetricsEntry.SPACES.Substring(0, 10 - str.Length);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <param name="width"></param>
    public static string FormatString(string str, int width)
    {
      return str += CallMetricsEntry.SPACES.Substring(0, width - str.Length);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="d"></param>
    /// <returns></returns>
    public static string FormatMsec(DateTime d)
    {
      return CallMetricsEntry.FormatString(d.ToString("ssfff"), 10);
    }
  }
}
