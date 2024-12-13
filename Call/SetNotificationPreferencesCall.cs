// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetNotificationPreferencesCall
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
  public class SetNotificationPreferencesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetNotificationPreferencesCall()
    {
      this.ApiRequest = new SetNotificationPreferencesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetNotificationPreferencesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetNotificationPreferencesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Manages notification and alert preferences for applications and users.
    /// </summary>
    /// <param name="ApplicationDeliveryPreferences">
    /// Specifies application-level event preferences that have been enabled,
    /// including the URL to which notifications should be delivered and whether
    /// notifications should be enabled or disabled (although the
    /// <b>UserDeliveryPreferenceArray</b> input property specifies specific
    /// notification subscriptions).
    /// </param>
    /// <param name="UserDeliveryPreferenceList">
    /// Specifies events and whether or not they are enabled.
    /// </param>
    /// <param name="UserData">
    /// Specifies user data for notification settings, such as mobile phone number.
    /// </param>
    /// <param name="EventPropertyList">
    /// Characteristics or details of an event such as type, name and value.
    /// Currently can only be set for wireless applications.
    /// </param>
    /// <param name="DeliveryURLName">
    /// Specifies up to 25 ApplicationDeliveryPreferences.DeliveryURLDetails.DeliveryURLName to associate with a user token sent in a SetNotificationPreferences request. To specify multiple DeliveryURLNames, create separate instances of ApplicationDeliveryPreferences.DeliveryURLDetails.DeliveryURLName, and then enable up to 25 DeliveryURLNames by including them in comma-separated format in this field.
    /// </param>
    public void SetNotificationPreferences(
      ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences,
      NotificationEnableTypeCollection UserDeliveryPreferenceList,
      NotificationUserDataType UserData,
      NotificationEventPropertyTypeCollection EventPropertyList,
      string DeliveryURLName)
    {
      this.ApplicationDeliveryPreferences = ApplicationDeliveryPreferences;
      this.UserDeliveryPreferenceList = UserDeliveryPreferenceList;
      this.UserData = UserData;
      this.EventPropertyList = EventPropertyList;
      this.DeliveryURLName = DeliveryURLName;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void SetNotificationPreferences(
      NotificationEnableTypeCollection UserDeliveryPreferenceList)
    {
      this.UserDeliveryPreferenceList = UserDeliveryPreferenceList;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void SetNotificationPreferences(
      ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences)
    {
      this.ApplicationDeliveryPreferences = ApplicationDeliveryPreferences;
      this.Execute();
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void SetNotificationPreferences(
      ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences,
      NotificationEnableTypeCollection UserDeliveryPreferenceList)
    {
      this.ApplicationDeliveryPreferences = ApplicationDeliveryPreferences;
      this.UserDeliveryPreferenceList = UserDeliveryPreferenceList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType" /> for this API call.
    /// </summary>
    public SetNotificationPreferencesRequestType ApiRequest
    {
      get => (SetNotificationPreferencesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetNotificationPreferencesResponseType" /> for this API call.
    /// </summary>
    public SetNotificationPreferencesResponseType ApiResponse
    {
      get => (SetNotificationPreferencesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType.ApplicationDeliveryPreferences" /> of type <see cref="T:eBay.Service.Core.Soap.ApplicationDeliveryPreferencesType" />.
    /// </summary>
    public ApplicationDeliveryPreferencesType ApplicationDeliveryPreferences
    {
      get => this.ApiRequest.ApplicationDeliveryPreferences;
      set => this.ApiRequest.ApplicationDeliveryPreferences = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType.UserDeliveryPreferenceArray" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationEnableTypeCollection" />.
    /// </summary>
    public NotificationEnableTypeCollection UserDeliveryPreferenceList
    {
      get => this.ApiRequest.UserDeliveryPreferenceArray;
      set => this.ApiRequest.UserDeliveryPreferenceArray = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType.UserData" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationUserDataType" />.
    /// </summary>
    public NotificationUserDataType UserData
    {
      get => this.ApiRequest.UserData;
      set => this.ApiRequest.UserData = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType.EventProperty" /> of type <see cref="T:eBay.Service.Core.Soap.NotificationEventPropertyTypeCollection" />.
    /// </summary>
    public NotificationEventPropertyTypeCollection EventPropertyList
    {
      get => this.ApiRequest.EventProperty;
      set => this.ApiRequest.EventProperty = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetNotificationPreferencesRequestType.DeliveryURLName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DeliveryURLName
    {
      get => this.ApiRequest.DeliveryURLName;
      set => this.ApiRequest.DeliveryURLName = value;
    }
  }
}
