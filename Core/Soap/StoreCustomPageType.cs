// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreCustomPageType
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
  public class StoreCustomPageType
  {
    private string mName;
    private long mPageID;
    private bool mPageIDSpecified;
    private string mURLPath;
    private string mURL;
    private StoreCustomPageStatusCodeType mStatus;
    private bool mStatusSpecified;
    private string mContent;
    private bool mLeftNav;
    private bool mLeftNavSpecified;
    private bool mPreviewEnabled;
    private bool mPreviewEnabledSpecified;
    private int mOrder;
    private bool mOrderSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Name
    {
      get => this.mName;
      set => this.mName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long PageID
    {
      get => this.mPageID;
      set
      {
        this.mPageID = value;
        this.mPageIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PageIDSpecified
    {
      get => this.mPageIDSpecified;
      set => this.mPageIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string URLPath
    {
      get => this.mURLPath;
      set => this.mURLPath = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string URL
    {
      get => this.mURL;
      set => this.mURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public StoreCustomPageStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Content
    {
      get => this.mContent;
      set => this.mContent = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool LeftNav
    {
      get => this.mLeftNav;
      set
      {
        this.mLeftNav = value;
        this.mLeftNavSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LeftNavSpecified
    {
      get => this.mLeftNavSpecified;
      set => this.mLeftNavSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool PreviewEnabled
    {
      get => this.mPreviewEnabled;
      set
      {
        this.mPreviewEnabled = value;
        this.mPreviewEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PreviewEnabledSpecified
    {
      get => this.mPreviewEnabledSpecified;
      set => this.mPreviewEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Order
    {
      get => this.mOrder;
      set
      {
        this.mOrder = value;
        this.mOrderSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OrderSpecified
    {
      get => this.mOrderSpecified;
      set => this.mOrderSpecified = value;
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
