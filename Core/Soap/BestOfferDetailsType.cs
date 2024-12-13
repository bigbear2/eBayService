// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BestOfferDetailsType
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
  public class BestOfferDetailsType
  {
    private int mBestOfferCount;
    private bool mBestOfferCountSpecified;
    private bool mBestOfferEnabled;
    private bool mBestOfferEnabledSpecified;
    private AmountType mBestOffer;
    private BestOfferStatusCodeType mBestOfferStatus;
    private bool mBestOfferStatusSpecified;
    private BestOfferTypeCodeType mBestOfferType;
    private bool mBestOfferTypeSpecified;
    private bool mNewBestOffer;
    private bool mNewBestOfferSpecified;
    private XmlElementCollection mAny;

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

    /// <summary>
    /// 
    /// </summary>
    public bool BestOfferEnabled
    {
      get => this.mBestOfferEnabled;
      set
      {
        this.mBestOfferEnabled = value;
        this.mBestOfferEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferEnabledSpecified
    {
      get => this.mBestOfferEnabledSpecified;
      set => this.mBestOfferEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType BestOffer
    {
      get => this.mBestOffer;
      set => this.mBestOffer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferStatusCodeType BestOfferStatus
    {
      get => this.mBestOfferStatus;
      set
      {
        this.mBestOfferStatus = value;
        this.mBestOfferStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferStatusSpecified
    {
      get => this.mBestOfferStatusSpecified;
      set => this.mBestOfferStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BestOfferTypeCodeType BestOfferType
    {
      get => this.mBestOfferType;
      set
      {
        this.mBestOfferType = value;
        this.mBestOfferTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferTypeSpecified
    {
      get => this.mBestOfferTypeSpecified;
      set => this.mBestOfferTypeSpecified = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
