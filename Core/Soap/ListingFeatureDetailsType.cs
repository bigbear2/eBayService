// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingFeatureDetailsType
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
  public class ListingFeatureDetailsType
  {
    private BoldTitleCodeType mBoldTitle;
    private bool mBoldTitleSpecified;
    private BorderCodeType mBorder;
    private bool mBorderSpecified;
    private HighlightCodeType mHighlight;
    private bool mHighlightSpecified;
    private GiftIconCodeType mGiftIcon;
    private bool mGiftIconSpecified;
    private HomePageFeaturedCodeType mHomePageFeatured;
    private bool mHomePageFeaturedSpecified;
    private FeaturedFirstCodeType mFeaturedFirst;
    private bool mFeaturedFirstSpecified;
    private FeaturedPlusCodeType mFeaturedPlus;
    private bool mFeaturedPlusSpecified;
    private ProPackCodeType mProPack;
    private bool mProPackSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public BoldTitleCodeType BoldTitle
    {
      get => this.mBoldTitle;
      set
      {
        this.mBoldTitle = value;
        this.mBoldTitleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BoldTitleSpecified
    {
      get => this.mBoldTitleSpecified;
      set => this.mBoldTitleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BorderCodeType Border
    {
      get => this.mBorder;
      set
      {
        this.mBorder = value;
        this.mBorderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BorderSpecified
    {
      get => this.mBorderSpecified;
      set => this.mBorderSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public HighlightCodeType Highlight
    {
      get => this.mHighlight;
      set
      {
        this.mHighlight = value;
        this.mHighlightSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HighlightSpecified
    {
      get => this.mHighlightSpecified;
      set => this.mHighlightSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GiftIconCodeType GiftIcon
    {
      get => this.mGiftIcon;
      set
      {
        this.mGiftIcon = value;
        this.mGiftIconSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GiftIconSpecified
    {
      get => this.mGiftIconSpecified;
      set => this.mGiftIconSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public HomePageFeaturedCodeType HomePageFeatured
    {
      get => this.mHomePageFeatured;
      set
      {
        this.mHomePageFeatured = value;
        this.mHomePageFeaturedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HomePageFeaturedSpecified
    {
      get => this.mHomePageFeaturedSpecified;
      set => this.mHomePageFeaturedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeaturedFirstCodeType FeaturedFirst
    {
      get => this.mFeaturedFirst;
      set
      {
        this.mFeaturedFirst = value;
        this.mFeaturedFirstSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeaturedFirstSpecified
    {
      get => this.mFeaturedFirstSpecified;
      set => this.mFeaturedFirstSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeaturedPlusCodeType FeaturedPlus
    {
      get => this.mFeaturedPlus;
      set
      {
        this.mFeaturedPlus = value;
        this.mFeaturedPlusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeaturedPlusSpecified
    {
      get => this.mFeaturedPlusSpecified;
      set => this.mFeaturedPlusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProPackCodeType ProPack
    {
      get => this.mProPack;
      set
      {
        this.mProPack = value;
        this.mProPackSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProPackSpecified
    {
      get => this.mProPackSpecified;
      set => this.mProPackSpecified = value;
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
