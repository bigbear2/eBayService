// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReviseItemRequestType
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
  public class ReviseItemRequestType : AbstractRequestType
  {
    private ItemType mItem;
    private StringCollection mDeletedField;
    private bool mVerifyOnly;
    private bool mVerifyOnlySpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public ItemType Item
    {
      get => this.mItem;
      set => this.mItem = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DeletedField", Order = 1)]
    public StringCollection DeletedField
    {
      get => this.mDeletedField;
      set => this.mDeletedField = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool VerifyOnly
    {
      get => this.mVerifyOnly;
      set
      {
        this.mVerifyOnly = value;
        this.mVerifyOnlySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VerifyOnlySpecified
    {
      get => this.mVerifyOnlySpecified;
      set => this.mVerifyOnlySpecified = value;
    }
  }
}
