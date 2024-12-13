// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VeROReportItemsResponseType
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
  public class VeROReportItemsResponseType : AbstractResponseType
  {
    private long mVeROReportPacketID;
    private bool mVeROReportPacketIDSpecified;
    private VeROReportPacketStatusCodeType mVeROReportPacketStatus;
    private bool mVeROReportPacketStatusSpecified;

    /// <summary>
    /// 
    /// </summary>
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
    public VeROReportPacketStatusCodeType VeROReportPacketStatus
    {
      get => this.mVeROReportPacketStatus;
      set
      {
        this.mVeROReportPacketStatus = value;
        this.mVeROReportPacketStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VeROReportPacketStatusSpecified
    {
      get => this.mVeROReportPacketStatusSpecified;
      set => this.mVeROReportPacketStatusSpecified = value;
    }
  }
}
