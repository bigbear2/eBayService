// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.LeaveFeedbackRequestType
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
  public class LeaveFeedbackRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mCommentText;
    private CommentTypeCodeType mCommentType;
    private bool mCommentTypeSpecified;
    private string mTransactionID;
    private string mTargetUser;
    private ItemRatingDetailsTypeCollection mSellerItemRatingDetailArray;
    private string mOrderLineItemID;
    private ItemArrivedWithinEDDCodeType mItemArrivedWithinEDDType;
    private bool mItemArrivedWithinEDDTypeSpecified;
    private bool mItemDeliveredWithinEDD;
    private bool mItemDeliveredWithinEDDSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string CommentText
    {
      get => this.mCommentText;
      set => this.mCommentText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string TargetUser
    {
      get => this.mTargetUser;
      set => this.mTargetUser = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 5)]
    [XmlArrayItem("ItemRatingDetails", IsNullable = false)]
    public ItemRatingDetailsTypeCollection SellerItemRatingDetailArray
    {
      get => this.mSellerItemRatingDetailArray;
      set => this.mSellerItemRatingDetailArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public ItemArrivedWithinEDDCodeType ItemArrivedWithinEDDType
    {
      get => this.mItemArrivedWithinEDDType;
      set
      {
        this.mItemArrivedWithinEDDType = value;
        this.mItemArrivedWithinEDDTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemArrivedWithinEDDTypeSpecified
    {
      get => this.mItemArrivedWithinEDDTypeSpecified;
      set => this.mItemArrivedWithinEDDTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public bool ItemDeliveredWithinEDD
    {
      get => this.mItemDeliveredWithinEDD;
      set
      {
        this.mItemDeliveredWithinEDD = value;
        this.mItemDeliveredWithinEDDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemDeliveredWithinEDDSpecified
    {
      get => this.mItemDeliveredWithinEDDSpecified;
      set => this.mItemDeliveredWithinEDDSpecified = value;
    }
  }
}
