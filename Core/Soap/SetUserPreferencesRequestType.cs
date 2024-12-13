// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetUserPreferencesRequestType
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
  public class SetUserPreferencesRequestType : AbstractRequestType
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
    private UnpaidItemAssistancePreferencesType mUnpaidItemAssistancePreferences;
    private PurchaseReminderEmailPreferencesType mPurchaseReminderEmailPreferences;
    private bool mSellerThirdPartyCheckoutDisabled;
    private bool mSellerThirdPartyCheckoutDisabledSpecified;
    private DispatchCutoffTimePreferencesType mDispatchCutoffTimePreference;
    private bool mGlobalShippingProgramListingPreference;
    private bool mGlobalShippingProgramListingPreferenceSpecified;
    private bool mOverrideGSPserviceWithIntlService;
    private bool mOverrideGSPserviceWithIntlServiceSpecified;
    private bool mOutOfStockControlPreference;
    private bool mOutOfStockControlPreferenceSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public BidderNoticePreferencesType BidderNoticePreferences
    {
      get => this.mBidderNoticePreferences;
      set => this.mBidderNoticePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public CombinedPaymentPreferencesType CombinedPaymentPreferences
    {
      get => this.mCombinedPaymentPreferences;
      set => this.mCombinedPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public CrossPromotionPreferencesType CrossPromotionPreferences
    {
      get => this.mCrossPromotionPreferences;
      set => this.mCrossPromotionPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public SellerPaymentPreferencesType SellerPaymentPreferences
    {
      get => this.mSellerPaymentPreferences;
      set => this.mSellerPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public SellerFavoriteItemPreferencesType SellerFavoriteItemPreferences
    {
      get => this.mSellerFavoriteItemPreferences;
      set => this.mSellerFavoriteItemPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public EndOfAuctionEmailPreferencesType EndOfAuctionEmailPreferences
    {
      get => this.mEndOfAuctionEmailPreferences;
      set => this.mEndOfAuctionEmailPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
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
    [XmlElement(Order = 7)]
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
    [XmlElement(Order = 8)]
    public UnpaidItemAssistancePreferencesType UnpaidItemAssistancePreferences
    {
      get => this.mUnpaidItemAssistancePreferences;
      set => this.mUnpaidItemAssistancePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public PurchaseReminderEmailPreferencesType PurchaseReminderEmailPreferences
    {
      get => this.mPurchaseReminderEmailPreferences;
      set => this.mPurchaseReminderEmailPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
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
    [XmlElement(Order = 11)]
    public DispatchCutoffTimePreferencesType DispatchCutoffTimePreference
    {
      get => this.mDispatchCutoffTimePreference;
      set => this.mDispatchCutoffTimePreference = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
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
    [XmlElement(Order = 13)]
    public bool OverrideGSPserviceWithIntlService
    {
      get => this.mOverrideGSPserviceWithIntlService;
      set
      {
        this.mOverrideGSPserviceWithIntlService = value;
        this.mOverrideGSPserviceWithIntlServiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OverrideGSPserviceWithIntlServiceSpecified
    {
      get => this.mOverrideGSPserviceWithIntlServiceSpecified;
      set => this.mOverrideGSPserviceWithIntlServiceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14)]
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
  }
}
