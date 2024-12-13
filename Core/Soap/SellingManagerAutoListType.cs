// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SellingManagerAutoListType
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
  public class SellingManagerAutoListType
  {
    private long mSourceSaleTemplateID;
    private bool mSourceSaleTemplateIDSpecified;
    private SellingManagerAutoListMinActiveItemsType mKeepMinActive;
    private SellingManagerAutoListAccordingToScheduleType mListAccordingToSchedule;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long SourceSaleTemplateID
    {
      get => this.mSourceSaleTemplateID;
      set
      {
        this.mSourceSaleTemplateID = value;
        this.mSourceSaleTemplateIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SourceSaleTemplateIDSpecified
    {
      get => this.mSourceSaleTemplateIDSpecified;
      set => this.mSourceSaleTemplateIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutoListMinActiveItemsType KeepMinActive
    {
      get => this.mKeepMinActive;
      set => this.mKeepMinActive = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SellingManagerAutoListAccordingToScheduleType ListAccordingToSchedule
    {
      get => this.mListAccordingToSchedule;
      set => this.mListAccordingToSchedule = value;
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
