// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreCustomCategoryType
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
  public class StoreCustomCategoryType
  {
    private long mCategoryID;
    private string mName;
    private int mOrder;
    private bool mOrderSpecified;
    private StoreCustomCategoryTypeCollection mChildCategory;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public long CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

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
    [XmlElement("ChildCategory")]
    public StoreCustomCategoryTypeCollection ChildCategory
    {
      get => this.mChildCategory;
      set => this.mChildCategory = value;
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
