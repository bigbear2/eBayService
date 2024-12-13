// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetBestOffersRequestType
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
  public class GetBestOffersRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mBestOfferID;
    private BestOfferStatusCodeType mBestOfferStatus;
    private bool mBestOfferStatusSpecified;
    private PaginationType mPagination;

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
    public string BestOfferID
    {
      get => this.mBestOfferID;
      set => this.mBestOfferID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public BestOfferStatusCodeType BestOfferStatus
    {
      get => this.mBestOfferStatus;
      set
      {
        this.mBestOfferStatus = value;
        this.mBestOfferStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BestOfferStatusSpecified
    {
      get => this.mBestOfferStatusSpecified;
      set => this.mBestOfferStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }
  }
}
