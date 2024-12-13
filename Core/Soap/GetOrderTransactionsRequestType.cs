// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetOrderTransactionsRequestType
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
  public class GetOrderTransactionsRequestType : AbstractRequestType
  {
    private ItemTransactionIDTypeCollection mItemTransactionIDArray;
    private StringCollection mOrderIDArray;
    private TransactionPlatformCodeType mPlatform;
    private bool mPlatformSpecified;
    private bool mIncludeFinalValueFees;
    private bool mIncludeFinalValueFeesSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 0)]
    [XmlArrayItem("ItemTransactionID", IsNullable = false)]
    public ItemTransactionIDTypeCollection ItemTransactionIDArray
    {
      get => this.mItemTransactionIDArray;
      set => this.mItemTransactionIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 1)]
    [XmlArrayItem("OrderID", IsNullable = false)]
    public StringCollection OrderIDArray
    {
      get => this.mOrderIDArray;
      set => this.mOrderIDArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public TransactionPlatformCodeType Platform
    {
      get => this.mPlatform;
      set
      {
        this.mPlatform = value;
        this.mPlatformSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PlatformSpecified
    {
      get => this.mPlatformSpecified;
      set => this.mPlatformSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool IncludeFinalValueFees
    {
      get => this.mIncludeFinalValueFees;
      set
      {
        this.mIncludeFinalValueFees = value;
        this.mIncludeFinalValueFeesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeFinalValueFeesSpecified
    {
      get => this.mIncludeFinalValueFeesSpecified;
      set => this.mIncludeFinalValueFeesSpecified = value;
    }
  }
}
