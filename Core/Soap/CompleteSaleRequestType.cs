// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CompleteSaleRequestType
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
  public class CompleteSaleRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mTransactionID;
    private FeedbackInfoType mFeedbackInfo;
    private bool mShipped;
    private bool mShippedSpecified;
    private bool mPaid;
    private bool mPaidSpecified;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private ShipmentType mShipment;
    private string mOrderID;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public FeedbackInfoType FeedbackInfo
    {
      get => this.mFeedbackInfo;
      set => this.mFeedbackInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool Shipped
    {
      get => this.mShipped;
      set
      {
        this.mShipped = value;
        this.mShippedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippedSpecified
    {
      get => this.mShippedSpecified;
      set => this.mShippedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public bool Paid
    {
      get => this.mPaid;
      set
      {
        this.mPaid = value;
        this.mPaidSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaidSpecified
    {
      get => this.mPaidSpecified;
      set => this.mPaidSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public ListingTypeCodeType ListingType
    {
      get => this.mListingType;
      set
      {
        this.mListingType = value;
        this.mListingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingTypeSpecified
    {
      get => this.mListingTypeSpecified;
      set => this.mListingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public ShipmentType Shipment
    {
      get => this.mShipment;
      set => this.mShipment = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public string OrderID
    {
      get => this.mOrderID;
      set => this.mOrderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
