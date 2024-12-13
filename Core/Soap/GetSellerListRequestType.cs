// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellerListRequestType
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
  public class GetSellerListRequestType : AbstractRequestType
  {
    private string mUserID;
    private UserIDArrayType mMotorsDealerUsers;
    private DateTime mEndTimeFrom;
    private bool mEndTimeFromSpecified;
    private DateTime mEndTimeTo;
    private bool mEndTimeToSpecified;
    private int mSort;
    private bool mSortSpecified;
    private DateTime mStartTimeFrom;
    private bool mStartTimeFromSpecified;
    private DateTime mStartTimeTo;
    private bool mStartTimeToSpecified;
    private PaginationType mPagination;
    private GranularityLevelCodeType mGranularityLevel;
    private bool mGranularityLevelSpecified;
    private StringCollection mSKUArray;
    private bool mIncludeWatchCount;
    private bool mIncludeWatchCountSpecified;
    private bool mAdminEndedItemsOnly;
    private bool mAdminEndedItemsOnlySpecified;
    private int mCategoryID;
    private bool mCategoryIDSpecified;
    private bool mIncludeVariations;
    private bool mIncludeVariationsSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public UserIDArrayType MotorsDealerUsers
    {
      get => this.mMotorsDealerUsers;
      set => this.mMotorsDealerUsers = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public DateTime EndTimeFrom
    {
      get => this.mEndTimeFrom;
      set
      {
        this.mEndTimeFrom = value;
        this.mEndTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeFromSpecified
    {
      get => this.mEndTimeFromSpecified;
      set => this.mEndTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public DateTime EndTimeTo
    {
      get => this.mEndTimeTo;
      set
      {
        this.mEndTimeTo = value;
        this.mEndTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EndTimeToSpecified
    {
      get => this.mEndTimeToSpecified;
      set => this.mEndTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public int Sort
    {
      get => this.mSort;
      set
      {
        this.mSort = value;
        this.mSortSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SortSpecified
    {
      get => this.mSortSpecified;
      set => this.mSortSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public DateTime StartTimeFrom
    {
      get => this.mStartTimeFrom;
      set
      {
        this.mStartTimeFrom = value;
        this.mStartTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeFromSpecified
    {
      get => this.mStartTimeFromSpecified;
      set => this.mStartTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public DateTime StartTimeTo
    {
      get => this.mStartTimeTo;
      set
      {
        this.mStartTimeTo = value;
        this.mStartTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartTimeToSpecified
    {
      get => this.mStartTimeToSpecified;
      set => this.mStartTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
    public GranularityLevelCodeType GranularityLevel
    {
      get => this.mGranularityLevel;
      set
      {
        this.mGranularityLevel = value;
        this.mGranularityLevelSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GranularityLevelSpecified
    {
      get => this.mGranularityLevelSpecified;
      set => this.mGranularityLevelSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 9)]
    [XmlArrayItem("SKU", IsNullable = false)]
    public StringCollection SKUArray
    {
      get => this.mSKUArray;
      set => this.mSKUArray = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
    public bool IncludeWatchCount
    {
      get => this.mIncludeWatchCount;
      set
      {
        this.mIncludeWatchCount = value;
        this.mIncludeWatchCountSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeWatchCountSpecified
    {
      get => this.mIncludeWatchCountSpecified;
      set => this.mIncludeWatchCountSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 11)]
    public bool AdminEndedItemsOnly
    {
      get => this.mAdminEndedItemsOnly;
      set
      {
        this.mAdminEndedItemsOnly = value;
        this.mAdminEndedItemsOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AdminEndedItemsOnlySpecified
    {
      get => this.mAdminEndedItemsOnlySpecified;
      set => this.mAdminEndedItemsOnlySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 12)]
    public int CategoryID
    {
      get => this.mCategoryID;
      set
      {
        this.mCategoryID = value;
        this.mCategoryIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CategoryIDSpecified
    {
      get => this.mCategoryIDSpecified;
      set => this.mCategoryIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 13)]
    public bool IncludeVariations
    {
      get => this.mIncludeVariations;
      set
      {
        this.mIncludeVariations = value;
        this.mIncludeVariationsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeVariationsSpecified
    {
      get => this.mIncludeVariationsSpecified;
      set => this.mIncludeVariationsSpecified = value;
    }
  }
}
