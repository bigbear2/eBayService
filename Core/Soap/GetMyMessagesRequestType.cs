// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMyMessagesRequestType
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
  public class GetMyMessagesRequestType : AbstractRequestType
  {
    private StringCollection mAlertIDs;
    private StringCollection mMessageIDs;
    private long mFolderID;
    private bool mFolderIDSpecified;
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private StringCollection mExternalMessageIDs;
    private PaginationType mPagination;
    private bool mIncludeHighPriorityMessageOnly;
    private bool mIncludeHighPriorityMessageOnlySpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 0)]
    [XmlArrayItem("AlertID", IsNullable = false)]
    public StringCollection AlertIDs
    {
      get => this.mAlertIDs;
      set => this.mAlertIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 1)]
    [XmlArrayItem("MessageID", IsNullable = false)]
    public StringCollection MessageIDs
    {
      get => this.mMessageIDs;
      set => this.mMessageIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
    public DateTime StartTime
    {
      get => this.mStartTime;
      set
      {
        this.mStartTime = value;
        this.mStartTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeSpecified
    {
      get => this.mStartTimeSpecified;
      set => this.mStartTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public DateTime EndTime
    {
      get => this.mEndTime;
      set
      {
        this.mEndTime = value;
        this.mEndTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeSpecified
    {
      get => this.mEndTimeSpecified;
      set => this.mEndTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 5)]
    [XmlArrayItem("ExternalMessageID", IsNullable = false)]
    public StringCollection ExternalMessageIDs
    {
      get => this.mExternalMessageIDs;
      set => this.mExternalMessageIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool IncludeHighPriorityMessageOnly
    {
      get => this.mIncludeHighPriorityMessageOnly;
      set
      {
        this.mIncludeHighPriorityMessageOnly = value;
        this.mIncludeHighPriorityMessageOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeHighPriorityMessageOnlySpecified
    {
      get => this.mIncludeHighPriorityMessageOnlySpecified;
      set => this.mIncludeHighPriorityMessageOnlySpecified = value;
    }
  }
}
