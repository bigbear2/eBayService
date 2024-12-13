// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ExpressItemRequirementsType
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
  public class ExpressItemRequirementsType
  {
    private bool mSellerExpressEligible;
    private bool mSellerExpressEligibleSpecified;
    private bool mExpressOptOut;
    private bool mExpressOptOutSpecified;
    private bool mExpressApproved;
    private bool mExpressApprovedSpecified;
    private bool mExpressEligibleListingType;
    private bool mExpressEligibleListingTypeSpecified;
    private bool mExpressEnabledCategory;
    private bool mExpressEnabledCategorySpecified;
    private bool mEligiblePayPalAccount;
    private bool mEligiblePayPalAccountSpecified;
    private bool mDomesticShippingCost;
    private bool mDomesticShippingCostSpecified;
    private bool mEligibleReturnPolicy;
    private bool mEligibleReturnPolicySpecified;
    private bool mPicture;
    private bool mPictureSpecified;
    private bool mEligibleItemCondition;
    private bool mEligibleItemConditionSpecified;
    private bool mPriceAboveMinimum;
    private bool mPriceAboveMinimumSpecified;
    private bool mPriceBelowMaximum;
    private bool mPriceBelowMaximumSpecified;
    private bool mEligibleCheckout;
    private bool mEligibleCheckoutSpecified;
    private bool mNoPreapprovedBidderList;
    private bool mNoPreapprovedBidderListSpecified;
    private bool mNoCharity;
    private bool mNoCharitySpecified;
    private bool mCombinedShippingDiscount;
    private bool mCombinedShippingDiscountSpecified;
    private bool mShipFromEligibleCountry;
    private bool mShipFromEligibleCountrySpecified;
    private bool mPayPalAccountAcceptsUnconfirmedAddress;
    private bool mPayPalAccountAcceptsUnconfirmedAddressSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool SellerExpressEligible
    {
      get => this.mSellerExpressEligible;
      set
      {
        this.mSellerExpressEligible = value;
        this.mSellerExpressEligibleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerExpressEligibleSpecified
    {
      get => this.mSellerExpressEligibleSpecified;
      set => this.mSellerExpressEligibleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressOptOut
    {
      get => this.mExpressOptOut;
      set
      {
        this.mExpressOptOut = value;
        this.mExpressOptOutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressOptOutSpecified
    {
      get => this.mExpressOptOutSpecified;
      set => this.mExpressOptOutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressApproved
    {
      get => this.mExpressApproved;
      set
      {
        this.mExpressApproved = value;
        this.mExpressApprovedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressApprovedSpecified
    {
      get => this.mExpressApprovedSpecified;
      set => this.mExpressApprovedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressEligibleListingType
    {
      get => this.mExpressEligibleListingType;
      set
      {
        this.mExpressEligibleListingType = value;
        this.mExpressEligibleListingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressEligibleListingTypeSpecified
    {
      get => this.mExpressEligibleListingTypeSpecified;
      set => this.mExpressEligibleListingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpressEnabledCategory
    {
      get => this.mExpressEnabledCategory;
      set
      {
        this.mExpressEnabledCategory = value;
        this.mExpressEnabledCategorySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpressEnabledCategorySpecified
    {
      get => this.mExpressEnabledCategorySpecified;
      set => this.mExpressEnabledCategorySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligiblePayPalAccount
    {
      get => this.mEligiblePayPalAccount;
      set
      {
        this.mEligiblePayPalAccount = value;
        this.mEligiblePayPalAccountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligiblePayPalAccountSpecified
    {
      get => this.mEligiblePayPalAccountSpecified;
      set => this.mEligiblePayPalAccountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DomesticShippingCost
    {
      get => this.mDomesticShippingCost;
      set
      {
        this.mDomesticShippingCost = value;
        this.mDomesticShippingCostSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DomesticShippingCostSpecified
    {
      get => this.mDomesticShippingCostSpecified;
      set => this.mDomesticShippingCostSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleReturnPolicy
    {
      get => this.mEligibleReturnPolicy;
      set
      {
        this.mEligibleReturnPolicy = value;
        this.mEligibleReturnPolicySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleReturnPolicySpecified
    {
      get => this.mEligibleReturnPolicySpecified;
      set => this.mEligibleReturnPolicySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Picture
    {
      get => this.mPicture;
      set
      {
        this.mPicture = value;
        this.mPictureSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureSpecified
    {
      get => this.mPictureSpecified;
      set => this.mPictureSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleItemCondition
    {
      get => this.mEligibleItemCondition;
      set
      {
        this.mEligibleItemCondition = value;
        this.mEligibleItemConditionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleItemConditionSpecified
    {
      get => this.mEligibleItemConditionSpecified;
      set => this.mEligibleItemConditionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PriceAboveMinimum
    {
      get => this.mPriceAboveMinimum;
      set
      {
        this.mPriceAboveMinimum = value;
        this.mPriceAboveMinimumSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PriceAboveMinimumSpecified
    {
      get => this.mPriceAboveMinimumSpecified;
      set => this.mPriceAboveMinimumSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PriceBelowMaximum
    {
      get => this.mPriceBelowMaximum;
      set
      {
        this.mPriceBelowMaximum = value;
        this.mPriceBelowMaximumSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PriceBelowMaximumSpecified
    {
      get => this.mPriceBelowMaximumSpecified;
      set => this.mPriceBelowMaximumSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EligibleCheckout
    {
      get => this.mEligibleCheckout;
      set
      {
        this.mEligibleCheckout = value;
        this.mEligibleCheckoutSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EligibleCheckoutSpecified
    {
      get => this.mEligibleCheckoutSpecified;
      set => this.mEligibleCheckoutSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool NoPreapprovedBidderList
    {
      get => this.mNoPreapprovedBidderList;
      set
      {
        this.mNoPreapprovedBidderList = value;
        this.mNoPreapprovedBidderListSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NoPreapprovedBidderListSpecified
    {
      get => this.mNoPreapprovedBidderListSpecified;
      set => this.mNoPreapprovedBidderListSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool NoCharity
    {
      get => this.mNoCharity;
      set
      {
        this.mNoCharity = value;
        this.mNoCharitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NoCharitySpecified
    {
      get => this.mNoCharitySpecified;
      set => this.mNoCharitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CombinedShippingDiscount
    {
      get => this.mCombinedShippingDiscount;
      set
      {
        this.mCombinedShippingDiscount = value;
        this.mCombinedShippingDiscountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CombinedShippingDiscountSpecified
    {
      get => this.mCombinedShippingDiscountSpecified;
      set => this.mCombinedShippingDiscountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShipFromEligibleCountry
    {
      get => this.mShipFromEligibleCountry;
      set
      {
        this.mShipFromEligibleCountry = value;
        this.mShipFromEligibleCountrySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShipFromEligibleCountrySpecified
    {
      get => this.mShipFromEligibleCountrySpecified;
      set => this.mShipFromEligibleCountrySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalAccountAcceptsUnconfirmedAddress
    {
      get => this.mPayPalAccountAcceptsUnconfirmedAddress;
      set
      {
        this.mPayPalAccountAcceptsUnconfirmedAddress = value;
        this.mPayPalAccountAcceptsUnconfirmedAddressSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalAccountAcceptsUnconfirmedAddressSpecified
    {
      get => this.mPayPalAccountAcceptsUnconfirmedAddressSpecified;
      set => this.mPayPalAccountAcceptsUnconfirmedAddressSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
