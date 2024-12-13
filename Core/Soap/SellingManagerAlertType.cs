// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAlertType
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
  public class SellingManagerAlertType
  {
    private SellingManagerAlertTypeCodeType mAlertType;
    private bool mAlertTypeSpecified;
    private SellingManagerSoldListingsPropertyTypeCodeType mSoldAlert;
    private bool mSoldAlertSpecified;
    private SellingManagerInventoryPropertyTypeCodeType mInventoryAlert;
    private bool mInventoryAlertSpecified;
    private SellingManagerAutomationPropertyTypeCodeType mAutomationAlert;
    private bool mAutomationAlertSpecified;
    private SellingManagerPaisaPayPropertyTypeCodeType mPaisaPayAlert;
    private bool mPaisaPayAlertSpecified;
    private SellingManagerGeneralPropertyTypeCodeType mGeneralAlert;
    private bool mGeneralAlertSpecified;
    private int mDurationInDays;
    private bool mDurationInDaysSpecified;
    private long mCount;
    private bool mCountSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAlertTypeCodeType AlertType
    {
      get => this.mAlertType;
      set
      {
        this.mAlertType = value;
        this.mAlertTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AlertTypeSpecified
    {
      get => this.mAlertTypeSpecified;
      set => this.mAlertTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerSoldListingsPropertyTypeCodeType SoldAlert
    {
      get => this.mSoldAlert;
      set
      {
        this.mSoldAlert = value;
        this.mSoldAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SoldAlertSpecified
    {
      get => this.mSoldAlertSpecified;
      set => this.mSoldAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerInventoryPropertyTypeCodeType InventoryAlert
    {
      get => this.mInventoryAlert;
      set
      {
        this.mInventoryAlert = value;
        this.mInventoryAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InventoryAlertSpecified
    {
      get => this.mInventoryAlertSpecified;
      set => this.mInventoryAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutomationPropertyTypeCodeType AutomationAlert
    {
      get => this.mAutomationAlert;
      set
      {
        this.mAutomationAlert = value;
        this.mAutomationAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AutomationAlertSpecified
    {
      get => this.mAutomationAlertSpecified;
      set => this.mAutomationAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerPaisaPayPropertyTypeCodeType PaisaPayAlert
    {
      get => this.mPaisaPayAlert;
      set
      {
        this.mPaisaPayAlert = value;
        this.mPaisaPayAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PaisaPayAlertSpecified
    {
      get => this.mPaisaPayAlertSpecified;
      set => this.mPaisaPayAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerGeneralPropertyTypeCodeType GeneralAlert
    {
      get => this.mGeneralAlert;
      set
      {
        this.mGeneralAlert = value;
        this.mGeneralAlertSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GeneralAlertSpecified
    {
      get => this.mGeneralAlertSpecified;
      set => this.mGeneralAlertSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int DurationInDays
    {
      get => this.mDurationInDays;
      set
      {
        this.mDurationInDays = value;
        this.mDurationInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DurationInDaysSpecified
    {
      get => this.mDurationInDaysSpecified;
      set => this.mDurationInDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long Count
    {
      get => this.mCount;
      set
      {
        this.mCount = value;
        this.mCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CountSpecified
    {
      get => this.mCountSpecified;
      set => this.mCountSpecified = value;
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
