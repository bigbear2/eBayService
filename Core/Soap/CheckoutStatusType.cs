// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CheckoutStatusType
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
  public class CheckoutStatusType
  {
    private PaymentStatusCodeType meBayPaymentStatus;
    private bool meBayPaymentStatusSpecified;
    private DateTime mLastModifiedTime;
    private bool mLastModifiedTimeSpecified;
    private BuyerPaymentMethodCodeType mPaymentMethod;
    private bool mPaymentMethodSpecified;
    private CompleteStatusCodeType mStatus;
    private bool mStatusSpecified;
    private bool mIntegratedMerchantCreditCardEnabled;
    private bool mIntegratedMerchantCreditCardEnabledSpecified;
    private eBayPaymentMismatchDetailsType meBayPaymentMismatchDetails;
    private BuyerPaymentInstrumentCodeType mPaymentInstrument;
    private bool mPaymentInstrumentSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public PaymentStatusCodeType eBayPaymentStatus
    {
      get => this.meBayPaymentStatus;
      set
      {
        this.meBayPaymentStatus = value;
        this.meBayPaymentStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool eBayPaymentStatusSpecified
    {
      get => this.meBayPaymentStatusSpecified;
      set => this.meBayPaymentStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastModifiedTime
    {
      get => this.mLastModifiedTime;
      set
      {
        this.mLastModifiedTime = value;
        this.mLastModifiedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastModifiedTimeSpecified
    {
      get => this.mLastModifiedTimeSpecified;
      set => this.mLastModifiedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerPaymentMethodCodeType PaymentMethod
    {
      get => this.mPaymentMethod;
      set
      {
        this.mPaymentMethod = value;
        this.mPaymentMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentMethodSpecified
    {
      get => this.mPaymentMethodSpecified;
      set => this.mPaymentMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CompleteStatusCodeType Status
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
    public bool IntegratedMerchantCreditCardEnabled
    {
      get => this.mIntegratedMerchantCreditCardEnabled;
      set
      {
        this.mIntegratedMerchantCreditCardEnabled = value;
        this.mIntegratedMerchantCreditCardEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IntegratedMerchantCreditCardEnabledSpecified
    {
      get => this.mIntegratedMerchantCreditCardEnabledSpecified;
      set => this.mIntegratedMerchantCreditCardEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public eBayPaymentMismatchDetailsType eBayPaymentMismatchDetails
    {
      get => this.meBayPaymentMismatchDetails;
      set => this.meBayPaymentMismatchDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerPaymentInstrumentCodeType PaymentInstrument
    {
      get => this.mPaymentInstrument;
      set
      {
        this.mPaymentInstrument = value;
        this.mPaymentInstrumentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentInstrumentSpecified
    {
      get => this.mPaymentInstrumentSpecified;
      set => this.mPaymentInstrumentSpecified = value;
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
