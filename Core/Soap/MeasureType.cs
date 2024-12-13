// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MeasureType
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
  public class MeasureType
  {
    private string munit;
    private MeasurementSystemCodeType mmeasurementSystem;
    private bool mmeasurementSystemSpecified;
    private Decimal mValue;

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute(DataType = "token")]
    public string unit
    {
      get => this.munit;
      set => this.munit = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public MeasurementSystemCodeType measurementSystem
    {
      get => this.mmeasurementSystem;
      set
      {
        this.mmeasurementSystem = value;
        this.mmeasurementSystemSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool measurementSystemSpecified
    {
      get => this.mmeasurementSystemSpecified;
      set => this.mmeasurementSystemSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlText]
    public Decimal Value
    {
      get => this.mValue;
      set => this.mValue = value;
    }
  }
}
