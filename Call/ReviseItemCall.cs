﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseItemCall
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
  public class ReviseItemCall : ApiCall
  {
    private StringCollection mPictureFileList = new StringCollection();

    /// <summary>
    /// 
    /// </summary>
    public ReviseItemCall() => this.ApiRequest = new ReviseItemRequestType();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to revise a listing on a specified eBay site. To revise an active listing, the seller specifies the <b>ItemID</b> value for the listing. The seller makes one or multiple changes to the listing through the <b>Item</b> container, and the seller can also use one or more <b>DeletedField</b> tags to remove an optional field/setting from the listing.
    /// 
    /// 
    /// After a multiple-quantity, fixed-price listing has one or more sales, or less than 12 hours remain before the listing is scheduled to end, you can not edit the values in the Listing Title, Primary Category, Secondary Category, Listing Duration, and Listing Type fields for that listing. The same applies to an auction listing that has at least one bid.
    /// 
    /// 
    /// To revise a multiple-variation, fixed-price listing, the <b>ReviseFixedPriceItem</b> call should be used instead, as the <b>ReviseItem</b> call does not support variation-level edits.
    /// </summary>
    /// <param name="Item">
    /// The <b>Item</b> container is used to make changes to the active listing. The seller must pass in the <b>ItemID</b> value for the listing that is being revised. For anything else that the seller wishes to change, such as quantity or price, the seller should include this field in the call request and give it a new value.
    /// <br /><br />
    /// If the seller wants to delete one or more optional settings in the listing, the seller should use the <b>DeletedField</b> tag.
    /// </param>
    /// <param name="DeletedFieldList">
    /// Specifies the name of a field to delete from a listing. The request can
    /// contain zero, one, or many instances of <b>DeletedField</b> (one for each field
    /// to be deleted). See the relevant field descriptions to determine when to
    /// use <b>DeletedField</b> (and potential consequences).
    /// 
    /// You cannot delete required fields from a listing.
    /// 
    /// Some fields are optional when you first list an item (e.g.,
    /// <b>SecondaryCategory</b>), but once they are set they cannot be deleted when you
    /// revise an item. Some optional fields cannot be deleted if the item has
    /// bids and/or ends within 12 hours. Some optional fields cannot be deleted
    /// if other fields depend on them.
    /// 
    /// Use values that match the case of the
    /// schema element names (<b>Item.PictureDetails.GalleryURL</b>) or make the initial
    /// letter of each field name lowercase (<b>item.pictureDetails.galleryURL</b>).
    /// However, do not change the case of letters in the middle of a field name.
    /// For example, <b>item.picturedetails.galleryUrl</b> is not allowed.
    /// 
    /// To delete a listing enhancement like <b>BoldTitle</b>, specify the value you are
    /// deleting in square brackets ("[ ]"); for example,
    /// <b>Item.ListingEnhancement[BoldTitle]</b>.
    /// </param>
    /// <param name="VerifyOnly">
    /// When the <b>VerifyOnly</b> is included and set as <code>true</code>, the active listing is not actually revised, but the same response is returned and the seller gets to see the expected fees based on the changes made, and can also view any listing recommendations if the <b>Item.IncludeRecommedations</b> boolean field is included and set to <code>true</code>.
    /// </param>
    public DateTime ReviseItem(ItemType Item, StringCollection DeletedFieldList, bool VerifyOnly)
    {
      this.Item = Item;
      this.DeletedFieldList = DeletedFieldList;
      this.VerifyOnly = VerifyOnly;
      this.Execute();
      return this.ApiResponse.StartTime;
    }

    /// <summary>
    /// 
    /// </summary>
    public override void Execute()
    {
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
      base.Execute();
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

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseItemRequestType" /> for this API call.
    /// </summary>
    public ReviseItemRequestType ApiRequest
    {
      get => (ReviseItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseItemResponseType" /> for this API call.
    /// </summary>
    public ReviseItemResponseType ApiResponse => (ReviseItemResponseType) this.AbstractResponse;

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseItemRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseItemRequestType.DeletedField" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection DeletedFieldList
    {
      get => this.ApiRequest.DeletedField;
      set => this.ApiRequest.DeletedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseItemRequestType.VerifyOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool VerifyOnly
    {
      get => this.ApiRequest.VerifyOnly;
      set => this.ApiRequest.VerifyOnly = value;
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
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.StartTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime StartTime => this.ApiResponse.StartTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.EndTime" /> of type <see cref="T:System.DateTime" />.
    /// </summary>
    public DateTime EndTime => this.ApiResponse.EndTime;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.VerifyOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool VerifyOnlyReturn => this.ApiResponse.VerifyOnly;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.DiscountReason" /> of type <see cref="T:eBay.Service.Core.Soap.DiscountReasonCodeTypeCollection" />.
    /// </summary>
    public DiscountReasonCodeTypeCollection DiscountReasonList => this.ApiResponse.DiscountReason;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.ProductSuggestions" /> of type <see cref="T:eBay.Service.Core.Soap.ProductSuggestionsType" />.
    /// </summary>
    public ProductSuggestionsType ProductSuggestions => this.ApiResponse.ProductSuggestions;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseItemResponseType.ListingRecommendations" /> of type <see cref="T:eBay.Service.Core.Soap.ListingRecommendationsType" />.
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.ApiResponse.ListingRecommendations;
    }
  }
}
