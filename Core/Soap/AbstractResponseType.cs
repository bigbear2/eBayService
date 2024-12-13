// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AbstractResponseType
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
  [XmlInclude(typeof (NotificationMessageType))]
  [XmlInclude(typeof (ItemsCanceledEventType))]
  [XmlInclude(typeof (VerifyRelistItemResponseType))]
  [XmlInclude(typeof (VerifyAddSecondChanceItemResponseType))]
  [XmlInclude(typeof (VerifyAddItemResponseType))]
  [XmlInclude(typeof (VerifyAddFixedPriceItemResponseType))]
  [XmlInclude(typeof (VeROReportItemsResponseType))]
  [XmlInclude(typeof (ValidateTestUserRegistrationResponseType))]
  [XmlInclude(typeof (ValidateChallengeInputResponseType))]
  [XmlInclude(typeof (UploadSiteHostedPicturesResponseType))]
  [XmlInclude(typeof (SetUserPreferencesResponseType))]
  [XmlInclude(typeof (SetUserNotesResponseType))]
  [XmlInclude(typeof (SetTaxTableResponseType))]
  [XmlInclude(typeof (SetStorePreferencesResponseType))]
  [XmlInclude(typeof (SetStoreCustomPageResponseType))]
  [XmlInclude(typeof (SetStoreCategoriesResponseType))]
  [XmlInclude(typeof (SetStoreResponseType))]
  [XmlInclude(typeof (SetShippingDiscountProfilesResponseType))]
  [XmlInclude(typeof (SetSellingManagerTemplateAutomationRuleResponseType))]
  [XmlInclude(typeof (SetSellingManagerItemAutomationRuleResponseType))]
  [XmlInclude(typeof (SetSellingManagerFeedbackOptionsResponseType))]
  [XmlInclude(typeof (SetPromotionalSaleListingsResponseType))]
  [XmlInclude(typeof (SetPromotionalSaleResponseType))]
  [XmlInclude(typeof (SetNotificationPreferencesResponseType))]
  [XmlInclude(typeof (SetMessagePreferencesResponseType))]
  [XmlInclude(typeof (SendInvoiceResponseType))]
  [XmlInclude(typeof (SellerReverseDisputeResponseType))]
  [XmlInclude(typeof (SaveItemToSellingManagerTemplateResponseType))]
  [XmlInclude(typeof (RevokeTokenResponseType))]
  [XmlInclude(typeof (ReviseSellingManagerTemplateResponseType))]
  [XmlInclude(typeof (ReviseSellingManagerSaleRecordResponseType))]
  [XmlInclude(typeof (ReviseSellingManagerProductResponseType))]
  [XmlInclude(typeof (ReviseSellingManagerInventoryFolderResponseType))]
  [XmlInclude(typeof (ReviseMyMessagesFoldersResponseType))]
  [XmlInclude(typeof (ReviseMyMessagesResponseType))]
  [XmlInclude(typeof (ReviseItemResponseType))]
  [XmlInclude(typeof (ReviseInventoryStatusResponseType))]
  [XmlInclude(typeof (ReviseFixedPriceItemResponseType))]
  [XmlInclude(typeof (ReviseCheckoutStatusResponseType))]
  [XmlInclude(typeof (RespondToFeedbackResponseType))]
  [XmlInclude(typeof (RespondToBestOfferResponseType))]
  [XmlInclude(typeof (RemoveFromWatchListResponseType))]
  [XmlInclude(typeof (RelistItemResponseType))]
  [XmlInclude(typeof (RelistFixedPriceItemResponseType))]
  [XmlInclude(typeof (PlaceOfferResponseType))]
  [XmlInclude(typeof (MoveSellingManagerInventoryFolderResponseType))]
  [XmlInclude(typeof (LeaveFeedbackResponseType))]
  [XmlInclude(typeof (GeteBayOfficialTimeResponseType))]
  [XmlInclude(typeof (GeteBayDetailsResponseType))]
  [XmlInclude(typeof (GetVeROReportStatusResponseType))]
  [XmlInclude(typeof (GetVeROReasonCodeDetailsResponseType))]
  [XmlInclude(typeof (GetUserPreferencesResponseType))]
  [XmlInclude(typeof (GetUserDisputesResponseType))]
  [XmlInclude(typeof (GetUserContactDetailsResponseType))]
  [XmlInclude(typeof (GetUserResponseType))]
  [XmlInclude(typeof (GetTokenStatusResponseType))]
  [XmlInclude(typeof (GetTaxTableResponseType))]
  [XmlInclude(typeof (GetSuggestedCategoriesResponseType))]
  [XmlInclude(typeof (GetStorePreferencesResponseType))]
  [XmlInclude(typeof (GetStoreOptionsResponseType))]
  [XmlInclude(typeof (GetStoreCustomPageResponseType))]
  [XmlInclude(typeof (GetStoreCategoryUpdateStatusResponseType))]
  [XmlInclude(typeof (GetStoreResponseType))]
  [XmlInclude(typeof (GetShippingDiscountProfilesResponseType))]
  [XmlInclude(typeof (GetSessionIDResponseType))]
  [XmlInclude(typeof (GetSellingManagerTemplatesResponseType))]
  [XmlInclude(typeof (GetSellingManagerTemplateAutomationRuleResponseType))]
  [XmlInclude(typeof (GetSellingManagerSoldListingsResponseType))]
  [XmlInclude(typeof (GetSellingManagerSaleRecordResponseType))]
  [XmlInclude(typeof (GetSellingManagerItemAutomationRuleResponseType))]
  [XmlInclude(typeof (GetSellingManagerInventoryFolderResponseType))]
  [XmlInclude(typeof (GetSellingManagerInventoryResponseType))]
  [XmlInclude(typeof (GetSellingManagerEmailLogResponseType))]
  [XmlInclude(typeof (GetSellingManagerAlertsResponseType))]
  [XmlInclude(typeof (GetSellerTransactionsResponseType))]
  [XmlInclude(typeof (GetSellerListResponseType))]
  [XmlInclude(typeof (GetSellerEventsResponseType))]
  [XmlInclude(typeof (GetSellerDashboardResponseType))]
  [XmlInclude(typeof (GetPromotionalSaleDetailsResponseType))]
  [XmlInclude(typeof (GetOrdersResponseType))]
  [XmlInclude(typeof (GetOrderTransactionsResponseType))]
  [XmlInclude(typeof (GetNotificationsUsageResponseType))]
  [XmlInclude(typeof (GetNotificationPreferencesResponseType))]
  [XmlInclude(typeof (GetMyeBaySellingResponseType))]
  [XmlInclude(typeof (GetMyeBayRemindersResponseType))]
  [XmlInclude(typeof (GetMyeBayBuyingResponseType))]
  [XmlInclude(typeof (GetMyMessagesResponseType))]
  [XmlInclude(typeof (GetMessagePreferencesResponseType))]
  [XmlInclude(typeof (GetMemberMessagesResponseType))]
  [XmlInclude(typeof (GetItemsAwaitingFeedbackResponseType))]
  [XmlInclude(typeof (GetItemTransactionsResponseType))]
  [XmlInclude(typeof (GetItemShippingResponseType))]
  [XmlInclude(typeof (GetItemResponseType))]
  [XmlInclude(typeof (GetFeedbackResponseType))]
  [XmlInclude(typeof (GetDisputeResponseType))]
  [XmlInclude(typeof (GetDescriptionTemplatesResponseType))]
  [XmlInclude(typeof (GetContextualKeywordsResponseType))]
  [XmlInclude(typeof (GetClientAlertsAuthTokenResponseType))]
  [XmlInclude(typeof (GetCharitiesResponseType))]
  [XmlInclude(typeof (GetChallengeTokenResponseType))]
  [XmlInclude(typeof (GetCategorySpecificsResponseType))]
  [XmlInclude(typeof (GetCategoryMappingsResponseType))]
  [XmlInclude(typeof (GetCategoryFeaturesResponseType))]
  [XmlInclude(typeof (GetCategoriesResponseType))]
  [XmlInclude(typeof (GetBidderListResponseType))]
  [XmlInclude(typeof (GetBestOffersResponseType))]
  [XmlInclude(typeof (GetApiAccessRulesResponseType))]
  [XmlInclude(typeof (GetAllBiddersResponseType))]
  [XmlInclude(typeof (GetAdFormatLeadsResponseType))]
  [XmlInclude(typeof (GetAccountResponseType))]
  [XmlInclude(typeof (FetchTokenResponseType))]
  [XmlInclude(typeof (ExtendSiteHostedPicturesResponseType))]
  [XmlInclude(typeof (EndItemsResponseType))]
  [XmlInclude(typeof (EndItemResponseType))]
  [XmlInclude(typeof (EndFixedPriceItemResponseType))]
  [XmlInclude(typeof (DisableUnpaidItemAssistanceResponseType))]
  [XmlInclude(typeof (DeleteSellingManagerTemplateAutomationRuleResponseType))]
  [XmlInclude(typeof (DeleteSellingManagerTemplateResponseType))]
  [XmlInclude(typeof (DeleteSellingManagerProductResponseType))]
  [XmlInclude(typeof (DeleteSellingManagerItemAutomationRuleResponseType))]
  [XmlInclude(typeof (DeleteSellingManagerInventoryFolderResponseType))]
  [XmlInclude(typeof (DeleteMyMessagesResponseType))]
  [XmlInclude(typeof (ConfirmIdentityResponseType))]
  [XmlInclude(typeof (CompleteSaleResponseType))]
  [XmlInclude(typeof (AddTransactionConfirmationItemResponseType))]
  [XmlInclude(typeof (AddToWatchListResponseType))]
  [XmlInclude(typeof (AddToItemDescriptionResponseType))]
  [XmlInclude(typeof (AddSellingManagerTemplateResponseType))]
  [XmlInclude(typeof (AddSellingManagerProductResponseType))]
  [XmlInclude(typeof (AddSellingManagerInventoryFolderResponseType))]
  [XmlInclude(typeof (AddSecondChanceItemResponseType))]
  [XmlInclude(typeof (AddOrderResponseType))]
  [XmlInclude(typeof (AddMemberMessagesAAQToBidderResponseType))]
  [XmlInclude(typeof (AddMemberMessageRTQResponseType))]
  [XmlInclude(typeof (AddMemberMessageAAQToPartnerResponseType))]
  [XmlInclude(typeof (AddItemsResponseType))]
  [XmlInclude(typeof (AddItemFromSellingManagerTemplateResponseType))]
  [XmlInclude(typeof (AddItemResponseType))]
  [XmlInclude(typeof (AddFixedPriceItemResponseType))]
  [XmlInclude(typeof (AddDisputeResponseResponseType))]
  [XmlInclude(typeof (AddDisputeResponseType))]
  [GeneratedCode("CodeGen05", "1.0.7142.28876")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [XmlType(Namespace = "urn:ebay:apis:eBLBaseComponents")]
  [Serializable]
  public abstract class AbstractResponseType
  {
    private DateTime mTimestamp;
    private bool mTimestampSpecified;
    private AckCodeType mAck;
    private bool mAckSpecified;
    private string mCorrelationID;
    private ErrorTypeCollection mErrors;
    private string mMessage;
    private string mVersion;
    private string mBuild;
    private string mNotificationEventName;
    private DuplicateInvocationDetailsType mDuplicateInvocationDetails;
    private string mRecipientUserID;
    private string mEIASToken;
    private string mNotificationSignature;
    private string mHardExpirationWarning;
    private BotBlockResponseType mBotBlock;
    private string mExternalUserData;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DateTime Timestamp
    {
      get => this.mTimestamp;
      set
      {
        this.mTimestamp = value;
        this.mTimestampSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TimestampSpecified
    {
      get => this.mTimestampSpecified;
      set => this.mTimestampSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AckCodeType Ack
    {
      get => this.mAck;
      set
      {
        this.mAck = value;
        this.mAckSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AckSpecified
    {
      get => this.mAckSpecified;
      set => this.mAckSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CorrelationID
    {
      get => this.mCorrelationID;
      set => this.mCorrelationID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Errors")]
    public ErrorTypeCollection Errors
    {
      get => this.mErrors;
      set => this.mErrors = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Message
    {
      get => this.mMessage;
      set => this.mMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Version
    {
      get => this.mVersion;
      set => this.mVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Build
    {
      get => this.mBuild;
      set => this.mBuild = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NotificationEventName
    {
      get => this.mNotificationEventName;
      set => this.mNotificationEventName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DuplicateInvocationDetailsType DuplicateInvocationDetails
    {
      get => this.mDuplicateInvocationDetails;
      set => this.mDuplicateInvocationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RecipientUserID
    {
      get => this.mRecipientUserID;
      set => this.mRecipientUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EIASToken
    {
      get => this.mEIASToken;
      set => this.mEIASToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NotificationSignature
    {
      get => this.mNotificationSignature;
      set => this.mNotificationSignature = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string HardExpirationWarning
    {
      get => this.mHardExpirationWarning;
      set => this.mHardExpirationWarning = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BotBlockResponseType BotBlock
    {
      get => this.mBotBlock;
      set => this.mBotBlock = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalUserData
    {
      get => this.mExternalUserData;
      set => this.mExternalUserData = value;
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
