// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CharacteristicType
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
  public class CharacteristicType
  {
    private int mAttributeID;
    private string mDateFormat;
    private string mDisplaySequence;
    private string mDisplayUOM;
    private LabelType mLabel;
    private SortOrderCodeType mSortOrder;
    private bool mSortOrderSpecified;
    private ValTypeCollection mValueList;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int AttributeID
    {
      get => this.mAttributeID;
      set => this.mAttributeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DateFormat
    {
      get => this.mDateFormat;
      set => this.mDateFormat = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DisplaySequence
    {
      get => this.mDisplaySequence;
      set => this.mDisplaySequence = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DisplayUOM
    {
      get => this.mDisplayUOM;
      set => this.mDisplayUOM = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public LabelType Label
    {
      get => this.mLabel;
      set => this.mLabel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SortOrderCodeType SortOrder
    {
      get => this.mSortOrder;
      set
      {
        this.mSortOrder = value;
        this.mSortOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortOrderSpecified
    {
      get => this.mSortOrderSpecified;
      set => this.mSortOrderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ValueList")]
    public ValTypeCollection ValueList
    {
      get => this.mValueList;
      set => this.mValueList = value;
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
