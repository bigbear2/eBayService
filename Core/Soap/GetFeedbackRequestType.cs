// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetFeedbackRequestType
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
  public class GetFeedbackRequestType : AbstractRequestType
  {
    private string mUserID;
    private string mFeedbackID;
    private string mItemID;
    private string mTransactionID;
    private CommentTypeCodeTypeCollection mCommentType;
    private FeedbackTypeCodeType mFeedbackType;
    private bool mFeedbackTypeSpecified;
    private PaginationType mPagination;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string FeedbackID
    {
      get => this.mFeedbackID;
      set => this.mFeedbackID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CommentType", Order = 4)]
    public CommentTypeCodeTypeCollection CommentType
    {
      get => this.mCommentType;
      set => this.mCommentType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public FeedbackTypeCodeType FeedbackType
    {
      get => this.mFeedbackType;
      set
      {
        this.mFeedbackType = value;
        this.mFeedbackTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeedbackTypeSpecified
    {
      get => this.mFeedbackTypeSpecified;
      set => this.mFeedbackTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
