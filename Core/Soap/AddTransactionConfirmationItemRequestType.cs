// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddTransactionConfirmationItemRequestType
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
  public class AddTransactionConfirmationItemRequestType : AbstractRequestType
  {
    private string mRecipientUserID;
    private string mVerifyEligibilityOnly;
    private string mRecipientPostalCode;
    private RecipientRelationCodeType mRecipientRelationType;
    private AmountType mNegotiatedPrice;
    private SecondChanceOfferDurationCodeType mListingDuration;
    private string mItemID;
    private string mComments;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string RecipientUserID
    {
      get => this.mRecipientUserID;
      set => this.mRecipientUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string VerifyEligibilityOnly
    {
      get => this.mVerifyEligibilityOnly;
      set => this.mVerifyEligibilityOnly = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string RecipientPostalCode
    {
      get => this.mRecipientPostalCode;
      set => this.mRecipientPostalCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public RecipientRelationCodeType RecipientRelationType
    {
      get => this.mRecipientRelationType;
      set => this.mRecipientRelationType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public AmountType NegotiatedPrice
    {
      get => this.mNegotiatedPrice;
      set => this.mNegotiatedPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public SecondChanceOfferDurationCodeType ListingDuration
    {
      get => this.mListingDuration;
      set => this.mListingDuration = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public string Comments
    {
      get => this.mComments;
      set => this.mComments = value;
    }
  }
}
