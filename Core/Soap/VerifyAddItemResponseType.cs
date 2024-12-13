// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VerifyAddItemResponseType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public class VerifyAddItemResponseType : AbstractResponseType
  {
    private string mItemID;
    private FeeTypeCollection mFees;
    private bool mExpressListing;
    private bool mExpressListingSpecified;
    private ExpressItemRequirementsType mExpressItemRequirements;
    private string mCategoryID;
    private string mCategory2ID;
    private DiscountReasonCodeTypeCollection mDiscountReason;
    private ProductSuggestionsType mProductSuggestions;
    private ListingRecommendationsType mListingRecommendations;

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Fee", IsNullable = false)]
    public FeeTypeCollection Fees
    {
      get => this.mFees;
      set => this.mFees = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressListing
    {
      get => this.mExpressListing;
      set
      {
        this.mExpressListing = value;
        this.mExpressListingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressListingSpecified
    {
      get => this.mExpressListingSpecified;
      set => this.mExpressListingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ExpressItemRequirementsType ExpressItemRequirements
    {
      get => this.mExpressItemRequirements;
      set => this.mExpressItemRequirements = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Category2ID
    {
      get => this.mCategory2ID;
      set => this.mCategory2ID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DiscountReason")]
    public DiscountReasonCodeTypeCollection DiscountReason
    {
      get => this.mDiscountReason;
      set => this.mDiscountReason = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductSuggestionsType ProductSuggestions
    {
      get => this.mProductSuggestions;
      set => this.mProductSuggestions = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.mListingRecommendations;
      set => this.mListingRecommendations = value;
    }
  }
}
