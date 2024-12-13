// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetAllBiddersResponseType
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
  public class GetAllBiddersResponseType : AbstractResponseType
  {
    private OfferTypeCollection mBidArray;
    private string mHighBidder;
    private AmountType mHighestBid;
    private ListingStatusCodeType mListingStatus;
    private bool mListingStatusSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Offer", IsNullable = false)]
    public OfferTypeCollection BidArray
    {
      get => this.mBidArray;
      set => this.mBidArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string HighBidder
    {
      get => this.mHighBidder;
      set => this.mHighBidder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType HighestBid
    {
      get => this.mHighestBid;
      set => this.mHighestBid = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingStatusCodeType ListingStatus
    {
      get => this.mListingStatus;
      set
      {
        this.mListingStatus = value;
        this.mListingStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingStatusSpecified
    {
      get => this.mListingStatusSpecified;
      set => this.mListingStatusSpecified = value;
    }
  }
}
