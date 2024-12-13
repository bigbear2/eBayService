// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CrossPromotionsType
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
  public class CrossPromotionsType
  {
    private string mItemID;
    private PromotionSchemeCodeType mPrimaryScheme;
    private bool mPrimarySchemeSpecified;
    private PromotionMethodCodeType mPromotionMethod;
    private bool mPromotionMethodSpecified;
    private string mSellerID;
    private bool mShippingDiscount;
    private string mStoreName;
    private PromotedItemTypeCollection mPromotedItem;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionSchemeCodeType PrimaryScheme
    {
      get => this.mPrimaryScheme;
      set
      {
        this.mPrimaryScheme = value;
        this.mPrimarySchemeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PrimarySchemeSpecified
    {
      get => this.mPrimarySchemeSpecified;
      set => this.mPrimarySchemeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionMethodCodeType PromotionMethod
    {
      get => this.mPromotionMethod;
      set
      {
        this.mPromotionMethod = value;
        this.mPromotionMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionMethodSpecified
    {
      get => this.mPromotionMethodSpecified;
      set => this.mPromotionMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerID
    {
      get => this.mSellerID;
      set => this.mSellerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShippingDiscount
    {
      get => this.mShippingDiscount;
      set => this.mShippingDiscount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StoreName
    {
      get => this.mStoreName;
      set => this.mStoreName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PromotedItem")]
    public PromotedItemTypeCollection PromotedItem
    {
      get => this.mPromotedItem;
      set => this.mPromotedItem = value;
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
