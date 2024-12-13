﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.GetTaxTableCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class GetTaxTableCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public GetTaxTableCall() => this.ApiRequest = new GetTaxTableRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public GetTaxTableCall(ApiContext ApiContext)
    {
      this.ApiRequest = new GetTaxTableRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request type of the <b>GetTaxTable</b> call, which retrieves information on the seller's Sales Tax Table. This information includes all of the site's tax jurisdictions, a boolean field to indicate if sales tax is applied to shipping and handling charges, and the sales tax rate for each jurisdiction (if a sales tax rate is set for that jurisdiction).
    /// <br /><br />
    /// Sales tax tables are only supported on the eBay US and Candada marketplaces.
    /// </summary>
    public TaxJurisdictionTypeCollection GetTaxTable()
    {
      this.Execute();
      return this.ApiResponse.TaxTable;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.GetTaxTableRequestType" /> for this API call.
    /// </summary>
    public GetTaxTableRequestType ApiRequest
    {
      get => (GetTaxTableRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.GetTaxTableResponseType" /> for this API call.
    /// </summary>
    public GetTaxTableResponseType ApiResponse => (GetTaxTableResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetTaxTableResponseType.LastUpdateTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime LastUpdateTime => this.ApiResponse.LastUpdateTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.GetTaxTableResponseType.TaxTable" /> of type <see cref="T:eBay.Service.Core.Soap.TaxJurisdictionTypeCollection" />.
    /// </summary>
    public TaxJurisdictionTypeCollection TaxTableList => this.ApiResponse.TaxTable;
  }
}