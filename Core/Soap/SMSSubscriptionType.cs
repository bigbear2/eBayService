// Decompiled with JetBrains decompiler
// Type: eBay.Service.Core.Soap.SMSSubscriptionType
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
  public class SMSSubscriptionType
  {
    private string mSMSPhone;
    private SMSSubscriptionUserStatusCodeType mUserStatus;
    private bool mUserStatusSpecified;
    private WirelessCarrierIDCodeType mCarrierID;
    private bool mCarrierIDSpecified;
    private SMSSubscriptionErrorCodeCodeType mErrorCode;
    private bool mErrorCodeSpecified;
    private string mItemToUnsubscribe;
    private XmlElementCollection mAny;

    /// <summary>
    /// 
    /// </summary>
    public string SMSPhone
    {
      get => this.mSMSPhone;
      set => this.mSMSPhone = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SMSSubscriptionUserStatusCodeType UserStatus
    {
      get => this.mUserStatus;
      set
      {
        this.mUserStatus = value;
        this.mUserStatusSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool UserStatusSpecified
    {
      get => this.mUserStatusSpecified;
      set => this.mUserStatusSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public WirelessCarrierIDCodeType CarrierID
    {
      get => this.mCarrierID;
      set
      {
        this.mCarrierID = value;
        this.mCarrierIDSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool CarrierIDSpecified
    {
      get => this.mCarrierIDSpecified;
      set => this.mCarrierIDSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public SMSSubscriptionErrorCodeCodeType ErrorCode
    {
      get => this.mErrorCode;
      set
      {
        this.mErrorCode = value;
        this.mErrorCodeSpecified = true;
      }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool ErrorCodeSpecified
    {
      get => this.mErrorCodeSpecified;
      set => this.mErrorCodeSpecified = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public string ItemToUnsubscribe
    {
      get => this.mItemToUnsubscribe;
      set => this.mItemToUnsubscribe = value;
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
