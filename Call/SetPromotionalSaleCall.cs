// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.SetPromotionalSaleCall
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
  public class SetPromotionalSaleCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public SetPromotionalSaleCall() => this.ApiRequest = new SetPromotionalSaleRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public SetPromotionalSaleCall(ApiContext ApiContext)
    {
      this.ApiRequest = new SetPromotionalSaleRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Creates or modifies a promotional sale. Promotional sales enable sellers
    /// to apply discounts and/or free shipping across many listings. To use this call, the seller must be a registered eBay Store owner.
    /// </summary>
    /// <param name="Action">
    /// The seller must include this field and set it to 'Add' to create a new promotional sale, or set it to 'Update' to modify an existing promotional sale, or set it to 'Delete' to delete a promotional sale.
    /// </param>
    /// <param name="PromotionalSaleDetails">
    /// This container must be included in each <b>SetPromotionalSale</b> call. The fields of this container that will be used will depend on whether the seller is adding a new promotional sale, updating an existing promotional sale, or deleting an existing promotional sale.
    /// </param>
    public PromotionalSaleStatusCodeType SetPromotionalSale(
      ModifyActionCodeType Action,
      PromotionalSaleType PromotionalSaleDetails)
    {
      this.Action = Action;
      this.PromotionalSaleDetails = PromotionalSaleDetails;
      this.Execute();
      return this.ApiResponse.Status;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.SetPromotionalSaleRequestType" /> for this API call.
    /// </summary>
    public SetPromotionalSaleRequestType ApiRequest
    {
      get => (SetPromotionalSaleRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.SetPromotionalSaleResponseType" /> for this API call.
    /// </summary>
    public SetPromotionalSaleResponseType ApiResponse
    {
      get => (SetPromotionalSaleResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleRequestType.Action" /> of type <see cref="T:eBay.Service.Core.Soap.ModifyActionCodeType" />.
    /// </summary>
    public ModifyActionCodeType Action
    {
      get => this.ApiRequest.Action;
      set => this.ApiRequest.Action = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleRequestType.PromotionalSaleDetails" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalSaleType" />.
    /// </summary>
    public PromotionalSaleType PromotionalSaleDetails
    {
      get => this.ApiRequest.PromotionalSaleDetails;
      set => this.ApiRequest.PromotionalSaleDetails = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleResponseType.Status" /> of type <see cref="T:eBay.Service.Core.Soap.PromotionalSaleStatusCodeType" />.
    /// </summary>
    public PromotionalSaleStatusCodeType Status => this.ApiResponse.Status;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.SetPromotionalSaleResponseType.PromotionalSaleID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long PromotionalSaleID => this.ApiResponse.PromotionalSaleID;
  }
}
