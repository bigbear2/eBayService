// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ShippingServiceDetailsType
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
  public class ShippingServiceDetailsType
  {
    private string mDescription;
    private bool mExpeditedService;
    private bool mExpeditedServiceSpecified;
    private bool mInternationalService;
    private bool mInternationalServiceSpecified;
    private string mShippingService;
    private int mShippingServiceID;
    private bool mShippingServiceIDSpecified;
    private int mShippingTimeMax;
    private bool mShippingTimeMaxSpecified;
    private int mShippingTimeMin;
    private bool mShippingTimeMinSpecified;
    private ShippingServiceCodeType mShippingServiceCode;
    private bool mShippingServiceCodeSpecified;
    private ShippingTypeCodeTypeCollection mServiceType;
    private ShippingPackageCodeTypeCollection mShippingPackage;
    private bool mDimensionsRequired;
    private bool mDimensionsRequiredSpecified;
    private bool mValidForSellingFlow;
    private bool mValidForSellingFlowSpecified;
    private bool mSurchargeApplicable;
    private bool mSurchargeApplicableSpecified;
    private ShippingCarrierCodeTypeCollection mShippingCarrier;
    private bool mCODService;
    private bool mCODServiceSpecified;
    private AnnouncementMessageTypeCollection mDeprecationDetails;
    private int mMappedToShippingServiceID;
    private bool mMappedToShippingServiceIDSpecified;
    private string mCostGroupFlat;
    private ShippingServicePackageDetailsTypeCollection mShippingServicePackageDetails;
    private bool mWeightRequired;
    private bool mWeightRequiredSpecified;
    private string mDetailVersion;
    private DateTime mUpdateTime;
    private bool mUpdateTimeSpecified;
    private string mShippingCategory;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string Description
    {
      get => this.mDescription;
      set => this.mDescription = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ExpeditedService
    {
      get => this.mExpeditedService;
      set
      {
        this.mExpeditedService = value;
        this.mExpeditedServiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpeditedServiceSpecified
    {
      get => this.mExpeditedServiceSpecified;
      set => this.mExpeditedServiceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool InternationalService
    {
      get => this.mInternationalService;
      set
      {
        this.mInternationalService = value;
        this.mInternationalServiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool InternationalServiceSpecified
    {
      get => this.mInternationalServiceSpecified;
      set => this.mInternationalServiceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingService
    {
      get => this.mShippingService;
      set => this.mShippingService = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingServiceID
    {
      get => this.mShippingServiceID;
      set
      {
        this.mShippingServiceID = value;
        this.mShippingServiceIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingServiceIDSpecified
    {
      get => this.mShippingServiceIDSpecified;
      set => this.mShippingServiceIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingTimeMax
    {
      get => this.mShippingTimeMax;
      set
      {
        this.mShippingTimeMax = value;
        this.mShippingTimeMaxSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTimeMaxSpecified
    {
      get => this.mShippingTimeMaxSpecified;
      set => this.mShippingTimeMaxSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int ShippingTimeMin
    {
      get => this.mShippingTimeMin;
      set
      {
        this.mShippingTimeMin = value;
        this.mShippingTimeMinSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingTimeMinSpecified
    {
      get => this.mShippingTimeMinSpecified;
      set => this.mShippingTimeMinSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ShippingServiceCodeType ShippingServiceCode
    {
      get => this.mShippingServiceCode;
      set
      {
        this.mShippingServiceCode = value;
        this.mShippingServiceCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ShippingServiceCodeSpecified
    {
      get => this.mShippingServiceCodeSpecified;
      set => this.mShippingServiceCodeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ServiceType")]
    public ShippingTypeCodeTypeCollection ServiceType
    {
      get => this.mServiceType;
      set => this.mServiceType = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingPackage")]
    public ShippingPackageCodeTypeCollection ShippingPackage
    {
      get => this.mShippingPackage;
      set => this.mShippingPackage = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool DimensionsRequired
    {
      get => this.mDimensionsRequired;
      set
      {
        this.mDimensionsRequired = value;
        this.mDimensionsRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DimensionsRequiredSpecified
    {
      get => this.mDimensionsRequiredSpecified;
      set => this.mDimensionsRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ValidForSellingFlow
    {
      get => this.mValidForSellingFlow;
      set
      {
        this.mValidForSellingFlow = value;
        this.mValidForSellingFlowSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ValidForSellingFlowSpecified
    {
      get => this.mValidForSellingFlowSpecified;
      set => this.mValidForSellingFlowSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool SurchargeApplicable
    {
      get => this.mSurchargeApplicable;
      set
      {
        this.mSurchargeApplicable = value;
        this.mSurchargeApplicableSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SurchargeApplicableSpecified
    {
      get => this.mSurchargeApplicableSpecified;
      set => this.mSurchargeApplicableSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingCarrier")]
    public ShippingCarrierCodeTypeCollection ShippingCarrier
    {
      get => this.mShippingCarrier;
      set => this.mShippingCarrier = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool CODService
    {
      get => this.mCODService;
      set
      {
        this.mCODService = value;
        this.mCODServiceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CODServiceSpecified
    {
      get => this.mCODServiceSpecified;
      set => this.mCODServiceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("DeprecationDetails")]
    public AnnouncementMessageTypeCollection DeprecationDetails
    {
      get => this.mDeprecationDetails;
      set => this.mDeprecationDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MappedToShippingServiceID
    {
      get => this.mMappedToShippingServiceID;
      set
      {
        this.mMappedToShippingServiceID = value;
        this.mMappedToShippingServiceIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MappedToShippingServiceIDSpecified
    {
      get => this.mMappedToShippingServiceIDSpecified;
      set => this.mMappedToShippingServiceIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string CostGroupFlat
    {
      get => this.mCostGroupFlat;
      set => this.mCostGroupFlat = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("ShippingServicePackageDetails")]
    public ShippingServicePackageDetailsTypeCollection ShippingServicePackageDetails
    {
      get => this.mShippingServicePackageDetails;
      set => this.mShippingServicePackageDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool WeightRequired
    {
      get => this.mWeightRequired;
      set
      {
        this.mWeightRequired = value;
        this.mWeightRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WeightRequiredSpecified
    {
      get => this.mWeightRequiredSpecified;
      set => this.mWeightRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DetailVersion
    {
      get => this.mDetailVersion;
      set => this.mDetailVersion = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UpdateTime
    {
      get => this.mUpdateTime;
      set
      {
        this.mUpdateTime = value;
        this.mUpdateTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UpdateTimeSpecified
    {
      get => this.mUpdateTimeSpecified;
      set => this.mUpdateTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "token")]
    public string ShippingCategory
    {
      get => this.mShippingCategory;
      set => this.mShippingCategory = value;
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
