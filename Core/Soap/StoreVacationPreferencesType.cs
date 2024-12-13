// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.StoreVacationPreferencesType
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
  public class StoreVacationPreferencesType
  {
    private bool mOnVacation;
    private bool mOnVacationSpecified;
    private DateTime mReturnDate;
    private bool mReturnDateSpecified;
    private bool mHideFixedPriceStoreItems;
    private bool mHideFixedPriceStoreItemsSpecified;
    private bool mMessageItem;
    private bool mMessageItemSpecified;
    private bool mMessageStore;
    private bool mMessageStoreSpecified;
    private bool mDisplayMessageStoreCustomText;
    private bool mDisplayMessageStoreCustomTextSpecified;
    private string mMessageStoreCustomText;

    /// <summary>
    /// 
    /// </summary>
    public bool OnVacation
    {
      get => this.mOnVacation;
      set
      {
        this.mOnVacation = value;
        this.mOnVacationSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool OnVacationSpecified
    {
      get => this.mOnVacationSpecified;
      set => this.mOnVacationSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ReturnDate
    {
      get => this.mReturnDate;
      set
      {
        this.mReturnDate = value;
        this.mReturnDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ReturnDateSpecified
    {
      get => this.mReturnDateSpecified;
      set => this.mReturnDateSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool HideFixedPriceStoreItems
    {
      get => this.mHideFixedPriceStoreItems;
      set
      {
        this.mHideFixedPriceStoreItems = value;
        this.mHideFixedPriceStoreItemsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HideFixedPriceStoreItemsSpecified
    {
      get => this.mHideFixedPriceStoreItemsSpecified;
      set => this.mHideFixedPriceStoreItemsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool MessageItem
    {
      get => this.mMessageItem;
      set
      {
        this.mMessageItem = value;
        this.mMessageItemSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageItemSpecified
    {
      get => this.mMessageItemSpecified;
      set => this.mMessageItemSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool MessageStore
    {
      get => this.mMessageStore;
      set
      {
        this.mMessageStore = value;
        this.mMessageStoreSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MessageStoreSpecified
    {
      get => this.mMessageStoreSpecified;
      set => this.mMessageStoreSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DisplayMessageStoreCustomText
    {
      get => this.mDisplayMessageStoreCustomText;
      set
      {
        this.mDisplayMessageStoreCustomText = value;
        this.mDisplayMessageStoreCustomTextSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DisplayMessageStoreCustomTextSpecified
    {
      get => this.mDisplayMessageStoreCustomTextSpecified;
      set => this.mDisplayMessageStoreCustomTextSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MessageStoreCustomText
    {
      get => this.mMessageStoreCustomText;
      set => this.mMessageStoreCustomText = value;
    }
  }
}
