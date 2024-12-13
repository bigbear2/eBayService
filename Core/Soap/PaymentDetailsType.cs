// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PaymentDetailsType
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
  public class PaymentDetailsType
  {
    private int mHoursToDeposit;
    private bool mHoursToDepositSpecified;
    private int mDaysToFullPayment;
    private bool mDaysToFullPaymentSpecified;
    private AmountType mDepositAmount;
    private DepositTypeCodeType mDepositType;
    private bool mDepositTypeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int HoursToDeposit
    {
      get => this.mHoursToDeposit;
      set
      {
        this.mHoursToDeposit = value;
        this.mHoursToDepositSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HoursToDepositSpecified
    {
      get => this.mHoursToDepositSpecified;
      set => this.mHoursToDepositSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DaysToFullPayment
    {
      get => this.mDaysToFullPayment;
      set
      {
        this.mDaysToFullPayment = value;
        this.mDaysToFullPaymentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DaysToFullPaymentSpecified
    {
      get => this.mDaysToFullPaymentSpecified;
      set => this.mDaysToFullPaymentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType DepositAmount
    {
      get => this.mDepositAmount;
      set => this.mDepositAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DepositTypeCodeType DepositType
    {
      get => this.mDepositType;
      set
      {
        this.mDepositType = value;
        this.mDepositTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DepositTypeSpecified
    {
      get => this.mDepositTypeSpecified;
      set => this.mDepositTypeSpecified = value;
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
