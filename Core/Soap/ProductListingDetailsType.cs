// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ProductListingDetailsType
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
  public class ProductListingDetailsType
  {
    private bool mIncludeStockPhotoURL;
    private bool mIncludeStockPhotoURLSpecified;
    private bool mUseStockPhotoURLAsGallery;
    private bool mUseStockPhotoURLAsGallerySpecified;
    private string mStockPhotoURL;
    private StringCollection mCopyright;
    private string mProductReferenceID;
    private string mDetailsURL;
    private string mProductDetailsURL;
    private bool mReturnSearchResultOnDuplicates;
    private bool mReturnSearchResultOnDuplicatesSpecified;
    private string mISBN;
    private string mUPC;
    private string mEAN;
    private BrandMPNType mBrandMPN;
    private TicketListingDetailsType mTicketListingDetails;
    private bool mUseFirstProduct;
    private bool mUseFirstProductSpecified;
    private bool mIncludeeBayProductDetails;
    private bool mIncludeeBayProductDetailsSpecified;
    private NameValueListTypeCollection mNameValueList;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeStockPhotoURL
    {
      get => this.mIncludeStockPhotoURL;
      set
      {
        this.mIncludeStockPhotoURL = value;
        this.mIncludeStockPhotoURLSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeStockPhotoURLSpecified
    {
      get => this.mIncludeStockPhotoURLSpecified;
      set => this.mIncludeStockPhotoURLSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UseStockPhotoURLAsGallery
    {
      get => this.mUseStockPhotoURLAsGallery;
      set
      {
        this.mUseStockPhotoURLAsGallery = value;
        this.mUseStockPhotoURLAsGallerySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UseStockPhotoURLAsGallerySpecified
    {
      get => this.mUseStockPhotoURLAsGallerySpecified;
      set => this.mUseStockPhotoURLAsGallerySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string StockPhotoURL
    {
      get => this.mStockPhotoURL;
      set => this.mStockPhotoURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Copyright")]
    public StringCollection Copyright
    {
      get => this.mCopyright;
      set => this.mCopyright = value;
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
    [XmlElement(DataType = "anyURI")]
    public string DetailsURL
    {
      get => this.mDetailsURL;
      set => this.mDetailsURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ProductDetailsURL
    {
      get => this.mProductDetailsURL;
      set => this.mProductDetailsURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ReturnSearchResultOnDuplicates
    {
      get => this.mReturnSearchResultOnDuplicates;
      set
      {
        this.mReturnSearchResultOnDuplicates = value;
        this.mReturnSearchResultOnDuplicatesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnSearchResultOnDuplicatesSpecified
    {
      get => this.mReturnSearchResultOnDuplicatesSpecified;
      set => this.mReturnSearchResultOnDuplicatesSpecified = value;
    }

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
    public BrandMPNType BrandMPN
    {
      get => this.mBrandMPN;
      set => this.mBrandMPN = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public TicketListingDetailsType TicketListingDetails
    {
      get => this.mTicketListingDetails;
      set => this.mTicketListingDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool UseFirstProduct
    {
      get => this.mUseFirstProduct;
      set
      {
        this.mUseFirstProduct = value;
        this.mUseFirstProductSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UseFirstProductSpecified
    {
      get => this.mUseFirstProductSpecified;
      set => this.mUseFirstProductSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeeBayProductDetails
    {
      get => this.mIncludeeBayProductDetails;
      set
      {
        this.mIncludeeBayProductDetails = value;
        this.mIncludeeBayProductDetailsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeeBayProductDetailsSpecified
    {
      get => this.mIncludeeBayProductDetailsSpecified;
      set => this.mIncludeeBayProductDetailsSpecified = value;
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
