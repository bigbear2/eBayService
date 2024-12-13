// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.ApiLogManager
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Util;
using System;
using System.Collections;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// ApiLogManager is optional; it is used in an application if any file, console, or event logging
  /// is needed. The ApiLogManager object is set in the application's <see cref="T:eBay.Service.Core.Sdk.ApiContext" /> object, logging is turned
  /// on using the <see cref="P:eBay.Service.Core.Sdk.ApiLogManager.EnableLogging" /> property, and then any individual loggers are added using
  /// the <see cref="P:eBay.Service.Core.Sdk.ApiLogManager.ApiLoggerList" /> Add property. Notice that the level of detail that is logged is set by
  /// the individual file, console, or event loggers that are in the logger list; the detail level is not set
  /// by the ApiLogManager. The individual loggers can be
  /// set to log error messages, and/or exceptions, and/or informational messages.
  /// </summary>
  /// <example>
  /// This snippet shows how to add a file logger using the ApiLogManager class, with everything logged,
  /// error messages, exceptions, and informational messages:
  /// <code>
  /// apiContext.ApiLogManager = new ApiLogManager();
  /// apiContext.ApiLogManager.ApiLoggerList.Add(new FileLogger("listing_log.txt", true, true, true));
  /// apiContext.ApiLogManager.EnableLogging = true;
  ///  </code>
  /// </example>
  public class ApiLogManager
  {
    private ApiLoggerCollection mApiLoggerList = new ApiLoggerCollection();
    private bool mEnableLogging = true;
    private ExceptionFilter mMessageLoggingFilter;

    /// <summary>
    /// 
    /// </summary>
    public ApiLogManager()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    public ApiLogManager(ApiLoggerCollection ApiLoggerList)
    {
      this.mApiLoggerList.AddRange(ApiLoggerList);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    public void RecordMessage(string Message)
    {
      this.RecordMessage(Message, MessageType.Information, MessageSeverity.Informational);
    }

    /// <summary>
    /// Log a message to all loggers enabled for this type of message.
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Type"></param>
    /// <param name="Severity"></param>
    public void RecordMessage(string Message, MessageType Type, MessageSeverity Severity)
    {
      if (!this.mEnableLogging)
        return;
      switch (Type)
      {
        case MessageType.ApiMessage:
          IEnumerator enumerator1 = this.mApiLoggerList.GetEnumerator();
          try
          {
            while (enumerator1.MoveNext())
            {
              ApiLogger current = (ApiLogger) enumerator1.Current;
              if (current.LogApiMessages)
                current.RecordMessage(Message, Severity);
            }
            break;
          }
          finally
          {
            if (enumerator1 is IDisposable disposable)
              disposable.Dispose();
          }
        case MessageType.Exception:
          IEnumerator enumerator2 = this.mApiLoggerList.GetEnumerator();
          try
          {
            while (enumerator2.MoveNext())
            {
              ApiLogger current = (ApiLogger) enumerator2.Current;
              if (current.LogExceptions)
                current.RecordMessage(Message, Severity);
            }
            break;
          }
          finally
          {
            if (enumerator2 is IDisposable disposable)
              disposable.Dispose();
          }
        case MessageType.Information:
          IEnumerator enumerator3 = this.mApiLoggerList.GetEnumerator();
          try
          {
            while (enumerator3.MoveNext())
            {
              ApiLogger current = (ApiLogger) enumerator3.Current;
              if (current.LogInformations)
                current.RecordMessage(Message, Severity);
            }
            break;
          }
          finally
          {
            if (enumerator3 is IDisposable disposable)
              disposable.Dispose();
          }
      }
    }

    /// <summary>
    /// Used only for exception-based payload logging; variation of RecordMessage which takes an exception parameter.
    /// Calls RecordMessage if no exception is supplied, or if this is not an ApiMessage (i.e. payload message), or if
    /// no MessageLoggingFilter property is configured on the log manager.  Otherwise, the exception logic is applied: the
    /// method will continue calling RecordMessage only if the exception matches the configured MessageLoggingFilter property.
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Type"></param>
    /// <param name="Severity"></param>
    /// <param name="Ex"></param>
    public void RecordPayloadOnException(
      string Message,
      MessageType Type,
      MessageSeverity Severity,
      Exception Ex)
    {
      if (Type == MessageType.ApiMessage && this.mMessageLoggingFilter != null && !this.mMessageLoggingFilter.Matches(Ex))
        return;
      this.RecordMessage(Message, Type, Severity);
    }

    /// <summary>
    /// Gets or sets the list of loggers to be used in the ApiLogManager. Type <see cref="T:eBay.Service.Util.ApiLoggerCollection" />.
    /// The individual file, console, or event loggers are added to this list using <see cref="P:eBay.Service.Core.Sdk.ApiLogManager.ApiLoggerList" /> Add.
    /// </summary>
    public ApiLoggerCollection ApiLoggerList
    {
      get => this.mApiLoggerList;
      set => this.mApiLoggerList = value;
    }

    /// <summary>
    /// If used as a getter, indicates whether logging is enabled (<b>true</b>) or not enabled (<b>false</b>).
    /// If used as a setter, a value of <b>true</b> enables logging, a value of <b>false</b> disables logging.
    /// </summary>
    public bool EnableLogging
    {
      get => this.mEnableLogging;
      set => this.mEnableLogging = value;
    }

    /// <summary>
    /// Gets or sets a global message logging filter.  If this is set, all loggers will perform message logging
    /// </summary>
    public ExceptionFilter MessageLoggingFilter
    {
      get => this.mMessageLoggingFilter;
      set => this.mMessageLoggingFilter = value;
    }

    /// <summary>
    /// Get only - returns <b>true</b> if any logger is enabling message logging.
    /// The enabling (or not) of this feature for each invidual logger is done in the logger constructor.
    /// </summary>
    public bool LogApiMessages
    {
      get
      {
        foreach (ApiLogger mApiLogger in (CollectionBase) this.mApiLoggerList)
        {
          if (mApiLogger.LogApiMessages)
            return true;
        }
        return false;
      }
    }

    /// <summary>
    /// Get only - returns <b>true</b> if any logger is enabling logging of exception message strings.
    /// The enabling (or not) of this feature for each invidual logger is done in the logger constructor.
    /// 
    /// </summary>
    public bool LogExceptions
    {
      get
      {
        foreach (ApiLogger mApiLogger in (CollectionBase) this.mApiLoggerList)
        {
          if (mApiLogger.LogExceptions)
            return true;
        }
        return false;
      }
    }

    /// <summary>
    /// Get only - returns <b>true</b> if any logger is enabling information logging.
    /// The enabling (or not) of this feature for each invidual logger is done in the logger constructor.
    /// </summary>
    public bool LogInformation
    {
      get
      {
        foreach (ApiLogger mApiLogger in (CollectionBase) this.mApiLoggerList)
        {
          if (mApiLogger.LogInformations)
            return true;
        }
        return false;
      }
    }
  }
}
