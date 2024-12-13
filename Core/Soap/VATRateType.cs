// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VATRateType
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
  public class VATRateType
  {
    private string mItemID;
    private string mTransactionID;
    private float mVATPercent;
    private bool mVATPercentSpecified;
    private string mOrderLineItemID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float VATPercent
    {
      get => this.mVATPercent;
      set
      {
        this.mVATPercent = value;
        this.mVATPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VATPercentSpecified
    {
      get => this.mVATPercentSpecified;
      set => this.mVATPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
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
