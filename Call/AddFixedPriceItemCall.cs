// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.AddFixedPriceItemCall
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
  public class AddFixedPriceItemCall : ApiCall
  {
    private bool mAutoSetItemUUID;
    private StringCollection mPictureFileList = new StringCollection();

    /// <summary>
    /// 
    /// </summary>
    public AddFixedPriceItemCall() => this.ApiRequest = new AddFixedPriceItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public AddFixedPriceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new AddFixedPriceItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// This call allows a seller to create and publish a fixed-price listing.
    /// The main difference between <b>AddFixedPriceItem</b> and <b>AddItem</b> is that
    /// <b>AddFixedPriceItem</b> supports the creation of fixed-price listings only,
    /// whereas <b>AddItem</b> supports all listing formats.
    /// 
    /// 
    /// Also, only <b>AddFixedPriceItem</b> supports multipl-variation listings
    /// and tracking inventory by a seller-defined SKU value. <b>AddItem</b> does not support
    /// Variations or the <b>InventoryTrackingMethod</b> field.
    /// </summary>
    /// <param name="Item">
    /// This container is used to specify all of the values and settings that define a new fixed-price listing.
    /// </param>
    public FeeTypeCollection AddFixedPriceItem(ItemType Item)
    {
      this.Item = Item;
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
          this.Item.UUID = AddFixedPriceItemCall.NewUUID();
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
      this.Item.ItemID = this.ApiResponse.ItemID;
      if (this.Item.ListingDetails == null)
        this.Item.ListingDetails = new ListingDetailsType();
      this.Item.ListingDetails.StartTime = this.ApiResponse.StartTime;
      this.Item.ListingDetails.EndTime = this.ApiResponse.EndTime;
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
    public static void ResetItemUUID(ItemType Item) => Item.UUID = AddFixedPriceItemCall.NewUUID();

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.AddFixedPriceItemRequestType" /> for this API call.
    /// </summary>
    public AddFixedPriceItemRequestType ApiRequest
    {
      get => (AddFixedPriceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.AddFixedPriceItemResponseType" /> for this API call.
    /// </summary>
    public AddFixedPriceItemResponseType ApiResponse
    {
      get => (AddFixedPriceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
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
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKU => this.ApiResponse.SKU;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.DiscountReason" /> of type <see cref="T:eBay.Service.Core.Soap.DiscountReasonCodeTypeCollection" />.
    /// </summary>
    public DiscountReasonCodeTypeCollection DiscountReasonList => this.ApiResponse.DiscountReason;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.ProductSuggestions" /> of type <see cref="T:eBay.Service.Core.Soap.ProductSuggestionsType" />.
    /// </summary>
    public ProductSuggestionsType ProductSuggestions => this.ApiResponse.ProductSuggestions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.AddFixedPriceItemResponseType.ListingRecommendations" /> of type <see cref="T:eBay.Service.Core.Soap.ListingRecommendationsType" />.
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.ApiResponse.ListingRecommendations;
    }
  }
}
