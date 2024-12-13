// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetItemShippingRequestType
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
  public class GetItemShippingRequestType : AbstractRequestType
  {
    private string mItemID;
    private int mQuantitySold;
    private bool mQuantitySoldSpecified;
    private string mDestinationPostalCode;
    private CountryCodeType mDestinationCountryCode;
    private bool mDestinationCountryCodeSpecified;

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
    public int QuantitySold
    {
      get => this.mQuantitySold;
      set
      {
        this.mQuantitySold = value;
        this.mQuantitySoldSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool QuantitySoldSpecified
    {
      get => this.mQuantitySoldSpecified;
      set => this.mQuantitySoldSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public string DestinationPostalCode
    {
      get => this.mDestinationPostalCode;
      set => this.mDestinationPostalCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public CountryCodeType DestinationCountryCode
    {
      get => this.mDestinationCountryCode;
      set
      {
        this.mDestinationCountryCode = value;
        this.mDestinationCountryCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DestinationCountryCodeSpecified
    {
      get => this.mDestinationCountryCodeSpecified;
      set => this.mDestinationCountryCodeSpecified = value;
    }
  }
}
