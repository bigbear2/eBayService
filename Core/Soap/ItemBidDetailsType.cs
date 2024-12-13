// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemBidDetailsType
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
  public class ItemBidDetailsType
  {
    private string mItemID;
    private string mCategoryID;
    private int mBidCount;
    private bool mBidCountSpecified;
    private string mSellerID;
    private DateTime mLastBidTime;
    private bool mLastBidTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int BidCount
    {
      get => this.mBidCount;
      set
      {
        this.mBidCount = value;
        this.mBidCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool BidCountSpecified
    {
      get => this.mBidCountSpecified;
      set => this.mBidCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string SellerID
    {
      get => this.mSellerID;
      set => this.mSellerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastBidTime
    {
      get => this.mLastBidTime;
      set
      {
        this.mLastBidTime = value;
        this.mLastBidTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastBidTimeSpecified
    {
      get => this.mLastBidTimeSpecified;
      set => this.mLastBidTimeSpecified = value;
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
