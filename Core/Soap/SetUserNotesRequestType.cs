// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SetUserNotesRequestType
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
  public class SetUserNotesRequestType : AbstractRequestType
  {
    private string mItemID;
    private SetUserNotesActionCodeType mAction;
    private bool mActionSpecified;
    private string mNoteText;
    private string mTransactionID;
    private NameValueListTypeCollection mVariationSpecifics;
    private string mSKU;
    private string mOrderLineItemID;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string ItemID
    {
      get => this.mItemID;
      set => this.mItemID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public SetUserNotesActionCodeType Action
    {
      get => this.mAction;
      set
      {
        this.mAction = value;
        this.mActionSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ActionSpecified
    {
      get => this.mActionSpecified;
      set => this.mActionSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string NoteText
    {
      get => this.mNoteText;
      set => this.mNoteText = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public string TransactionID
    {
      get => this.mTransactionID;
      set => this.mTransactionID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray(Order = 4)]
    [XmlArrayItem("NameValueList", IsNullable = false)]
    public NameValueListTypeCollection VariationSpecifics
    {
      get => this.mVariationSpecifics;
      set => this.mVariationSpecifics = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 5)]
    public string SKU
    {
      get => this.mSKU;
      set => this.mSKU = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 6)]
    public string OrderLineItemID
    {
      get => this.mOrderLineItemID;
      set => this.mOrderLineItemID = value;
    }
  }
}
