// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetPromotionalSaleResponseType
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
  public class SetPromotionalSaleResponseType : AbstractResponseType
  {
    private PromotionalSaleStatusCodeType mStatus;
    private bool mStatusSpecified;
    private long mPromotionalSaleID;
    private bool mPromotionalSaleIDSpecified;

    /// <summary>
    /// 
    /// </summary>
    public PromotionalSaleStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long PromotionalSaleID
    {
      get => this.mPromotionalSaleID;
      set
      {
        this.mPromotionalSaleID = value;
        this.mPromotionalSaleIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PromotionalSaleIDSpecified
    {
      get => this.mPromotionalSaleIDSpecified;
      set => this.mPromotionalSaleIDSpecified = value;
    }
  }
}
