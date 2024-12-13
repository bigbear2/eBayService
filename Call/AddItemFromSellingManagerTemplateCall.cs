// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddItemFromSellingManagerTemplateCall
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
  public class AddItemFromSellingManagerTemplateCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddItemFromSellingManagerTemplateCall()
    {
      this.ApiRequest = new AddItemFromSellingManagerTemplateRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddItemFromSellingManagerTemplateCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddItemFromSellingManagerTemplateRequestType();
      this.ApiContext = ApiContext;
    }

    public string AddItemFromSellingManagerTemplate(
      long SaleTemplateID,
      DateTime ScheduleTime,
      ItemType Item)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.ScheduleTime = ScheduleTime;
      this.Item = Item;
      this.Execute();
      return this.ApiResponse.ItemID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateRequestType" /> for this API call.
    /// </summary>
    public AddItemFromSellingManagerTemplateRequestType ApiRequest
    {
      get => (AddItemFromSellingManagerTemplateRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType" /> for this API call.
    /// </summary>
    public AddItemFromSellingManagerTemplateResponseType ApiResponse
    {
      get => (AddItemFromSellingManagerTemplateResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateRequestType.ScheduleTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime ScheduleTime
    {
      get => this.ApiRequest.ScheduleTime;
      set => this.ApiRequest.ScheduleTime = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddItemFromSellingManagerTemplateResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;
  }
}
