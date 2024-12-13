// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RefundTransactionInfoType
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
  public class RefundTransactionInfoType
  {
    private PaymentTransactionStatusCodeType mRefundStatus;
    private bool mRefundStatusSpecified;
    private RefundSourceTypeCodeType mRefundType;
    private bool mRefundTypeSpecified;
    private UserIdentityType mRefundTo;
    private DateTime mRefundTime;
    private bool mRefundTimeSpecified;
    private AmountType mRefundAmount;
    private TransactionReferenceType mReferenceID;
    private AmountType mFeeOrCreditAmount;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public PaymentTransactionStatusCodeType RefundStatus
    {
      get => this.mRefundStatus;
      set
      {
        this.mRefundStatus = value;
        this.mRefundStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundStatusSpecified
    {
      get => this.mRefundStatusSpecified;
      set => this.mRefundStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RefundSourceTypeCodeType RefundType
    {
      get => this.mRefundType;
      set
      {
        this.mRefundType = value;
        this.mRefundTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundTypeSpecified
    {
      get => this.mRefundTypeSpecified;
      set => this.mRefundTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserIdentityType RefundTo
    {
      get => this.mRefundTo;
      set => this.mRefundTo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RefundTime
    {
      get => this.mRefundTime;
      set
      {
        this.mRefundTime = value;
        this.mRefundTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundTimeSpecified
    {
      get => this.mRefundTimeSpecified;
      set => this.mRefundTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType RefundAmount
    {
      get => this.mRefundAmount;
      set => this.mRefundAmount = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
