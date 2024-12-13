// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RemindersType
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
  public class RemindersType
  {
    private int mPaymentToSendCount;
    private bool mPaymentToSendCountSpecified;
    private int mFeedbackToReceiveCount;
    private bool mFeedbackToReceiveCountSpecified;
    private int mFeedbackToSendCount;
    private bool mFeedbackToSendCountSpecified;
    private int mOutbidCount;
    private bool mOutbidCountSpecified;
    private int mPaymentToReceiveCount;
    private bool mPaymentToReceiveCountSpecified;
    private int mSecondChanceOfferCount;
    private bool mSecondChanceOfferCountSpecified;
    private int mShippingNeededCount;
    private bool mShippingNeededCountSpecified;
    private int mRelistingNeededCount;
    private bool mRelistingNeededCountSpecified;
    private int mTotalNewLeadsCount;
    private bool mTotalNewLeadsCountSpecified;
    private int mDocsForCCProcessingToSendCount;
    private bool mDocsForCCProcessingToSendCountSpecified;
    private int mRTEToProcessCount;
    private bool mRTEToProcessCountSpecified;
    private int mItemReceiptToConfirmCount;
    private bool mItemReceiptToConfirmCountSpecified;
    private int mRefundOnHoldCount;
    private bool mRefundOnHoldCountSpecified;
    private int mRefundCancelledCount;
    private bool mRefundCancelledCountSpecified;
    private int mShippingDetailsToBeProvidedCount;
    private bool mShippingDetailsToBeProvidedCountSpecified;
    private int mItemReceiptConfirmationToReceiveCount;
    private bool mItemReceiptConfirmationToReceiveCountSpecified;
    private int mRefundInitiatedCount;
    private bool mRefundInitiatedCountSpecified;
    private int mPendingRTERequestCount;
    private bool mPendingRTERequestCountSpecified;
    private int mDeclinedRTERequestCount;
    private bool mDeclinedRTERequestCountSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int PaymentToSendCount
    {
      get => this.mPaymentToSendCount;
      set
      {
        this.mPaymentToSendCount = value;
        this.mPaymentToSendCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentToSendCountSpecified
    {
      get => this.mPaymentToSendCountSpecified;
      set => this.mPaymentToSendCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FeedbackToReceiveCount
    {
      get => this.mFeedbackToReceiveCount;
      set
      {
        this.mFeedbackToReceiveCount = value;
        this.mFeedbackToReceiveCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackToReceiveCountSpecified
    {
      get => this.mFeedbackToReceiveCountSpecified;
      set => this.mFeedbackToReceiveCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FeedbackToSendCount
    {
      get => this.mFeedbackToSendCount;
      set
      {
        this.mFeedbackToSendCount = value;
        this.mFeedbackToSendCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackToSendCountSpecified
    {
      get => this.mFeedbackToSendCountSpecified;
      set => this.mFeedbackToSendCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int OutbidCount
    {
      get => this.mOutbidCount;
      set
      {
        this.mOutbidCount = value;
        this.mOutbidCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OutbidCountSpecified
    {
      get => this.mOutbidCountSpecified;
      set => this.mOutbidCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PaymentToReceiveCount
    {
      get => this.mPaymentToReceiveCount;
      set
      {
        this.mPaymentToReceiveCount = value;
        this.mPaymentToReceiveCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentToReceiveCountSpecified
    {
      get => this.mPaymentToReceiveCountSpecified;
      set => this.mPaymentToReceiveCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int SecondChanceOfferCount
    {
      get => this.mSecondChanceOfferCount;
      set
      {
        this.mSecondChanceOfferCount = value;
        this.mSecondChanceOfferCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SecondChanceOfferCountSpecified
    {
      get => this.mSecondChanceOfferCountSpecified;
      set => this.mSecondChanceOfferCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingNeededCount
    {
      get => this.mShippingNeededCount;
      set
      {
        this.mShippingNeededCount = value;
        this.mShippingNeededCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingNeededCountSpecified
    {
      get => this.mShippingNeededCountSpecified;
      set => this.mShippingNeededCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RelistingNeededCount
    {
      get => this.mRelistingNeededCount;
      set
      {
        this.mRelistingNeededCount = value;
        this.mRelistingNeededCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RelistingNeededCountSpecified
    {
      get => this.mRelistingNeededCountSpecified;
      set => this.mRelistingNeededCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalNewLeadsCount
    {
      get => this.mTotalNewLeadsCount;
      set
      {
        this.mTotalNewLeadsCount = value;
        this.mTotalNewLeadsCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalNewLeadsCountSpecified
    {
      get => this.mTotalNewLeadsCountSpecified;
      set => this.mTotalNewLeadsCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DocsForCCProcessingToSendCount
    {
      get => this.mDocsForCCProcessingToSendCount;
      set
      {
        this.mDocsForCCProcessingToSendCount = value;
        this.mDocsForCCProcessingToSendCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DocsForCCProcessingToSendCountSpecified
    {
      get => this.mDocsForCCProcessingToSendCountSpecified;
      set => this.mDocsForCCProcessingToSendCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RTEToProcessCount
    {
      get => this.mRTEToProcessCount;
      set
      {
        this.mRTEToProcessCount = value;
        this.mRTEToProcessCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RTEToProcessCountSpecified
    {
      get => this.mRTEToProcessCountSpecified;
      set => this.mRTEToProcessCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ItemReceiptToConfirmCount
    {
      get => this.mItemReceiptToConfirmCount;
      set
      {
        this.mItemReceiptToConfirmCount = value;
        this.mItemReceiptToConfirmCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemReceiptToConfirmCountSpecified
    {
      get => this.mItemReceiptToConfirmCountSpecified;
      set => this.mItemReceiptToConfirmCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RefundOnHoldCount
    {
      get => this.mRefundOnHoldCount;
      set
      {
        this.mRefundOnHoldCount = value;
        this.mRefundOnHoldCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundOnHoldCountSpecified
    {
      get => this.mRefundOnHoldCountSpecified;
      set => this.mRefundOnHoldCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RefundCancelledCount
    {
      get => this.mRefundCancelledCount;
      set
      {
        this.mRefundCancelledCount = value;
        this.mRefundCancelledCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundCancelledCountSpecified
    {
      get => this.mRefundCancelledCountSpecified;
      set => this.mRefundCancelledCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingDetailsToBeProvidedCount
    {
      get => this.mShippingDetailsToBeProvidedCount;
      set
      {
        this.mShippingDetailsToBeProvidedCount = value;
        this.mShippingDetailsToBeProvidedCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingDetailsToBeProvidedCountSpecified
    {
      get => this.mShippingDetailsToBeProvidedCountSpecified;
      set => this.mShippingDetailsToBeProvidedCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ItemReceiptConfirmationToReceiveCount
    {
      get => this.mItemReceiptConfirmationToReceiveCount;
      set
      {
        this.mItemReceiptConfirmationToReceiveCount = value;
        this.mItemReceiptConfirmationToReceiveCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemReceiptConfirmationToReceiveCountSpecified
    {
      get => this.mItemReceiptConfirmationToReceiveCountSpecified;
      set => this.mItemReceiptConfirmationToReceiveCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RefundInitiatedCount
    {
      get => this.mRefundInitiatedCount;
      set
      {
        this.mRefundInitiatedCount = value;
        this.mRefundInitiatedCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundInitiatedCountSpecified
    {
      get => this.mRefundInitiatedCountSpecified;
      set => this.mRefundInitiatedCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PendingRTERequestCount
    {
      get => this.mPendingRTERequestCount;
      set
      {
        this.mPendingRTERequestCount = value;
        this.mPendingRTERequestCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PendingRTERequestCountSpecified
    {
      get => this.mPendingRTERequestCountSpecified;
      set => this.mPendingRTERequestCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DeclinedRTERequestCount
    {
      get => this.mDeclinedRTERequestCount;
      set
      {
        this.mDeclinedRTERequestCount = value;
        this.mDeclinedRTERequestCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeclinedRTERequestCountSpecified
    {
      get => this.mDeclinedRTERequestCountSpecified;
      set => this.mDeclinedRTERequestCountSpecified = value;
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
