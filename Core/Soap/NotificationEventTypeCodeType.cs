// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NotificationEventTypeCodeType
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
  public enum NotificationEventTypeCodeType
  {
    /// <remarks />
    None,
    /// <remarks />
    OutBid,
    /// <remarks />
    EndOfAuction,
    /// <remarks />
    AuctionCheckoutComplete,
    /// <remarks />
    CheckoutBuyerRequestsTotal,
    /// <remarks />
    Feedback,
    /// <remarks />
    FeedbackForSeller,
    /// <remarks />
    FixedPriceTransaction,
    /// <remarks />
    SecondChanceOffer,
    /// <remarks />
    AskSellerQuestion,
    /// <remarks />
    ItemListed,
    /// <remarks />
    ItemRevised,
    /// <remarks />
    BuyerResponseDispute,
    /// <remarks />
    SellerOpenedDispute,
    /// <remarks />
    SellerRespondedToDispute,
    /// <remarks />
    SellerClosedDispute,
    /// <remarks />
    BestOffer,
    /// <remarks />
    MyMessagesAlertHeader,
    /// <remarks />
    MyMessagesAlert,
    /// <remarks />
    MyMessageseBayMessageHeader,
    /// <remarks />
    MyMessageseBayMessage,
    /// <remarks />
    MyMessagesM2MMessageHeader,
    /// <remarks />
    MyMessagesM2MMessage,
    /// <remarks />
    INRBuyerOpenedDispute,
    /// <remarks />
    INRBuyerRespondedToDispute,
    /// <remarks />
    INRBuyerClosedDispute,
    /// <remarks />
    INRSellerRespondedToDispute,
    /// <remarks />
    Checkout,
    /// <remarks />
    WatchedItemEndingSoon,
    /// <remarks />
    ItemClosed,
    /// <remarks />
    ItemSuspended,
    /// <remarks />
    ItemSold,
    /// <remarks />
    ItemExtended,
    /// <remarks />
    UserIDChanged,
    /// <remarks />
    EmailAddressChanged,
    /// <remarks />
    PasswordChanged,
    /// <remarks />
    PasswordHintChanged,
    /// <remarks />
    PaymentDetailChanged,
    /// <remarks />
    AccountSuspended,
    /// <remarks />
    AccountSummary,
    /// <remarks />
    ThirdPartyCartCheckout,
    /// <remarks />
    ItemRevisedAddCharity,
    /// <remarks />
    ItemAddedToWatchList,
    /// <remarks />
    ItemRemovedFromWatchList,
    /// <remarks />
    ItemAddedToBidGroup,
    /// <remarks />
    ItemRemovedFromBidGroup,
    /// <remarks />
    FeedbackLeft,
    /// <remarks />
    FeedbackReceived,
    /// <remarks />
    FeedbackStarChanged,
    /// <remarks />
    BidPlaced,
    /// <remarks />
    BidReceived,
    /// <remarks />
    ItemWon,
    /// <remarks />
    ItemLost,
    /// <remarks />
    ItemUnsold,
    /// <remarks />
    CounterOfferReceived,
    /// <remarks />
    BestOfferDeclined,
    /// <remarks />
    BestOfferPlaced,
    /// <remarks />
    AddToWatchList,
    /// <remarks />
    PlaceOffer,
    /// <remarks />
    RemoveFromWatchList,
    /// <remarks />
    AddToBidGroup,
    /// <remarks />
    RemoveFromBidGroup,
    /// <remarks />
    ItemsCanceled,
    /// <remarks />
    TokenRevocation,
    /// <remarks />
    BulkDataExchangeJobCompleted,
    /// <remarks />
    CustomCode,
    /// <remarks />
    ItemMarkedShipped,
    /// <remarks />
    ItemMarkedPaid,
    /// <remarks />
    EBPMyResponseDue,
    /// <remarks />
    EBPOtherPartyResponseDue,
    /// <remarks />
    EBPEscalatedCase,
    /// <remarks />
    EBPAppealedCase,
    /// <remarks />
    EBPMyPaymentDue,
    /// <remarks />
    EBPPaymentDone,
    /// <remarks />
    EBPClosedAppeal,
    /// <remarks />
    EBPClosedCase,
    /// <remarks />
    MyMessagesHighPriorityMessage,
    /// <remarks />
    MyMessagesHighPriorityMessageHeader,
    /// <remarks />
    EBPOnHoldCase,
    /// <remarks />
    ReadyToShip,
    /// <remarks />
    ReadyForPayout,
    /// <remarks />
    BidItemEndingSoon,
    /// <remarks />
    ShoppingCartItemEndingSoon,
    /// <remarks />
    ReturnCreated,
    /// <remarks />
    ReturnWaitingForSellerInfo,
    /// <remarks />
    ReturnSellerInfoOverdue,
    /// <remarks />
    ReturnShipped,
    /// <remarks />
    ReturnDelivered,
    /// <remarks />
    ReturnRefundOverdue,
    /// <remarks />
    ReturnClosed,
    /// <remarks />
    ReturnEscalated,
    /// <remarks />
    BuyerCancelRequested,
    /// <remarks />
    UnmatchedPaymentReceived,
    /// <remarks />
    RefundSuccess,
    /// <remarks />
    RefundFailure,
    /// <remarks />
    OrderInquiryOpened,
    /// <remarks />
    OrderInquiryReminderForEscalation,
    /// <remarks />
    OrderInquiryProvideShipmentInformation,
    /// <remarks />
    OrderInquiryClosed,
    /// <remarks />
    OrderInquiryEscalatedToCase,
    /// <remarks />
    ItemReadyForPickup,
    /// <remarks />
    ItemOutOfStock,
    /// <remarks />
    BuyerNoShow,
    /// <remarks />
    WebnextMobilePhotoSync,
    /// <remarks />
    PaymentReminder,
    /// <remarks />
    EBNOrderPickedUp,
    /// <remarks />
    EBNOrderCanceled,
    /// <remarks />
    M2MMessageStatusChange,
  }
}
