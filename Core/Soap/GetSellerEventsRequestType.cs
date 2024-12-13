// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetSellerEventsRequestType
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
  public class GetSellerEventsRequestType : AbstractRequestType
  {
    private string mUserID;
    private DateTime mStartTimeFrom;
    private bool mStartTimeFromSpecified;
    private DateTime mStartTimeTo;
    private bool mStartTimeToSpecified;
    private DateTime mEndTimeFrom;
    private bool mEndTimeFromSpecified;
    private DateTime mEndTimeTo;
    private bool mEndTimeToSpecified;
    private DateTime mModTimeFrom;
    private bool mModTimeFromSpecified;
    private DateTime mModTimeTo;
    private bool mModTimeToSpecified;
    private bool mNewItemFilter;
    private bool mNewItemFilterSpecified;
    private bool mIncludeWatchCount;
    private bool mIncludeWatchCountSpecified;
    private bool mIncludeVariationSpecifics;
    private bool mIncludeVariationSpecificsSpecified;
    private bool mHideVariations;
    private bool mHideVariationsSpecified;

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
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
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
    [XmlElement(Order = 4)]
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
    [XmlElement(Order = 5)]
    public DateTime ModTimeFrom
    {
      get => this.mModTimeFrom;
      set
      {
        this.mModTimeFrom = value;
        this.mModTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModTimeFromSpecified
    {
      get => this.mModTimeFromSpecified;
      set => this.mModTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public DateTime ModTimeTo
    {
      get => this.mModTimeTo;
      set
      {
        this.mModTimeTo = value;
        this.mModTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ModTimeToSpecified
    {
      get => this.mModTimeToSpecified;
      set => this.mModTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public bool NewItemFilter
    {
      get => this.mNewItemFilter;
      set
      {
        this.mNewItemFilter = value;
        this.mNewItemFilterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NewItemFilterSpecified
    {
      get => this.mNewItemFilterSpecified;
      set => this.mNewItemFilterSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 8)]
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
    [XmlElement(Order = 9)]
    public bool IncludeVariationSpecifics
    {
      get => this.mIncludeVariationSpecifics;
      set
      {
        this.mIncludeVariationSpecifics = value;
        this.mIncludeVariationSpecificsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeVariationSpecificsSpecified
    {
      get => this.mIncludeVariationSpecificsSpecified;
      set => this.mIncludeVariationSpecificsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 10)]
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
