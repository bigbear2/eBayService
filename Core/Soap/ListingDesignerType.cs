// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingDesignerType
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
  public class ListingDesignerType
  {
    private int mLayoutID;
    private bool mLayoutIDSpecified;
    private bool mOptimalPictureSize;
    private bool mOptimalPictureSizeSpecified;
    private int mThemeID;
    private bool mThemeIDSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public int LayoutID
    {
      get => this.mLayoutID;
      set
      {
        this.mLayoutID = value;
        this.mLayoutIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LayoutIDSpecified
    {
      get => this.mLayoutIDSpecified;
      set => this.mLayoutIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool OptimalPictureSize
    {
      get => this.mOptimalPictureSize;
      set
      {
        this.mOptimalPictureSize = value;
        this.mOptimalPictureSizeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OptimalPictureSizeSpecified
    {
      get => this.mOptimalPictureSizeSpecified;
      set => this.mOptimalPictureSizeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ThemeID
    {
      get => this.mThemeID;
      set
      {
        this.mThemeID = value;
        this.mThemeIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ThemeIDSpecified
    {
      get => this.mThemeIDSpecified;
      set => this.mThemeIDSpecified = value;
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
