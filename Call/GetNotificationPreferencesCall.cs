// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetNotificationPreferencesCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetNotificationPreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetNotificationPreferencesCall()
    {
      this.ApiRequest = new GetNotificationPreferencesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetNotificationPreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetNotificationPreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves the requesting application's notification preferences. Details are only returned for events for which a preference has been set. For example, if you enabled notification for the <b>EndOfAuction</b> event and later disabled it, the <b>GetNotificationPreferences</b> response would cite the <b>EndOfAuction</b> event preference as <b>Disabled</b>. Otherwise, no details would be returned regarding <b>EndOfAuction</b>.
    /// </summary>
    /// <param name="PreferenceLevel">
    /// Specifies the type of preferences to retrieve. For example, preferences can be associated with a user, with
    /// an application, or with events.
    /// 
    /// </param>
    public void GetNotificationPreferences(NotificationRoleCodeType PreferenceLevel)
    {
      this.PreferenceLevel = PreferenceLevel;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetNotificationPreferencesRequestType" /> for this API call.
    /// </summary>
    public GetNotificationPreferencesRequestType ApiRequest
    {
      get => (GetNotificationPreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType" /> for this API call.
    /// </summary>
    public GetNotificationPreferencesResponseType ApiResponse
    {
      get => (GetNotificationPreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesRequestType.PreferenceLevel" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationRoleCodeType" />.
    /// </summary>
    public NotificationRoleCodeType PreferenceLevel
    {
      get => this.ApiRequest.PreferenceLevel;
      set => this.ApiRequest.PreferenceLevel = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType.ApplicationDeliveryPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.ApplicationDeliveryPreferencesType" />.
    /// </summary>
    public ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences
    {
      get => this.ApiResponse.ApplicationDeliveryPreferences;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType.DeliveryURLName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DeliveryURLName => this.ApiResponse.DeliveryURLName;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType.UserDeliveryPreferenceArray" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationEnableTypeCollection" />.
    /// </summary>
    public NotificationEnableTypeCollection UserDeliveryPreferenceList
    {
      get => this.ApiResponse.UserDeliveryPreferenceArray;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType.UserData" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationUserDataType" />.
    /// </summary>
    public NotificationUserDataType UserData => this.ApiResponse.UserData;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetNotificationPreferencesResponseType.EventProperty" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationEventPropertyTypeCollection" />.
    /// </summary>
    public NotificationEventPropertyTypeCollection EventPropertyList
    {
      get => this.ApiResponse.EventProperty;
    }
  }
}
