// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerProductInventoryStatusType
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
  public class SellingManagerProductInventoryStatusType
  {
    private int mQuantityScheduled;
    private bool mQuantityScheduledSpecified;
    private int mQuantityActive;
    private bool mQuantityActiveSpecified;
    private int mQuantitySold;
    private bool mQuantitySoldSpecified;
    private int mQuantityUnsold;
    private bool mQuantityUnsoldSpecified;
    private float mSuccessPercent;
    private bool mSuccessPercentSpecified;
    private AmountType mAverageSellingPrice;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int QuantityScheduled
    {
      get => this.mQuantityScheduled;
      set
      {
        this.mQuantityScheduled = value;
        this.mQuantityScheduledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityScheduledSpecified
    {
      get => this.mQuantityScheduledSpecified;
      set => this.mQuantityScheduledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantityActive
    {
      get => this.mQuantityActive;
      set
      {
        this.mQuantityActive = value;
        this.mQuantityActiveSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityActiveSpecified
    {
      get => this.mQuantityActiveSpecified;
      set => this.mQuantityActiveSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantitySold
    {
      get => this.mQuantitySold;
      set
      {
        this.mQuantitySold = value;
        this.mQuantitySoldSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySoldSpecified
    {
      get => this.mQuantitySoldSpecified;
      set => this.mQuantitySoldSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantityUnsold
    {
      get => this.mQuantityUnsold;
      set
      {
        this.mQuantityUnsold = value;
        this.mQuantityUnsoldSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityUnsoldSpecified
    {
      get => this.mQuantityUnsoldSpecified;
      set => this.mQuantityUnsoldSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float SuccessPercent
    {
      get => this.mSuccessPercent;
      set
      {
        this.mSuccessPercent = value;
        this.mSuccessPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SuccessPercentSpecified
    {
      get => this.mSuccessPercentSpecified;
      set => this.mSuccessPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType AverageSellingPrice
    {
      get => this.mAverageSellingPrice;
      set => this.mAverageSellingPrice = value;
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
