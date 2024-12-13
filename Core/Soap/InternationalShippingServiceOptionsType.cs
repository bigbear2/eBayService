﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.InternationalShippingServiceOptionsType
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
  public class InternationalShippingServiceOptionsType
  {
    private string mShippingService;
    private AmountType mShippingServiceCost;
    private AmountType mShippingServiceAdditionalCost;
    private int mShippingServicePriority;
    private bool mShippingServicePrioritySpecified;
    private StringCollection mShipToLocation;
    private AmountType mShippingInsuranceCost;
    private AmountType mImportCharge;
    private DateTime mShippingServiceCutOffTime;
    private bool mShippingServiceCutOffTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingService
    {
      get => this.mShippingService;
      set => this.mShippingService = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingServiceCost
    {
      get => this.mShippingServiceCost;
      set => this.mShippingServiceCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingServiceAdditionalCost
    {
      get => this.mShippingServiceAdditionalCost;
      set => this.mShippingServiceAdditionalCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingServicePriority
    {
      get => this.mShippingServicePriority;
      set
      {
        this.mShippingServicePriority = value;
        this.mShippingServicePrioritySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingServicePrioritySpecified
    {
      get => this.mShippingServicePrioritySpecified;
      set => this.mShippingServicePrioritySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShipToLocation")]
    public StringCollection ShipToLocation
    {
      get => this.mShipToLocation;
      set => this.mShipToLocation = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingInsuranceCost
    {
      get => this.mShippingInsuranceCost;
      set => this.mShippingInsuranceCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ImportCharge
    {
      get => this.mImportCharge;
      set => this.mImportCharge = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ShippingServiceCutOffTime
    {
      get => this.mShippingServiceCutOffTime;
      set
      {
        this.mShippingServiceCutOffTime = value;
        this.mShippingServiceCutOffTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingServiceCutOffTimeSpecified
    {
      get => this.mShippingServiceCutOffTimeSpecified;
      set => this.mShippingServiceCutOffTimeSpecified = value;
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
