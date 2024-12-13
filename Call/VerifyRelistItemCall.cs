// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.VerifyRelistItemCall
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
  public class VerifyRelistItemCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public VerifyRelistItemCall() => this.ApiRequest = new VerifyRelistItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public VerifyRelistItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new VerifyRelistItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enable the seller to verify that the data they plan to pass into a <b>RelistItem</b> call will produce the results that you are expecting, including a successful call with no errors.
    /// </summary>
    /// <param name="Item">
    /// The <b>Item</b> container is used to configure the item that will be relisted. If the seller plans to relist the item with no changes, the only field under the <b>Item</b> container that is required is the <b>ItemID</b> field. In the <b>ItemID</b> field, the seller specifies the item that will be relisted. If the seller wishes to change anything else for the listing, the seller should include this field in the call request and give it a new value.
    /// <br /><br />
    /// If the seller wants to delete one or more optional settings in the listing, the seller should use the <b>DeletedField</b> tag.
    /// </param>
    /// <param name="DeletedFieldList">
    /// Specifies the name of the field to delete from a listing. See the eBay Features Guide for rules on deleting values when relisting items. Also see the relevant field descriptions to determine when to use <b>DeletedField</b> (and potential consequences).
    /// The request can contain zero, one, or many instances of <b>DeletedField</b> (one for each field to be deleted).
    /// 
    /// Case-sensitivity must be taken into account when using a <b>DeletedField</b> tag to delete a field. The value passed into a <b>DeletedField</b> tag must either match the case of the schema element names in the full field path (Item.PictureDetails.GalleryURL), or the initial letter of each schema element name in the full field path must be  lowercase (item.pictureDetails.galleryURL).
    /// Do not change the case of letters in the middle of a field name.
    /// For example, item.picturedetails.galleryUrl is not allowed.
    /// To delete a listing enhancement like 'BoldTitle', specify the value you are deleting;
    /// for example, Item.ListingEnhancement[BoldTitle].
    /// </param>
    public string VerifyRelistItem(ItemType Item, StringCollection DeletedFieldList)
    {
      this.Item = Item;
      this.DeletedFieldList = DeletedFieldList;
      this.Execute();
      return this.ApiResponse.ItemID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.VerifyRelistItemRequestType" /> for this API call.
    /// </summary>
    public VerifyRelistItemRequestType ApiRequest
    {
      get => (VerifyRelistItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.VerifyRelistItemResponseType" /> for this API call.
    /// </summary>
    public VerifyRelistItemResponseType ApiResponse
    {
      get => (VerifyRelistItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemRequestType.DeletedField" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection DeletedFieldList
    {
      get => this.ApiRequest.DeletedField;
      set => this.ApiRequest.DeletedField = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.DiscountReason" /> of type <see cref="T:eBay.Service.Core.Soap.DiscountReasonCodeTypeCollection" />.
    /// </summary>
    public DiscountReasonCodeTypeCollection DiscountReasonList => this.ApiResponse.DiscountReason;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.ProductSuggestions" /> of type <see cref="T:eBay.Service.Core.Soap.ProductSuggestionsType" />.
    /// </summary>
    public ProductSuggestionsType ProductSuggestions => this.ApiResponse.ProductSuggestions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyRelistItemResponseType.ListingRecommendations" /> of type <see cref="T:eBay.Service.Core.Soap.ListingRecommendationsType" />.
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.ApiResponse.ListingRecommendations;
    }
  }
}
