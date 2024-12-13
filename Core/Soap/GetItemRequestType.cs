// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetItemRequestType
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
  public class GetItemRequestType : AbstractRequestType
  {
    private string mItemID;
    private bool mIncludeWatchCount;
    private bool mIncludeWatchCountSpecified;
    private bool mIncludeCrossPromotion;
    private bool mIncludeCrossPromotionSpecified;
    private bool mIncludeItemSpecifics;
    private bool mIncludeItemSpecificsSpecified;
    private bool mIncludeTaxTable;
    private bool mIncludeTaxTableSpecified;
    private string mSKU;
    private string mVariationSKU;
    private NameValueListTypeCollection mVariationSpecifics;
    private string mTransactionID;
    private bool mIncludeItemCompatibilityList;
    private bool mIncludeItemCompatibilityListSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool IncludeWatchCount
    {
      get => this.mIncludeWatchCount;
      set
      {
        this.mIncludeWatchCount = value;
        this.mIncludeWatchCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeWatchCountSpecified
    {
      get => this.mIncludeWatchCountSpecified;
      set => this.mIncludeWatchCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool IncludeCrossPromotion
    {
      get => this.mIncludeCrossPromotion;
      set
      {
        this.mIncludeCrossPromotion = value;
        this.mIncludeCrossPromotionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeCrossPromotionSpecified
    {
      get => this.mIncludeCrossPromotionSpecified;
      set => this.mIncludeCrossPromotionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool IncludeItemSpecifics
    {
      get => this.mIncludeItemSpecifics;
      set
      {
        this.mIncludeItemSpecifics = value;
        this.mIncludeItemSpecificsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeItemSpecificsSpecified
    {
      get => this.mIncludeItemSpecificsSpecified;
      set => this.mIncludeItemSpecificsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public bool IncludeTaxTable
    {
      get => this.mIncludeTaxTable;
      set
      {
        this.mIncludeTaxTable = value;
        this.mIncludeTaxTableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeTaxTableSpecified
    {
      get => this.mIncludeTaxTableSpecified;
      set => this.mIncludeTaxTableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public string SKU
    {
      get => this.mSKU;
      set => this.mSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public string VariationSKU
    {
      get => this.mVariationSKU;
      set => this.mVariationSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 7)]
    [XmlArrayItem("NameValueList", IsNullable = false)]
    public NameValueListTypeCollection VariationSpecifics
    {
      get => this.mVariationSpecifics;
      set => this.mVariationSpecifics = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 9)]
    public bool IncludeItemCompatibilityList
    {
      get => this.mIncludeItemCompatibilityList;
      set
      {
        this.mIncludeItemCompatibilityList = value;
        this.mIncludeItemCompatibilityListSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeItemCompatibilityListSpecified
    {
      get => this.mIncludeItemCompatibilityListSpecified;
      set => this.mIncludeItemCompatibilityListSpecified = value;
    }
  }
}
