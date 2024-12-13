// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetStoreCategoriesRequestType
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
  public class SetStoreCategoriesRequestType : AbstractRequestType
  {
    private StoreCategoryUpdateActionCodeType mAction;
    private bool mActionSpecified;
    private long mItemDestinationCategoryID;
    private bool mItemDestinationCategoryIDSpecified;
    private long mDestinationParentCategoryID;
    private bool mDestinationParentCategoryIDSpecified;
    private StoreCustomCategoryTypeCollection mStoreCategories;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public StoreCategoryUpdateActionCodeType Action
    {
      get => this.mAction;
      set
      {
        this.mAction = value;
        this.mActionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionSpecified
    {
      get => this.mActionSpecified;
      set => this.mActionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public long ItemDestinationCategoryID
    {
      get => this.mItemDestinationCategoryID;
      set
      {
        this.mItemDestinationCategoryID = value;
        this.mItemDestinationCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ItemDestinationCategoryIDSpecified
    {
      get => this.mItemDestinationCategoryIDSpecified;
      set => this.mItemDestinationCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public long DestinationParentCategoryID
    {
      get => this.mDestinationParentCategoryID;
      set
      {
        this.mDestinationParentCategoryID = value;
        this.mDestinationParentCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DestinationParentCategoryIDSpecified
    {
      get => this.mDestinationParentCategoryIDSpecified;
      set => this.mDestinationParentCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 3)]
    [XmlArrayItem("CustomCategory", IsNullable = false)]
    public StoreCustomCategoryTypeCollection StoreCategories
    {
      get => this.mStoreCategories;
      set => this.mStoreCategories = value;
    }
  }
}
