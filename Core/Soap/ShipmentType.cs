// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShipmentType
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
  public class ShipmentType
  {
    private DateTime mEstimatedDeliveryDate;
    private bool mEstimatedDeliveryDateSpecified;
    private AmountType mInsuredValue;
    private MeasureType mPackageDepth;
    private MeasureType mPackageLength;
    private MeasureType mPackageWidth;
    private string mPayPalShipmentID;
    private long mShipmentID;
    private bool mShipmentIDSpecified;
    private AmountType mPostageTotal;
    private DateTime mPrintedTime;
    private bool mPrintedTimeSpecified;
    private AddressType mShipFromAddress;
    private AddressType mShippingAddress;
    private string mShippingCarrierUsed;
    private ShippingFeatureCodeTypeCollection mShippingFeature;
    private ShippingPackageCodeType mShippingPackage;
    private bool mShippingPackageSpecified;
    private string mShippingServiceUsed;
    private string mShipmentTrackingNumber;
    private MeasureType mWeightMajor;
    private MeasureType mWeightMinor;
    private ItemTransactionIDTypeCollection mItemTransactionID;
    private DateTime mDeliveryDate;
    private bool mDeliveryDateSpecified;
    private ShipmentDeliveryStatusCodeType mDeliveryStatus;
    private bool mDeliveryStatusSpecified;
    private DateTime mRefundGrantedTime;
    private bool mRefundGrantedTimeSpecified;
    private DateTime mRefundRequestedTime;
    private bool mRefundRequestedTimeSpecified;
    private ShipmentStatusCodeType mStatus;
    private bool mStatusSpecified;
    private DateTime mShippedTime;
    private bool mShippedTimeSpecified;
    private string mNotes;
    private ShipmentTrackingDetailsTypeCollection mShipmentTrackingDetails;
    private ShipmentLineItemType mShipmentLineItem;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DateTime EstimatedDeliveryDate
    {
      get => this.mEstimatedDeliveryDate;
      set
      {
        this.mEstimatedDeliveryDate = value;
        this.mEstimatedDeliveryDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EstimatedDeliveryDateSpecified
    {
      get => this.mEstimatedDeliveryDateSpecified;
      set => this.mEstimatedDeliveryDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType InsuredValue
    {
      get => this.mInsuredValue;
      set => this.mInsuredValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType PackageDepth
    {
      get => this.mPackageDepth;
      set => this.mPackageDepth = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType PackageLength
    {
      get => this.mPackageLength;
      set => this.mPackageLength = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType PackageWidth
    {
      get => this.mPackageWidth;
      set => this.mPackageWidth = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PayPalShipmentID
    {
      get => this.mPayPalShipmentID;
      set => this.mPayPalShipmentID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long ShipmentID
    {
      get => this.mShipmentID;
      set
      {
        this.mShipmentID = value;
        this.mShipmentIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShipmentIDSpecified
    {
      get => this.mShipmentIDSpecified;
      set => this.mShipmentIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType PostageTotal
    {
      get => this.mPostageTotal;
      set => this.mPostageTotal = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PrintedTime
    {
      get => this.mPrintedTime;
      set
      {
        this.mPrintedTime = value;
        this.mPrintedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PrintedTimeSpecified
    {
      get => this.mPrintedTimeSpecified;
      set => this.mPrintedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType ShipFromAddress
    {
      get => this.mShipFromAddress;
      set => this.mShipFromAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType ShippingAddress
    {
      get => this.mShippingAddress;
      set => this.mShippingAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShippingCarrierUsed
    {
      get => this.mShippingCarrierUsed;
      set => this.mShippingCarrierUsed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingFeature")]
    public ShippingFeatureCodeTypeCollection ShippingFeature
    {
      get => this.mShippingFeature;
      set => this.mShippingFeature = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingPackageCodeType ShippingPackage
    {
      get => this.mShippingPackage;
      set
      {
        this.mShippingPackage = value;
        this.mShippingPackageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingPackageSpecified
    {
      get => this.mShippingPackageSpecified;
      set => this.mShippingPackageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingServiceUsed
    {
      get => this.mShippingServiceUsed;
      set => this.mShippingServiceUsed = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShipmentTrackingNumber
    {
      get => this.mShipmentTrackingNumber;
      set => this.mShipmentTrackingNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType WeightMajor
    {
      get => this.mWeightMajor;
      set => this.mWeightMajor = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType WeightMinor
    {
      get => this.mWeightMinor;
      set => this.mWeightMinor = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemTransactionID")]
    public ItemTransactionIDTypeCollection ItemTransactionID
    {
      get => this.mItemTransactionID;
      set => this.mItemTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime DeliveryDate
    {
      get => this.mDeliveryDate;
      set
      {
        this.mDeliveryDate = value;
        this.mDeliveryDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeliveryDateSpecified
    {
      get => this.mDeliveryDateSpecified;
      set => this.mDeliveryDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShipmentDeliveryStatusCodeType DeliveryStatus
    {
      get => this.mDeliveryStatus;
      set
      {
        this.mDeliveryStatus = value;
        this.mDeliveryStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeliveryStatusSpecified
    {
      get => this.mDeliveryStatusSpecified;
      set => this.mDeliveryStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RefundGrantedTime
    {
      get => this.mRefundGrantedTime;
      set
      {
        this.mRefundGrantedTime = value;
        this.mRefundGrantedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundGrantedTimeSpecified
    {
      get => this.mRefundGrantedTimeSpecified;
      set => this.mRefundGrantedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RefundRequestedTime
    {
      get => this.mRefundRequestedTime;
      set
      {
        this.mRefundRequestedTime = value;
        this.mRefundRequestedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundRequestedTimeSpecified
    {
      get => this.mRefundRequestedTimeSpecified;
      set => this.mRefundRequestedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShipmentStatusCodeType Status
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
    public DateTime ShippedTime
    {
      get => this.mShippedTime;
      set
      {
        this.mShippedTime = value;
        this.mShippedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippedTimeSpecified
    {
      get => this.mShippedTimeSpecified;
      set => this.mShippedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Notes
    {
      get => this.mNotes;
      set => this.mNotes = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShipmentTrackingDetails")]
    public ShipmentTrackingDetailsTypeCollection ShipmentTrackingDetails
    {
      get => this.mShipmentTrackingDetails;
      set => this.mShipmentTrackingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShipmentLineItemType ShipmentLineItem
    {
      get => this.mShipmentLineItem;
      set => this.mShipmentLineItem = value;
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
