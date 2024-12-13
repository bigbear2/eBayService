﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.VerifyAddFixedPriceItemCall
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
  public class VerifyAddFixedPriceItemCall : ApiCall
  {
    private bool mAutoSetItemUUID;
    private StringCollection mPictureFileList = new StringCollection();

    /// <summary>
    /// 
    /// </summary>
    public VerifyAddFixedPriceItemCall()
    {
      this.ApiRequest = new VerifyAddFixedPriceItemRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public VerifyAddFixedPriceItemCall(ApiContext ApiContext)
    {
      this.ApiRequest = new VerifyAddFixedPriceItemRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Enables a seller to test the definition of a new fixed-price listing by
    /// submitting the definition to eBay without creating an actual listing.
    /// </summary>
    /// <param name="Item">
    /// Root container holding all values that define a new
    /// fixed-price listing.
    /// </param>
    public FeeTypeCollection VerifyAddFixedPriceItem(ItemType Item)
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
          this.Item.UUID = VerifyAddFixedPriceItemCall.NewUUID();
        if (this.ApiContext.EPSServerUrl != null && this.PictureFileList != null && this.PictureFileList.Count > 0)
        {
          if (this.Item.PictureDetails == null)
          {
            this.Item.PictureDetails = new PictureDetailsType();
            this.Item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.None;
          }
          else if (!this.Item.PictureDetails.PhotoDisplaySpecified || this.Item.PictureDetails.PhotoDisplay == PhotoDisplayCodeType.CustomCode)
            this.Item.PictureDetails.PhotoDisplay = PhotoDisplayCodeType.None;
          string[] items = new string[this.mPictureFileList.Count];
          this.Item.PictureDetails.PictureURL = new StringCollection();
          this.Item.PictureDetails.PictureURL.AddRange(items);
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

    /// <summary>Generates a universal unique identifier.</summary>
    /// <returns>A universal unique identifier of type <see cref="T:System.String" /></returns>
    public static string NewUUID() => Guid.NewGuid().ToString().Replace("-", "").ToString();

    /// <summary>
    /// Sets or overwrites the <see cref="P:eBay.Service.Core.Soap.ItemType.UUID" />.
    /// </summary>
    /// <param name="Item">The item to assign a universal unique identifier to.</param>
    public static void ResetItemUUID(ItemType Item)
    {
      Item.UUID = VerifyAddFixedPriceItemCall.NewUUID();
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.VerifyAddFixedPriceItemRequestType" /> for this API call.
    /// </summary>
    public VerifyAddFixedPriceItemRequestType ApiRequest
    {
      get => (VerifyAddFixedPriceItemRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType" /> for this API call.
    /// </summary>
    public VerifyAddFixedPriceItemResponseType ApiResponse
    {
      get => (VerifyAddFixedPriceItemResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
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
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.ItemID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string ItemID => this.ApiResponse.ItemID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.SKU" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SKU => this.ApiResponse.SKU;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.ExpressListing" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool ExpressListing => this.ApiResponse.ExpressListing;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.ExpressItemRequirements" /> of type <see cref="T:eBay.Service.Core.Soap.ExpressItemRequirementsType" />.
    /// </summary>
    public ExpressItemRequirementsType ExpressItemRequirements
    {
      get => this.ApiResponse.ExpressItemRequirements;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.DiscountReason" /> of type <see cref="T:eBay.Service.Core.Soap.DiscountReasonCodeTypeCollection" />.
    /// </summary>
    public DiscountReasonCodeTypeCollection DiscountReasonList => this.ApiResponse.DiscountReason;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.VerifyAddFixedPriceItemResponseType.ListingRecommendations" /> of type <see cref="T:eBay.Service.Core.Soap.ListingRecommendationsType" />.
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.ApiResponse.ListingRecommendations;
    }
  }
}