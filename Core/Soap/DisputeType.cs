// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DisputeType
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
  public class DisputeType
  {
    private string mDisputeID;
    private DisputeRecordTypeCodeType mDisputeRecordType;
    private bool mDisputeRecordTypeSpecified;
    private DisputeStateCodeType mDisputeState;
    private bool mDisputeStateSpecified;
    private DisputeStatusCodeType mDisputeStatus;
    private bool mDisputeStatusSpecified;
    private TradingRoleCodeType mOtherPartyRole;
    private bool mOtherPartyRoleSpecified;
    private string mOtherPartyName;
    private TradingRoleCodeType mUserRole;
    private bool mUserRoleSpecified;
    private string mBuyerUserID;
    private string mSellerUserID;
    private string mTransactionID;
    private ItemType mItem;
    private DisputeReasonCodeType mDisputeReason;
    private bool mDisputeReasonSpecified;
    private DisputeExplanationCodeType mDisputeExplanation;
    private bool mDisputeExplanationSpecified;
    private DisputeCreditEligibilityCodeType mDisputeCreditEligibility;
    private bool mDisputeCreditEligibilitySpecified;
    private DateTime mDisputeCreatedTime;
    private bool mDisputeCreatedTimeSpecified;
    private DateTime mDisputeModifiedTime;
    private bool mDisputeModifiedTimeSpecified;
    private DisputeResolutionTypeCollection mDisputeResolution;
    private DisputeMessageTypeCollection mDisputeMessage;
    private bool mEscalation;
    private bool mEscalationSpecified;
    private bool mPurchaseProtection;
    private bool mPurchaseProtectionSpecified;
    private string mOrderLineItemID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string DisputeID
    {
      get => this.mDisputeID;
      set => this.mDisputeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeRecordTypeCodeType DisputeRecordType
    {
      get => this.mDisputeRecordType;
      set
      {
        this.mDisputeRecordType = value;
        this.mDisputeRecordTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeRecordTypeSpecified
    {
      get => this.mDisputeRecordTypeSpecified;
      set => this.mDisputeRecordTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeStateCodeType DisputeState
    {
      get => this.mDisputeState;
      set
      {
        this.mDisputeState = value;
        this.mDisputeStateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeStateSpecified
    {
      get => this.mDisputeStateSpecified;
      set => this.mDisputeStateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeStatusCodeType DisputeStatus
    {
      get => this.mDisputeStatus;
      set
      {
        this.mDisputeStatus = value;
        this.mDisputeStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeStatusSpecified
    {
      get => this.mDisputeStatusSpecified;
      set => this.mDisputeStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TradingRoleCodeType OtherPartyRole
    {
      get => this.mOtherPartyRole;
      set
      {
        this.mOtherPartyRole = value;
        this.mOtherPartyRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OtherPartyRoleSpecified
    {
      get => this.mOtherPartyRoleSpecified;
      set => this.mOtherPartyRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OtherPartyName
    {
      get => this.mOtherPartyName;
      set => this.mOtherPartyName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TradingRoleCodeType UserRole
    {
      get => this.mUserRole;
      set
      {
        this.mUserRole = value;
        this.mUserRoleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserRoleSpecified
    {
      get => this.mUserRoleSpecified;
      set => this.mUserRoleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerUserID
    {
      get => this.mBuyerUserID;
      set => this.mBuyerUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerUserID
    {
      get => this.mSellerUserID;
      set => this.mSellerUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemType Item
    {
      get => this.mItem;
      set => this.mItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeReasonCodeType DisputeReason
    {
      get => this.mDisputeReason;
      set
      {
        this.mDisputeReason = value;
        this.mDisputeReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeReasonSpecified
    {
      get => this.mDisputeReasonSpecified;
      set => this.mDisputeReasonSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeExplanationCodeType DisputeExplanation
    {
      get => this.mDisputeExplanation;
      set
      {
        this.mDisputeExplanation = value;
        this.mDisputeExplanationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeExplanationSpecified
    {
      get => this.mDisputeExplanationSpecified;
      set => this.mDisputeExplanationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeCreditEligibilityCodeType DisputeCreditEligibility
    {
      get => this.mDisputeCreditEligibility;
      set
      {
        this.mDisputeCreditEligibility = value;
        this.mDisputeCreditEligibilitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeCreditEligibilitySpecified
    {
      get => this.mDisputeCreditEligibilitySpecified;
      set => this.mDisputeCreditEligibilitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime DisputeCreatedTime
    {
      get => this.mDisputeCreatedTime;
      set
      {
        this.mDisputeCreatedTime = value;
        this.mDisputeCreatedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeCreatedTimeSpecified
    {
      get => this.mDisputeCreatedTimeSpecified;
      set => this.mDisputeCreatedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime DisputeModifiedTime
    {
      get => this.mDisputeModifiedTime;
      set
      {
        this.mDisputeModifiedTime = value;
        this.mDisputeModifiedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeModifiedTimeSpecified
    {
      get => this.mDisputeModifiedTimeSpecified;
      set => this.mDisputeModifiedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DisputeResolution")]
    public DisputeResolutionTypeCollection DisputeResolution
    {
      get => this.mDisputeResolution;
      set => this.mDisputeResolution = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DisputeMessage")]
    public DisputeMessageTypeCollection DisputeMessage
    {
      get => this.mDisputeMessage;
      set => this.mDisputeMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Escalation
    {
      get => this.mEscalation;
      set
      {
        this.mEscalation = value;
        this.mEscalationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EscalationSpecified
    {
      get => this.mEscalationSpecified;
      set => this.mEscalationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PurchaseProtection
    {
      get => this.mPurchaseProtection;
      set
      {
        this.mPurchaseProtection = value;
        this.mPurchaseProtectionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PurchaseProtectionSpecified
    {
      get => this.mPurchaseProtectionSpecified;
      set => this.mPurchaseProtectionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
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
