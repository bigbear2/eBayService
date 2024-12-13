// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RefundFundingSourceType
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
  public class RefundFundingSourceType
  {
    private RefundingSourceTypeCodeType mRefundingSourceType;
    private bool mRefundingSourceTypeSpecified;
    private string mAccountNumber;
    private AmountType mRefundAmount;
    private string mSellerExternalTransactionID;
    private string mBuyerExternalTransactionID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public RefundingSourceTypeCodeType RefundingSourceType
    {
      get => this.mRefundingSourceType;
      set
      {
        this.mRefundingSourceType = value;
        this.mRefundingSourceTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RefundingSourceTypeSpecified
    {
      get => this.mRefundingSourceTypeSpecified;
      set => this.mRefundingSourceTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AccountNumber
    {
      get => this.mAccountNumber;
      set => this.mAccountNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType RefundAmount
    {
      get => this.mRefundAmount;
      set => this.mRefundAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerExternalTransactionID
    {
      get => this.mSellerExternalTransactionID;
      set => this.mSellerExternalTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string BuyerExternalTransactionID
    {
      get => this.mBuyerExternalTransactionID;
      set => this.mBuyerExternalTransactionID = value;
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
