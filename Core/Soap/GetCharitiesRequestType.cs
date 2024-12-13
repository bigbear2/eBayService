// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCharitiesRequestType
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
  public class GetCharitiesRequestType : AbstractRequestType
  {
    private string mCharityID;
    private string mCharityName;
    private string mQuery;
    private int mCharityRegion;
    private bool mCharityRegionSpecified;
    private int mCharityDomain;
    private bool mCharityDomainSpecified;
    private bool mIncludeDescription;
    private bool mIncludeDescriptionSpecified;
    private StringMatchCodeType mMatchType;
    private bool mMatchTypeSpecified;
    private bool mFeatured;
    private bool mFeaturedSpecified;
    private long mCampaignID;
    private bool mCampaignIDSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string CharityID
    {
      get => this.mCharityID;
      set => this.mCharityID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string CharityName
    {
      get => this.mCharityName;
      set => this.mCharityName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string Query
    {
      get => this.mQuery;
      set => this.mQuery = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public int CharityRegion
    {
      get => this.mCharityRegion;
      set
      {
        this.mCharityRegion = value;
        this.mCharityRegionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityRegionSpecified
    {
      get => this.mCharityRegionSpecified;
      set => this.mCharityRegionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public int CharityDomain
    {
      get => this.mCharityDomain;
      set
      {
        this.mCharityDomain = value;
        this.mCharityDomainSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CharityDomainSpecified
    {
      get => this.mCharityDomainSpecified;
      set => this.mCharityDomainSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public bool IncludeDescription
    {
      get => this.mIncludeDescription;
      set
      {
        this.mIncludeDescription = value;
        this.mIncludeDescriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeDescriptionSpecified
    {
      get => this.mIncludeDescriptionSpecified;
      set => this.mIncludeDescriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public StringMatchCodeType MatchType
    {
      get => this.mMatchType;
      set
      {
        this.mMatchType = value;
        this.mMatchTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MatchTypeSpecified
    {
      get => this.mMatchTypeSpecified;
      set => this.mMatchTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool Featured
    {
      get => this.mFeatured;
      set
      {
        this.mFeatured = value;
        this.mFeaturedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FeaturedSpecified
    {
      get => this.mFeaturedSpecified;
      set => this.mFeaturedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public long CampaignID
    {
      get => this.mCampaignID;
      set
      {
        this.mCampaignID = value;
        this.mCampaignIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CampaignIDSpecified
    {
      get => this.mCampaignIDSpecified;
      set => this.mCampaignIDSpecified = value;
    }
  }
}
