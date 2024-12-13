// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CharityType
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
  public class CharityType
  {
    private string mCharityName;
    private int mCharityNumber;
    private bool mCharityNumberSpecified;
    private float mDonationPercent;
    private bool mDonationPercentSpecified;
    private string mCharityID;
    private string mMission;
    private string mLogoURL;
    private CharityStatusCodeType mStatus;
    private bool mStatusSpecified;
    private bool mCharityListing;
    private bool mCharityListingSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string CharityName
    {
      get => this.mCharityName;
      set => this.mCharityName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int CharityNumber
    {
      get => this.mCharityNumber;
      set
      {
        this.mCharityNumber = value;
        this.mCharityNumberSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityNumberSpecified
    {
      get => this.mCharityNumberSpecified;
      set => this.mCharityNumberSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float DonationPercent
    {
      get => this.mDonationPercent;
      set
      {
        this.mDonationPercent = value;
        this.mDonationPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DonationPercentSpecified
    {
      get => this.mDonationPercentSpecified;
      set => this.mDonationPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CharityID
    {
      get => this.mCharityID;
      set => this.mCharityID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Mission
    {
      get => this.mMission;
      set => this.mMission = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LogoURL
    {
      get => this.mLogoURL;
      set => this.mLogoURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CharityStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CharityListing
    {
      get => this.mCharityListing;
      set
      {
        this.mCharityListing = value;
        this.mCharityListingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityListingSpecified
    {
      get => this.mCharityListingSpecified;
      set => this.mCharityListingSpecified = value;
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
