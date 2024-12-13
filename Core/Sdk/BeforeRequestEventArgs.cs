// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.BeforeRequestEventArgs
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
  public class BeforeRequestEventArgs : EventArgs
  {
    private AbstractRequestType mRequest;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="AbstractRequest">The <see cref="P:eBay.Service.Core.Sdk.BeforeRequestEventArgs.AbstractRequest" /> for this API Call.</param>
    public BeforeRequestEventArgs(AbstractRequestType AbstractRequest)
    {
      this.mRequest = AbstractRequest;
    }

    /// <summary>
    /// Gets or sets the Request for this API call of type <see cref="T:eBay.Service.Core.Soap.AbstractRequestType" />.
    /// </summary>
    public AbstractRequestType AbstractRequest
    {
      get => this.mRequest;
      set => this.mRequest = value;
    }
  }
}
