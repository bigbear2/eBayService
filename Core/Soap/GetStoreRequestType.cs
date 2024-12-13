// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetStoreRequestType
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
  public class GetStoreRequestType : AbstractRequestType
  {
    private bool mCategoryStructureOnly;
    private bool mCategoryStructureOnlySpecified;
    private long mRootCategoryID;
    private bool mRootCategoryIDSpecified;
    private int mLevelLimit;
    private bool mLevelLimitSpecified;
    private string mUserID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public bool CategoryStructureOnly
    {
      get => this.mCategoryStructureOnly;
      set
      {
        this.mCategoryStructureOnly = value;
        this.mCategoryStructureOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryStructureOnlySpecified
    {
      get => this.mCategoryStructureOnlySpecified;
      set => this.mCategoryStructureOnlySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public long RootCategoryID
    {
      get => this.mRootCategoryID;
      set
      {
        this.mRootCategoryID = value;
        this.mRootCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RootCategoryIDSpecified
    {
      get => this.mRootCategoryIDSpecified;
      set => this.mRootCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public int LevelLimit
    {
      get => this.mLevelLimit;
      set
      {
        this.mLevelLimit = value;
        this.mLevelLimitSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LevelLimitSpecified
    {
      get => this.mLevelLimitSpecified;
      set => this.mLevelLimitSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }
  }
}
