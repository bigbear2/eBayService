// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RespondToFeedbackRequestType
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
  public class RespondToFeedbackRequestType : AbstractRequestType
  {
    private string mFeedbackID;
    private string mItemID;
    private string mTransactionID;
    private string mTargetUserID;
    private FeedbackResponseCodeType mResponseType;
    private bool mResponseTypeSpecified;
    private string mResponseText;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string FeedbackID
    {
      get => this.mFeedbackID;
      set => this.mFeedbackID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string TargetUserID
    {
      get => this.mTargetUserID;
      set => this.mTargetUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public FeedbackResponseCodeType ResponseType
    {
      get => this.mResponseType;
      set
      {
        this.mResponseType = value;
        this.mResponseTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResponseTypeSpecified
    {
      get => this.mResponseTypeSpecified;
      set => this.mResponseTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public string ResponseText
    {
      get => this.mResponseText;
      set => this.mResponseText = value;
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
  }
}
