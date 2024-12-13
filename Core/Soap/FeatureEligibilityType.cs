// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FeatureEligibilityType
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
  public class FeatureEligibilityType
  {
    private bool mQualifiesForBuyItNow;
    private bool mQualifiesForBuyItNowSpecified;
    private bool mQualifiesForBuyItNowMultiple;
    private bool mQualifiesForBuyItNowMultipleSpecified;
    private bool mQualifiedForFixedPriceOneDayDuration;
    private bool mQualifiedForFixedPriceOneDayDurationSpecified;
    private bool mQualifiesForVariations;
    private bool mQualifiesForVariationsSpecified;
    private bool mQualifiedForAuctionOneDayDuration;
    private bool mQualifiedForAuctionOneDayDurationSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiesForBuyItNow
    {
      get => this.mQualifiesForBuyItNow;
      set
      {
        this.mQualifiesForBuyItNow = value;
        this.mQualifiesForBuyItNowSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiesForBuyItNowSpecified
    {
      get => this.mQualifiesForBuyItNowSpecified;
      set => this.mQualifiesForBuyItNowSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiesForBuyItNowMultiple
    {
      get => this.mQualifiesForBuyItNowMultiple;
      set
      {
        this.mQualifiesForBuyItNowMultiple = value;
        this.mQualifiesForBuyItNowMultipleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiesForBuyItNowMultipleSpecified
    {
      get => this.mQualifiesForBuyItNowMultipleSpecified;
      set => this.mQualifiesForBuyItNowMultipleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiedForFixedPriceOneDayDuration
    {
      get => this.mQualifiedForFixedPriceOneDayDuration;
      set
      {
        this.mQualifiedForFixedPriceOneDayDuration = value;
        this.mQualifiedForFixedPriceOneDayDurationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiedForFixedPriceOneDayDurationSpecified
    {
      get => this.mQualifiedForFixedPriceOneDayDurationSpecified;
      set => this.mQualifiedForFixedPriceOneDayDurationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiesForVariations
    {
      get => this.mQualifiesForVariations;
      set
      {
        this.mQualifiesForVariations = value;
        this.mQualifiesForVariationsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiesForVariationsSpecified
    {
      get => this.mQualifiesForVariationsSpecified;
      set => this.mQualifiesForVariationsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool QualifiedForAuctionOneDayDuration
    {
      get => this.mQualifiedForAuctionOneDayDuration;
      set
      {
        this.mQualifiedForAuctionOneDayDuration = value;
        this.mQualifiedForAuctionOneDayDurationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QualifiedForAuctionOneDayDurationSpecified
    {
      get => this.mQualifiedForAuctionOneDayDurationSpecified;
      set => this.mQualifiedForAuctionOneDayDurationSpecified = value;
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
