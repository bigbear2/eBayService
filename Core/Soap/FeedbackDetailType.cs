// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FeedbackDetailType
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
  public class FeedbackDetailType
  {
    private string mCommentingUser;
    private FeedbackRatingStarCodeType mFeedbackRatingStar;
    private bool mFeedbackRatingStarSpecified;
    private int mCommentingUserScore;
    private bool mCommentingUserScoreSpecified;
    private string mCommentText;
    private DateTime mCommentTime;
    private bool mCommentTimeSpecified;
    private CommentTypeCodeType mCommentType;
    private bool mCommentTypeSpecified;
    private string mFeedbackResponse;
    private string mFollowup;
    private string mItemID;
    private TradingRoleCodeType mRole;
    private bool mRoleSpecified;
    private string mItemTitle;
    private AmountType mItemPrice;
    private string mFeedbackID;
    private string mTransactionID;
    private bool mCommentReplaced;
    private bool mCommentReplacedSpecified;
    private bool mResponseReplaced;
    private bool mResponseReplacedSpecified;
    private bool mFollowUpReplaced;
    private bool mFollowUpReplacedSpecified;
    private bool mCountable;
    private bool mCountableSpecified;
    private bool mFeedbackRevised;
    private bool mFeedbackRevisedSpecified;
    private string mOrderLineItemID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string CommentingUser
    {
      get => this.mCommentingUser;
      set => this.mCommentingUser = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeedbackRatingStarCodeType FeedbackRatingStar
    {
      get => this.mFeedbackRatingStar;
      set
      {
        this.mFeedbackRatingStar = value;
        this.mFeedbackRatingStarSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackRatingStarSpecified
    {
      get => this.mFeedbackRatingStarSpecified;
      set => this.mFeedbackRatingStarSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CommentingUserScore
    {
      get => this.mCommentingUserScore;
      set
      {
        this.mCommentingUserScore = value;
        this.mCommentingUserScoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CommentingUserScoreSpecified
    {
      get => this.mCommentingUserScoreSpecified;
      set => this.mCommentingUserScoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CommentText
    {
      get => this.mCommentText;
      set => this.mCommentText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CommentTime
    {
      get => this.mCommentTime;
      set
      {
        this.mCommentTime = value;
        this.mCommentTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CommentTimeSpecified
    {
      get => this.mCommentTimeSpecified;
      set => this.mCommentTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CommentTypeCodeType CommentType
    {
      get => this.mCommentType;
      set
      {
        this.mCommentType = value;
        this.mCommentTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CommentTypeSpecified
    {
      get => this.mCommentTypeSpecified;
      set => this.mCommentTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FeedbackResponse
    {
      get => this.mFeedbackResponse;
      set => this.mFeedbackResponse = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Followup
    {
      get => this.mFollowup;
      set => this.mFollowup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TradingRoleCodeType Role
    {
      get => this.mRole;
      set
      {
        this.mRole = value;
        this.mRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RoleSpecified
    {
      get => this.mRoleSpecified;
      set => this.mRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ItemTitle
    {
      get => this.mItemTitle;
      set => this.mItemTitle = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType ItemPrice
    {
      get => this.mItemPrice;
      set => this.mItemPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FeedbackID
    {
      get => this.mFeedbackID;
      set => this.mFeedbackID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CommentReplaced
    {
      get => this.mCommentReplaced;
      set
      {
        this.mCommentReplaced = value;
        this.mCommentReplacedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CommentReplacedSpecified
    {
      get => this.mCommentReplacedSpecified;
      set => this.mCommentReplacedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ResponseReplaced
    {
      get => this.mResponseReplaced;
      set
      {
        this.mResponseReplaced = value;
        this.mResponseReplacedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResponseReplacedSpecified
    {
      get => this.mResponseReplacedSpecified;
      set => this.mResponseReplacedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FollowUpReplaced
    {
      get => this.mFollowUpReplaced;
      set
      {
        this.mFollowUpReplaced = value;
        this.mFollowUpReplacedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FollowUpReplacedSpecified
    {
      get => this.mFollowUpReplacedSpecified;
      set => this.mFollowUpReplacedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Countable
    {
      get => this.mCountable;
      set
      {
        this.mCountable = value;
        this.mCountableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CountableSpecified
    {
      get => this.mCountableSpecified;
      set => this.mCountableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool FeedbackRevised
    {
      get => this.mFeedbackRevised;
      set
      {
        this.mFeedbackRevised = value;
        this.mFeedbackRevisedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackRevisedSpecified
    {
      get => this.mFeedbackRevisedSpecified;
      set => this.mFeedbackRevisedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
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
