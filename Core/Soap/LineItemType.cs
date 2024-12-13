﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.LineItemType
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
  public class LineItemType
  {
    private int mQuantity;
    private bool mQuantitySpecified;
    private string mCountryOfOrigin;
    private string mDescription;
    private string mItemID;
    private string mTransactionID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int Quantity
    {
      get => this.mQuantity;
      set
      {
        this.mQuantity = value;
        this.mQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySpecified
    {
      get => this.mQuantitySpecified;
      set => this.mQuantitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CountryOfOrigin
    {
      get => this.mCountryOfOrigin;
      set => this.mCountryOfOrigin = value;
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
    [XmlAnyElement]
    public XmlElementCollection Any
    {
      get => this.mAny;
      set => this.mAny = value;
    }
  }
}