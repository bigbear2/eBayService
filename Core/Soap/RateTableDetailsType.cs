// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RateTableDetailsType
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
  public class RateTableDetailsType
  {
    private string mDomesticRateTable;
    private string mInternationalRateTable;
    private string mDomesticRateTableId;
    private string mInternationalRateTableId;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string DomesticRateTable
    {
      get => this.mDomesticRateTable;
      set => this.mDomesticRateTable = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalRateTable
    {
      get => this.mInternationalRateTable;
      set => this.mInternationalRateTable = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DomesticRateTableId
    {
      get => this.mDomesticRateTableId;
      set => this.mDomesticRateTableId = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalRateTableId
    {
      get => this.mInternationalRateTableId;
      set => this.mInternationalRateTableId = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
