// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetBidderListRequestType
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
  public class GetBidderListRequestType : AbstractRequestType
  {
    private bool mActiveItemsOnly;
    private bool mActiveItemsOnlySpecified;
    private DateTime mEndTimeFrom;
    private bool mEndTimeFromSpecified;
    private DateTime mEndTimeTo;
    private bool mEndTimeToSpecified;
    private string mUserID;
    private GranularityLevelCodeType mGranularityLevel;
    private bool mGranularityLevelSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public bool ActiveItemsOnly
    {
      get => this.mActiveItemsOnly;
      set
      {
        this.mActiveItemsOnly = value;
        this.mActiveItemsOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActiveItemsOnlySpecified
    {
      get => this.mActiveItemsOnlySpecified;
      set => this.mActiveItemsOnlySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime EndTimeFrom
    {
      get => this.mEndTimeFrom;
      set
      {
        this.mEndTimeFrom = value;
        this.mEndTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeFromSpecified
    {
      get => this.mEndTimeFromSpecified;
      set => this.mEndTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public DateTime EndTimeTo
    {
      get => this.mEndTimeTo;
      set
      {
        this.mEndTimeTo = value;
        this.mEndTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeToSpecified
    {
      get => this.mEndTimeToSpecified;
      set => this.mEndTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public GranularityLevelCodeType GranularityLevel
    {
      get => this.mGranularityLevel;
      set
      {
        this.mGranularityLevel = value;
        this.mGranularityLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GranularityLevelSpecified
    {
      get => this.mGranularityLevelSpecified;
      set => this.mGranularityLevelSpecified = value;
    }
  }
}
