// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.SdkException
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
  /// SdkException is used for general exceptions related to SDK kernel itself.
  /// For example, if a token is not set the exception will be wrapped as SdkException.
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  [Serializable]
  public class SdkException : ApplicationException, ISerializable
  {
    /// <summary>
    /// 
    /// </summary>
    public SdkException()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    public SdkException(string message)
      : base(message)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message">A message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception.</param>
    public SdkException(string message, Exception inner)
      : base(message, inner)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="info">The object that holds the serialized object data.</param>
    /// <param name="context">The contextual information about the source or destination.</param>
    protected SdkException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      base.GetObjectData(info, context);
    }
  }
}
