// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType
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
  public class SellingManagerAutoSecondChanceOfferType
  {
    private SellingManagerAutoSecondChanceOfferTypeCodeType mSecondChanceOfferCondition;
    private bool mSecondChanceOfferConditionSpecified;
    private AmountType mAmount;
    private float mProfitPercent;
    private bool mProfitPercentSpecified;
    private SecondChanceOfferDurationCodeType mDuration;
    private bool mDurationSpecified;
    private int mListingHoldInventoryLevel;
    private bool mListingHoldInventoryLevelSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutoSecondChanceOfferTypeCodeType SecondChanceOfferCondition
    {
      get => this.mSecondChanceOfferCondition;
      set
      {
        this.mSecondChanceOfferCondition = value;
        this.mSecondChanceOfferConditionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SecondChanceOfferConditionSpecified
    {
      get => this.mSecondChanceOfferConditionSpecified;
      set => this.mSecondChanceOfferConditionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Amount
    {
      get => this.mAmount;
      set => this.mAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float ProfitPercent
    {
      get => this.mProfitPercent;
      set
      {
        this.mProfitPercent = value;
        this.mProfitPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProfitPercentSpecified
    {
      get => this.mProfitPercentSpecified;
      set => this.mProfitPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SecondChanceOfferDurationCodeType Duration
    {
      get => this.mDuration;
      set
      {
        this.mDuration = value;
        this.mDurationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DurationSpecified
    {
      get => this.mDurationSpecified;
      set => this.mDurationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ListingHoldInventoryLevel
    {
      get => this.mListingHoldInventoryLevel;
      set
      {
        this.mListingHoldInventoryLevel = value;
        this.mListingHoldInventoryLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingHoldInventoryLevelSpecified
    {
      get => this.mListingHoldInventoryLevelSpecified;
      set => this.mListingHoldInventoryLevelSpecified = value;
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
