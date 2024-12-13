// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VeROReportItemType
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
  public class VeROReportItemType
  {
    private string mItemID;
    private long mVeROReasonCodeID;
    private bool mVeROReasonCodeIDSpecified;
    private string mMessageToSeller;
    private bool mCopyEmailToRightsOwner;
    private bool mCopyEmailToRightsOwnerSpecified;
    private ShippingRegionCodeTypeCollection mRegion;
    private CountryCodeTypeCollection mCountry;
    private string mPatent;
    private string mDetailedMessage;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long VeROReasonCodeID
    {
      get => this.mVeROReasonCodeID;
      set
      {
        this.mVeROReasonCodeID = value;
        this.mVeROReasonCodeIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VeROReasonCodeIDSpecified
    {
      get => this.mVeROReasonCodeIDSpecified;
      set => this.mVeROReasonCodeIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MessageToSeller
    {
      get => this.mMessageToSeller;
      set => this.mMessageToSeller = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CopyEmailToRightsOwner
    {
      get => this.mCopyEmailToRightsOwner;
      set
      {
        this.mCopyEmailToRightsOwner = value;
        this.mCopyEmailToRightsOwnerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CopyEmailToRightsOwnerSpecified
    {
      get => this.mCopyEmailToRightsOwnerSpecified;
      set => this.mCopyEmailToRightsOwnerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Region")]
    public ShippingRegionCodeTypeCollection Region
    {
      get => this.mRegion;
      set => this.mRegion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Country")]
    public CountryCodeTypeCollection Country
    {
      get => this.mCountry;
      set => this.mCountry = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Patent
    {
      get => this.mPatent;
      set => this.mPatent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailedMessage
    {
      get => this.mDetailedMessage;
      set => this.mDetailedMessage = value;
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
