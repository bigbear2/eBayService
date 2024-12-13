// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetUserRequestType
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
  public class GetUserRequestType : AbstractRequestType
  {
    private string mItemID;
    private string mUserID;
    private bool mIncludeExpressRequirements;
    private bool mIncludeExpressRequirementsSpecified;
    private bool mIncludeFeatureEligibility;
    private bool mIncludeFeatureEligibilitySpecified;

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
    public string UserID
    {
      get => this.mUserID;
      set => this.mUserID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool IncludeExpressRequirements
    {
      get => this.mIncludeExpressRequirements;
      set
      {
        this.mIncludeExpressRequirements = value;
        this.mIncludeExpressRequirementsSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeExpressRequirementsSpecified
    {
      get => this.mIncludeExpressRequirementsSpecified;
      set => this.mIncludeExpressRequirementsSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 3)]
    public bool IncludeFeatureEligibility
    {
      get => this.mIncludeFeatureEligibility;
      set
      {
        this.mIncludeFeatureEligibility = value;
        this.mIncludeFeatureEligibilitySpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeFeatureEligibilitySpecified
    {
      get => this.mIncludeFeatureEligibilitySpecified;
      set => this.mIncludeFeatureEligibilitySpecified = value;
    }
  }
}
