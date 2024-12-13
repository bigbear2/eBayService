// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseCheckoutStatusRequestType
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
  public class ReviseCheckoutStatusRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mTransactionID;
    private string mOrderID;
    private AmountType mAmountPaid;
    private BuyerPaymentMethodCodeType mPaymentMethodUsed;
    private bool mPaymentMethodUsedSpecified;
    private CompleteStatusCodeType mCheckoutStatus;
    private bool mCheckoutStatusSpecified;
    private string mShippingService;
    private bool mShippingIncludedInTax;
    private bool mShippingIncludedInTaxSpecified;
    private CheckoutMethodCodeType mCheckoutMethod;
    private bool mCheckoutMethodSpecified;
    private InsuranceSelectedCodeType mInsuranceType;
    private bool mInsuranceTypeSpecified;
    private RCSPaymentStatusCodeType mPaymentStatus;
    private bool mPaymentStatusSpecified;
    private AmountType mAdjustmentAmount;
    private AddressType mShippingAddress;
    private string mBuyerID;
    private AmountType mShippingInsuranceCost;
    private AmountType mSalesTax;
    private AmountType mShippingCost;
    private string mEncryptedID;
    private ExternalTransactionType mExternalTransaction;
    private string mMultipleSellerPaymentID;
    private AmountType mCODCost;
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
    public string OrderID
    {
      get => this.mOrderID;
      set => this.mOrderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public AmountType AmountPaid
    {
      get => this.mAmountPaid;
      set => this.mAmountPaid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public BuyerPaymentMethodCodeType PaymentMethodUsed
    {
      get => this.mPaymentMethodUsed;
      set
      {
        this.mPaymentMethodUsed = value;
        this.mPaymentMethodUsedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentMethodUsedSpecified
    {
      get => this.mPaymentMethodUsedSpecified;
      set => this.mPaymentMethodUsedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public CompleteStatusCodeType CheckoutStatus
    {
      get => this.mCheckoutStatus;
      set
      {
        this.mCheckoutStatus = value;
        this.mCheckoutStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CheckoutStatusSpecified
    {
      get => this.mCheckoutStatusSpecified;
      set => this.mCheckoutStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token", Order = 6)]
    public string ShippingService
    {
      get => this.mShippingService;
      set => this.mShippingService = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool ShippingIncludedInTax
    {
      get => this.mShippingIncludedInTax;
      set
      {
        this.mShippingIncludedInTax = value;
        this.mShippingIncludedInTaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingIncludedInTaxSpecified
    {
      get => this.mShippingIncludedInTaxSpecified;
      set => this.mShippingIncludedInTaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public CheckoutMethodCodeType CheckoutMethod
    {
      get => this.mCheckoutMethod;
      set
      {
        this.mCheckoutMethod = value;
        this.mCheckoutMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CheckoutMethodSpecified
    {
      get => this.mCheckoutMethodSpecified;
      set => this.mCheckoutMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public InsuranceSelectedCodeType InsuranceType
    {
      get => this.mInsuranceType;
      set
      {
        this.mInsuranceType = value;
        this.mInsuranceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InsuranceTypeSpecified
    {
      get => this.mInsuranceTypeSpecified;
      set => this.mInsuranceTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public RCSPaymentStatusCodeType PaymentStatus
    {
      get => this.mPaymentStatus;
      set
      {
        this.mPaymentStatus = value;
        this.mPaymentStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentStatusSpecified
    {
      get => this.mPaymentStatusSpecified;
      set => this.mPaymentStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public AmountType AdjustmentAmount
    {
      get => this.mAdjustmentAmount;
      set => this.mAdjustmentAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    public AddressType ShippingAddress
    {
      get => this.mShippingAddress;
      set => this.mShippingAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    public string BuyerID
    {
      get => this.mBuyerID;
      set => this.mBuyerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14)]
    public AmountType ShippingInsuranceCost
    {
      get => this.mShippingInsuranceCost;
      set => this.mShippingInsuranceCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 15)]
    public AmountType SalesTax
    {
      get => this.mSalesTax;
      set => this.mSalesTax = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 16)]
    public AmountType ShippingCost
    {
      get => this.mShippingCost;
      set => this.mShippingCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 17)]
    public string EncryptedID
    {
      get => this.mEncryptedID;
      set => this.mEncryptedID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 18)]
    public ExternalTransactionType ExternalTransaction
    {
      get => this.mExternalTransaction;
      set => this.mExternalTransaction = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 19)]
    public string MultipleSellerPaymentID
    {
      get => this.mMultipleSellerPaymentID;
      set => this.mMultipleSellerPaymentID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 20)]
    public AmountType CODCost
    {
      get => this.mCODCost;
      set => this.mCODCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 21)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
