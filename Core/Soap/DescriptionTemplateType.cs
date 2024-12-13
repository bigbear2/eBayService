// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DescriptionTemplateType
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
  public class DescriptionTemplateType
  {
    private int mGroupID;
    private bool mGroupIDSpecified;
    private int mID;
    private bool mIDSpecified;
    private string mImageURL;
    private string mName;
    private string mTemplateXML;
    private DescriptionTemplateCodeType mType;
    private bool mTypeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int GroupID
    {
      get => this.mGroupID;
      set
      {
        this.mGroupID = value;
        this.mGroupIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GroupIDSpecified
    {
      get => this.mGroupIDSpecified;
      set => this.mGroupIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ID
    {
      get => this.mID;
      set
      {
        this.mID = value;
        this.mIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IDSpecified
    {
      get => this.mIDSpecified;
      set => this.mIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ImageURL
    {
      get => this.mImageURL;
      set => this.mImageURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TemplateXML
    {
      get => this.mTemplateXML;
      set => this.mTemplateXML = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DescriptionTemplateCodeType Type
    {
      get => this.mType;
      set
      {
        this.mType = value;
        this.mTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TypeSpecified
    {
      get => this.mTypeSpecified;
      set => this.mTypeSpecified = value;
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
