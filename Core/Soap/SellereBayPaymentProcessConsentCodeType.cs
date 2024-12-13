// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellereBayPaymentProcessConsentCodeType
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
  public class SellereBayPaymentProcessConsentCodeType
  {
    private bool mPayoutMethodSet;
    private bool mPayoutMethodSetSpecified;
    private PayoutMethodType mPayoutMethod;
    private bool mPayoutMethodSpecified;
    private UserAgreementInfoTypeCollection mUserAgreementInfo;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool PayoutMethodSet
    {
      get => this.mPayoutMethodSet;
      set
      {
        this.mPayoutMethodSet = value;
        this.mPayoutMethodSetSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayoutMethodSetSpecified
    {
      get => this.mPayoutMethodSetSpecified;
      set => this.mPayoutMethodSetSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PayoutMethodType PayoutMethod
    {
      get => this.mPayoutMethod;
      set
      {
        this.mPayoutMethod = value;
        this.mPayoutMethodSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayoutMethodSpecified
    {
      get => this.mPayoutMethodSpecified;
      set => this.mPayoutMethodSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("UserAgreementInfo")]
    public UserAgreementInfoTypeCollection UserAgreementInfo
    {
      get => this.mUserAgreementInfo;
      set => this.mUserAgreementInfo = value;
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
