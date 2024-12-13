// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseFixedPriceItemResponseType
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
  public class ReviseFixedPriceItemResponseType : AbstractResponseType
  {
    private string mItemID;
    private string mSKU;
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private FeeTypeCollection mFees;
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
    public string SKU
    {
      get => this.mSKU;
      set => this.mSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime StartTime
    {
      get => this.mStartTime;
      set
      {
        this.mStartTime = value;
        this.mStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeSpecified
    {
      get => this.mStartTimeSpecified;
      set => this.mStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime EndTime
    {
      get => this.mEndTime;
      set
      {
        this.mEndTime = value;
        this.mEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeSpecified
    {
      get => this.mEndTimeSpecified;
      set => this.mEndTimeSpecified = value;
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
