// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetNotificationsUsageCall
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
  public class GetNotificationsUsageCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetNotificationsUsageCall() => this.ApiRequest = new GetNotificationsUsageRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetNotificationsUsageCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetNotificationsUsageRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves usage information about platform notifications for a given application.
    /// You can use this notification information to troubleshoot issues with platform
    /// notifications. You can call this up to 50 times per hour for a given application.
    /// </summary>
    /// <param name="StartTime">
    /// Specifies the start date and time for which notification information will be retrieved. <b>StartTime</b> is optional. If no <b>StartTime</b> is specified, the default value of 24 hours prior to the call time is used. If no <b>StartTime</b> is specified or if an invalid <b>StartTime</b> is specified, date range errors are returned in the response. For a <b>StartTime</b> to be valid, it must be no more than 72 hours before the time of the call, it cannot be more recent than the <b>EndTime</b>, and it cannot be later than the time of the call. If an invalid <b>StartTime</b> is specified, the default value is used.
    /// </param>
    /// <param name="EndTime">
    /// Specifies the end date and time for which notification information will be retrieved. <b>EndTime</b> is optional. <br /><br /> If no <b>EndTime</b> is specified, the current time (the time the call is made) is used. If no <b>EndTime</b> is specified or if an invalid <b>EndTime</b> is specified, date range errors are returned in the response. For an <b>EndTime</b> to be valid, it must be no more than 72 hours before the time the of the call, it cannot be before the <b>StartTime</b>, and it cannot be later than the time of the call. If an invalid <b>EndTime</b> is specified, the current time is used.
    /// </param>
    /// <param name="ItemID">
    /// Specifies an item ID for which detailed notification information will be retrieved. <b>ItemID</b> is optional. If no <b>ItemID</b> is specified, the response will not include any individual notification details.
    /// </param>
    public void GetNotificationsUsage(DateTime StartTime, DateTime EndTime, string ItemID)
    {
      this.StartTime = StartTime;
      this.EndTime = EndTime;
      this.ItemID = ItemID;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetNotificationsUsageRequestType" /> for this API call.
    /// </summary>
    public GetNotificationsUsageRequestType ApiRequest
    {
      get => (GetNotificationsUsageRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetNotificationsUsageResponseType" /> for this API call.
    /// </summary>
    public GetNotificationsUsageResponseType ApiResponse
    {
      get => (GetNotificationsUsageResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageRequestType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime
    {
      get => this.ApiRequest.StartTime;
      set => this.ApiRequest.StartTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageRequestType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime
    {
      get => this.ApiRequest.EndTime;
      set => this.ApiRequest.EndTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTimeReturn => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTimeReturn => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageResponseType.NotificationDetailsArray" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationDetailsTypeCollection" />.
    /// </summary>
    public NotificationDetailsTypeCollection NotificationDetailsList
    {
      get => this.ApiResponse.NotificationDetailsArray;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageResponseType.MarkUpMarkDownHistory" /> of type <see cref="T:eBay.Service.Core.Soap.MarkUpMarkDownEventTypeCollection" />.
    /// </summary>
    public MarkUpMarkDownEventTypeCollection MarkUpMarkDownHistoryList
    {
      get => this.ApiResponse.MarkUpMarkDownHistory;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationsUsageResponseType.NotificationStatistics" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationStatisticsType" />.
    /// </summary>
    public NotificationStatisticsType NotificationStatistics
    {
      get => this.ApiResponse.NotificationStatistics;
    }
  }
}
