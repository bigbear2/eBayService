// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserDisputesResponseType
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
  public class GetUserDisputesResponseType : AbstractResponseType
  {
    private string mStartingDisputeID;
    private string mEndingDisputeID;
    private DisputeTypeCollection mDisputeArray;
    private int mItemsPerPage;
    private bool mItemsPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private DisputeFilterCountTypeCollection mDisputeFilterCount;
    private PaginationResultType mPaginationResult;

    /// <summary>
    /// 
    /// </summary>
    public string StartingDisputeID
    {
      get => this.mStartingDisputeID;
      set => this.mStartingDisputeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EndingDisputeID
    {
      get => this.mEndingDisputeID;
      set => this.mEndingDisputeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Dispute", IsNullable = false)]
    public DisputeTypeCollection DisputeArray
    {
      get => this.mDisputeArray;
      set => this.mDisputeArray = value;
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
    [XmlElement("DisputeFilterCount")]
    public DisputeFilterCountTypeCollection DisputeFilterCount
    {
      get => this.mDisputeFilterCount;
      set => this.mDisputeFilterCount = value;
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
