// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SendInvoiceRequestType
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
  public class SendInvoiceRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mTransactionID;
    private string mOrderID;
    private InternationalShippingServiceOptionsTypeCollection mInternationalShippingServiceOptions;
    private ShippingServiceOptionsTypeCollection mShippingServiceOptions;
    private SalesTaxType mSalesTax;
    private InsuranceOptionCodeType mInsuranceOption;
    private bool mInsuranceOptionSpecified;
    private AmountType mInsuranceFee;
    private BuyerPaymentMethodCodeTypeCollection mPaymentMethods;
    private string mPayPalEmailAddress;
    private string mCheckoutInstructions;
    private bool mEmailCopyToSeller;
    private bool mEmailCopyToSellerSpecified;
    private AmountType mCODCost;
    private string mSKU;
    private string mOrderLineItemID;
    private AmountType mAdjustmentAmount;

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
    [XmlElement("InternationalShippingServiceOptions", Order = 3)]
    public InternationalShippingServiceOptionsTypeCollection InternationalShippingServiceOptions
    {
      get => this.mInternationalShippingServiceOptions;
      set => this.mInternationalShippingServiceOptions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingServiceOptions", Order = 4)]
    public ShippingServiceOptionsTypeCollection ShippingServiceOptions
    {
      get => this.mShippingServiceOptions;
      set => this.mShippingServiceOptions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public SalesTaxType SalesTax
    {
      get => this.mSalesTax;
      set => this.mSalesTax = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public InsuranceOptionCodeType InsuranceOption
    {
      get => this.mInsuranceOption;
      set
      {
        this.mInsuranceOption = value;
        this.mInsuranceOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InsuranceOptionSpecified
    {
      get => this.mInsuranceOptionSpecified;
      set => this.mInsuranceOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public AmountType InsuranceFee
    {
      get => this.mInsuranceFee;
      set => this.mInsuranceFee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PaymentMethods", Order = 8)]
    public BuyerPaymentMethodCodeTypeCollection PaymentMethods
    {
      get => this.mPaymentMethods;
      set => this.mPaymentMethods = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public string PayPalEmailAddress
    {
      get => this.mPayPalEmailAddress;
      set => this.mPayPalEmailAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public string CheckoutInstructions
    {
      get => this.mCheckoutInstructions;
      set => this.mCheckoutInstructions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public bool EmailCopyToSeller
    {
      get => this.mEmailCopyToSeller;
      set
      {
        this.mEmailCopyToSeller = value;
        this.mEmailCopyToSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailCopyToSellerSpecified
    {
      get => this.mEmailCopyToSellerSpecified;
      set => this.mEmailCopyToSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    public AmountType CODCost
    {
      get => this.mCODCost;
      set => this.mCODCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    public string SKU
    {
      get => this.mSKU;
      set => this.mSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 15)]
    public AmountType AdjustmentAmount
    {
      get => this.mAdjustmentAmount;
      set => this.mAdjustmentAmount = value;
    }
  }
}
