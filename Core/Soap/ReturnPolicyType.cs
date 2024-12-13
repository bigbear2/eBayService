// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReturnPolicyType
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
  public class ReturnPolicyType
  {
    private string mRefundOption;
    private string mRefund;
    private string mReturnsWithinOption;
    private string mReturnsWithin;
    private string mReturnsAcceptedOption;
    private string mReturnsAccepted;
    private string mDescription;
    private string mWarrantyOfferedOption;
    private string mWarrantyOffered;
    private string mWarrantyTypeOption;
    private string mWarrantyType;
    private string mWarrantyDurationOption;
    private string mWarrantyDuration;
    private string mShippingCostPaidByOption;
    private string mShippingCostPaidBy;
    private string mRestockingFeeValue;
    private string mRestockingFeeValueOption;
    private bool mExtendedHolidayReturns;
    private bool mExtendedHolidayReturnsSpecified;
    private string mInternationalRefundOption;
    private string mInternationalReturnsAcceptedOption;
    private string mInternationalReturnsWithinOption;
    private string mInternationalShippingCostPaidByOption;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string RefundOption
    {
      get => this.mRefundOption;
      set => this.mRefundOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Refund
    {
      get => this.mRefund;
      set => this.mRefund = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ReturnsWithinOption
    {
      get => this.mReturnsWithinOption;
      set => this.mReturnsWithinOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ReturnsWithin
    {
      get => this.mReturnsWithin;
      set => this.mReturnsWithin = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ReturnsAcceptedOption
    {
      get => this.mReturnsAcceptedOption;
      set => this.mReturnsAcceptedOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ReturnsAccepted
    {
      get => this.mReturnsAccepted;
      set => this.mReturnsAccepted = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Description
    {
      get => this.mDescription;
      set => this.mDescription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string WarrantyOfferedOption
    {
      get => this.mWarrantyOfferedOption;
      set => this.mWarrantyOfferedOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string WarrantyOffered
    {
      get => this.mWarrantyOffered;
      set => this.mWarrantyOffered = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string WarrantyTypeOption
    {
      get => this.mWarrantyTypeOption;
      set => this.mWarrantyTypeOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string WarrantyType
    {
      get => this.mWarrantyType;
      set => this.mWarrantyType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string WarrantyDurationOption
    {
      get => this.mWarrantyDurationOption;
      set => this.mWarrantyDurationOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string WarrantyDuration
    {
      get => this.mWarrantyDuration;
      set => this.mWarrantyDuration = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingCostPaidByOption
    {
      get => this.mShippingCostPaidByOption;
      set => this.mShippingCostPaidByOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShippingCostPaidBy
    {
      get => this.mShippingCostPaidBy;
      set => this.mShippingCostPaidBy = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string RestockingFeeValue
    {
      get => this.mRestockingFeeValue;
      set => this.mRestockingFeeValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string RestockingFeeValueOption
    {
      get => this.mRestockingFeeValueOption;
      set => this.mRestockingFeeValueOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExtendedHolidayReturns
    {
      get => this.mExtendedHolidayReturns;
      set
      {
        this.mExtendedHolidayReturns = value;
        this.mExtendedHolidayReturnsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExtendedHolidayReturnsSpecified
    {
      get => this.mExtendedHolidayReturnsSpecified;
      set => this.mExtendedHolidayReturnsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string InternationalRefundOption
    {
      get => this.mInternationalRefundOption;
      set => this.mInternationalRefundOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string InternationalReturnsAcceptedOption
    {
      get => this.mInternationalReturnsAcceptedOption;
      set => this.mInternationalReturnsAcceptedOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string InternationalReturnsWithinOption
    {
      get => this.mInternationalReturnsWithinOption;
      set => this.mInternationalReturnsWithinOption = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string InternationalShippingCostPaidByOption
    {
      get => this.mInternationalShippingCostPaidByOption;
      set => this.mInternationalShippingCostPaidByOption = value;
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
