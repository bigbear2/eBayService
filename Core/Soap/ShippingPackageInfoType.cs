// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingPackageInfoType
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
  public class ShippingPackageInfoType
  {
    private string mStoreID;
    private string mShippingTrackingEvent;
    private DateTime mScheduledDeliveryTimeMin;
    private bool mScheduledDeliveryTimeMinSpecified;
    private DateTime mScheduledDeliveryTimeMax;
    private bool mScheduledDeliveryTimeMaxSpecified;
    private DateTime mActualDeliveryTime;
    private bool mActualDeliveryTimeSpecified;
    private DateTime mEstimatedDeliveryTimeMin;
    private bool mEstimatedDeliveryTimeMinSpecified;
    private DateTime mEstimatedDeliveryTimeMax;
    private bool mEstimatedDeliveryTimeMaxSpecified;
    private DateTime mHandleByTime;
    private bool mHandleByTimeSpecified;
    private DateTime mMinNativeEstimatedDeliveryTime;
    private bool mMinNativeEstimatedDeliveryTimeSpecified;
    private DateTime mMaxNativeEstimatedDeliveryTime;
    private bool mMaxNativeEstimatedDeliveryTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string StoreID
    {
      get => this.mStoreID;
      set => this.mStoreID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingTrackingEvent
    {
      get => this.mShippingTrackingEvent;
      set => this.mShippingTrackingEvent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ScheduledDeliveryTimeMin
    {
      get => this.mScheduledDeliveryTimeMin;
      set
      {
        this.mScheduledDeliveryTimeMin = value;
        this.mScheduledDeliveryTimeMinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ScheduledDeliveryTimeMinSpecified
    {
      get => this.mScheduledDeliveryTimeMinSpecified;
      set => this.mScheduledDeliveryTimeMinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ScheduledDeliveryTimeMax
    {
      get => this.mScheduledDeliveryTimeMax;
      set
      {
        this.mScheduledDeliveryTimeMax = value;
        this.mScheduledDeliveryTimeMaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ScheduledDeliveryTimeMaxSpecified
    {
      get => this.mScheduledDeliveryTimeMaxSpecified;
      set => this.mScheduledDeliveryTimeMaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ActualDeliveryTime
    {
      get => this.mActualDeliveryTime;
      set
      {
        this.mActualDeliveryTime = value;
        this.mActualDeliveryTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActualDeliveryTimeSpecified
    {
      get => this.mActualDeliveryTimeSpecified;
      set => this.mActualDeliveryTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EstimatedDeliveryTimeMin
    {
      get => this.mEstimatedDeliveryTimeMin;
      set
      {
        this.mEstimatedDeliveryTimeMin = value;
        this.mEstimatedDeliveryTimeMinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EstimatedDeliveryTimeMinSpecified
    {
      get => this.mEstimatedDeliveryTimeMinSpecified;
      set => this.mEstimatedDeliveryTimeMinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EstimatedDeliveryTimeMax
    {
      get => this.mEstimatedDeliveryTimeMax;
      set
      {
        this.mEstimatedDeliveryTimeMax = value;
        this.mEstimatedDeliveryTimeMaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EstimatedDeliveryTimeMaxSpecified
    {
      get => this.mEstimatedDeliveryTimeMaxSpecified;
      set => this.mEstimatedDeliveryTimeMaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime HandleByTime
    {
      get => this.mHandleByTime;
      set
      {
        this.mHandleByTime = value;
        this.mHandleByTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HandleByTimeSpecified
    {
      get => this.mHandleByTimeSpecified;
      set => this.mHandleByTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime MinNativeEstimatedDeliveryTime
    {
      get => this.mMinNativeEstimatedDeliveryTime;
      set
      {
        this.mMinNativeEstimatedDeliveryTime = value;
        this.mMinNativeEstimatedDeliveryTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinNativeEstimatedDeliveryTimeSpecified
    {
      get => this.mMinNativeEstimatedDeliveryTimeSpecified;
      set => this.mMinNativeEstimatedDeliveryTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime MaxNativeEstimatedDeliveryTime
    {
      get => this.mMaxNativeEstimatedDeliveryTime;
      set
      {
        this.mMaxNativeEstimatedDeliveryTime = value;
        this.mMaxNativeEstimatedDeliveryTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxNativeEstimatedDeliveryTimeSpecified
    {
      get => this.mMaxNativeEstimatedDeliveryTimeSpecified;
      set => this.mMaxNativeEstimatedDeliveryTimeSpecified = value;
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
