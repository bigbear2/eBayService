// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TransactionReferenceType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class TransactionReferenceType
  {
    private TransactionReferenceCodeType mtype;
    private bool mtypeSpecified;
    private string mValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public TransactionReferenceCodeType type
    {
      get => this.mtype;
      set
      {
        this.mtype = value;
        this.mtypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool typeSpecified
    {
      get => this.mtypeSpecified;
      set => this.mtypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    public string Value
    {
      get => this.mValue;
      set => this.mValue = value;
    }
  }
}
