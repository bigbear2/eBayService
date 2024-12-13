// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingServiceCodeType
// Assembly: eBay.Service, Version=3.1131.0.0, Culture=neutral, PublicKeyToken=1d9d786a5932eaf0
// MVID: DB37CD86-03E4-4A03-BCFC-56AD7C99FC60
// Assembly location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.dll
// XML documentation location: D:\Sviluppo\Lazarus\Progetti\Agrozootecnica\Programmi\Gestione eBay\eBayRestApi\eBay.Service.xml

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;


namespace eBay.Service.Core.Soap
{
  /// <remarks />
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public enum ShippingServiceCodeType
  {
    /// <remarks />
    UPSGround,
    /// <remarks />
    UPS3rdDay,
    /// <remarks />
    UPS2ndDay,
    /// <remarks />
    UPSNextDay,
    /// <remarks />
    USPSPriority,
    /// <remarks />
    USPSParcel,
    /// <remarks />
    USPSStandardPost,
    /// <remarks />
    USPSMedia,
    /// <remarks />
    USPSFirstClass,
    /// <remarks />
    ShippingMethodStandard,
    /// <remarks />
    ShippingMethodExpress,
    /// <remarks />
    USPSExpressMail,
    /// <remarks />
    UPSNextDayAir,
    /// <remarks />
    UPS2DayAirAM,
    /// <remarks />
    USPSExpressMailFlatRateEnvelope,
    /// <remarks />
    USPSExpressMailPaddedFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailSmallFlatRateBox,
    /// <remarks />
    USPSPriorityMailFlatRateBox,
    /// <remarks />
    USPSPriorityMailLargeFlatRateBox,
    /// <remarks />
    USPSPriorityMailPaddedFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailLegalFlatRateEnvelope,
    /// <remarks />
    USPSExpressMailLegalFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailRegionalBoxA,
    /// <remarks />
    USPSPriorityMailRegionalBoxB,
    /// <remarks />
    USPSPriorityMailRegionalBoxC,
    /// <remarks />
    USPSExpressMailFlatRateBox,
    /// <remarks />
    Other,
    /// <remarks />
    LocalDelivery,
    /// <remarks />
    NotSelected,
    /// <remarks />
    InternationalNotSelected,
    /// <remarks />
    StandardInternational,
    /// <remarks />
    ExpeditedInternational,
    /// <remarks />
    USPSGlobalExpress,
    /// <remarks />
    USPSGlobalPriority,
    /// <remarks />
    USPSEconomyParcel,
    /// <remarks />
    USPSEconomyLetter,
    /// <remarks />
    USPSAirmailLetter,
    /// <remarks />
    USPSAirmailParcel,
    /// <remarks />
    UPSWorldWideExpressPlus,
    /// <remarks />
    UPSWorldWideExpress,
    /// <remarks />
    UPSWorldWideExpedited,
    /// <remarks />
    UPSWorldwideSaver,
    /// <remarks />
    UPSStandardToCanada,
    /// <remarks />
    USPSExpressMailInternationalFlatRateEnvelope,
    /// <remarks />
    USPSExpressMailInternationalPaddedFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailInternationalFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailInternationalSmallFlatRateBox,
    /// <remarks />
    USPSPriorityMailInternationalFlatRateBox,
    /// <remarks />
    USPSPriorityMailInternationalLargeFlatRateBox,
    /// <remarks />
    USPSPriorityMailInternationalPaddedFlatRateEnvelope,
    /// <remarks />
    USPSPriorityMailInternationalLegalFlatRateEnvelope,
    /// <remarks />
    USPSExpressMailInternationalLegalFlatRateEnvelope,
    /// <remarks />
    USPSExpressMailInternationalFlatRateBox,
    /// <remarks />
    OtherInternational,
    /// <remarks />
    AT_StandardDispatch,
    /// <remarks />
    AT_InsuredDispatch,
    /// <remarks />
    AT_Writing,
    /// <remarks />
    AT_COD,
    /// <remarks />
    AT_ExpressOrCourier,
    /// <remarks />
    AT_InsuredExpressOrCourier,
    /// <remarks />
    AT_SpecialDispatch,
    /// <remarks />
    AT_InsuredSpecialDispatch,
    /// <remarks />
    AT_Sonstige,
    /// <remarks />
    AT_UnversicherterVersandInternational,
    /// <remarks />
    AT_VersicherterVersandInternational,
    /// <remarks />
    AT_SonstigerVersandInternational,
    /// <remarks />
    AT_UnversicherterExpressVersandInternational,
    /// <remarks />
    AT_VersicherterExpressVersandInternational,
    /// <remarks />
    AT_EconomyDeliveryFromAbroad,
    /// <remarks />
    AT_StandardDeliveryFromAbroad,
    /// <remarks />
    AT_ExpressDeliveryFromAbroad,
    /// <remarks />
    AT_TrackedDeliveryFromAbroad,
    /// <remarks />
    AU_Regular,
    /// <remarks />
    AU_Express,
    /// <remarks />
    AU_Registered,
    /// <remarks />
    AU_Courier,
    /// <remarks />
    AU_Other,
    /// <remarks />
    AU_EMSInternationalCourierParcels,
    /// <remarks />
    AU_EMSInternationalCourierDocuments,
    /// <remarks />
    AU_ExpressPostInternationalDocuments,
    /// <remarks />
    AU_AirMailInternational,
    /// <remarks />
    AU_EconomyAirInternational,
    /// <remarks />
    AU_SeaMailInternational,
    /// <remarks />
    AU_StandardInternational,
    /// <remarks />
    AU_ExpeditedInternational,
    /// <remarks />
    AU_OtherInternational,
    /// <remarks />
    AU_AusPostRegisteredPostInternationalPaddedBag1kg,
    /// <remarks />
    AU_AusPostRegisteredPostInternationalPaddedBag500g,
    /// <remarks />
    AU_AusPostRegisteredPostInternationalParcel,
    /// <remarks />
    AU_ExpeditedDeliveryFromOutsideAU,
    /// <remarks />
    AU_EconomyDeliveryFromOutsideAU,
    /// <remarks />
    AU_StandardDeliveryFromOutsideAU,
    /// <remarks />
    AU_AustralianAirExpressMetro15kg,
    /// <remarks />
    AU_AustralianAirExpressFlatRate5kg,
    /// <remarks />
    AU_AustralianAirExpressFlatRate3kg,
    /// <remarks />
    AU_AustralianAirExpressFlatRate1kg,
    /// <remarks />
    AU_ExpressDelivery,
    /// <remarks />
    AU_StandardDelivery,
    /// <remarks />
    AU_eBayAusPost3kgFlatRateSatchel,
    /// <remarks />
    AU_eBayAusPost500gFlatRateSatchel,
    /// <remarks />
    AU_Freight,
    /// <remarks />
    BEFR_StandardDelivery,
    /// <remarks />
    BEFR_PriorityDelivery,
    /// <remarks />
    BEFR_ParcelPost,
    /// <remarks />
    BEFR_RegisteredMail,
    /// <remarks />
    BEFR_Other,
    /// <remarks />
    BEFR_DePostInternational,
    /// <remarks />
    BEFR_UPSInternational,
    /// <remarks />
    BEFR_FedExInternational,
    /// <remarks />
    BEFR_DHLInternational,
    /// <remarks />
    BEFR_TPGPostTNTInternational,
    /// <remarks />
    BEFR_StandardInternational,
    /// <remarks />
    BEFR_ExpeditedInternational,
    /// <remarks />
    BEFR_OtherInternational,
    /// <remarks />
    BEFR_LaPosteInternational,
    /// <remarks />
    BEFR_LaPosteStandardShipping,
    /// <remarks />
    BEFR_LaPosteCertifiedShipping,
    /// <remarks />
    BEFR_LaPosteTaxipostLLS,
    /// <remarks />
    BEFR_LaPosteTaxipost24h,
    /// <remarks />
    BEFR_LaPosteTaxipostSecur,
    /// <remarks />
    BEFR_PostInternationalStandard,
    /// <remarks />
    BEFR_PostInternationalRegistered,
    /// <remarks />
    BEFR_TNTInternational,
    /// <remarks />
    BEFR_EconomyDeliveryFromAbroad,
    /// <remarks />
    BEFR_StandardDeliveryFromAbroad,
    /// <remarks />
    BEFR_ExpressDeliveryFromAbroad,
    /// <remarks />
    BEFR_TrackedDeliveryFromAbroad,
    /// <remarks />
    BENL_StandardDelivery,
    /// <remarks />
    BENL_PriorityDelivery,
    /// <remarks />
    BENL_ParcelPost,
    /// <remarks />
    BENL_RegisteredMail,
    /// <remarks />
    BENL_Other,
    /// <remarks />
    BENL_DePostInternational,
    /// <remarks />
    BENL_UPSInternational,
    /// <remarks />
    BENL_FedExInternational,
    /// <remarks />
    BENL_DHLInternational,
    /// <remarks />
    BENL_TPGPostTNTInternational,
    /// <remarks />
    BENL_StandardInternational,
    /// <remarks />
    BENL_ExpeditedInternational,
    /// <remarks />
    BENL_OtherInternational,
    /// <remarks />
    BENL_LaPosteInternational,
    /// <remarks />
    BENL_DePostStandardShipping,
    /// <remarks />
    BENL_DePostCertifiedShipping,
    /// <remarks />
    BENL_DePostTaxipostLLS,
    /// <remarks />
    BENL_DePostTaxipost24h,
    /// <remarks />
    BENL_DePostTaxipostSecur,
    /// <remarks />
    BENL_OtherShippingMethods,
    /// <remarks />
    BENL_PostInternationalStandard,
    /// <remarks />
    BENL_PostInternationalRegistered,
    /// <remarks />
    BENL_TNTInternational,
    /// <remarks />
    BENL_EconomyDeliveryFromAbroad,
    /// <remarks />
    BENL_StandardDeliveryFromAbroad,
    /// <remarks />
    BENL_ExpressDeliveryFromAbroad,
    /// <remarks />
    BENL_TrackedDeliveryFromAbroad,
    /// <remarks />
    CA_StandardDelivery,
    /// <remarks />
    CA_ExpeditedDelivery,
    /// <remarks />
    CA_PostLettermail,
    /// <remarks />
    CA_PostRegularParcel,
    /// <remarks />
    CA_PostExpeditedParcel,
    /// <remarks />
    CA_PostXpresspost,
    /// <remarks />
    CA_PostPriorityCourier,
    /// <remarks />
    CanadaPostExpeditedFlatRateBox,
    /// <remarks />
    CA_PostExpeditedFlatRateBox,
    /// <remarks />
    CA_StandardInternational,
    /// <remarks />
    CA_ExpeditedInternational,
    /// <remarks />
    CA_OtherInternational,
    /// <remarks />
    CA_PostExpeditedParcelUSA,
    /// <remarks />
    CA_PostSmallPacketsUSA,
    /// <remarks />
    CA_PostXpresspostUSA,
    /// <remarks />
    CA_PostXpresspostInternational,
    /// <remarks />
    CA_PostInternationalParcelSurface,
    /// <remarks />
    CA_PostInternationalParcelAir,
    /// <remarks />
    CA_SmallPacketsInternational,
    /// <remarks />
    CA_PurolatorInternational,
    /// <remarks />
    CA_PostSmallPacketsUSAGround,
    /// <remarks />
    CA_PostSmallPacketsUSAAir,
    /// <remarks />
    CA_SmallPacketsInternationalGround,
    /// <remarks />
    CA_SmallPacketsInternationalAir,
    /// <remarks />
    CA_PostUSALetterPost,
    /// <remarks />
    CA_PostInternationalLetterPost,
    /// <remarks />
    CA_PostExpeditedFlatRateBoxUSA,
    /// <remarks />
    CA_UPSExpressCanada,
    /// <remarks />
    CA_UPSExpressSaverCanada,
    /// <remarks />
    CA_UPSExpeditedCanada,
    /// <remarks />
    CA_UPSStandardCanada,
    /// <remarks />
    CA_UPSExpressUnitedStates,
    /// <remarks />
    CA_UPSExpeditedUnitedStates,
    /// <remarks />
    CA_UPS3DaySelectUnitedStates,
    /// <remarks />
    CA_UPSStandardUnitedStates,
    /// <remarks />
    CA_UPSWorldWideExpress,
    /// <remarks />
    CA_UPSWorldWideExpedited,
    /// <remarks />
    CA_PriorityWorldwide,
    /// <remarks />
    CanadaPostExpeditedFlatRateBoxUSA,
    /// <remarks />
    CA_PostTrackedPacketsUSA,
    /// <remarks />
    CA_PostTrackedPacketsInternational,
    /// <remarks />
    CA_Freight,
    /// <remarks />
    CH_StandardDispatchAPost,
    /// <remarks />
    CH_StandardDispatchBPost,
    /// <remarks />
    CH_InsuredDispatch,
    /// <remarks />
    CH_Writing,
    /// <remarks />
    CH_COD,
    /// <remarks />
    CH_ExpressOrCourier,
    /// <remarks />
    CH_InsuredExpressOrCourier,
    /// <remarks />
    CH_SpecialDispatch,
    /// <remarks />
    CH_InsuredSpecialDispatch,
    /// <remarks />
    CH_Sonstige,
    /// <remarks />
    CH_SonstigerVersandInternational,
    /// <remarks />
    CH_EconomySendungenInternational,
    /// <remarks />
    CH_PrioritySendungenInternational,
    /// <remarks />
    CH_UrgentSendungenInternational,
    /// <remarks />
    CH_EconomyDeliveryFromAbroad,
    /// <remarks />
    CH_StandardDeliveryFromAbroad,
    /// <remarks />
    CH_ExpressDeliveryFromAbroad,
    /// <remarks />
    CH_TrackedDeliveryFromAbroad,
    /// <remarks />
    CN_PersonalDelivery,
    /// <remarks />
    CN_RegularPackage,
    /// <remarks />
    CN_DeliveryCompanyExpress,
    /// <remarks />
    CN_PostOfficeExpress,
    /// <remarks />
    CN_Others,
    /// <remarks />
    CN_FastPostOffice,
    /// <remarks />
    CN_ExpressDeliverySameCity,
    /// <remarks />
    CN_ExpressDeliveryOtherCities,
    /// <remarks />
    CN_StandardInternational,
    /// <remarks />
    CN_ExpeditedInternational,
    /// <remarks />
    CN_OtherInternational,
    /// <remarks />
    CN_CODInternational,
    /// <remarks />
    CN_StandardMailingInternational,
    /// <remarks />
    CN_RegularLogisticsInternational,
    /// <remarks />
    CN_EMSInternational,
    /// <remarks />
    CN_OthersInternational,
    /// <remarks />
    DE_StandardDispatch,
    /// <remarks />
    DE_InsuredDispatch,
    /// <remarks />
    DE_Writing,
    /// <remarks />
    DE_COD,
    /// <remarks />
    DE_ExpressOrCourier,
    /// <remarks />
    DE_InsuredExpressOrCourier,
    /// <remarks />
    DE_SpecialDispatch,
    /// <remarks />
    DE_InsuredSpecialDispatch,
    /// <remarks />
    DE_UnversicherterVersand,
    /// <remarks />
    DE_DeutschePostBrief,
    /// <remarks />
    DE_eBayDHLPaket24x7,
    /// <remarks />
    DE_DHLPostpaket,
    /// <remarks />
    DE_DHLPackchen,
    /// <remarks />
    DE_DeutschePostWarensendung,
    /// <remarks />
    DE_DeutschePostBuchersendung,
    /// <remarks />
    DE_HermesPaketUnversichert,
    /// <remarks />
    DE_HermesPaketVersichert,
    /// <remarks />
    DE_IloxxTransportXXL,
    /// <remarks />
    DE_IloxxUbernachtExpress,
    /// <remarks />
    DE_IloxxStandard,
    /// <remarks />
    DE_Sonstige,
    /// <remarks />
    DE_UnversicherterVersandInternational,
    /// <remarks />
    DE_VersicherterVersandInternational,
    /// <remarks />
    DE_DHLPostpaketInternational,
    /// <remarks />
    DE_DHLPackchenInternational,
    /// <remarks />
    DE_SonstigerVersandInternational,
    /// <remarks />
    DE_UnversicherterExpressVersandInternational,
    /// <remarks />
    DE_VersicherterExpressVersandInternational,
    /// <remarks />
    DE_DeutschePostBriefLandInternational,
    /// <remarks />
    DE_DeutschePostBriefLuftInternational,
    /// <remarks />
    DE_IloxxEuropaInternational,
    /// <remarks />
    DE_IloxxWorldWideInternational,
    /// <remarks />
    DE_Paket,
    /// <remarks />
    DE_Express,
    /// <remarks />
    DE_DHLPaket,
    /// <remarks />
    DE_DPBuecherWarensendung,
    /// <remarks />
    DE_HermesPaket,
    /// <remarks />
    DE_IloxxTransport,
    /// <remarks />
    DE_SonstigeDomestic,
    /// <remarks />
    DE_Einschreiben,
    /// <remarks />
    DE_Nachname,
    /// <remarks />
    DE_SpecialDelivery,
    /// <remarks />
    DE_UPS,
    /// <remarks />
    DE_DPD,
    /// <remarks />
    DE_GLS,
    /// <remarks />
    DE_PaketInternational,
    /// <remarks />
    DE_DHLPaketInternational,
    /// <remarks />
    DE_DHLPaketIntlExpress,
    /// <remarks />
    DE_SonstigeInternational,
    /// <remarks />
    DE_ExpressInternational,
    /// <remarks />
    DE_DPBriefInternational,
    /// <remarks />
    DE_IloxxTransportInternational,
    /// <remarks />
    DE_HermesPaketInternational,
    /// <remarks />
    DE_UPSInternational,
    /// <remarks />
    DE_DPDInternational,
    /// <remarks />
    DE_GLSInternational,
    /// <remarks />
    DE_eBayHermesPaketShop2ShopKaeufer,
    /// <remarks />
    DE_HermesPaketShop2ShopKaeufer,
    /// <remarks />
    DE_eBayHermesPaketShop2Shop,
    /// <remarks />
    DE_HermesPaketShop2Shop,
    /// <remarks />
    DE_HermesPaketSperrgut,
    /// <remarks />
    DE_eBayHermesPaketSperrgutShop2Shop,
    /// <remarks />
    DE_DHLPaeckchenPackstation,
    /// <remarks />
    DE_DHLPaketPackstation,
    /// <remarks />
    DE_eBayDHLPaeckchen,
    /// <remarks />
    DE_DHLStarPaeckchen,
    /// <remarks />
    DE_TrackedDeliveryFromAbroad,
    /// <remarks />
    ES_CartasNacionalesHasta20,
    /// <remarks />
    ES_CartasNacionalesDeMas20,
    /// <remarks />
    ES_CartasInternacionalesHasta20,
    /// <remarks />
    ES_CartasInternacionalesDeMas20,
    /// <remarks />
    ES_PaqueteAzulHasta2kg,
    /// <remarks />
    ES_PaqueteAzulDeMas2kg,
    /// <remarks />
    ES_PaqueteInternacionalEconomico,
    /// <remarks />
    ES_Urgente,
    /// <remarks />
    ES_Otros,
    /// <remarks />
    ES_StandardInternational,
    /// <remarks />
    ES_ExpeditedInternational,
    /// <remarks />
    ES_OtherInternational,
    /// <remarks />
    ES_CartasPostalInternational,
    /// <remarks />
    ES_EmsPostalExpressInternational,
    /// <remarks />
    ES_EconomyPacketInternational,
    /// <remarks />
    ES_EconomyDeliveryFromAbroad,
    /// <remarks />
    ES_StandardDeliveryFromAbroad,
    /// <remarks />
    ES_ExpressDeliveryFromAbroad,
    /// <remarks />
    ES_TrackedDeliveryFromAbroad,
    /// <remarks />
    ES_ENTREGA_KIALA_8KG,
    /// <remarks />
    FR_ChronoposteInternationalClassic,
    /// <remarks />
    FR_ColiposteColissimoDirect,
    /// <remarks />
    FR_DHLExpressEuropack,
    /// <remarks />
    FR_UPSStandard,
    /// <remarks />
    FR_PostOfficeLetter,
    /// <remarks />
    FR_PostOfficeLetterFollowed,
    /// <remarks />
    FR_PostOfficeLetterRecommended,
    /// <remarks />
    FR_ColiposteColissimo,
    /// <remarks />
    FR_ColiposteColissimoRecommended,
    /// <remarks />
    FR_UPSStandardAgainstRefund,
    /// <remarks />
    FR_Autre,
    /// <remarks />
    FR_Ecopli,
    /// <remarks />
    FR_Colieco,
    /// <remarks />
    FR_AuteModeDenvoiDeColis,
    /// <remarks />
    FR_RemiseEnMainPropre,
    /// <remarks />
    FR_StandardInternational,
    /// <remarks />
    FR_ExpeditedInternational,
    /// <remarks />
    FR_OtherInternational,
    /// <remarks />
    FR_LaPosteInternationalPriorityCourier,
    /// <remarks />
    FR_LaPosteInternationalEconomyCourier,
    /// <remarks />
    FR_LaPosteColissimoInternational,
    /// <remarks />
    FR_LaPosteColisEconomiqueInternational,
    /// <remarks />
    FR_LaPosteColissimoEmballageInternational,
    /// <remarks />
    FR_ChronopostClassicInternational,
    /// <remarks />
    FR_ChronopostPremiumInternational,
    /// <remarks />
    FR_UPSStandardInternational,
    /// <remarks />
    FR_UPSExpressInternational,
    /// <remarks />
    FR_DHLInternational,
    /// <remarks />
    FR_LaPosteLetterMax,
    /// <remarks />
    FR_KIALA_DELIVERY,
    /// <remarks />
    FR_TrackedDeliveryFromAbroad,
    /// <remarks />
    IN_Regular,
    /// <remarks />
    IN_Express,
    /// <remarks />
    IN_NationalCOD,
    /// <remarks />
    IN_Courier,
    /// <remarks />
    IN_LocalCOD,
    /// <remarks />
    IN_StandardInternational,
    /// <remarks />
    IN_ExpeditedInternational,
    /// <remarks />
    IN_OtherInternational,
    /// <remarks />
    IN_FlatRateCOD,
    /// <remarks />
    IN_BuyerPicksUpAndPays,
    /// <remarks />
    IT_RegularMail,
    /// <remarks />
    IT_PriorityMail,
    /// <remarks />
    IT_MailRegisteredLetter,
    /// <remarks />
    IT_MailRegisteredLetterWithMark,
    /// <remarks />
    IT_InsuredMail,
    /// <remarks />
    IT_QuickMail,
    /// <remarks />
    IT_RegularPackage,
    /// <remarks />
    IT_QuickPackage1,
    /// <remarks />
    IT_QuickPackage3,
    /// <remarks />
    IT_ExpressCourier,
    /// <remarks />
    IT_ExpressPackageMaxi,
    /// <remarks />
    IT_StandardInternational,
    /// <remarks />
    IT_ExpeditedInternational,
    /// <remarks />
    IT_OtherInternational,
    /// <remarks />
    IT_TrackedDeliveryFromAbroad,
    /// <remarks />
    NL_StandardDelivery,
    /// <remarks />
    NL_ParcelPost,
    /// <remarks />
    NL_RegisteredMail,
    /// <remarks />
    NL_Other,
    /// <remarks />
    NL_TPGPostTNTInternational,
    /// <remarks />
    NL_UPSInternational,
    /// <remarks />
    NL_FedExInternational,
    /// <remarks />
    NL_DHLInternational,
    /// <remarks />
    NL_DPDGBRInternational,
    /// <remarks />
    NL_GLSBusinessInternational,
    /// <remarks />
    NL_StandardInternational,
    /// <remarks />
    NL_ExpeditedInternational,
    /// <remarks />
    NL_OtherInternational,
    /// <remarks />
    NL_EconomyDeliveryFromAbroad,
    /// <remarks />
    NL_StandardDeliveryFromAbroad,
    /// <remarks />
    NL_ExpressDeliveryFromAbroad,
    /// <remarks />
    NL_TrackedDeliveryFromAbroad,
    /// <remarks />
    TW_RegisteredMail,
    /// <remarks />
    TW_UnregisteredMail,
    /// <remarks />
    TW_COD,
    /// <remarks />
    TW_DwellingMatchPost,
    /// <remarks />
    TW_DwellingMatchCOD,
    /// <remarks />
    TW_SelfPickup,
    /// <remarks />
    TW_ParcelPost,
    /// <remarks />
    TW_ExpressMail,
    /// <remarks />
    TW_Other,
    /// <remarks />
    TW_CPInternationalLetterPost,
    /// <remarks />
    TW_CPInternationalParcelPost,
    /// <remarks />
    TW_CPInternationalRegisteredLetterPost,
    /// <remarks />
    TW_CPInternationalRegisteredParcelPost,
    /// <remarks />
    TW_CPInternationalEMS,
    /// <remarks />
    TW_CPInternationalOceanShippingParcel,
    /// <remarks />
    TW_FedExInternationalPriority,
    /// <remarks />
    TW_FedExInternationalEconomy,
    /// <remarks />
    TW_UPSWorldwideExpedited,
    /// <remarks />
    TW_UPSWorldwideExpress,
    /// <remarks />
    TW_UPSWorldwideExpressPlus,
    /// <remarks />
    TW_OtherInternational,
    /// <remarks />
    UK_RoyalMailFirstClassStandard,
    /// <remarks />
    UK_RoyalMailSecondClassStandard,
    /// <remarks />
    UK_RoyalMailFirstClassRecorded,
    /// <remarks />
    UK_RoyalMailSecondClassRecorded,
    /// <remarks />
    UK_RoyalMailSpecialDelivery,
    /// <remarks />
    UK_RoyalMailStandardParcel,
    /// <remarks />
    UK_Parcelforce24,
    /// <remarks />
    UK_Parcelforce48,
    /// <remarks />
    UK_OtherCourier,
    /// <remarks />
    UK_myHermesDoorToDoorService,
    /// <remarks />
    UK_CollectDropAtStoreDeliveryToDoor,
    /// <remarks />
    UK_SellersStandardRate,
    /// <remarks />
    UK_CollectInPerson,
    /// <remarks />
    UK_SellersStandardInternationalRate,
    /// <remarks />
    UK_RoyalMailAirmailInternational,
    /// <remarks />
    UK_RoyalMailAirsureInternational,
    /// <remarks />
    UK_RoyalMailSurfaceMailInternational,
    /// <remarks />
    UK_RoyalMailInternationalSignedFor,
    /// <remarks />
    UK_RoyalMailHMForcesMailInternational,
    /// <remarks />
    UK_ParcelForceInternationalDatapost,
    /// <remarks />
    UK_ParcelForceIreland24International,
    /// <remarks />
    UK_ParcelForceEuro48International,
    /// <remarks />
    UK_ParcelForceInternationalScheduled,
    /// <remarks />
    UK_OtherCourierOrDeliveryInternational,
    /// <remarks />
    UK_CollectInPersonInternational,
    /// <remarks />
    UK_ParcelForceIntlExpress,
    /// <remarks />
    UK_ParcelForceIntlValue,
    /// <remarks />
    UK_ParcelForceIntlEconomy,
    /// <remarks />
    UK_TrackedDeliveryFromAbroad,
    /// <remarks />
    UK_IntlTrackedPostage,
    /// <remarks />
    IE_SellersStandardRate,
    /// <remarks />
    IE_FirstClassLetterService,
    /// <remarks />
    IE_SwiftPostNational,
    /// <remarks />
    IE_RegisteredPost,
    /// <remarks />
    IE_EMSSDSCourier,
    /// <remarks />
    IE_EconomySDSCourier,
    /// <remarks />
    IE_OtherCourier,
    /// <remarks />
    IE_CollectionInPerson,
    /// <remarks />
    IE_SellersStandardRateInternational,
    /// <remarks />
    IE_InternationalEconomyService,
    /// <remarks />
    IE_InternationalPriorityService,
    /// <remarks />
    IE_SwiftPostExpressInternational,
    /// <remarks />
    IE_SwiftPostInternational,
    /// <remarks />
    IE_EMSSDSCourierInternational,
    /// <remarks />
    IE_EconomySDSCourierInternational,
    /// <remarks />
    IE_OtherCourierInternational,
    /// <remarks />
    IE_CollectionInPersonInternational,
    /// <remarks />
    IE_EconomyDeliveryFromAbroad,
    /// <remarks />
    IE_StandardDeliveryFromAbroad,
    /// <remarks />
    IE_ExpressDeliveryFromAbroad,
    /// <remarks />
    IE_TrackedDeliveryFromAbroad,
    /// <remarks />
    PL_DomesticRegular,
    /// <remarks />
    PL_DomesticSpecial,
    /// <remarks />
    PL_EconomyDeliveryFromAbroad,
    /// <remarks />
    PL_StandardDeliveryFromAbroad,
    /// <remarks />
    PL_ExpressDeliveryFromAbroad,
    /// <remarks />
    PL_TrackedDeliveryFromAbroad,
    /// <remarks />
    FreightShipping,
    /// <remarks />
    FreightOtherShipping,
    /// <remarks />
    Freight,
    /// <remarks />
    FreightShippingInternational,
    /// <remarks />
    USPSGround,
    /// <remarks />
    ShippingMethodOvernight,
    /// <remarks />
    CustomCode,
    /// <remarks />
    USPSPriorityFlatRateEnvelope,
    /// <remarks />
    USPSPriorityFlatRateBox,
    /// <remarks />
    USPSGlobalPrioritySmallEnvelope,
    /// <remarks />
    USPSGlobalPriorityLargeEnvelope,
    /// <remarks />
    USPSExpressFlatRateEnvelope,
    /// <remarks />
    UPSWorldWideExpressBox10kg,
    /// <remarks />
    UPSWorldWideExpressBox25kg,
    /// <remarks />
    UPSWorldWideExpressPlusBox10kg,
    /// <remarks />
    UPSWorldWideExpressPlusBox25kg,
    /// <remarks />
    HK_LocalPickUpOnly,
    /// <remarks />
    HK_LocalCourier,
    /// <remarks />
    HK_DomesticRegularShipping,
    /// <remarks />
    HK_DomesticSpecialShipping,
    /// <remarks />
    HK_InternationalRegularShipping,
    /// <remarks />
    HK_InternationalSpecialShipping,
    /// <remarks />
    SG_LocalPickUpOnly,
    /// <remarks />
    SG_LocalCourier,
    /// <remarks />
    SG_DomesticStandardMail,
    /// <remarks />
    SG_DomesticNonStandardMail,
    /// <remarks />
    SG_DomesticSpeedpostIslandwide,
    /// <remarks />
    SG_InternationalStandardMail,
    /// <remarks />
    SG_InternationalExpressMailService,
    /// <remarks />
    SG_InternationalCourier,
    /// <remarks />
    BENL_DePostZendingNONPRIOR,
    /// <remarks />
    BENL_DePostZendingPRIOR,
    /// <remarks />
    BENL_DePostZendingAangetekend,
    /// <remarks />
    BENL_KilopostPakje,
    /// <remarks />
    BENL_Taxipost,
    /// <remarks />
    BENL_KialaAfhaalpunt,
    /// <remarks />
    BENL_VasteKostenStandaardVerzending,
    /// <remarks />
    BENL_VasteKostenVersneldeVerzending,
    /// <remarks />
    BENL_VerzekerdeVerzending,
    /// <remarks />
    BEFR_LaPosteEnvoiNONPRIOR,
    /// <remarks />
    BEFR_LaPosteEnvoiPRIOR,
    /// <remarks />
    BEFR_LaPosteEnvoiRecommande,
    /// <remarks />
    BEFR_PaquetKilopost,
    /// <remarks />
    BEFR_Taxipost,
    /// <remarks />
    BEFR_PointRetraitKiala,
    /// <remarks />
    BEFR_LivraisonStandardPrixforFaitaire,
    /// <remarks />
    BEFR_LivraisonExpressPrixforFaitaire,
    /// <remarks />
    BEFR_LivraisonSecurise,
    /// <remarks />
    BENL_DePostZendingPRIORInternational,
    /// <remarks />
    BENL_DePostZendingNONPRIORInternational,
    /// <remarks />
    BENL_DePostZendingAangetekendInternational,
    /// <remarks />
    BENL_KilopostPakjeInternational,
    /// <remarks />
    BENL_TaxipostExpressverzending,
    /// <remarks />
    BENL_VerzekerdeVerzendingInternational,
    /// <remarks />
    BEFR_LaPosteenvoiePRIOR,
    /// <remarks />
    BEFR_LaPosteenvoieNONPRIOR,
    /// <remarks />
    BEFR_LaPosteenvoieRecommande,
    /// <remarks />
    BEFR_PaquetKilopostInternationale,
    /// <remarks />
    BEFR_ExpressTaxipost,
    /// <remarks />
    BEFR_LivraisonStandardInternationalePrixforFaitaire,
    /// <remarks />
    BEFR_LivraisonExpressInternationalePrixforFaitaire,
    /// <remarks />
    BEFR_LivraisonSecuriseInternational,
    /// <remarks />
    FR_Chronopost,
    /// <remarks />
    UK_RoyalMailSpecialDeliveryNextDay,
    /// <remarks />
    CA_PostLightPacketInternational,
    /// <remarks />
    CA_PostLightPacketUSA,
    /// <remarks />
    PL_DHLInternational,
    /// <remarks />
    PL_InternationalRegular,
    /// <remarks />
    PL_InternationalSpecial,
    /// <remarks />
    PL_UPSInternational,
    /// <remarks />
    CAFR_StandardDelivery,
    /// <remarks />
    CAFR_ExpeditedDelivery,
    /// <remarks />
    CAFR_PostLettermail,
    /// <remarks />
    CAFR_PostRegularParcel,
    /// <remarks />
    CAFR_PostExpeditedParcel,
    /// <remarks />
    CAFR_PostXpresspost,
    /// <remarks />
    CAFR_PostPriorityCourier,
    /// <remarks />
    CAFR_StandardInternational,
    /// <remarks />
    CAFR_ExpeditedInternational,
    /// <remarks />
    CAFR_OtherInternational,
    /// <remarks />
    CAFR_PostExpeditedParcelUSA,
    /// <remarks />
    CAFR_PostSmallPacketsUSA,
    /// <remarks />
    CAFR_PostXpresspostUSA,
    /// <remarks />
    CAFR_PostXpresspostInternational,
    /// <remarks />
    CAFR_PostInternationalParcelSurface,
    /// <remarks />
    CAFR_PostInternationalParcelAir,
    /// <remarks />
    CAFR_SmallPacketsInternational,
    /// <remarks />
    CAFR_PurolatorInternational,
    /// <remarks />
    CAFR_PostSmallPacketsUSAGround,
    /// <remarks />
    CAFR_PostSmallPacketsUSAAir,
    /// <remarks />
    CAFR_SmallPacketsInternationalGround,
    /// <remarks />
    CAFR_SmallPacketsInternationalAir,
    /// <remarks />
    CAFR_PostUSALetterPost,
    /// <remarks />
    CAFR_PostInternationalLetterPost,
    /// <remarks />
    CAFR_UPSExpressCanada,
    /// <remarks />
    CAFR_UPSExpressSaverCanada,
    /// <remarks />
    CAFR_UPSExpeditedCanada,
    /// <remarks />
    CAFR_UPSStandardCanada,
    /// <remarks />
    CAFR_UPSExpressUnitedStates,
    /// <remarks />
    CAFR_UPSExpeditedUnitedStates,
    /// <remarks />
    CAFR_UPS3DaySelectUnitedStates,
    /// <remarks />
    CAFR_UPSStandardUnitedStates,
    /// <remarks />
    CAFR_UPSWorldWideExpress,
    /// <remarks />
    CAFR_UPSWorldWideExpedited,
    /// <remarks />
    UK_RoyalMailSpecialDelivery9am,
    /// <remarks />
    USPSFirstClassMailInternational,
    /// <remarks />
    USPSPriorityMailInternational,
    /// <remarks />
    USPSExpressMailInternational,
    /// <remarks />
    CH_StandardInternational,
    /// <remarks />
    CH_ExpeditedInternational,
    /// <remarks />
    CH_SonstigerVersandSieheArtikelbeschreibung,
    /// <remarks />
    TW_StandardInternationalFixedRate,
    /// <remarks />
    TW_ExpeditedInternationalFixedRate,
    /// <remarks />
    USPSGlobalExpressGuaranteed,
    /// <remarks />
    AU_RegularWithInsurance,
    /// <remarks />
    AU_ExpressWithInsurance,
    /// <remarks />
    DE_DeutschePostWarensendungInternational,
    /// <remarks />
    DE_DeutschePostByendung,
    /// <remarks />
    DE_HermesPaketUnversichertInternational,
    /// <remarks />
    DE_HermesPaketVersichertInternational,
    /// <remarks />
    DE_iLoxxTransportXXLInternational,
    /// <remarks />
    DE_iLoxxUbernachtExpressInternational,
    /// <remarks />
    DE_iLoxxStandardInternational,
    /// <remarks />
    DE_StandardInternational,
    /// <remarks />
    DE_ExpeditedInternational,
    /// <remarks />
    DE_DeutschePostBriefIntlEcon,
    /// <remarks />
    DE_DeutschePostBriefIntlPri,
    /// <remarks />
    AT_BitteTreffenSieEineAuswahl,
    /// <remarks />
    AT_EinschreibenVersandInklEinschreibengebuhr,
    /// <remarks />
    AT_NachnahmeVersandInklNachnahmegebuhr,
    /// <remarks />
    AT_ExpressOrCourierInternational,
    /// <remarks />
    AT_InsuredExpressOrCourierInternational,
    /// <remarks />
    AT_SpecialDispatchInternational,
    /// <remarks />
    AT_InsuredSpecialDispatchInternational,
    /// <remarks />
    AT_StandardInternational,
    /// <remarks />
    AT_ExpeditedInternational,
    /// <remarks />
    AT_OtherInternationalShipping,
    /// <remarks />
    CH_BitteTreffenSieEineAuswahl,
    /// <remarks />
    CH_UnversicherterVersand,
    /// <remarks />
    CH_VersicherterVersand,
    /// <remarks />
    CH_EinschreibenVersandInklEinschreibengebuhr,
    /// <remarks />
    CH_NachnahmeVersandInklNachnahmegebuhr,
    /// <remarks />
    CH_ExpressOrCourierInternational,
    /// <remarks />
    CH_InsuredExpressOrCourierInternational,
    /// <remarks />
    CH_SonderversandZBSperrgutKFZ,
    /// <remarks />
    CH_VersicherterSonderversandZBSperrgutKFZ,
    /// <remarks />
    CH_StandardversandAPostPriority,
    /// <remarks />
    CH_StandardversandBPostEconomy,
    /// <remarks />
    DE_BitteTreffenSieEineAuswahl,
    /// <remarks />
    DE_EinschreibenVersandInklEinschreibengebuhr,
    /// <remarks />
    DE_NachnahmeVersandInklNachnahmegebuhr,
    /// <remarks />
    DE_ExpressOrCourierInternational,
    /// <remarks />
    DE_InsuredExpressOrCourierInternational,
    /// <remarks />
    DE_SonderversandZBMobelKFZ,
    /// <remarks />
    DE_VersicherterSonderversandZBMobelKFZ,
    /// <remarks />
    DE_DeutschePostBriefInternational,
    /// <remarks />
    IE_StandardInternationalFlatRatePostage,
    /// <remarks />
    IE_ExpeditedInternationalFlatRatePostage,
    /// <remarks />
    IE_OtherInternationalPostage,
    /// <remarks />
    UK_StandardInternationalFlatRatePostage,
    /// <remarks />
    UK_ExpeditedInternationalFlatRatePostage,
    /// <remarks />
    UK_OtherInternationalPostage,
    /// <remarks />
    FR_ChronopostChronoRelais,
    /// <remarks />
    FR_Chrono10,
    /// <remarks />
    FR_Chrono13,
    /// <remarks />
    FR_Chrono18,
    /// <remarks />
    FR_ChronopostExpressInternational,
    /// <remarks />
    Pickup,
    /// <remarks />
    Delivery,
    /// <remarks />
    CA_Pickup,
    /// <remarks />
    DE_Pickup,
    /// <remarks />
    AU_Pickup,
    /// <remarks />
    AU_SmallParcels,
    /// <remarks />
    AU_SmallParcelWithTracking,
    /// <remarks />
    AU_SmallParcelWithTrackingAndSignature,
    /// <remarks />
    AU_RegularParcelWithTracking,
    /// <remarks />
    AU_RegularParcelWithTrackingAndSignature,
    /// <remarks />
    AU_PrePaidExpressPostSatchel5kg,
    /// <remarks />
    AU_PrePaidParcelPostSatchels500g,
    /// <remarks />
    AU_PrePaidParcelPostSatchels3kg,
    /// <remarks />
    AU_PrePaidParcelPostSatchels5kg,
    /// <remarks />
    AU_PrePaidExpressPostSatchel500g,
    /// <remarks />
    AU_PrePaidExpressPostSatchel3kg,
    /// <remarks />
    AU_PrePaidExpressPostPlatinum500g,
    /// <remarks />
    AU_PrePaidExpressPostPlatinum3kg,
    /// <remarks />
    AU_ExpressCourierInternational,
    /// <remarks />
    AU_ExpressPostInternational,
    /// <remarks />
    AU_PrePaidExpressPostInternationalEnvelopeC5,
    /// <remarks />
    AU_PrePaidExpressPostInternationalEnvelopeB4,
    /// <remarks />
    AU_PrePaidExpressPostInternationalSatchels2kg,
    /// <remarks />
    AU_PrePaidExpressPostInternationalSatchels3kg,
    /// <remarks />
    AU_PrePaidExpressPostInternationalBox5kg,
    /// <remarks />
    AU_PrePaidExpressPostInternationalBox10kg,
    /// <remarks />
    AU_PrePaidExpressPostInternationalBox20kg,
    /// <remarks />
    AU_RegisteredParcelPost,
    /// <remarks />
    AU_RegisteredSmallParcel,
    /// <remarks />
    AU_RegisteredParcelPostPrepaidSatchel500g,
    /// <remarks />
    AU_RegisteredParcelPostPrepaidSatchel3kg,
    /// <remarks />
    AU_RegisteredParcelPostPrepaidSatchel5kg,
    /// <remarks />
    AU_ExpressPostSatchel500g,
    /// <remarks />
    AU_ExpressPostSatchel3kg,
    /// <remarks />
    FR_Pickup,
    /// <remarks />
    AT_Pickup,
    /// <remarks />
    BENL_Pickup,
    /// <remarks />
    BEFR_Pickup,
    /// <remarks />
    CH_Pickup,
    /// <remarks />
    IT_Pickup,
    /// <remarks />
    NL_Pickup,
    /// <remarks />
    PL_Pickup,
    /// <remarks />
    ES_Pickup,
    /// <remarks />
    SG_Delivery,
    /// <remarks />
    UK_OtherCourier24,
    /// <remarks />
    UK_OtherCourier48,
    /// <remarks />
    UK_OtherCourier3Days,
    /// <remarks />
    UK_OtherCourier5Days,
    /// <remarks />
    Courier,
    /// <remarks />
    FedExPriorityOvernight,
    /// <remarks />
    FedExStandardOvernight,
    /// <remarks />
    FedEx2Day,
    /// <remarks />
    FedExGround,
    /// <remarks />
    FedExHomeDelivery,
    /// <remarks />
    FedExExpressSaver,
    /// <remarks />
    FedExGroundDisabled,
    /// <remarks />
    FedExHomeDeliveryDisabled,
    /// <remarks />
    FedExInternationalFirst,
    /// <remarks />
    FedExInternationalPriority,
    /// <remarks />
    FedExInternationalEconomy,
    /// <remarks />
    FedExInternationalGround,
    /// <remarks />
    EconomyShippingFromOutsideUS,
    /// <remarks />
    ExpeditedShippingFromOutsideUS,
    /// <remarks />
    StandardShippingFromOutsideUS,
    /// <remarks />
    UK_EconomyShippingFromOutside,
    /// <remarks />
    UK_ExpeditedShippingFromOutside,
    /// <remarks />
    UK_StandardShippingFromOutside,
    /// <remarks />
    DE_SparversandAusDemAusland,
    /// <remarks />
    DE_StandardversandAusDemAusland,
    /// <remarks />
    DE_ExpressversandAusDemAusland,
    /// <remarks />
    DE_DHL2KGPaket,
    /// <remarks />
    InternationalPriorityShipping,
    /// <remarks />
    SameDayShipping,
    /// <remarks />
    UK_RoyalMailNextDay,
    /// <remarks />
    UK_RoyalMailTracked,
    /// <remarks />
    eBayNowImmediateDelivery,
  }
}
