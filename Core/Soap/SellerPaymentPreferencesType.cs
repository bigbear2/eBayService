// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerPaymentPreferencesType
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
  public class SellerPaymentPreferencesType
  {
    private bool mAlwaysUseThisPaymentAddress;
    private bool mAlwaysUseThisPaymentAddressSpecified;
    private DisplayPayNowButtonCodeType mDisplayPayNowButton;
    private bool mDisplayPayNowButtonSpecified;
    private bool mPayPalPreferred;
    private bool mPayPalPreferredSpecified;
    private string mDefaultPayPalEmailAddress;
    private bool mPayPalAlwaysOn;
    private bool mPayPalAlwaysOnSpecified;
    private AddressType mSellerPaymentAddress;
    private UPSRateOptionCodeType mUPSRateOption;
    private bool mUPSRateOptionSpecified;
    private FedExRateOptionCodeType mFedExRateOption;
    private bool mFedExRateOptionSpecified;
    private USPSRateOptionCodeType mUSPSRateOption;
    private bool mUSPSRateOptionSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool AlwaysUseThisPaymentAddress
    {
      get => this.mAlwaysUseThisPaymentAddress;
      set
      {
        this.mAlwaysUseThisPaymentAddress = value;
        this.mAlwaysUseThisPaymentAddressSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AlwaysUseThisPaymentAddressSpecified
    {
      get => this.mAlwaysUseThisPaymentAddressSpecified;
      set => this.mAlwaysUseThisPaymentAddressSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisplayPayNowButtonCodeType DisplayPayNowButton
    {
      get => this.mDisplayPayNowButton;
      set
      {
        this.mDisplayPayNowButton = value;
        this.mDisplayPayNowButtonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayPayNowButtonSpecified
    {
      get => this.mDisplayPayNowButtonSpecified;
      set => this.mDisplayPayNowButtonSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalPreferred
    {
      get => this.mPayPalPreferred;
      set
      {
        this.mPayPalPreferred = value;
        this.mPayPalPreferredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalPreferredSpecified
    {
      get => this.mPayPalPreferredSpecified;
      set => this.mPayPalPreferredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DefaultPayPalEmailAddress
    {
      get => this.mDefaultPayPalEmailAddress;
      set => this.mDefaultPayPalEmailAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PayPalAlwaysOn
    {
      get => this.mPayPalAlwaysOn;
      set
      {
        this.mPayPalAlwaysOn = value;
        this.mPayPalAlwaysOnSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PayPalAlwaysOnSpecified
    {
      get => this.mPayPalAlwaysOnSpecified;
      set => this.mPayPalAlwaysOnSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressType SellerPaymentAddress
    {
      get => this.mSellerPaymentAddress;
      set => this.mSellerPaymentAddress = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UPSRateOptionCodeType UPSRateOption
    {
      get => this.mUPSRateOption;
      set
      {
        this.mUPSRateOption = value;
        this.mUPSRateOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UPSRateOptionSpecified
    {
      get => this.mUPSRateOptionSpecified;
      set => this.mUPSRateOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public FedExRateOptionCodeType FedExRateOption
    {
      get => this.mFedExRateOption;
      set
      {
        this.mFedExRateOption = value;
        this.mFedExRateOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FedExRateOptionSpecified
    {
      get => this.mFedExRateOptionSpecified;
      set => this.mFedExRateOptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public USPSRateOptionCodeType USPSRateOption
    {
      get => this.mUSPSRateOption;
      set
      {
        this.mUSPSRateOption = value;
        this.mUSPSRateOptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool USPSRateOptionSpecified
    {
      get => this.mUSPSRateOptionSpecified;
      set => this.mUSPSRateOptionSpecified = value;
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
