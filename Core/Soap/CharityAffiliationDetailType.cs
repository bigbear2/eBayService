// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.CharityAffiliationDetailType
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
  public class CharityAffiliationDetailType
  {
    private string mCharityID;
    private CharityAffiliationTypeCodeType mAffiliationType;
    private bool mAffiliationTypeSpecified;
    private DateTime mLastUsedTime;
    private bool mLastUsedTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string CharityID
    {
      get => this.mCharityID;
      set => this.mCharityID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public CharityAffiliationTypeCodeType AffiliationType
    {
      get => this.mAffiliationType;
      set
      {
        this.mAffiliationType = value;
        this.mAffiliationTypeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool AffiliationTypeSpecified
    {
      get => this.mAffiliationTypeSpecified;
      set => this.mAffiliationTypeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime LastUsedTime
    {
      get => this.mLastUsedTime;
      set
      {
        this.mLastUsedTime = value;
        this.mLastUsedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastUsedTimeSpecified
    {
      get => this.mLastUsedTimeSpecified;
      set => this.mLastUsedTimeSpecified = value;
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
