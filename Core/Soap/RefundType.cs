// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RefundType
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
  public class RefundType
  {
    private AmountType mRefundFromSeller;
    private AmountType mTotalRefundToBuyer;
    private DateTime mRefundTime;
    private bool mRefundTimeSpecified;
    private string mRefundID;
    private RefundTransactionArrayType mRefundTransactionArray;
    private AmountType mRefundAmount;
    private RefundStatusCodeType mRefundStatus;
    private bool mRefundStatusSpecified;
    private RefundFailureReasonType mRefundFailureReason;
    private RefundFundingSourceArrayType mRefundFundingSourceArray;
    private string mExternalReferenceID;
    private DateTime mRefundRequestedTime;
    private bool mRefundRequestedTimeSpecified;
    private DateTime mRefundCompletionTime;
    private bool mRefundCompletionTimeSpecified;
    private DateTime mEstimatedRefundCompletionTime;
    private bool mEstimatedRefundCompletionTimeSpecified;
    private string mSellerNoteToBuyer;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public AmountType RefundFromSeller
    {
      get => this.mRefundFromSeller;
      set => this.mRefundFromSeller = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType TotalRefundToBuyer
    {
      get => this.mTotalRefundToBuyer;
      set => this.mTotalRefundToBuyer = value;
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
    public string RefundID
    {
      get => this.mRefundID;
      set => this.mRefundID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RefundTransactionArrayType RefundTransactionArray
    {
      get => this.mRefundTransactionArray;
      set => this.mRefundTransactionArray = value;
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
    public RefundStatusCodeType RefundStatus
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
    public RefundFailureReasonType RefundFailureReason
    {
      get => this.mRefundFailureReason;
      set => this.mRefundFailureReason = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public RefundFundingSourceArrayType RefundFundingSourceArray
    {
      get => this.mRefundFundingSourceArray;
      set => this.mRefundFundingSourceArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalReferenceID
    {
      get => this.mExternalReferenceID;
      set => this.mExternalReferenceID = value;
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
    public DateTime RefundCompletionTime
    {
      get => this.mRefundCompletionTime;
      set
      {
        this.mRefundCompletionTime = value;
        this.mRefundCompletionTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundCompletionTimeSpecified
    {
      get => this.mRefundCompletionTimeSpecified;
      set => this.mRefundCompletionTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EstimatedRefundCompletionTime
    {
      get => this.mEstimatedRefundCompletionTime;
      set
      {
        this.mEstimatedRefundCompletionTime = value;
        this.mEstimatedRefundCompletionTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EstimatedRefundCompletionTimeSpecified
    {
      get => this.mEstimatedRefundCompletionTimeSpecified;
      set => this.mEstimatedRefundCompletionTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerNoteToBuyer
    {
      get => this.mSellerNoteToBuyer;
      set => this.mSellerNoteToBuyer = value;
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
