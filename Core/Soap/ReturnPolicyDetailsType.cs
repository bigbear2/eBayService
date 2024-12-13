// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReturnPolicyDetailsType
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
  public class ReturnPolicyDetailsType
  {
    private RefundDetailsTypeCollection mRefund;
    private ReturnsWithinDetailsTypeCollection mReturnsWithin;
    private ReturnsAcceptedDetailsTypeCollection mReturnsAccepted;
    private bool mDescription;
    private bool mDescriptionSpecified;
    private WarrantyOfferedDetailsTypeCollection mWarrantyOffered;
    private WarrantyTypeDetailsTypeCollection mWarrantyType;
    private WarrantyDurationDetailsTypeCollection mWarrantyDuration;
    private bool mEAN;
    private bool mEANSpecified;
    private ShippingCostPaidByDetailsTypeCollection mShippingCostPaidBy;
    private RestockingFeeValueDetailsTypeCollection mRestockingFeeValue;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Refund")]
    public RefundDetailsTypeCollection Refund
    {
      get => this.mRefund;
      set => this.mRefund = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ReturnsWithin")]
    public ReturnsWithinDetailsTypeCollection ReturnsWithin
    {
      get => this.mReturnsWithin;
      set => this.mReturnsWithin = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ReturnsAccepted")]
    public ReturnsAcceptedDetailsTypeCollection ReturnsAccepted
    {
      get => this.mReturnsAccepted;
      set => this.mReturnsAccepted = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Description
    {
      get => this.mDescription;
      set
      {
        this.mDescription = value;
        this.mDescriptionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DescriptionSpecified
    {
      get => this.mDescriptionSpecified;
      set => this.mDescriptionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("WarrantyOffered")]
    public WarrantyOfferedDetailsTypeCollection WarrantyOffered
    {
      get => this.mWarrantyOffered;
      set => this.mWarrantyOffered = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("WarrantyType")]
    public WarrantyTypeDetailsTypeCollection WarrantyType
    {
      get => this.mWarrantyType;
      set => this.mWarrantyType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("WarrantyDuration")]
    public WarrantyDurationDetailsTypeCollection WarrantyDuration
    {
      get => this.mWarrantyDuration;
      set => this.mWarrantyDuration = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EAN
    {
      get => this.mEAN;
      set
      {
        this.mEAN = value;
        this.mEANSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EANSpecified
    {
      get => this.mEANSpecified;
      set => this.mEANSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingCostPaidBy")]
    public ShippingCostPaidByDetailsTypeCollection ShippingCostPaidBy
    {
      get => this.mShippingCostPaidBy;
      set => this.mShippingCostPaidBy = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("RestockingFeeValue")]
    public RestockingFeeValueDetailsTypeCollection RestockingFeeValue
    {
      get => this.mRestockingFeeValue;
      set => this.mRestockingFeeValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
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
