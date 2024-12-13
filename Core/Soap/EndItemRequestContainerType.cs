// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.EndItemRequestContainerType
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
  public class EndItemRequestContainerType
  {
    private string mItemID;
    private EndReasonCodeType mEndingReason;
    private bool mEndingReasonSpecified;
    private string mMessageID;
    private string mSellerInventoryID;
    private XmlElementCollection mAny;

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
    public EndReasonCodeType EndingReason
    {
      get => this.mEndingReason;
      set
      {
        this.mEndingReason = value;
        this.mEndingReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndingReasonSpecified
    {
      get => this.mEndingReasonSpecified;
      set => this.mEndingReasonSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MessageID
    {
      get => this.mMessageID;
      set => this.mMessageID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerInventoryID
    {
      get => this.mSellerInventoryID;
      set => this.mSellerInventoryID = value;
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
