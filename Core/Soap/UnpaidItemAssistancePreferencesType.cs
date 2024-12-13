// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UnpaidItemAssistancePreferencesType
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
  public class UnpaidItemAssistancePreferencesType
  {
    private int mDelayBeforeOpeningDispute;
    private bool mDelayBeforeOpeningDisputeSpecified;
    private bool mOptInStatus;
    private bool mOptInStatusSpecified;
    private bool mAutoRelist;
    private bool mRemoveAllExcludedUsers;
    private StringCollection mExcludedUser;
    private bool mAutoOptDonationRefund;
    private bool mAutoOptDonationRefundSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public UnpaidItemAssistancePreferencesType()
    {
      this.AutoRelist = false;
      this.RemoveAllExcludedUsers = false;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DelayBeforeOpeningDispute
    {
      get => this.mDelayBeforeOpeningDispute;
      set
      {
        this.mDelayBeforeOpeningDispute = value;
        this.mDelayBeforeOpeningDisputeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DelayBeforeOpeningDisputeSpecified
    {
      get => this.mDelayBeforeOpeningDisputeSpecified;
      set => this.mDelayBeforeOpeningDisputeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool OptInStatus
    {
      get => this.mOptInStatus;
      set
      {
        this.mOptInStatus = value;
        this.mOptInStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OptInStatusSpecified
    {
      get => this.mOptInStatusSpecified;
      set => this.mOptInStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(false)]
    public bool AutoRelist
    {
      get => this.mAutoRelist;
      set => this.mAutoRelist = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(false)]
    public bool RemoveAllExcludedUsers
    {
      get => this.mRemoveAllExcludedUsers;
      set => this.mRemoveAllExcludedUsers = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExcludedUser")]
    public StringCollection ExcludedUser
    {
      get => this.mExcludedUser;
      set => this.mExcludedUser = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AutoOptDonationRefund
    {
      get => this.mAutoOptDonationRefund;
      set
      {
        this.mAutoOptDonationRefund = value;
        this.mAutoOptDonationRefundSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AutoOptDonationRefundSpecified
    {
      get => this.mAutoOptDonationRefundSpecified;
      set => this.mAutoOptDonationRefundSpecified = value;
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
