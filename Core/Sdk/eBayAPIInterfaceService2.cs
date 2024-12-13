// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.eBayAPIInterfaceService2
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;
using System.Net;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// Enhanced eBayAPIInterfaceService with GZIP compression support.
  /// </summary>
  internal class eBayAPIInterfaceService2 : eBayAPIInterfaceService
  {
    private bool mEnableComression;
    private ApiLogManager mLogger;
    private CallMetricsEntry mCallMetrics;
    private IWebProxy mWebProxy;
    private string moAuthToken;

    public bool EnableComression
    {
      get => this.mEnableComression;
      set => this.mEnableComression = value;
    }

    public ApiLogManager ApiLogManager
    {
      get => this.mLogger;
      set => this.mLogger = value;
    }

    public CallMetricsEntry CallMetricsEntry
    {
      get => this.mCallMetrics;
      set => this.mCallMetrics = value;
    }

    public IWebProxy WebProxy
    {
      get => this.mWebProxy;
      set => this.mWebProxy = value;
    }

    public string OAuthToken
    {
      get => this.moAuthToken;
      set => this.moAuthToken = value;
    }

    protected override WebRequest GetWebRequest(Uri uri)
    {
      if (this.mEnableComression)
      {
        HttpWebRequest webRequest = (HttpWebRequest) base.GetWebRequest(uri);
        webRequest.ProtocolVersion = HttpVersion.Version11;
        if (!string.IsNullOrEmpty(this.moAuthToken))
          webRequest.Headers.Add("X-EBAY-API-IAF-TOKEN", this.OAuthToken);
        webRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
        if (this.mCallMetrics != null)
        {
          this.mCallMetrics.NetworkSendStarted = DateTime.Now;
          webRequest.Headers.Add("X-EBAY-API-METRICS", "true");
        }
        if (this.mWebProxy != null)
          webRequest.Proxy = this.mWebProxy;
        return (WebRequest) webRequest;
      }
      WebRequest webRequest1 = base.GetWebRequest(uri);
      if (!string.IsNullOrEmpty(this.OAuthToken))
        webRequest1.Headers.Add("X-EBAY-API-IAF-TOKEN", this.OAuthToken);
      if (this.mCallMetrics != null)
      {
        this.mCallMetrics.NetworkSendStarted = DateTime.Now;
        webRequest1.Headers.Add("X-EBAY-API-METRICS", "true");
      }
      if (this.mWebProxy != null)
        webRequest1.Proxy = this.mWebProxy;
      return webRequest1;
    }

    protected override WebResponse GetWebResponse(WebRequest request)
    {
      if (this.mEnableComression)
      {
        HttpWebResponseDecompressed webResponse = new HttpWebResponseDecompressed(request);
        if (this.mCallMetrics != null)
        {
          this.mCallMetrics.NetworkReceiveEnded = DateTime.Now;
          this.mCallMetrics.ServerProcessingTime = this.convertProcessingTime(webResponse.Headers.Get("X-EBAY-API-PROCESS-TIME"));
        }
        webResponse.ApiLogManager = this.mLogger;
        this.validate(webResponse.CastToHttpWebResponse.StatusCode);
        return (WebResponse) webResponse;
      }
      HttpWebResponse webResponse1 = (HttpWebResponse) base.GetWebResponse(request);
      if (this.mCallMetrics != null)
      {
        this.mCallMetrics.NetworkReceiveEnded = DateTime.Now;
        this.mCallMetrics.ServerProcessingTime = this.convertProcessingTime(webResponse1.Headers.Get("X-EBAY-API-PROCESS-TIME"));
      }
      this.validate(webResponse1.StatusCode);
      return (WebResponse) webResponse1;
    }

    private void validate(HttpStatusCode code)
    {
      int code1 = (int) code;
      if (code1 >= 300 && code1 <= 599 && code1 != 500)
        throw new HttpException(code1);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    private long convertProcessingTime(string val)
    {
      if (val == null)
        return 0;
      long num = 0;
      try
      {
        num = (long) float.Parse(val);
      }
      catch (Exception ex)
      {
      }
      return num;
    }
  }
}
