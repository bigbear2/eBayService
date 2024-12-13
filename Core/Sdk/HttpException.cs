// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.HttpException
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  ///  Wraps HTTP errors (unexpected return codes 300 - 499, 501-599) for SDK.
  ///  The HTTP status code is available in the StatusCode property.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Serializable]
  public class HttpException : SdkException, ISerializable
  {
    private int mCode;

    /// <summary>Default constructor.</summary>
    public HttpException()
    {
    }

    /// <summary>
    /// Construct an HttpException described by the specified message.
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    public HttpException(string message)
      : base(message)
    {
    }

    /// <summary>
    /// Construct an HttpException wrapping the given exception, and described by the specified message.
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception.</param>
    public HttpException(string message, Exception inner)
      : base(message, inner)
    {
    }

    /// <summary>
    /// Construct an HttpException with the specified HTTP status code.
    /// </summary>
    /// <param name="code">The HTTP status code associated with the exception.</param>
    public HttpException(int code) => this.mCode = code;

    /// <summary>
    /// Deserialize an HttpException from serialized state information.
    /// </summary>
    /// <param name="info">The object that holds the serialized object data.</param>
    /// <param name="context">The contextual information about the source or destination.</param>
    protected HttpException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
      this.mCode = (int) info.GetValue(nameof (mCode), typeof (int));
    }

    /// <summary>Serialize an HttpException.</summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      info.AddValue("mCode", (object) this.mCode, typeof (int));
      base.GetObjectData(info, context);
    }

    /// <summary>
    /// Read-only property providing the StatusCode of the HttpException.
    /// </summary>
    public int StatusCode => this.mCode;
  }
}
