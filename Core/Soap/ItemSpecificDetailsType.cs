// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemSpecificDetailsType
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
  public class ItemSpecificDetailsType
  {
    private int mMaxItemSpecificsPerItem;
    private bool mMaxItemSpecificsPerItemSpecified;
    private int mMaxValuesPerName;
    private bool mMaxValuesPerNameSpecified;
    private int mMaxCharactersPerValue;
    private bool mMaxCharactersPerValueSpecified;
    private int mMaxCharactersPerName;
    private bool mMaxCharactersPerNameSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int MaxItemSpecificsPerItem
    {
      get => this.mMaxItemSpecificsPerItem;
      set
      {
        this.mMaxItemSpecificsPerItem = value;
        this.mMaxItemSpecificsPerItemSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxItemSpecificsPerItemSpecified
    {
      get => this.mMaxItemSpecificsPerItemSpecified;
      set => this.mMaxItemSpecificsPerItemSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxValuesPerName
    {
      get => this.mMaxValuesPerName;
      set
      {
        this.mMaxValuesPerName = value;
        this.mMaxValuesPerNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxValuesPerNameSpecified
    {
      get => this.mMaxValuesPerNameSpecified;
      set => this.mMaxValuesPerNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxCharactersPerValue
    {
      get => this.mMaxCharactersPerValue;
      set
      {
        this.mMaxCharactersPerValue = value;
        this.mMaxCharactersPerValueSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxCharactersPerValueSpecified
    {
      get => this.mMaxCharactersPerValueSpecified;
      set => this.mMaxCharactersPerValueSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxCharactersPerName
    {
      get => this.mMaxCharactersPerName;
      set
      {
        this.mMaxCharactersPerName = value;
        this.mMaxCharactersPerNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxCharactersPerNameSpecified
    {
      get => this.mMaxCharactersPerNameSpecified;
      set => this.mMaxCharactersPerNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
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
