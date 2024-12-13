// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.TokenStatusType
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
  public class TokenStatusType
  {
    private TokenStatusCodeType mStatus;
    private bool mStatusSpecified;
    private string mEIASToken;
    private DateTime mExpirationTime;
    private bool mExpirationTimeSpecified;
    private DateTime mRevocationTime;
    private bool mRevocationTimeSpecified;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public TokenStatusCodeType Status
    {
      get => this.mStatus;
      set
      {
        this.mStatus = value;
        this.mStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StatusSpecified
    {
      get => this.mStatusSpecified;
      set => this.mStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string EIASToken
    {
      get => this.mEIASToken;
      set => this.mEIASToken = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime ExpirationTime
    {
      get => this.mExpirationTime;
      set
      {
        this.mExpirationTime = value;
        this.mExpirationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ExpirationTimeSpecified
    {
      get => this.mExpirationTimeSpecified;
      set => this.mExpirationTimeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public DateTime RevocationTime
    {
      get => this.mRevocationTime;
      set
      {
        this.mRevocationTime = value;
        this.mRevocationTimeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool RevocationTimeSpecified
    {
      get => this.mRevocationTimeSpecified;
      set => this.mRevocationTimeSpecified = value;
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
