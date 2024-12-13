// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StorefrontType
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
  public class StorefrontType
  {
    private long mStoreCategoryID;
    private long mStoreCategory2ID;
    private string mStoreCategoryName;
    private string mStoreCategory2Name;
    private string mStoreURL;
    private string mStoreName;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long StoreCategoryID
    {
      get => this.mStoreCategoryID;
      set => this.mStoreCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public long StoreCategory2ID
    {
      get => this.mStoreCategory2ID;
      set => this.mStoreCategory2ID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StoreCategoryName
    {
      get => this.mStoreCategoryName;
      set => this.mStoreCategoryName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StoreCategory2Name
    {
      get => this.mStoreCategory2Name;
      set => this.mStoreCategory2Name = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string StoreURL
    {
      get => this.mStoreURL;
      set => this.mStoreURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StoreName
    {
      get => this.mStoreName;
      set => this.mStoreName = value;
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
