// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetStoreOptionsResponseType
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
  public class GetStoreOptionsResponseType : AbstractResponseType
  {
    private StoreThemeArrayType mBasicThemeArray;
    private StoreThemeArrayType mAdvancedThemeArray;
    private StoreLogoTypeCollection mLogoArray;
    private StoreSubscriptionTypeCollection mSubscriptionArray;
    private int mMaxCategories;
    private bool mMaxCategoriesSpecified;
    private int mMaxCategoryLevels;
    private bool mMaxCategoryLevelsSpecified;

    /// <summary>
    /// 
    /// </summary>
    public StoreThemeArrayType BasicThemeArray
    {
      get => this.mBasicThemeArray;
      set => this.mBasicThemeArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreThemeArrayType AdvancedThemeArray
    {
      get => this.mAdvancedThemeArray;
      set => this.mAdvancedThemeArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Logo", IsNullable = false)]
    public StoreLogoTypeCollection LogoArray
    {
      get => this.mLogoArray;
      set => this.mLogoArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArrayItem("Subscription", IsNullable = false)]
    public StoreSubscriptionTypeCollection SubscriptionArray
    {
      get => this.mSubscriptionArray;
      set => this.mSubscriptionArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxCategories
    {
      get => this.mMaxCategories;
      set
      {
        this.mMaxCategories = value;
        this.mMaxCategoriesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxCategoriesSpecified
    {
      get => this.mMaxCategoriesSpecified;
      set => this.mMaxCategoriesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxCategoryLevels
    {
      get => this.mMaxCategoryLevels;
      set
      {
        this.mMaxCategoryLevels = value;
        this.mMaxCategoryLevelsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxCategoryLevelsSpecified
    {
      get => this.mMaxCategoryLevelsSpecified;
      set => this.mMaxCategoryLevelsSpecified = value;
    }
  }
}
