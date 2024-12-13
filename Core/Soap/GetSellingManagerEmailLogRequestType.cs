// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellingManagerEmailLogRequestType
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
  public class GetSellingManagerEmailLogRequestType : AbstractRequestType
  {
    private string mItemID;
    private long mTransactionID;
    private bool mTransactionIDSpecified;
    private string mOrderID;
    private TimeRangeType mEmailDateRange;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public long TransactionID
    {
      get => this.mTransactionID;
      set
      {
        this.mTransactionID = value;
        this.mTransactionIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TransactionIDSpecified
    {
      get => this.mTransactionIDSpecified;
      set => this.mTransactionIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string OrderID
    {
      get => this.mOrderID;
      set => this.mOrderID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public TimeRangeType EmailDateRange
    {
      get => this.mEmailDateRange;
      set => this.mEmailDateRange = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
