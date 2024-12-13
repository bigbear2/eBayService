// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PictureSetMemberType
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
  public class PictureSetMemberType
  {
    private string mMemberURL;
    private int mPictureHeight;
    private bool mPictureHeightSpecified;
    private int mPictureWidth;
    private bool mPictureWidthSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string MemberURL
    {
      get => this.mMemberURL;
      set => this.mMemberURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PictureHeight
    {
      get => this.mPictureHeight;
      set
      {
        this.mPictureHeight = value;
        this.mPictureHeightSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureHeightSpecified
    {
      get => this.mPictureHeightSpecified;
      set => this.mPictureHeightSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int PictureWidth
    {
      get => this.mPictureWidth;
      set
      {
        this.mPictureWidth = value;
        this.mPictureWidthSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PictureWidthSpecified
    {
      get => this.mPictureWidthSpecified;
      set => this.mPictureWidthSpecified = value;
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
