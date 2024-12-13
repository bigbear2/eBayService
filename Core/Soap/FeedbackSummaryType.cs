// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FeedbackSummaryType
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
  public class FeedbackSummaryType
  {
    private FeedbackPeriodTypeCollection mBidRetractionFeedbackPeriodArray;
    private FeedbackPeriodTypeCollection mNegativeFeedbackPeriodArray;
    private FeedbackPeriodTypeCollection mNeutralFeedbackPeriodArray;
    private FeedbackPeriodTypeCollection mPositiveFeedbackPeriodArray;
    private FeedbackPeriodTypeCollection mTotalFeedbackPeriodArray;
    private int mNeutralCommentCountFromSuspendedUsers;
    private bool mNeutralCommentCountFromSuspendedUsersSpecified;
    private int mUniqueNegativeFeedbackCount;
    private bool mUniqueNegativeFeedbackCountSpecified;
    private int mUniquePositiveFeedbackCount;
    private bool mUniquePositiveFeedbackCountSpecified;
    private int mUniqueNeutralFeedbackCount;
    private bool mUniqueNeutralFeedbackCountSpecified;
    private AverageRatingSummaryTypeCollection mSellerRatingSummaryArray;
    private SellerRoleMetricsType mSellerRoleMetrics;
    private BuyerRoleMetricsType mBuyerRoleMetrics;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackPeriod", IsNullable = false)]
    public FeedbackPeriodTypeCollection BidRetractionFeedbackPeriodArray
    {
      get => this.mBidRetractionFeedbackPeriodArray;
      set => this.mBidRetractionFeedbackPeriodArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackPeriod", IsNullable = false)]
    public FeedbackPeriodTypeCollection NegativeFeedbackPeriodArray
    {
      get => this.mNegativeFeedbackPeriodArray;
      set => this.mNegativeFeedbackPeriodArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackPeriod", IsNullable = false)]
    public FeedbackPeriodTypeCollection NeutralFeedbackPeriodArray
    {
      get => this.mNeutralFeedbackPeriodArray;
      set => this.mNeutralFeedbackPeriodArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackPeriod", IsNullable = false)]
    public FeedbackPeriodTypeCollection PositiveFeedbackPeriodArray
    {
      get => this.mPositiveFeedbackPeriodArray;
      set => this.mPositiveFeedbackPeriodArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackPeriod", IsNullable = false)]
    public FeedbackPeriodTypeCollection TotalFeedbackPeriodArray
    {
      get => this.mTotalFeedbackPeriodArray;
      set => this.mTotalFeedbackPeriodArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NeutralCommentCountFromSuspendedUsers
    {
      get => this.mNeutralCommentCountFromSuspendedUsers;
      set
      {
        this.mNeutralCommentCountFromSuspendedUsers = value;
        this.mNeutralCommentCountFromSuspendedUsersSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NeutralCommentCountFromSuspendedUsersSpecified
    {
      get => this.mNeutralCommentCountFromSuspendedUsersSpecified;
      set => this.mNeutralCommentCountFromSuspendedUsersSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniqueNegativeFeedbackCount
    {
      get => this.mUniqueNegativeFeedbackCount;
      set
      {
        this.mUniqueNegativeFeedbackCount = value;
        this.mUniqueNegativeFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniqueNegativeFeedbackCountSpecified
    {
      get => this.mUniqueNegativeFeedbackCountSpecified;
      set => this.mUniqueNegativeFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniquePositiveFeedbackCount
    {
      get => this.mUniquePositiveFeedbackCount;
      set
      {
        this.mUniquePositiveFeedbackCount = value;
        this.mUniquePositiveFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniquePositiveFeedbackCountSpecified
    {
      get => this.mUniquePositiveFeedbackCountSpecified;
      set => this.mUniquePositiveFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UniqueNeutralFeedbackCount
    {
      get => this.mUniqueNeutralFeedbackCount;
      set
      {
        this.mUniqueNeutralFeedbackCount = value;
        this.mUniqueNeutralFeedbackCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UniqueNeutralFeedbackCountSpecified
    {
      get => this.mUniqueNeutralFeedbackCountSpecified;
      set => this.mUniqueNeutralFeedbackCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("AverageRatingSummary", IsNullable = false)]
    public AverageRatingSummaryTypeCollection SellerRatingSummaryArray
    {
      get => this.mSellerRatingSummaryArray;
      set => this.mSellerRatingSummaryArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerRoleMetricsType SellerRoleMetrics
    {
      get => this.mSellerRoleMetrics;
      set => this.mSellerRoleMetrics = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BuyerRoleMetricsType BuyerRoleMetrics
    {
      get => this.mBuyerRoleMetrics;
      set => this.mBuyerRoleMetrics = value;
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
