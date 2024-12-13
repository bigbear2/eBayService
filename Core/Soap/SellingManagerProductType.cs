// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerProductType
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
  public class SellingManagerProductType
  {
    private SellingManagerProductDetailsType mSellingManagerProductDetails;
    private SellingManagerTemplateDetailsTypeCollection mSellingManagerTemplateDetailsArray;
    private SellingManagerProductInventoryStatusType mSellingManagerProductInventoryStatus;
    private SellingManagerProductSpecificsType mSellingManagerProductSpecifics;
    private XmlElementCollection mAny;

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
    [XmlArrayItem("SellingManagerTemplateDetails", IsNullable = false)]
    public SellingManagerTemplateDetailsTypeCollection SellingManagerTemplateDetailsArray
    {
      get => this.mSellingManagerTemplateDetailsArray;
      set => this.mSellingManagerTemplateDetailsArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerProductInventoryStatusType SellingManagerProductInventoryStatus
    {
      get => this.mSellingManagerProductInventoryStatus;
      set => this.mSellingManagerProductInventoryStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerProductSpecificsType SellingManagerProductSpecifics
    {
      get => this.mSellingManagerProductSpecifics;
      set => this.mSellingManagerProductSpecifics = value;
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
