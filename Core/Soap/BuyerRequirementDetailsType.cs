// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BuyerRequirementDetailsType
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
  public class BuyerRequirementDetailsType
  {
    private bool mShipToRegistrationCountry;
    private bool mShipToRegistrationCountrySpecified;
    private bool mZeroFeedbackScore;
    private bool mZeroFeedbackScoreSpecified;
    private MaximumItemRequirementsType mMaximumItemRequirements;
    private MaximumUnpaidItemStrikesInfoType mMaximumUnpaidItemStrikesInfo;
    private XmlElementCollection mAny;

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
    public bool ZeroFeedbackScore
    {
      get => this.mZeroFeedbackScore;
      set
      {
        this.mZeroFeedbackScore = value;
        this.mZeroFeedbackScoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ZeroFeedbackScoreSpecified
    {
      get => this.mZeroFeedbackScoreSpecified;
      set => this.mZeroFeedbackScoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaximumItemRequirementsType MaximumItemRequirements
    {
      get => this.mMaximumItemRequirements;
      set => this.mMaximumItemRequirements = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MaximumUnpaidItemStrikesInfoType MaximumUnpaidItemStrikesInfo
    {
      get => this.mMaximumUnpaidItemStrikesInfo;
      set => this.mMaximumUnpaidItemStrikesInfo = value;
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
