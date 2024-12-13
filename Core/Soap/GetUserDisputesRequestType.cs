// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserDisputesRequestType
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
  public class GetUserDisputesRequestType : AbstractRequestType
  {
    private DisputeFilterTypeCodeType mDisputeFilterType;
    private bool mDisputeFilterTypeSpecified;
    private DisputeSortTypeCodeType mDisputeSortType;
    private bool mDisputeSortTypeSpecified;
    private DateTime mModTimeFrom;
    private bool mModTimeFromSpecified;
    private DateTime mModTimeTo;
    private bool mModTimeToSpecified;
    private PaginationType mPagination;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public DisputeFilterTypeCodeType DisputeFilterType
    {
      get => this.mDisputeFilterType;
      set
      {
        this.mDisputeFilterType = value;
        this.mDisputeFilterTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeFilterTypeSpecified
    {
      get => this.mDisputeFilterTypeSpecified;
      set => this.mDisputeFilterTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DisputeSortTypeCodeType DisputeSortType
    {
      get => this.mDisputeSortType;
      set
      {
        this.mDisputeSortType = value;
        this.mDisputeSortTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeSortTypeSpecified
    {
      get => this.mDisputeSortTypeSpecified;
      set => this.mDisputeSortTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
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
    [XmlElement(Order = 4)]
    public PaginationType Pagination
    {
      get => this.mPagination;
      set => this.mPagination = value;
    }
  }
}
