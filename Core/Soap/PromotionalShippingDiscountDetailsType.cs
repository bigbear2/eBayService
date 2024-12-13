// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PromotionalShippingDiscountDetailsType
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
  public class PromotionalShippingDiscountDetailsType
  {
    private DiscountNameCodeType mDiscountName;
    private bool mDiscountNameSpecified;
    private AmountType mShippingCost;
    private AmountType mOrderAmount;
    private int mItemCount;
    private bool mItemCountSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DiscountNameCodeType DiscountName
    {
      get => this.mDiscountName;
      set
      {
        this.mDiscountName = value;
        this.mDiscountNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DiscountNameSpecified
    {
      get => this.mDiscountNameSpecified;
      set => this.mDiscountNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ShippingCost
    {
      get => this.mShippingCost;
      set => this.mShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType OrderAmount
    {
      get => this.mOrderAmount;
      set => this.mOrderAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ItemCount
    {
      get => this.mItemCount;
      set
      {
        this.mItemCount = value;
        this.mItemCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemCountSpecified
    {
      get => this.mItemCountSpecified;
      set => this.mItemCountSpecified = value;
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
