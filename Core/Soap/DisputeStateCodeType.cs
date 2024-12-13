﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DisputeStateCodeType
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
  public enum DisputeStateCodeType
  {
    /// <remarks />
    Locked,
    /// <remarks />
    Closed,
    /// <remarks />
    BuyerFirstResponsePayOption,
    /// <remarks />
    BuyerFirstResponseNoPayOption,
    /// <remarks />
    BuyerFirstResponsePayOptionLateResponse,
    /// <remarks />
    BuyerFirstResponseNoPayOptionLateResponse,
    /// <remarks />
    MutualCommunicationPayOption,
    /// <remarks />
    MutualCommunicationNoPayOption,
    /// <remarks />
    PendingResolve,
    /// <remarks />
    MutualWithdrawalAgreement,
    /// <remarks />
    MutualWithdrawalAgreementLate,
    /// <remarks />
    NotReceivedNoSellerResponse,
    /// <remarks />
    NotAsDescribedNoSellerResponse,
    /// <remarks />
    NotReceivedMutualCommunication,
    /// <remarks />
    NotAsDescribedMutualCommunication,
    /// <remarks />
    MutualAgreementOrBuyerReturningItem,
    /// <remarks />
    ClaimOpened,
    /// <remarks />
    NoDocumentation,
    /// <remarks />
    ClaimClosed,
    /// <remarks />
    ClaimDenied,
    /// <remarks />
    ClaimPending,
    /// <remarks />
    ClaimPaymentPending,
    /// <remarks />
    ClaimPaid,
    /// <remarks />
    ClaimResolved,
    /// <remarks />
    ClaimSubmitted,
    /// <remarks />
    UnpaidItemOpen,
    /// <remarks />
    UPIAssistanceDisabledByeBay,
    /// <remarks />
    UPIAssistanceDisabledBySeller,
    /// <remarks />
    CustomCode,
  }
}
