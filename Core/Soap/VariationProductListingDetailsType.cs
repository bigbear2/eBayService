// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VariationProductListingDetailsType
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
  public class VariationProductListingDetailsType
  {
    private string mISBN;
    private string mUPC;
    private string mEAN;
    private string mProductReferenceID;
    private NameValueListTypeCollection mNameValueList;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ISBN
    {
      get => this.mISBN;
      set => this.mISBN = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string UPC
    {
      get => this.mUPC;
      set => this.mUPC = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EAN
    {
      get => this.mEAN;
      set => this.mEAN = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ProductReferenceID
    {
      get => this.mProductReferenceID;
      set => this.mProductReferenceID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("NameValueList")]
    public NameValueListTypeCollection NameValueList
    {
      get => this.mNameValueList;
      set => this.mNameValueList = value;
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
