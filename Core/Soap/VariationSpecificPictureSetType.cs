// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.VariationSpecificPictureSetType
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
  public class VariationSpecificPictureSetType
  {
    private string mVariationSpecificValue;
    private StringCollection mPictureURL;
    private string mGalleryURL;
    private StringCollection mExternalPictureURL;
    private ExtendedPictureDetailsType mExtendedPictureDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string VariationSpecificValue
    {
      get => this.mVariationSpecificValue;
      set => this.mVariationSpecificValue = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PictureURL", DataType = "anyURI")]
    public StringCollection PictureURL
    {
      get => this.mPictureURL;
      set => this.mPictureURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string GalleryURL
    {
      get => this.mGalleryURL;
      set => this.mGalleryURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExternalPictureURL", DataType = "anyURI")]
    public StringCollection ExternalPictureURL
    {
      get => this.mExternalPictureURL;
      set => this.mExternalPictureURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ExtendedPictureDetailsType ExtendedPictureDetails
    {
      get => this.mExtendedPictureDetails;
      set => this.mExtendedPictureDetails = value;
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
