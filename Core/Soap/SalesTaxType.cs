// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SalesTaxType
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
  public class SalesTaxType
  {
    private float mSalesTaxPercent;
    private bool mSalesTaxPercentSpecified;
    private string mSalesTaxState;
    private bool mShippingIncludedInTax;
    private bool mShippingIncludedInTaxSpecified;
    private AmountType mSalesTaxAmount;
    private XmlElementCollection mAny;

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
    public string SalesTaxState
    {
      get => this.mSalesTaxState;
      set => this.mSalesTaxState = value;
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
    public AmountType SalesTaxAmount
    {
      get => this.mSalesTaxAmount;
      set => this.mSalesTaxAmount = value;
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
