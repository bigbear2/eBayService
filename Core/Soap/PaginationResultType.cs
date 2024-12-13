// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PaginationResultType
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
  public class PaginationResultType
  {
    private int mTotalNumberOfPages;
    private bool mTotalNumberOfPagesSpecified;
    private int mTotalNumberOfEntries;
    private bool mTotalNumberOfEntriesSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int TotalNumberOfPages
    {
      get => this.mTotalNumberOfPages;
      set
      {
        this.mTotalNumberOfPages = value;
        this.mTotalNumberOfPagesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalNumberOfPagesSpecified
    {
      get => this.mTotalNumberOfPagesSpecified;
      set => this.mTotalNumberOfPagesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int TotalNumberOfEntries
    {
      get => this.mTotalNumberOfEntries;
      set
      {
        this.mTotalNumberOfEntries = value;
        this.mTotalNumberOfEntriesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TotalNumberOfEntriesSpecified
    {
      get => this.mTotalNumberOfEntriesSpecified;
      set => this.mTotalNumberOfEntriesSpecified = value;
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
