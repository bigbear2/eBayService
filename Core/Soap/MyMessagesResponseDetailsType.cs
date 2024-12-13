// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.MyMessagesResponseDetailsType
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
  public class MyMessagesResponseDetailsType
  {
    private bool mResponseEnabled;
    private bool mResponseEnabledSpecified;
    private string mResponseURL;
    private DateTime mUserResponseDate;
    private bool mUserResponseDateSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public bool ResponseEnabled
    {
      get => this.mResponseEnabled;
      set
      {
        this.mResponseEnabled = value;
        this.mResponseEnabledSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ResponseEnabledSpecified
    {
      get => this.mResponseEnabledSpecified;
      set => this.mResponseEnabledSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement(DataType = "anyURI")]
    public string ResponseURL
    {
      get => this.mResponseURL;
      set => this.mResponseURL = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime UserResponseDate
    {
      get => this.mUserResponseDate;
      set
      {
        this.mUserResponseDate = value;
        this.mUserResponseDateSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserResponseDateSpecified
    {
      get => this.mUserResponseDateSpecified;
      set => this.mUserResponseDateSpecified = value;
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
