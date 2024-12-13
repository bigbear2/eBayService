// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerProductDetailsType
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
  public class SellingManagerProductDetailsType
  {
    private string mProductName;
    private long mProductID;
    private bool mProductIDSpecified;
    private string mCustomLabel;
    private int mQuantityAvailable;
    private bool mQuantityAvailableSpecified;
    private AmountType mUnitCost;
    private long mFolderID;
    private bool mFolderIDSpecified;
    private bool mRestockAlert;
    private bool mRestockAlertSpecified;
    private int mRestockThreshold;
    private bool mRestockThresholdSpecified;
    private SellingManagerVendorDetailsType mVendorInfo;
    private string mNote;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ProductName
    {
      get => this.mProductName;
      set => this.mProductName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long ProductID
    {
      get => this.mProductID;
      set
      {
        this.mProductID = value;
        this.mProductIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProductIDSpecified
    {
      get => this.mProductIDSpecified;
      set => this.mProductIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CustomLabel
    {
      get => this.mCustomLabel;
      set => this.mCustomLabel = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int QuantityAvailable
    {
      get => this.mQuantityAvailable;
      set
      {
        this.mQuantityAvailable = value;
        this.mQuantityAvailableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantityAvailableSpecified
    {
      get => this.mQuantityAvailableSpecified;
      set => this.mQuantityAvailableSpecified = value;
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
    public long FolderID
    {
      get => this.mFolderID;
      set
      {
        this.mFolderID = value;
        this.mFolderIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FolderIDSpecified
    {
      get => this.mFolderIDSpecified;
      set => this.mFolderIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool RestockAlert
    {
      get => this.mRestockAlert;
      set
      {
        this.mRestockAlert = value;
        this.mRestockAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RestockAlertSpecified
    {
      get => this.mRestockAlertSpecified;
      set => this.mRestockAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int RestockThreshold
    {
      get => this.mRestockThreshold;
      set
      {
        this.mRestockThreshold = value;
        this.mRestockThresholdSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RestockThresholdSpecified
    {
      get => this.mRestockThresholdSpecified;
      set => this.mRestockThresholdSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerVendorDetailsType VendorInfo
    {
      get => this.mVendorInfo;
      set => this.mVendorInfo = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Note
    {
      get => this.mNote;
      set => this.mNote = value;
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
