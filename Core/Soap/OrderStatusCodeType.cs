// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.OrderStatusCodeType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public enum OrderStatusCodeType
  {
    /// <remarks />
    Active,
    /// <remarks />
    Inactive,
    /// <remarks />
    Completed,
    /// <remarks />
    Cancelled,
    /// <remarks />
    Shipped,
    /// <remarks />
    Default,
    /// <remarks />
    Authenticated,
    /// <remarks />
    InProcess,
    /// <remarks />
    Invalid,
    /// <remarks />
    CustomCode,
    /// <remarks />
    All,
    /// <remarks />
    CancelPending,
  }
}
