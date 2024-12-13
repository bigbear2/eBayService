// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UserAgreementInfoType
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
  public class UserAgreementInfoType
  {
    private SiteCodeType mSite;
    private bool mSiteSpecified;
    private SellereBayPaymentProcessStatusCodeType mSellereBayPaymentProcessStatus;
    private bool mSellereBayPaymentProcessStatusSpecified;
    private DateTime mAcceptedTime;
    private bool mAcceptedTimeSpecified;
    private DateTime mSellereBayPaymentProcessEnableTime;
    private bool mSellereBayPaymentProcessEnableTimeSpecified;
    private string mUserAgreementURL;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SiteCodeType Site
    {
      get => this.mSite;
      set
      {
        this.mSite = value;
        this.mSiteSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SiteSpecified
    {
      get => this.mSiteSpecified;
      set => this.mSiteSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellereBayPaymentProcessStatusCodeType SellereBayPaymentProcessStatus
    {
      get => this.mSellereBayPaymentProcessStatus;
      set
      {
        this.mSellereBayPaymentProcessStatus = value;
        this.mSellereBayPaymentProcessStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellereBayPaymentProcessStatusSpecified
    {
      get => this.mSellereBayPaymentProcessStatusSpecified;
      set => this.mSellereBayPaymentProcessStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime AcceptedTime
    {
      get => this.mAcceptedTime;
      set
      {
        this.mAcceptedTime = value;
        this.mAcceptedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AcceptedTimeSpecified
    {
      get => this.mAcceptedTimeSpecified;
      set => this.mAcceptedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime SellereBayPaymentProcessEnableTime
    {
      get => this.mSellereBayPaymentProcessEnableTime;
      set
      {
        this.mSellereBayPaymentProcessEnableTime = value;
        this.mSellereBayPaymentProcessEnableTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SellereBayPaymentProcessEnableTimeSpecified
    {
      get => this.mSellereBayPaymentProcessEnableTimeSpecified;
      set => this.mSellereBayPaymentProcessEnableTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string UserAgreementURL
    {
      get => this.mUserAgreementURL;
      set => this.mUserAgreementURL = value;
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
