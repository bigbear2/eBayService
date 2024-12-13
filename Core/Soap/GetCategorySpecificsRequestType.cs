// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetCategorySpecificsRequestType
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
  public class GetCategorySpecificsRequestType : AbstractRequestType
  {
    private StringCollection mCategoryID;
    private DateTime mLastUpdateTime;
    private bool mLastUpdateTimeSpecified;
    private int mMaxNames;
    private bool mMaxNamesSpecified;
    private int mMaxValuesPerName;
    private bool mMaxValuesPerNameSpecified;
    private string mName;
    private CategoryItemSpecificsTypeCollection mCategorySpecific;
    private bool mExcludeRelationships;
    private bool mExcludeRelationshipsSpecified;
    private bool mIncludeConfidence;
    private bool mIncludeConfidenceSpecified;
    private bool mCategorySpecificsFileInfo;
    private bool mCategorySpecificsFileInfoSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CategoryID", Order = 0)]
    public StringCollection CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime LastUpdateTime
    {
      get => this.mLastUpdateTime;
      set
      {
        this.mLastUpdateTime = value;
        this.mLastUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastUpdateTimeSpecified
    {
      get => this.mLastUpdateTimeSpecified;
      set => this.mLastUpdateTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public int MaxNames
    {
      get => this.mMaxNames;
      set
      {
        this.mMaxNames = value;
        this.mMaxNamesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxNamesSpecified
    {
      get => this.mMaxNamesSpecified;
      set => this.mMaxNamesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public int MaxValuesPerName
    {
      get => this.mMaxValuesPerName;
      set
      {
        this.mMaxValuesPerName = value;
        this.mMaxValuesPerNameSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxValuesPerNameSpecified
    {
      get => this.mMaxValuesPerNameSpecified;
      set => this.mMaxValuesPerNameSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("CategorySpecific", Order = 5)]
    public CategoryItemSpecificsTypeCollection CategorySpecific
    {
      get => this.mCategorySpecific;
      set => this.mCategorySpecific = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public bool ExcludeRelationships
    {
      get => this.mExcludeRelationships;
      set
      {
        this.mExcludeRelationships = value;
        this.mExcludeRelationshipsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExcludeRelationshipsSpecified
    {
      get => this.mExcludeRelationshipsSpecified;
      set => this.mExcludeRelationshipsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool IncludeConfidence
    {
      get => this.mIncludeConfidence;
      set
      {
        this.mIncludeConfidence = value;
        this.mIncludeConfidenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeConfidenceSpecified
    {
      get => this.mIncludeConfidenceSpecified;
      set => this.mIncludeConfidenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public bool CategorySpecificsFileInfo
    {
      get => this.mCategorySpecificsFileInfo;
      set
      {
        this.mCategorySpecificsFileInfo = value;
        this.mCategorySpecificsFileInfoSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategorySpecificsFileInfoSpecified
    {
      get => this.mCategorySpecificsFileInfoSpecified;
      set => this.mCategorySpecificsFileInfoSpecified = value;
    }
  }
}
