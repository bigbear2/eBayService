// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.UserIdPasswordType
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
  public class UserIdPasswordType
  {
    private string mAppId;
    private string mDevId;
    private string mAuthCert;
    private string mUsername;
    private string mPassword;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string AppId
    {
      get => this.mAppId;
      set => this.mAppId = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string DevId
    {
      get => this.mDevId;
      set => this.mDevId = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string AuthCert
    {
      get => this.mAuthCert;
      set => this.mAuthCert = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Username
    {
      get => this.mUsername;
      set => this.mUsername = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string Password
    {
      get => this.mPassword;
      set => this.mPassword = value;
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
