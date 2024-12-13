// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyMessagesFolderSummaryType
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
  public class MyMessagesFolderSummaryType
  {
    private long mFolderID;
    private bool mFolderIDSpecified;
    private string mFolderName;
    private int mNewAlertCount;
    private bool mNewAlertCountSpecified;
    private int mNewMessageCount;
    private bool mNewMessageCountSpecified;
    private int mTotalAlertCount;
    private bool mTotalAlertCountSpecified;
    private int mTotalMessageCount;
    private bool mTotalMessageCountSpecified;
    private int mNewHighPriorityCount;
    private bool mNewHighPriorityCountSpecified;
    private int mTotalHighPriorityCount;
    private bool mTotalHighPriorityCountSpecified;
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
    public string FolderName
    {
      get => this.mFolderName;
      set => this.mFolderName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NewAlertCount
    {
      get => this.mNewAlertCount;
      set
      {
        this.mNewAlertCount = value;
        this.mNewAlertCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewAlertCountSpecified
    {
      get => this.mNewAlertCountSpecified;
      set => this.mNewAlertCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NewMessageCount
    {
      get => this.mNewMessageCount;
      set
      {
        this.mNewMessageCount = value;
        this.mNewMessageCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewMessageCountSpecified
    {
      get => this.mNewMessageCountSpecified;
      set => this.mNewMessageCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalAlertCount
    {
      get => this.mTotalAlertCount;
      set
      {
        this.mTotalAlertCount = value;
        this.mTotalAlertCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalAlertCountSpecified
    {
      get => this.mTotalAlertCountSpecified;
      set => this.mTotalAlertCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalMessageCount
    {
      get => this.mTotalMessageCount;
      set
      {
        this.mTotalMessageCount = value;
        this.mTotalMessageCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalMessageCountSpecified
    {
      get => this.mTotalMessageCountSpecified;
      set => this.mTotalMessageCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int NewHighPriorityCount
    {
      get => this.mNewHighPriorityCount;
      set
      {
        this.mNewHighPriorityCount = value;
        this.mNewHighPriorityCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewHighPriorityCountSpecified
    {
      get => this.mNewHighPriorityCountSpecified;
      set => this.mNewHighPriorityCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalHighPriorityCount
    {
      get => this.mTotalHighPriorityCount;
      set
      {
        this.mTotalHighPriorityCount = value;
        this.mTotalHighPriorityCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalHighPriorityCountSpecified
    {
      get => this.mTotalHighPriorityCountSpecified;
      set => this.mTotalHighPriorityCountSpecified = value;
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
