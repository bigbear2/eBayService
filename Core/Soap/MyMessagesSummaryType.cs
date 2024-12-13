// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyMessagesSummaryType
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
  public class MyMessagesSummaryType
  {
    private MyMessagesFolderSummaryTypeCollection mFolderSummary;
    private int mNewAlertCount;
    private bool mNewAlertCountSpecified;
    private int mNewMessageCount;
    private bool mNewMessageCountSpecified;
    private int mUnresolvedAlertCount;
    private bool mUnresolvedAlertCountSpecified;
    private int mFlaggedMessageCount;
    private bool mFlaggedMessageCountSpecified;
    private int mTotalAlertCount;
    private bool mTotalAlertCountSpecified;
    private int mTotalMessageCount;
    private bool mTotalMessageCountSpecified;
    private int mNewHighPriorityCount;
    private bool mNewHighPriorityCountSpecified;
    private int mTotalHighPriorityCount;
    private bool mTotalHighPriorityCountSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FolderSummary")]
    public MyMessagesFolderSummaryTypeCollection FolderSummary
    {
      get => this.mFolderSummary;
      set => this.mFolderSummary = value;
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
    public int UnresolvedAlertCount
    {
      get => this.mUnresolvedAlertCount;
      set
      {
        this.mUnresolvedAlertCount = value;
        this.mUnresolvedAlertCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UnresolvedAlertCountSpecified
    {
      get => this.mUnresolvedAlertCountSpecified;
      set => this.mUnresolvedAlertCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int FlaggedMessageCount
    {
      get => this.mFlaggedMessageCount;
      set
      {
        this.mFlaggedMessageCount = value;
        this.mFlaggedMessageCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FlaggedMessageCountSpecified
    {
      get => this.mFlaggedMessageCountSpecified;
      set => this.mFlaggedMessageCountSpecified = value;
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
  }
}
