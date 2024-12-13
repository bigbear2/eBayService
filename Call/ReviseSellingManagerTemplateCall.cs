// Decompiled with JetBrains decompiler
// Type: eBay.Service.Call.ReviseSellingManagerTemplateCall
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
  public class ReviseSellingManagerTemplateCall : ApiCall
  {
    /// <summary>
    /// 
    /// </summary>
    public ReviseSellingManagerTemplateCall()
    {
      this.ApiRequest = new ReviseSellingManagerTemplateRequestType();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ApiContext">The <see cref="P:eBay.Service.Core.Sdk.ApiCall.ApiContext" /> for this API Call of type <see cref="T:eBay.Service.Core.Sdk.ApiContext" />.</param>
    public ReviseSellingManagerTemplateCall(ApiContext ApiContext)
    {
      this.ApiRequest = new ReviseSellingManagerTemplateRequestType();
      this.ApiContext = ApiContext;
    }

    /// <summary>
    /// Revises a Selling Manager template.
    /// This call is subject to change without notice; the
    /// deprecation process is inapplicable to this call. The user must have a Selling Manager Pro subscription to use this call.
    /// </summary>
    /// <param name="SaleTemplateID">
    /// The unique identifier of the Selling Manager template. You can obtain a
    /// <b>SaleTemplateID</b> value by calling <b>GetSellingManagerInventory</b>.
    /// </param>
    /// <param name="ProductID">Reserved for future use.</param>
    /// <param name="SaleTemplateName">
    /// The name of the Selling Manager template.
    /// </param>
    /// <param name="Item">
    /// This container is used to modify the Selling Manager template. In the <b>Item.ItemID</b> field, you specify the same value as the
    /// one specified in <b>SaleTemplateID</b>.
    /// Other child elements hold the values for properties that are being changed.
    /// Set values in the Item object only for those properties that are
    /// changing. Use <b>DeletedField</b> to remove a property.
    /// </param>
    /// <param name="DeletedFieldList">
    /// Specifies the name of a field to remove from a template.
    /// See the eBay Web Services guide for rules on removing values when revising items.
    /// Also see the relevant field descriptions to determine when to use DeletedField (and potential consequences).
    /// The request can contain zero, one, or many instances of DeletedField (one for each field to be removed).
    /// DeletedField accepts the following path names, which remove the corresponding fields:
    /// 
    /// Item.ApplicationData
    /// Item.AttributeSetArray
    /// Item.ConditionID
    /// Item.ItemSpecifics
    /// Item.ListingCheckoutRedirectPreference.ProStoresStoreName
    /// Item.ListingCheckoutRedirectPreference.SellerThirdPartyUsername
    /// Item.ListingDesigner.LayoutID
    /// Item.ListingDesigner.ThemeID
    /// Item.ListingEnhancement[Value]
    /// Item.PayPalEmailAddress
    /// Item.PictureDetails.GalleryURL
    /// Item.PictureDetails.PictureURL
    /// Item.PostalCode
    /// Item.ProductListingDetails
    /// item.ShippingDetails.PaymentInstructions
    /// item.SKU
    /// Item.SubTitle
    /// These values are case-sensitive. Use values that match the case of the schema element names
    /// (Item.PictureDetails.GalleryURL) or make the initial letter of each field name lowercase (item.pictureDetails.galleryURL).
    /// However, do not change the case of letters in the middle of a field name (e.g., item.picturedetails.galleryUrl is not allowed).
    /// 
    /// Depending on how you have configured your pictures, you cannot necessarily delete
    /// both GalleryURL and PictureURL from an existing listing.
    /// If GalleryType was already set for the item you are revising, you cannot remove it.
    /// This means you still need to include either a first picture
    /// or a gallery URL in your revised listing.
    /// </param>
    /// <param name="VerifyOnly">
    /// Use this field to verify the template instead of revising it.
    /// </param>
    public long ReviseSellingManagerTemplate(
      long SaleTemplateID,
      long ProductID,
      string SaleTemplateName,
      ItemType Item,
      StringCollection DeletedFieldList,
      bool VerifyOnly)
    {
      this.SaleTemplateID = SaleTemplateID;
      this.ProductID = ProductID;
      this.SaleTemplateName = SaleTemplateName;
      this.Item = Item;
      this.DeletedFieldList = DeletedFieldList;
      this.VerifyOnly = VerifyOnly;
      this.Execute();
      return this.ApiResponse.SaleTemplateID;
    }

    /// <summary>The base interface object.</summary>
    /// <remarks>This property is reserved for users who have difficulty querying multiple interfaces.</remarks>
    public ApiCall ApiCallBase => (ApiCall) this;

    /// <summary>
    /// Gets or sets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerTemplateRequestType ApiRequest
    {
      get => (ReviseSellingManagerTemplateRequestType) this.AbstractRequest;
      set => this.AbstractRequest = (AbstractRequestType) value;
    }

    /// <summary>
    /// Gets the <see cref="T:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType" /> for this API call.
    /// </summary>
    public ReviseSellingManagerTemplateResponseType ApiResponse
    {
      get => (ReviseSellingManagerTemplateResponseType) this.AbstractResponse;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateID
    {
      get => this.ApiRequest.SaleTemplateID;
      set => this.ApiRequest.SaleTemplateID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.ProductID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long ProductID
    {
      get => this.ApiRequest.ProductID;
      set => this.ApiRequest.ProductID = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.SaleTemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SaleTemplateName
    {
      get => this.ApiRequest.SaleTemplateName;
      set => this.ApiRequest.SaleTemplateName = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.Item" /> of type <see cref="T:eBay.Service.Core.Soap.ItemType" />.
    /// </summary>
    public ItemType Item
    {
      get => this.ApiRequest.Item;
      set => this.ApiRequest.Item = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.DeletedField" /> of type <see cref="T:eBay.Service.Core.Soap.StringCollection" />.
    /// </summary>
    public StringCollection DeletedFieldList
    {
      get => this.ApiRequest.DeletedField;
      set => this.ApiRequest.DeletedField = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateRequestType.VerifyOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool VerifyOnly
    {
      get => this.ApiRequest.VerifyOnly;
      set => this.ApiRequest.VerifyOnly = value;
    }

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.SaleTemplateID" /> of type <see cref="T:System.Int64" />.
    /// </summary>
    public long SaleTemplateIDReturn => this.ApiResponse.SaleTemplateID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.Fees" /> of type <see cref="T:eBay.Service.Core.Soap.FeeTypeCollection" />.
    /// </summary>
    public FeeTypeCollection FeeList => this.ApiResponse.Fees;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.CategoryID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string CategoryID => this.ApiResponse.CategoryID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.Category2ID" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string Category2ID => this.ApiResponse.Category2ID;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.VerifyOnly" /> of type <see cref="T:System.Boolean" />.
    /// </summary>
    public bool VerifyOnlyReturn => this.ApiResponse.VerifyOnly;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.SaleTemplateName" /> of type <see cref="T:System.String" />.
    /// </summary>
    public string SaleTemplateNameReturn => this.ApiResponse.SaleTemplateName;

    /// <summary>
    /// Gets the returned <see cref="P:eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType.SellingManagerProductDetails" /> of type <see cref="T:eBay.Service.Core.Soap.SellingManagerProductDetailsType" />.
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.ApiResponse.SellingManagerProductDetails;
    }
  }
}
