// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BestOfferType
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
  public class BestOfferType
  {
    private string mBestOfferID;
    private DateTime mExpirationTime;
    private bool mExpirationTimeSpecified;
    private UserType mBuyer;
    private AmountType mPrice;
    private BestOfferStatusCodeType mStatus;
    private bool mStatusSpecified;
    private int mQuantity;
    private bool mQuantitySpecified;
    private string mBuyerMessage;
    private string mSellerMessage;
    private BestOfferTypeCodeType mBestOfferCodeType;
    private bool mBestOfferCodeTypeSpecified;
    private string mCallStatus;
    private bool mNewBestOffer;
    private bool mNewBestOfferSpecified;
    private bool mImmediatePayEligible;
    private bool mImmediatePayEligibleSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string BestOfferID
    {
      get => this.mBestOfferID;
      set => this.mBestOfferID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpirationTime
    {
      get => this.mExpirationTime;
      set
      {
        this.mExpirationTime = value;
        this.mExpirationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpirationTimeSpecified
    {
      get => this.mExpirationTimeSpecified;
      set => this.mExpirationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserType Buyer
    {
      get => this.mBuyer;
      set => this.mBuyer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType Price
    {
      get => this.mPrice;
      set => this.mPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Quantity
    {
      get => this.mQuantity;
      set
      {
        this.mQuantity = value;
        this.mQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySpecified
    {
      get => this.mQuantitySpecified;
      set => this.mQuantitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerMessage
    {
      get => this.mBuyerMessage;
      set => this.mBuyerMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerMessage
    {
      get => this.mSellerMessage;
      set => this.mSellerMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferTypeCodeType BestOfferCodeType
    {
      get => this.mBestOfferCodeType;
      set
      {
        this.mBestOfferCodeType = value;
        this.mBestOfferCodeTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferCodeTypeSpecified
    {
      get => this.mBestOfferCodeTypeSpecified;
      set => this.mBestOfferCodeTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CallStatus
    {
      get => this.mCallStatus;
      set => this.mCallStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool NewBestOffer
    {
      get => this.mNewBestOffer;
      set
      {
        this.mNewBestOffer = value;
        this.mNewBestOfferSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewBestOfferSpecified
    {
      get => this.mNewBestOfferSpecified;
      set => this.mNewBestOfferSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ImmediatePayEligible
    {
      get => this.mImmediatePayEligible;
      set
      {
        this.mImmediatePayEligible = value;
        this.mImmediatePayEligibleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ImmediatePayEligibleSpecified
    {
      get => this.mImmediatePayEligibleSpecified;
      set => this.mImmediatePayEligibleSpecified = value;
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
