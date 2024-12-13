// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetVeROReportStatusCall
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
  public class GetVeROReportStatusCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetVeROReportStatusCall() => this.ApiRequest = new GetVeROReportStatusRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetVeROReportStatusCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetVeROReportStatusRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves status information about VeRO reported items you have submitted. You
    /// can receive the status of individual items you have reported or, by specifying
    /// <strong>VeROReportPacketID</strong>, you can retrieve status for all items reported with a given
    /// <strong>VeROReportItems</strong> request. You can also retrieve items that were reported during a
    /// given time period. If no input parameters are specified, status is returned on all
    /// items you have reported in the last two years.
    /// You must be a member of the Verified Rights Owner (VeRO) Program to use this
    /// call.
    /// </summary>
    /// <param name="VeROReportPacketID">
    /// Packet identifier associated with the reported items for which you want to
    /// retrieve status. By default, reported item details are not returned when
    /// you specify the packet ID in the request. Applies only to items reported
    /// with the <strong>VeROReportItems</strong> call.
    /// </param>
    /// <param name="ItemID">
    /// Unique identifier for an eBay listing reported for alleged infringement. Applies to items reported with the <strong>VeROReportItems</strong> call or by other means (e.g., through the Web flow).
    /// </param>
    /// <param name="IncludeReportedItemDetails">
    /// Set to true to return reported item details when you specify <strong>VeROReportPacketID</strong> in the request.
    /// </param>
    /// <param name="TimeFrom">
    /// Limits returned items to only those that were submited on or after the
    /// date-time specified. If specified, TimeTo must also be specified.
    /// Express the date-time in the format YYYY-MM-DD HH:MM:SS, and in GMT.
    /// (For information on how to convert between your local time zone
    /// and GMT, see Time Values Note.) Applies to items reported with
    /// VeROReportItems or by other means (e.g., through the web flow).
    /// Infringement reporting data is maintained for two years after the date of
    /// submission.
    /// This field is ignored if <strong>VeROReportPacketID</strong> or <strong>ItemID</strong> is specified.
    /// </param>
    /// <param name="TimeTo">
    /// Limits returned items to only those that were submited on or before the
    /// date-time specified. If specified, TimeFrom must also be specified.
    /// Express date-time in the format YYYY-MM-DD HH:MM:SS, and in GMT.
    /// (For information on how to convert between your local time zone
    /// and GMT, see Time Values Note.) Applies to items reported with
    /// VeROReportItems or by other means (e.g., through the web flow).
    /// Infringement reporting data is maintained for two years after the date of
    /// submission.
    /// This field is ignored if <strong>VeROReportPacketID</strong> or <strong>ItemID</strong> is specified.
    /// </param>
    /// <param name="Pagination">
    /// Contains the data controlling the pagination of the returned values: how
    /// many items are returned per page of data (per call) and the number of the
    /// page to return with the current call.
    /// </param>
    public PaginationResultType GetVeROReportStatus(
      long VeROReportPacketID,
      string ItemID,
      bool IncludeReportedItemDetails,
      DateTime TimeFrom,
      DateTime TimeTo,
      PaginationType Pagination)
    {
      this.VeROReportPacketID = VeROReportPacketID;
      this.ItemID = ItemID;
      this.IncludeReportedItemDetails = IncludeReportedItemDetails;
      this.TimeFrom = TimeFrom;
      this.TimeTo = TimeTo;
      this.Pagination = Pagination;
      this.Execute();
      return this.ApiResponse.PaginationResult;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetVeROReportStatusRequestType" /> for this API call.
    /// </summary>
    public GetVeROReportStatusRequestType ApiRequest
    {
      get => (GetVeROReportStatusRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetVeROReportStatusResponseType" /> for this API call.
    /// </summary>
    public GetVeROReportStatusResponseType ApiResponse
    {
      get => (GetVeROReportStatusResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.VeROReportPacketID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long VeROReportPacketID
    {
      get => this.ApiRequest.VeROReportPacketID;
      set => this.ApiRequest.VeROReportPacketID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.IncludeReportedItemDetails" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool IncludeReportedItemDetails
    {
      get => this.ApiRequest.IncludeReportedItemDetails;
      set => this.ApiRequest.IncludeReportedItemDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.TimeFrom" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime TimeFrom
    {
      get => this.ApiRequest.TimeFrom;
      set => this.ApiRequest.TimeFrom = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.TimeTo" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime TimeTo
    {
      get => this.ApiRequest.TimeTo;
      set => this.ApiRequest.TimeTo = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusRequestType.Pagination" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationType" />.
    /// </summary>
    public PaginationType Pagination
    {
      get => this.ApiRequest.Pagination;
      set => this.ApiRequest.Pagination = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.PaginationResult" /> of type <see cref="T:eBay.Service.Core.Soap.PaginationResultType" />.
    /// </summary>
    public PaginationResultType PaginationResult => this.ApiResponse.PaginationResult;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.HasMoreItems" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool HasMoreItems => this.ApiResponse.HasMoreItems;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.ItemsPerPage" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int ItemsPerPage => this.ApiResponse.ItemsPerPage;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.PageNumber" /> of type <see cref="T:System.Int32" />.
    /// </summary>
    public int PageNumber => this.ApiResponse.PageNumber;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.VeROReportPacketID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long VeROReportPacketIDReturn => this.ApiResponse.VeROReportPacketID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.VeROReportPacketStatus" /> of type <see cref="T:eBay.Service.Core.Soap.VeROReportPacketStatusCodeType" />.
    /// </summary>
    public VeROReportPacketStatusCodeType VeROReportPacketStatus
    {
      get => this.ApiResponse.VeROReportPacketStatus;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetVeROReportStatusResponseType.ReportedItemDetails" /> of type <see cref="T:eBay.Service.Core.Soap.VeROReportedItemTypeCollection" />.
    /// </summary>
    public VeROReportedItemTypeCollection ReportedItemDetailList
    {
      get => this.ApiResponse.ReportedItemDetails;
    }
  }
}
