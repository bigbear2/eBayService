﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MembershipDetailType
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
  public class MembershipDetailType
  {
    private string mProgramName;
    private SiteCodeType mSite;
    private bool mSiteSpecified;
    private DateTime mExpiryDate;
    private bool mExpiryDateSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ProgramName
    {
      get => this.mProgramName;
      set => this.mProgramName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SiteCodeType Site
    {
      get => this.mSite;
      set
      {
        this.mSite = value;
        this.mSiteSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SiteSpecified
    {
      get => this.mSiteSpecified;
      set => this.mSiteSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpiryDate
    {
      get => this.mExpiryDate;
      set
      {
        this.mExpiryDate = value;
        this.mExpiryDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpiryDateSpecified
    {
      get => this.mExpiryDateSpecified;
      set => this.mExpiryDateSpecified = value;
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