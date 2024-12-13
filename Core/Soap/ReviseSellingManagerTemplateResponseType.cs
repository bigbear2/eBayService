// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseSellingManagerTemplateResponseType
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
  public class ReviseSellingManagerTemplateResponseType : AbstractResponseType
  {
    private long mSaleTemplateID;
    private bool mSaleTemplateIDSpecified;
    private FeeTypeCollection mFees;
    private string mCategoryID;
    private string mCategory2ID;
    private bool mVerifyOnly;
    private bool mVerifyOnlySpecified;
    private string mSaleTemplateName;
    private SellingManagerProductDetailsType mSellingManagerProductDetails;

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
    [XmlArrayItem("Fee", IsNullable = false)]
    public FeeTypeCollection Fees
    {
      get => this.mFees;
      set => this.mFees = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Category2ID
    {
      get => this.mCategory2ID;
      set => this.mCategory2ID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool VerifyOnly
    {
      get => this.mVerifyOnly;
      set
      {
        this.mVerifyOnly = value;
        this.mVerifyOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VerifyOnlySpecified
    {
      get => this.mVerifyOnlySpecified;
      set => this.mVerifyOnlySpecified = value;
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
  }
}
