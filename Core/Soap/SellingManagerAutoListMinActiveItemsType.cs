// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAutoListMinActiveItemsType
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
  public class SellingManagerAutoListMinActiveItemsType
  {
    private int mMinActiveItemCount;
    private bool mMinActiveItemCountSpecified;
    private DateTime mListTimeFrom;
    private bool mListTimeFromSpecified;
    private DateTime mListTimeTo;
    private bool mListTimeToSpecified;
    private int mSpacingIntervalInMinutes;
    private bool mSpacingIntervalInMinutesSpecified;
    private int mListingHoldInventoryLevel;
    private bool mListingHoldInventoryLevelSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int MinActiveItemCount
    {
      get => this.mMinActiveItemCount;
      set
      {
        this.mMinActiveItemCount = value;
        this.mMinActiveItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinActiveItemCountSpecified
    {
      get => this.mMinActiveItemCountSpecified;
      set => this.mMinActiveItemCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime ListTimeFrom
    {
      get => this.mListTimeFrom;
      set
      {
        this.mListTimeFrom = value;
        this.mListTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListTimeFromSpecified
    {
      get => this.mListTimeFromSpecified;
      set => this.mListTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime ListTimeTo
    {
      get => this.mListTimeTo;
      set
      {
        this.mListTimeTo = value;
        this.mListTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListTimeToSpecified
    {
      get => this.mListTimeToSpecified;
      set => this.mListTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int SpacingIntervalInMinutes
    {
      get => this.mSpacingIntervalInMinutes;
      set
      {
        this.mSpacingIntervalInMinutes = value;
        this.mSpacingIntervalInMinutesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SpacingIntervalInMinutesSpecified
    {
      get => this.mSpacingIntervalInMinutesSpecified;
      set => this.mSpacingIntervalInMinutesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ListingHoldInventoryLevel
    {
      get => this.mListingHoldInventoryLevel;
      set
      {
        this.mListingHoldInventoryLevel = value;
        this.mListingHoldInventoryLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingHoldInventoryLevelSpecified
    {
      get => this.mListingHoldInventoryLevelSpecified;
      set => this.mListingHoldInventoryLevelSpecified = value;
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
