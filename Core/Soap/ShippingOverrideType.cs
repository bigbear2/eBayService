// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingOverrideType
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
  public class ShippingOverrideType
  {
    private ShippingServiceCostOverrideListType mShippingServiceCostOverrideList;
    private int mDispatchTimeMaxOverride;
    private bool mDispatchTimeMaxOverrideSpecified;

    /// <summary>
    /// 
    /// </summary>
    public ShippingServiceCostOverrideListType ShippingServiceCostOverrideList
    {
      get => this.mShippingServiceCostOverrideList;
      set => this.mShippingServiceCostOverrideList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DispatchTimeMaxOverride
    {
      get => this.mDispatchTimeMaxOverride;
      set
      {
        this.mDispatchTimeMaxOverride = value;
        this.mDispatchTimeMaxOverrideSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DispatchTimeMaxOverrideSpecified
    {
      get => this.mDispatchTimeMaxOverrideSpecified;
      set => this.mDispatchTimeMaxOverrideSpecified = value;
    }
  }
}
