// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ContactHoursDetailsType
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
  public class ContactHoursDetailsType
  {
    private string mTimeZoneID;
    private DaysCodeType mHours1Days;
    private bool mHours1DaysSpecified;
    private bool mHours1AnyTime;
    private bool mHours1AnyTimeSpecified;
    private DateTime mHours1From;
    private bool mHours1FromSpecified;
    private DateTime mHours1To;
    private bool mHours1ToSpecified;
    private DaysCodeType mHours2Days;
    private bool mHours2DaysSpecified;
    private bool mHours2AnyTime;
    private bool mHours2AnyTimeSpecified;
    private DateTime mHours2From;
    private bool mHours2FromSpecified;
    private DateTime mHours2To;
    private bool mHours2ToSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string TimeZoneID
    {
      get => this.mTimeZoneID;
      set => this.mTimeZoneID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DaysCodeType Hours1Days
    {
      get => this.mHours1Days;
      set
      {
        this.mHours1Days = value;
        this.mHours1DaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours1DaysSpecified
    {
      get => this.mHours1DaysSpecified;
      set => this.mHours1DaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Hours1AnyTime
    {
      get => this.mHours1AnyTime;
      set
      {
        this.mHours1AnyTime = value;
        this.mHours1AnyTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours1AnyTimeSpecified
    {
      get => this.mHours1AnyTimeSpecified;
      set => this.mHours1AnyTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime Hours1From
    {
      get => this.mHours1From;
      set
      {
        this.mHours1From = value;
        this.mHours1FromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours1FromSpecified
    {
      get => this.mHours1FromSpecified;
      set => this.mHours1FromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime Hours1To
    {
      get => this.mHours1To;
      set
      {
        this.mHours1To = value;
        this.mHours1ToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours1ToSpecified
    {
      get => this.mHours1ToSpecified;
      set => this.mHours1ToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DaysCodeType Hours2Days
    {
      get => this.mHours2Days;
      set
      {
        this.mHours2Days = value;
        this.mHours2DaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours2DaysSpecified
    {
      get => this.mHours2DaysSpecified;
      set => this.mHours2DaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Hours2AnyTime
    {
      get => this.mHours2AnyTime;
      set
      {
        this.mHours2AnyTime = value;
        this.mHours2AnyTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours2AnyTimeSpecified
    {
      get => this.mHours2AnyTimeSpecified;
      set => this.mHours2AnyTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime Hours2From
    {
      get => this.mHours2From;
      set
      {
        this.mHours2From = value;
        this.mHours2FromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours2FromSpecified
    {
      get => this.mHours2FromSpecified;
      set => this.mHours2FromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "time")]
    public DateTime Hours2To
    {
      get => this.mHours2To;
      set
      {
        this.mHours2To = value;
        this.mHours2ToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool Hours2ToSpecified
    {
      get => this.mHours2ToSpecified;
      set => this.mHours2ToSpecified = value;
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
