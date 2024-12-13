// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreFontType
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
  public class StoreFontType
  {
    private StoreFontFaceCodeType mNameFace;
    private bool mNameFaceSpecified;
    private StoreFontSizeCodeType mNameSize;
    private bool mNameSizeSpecified;
    private string mNameColor;
    private StoreFontFaceCodeType mTitleFace;
    private bool mTitleFaceSpecified;
    private StoreFontSizeCodeType mTitleSize;
    private bool mTitleSizeSpecified;
    private string mTitleColor;
    private StoreFontFaceCodeType mDescFace;
    private bool mDescFaceSpecified;
    private StoreFontSizeCodeType mDescSize;
    private bool mDescSizeSpecified;
    private string mDescColor;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public StoreFontFaceCodeType NameFace
    {
      get => this.mNameFace;
      set
      {
        this.mNameFace = value;
        this.mNameFaceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NameFaceSpecified
    {
      get => this.mNameFaceSpecified;
      set => this.mNameFaceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreFontSizeCodeType NameSize
    {
      get => this.mNameSize;
      set
      {
        this.mNameSize = value;
        this.mNameSizeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NameSizeSpecified
    {
      get => this.mNameSizeSpecified;
      set => this.mNameSizeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string NameColor
    {
      get => this.mNameColor;
      set => this.mNameColor = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreFontFaceCodeType TitleFace
    {
      get => this.mTitleFace;
      set
      {
        this.mTitleFace = value;
        this.mTitleFaceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TitleFaceSpecified
    {
      get => this.mTitleFaceSpecified;
      set => this.mTitleFaceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreFontSizeCodeType TitleSize
    {
      get => this.mTitleSize;
      set
      {
        this.mTitleSize = value;
        this.mTitleSizeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TitleSizeSpecified
    {
      get => this.mTitleSizeSpecified;
      set => this.mTitleSizeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string TitleColor
    {
      get => this.mTitleColor;
      set => this.mTitleColor = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreFontFaceCodeType DescFace
    {
      get => this.mDescFace;
      set
      {
        this.mDescFace = value;
        this.mDescFaceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DescFaceSpecified
    {
      get => this.mDescFaceSpecified;
      set => this.mDescFaceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreFontSizeCodeType DescSize
    {
      get => this.mDescSize;
      set
      {
        this.mDescSize = value;
        this.mDescSizeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DescSizeSpecified
    {
      get => this.mDescSizeSpecified;
      set => this.mDescSizeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DescColor
    {
      get => this.mDescColor;
      set => this.mDescColor = value;
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
