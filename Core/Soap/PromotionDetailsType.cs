// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PromotionDetailsType
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
  public class PromotionDetailsType
  {
    private AmountType mPromotionPrice;
    private PromotionItemPriceTypeCodeType mPromotionPriceType;
    private bool mPromotionPriceTypeSpecified;
    private int mBidCount;
    private bool mBidCountSpecified;
    private AmountType mConvertedPromotionPrice;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AmountType PromotionPrice
    {
      get => this.mPromotionPrice;
      set => this.mPromotionPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionItemPriceTypeCodeType PromotionPriceType
    {
      get => this.mPromotionPriceType;
      set
      {
        this.mPromotionPriceType = value;
        this.mPromotionPriceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionPriceTypeSpecified
    {
      get => this.mPromotionPriceTypeSpecified;
      set => this.mPromotionPriceTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidCount
    {
      get => this.mBidCount;
      set
      {
        this.mBidCount = value;
        this.mBidCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidCountSpecified
    {
      get => this.mBidCountSpecified;
      set => this.mBidCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedPromotionPrice
    {
      get => this.mConvertedPromotionPrice;
      set => this.mConvertedPromotionPrice = value;
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
