// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteSellingManagerItemAutomationRuleCall
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
  public class DeleteSellingManagerItemAutomationRuleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteSellingManagerItemAutomationRuleCall()
    {
      this.ApiRequest = new DeleteSellingManagerItemAutomationRuleRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteSellingManagerItemAutomationRuleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteSellingManagerItemAutomationRuleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Removes the association of Selling Manager automation rules
    /// to an item. Returns the remaining rules in the response.
    /// 
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call.
    /// </summary>
    /// <param name="ItemID">
    /// The unique identifier of the listing from which to delete automation rules.
    /// </param>
    /// <param name="DeleteAutomatedRelistingRule">
    /// This field is included and set to <code>true</code> if the user would like to disable the automated relisting rule for the listing.
    /// </param>
    /// <param name="DeleteAutomatedSecondChanceOfferRule">
    /// This field is included and set to <code>true</code> if the user would like to disable the automated Second Chance Offer rule for the listing.
    /// </param>
    public SellingManagerAutoListType DeleteSellingManagerItemAutomationRule(
      string ItemID,
      bool DeleteAutomatedRelistingRule,
      bool DeleteAutomatedSecondChanceOfferRule)
    {
      this.ItemID = ItemID;
      this.DeleteAutomatedRelistingRule = DeleteAutomatedRelistingRule;
      this.DeleteAutomatedSecondChanceOfferRule = DeleteAutomatedSecondChanceOfferRule;
      this.Execute();
      return this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleRequestType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerItemAutomationRuleRequestType ApiRequest
    {
      get => (DeleteSellingManagerItemAutomationRuleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleResponseType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerItemAutomationRuleResponseType ApiResponse
    {
      get => (DeleteSellingManagerItemAutomationRuleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleRequestType.DeleteAutomatedRelistingRule" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DeleteAutomatedRelistingRule
    {
      get => this.ApiRequest.DeleteAutomatedRelistingRule;
      set => this.ApiRequest.DeleteAutomatedRelistingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleRequestType.DeleteAutomatedSecondChanceOfferRule" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DeleteAutomatedSecondChanceOfferRule
    {
      get => this.ApiRequest.DeleteAutomatedSecondChanceOfferRule;
      set => this.ApiRequest.DeleteAutomatedSecondChanceOfferRule = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleResponseType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRule => this.ApiResponse.AutomatedListingRule;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleResponseType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRule
    {
      get => this.ApiResponse.AutomatedRelistingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleResponseType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
    {
      get => this.ApiResponse.AutomatedSecondChanceOfferRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerItemAutomationRuleResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
