// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CharacteristicsSetType
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
  public class CharacteristicsSetType
  {
    private string mName;
    private int mAttributeSetID;
    private bool mAttributeSetIDSpecified;
    private string mAttributeSetVersion;
    private CharacteristicTypeCollection mCharacteristics;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int AttributeSetID
    {
      get => this.mAttributeSetID;
      set
      {
        this.mAttributeSetID = value;
        this.mAttributeSetIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AttributeSetIDSpecified
    {
      get => this.mAttributeSetIDSpecified;
      set => this.mAttributeSetIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AttributeSetVersion
    {
      get => this.mAttributeSetVersion;
      set => this.mAttributeSetVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Characteristics")]
    public CharacteristicTypeCollection Characteristics
    {
      get => this.mCharacteristics;
      set => this.mCharacteristics = value;
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
