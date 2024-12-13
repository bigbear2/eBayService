// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.EndOfAuctionEmailPreferencesType
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
  public class EndOfAuctionEmailPreferencesType
  {
    private string mTemplateText;
    private string mLogoURL;
    private EndOfAuctionLogoTypeCodeType mLogoType;
    private bool mLogoTypeSpecified;
    private bool mEmailCustomized;
    private bool mEmailCustomizedSpecified;
    private bool mTextCustomized;
    private bool mTextCustomizedSpecified;
    private bool mLogoCustomized;
    private bool mLogoCustomizedSpecified;
    private bool mCopyEmail;
    private bool mCopyEmailSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string TemplateText
    {
      get => this.mTemplateText;
      set => this.mTemplateText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string LogoURL
    {
      get => this.mLogoURL;
      set => this.mLogoURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public EndOfAuctionLogoTypeCodeType LogoType
    {
      get => this.mLogoType;
      set
      {
        this.mLogoType = value;
        this.mLogoTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LogoTypeSpecified
    {
      get => this.mLogoTypeSpecified;
      set => this.mLogoTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool EmailCustomized
    {
      get => this.mEmailCustomized;
      set
      {
        this.mEmailCustomized = value;
        this.mEmailCustomizedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EmailCustomizedSpecified
    {
      get => this.mEmailCustomizedSpecified;
      set => this.mEmailCustomizedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool TextCustomized
    {
      get => this.mTextCustomized;
      set
      {
        this.mTextCustomized = value;
        this.mTextCustomizedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool TextCustomizedSpecified
    {
      get => this.mTextCustomizedSpecified;
      set => this.mTextCustomizedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LogoCustomized
    {
      get => this.mLogoCustomized;
      set
      {
        this.mLogoCustomized = value;
        this.mLogoCustomizedSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LogoCustomizedSpecified
    {
      get => this.mLogoCustomizedSpecified;
      set => this.mLogoCustomizedSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CopyEmail
    {
      get => this.mCopyEmail;
      set
      {
        this.mCopyEmail = value;
        this.mCopyEmailSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CopyEmailSpecified
    {
      get => this.mCopyEmailSpecified;
      set => this.mCopyEmailSpecified = value;
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
