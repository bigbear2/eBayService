// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.eBayXmlAPIInterfaceService
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Util;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  [DebuggerStepThrough]
  public class eBayXmlAPIInterfaceService
  {
    private CustomSecurityHeaderType mRequesterCredentials;
    private string mXmlRequestMsg;
    private string mXmlResponseMsg;
    private string mUrl;
    private string mVersion;
    private int mTimeout = 30000;

    /// <summary>
    /// 
    /// </summary>
    public eBayXmlAPIInterfaceService() => this.Url = "http://localhost:8080/ws/websvc/eBayAPI";

    /// <summary>Makes an Xml request to eBay.</summary>
    /// <param name="Request">The Xml Request to make of type <see cref="T:System.Xml.XmlDocument" />.</param>
    /// <returns>The <see cref="T:System.Xml.XmlDocument" /> response from the API call.</returns>
    public XmlDocument Invoke(XmlDocument Request)
    {
      if (Request == null)
        throw new ArgumentNullException(nameof (Request), "Request reference not set.");
      if (this.RequesterCredentials == null)
        throw new ArgumentNullException("RequesterCredentials", "RequesterCredentials reference not set.");
      string encoding = ((XmlDeclaration) Request.FirstChild).Encoding;
      this.mXmlRequestMsg = Request.InnerXml;
      byte[] numArray1 = new byte[Encoding.GetEncoding(encoding).GetByteCount(this.mXmlRequestMsg)];
      Encoding.UTF8.GetBytes(this.mXmlRequestMsg, 0, this.mXmlRequestMsg.Length, numArray1, 0);
      if (numArray1[0] != (byte) 60)
      {
        byte[] numArray2 = new byte[numArray1.Length - 3];
        for (int index = 0; index < numArray2.Length; ++index)
          numArray2[index] = numArray1[index + 3];
        numArray1 = numArray2;
      }
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.Url);
      httpWebRequest.Method = "POST";
      httpWebRequest.ContentType = "text/xml";
      httpWebRequest.ContentLength = (long) numArray1.Length;
      httpWebRequest.KeepAlive = false;
      httpWebRequest.Headers.Add("X-EBAY-API-SESSION-CERTIFICATE: " + this.RequesterCredentials.Credentials.DevId + ";" + this.RequesterCredentials.Credentials.AppId + ";" + this.RequesterCredentials.Credentials.AuthCert);
      httpWebRequest.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL: " + this.Version);
      httpWebRequest.Headers.Add("X-EBAY-API-DEV-NAME", this.RequesterCredentials.Credentials.DevId);
      httpWebRequest.Headers.Add("X-EBAY-API-APP-NAME", this.RequesterCredentials.Credentials.AppId);
      httpWebRequest.Headers.Add("X-EBAY-API-CERT-NAME", this.RequesterCredentials.Credentials.AuthCert);
      httpWebRequest.Headers.Add("X-EBAY-API-CALL-NAME", XmlUtility.GetString(Request.CreateNavigator(), "/request/Verb"));
      httpWebRequest.Headers.Add("X-EBAY-API-SITEID", XmlUtility.GetString(Request.CreateNavigator(), "/request/SiteId"));
      httpWebRequest.Headers.Add("X-EBAY-API-DETAIL-LEVEL", XmlUtility.GetString(Request.CreateNavigator(), "/request/DetailLevel"));
      if (this.RequesterCredentials.oAuthToken != null && this.RequesterCredentials.oAuthToken.Length > 0 && this.RequesterCredentials.eBayAuthToken == null && this.RequesterCredentials.eBayAuthToken.Length <= 0)
        httpWebRequest.Headers.Add("X-EBAY-API-IAF-TOKEN", this.RequesterCredentials.oAuthToken);
      httpWebRequest.Timeout = this.Timeout;
      Stream requestStream = httpWebRequest.GetRequestStream();
      requestStream.Write(numArray1, 0, numArray1.Length);
      requestStream.Close();
      Stream responseStream = httpWebRequest.GetResponse().GetResponseStream();
      StreamReader streamReader = new StreamReader(responseStream);
      this.mXmlResponseMsg = streamReader.ReadToEnd();
      streamReader.Close();
      responseStream.Close();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.LoadXml(this.mXmlResponseMsg);
      return xmlDocument;
    }

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

    /// <summary>
    /// Gets or sets credential information that is used to set the required Http headers.
    /// </summary>
    /// <remarks>Only the AppId, DevId, and AuthCert are required.</remarks>
    public CustomSecurityHeaderType RequesterCredentials
    {
      get => this.mRequesterCredentials;
      set => this.mRequesterCredentials = value;
    }

    /// <summary>Gets or sets the Compatability Level of the API call.</summary>
    public string Version
    {
      get => this.mVersion;
      set => this.mVersion = value;
    }

    /// <summary>Gets or sets the Url to send the API Call to.</summary>
    public string Url
    {
      get => this.mUrl;
      set => this.mUrl = value;
    }

    /// <summary>Gets or sets the Timeout for the API call.</summary>
    public int Timeout
    {
      get => this.mTimeout;
      set => this.mTimeout = value;
    }

    /// <summary>
    /// Gets the API Request of type <see cref="T:System.String" />.
    /// </summary>
    public string XmlRequest
    {
      get
      {
        try
        {
          return this.Pretty(this.mXmlRequestMsg);
        }
        catch (Exception ex)
        {
          return this.mXmlRequestMsg;
        }
      }
    }

    /// <summary>
    /// Gets the API Response of type <see cref="T:System.String" />.
    /// </summary>
    public string XmlResponse
    {
      get
      {
        try
        {
          return this.Pretty(this.mXmlResponseMsg);
        }
        catch (Exception ex)
        {
          return this.mXmlResponseMsg;
        }
      }
    }
  }
}
