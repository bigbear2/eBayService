// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ItemCompatibilityType
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
  public class ItemCompatibilityType
  {
    private bool mDelete;
    private bool mDeleteSpecified;
    private NameValueListTypeCollection mNameValueList;
    private string mCompatibilityNotes;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool Delete
    {
      get => this.mDelete;
      set
      {
        this.mDelete = value;
        this.mDeleteSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DeleteSpecified
    {
      get => this.mDeleteSpecified;
      set => this.mDeleteSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("NameValueList")]
    public NameValueListTypeCollection NameValueList
    {
      get => this.mNameValueList;
      set => this.mNameValueList = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CompatibilityNotes
    {
      get => this.mCompatibilityNotes;
      set => this.mCompatibilityNotes = value;
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
