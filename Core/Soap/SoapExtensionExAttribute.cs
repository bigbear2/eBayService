// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SoapExtensionExAttribute
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.Web.Services.Protocols;


namespace eBay.Service.Core.Soap
{
  /// <summary>
  /// 
  /// </summary>
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class SoapExtensionExAttribute : SoapExtensionAttribute
  {
    private int mPriority;

    /// <summary>
    /// 
    /// </summary>
    public override int Priority
    {
      get => this.mPriority;
      set => this.mPriority = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public override Type ExtensionType => typeof (SoapExtensionEx);
  }
}
