// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddOrderCall
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
  public class AddOrderCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddOrderCall() => this.ApiRequest = new AddOrderRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddOrderCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddOrderRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The <b>AddOrder</b> call can be used by a seller to combine two or more unpaid, single line item orders from the same buyer into one 'Combined Invoice' order with multiple line items. Once multiple line items are combined into one order, the buyer can make one single payment for multiple line item order. If possible and agreed to, the seller can then ship multiple line items in the same shipping package, saving on shipping costs, and possibly passing that savings down to the buyer through Combined Shipping Discount rules set up in My eBay.
    /// </summary>
    /// <param name="Order">
    /// The root container of the <b>AddOrder</b> request. In this call, the seller identifies two or more unpaid order line items from the same buyer through the <b>TransactionArray</b> container, specifies one or more accepted payment methods through the <b>PaymentMethods</b> field(s), and specifies available shipping services and other shipping details through the <b>ShippingDetails</b> container.
    /// </param>
    public string AddOrder(OrderType Order)
    {
      this.Order = Order;
      this.Execute();
      return this.ApiResponse.OrderID;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Execute()
    {
      base.Execute();
      this.Order.OrderID = this.ApiResponse.OrderID;
      this.Order.CreatedTime = this.ApiResponse.CreatedTime;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddOrderRequestType" /> for this API call.
    /// </summary>
    public AddOrderRequestType ApiRequest
    {
      get => (AddOrderRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddOrderResponseType" /> for this API call.
    /// </summary>
    public AddOrderResponseType ApiResponse => (AddOrderResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddOrderRequestType.Order" /> of type <see cref="T:eBay.Service.Core.Soap.OrderType" />.
    /// </summary>
    public OrderType Order
    {
      get => this.ApiRequest.Order;
      set => this.ApiRequest.Order = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddOrderResponseType.OrderID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string OrderID => this.ApiResponse.OrderID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddOrderResponseType.CreatedTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime CreatedTime => this.ApiResponse.CreatedTime;
  }
}
