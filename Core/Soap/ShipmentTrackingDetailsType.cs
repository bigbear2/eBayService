// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShipmentTrackingDetailsType
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
  public class ShipmentTrackingDetailsType
  {
    private string mShippingCarrierUsed;
    private string mShipmentTrackingNumber;
    private ShipmentLineItemType mShipmentLineItem;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ShippingCarrierUsed
    {
      get => this.mShippingCarrierUsed;
      set => this.mShippingCarrierUsed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShipmentTrackingNumber
    {
      get => this.mShipmentTrackingNumber;
      set => this.mShipmentTrackingNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShipmentLineItemType ShipmentLineItem
    {
      get => this.mShipmentLineItem;
      set => this.mShipmentLineItem = value;
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
