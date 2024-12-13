// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddDisputeResponseRequestType
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
  public class AddDisputeResponseRequestType : AbstractRequestType
  {
    private string mDisputeID;
    private string mMessageText;
    private DisputeActivityCodeType mDisputeActivity;
    private bool mDisputeActivitySpecified;
    private string mShippingCarrierUsed;
    private string mShipmentTrackNumber;
    private DateTime mShippingTime;
    private bool mShippingTimeSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string DisputeID
    {
      get => this.mDisputeID;
      set => this.mDisputeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string MessageText
    {
      get => this.mMessageText;
      set => this.mMessageText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public DisputeActivityCodeType DisputeActivity
    {
      get => this.mDisputeActivity;
      set
      {
        this.mDisputeActivity = value;
        this.mDisputeActivitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeActivitySpecified
    {
      get => this.mDisputeActivitySpecified;
      set => this.mDisputeActivitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string ShippingCarrierUsed
    {
      get => this.mShippingCarrierUsed;
      set => this.mShippingCarrierUsed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string ShipmentTrackNumber
    {
      get => this.mShipmentTrackNumber;
      set => this.mShipmentTrackNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public DateTime ShippingTime
    {
      get => this.mShippingTime;
      set
      {
        this.mShippingTime = value;
        this.mShippingTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTimeSpecified
    {
      get => this.mShippingTimeSpecified;
      set => this.mShippingTimeSpecified = value;
    }
  }
}
