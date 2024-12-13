// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetUserDisputesCall
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
  public class GetUserDisputesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetUserDisputesCall() => this.ApiRequest = new GetUserDisputesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetUserDisputesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetUserDisputesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Requests a list of disputes the requester is involved in as buyer or seller. eBay Money Back Guarantee Item Not Received and Return cases are not returned with this call. To retrieve eBay Money Back Guarantee cases, use the <b>Search Cases</b> call of the Post-Order API (or alternatively, the <b>getUserCases</b> call of the Resolution Case Management API.
    /// </summary>
    /// <param name="DisputeFilterType">
    /// An inclusive filter that isolates the returned disputes to a certain type such as Item Not Received or Unpaid Item disputes. eBay Money Back Guarantee cases are not retrieved with this call, even if the <b>ItemNotReceivedDisputes</b> filter is included in the request.
    /// </param>
    /// <param name="DisputeSortType">
    /// One of the values defined in <b>DisputeSortTypeCodeType</b> is used here to control the order of disputes that are returned.
    /// </param>
    /// <param name="ModTimeFrom">
    /// A filter that retrieves disputes whose <b>DisputeModifiedTime</b> is later than or equal to this value. Specify the time value in GMT. See the eBay Features Guide for information about specifying time values. For more precise control of the date range filter, it is a good practice to also specify <b>ModTimeTo</b>. Otherwise, the end of the date range is the present time. Filtering by date range is optional. You can use date range filters in combination with other filters like <b>DisputeFilterType</b> to control the amount of data returned.
    /// </param>
    /// <param name="ModTimeTo">
    /// A filter that retrieves disputes whose <b>DisputeModifiedTime</b> is earlier than or equal to this value. Specify the time value in GMT. See the eBay Features Guide for information about specifying time values. For more precise control of the date range filter, it is a good practice to also specify <b>ModTimeFrom</b>. Otherwise, all available disputes modified prior to the <b>ModTimeTo</b> value are returned. Filtering by date range is optional. You can use date range filters in combination with other filters like <b>DisputeFilterType</b> to control the amount of data returned.
    /// </param>
    /// <param name="Pagination">
    /// The virtual page number of the result set to display. A result set has a number of disputes divided into virtual pages, with 200 disputes per page. The response can only display one page. The first page in the result set is number 1. Required. If not specified, a warning is returned and <b>Pagination.PageNumber</b> is set to 1 by default.
    /// </param>
    public DisputeTypeCollection GetUserDisputes(
      DisputeFilterTypeCodeType DisputeFilterType,
      DisputeSortTypeCodeType DisputeSortType,
      DateTime ModTimeFrom,
      DateTime ModTimeTo,
      PaginationType Pagination)
    {
      this.DisputeFilterType = DisputeFilterType;
      this.DisputeSortType = DisputeSortType;
      this.ModTimeFrom = ModTimeFrom;
      this.ModTimeTo = ModTimeTo;
      this.Pagination = Pagination;
      this.Execute();
      return this.ApiResponse.DisputeArray;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public DisputeTypeCollection GetUserDisputes(PaginationType Pagination)
    {
      this.Pagination = Pagination;
      this.Execute();
      return this.DisputeList;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetUserDisputesRequestType" /> for this API call.
    /// </summary>
    public GetUserDisputesRequestType ApiRequest
    {
      get => (GetUserDisputesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetUserDisputesResponseType" /> for this API call.
    /// </summary>
    public GetUserDisputesResponseType ApiResponse
    {
      get => (GetUserDisputesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserDisputesRequestType.DisputeFilterType" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeFilterTypeCodeType" />.
    /// </summary>
    public DisputeFilterTypeCodeType DisputeFilterType
    {
      get => this.ApiRequest.DisputeFilterType;
      set => this.ApiRequest.DisputeFilterType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserDisputesRequestType.DisputeSortType" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeSortTypeCodeType" />.
    /// </summary>
    public DisputeSortTypeCodeType DisputeSortType
    {
      get => this.ApiRequest.DisputeSortType;
      set => this.ApiRequest.DisputeSortType = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserDisputesRequestType.ModTimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeFrom
    {
      get => this.ApiRequest.ModTimeFrom;
      set => this.ApiRequest.ModTimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserDisputesRequestType.ModTimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ModTimeTo
    {
      get => this.ApiRequest.ModTimeTo;
      set => this.ApiRequest.ModTimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetUserDisputesRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.StartingDisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string StartingDisputeID => this.ApiResponse.StartingDisputeID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.EndingDisputeID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string EndingDisputeID => this.ApiResponse.EndingDisputeID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.DisputeArray" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeTypeCollection" />.
    /// </summary>
    public DisputeTypeCollection DisputeList => this.ApiResponse.DisputeArray;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.ItemsPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ItemsPerPage => this.ApiResponse.ItemsPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.DisputeFilterCount" /> of type <see cref="T:eBay.Service.Core.Soap.DisputeFilterCountTypeCollection" />.
    /// </summary>
    public DisputeFilterCountTypeCollection DisputeFilterList
    {
      get => this.ApiResponse.DisputeFilterCount;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetUserDisputesResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;
  }
}
