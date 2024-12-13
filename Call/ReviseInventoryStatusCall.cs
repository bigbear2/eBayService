// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseInventoryStatusCall
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
  public class ReviseInventoryStatusCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseInventoryStatusCall() => this.ApiRequest = new ReviseInventoryStatusRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseInventoryStatusCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseInventoryStatusRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to change the price and/or quantity of one to four
    /// active, fixed-price listings. The fixed-price listing to modify is identified with the <b>ItemID</b> of the listing and/or the <b>SKU</b> value of the item (if a seller-defined SKU value exists for the listing). If the seller is modifying one or more variations within a multiple-variation listing, the <b>ItemID</b> and <b>SKU</b> fields in the <b>InventoryStatus</b> container become required, with the <b>ItemID</b> value identifying the listing, and the <b>SKU</b> value identifying the specific product variation within that multiple-variation listing. Each variation within a multiple-variation listing requires a seller-defined SKU value.
    /// <br /><br />
    /// Whether updating the price and/or quantity of a single-variation listing or a specific variation within a multiple-variation listing, the limit of items or item variations that can be modified with one call is four.
    /// </summary>
    /// <param name="InventoryStatuList">
    /// One <b>InventoryStatus</b> container is required for each item or item variation that is being revised. Whether updating the price and/or quantity of a single-variation listing or a specific variation within a multiple-variation listing, the limit of items or item variations that can be modified with one call is four.
    /// </param>
    public InventoryStatusTypeCollection ReviseInventoryStatus(
      InventoryStatusTypeCollection InventoryStatuList)
    {
      this.InventoryStatuList = InventoryStatuList;
      this.Execute();
      return this.ApiResponse.InventoryStatus;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseInventoryStatusRequestType" /> for this API call.
    /// </summary>
    public ReviseInventoryStatusRequestType ApiRequest
    {
      get => (ReviseInventoryStatusRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseInventoryStatusResponseType" /> for this API call.
    /// </summary>
    public ReviseInventoryStatusResponseType ApiResponse
    {
      get => (ReviseInventoryStatusResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseInventoryStatusRequestType.InventoryStatus" /> of type <see cref="T:eBay.Service.Core.Soap.InventoryStatusTypeCollection" />.
    /// </summary>
    public InventoryStatusTypeCollection InventoryStatuList
    {
      get => this.ApiRequest.InventoryStatus;
      set => this.ApiRequest.InventoryStatus = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseInventoryStatusResponseType.InventoryStatus" /> of type <see cref="T:eBay.Service.Core.Soap.InventoryStatusTypeCollection" />.
    /// </summary>
    public InventoryStatusTypeCollection InventoryStatuListReturn
    {
      get => this.ApiResponse.InventoryStatus;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseInventoryStatusResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.InventoryFeesTypeCollection" />.
    /// </summary>
    public InventoryFeesTypeCollection FeeList => this.ApiResponse.Fees;
  }
}
