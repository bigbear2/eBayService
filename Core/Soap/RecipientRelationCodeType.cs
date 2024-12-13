// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RecipientRelationCodeType
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
  public enum RecipientRelationCodeType
  {
    /// <remarks />
    [XmlEnum("1")] Item1,
    /// <remarks />
    [XmlEnum("2")] Item2,
    /// <remarks />
    [XmlEnum("3")] Item3,
    /// <remarks />
    [XmlEnum("4")] Item4,
    /// <remarks />
    CustomCode,
  }
}
