﻿// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddItemResponseContainerType
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
  public class AddItemResponseContainerType
  {
    private string mItemID;
    private DateTime mStartTime;
    private bool mStartTimeSpecified;
    private DateTime mEndTime;
    private bool mEndTimeSpecified;
    private FeeTypeCollection mFees;
    private string mCategoryID;
    private string mCategory2ID;
    private string mCorrelationID;
    private ErrorTypeCollection mErrors;
    private string mMessage;
    private DiscountReasonCodeTypeCollection mDiscountReason;
    private ListingRecommendationsType mListingRecommendations;
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
    [XmlArrayItem("Fee", IsNullable = false)]
    public FeeTypeCollection Fees
    {
      get => this.mFees;
      set => this.mFees = value;
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
    public string Category2ID
    {
      get => this.mCategory2ID;
      set => this.mCategory2ID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CorrelationID
    {
      get => this.mCorrelationID;
      set => this.mCorrelationID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Errors")]
    public ErrorTypeCollection Errors
    {
      get => this.mErrors;
      set => this.mErrors = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Message
    {
      get => this.mMessage;
      set => this.mMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DiscountReason")]
    public DiscountReasonCodeTypeCollection DiscountReason
    {
      get => this.mDiscountReason;
      set => this.mDiscountReason = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ListingRecommendationsType ListingRecommendations
    {
      get => this.mListingRecommendations;
      set => this.mListingRecommendations = value;
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