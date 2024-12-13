// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreCustomListingHeaderType
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
  public class StoreCustomListingHeaderType
  {
    private StoreCustomListingHeaderDisplayCodeType mDisplayType;
    private bool mDisplayTypeSpecified;
    private bool mLogo;
    private bool mLogoSpecified;
    private bool mSearchBox;
    private bool mSearchBoxSpecified;
    private StoreCustomListingHeaderLinkTypeCollection mLinkToInclude;
    private bool mAddToFavoriteStores;
    private bool mAddToFavoriteStoresSpecified;
    private bool mSignUpForStoreNewsletter;
    private bool mSignUpForStoreNewsletterSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomListingHeaderDisplayCodeType DisplayType
    {
      get => this.mDisplayType;
      set
      {
        this.mDisplayType = value;
        this.mDisplayTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayTypeSpecified
    {
      get => this.mDisplayTypeSpecified;
      set => this.mDisplayTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Logo
    {
      get => this.mLogo;
      set
      {
        this.mLogo = value;
        this.mLogoSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LogoSpecified
    {
      get => this.mLogoSpecified;
      set => this.mLogoSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SearchBox
    {
      get => this.mSearchBox;
      set
      {
        this.mSearchBox = value;
        this.mSearchBoxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SearchBoxSpecified
    {
      get => this.mSearchBoxSpecified;
      set => this.mSearchBoxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LinkToInclude")]
    public StoreCustomListingHeaderLinkTypeCollection LinkToInclude
    {
      get => this.mLinkToInclude;
      set => this.mLinkToInclude = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool AddToFavoriteStores
    {
      get => this.mAddToFavoriteStores;
      set
      {
        this.mAddToFavoriteStores = value;
        this.mAddToFavoriteStoresSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddToFavoriteStoresSpecified
    {
      get => this.mAddToFavoriteStoresSpecified;
      set => this.mAddToFavoriteStoresSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SignUpForStoreNewsletter
    {
      get => this.mSignUpForStoreNewsletter;
      set
      {
        this.mSignUpForStoreNewsletter = value;
        this.mSignUpForStoreNewsletterSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SignUpForStoreNewsletterSpecified
    {
      get => this.mSignUpForStoreNewsletterSpecified;
      set => this.mSignUpForStoreNewsletterSpecified = value;
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
