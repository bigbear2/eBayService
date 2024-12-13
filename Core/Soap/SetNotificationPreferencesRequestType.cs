// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetNotificationPreferencesRequestType
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
  public class SetNotificationPreferencesRequestType : AbstractRequestType
  {
    private ApplicationDeliveryPreferencesType mApplicationDeliveryPreferences;
    private NotificationEnableTypeCollection mUserDeliveryPreferenceArray;
    private NotificationUserDataType mUserData;
    private NotificationEventPropertyTypeCollection mEventProperty;
    private string mDeliveryURLName;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences
    {
      get => this.mApplicationDeliveryPreferences;
      set => this.mApplicationDeliveryPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 1)]
    [XmlArrayItem("NotificationEnable", IsNullable = false)]
    public NotificationEnableTypeCollection UserDeliveryPreferenceArray
    {
      get => this.mUserDeliveryPreferenceArray;
      set => this.mUserDeliveryPreferenceArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public NotificationUserDataType UserData
    {
      get => this.mUserData;
      set => this.mUserData = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("EventProperty", Order = 3)]
    public NotificationEventPropertyTypeCollection EventProperty
    {
      get => this.mEventProperty;
      set => this.mEventProperty = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string DeliveryURLName
    {
      get => this.mDeliveryURLName;
      set => this.mDeliveryURLName = value;
    }
  }
}
