// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetTaxTableCall
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
  public class SetTaxTableCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetTaxTableCall() => this.ApiRequest = new SetTaxTableRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetTaxTableCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetTaxTableRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call allows you to add or modify sales tax rates for one or more tax jurisdictions within the specified site. Any additions or modifications made with this call is saved in the seller's Sales Tax Table in My eBay.
    /// <br /><br />
    /// Sales Tax Tables are only supported on the US and Canada (English and French versions) sites, so this call is only applicable to those sites. To view their current Sales Tax Table, a seller may go to the Sales Tax Table in My eBay, or they can make a <b>GetTaxTable</b> call.
    /// </summary>
    /// <param name="TaxTableList">
    /// This table is used to set or modify sales tax rates for one or more tax jurisdictions within that country. A <b>TaxJurisdiction</b> container is required for each tax jurisdiction that is being added/updated.
    /// </param>
    public void SetTaxTable(TaxJurisdictionTypeCollection TaxTableList)
    {
      this.TaxTableList = TaxTableList;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetTaxTableRequestType" /> for this API call.
    /// </summary>
    public SetTaxTableRequestType ApiRequest
    {
      get => (SetTaxTableRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetTaxTableResponseType" /> for this API call.
    /// </summary>
    public SetTaxTableResponseType ApiResponse => (SetTaxTableResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetTaxTableRequestType.TaxTable" /> of type <see cref="T:eBay.Service.Core.Soap.TaxJurisdictionTypeCollection" />.
    /// </summary>
    public TaxJurisdictionTypeCollection TaxTableList
    {
      get => this.ApiRequest.TaxTable;
      set => this.ApiRequest.TaxTable = value;
    }
  }
}
