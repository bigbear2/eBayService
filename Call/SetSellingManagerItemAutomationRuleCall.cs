// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetSellingManagerItemAutomationRuleCall
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
  public class SetSellingManagerItemAutomationRuleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetSellingManagerItemAutomationRuleCall()
    {
      this.ApiRequest = new SetSellingManagerItemAutomationRuleRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetSellingManagerItemAutomationRuleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetSellingManagerItemAutomationRuleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Revises, or adds to, the set of Selling Manager automation rules associated with an item.
    /// 
    /// 
    /// This call is subject to change without notice; the deprecation process is inapplicable to this call. You must have a Selling Manager Pro subscription to use this call.
    /// 
    /// 
    /// Using this call, you can add an automated relisting rule. You also can add a Second Chance Offer rule. Note that automated relisting rules can only be set on templates. An automated relisting rule for an item is inherited from a template.
    /// 
    /// 
    /// This call also enables you to specify particular information about automation rules.
    /// 
    /// 
    /// If a node is not passed in the call, the setting for the corresponding
    /// automation rule remains unchanged.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of the listing whose automation rules you want to change.
    /// </param>
    /// <param name="AutomatedRelistingRule">
    /// The information for the automated relisting rule to be associated with the listing.
    /// </param>
    /// <param name="AutomatedSecondChanceOfferRule">
    /// The information for the automated Second Chance Offer rule to be associated with the listing.
    /// </param>
    public SellingManagerAutoListType SetSellingManagerItemAutomationRule(
      string ItemID,
      SellingManagerAutoRelistType AutomatedRelistingRule,
      SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule)
    {
      this.ItemID = ItemID;
      this.AutomatedRelistingRule = AutomatedRelistingRule;
      this.AutomatedSecondChanceOfferRule = AutomatedSecondChanceOfferRule;
      this.Execute();
      return this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleRequestType" /> for this API call.
    /// </summary>
    public SetSellingManagerItemAutomationRuleRequestType ApiRequest
    {
      get => (SetSellingManagerItemAutomationRuleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleResponseType" /> for this API call.
    /// </summary>
    public SetSellingManagerItemAutomationRuleResponseType ApiResponse
    {
      get => (SetSellingManagerItemAutomationRuleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleRequestType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRule
    {
      get => this.ApiRequest.AutomatedRelistingRule;
      set => this.ApiRequest.AutomatedRelistingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleRequestType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
    {
      get => this.ApiRequest.AutomatedSecondChanceOfferRule;
      set => this.ApiRequest.AutomatedSecondChanceOfferRule = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleResponseType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRule => this.ApiResponse.AutomatedListingRule;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleResponseType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRuleReturn
    {
      get => this.ApiResponse.AutomatedRelistingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleResponseType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRuleReturn
    {
      get => this.ApiResponse.AutomatedSecondChanceOfferRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerItemAutomationRuleResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
