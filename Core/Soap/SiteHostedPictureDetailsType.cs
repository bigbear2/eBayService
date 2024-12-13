// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SiteHostedPictureDetailsType
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
  public class SiteHostedPictureDetailsType
  {
    private string mPictureName;
    private PictureSetCodeType mPictureSet;
    private bool mPictureSetSpecified;
    private PictureFormatCodeType mPictureFormat;
    private bool mPictureFormatSpecified;
    private string mFullURL;
    private string mBaseURL;
    private PictureSetMemberTypeCollection mPictureSetMember;
    private string mExternalPictureURL;
    private DateTime mUseByDate;
    private bool mUseByDateSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string PictureName
    {
      get => this.mPictureName;
      set => this.mPictureName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PictureSetCodeType PictureSet
    {
      get => this.mPictureSet;
      set
      {
        this.mPictureSet = value;
        this.mPictureSetSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureSetSpecified
    {
      get => this.mPictureSetSpecified;
      set => this.mPictureSetSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PictureFormatCodeType PictureFormat
    {
      get => this.mPictureFormat;
      set
      {
        this.mPictureFormat = value;
        this.mPictureFormatSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureFormatSpecified
    {
      get => this.mPictureFormatSpecified;
      set => this.mPictureFormatSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string FullURL
    {
      get => this.mFullURL;
      set => this.mFullURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string BaseURL
    {
      get => this.mBaseURL;
      set => this.mBaseURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PictureSetMember")]
    public PictureSetMemberTypeCollection PictureSetMember
    {
      get => this.mPictureSetMember;
      set => this.mPictureSetMember = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ExternalPictureURL
    {
      get => this.mExternalPictureURL;
      set => this.mExternalPictureURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UseByDate
    {
      get => this.mUseByDate;
      set
      {
        this.mUseByDate = value;
        this.mUseByDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UseByDateSpecified
    {
      get => this.mUseByDateSpecified;
      set => this.mUseByDateSpecified = value;
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
