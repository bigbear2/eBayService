// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PromotedItemType
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
  public class PromotedItemType
  {
    private string mItemID;
    private string mPictureURL;
    private int mPosition;
    private bool mPositionSpecified;
    private PromotionItemSelectionCodeType mSelectionType;
    private bool mSelectionTypeSpecified;
    private string mTitle;
    private ListingTypeCodeType mListingType;
    private bool mListingTypeSpecified;
    private PromotionDetailsTypeCollection mPromotionDetails;
    private string mTimeLeft;
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
    public string PictureURL
    {
      get => this.mPictureURL;
      set => this.mPictureURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Position
    {
      get => this.mPosition;
      set
      {
        this.mPosition = value;
        this.mPositionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PositionSpecified
    {
      get => this.mPositionSpecified;
      set => this.mPositionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PromotionItemSelectionCodeType SelectionType
    {
      get => this.mSelectionType;
      set
      {
        this.mSelectionType = value;
        this.mSelectionTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SelectionTypeSpecified
    {
      get => this.mSelectionTypeSpecified;
      set => this.mSelectionTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Title
    {
      get => this.mTitle;
      set => this.mTitle = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingTypeCodeType ListingType
    {
      get => this.mListingType;
      set
      {
        this.mListingType = value;
        this.mListingTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ListingTypeSpecified
    {
      get => this.mListingTypeSpecified;
      set => this.mListingTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PromotionDetails")]
    public PromotionDetailsTypeCollection PromotionDetails
    {
      get => this.mPromotionDetails;
      set => this.mPromotionDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "duration")]
    public string TimeLeft
    {
      get => this.mTimeLeft;
      set => this.mTimeLeft = value;
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
