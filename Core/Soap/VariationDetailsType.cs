// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VariationDetailsType
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
  public class VariationDetailsType
  {
    private int mMaxVariationsPerItem;
    private bool mMaxVariationsPerItemSpecified;
    private int mMaxNamesPerVariationSpecificsSet;
    private bool mMaxNamesPerVariationSpecificsSetSpecified;
    private int mMaxValuesPerVariationSpecificsSetName;
    private bool mMaxValuesPerVariationSpecificsSetNameSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int MaxVariationsPerItem
    {
      get => this.mMaxVariationsPerItem;
      set
      {
        this.mMaxVariationsPerItem = value;
        this.mMaxVariationsPerItemSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxVariationsPerItemSpecified
    {
      get => this.mMaxVariationsPerItemSpecified;
      set => this.mMaxVariationsPerItemSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxNamesPerVariationSpecificsSet
    {
      get => this.mMaxNamesPerVariationSpecificsSet;
      set
      {
        this.mMaxNamesPerVariationSpecificsSet = value;
        this.mMaxNamesPerVariationSpecificsSetSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxNamesPerVariationSpecificsSetSpecified
    {
      get => this.mMaxNamesPerVariationSpecificsSetSpecified;
      set => this.mMaxNamesPerVariationSpecificsSetSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxValuesPerVariationSpecificsSetName
    {
      get => this.mMaxValuesPerVariationSpecificsSetName;
      set
      {
        this.mMaxValuesPerVariationSpecificsSetName = value;
        this.mMaxValuesPerVariationSpecificsSetNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxValuesPerVariationSpecificsSetNameSpecified
    {
      get => this.mMaxValuesPerVariationSpecificsSetNameSpecified;
      set => this.mMaxValuesPerVariationSpecificsSetNameSpecified = value;
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
