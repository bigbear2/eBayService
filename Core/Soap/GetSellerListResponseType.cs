// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellerListResponseType
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
  public class GetSellerListResponseType : AbstractResponseType
  {
    private PaginationResultType mPaginationResult;
    private bool mHasMoreItems;
    private bool mHasMoreItemsSpecified;
    private ItemTypeCollection mItemArray;
    private int mItemsPerPage;
    private bool mItemsPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private int mReturnedItemCountActual;
    private bool mReturnedItemCountActualSpecified;
    private UserType mSeller;

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
    [XmlArrayItem("Item", IsNullable = false)]
    public ItemTypeCollection ItemArray
    {
      get => this.mItemArray;
      set => this.mItemArray = value;
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
    public int ReturnedItemCountActual
    {
      get => this.mReturnedItemCountActual;
      set
      {
        this.mReturnedItemCountActual = value;
        this.mReturnedItemCountActualSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnedItemCountActualSpecified
    {
      get => this.mReturnedItemCountActualSpecified;
      set => this.mReturnedItemCountActualSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UserType Seller
    {
      get => this.mSeller;
      set => this.mSeller = value;
    }
  }
}
