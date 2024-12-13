// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseMyMessagesRequestType
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
  public class ReviseMyMessagesRequestType : AbstractRequestType
  {
    private StringCollection mMessageIDs;
    private StringCollection mAlertIDs;
    private bool mRead;
    private bool mReadSpecified;
    private bool mFlagged;
    private bool mFlaggedSpecified;
    private long mFolderID;
    private bool mFolderIDSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 0)]
    [XmlArrayItem("MessageID", IsNullable = false)]
    public StringCollection MessageIDs
    {
      get => this.mMessageIDs;
      set => this.mMessageIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 1)]
    [XmlArrayItem("AlertID", IsNullable = false)]
    public StringCollection AlertIDs
    {
      get => this.mAlertIDs;
      set => this.mAlertIDs = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool Read
    {
      get => this.mRead;
      set
      {
        this.mRead = value;
        this.mReadSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReadSpecified
    {
      get => this.mReadSpecified;
      set => this.mReadSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool Flagged
    {
      get => this.mFlagged;
      set
      {
        this.mFlagged = value;
        this.mFlaggedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FlaggedSpecified
    {
      get => this.mFlaggedSpecified;
      set => this.mFlaggedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
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
  }
}
