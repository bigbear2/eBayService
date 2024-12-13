// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.ApiLogger
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System.IO;
using System.Reflection;


namespace eBay.Service.Util
{
  /// <summary>
  /// Base class of the <see cref="T:eBay.Service.Util.FileLogger" />, <see cref="T:eBay.Service.Util.EventLogger" />, and
  /// <see cref="T:eBay.Service.Util.ConsoleLogger" /> classes. Typically, the individual classes that
  /// inherit from ApiLogger are used in the <see cref="P:eBay.Service.Core.Sdk.ApiLogManager.ApiLoggerList" />
  /// to specify which loggers are to be used for logging.
  /// </summary>
  public abstract class ApiLogger
  {
    private bool mLogApiMessages;
    private bool mLogExceptions;
    private bool mLogInformations;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message">The message to log of type <see cref="T:System.String" />.</param>
    /// <param name="Severity">The severity of the message to log of type <see cref="T:eBay.Service.Util.MessageSeverity" />.</param>
    public abstract void RecordMessage(string Message, MessageSeverity Severity);

    /// <summary>get directory path of eBay.Service.dll</summary>
    /// <returns></returns>
    protected string GetGetExecutingAssemblyDirectory()
    {
      return Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
    }

    /// <summary>
    /// Gets or sets a property that determines if the API Call payloads should be logged.
    /// </summary>
    public bool LogApiMessages
    {
      get => this.mLogApiMessages;
      set => this.mLogApiMessages = value;
    }

    /// <summary>
    /// Gets or sets a property that determines if the exceptions should be logged.
    /// </summary>
    public bool LogExceptions
    {
      get => this.mLogExceptions;
      set => this.mLogExceptions = value;
    }

    /// <summary>
    /// Gets or sets a property that determines if informational messages should be logged.
    /// </summary>
    public bool LogInformations
    {
      get => this.mLogInformations;
      set => this.mLogInformations = value;
    }
  }
}
