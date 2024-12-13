// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VariationType
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
  public class VariationType
  {
    private string mSKU;
    private AmountType mStartPrice;
    private int mQuantity;
    private bool mQuantitySpecified;
    private NameValueListTypeCollection mVariationSpecifics;
    private int mUnitsAvailable;
    private bool mUnitsAvailableSpecified;
    private AmountType mUnitCost;
    private SellingStatusType mSellingStatus;
    private string mVariationTitle;
    private string mVariationViewItemURL;
    private bool mDelete;
    private SellingManagerProductInventoryStatusType mSellingManagerProductInventoryStatus;
    private long mWatchCount;
    private bool mWatchCountSpecified;
    private string mPrivateNotes;
    private DiscountPriceInfoType mDiscountPriceInfo;
    private VariationProductListingDetailsType mVariationProductListingDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public VariationType() => this.Delete = false;

    /// <summary>
    /// 
    /// </summary>
    public string SKU
    {
      get => this.mSKU;
      set => this.mSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType StartPrice
    {
      get => this.mStartPrice;
      set => this.mStartPrice = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Quantity
    {
      get => this.mQuantity;
      set
      {
        this.mQuantity = value;
        this.mQuantitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySpecified
    {
      get => this.mQuantitySpecified;
      set => this.mQuantitySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("NameValueList", IsNullable = false)]
    public NameValueListTypeCollection VariationSpecifics
    {
      get => this.mVariationSpecifics;
      set => this.mVariationSpecifics = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int UnitsAvailable
    {
      get => this.mUnitsAvailable;
      set
      {
        this.mUnitsAvailable = value;
        this.mUnitsAvailableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UnitsAvailableSpecified
    {
      get => this.mUnitsAvailableSpecified;
      set => this.mUnitsAvailableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType UnitCost
    {
      get => this.mUnitCost;
      set => this.mUnitCost = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingStatusType SellingStatus
    {
      get => this.mSellingStatus;
      set => this.mSellingStatus = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string VariationTitle
    {
      get => this.mVariationTitle;
      set => this.mVariationTitle = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string VariationViewItemURL
    {
      get => this.mVariationViewItemURL;
      set => this.mVariationViewItemURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [DefaultValue(false)]
    public bool Delete
    {
      get => this.mDelete;
      set => this.mDelete = value;
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
    public long WatchCount
    {
      get => this.mWatchCount;
      set
      {
        this.mWatchCount = value;
        this.mWatchCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WatchCountSpecified
    {
      get => this.mWatchCountSpecified;
      set => this.mWatchCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PrivateNotes
    {
      get => this.mPrivateNotes;
      set => this.mPrivateNotes = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DiscountPriceInfoType DiscountPriceInfo
    {
      get => this.mDiscountPriceInfo;
      set => this.mDiscountPriceInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationProductListingDetailsType VariationProductListingDetails
    {
      get => this.mVariationProductListingDetails;
      set => this.mVariationProductListingDetails = value;
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
