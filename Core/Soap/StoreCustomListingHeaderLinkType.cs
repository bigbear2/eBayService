﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreCustomListingHeaderLinkType
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
  public class StoreCustomListingHeaderLinkType
  {
    private int mLinkID;
    private int mOrder;
    private StoreCustomListingHeaderLinkCodeType mLinkType;
    private bool mLinkTypeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int LinkID
    {
      get => this.mLinkID;
      set => this.mLinkID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Order
    {
      get => this.mOrder;
      set => this.mOrder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomListingHeaderLinkCodeType LinkType
    {
      get => this.mLinkType;
      set
      {
        this.mLinkType = value;
        this.mLinkTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LinkTypeSpecified
    {
      get => this.mLinkTypeSpecified;
      set => this.mLinkTypeSpecified = value;
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
