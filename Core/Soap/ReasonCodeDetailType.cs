// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReasonCodeDetailType
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
  public class ReasonCodeDetailType
  {
    private string mBriefText;
    private string mDetailedText;
    private XmlElementCollection mAny;
    private long mcodeID;
    private bool mcodeIDSpecified;

    /// <summary>
    /// 
    /// </summary>
    public string BriefText
    {
      get => this.mBriefText;
      set => this.mBriefText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailedText
    {
      get => this.mDetailedText;
      set => this.mDetailedText = value;
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

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public long codeID
    {
      get => this.mcodeID;
      set
      {
        this.mcodeID = value;
        this.mcodeIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool codeIDSpecified
    {
      get => this.mcodeIDSpecified;
      set => this.mcodeIDSpecified = value;
    }
  }
}
