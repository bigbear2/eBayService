// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.BidGroupType
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
  public class BidGroupType
  {
    private BidGroupItemTypeCollection mBidGroupItem;
    private long mBidGroupID;
    private bool mBidGroupIDSpecified;
    private string mBidGroupName;
    private BidGroupStatusCodeType mBidGroupStatus;
    private bool mBidGroupStatusSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("BidGroupItem")]
    public BidGroupItemTypeCollection BidGroupItem
    {
      get => this.mBidGroupItem;
      set => this.mBidGroupItem = value;
    }

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
    public string BidGroupName
    {
      get => this.mBidGroupName;
      set => this.mBidGroupName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public BidGroupStatusCodeType BidGroupStatus
    {
      get => this.mBidGroupStatus;
      set
      {
        this.mBidGroupStatus = value;
        this.mBidGroupStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidGroupStatusSpecified
    {
      get => this.mBidGroupStatusSpecified;
      set => this.mBidGroupStatusSpecified = value;
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
