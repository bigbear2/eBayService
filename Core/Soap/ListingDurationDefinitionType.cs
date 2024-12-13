// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingDurationDefinitionType
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
  public class ListingDurationDefinitionType
  {
    private StringCollection mDuration;
    private XmlElementCollection mAny;
    private int mdurationSetID;
    private bool mdurationSetIDSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Duration", DataType = "token")]
    public StringCollection Duration
    {
      get => this.mDuration;
      set => this.mDuration = value;
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

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int durationSetID
    {
      get => this.mdurationSetID;
      set
      {
        this.mdurationSetID = value;
        this.mdurationSetIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool durationSetIDSpecified
    {
      get => this.mdurationSetIDSpecified;
      set => this.mdurationSetIDSpecified = value;
    }
  }
}
