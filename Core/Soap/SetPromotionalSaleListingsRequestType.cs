// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetPromotionalSaleListingsRequestType
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
  public class SetPromotionalSaleListingsRequestType : AbstractRequestType
  {
    private long mPromotionalSaleID;
    private bool mPromotionalSaleIDSpecified;
    private ModifyActionCodeType mAction;
    private bool mActionSpecified;
    private ItemIDArrayType mPromotionalSaleItemIDArray;
    private long mStoreCategoryID;
    private bool mStoreCategoryIDSpecified;
    private long mCategoryID;
    private bool mCategoryIDSpecified;
    private bool mAllFixedPriceItems;
    private bool mAllFixedPriceItemsSpecified;
    private bool mAllStoreInventoryItems;
    private bool mAllStoreInventoryItemsSpecified;
    private bool mAllAuctionItems;
    private bool mAllAuctionItemsSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public long PromotionalSaleID
    {
      get => this.mPromotionalSaleID;
      set
      {
        this.mPromotionalSaleID = value;
        this.mPromotionalSaleIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleIDSpecified
    {
      get => this.mPromotionalSaleIDSpecified;
      set => this.mPromotionalSaleIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public ModifyActionCodeType Action
    {
      get => this.mAction;
      set
      {
        this.mAction = value;
        this.mActionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionSpecified
    {
      get => this.mActionSpecified;
      set => this.mActionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public ItemIDArrayType PromotionalSaleItemIDArray
    {
      get => this.mPromotionalSaleItemIDArray;
      set => this.mPromotionalSaleItemIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public long StoreCategoryID
    {
      get => this.mStoreCategoryID;
      set
      {
        this.mStoreCategoryID = value;
        this.mStoreCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StoreCategoryIDSpecified
    {
      get => this.mStoreCategoryIDSpecified;
      set => this.mStoreCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public long CategoryID
    {
      get => this.mCategoryID;
      set
      {
        this.mCategoryID = value;
        this.mCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryIDSpecified
    {
      get => this.mCategoryIDSpecified;
      set => this.mCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public bool AllFixedPriceItems
    {
      get => this.mAllFixedPriceItems;
      set
      {
        this.mAllFixedPriceItems = value;
        this.mAllFixedPriceItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AllFixedPriceItemsSpecified
    {
      get => this.mAllFixedPriceItemsSpecified;
      set => this.mAllFixedPriceItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public bool AllStoreInventoryItems
    {
      get => this.mAllStoreInventoryItems;
      set
      {
        this.mAllStoreInventoryItems = value;
        this.mAllStoreInventoryItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AllStoreInventoryItemsSpecified
    {
      get => this.mAllStoreInventoryItemsSpecified;
      set => this.mAllStoreInventoryItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool AllAuctionItems
    {
      get => this.mAllAuctionItems;
      set
      {
        this.mAllAuctionItems = value;
        this.mAllAuctionItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AllAuctionItemsSpecified
    {
      get => this.mAllAuctionItemsSpecified;
      set => this.mAllAuctionItemsSpecified = value;
    }
  }
}
