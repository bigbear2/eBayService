// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NotificationStatisticsType
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
  public class NotificationStatisticsType
  {
    private int mDeliveredCount;
    private bool mDeliveredCountSpecified;
    private int mQueuedNewCount;
    private bool mQueuedNewCountSpecified;
    private int mQueuedPendingCount;
    private bool mQueuedPendingCountSpecified;
    private int mExpiredCount;
    private bool mExpiredCountSpecified;
    private int mErrorCount;
    private bool mErrorCountSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int DeliveredCount
    {
      get => this.mDeliveredCount;
      set
      {
        this.mDeliveredCount = value;
        this.mDeliveredCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeliveredCountSpecified
    {
      get => this.mDeliveredCountSpecified;
      set => this.mDeliveredCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QueuedNewCount
    {
      get => this.mQueuedNewCount;
      set
      {
        this.mQueuedNewCount = value;
        this.mQueuedNewCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QueuedNewCountSpecified
    {
      get => this.mQueuedNewCountSpecified;
      set => this.mQueuedNewCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QueuedPendingCount
    {
      get => this.mQueuedPendingCount;
      set
      {
        this.mQueuedPendingCount = value;
        this.mQueuedPendingCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QueuedPendingCountSpecified
    {
      get => this.mQueuedPendingCountSpecified;
      set => this.mQueuedPendingCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ExpiredCount
    {
      get => this.mExpiredCount;
      set
      {
        this.mExpiredCount = value;
        this.mExpiredCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpiredCountSpecified
    {
      get => this.mExpiredCountSpecified;
      set => this.mExpiredCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ErrorCount
    {
      get => this.mErrorCount;
      set
      {
        this.mErrorCount = value;
        this.mErrorCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ErrorCountSpecified
    {
      get => this.mErrorCountSpecified;
      set => this.mErrorCountSpecified = value;
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
