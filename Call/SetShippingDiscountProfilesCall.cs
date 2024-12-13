// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetShippingDiscountProfilesCall
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
  public class SetShippingDiscountProfilesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetShippingDiscountProfilesCall()
    {
      this.ApiRequest = new SetShippingDiscountProfilesRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetShippingDiscountProfilesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetShippingDiscountProfilesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call enables a seller to create and manage shipping discounts rules. These are the same shipping discount rules that can be created or managed in My eBay Shipping Preferences.
    /// <br /><br />
    /// The types of shipping discount rules that can be created and managed with this call include flat-rate shipping rules, calculated shipping rules, and promotional shipping rules. This call can also be used by sellers to set whether or not they allow buyers to combine separate line items into one Combined Invoice order, and how many days they allow buyers to perform that action.
    /// <br /><br />
    /// A seller can only create, update, or delete one discount rule type with each call. The action to take (either <code>Add</code>, <code>Update</code>, or <code>Delete</code>) is set and controlled with the <b>ModifyActionCode</b> field.
    /// </summary>
    /// <param name="CurrencyID">
    /// The three-digit code of the currency to be used for shipping discounts on  Combined Invoice orders. A discount profile can only be associated with a listing if the <b>CurrencyID</b> value of the profile matches the <b>Item.Currency</b> value specified in a listing. This field is required if the user is adding or updating one or more shipping discount profiles.
    /// 
    /// Note that There is a <b>currencyID</b> attribute on all   <b>SetShippingDiscountProfiles</b> elements involving money. To avoid a call error, be sure to use the same currency type in these attributes as what is set for the <b>CurrencyID</b> field.
    /// </param>
    /// <param name="CombinedDuration">
    /// This field is used to specify the number of days after the purchase of an
    /// item that the buyer or seller can combine multiple and mutual order
    /// line items into one Combined Invoice order. In a Combined Invoice order,
    /// the buyer makes one payment for all order line items, hence only unpaid
    /// order line items can be combined into a Combined Invoice order.
    /// </param>
    /// <param name="ModifyActionCode">
    /// This field is used to set which action is being taken (<code>Add</code>, <code>Update</code>, or <code>Delete</code>) in the call. If you are adding a shipping discount rule, you will have to supply a name for that shipping discount profile. If you want to update or delete a shipping discount profile, you'll have to provide the unique identifier of this rule through the corresponding containers. The unique identifiers of these rules can be retrieved with the <b>GetShippingDiscountRules</b> call, or the seller can view these identifiers in My eBay Shipping Preferences.
    /// </param>
    /// <param name="FlatShippingDiscount">
    /// This container allows you to create, update, or delete a flat-rate shipping discount profile.
    /// </param>
    /// <param name="CalculatedShippingDiscount">
    /// This container allows you to create, update, or delete a calculated shipping discount profile.
    /// </param>
    /// <param name="CalculatedHandlingDiscount">
    /// This container allows you to create, update, or delete a calculated handling discount profile.
    /// </param>
    /// <param name="PromotionalShippingDiscountDetails">
    /// This container allows you to create, update, or delete a promotional shipping discount profile.
    /// </param>
    /// <param name="ShippingInsurance">
    /// This field is no longer applicable as it is not longer possible for a seller to offer a buyer shipping insurance.
    /// </param>
    /// <param name="InternationalShippingInsurance">
    /// This field is no longer applicable as it is not longer possible for a seller to offer a buyer shipping insurance.
    /// </param>
    public void SetShippingDiscountProfiles(
      CurrencyCodeType CurrencyID,
      CombinedPaymentPeriodCodeType CombinedDuration,
      ModifyActionCodeType ModifyActionCode,
      FlatShippingDiscountType FlatShippingDiscount,
      CalculatedShippingDiscountType CalculatedShippingDiscount,
      CalculatedHandlingDiscountType CalculatedHandlingDiscount,
      PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails,
      ShippingInsuranceType ShippingInsurance,
      ShippingInsuranceType InternationalShippingInsurance)
    {
      this.CurrencyID = CurrencyID;
      this.CombinedDuration = CombinedDuration;
      this.ModifyActionCode = ModifyActionCode;
      this.FlatShippingDiscount = FlatShippingDiscount;
      this.CalculatedShippingDiscount = CalculatedShippingDiscount;
      this.CalculatedHandlingDiscount = CalculatedHandlingDiscount;
      this.PromotionalShippingDiscountDetails = PromotionalShippingDiscountDetails;
      this.ShippingInsurance = ShippingInsurance;
      this.InternationalShippingInsurance = InternationalShippingInsurance;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType" /> for this API call.
    /// </summary>
    public SetShippingDiscountProfilesRequestType ApiRequest
    {
      get => (SetShippingDiscountProfilesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetShippingDiscountProfilesResponseType" /> for this API call.
    /// </summary>
    public SetShippingDiscountProfilesResponseType ApiResponse
    {
      get => (SetShippingDiscountProfilesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.CurrencyID" /> of type <see cref="T:eBay.Service.Core.Soap.CurrencyCodeType" />.
    /// </summary>
    public CurrencyCodeType CurrencyID
    {
      get => this.ApiRequest.CurrencyID;
      set => this.ApiRequest.CurrencyID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.CombinedDuration" /> of type <see cref="T:eBay.Service.Core.Soap.CombinedPaymentPeriodCodeType" />.
    /// </summary>
    public CombinedPaymentPeriodCodeType CombinedDuration
    {
      get => this.ApiRequest.CombinedDuration;
      set => this.ApiRequest.CombinedDuration = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.ModifyActionCode" /> of type <see cref="T:eBay.Service.Core.Soap.ModifyActionCodeType" />.
    /// </summary>
    public ModifyActionCodeType ModifyActionCode
    {
      get => this.ApiRequest.ModifyActionCode;
      set => this.ApiRequest.ModifyActionCode = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.FlatShippingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.FlatShippingDiscountType" />.
    /// </summary>
    public FlatShippingDiscountType FlatShippingDiscount
    {
      get => this.ApiRequest.FlatShippingDiscount;
      set => this.ApiRequest.FlatShippingDiscount = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.CalculatedShippingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.CalculatedShippingDiscountType" />.
    /// </summary>
    public CalculatedShippingDiscountType CalculatedShippingDiscount
    {
      get => this.ApiRequest.CalculatedShippingDiscount;
      set => this.ApiRequest.CalculatedShippingDiscount = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.CalculatedHandlingDiscount" /> of type <see cref="T:eBay.Service.Core.Soap.CalculatedHandlingDiscountType" />.
    /// </summary>
    public CalculatedHandlingDiscountType CalculatedHandlingDiscount
    {
      get => this.ApiRequest.CalculatedHandlingDiscount;
      set => this.ApiRequest.CalculatedHandlingDiscount = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.PromotionalShippingDiscountDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalShippingDiscountDetailsType" />.
    /// </summary>
    public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
    {
      get => this.ApiRequest.PromotionalShippingDiscountDetails;
      set => this.ApiRequest.PromotionalShippingDiscountDetails = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.ShippingInsurance" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingInsuranceType" />.
    /// </summary>
    public ShippingInsuranceType ShippingInsurance
    {
      get => this.ApiRequest.ShippingInsurance;
      set => this.ApiRequest.ShippingInsurance = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetShippingDiscountProfilesRequestType.InternationalShippingInsurance" /> of type <see cref="T:eBay.Service.Core.Soap.ShippingInsuranceType" />.
    /// </summary>
    public ShippingInsuranceType InternationalShippingInsurance
    {
      get => this.ApiRequest.InternationalShippingInsurance;
      set => this.ApiRequest.InternationalShippingInsurance = value;
    }
  }
}
