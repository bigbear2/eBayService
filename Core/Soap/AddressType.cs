// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.AddressType
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
  public class AddressType
  {
    private string mName;
    private string mStreet;
    private string mStreet1;
    private string mStreet2;
    private string mCityName;
    private string mCounty;
    private string mStateOrProvince;
    private CountryCodeType mCountry;
    private bool mCountrySpecified;
    private string mCountryName;
    private string mPhone;
    private CountryCodeType mPhoneCountryCode;
    private bool mPhoneCountryCodeSpecified;
    private string mPhoneCountryPrefix;
    private string mPhoneAreaOrCityCode;
    private string mPhoneLocalNumber;
    private string mPostalCode;
    private string mAddressID;
    private AddressOwnerCodeType mAddressOwner;
    private bool mAddressOwnerSpecified;
    private AddressStatusCodeType mAddressStatus;
    private bool mAddressStatusSpecified;
    private string mExternalAddressID;
    private string mInternationalName;
    private string mInternationalStateAndCity;
    private string mInternationalStreet;
    private string mCompanyName;
    private AddressRecordTypeCodeType mAddressRecordType;
    private bool mAddressRecordTypeSpecified;
    private string mFirstName;
    private string mLastName;
    private string mPhone2;
    private AddressUsageCodeType mAddressUsage;
    private bool mAddressUsageSpecified;
    private string mReferenceID;
    private AddressAttributeTypeCollection mAddressAttribute;
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
    public string Street
    {
      get => this.mStreet;
      set => this.mStreet = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Street1
    {
      get => this.mStreet1;
      set => this.mStreet1 = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Street2
    {
      get => this.mStreet2;
      set => this.mStreet2 = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CityName
    {
      get => this.mCityName;
      set => this.mCityName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string County
    {
      get => this.mCounty;
      set => this.mCounty = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string StateOrProvince
    {
      get => this.mStateOrProvince;
      set => this.mStateOrProvince = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryCodeType Country
    {
      get => this.mCountry;
      set
      {
        this.mCountry = value;
        this.mCountrySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CountrySpecified
    {
      get => this.mCountrySpecified;
      set => this.mCountrySpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CountryName
    {
      get => this.mCountryName;
      set => this.mCountryName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Phone
    {
      get => this.mPhone;
      set => this.mPhone = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CountryCodeType PhoneCountryCode
    {
      get => this.mPhoneCountryCode;
      set
      {
        this.mPhoneCountryCode = value;
        this.mPhoneCountryCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PhoneCountryCodeSpecified
    {
      get => this.mPhoneCountryCodeSpecified;
      set => this.mPhoneCountryCodeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PhoneCountryPrefix
    {
      get => this.mPhoneCountryPrefix;
      set => this.mPhoneCountryPrefix = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PhoneAreaOrCityCode
    {
      get => this.mPhoneAreaOrCityCode;
      set => this.mPhoneAreaOrCityCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PhoneLocalNumber
    {
      get => this.mPhoneLocalNumber;
      set => this.mPhoneLocalNumber = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PostalCode
    {
      get => this.mPostalCode;
      set => this.mPostalCode = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AddressID
    {
      get => this.mAddressID;
      set => this.mAddressID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressOwnerCodeType AddressOwner
    {
      get => this.mAddressOwner;
      set
      {
        this.mAddressOwner = value;
        this.mAddressOwnerSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddressOwnerSpecified
    {
      get => this.mAddressOwnerSpecified;
      set => this.mAddressOwnerSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressStatusCodeType AddressStatus
    {
      get => this.mAddressStatus;
      set
      {
        this.mAddressStatus = value;
        this.mAddressStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddressStatusSpecified
    {
      get => this.mAddressStatusSpecified;
      set => this.mAddressStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalAddressID
    {
      get => this.mExternalAddressID;
      set => this.mExternalAddressID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalName
    {
      get => this.mInternationalName;
      set => this.mInternationalName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalStateAndCity
    {
      get => this.mInternationalStateAndCity;
      set => this.mInternationalStateAndCity = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string InternationalStreet
    {
      get => this.mInternationalStreet;
      set => this.mInternationalStreet = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string CompanyName
    {
      get => this.mCompanyName;
      set => this.mCompanyName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressRecordTypeCodeType AddressRecordType
    {
      get => this.mAddressRecordType;
      set
      {
        this.mAddressRecordType = value;
        this.mAddressRecordTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddressRecordTypeSpecified
    {
      get => this.mAddressRecordTypeSpecified;
      set => this.mAddressRecordTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string FirstName
    {
      get => this.mFirstName;
      set => this.mFirstName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string LastName
    {
      get => this.mLastName;
      set => this.mLastName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Phone2
    {
      get => this.mPhone2;
      set => this.mPhone2 = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AddressUsageCodeType AddressUsage
    {
      get => this.mAddressUsage;
      set
      {
        this.mAddressUsage = value;
        this.mAddressUsageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AddressUsageSpecified
    {
      get => this.mAddressUsageSpecified;
      set => this.mAddressUsageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ReferenceID
    {
      get => this.mReferenceID;
      set => this.mReferenceID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("AddressAttribute")]
    public AddressAttributeTypeCollection AddressAttribute
    {
      get => this.mAddressAttribute;
      set => this.mAddressAttribute = value;
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
