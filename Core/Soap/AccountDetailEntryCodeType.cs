// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AccountDetailEntryCodeType
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
  public enum AccountDetailEntryCodeType
  {
    /// <remarks />
    Unknown,
    /// <remarks />
    FeeInsertion,
    /// <remarks />
    FeeBold,
    /// <remarks />
    FeeFeatured,
    /// <remarks />
    FeeCategoryFeatured,
    /// <remarks />
    FeeFinalValue,
    /// <remarks />
    PaymentCheck,
    /// <remarks />
    PaymentCC,
    /// <remarks />
    CreditCourtesy,
    /// <remarks />
    CreditNoSale,
    /// <remarks />
    CreditPartialSale,
    /// <remarks />
    RefundCC,
    /// <remarks />
    RefundCheck,
    /// <remarks />
    FinanceCharge,
    /// <remarks />
    AWDebit,
    /// <remarks />
    AWCredit,
    /// <remarks />
    AWMemo,
    /// <remarks />
    CreditDuplicateListing,
    /// <remarks />
    FeePartialSale,
    /// <remarks />
    PaymentElectronicTransferReversal,
    /// <remarks />
    PaymentCCOnce,
    /// <remarks />
    FeeReturnedCheck,
    /// <remarks />
    FeeRedepositCheck,
    /// <remarks />
    PaymentCash,
    /// <remarks />
    CreditInsertion,
    /// <remarks />
    CreditBold,
    /// <remarks />
    CreditFeatured,
    /// <remarks />
    CreditCategoryFeatured,
    /// <remarks />
    CreditFinalValue,
    /// <remarks />
    FeeNSFCheck,
    /// <remarks />
    FeeReturnCheckClose,
    /// <remarks />
    Memo,
    /// <remarks />
    PaymentMoneyOrder,
    /// <remarks />
    CreditCardOnFile,
    /// <remarks />
    CreditCardNotOnFile,
    /// <remarks />
    Invoiced,
    /// <remarks />
    InvoicedCreditCard,
    /// <remarks />
    CreditTransferFrom,
    /// <remarks />
    DebitTransferTo,
    /// <remarks />
    InvoiceCreditBalance,
    /// <remarks />
    eBayDebit,
    /// <remarks />
    eBayCredit,
    /// <remarks />
    PromotionalCredit,
    /// <remarks />
    CCNotOnFilePerCustReq,
    /// <remarks />
    CreditInsertionFee,
    /// <remarks />
    CCPaymentRejected,
    /// <remarks />
    FeeGiftIcon,
    /// <remarks />
    CreditGiftIcon,
    /// <remarks />
    FeeGallery,
    /// <remarks />
    FeeFeaturedGallery,
    /// <remarks />
    CreditGallery,
    /// <remarks />
    CreditFeaturedGallery,
    /// <remarks />
    ItemMoveFee,
    /// <remarks />
    OutageCredit,
    /// <remarks />
    CreditPSA,
    /// <remarks />
    CreditPCGS,
    /// <remarks />
    FeeReserve,
    /// <remarks />
    CreditReserve,
    /// <remarks />
    eBayVISACredit,
    /// <remarks />
    BBAdminCredit,
    /// <remarks />
    BBAdminDebit,
    /// <remarks />
    ReferrerCredit,
    /// <remarks />
    ReferrerDebit,
    /// <remarks />
    SwitchCurrency,
    /// <remarks />
    PaymentGiftCertificate,
    /// <remarks />
    PaymentWireTransfer,
    /// <remarks />
    PaymentHomeBanking,
    /// <remarks />
    PaymentElectronicTransfer,
    /// <remarks />
    PaymentAdjustmentCredit,
    /// <remarks />
    PaymentAdjustmentDebit,
    /// <remarks />
    Chargeoff,
    /// <remarks />
    ChargeoffRecovery,
    /// <remarks />
    ChargeoffBankruptcy,
    /// <remarks />
    ChargeoffSuspended,
    /// <remarks />
    ChargeoffDeceased,
    /// <remarks />
    ChargeoffOther,
    /// <remarks />
    ChargeoffWacko,
    /// <remarks />
    FinanceChargeReversal,
    /// <remarks />
    FVFCreditReversal,
    /// <remarks />
    ForeignFundsConvert,
    /// <remarks />
    ForeignFundsCheckReversal,
    /// <remarks />
    EOMRestriction,
    /// <remarks />
    AllFeesCredit,
    /// <remarks />
    SetOnHold,
    /// <remarks />
    RevertUserState,
    /// <remarks />
    DirectDebitOnFile,
    /// <remarks />
    DirectDebitNotOnFile,
    /// <remarks />
    PaymentDirectDebit,
    /// <remarks />
    DirectDebitReversal,
    /// <remarks />
    DirectDebitReturnedItem,
    /// <remarks />
    FeeHighlight,
    /// <remarks />
    CreditHighlight,
    /// <remarks />
    BulkUserSuspension,
    /// <remarks />
    FeeRealEstate30DaysListing,
    /// <remarks />
    CreditRealEstate30DaysListing,
    /// <remarks />
    TradingLimitOverrideOn,
    /// <remarks />
    TradingLimitOverrideOff,
    /// <remarks />
    EquifaxRealtimeFee,
    /// <remarks />
    CreditEquifaxRealtimeFee,
    /// <remarks />
    PaymentEquifaxDebit,
    /// <remarks />
    PaymentEquifaxCredit,
    /// <remarks />
    Merged,
    /// <remarks />
    AutoTraderOn,
    /// <remarks />
    AutoTraderOff,
    /// <remarks />
    PaperInvoiceOn,
    /// <remarks />
    PaperInvoiceOff,
    /// <remarks />
    AccountStateSwitch,
    /// <remarks />
    FVFCreditReversalAutomatic,
    /// <remarks />
    CreditSoftOutage,
    /// <remarks />
    LACatalogFee,
    /// <remarks />
    LAExtraItem,
    /// <remarks />
    LACatalogItemFeeRefund,
    /// <remarks />
    LACatalogInsertionRefund,
    /// <remarks />
    LAFinalValueFee,
    /// <remarks />
    LAFinalValueFeeRefund,
    /// <remarks />
    LABuyerPremiumPercentageFee,
    /// <remarks />
    LABuyerPremiumPercentageFeeRefund,
    /// <remarks />
    LAAudioVideoFee,
    /// <remarks />
    LAAudioVideoFeeRefund,
    /// <remarks />
    FeeIPIXPhoto,
    /// <remarks />
    FeeIPIXSlideShow,
    /// <remarks />
    CreditIPIXPhoto,
    /// <remarks />
    CreditIPIXSlideShow,
    /// <remarks />
    FeeTenDayAuction,
    /// <remarks />
    CreditTenDayAuction,
    /// <remarks />
    TemporaryCredit,
    /// <remarks />
    TemporaryCreditReversal,
    /// <remarks />
    SubscriptionAABasic,
    /// <remarks />
    SubscriptionAAPro,
    /// <remarks />
    CreditAABasic,
    /// <remarks />
    CreditAAPro,
    /// <remarks />
    FeeLargePicture,
    /// <remarks />
    CreditLargePicture,
    /// <remarks />
    FeePicturePack,
    /// <remarks />
    CreditPicturePackPartial,
    /// <remarks />
    CreditPicturePackFull,
    /// <remarks />
    SubscriptioneBayStores,
    /// <remarks />
    CrediteBayStores,
    /// <remarks />
    FeeInsertionFixedPrice,
    /// <remarks />
    CreditInsertionFixedPrice,
    /// <remarks />
    FeeFinalValueFixedPrice,
    /// <remarks />
    CreditFinalValueFixedPrice,
    /// <remarks />
    ElectronicInvoiceOn,
    /// <remarks />
    ElectronicInvoiceOff,
    /// <remarks />
    FlagDDDDPending,
    /// <remarks />
    FlagDDPaymentConfirmed,
    /// <remarks />
    FixedPriceDurationFee,
    /// <remarks />
    FixedPriceDurationCredit,
    /// <remarks />
    BuyItNowFee,
    /// <remarks />
    BuyItNowCredit,
    /// <remarks />
    FeeSchedule,
    /// <remarks />
    CreditSchedule,
    /// <remarks />
    SubscriptionSMBasic,
    /// <remarks />
    SubscriptionSMBasicPro,
    /// <remarks />
    CreditSMBasic,
    /// <remarks />
    CreditSMBasicPro,
    /// <remarks />
    StoresGTCFee,
    /// <remarks />
    StoresGTCCredit,
    /// <remarks />
    ListingDesignerFee,
    /// <remarks />
    ListingDesignerCredit,
    /// <remarks />
    ExtendedAuctionFee,
    /// <remarks />
    ExtendedAcutionCredit,
    /// <remarks />
    PayPalOTPSucc,
    /// <remarks />
    PayPalOTPPend,
    /// <remarks />
    PayPalFailed,
    /// <remarks />
    PayPalChargeBack,
    /// <remarks />
    ChargeBack,
    /// <remarks />
    ChargeBackReversal,
    /// <remarks />
    PayPalRefund,
    /// <remarks />
    BonusPointsAddition,
    /// <remarks />
    BonusPointsReduction,
    /// <remarks />
    BonusPointsPaymentAutomatic,
    /// <remarks />
    BonusPointsPaymentManual,
    /// <remarks />
    BonusPointsPaymentReversal,
    /// <remarks />
    BonusPointsCashPayout,
    /// <remarks />
    VATCredit,
    /// <remarks />
    VATDebit,
    /// <remarks />
    VATStatusChangePending,
    /// <remarks />
    VATStatusChangeApproved,
    /// <remarks />
    VATStatusChange_Denied,
    /// <remarks />
    VATStatusDeletedByCSR,
    /// <remarks />
    VATStatusDeletedByUser,
    /// <remarks />
    SMProListingDesignerFee,
    /// <remarks />
    SMProListingDesignerCredit,
    /// <remarks />
    StoresSuccessfulListingFee,
    /// <remarks />
    StoresSuccessfulListingFeeCredit,
    /// <remarks />
    StoresReferralFee,
    /// <remarks />
    StoresReferralCredit,
    /// <remarks />
    SubtitleFee,
    /// <remarks />
    SubtitleFeeCredit,
    /// <remarks />
    eBayStoreInventorySubscriptionCredit,
    /// <remarks />
    AutoPmntReqExempt,
    /// <remarks />
    AutoPmntReqRein,
    /// <remarks />
    PictureManagerSubscriptionFee,
    /// <remarks />
    PictureManagerSubscriptionFeeCredit,
    /// <remarks />
    SellerReportsBasicFee,
    /// <remarks />
    SellerReportsBasicCredit,
    /// <remarks />
    SellerReportsPlusFee,
    /// <remarks />
    SellerReportsPlusCredit,
    /// <remarks />
    PaypalOnFile,
    /// <remarks />
    PaypalOnFileByCSR,
    /// <remarks />
    PaypalOffFile,
    /// <remarks />
    BorderFee,
    /// <remarks />
    BorderFeeCredit,
    /// <remarks />
    FeeSearchableMobileDE,
    /// <remarks />
    SalesReportsPlusFee,
    /// <remarks />
    SalesReportsPlusCredit,
    /// <remarks />
    CreditSearchableMobileDE,
    /// <remarks />
    EmailMarketingFee,
    /// <remarks />
    EmailMarketingCredit,
    /// <remarks />
    FeePictureShow,
    /// <remarks />
    CreditPictureShow,
    /// <remarks />
    ProPackBundleFee,
    /// <remarks />
    ProPackBundleFeeCredit,
    /// <remarks />
    BasicUpgradePackBundleFee,
    /// <remarks />
    BasicUpgradePackBundleFeeCredit,
    /// <remarks />
    ValuePackBundleFee,
    /// <remarks />
    ValuePackBundleFeeCredit,
    /// <remarks />
    ProPackPlusBundleFee,
    /// <remarks />
    ProPackPlusBundleFeeCredit,
    /// <remarks />
    FinalEntry,
    /// <remarks />
    CustomCode,
    /// <remarks />
    ExtendedDurationFee,
    /// <remarks />
    ExtendedDurationFeeCredit,
    /// <remarks />
    InternationalListingFee,
    /// <remarks />
    InternationalListingCredit,
    /// <remarks />
    MarketplaceResearchExpiredSubscriptionFee,
    /// <remarks />
    MarketplaceResearchExpiredSubscriptionFeeCredit,
    /// <remarks />
    MarketplaceResearchBasicSubscriptionFee,
    /// <remarks />
    MarketplaceResearchBasicSubscriptionFeeCredit,
    /// <remarks />
    MarketplaceResearchProSubscriptionFee,
    /// <remarks />
    BasicBundleFee,
    /// <remarks />
    BasicBundleFeeCredit,
    /// <remarks />
    MarketplaceResearchProSubscriptionFeeCredit,
    /// <remarks />
    VehicleLocalSubscriptionFee,
    /// <remarks />
    VehicleLocalSubscriptionFeeCredit,
    /// <remarks />
    VehicleLocalInsertionFee,
    /// <remarks />
    VehicleLocalInsertionFeeCredit,
    /// <remarks />
    VehicleLocalFinalValueFee,
    /// <remarks />
    VehicleLocalFinalValueFeeCredit,
    /// <remarks />
    VehicleLocalGTCFee,
    /// <remarks />
    VehicleLocalGTCFeeCredit,
    /// <remarks />
    eBayMotorsProFee,
    /// <remarks />
    CrediteBayMotorsProFee,
    /// <remarks />
    eBayMotorsProFeatureFee,
    /// <remarks />
    CrediteBayMotorsProFeatureFee,
    /// <remarks />
    FeeGalleryPlus,
    /// <remarks />
    CreditGalleryPlus,
    /// <remarks />
    PrivateListing,
    /// <remarks />
    CreditPrivateListing,
    /// <remarks />
    ImmoProFee,
    /// <remarks />
    CreditImmoProFee,
    /// <remarks />
    ImmoProFeatureFee,
    /// <remarks />
    CreditImmoProFeatureFee,
    /// <remarks />
    RealEstateProFee,
    /// <remarks />
    CreditRealEstateProFee,
    /// <remarks />
    RealEstateProFeatureFee,
    /// <remarks />
    CreditRealEstateProFeatureFee,
    /// <remarks />
    Discount,
    /// <remarks />
    CreditFinalValueShipping,
    /// <remarks />
    FeeFinalValueShipping,
    /// <remarks />
    FeeReturnShipping,
    /// <remarks />
    CreditReturnShipping,
    /// <remarks />
    FeeGlobalShippingProgram,
    /// <remarks />
    CreditGlobalShippingProgram,
    /// <remarks />
    FeeAuctionEndEarly,
    /// <remarks />
    CreditAuctionEndEarly,
    /// <remarks />
    FeeFedExShippingLabel,
    /// <remarks />
    CreditFedExShippingLabel,
    /// <remarks />
    FeeReturnRefund,
    /// <remarks />
    CreditReturnRefund,
    /// <remarks />
    FeeStoresSubscriptionEarlyTermination,
    /// <remarks />
    CreditStoresSubscriptionEarlyTermination,
    /// <remarks />
    FeeVehicleSubscriptionEarlyTermination,
    /// <remarks />
    CreditVehicleSubscriptionEarlyTermination,
    /// <remarks />
    FeeVehicleSubscription,
    /// <remarks />
    CreditVehicleSubscription,
    /// <remarks />
    FeeAUPostShippingLabel,
    /// <remarks />
    CreditAUPostShippingLabel,
    /// <remarks />
    FeeAPACFedExShippingLabel,
    /// <remarks />
    CreditAPACFedExShippingLabel,
    /// <remarks />
    FeeAPACTNTShippingLabel,
    /// <remarks />
    CreditAPACTNTShippingLabel,
    /// <remarks />
    FeeEBPReimbursement,
    /// <remarks />
    CreditEBPReimbursement,
    /// <remarks />
    FeePromotedListingFeature,
    /// <remarks />
    CreditPromotedListingFeature,
    /// <remarks />
    FeeAd,
    /// <remarks />
    CreditAd,
    /// <remarks />
    FeeUBIShippingLabel,
    /// <remarks />
    CreditUBIShippingLabel,
    /// <remarks />
    FeeeBayPlusSubscription,
    /// <remarks />
    CrediteBayPlusSubscription,
    /// <remarks />
    PaymentIntermediationFee,
    /// <remarks />
    PaymentIntermediationFeeCredit,
    /// <remarks />
    FeePaymentIntermediationRVI,
    /// <remarks />
    FeePaymentIntermediationChargeback,
    /// <remarks />
    FeePaymentIntermediationChargebackRVI,
    /// <remarks />
    SnadOutlierFinalValueFee,
    /// <remarks />
    SnadOutlierFinalValueFeeOnShipping,
    /// <remarks />
    HighlineSearchFee,
    /// <remarks />
    HighlineSearchFeeCredit,
    /// <remarks />
    SnadOutlierFinalValueFeeCredit,
    /// <remarks />
    SnadOutlierFinalValueFeeOnShippingCredit,
    /// <remarks />
    AdFeePremium,
    /// <remarks />
    AdFeePremiumCredit,
    /// <remarks />
    PerListingPaymentsFee,
    /// <remarks />
    PerListingPaymentsFeeCredit,
    /// <remarks />
    VehiclesListingBasicPackageFee,
    /// <remarks />
    VehiclesListingBasicPackageCredit,
    /// <remarks />
    VehiclesListingPlusPackageFee,
    /// <remarks />
    VehiclesListingPlusPackageCredit,
    /// <remarks />
    VehiclesListingPremiumPackageFee,
    /// <remarks />
    VehiclesListingPremiumPackageCredit,
    /// <remarks />
    SendLabelFee,
    /// <remarks />
    SendLabelFeeCredit,
    /// <remarks />
    UpsLabelFee,
    /// <remarks />
    UpsLabelFeeCredit,
    /// <remarks />
    CanadaPostLabelFee,
    /// <remarks />
    CanadaPostLabelFeeCredit,
    /// <remarks />
    EbaySendLabelFee,
    /// <remarks />
    EbaySendLabelFeeCredit,
    /// <remarks />
    USInternetSalesTax,
    /// <remarks />
    USInternetSalesTaxCredit,
    /// <remarks />
    NewZealandGST,
    /// <remarks />
    NewZealandGSTCredit,
    /// <remarks />
    AustraliaGST,
    /// <remarks />
    AustraliaGSTCredit,
    /// <remarks />
    CoFundingCharge,
    /// <remarks />
    CoFundingChargeCredit,
  }
}
