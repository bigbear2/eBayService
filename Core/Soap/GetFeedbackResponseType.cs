// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetFeedbackResponseType
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
  public class GetFeedbackResponseType : AbstractResponseType
  {
    private FeedbackDetailTypeCollection mFeedbackDetailArray;
    private int mFeedbackDetailItemTotal;
    private bool mFeedbackDetailItemTotalSpecified;
    private FeedbackSummaryType mFeedbackSummary;
    private int mFeedbackScore;
    private bool mFeedbackScoreSpecified;
    private PaginationResultType mPaginationResult;
    private int mEntriesPerPage;
    private bool mEntriesPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("FeedbackDetail", IsNullable = false)]
    public FeedbackDetailTypeCollection FeedbackDetailArray
    {
      get => this.mFeedbackDetailArray;
      set => this.mFeedbackDetailArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FeedbackDetailItemTotal
    {
      get => this.mFeedbackDetailItemTotal;
      set
      {
        this.mFeedbackDetailItemTotal = value;
        this.mFeedbackDetailItemTotalSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackDetailItemTotalSpecified
    {
      get => this.mFeedbackDetailItemTotalSpecified;
      set => this.mFeedbackDetailItemTotalSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FeedbackSummaryType FeedbackSummary
    {
      get => this.mFeedbackSummary;
      set => this.mFeedbackSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FeedbackScore
    {
      get => this.mFeedbackScore;
      set
      {
        this.mFeedbackScore = value;
        this.mFeedbackScoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackScoreSpecified
    {
      get => this.mFeedbackScoreSpecified;
      set => this.mFeedbackScoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int EntriesPerPage
    {
      get => this.mEntriesPerPage;
      set
      {
        this.mEntriesPerPage = value;
        this.mEntriesPerPageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EntriesPerPageSpecified
    {
      get => this.mEntriesPerPageSpecified;
      set => this.mEntriesPerPageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PageNumber
    {
      get => this.mPageNumber;
      set
      {
        this.mPageNumber = value;
        this.mPageNumberSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PageNumberSpecified
    {
      get => this.mPageNumberSpecified;
      set => this.mPageNumberSpecified = value;
    }
  }
}
