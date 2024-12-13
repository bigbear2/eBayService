// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddToItemDescriptionCall
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
  public class AddToItemDescriptionCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public AddToItemDescriptionCall() => this.ApiRequest = new AddToItemDescriptionRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddToItemDescriptionCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddToItemDescriptionRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// The base request of the <b>AddToItemDescription</b> call, which is used to add additional text to an active listing's item description. Upon a successful call, the text supplied in this call will be inserted into the active listing, with a horizontal rule separating the original item description and the additional text that was added with this call.
    /// </summary>
    /// <param name="ItemID">
    /// This field is used to identify the active listing that will be updated with additional text in the item description field. The Item ID is a unique identifier for a listing.
    /// </param>
    /// <param name="DescriptionToAppend">
    /// This field is used to specify the text that will be appended to the end of the active listing's item description.
    /// The text provided in this field must abide by the same rules/restrictions
    /// applicable to the original item description supplied at listing time. For more information on these rules and restrictions, see the <a href="http://developer.ebay.com/Devzone/XML/docs/Reference/ebay/types/ItemType.html#Description">Description field of ItemType</a>.
    /// </param>
    public void AddToItemDescription(string ItemID, string DescriptionToAppend)
    {
      this.ItemID = ItemID;
      this.DescriptionToAppend = DescriptionToAppend;
      this.Execute();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddToItemDescriptionRequestType" /> for this API call.
    /// </summary>
    public AddToItemDescriptionRequestType ApiRequest
    {
      get => (AddToItemDescriptionRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddToItemDescriptionResponseType" /> for this API call.
    /// </summary>
    public AddToItemDescriptionResponseType ApiResponse
    {
      get => (AddToItemDescriptionResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddToItemDescriptionRequestType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID
    {
      get => this.ApiRequest.ItemID;
      set => this.ApiRequest.ItemID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddToItemDescriptionRequestType.Description" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string DescriptionToAppend
    {
      get => this.ApiRequest.Description;
      set => this.ApiRequest.Description = value;
    }
  }
}
