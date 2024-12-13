// Decompiled with JetBrains decompiler
// Type: eBay.Service.EPS.eBayPictureService
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.Util;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;


namespace eBay.Service.EPS
{
  /// <summary>
  /// Class to upload picture with schema xml call.
  /// EpsServerUrl:
  /// for production, use: http://api.ebay.com/ws/api.dll
  /// for sandbox, use: http://api.sandbox.ebay.com/ws/api.dll
  /// </summary>
  public class eBayPictureService
  {
    private ApiContext mApiContext = new ApiContext();
    private const string X_EBAY_API_CALL_NAME = "UploadSiteHostedPictures";
    private const string X_EBAY_API_DETAIL_LEVEL = "0";
    private const string NAMESPACE = "urn:ebay:apis:eBLBaseComponents";

    /// <summary>
    /// 
    /// </summary>
    public eBayPictureService(ApiContext apiContext) => this.ApiContext = apiContext;

    /// <summary>
    /// Method to upload one picture to eBay picture server, use this method
    /// if you want to operate on UploadSiteHostedPicture request/response directly
    /// </summary>
    /// <param name="request">UploadSiteHostedPicturesRequestType</param>
    /// <param name="fileName">full path of the picture file</param>
    /// <returns>UploadSiteHostedPicturesResponseType</returns>
    public UploadSiteHostedPicturesResponseType UpLoadSiteHostedPicture(
      UploadSiteHostedPicturesRequestType request,
      string fileName)
    {
      UploadSiteHostedPicturesResponseType picturesResponseType = (UploadSiteHostedPicturesResponseType) null;
      try
      {
        XmlDocument xmlDoc = this.serializeToXmlDoc((object) request);
        this.fixEncoding(xmlDoc);
        this.addApiCredentials(xmlDoc);
        this.updateElementName(xmlDoc, "UploadSiteHostedPicturesRequestType", "UploadSiteHostedPicturesRequest");
        string outerXml = xmlDoc.OuterXml;
        string xml = this.sendFile(fileName, outerXml);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);
        this.updateElementName(doc, "UploadSiteHostedPicturesResponse", "UploadSiteHostedPicturesResponseType");
        picturesResponseType = (UploadSiteHostedPicturesResponseType) this.deserializeFromXml(doc.OuterXml, typeof (UploadSiteHostedPicturesResponseType));
        if (picturesResponseType != null && picturesResponseType.Errors != null && picturesResponseType.Errors.Count > 0)
          throw new ApiException(new ErrorTypeCollection(picturesResponseType.Errors));
        return picturesResponseType;
      }
      catch (Exception ex)
      {
        ApiException apiException = !(ex is ApiException) ? new ApiException(ex.Message, ex) : (ApiException) ex;
        MessageSeverity Severity = apiException.SeverityErrorCount > 0 ? MessageSeverity.Error : MessageSeverity.Warning;
        this.LogMessage("EPS Exception : " + apiException.Message, MessageType.Exception, Severity);
        if (apiException.SeverityErrorCount > 0)
          throw apiException;
      }
      return picturesResponseType;
    }

    private void updateElementName(XmlDocument doc, string oldName, string newName)
    {
      XmlElement xmlElement = (XmlElement) doc.GetElementsByTagName(oldName)[0];
      XmlElement name = this.copyElementToName(xmlElement, newName);
      doc.ReplaceChild((XmlNode) name, (XmlNode) xmlElement);
    }

    private XmlElement copyElementToName(XmlElement element, string tagName)
    {
      XmlElement element1 = element.OwnerDocument.CreateElement(tagName);
      for (int i = 0; i < element.Attributes.Count; ++i)
        element1.SetAttributeNode((XmlAttribute) element.Attributes[i].CloneNode(true));
      for (int i = 0; i < element.ChildNodes.Count; ++i)
        element1.AppendChild(element.ChildNodes[i].CloneNode(true));
      return element1;
    }

    /// <summary>
    /// Method to upload list of pictures to eBay picture server
    /// </summary>
    /// <param name="photoDisplay">PhotoDisplayCodeType</param>
    /// <param name="pictureFileList">picture file list</param>
    /// <returns>string[]</returns>
    public string[] UpLoadPictureFiles(PhotoDisplayCodeType photoDisplay, string[] pictureFileList)
    {
      UploadSiteHostedPicturesRequestType request = new UploadSiteHostedPicturesRequestType();
      ArrayList arrayList = new ArrayList();
      foreach (string pictureFile in pictureFileList)
      {
        if (photoDisplay == PhotoDisplayCodeType.PicturePack || photoDisplay == PhotoDisplayCodeType.SuperSize)
          request.PictureSet = PictureSetCodeType.Supersize;
        UploadSiteHostedPicturesResponseType picturesResponseType = this.UpLoadSiteHostedPicture(request, pictureFile);
        arrayList.Add((object) picturesResponseType.SiteHostedPictureDetails.FullURL);
      }
      return (string[]) arrayList.ToArray(typeof (string));
    }

    /// <summary>Method to upload one picture to eBay picture server</summary>
    /// <param name="photoDisplay">PhotoDisplayCodeType</param>
    /// <param name="pictureFile">string</param>
    /// <returns>string</returns>
    public string UpLoadPictureFile(PhotoDisplayCodeType photoDisplay, string pictureFile)
    {
      return this.UpLoadPictureFiles(photoDisplay, new string[1]
      {
        pictureFile
      })[0];
    }

    /// <summary>Method to add eBay Api Credentials</summary>
    /// <param name="doc">xml document</param>
    /// <returns>void</returns>
    private void addApiCredentials(XmlDocument doc)
    {
      XmlElement newChild1 = (XmlElement) null;
      XmlElement newChild2 = (XmlElement) null;
      if (this.ApiContext.ApiCredential.oAuthToken != null && this.ApiContext.ApiCredential.oAuthToken.Length > 0)
      {
        if (this.ApiContext.ApiCredential.eBayToken != null && this.ApiContext.ApiCredential.eBayToken.Length > 0)
        {
          newChild2 = doc.CreateElement("eBayAuthToken", "urn:ebay:apis:eBLBaseComponents");
          newChild1 = doc.CreateElement("RequesterCredentials", "urn:ebay:apis:eBLBaseComponents");
          newChild2.InnerText = this.ApiContext.ApiCredential.eBayToken;
        }
      }
      else if (this.ApiContext.ApiCredential.eBayToken != null && this.ApiContext.ApiCredential.eBayToken.Length > 0)
      {
        newChild2 = doc.CreateElement("eBayAuthToken", "urn:ebay:apis:eBLBaseComponents");
        newChild1 = doc.CreateElement("RequesterCredentials", "urn:ebay:apis:eBLBaseComponents");
        newChild2.InnerText = this.ApiContext.ApiCredential.eBayToken;
      }
      if (newChild1 == null)
        return;
      newChild1.AppendChild((XmlNode) newChild2);
      doc.DocumentElement.InsertBefore((XmlNode) newChild1, doc.DocumentElement.FirstChild);
    }

    /// <summary>Method to fix the encoding of the xml document</summary>
    /// <param name="doc">xml document</param>
    /// <returns>void</returns>
    private void fixEncoding(XmlDocument doc)
    {
      if (doc.FirstChild.NodeType != XmlNodeType.XmlDeclaration)
        return;
      ((XmlDeclaration) doc.FirstChild).Encoding = "utf-8";
    }

    /// <summary>Method to post picture data with HttpWebRequest</summary>
    /// <param name="fileName">the full path of the picture file to be uploaded</param>
    /// <param name="requestXmlString">request xml string</param>
    /// <returns>response string</returns>
    private string sendFile(string fileName, string requestXmlString)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create(this.ApiContext.EPSServerUrl);
      httpWebRequest.Method = "POST";
      httpWebRequest.ProtocolVersion = HttpVersion.Version11;
      if (this.ApiContext.WebProxy != null)
        httpWebRequest.Proxy = this.ApiContext.WebProxy;
      httpWebRequest.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", this.ApiContext.Version);
      httpWebRequest.Headers.Add("X-EBAY-API-SITEID", SiteUtility.GetSiteID(this.ApiContext.Site).ToString());
      httpWebRequest.Headers.Add("X-EBAY-API-DETAIL-LEVEL", "0");
      httpWebRequest.Headers.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");
      httpWebRequest.ContentType = "multipart/form-data; boundary=MIME_boundary";
      if (!string.IsNullOrEmpty(this.ApiContext.ApiCredential.oAuthToken))
        httpWebRequest.Headers.Add("X-EBAY-API-IAF-TOKEN", this.ApiContext.ApiCredential.oAuthToken);
      FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
      input.Seek(0L, SeekOrigin.Begin);
      BinaryReader binaryReader = new BinaryReader((Stream) input);
      byte[] buffer = binaryReader.ReadBytes((int) input.Length);
      binaryReader.Close();
      input.Close();
      string s1 = "--MIME_boundary\r\nContent-Disposition: form-data; name=document\r\nContent-Type: text/xml; charset=\"UTF-8\"\r\n\r\n" + requestXmlString + "\r\n--MIME_boundary\r\nContent-Disposition: form-data; name=image; filename=image\r\nContent-Transfer-Encoding: binary\r\nContent-Type: application/octet-stream\r\n\r\n";
      string s2 = "\r\n--MIME_boundary--\r\n";
      this.LogMessage("UploadSiteHostedPicturesRequest to " + this.ApiContext.EPSServerUrl, MessageType.Information, MessageSeverity.Informational);
      this.LogMessage(Regex.Replace(XmlUtility.FormatXml(requestXmlString) + "\r\n\r\n", "<eBayAuthToken>.+</eBayAuthToken>", "<eBayAuthToken>******</eBayAuthToken>"), MessageType.ApiMessage, MessageSeverity.Informational);
      byte[] bytes1 = Encoding.ASCII.GetBytes(s1);
      byte[] bytes2 = Encoding.ASCII.GetBytes(s2);
      int num = bytes1.Length + bytes2.Length + buffer.Length;
      httpWebRequest.ContentLength = (long) num;
      Stream requestStream = httpWebRequest.GetRequestStream();
      requestStream.Write(bytes1, 0, bytes1.Length);
      requestStream.Write(buffer, 0, buffer.Length);
      requestStream.Write(bytes2, 0, bytes2.Length);
      requestStream.Close();
      HttpWebResponse response = (HttpWebResponse) httpWebRequest.GetResponse();
      string end = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
      this.LogMessage("UploadSiteHostedPicturesResponse from " + this.ApiContext.EPSServerUrl, MessageType.Information, MessageSeverity.Informational);
      this.LogMessage(XmlUtility.FormatXml(end) + "\r\n\r\n", MessageType.ApiMessage, MessageSeverity.Informational);
      response.Close();
      return end;
    }

    /// <summary>
    /// Log the message information under the specified type and severity.
    /// </summary>
    /// <param name="Message">The content to log of type <see cref="T:System.String" />.</param>
    /// <param name="Type">The type of message to log of type <see cref="T:eBay.Service.Util.MessageType" />.</param>
    /// <param name="Severity">The severity of the message of type <see cref="T:eBay.Service.Util.MessageSeverity" />/</param>
    private void LogMessage(string Message, MessageType Type, MessageSeverity Severity)
    {
      if (Message == null || this.ApiContext == null || this.ApiContext.ApiLogManager == null || this.ApiContext.ApiLogManager.ApiLoggerList == null || this.ApiContext.ApiLogManager.ApiLoggerList.Count == 0)
        return;
      this.ApiContext.ApiLogManager.RecordMessage(Message, Type, Severity);
    }

    /// <summary>Method to convert a custom Object to XML Document</summary>
    /// <param name="obj">Object that is to be serialized to XmlDocument</param>
    /// <returns>XmlDocument</returns>
    private XmlDocument serializeToXmlDoc(object obj)
    {
      XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType(), "urn:ebay:apis:eBLBaseComponents");
      MemoryStream inStream = new MemoryStream();
      MemoryStream memoryStream = inStream;
      object o = obj;
      xmlSerializer.Serialize((Stream) memoryStream, o);
      inStream.Seek(0L, SeekOrigin.Begin);
      XmlDocument xmlDoc = new XmlDocument();
      xmlDoc.Load((Stream) inStream);
      inStream.Close();
      return xmlDoc;
    }

    /// <summary>Method to reconstruct an Object from XML string</summary>
    /// <param name="pXmlizedString">xml string to be converted</param>
    /// <param name="type">type of the object</param>
    /// <returns>object</returns>
    private object deserializeFromXml(string pXmlizedString, Type type)
    {
      return new XmlSerializer(type, "urn:ebay:apis:eBLBaseComponents").Deserialize((TextReader) new StringReader(pXmlizedString));
    }

    /// <summary>
    /// Gets or sets the ApiContext of the call of type <see cref="P:eBay.Service.EPS.eBayPictureService.ApiContext" />.
    /// </summary>
    public ApiContext ApiContext
    {
      get => this.mApiContext;
      set => this.mApiContext = value;
    }
  }
}
