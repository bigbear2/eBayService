// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SearchDetailsType
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
  public class SearchDetailsType
  {
    private bool mBuyItNowEnabled;
    private bool mBuyItNowEnabledSpecified;
    private bool mPicture;
    private bool mPictureSpecified;
    private bool mRecentListing;
    private bool mRecentListingSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool BuyItNowEnabled
    {
      get => this.mBuyItNowEnabled;
      set
      {
        this.mBuyItNowEnabled = value;
        this.mBuyItNowEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyItNowEnabledSpecified
    {
      get => this.mBuyItNowEnabledSpecified;
      set => this.mBuyItNowEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Picture
    {
      get => this.mPicture;
      set
      {
        this.mPicture = value;
        this.mPictureSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureSpecified
    {
      get => this.mPictureSpecified;
      set => this.mPictureSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RecentListing
    {
      get => this.mRecentListing;
      set
      {
        this.mRecentListing = value;
        this.mRecentListingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RecentListingSpecified
    {
      get => this.mRecentListingSpecified;
      set => this.mRecentListingSpecified = value;
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
