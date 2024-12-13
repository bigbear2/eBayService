// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BuyerRoleMetricsType
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
  public class BuyerRoleMetricsType
  {
    private int mPositiveFeedbackLeftCount;
    private bool mPositiveFeedbackLeftCountSpecified;
    private int mNegativeFeedbackLeftCount;
    private bool mNegativeFeedbackLeftCountSpecified;
    private int mNeutralFeedbackLeftCount;
    private bool mNeutralFeedbackLeftCountSpecified;
    private float mFeedbackLeftPercent;
    private bool mFeedbackLeftPercentSpecified;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
