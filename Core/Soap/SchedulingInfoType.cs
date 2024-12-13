// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SchedulingInfoType
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
  public class SchedulingInfoType
  {
    private int mMaxScheduledMinutes;
    private bool mMaxScheduledMinutesSpecified;
    private int mMinScheduledMinutes;
    private bool mMinScheduledMinutesSpecified;
    private int mMaxScheduledItems;
    private bool mMaxScheduledItemsSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int MaxScheduledMinutes
    {
      get => this.mMaxScheduledMinutes;
      set
      {
        this.mMaxScheduledMinutes = value;
        this.mMaxScheduledMinutesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxScheduledMinutesSpecified
    {
      get => this.mMaxScheduledMinutesSpecified;
      set => this.mMaxScheduledMinutesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MinScheduledMinutes
    {
      get => this.mMinScheduledMinutes;
      set
      {
        this.mMinScheduledMinutes = value;
        this.mMinScheduledMinutesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinScheduledMinutesSpecified
    {
      get => this.mMinScheduledMinutesSpecified;
      set => this.mMinScheduledMinutesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxScheduledItems
    {
      get => this.mMaxScheduledItems;
      set
      {
        this.mMaxScheduledItems = value;
        this.mMaxScheduledItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxScheduledItemsSpecified
    {
      get => this.mMaxScheduledItemsSpecified;
      set => this.mMaxScheduledItemsSpecified = value;
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
