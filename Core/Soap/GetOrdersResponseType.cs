// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetOrdersResponseType
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
  public class GetOrdersResponseType : AbstractResponseType
  {
    private PaginationResultType mPaginationResult;
    private bool mHasMoreOrders;
    private bool mHasMoreOrdersSpecified;
    private OrderTypeCollection mOrderArray;
    private int mOrdersPerPage;
    private bool mOrdersPerPageSpecified;
    private int mPageNumber;
    private bool mPageNumberSpecified;
    private int mReturnedOrderCountActual;
    private bool mReturnedOrderCountActualSpecified;

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
    public bool HasMoreOrders
    {
      get => this.mHasMoreOrders;
      set
      {
        this.mHasMoreOrders = value;
        this.mHasMoreOrdersSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HasMoreOrdersSpecified
    {
      get => this.mHasMoreOrdersSpecified;
      set => this.mHasMoreOrdersSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Order", IsNullable = false)]
    public OrderTypeCollection OrderArray
    {
      get => this.mOrderArray;
      set => this.mOrderArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int OrdersPerPage
    {
      get => this.mOrdersPerPage;
      set
      {
        this.mOrdersPerPage = value;
        this.mOrdersPerPageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrdersPerPageSpecified
    {
      get => this.mOrdersPerPageSpecified;
      set => this.mOrdersPerPageSpecified = value;
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
    public int ReturnedOrderCountActual
    {
      get => this.mReturnedOrderCountActual;
      set
      {
        this.mReturnedOrderCountActual = value;
        this.mReturnedOrderCountActualSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnedOrderCountActualSpecified
    {
      get => this.mReturnedOrderCountActualSpecified;
      set => this.mReturnedOrderCountActualSpecified = value;
    }
  }
}
