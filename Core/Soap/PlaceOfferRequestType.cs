// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PlaceOfferRequestType
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
  public class PlaceOfferRequestType : AbstractRequestType
  {
    private OfferType mOffer;
    private string mItemID;
    private bool mBlockOnWarning;
    private bool mBlockOnWarningSpecified;
    private AffiliateTrackingDetailsType mAffiliateTrackingDetails;
    private NameValueListTypeCollection mVariationSpecifics;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public OfferType Offer
    {
      get => this.mOffer;
      set => this.mOffer = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool BlockOnWarning
    {
      get => this.mBlockOnWarning;
      set
      {
        this.mBlockOnWarning = value;
        this.mBlockOnWarningSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BlockOnWarningSpecified
    {
      get => this.mBlockOnWarningSpecified;
      set => this.mBlockOnWarningSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public AffiliateTrackingDetailsType AffiliateTrackingDetails
    {
      get => this.mAffiliateTrackingDetails;
      set => this.mAffiliateTrackingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 4)]
    [XmlArrayItem("NameValueList", IsNullable = false)]
    public NameValueListTypeCollection VariationSpecifics
    {
      get => this.mVariationSpecifics;
      set => this.mVariationSpecifics = value;
    }
  }
}
