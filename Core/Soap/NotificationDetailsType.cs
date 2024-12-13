// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NotificationDetailsType
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
  public class NotificationDetailsType
  {
    private string mDeliveryURL;
    private string mReferenceID;
    private DateTime mExpirationTime;
    private bool mExpirationTimeSpecified;
    private NotificationEventTypeCodeType mType;
    private bool mTypeSpecified;
    private int mRetries;
    private bool mRetriesSpecified;
    private NotificationEventStateCodeType mDeliveryStatus;
    private bool mDeliveryStatusSpecified;
    private DateTime mNextRetryTime;
    private bool mNextRetryTimeSpecified;
    private DateTime mDeliveryTime;
    private bool mDeliveryTimeSpecified;
    private string mErrorMessage;
    private string mDeliveryURLName;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string DeliveryURL
    {
      get => this.mDeliveryURL;
      set => this.mDeliveryURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ReferenceID
    {
      get => this.mReferenceID;
      set => this.mReferenceID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpirationTime
    {
      get => this.mExpirationTime;
      set
      {
        this.mExpirationTime = value;
        this.mExpirationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpirationTimeSpecified
    {
      get => this.mExpirationTimeSpecified;
      set => this.mExpirationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NotificationEventTypeCodeType Type
    {
      get => this.mType;
      set
      {
        this.mType = value;
        this.mTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TypeSpecified
    {
      get => this.mTypeSpecified;
      set => this.mTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Retries
    {
      get => this.mRetries;
      set
      {
        this.mRetries = value;
        this.mRetriesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RetriesSpecified
    {
      get => this.mRetriesSpecified;
      set => this.mRetriesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NotificationEventStateCodeType DeliveryStatus
    {
      get => this.mDeliveryStatus;
      set
      {
        this.mDeliveryStatus = value;
        this.mDeliveryStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeliveryStatusSpecified
    {
      get => this.mDeliveryStatusSpecified;
      set => this.mDeliveryStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime NextRetryTime
    {
      get => this.mNextRetryTime;
      set
      {
        this.mNextRetryTime = value;
        this.mNextRetryTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NextRetryTimeSpecified
    {
      get => this.mNextRetryTimeSpecified;
      set => this.mNextRetryTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime DeliveryTime
    {
      get => this.mDeliveryTime;
      set
      {
        this.mDeliveryTime = value;
        this.mDeliveryTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeliveryTimeSpecified
    {
      get => this.mDeliveryTimeSpecified;
      set => this.mDeliveryTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ErrorMessage
    {
      get => this.mErrorMessage;
      set => this.mErrorMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DeliveryURLName
    {
      get => this.mDeliveryURLName;
      set => this.mDeliveryURLName = value;
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
