// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetVeROReportStatusRequestType
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
  public class GetVeROReportStatusRequestType : AbstractRequestType
  {
    private long mVeROReportPacketID;
    private bool mVeROReportPacketIDSpecified;
    private string mItemID;
    private bool mIncludeReportedItemDetails;
    private bool mIncludeReportedItemDetailsSpecified;
    private DateTime mTimeFrom;
    private bool mTimeFromSpecified;
    private DateTime mTimeTo;
    private bool mTimeToSpecified;
    private PaginationType mPagination;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public long VeROReportPacketID
    {
      get => this.mVeROReportPacketID;
      set
      {
        this.mVeROReportPacketID = value;
        this.mVeROReportPacketIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VeROReportPacketIDSpecified
    {
      get => this.mVeROReportPacketIDSpecified;
      set => this.mVeROReportPacketIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool IncludeReportedItemDetails
    {
      get => this.mIncludeReportedItemDetails;
      set
      {
        this.mIncludeReportedItemDetails = value;
        this.mIncludeReportedItemDetailsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeReportedItemDetailsSpecified
    {
      get => this.mIncludeReportedItemDetailsSpecified;
      set => this.mIncludeReportedItemDetailsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public DateTime TimeFrom
    {
      get => this.mTimeFrom;
      set
      {
        this.mTimeFrom = value;
        this.mTimeFromSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TimeFromSpecified
    {
      get => this.mTimeFromSpecified;
      set => this.mTimeFromSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public DateTime TimeTo
    {
      get => this.mTimeTo;
      set
      {
        this.mTimeTo = value;
        this.mTimeToSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TimeToSpecified
    {
      get => this.mTimeToSpecified;
      set => this.mTimeToSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }
  }
}
