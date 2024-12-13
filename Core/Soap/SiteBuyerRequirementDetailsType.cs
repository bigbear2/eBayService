// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SiteBuyerRequirementDetailsType
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
  public class SiteBuyerRequirementDetailsType
  {
    private bool mLinkedPayPalAccount;
    private bool mLinkedPayPalAccountSpecified;
    private MaximumBuyerPolicyViolationsDetailsType mMaximumBuyerPolicyViolations;
    private MaximumItemRequirementsDetailsType mMaximumItemRequirements;
    private MaximumUnpaidItemStrikesInfoDetailsType mMaximumUnpaidItemStrikesInfo;
    private MinimumFeedbackScoreDetailsType mMinimumFeedbackScore;
    private bool mShipToRegistrationCountry;
    private bool mShipToRegistrationCountrySpecified;
    private VerifiedUserRequirementsDetailsType mVerifiedUserRequirements;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool LinkedPayPalAccount
    {
      get => this.mLinkedPayPalAccount;
      set
      {
        this.mLinkedPayPalAccount = value;
        this.mLinkedPayPalAccountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LinkedPayPalAccountSpecified
    {
      get => this.mLinkedPayPalAccountSpecified;
      set => this.mLinkedPayPalAccountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaximumBuyerPolicyViolationsDetailsType MaximumBuyerPolicyViolations
    {
      get => this.mMaximumBuyerPolicyViolations;
      set => this.mMaximumBuyerPolicyViolations = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaximumItemRequirementsDetailsType MaximumItemRequirements
    {
      get => this.mMaximumItemRequirements;
      set => this.mMaximumItemRequirements = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaximumUnpaidItemStrikesInfoDetailsType MaximumUnpaidItemStrikesInfo
    {
      get => this.mMaximumUnpaidItemStrikesInfo;
      set => this.mMaximumUnpaidItemStrikesInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MinimumFeedbackScoreDetailsType MinimumFeedbackScore
    {
      get => this.mMinimumFeedbackScore;
      set => this.mMinimumFeedbackScore = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ShipToRegistrationCountry
    {
      get => this.mShipToRegistrationCountry;
      set
      {
        this.mShipToRegistrationCountry = value;
        this.mShipToRegistrationCountrySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShipToRegistrationCountrySpecified
    {
      get => this.mShipToRegistrationCountrySpecified;
      set => this.mShipToRegistrationCountrySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VerifiedUserRequirementsDetailsType VerifiedUserRequirements
    {
      get => this.mVerifiedUserRequirements;
      set => this.mVerifiedUserRequirements = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
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
