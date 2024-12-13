// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.GetDescriptionTemplatesRequestType
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
  public class GetDescriptionTemplatesRequestType : AbstractRequestType
  {
    private string mCategoryID;
    private DateTime mLastModifiedTime;
    private bool mLastModifiedTimeSpecified;
    private bool mMotorVehicles;
    private bool mMotorVehiclesSpecified;

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 0)]
    public string CategoryID
    {
      get => this.mCategoryID;
      set => this.mCategoryID = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 1)]
    public DateTime LastModifiedTime
    {
      get => this.mLastModifiedTime;
      set
      {
        this.mLastModifiedTime = value;
        this.mLastModifiedTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool LastModifiedTimeSpecified
    {
      get => this.mLastModifiedTimeSpecified;
      set => this.mLastModifiedTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(Order = 2)]
    public bool MotorVehicles
    {
      get => this.mMotorVehicles;
      set
      {
        this.mMotorVehicles = value;
        this.mMotorVehiclesSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MotorVehiclesSpecified
    {
      get => this.mMotorVehiclesSpecified;
      set => this.mMotorVehiclesSpecified = value;
    }
  }
}
