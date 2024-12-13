// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.HttpWebResponseDecompressed
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.IO;
using System.IO.Compression;
using System.Net;


namespace eBay.Service.Core.Sdk
{
  /// <summary>Summary description for HttpWebResponseDecompressed.</summary>
  public class HttpWebResponseDecompressed : WebResponse
  {
    private HttpWebResponse response;
    private ApiLogManager mLogger;

    /// <summary>
    /// 
    /// </summary>
    public ApiLogManager ApiLogManager
    {
      get => this.mLogger;
      set => this.mLogger = value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    public HttpWebResponseDecompressed(WebRequest request)
    {
      WebResponse webResponse;
      try
      {
        webResponse = request.GetResponse();
      }
      catch (WebException ex)
      {
        webResponse = ex.Response != null ? ex.Response : throw ex;
      }
      this.response = (HttpWebResponse) webResponse;
    }

    /// <summary>
    /// 
    /// </summary>
    public HttpWebResponse CastToHttpWebResponse => this.response;

    /// <summary>
    /// 
    /// </summary>
    public override void Close() => this.response.Close();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override Stream GetResponseStream()
    {
      Stream responseStream1 = this.response.GetResponseStream();
      Stream stream = (Stream) null;
      if (this.response.ContentEncoding.ToLower().Contains("gzip"))
        stream = (Stream) new GZipStream(responseStream1, CompressionMode.Decompress);
      if (stream == null)
        return responseStream1;
      MemoryStream responseStream2 = new MemoryStream();
      byte[] buffer = new byte[2048];
      while (true)
      {
        int count = stream.Read(buffer, 0, buffer.Length);
        if (count > 0)
          responseStream2.Write(buffer, 0, count);
        else
          break;
      }
      long position = responseStream2.Position;
      responseStream2.Seek(0L, SeekOrigin.Begin);
      if (this.mLogger != null)
        this.mLogger.RecordMessage(string.Format("Http Compression - decompressed {0}-encoded response data: CompressedSize={1} OriginalSize={2}", (object) this.response.ContentEncoding, (object) this.ContentLength, (object) position));
      return (Stream) responseStream2;
    }

    /// <summary>
    /// 
    /// </summary>
    public override long ContentLength => this.response.ContentLength;

    /// <summary>
    /// 
    /// </summary>
    public override string ContentType => this.response.ContentType;

    /// <summary>
    /// 
    /// </summary>
    public override WebHeaderCollection Headers => this.response.Headers;

    /// <summary>
    /// 
    /// </summary>
    public override Uri ResponseUri => this.response.ResponseUri;
  }
}
