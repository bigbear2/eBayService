// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CancelDetailType
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
  public class CancelDetailType
  {
    private string mCancelReason;
    private string mCancelReasonDetails;
    private string mCancelIntiator;
    private DateTime mCancelIntiationDate;
    private bool mCancelIntiationDateSpecified;
    private DateTime mCancelCompleteDate;
    private bool mCancelCompleteDateSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string CancelReason
    {
      get => this.mCancelReason;
      set => this.mCancelReason = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CancelReasonDetails
    {
      get => this.mCancelReasonDetails;
      set => this.mCancelReasonDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string CancelIntiator
    {
      get => this.mCancelIntiator;
      set => this.mCancelIntiator = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CancelIntiationDate
    {
      get => this.mCancelIntiationDate;
      set
      {
        this.mCancelIntiationDate = value;
        this.mCancelIntiationDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CancelIntiationDateSpecified
    {
      get => this.mCancelIntiationDateSpecified;
      set => this.mCancelIntiationDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CancelCompleteDate
    {
      get => this.mCancelCompleteDate;
      set
      {
        this.mCancelCompleteDate = value;
        this.mCancelCompleteDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CancelCompleteDateSpecified
    {
      get => this.mCancelCompleteDateSpecified;
      set => this.mCancelCompleteDateSpecified = value;
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
