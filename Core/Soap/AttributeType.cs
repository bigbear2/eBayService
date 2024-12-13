// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AttributeType
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
  public class AttributeType
  {
    private ValTypeCollection mValue;
    private XmlElementCollection mAny;
    private int mattributeID;
    private bool mattributeIDSpecified;
    private string mattributeLabel;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Value")]
    public ValTypeCollection Value
    {
      get => this.mValue;
      set => this.mValue = value;
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
    public int attributeID
    {
      get => this.mattributeID;
      set
      {
        this.mattributeID = value;
        this.mattributeIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool attributeIDSpecified
    {
      get => this.mattributeIDSpecified;
      set => this.mattributeIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string attributeLabel
    {
      get => this.mattributeLabel;
      set => this.mattributeLabel = value;
    }
  }
}
