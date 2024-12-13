// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMyeBaySellingRequestType
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
  public class GetMyeBaySellingRequestType : AbstractRequestType
  {
    private ItemListCustomizationType mScheduledList;
    private ItemListCustomizationType mActiveList;
    private ItemListCustomizationType mSoldList;
    private ItemListCustomizationType mUnsoldList;
    private ItemListCustomizationType mBidList;
    private ItemListCustomizationType mDeletedFromSoldList;
    private ItemListCustomizationType mDeletedFromUnsoldList;
    private ItemListCustomizationType mSellingSummary;
    private bool mHideVariations;
    private bool mHideVariationsSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public ItemListCustomizationType ScheduledList
    {
      get => this.mScheduledList;
      set => this.mScheduledList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public ItemListCustomizationType ActiveList
    {
      get => this.mActiveList;
      set => this.mActiveList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public ItemListCustomizationType SoldList
    {
      get => this.mSoldList;
      set => this.mSoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public ItemListCustomizationType UnsoldList
    {
      get => this.mUnsoldList;
      set => this.mUnsoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public ItemListCustomizationType BidList
    {
      get => this.mBidList;
      set => this.mBidList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public ItemListCustomizationType DeletedFromSoldList
    {
      get => this.mDeletedFromSoldList;
      set => this.mDeletedFromSoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public ItemListCustomizationType DeletedFromUnsoldList
    {
      get => this.mDeletedFromUnsoldList;
      set => this.mDeletedFromUnsoldList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public ItemListCustomizationType SellingSummary
    {
      get => this.mSellingSummary;
      set => this.mSellingSummary = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public bool HideVariations
    {
      get => this.mHideVariations;
      set
      {
        this.mHideVariations = value;
        this.mHideVariationsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HideVariationsSpecified
    {
      get => this.mHideVariationsSpecified;
      set => this.mHideVariationsSpecified = value;
    }
  }
}
