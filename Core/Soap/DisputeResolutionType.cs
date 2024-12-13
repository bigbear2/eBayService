// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DisputeResolutionType
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
  public class DisputeResolutionType
  {
    private DisputeResolutionRecordTypeCodeType mDisputeResolutionRecordType;
    private bool mDisputeResolutionRecordTypeSpecified;
    private DisputeResolutionReasonCodeType mDisputeResolutionReason;
    private bool mDisputeResolutionReasonSpecified;
    private DateTime mResolutionTime;
    private bool mResolutionTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public DisputeResolutionRecordTypeCodeType DisputeResolutionRecordType
    {
      get => this.mDisputeResolutionRecordType;
      set
      {
        this.mDisputeResolutionRecordType = value;
        this.mDisputeResolutionRecordTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeResolutionRecordTypeSpecified
    {
      get => this.mDisputeResolutionRecordTypeSpecified;
      set => this.mDisputeResolutionRecordTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DisputeResolutionReasonCodeType DisputeResolutionReason
    {
      get => this.mDisputeResolutionReason;
      set
      {
        this.mDisputeResolutionReason = value;
        this.mDisputeResolutionReasonSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisputeResolutionReasonSpecified
    {
      get => this.mDisputeResolutionReasonSpecified;
      set => this.mDisputeResolutionReasonSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ResolutionTime
    {
      get => this.mResolutionTime;
      set
      {
        this.mResolutionTime = value;
        this.mResolutionTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResolutionTimeSpecified
    {
      get => this.mResolutionTimeSpecified;
      set => this.mResolutionTimeSpecified = value;
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
