// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetBestOffersResponseType
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
  public class GetBestOffersResponseType : AbstractResponseType
  {
    private BestOfferTypeCollection mBestOfferArray;
    private ItemType mItem;
    private ItemBestOffersArrayType mItemBestOffersArray;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private PaginationResultType mPaginationResult;

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("BestOffer", IsNullable = false)]
    public BestOfferTypeCollection BestOfferArray
    {
      get => this.mBestOfferArray;
      set => this.mBestOfferArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemType Item
    {
      get => this.mItem;
      set => this.mItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemBestOffersArrayType ItemBestOffersArray
    {
      get => this.mItemBestOffersArray;
      set => this.mItemBestOffersArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PageNumber
    {
      get => this.mPageNumber;
      set
      {
        this.mPageNumber = value;
        this.mPageNumberSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PageNumberSpecified
    {
      get => this.mPageNumberSpecified;
      set => this.mPageNumberSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }
  }
}
