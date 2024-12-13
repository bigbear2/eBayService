// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DeleteSellingManagerTemplateAutomationRuleRequestType
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
  public class DeleteSellingManagerTemplateAutomationRuleRequestType : AbstractRequestType
  {
    private long mSaleTemplateID;
    private bool mSaleTemplateIDSpecified;
    private bool mDeleteAutomatedListingRule;
    private bool mDeleteAutomatedListingRuleSpecified;
    private bool mDeleteAutomatedRelistingRule;
    private bool mDeleteAutomatedRelistingRuleSpecified;
    private bool mDeleteAutomatedSecondChanceOfferRule;
    private bool mDeleteAutomatedSecondChanceOfferRuleSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public long SaleTemplateID
    {
      get => this.mSaleTemplateID;
      set
      {
        this.mSaleTemplateID = value;
        this.mSaleTemplateIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SaleTemplateIDSpecified
    {
      get => this.mSaleTemplateIDSpecified;
      set => this.mSaleTemplateIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool DeleteAutomatedListingRule
    {
      get => this.mDeleteAutomatedListingRule;
      set
      {
        this.mDeleteAutomatedListingRule = value;
        this.mDeleteAutomatedListingRuleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeleteAutomatedListingRuleSpecified
    {
      get => this.mDeleteAutomatedListingRuleSpecified;
      set => this.mDeleteAutomatedListingRuleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool DeleteAutomatedRelistingRule
    {
      get => this.mDeleteAutomatedRelistingRule;
      set
      {
        this.mDeleteAutomatedRelistingRule = value;
        this.mDeleteAutomatedRelistingRuleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeleteAutomatedRelistingRuleSpecified
    {
      get => this.mDeleteAutomatedRelistingRuleSpecified;
      set => this.mDeleteAutomatedRelistingRuleSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool DeleteAutomatedSecondChanceOfferRule
    {
      get => this.mDeleteAutomatedSecondChanceOfferRule;
      set
      {
        this.mDeleteAutomatedSecondChanceOfferRule = value;
        this.mDeleteAutomatedSecondChanceOfferRuleSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeleteAutomatedSecondChanceOfferRuleSpecified
    {
      get => this.mDeleteAutomatedSecondChanceOfferRuleSpecified;
      set => this.mDeleteAutomatedSecondChanceOfferRuleSpecified = value;
    }
  }
}
