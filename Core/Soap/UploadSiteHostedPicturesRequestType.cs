// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UploadSiteHostedPicturesRequestType
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
  public class UploadSiteHostedPicturesRequestType : AbstractRequestType
  {
    private string mPictureName;
    private int mPictureSystemVersion;
    private bool mPictureSystemVersionSpecified;
    private PictureSetCodeType mPictureSet;
    private bool mPictureSetSpecified;
    private Base64BinaryType mPictureData;
    private PictureUploadPolicyCodeType mPictureUploadPolicy;
    private bool mPictureUploadPolicySpecified;
    private StringCollection mExternalPictureURL;
    private PictureWatermarkCodeTypeCollection mPictureWatermark;
    private int mExtensionInDays;
    private bool mExtensionInDaysSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string PictureName
    {
      get => this.mPictureName;
      set => this.mPictureName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public int PictureSystemVersion
    {
      get => this.mPictureSystemVersion;
      set
      {
        this.mPictureSystemVersion = value;
        this.mPictureSystemVersionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureSystemVersionSpecified
    {
      get => this.mPictureSystemVersionSpecified;
      set => this.mPictureSystemVersionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
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
    [XmlElement(Order = 3)]
    public Base64BinaryType PictureData
    {
      get => this.mPictureData;
      set => this.mPictureData = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 4)]
    public PictureUploadPolicyCodeType PictureUploadPolicy
    {
      get => this.mPictureUploadPolicy;
      set
      {
        this.mPictureUploadPolicy = value;
        this.mPictureUploadPolicySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureUploadPolicySpecified
    {
      get => this.mPictureUploadPolicySpecified;
      set => this.mPictureUploadPolicySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ExternalPictureURL", DataType = "anyURI", Order = 5)]
    public StringCollection ExternalPictureURL
    {
      get => this.mExternalPictureURL;
      set => this.mExternalPictureURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("PictureWatermark", Order = 6)]
    public PictureWatermarkCodeTypeCollection PictureWatermark
    {
      get => this.mPictureWatermark;
      set => this.mPictureWatermark = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 7)]
    public int ExtensionInDays
    {
      get => this.mExtensionInDays;
      set
      {
        this.mExtensionInDays = value;
        this.mExtensionInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExtensionInDaysSpecified
    {
      get => this.mExtensionInDaysSpecified;
      set => this.mExtensionInDaysSpecified = value;
    }
  }
}
