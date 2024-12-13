// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingServiceOptionsType
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
  public class ShippingServiceOptionsType
  {
    private AmountType mShippingInsuranceCost;
    private string mShippingService;
    private AmountType mShippingServiceCost;
    private AmountType mShippingServiceAdditionalCost;
    private int mShippingServicePriority;
    private bool mShippingServicePrioritySpecified;
    private bool mExpeditedService;
    private bool mExpeditedServiceSpecified;
    private int mShippingTimeMin;
    private bool mShippingTimeMinSpecified;
    private int mShippingTimeMax;
    private bool mShippingTimeMaxSpecified;
    private bool mFreeShipping;
    private bool mFreeShippingSpecified;
    private bool mLocalPickup;
    private bool mLocalPickupSpecified;
    private AmountType mImportCharge;
    private ShippingPackageInfoTypeCollection mShippingPackageInfo;
    private DateTime mShippingServiceCutOffTime;
    private bool mShippingServiceCutOffTimeSpecified;
    private string mLogisticPlanType;
    private XmlElementCollection mAny;

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
    public bool ExpeditedService
    {
      get => this.mExpeditedService;
      set
      {
        this.mExpeditedService = value;
        this.mExpeditedServiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpeditedServiceSpecified
    {
      get => this.mExpeditedServiceSpecified;
      set => this.mExpeditedServiceSpecified = value;
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
    public bool FreeShipping
    {
      get => this.mFreeShipping;
      set
      {
        this.mFreeShipping = value;
        this.mFreeShippingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FreeShippingSpecified
    {
      get => this.mFreeShippingSpecified;
      set => this.mFreeShippingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LocalPickup
    {
      get => this.mLocalPickup;
      set
      {
        this.mLocalPickup = value;
        this.mLocalPickupSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LocalPickupSpecified
    {
      get => this.mLocalPickupSpecified;
      set => this.mLocalPickupSpecified = value;
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
    [XmlElement("ShippingPackageInfo")]
    public ShippingPackageInfoTypeCollection ShippingPackageInfo
    {
      get => this.mShippingPackageInfo;
      set => this.mShippingPackageInfo = value;
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
    public string LogisticPlanType
    {
      get => this.mLogisticPlanType;
      set => this.mLogisticPlanType = value;
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
