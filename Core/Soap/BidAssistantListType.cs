// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BidAssistantListType
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
  public class BidAssistantListType
  {
    private long mBidGroupID;
    private bool mBidGroupIDSpecified;
    private bool mIncludeNotes;
    private bool mIncludeNotesSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long BidGroupID
    {
      get => this.mBidGroupID;
      set
      {
        this.mBidGroupID = value;
        this.mBidGroupIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidGroupIDSpecified
    {
      get => this.mBidGroupIDSpecified;
      set => this.mBidGroupIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool IncludeNotes
    {
      get => this.mIncludeNotes;
      set
      {
        this.mIncludeNotes = value;
        this.mIncludeNotesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeNotesSpecified
    {
      get => this.mIncludeNotesSpecified;
      set => this.mIncludeNotesSpecified = value;
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
