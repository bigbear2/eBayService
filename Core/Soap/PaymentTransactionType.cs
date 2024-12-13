// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PaymentTransactionType
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
  public class PaymentTransactionType
  {
    private PaymentTransactionStatusCodeType mPaymentStatus;
    private bool mPaymentStatusSpecified;
    private UserIdentityType mPayer;
    private UserIdentityType mPayee;
    private DateTime mPaymentTime;
    private bool mPaymentTimeSpecified;
    private AmountType mPaymentAmount;
    private TransactionReferenceType mReferenceID;
    private AmountType mFeeOrCreditAmount;
    private TransactionReferenceTypeCollection mPaymentReferenceID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public PaymentTransactionStatusCodeType PaymentStatus
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
    public UserIdentityType Payer
    {
      get => this.mPayer;
      set => this.mPayer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserIdentityType Payee
    {
      get => this.mPayee;
      set => this.mPayee = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PaymentTime
    {
      get => this.mPaymentTime;
      set
      {
        this.mPaymentTime = value;
        this.mPaymentTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentTimeSpecified
    {
      get => this.mPaymentTimeSpecified;
      set => this.mPaymentTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType PaymentAmount
    {
      get => this.mPaymentAmount;
      set => this.mPaymentAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TransactionReferenceType ReferenceID
    {
      get => this.mReferenceID;
      set => this.mReferenceID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType FeeOrCreditAmount
    {
      get => this.mFeeOrCreditAmount;
      set => this.mFeeOrCreditAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PaymentReferenceID")]
    public TransactionReferenceTypeCollection PaymentReferenceID
    {
      get => this.mPaymentReferenceID;
      set => this.mPaymentReferenceID = value;
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
