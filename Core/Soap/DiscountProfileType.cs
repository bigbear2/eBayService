// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.DiscountProfileType
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
  public class DiscountProfileType
  {
    private string mDiscountProfileID;
    private string mDiscountProfileName;
    private AmountType mEachAdditionalAmount;
    private AmountType mEachAdditionalAmountOff;
    private float mEachAdditionalPercentOff;
    private bool mEachAdditionalPercentOffSpecified;
    private MeasureType mWeightOff;
    private string mMappedDiscountProfileID;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string DiscountProfileID
    {
      get => this.mDiscountProfileID;
      set => this.mDiscountProfileID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DiscountProfileName
    {
      get => this.mDiscountProfileName;
      set => this.mDiscountProfileName = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType EachAdditionalAmount
    {
      get => this.mEachAdditionalAmount;
      set => this.mEachAdditionalAmount = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public AmountType EachAdditionalAmountOff
    {
      get => this.mEachAdditionalAmountOff;
      set => this.mEachAdditionalAmountOff = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public float EachAdditionalPercentOff
    {
      get => this.mEachAdditionalPercentOff;
      set
      {
        this.mEachAdditionalPercentOff = value;
        this.mEachAdditionalPercentOffSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool EachAdditionalPercentOffSpecified
    {
      get => this.mEachAdditionalPercentOffSpecified;
      set => this.mEachAdditionalPercentOffSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public MeasureType WeightOff
    {
      get => this.mWeightOff;
      set => this.mWeightOff = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string MappedDiscountProfileID
    {
      get => this.mMappedDiscountProfileID;
      set => this.mMappedDiscountProfileID = value;
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
