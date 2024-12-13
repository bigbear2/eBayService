// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddDisputeRequestType
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
  public class AddDisputeRequestType : AbstractRequestType
  {
    private DisputeExplanationCodeType mDisputeExplanation;
    private bool mDisputeExplanationSpecified;
    private DisputeReasonCodeType mDisputeReason;
    private bool mDisputeReasonSpecified;
    private string mItemID;
    private string mTransactionID;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public DisputeExplanationCodeType DisputeExplanation
    {
      get => this.mDisputeExplanation;
      set
      {
        this.mDisputeExplanation = value;
        this.mDisputeExplanationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeExplanationSpecified
    {
      get => this.mDisputeExplanationSpecified;
      set => this.mDisputeExplanationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DisputeReasonCodeType DisputeReason
    {
      get => this.mDisputeReason;
      set
      {
        this.mDisputeReason = value;
        this.mDisputeReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeReasonSpecified
    {
      get => this.mDisputeReasonSpecified;
      set => this.mDisputeReasonSpecified = value;
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
    [XmlElement(Order = 4)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
