// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RemoveFromWatchListRequestType
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
  public class RemoveFromWatchListRequestType : AbstractRequestType
  {
    private StringCollection mItemID;
    private bool mRemoveAllItems;
    private bool mRemoveAllItemsSpecified;
    private VariationKeyTypeCollection mVariationKey;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ItemID", Order = 0)]
    public StringCollection ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool RemoveAllItems
    {
      get => this.mRemoveAllItems;
      set
      {
        this.mRemoveAllItems = value;
        this.mRemoveAllItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RemoveAllItemsSpecified
    {
      get => this.mRemoveAllItemsSpecified;
      set => this.mRemoveAllItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("VariationKey", Order = 2)]
    public VariationKeyTypeCollection VariationKey
    {
      get => this.mVariationKey;
      set => this.mVariationKey = value;
    }
  }
}
