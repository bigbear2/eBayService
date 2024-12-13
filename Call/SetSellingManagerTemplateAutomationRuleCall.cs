// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetSellingManagerTemplateAutomationRuleCall
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
  public class SetSellingManagerTemplateAutomationRuleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetSellingManagerTemplateAutomationRuleCall()
    {
      this.ApiRequest = new SetSellingManagerTemplateAutomationRuleRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetSellingManagerTemplateAutomationRuleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetSellingManagerTemplateAutomationRuleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Revises, or adds to, the Selling Manager automation rules associated with a template.
    /// 
    /// 
    /// This call is subject to change without notice; the deprecation process is inapplicable to this call. You must have a Selling Manager Pro subscription to use this call.
    /// 
    /// 
    /// Using this call, you can add either an automated listing or relisting rule, but not both. You also can add a Second Chance Offer rule.
    /// 
    /// 
    /// This call also enables you to specify particular information about automation rules.
    /// 
    /// 
    /// If a node is not passed in the call, the setting for the corresponding automation rule remains unchanged.
    /// </summary>
    /// <param name="SaleTemplateID">
    /// The ID of the Selling Manager template whose automation rules you want to change. You can obtain a <b>SaleTemplateID</b> by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    /// <param name="AutomatedListingRule">
    /// The information for the automated listing rule to be associated with the template.
    /// </param>
    /// <param name="AutomatedRelistingRule">
    /// The information for the automated relisting rule to be associated with the template.
    /// </param>
    /// <param name="AutomatedSecondChanceOfferRule">
    /// The information for the automated Second Chance Offer rule to be associated with the template.
    /// </param>
    public SellingManagerAutoListType SetSellingManagerTemplateAutomationRule(
      long SaleTemplateID,
      SellingManagerAutoListType AutomatedListingRule,
      SellingManagerAutoRelistType AutomatedRelistingRule,
      SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.AutomatedListingRule = AutomatedListingRule;
      this.AutomatedRelistingRule = AutomatedRelistingRule;
      this.AutomatedSecondChanceOfferRule = AutomatedSecondChanceOfferRule;
      this.Execute();
      return this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleRequestType" /> for this API call.
    /// </summary>
    public SetSellingManagerTemplateAutomationRuleRequestType ApiRequest
    {
      get => (SetSellingManagerTemplateAutomationRuleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleResponseType" /> for this API call.
    /// </summary>
    public SetSellingManagerTemplateAutomationRuleResponseType ApiResponse
    {
      get => (SetSellingManagerTemplateAutomationRuleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleRequestType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRule
    {
      get => this.ApiRequest.AutomatedListingRule;
      set => this.ApiRequest.AutomatedListingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleRequestType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRule
    {
      get => this.ApiRequest.AutomatedRelistingRule;
      set => this.ApiRequest.AutomatedRelistingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleRequestType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
    {
      get => this.ApiRequest.AutomatedSecondChanceOfferRule;
      set => this.ApiRequest.AutomatedSecondChanceOfferRule = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleResponseType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRuleReturn
    {
      get => this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleResponseType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRuleReturn
    {
      get => this.ApiResponse.AutomatedRelistingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleResponseType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRuleReturn
    {
      get => this.ApiResponse.AutomatedSecondChanceOfferRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetSellingManagerTemplateAutomationRuleResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
