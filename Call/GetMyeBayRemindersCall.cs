// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetMyeBayRemindersCall
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
  public class GetMyeBayRemindersCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetMyeBayRemindersCall() => this.ApiRequest = new GetMyeBayRemindersRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetMyeBayRemindersCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetMyeBayRemindersRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This is the base request type of the <b>GetMyeBayReminders</b> call. This call returns the total counts for My eBay Buying and/or My eBay Selling Reminders for a user.
    /// </summary>
    /// <param name="BuyingReminders">
    /// This container should be included if the user wishes to retrieve the counts of My eBay Buying Reminders. Counts will only be retrieved for My eBay Buying Reminders that the user received.
    /// </param>
    /// <param name="SellingReminders">
    /// This container should be included if the user wishes to retrieve the counts of My eBay Selling Reminders. Counts will only be retrieved for My eBay Selling Reminders that the user received.
    /// </param>
    public RemindersType GetMyeBayReminders(
      ReminderCustomizationType BuyingReminders,
      ReminderCustomizationType SellingReminders)
    {
      this.BuyingReminders = BuyingReminders;
      this.SellingReminders = SellingReminders;
      this.Execute();
      return this.ApiResponse.BuyingReminders;
    }

    /// <summary>For backward compatibility with old wrappers.</summary>
    public void GetMyeBayReminders() => this.Execute();

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetMyeBayRemindersRequestType" /> for this API call.
    /// </summary>
    public GetMyeBayRemindersRequestType ApiRequest
    {
      get => (GetMyeBayRemindersRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetMyeBayRemindersResponseType" /> for this API call.
    /// </summary>
    public GetMyeBayRemindersResponseType ApiResponse
    {
      get => (GetMyeBayRemindersResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayRemindersRequestType.BuyingReminders" /> of type <see cref="T:eBay.Service.Core.Soap.ReminderCustomizationType" />.
    /// </summary>
    public ReminderCustomizationType BuyingReminders
    {
      get => this.ApiRequest.BuyingReminders;
      set => this.ApiRequest.BuyingReminders = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetMyeBayRemindersRequestType.SellingReminders" /> of type <see cref="T:eBay.Service.Core.Soap.ReminderCustomizationType" />.
    /// </summary>
    public ReminderCustomizationType SellingReminders
    {
      get => this.ApiRequest.SellingReminders;
      set => this.ApiRequest.SellingReminders = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayRemindersResponseType.BuyingReminders" /> of type <see cref="T:eBay.Service.Core.Soap.RemindersType" />.
    /// </summary>
    public RemindersType BuyingRemindersReturn => this.ApiResponse.BuyingReminders;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetMyeBayRemindersResponseType.SellingReminders" /> of type <see cref="T:eBay.Service.Core.Soap.RemindersType" />.
    /// </summary>
    public RemindersType SellingRemindersReturn => this.ApiResponse.SellingReminders;
  }
}
