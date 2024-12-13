// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TaxDetailsType
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
  public class TaxDetailsType
  {
    private TaxTypeCodeType mImposition;
    private bool mImpositionSpecified;
    private TaxDescriptionCodeType mTaxDescription;
    private bool mTaxDescriptionSpecified;
    private AmountType mTaxAmount;
    private AmountType mTaxOnSubtotalAmount;
    private AmountType mTaxOnShippingAmount;
    private AmountType mTaxOnHandlingAmount;
    private string mTaxCode;
    private CollectionMethodCodeType mCollectionMethod;
    private bool mCollectionMethodSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public TaxTypeCodeType Imposition
    {
      get => this.mImposition;
      set
      {
        this.mImposition = value;
        this.mImpositionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ImpositionSpecified
    {
      get => this.mImpositionSpecified;
      set => this.mImpositionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TaxDescriptionCodeType TaxDescription
    {
      get => this.mTaxDescription;
      set
      {
        this.mTaxDescription = value;
        this.mTaxDescriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TaxDescriptionSpecified
    {
      get => this.mTaxDescriptionSpecified;
      set => this.mTaxDescriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TaxAmount
    {
      get => this.mTaxAmount;
      set => this.mTaxAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TaxOnSubtotalAmount
    {
      get => this.mTaxOnSubtotalAmount;
      set => this.mTaxOnSubtotalAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TaxOnShippingAmount
    {
      get => this.mTaxOnShippingAmount;
      set => this.mTaxOnShippingAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TaxOnHandlingAmount
    {
      get => this.mTaxOnHandlingAmount;
      set => this.mTaxOnHandlingAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TaxCode
    {
      get => this.mTaxCode;
      set => this.mTaxCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CollectionMethodCodeType CollectionMethod
    {
      get => this.mCollectionMethod;
      set
      {
        this.mCollectionMethod = value;
        this.mCollectionMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CollectionMethodSpecified
    {
      get => this.mCollectionMethodSpecified;
      set => this.mCollectionMethodSpecified = value;
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
