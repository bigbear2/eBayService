// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SoapExtensionEx
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Web.Services.Protocols;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  public class SoapExtensionEx : SoapExtension
  {
    private Stream mStrOld;
    private Stream mStrNew;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="MethodInfo"></param>
    /// <param name="Attribute"></param>
    /// <returns></returns>
    public override object GetInitializer(
      LogicalMethodInfo MethodInfo,
      SoapExtensionAttribute Attribute)
    {
      return (object) null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ServiceType"></param>
    /// <returns></returns>
    public override object GetInitializer(Type ServiceType) => (object) typeof (SoapExtensionEx);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Initializer"></param>
    public override void Initialize(object Initializer)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    public override void ProcessMessage(SoapMessage Message)
    {
      if (Message.Stage == SoapMessageStage.BeforeSerialize)
        return;
      if (Message.Stage == SoapMessageStage.AfterSerialize)
      {
        this.SaveRequestMessage(Message);
        this.Copy(this.mStrNew, this.mStrOld);
      }
      else if (Message.Stage == SoapMessageStage.BeforeDeserialize)
        this.SaveResponseMessage(Message);
      else if (Message.Stage != SoapMessageStage.AfterDeserialize)
        throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Invalid Soap Message stage [{0}]", (object) Message.Stage), nameof (Message));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="StrFrom"></param>
    public override Stream ChainStream(Stream StrFrom)
    {
      this.mStrOld = StrFrom;
      this.mStrNew = (Stream) new MemoryStream();
      return this.mStrNew;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    private void SaveRequestMessage(SoapMessage Message)
    {
      UTF8Encoding utF8Encoding = new UTF8Encoding();
      this.mStrNew.Position = 0L;
      byte[] numArray = new byte[this.mStrNew.Length];
      this.mStrNew.Read(numArray, 0, numArray.Length);
      ((SoapHttpClientProtocolEx) ((SoapClientMessage) Message).Client).SoapRequest = utF8Encoding.GetString(numArray);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Message"></param>
    private void SaveResponseMessage(SoapMessage Message)
    {
      UTF8Encoding utF8Encoding = new UTF8Encoding();
      Stream stream = (Stream) new MemoryStream();
      this.Copy(this.mStrOld, stream);
      byte[] numArray = new byte[stream.Length];
      stream.Read(numArray, 0, numArray.Length);
      ((SoapHttpClientProtocolEx) ((SoapClientMessage) Message).Client).SoapResponse = utF8Encoding.GetString(numArray);
      this.Copy(stream, this.mStrNew);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="StrFrom"></param>
    /// <param name="StrTo"></param>
    private void Copy(Stream StrFrom, Stream StrTo)
    {
      if (StrFrom.CanSeek)
        StrFrom.Position = 0L;
      TextReader textReader = (TextReader) new StreamReader(StrFrom);
      StreamWriter streamWriter = new StreamWriter(StrTo);
      streamWriter.WriteLine(textReader.ReadToEnd());
      streamWriter.Flush();
      if (!StrTo.CanSeek)
        return;
      StrTo.Position = 0L;
    }
  }
}
