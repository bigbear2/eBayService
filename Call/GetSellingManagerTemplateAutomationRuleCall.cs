// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetSellingManagerTemplateAutomationRuleCall
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
  public class GetSellingManagerTemplateAutomationRuleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetSellingManagerTemplateAutomationRuleCall()
    {
      this.ApiRequest = new GetSellingManagerTemplateAutomationRuleRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetSellingManagerTemplateAutomationRuleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetSellingManagerTemplateAutomationRuleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Retrieves the set of Selling Manager automation rules associated with a Selling Manager template. This call is subject to change without notice; the deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="SaleTemplateID">
    /// The unique ID of the Selling Manager Template whose Selling Manager
    /// automation rules you want to retrieve.
    /// You can obtain a <b>SaleTemplateID</b> by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    public SellingManagerAutoListType GetSellingManagerTemplateAutomationRule(long SaleTemplateID)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.Execute();
      return this.ApiResponse.AutomatedListingRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleRequestType" /> for this API call.
    /// </summary>
    public GetSellingManagerTemplateAutomationRuleRequestType ApiRequest
    {
      get => (GetSellingManagerTemplateAutomationRuleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleResponseType" /> for this API call.
    /// </summary>
    public GetSellingManagerTemplateAutomationRuleResponseType ApiResponse
    {
      get => (GetSellingManagerTemplateAutomationRuleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleResponseType.AutomatedListingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoListType" />.
    /// </summary>
    public SellingManagerAutoListType AutomatedListingRule => this.ApiResponse.AutomatedListingRule;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleResponseType.AutomatedRelistingRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoRelistType" />.
    /// </summary>
    public SellingManagerAutoRelistType AutomatedRelistingRule
    {
      get => this.ApiResponse.AutomatedRelistingRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleResponseType.AutomatedSecondChanceOfferRule" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerAutoSecondChanceOfferType" />.
    /// </summary>
    public SellingManagerAutoSecondChanceOfferType AutomatedSecondChanceOfferRule
    {
      get => this.ApiResponse.AutomatedSecondChanceOfferRule;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetSellingManagerTemplateAutomationRuleResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
