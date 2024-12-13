// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BiddingDetailsType
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
  public class BiddingDetailsType
  {
    private AmountType mConvertedMaxBid;
    private AmountType mMaxBid;
    private int mQuantityBid;
    private bool mQuantityBidSpecified;
    private int mQuantityWon;
    private bool mQuantityWonSpecified;
    private bool mWinning;
    private bool mWinningSpecified;
    private bool mBidAssistant;
    private bool mBidAssistantSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AmountType ConvertedMaxBid
    {
      get => this.mConvertedMaxBid;
      set => this.mConvertedMaxBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType MaxBid
    {
      get => this.mMaxBid;
      set => this.mMaxBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantityBid
    {
      get => this.mQuantityBid;
      set
      {
        this.mQuantityBid = value;
        this.mQuantityBidSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityBidSpecified
    {
      get => this.mQuantityBidSpecified;
      set => this.mQuantityBidSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantityWon
    {
      get => this.mQuantityWon;
      set
      {
        this.mQuantityWon = value;
        this.mQuantityWonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityWonSpecified
    {
      get => this.mQuantityWonSpecified;
      set => this.mQuantityWonSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Winning
    {
      get => this.mWinning;
      set
      {
        this.mWinning = value;
        this.mWinningSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WinningSpecified
    {
      get => this.mWinningSpecified;
      set => this.mWinningSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BidAssistant
    {
      get => this.mBidAssistant;
      set
      {
        this.mBidAssistant = value;
        this.mBidAssistantSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidAssistantSpecified
    {
      get => this.mBidAssistantSpecified;
      set => this.mBidAssistantSpecified = value;
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
