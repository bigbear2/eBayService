// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ExtendedContactDetailsType
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
  public class ExtendedContactDetailsType
  {
    private ContactHoursDetailsType mContactHoursDetails;
    private bool mClassifiedAdContactByEmailEnabled;
    private bool mClassifiedAdContactByEmailEnabledSpecified;
    private string mPayPerLeadPhoneNumber;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public ContactHoursDetailsType ContactHoursDetails
    {
      get => this.mContactHoursDetails;
      set => this.mContactHoursDetails = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool ClassifiedAdContactByEmailEnabled
    {
      get => this.mClassifiedAdContactByEmailEnabled;
      set
      {
        this.mClassifiedAdContactByEmailEnabled = value;
        this.mClassifiedAdContactByEmailEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ClassifiedAdContactByEmailEnabledSpecified
    {
      get => this.mClassifiedAdContactByEmailEnabledSpecified;
      set => this.mClassifiedAdContactByEmailEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string PayPerLeadPhoneNumber
    {
      get => this.mPayPerLeadPhoneNumber;
      set => this.mPayPerLeadPhoneNumber = value;
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
