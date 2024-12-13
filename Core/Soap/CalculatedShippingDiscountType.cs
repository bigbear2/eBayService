﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CalculatedShippingDiscountType
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
  public class CalculatedShippingDiscountType
  {
    private DiscountNameCodeType mDiscountName;
    private bool mDiscountNameSpecified;
    private DiscountProfileTypeCollection mDiscountProfile;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DiscountNameCodeType DiscountName
    {
      get => this.mDiscountName;
      set
      {
        this.mDiscountName = value;
        this.mDiscountNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DiscountNameSpecified
    {
      get => this.mDiscountNameSpecified;
      set => this.mDiscountNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DiscountProfile")]
    public DiscountProfileTypeCollection DiscountProfile
    {
      get => this.mDiscountProfile;
      set => this.mDiscountProfile = value;
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
