// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseStatusType
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
  public class ReviseStatusType
  {
    private bool mItemRevised;
    private bool mBuyItNowAdded;
    private bool mBuyItNowAddedSpecified;
    private bool mBuyItNowLowered;
    private bool mBuyItNowLoweredSpecified;
    private bool mReserveLowered;
    private bool mReserveLoweredSpecified;
    private bool mReserveRemoved;
    private bool mReserveRemovedSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool ItemRevised
    {
      get => this.mItemRevised;
      set => this.mItemRevised = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BuyItNowAdded
    {
      get => this.mBuyItNowAdded;
      set
      {
        this.mBuyItNowAdded = value;
        this.mBuyItNowAddedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyItNowAddedSpecified
    {
      get => this.mBuyItNowAddedSpecified;
      set => this.mBuyItNowAddedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool BuyItNowLowered
    {
      get => this.mBuyItNowLowered;
      set
      {
        this.mBuyItNowLowered = value;
        this.mBuyItNowLoweredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BuyItNowLoweredSpecified
    {
      get => this.mBuyItNowLoweredSpecified;
      set => this.mBuyItNowLoweredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReserveLowered
    {
      get => this.mReserveLowered;
      set
      {
        this.mReserveLowered = value;
        this.mReserveLoweredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReserveLoweredSpecified
    {
      get => this.mReserveLoweredSpecified;
      set => this.mReserveLoweredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReserveRemoved
    {
      get => this.mReserveRemoved;
      set
      {
        this.mReserveRemoved = value;
        this.mReserveRemovedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReserveRemovedSpecified
    {
      get => this.mReserveRemovedSpecified;
      set => this.mReserveRemovedSpecified = value;
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
