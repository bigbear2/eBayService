// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddSellingManagerTemplateResponseType
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
  public class AddSellingManagerTemplateResponseType : AbstractResponseType
  {
    private long mCategoryID;
    private bool mCategoryIDSpecified;
    private long mCategory2ID;
    private bool mCategory2IDSpecified;
    private long mSaleTemplateID;
    private bool mSaleTemplateIDSpecified;
    private long mSaleTemplateGroupID;
    private bool mSaleTemplateGroupIDSpecified;
    private string mSaleTemplateName;
    private SellingManagerProductDetailsType mSellingManagerProductDetails;
    private FeeTypeCollection mFees;

    /// <summary>
    /// 
    /// </summary>
    public long CategoryID
    {
      get => this.mCategoryID;
      set
      {
        this.mCategoryID = value;
        this.mCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryIDSpecified
    {
      get => this.mCategoryIDSpecified;
      set => this.mCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long Category2ID
    {
      get => this.mCategory2ID;
      set
      {
        this.mCategory2ID = value;
        this.mCategory2IDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Category2IDSpecified
    {
      get => this.mCategory2IDSpecified;
      set => this.mCategory2IDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
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
    public long SaleTemplateGroupID
    {
      get => this.mSaleTemplateGroupID;
      set
      {
        this.mSaleTemplateGroupID = value;
        this.mSaleTemplateGroupIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SaleTemplateGroupIDSpecified
    {
      get => this.mSaleTemplateGroupIDSpecified;
      set => this.mSaleTemplateGroupIDSpecified = value;
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
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.mSellingManagerProductDetails;
      set => this.mSellingManagerProductDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Fee", IsNullable = false)]
    public FeeTypeCollection Fees
    {
      get => this.mFees;
      set => this.mFees = value;
    }
  }
}
