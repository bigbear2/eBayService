// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingServiceCostOverrideType
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
  public class ShippingServiceCostOverrideType
  {
    private int mShippingServicePriority;
    private bool mShippingServicePrioritySpecified;
    private ShippingServiceType mShippingServiceType;
    private bool mShippingServiceTypeSpecified;
    private XmlElementCollection mAny;
    private AmountType mShippingServiceCost;
    private AmountType mShippingServiceAdditionalCost;
    private AmountType mShippingSurcharge;

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
    public ShippingServiceType ShippingServiceType
    {
      get => this.mShippingServiceType;
      set
      {
        this.mShippingServiceType = value;
        this.mShippingServiceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingServiceTypeSpecified
    {
      get => this.mShippingServiceTypeSpecified;
      set => this.mShippingServiceTypeSpecified = value;
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
    public AmountType ShippingSurcharge
    {
      get => this.mShippingSurcharge;
      set => this.mShippingSurcharge = value;
    }
  }
}
