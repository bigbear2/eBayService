// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.PickupMethodSelectedType
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
  public class PickupMethodSelectedType
  {
    private string mPickupMethod;
    private string mPickupStoreID;
    private PickupStatusCodeType mPickupStatus;
    private bool mPickupStatusSpecified;
    private string mMerchantPickupCode;
    private DateTime mPickupFulfillmentTime;
    private bool mPickupFulfillmentTimeSpecified;
    private string mPickupLocationUUID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string PickupMethod
    {
      get => this.mPickupMethod;
      set => this.mPickupMethod = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PickupStoreID
    {
      get => this.mPickupStoreID;
      set => this.mPickupStoreID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public PickupStatusCodeType PickupStatus
    {
      get => this.mPickupStatus;
      set
      {
        this.mPickupStatus = value;
        this.mPickupStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PickupStatusSpecified
    {
      get => this.mPickupStatusSpecified;
      set => this.mPickupStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MerchantPickupCode
    {
      get => this.mMerchantPickupCode;
      set => this.mMerchantPickupCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PickupFulfillmentTime
    {
      get => this.mPickupFulfillmentTime;
      set
      {
        this.mPickupFulfillmentTime = value;
        this.mPickupFulfillmentTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PickupFulfillmentTimeSpecified
    {
      get => this.mPickupFulfillmentTimeSpecified;
      set => this.mPickupFulfillmentTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PickupLocationUUID
    {
      get => this.mPickupLocationUUID;
      set => this.mPickupLocationUUID = value;
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
