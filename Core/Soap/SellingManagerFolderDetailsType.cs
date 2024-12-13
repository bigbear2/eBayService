// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerFolderDetailsType
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
  public class SellingManagerFolderDetailsType
  {
    private long mFolderID;
    private bool mFolderIDSpecified;
    private long mParentFolderID;
    private bool mParentFolderIDSpecified;
    private long mFolderLevel;
    private bool mFolderLevelSpecified;
    private string mFolderName;
    private string mFolderComment;
    private SellingManagerFolderDetailsTypeCollection mChildFolder;
    private DateTime mCreationTime;
    private bool mCreationTimeSpecified;
    private XmlElementCollection mAny;

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
    public long ParentFolderID
    {
      get => this.mParentFolderID;
      set
      {
        this.mParentFolderID = value;
        this.mParentFolderIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ParentFolderIDSpecified
    {
      get => this.mParentFolderIDSpecified;
      set => this.mParentFolderIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long FolderLevel
    {
      get => this.mFolderLevel;
      set
      {
        this.mFolderLevel = value;
        this.mFolderLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FolderLevelSpecified
    {
      get => this.mFolderLevelSpecified;
      set => this.mFolderLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FolderName
    {
      get => this.mFolderName;
      set => this.mFolderName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FolderComment
    {
      get => this.mFolderComment;
      set => this.mFolderComment = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ChildFolder")]
    public SellingManagerFolderDetailsTypeCollection ChildFolder
    {
      get => this.mChildFolder;
      set => this.mChildFolder = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationTime
    {
      get => this.mCreationTime;
      set
      {
        this.mCreationTime = value;
        this.mCreationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CreationTimeSpecified
    {
      get => this.mCreationTimeSpecified;
      set => this.mCreationTimeSpecified = value;
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
