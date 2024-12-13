// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CrossPromotionPreferencesType
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
  public class CrossPromotionPreferencesType
  {
    private bool mCrossPromotionEnabled;
    private bool mCrossPromotionEnabledSpecified;
    private ItemFormatSortFilterCodeType mCrossSellItemFormatSortFilter;
    private bool mCrossSellItemFormatSortFilterSpecified;
    private GallerySortFilterCodeType mCrossSellGallerySortFilter;
    private bool mCrossSellGallerySortFilterSpecified;
    private ItemSortFilterCodeType mCrossSellItemSortFilter;
    private bool mCrossSellItemSortFilterSpecified;
    private ItemFormatSortFilterCodeType mUpSellItemFormatSortFilter;
    private bool mUpSellItemFormatSortFilterSpecified;
    private GallerySortFilterCodeType mUpSellGallerySortFilter;
    private bool mUpSellGallerySortFilterSpecified;
    private ItemSortFilterCodeType mUpSellItemSortFilter;
    private bool mUpSellItemSortFilterSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool CrossPromotionEnabled
    {
      get => this.mCrossPromotionEnabled;
      set
      {
        this.mCrossPromotionEnabled = value;
        this.mCrossPromotionEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossPromotionEnabledSpecified
    {
      get => this.mCrossPromotionEnabledSpecified;
      set => this.mCrossPromotionEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemFormatSortFilterCodeType CrossSellItemFormatSortFilter
    {
      get => this.mCrossSellItemFormatSortFilter;
      set
      {
        this.mCrossSellItemFormatSortFilter = value;
        this.mCrossSellItemFormatSortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossSellItemFormatSortFilterSpecified
    {
      get => this.mCrossSellItemFormatSortFilterSpecified;
      set => this.mCrossSellItemFormatSortFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GallerySortFilterCodeType CrossSellGallerySortFilter
    {
      get => this.mCrossSellGallerySortFilter;
      set
      {
        this.mCrossSellGallerySortFilter = value;
        this.mCrossSellGallerySortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossSellGallerySortFilterSpecified
    {
      get => this.mCrossSellGallerySortFilterSpecified;
      set => this.mCrossSellGallerySortFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSortFilterCodeType CrossSellItemSortFilter
    {
      get => this.mCrossSellItemSortFilter;
      set
      {
        this.mCrossSellItemSortFilter = value;
        this.mCrossSellItemSortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossSellItemSortFilterSpecified
    {
      get => this.mCrossSellItemSortFilterSpecified;
      set => this.mCrossSellItemSortFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemFormatSortFilterCodeType UpSellItemFormatSortFilter
    {
      get => this.mUpSellItemFormatSortFilter;
      set
      {
        this.mUpSellItemFormatSortFilter = value;
        this.mUpSellItemFormatSortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpSellItemFormatSortFilterSpecified
    {
      get => this.mUpSellItemFormatSortFilterSpecified;
      set => this.mUpSellItemFormatSortFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GallerySortFilterCodeType UpSellGallerySortFilter
    {
      get => this.mUpSellGallerySortFilter;
      set
      {
        this.mUpSellGallerySortFilter = value;
        this.mUpSellGallerySortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpSellGallerySortFilterSpecified
    {
      get => this.mUpSellGallerySortFilterSpecified;
      set => this.mUpSellGallerySortFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemSortFilterCodeType UpSellItemSortFilter
    {
      get => this.mUpSellItemSortFilter;
      set
      {
        this.mUpSellItemSortFilter = value;
        this.mUpSellItemSortFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpSellItemSortFilterSpecified
    {
      get => this.mUpSellItemSortFilterSpecified;
      set => this.mUpSellItemSortFilterSpecified = value;
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
