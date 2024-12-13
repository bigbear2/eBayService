// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetVeROReportStatusResponseType
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
  public class GetVeROReportStatusResponseType : AbstractResponseType
  {
    private PaginationResultType mPaginationResult;
    private bool mHasMoreItems;
    private bool mHasMoreItemsSpecified;
    private int mItemsPerPage;
    private bool mItemsPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private long mVeROReportPacketID;
    private bool mVeROReportPacketIDSpecified;
    private VeROReportPacketStatusCodeType mVeROReportPacketStatus;
    private bool mVeROReportPacketStatusSpecified;
    private VeROReportedItemTypeCollection mReportedItemDetails;

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HasMoreItems
    {
      get => this.mHasMoreItems;
      set
      {
        this.mHasMoreItems = value;
        this.mHasMoreItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasMoreItemsSpecified
    {
      get => this.mHasMoreItemsSpecified;
      set => this.mHasMoreItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ItemsPerPage
    {
      get => this.mItemsPerPage;
      set
      {
        this.mItemsPerPage = value;
        this.mItemsPerPageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemsPerPageSpecified
    {
      get => this.mItemsPerPageSpecified;
      set => this.mItemsPerPageSpecified = value;
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
    public long VeROReportPacketID
    {
      get => this.mVeROReportPacketID;
      set
      {
        this.mVeROReportPacketID = value;
        this.mVeROReportPacketIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VeROReportPacketIDSpecified
    {
      get => this.mVeROReportPacketIDSpecified;
      set => this.mVeROReportPacketIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VeROReportPacketStatusCodeType VeROReportPacketStatus
    {
      get => this.mVeROReportPacketStatus;
      set
      {
        this.mVeROReportPacketStatus = value;
        this.mVeROReportPacketStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VeROReportPacketStatusSpecified
    {
      get => this.mVeROReportPacketStatusSpecified;
      set => this.mVeROReportPacketStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("ReportedItem", IsNullable = false)]
    public VeROReportedItemTypeCollection ReportedItemDetails
    {
      get => this.mReportedItemDetails;
      set => this.mReportedItemDetails = value;
    }
  }
}
