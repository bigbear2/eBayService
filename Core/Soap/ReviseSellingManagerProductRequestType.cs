// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseSellingManagerProductRequestType
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
  public class ReviseSellingManagerProductRequestType : AbstractRequestType
  {
    private SellingManagerProductDetailsType mSellingManagerProductDetails;
    private SellingManagerFolderDetailsType mSellingManagerFolderDetails;
    private StringCollection mDeletedField;
    private SellingManagerProductSpecificsType mSellingManagerProductSpecifics;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public SellingManagerProductDetailsType SellingManagerProductDetails
    {
      get => this.mSellingManagerProductDetails;
      set => this.mSellingManagerProductDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public SellingManagerFolderDetailsType SellingManagerFolderDetails
    {
      get => this.mSellingManagerFolderDetails;
      set => this.mSellingManagerFolderDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DeletedField", Order = 2)]
    public StringCollection DeletedField
    {
      get => this.mDeletedField;
      set => this.mDeletedField = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public SellingManagerProductSpecificsType SellingManagerProductSpecifics
    {
      get => this.mSellingManagerProductSpecifics;
      set => this.mSellingManagerProductSpecifics = value;
    }
  }
}
