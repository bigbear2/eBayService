// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.RecommendationValidationRulesType
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
  public class RecommendationValidationRulesType
  {
    private ValueTypeCodeType mValueType;
    private bool mValueTypeSpecified;
    private int mMinValues;
    private bool mMinValuesSpecified;
    private int mMaxValues;
    private bool mMaxValuesSpecified;
    private SelectionModeCodeType mSelectionMode;
    private bool mSelectionModeSpecified;
    private AspectUsageCodeType mAspectUsage;
    private bool mAspectUsageSpecified;
    private int mMaxValueLength;
    private bool mMaxValueLengthSpecified;
    private ProductRequiredCodeType mProductRequired;
    private bool mProductRequiredSpecified;
    private UsageConstraintCodeType mUsageConstraint;
    private bool mUsageConstraintSpecified;
    private int mConfidence;
    private bool mConfidenceSpecified;
    private NameValueRelationshipTypeCollection mRelationship;
    private VariationPictureRuleCodeType mVariationPicture;
    private bool mVariationPictureSpecified;
    private VariationSpecificsRuleCodeType mVariationSpecifics;
    private bool mVariationSpecificsSpecified;
    private ValueFormatCodeType mValueFormat;
    private bool mValueFormatSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public ValueTypeCodeType ValueType
    {
      get => this.mValueType;
      set
      {
        this.mValueType = value;
        this.mValueTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ValueTypeSpecified
    {
      get => this.mValueTypeSpecified;
      set => this.mValueTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MinValues
    {
      get => this.mMinValues;
      set
      {
        this.mMinValues = value;
        this.mMinValuesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MinValuesSpecified
    {
      get => this.mMinValuesSpecified;
      set => this.mMinValuesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxValues
    {
      get => this.mMaxValues;
      set
      {
        this.mMaxValues = value;
        this.mMaxValuesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxValuesSpecified
    {
      get => this.mMaxValuesSpecified;
      set => this.mMaxValuesSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SelectionModeCodeType SelectionMode
    {
      get => this.mSelectionMode;
      set
      {
        this.mSelectionMode = value;
        this.mSelectionModeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool SelectionModeSpecified
    {
      get => this.mSelectionModeSpecified;
      set => this.mSelectionModeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AspectUsageCodeType AspectUsage
    {
      get => this.mAspectUsage;
      set
      {
        this.mAspectUsage = value;
        this.mAspectUsageSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AspectUsageSpecified
    {
      get => this.mAspectUsageSpecified;
      set => this.mAspectUsageSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int MaxValueLength
    {
      get => this.mMaxValueLength;
      set
      {
        this.mMaxValueLength = value;
        this.mMaxValueLengthSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MaxValueLengthSpecified
    {
      get => this.mMaxValueLengthSpecified;
      set => this.mMaxValueLengthSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ProductRequiredCodeType ProductRequired
    {
      get => this.mProductRequired;
      set
      {
        this.mProductRequired = value;
        this.mProductRequiredSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ProductRequiredSpecified
    {
      get => this.mProductRequiredSpecified;
      set => this.mProductRequiredSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public UsageConstraintCodeType UsageConstraint
    {
      get => this.mUsageConstraint;
      set
      {
        this.mUsageConstraint = value;
        this.mUsageConstraintSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UsageConstraintSpecified
    {
      get => this.mUsageConstraintSpecified;
      set => this.mUsageConstraintSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public int Confidence
    {
      get => this.mConfidence;
      set
      {
        this.mConfidence = value;
        this.mConfidenceSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ConfidenceSpecified
    {
      get => this.mConfidenceSpecified;
      set => this.mConfidenceSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Relationship")]
    public NameValueRelationshipTypeCollection Relationship
    {
      get => this.mRelationship;
      set => this.mRelationship = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationPictureRuleCodeType VariationPicture
    {
      get => this.mVariationPicture;
      set
      {
        this.mVariationPicture = value;
        this.mVariationPictureSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VariationPictureSpecified
    {
      get => this.mVariationPictureSpecified;
      set => this.mVariationPictureSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public VariationSpecificsRuleCodeType VariationSpecifics
    {
      get => this.mVariationSpecifics;
      set
      {
        this.mVariationSpecifics = value;
        this.mVariationSpecificsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool VariationSpecificsSpecified
    {
      get => this.mVariationSpecificsSpecified;
      set => this.mVariationSpecificsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public ValueFormatCodeType ValueFormat
    {
      get => this.mValueFormat;
      set
      {
        this.mValueFormat = value;
        this.mValueFormatSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ValueFormatSpecified
    {
      get => this.mValueFormatSpecified;
      set => this.mValueFormatSpecified = value;
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
