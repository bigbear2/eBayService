// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.ReminderCustomizationType
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
  public class ReminderCustomizationType
  {
    private int mDurationInDays;
    private bool mDurationInDaysSpecified;
    private bool mInclude;
    private bool mIncludeSpecified;

    /// <summary>
    /// 
    /// </summary>
    public int DurationInDays
    {
      get => this.mDurationInDays;
      set
      {
        this.mDurationInDays = value;
        this.mDurationInDaysSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DurationInDaysSpecified
    {
      get => this.mDurationInDaysSpecified;
      set => this.mDurationInDaysSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public bool Include
    {
      get => this.mInclude;
      set
      {
        this.mInclude = value;
        this.mIncludeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncludeSpecified
    {
      get => this.mIncludeSpecified;
      set => this.mIncludeSpecified = value;
    }
  }
}
