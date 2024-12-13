// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellerListCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetSellerListCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellerListCall() => this.ApiRequest = new GetSellerListRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellerListCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellerListRequestType();
      this.ApiContext = ApiContext;
    }

    public ItemTypeCollection GetSellerList(
      string UserID,
      UserIDArrayType MotorsDealerUserList,
      DateTime EndTimeFrom,
      DateTime EndTimeTo,
      int Sort,
      DateTime StartTimeFrom,
      DateTime StartTimeTo,
      PaginationType Pagination,
      GranularityLevelCodeType GranularityLevel,
      StringCollection SKUArrayList,
      bool IncludeWatchCount,
      bool AdminEndedItemsOnly,
      int CategoryID,
      bool IncludeVariations)
    {
      this.UserID = UserID;
      this.MotorsDealerUserList = MotorsDealerUserList;
      this.EndTimeFrom = EndTimeFrom;
      this.EndTimeTo = EndTimeTo;
      this.Sort = Sort;
      this.StartTimeFrom = StartTimeFrom;
      this.StartTimeTo = StartTimeTo;
      this.Pagination = Pagination;
      this.GranularityLevel = GranularityLevel;
      this.SKUArrayList = SKUArrayList;
      this.IncludeWatchCount = IncludeWatchCount;
      this.AdminEndedItemsOnly = AdminEndedItemsOnly;
      this.CategoryID = CategoryID;
      this.IncludeVariations = IncludeVariations;
      this.Execute();
      return this.ApiResponse.ItemArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public ItemTypeCollection GetSellerList()
    {
      this.Execute();
      return this.ItemList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellerListRequestType" /> for this API call.
    /// </summary>
    public GetSellerListRequestType ApiRequest
    {
      get => (GetSellerListRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellerListResponseType" /> for this API call.
    /// </summary>
    public GetSellerListResponseType ApiResponse
    {
      get => (GetSellerListResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.UserID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string UserID
    {
      get => this.ApiRequest.UserID;
      set => this.ApiRequest.UserID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.MotorsDealerUsers" /> of type <see cref="T:eBay.Service.Core.Soap.UserIDArrayType" />.
    /// </summary>
    public UserIDArrayType MotorsDealerUserList
    {
      get => this.ApiRequest.MotorsDealerUsers;
      set => this.ApiRequest.MotorsDealerUsers = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.EndTimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTimeFrom
    {
      get => this.ApiRequest.EndTimeFrom;
      set => this.ApiRequest.EndTimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.EndTimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTimeTo
    {
      get => this.ApiRequest.EndTimeTo;
      set => this.ApiRequest.EndTimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.Sort" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int Sort
    {
      get => this.ApiRequest.Sort;
      set => this.ApiRequest.Sort = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.StartTimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTimeFrom
    {
      get => this.ApiRequest.StartTimeFrom;
      set => this.ApiRequest.StartTimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.StartTimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTimeTo
    {
      get => this.ApiRequest.StartTimeTo;
      set => this.ApiRequest.StartTimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.GranularityLevel" /> of type <see cref="T:eBay.Service.Core.Soap.GranularityLevelCodeType" />.
    /// </summary>
    public GranularityLevelCodeType GranularityLevel
    {
      get => this.ApiRequest.GranularityLevel;
      set => this.ApiRequest.GranularityLevel = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.SKUArray" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection SKUArrayList
    {
      get => this.ApiRequest.SKUArray;
      set => this.ApiRequest.SKUArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.IncludeWatchCount" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeWatchCount
    {
      get => this.ApiRequest.IncludeWatchCount;
      set => this.ApiRequest.IncludeWatchCount = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.AdminEndedItemsOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool AdminEndedItemsOnly
    {
      get => this.ApiRequest.AdminEndedItemsOnly;
      set => this.ApiRequest.AdminEndedItemsOnly = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.CategoryID" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int CategoryID
    {
      get => this.ApiRequest.CategoryID;
      set => this.ApiRequest.CategoryID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.IncludeVariations" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeVariations
    {
      get => this.ApiRequest.IncludeVariations;
      set => this.ApiRequest.IncludeVariations = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.EndTimeFrom" /> and <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.EndTimeTo" /> of type <see cref="T:eBay.Service.Core.Soap.TimeFilter" />.
    /// </summary>
    public TimeFilter EndTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.EndTimeFrom, this.ApiRequest.EndTimeTo);
      set
      {
        if (value.TimeFrom > DateTime.MinValue)
          this.ApiRequest.EndTimeFrom = value.TimeFrom;
        if (!(value.TimeTo > DateTime.MinValue))
          return;
        this.ApiRequest.EndTimeTo = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.StartTimeFrom" /> and <see cref="P:eBay.Service.Core.Soap.GetSellerListRequestType.StartTimeTo" /> of type <see cref="T:eBay.Service.Core.Soap.TimeFilter" />.
    /// </summary>
    public TimeFilter StartTimeFilter
    {
      get => new TimeFilter(this.ApiRequest.StartTimeFrom, this.ApiRequest.StartTimeTo);
      set
      {
        if (value.TimeFrom > DateTime.MinValue)
          this.ApiRequest.StartTimeFrom = value.TimeFrom;
        if (!(value.TimeTo > DateTime.MinValue))
          return;
        this.ApiRequest.StartTimeTo = value.TimeTo;
      }
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.HasMoreItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreItems => this.ApiResponse.HasMoreItems;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.ItemArray" /> of type <see cref="T:eBay.Service.Core.Soap.ItemTypeCollection" />.
    /// </summary>
    public ItemTypeCollection ItemList => this.ApiResponse.ItemArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.ItemsPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ItemsPerPage => this.ApiResponse.ItemsPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.ReturnedItemCountActual" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ReturnedItemCountActual => this.ApiResponse.ReturnedItemCountActual;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellerListResponseType.Seller" /> of type <see cref="T:eBay.Service.Core.Soap.UserType" />.
    /// </summary>
    public UserType Seller => this.ApiResponse.Seller;
  }
}
