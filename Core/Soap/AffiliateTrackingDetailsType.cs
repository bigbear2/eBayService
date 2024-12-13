// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AffiliateTrackingDetailsType
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
  public class AffiliateTrackingDetailsType
  {
    private string mTrackingID;
    private string mTrackingPartnerCode;
    private ApplicationDeviceTypeCodeType mApplicationDeviceType;
    private bool mApplicationDeviceTypeSpecified;
    private string mAffiliateUserID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string TrackingID
    {
      get => this.mTrackingID;
      set => this.mTrackingID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TrackingPartnerCode
    {
      get => this.mTrackingPartnerCode;
      set => this.mTrackingPartnerCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ApplicationDeviceTypeCodeType ApplicationDeviceType
    {
      get => this.mApplicationDeviceType;
      set
      {
        this.mApplicationDeviceType = value;
        this.mApplicationDeviceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ApplicationDeviceTypeSpecified
    {
      get => this.mApplicationDeviceTypeSpecified;
      set => this.mApplicationDeviceTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AffiliateUserID
    {
      get => this.mAffiliateUserID;
      set => this.mAffiliateUserID = value;
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
