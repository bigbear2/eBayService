// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AbstractRequestType
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
  [XmlInclude(typeof (VerifyRelistItemRequestType))]
  [XmlInclude(typeof (VerifyAddSecondChanceItemRequestType))]
  [XmlInclude(typeof (VerifyAddItemRequestType))]
  [XmlInclude(typeof (VerifyAddFixedPriceItemRequestType))]
  [XmlInclude(typeof (VeROReportItemsRequestType))]
  [XmlInclude(typeof (ValidateTestUserRegistrationRequestType))]
  [XmlInclude(typeof (ValidateChallengeInputRequestType))]
  [XmlInclude(typeof (UploadSiteHostedPicturesRequestType))]
  [XmlInclude(typeof (SetUserPreferencesRequestType))]
  [XmlInclude(typeof (SetUserNotesRequestType))]
  [XmlInclude(typeof (SetTaxTableRequestType))]
  [XmlInclude(typeof (SetStorePreferencesRequestType))]
  [XmlInclude(typeof (SetStoreCustomPageRequestType))]
  [XmlInclude(typeof (SetStoreCategoriesRequestType))]
  [XmlInclude(typeof (SetStoreRequestType))]
  [XmlInclude(typeof (SetShippingDiscountProfilesRequestType))]
  [XmlInclude(typeof (SetSellingManagerTemplateAutomationRuleRequestType))]
  [XmlInclude(typeof (SetSellingManagerItemAutomationRuleRequestType))]
  [XmlInclude(typeof (SetSellingManagerFeedbackOptionsRequestType))]
  [XmlInclude(typeof (SetPromotionalSaleListingsRequestType))]
  [XmlInclude(typeof (SetPromotionalSaleRequestType))]
  [XmlInclude(typeof (SetNotificationPreferencesRequestType))]
  [XmlInclude(typeof (SetMessagePreferencesRequestType))]
  [XmlInclude(typeof (SendInvoiceRequestType))]
  [XmlInclude(typeof (SellerReverseDisputeRequestType))]
  [XmlInclude(typeof (SaveItemToSellingManagerTemplateRequestType))]
  [XmlInclude(typeof (RevokeTokenRequestType))]
  [XmlInclude(typeof (ReviseSellingManagerTemplateRequestType))]
  [XmlInclude(typeof (ReviseSellingManagerSaleRecordRequestType))]
  [XmlInclude(typeof (ReviseSellingManagerProductRequestType))]
  [XmlInclude(typeof (ReviseSellingManagerInventoryFolderRequestType))]
  [XmlInclude(typeof (ReviseMyMessagesFoldersRequestType))]
  [XmlInclude(typeof (ReviseMyMessagesRequestType))]
  [XmlInclude(typeof (ReviseItemRequestType))]
  [XmlInclude(typeof (ReviseInventoryStatusRequestType))]
  [XmlInclude(typeof (ReviseFixedPriceItemRequestType))]
  [XmlInclude(typeof (ReviseCheckoutStatusRequestType))]
  [XmlInclude(typeof (RespondToFeedbackRequestType))]
  [XmlInclude(typeof (RespondToBestOfferRequestType))]
  [XmlInclude(typeof (RemoveFromWatchListRequestType))]
  [XmlInclude(typeof (RelistItemRequestType))]
  [XmlInclude(typeof (RelistFixedPriceItemRequestType))]
  [XmlInclude(typeof (PlaceOfferRequestType))]
  [XmlInclude(typeof (MoveSellingManagerInventoryFolderRequestType))]
  [XmlInclude(typeof (LeaveFeedbackRequestType))]
  [XmlInclude(typeof (GeteBayOfficialTimeRequestType))]
  [XmlInclude(typeof (GeteBayDetailsRequestType))]
  [XmlInclude(typeof (GetVeROReportStatusRequestType))]
  [XmlInclude(typeof (GetVeROReasonCodeDetailsRequestType))]
  [XmlInclude(typeof (GetUserPreferencesRequestType))]
  [XmlInclude(typeof (GetUserDisputesRequestType))]
  [XmlInclude(typeof (GetUserContactDetailsRequestType))]
  [XmlInclude(typeof (GetUserRequestType))]
  [XmlInclude(typeof (GetTokenStatusRequestType))]
  [XmlInclude(typeof (GetTaxTableRequestType))]
  [XmlInclude(typeof (GetSuggestedCategoriesRequestType))]
  [XmlInclude(typeof (GetStorePreferencesRequestType))]
  [XmlInclude(typeof (GetStoreOptionsRequestType))]
  [XmlInclude(typeof (GetStoreCustomPageRequestType))]
  [XmlInclude(typeof (GetStoreCategoryUpdateStatusRequestType))]
  [XmlInclude(typeof (GetStoreRequestType))]
  [XmlInclude(typeof (GetShippingDiscountProfilesRequestType))]
  [XmlInclude(typeof (GetSessionIDRequestType))]
  [XmlInclude(typeof (GetSellingManagerTemplatesRequestType))]
  [XmlInclude(typeof (GetSellingManagerTemplateAutomationRuleRequestType))]
  [XmlInclude(typeof (GetSellingManagerSoldListingsRequestType))]
  [XmlInclude(typeof (GetSellingManagerSaleRecordRequestType))]
  [XmlInclude(typeof (GetSellingManagerItemAutomationRuleRequestType))]
  [XmlInclude(typeof (GetSellingManagerInventoryFolderRequestType))]
  [XmlInclude(typeof (GetSellingManagerInventoryRequestType))]
  [XmlInclude(typeof (GetSellingManagerEmailLogRequestType))]
  [XmlInclude(typeof (GetSellingManagerAlertsRequestType))]
  [XmlInclude(typeof (GetSellerTransactionsRequestType))]
  [XmlInclude(typeof (GetSellerListRequestType))]
  [XmlInclude(typeof (GetSellerEventsRequestType))]
  [XmlInclude(typeof (GetSellerDashboardRequestType))]
  [XmlInclude(typeof (GetPromotionalSaleDetailsRequestType))]
  [XmlInclude(typeof (GetOrdersRequestType))]
  [XmlInclude(typeof (GetOrderTransactionsRequestType))]
  [XmlInclude(typeof (GetNotificationsUsageRequestType))]
  [XmlInclude(typeof (GetNotificationPreferencesRequestType))]
  [XmlInclude(typeof (GetMyeBaySellingRequestType))]
  [XmlInclude(typeof (GetMyeBayRemindersRequestType))]
  [XmlInclude(typeof (GetMyeBayBuyingRequestType))]
  [XmlInclude(typeof (GetMyMessagesRequestType))]
  [XmlInclude(typeof (GetMessagePreferencesRequestType))]
  [XmlInclude(typeof (GetMemberMessagesRequestType))]
  [XmlInclude(typeof (GetItemsAwaitingFeedbackRequestType))]
  [XmlInclude(typeof (GetItemTransactionsRequestType))]
  [XmlInclude(typeof (GetItemShippingRequestType))]
  [XmlInclude(typeof (GetItemRequestType))]
  [XmlInclude(typeof (GetFeedbackRequestType))]
  [XmlInclude(typeof (GetDisputeRequestType))]
  [XmlInclude(typeof (GetDescriptionTemplatesRequestType))]
  [XmlInclude(typeof (GetContextualKeywordsRequestType))]
  [XmlInclude(typeof (GetClientAlertsAuthTokenRequestType))]
  [XmlInclude(typeof (GetCharitiesRequestType))]
  [XmlInclude(typeof (GetChallengeTokenRequestType))]
  [XmlInclude(typeof (GetCategorySpecificsRequestType))]
  [XmlInclude(typeof (GetCategoryMappingsRequestType))]
  [XmlInclude(typeof (GetCategoryFeaturesRequestType))]
  [XmlInclude(typeof (GetCategoriesRequestType))]
  [XmlInclude(typeof (GetBidderListRequestType))]
  [XmlInclude(typeof (GetBestOffersRequestType))]
  [XmlInclude(typeof (GetApiAccessRulesRequestType))]
  [XmlInclude(typeof (GetAllBiddersRequestType))]
  [XmlInclude(typeof (GetAdFormatLeadsRequestType))]
  [XmlInclude(typeof (GetAccountRequestType))]
  [XmlInclude(typeof (FetchTokenRequestType))]
  [XmlInclude(typeof (ExtendSiteHostedPicturesRequestType))]
  [XmlInclude(typeof (EndItemsRequestType))]
  [XmlInclude(typeof (EndItemRequestType))]
  [XmlInclude(typeof (EndFixedPriceItemRequestType))]
  [XmlInclude(typeof (DisableUnpaidItemAssistanceRequestType))]
  [XmlInclude(typeof (DeleteSellingManagerTemplateAutomationRuleRequestType))]
  [XmlInclude(typeof (DeleteSellingManagerTemplateRequestType))]
  [XmlInclude(typeof (DeleteSellingManagerProductRequestType))]
  [XmlInclude(typeof (DeleteSellingManagerItemAutomationRuleRequestType))]
  [XmlInclude(typeof (DeleteSellingManagerInventoryFolderRequestType))]
  [XmlInclude(typeof (DeleteMyMessagesRequestType))]
  [XmlInclude(typeof (ConfirmIdentityRequestType))]
  [XmlInclude(typeof (CompleteSaleRequestType))]
  [XmlInclude(typeof (AddTransactionConfirmationItemRequestType))]
  [XmlInclude(typeof (AddToWatchListRequestType))]
  [XmlInclude(typeof (AddToItemDescriptionRequestType))]
  [XmlInclude(typeof (AddSellingManagerTemplateRequestType))]
  [XmlInclude(typeof (AddSellingManagerProductRequestType))]
  [XmlInclude(typeof (AddSellingManagerInventoryFolderRequestType))]
  [XmlInclude(typeof (AddSecondChanceItemRequestType))]
  [XmlInclude(typeof (AddOrderRequestType))]
  [XmlInclude(typeof (AddMemberMessagesAAQToBidderRequestType))]
  [XmlInclude(typeof (AddMemberMessageRTQRequestType))]
  [XmlInclude(typeof (AddMemberMessageAAQToPartnerRequestType))]
  [XmlInclude(typeof (AddItemsRequestType))]
  [XmlInclude(typeof (AddItemFromSellingManagerTemplateRequestType))]
  [XmlInclude(typeof (AddItemRequestType))]
  [XmlInclude(typeof (AddFixedPriceItemRequestType))]
  [XmlInclude(typeof (AddDisputeResponseRequestType))]
  [XmlInclude(typeof (AddDisputeRequestType))]
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public abstract class AbstractRequestType
  {
    private DetailLevelCodeTypeCollection mDetailLevel;
    private string mErrorLanguage;
    private string mMessageID;
    private string mVersion;
    private string mEndUserIP;
    private ErrorHandlingCodeType mErrorHandling;
    private bool mErrorHandlingSpecified;
    private string mInvocationID;
    private StringCollection mOutputSelector;
    private WarningLevelCodeType mWarningLevel;
    private bool mWarningLevelSpecified;
    private BotBlockRequestType mBotBlock;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DetailLevel", Order = 0)]
    public DetailLevelCodeTypeCollection DetailLevel
    {
      get => this.mDetailLevel;
      set => this.mDetailLevel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string ErrorLanguage
    {
      get => this.mErrorLanguage;
      set => this.mErrorLanguage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string MessageID
    {
      get => this.mMessageID;
      set => this.mMessageID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string Version
    {
      get => this.mVersion;
      set => this.mVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string EndUserIP
    {
      get => this.mEndUserIP;
      set => this.mEndUserIP = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public ErrorHandlingCodeType ErrorHandling
    {
      get => this.mErrorHandling;
      set
      {
        this.mErrorHandling = value;
        this.mErrorHandlingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ErrorHandlingSpecified
    {
      get => this.mErrorHandlingSpecified;
      set => this.mErrorHandlingSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public string InvocationID
    {
      get => this.mInvocationID;
      set => this.mInvocationID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("OutputSelector", Order = 7)]
    public StringCollection OutputSelector
    {
      get => this.mOutputSelector;
      set => this.mOutputSelector = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public WarningLevelCodeType WarningLevel
    {
      get => this.mWarningLevel;
      set
      {
        this.mWarningLevel = value;
        this.mWarningLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WarningLevelSpecified
    {
      get => this.mWarningLevelSpecified;
      set => this.mWarningLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public BotBlockRequestType BotBlock
    {
      get => this.mBotBlock;
      set => this.mBotBlock = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAnyElement(Order = 10)]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}
