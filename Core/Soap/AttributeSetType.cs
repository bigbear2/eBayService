// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AttributeSetType
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
  public class AttributeSetType
  {
    private AttributeTypeCollection mAttribute;
    private XmlElementCollection mAny;
    private int mattributeSetID;
    private bool mattributeSetIDSpecified;
    private string mattributeSetVersion;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Attribute")]
    public AttributeTypeCollection Attribute
    {
      get => this.mAttribute;
      set => this.mAttribute = value;
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
    public int attributeSetID
    {
      get => this.mattributeSetID;
      set
      {
        this.mattributeSetID = value;
        this.mattributeSetIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool attributeSetIDSpecified
    {
      get => this.mattributeSetIDSpecified;
      set => this.mattributeSetIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string attributeSetVersion
    {
      get => this.mattributeSetVersion;
      set => this.mattributeSetVersion = value;
    }
  }
}
