// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.CallRetry
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// When your application accesses the eBay platform using the SDK, errors can occur. For many types of these
  /// errors, your application should retry the call. For example, for most calls that fail due to HTTP problems,
  /// such as error 502 bad gateway, error 404, and so forth, you should retry two or three times. Similarly, API call
  /// failures, notably <see cref="T:eBay.Service.Call.AddItemCall" />, can occur even though the request is validly constructed due to server traffic.
  /// 
  /// The SDK provides an easy way to make call retries
  /// using the <see cref="T:eBay.Service.Core.Sdk.ApiCall" /> class property named CallRetry. To do this, you instantiate
  /// an object of the CallRetry class and set the number of retries, the errors for which you want to retry and the
  /// interval at which you want to retry. You must retry only for errors caused on the eBay server side and not because
  /// of an error in your application, because retries will not help resolve application errors. You should normally try no more than 2 times.
  /// You should check the Error result set returned by the API call and set valid input arguments before you retry.
  /// 
  /// You can retry on any of following errors:
  /// <list type="bullet">
  /// <item>API errors using TriggerErrorCodes</item>
  /// <item>HTTP errors using TriggerHttpStatusCodes</item>
  /// <item>.NET or SDK exception using TriggerExceptions</item>
  /// </list>
  /// For details and a complete code sample, see the knowledgebase article
  /// <see href="http://ebay.custhelp.com/cgi-bin/ebay.cfg/php/enduser/std_adp.php?p_faqid=412">Call Retries.</see>
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class CallRetry
  {
    private int mDelayTime = 5000;
    private int mMaximumRetries;
    private ExceptionFilter mFilter = new ExceptionFilter();

    /// <summary>
    /// Determines if a retry should be invoked based on an exception that occured.
    /// </summary>
    /// <param name="ex">The <see cref="T:System.Exception" /> to test for retry.</param>
    /// <returns>Returns <b>true</b> if retry should be invoked, else <b>false</b></returns>
    public bool ShouldRetry(Exception ex) => this.mFilter.Matches(ex);

    /// <summary>Time to wait between retries.</summary>
    public int DelayTime
    {
      get => this.mDelayTime;
      set => this.mDelayTime = value;
    }

    /// <summary>Maximum number of times to retry.</summary>
    public int MaximumRetries
    {
      get => this.mMaximumRetries;
      set
      {
        this.mMaximumRetries = value >= 0 ? value : throw new SdkException("Maximum retries is invalid", (Exception) new ArgumentException());
      }
    }

    /// <summary>
    /// If using the getter, this gets the error codes that will result in a retry. Type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// If using the setter, this specifies the error codes that are to cause a retry.
    /// </summary>
    public StringCollection TriggerErrorCodes
    {
      get => this.mFilter.TriggerErrorCodes;
      set => this.mFilter.TriggerErrorCodes = value;
    }

    /// <summary>
    /// If using the getter, this gets the status codes that will result in a retry. Type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// If using the setter, this specifies the status codes that are to cause a retry.
    /// </summary>
    public Int32Collection TriggerHttpStatusCodes
    {
      get => this.mFilter.TriggerHttpStatusCodes;
      set => this.mFilter.TriggerHttpStatusCodes = value;
    }

    /// <summary>
    /// If using the getter, this gets the exceptions that will result in a retry. Type <see cref="T:eBay.Service.Core.Soap.TypeCollection" />..
    /// If using the setter, this specifies the exceptions that are to cause a retry.
    /// </summary>
    public TypeCollection TriggerExceptions
    {
      get => this.mFilter.TriggerExceptions;
      set => this.mFilter.TriggerExceptions = value;
    }
  }
}
