// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ApplicationDeliveryPreferencesType
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
  public class ApplicationDeliveryPreferencesType
  {
    private string mApplicationURL;
    private EnableCodeType mApplicationEnable;
    private bool mApplicationEnableSpecified;
    private string mAlertEmail;
    private EnableCodeType mAlertEnable;
    private bool mAlertEnableSpecified;
    private NotificationPayloadTypeCodeType mNotificationPayloadType;
    private bool mNotificationPayloadTypeSpecified;
    private DeviceTypeCodeType mDeviceType;
    private bool mDeviceTypeSpecified;
    private string mPayloadVersion;
    private DeliveryURLDetailTypeCollection mDeliveryURLDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ApplicationURL
    {
      get => this.mApplicationURL;
      set => this.mApplicationURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EnableCodeType ApplicationEnable
    {
      get => this.mApplicationEnable;
      set
      {
        this.mApplicationEnable = value;
        this.mApplicationEnableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ApplicationEnableSpecified
    {
      get => this.mApplicationEnableSpecified;
      set => this.mApplicationEnableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string AlertEmail
    {
      get => this.mAlertEmail;
      set => this.mAlertEmail = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EnableCodeType AlertEnable
    {
      get => this.mAlertEnable;
      set
      {
        this.mAlertEnable = value;
        this.mAlertEnableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AlertEnableSpecified
    {
      get => this.mAlertEnableSpecified;
      set => this.mAlertEnableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public NotificationPayloadTypeCodeType NotificationPayloadType
    {
      get => this.mNotificationPayloadType;
      set
      {
        this.mNotificationPayloadType = value;
        this.mNotificationPayloadTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NotificationPayloadTypeSpecified
    {
      get => this.mNotificationPayloadTypeSpecified;
      set => this.mNotificationPayloadTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DeviceTypeCodeType DeviceType
    {
      get => this.mDeviceType;
      set
      {
        this.mDeviceType = value;
        this.mDeviceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeviceTypeSpecified
    {
      get => this.mDeviceTypeSpecified;
      set => this.mDeviceTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PayloadVersion
    {
      get => this.mPayloadVersion;
      set => this.mPayloadVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DeliveryURLDetails")]
    public DeliveryURLDetailTypeCollection DeliveryURLDetails
    {
      get => this.mDeliveryURLDetails;
      set => this.mDeliveryURLDetails = value;
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
