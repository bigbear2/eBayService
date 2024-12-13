// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetMessagePreferencesRequestType
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
  public class GetMessagePreferencesRequestType : AbstractRequestType
  {
    private string mSellerID;
    private bool mIncludeASQPreferences;
    private bool mIncludeASQPreferencesSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string SellerID
    {
      get => this.mSellerID;
      set => this.mSellerID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public bool IncludeASQPreferences
    {
      get => this.mIncludeASQPreferences;
      set
      {
        this.mIncludeASQPreferences = value;
        this.mIncludeASQPreferencesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeASQPreferencesSpecified
    {
      get => this.mIncludeASQPreferencesSpecified;
      set => this.mIncludeASQPreferencesSpecified = value;
    }
  }
}
