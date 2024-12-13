// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.AfterRequestEventArgs
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class AfterRequestEventArgs : EventArgs
  {
    private AbstractResponseType mResponse;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="AbstractResponse">The <see cref="P:eBay.Service.Core.Sdk.AfterRequestEventArgs.AbstractResponse" /> for this API Call.</param>
    public AfterRequestEventArgs(AbstractResponseType AbstractResponse)
    {
      this.mResponse = AbstractResponse;
    }

    /// <summary>
    /// Gets the Response for this API call of type <see cref="T:eBay.Service.Core.Soap.AbstractResponseType" />.
    /// </summary>
    public AbstractResponseType AbstractResponse => this.mResponse;
  }
}
