// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BuyingSummaryType
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
  public class BuyingSummaryType
  {
    private int mBiddingCount;
    private bool mBiddingCountSpecified;
    private int mWinningCount;
    private bool mWinningCountSpecified;
    private AmountType mTotalWinningCost;
    private int mWonCount;
    private bool mWonCountSpecified;
    private AmountType mTotalWonCost;
    private int mWonDurationInDays;
    private bool mWonDurationInDaysSpecified;
    private int mBestOfferCount;
    private bool mBestOfferCountSpecified;

    /// <summary>
    /// 
    /// </summary>
    public int BiddingCount
    {
      get => this.mBiddingCount;
      set
      {
        this.mBiddingCount = value;
        this.mBiddingCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BiddingCountSpecified
    {
      get => this.mBiddingCountSpecified;
      set => this.mBiddingCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int WinningCount
    {
      get => this.mWinningCount;
      set
      {
        this.mWinningCount = value;
        this.mWinningCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WinningCountSpecified
    {
      get => this.mWinningCountSpecified;
      set => this.mWinningCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalWinningCost
    {
      get => this.mTotalWinningCost;
      set => this.mTotalWinningCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int WonCount
    {
      get => this.mWonCount;
      set
      {
        this.mWonCount = value;
        this.mWonCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WonCountSpecified
    {
      get => this.mWonCountSpecified;
      set => this.mWonCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalWonCost
    {
      get => this.mTotalWonCost;
      set => this.mTotalWonCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int WonDurationInDays
    {
      get => this.mWonDurationInDays;
      set
      {
        this.mWonDurationInDays = value;
        this.mWonDurationInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WonDurationInDaysSpecified
    {
      get => this.mWonDurationInDaysSpecified;
      set => this.mWonDurationInDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BestOfferCount
    {
      get => this.mBestOfferCount;
      set
      {
        this.mBestOfferCount = value;
        this.mBestOfferCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferCountSpecified
    {
      get => this.mBestOfferCountSpecified;
      set => this.mBestOfferCountSpecified = value;
    }
  }
}
