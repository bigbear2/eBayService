// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PickupInStoreDetailsType
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
  public class PickupInStoreDetailsType
  {
    private bool mEligibleForPickupInStore;
    private bool mEligibleForPickupInStoreSpecified;
    private bool mEligibleForPickupDropOff;
    private bool mEligibleForPickupDropOffSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleForPickupInStore
    {
      get => this.mEligibleForPickupInStore;
      set
      {
        this.mEligibleForPickupInStore = value;
        this.mEligibleForPickupInStoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleForPickupInStoreSpecified
    {
      get => this.mEligibleForPickupInStoreSpecified;
      set => this.mEligibleForPickupInStoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleForPickupDropOff
    {
      get => this.mEligibleForPickupDropOff;
      set
      {
        this.mEligibleForPickupDropOff = value;
        this.mEligibleForPickupDropOffSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleForPickupDropOffSpecified
    {
      get => this.mEligibleForPickupDropOffSpecified;
      set => this.mEligibleForPickupDropOffSpecified = value;
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
