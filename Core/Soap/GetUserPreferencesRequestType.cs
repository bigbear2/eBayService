// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserPreferencesRequestType
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
  public class GetUserPreferencesRequestType : AbstractRequestType
  {
    private bool mShowBidderNoticePreferences;
    private bool mShowCombinedPaymentPreferences;
    private bool mShowCrossPromotionPreferences;
    private bool mShowSellerPaymentPreferences;
    private bool mShowEndOfAuctionEmailPreferences;
    private bool mShowEndOfAuctionEmailPreferencesSpecified;
    private bool mShowSellerFavoriteItemPreferences;
    private bool mShowSellerFavoriteItemPreferencesSpecified;
    private bool mShowProStoresPreferences;
    private bool mShowProStoresPreferencesSpecified;
    private bool mShowEmailShipmentTrackingNumberPreference;
    private bool mShowEmailShipmentTrackingNumberPreferenceSpecified;
    private bool mShowRequiredShipPhoneNumberPreference;
    private bool mShowRequiredShipPhoneNumberPreferenceSpecified;
    private bool mShowSellerExcludeShipToLocationPreference;
    private bool mShowSellerExcludeShipToLocationPreferenceSpecified;
    private bool mShowUnpaidItemAssistancePreference;
    private bool mShowUnpaidItemAssistancePreferenceSpecified;
    private bool mShowPurchaseReminderEmailPreferences;
    private bool mShowPurchaseReminderEmailPreferencesSpecified;
    private bool mShowUnpaidItemAssistanceExclusionList;
    private bool mShowUnpaidItemAssistanceExclusionListSpecified;
    private bool mShowSellerProfilePreferences;
    private bool mShowSellerReturnPreferences;
    private bool mShowSellerReturnPreferencesSpecified;
    private bool mShowGlobalShippingProgramPreference;
    private bool mShowGlobalShippingProgramPreferenceSpecified;
    private bool mShowDispatchCutoffTimePreferences;
    private bool mShowDispatchCutoffTimePreferencesSpecified;
    private bool mShowGlobalShippingProgramListingPreference;
    private bool mShowGlobalShippingProgramListingPreferenceSpecified;
    private bool mShowOverrideGSPServiceWithIntlServicePreference;
    private bool mShowOverrideGSPServiceWithIntlServicePreferenceSpecified;
    private bool mShowPickupDropoffPreferences;
    private bool mShowPickupDropoffPreferencesSpecified;
    private bool mShowOutOfStockControlPreference;
    private bool mShowOutOfStockControlPreferenceSpecified;
    private bool mShoweBayPLUSPreference;
    private bool mShoweBayPLUSPreferenceSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public bool ShowBidderNoticePreferences
    {
      get => this.mShowBidderNoticePreferences;
      set => this.mShowBidderNoticePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool ShowCombinedPaymentPreferences
    {
      get => this.mShowCombinedPaymentPreferences;
      set => this.mShowCombinedPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool ShowCrossPromotionPreferences
    {
      get => this.mShowCrossPromotionPreferences;
      set => this.mShowCrossPromotionPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool ShowSellerPaymentPreferences
    {
      get => this.mShowSellerPaymentPreferences;
      set => this.mShowSellerPaymentPreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public bool ShowEndOfAuctionEmailPreferences
    {
      get => this.mShowEndOfAuctionEmailPreferences;
      set
      {
        this.mShowEndOfAuctionEmailPreferences = value;
        this.mShowEndOfAuctionEmailPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowEndOfAuctionEmailPreferencesSpecified
    {
      get => this.mShowEndOfAuctionEmailPreferencesSpecified;
      set => this.mShowEndOfAuctionEmailPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public bool ShowSellerFavoriteItemPreferences
    {
      get => this.mShowSellerFavoriteItemPreferences;
      set
      {
        this.mShowSellerFavoriteItemPreferences = value;
        this.mShowSellerFavoriteItemPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowSellerFavoriteItemPreferencesSpecified
    {
      get => this.mShowSellerFavoriteItemPreferencesSpecified;
      set => this.mShowSellerFavoriteItemPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public bool ShowProStoresPreferences
    {
      get => this.mShowProStoresPreferences;
      set
      {
        this.mShowProStoresPreferences = value;
        this.mShowProStoresPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowProStoresPreferencesSpecified
    {
      get => this.mShowProStoresPreferencesSpecified;
      set => this.mShowProStoresPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool ShowEmailShipmentTrackingNumberPreference
    {
      get => this.mShowEmailShipmentTrackingNumberPreference;
      set
      {
        this.mShowEmailShipmentTrackingNumberPreference = value;
        this.mShowEmailShipmentTrackingNumberPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowEmailShipmentTrackingNumberPreferenceSpecified
    {
      get => this.mShowEmailShipmentTrackingNumberPreferenceSpecified;
      set => this.mShowEmailShipmentTrackingNumberPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public bool ShowRequiredShipPhoneNumberPreference
    {
      get => this.mShowRequiredShipPhoneNumberPreference;
      set
      {
        this.mShowRequiredShipPhoneNumberPreference = value;
        this.mShowRequiredShipPhoneNumberPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowRequiredShipPhoneNumberPreferenceSpecified
    {
      get => this.mShowRequiredShipPhoneNumberPreferenceSpecified;
      set => this.mShowRequiredShipPhoneNumberPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public bool ShowSellerExcludeShipToLocationPreference
    {
      get => this.mShowSellerExcludeShipToLocationPreference;
      set
      {
        this.mShowSellerExcludeShipToLocationPreference = value;
        this.mShowSellerExcludeShipToLocationPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowSellerExcludeShipToLocationPreferenceSpecified
    {
      get => this.mShowSellerExcludeShipToLocationPreferenceSpecified;
      set => this.mShowSellerExcludeShipToLocationPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public bool ShowUnpaidItemAssistancePreference
    {
      get => this.mShowUnpaidItemAssistancePreference;
      set
      {
        this.mShowUnpaidItemAssistancePreference = value;
        this.mShowUnpaidItemAssistancePreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowUnpaidItemAssistancePreferenceSpecified
    {
      get => this.mShowUnpaidItemAssistancePreferenceSpecified;
      set => this.mShowUnpaidItemAssistancePreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public bool ShowPurchaseReminderEmailPreferences
    {
      get => this.mShowPurchaseReminderEmailPreferences;
      set
      {
        this.mShowPurchaseReminderEmailPreferences = value;
        this.mShowPurchaseReminderEmailPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowPurchaseReminderEmailPreferencesSpecified
    {
      get => this.mShowPurchaseReminderEmailPreferencesSpecified;
      set => this.mShowPurchaseReminderEmailPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    public bool ShowUnpaidItemAssistanceExclusionList
    {
      get => this.mShowUnpaidItemAssistanceExclusionList;
      set
      {
        this.mShowUnpaidItemAssistanceExclusionList = value;
        this.mShowUnpaidItemAssistanceExclusionListSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowUnpaidItemAssistanceExclusionListSpecified
    {
      get => this.mShowUnpaidItemAssistanceExclusionListSpecified;
      set => this.mShowUnpaidItemAssistanceExclusionListSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    public bool ShowSellerProfilePreferences
    {
      get => this.mShowSellerProfilePreferences;
      set => this.mShowSellerProfilePreferences = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 14)]
    public bool ShowSellerReturnPreferences
    {
      get => this.mShowSellerReturnPreferences;
      set
      {
        this.mShowSellerReturnPreferences = value;
        this.mShowSellerReturnPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowSellerReturnPreferencesSpecified
    {
      get => this.mShowSellerReturnPreferencesSpecified;
      set => this.mShowSellerReturnPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 15)]
    public bool ShowGlobalShippingProgramPreference
    {
      get => this.mShowGlobalShippingProgramPreference;
      set
      {
        this.mShowGlobalShippingProgramPreference = value;
        this.mShowGlobalShippingProgramPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowGlobalShippingProgramPreferenceSpecified
    {
      get => this.mShowGlobalShippingProgramPreferenceSpecified;
      set => this.mShowGlobalShippingProgramPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 16)]
    public bool ShowDispatchCutoffTimePreferences
    {
      get => this.mShowDispatchCutoffTimePreferences;
      set
      {
        this.mShowDispatchCutoffTimePreferences = value;
        this.mShowDispatchCutoffTimePreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowDispatchCutoffTimePreferencesSpecified
    {
      get => this.mShowDispatchCutoffTimePreferencesSpecified;
      set => this.mShowDispatchCutoffTimePreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 17)]
    public bool ShowGlobalShippingProgramListingPreference
    {
      get => this.mShowGlobalShippingProgramListingPreference;
      set
      {
        this.mShowGlobalShippingProgramListingPreference = value;
        this.mShowGlobalShippingProgramListingPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowGlobalShippingProgramListingPreferenceSpecified
    {
      get => this.mShowGlobalShippingProgramListingPreferenceSpecified;
      set => this.mShowGlobalShippingProgramListingPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 18)]
    public bool ShowOverrideGSPServiceWithIntlServicePreference
    {
      get => this.mShowOverrideGSPServiceWithIntlServicePreference;
      set
      {
        this.mShowOverrideGSPServiceWithIntlServicePreference = value;
        this.mShowOverrideGSPServiceWithIntlServicePreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowOverrideGSPServiceWithIntlServicePreferenceSpecified
    {
      get => this.mShowOverrideGSPServiceWithIntlServicePreferenceSpecified;
      set => this.mShowOverrideGSPServiceWithIntlServicePreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 19)]
    public bool ShowPickupDropoffPreferences
    {
      get => this.mShowPickupDropoffPreferences;
      set
      {
        this.mShowPickupDropoffPreferences = value;
        this.mShowPickupDropoffPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowPickupDropoffPreferencesSpecified
    {
      get => this.mShowPickupDropoffPreferencesSpecified;
      set => this.mShowPickupDropoffPreferencesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 20)]
    public bool ShowOutOfStockControlPreference
    {
      get => this.mShowOutOfStockControlPreference;
      set
      {
        this.mShowOutOfStockControlPreference = value;
        this.mShowOutOfStockControlPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShowOutOfStockControlPreferenceSpecified
    {
      get => this.mShowOutOfStockControlPreferenceSpecified;
      set => this.mShowOutOfStockControlPreferenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 21)]
    public bool ShoweBayPLUSPreference
    {
      get => this.mShoweBayPLUSPreference;
      set
      {
        this.mShoweBayPLUSPreference = value;
        this.mShoweBayPLUSPreferenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShoweBayPLUSPreferenceSpecified
    {
      get => this.mShoweBayPLUSPreferenceSpecified;
      set => this.mShoweBayPLUSPreferenceSpecified = value;
    }
  }
}
