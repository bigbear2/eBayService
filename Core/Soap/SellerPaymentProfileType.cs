﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellerPaymentProfileType
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
  public class SellerPaymentProfileType
  {
    private long mPaymentProfileID;
    private bool mPaymentProfileIDSpecified;
    private string mPaymentProfileName;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long PaymentProfileID
    {
      get => this.mPaymentProfileID;
      set
      {
        this.mPaymentProfileID = value;
        this.mPaymentProfileIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaymentProfileIDSpecified
    {
      get => this.mPaymentProfileIDSpecified;
      set => this.mPaymentProfileIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PaymentProfileName
    {
      get => this.mPaymentProfileName;
      set => this.mPaymentProfileName = value;
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