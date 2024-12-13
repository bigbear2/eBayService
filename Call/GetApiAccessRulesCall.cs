// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetApiAccessRulesCall
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
  public class GetApiAccessRulesCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetApiAccessRulesCall() => this.ApiRequest = new GetApiAccessRulesRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetApiAccessRulesCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetApiAccessRulesRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type for the <b>GetApiAccessRules</b> call, which returns details on how many calls your application has made and is allowed to make per hour or day.
    /// </summary>
    public ApiAccessRuleTypeCollection GetApiAccessRules()
    {
      this.Execute();
      return this.ApiResponse.ApiAccessRule;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetApiAccessRulesRequestType" /> for this API call.
    /// </summary>
    public GetApiAccessRulesRequestType ApiRequest
    {
      get => (GetApiAccessRulesRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetApiAccessRulesResponseType" /> for this API call.
    /// </summary>
    public GetApiAccessRulesResponseType ApiResponse
    {
      get => (GetApiAccessRulesResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetApiAccessRulesResponseType.ApiAccessRule" /> of type <see cref="T:eBay.Service.Core.Soap.ApiAccessRuleTypeCollection" />.
    /// </summary>
    public ApiAccessRuleTypeCollection ApiAccessRuleList => this.ApiResponse.ApiAccessRule;
  }
}
