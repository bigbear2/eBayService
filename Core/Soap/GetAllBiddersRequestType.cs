// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetAllBiddersRequestType
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
  public class GetAllBiddersRequestType : AbstractRequestType
  {
    private string mItemID;
    private GetAllBiddersModeCodeType mCallMode;
    private bool mCallModeSpecified;
    private bool mIncludeBiddingSummary;
    private bool mIncludeBiddingSummarySpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public GetAllBiddersModeCodeType CallMode
    {
      get => this.mCallMode;
      set
      {
        this.mCallMode = value;
        this.mCallModeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CallModeSpecified
    {
      get => this.mCallModeSpecified;
      set => this.mCallModeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool IncludeBiddingSummary
    {
      get => this.mIncludeBiddingSummary;
      set
      {
        this.mIncludeBiddingSummary = value;
        this.mIncludeBiddingSummarySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeBiddingSummarySpecified
    {
      get => this.mIncludeBiddingSummarySpecified;
      set => this.mIncludeBiddingSummarySpecified = value;
    }
  }
}
