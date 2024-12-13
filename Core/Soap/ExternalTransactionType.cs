// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ExternalTransactionType
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
  public class ExternalTransactionType
  {
    private string mExternalTransactionID;
    private DateTime mExternalTransactionTime;
    private bool mExternalTransactionTimeSpecified;
    private AmountType mFeeOrCreditAmount;
    private AmountType mPaymentOrRefundAmount;
    private PaymentTransactionStatusCodeType mExternalTransactionStatus;
    private bool mExternalTransactionStatusSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ExternalTransactionID
    {
      get => this.mExternalTransactionID;
      set => this.mExternalTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExternalTransactionTime
    {
      get => this.mExternalTransactionTime;
      set
      {
        this.mExternalTransactionTime = value;
        this.mExternalTransactionTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExternalTransactionTimeSpecified
    {
      get => this.mExternalTransactionTimeSpecified;
      set => this.mExternalTransactionTimeSpecified = value;
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
    public AmountType PaymentOrRefundAmount
    {
      get => this.mPaymentOrRefundAmount;
      set => this.mPaymentOrRefundAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentTransactionStatusCodeType ExternalTransactionStatus
    {
      get => this.mExternalTransactionStatus;
      set
      {
        this.mExternalTransactionStatus = value;
        this.mExternalTransactionStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExternalTransactionStatusSpecified
    {
      get => this.mExternalTransactionStatusSpecified;
      set => this.mExternalTransactionStatusSpecified = value;
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
