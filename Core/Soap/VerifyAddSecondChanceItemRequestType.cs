// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VerifyAddSecondChanceItemRequestType
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
  public class VerifyAddSecondChanceItemRequestType : AbstractRequestType
  {
    private string mRecipientBidderUserID;
    private AmountType mBuyItNowPrice;
    private SecondChanceOfferDurationCodeType mDuration;
    private bool mDurationSpecified;
    private string mItemID;
    private string mSellerMessage;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string RecipientBidderUserID
    {
      get => this.mRecipientBidderUserID;
      set => this.mRecipientBidderUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public AmountType BuyItNowPrice
    {
      get => this.mBuyItNowPrice;
      set => this.mBuyItNowPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public SecondChanceOfferDurationCodeType Duration
    {
      get => this.mDuration;
      set
      {
        this.mDuration = value;
        this.mDurationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DurationSpecified
    {
      get => this.mDurationSpecified;
      set => this.mDurationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string SellerMessage
    {
      get => this.mSellerMessage;
      set => this.mSellerMessage = value;
    }
  }
}
