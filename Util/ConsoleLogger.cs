// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.ConsoleLogger
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Globalization;
using System.Text;


namespace eBay.Service.Util
{
  /// <summary>
  /// 
  /// </summary>
  public class ConsoleLogger : ApiLogger
  {
    /// <summary>
    /// 
    /// </summary>
    public ConsoleLogger()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="LogInformations"></param>
    /// <param name="LogApiMessages"></param>
    /// <param name="LogExceptions"></param>
    public ConsoleLogger(bool LogInformations, bool LogApiMessages, bool LogExceptions)
    {
      this.LogApiMessages = LogApiMessages;
      this.LogInformations = LogInformations;
      this.LogExceptions = LogExceptions;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    /// <param name="Severity"></param>
    public override void RecordMessage(string Message, MessageSeverity Severity)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("[" + DateTime.Now.ToString((IFormatProvider) CultureInfo.CurrentUICulture));
      stringBuilder.Append(", " + Severity.ToString());
      stringBuilder.Append("]\r\n" + Message + "\r\n");
      Console.WriteLine((object) stringBuilder);
    }
  }
}
