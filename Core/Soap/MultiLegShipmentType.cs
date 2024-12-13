// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MultiLegShipmentType
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
  public class MultiLegShipmentType
  {
    private MultiLegShippingServiceType mShippingServiceDetails;
    private AddressType mShipToAddress;
    private int mShippingTimeMin;
    private bool mShippingTimeMinSpecified;
    private int mShippingTimeMax;
    private bool mShippingTimeMaxSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public MultiLegShippingServiceType ShippingServiceDetails
    {
      get => this.mShippingServiceDetails;
      set => this.mShippingServiceDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType ShipToAddress
    {
      get => this.mShipToAddress;
      set => this.mShipToAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingTimeMin
    {
      get => this.mShippingTimeMin;
      set
      {
        this.mShippingTimeMin = value;
        this.mShippingTimeMinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTimeMinSpecified
    {
      get => this.mShippingTimeMinSpecified;
      set => this.mShippingTimeMinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingTimeMax
    {
      get => this.mShippingTimeMax;
      set
      {
        this.mShippingTimeMax = value;
        this.mShippingTimeMaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTimeMaxSpecified
    {
      get => this.mShippingTimeMaxSpecified;
      set => this.mShippingTimeMaxSpecified = value;
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
