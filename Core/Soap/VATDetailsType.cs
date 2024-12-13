// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VATDetailsType
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
  public class VATDetailsType
  {
    private bool mBusinessSeller;
    private bool mBusinessSellerSpecified;
    private bool mRestrictedToBusiness;
    private bool mRestrictedToBusinessSpecified;
    private float mVATPercent;
    private bool mVATPercentSpecified;
    private string mVATSite;
    private string mVATID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool BusinessSeller
    {
      get => this.mBusinessSeller;
      set
      {
        this.mBusinessSeller = value;
        this.mBusinessSellerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BusinessSellerSpecified
    {
      get => this.mBusinessSellerSpecified;
      set => this.mBusinessSellerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RestrictedToBusiness
    {
      get => this.mRestrictedToBusiness;
      set
      {
        this.mRestrictedToBusiness = value;
        this.mRestrictedToBusinessSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RestrictedToBusinessSpecified
    {
      get => this.mRestrictedToBusinessSpecified;
      set => this.mRestrictedToBusinessSpecified = value;
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
    public string VATSite
    {
      get => this.mVATSite;
      set => this.mVATSite = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string VATID
    {
      get => this.mVATID;
      set => this.mVATID = value;
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
