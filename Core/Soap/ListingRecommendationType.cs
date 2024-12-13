// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingRecommendationType
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
  public class ListingRecommendationType
  {
    private string mType;
    private string mGroup;
    private string mFieldName;
    private string mCode;
    private StringCollection mValue;
    private string mMessage;
    private MetadataTypeCollection mMetadata;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Type
    {
      get => this.mType;
      set => this.mType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Group
    {
      get => this.mGroup;
      set => this.mGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FieldName
    {
      get => this.mFieldName;
      set => this.mFieldName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Code
    {
      get => this.mCode;
      set => this.mCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Value")]
    public StringCollection Value
    {
      get => this.mValue;
      set => this.mValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Message
    {
      get => this.mMessage;
      set => this.mMessage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Metadata")]
    public MetadataTypeCollection Metadata
    {
      get => this.mMetadata;
      set => this.mMetadata = value;
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
