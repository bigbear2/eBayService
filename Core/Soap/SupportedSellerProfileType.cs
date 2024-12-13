// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SupportedSellerProfileType
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
  public class SupportedSellerProfileType
  {
    private long mProfileID;
    private bool mProfileIDSpecified;
    private string mProfileType;
    private string mProfileName;
    private string mShortSummary;
    private CategoryGroupType mCategoryGroup;

    /// <summary>
    /// 
    /// </summary>
    public long ProfileID
    {
      get => this.mProfileID;
      set
      {
        this.mProfileID = value;
        this.mProfileIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProfileIDSpecified
    {
      get => this.mProfileIDSpecified;
      set => this.mProfileIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ProfileType
    {
      get => this.mProfileType;
      set => this.mProfileType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ProfileName
    {
      get => this.mProfileName;
      set => this.mProfileName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ShortSummary
    {
      get => this.mShortSummary;
      set => this.mShortSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CategoryGroupType CategoryGroup
    {
      get => this.mCategoryGroup;
      set => this.mCategoryGroup = value;
    }
  }
}
