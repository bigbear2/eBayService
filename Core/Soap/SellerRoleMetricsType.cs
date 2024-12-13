// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerRoleMetricsType
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
  public class SellerRoleMetricsType
  {
    private int mPositiveFeedbackLeftCount;
    private bool mPositiveFeedbackLeftCountSpecified;
    private int mNegativeFeedbackLeftCount;
    private bool mNegativeFeedbackLeftCountSpecified;
    private int mNeutralFeedbackLeftCount;
    private bool mNeutralFeedbackLeftCountSpecified;
    private float mFeedbackLeftPercent;
    private bool mFeedbackLeftPercentSpecified;
    private int mRepeatBuyerCount;
    private bool mRepeatBuyerCountSpecified;
    private float mRepeatBuyerPercent;
    private bool mRepeatBuyerPercentSpecified;
    private int mUniqueBuyerCount;
    private bool mUniqueBuyerCountSpecified;
    private float mTransactionPercent;
    private bool mTransactionPercentSpecified;
    private int mCrossBorderTransactionCount;
    private bool mCrossBorderTransactionCountSpecified;
    private float mCrossBorderTransactionPercent;
    private bool mCrossBorderTransactionPercentSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int PositiveFeedbackLeftCount
    {
      get => this.mPositiveFeedbackLeftCount;
      set
      {
        this.mPositiveFeedbackLeftCount = value;
        this.mPositiveFeedbackLeftCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PositiveFeedbackLeftCountSpecified
    {
      get => this.mPositiveFeedbackLeftCountSpecified;
      set => this.mPositiveFeedbackLeftCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NegativeFeedbackLeftCount
    {
      get => this.mNegativeFeedbackLeftCount;
      set
      {
        this.mNegativeFeedbackLeftCount = value;
        this.mNegativeFeedbackLeftCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NegativeFeedbackLeftCountSpecified
    {
      get => this.mNegativeFeedbackLeftCountSpecified;
      set => this.mNegativeFeedbackLeftCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NeutralFeedbackLeftCount
    {
      get => this.mNeutralFeedbackLeftCount;
      set
      {
        this.mNeutralFeedbackLeftCount = value;
        this.mNeutralFeedbackLeftCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NeutralFeedbackLeftCountSpecified
    {
      get => this.mNeutralFeedbackLeftCountSpecified;
      set => this.mNeutralFeedbackLeftCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float FeedbackLeftPercent
    {
      get => this.mFeedbackLeftPercent;
      set
      {
        this.mFeedbackLeftPercent = value;
        this.mFeedbackLeftPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackLeftPercentSpecified
    {
      get => this.mFeedbackLeftPercentSpecified;
      set => this.mFeedbackLeftPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RepeatBuyerCount
    {
      get => this.mRepeatBuyerCount;
      set
      {
        this.mRepeatBuyerCount = value;
        this.mRepeatBuyerCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RepeatBuyerCountSpecified
    {
      get => this.mRepeatBuyerCountSpecified;
      set => this.mRepeatBuyerCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float RepeatBuyerPercent
    {
      get => this.mRepeatBuyerPercent;
      set
      {
        this.mRepeatBuyerPercent = value;
        this.mRepeatBuyerPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RepeatBuyerPercentSpecified
    {
      get => this.mRepeatBuyerPercentSpecified;
      set => this.mRepeatBuyerPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniqueBuyerCount
    {
      get => this.mUniqueBuyerCount;
      set
      {
        this.mUniqueBuyerCount = value;
        this.mUniqueBuyerCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniqueBuyerCountSpecified
    {
      get => this.mUniqueBuyerCountSpecified;
      set => this.mUniqueBuyerCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float TransactionPercent
    {
      get => this.mTransactionPercent;
      set
      {
        this.mTransactionPercent = value;
        this.mTransactionPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionPercentSpecified
    {
      get => this.mTransactionPercentSpecified;
      set => this.mTransactionPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CrossBorderTransactionCount
    {
      get => this.mCrossBorderTransactionCount;
      set
      {
        this.mCrossBorderTransactionCount = value;
        this.mCrossBorderTransactionCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossBorderTransactionCountSpecified
    {
      get => this.mCrossBorderTransactionCountSpecified;
      set => this.mCrossBorderTransactionCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float CrossBorderTransactionPercent
    {
      get => this.mCrossBorderTransactionPercent;
      set
      {
        this.mCrossBorderTransactionPercent = value;
        this.mCrossBorderTransactionPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CrossBorderTransactionPercentSpecified
    {
      get => this.mCrossBorderTransactionPercentSpecified;
      set => this.mCrossBorderTransactionPercentSpecified = value;
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
