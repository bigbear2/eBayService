// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemRatingDetailsType
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
  public class ItemRatingDetailsType
  {
    private FeedbackRatingDetailCodeType mRatingDetail;
    private bool mRatingDetailSpecified;
    private int mRating;
    private bool mRatingSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public FeedbackRatingDetailCodeType RatingDetail
    {
      get => this.mRatingDetail;
      set
      {
        this.mRatingDetail = value;
        this.mRatingDetailSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RatingDetailSpecified
    {
      get => this.mRatingDetailSpecified;
      set => this.mRatingDetailSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Rating
    {
      get => this.mRating;
      set
      {
        this.mRating = value;
        this.mRatingSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RatingSpecified
    {
      get => this.mRatingSpecified;
      set => this.mRatingSpecified = value;
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
