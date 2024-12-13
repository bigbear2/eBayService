// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ListingDurationDefinitionsType
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
  public class ListingDurationDefinitionsType
  {
    private ListingDurationDefinitionTypeCollection mListingDuration;
    private int mVersion;
    private bool mVersionSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ListingDuration")]
    public ListingDurationDefinitionTypeCollection ListingDuration
    {
      get => this.mListingDuration;
      set => this.mListingDuration = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Version
    {
      get => this.mVersion;
      set
      {
        this.mVersion = value;
        this.mVersionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VersionSpecified
    {
      get => this.mVersionSpecified;
      set => this.mVersionSpecified = value;
    }
  }
}
