// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Sdk.TokenHardExpirationEventArgs
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Core.Sdk
{
  /// <summary>
  /// 
  /// </summary>
  [ComVisible(false)]
  public class TokenHardExpirationEventArgs : EventArgs
  {
    private DateTime mExpirationDate;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ExpirationDate">The time the token expires of type <see cref="T:System.DateTime" />.</param>
    public TokenHardExpirationEventArgs(DateTime ExpirationDate)
    {
      this.mExpirationDate = ExpirationDate;
    }

    /// <summary>Gets the time the token will expire.</summary>
    public DateTime ExpirationDate => this.mExpirationDate;
  }
}
