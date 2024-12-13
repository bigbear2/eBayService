// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TaxJurisdictionType
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
  public class TaxJurisdictionType
  {
    private string mJurisdictionID;
    private float mSalesTaxPercent;
    private bool mSalesTaxPercentSpecified;
    private bool mShippingIncludedInTax;
    private bool mShippingIncludedInTaxSpecified;
    private string mJurisdictionName;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string JurisdictionID
    {
      get => this.mJurisdictionID;
      set => this.mJurisdictionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float SalesTaxPercent
    {
      get => this.mSalesTaxPercent;
      set
      {
        this.mSalesTaxPercent = value;
        this.mSalesTaxPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SalesTaxPercentSpecified
    {
      get => this.mSalesTaxPercentSpecified;
      set => this.mSalesTaxPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShippingIncludedInTax
    {
      get => this.mShippingIncludedInTax;
      set
      {
        this.mShippingIncludedInTax = value;
        this.mShippingIncludedInTaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingIncludedInTaxSpecified
    {
      get => this.mShippingIncludedInTaxSpecified;
      set => this.mShippingIncludedInTaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string JurisdictionName
    {
      get => this.mJurisdictionName;
      set => this.mJurisdictionName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
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
