// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetVeROReasonCodeDetailsRequestType
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
  public class GetVeROReasonCodeDetailsRequestType : AbstractRequestType
  {
    private long mReasonCodeID;
    private bool mReasonCodeIDSpecified;
    private bool mReturnAllSites;
    private bool mReturnAllSitesSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public long ReasonCodeID
    {
      get => this.mReasonCodeID;
      set
      {
        this.mReasonCodeID = value;
        this.mReasonCodeIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReasonCodeIDSpecified
    {
      get => this.mReasonCodeIDSpecified;
      set => this.mReasonCodeIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool ReturnAllSites
    {
      get => this.mReturnAllSites;
      set
      {
        this.mReturnAllSites = value;
        this.mReturnAllSitesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnAllSitesSpecified
    {
      get => this.mReturnAllSitesSpecified;
      set => this.mReturnAllSitesSpecified = value;
    }
  }
}
