// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ThemeGroupType
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
  public class ThemeGroupType
  {
    private int mGroupID;
    private bool mGroupIDSpecified;
    private string mGroupName;
    private Int32Collection mThemeID;
    private int mThemeTotal;
    private bool mThemeTotalSpecified;
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
    public string GroupName
    {
      get => this.mGroupName;
      set => this.mGroupName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ThemeID")]
    public Int32Collection ThemeID
    {
      get => this.mThemeID;
      set => this.mThemeID = value;
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
