// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.NonProfitAddressType
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
  public class NonProfitAddressType
  {
    private string mAddressLine1;
    private string mAddressLine2;
    private string mCity;
    private string mState;
    private string mZipCode;
    private Decimal mLatitude;
    private bool mLatitudeSpecified;
    private Decimal mLongitude;
    private bool mLongitudeSpecified;
    private AddressTypeCodeType mAddressType;
    private bool mAddressTypeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string AddressLine1
    {
      get => this.mAddressLine1;
      set => this.mAddressLine1 = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AddressLine2
    {
      get => this.mAddressLine2;
      set => this.mAddressLine2 = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string City
    {
      get => this.mCity;
      set => this.mCity = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string State
    {
      get => this.mState;
      set => this.mState = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ZipCode
    {
      get => this.mZipCode;
      set => this.mZipCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Decimal Latitude
    {
      get => this.mLatitude;
      set
      {
        this.mLatitude = value;
        this.mLatitudeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LatitudeSpecified
    {
      get => this.mLatitudeSpecified;
      set => this.mLatitudeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public Decimal Longitude
    {
      get => this.mLongitude;
      set
      {
        this.mLongitude = value;
        this.mLongitudeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LongitudeSpecified
    {
      get => this.mLongitudeSpecified;
      set => this.mLongitudeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressTypeCodeType AddressType
    {
      get => this.mAddressType;
      set
      {
        this.mAddressType = value;
        this.mAddressTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddressTypeSpecified
    {
      get => this.mAddressTypeSpecified;
      set => this.mAddressTypeSpecified = value;
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
