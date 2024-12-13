// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SoapHttpClientProtocolEx
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.IO;
using System.Text;
using System.Web.Services.Protocols;
using System.Xml;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  public class SoapHttpClientProtocolEx : SoapHttpClientProtocol
  {
    private string mSoapRequestMsg;
    private string mSoapResponseMsg;

    /// <summary>
    /// 
    /// </summary>
    public string SoapRequest
    {
      get
      {
        try
        {
          return this.Pretty(this.mSoapRequestMsg);
        }
        catch (Exception ex)
        {
          return this.mSoapRequestMsg;
        }
      }
      set => this.mSoapRequestMsg = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SoapResponse
    {
      get
      {
        try
        {
          return this.Pretty(this.mSoapResponseMsg);
        }
        catch (Exception ex)
        {
          return this.mSoapResponseMsg;
        }
      }
      set => this.mSoapResponseMsg = value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    /// <returns></returns>
    private string Pretty(string Message)
    {
      XmlDocument xmlDocument = new XmlDocument();
      MemoryStream w1 = new MemoryStream();
      XmlTextWriter w2 = new XmlTextWriter((Stream) w1, Encoding.Unicode);
      w2.Formatting = Formatting.Indented;
      xmlDocument.LoadXml(Message);
      xmlDocument.WriteContentTo((XmlWriter) w2);
      w2.Flush();
      w1.Flush();
      w1.Position = 0L;
      string end = new StreamReader((Stream) w1).ReadToEnd();
      w1.Close();
      w2.Close();
      return end;
    }
  }
}
