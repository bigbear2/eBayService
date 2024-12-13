// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.FetchTokenResponseType
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
  public class FetchTokenResponseType : AbstractResponseType
  {
    private string meBayAuthToken;
    private DateTime mHardExpirationTime;
    private bool mHardExpirationTimeSpecified;
    private string mRESTToken;

    /// <summary>
    /// 
    /// </summary>
    public string eBayAuthToken
    {
      get => this.meBayAuthToken;
      set => this.meBayAuthToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime HardExpirationTime
    {
      get => this.mHardExpirationTime;
      set
      {
        this.mHardExpirationTime = value;
        this.mHardExpirationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool HardExpirationTimeSpecified
    {
      get => this.mHardExpirationTimeSpecified;
      set => this.mHardExpirationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string RESTToken
    {
      get => this.mRESTToken;
      set => this.mRESTToken = value;
    }
  }
}
