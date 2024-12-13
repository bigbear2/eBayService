// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RespondToBestOfferRequestType
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
  public class RespondToBestOfferRequestType : AbstractRequestType
  {
    private string mItemID;
    private StringCollection mBestOfferID;
    private BestOfferActionCodeType mAction;
    private bool mActionSpecified;
    private string mSellerResponse;
    private AmountType mCounterOfferPrice;
    private int mCounterOfferQuantity;
    private bool mCounterOfferQuantitySpecified;

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
    [XmlElement("BestOfferID", Order = 1)]
    public StringCollection BestOfferID
    {
      get => this.mBestOfferID;
      set => this.mBestOfferID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public BestOfferActionCodeType Action
    {
      get => this.mAction;
      set
      {
        this.mAction = value;
        this.mActionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionSpecified
    {
      get => this.mActionSpecified;
      set => this.mActionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string SellerResponse
    {
      get => this.mSellerResponse;
      set => this.mSellerResponse = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public AmountType CounterOfferPrice
    {
      get => this.mCounterOfferPrice;
      set => this.mCounterOfferPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public int CounterOfferQuantity
    {
      get => this.mCounterOfferQuantity;
      set
      {
        this.mCounterOfferQuantity = value;
        this.mCounterOfferQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CounterOfferQuantitySpecified
    {
      get => this.mCounterOfferQuantitySpecified;
      set => this.mCounterOfferQuantitySpecified = value;
    }
  }
}
