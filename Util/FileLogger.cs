// Decompiled with JetBrains decompiler
// Type: eBay.Service.Util.FileLogger
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace eBay.Service.Util
{
  /// <summary>
  /// 
  /// </summary>
  public class FileLogger : ApiLogger
  {
    private string mFileName = "Log.txt";

    /// <summary>
    /// 
    /// </summary>
    public FileLogger()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="FileName"></param>
    public FileLogger(string FileName) => this.mFileName = FileName;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="FileName"></param>
    /// <param name="LogInformations"></param>
    /// <param name="LogApiMessages"></param>
    /// <param name="LogExceptions"></param>
    public FileLogger(
      string FileName,
      bool LogInformations,
      bool LogApiMessages,
      bool LogExceptions)
    {
      this.LogApiMessages = LogApiMessages;
      this.LogInformations = LogInformations;
      this.LogExceptions = LogExceptions;
      this.mFileName = FileName;
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
      lock (this)
      {
        StreamWriter streamWriter;
        using (streamWriter = new StreamWriter((Stream) new FileStream(this.getAbsoluteFilePath(), FileMode.OpenOrCreate, FileAccess.Write)))
        {
          streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
          streamWriter.WriteLine(stringBuilder.ToString());
          streamWriter.Flush();
          streamWriter?.Close();
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    public void Close()
    {
    }

    /// <summary>
    /// 1. for relative path
    /// If the fileName is specified as an relative path such as "log.txt", the current excuting path will be changed while
    /// selecting a picture. The current excuting path need to be reseted by adding an prifix with dll's location.
    /// 2. for absolute path
    /// If the fileName is specified as an absolute path, there is no need to change it.
    /// </summary>
    /// <returns></returns>
    private string getAbsoluteFilePath()
    {
      return this.isAbsolutePath(this.mFileName) ? this.mFileName : this.convertUriToDirectoryPathFormat(this.GetGetExecutingAssemblyDirectory() + Path.DirectorySeparatorChar.ToString() + this.mFileName);
    }

    /// <summary>
    /// convert an uri string to a local directory path format
    /// </summary>
    /// <param name="uriString"></param>
    /// <returns></returns>
    private string convertUriToDirectoryPathFormat(string uriString)
    {
      Uri uri = new Uri(uriString);
      return Uri.UnescapeDataString(uri.LocalPath + uri.Fragment);
    }

    /// <summary>
    /// Gets whether the specified path is a valid absolute file path.
    /// </summary>
    /// <param name="path">Any path. OK if null or empty.</param>
    public bool isAbsolutePath(string path)
    {
      return new Regex("^(([a-zA-Z]\\:)|(\\\\))(\\\\{1}|((\\\\{1})[^\\\\]([^/:*?<>\"|]*))+)$").IsMatch(path);
    }

    /// <summary>
    /// 
    /// </summary>
    public string FileName
    {
      get => this.mFileName;
      set => this.mFileName = value;
    }
  }
}
