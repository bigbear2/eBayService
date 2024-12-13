// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DigitalDeliverySelectedType
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
  public class DigitalDeliverySelectedType
  {
    private string mDeliveryMethod;
    private DeliveryStatusType mDeliveryStatus;
    private DeliveryDetailsType mDeliveryDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string DeliveryMethod
    {
      get => this.mDeliveryMethod;
      set => this.mDeliveryMethod = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DeliveryStatusType DeliveryStatus
    {
      get => this.mDeliveryStatus;
      set => this.mDeliveryStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DeliveryDetailsType DeliveryDetails
    {
      get => this.mDeliveryDetails;
      set => this.mDeliveryDetails = value;
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
