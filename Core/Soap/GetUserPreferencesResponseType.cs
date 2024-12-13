// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserPreferencesResponseType
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
  public class GetUserPreferencesResponseType : AbstractResponseType
  {
    private BidderNoticePreferencesType mBidderNoticePreferences;
    private CombinedPaymentPreferencesType mCombinedPaymentPreferences;
    private CrossPromotionPreferencesType mCrossPromotionPreferences;
    private SellerPaymentPreferencesType mSellerPaymentPreferences;
    private SellerFavoriteItemPreferencesType mSellerFavoriteItemPreferences;
    private EndOfAuctionEmailPreferencesType mEndOfAuctionEmailPreferences;
    private bool mEmailShipmentTrackingNumberPreference;
    private bool mEmailShipmentTrackingNumberPreferenceSpecified;
    private bool mRequiredShipPhoneNumberPreference;
    private bool mRequiredShipPhoneNumberPreferenceSpecified;
    private ProStoresCheckoutPreferenceType mProStoresPreference;
    private UnpaidItemAssistancePreferencesType mUnpaidItemAssistancePreferences;
    private SellerExcludeShipToLocationPreferencesType mSellerExcludeShipToLocationPreferences;
    private PurchaseReminderEmailPreferencesType mPurchaseReminderEmailPreferences;
    private bool mSellerThirdPartyCheckoutDisabled;
    private bool mSellerThirdPartyCheckoutDisabledSpecified;
    private SellerProfilePreferencesType mSellerProfilePreferences;
    private SellerReturnPreferencesType mSellerReturnPreferences;
    private bool mOfferGlobalShippingProgramPreference;
    private bool mOfferGlobalShippingProgramPreferenceSpecified;
    private DispatchCutoffTimePreferencesType mDispatchCutoffTimePreference;
    private bool mGlobalShippingProgramListingPreference;
    private bool mGlobalShippingProgramListingPreferenceSpecified;
    private bool mOverrideGSPServiceWithIntlServicePreference;
    private bool mOverrideGSPServiceWithIntlServicePreferenceSpecified;
    private bool mPickupDropoffSellerPreference;
    private bool mPickupDropoffSellerPreferenceSpecified;
    private bool mOutOfStockControlPreference;
    private bool mOutOfStockControlPreferenceSpecified;
    private eBayPLUSPreferenceTypeCollection meBayPLUSPreference;

    /// <summary>
    /// 
    /// </summary>
    public BidderNoticePreferencesType BidderNoticePreferences
    {
      get => this.mBidderNoticePreferences;
      set => this.mBidderNoticePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CombinedPaymentPreferencesType CombinedPaymentPreferences
    {
      get => this.mCombinedPaymentPreferences;
      set => this.mCombinedPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CrossPromotionPreferencesType CrossPromotionPreferences
    {
      get => this.mCrossPromotionPreferences;
      set => this.mCrossPromotionPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerPaymentPreferencesType SellerPaymentPreferences
    {
      get => this.mSellerPaymentPreferences;
      set => this.mSellerPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences
    {
      get => this.mSellerFavoriteItemPreferences;
      set => this.mSellerFavoriteItemPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences
    {
      get => this.mEndOfAuctionEmailPreferences;
      set => this.mEndOfAuctionEmailPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EmailShipmentTrackingNumberPreference
    {
      get => this.mEmailShipmentTrackingNumberPreference;
      set
      {
        this.mEmailShipmentTrackingNumberPreference = value;
        this.mEmailShipmentTrackingNumberPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailShipmentTrackingNumberPreferenceSpecified
    {
      get => this.mEmailShipmentTrackingNumberPreferenceSpecified;
      set => this.mEmailShipmentTrackingNumberPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RequiredShipPhoneNumberPreference
    {
      get => this.mRequiredShipPhoneNumberPreference;
      set
      {
        this.mRequiredShipPhoneNumberPreference = value;
        this.mRequiredShipPhoneNumberPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RequiredShipPhoneNumberPreferenceSpecified
    {
      get => this.mRequiredShipPhoneNumberPreferenceSpecified;
      set => this.mRequiredShipPhoneNumberPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProStoresCheckoutPreferenceType ProStoresPreference
    {
      get => this.mProStoresPreference;
      set => this.mProStoresPreference = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences
    {
      get => this.mUnpaidItemAssistancePreferences;
      set => this.mUnpaidItemAssistancePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerExcludeShipToLocationPreferencesType SellerExcludeShipToLocationPreferences
    {
      get => this.mSellerExcludeShipToLocationPreferences;
      set => this.mSellerExcludeShipToLocationPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences
    {
      get => this.mPurchaseReminderEmailPreferences;
      set => this.mPurchaseReminderEmailPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SellerThirdPartyCheckoutDisabled
    {
      get => this.mSellerThirdPartyCheckoutDisabled;
      set
      {
        this.mSellerThirdPartyCheckoutDisabled = value;
        this.mSellerThirdPartyCheckoutDisabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellerThirdPartyCheckoutDisabledSpecified
    {
      get => this.mSellerThirdPartyCheckoutDisabledSpecified;
      set => this.mSellerThirdPartyCheckoutDisabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerProfilePreferencesType SellerProfilePreferences
    {
      get => this.mSellerProfilePreferences;
      set => this.mSellerProfilePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellerReturnPreferencesType SellerReturnPreferences
    {
      get => this.mSellerReturnPreferences;
      set => this.mSellerReturnPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool OfferGlobalShippingProgramPreference
    {
      get => this.mOfferGlobalShippingProgramPreference;
      set
      {
        this.mOfferGlobalShippingProgramPreference = value;
        this.mOfferGlobalShippingProgramPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OfferGlobalShippingProgramPreferenceSpecified
    {
      get => this.mOfferGlobalShippingProgramPreferenceSpecified;
      set => this.mOfferGlobalShippingProgramPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DispatchCutoffTimePreferencesType DispatchCutoffTimePreference
    {
      get => this.mDispatchCutoffTimePreference;
      set => this.mDispatchCutoffTimePreference = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool GlobalShippingProgramListingPreference
    {
      get => this.mGlobalShippingProgramListingPreference;
      set
      {
        this.mGlobalShippingProgramListingPreference = value;
        this.mGlobalShippingProgramListingPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GlobalShippingProgramListingPreferenceSpecified
    {
      get => this.mGlobalShippingProgramListingPreferenceSpecified;
      set => this.mGlobalShippingProgramListingPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool OverrideGSPServiceWithIntlServicePreference
    {
      get => this.mOverrideGSPServiceWithIntlServicePreference;
      set
      {
        this.mOverrideGSPServiceWithIntlServicePreference = value;
        this.mOverrideGSPServiceWithIntlServicePreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OverrideGSPServiceWithIntlServicePreferenceSpecified
    {
      get => this.mOverrideGSPServiceWithIntlServicePreferenceSpecified;
      set => this.mOverrideGSPServiceWithIntlServicePreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PickupDropoffSellerPreference
    {
      get => this.mPickupDropoffSellerPreference;
      set
      {
        this.mPickupDropoffSellerPreference = value;
        this.mPickupDropoffSellerPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PickupDropoffSellerPreferenceSpecified
    {
      get => this.mPickupDropoffSellerPreferenceSpecified;
      set => this.mPickupDropoffSellerPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool OutOfStockControlPreference
    {
      get => this.mOutOfStockControlPreference;
      set
      {
        this.mOutOfStockControlPreference = value;
        this.mOutOfStockControlPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OutOfStockControlPreferenceSpecified
    {
      get => this.mOutOfStockControlPreferenceSpecified;
      set => this.mOutOfStockControlPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("eBayPLUSPreference")]
    public eBayPLUSPreferenceTypeCollection eBayPLUSPreference
    {
      get => this.meBayPLUSPreference;
      set => this.meBayPLUSPreference = value;
    }
  }
}
