// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerTemplateDetailsType
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
  public class SellingManagerTemplateDetailsType
  {
    private string mSaleTemplateID;
    private string mSaleTemplateName;
    private float mSuccessPercent;
    private bool mSuccessPercentSpecified;
    private SellingManagerProductDetailsType mSellingManagerProductDetails;
    private ItemType mTemplate;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string SaleTemplateID
    {
      get => this.mSaleTemplateID;
      set => this.mSaleTemplateID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SaleTemplateName
    {
      get => this.mSaleTemplateName;
      set => this.mSaleTemplateName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float SuccessPercent
    {
      get => this.mSuccessPercent;
      set
      {
        this.mSuccessPercent = value;
        this.mSuccessPercentSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SuccessPercentSpecified
    {
      get => this.mSuccessPercentSpecified;
      set => this.mSuccessPercentSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.mSellingManagerProductDetails;
      set => this.mSellingManagerProductDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ItemType Template
    {
      get => this.mTemplate;
      set => this.mTemplate = value;
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
