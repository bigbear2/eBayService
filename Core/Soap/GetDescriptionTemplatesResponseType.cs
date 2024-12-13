// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetDescriptionTemplatesResponseType
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
  public class GetDescriptionTemplatesResponseType : AbstractResponseType
  {
    private DescriptionTemplateTypeCollection mDescriptionTemplate;
    private int mLayoutTotal;
    private bool mLayoutTotalSpecified;
    private Int32Collection mObsoleteLayoutID;
    private Int32Collection mObsoleteThemeID;
    private ThemeGroupTypeCollection mThemeGroup;
    private int mThemeTotal;
    private bool mThemeTotalSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DescriptionTemplate")]
    public DescriptionTemplateTypeCollection DescriptionTemplate
    {
      get => this.mDescriptionTemplate;
      set => this.mDescriptionTemplate = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int LayoutTotal
    {
      get => this.mLayoutTotal;
      set
      {
        this.mLayoutTotal = value;
        this.mLayoutTotalSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LayoutTotalSpecified
    {
      get => this.mLayoutTotalSpecified;
      set => this.mLayoutTotalSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ObsoleteLayoutID")]
    public Int32Collection ObsoleteLayoutID
    {
      get => this.mObsoleteLayoutID;
      set => this.mObsoleteLayoutID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ObsoleteThemeID")]
    public Int32Collection ObsoleteThemeID
    {
      get => this.mObsoleteThemeID;
      set => this.mObsoleteThemeID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ThemeGroup")]
    public ThemeGroupTypeCollection ThemeGroup
    {
      get => this.mThemeGroup;
      set => this.mThemeGroup = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ThemeTotal
    {
      get => this.mThemeTotal;
      set
      {
        this.mThemeTotal = value;
        this.mThemeTotalSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ThemeTotalSpecified
    {
      get => this.mThemeTotalSpecified;
      set => this.mThemeTotalSpecified = value;
    }
  }
}
