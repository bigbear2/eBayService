// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PictureDetailsType
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
  public class PictureDetailsType
  {
    private GalleryTypeCodeType mGalleryType;
    private bool mGalleryTypeSpecified;
    private PhotoDisplayCodeType mPhotoDisplay;
    private bool mPhotoDisplaySpecified;
    private StringCollection mPictureURL;
    private PictureSourceCodeType mPictureSource;
    private bool mPictureSourceSpecified;
    private GalleryStatusCodeType mGalleryStatus;
    private bool mGalleryStatusSpecified;
    private string mGalleryErrorInfo;
    private StringCollection mExternalPictureURL;
    private ExtendedPictureDetailsType mExtendedPictureDetails;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public GalleryTypeCodeType GalleryType
    {
      get => this.mGalleryType;
      set
      {
        this.mGalleryType = value;
        this.mGalleryTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GalleryTypeSpecified
    {
      get => this.mGalleryTypeSpecified;
      set => this.mGalleryTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PhotoDisplayCodeType PhotoDisplay
    {
      get => this.mPhotoDisplay;
      set
      {
        this.mPhotoDisplay = value;
        this.mPhotoDisplaySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PhotoDisplaySpecified
    {
      get => this.mPhotoDisplaySpecified;
      set => this.mPhotoDisplaySpecified = value;
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
    public PictureSourceCodeType PictureSource
    {
      get => this.mPictureSource;
      set
      {
        this.mPictureSource = value;
        this.mPictureSourceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureSourceSpecified
    {
      get => this.mPictureSourceSpecified;
      set => this.mPictureSourceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public GalleryStatusCodeType GalleryStatus
    {
      get => this.mGalleryStatus;
      set
      {
        this.mGalleryStatus = value;
        this.mGalleryStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool GalleryStatusSpecified
    {
      get => this.mGalleryStatusSpecified;
      set => this.mGalleryStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string GalleryErrorInfo
    {
      get => this.mGalleryErrorInfo;
      set => this.mGalleryErrorInfo = value;
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
