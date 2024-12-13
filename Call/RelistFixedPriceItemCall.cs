// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.RelistFixedPriceItemCall
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using eBay.Service.Core.Sdk;
using eBay.Service.Core.Soap;
using eBay.Service.EPS;
using eBay.Service.Util;
using System;
using System.Runtime.InteropServices;


namespace eBay.Service.Call
{
  /// <summary>
  /// 
  /// </summary>
  [ClassInterface(ClassInterfaceType.AutoDispatch)]
  public class RelistFixedPriceItemCall : ApiCall
  {
    private bool mAutoSetItemUUID;
    private StringCollection mPictureFileList = new StringCollection();

    /// <summary>
    /// 
    /// </summary>
    public RelistFixedPriceItemCall() => this.ApiRequest = new RelistFixedPriceItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public RelistFixedPriceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new RelistFixedPriceItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to relist a fixed-price listing that has recently ended on a specified eBay site. A seller has to up to 90 days to relist an ended listing. When an item is relisted, it will receive a new <b>ItemID</b> value, but this item will remain on other users' Watch Lists after it is relisted. The seller has the opportunity to make changes to the listing through the <b>Item</b> container, and the seller can also use one or more <b>DeletedField</b> tags to remove an optional field/setting from the listing.
    /// </summary>
    /// <param name="Item">
    /// The <b>Item</b> container is used to configure the item that will be relisted. If the seller plans to relist the item with no changes, the only field under the <b>Item</b> container that is required is the <b>ItemID</b> field. In the <b>ItemID</b> field, the seller specifies the item that will be relisted. If the seller wishes to change anything else for the listing, the seller should include this field in the call request and give it a new value.
    /// <br /><br />
    /// If the seller wants to delete one or more optional settings in the listing, the seller should use the <b>DeletedField</b> tag.
    /// </param>
    /// <param name="DeletedFieldList">
    /// Specifies the name of the field to delete from a listing.
    /// See <a href="http://developer.ebay.com/Devzone/guides/features-guide/default.html#development/Listings-RelistingItems.html">Relisting Items</a> for rules on deleting values when relisting items.
    /// Also see the relevant field descriptions to determine when to use <b>DeletedField</b> (and potential consequences).
    /// The request can contain zero, one, or many instances of <b>DeletedField</b> (one for each field to be deleted).
    /// 
    /// 
    /// Some data (such as <b>Variation</b> nodes within <b>Variations</b>)
    /// can't be deleted by using a <b>DeletedField</b> tag. See the relevant field
    /// descriptions for how to delete such data.
    /// 
    /// 
    /// Case-sensitivity must be taken into account when using a <b>DeletedField</b> tag to delete a field. The value passed into a <b>DeletedField</b> tag must either match the case of the schema element names in the full field path (Item.PictureDetails.GalleryURL), or the initial letter of each schema element name in the full field path must be lowercase (item.pictureDetails.galleryURL).
    /// Do not change the case of letters in the middle of a field name.
    /// For example, item.picturedetails.galleryUrl is not allowed.
    /// To delete a listing enhancement like 'BoldTitle', specify the value you are deleting;
    /// for example, Item.ListingEnhancement[BoldTitle].
    /// </param>
    public FeeTypeCollection RelistFixedPriceItem(ItemType Item, StringCollection DeletedFieldList)
    {
      this.Item = Item;
      this.DeletedFieldList = DeletedFieldList;
      this.Execute();
      return this.ApiResponse.Fees;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Execute()
    {
      if (this.Item != null)
      {
        if ((this.Item.UUID == null || this.Item.UUID.Length == 0) && this.AutoSetItemUUID)
          this.Item.UUID = RelistFixedPriceItemCall.NewUUID();
        if (this.ApiContext.EPSServerUrl != null && this.PictureFileList != null && this.PictureFileList.Count > 0)
        {
          eBayPictureService bayPictureService = new eBayPictureService(this.ApiContext);
          if (this.Item.PictureDetails == null)
          {
            this.Item.PictureDetails = new PictureDetailsType();
            this.Item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.None;
          }
          else if (!this.Item.PictureDetails.PhotoDisplaySpecified || this.Item.PictureDetails.PhotoDisplay == PhotoDisplayCodeType.CustomCode)
            this.Item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.None;
          try
          {
            this.Item.PictureDetails.PictureURL = new StringCollection();
            this.Item.PictureDetails.PictureURL.AddRange(bayPictureService.UpLoadPictureFiles(this.Item.PictureDetails.PhotoDisplay, this.PictureFileList.ToArray()));
          }
          catch (Exception ex)
          {
            this.LogMessage(ex.Message, MessageType.Exception, MessageSeverity.Error);
            throw new SdkException(ex.Message, ex);
          }
        }
      }
      base.Execute();
      string itemId = this.Item.ItemID;
      this.Item.ItemID = this.ApiResponse.ItemID;
      if (this.Item.ListingDetails == null)
        this.Item.ListingDetails = new ListingDetailsType();
      this.Item.ListingDetails.StartTime = this.ApiResponse.StartTime;
      this.Item.ListingDetails.EndTime = this.ApiResponse.EndTime;
      this.Item.ListingDetails.RelistedItemID = itemId;
      if (this.ApiResponse.CategoryID != null && this.ApiResponse.CategoryID.Length > 0)
      {
        if (this.Item.PrimaryCategory == null)
          this.Item.PrimaryCategory = new CategoryType();
        this.Item.PrimaryCategory.CategoryID = this.ApiResponse.CategoryID;
      }
      if (this.ApiResponse.Category2ID == null || this.ApiResponse.Category2ID.Length <= 0)
        return;
      if (this.Item.SecondaryCategory == null)
        this.Item.SecondaryCategory = new CategoryType();
      this.Item.SecondaryCategory.CategoryID = this.ApiResponse.Category2ID;
    }

    /// <summary>Generates a universal unique identifier.</summary>
    /// <returns>A universal unique identifier of type <see cref="T:System.String" /></returns>
    public static string NewUUID() => Guid.NewGuid().ToString().Replace("-", "").ToString();

    /// <summary>
    /// Sets or overwrites the <see cref="P:eBay.Service.Core.Soap.ItemType.UUID" />.
    /// </summary>
    /// <param name="Item">The item to assign a universal unique identifier to.</param>
    public static void ResetItemUUID(ItemType Item)
    {
      Item.UUID = RelistFixedPriceItemCall.NewUUID();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.RelistFixedPriceItemRequestType" /> for this API call.
    /// </summary>
    public RelistFixedPriceItemRequestType ApiRequest
    {
      get => (RelistFixedPriceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType" /> for this API call.
    /// </summary>
    public RelistFixedPriceItemResponseType ApiResponse
    {
      get => (RelistFixedPriceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemRequestType.DeletedField" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection DeletedFieldList
    {
      get => this.ApiRequest.DeletedField;
      set => this.ApiRequest.DeletedField = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AutoSetItemUUID
    {
      get => this.mAutoSetItemUUID;
      set => this.mAutoSetItemUUID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StringCollection PictureFileList
    {
      get => this.mPictureFileList;
      set => this.mPictureFileList = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKU => this.ApiResponse.SKU;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.DiscountReason" /> of type <see cref="T:eBay.Service.Core.Soap.DiscountReasonCodeTypeCollection" />.
    /// </summary>
    public DiscountReasonCodeTypeCollection DiscountReasonList => this.ApiResponse.DiscountReason;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.ProductSuggestions" /> of type <see cref="T:eBay.Service.Core.Soap.ProductSuggestionsType" />.
    /// </summary>
    public ProductSuggestionsType ProductSuggestions => this.ApiResponse.ProductSuggestions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.RelistFixedPriceItemResponseType.ListingRecommendations" /> of type <see cref="T:eBay.Service.Core.Soap.ListingRecommendationsType" />.
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.ApiResponse.ListingRecommendations;
    }
  }
}
