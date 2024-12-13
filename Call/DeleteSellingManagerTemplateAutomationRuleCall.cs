// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.DeleteSellingManagerTemplateAutomationRuleCall
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
  public class DeleteSellingManagerTemplateAutomationRuleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public DeleteSellingManagerTemplateAutomationRuleCall()
    {
      this.ApiRequest = new DeleteSellingManagerTemplateAutomationRuleRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public DeleteSellingManagerTemplateAutomationRuleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new DeleteSellingManagerTemplateAutomationRuleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Removes the association of Selling Manager automation rules
    /// to a template. Returns the remaining rules in the response.
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call.
    /// </summary>
    /// <param name="SaleTemplateID">
    /// The unique identifier of the Selling Manager template from which you want to remove automation rules.
    /// You can obtain a <b>SaleTemplateID</b> by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    /// <param name="DeleteAutomatedListingRule">
    /// This field is included and set to <code>true</code> if the user would like to disable the automated listing rule for the Selling Manager template.
    /// </param>
    /// <param name="DeleteAutomatedRelistingRule">
    /// This field is included and set to <code>true</code> if the user would like to disable the automated relisting rule for the Selling Manager template.
    /// </param>
    /// <param name="DeleteAutomatedSecondChanceOfferRule">
    /// This field is included and set to <code>true</code> if the user would like to disable the automated Second Chance Offer rule for the Selling Manager template.
    /// </param>
    public SellingManagerAutoListType DeleteSellingManagerTemplateAutomationRule(
      long SaleTemplateID,
      bool DeleteAutomatedListingRule,
      bool DeleteAutomatedRelistingRule,
      bool DeleteAutomatedSecondChanceOfferRule)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.DeleteAutomatedListingRule = DeleteAutomatedListingRule;
      this.DeleteAutomatedRelistingRule = DeleteAutomatedRelistingRule;
      this.DeleteAutomatedSecondChanceOfferRule = DeleteAutomatedSecondChanceOfferRule;
      this.Execute();
      return this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerTemplateAutomationRuleRequestType ApiRequest
    {
      get => (DeleteSellingManagerTemplateAutomationRuleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleResponseType" /> for this API call.
    /// </summary>
    public DeleteSellingManagerTemplateAutomationRuleResponseType ApiResponse
    {
      get => (DeleteSellingManagerTemplateAutomationRuleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType.DeleteAutomatedListingRule" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DeleteAutomatedListingRule
    {
      get => this.ApiRequest.DeleteAutomatedListingRule;
      set => this.ApiRequest.DeleteAutomatedListingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType.DeleteAutomatedRelistingRule" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DeleteAutomatedRelistingRule
    {
      get => this.ApiRequest.DeleteAutomatedRelistingRule;
      set => this.ApiRequest.DeleteAutomatedRelistingRule = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType.DeleteAutomatedSecondChanceOfferRule" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool DeleteAutomatedSecondChanceOfferRule
    {
      get => this.ApiRequest.DeleteAutomatedSecondChanceOfferRule;
      set => this.ApiRequest.DeleteAutomatedSecondChanceOfferRule = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleResponseType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRule => this.ApiResponse.AutomatedListingRule;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleResponseType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRule
    {
      get => this.ApiResponse.AutomatedRelistingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleResponseType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
    {
      get => this.ApiResponse.AutomatedSecondChanceOfferRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
