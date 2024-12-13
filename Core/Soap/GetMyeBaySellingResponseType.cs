// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMyeBaySellingResponseType
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
  public class GetMyeBaySellingResponseType : AbstractResponseType
  {
    private SellingSummaryType mSellingSummary;
    private PaginatedItemArrayType mScheduledList;
    private PaginatedItemArrayType mActiveList;
    private PaginatedOrderTransactionArrayType mSoldList;
    private PaginatedItemArrayType mUnsoldList;
    private MyeBaySellingSummaryType mSummary;
    private PaginatedItemArrayType mBidList;
    private PaginatedOrderTransactionArrayType mDeletedFromSoldList;
    private PaginatedItemArrayType mDeletedFromUnsoldList;

    /// <summary>
    /// 
    /// </summary>
    public SellingSummaryType SellingSummary
    {
      get => this.mSellingSummary;
      set => this.mSellingSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType ScheduledList
    {
      get => this.mScheduledList;
      set => this.mScheduledList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType ActiveList
    {
      get => this.mActiveList;
      set => this.mActiveList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedOrderTransactionArrayType SoldList
    {
      get => this.mSoldList;
      set => this.mSoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType UnsoldList
    {
      get => this.mUnsoldList;
      set => this.mUnsoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MyeBaySellingSummaryType Summary
    {
      get => this.mSummary;
      set => this.mSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType BidList
    {
      get => this.mBidList;
      set => this.mBidList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedOrderTransactionArrayType DeletedFromSoldList
    {
      get => this.mDeletedFromSoldList;
      set => this.mDeletedFromSoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginatedItemArrayType DeletedFromUnsoldList
    {
      get => this.mDeletedFromUnsoldList;
      set => this.mDeletedFromUnsoldList = value;
    }
  }
}
