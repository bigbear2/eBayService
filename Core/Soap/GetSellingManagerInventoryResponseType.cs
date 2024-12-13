// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellingManagerInventoryResponseType
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
  public class GetSellingManagerInventoryResponseType : AbstractResponseType
  {
    private DateTime mInventoryCountLastCalculatedDate;
    private bool mInventoryCountLastCalculatedDateSpecified;
    private SellingManagerProductTypeCollection mSellingManagerProduct;
    private PaginationResultType mPaginationResult;

    /// <summary>
    /// 
    /// </summary>
    public DateTime InventoryCountLastCalculatedDate
    {
      get => this.mInventoryCountLastCalculatedDate;
      set
      {
        this.mInventoryCountLastCalculatedDate = value;
        this.mInventoryCountLastCalculatedDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InventoryCountLastCalculatedDateSpecified
    {
      get => this.mInventoryCountLastCalculatedDateSpecified;
      set => this.mInventoryCountLastCalculatedDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("SellingManagerProduct")]
    public SellingManagerProductTypeCollection SellingManagerProduct
    {
      get => this.mSellingManagerProduct;
      set => this.mSellingManagerProduct = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PaginationResultType PaginationResult
    {
      get => this.mPaginationResult;
      set => this.mPaginationResult = value;
    }
  }
}
