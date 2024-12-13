// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PaymentHoldDetailType
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
  public class PaymentHoldDetailType
  {
    private DateTime mExpectedReleaseDate;
    private bool mExpectedReleaseDateSpecified;
    private RequiredSellerActionCodeTypeCollection mRequiredSellerActionArray;
    private int mNumOfReqSellerActions;
    private bool mNumOfReqSellerActionsSpecified;
    private PaymentHoldReasonCodeType mPaymentHoldReason;
    private bool mPaymentHoldReasonSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpectedReleaseDate
    {
      get => this.mExpectedReleaseDate;
      set
      {
        this.mExpectedReleaseDate = value;
        this.mExpectedReleaseDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpectedReleaseDateSpecified
    {
      get => this.mExpectedReleaseDateSpecified;
      set => this.mExpectedReleaseDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("RequiredSellerAction", IsNullable = false)]
    public RequiredSellerActionCodeTypeCollection RequiredSellerActionArray
    {
      get => this.mRequiredSellerActionArray;
      set => this.mRequiredSellerActionArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NumOfReqSellerActions
    {
      get => this.mNumOfReqSellerActions;
      set
      {
        this.mNumOfReqSellerActions = value;
        this.mNumOfReqSellerActionsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NumOfReqSellerActionsSpecified
    {
      get => this.mNumOfReqSellerActionsSpecified;
      set => this.mNumOfReqSellerActionsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaymentHoldReasonCodeType PaymentHoldReason
    {
      get => this.mPaymentHoldReason;
      set
      {
        this.mPaymentHoldReason = value;
        this.mPaymentHoldReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentHoldReasonSpecified
    {
      get => this.mPaymentHoldReasonSpecified;
      set => this.mPaymentHoldReasonSpecified = value;
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
